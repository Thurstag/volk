// Copyright 2020-2020 Volk Project
// Licensed under Apache License 2.0 or any later version
// Refer to the LICENSE.md file included.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using static Volk.Generator.Utilities.GeneratorUtilities;
using static Volk.Generator.Utilities.VulkanUtilities;

namespace Volk.Generator.Writers {
    /// <summary>
    /// Writer for vulkan constants
    /// </summary>
    public static class ConstantsWriter {
        /// <summary>
        /// Write Constants file
        /// </summary>
        /// <param name="constants">Vulkan constants</param>
        public static void Write(IEnumerable<XElement> constants) {
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
                    value = TrimVkPrefix(alias.Value.ToTitleCase());
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
                    $"        public const {type} {TrimVkPrefix(name.Value.ToTitleCase())} = {value};";
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
    }
}