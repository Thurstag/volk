// Copyright 2020-2020 Volk Project
// Licensed under Apache License 2.0 or any later version
// Refer to the LICENSE.md file included.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Volk.Generator.Writers;
using static Volk.Generator.Utilities.GeneratorUtilities;
using static Volk.Generator.Utilities.VulkanUtilities;

namespace Volk.Generator {
    /// <summary>
    /// Entry point
    /// </summary>
    internal static class Program {
        private const string VulkanSpecUrl = "https://raw.githubusercontent.com/KhronosGroup/Vulkan-Docs/master/xml/vk.xml";

        private static void Main(string[] args) {
            // Download vulkan spec
            XDocument doc = XDocument.Load(args.Length > 0 ? args[0] : VulkanSpecUrl);
            Console.WriteLine("Vulkan specification loaded");

            // Check root
            if (doc.Root is null) {
                throw new Exception("XML root is null");
            }

            // Extract commands
            var commands = new Dictionary<string, XElement>();
            // Dictionary<string, string> commandAliases = new Dictionary<string, string>();
            foreach (var cmdGroup in doc.Root.Elements("commands")) {
                foreach (var cmd in cmdGroup.Elements("command")) {
                    if (cmd is null) {
                        continue;
                    }

                    var alias = cmd.Attribute("alias");
                    var name = cmd.Attribute("name");

                    if (alias != null && name != null) { // Alias
                        // commandAliases.Add(name.Value, alias.Value);
                    } else {
                        var cmdName = cmd.Element("proto")?.Element("name")?.Value;
                        if (cmdName is null) {
                            throw new Exception("Malformed command");
                        }

                        commands[cmdName] = cmd;
                    }
                }
            }

            Console.WriteLine("Commands and command aliases extracted");


            // Extract types
            var types = new Dictionary<string, XElement>();
            var typeAliases = new Dictionary<string, LinkedList<string>>();
            foreach (var typeGroup in doc.Root.Elements("types")) {
                foreach (var type in typeGroup.Elements("type")) {
                    var alias = type.Attribute("alias");
                    var name = type.Attribute("name");

                    if (alias != null && name != null) { // Alias
                        if (!typeAliases.ContainsKey(alias.Value)) {
                            typeAliases[alias.Value] = new LinkedList<string>();
                        }

                        typeAliases[alias.Value].AddLast(name.Value);
                    } else if (name != null) {
                        types[name.Value] = type;
                    } else if (type.Elements().Any()) {
                        var typeName = type.Element("name")?.Value;
                        if (typeName is null) {
                            throw new Exception("Malformed type");
                        }

                        types[typeName] = type;
                    }
                }
            }

            Console.WriteLine("Types extracted");

            // Extract base types, enumerations
            var (
                baseTypes,
                handles,
                enumerations,
                bitmasks,
                structures,
                unions,
                usings
                ) = ExtractObjects(types, typeAliases);

            // Extract enumerations values
            var constants = ExtractEnumerationsValues(doc.Root, enumerations, bitmasks);

            // Write commands in a file
            CommandsWriter.Write(commands, baseTypes, usings, handles);

            // Write enumerations in a file
            EnumerationsWriter.Write(enumerations, bitmasks, baseTypes);

            // Write structures in a file
            StructuresWriter.Write(structures, types, baseTypes, usings, handles, constants);

            // Write unions in a file
            UnionsWriter.Write(unions, baseTypes);

            // Write constants
            ConstantsWriter.Write(constants);

            // Write commands table
            WriteCommandTable(commands);

            // Write functions loaders
            FunctionsWriter.Write(commands, types);
        }

        /// <summary>
        /// Write CommandTable file
        /// </summary>
        /// <param name="commands">Vulkan commands</param>
        private static void WriteCommandTable(Dictionary<string, XElement> commands) {
            string DeclareMember(string command) => $@"        public static Commands.{command}? {command};";

            using var commandsFile = new StreamWriter("CommandTable.cs", false);
            commandsFile.WriteLine(
                $@"{Copyright()}
namespace Volk.Vulkan {{

	/// <summary>
	/// Global table of commands
	/// </summary>
    public static class CommandTable {{
{string.Join("\n\n", commands.Keys.Select(TrimVkPrefix).Select(DeclareMember))}
    }}
}}"
            );

            Console.WriteLine("Command table was written");
        }

        /// <summary>
        /// Extract enumeration values into <paramref name="enumerations"/> and <paramref name="bitmasks"/>
        /// </summary>
        /// <param name="root">XML root</param>
        /// <param name="enumerations">Enumerations</param>
        /// <param name="bitmasks">Bitmasks</param>
        /// <returns>Constants</returns>
        private static LinkedList<XElement> ExtractEnumerationsValues(XContainer root,
                                                                      IReadOnlyDictionary<string, LinkedList<XElement>> enumerations,
                                                                      IReadOnlyDictionary<string, ((string, XElement), LinkedList<XElement>)>
                                                                          bitmasks) {
            var constants = new LinkedList<XElement>();

            foreach (var enumerationValue in root.Elements("enums")) {
                var name = enumerationValue.Attribute("name")?.Value;
                if (name is null) {
                    continue;
                }

                if (enumerations.ContainsKey(name)) {
                    enumerations[name].AddLastRange(enumerationValue.Elements("enum"));
                }

                if (bitmasks.ContainsKey(name)) {
                    bitmasks[name].Item2.AddLastRange(enumerationValue.Elements("enum"));
                }

                if (Equals(name, "API Constants")) {
                    constants.AddLastRange(enumerationValue.Elements("enum"));
                }
            }

            foreach (var enumerationValue in root.Elements("feature")
                .SelectMany(feature => feature.Elements("require"))
                .SelectMany(require => require.Elements("enum"))) {
                var extends = enumerationValue.Attribute("extends")?.Value;
                if (extends is null) {
                    continue;
                }

                if (enumerations.ContainsKey(extends)) {
                    enumerations[extends].AddLast(enumerationValue);
                }

                if (bitmasks.ContainsKey(extends)) {
                    bitmasks[extends].Item2.AddLast(enumerationValue);
                }
            }

            foreach (var enumerationValue in root.Elements("extensions")
                .SelectMany(extensions => extensions.Elements("extension"))
                .SelectMany(extension => extension.Elements("require"))
                .SelectMany(require => require.Elements("enum"))) {
                var extends = enumerationValue.Attribute("extends")?.Value;
                if (extends is null) {
                    continue;
                }

                if (enumerations.ContainsKey(extends)) {
                    enumerations[extends].AddLast(enumerationValue);
                }

                if (bitmasks.ContainsKey(extends)) {
                    bitmasks[extends].Item2.AddLast(enumerationValue);
                }
            }

            return constants;
        }

        /// <summary>
        /// Extract vulkan objects
        /// </summary>
        /// <param name="types">Types</param>
        /// <param name="typeAliases">Type alias</param>
        /// <returns>Base types, Handles, Enumerations, Bitmasks, Structures, Unions and Usings</returns>
        private static (LinkedList<string>, LinkedList<string>, Dictionary<string, LinkedList<XElement>>,
            Dictionary<string, ((string, XElement), LinkedList<XElement>)>, Dictionary<string, XElement>, Dictionary<string, XElement>,
            LinkedList<string>)
            ExtractObjects(Dictionary<string, XElement> types, IReadOnlyDictionary<string, LinkedList<string>> typeAliases) {
            var bitmasks = new Dictionary<string, ((string, XElement), LinkedList<XElement>)>();
            var enumerations = new Dictionary<string, LinkedList<XElement>>();
            var structures = new Dictionary<string, XElement>();
            var unions = new Dictionary<string, XElement>();
            var usings = new LinkedList<string>();
            var baseTypes = new LinkedList<string>();
            var handles = new LinkedList<string>();

            foreach (var (typeName, type) in types
                .Where(type => type.Value.Attribute("category") != null)) {
                switch (type.Attribute("category")?.Value) {
                    case "basetype":
                        var typeElement = type.Element("type");
                        if (typeElement != null) {
                            baseTypes.AddLast(@$"using {ToCSharpType(typeName)} = {typeElement.Value switch {
                                "uint32_t" => "System.UInt32",
                                "uint64_t" => "System.UInt64",
                                _          => type
                            }};");
                        }

                        break;

                    case "handle":
                        var nameElement = type.Element("name");
                        if (nameElement != null) {
                            string name = nameElement.Value;
                            string volkName = ToCSharpType(name);

                            handles.AddLast($"using {volkName} = System.IntPtr;");
                            if (typeAliases.ContainsKey(name)) {
                                foreach (var alias in typeAliases[name]) {
                                    handles.AddLast($"using {ToCSharpType(alias)} = System.IntPtr;");
                                }
                            }
                        }

                        break;

                    case "enum":
                        if (typeAliases.ContainsKey(typeName)) {
                            foreach (var alias in typeAliases[typeName]) {
                                usings.AddLast($"using {ToCSharpType(alias)} = Volk.Vulkan.Types.{ToCSharpType(typeName)};");
                            }
                        }

                        enumerations.Add(typeName, new LinkedList<XElement>());
                        break;

                    case "struct":
                        structures.Add(typeName, type);

                        if (typeAliases.ContainsKey(typeName)) {
                            foreach (var alias in typeAliases[typeName]) {
                                usings.AddLast($"using {ToCSharpType(alias)} = Volk.Vulkan.Types.{ToCSharpType(typeName)};");
                            }
                        }

                        break;

                    case "bitmask":
                        if (type.Element("type") is null) {
                            throw new Exception("Based type is undefined");
                        }

                        var requires = type.Attribute("requires");
                        bitmasks.Add(requires is null ? typeName : requires.Value, ((typeName, type), new LinkedList<XElement>()));

                        break;

                    case "union":
                        unions.Add(typeName, type);
                        break;
                }
            }

            return (baseTypes, handles, enumerations, bitmasks, structures, unions, usings);
        }
    }
}