// Copyright 2020-2020 Volk Project
// Licensed under Apache License 2.0 or any later version
// Refer to the LICENSE.md file included.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Volk.Generator.Utilities {
    /// <summary>
    ///     A utility class for generator
    /// </summary>
    public static class GeneratorUtilities {
        /// <summary>
        ///     Generate the copyright comment for volk files
        /// </summary>
        /// <returns>Copyright</returns>
        public static string Copyright() {
            return $"// Copyright 2020-{DateTime.Now.Year} Volk Project\n" +
                   "// Licensed under Apache License 2.0 or any later version\n" +
                   "// Refer to the LICENSE.md file included.\n\n" +
                   "// This file is generated automatically by generator\n" +
                   "\n";
        }

        /// <summary>
        ///     Convert a string containing upper-case letters and underscores into a title case string without underscores
        /// </summary>
        /// <param name="str">String</param>
        /// <returns>Transformed string</returns>
        public static string ToTitleCase(this string str) {
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
        ///     Filter non null elements
        /// </summary>
        /// <param name="source">Source</param>
        /// <typeparam name="T">Element type</typeparam>
        /// <returns>Source without null</returns>
        public static IEnumerable<T> NonNull<T>(this IEnumerable<T?> source) where T : struct => source.OfType<T>();

        /// <summary>
        ///     Add a range of items into a linked list
        /// </summary>
        /// <param name="source">Linked list</param>
        /// <param name="items">Items to add</param>
        /// <typeparam name="T">Item type</typeparam>
        public static void AddLastRange<T>(this LinkedList<T> source, IEnumerable<T> items) {
            foreach (var item in items) {
                source.AddLast(item);
            }
        }
    }
}