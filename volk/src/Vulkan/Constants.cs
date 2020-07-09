// Copyright 2020-2020 Volk Project
// Licensed under Apache License 2.0 or any later version
// Refer to the LICENSE.md file included.

namespace Volk.Vulkan {
	public class Constants {
		public const int MaxPhysicalDeviceNameSize = 256;
		public const int UuidSize = 16;
		public const int LuidSize = 8;
		public const int LuidSizeKhr = LuidSize;
		public const int MaxExtensionNameSize = 256;
		public const int MaxDescriptionSize = 256;
		public const int MaxMemoryTypes = 32;
		public const int MaxMemoryHeaps = 16;
		public const float LodClampNone = 1000.0f;
		public const ushort RemainingMipLevels = unchecked((ushort) (~0U));
		public const ushort RemainingArrayLayers = unchecked((ushort) (~0U));
		public const ulong WholeSize = (~0UL);
		public const ushort AttachmentUnused = unchecked((ushort) (~0U));
		public const int True = 1;
		public const int False = 0;
		public const ushort QueueFamilyIgnored = unchecked((ushort) (~0U));
		public const ushort QueueFamilyExternal = unchecked((ushort) (~0U-1));
		public const ushort QueueFamilyExternalKhr = QueueFamilyExternal;
		public const ushort QueueFamilyForeignExt = unchecked((ushort) (~0U-2));
		public const ushort SubpassExternal = unchecked((ushort) (~0U));
		public const int MaxDeviceGroupSize = 32;
		public const int MaxDeviceGroupSizeKhr = MaxDeviceGroupSize;
		public const int MaxDriverNameSize = 256;
		public const int MaxDriverNameSizeKhr = MaxDriverNameSize;
		public const int MaxDriverInfoSize = 256;
		public const int MaxDriverInfoSizeKhr = MaxDriverInfoSize;
		public const ushort ShaderUnusedKhr = unchecked((ushort) (~0U));
		public const ushort ShaderUnusedNv = ShaderUnusedKhr;
	}

}
