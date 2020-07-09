// Copyright 2020-2020 Volk Project
// Licensed under Apache License 2.0 or any later version
// Refer to the LICENSE.md file included.

namespace Volk.Vulkan.Types {
    public struct SECURITY_ATTRIBUTES {
        public uint nLength;
        public unsafe void* lpSecurityDescriptor;
        public int bInheritHandle;
    }
}