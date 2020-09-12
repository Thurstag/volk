// Copyright 2020-2020 Volk Project
// Licensed under Apache License 2.0 or any later version
// Refer to the LICENSE.md file included.

using System;
using System.Runtime.InteropServices;
using System.Text;
using Volk.Library;
using Volk.Vulkan;

namespace Volk {
    /// <summary>
    /// Volk functions
    /// </summary>
    public static partial class Functions {
        private static LibraryHandle? _library;

        private delegate IntPtr LibraryLoader(string name);

        public delegate void LibraryDeleter(IntPtr library);

        private delegate IntPtr FunctionLoader(IntPtr library, string name);

        /// <summary>
        /// Initialize library by loading Vulkan loader, call this function before creating the Vulkan instance.
        /// </summary>
        /// <exception cref="Exception">Failed to load vkGetInstanceProcAddr function</exception>
        public static void Initialize() {
            IntPtr getInstanceProcAddrPtr;

            // Load getInstanceProcAddr function
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
                getInstanceProcAddrPtr = LoadGetInstanceProcAddr(Windows.VulkanDllNames, Windows.LoadLibrary, ptr => Windows.FreeLibrary(ptr),
                                                                 Windows.GetProcAddress);
            } else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) {
                getInstanceProcAddrPtr = LoadGetInstanceProcAddr(Linux.VulkanDllNames, name => Linux.dlopen(name, Linux.RTLD_LOCAL | Linux.RTLD_NOW),
                                                                 ptr => Linux.dlclose(ptr),
                                                                 Linux.dlsym);
            } else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) {
                getInstanceProcAddrPtr =
                    LoadGetInstanceProcAddr(OSX.VulkanDllNames, name => OSX.dlopen(name, OSX.RTLD_LOCAL | OSX.RTLD_NOW), ptr => OSX.dlclose(ptr),
                                            OSX.dlsym);
            } else {
                throw new Exception($"Unsupported operation system: {Environment.OSVersion.Platform}");
            }

            // Check getInstanceProcAddr
            CommandTable.GetInstanceProcAddr = FunctionPtrToDelegate<Commands.GetInstanceProcAddr>(getInstanceProcAddrPtr);
            if (CommandTable.GetInstanceProcAddr == null) {
                throw new Exception($"Failed to get {Volk.Library.Vulkan.GetInstanceProcAddrFuncName} function");
            }

            // Load functions
            unsafe {
                fixed (byte* funcName = &Encoding.UTF8.GetBytes(Volk.Library.Vulkan.CreateInstanceFuncName)[0]) {
                    CommandTable.CreateInstance =
                        FunctionPtrToDelegate<Commands.CreateInstance>(CommandTable.GetInstanceProcAddr(IntPtr.Zero, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes(Volk.Library.Vulkan.EnumerateInstanceExtensionPropertiesFuncName)[0]) {
                    CommandTable.EnumerateInstanceExtensionProperties =
                        FunctionPtrToDelegate<Commands.EnumerateInstanceExtensionProperties>(CommandTable.GetInstanceProcAddr(IntPtr.Zero, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes(Volk.Library.Vulkan.EnumerateInstanceLayerPropertiesFuncName)[0]) {
                    CommandTable.EnumerateInstanceLayerProperties =
                        FunctionPtrToDelegate<Commands.EnumerateInstanceLayerProperties>(CommandTable.GetInstanceProcAddr(IntPtr.Zero, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes(Volk.Library.Vulkan.EnumerateInstanceVersionFuncName)[0]) {
                    CommandTable.EnumerateInstanceVersion =
                        FunctionPtrToDelegate<Commands.EnumerateInstanceVersion>(CommandTable.GetInstanceProcAddr(IntPtr.Zero, funcName));
                }
            }
        }

        /// <summary>
        /// Free library previously loaded by <see cref="Initialize"/>
        /// </summary>
        public static void Destroy() {
            _library = null;
        }

        /// <summary>
        /// Try to load a library
        /// </summary>
        /// <param name="loader">Function to load a library</param>
        /// <param name="libraries">List of libraries</param>
        /// <returns>Library pointer or <see cref="IntPtr.Zero"/></returns>
        private static IntPtr TryToLoadLibrary(LibraryLoader loader, string[] libraries) {
            foreach (var library in libraries) {
                var lib = loader(library);

                if (lib != IntPtr.Zero) {
                    return lib;
                }
            }

            return IntPtr.Zero;
        }

        /// <summary>
        /// Load "vkGetInstanceProcAddr" function pointer
        /// </summary>
        /// <param name="libraries">List of libraries</param>
        /// <param name="libLoader">Function to load a library</param>
        /// <param name="deleter">Function to free library</param>
        /// <param name="funcLoader">Function to load a function from a library</param>
        /// <returns>Function pointer</returns>
        /// <exception cref="Exception">Failed to load any of the given libraries</exception>
        private static IntPtr LoadGetInstanceProcAddr(string[] libraries, LibraryLoader libLoader, LibraryDeleter deleter,
                                                      FunctionLoader funcLoader) {
            // Load dll
            var library = TryToLoadLibrary(libLoader, libraries);
            if (library == IntPtr.Zero) {
                throw new Exception($"Failed to load any of the following libraries: {string.Join(", ", libraries)}");
            }

            // Save library
            _library = new LibraryHandle(library, deleter);

            // Load vkGetInstanceProcAddr function
            return funcLoader(library, Volk.Library.Vulkan.GetInstanceProcAddrFuncName);
        }

        /// <summary>
        /// Convert a function pointer into a delegate
        /// </summary>
        /// <param name="function">Function pointer</param>
        /// <typeparam name="T">Delegate type</typeparam>
        /// <returns>Delegate if <paramref name="function"/> is a valid pointer or null otherwise</returns>
        private static T? FunctionPtrToDelegate<T>(IntPtr? function) where T : Delegate {
            if (function == null || function == IntPtr.Zero) {
                return null;
            }

            return Marshal.GetDelegateForFunctionPointer<T>(function.Value);
        }
    }
}