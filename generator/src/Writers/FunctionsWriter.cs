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
    ///     Writer for vulkan functions and loaders
    /// </summary>
    public static class FunctionsWriter {
        /// <summary>
        ///     Write InstanceFunctions, DeviceFunctions, DeviceCommandTable files
        /// </summary>
        /// <param name="commands">Vulkan commands</param>
        /// <param name="types">Vulkan types</param>
        public static void Write(Dictionary<string, XElement> commands, IReadOnlyDictionary<string, XElement> types) {
            LinkedList<string> instanceCommands = new LinkedList<string>(), deviceCommands = new LinkedList<string>();

            foreach (var (name, command) in commands) {
                var firstParamType = command.Element("param")?.Element("type")?.Value;
                if (firstParamType != null && IsDescendantType(types, "VkDevice", firstParamType) && !Equals(name, "vkGetDeviceProcAddr")) {
                    deviceCommands.AddLast(name);
                } else if (firstParamType != null && IsDescendantType(types, "VkInstance", firstParamType) &&
                           !Equals(name, "vkGetInstanceProcAddr")) {
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
        ///     Check if a given type is a descendant of another type
        /// </summary>
        /// <param name="types">Vulkan types</param>
        /// <param name="baseType">Base type</param>
        /// <param name="type">type</param>
        /// <returns>true if <paramref name="type" /> is a descendant of <paramref name="baseType" />, false otherwise</returns>
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
    }
}