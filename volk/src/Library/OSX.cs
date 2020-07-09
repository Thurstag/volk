// Copyright 2020-2020 Volk Project
// Licensed under Apache License 2.0 or any later version
// Refer to the LICENSE.md file included.

using System;
using System.Runtime.InteropServices;

namespace Volk.Library {
    /// <summary>
    /// Set of functions to manipulate macOS libraries
    /// </summary>
    public class OSX {
        private const string DllName = "libdl.dylib";
        public const int RTLD_LOCAL = 0;
        public const int RTLD_NOW = 0x00002;
        public static readonly string[] VulkanDllNames = {"libvulkan.dylib", "libvulkan.1.dylib", "libMoltenVK.dylib"};
        
        [DllImport(DllName)]
        public static extern IntPtr dlopen(String fileName, int flags);
        
        [DllImport(DllName)]
        public static extern IntPtr dlsym(IntPtr handle, string symbol);

        [DllImport(DllName)]
        public static extern IntPtr dlclose(IntPtr handle);
    }
}