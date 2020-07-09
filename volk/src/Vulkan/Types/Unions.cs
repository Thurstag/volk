// Copyright 2020-2020 Volk Project
// Licensed under Apache License 2.0 or any later version
// Refer to the LICENSE.md file included.

using System.Runtime.InteropServices;
using SampleMask = System.UInt32;
using Bool32 = System.UInt32;
using Flags = System.UInt32;
using DeviceSize = System.UInt64;
using DeviceAddress = System.UInt64;

namespace Volk.Vulkan.Types {
	[StructLayout(LayoutKind.Explicit)]
	public struct ClearColorValue {
		[FieldOffset(0)] public unsafe fixed float float32[4];
		[FieldOffset(0)] public unsafe fixed int int32[4];
		[FieldOffset(0)] public unsafe fixed uint uint32[4];
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ClearValue {
		[FieldOffset(0)] public unsafe ClearColorValue color;
		[FieldOffset(0)] public unsafe ClearDepthStencilValue depthStencil;
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct PerformanceCounterResultKHR {
		[FieldOffset(0)] public unsafe int int32;
		[FieldOffset(0)] public unsafe long int64;
		[FieldOffset(0)] public unsafe uint uint32;
		[FieldOffset(0)] public unsafe ulong uint64;
		[FieldOffset(0)] public unsafe float float32;
		[FieldOffset(0)] public unsafe double float64;
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct PerformanceValueDataINTEL {
		[FieldOffset(0)] public unsafe uint value32;
		[FieldOffset(0)] public unsafe ulong value64;
		[FieldOffset(0)] public unsafe float valueFloat;
		[FieldOffset(0)] public unsafe Bool32 valueBool;
		[FieldOffset(0)] public unsafe byte* valueString;
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct PipelineExecutableStatisticValueKHR {
		[FieldOffset(0)] public unsafe Bool32 b32;
		[FieldOffset(0)] public unsafe long i64;
		[FieldOffset(0)] public unsafe ulong u64;
		[FieldOffset(0)] public unsafe double f64;
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct DeviceOrHostAddressKHR {
		[FieldOffset(0)] public unsafe DeviceAddress deviceAddress;
		[FieldOffset(0)] public unsafe void* hostAddress;
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct DeviceOrHostAddressConstKHR {
		[FieldOffset(0)] public unsafe DeviceAddress deviceAddress;
		[FieldOffset(0)] public unsafe void* hostAddress;
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct AccelerationStructureGeometryDataKHR {
		[FieldOffset(0)] public unsafe AccelerationStructureGeometryTrianglesDataKHR triangles;
		[FieldOffset(0)] public unsafe AccelerationStructureGeometryAabbsDataKHR aabbs;
		[FieldOffset(0)] public unsafe AccelerationStructureGeometryInstancesDataKHR instances;
	}
}
