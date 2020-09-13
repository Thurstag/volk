// Copyright 2020-2020 Volk Project
// Licensed under Apache License 2.0 or any later version
// Refer to the LICENSE.md file included.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Volk.Generator.Utilities {
    /// <summary>
    /// A utility class for vulkan conversion
    /// </summary>
    public static class VulkanUtilities {
        /// <summary>
        /// Convert a C type into a C# type
        /// </summary>
        /// <param name="type">C type</param>
        /// <returns>C# type</returns>
        public static string ToCSharpType(string type) {
            if (type.EndsWith("*")) {
                return ToCSharpType(type.Substring(0, type.Length - 1)) + "*";
            }

            if (type.StartsWith("Vk")) {
                return type.Contains("FlagBits") ? type.Replace("FlagBits", "Flags").Substring(2) : type.Substring(2);
            }

            if (Equals(type, "uint16_t")) {
                return "ushort";
            }

            if (Equals(type, "uint32_t") || Equals(type, "xcb_window_t") || Equals(type, "zx_handle_t") || Equals(type, "DWORD")) {
                return "uint";
            }

            if (Equals(type, "uint64_t") || Equals(type, "RROutput") || Equals(type, "Window")) {
                return "ulong";
            }

            if (Equals(type, "int64_t")) {
                return "long";
            }

            if (type.StartsWith("PFN_")) {
                return "IntPtr";
            }

            if (Equals(type, "int")) {
                return "short";
            }

            if (Equals(type, "char")) {
                return "byte";
            }

            if (Equals(type, "int32_t") || Equals(type, "GgpStreamDescriptor") || Equals(type, "GgpFrameToken")) {
                return "int";
            }

            if (Equals(type, "size_t")) {
                return "nuint";
            }

            if (Regex.IsMatch(type, @"^.*\[.*\]$")) {
                return Regex.Replace(type, @"\[.*\]$", "[]");
            }

            if (Equals(type, "HANDLE") || Equals(type, "HINSTANCE") || Equals(type, "HWND") || Equals(type, "Display") ||
                Equals(type, "xcb_connection_t") ||
                Equals(type, "xcb_visualid_t") || Equals(type, "VisualID") || Equals(type, "wl_display") || Equals(type, "wl_surface") ||
                Equals(type, "AHardwareBuffer") ||
                Equals(type, "IDirectFB") || Equals(type, "ANativeWindow") || Equals(type, "IDirectFBSurface") || Equals(type, "HMONITOR")) {
                return "void*";
            }

            if (Equals(type, "uint8_t")) {
                return "byte";
            }

            if (Equals(type, "LPCWSTR")) {
                return "char*";
            }

            if (Equals(type, "CAMetalLayer")) {
                return "void";
            }

            return type;
        }

        /// <summary>
        /// Remove "vk" prefix in a string if presents
        /// </summary>
        /// <param name="str">String</param>
        /// <returns>String without vk prefix</returns>
        public static string TrimVkPrefix(string str) => str.StartsWith("Vk") || str.StartsWith("vk") ? str.Substring(2) : str;

        /// <summary>
        /// Deduce prototype (type and name)
        /// </summary>
        /// <param name="nodes">List of nodes</param>
        /// <returns>A tuple with the type and the name</returns>
        /// <exception cref="Exception">Unsupported node or unable to determine prototype</exception>
        public static (string, string) DeducePrototype(IEnumerable<XNode> nodes) {
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
        /// Convert a C parameter into C# parameter
        /// </summary>
        /// <param name="str">C parameter</param>
        /// <returns>C# parameter</returns>
        private static string ToCSharpParameter(string str) {
            if (Equals(str, "event")) {
                return "@event";
            }

            if (Equals(str, "object")) {
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
    }
}