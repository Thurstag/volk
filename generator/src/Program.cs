// Copyright 2020-2020 Volk Project
// Licensed under Apache License 2.0 or any later version
// Refer to the LICENSE.md file included.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Volk.Generator {
    // TODO: Fix AccelerationStructureInstanceKHR

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
                usingAliases
                ) = ExtractTypeGroups(types, typeAliases);

            // Extract enumerations values
            var constants = ExtractEnumerationsValues(doc.Root, enumerations, bitmasks);

            // Write commands in a file
            WriteCommands(commands, baseTypes, usingAliases, handles);

            // Write enumerations in a file
            WriteEnumerations(enumerations, bitmasks, baseTypes);

            // Write structures in a file
            WriteStructures(structures, types, baseTypes, usingAliases, handles, constants);

            // Write unions in a file
            WriteUnions(unions, baseTypes);

            // Write constants
            WriteConstants(constants);

            // Write commands table
            WriteCommandTable(commands);

            // Write functions loaders
            WriteInstanceAndDevicesFunctionsLoader(commands, types);
        }

        /// <summary>
        /// Write InstanceFunctions, DeviceFunctions, DeviceCommandTable files
        /// </summary>
        /// <param name="commands">Vulkan commands</param>
        /// <param name="types">Vulkan types</param>
        private static void
            WriteInstanceAndDevicesFunctionsLoader(Dictionary<string, XElement> commands, IReadOnlyDictionary<string, XElement> types) {
            LinkedList<string> instanceCommands = new LinkedList<string>(), deviceCommands = new LinkedList<string>();

            foreach (var (name, command) in commands) {
                var firstParamType = command.Element("param")?.Element("type")?.Value;
                if (firstParamType != null && IsDescendantType(types, "VkDevice", firstParamType) && name != "vkGetDeviceProcAddr") {
                    deviceCommands.AddLast(name);
                } else if (firstParamType != null && IsDescendantType(types, "VkInstance", firstParamType) &&
                           name != "vkGetInstanceProcAddr") {
                    instanceCommands.AddLast(name);
                }
            }

            string CommandLoader(string command, string loader, string param) => $@"
                fixed (byte* funcName = &Encoding.UTF8.GetBytes(""{command}"")[0]) {{
                    CommandTable.{TrimVkPrefix(command)} = FunctionPtrToDelegate<Commands.{TrimVkPrefix(command)}>(CommandTable.{loader}({param}, funcName));
                }}";

            using var instanceFile = new StreamWriter("InstanceFunctions.cs", false);
            instanceFile.WriteLine(
                $@"{Copyright()}
using System;
using System.Text;
using Volk.Vulkan;

namespace Volk {{
    public static partial class Functions {{

        /// <summary>
        /// Load instance commands into <see cref=""CommandTable""/>
        /// </summary>
        /// <param name=""instance"">Vulkan instance</param>
        /// <exception cref=""Exception"">GetInstanceProcAddr isn't loaded</exception>
        public static void LoadInstance(IntPtr instance) {{
            if (CommandTable.GetInstanceProcAddr is null) {{
                throw new Exception(""GetInstanceProcAddr isn't loaded"");
            }}

            unsafe {{
                {string.Join("\n", instanceCommands.Select(cmd => CommandLoader(cmd, "GetInstanceProcAddr", "instance")))}
            }}
        }}
    }}
}}"
            );

            string DeviceCommandLoader(string command) => $@"
                fixed (byte* funcName = &Encoding.UTF8.GetBytes(""{command}"")[0]) {{
                    deviceTable.{TrimVkPrefix(command)} = FunctionPtrToDelegate<Commands.{TrimVkPrefix(command)}>(CommandTable.GetDeviceProcAddr(device, funcName));
                }}";

            using var deviceFile = new StreamWriter("DeviceFunctions.cs", false);
            deviceFile.WriteLine(
                $@"{Copyright()}
using System;
using System.Text;
using Volk.Vulkan;

namespace Volk {{
    public static partial class Functions {{

        /// <summary>
        /// Load device commands into <see cref=""CommandTable""/>
        /// </summary>
        /// <param name=""device"">Vulkan logical device</param>
        /// <exception cref=""Exception"">GetDeviceProcAddr isn't loaded</exception>
        public static void LoadDevice(IntPtr device) {{
            if (CommandTable.GetDeviceProcAddr is null) {{
                throw new Exception(""GetDeviceProcAddr isn't loaded"");
            }}

            unsafe {{
                {string.Join("\n", deviceCommands.Select(cmd => CommandLoader(cmd, "GetDeviceProcAddr", "device")))}
            }}
        }}

        /// <summary>
        /// Load device commands into a local table
        /// </summary>
        /// <param name=""device"">Vulkan logical device</param>
        /// <returns>Device commands table</returns>
        /// <exception cref=""Exception"">GetDeviceProcAddr isn't loaded</exception>
        public static DeviceCommandTable LoadDeviceTable(IntPtr device) {{
            if (CommandTable.GetDeviceProcAddr is null) {{
                throw new Exception(""GetDeviceProcAddr isn't loaded"");
            }}

            var deviceTable = new DeviceCommandTable();

            unsafe {{
                {string.Join("\n", deviceCommands.Select(DeviceCommandLoader))}
            }}

            return deviceTable;
        }}
    }}
}}"
            );

            string DeclareCommandTableMember(string command) => $@"        public Commands.{command}? {command};";

            using var deviceTableFile = new StreamWriter("DeviceCommandTable.cs", false);
            deviceTableFile.WriteLine(
                $@"{Copyright()}
namespace Volk.Vulkan {{
    /// <summary>
	/// Table of device commands
	/// </summary>
    public class DeviceCommandTable {{
{string.Join("\n\n", deviceCommands.Select(TrimVkPrefix).Select(DeclareCommandTableMember))}
    }}
}}"
            );

            Console.WriteLine("Instance/Device commands loader was generated");
        }

        /// <summary>
        /// Check if a given type is a descendant of another type
        /// </summary>
        /// <param name="types">Vulkan types</param>
        /// <param name="baseType">Base type</param>
        /// <param name="type">type</param>
        /// <returns>true if <paramref name="type"/> is a descendant of <paramref name="baseType"/>, false otherwise</returns>
        private static bool IsDescendantType(IReadOnlyDictionary<string, XElement> types, string baseType, string type) {
            if (baseType == type) {
                return true;
            }

            if (!types.ContainsKey(type)) {
                return false;
            }

            var parents = types[type].Attribute("parent");
            return parents != null && parents.Value.Split(',').Any(parent => IsDescendantType(types, baseType, parent));
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
        /// Write Constants file
        /// </summary>
        /// <param name="constants">Vulkan constants</param>
        private static void WriteConstants(IEnumerable<XElement> constants) {
            var types = new Dictionary<string, string>();

            string DeclareConstant(XElement constant) {
                string type, value;

                var alias = constant.Attribute("alias");
                var name = constant.Attribute("name");

                if (name is null) {
                    throw new Exception("name is null");
                }

                if (alias != null) {
                    type = types[alias.Value];
                    value = TrimVkPrefix(ToTitleCase(alias.Value));
                } else {
                    type = DeclNumType(constant.Attribute("value")?.Value ?? throw new Exception("value is null"));

                    value = type switch {
                        "ushort" => $"unchecked((ushort) {constant.Attribute("value")?.Value})",
                        "ulong"  => constant.Attribute("value")?.Value?.Replace("ULL", "UL"),
                        _        => constant.Attribute("value")?.Value
                    } ?? throw new Exception("Failed to deduce value");

                    types.Add(name.Value, type);
                }

                return
                    $"        public const {type} {TrimVkPrefix(ToTitleCase(name.Value))} = {value};";
            }

            using var constantFile = new StreamWriter("Constants.cs", false);
            constantFile.WriteLine(
                $@"{Copyright()}
namespace Volk.Vulkan {{
    public class Constants {{
{string.Join("\n", constants.Select(DeclareConstant))}
    }}
}}"
            );

            Console.WriteLine("All constants were generated");
        }

        /// <summary>
        /// Deduce type of a number
        /// </summary>
        /// <param name="value">Number</param>
        /// <returns>Type</returns>
        private static string DeclNumType(string value) {
            if (value.Last() == 'f') {
                return "float";
            }

            if (value.Contains("ULL")) {
                return "ulong";
            }

            return value.Contains("U") ? "ushort" : "int";
        }

        /// <summary>
        /// Write Unions file
        /// </summary>
        /// <param name="unions">Vulkan unions</param>
        /// <param name="baseTypes">Base types</param>
        private static void WriteUnions(Dictionary<string, XElement> unions, LinkedList<string> baseTypes) {
            string DeclareUnionMember(string type, string name) {
                var @fixed = Regex.IsMatch(name, @"\[.*\]$");

                return $@"        [FieldOffset(0)] public {(IsUnsafe(type, @fixed) ? "unsafe " : "")}{(@fixed ? "fixed " : "")}{type} {name};";
            }

            string DeclareUnion(string name, XContainer content) {
                return $@"
    [StructLayout(LayoutKind.Explicit)]
    public struct {TrimVkPrefix(name)} {{
{string.Join("\n", content.Elements("member").Select(member => DeducePrototype(member.Nodes())).Select(proto => DeclareUnionMember(proto.Item1, proto.Item2)))}
    }}";
            }

            using var unionFile = new StreamWriter("Unions.cs", false);
            unionFile.WriteLine(
                $@"{Copyright()}
using System.Runtime.InteropServices;

{string.Join("\n", baseTypes)}

namespace Volk.Vulkan.Types {{
{string.Join("\n", unions.Select(union => DeclareUnion(union.Key, union.Value)))}
}}"
            );

            Console.WriteLine("All unions were generated");
        }

        /// <summary>
        /// Check if a given type is unsafe
        /// </summary>
        /// <param name="type">Type</param>
        /// <param name="fixed">Type is fixed</param>
        /// <returns>true if type is unsafe, false otherwise</returns>
        private static bool IsUnsafe(string type, bool @fixed) => @fixed || type.Contains('*');

        /// <summary>
        /// Write Structures file
        /// </summary>
        /// <param name="structures">Structures</param>
        /// <param name="types">Types</param>
        /// <param name="baseTypes">Base types</param>
        /// <param name="usingAliases"></param>
        /// <param name="handles">Handles</param>
        /// <param name="constants">Constants</param>
        private static void WriteStructures(Dictionary<string, XElement> structures, IReadOnlyDictionary<string, XElement> types,
                                            IEnumerable<string> baseTypes,
                                            IEnumerable<string> usingAliases,
                                            IEnumerable<string> handles, LinkedList<XElement> constants) {
            var structureArray = new string[structures.Count];

            var index = 0;
            foreach (var (structName, structure) in structures) {
                var members = new LinkedList<string>();

                foreach (var member in structure.Elements("member")) {
                    var (type, name) = DeducePrototype(member.Nodes());

                    var arrayMatcher = Regex.Match(name, @"\[.*\]$");
                    if (arrayMatcher.Success) {
                        if (name.EndsWith("[]")) {
                            type = $"{type}[]";
                            name = name.Substring(0, name.Length - 2);
                        } else if (Regex.IsMatch(name, @"\[.*\]\[.*\]$")) {
                            type = $"{type}[][]";
                            name = name.Substring(0, arrayMatcher.Index);
                        } else {
                            var sizeStr = name.Substring(arrayMatcher.Index + 1, name.Length - 2 - arrayMatcher.Index);
                            if (int.TryParse(sizeStr, out var size)) {
                                if (types.ContainsKey($"Vk{type}")) {
                                    for (var i = 0; i < size; i++) {
                                        members.AddLast($"\t\tpublic {type} {name.Substring(0, arrayMatcher.Index)}_{i};");
                                    }

                                    continue;
                                }

                                type = $"fixed {type}";
                            } else {
                                if (types.ContainsKey($"Vk{type}")) {
                                    var realSize = int.Parse(constants.First(constant => constant.Attribute("name")?.Value == sizeStr)
                                                                 .Attribute("value")?.Value ??
                                                             throw new Exception($"Unable to find real size of {type}"));
                                    for (var i = 0; i < realSize; i++) {
                                        members.AddLast($"\t\tpublic {type} {name.Substring(0, arrayMatcher.Index)}_{i};");
                                    }

                                    continue;
                                }

                                type = $"fixed {type}";
                                name = $"{name.Substring(0, arrayMatcher.Index)}[Constants.{TrimVkPrefix(ToTitleCase(sizeStr))}]";
                            }
                        }
                    }

                    members.AddLast($"\t\tpublic unsafe {type} {name};");
                }

                structureArray[index++] = $"\tpublic struct {ToCSharpType(structName)} {{\n" +
                                          $"{string.Join("\n", members)}\n" +
                                          "\t}";
            }

            using var structureFile = new StreamWriter("Structures.cs", false);
            structureFile.WriteLine(
                $@"{Copyright()}
using DotNetCross.NativeInts;
using IntPtr = System.IntPtr;

{string.Join("\n", baseTypes)}

{string.Join("\n", handles)}

{string.Join("\n", usingAliases)}

namespace Volk.Vulkan.Types {{
{string.Join("\n\n", structureArray)}
}}"
            );

            Console.WriteLine("All structures were generated");
        }

        // TODO: Doc
        private static void WriteEnumerations(Dictionary<string, LinkedList<XElement>> enumerations,
                                              IReadOnlyDictionary<string, ((string, XElement), LinkedList<XElement>)> bitmasks,
                                              LinkedList<string> baseTypes) {
            var enumerationArray = new string[enumerations.Count];
            var bitmaskArray = new string[bitmasks.Count];

            var index = 0;
            foreach (var (name, enumeration) in enumerations.Where(pair => !bitmasks.ContainsKey(pair.Key))) {
                enumerationArray[index++] = $"\tpublic enum {TrimVkPrefix(name)} {{\n" +
                                            $"{string.Join(",\n", enumeration.Select(DeduceEnumerationPrototype).Select(proto => $"\t\t{proto.Item1} = {proto.Item2}").Distinct())}\n" +
                                            "\t}";
            }

            index = 0;
            foreach (var (_, ((name, enumeration), values)) in bitmasks) {
                bitmaskArray[index++] =
                    "\t[FlagsAttribute]\n" +
                    $"\tpublic enum {TrimVkPrefix(name)} : {ToCSharpType(enumeration.Element("type").Value)} {{\n" +
                    $"{string.Join(",\n", values.Select(DeduceEnumerationPrototype).Select(proto => $"\t\t{proto.Item1} = {proto.Item2}").Distinct())}\n" +
                    "\t}";
            }

            using var bitmaskFile = new StreamWriter("Bitmasks.cs", false);
            bitmaskFile.WriteLine(Copyright());
            bitmaskFile.WriteLine("using FlagsAttribute = System.FlagsAttribute;\n" +
                                  $"{string.Join("\n", baseTypes)}\n\n" +
                                  "namespace Volk.Vulkan.Types {\n" +
                                  string.Join("\n\n", bitmaskArray) +
                                  "\n}");

            using var enumerationFile = new StreamWriter("Enumerations.cs", false);
            enumerationFile.WriteLine(Copyright());
            enumerationFile.WriteLine($"{string.Join("\n", baseTypes)}\n\n" +
                                      "namespace Volk.Vulkan.Types {\n" +
                                      string.Join("\n\n", enumerationArray) +
                                      "\n}");

            Console.WriteLine("All enumerations were generated");
        }

        // TODO: Doc
        private static LinkedList<XElement> ExtractEnumerationsValues(XContainer docRoot,
                                                                      IReadOnlyDictionary<string, LinkedList<XElement>> enumerations,
                                                                      Dictionary<string, ((string, XElement), LinkedList<XElement>)> bitmasks) {
            var constants = new LinkedList<XElement>();

            foreach (var enumerationValue in docRoot.Elements("enums")
                .Where(value => value.Attribute("name") != null)) {
                if (enumerations.ContainsKey(enumerationValue.Attribute("name").Value)) {
                    enumerations[enumerationValue.Attribute("name").Value].AddLastRange(enumerationValue.Elements("enum"));
                }

                if (bitmasks.ContainsKey(enumerationValue.Attribute("name").Value)) {
                    bitmasks[enumerationValue.Attribute("name").Value].Item2.AddLastRange(enumerationValue.Elements("enum"));
                }

                if (enumerationValue.Attribute("name").Value == "API Constants") {
                    constants.AddLastRange(enumerationValue.Elements("enum"));
                }
            }

            foreach (var enumerationValue in docRoot.Elements("feature")
                .SelectMany(feature => feature.Elements("require"))
                .SelectMany(require => require.Elements("enum"))
                .Where(value => value.Attribute("extends") != null)) {
                if (enumerations.ContainsKey(enumerationValue.Attribute("extends").Value)) {
                    enumerations[enumerationValue.Attribute("extends").Value].AddLast(enumerationValue);
                }

                if (bitmasks.ContainsKey(enumerationValue.Attribute("extends").Value)) {
                    bitmasks[enumerationValue.Attribute("extends").Value].Item2.AddLast(enumerationValue);
                }
            }

            foreach (var enumerationValue in docRoot.Elements("extensions")
                .SelectMany(extensions => extensions.Elements("extension"))
                .SelectMany(extension => extension.Elements("require"))
                .SelectMany(require => require.Elements("enum"))
                .Where(value => value.Attribute("extends") != null)) {
                if (enumerations.ContainsKey(enumerationValue.Attribute("extends").Value)) {
                    enumerations[enumerationValue.Attribute("extends").Value].AddLast(enumerationValue);
                }

                if (bitmasks.ContainsKey(enumerationValue.Attribute("extends").Value)) {
                    bitmasks[enumerationValue.Attribute("extends").Value].Item2.AddLast(enumerationValue);
                }
            }

            return constants;
        }

        // TODO: Doc
        private static (LinkedList<string>, LinkedList<string>, Dictionary<string, LinkedList<XElement>>,
            Dictionary<string, ((string, XElement), LinkedList<XElement>)>, Dictionary<string, XElement>, Dictionary<string, XElement>,
            LinkedList<string>)
            ExtractTypeGroups(Dictionary<string, XElement> types, IReadOnlyDictionary<string, LinkedList<string>> typeAliases) {
            var bitmasks = new Dictionary<string, ((string, XElement), LinkedList<XElement>)>();
            var enumerations = new Dictionary<string, LinkedList<XElement>>();
            var structures = new Dictionary<string, XElement>();
            var unions = new Dictionary<string, XElement>();
            var usingAliases = new LinkedList<string>();
            var baseTypes = new LinkedList<string>();
            var handles = new LinkedList<string>();

            foreach (var (typeName, type) in types
                .Where(type => type.Value.Attribute("category") != null)) {
                switch (type.Attribute("category")?.Value) {
                    case "basetype":
                        var typeElement = type.Element("type");
                        if (typeElement != null) {
                            baseTypes.AddLast($"using {ToCSharpType(typeName)} = {ToVolkAliasType(typeElement.Value)};");
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
                                usingAliases.AddLast($"using {ToCSharpType(alias)} = Volk.Vulkan.Types.{ToCSharpType(typeName)};");
                            }
                        }

                        enumerations.Add(typeName, new LinkedList<XElement>());
                        break;

                    case "struct":
                        structures.Add(typeName, type);

                        if (typeAliases.ContainsKey(typeName)) {
                            foreach (var alias in typeAliases[typeName]) {
                                usingAliases.AddLast($"using {ToCSharpType(alias)} = Volk.Vulkan.Types.{ToCSharpType(typeName)};");
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

            return (baseTypes, handles, enumerations, bitmasks, structures, unions, usingAliases);
        }

        // TODO: Doc
        private static void WriteCommands(Dictionary<string, XElement> commands, IEnumerable<string> baseTypes, IEnumerable<string> usingAliases,
                                          IEnumerable<string> handles) {
            var commandsArray = new string[commands.Count];

            var index = 0;
            foreach (var (cmdName, command) in commands) {
                var returnType = command.Element("proto")?.Element("type");
                if (returnType is null) {
                    throw new Exception("No return type for command: " + cmdName);
                }

                var parameters = new LinkedList<(string, string)>();
                foreach (var parameter in command.Elements("param")) {
                    var (type, name) = DeducePrototype(parameter.Nodes());

                    if (Regex.IsMatch(name, @"\[.*\]$")) {
                        type = $"{type}[]";
                        name = Regex.Replace(name, @"\[.*\]$", "");
                    }

                    parameters.AddLast((type, name));
                }

                commandsArray[index++] =
                    $"{ToCSharpType(returnType.Value)} {TrimVkPrefix(cmdName)}({string.Join(", ", parameters.Select(proto => $"{proto.Item1} {proto.Item2}"))})";
            }

            using var commandsFile = new StreamWriter("Commands.cs", false);
            commandsFile.WriteLine(Copyright());
            commandsFile.WriteLine("using IntPtr = System.IntPtr;\n" +
                                   "using Volk.Vulkan.Types;\n" +
                                   "using DotNetCross.NativeInts;\n" +
                                   $"{string.Join("\n", baseTypes)}\n\n" +
                                   $"{string.Join("\n", handles)}\n\n" +
                                   $"{string.Join("\n", usingAliases)}\n\n" +
                                   "namespace Volk.Vulkan {\n" +
                                   "\tpublic static class Commands {\n" +
                                   string.Join("\n\n", commandsArray.Select(cmd => $"\t\tpublic unsafe delegate {cmd};")) +
                                   "\n\t}\n" +
                                   "}");
            Console.WriteLine("All commands were generated");
        }

        /// <summary>
        /// Convert a C type into a C# type
        /// </summary>
        /// <param name="type">C type</param>
        /// <returns>C# type</returns>
        private static string ToCSharpType(string type) {
            if (type.EndsWith("*")) {
                return ToCSharpType(type.Substring(0, type.Length - 1)) + "*";
            }

            if (type.StartsWith("Vk")) {
                return type.Contains("FlagBits") ? type.Replace("FlagBits", "Flags").Substring(2) : type.Substring(2);
            }

            if (type == "uint16_t") {
                return "ushort";
            }

            if (type == "uint32_t" || type == "xcb_window_t" || type == "zx_handle_t" || type == "DWORD") {
                return "uint";
            }

            if (type == "uint64_t" || type == "RROutput" || type == "Window") {
                return "ulong";
            }

            if (type == "int64_t") {
                return "long";
            }

            if (type.StartsWith("PFN_")) {
                return "IntPtr";
            }

            if (type == "int") {
                return "short";
            }

            if (type == "char") {
                return "byte";
            }

            if (type == "int32_t" || type == "GgpStreamDescriptor" || type == "GgpFrameToken") {
                return "int";
            }

            if (type == "size_t") {
                return "nuint";
            }

            if (Regex.IsMatch(type, @"^.*\[.*\]$")) {
                return Regex.Replace(type, @"\[.*\]$", "[]");
            }

            if (type == "HANDLE" || type == "HINSTANCE" || type == "HWND" || type == "Display" || type == "xcb_connection_t" ||
                type == "xcb_visualid_t" || type == "VisualID" || type == "wl_display" || type == "wl_surface" || type == "AHardwareBuffer" ||
                type == "IDirectFB" || type == "ANativeWindow" || type == "IDirectFBSurface" || type == "HMONITOR") {
                return "void*";
            }

            if (type == "uint8_t") {
                return "byte";
            }

            if (type == "LPCWSTR") {
                return "char*";
            }

            if (type == "CAMetalLayer") {
                return "void";
            }

            return type;
        }

        /// <summary>
        /// Convert a C parameter into C# parameter
        /// </summary>
        /// <param name="str">C parameter</param>
        /// <returns>C# parameter</returns>
        private static string ToCSharpParameter(string str) {
            if (str == "event") {
                return "@event";
            }

            if (str == "object") {
                return "@object";
            }

            /* Rename pointer parameters */

            if (str.Length >= 2 && str.First() == 'p' && char.IsUpper(str[1])) {
                return ToCSharpParameter($"{char.ToLower(str[1])}{str.Substring(2)}");
            }

            if (str.Length >= 3 && str.First() == 'p' && str[1] == 'p' && char.IsUpper(str[2])) {
                return ToCSharpParameter($"{char.ToLower(str[2])}{str.Substring(3)}");
            }

            return str;
        }

        // TODO: Doc
        private static string ToVolkAliasType(string type) =>
            type switch {
                "uint32_t" => "System.UInt32",
                "uint64_t" => "System.UInt64",
                _          => type
            };

        /// <summary>
        /// Add a range of items into a linked list
        /// </summary>
        /// <param name="source">Linked list</param>
        /// <param name="items">Items to add</param>
        /// <typeparam name="T">Item type</typeparam>
        private static void AddLastRange<T>(this LinkedList<T> source, IEnumerable<T> items) {
            foreach (var item in items) {
                source.AddLast(item);
            }
        }

        /// <summary>
        /// Convert a string containing upper-case letters and underscores into a title case string without underscores
        /// </summary>
        /// <param name="str">String</param>
        /// <returns>Transformed string</returns>
        private static string ToTitleCase(string str) {
            var builder = new StringBuilder();

            for (var i = 0; i < str.Length; i++) {
                if (str[i] == '_') {
                    continue;
                }

                if (i == 0 || str[i - 1] == '_') {
                    builder.Append(char.ToUpper(str[i]));
                } else {
                    builder.Append(char.ToLower(str[i]));
                }
            }

            return builder.ToString();
        }

        /// <summary>
        /// Deduce enumeration value prototype (name and value)
        /// </summary>
        /// <param name="element">Element</param>
        /// <returns>A tuple with the name and the value</returns>
        /// <exception cref="Exception">Unable to deduce prototype</exception>
        private static (string, string) DeduceEnumerationPrototype(XElement element) {
            var originalName = element.Attribute("name");
            if (originalName is null) {
                throw new Exception("original name is null");
            }

            string name = TrimVkPrefix(ToTitleCase(originalName.Value));

            var alias = element.Attribute("alias");
            if (alias != null) {
                return (name, TrimVkPrefix(ToTitleCase(alias.Value)));
            }

            var bitpos = element.Attribute("bitpos");
            if (bitpos != null) {
                return (name, $"1 << {TrimVkPrefix(bitpos.Value)}");
            }

            var value = element.Attribute("value");
            if (value != null) {
                return (name, value.Value);
            }

            var offset = element.Attribute("offset");
            if (offset is null) {
                throw new Exception($"Unsupported element: {element}");
            }

            var direction = element.Attribute("dir") != null && element.Attribute("dir")?.Value.First() == '-' ? -1 : 1;

            var extensionNumber = element.Attribute("extnumber") != null
                ? element.Attribute("extnumber")?.Value
                : element.Parent?.Parent?.Attribute("number")?.Value;
            if (extensionNumber is null) {
                throw new Exception($"Undefined extension number for: {element}");
            }

            var result = direction * (1000000000 + (int.Parse(extensionNumber, CultureInfo.InvariantCulture.NumberFormat) - 1) * 1000 +
                                      int.Parse(offset.Value));

            return (name, result.ToString());
        }

        /// <summary>
        /// Remove "vk" prefix in a string if presents
        /// </summary>
        /// <param name="str">String</param>
        /// <returns>String without vk prefix</returns>
        private static string TrimVkPrefix(string str) => str.StartsWith("Vk") || str.StartsWith("vk") ? str.Substring(2) : str;

        /// <summary>
        /// Deduce prototype (type and name)
        /// </summary>
        /// <param name="nodes">List of nodes</param>
        /// <returns>A tuple with the type and the name</returns>
        /// <exception cref="Exception">Unsupported node or unable to determine prototype</exception>
        private static (string, string) DeducePrototype(IEnumerable<XNode> nodes) {
            var name = new StringBuilder();
            var type = new StringBuilder();

            var nameEncountered = false;
            foreach (var node in nodes) {
                if (node is XElement element) {
                    switch (element.Name.LocalName) {
                        case "name":
                            name.Append(element.Value);
                            nameEncountered = true;
                            break;

                        case "enum":
                            name.Append(element.Value);
                            break;

                        case "type":
                            type.Append(element.Value);
                            break;

                        case "comment": // Skip
                            break;

                        default:
                            throw new Exception($"Unsupported element: {element}");
                    }
                } else {
                    var content = node.ToString().Trim();

                    switch (content) {
                        case "const":
                        case "const struct":
                        case "struct":
                            continue;

                        case "* const*":
                            type.Append("**");
                            break;

                        default:
                            (nameEncountered ? name : type).Append(content);
                            break;
                    }
                }
            }

            if (name.Length == 0 || type.Length == 0) {
                throw new Exception("Unable to determine prototype");
            }

            return (ToCSharpType(type.ToString()), ToCSharpParameter(name.ToString()));
        }

        /// <summary>
        /// Generate the copyright comment for volk files
        /// </summary>
        /// <returns>Copyright</returns>
        private static string Copyright() =>
            $"// Copyright 2020-{DateTime.Now.Year} Volk Project\n" +
            "// Licensed under Apache License 2.0 or any later version\n" +
            "// Refer to the LICENSE.md file included.\n\n" +
            "// This file is generated automatically by generator\n" +
            "\n";
    }
}