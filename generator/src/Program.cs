﻿// Copyright 2020-2020 Volk Project
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

    static class Program {
        private const string VulkanSpecUrl = "https://raw.githubusercontent.com/KhronosGroup/Vulkan-Docs/master/xml/vk.xml";

        static void Main(string[] args) {
            // Download vulkan spec
            XDocument doc = XDocument.Load(args.Length > 1 ? args[0] : VulkanSpecUrl);
            Console.WriteLine("Vulkan specification loaded");

            // Extract commands
            var commands = new Dictionary<string, XElement>();
            var commandAliases = new Dictionary<string, string>();
            foreach (var cmdGroup in doc.Root.Elements("commands")) {
                foreach (var cmd in cmdGroup.Elements("command")) {
                    XAttribute alias = cmd.Attribute("alias"), name = cmd.Attribute("name");

                    if (alias != null && name != null) { // Alias
                        commandAliases[name.Value] = alias.Value;
                    } else {
                        var cmdName = cmd.Element("proto")?.Element("name")?.Value;
                        if (cmdName == null) {
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
                    XAttribute alias = type.Attribute("alias"), name = type.Attribute("name");

                    if (alias != null && name != null) { // Alias
                        if (!typeAliases.ContainsKey(alias.Value)) {
                            typeAliases[alias.Value] = new LinkedList<string>();
                        }

                        typeAliases[alias.Value].AddLast(name.Value);
                    } else if (name != null) {
                        types[name.Value] = type;
                    } else if (type.Elements().Any()) {
                        var typeName = type.Element("name")?.Value;
                        if (typeName == null) {
                            throw new Exception("Malformed type");
                        }

                        types[typeName] = type;
                    }
                }
            }

            Console.WriteLine("Types extracted");

            // Extract base types, enumerations
            LinkedList<string> baseTypes = new LinkedList<string>(), handles = new LinkedList<string>(), usingAliases = new LinkedList<string>();
            var constants = new LinkedList<XElement>();
            Dictionary<string, LinkedList<XElement>> enumerations = new Dictionary<string, LinkedList<XElement>>();
            Dictionary<string, KeyValuePair<KeyValuePair<string, XElement>, LinkedList<XElement>>> bitmasks =
                new Dictionary<string, KeyValuePair<KeyValuePair<string, XElement>, LinkedList<XElement>>>();
            Dictionary<string, XElement> structures = new Dictionary<string, XElement>(), unions = new Dictionary<string, XElement>();
            ExtractTypeGroups(types, typeAliases, baseTypes, handles, enumerations, bitmasks, structures, usingAliases, unions); // TODO: Use tuple

            // Extract enumerations values
            ExtractEnumerationsValues(doc.Root, enumerations, bitmasks, constants);

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

        // TODO: Doc
        private static void WriteInstanceAndDevicesFunctionsLoader(Dictionary<string, XElement> commands, Dictionary<string, XElement> types) {
            LinkedList<string> instanceCommands = new LinkedList<string>(), deviceCommands = new LinkedList<string>();

            foreach (var command in commands) {
                var firstParamType = command.Value.Element("param")?.Element("type")?.Value;
                if (firstParamType != null && IsDescendantType(types, "VkDevice", firstParamType) && command.Key != "vkGetDeviceProcAddr") {
                    deviceCommands.AddLast(command.Key);
                } else if (firstParamType != null && IsDescendantType(types, "VkInstance", firstParamType) &&
                           command.Key != "vkGetInstanceProcAddr") {
                    instanceCommands.AddLast(command.Key);
                }
            }

            using var instanceFile = new StreamWriter("InstanceFunctions.cs", false); // TODO: Doc
            instanceFile.WriteLine(Copyright());
            instanceFile.WriteLine("using System;\n" +
                                   "using System.Text;\n" +
                                   "using Volk.Vulkan;\n\n" +
                                   "namespace Volk {\n" +
                                   "\tpublic static partial class Functions {\n" +
                                   "\t\tpublic static void LoadInstance(IntPtr instance) {\n" +
                                   "\t\t\tif (CommandTable.GetInstanceProcAddr == null) {\n" +
                                   "\t\t\t\tthrow new Exception(\"GetInstanceProcAddr isn't loaded\");\n" +
                                   "\t\t\t}\n\n" +
                                   "\t\t\tunsafe {\n" +
                                   string.Join("\n",
                                       instanceCommands.Select(cmd =>
                                           $"\t\t\t\tfixed (byte* funcName = &Encoding.UTF8.GetBytes(\"{cmd}\")[0]) {{\n" +
                                           $"\t\t\t\t\tCommandTable.{TrimVKPrefix(cmd)} = FunctionPtrToDelegate<Commands.{TrimVKPrefix(cmd)}>(CommandTable.GetInstanceProcAddr(instance, funcName));" +
                                           "\n\t\t\t\t}")) +
                                   "\n\t\t\t}\n" +
                                   "\t\t}\n" +
                                   "\t}\n" +
                                   "}");

            using var deviceFile = new StreamWriter("DeviceFunctions.cs", false); // TODO: Doc
            deviceFile.WriteLine(Copyright());
            deviceFile.WriteLine("using System;\n" +
                                 "using System.Text;\n" +
                                 "using Volk.Vulkan;\n\n" +
                                 "namespace Volk {\n" +
                                 "\tpublic static partial class Functions {\n" +
                                 "\t\tpublic static void LoadDevice(IntPtr device) {\n" +
                                 "\t\t\tif (CommandTable.GetDeviceProcAddr == null) {\n" +
                                 "\t\t\t\tthrow new Exception(\"GetDeviceProcAddr isn't loaded\");\n" +
                                 "\t\t\t}\n\n" +
                                 "\t\t\tunsafe {\n" +
                                 string.Join("\n",
                                     deviceCommands.Select(cmd =>
                                         $"\t\t\t\tfixed (byte* funcName = &Encoding.UTF8.GetBytes(\"{cmd}\")[0]) {{\n" +
                                         $"\t\t\t\t\tCommandTable.{TrimVKPrefix(cmd)} = FunctionPtrToDelegate<Commands.{TrimVKPrefix(cmd)}>(CommandTable.GetDeviceProcAddr(device, funcName));" +
                                         "\n\t\t\t\t}")) +
                                 "\n\t\t\t}\n" +
                                 "\t\t}\n\n" +
                                 "\t\tpublic static DeviceCommandTable LoadDeviceTable(IntPtr device) {\n" +
                                 "\t\t\tif (CommandTable.GetDeviceProcAddr == null) {\n" +
                                 "\t\t\t\tthrow new Exception(\"GetDeviceProcAddr isn't loaded\");\n" +
                                 "\t\t\t}\n\n" +
                                 "\t\t\tvar deviceTable = new DeviceCommandTable();\n" +
                                 "\t\t\tunsafe {\n" +
                                 string.Join("\n",
                                     deviceCommands.Select(cmd =>
                                         $"\t\t\t\tfixed (byte* funcName = &Encoding.UTF8.GetBytes(\"{cmd}\")[0]) {{\n" +
                                         $"\t\t\t\t\tdeviceTable.{TrimVKPrefix(cmd)} = FunctionPtrToDelegate<Commands.{TrimVKPrefix(cmd)}>(CommandTable.GetDeviceProcAddr(device, funcName));" +
                                         "\n\t\t\t\t}")) +
                                 "\n\t\t\t}\n" +
                                 "\t\t\treturn deviceTable;\n" +
                                 "\t\t}\n" +
                                 "\t}\n" +
                                 "}");

            using var deviceTableFile = new StreamWriter("DeviceCommandTable.cs", false); // TODO: Doc
            deviceTableFile.WriteLine(Copyright());
            deviceTableFile.WriteLine("namespace Volk.Vulkan {\n" +
                                      "\tpublic class DeviceCommandTable {\n" +
                                      string.Join("\n",
                                          deviceCommands.Select(cmd => $"\t\tpublic Commands.{TrimVKPrefix(cmd)}? {TrimVKPrefix(cmd)};")) +
                                      "\n\t}\n" +
                                      "}");

            Console.WriteLine("Instance/Device commands loader was generated");
        }

        // TODO: Doc
        private static bool IsDescendantType(Dictionary<string, XElement> types, string baseType, string type) {
            if (baseType == type) {
                return true;
            }

            if (!types.ContainsKey(type)) {
                return false;
            }

            var parents = types[type].Attribute("parent");
            if (parents == null) {
                return false;
            }

            return parents.Value.Split(',').Any(parent => IsDescendantType(types, baseType, parent));
        }

        // TODO: Doc
        private static void WriteCommandTable(Dictionary<string, XElement> commands) {
            var commandsArray = new string[commands.Count];

            int index = 0;
            foreach (var cmd in commands) {
                commandsArray[index++] = $"\t\tpublic static Commands.{TrimVKPrefix(cmd.Key)}? {TrimVKPrefix(cmd.Key)};";
            }

            using var commandsFile = new StreamWriter("CommandTable.cs", false);
            commandsFile.WriteLine(Copyright());
            commandsFile.WriteLine("namespace Volk.Vulkan {\n" +
                                   "\tpublic static class CommandTable {\n" +
                                   string.Join("\n", commandsArray) +
                                   "\n\t}\n" +
                                   "}");
            Console.WriteLine("Command table was written");
        }

        // TODO: Doc
        private static void WriteConstants(LinkedList<XElement> constants) {
            var constantArray = new string[constants.Count];
            var types = new Dictionary<string, string>();

            int index = 0;
            foreach (var constant in constants) {
                string type, value;

                if (constant.Attribute("alias") != null) {
                    type = types[constant.Attribute("alias").Value];
                    value = TrimVKPrefix(ToTitleCase(constant.Attribute("alias").Value));
                } else {
                    type = DeclType(constant.Attribute("value").Value);
                    value = constant.Attribute("value").Value;

                    if (type == "ushort") {
                        value = $"unchecked((ushort) {value})";
                    } else if (type == "ulong") {
                        value = value.Replace("ULL", "UL");
                    }

                    types.Add(constant.Attribute("name").Value, type);
                }

                constantArray[index++] =
                    $"\t\tpublic const {type} {TrimVKPrefix(ToTitleCase(constant.Attribute("name").Value))} = {value};";
            }

            using var constantFile = new StreamWriter("Constants.cs", false);
            constantFile.WriteLine(Copyright());
            constantFile.WriteLine("namespace Volk.Vulkan {\n" +
                                   "\tpublic class Constants {\n" +
                                   $"{string.Join("\n", constantArray)}\n" +
                                   "\t}\n" +
                                   "\n}");

            Console.WriteLine("All constants were generated");
        }

        // TODO: Doc
        private static string DeclType(string value) {
            if (value.Last() == 'f') {
                return "float";
            } else if (value.Contains("ULL")) {
                return "ulong";
            } else if (value.Contains("U")) {
                return "ushort";
            }

            return "int";
        }

        private static void WriteUnions(Dictionary<string, XElement> unions, LinkedList<string> baseTypes) {
            var unionArray = new string[unions.Count];

            int index = 0;
            foreach (var union in unions) {
                unionArray[index++] = "\t[StructLayout(LayoutKind.Explicit)]\n" +
                                      $"\tpublic struct {TrimVKPrefix(union.Key)} {{\n" +
                                      $"{string.Join("\n", union.Value.Elements("member").Select(member => Declaration(member.Nodes())).Select(member => $"\t\t[FieldOffset(0)] public unsafe {(Regex.IsMatch(member.Value, @"\[.*\]$") ? "fixed " : "")}{member.Key} {member.Value};"))}\n" +
                                      "\t}";
            }

            using var unionFile = new StreamWriter("Unions.cs", false);
            unionFile.WriteLine(Copyright());
            unionFile.WriteLine("using System.Runtime.InteropServices;\n" +
                                $"{string.Join("\n", baseTypes)}\n\n" +
                                "namespace Volk.Vulkan.Types {\n" +
                                string.Join("\n\n", unionArray) +
                                "\n}");

            Console.WriteLine("All unions were generated");
        }

        private static void WriteStructures(Dictionary<string, XElement> structures, Dictionary<string, XElement> types, LinkedList<string> baseTypes,
            LinkedList<string> usingAliases,
            LinkedList<string> handles, LinkedList<XElement> constants) {
            var structureArray = new string[structures.Count];

            int index = 0;
            foreach (var structure in structures) {
                var members = new LinkedList<string>();

                foreach (var member in structure.Value.Elements("member")) {
                    var proto = Declaration(member.Nodes());

                    var arrayMatcher = Regex.Match(proto.Value, @"\[.*\]$");
                    if (arrayMatcher.Success) {
                        if (proto.Value.EndsWith("[]")) {
                            proto = new KeyValuePair<string, string>($"{proto.Key}[]", proto.Value.Substring(0, proto.Value.Length - 2));
                        } else if (Regex.IsMatch(proto.Value, @"\[.*\]\[.*\]$")) {
                            proto = new KeyValuePair<string, string>($"{proto.Key}[][]", proto.Value.Substring(0, arrayMatcher.Index));
                        } else {
                            var sizeStr = proto.Value.Substring(arrayMatcher.Index + 1, proto.Value.Length - 2 - arrayMatcher.Index);
                            int size;
                            if (int.TryParse(sizeStr, out size)) {
                                if (types.ContainsKey($"Vk{proto.Key}")) {
                                    for (int i = 0; i < size; i++) {
                                        members.AddLast($"\t\tpublic {proto.Key} {proto.Value.Substring(0, arrayMatcher.Index)}_{i};");
                                    }

                                    continue;
                                } else {
                                    proto = new KeyValuePair<string, string>($"fixed {proto.Key}", proto.Value);
                                }
                            } else {
                                if (types.ContainsKey($"Vk{proto.Key}")) {
                                    var realSize = int.Parse(constants.First(constant => constant.Attribute("name").Value == sizeStr)
                                        .Attribute("value").Value);
                                    for (int i = 0; i < realSize; i++) {
                                        members.AddLast($"\t\tpublic {proto.Key} {proto.Value.Substring(0, arrayMatcher.Index)}_{i};");
                                    }

                                    continue;
                                } else {
                                    proto = new KeyValuePair<string, string>($"fixed {proto.Key}",
                                        $"{proto.Value.Substring(0, arrayMatcher.Index)}[Constants.{TrimVKPrefix(ToTitleCase(sizeStr))}]");
                                }
                            }
                        }
                    }

                    members.AddLast($"\t\tpublic unsafe {proto.Key} {proto.Value};");
                }

                structureArray[index++] = $"\tpublic struct {ToVolkType(structure.Key)} {{\n" +
                                          $"{string.Join("\n", members)}\n" +
                                          "\t}";
            }

            using var structureFile = new StreamWriter("Structures.cs", false);
            structureFile.WriteLine(Copyright());
            structureFile.WriteLine("using DotNetCross.NativeInts;\n" +
                                    "using IntPtr = System.IntPtr;\n\n" +
                                    $"{string.Join("\n", baseTypes)}\n\n" +
                                    $"{string.Join("\n", handles)}\n\n" +
                                    $"{string.Join("\n", usingAliases)}\n\n" +
                                    "namespace Volk.Vulkan.Types {\n" +
                                    string.Join("\n\n", structureArray) +
                                    "\n}");

            Console.WriteLine("All structures were generated");
        }

        private static void WriteEnumerations(Dictionary<string, LinkedList<XElement>> enumerations,
            Dictionary<string, KeyValuePair<KeyValuePair<string, XElement>, LinkedList<XElement>>> bitmasks, LinkedList<string> baseTypes) {
            var enumerationArray = new string[enumerations.Count];
            var bitmaskArray = new string[bitmasks.Count];

            int index = 0;
            foreach (var enumeration in enumerations.Where(pair => !bitmasks.ContainsKey(pair.Key))) {
                enumerationArray[index++] = $"\tpublic enum {TrimVKPrefix(enumeration.Key)} {{\n" +
                                            $"{string.Join(",\n", enumeration.Value.Select(e => $"\t\t{ToEnumerationValue(e)}").Distinct())}\n" +
                                            "\t}";
            }

            index = 0;
            foreach (var bitmask in bitmasks) {
                bitmaskArray[index++] =
                    "\t[FlagsAttribute]\n" +
                    $"\tpublic enum {TrimVKPrefix(bitmask.Value.Key.Key)} : {ToVolkType(bitmask.Value.Key.Value.Element("type").Value)} {{\n" +
                    $"{string.Join(",\n", bitmask.Value.Value.Select(e => $"\t\t{ToEnumerationValue(e)}").Distinct())}\n" +
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
        private static void ExtractEnumerationsValues(XElement docRoot, Dictionary<string, LinkedList<XElement>> enumerations,
            Dictionary<string, KeyValuePair<KeyValuePair<string, XElement>, LinkedList<XElement>>> bitmasks, LinkedList<XElement> constants) {
            foreach (var enumerationValue in docRoot.Elements("enums")
                .Where(value => value.Attribute("name") != null)) {
                if (enumerations.ContainsKey(enumerationValue.Attribute("name").Value)) {
                    enumerations[enumerationValue.Attribute("name").Value].AddLastRange(enumerationValue.Elements("enum"));
                }

                if (bitmasks.ContainsKey(enumerationValue.Attribute("name").Value)) {
                    bitmasks[enumerationValue.Attribute("name").Value].Value.AddLastRange(enumerationValue.Elements("enum"));
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
                    bitmasks[enumerationValue.Attribute("extends").Value].Value.AddLast(enumerationValue);
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
                    bitmasks[enumerationValue.Attribute("extends").Value].Value.AddLast(enumerationValue);
                }
            }
        }

        // TODO: Doc
        private static void ExtractTypeGroups(Dictionary<string, XElement> types, Dictionary<string, LinkedList<string>> typeAliases,
            LinkedList<string> baseTypes,
            LinkedList<string> handles,
            Dictionary<string, LinkedList<XElement>> enumerations,
            Dictionary<string, KeyValuePair<KeyValuePair<string, XElement>, LinkedList<XElement>>> bitmasks,
            Dictionary<string, XElement> structures,
            LinkedList<string> usingAliases,
            Dictionary<string, XElement> unions) {
            foreach (var type in types
                .Where(type => type.Value.Attribute("category") != null)) {
                switch (type.Value.Attribute("category").Value) {
                    case "basetype":
                        if (type.Value.Element("type") != null) {
                            baseTypes.AddLast($"using {ToVolkType(type.Key)} = {ToVolkAliasType(type.Value.Element("type").Value)};");
                        }

                        break;

                    case "handle":
                        if (type.Value.Element("name") != null) {
                            string name = type.Value.Element("name").Value;
                            string volkName = ToVolkType(name);

                            handles.AddLast($"using {volkName} = System.IntPtr;");
                            if (typeAliases.ContainsKey(name)) {
                                foreach (var alias in typeAliases[name]) {
                                    handles.AddLast($"using {ToVolkType(alias)} = System.IntPtr;");
                                }
                            }
                        }

                        break;

                    case "enum":
                        if (typeAliases.ContainsKey(type.Key)) {
                            foreach (var alias in typeAliases[type.Key]) {
                                usingAliases.AddLast($"using {ToVolkType(alias)} = Volk.Vulkan.Types.{ToVolkType(type.Key)};");
                            }
                        }

                        enumerations.Add(type.Key, new LinkedList<XElement>());
                        break;

                    case "struct":
                        structures.Add(type.Key, type.Value);

                        if (typeAliases.ContainsKey(type.Key)) {
                            foreach (var alias in typeAliases[type.Key]) {
                                usingAliases.AddLast($"using {ToVolkType(alias)} = Volk.Vulkan.Types.{ToVolkType(type.Key)};");
                            }
                        }

                        break;

                    case "bitmask":
                        if (type.Value.Element("type") == null) {
                            throw new Exception("Based type is undefined");
                        }

                        if (type.Value.Attribute("requires") == null) {
                            bitmasks.Add(type.Key,
                                new KeyValuePair<KeyValuePair<string, XElement>, LinkedList<XElement>>(type, new LinkedList<XElement>()));
                        } else {
                            bitmasks.Add(type.Value.Attribute("requires").Value,
                                new KeyValuePair<KeyValuePair<string, XElement>, LinkedList<XElement>>(type, new LinkedList<XElement>()));
                        }

                        break;

                    case "union":
                        unions.Add(type.Key, type.Value);
                        break;
                }
            }
        }

        // TODO: Doc
        private static void WriteCommands(Dictionary<string, XElement> commands, LinkedList<string> baseTypes, LinkedList<string> usingAliases,
            LinkedList<string> handles) {
            var commandsArray = new string[commands.Count];

            int index = 0;
            foreach (var cmd in commands) {
                var returnType = cmd.Value.Element("proto")?.Element("type");
                if (returnType == null) {
                    throw new Exception("No return type for command: " + cmd.Key);
                }

                var parameters = new LinkedList<KeyValuePair<string, string>>();
                foreach (var parameter in cmd.Value.Elements("param")) {
                    var newParameter = Declaration(parameter.Nodes());

                    if (Regex.IsMatch(newParameter.Value, @"\[.*\]$")) {
                        newParameter = new KeyValuePair<string, string>($"{newParameter.Key}[]", Regex.Replace(newParameter.Value, @"\[.*\]$", ""));
                    }

                    parameters.AddLast(newParameter);
                }

                commandsArray[index++] =
                    $"{ToVolkType(returnType.Value)} {TrimVKPrefix(cmd.Key)}({string.Join(", ", parameters.Select(p => $"{p.Key} {p.Value}"))})";
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

        // TODO: Doc
        private static string ToVolkType(string type) {
            if (type.EndsWith("*")) {
                return ToVolkType(type.Substring(0, type.Length - 1)) + "*";
            }

            if (type.StartsWith("Vk")) {
                if (type.Contains("FlagBits")) {
                    return type.Replace("FlagBits", "Flags").Substring(2);
                }

                return type.Substring(2);
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

        // TODO: Doc
        private static string ToCSharpParameter(string str) {
            if (str == "event") {
                return "@event";
            }

            if (str == "object") {
                return "@object";
            }

            if (str.Length >= 2 && str.First() == 'p' && char.IsUpper(str[1])) {
                return ToCSharpParameter($"{char.ToLower(str[1])}{str.Substring(2)}");
            }

            if (str.Length >= 3 && str.First() == 'p' && str[1] == 'p' && char.IsUpper(str[2])) {
                return ToCSharpParameter($"{char.ToLower(str[2])}{str.Substring(3)}");
            }

            return str;
        }

        // TODO: Doc
        private static string ToVolkAliasType(string type) {
            if (type == "uint32_t") {
                return "System.UInt32";
            }

            if (type == "uint64_t") {
                return "System.UInt64";
            }

            return type;
        }

        // TODO: Doc
        public static void AddLastRange<T>(this LinkedList<T> source, IEnumerable<T> items) {
            foreach (T item in items) {
                source.AddLast(item);
            }
        }

        // TODO: Doc
        public static string ToTitleCase(string str) {
            var builder = new StringBuilder();

            for (int i = 0; i < str.Length; i++) {
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

        public static string ToEnumerationValue(XElement element) {
            string name = TrimVKPrefix(ToTitleCase(element.Attribute("name").Value));

            if (element.Attribute("alias") != null) {
                return $"{name} = {TrimVKPrefix(ToTitleCase(element.Attribute("alias").Value))}";
            }

            if (element.Attribute("bitpos") != null) {
                return $"{name} = 1 << {TrimVKPrefix(element.Attribute("bitpos").Value)}";
            }

            if (element.Attribute("value") != null) {
                return $"{name} = {element.Attribute("value").Value}";
            }

            if (element.Attribute("offset") != null) {
                int direction = element.Attribute("dir") != null && element.Attribute("dir").Value.First() == '-' ? -1 : 1;
                string? extensionNumber = element.Attribute("extnumber") != null
                    ? element.Attribute("extnumber").Value
                    : element.Parent?.Parent?.Attribute("number")?.Value;
                if (extensionNumber == null) {
                    throw new Exception($"Undefined extension number for: {element}");
                }

                int value = direction * (1000000000 + (int.Parse(extensionNumber, CultureInfo.InvariantCulture.NumberFormat) - 1) * 1000 +
                                         int.Parse(element.Attribute("offset").Value));

                return $"{name} = {value}";
            }

            throw new Exception($"Unable to decode: {element}");
        }

        // TODO: Doc
        public static string TrimVKPrefix(string str) {
            return str.StartsWith("Vk") || str.StartsWith("vk") ? str.Substring(2) : str;
        }

        // TODO: Doc + rename
        private static KeyValuePair<string, string> Declaration(IEnumerable<XNode> nodes) {
            var name = new StringBuilder();
            var type = new StringBuilder();

            bool nameEncountered = false;
            foreach (var node in nodes) {
                if (node is XElement element) {
                    if (element.Name.LocalName == "name") {
                        name.Append(element.Value);
                        nameEncountered = true;
                    } else if (element.Name.LocalName == "enum") {
                        name.Append(element.Value);
                    } else if (element.Name.LocalName == "type") {
                        type.Append(element.Value);
                    } else if (element.Name.LocalName == "comment") {
                        // Skip
                    } else {
                        throw new Exception($"Unsupported element: {element}");
                    }
                } else {
                    var content = node.ToString().Trim();
                    if (content == "const" || content == "const struct" || content == "struct") {
                        continue;
                    }

                    if (content == "* const*") {
                        type.Append("**");
                    } else {
                        (nameEncountered ? name : type).Append(content);
                    }
                }
            }

            if (name.Length == 0 || type.Length == 0) {
                throw new Exception("Unable to determine parameter");
            }

            return new KeyValuePair<string, string>(ToVolkType(type.ToString()), ToCSharpParameter(name.ToString()));
        }

        // TODO: Doc
        private static string Copyright() {
            return $"// Copyright 2020-{DateTime.Now.Year} Volk Project\n" +
                   "// Licensed under Apache License 2.0 or any later version\n" +
                   "// Refer to the LICENSE.md file included.\n";
        }
    }
}