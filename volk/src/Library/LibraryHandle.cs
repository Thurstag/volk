// Copyright 2020-2020 Volk Project
// Licensed under Apache License 2.0 or any later version
// Refer to the LICENSE.md file included.

using System;

namespace Volk.Library {
    /// <summary>
    ///     Managed pointer to a library
    /// </summary>
    public class LibraryHandle {
        private readonly Functions.LibraryDeleter _deleter;
        private readonly IntPtr _handle;

        /// <summary>
        ///     Constructor
        /// </summary>
        /// <param name="handle">Pointer to a dynamically loaded library</param>
        /// <param name="deleter">Function to free library automatically</param>
        public LibraryHandle(IntPtr handle, Functions.LibraryDeleter deleter) {
            _handle = handle;
            _deleter = deleter;
        }

        /// <summary>
        ///     Destructor
        /// </summary>
        ~LibraryHandle() {
            _deleter(_handle);
        }
    }
}