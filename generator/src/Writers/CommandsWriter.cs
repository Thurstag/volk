// Copyright 2020-2020 Volk Project
// Licensed under Apache License 2.0 or any later version
// Refer to the LICENSE.md file included.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static Volk.Generator.Utilities.GeneratorUtilities;
using static Volk.Generator.Utilities.VulkanUtilities;

namespace Volk.Generator.Writers {
    /// <summary>
    /// Writer for vulkan commands
    /// </summary>
    public static class CommandsWriter {
        /// <summary>
        /// Write vulkan commands file
        /// </summary>
        /// <param name="commands">Commands</param>
        /// <param name="baseTypes">Base types</param>
        /// <param name="usings">Usings</param>
        /// <param name="handles">Handles</param>
        public static void Write(Dictionary<string, XElement> commands, IEnumerable<string> baseTypes, IEnumerable<string> usings,
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
            commandsFile.WriteLine(
                $@"{Copyright()}
using IntPtr = System.IntPtr;
using Volk.Vulkan.Types;
using DotNetCross.NativeInts;

{string.Join("\n", baseTypes)}

{string.Join("\n", handles)}

{string.Join("\n", usings)}

namespace Volk.Vulkan {{
    public static class Commands {{
{string.Join("\n\n", commandsArray.Select(cmd => $"\t\tpublic unsafe delegate {cmd};"))}
    }}
}}"
            );
            Console.WriteLine("All commands were generated");
        }
    }
}