// Copyright 2020-2020 Volk Project
// Licensed under Apache License 2.0 or any later version
// Refer to the LICENSE.md file included.

using System;
using System.Runtime.InteropServices;

namespace Volk.Library {
    /// <summary>
    /// Set of functions to manipulate linux libraries
    /// </summary>
    public static class Linux {
        private const string DllName = "libdl.so";
        public const int RTLD_LOCAL = 0;
        public const int RTLD_NOW = 0x00002;
        public static readonly string[] VulkanDllNames = {"libvulkan.so.1", "libvulkan.so"};

        [DllImport(DllName)]
        public static extern IntPtr dlopen(string filename, int flags);

        [DllImport(DllName)]
        public static extern IntPtr dlsym(IntPtr handle, string symbol);

        [DllImport(DllName)]
        public static extern IntPtr dlclose(IntPtr handle);
    }
}