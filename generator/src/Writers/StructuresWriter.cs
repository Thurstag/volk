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
    /// Writer for vulkan structures
    /// </summary>
    public static class StructuresWriter {
        /// <summary>
        /// Write Structures file
        /// </summary>
        /// <param name="structures">Structures</param>
        /// <param name="types">Types</param>
        /// <param name="baseTypes">Base types</param>
        /// <param name="usings">Usings</param>
        /// <param name="handles">Handles</param>
        /// <param name="constants">Constants</param>
        public static void Write(Dictionary<string, XElement> structures, IReadOnlyDictionary<string, XElement> types,
                                 IEnumerable<string> baseTypes,
                                 IEnumerable<string> usings,
                                 IEnumerable<string> handles, LinkedList<XElement> constants) {
            var structureArray = new string[structures.Count];

            var index = 0;
            foreach (var (structName, structure) in structures) {
                var partialMembers = new HashSet<string>();
                var members = new LinkedList<string>();

                var originalMembers = new LinkedList<(string, string)>(structure.Elements("member").Select(m => DeducePrototype(m.Nodes())));
                for (var member = originalMembers.First; member != null; member = member.Next) {
                    var (type, name) = member.Value;

                    var arrayMatcher = Regex.Match(name, @"\[.*\]$");
                    var partialField = Regex.Match(name, @"\:\d*$");
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
                                name = $"{name.Substring(0, arrayMatcher.Index)}[Constants.{TrimVkPrefix(sizeStr.ToTitleCase())}]";
                            }
                        }
                    } else if (partialField.Success) {
                        // Skip members processed
                        var key = $"{type}/{name}";
                        if (partialMembers.Contains(key)) {
                            continue;
                        }

                        partialMembers.Add(key);

                        var localPartialMembers = new LinkedList<string>();
                        var totalSize = SizeOf(type);

                        // Reconstruct member
                        uint currentSize = 0;
                        for (LinkedListNode<(string, string)>? partialMember = member;
                            partialMember != null && currentSize != totalSize;
                            partialMember = partialMember.Next) {
                            var (partialType, partialName) = partialMember.Value;
                            var nameAndSize = partialName.Split(':');

                            currentSize += uint.Parse(nameAndSize[1]);
                            partialMembers.Add($"{partialType}/{partialName}");
                            localPartialMembers.AddLast(nameAndSize[0]);
                        }

                        members.AddLast(
                            $"\t\tpublic unsafe {type} {string.Join("And", localPartialMembers.Take(1).Concat(localPartialMembers.Skip(1).Select(n => n.Length == 0 ? n : char.ToUpper(n[0]) + n.Substring(1))))};");
                        continue;
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

{string.Join("\n", usings)}

namespace Volk.Vulkan.Types {{
{string.Join("\n\n", structureArray)}
}}"
            );

            Console.WriteLine("All structures were generated");
        }

        /// <summary>
        /// Get size of a given type in bits
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns>Size in bits</returns>
        private static uint SizeOf(string type) {
            return type switch {
                "uint" => 32,
                _      => throw new Exception($"Unknown size of {type}")
            };
        }
    }
}