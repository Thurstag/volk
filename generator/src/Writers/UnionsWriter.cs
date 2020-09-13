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
    /// Writer for vulkan unions
    /// </summary>
    public static class UnionsWriter {
        /// <summary>
        /// Write Unions file
        /// </summary>
        /// <param name="unions">Vulkan unions</param>
        /// <param name="baseTypes">Base types</param>
        public static void Write(Dictionary<string, XElement> unions, LinkedList<string> baseTypes) {
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
    }
}