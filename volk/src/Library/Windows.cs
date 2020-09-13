// Copyright 2020-2020 Volk Project
// Licensed under Apache License 2.0 or any later version
// Refer to the LICENSE.md file included.

using System;
using System.Runtime.InteropServices;

namespace Volk.Library {
    /// <summary>
    ///     Set of functions to manipulate windows libraries
    /// </summary>
    public static class Windows {
        private const string DllName = "kernel32.dll";
        public static readonly string[] VulkanDllNames = { "vulkan-1.dll" };

        [DllImport(DllName)]
        public static extern IntPtr LoadLibrary(string dllToLoad);

        [DllImport(DllName)]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

        [DllImport(DllName)]
        public static extern bool FreeLibrary(IntPtr hModule);
    }
}