// Copyright 2020-2020 Volk Project
// Licensed under Apache License 2.0 or any later version
// Refer to the LICENSE.md file included.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using static Volk.Generator.Utilities.GeneratorUtilities;
using static Volk.Generator.Utilities.VulkanUtilities;

namespace Volk.Generator.Writers {
    /// <summary>
    ///     Writer for vulkan enumerations
    /// </summary>
    public static class EnumerationsWriter {
        /// <summary>
        ///     Write enumerations and bitmasks in files
        /// </summary>
        /// <param name="enumerations">Enumerations</param>
        /// <param name="bitmasks">Bitmasks</param>
        /// <param name="baseTypes">Base types</param>
        public static void Write(Dictionary<string, LinkedList<XElement>> enumerations,
                                 IReadOnlyDictionary<string, ((string, XElement), LinkedList<XElement>)> bitmasks,
                                 LinkedList<string> baseTypes) {
            var enumerationArray = new string[enumerations.Count];
            var bitmaskArray = new string[bitmasks.Count];

            var index = 0;
            foreach (var (name, enumeration) in enumerations.Where(pair => !bitmasks.ContainsKey(pair.Key))) {
                enumerationArray[index++] = $"\tpublic enum {TrimVkPrefix(name)} {{\n" +
                                            $"{string.Join(",\n", enumeration.Select(DeduceEnumeration).NonNull().Select(proto => $"\t\t{proto.Item1} = {proto.Item2}").Distinct())}\n" +
                                            "\t}";
            }

            index = 0;
            foreach (var (_, ((name, enumeration), values)) in bitmasks) {
                bitmaskArray[index++] =
                    "\t[FlagsAttribute]\n" +
                    $"\tpublic enum {TrimVkPrefix(name)} : {ToCSharpType(enumeration.Element("type")?.Value ?? throw new Exception("Enumeration type is undefined"))} {{\n" +
                    $"{string.Join(",\n", values.Select(DeduceEnumeration).NonNull().Select(proto => $"\t\t{proto.Item1} = {proto.Item2}").Distinct())}\n" +
                    "\t}";
            }

            using var bitmaskFile = new StreamWriter("Bitmasks.cs", false);
            bitmaskFile.WriteLine(
                $@"{Copyright()}
using FlagsAttribute = System.FlagsAttribute;

{string.Join("\n", baseTypes)}

namespace Volk.Vulkan.Types {{
{string.Join("\n\n", bitmaskArray)}
}}"
            );

            using var enumerationFile = new StreamWriter("Enumerations.cs", false);
            enumerationFile.WriteLine(
                $@"{Copyright()}
{string.Join("\n", baseTypes)}

namespace Volk.Vulkan.Types {{
{string.Join("\n\n", enumerationArray)}
}}"
            );

            Console.WriteLine("All enumerations were generated");
        }

        /// <summary>
        ///     Deduce enumeration value prototype (name and value)
        /// </summary>
        /// <param name="element">Element</param>
        /// <returns>A tuple with the name and the value or null</returns>
        /// <exception cref="Exception">Unable to deduce prototype</exception>
        private static (string, string)? DeduceEnumeration(XElement element) {
            var originalName = element.Attribute("name");
            if (originalName is null) {
                throw new Exception("original name is null");
            }

            string name = TrimVkPrefix(originalName.Value.ToTitleCase());

            var alias = element.Attribute("alias");
            if (alias != null) {
                var aliasName = TrimVkPrefix(alias.Value.ToTitleCase());
                if (Equals(name, aliasName)) {
                    return null;
                }

                return (name, aliasName);
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
    }
}