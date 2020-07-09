// Copyright 2020-2020 Volk Project
// Licensed under Apache License 2.0 or any later version
// Refer to the LICENSE.md file included.

using DotNetCross.NativeInts;
using IntPtr = System.IntPtr;

using SampleMask = System.UInt32;
using Bool32 = System.UInt32;
using Flags = System.UInt32;
using DeviceSize = System.UInt64;
using DeviceAddress = System.UInt64;

using Instance = System.IntPtr;
using PhysicalDevice = System.IntPtr;
using Device = System.IntPtr;
using Queue = System.IntPtr;
using CommandBuffer = System.IntPtr;
using DeviceMemory = System.IntPtr;
using CommandPool = System.IntPtr;
using Buffer = System.IntPtr;
using BufferView = System.IntPtr;
using Image = System.IntPtr;
using ImageView = System.IntPtr;
using ShaderModule = System.IntPtr;
using Pipeline = System.IntPtr;
using PipelineLayout = System.IntPtr;
using Sampler = System.IntPtr;
using DescriptorSet = System.IntPtr;
using DescriptorSetLayout = System.IntPtr;
using DescriptorPool = System.IntPtr;
using Fence = System.IntPtr;
using Semaphore = System.IntPtr;
using Event = System.IntPtr;
using QueryPool = System.IntPtr;
using Framebuffer = System.IntPtr;
using RenderPass = System.IntPtr;
using PipelineCache = System.IntPtr;
using IndirectCommandsLayoutNV = System.IntPtr;
using DescriptorUpdateTemplate = System.IntPtr;
using DescriptorUpdateTemplateKHR = System.IntPtr;
using SamplerYcbcrConversion = System.IntPtr;
using SamplerYcbcrConversionKHR = System.IntPtr;
using ValidationCacheEXT = System.IntPtr;
using AccelerationStructureKHR = System.IntPtr;
using AccelerationStructureNV = System.IntPtr;
using PerformanceConfigurationINTEL = System.IntPtr;
using DeferredOperationKHR = System.IntPtr;
using PrivateDataSlotEXT = System.IntPtr;
using DisplayKHR = System.IntPtr;
using DisplayModeKHR = System.IntPtr;
using SurfaceKHR = System.IntPtr;
using SwapchainKHR = System.IntPtr;
using DebugReportCallbackEXT = System.IntPtr;
using DebugUtilsMessengerEXT = System.IntPtr;

using DescriptorUpdateTemplateTypeKHR = Volk.Vulkan.Types.DescriptorUpdateTemplateType;
using PointClippingBehaviorKHR = Volk.Vulkan.Types.PointClippingBehavior;
using ResolveModeFlagsKHR = Volk.Vulkan.Types.ResolveModeFlags;
using DescriptorBindingFlagsEXT = Volk.Vulkan.Types.DescriptorBindingFlags;
using SemaphoreTypeKHR = Volk.Vulkan.Types.SemaphoreType;
using GeometryFlagsNV = Volk.Vulkan.Types.GeometryFlagsKHR;
using GeometryInstanceFlagsNV = Volk.Vulkan.Types.GeometryInstanceFlagsKHR;
using BuildAccelerationStructureFlagsNV = Volk.Vulkan.Types.BuildAccelerationStructureFlagsKHR;
using CopyAccelerationStructureModeNV = Volk.Vulkan.Types.CopyAccelerationStructureModeKHR;
using AccelerationStructureTypeNV = Volk.Vulkan.Types.AccelerationStructureTypeKHR;
using GeometryTypeNV = Volk.Vulkan.Types.GeometryTypeKHR;
using RayTracingShaderGroupTypeNV = Volk.Vulkan.Types.RayTracingShaderGroupTypeKHR;
using AccelerationStructureMemoryRequirementsTypeNV = Volk.Vulkan.Types.AccelerationStructureMemoryRequirementsTypeKHR;
using SemaphoreWaitFlagsKHR = Volk.Vulkan.Types.SemaphoreWaitFlags;
using ExternalMemoryHandleTypeFlagsKHR = Volk.Vulkan.Types.ExternalMemoryHandleTypeFlags;
using ExternalMemoryFeatureFlagsKHR = Volk.Vulkan.Types.ExternalMemoryFeatureFlags;
using ExternalSemaphoreHandleTypeFlagsKHR = Volk.Vulkan.Types.ExternalSemaphoreHandleTypeFlags;
using ExternalSemaphoreFeatureFlagsKHR = Volk.Vulkan.Types.ExternalSemaphoreFeatureFlags;
using SemaphoreImportFlagsKHR = Volk.Vulkan.Types.SemaphoreImportFlags;
using ExternalFenceHandleTypeFlagsKHR = Volk.Vulkan.Types.ExternalFenceHandleTypeFlags;
using ExternalFenceFeatureFlagsKHR = Volk.Vulkan.Types.ExternalFenceFeatureFlags;
using FenceImportFlagsKHR = Volk.Vulkan.Types.FenceImportFlags;
using PeerMemoryFeatureFlagsKHR = Volk.Vulkan.Types.PeerMemoryFeatureFlags;
using MemoryAllocateFlagsKHR = Volk.Vulkan.Types.MemoryAllocateFlags;
using TessellationDomainOriginKHR = Volk.Vulkan.Types.TessellationDomainOrigin;
using SamplerYcbcrModelConversionKHR = Volk.Vulkan.Types.SamplerYcbcrModelConversion;
using SamplerYcbcrRangeKHR = Volk.Vulkan.Types.SamplerYcbcrRange;
using ChromaLocationKHR = Volk.Vulkan.Types.ChromaLocation;
using SamplerReductionModeEXT = Volk.Vulkan.Types.SamplerReductionMode;
using ShaderFloatControlsIndependenceKHR = Volk.Vulkan.Types.ShaderFloatControlsIndependence;
using DriverIdKHR = Volk.Vulkan.Types.DriverId;
using PhysicalDeviceFeatures2KHR = Volk.Vulkan.Types.PhysicalDeviceFeatures2;
using PhysicalDeviceProperties2KHR = Volk.Vulkan.Types.PhysicalDeviceProperties2;
using FormatProperties2KHR = Volk.Vulkan.Types.FormatProperties2;
using ImageFormatProperties2KHR = Volk.Vulkan.Types.ImageFormatProperties2;
using PhysicalDeviceImageFormatInfo2KHR = Volk.Vulkan.Types.PhysicalDeviceImageFormatInfo2;
using QueueFamilyProperties2KHR = Volk.Vulkan.Types.QueueFamilyProperties2;
using PhysicalDeviceMemoryProperties2KHR = Volk.Vulkan.Types.PhysicalDeviceMemoryProperties2;
using SparseImageFormatProperties2KHR = Volk.Vulkan.Types.SparseImageFormatProperties2;
using PhysicalDeviceSparseImageFormatInfo2KHR = Volk.Vulkan.Types.PhysicalDeviceSparseImageFormatInfo2;
using ConformanceVersionKHR = Volk.Vulkan.Types.ConformanceVersion;
using PhysicalDeviceDriverPropertiesKHR = Volk.Vulkan.Types.PhysicalDeviceDriverProperties;
using PhysicalDeviceVariablePointersFeaturesKHR = Volk.Vulkan.Types.PhysicalDeviceVariablePointersFeatures;
using PhysicalDeviceVariablePointerFeaturesKHR = Volk.Vulkan.Types.PhysicalDeviceVariablePointersFeatures;
using PhysicalDeviceVariablePointerFeatures = Volk.Vulkan.Types.PhysicalDeviceVariablePointersFeatures;
using ExternalMemoryPropertiesKHR = Volk.Vulkan.Types.ExternalMemoryProperties;
using PhysicalDeviceExternalImageFormatInfoKHR = Volk.Vulkan.Types.PhysicalDeviceExternalImageFormatInfo;
using ExternalImageFormatPropertiesKHR = Volk.Vulkan.Types.ExternalImageFormatProperties;
using PhysicalDeviceExternalBufferInfoKHR = Volk.Vulkan.Types.PhysicalDeviceExternalBufferInfo;
using ExternalBufferPropertiesKHR = Volk.Vulkan.Types.ExternalBufferProperties;
using PhysicalDeviceIDPropertiesKHR = Volk.Vulkan.Types.PhysicalDeviceIDProperties;
using ExternalMemoryImageCreateInfoKHR = Volk.Vulkan.Types.ExternalMemoryImageCreateInfo;
using ExternalMemoryBufferCreateInfoKHR = Volk.Vulkan.Types.ExternalMemoryBufferCreateInfo;
using ExportMemoryAllocateInfoKHR = Volk.Vulkan.Types.ExportMemoryAllocateInfo;
using PhysicalDeviceExternalSemaphoreInfoKHR = Volk.Vulkan.Types.PhysicalDeviceExternalSemaphoreInfo;
using ExternalSemaphorePropertiesKHR = Volk.Vulkan.Types.ExternalSemaphoreProperties;
using ExportSemaphoreCreateInfoKHR = Volk.Vulkan.Types.ExportSemaphoreCreateInfo;
using PhysicalDeviceExternalFenceInfoKHR = Volk.Vulkan.Types.PhysicalDeviceExternalFenceInfo;
using ExternalFencePropertiesKHR = Volk.Vulkan.Types.ExternalFenceProperties;
using ExportFenceCreateInfoKHR = Volk.Vulkan.Types.ExportFenceCreateInfo;
using PhysicalDeviceMultiviewFeaturesKHR = Volk.Vulkan.Types.PhysicalDeviceMultiviewFeatures;
using PhysicalDeviceMultiviewPropertiesKHR = Volk.Vulkan.Types.PhysicalDeviceMultiviewProperties;
using RenderPassMultiviewCreateInfoKHR = Volk.Vulkan.Types.RenderPassMultiviewCreateInfo;
using PhysicalDeviceGroupPropertiesKHR = Volk.Vulkan.Types.PhysicalDeviceGroupProperties;
using MemoryAllocateFlagsInfoKHR = Volk.Vulkan.Types.MemoryAllocateFlagsInfo;
using BindBufferMemoryInfoKHR = Volk.Vulkan.Types.BindBufferMemoryInfo;
using BindBufferMemoryDeviceGroupInfoKHR = Volk.Vulkan.Types.BindBufferMemoryDeviceGroupInfo;
using BindImageMemoryInfoKHR = Volk.Vulkan.Types.BindImageMemoryInfo;
using BindImageMemoryDeviceGroupInfoKHR = Volk.Vulkan.Types.BindImageMemoryDeviceGroupInfo;
using DeviceGroupRenderPassBeginInfoKHR = Volk.Vulkan.Types.DeviceGroupRenderPassBeginInfo;
using DeviceGroupCommandBufferBeginInfoKHR = Volk.Vulkan.Types.DeviceGroupCommandBufferBeginInfo;
using DeviceGroupSubmitInfoKHR = Volk.Vulkan.Types.DeviceGroupSubmitInfo;
using DeviceGroupBindSparseInfoKHR = Volk.Vulkan.Types.DeviceGroupBindSparseInfo;
using DeviceGroupDeviceCreateInfoKHR = Volk.Vulkan.Types.DeviceGroupDeviceCreateInfo;
using DescriptorUpdateTemplateEntryKHR = Volk.Vulkan.Types.DescriptorUpdateTemplateEntry;
using DescriptorUpdateTemplateCreateInfoKHR = Volk.Vulkan.Types.DescriptorUpdateTemplateCreateInfo;
using InputAttachmentAspectReferenceKHR = Volk.Vulkan.Types.InputAttachmentAspectReference;
using RenderPassInputAttachmentAspectCreateInfoKHR = Volk.Vulkan.Types.RenderPassInputAttachmentAspectCreateInfo;
using PhysicalDevice16BitStorageFeaturesKHR = Volk.Vulkan.Types.PhysicalDevice16BitStorageFeatures;
using PhysicalDeviceShaderSubgroupExtendedTypesFeaturesKHR = Volk.Vulkan.Types.PhysicalDeviceShaderSubgroupExtendedTypesFeatures;
using BufferMemoryRequirementsInfo2KHR = Volk.Vulkan.Types.BufferMemoryRequirementsInfo2;
using ImageMemoryRequirementsInfo2KHR = Volk.Vulkan.Types.ImageMemoryRequirementsInfo2;
using ImageSparseMemoryRequirementsInfo2KHR = Volk.Vulkan.Types.ImageSparseMemoryRequirementsInfo2;
using MemoryRequirements2KHR = Volk.Vulkan.Types.MemoryRequirements2;
using SparseImageMemoryRequirements2KHR = Volk.Vulkan.Types.SparseImageMemoryRequirements2;
using PhysicalDevicePointClippingPropertiesKHR = Volk.Vulkan.Types.PhysicalDevicePointClippingProperties;
using MemoryDedicatedRequirementsKHR = Volk.Vulkan.Types.MemoryDedicatedRequirements;
using MemoryDedicatedAllocateInfoKHR = Volk.Vulkan.Types.MemoryDedicatedAllocateInfo;
using ImageViewUsageCreateInfoKHR = Volk.Vulkan.Types.ImageViewUsageCreateInfo;
using PipelineTessellationDomainOriginStateCreateInfoKHR = Volk.Vulkan.Types.PipelineTessellationDomainOriginStateCreateInfo;
using SamplerYcbcrConversionInfoKHR = Volk.Vulkan.Types.SamplerYcbcrConversionInfo;
using SamplerYcbcrConversionCreateInfoKHR = Volk.Vulkan.Types.SamplerYcbcrConversionCreateInfo;
using BindImagePlaneMemoryInfoKHR = Volk.Vulkan.Types.BindImagePlaneMemoryInfo;
using ImagePlaneMemoryRequirementsInfoKHR = Volk.Vulkan.Types.ImagePlaneMemoryRequirementsInfo;
using PhysicalDeviceSamplerYcbcrConversionFeaturesKHR = Volk.Vulkan.Types.PhysicalDeviceSamplerYcbcrConversionFeatures;
using SamplerYcbcrConversionImageFormatPropertiesKHR = Volk.Vulkan.Types.SamplerYcbcrConversionImageFormatProperties;
using PhysicalDeviceSamplerFilterMinmaxPropertiesEXT = Volk.Vulkan.Types.PhysicalDeviceSamplerFilterMinmaxProperties;
using SamplerReductionModeCreateInfoEXT = Volk.Vulkan.Types.SamplerReductionModeCreateInfo;
using ImageFormatListCreateInfoKHR = Volk.Vulkan.Types.ImageFormatListCreateInfo;
using PhysicalDeviceMaintenance3PropertiesKHR = Volk.Vulkan.Types.PhysicalDeviceMaintenance3Properties;
using DescriptorSetLayoutSupportKHR = Volk.Vulkan.Types.DescriptorSetLayoutSupport;
using PhysicalDeviceShaderDrawParameterFeatures = Volk.Vulkan.Types.PhysicalDeviceShaderDrawParametersFeatures;
using PhysicalDeviceShaderFloat16Int8FeaturesKHR = Volk.Vulkan.Types.PhysicalDeviceShaderFloat16Int8Features;
using PhysicalDeviceFloat16Int8FeaturesKHR = Volk.Vulkan.Types.PhysicalDeviceShaderFloat16Int8Features;
using PhysicalDeviceFloatControlsPropertiesKHR = Volk.Vulkan.Types.PhysicalDeviceFloatControlsProperties;
using PhysicalDeviceHostQueryResetFeaturesEXT = Volk.Vulkan.Types.PhysicalDeviceHostQueryResetFeatures;
using PhysicalDeviceDescriptorIndexingFeaturesEXT = Volk.Vulkan.Types.PhysicalDeviceDescriptorIndexingFeatures;
using PhysicalDeviceDescriptorIndexingPropertiesEXT = Volk.Vulkan.Types.PhysicalDeviceDescriptorIndexingProperties;
using DescriptorSetLayoutBindingFlagsCreateInfoEXT = Volk.Vulkan.Types.DescriptorSetLayoutBindingFlagsCreateInfo;
using DescriptorSetVariableDescriptorCountAllocateInfoEXT = Volk.Vulkan.Types.DescriptorSetVariableDescriptorCountAllocateInfo;
using DescriptorSetVariableDescriptorCountLayoutSupportEXT = Volk.Vulkan.Types.DescriptorSetVariableDescriptorCountLayoutSupport;
using AttachmentDescription2KHR = Volk.Vulkan.Types.AttachmentDescription2;
using AttachmentReference2KHR = Volk.Vulkan.Types.AttachmentReference2;
using SubpassDescription2KHR = Volk.Vulkan.Types.SubpassDescription2;
using SubpassDependency2KHR = Volk.Vulkan.Types.SubpassDependency2;
using RenderPassCreateInfo2KHR = Volk.Vulkan.Types.RenderPassCreateInfo2;
using SubpassBeginInfoKHR = Volk.Vulkan.Types.SubpassBeginInfo;
using SubpassEndInfoKHR = Volk.Vulkan.Types.SubpassEndInfo;
using PhysicalDeviceTimelineSemaphoreFeaturesKHR = Volk.Vulkan.Types.PhysicalDeviceTimelineSemaphoreFeatures;
using PhysicalDeviceTimelineSemaphorePropertiesKHR = Volk.Vulkan.Types.PhysicalDeviceTimelineSemaphoreProperties;
using SemaphoreTypeCreateInfoKHR = Volk.Vulkan.Types.SemaphoreTypeCreateInfo;
using TimelineSemaphoreSubmitInfoKHR = Volk.Vulkan.Types.TimelineSemaphoreSubmitInfo;
using SemaphoreWaitInfoKHR = Volk.Vulkan.Types.SemaphoreWaitInfo;
using SemaphoreSignalInfoKHR = Volk.Vulkan.Types.SemaphoreSignalInfo;
using PhysicalDevice8BitStorageFeaturesKHR = Volk.Vulkan.Types.PhysicalDevice8BitStorageFeatures;
using PhysicalDeviceVulkanMemoryModelFeaturesKHR = Volk.Vulkan.Types.PhysicalDeviceVulkanMemoryModelFeatures;
using PhysicalDeviceShaderAtomicInt64FeaturesKHR = Volk.Vulkan.Types.PhysicalDeviceShaderAtomicInt64Features;
using PhysicalDeviceDepthStencilResolvePropertiesKHR = Volk.Vulkan.Types.PhysicalDeviceDepthStencilResolveProperties;
using SubpassDescriptionDepthStencilResolveKHR = Volk.Vulkan.Types.SubpassDescriptionDepthStencilResolve;
using BindAccelerationStructureMemoryInfoNV = Volk.Vulkan.Types.BindAccelerationStructureMemoryInfoKHR;
using WriteDescriptorSetAccelerationStructureNV = Volk.Vulkan.Types.WriteDescriptorSetAccelerationStructureKHR;
using ImageStencilUsageCreateInfoEXT = Volk.Vulkan.Types.ImageStencilUsageCreateInfo;
using PhysicalDeviceScalarBlockLayoutFeaturesEXT = Volk.Vulkan.Types.PhysicalDeviceScalarBlockLayoutFeatures;
using PhysicalDeviceUniformBufferStandardLayoutFeaturesKHR = Volk.Vulkan.Types.PhysicalDeviceUniformBufferStandardLayoutFeatures;
using PhysicalDeviceBufferDeviceAddressFeaturesKHR = Volk.Vulkan.Types.PhysicalDeviceBufferDeviceAddressFeatures;
using PhysicalDeviceBufferAddressFeaturesEXT = Volk.Vulkan.Types.PhysicalDeviceBufferDeviceAddressFeaturesEXT;
using BufferDeviceAddressInfoKHR = Volk.Vulkan.Types.BufferDeviceAddressInfo;
using BufferDeviceAddressInfoEXT = Volk.Vulkan.Types.BufferDeviceAddressInfo;
using BufferOpaqueCaptureAddressCreateInfoKHR = Volk.Vulkan.Types.BufferOpaqueCaptureAddressCreateInfo;
using PhysicalDeviceImagelessFramebufferFeaturesKHR = Volk.Vulkan.Types.PhysicalDeviceImagelessFramebufferFeatures;
using FramebufferAttachmentsCreateInfoKHR = Volk.Vulkan.Types.FramebufferAttachmentsCreateInfo;
using FramebufferAttachmentImageInfoKHR = Volk.Vulkan.Types.FramebufferAttachmentImageInfo;
using RenderPassAttachmentBeginInfoKHR = Volk.Vulkan.Types.RenderPassAttachmentBeginInfo;
using QueryPoolCreateInfoINTEL = Volk.Vulkan.Types.QueryPoolPerformanceQueryCreateInfoINTEL;
using PhysicalDeviceSeparateDepthStencilLayoutsFeaturesKHR = Volk.Vulkan.Types.PhysicalDeviceSeparateDepthStencilLayoutsFeatures;
using AttachmentReferenceStencilLayoutKHR = Volk.Vulkan.Types.AttachmentReferenceStencilLayout;
using AttachmentDescriptionStencilLayoutKHR = Volk.Vulkan.Types.AttachmentDescriptionStencilLayout;
using MemoryOpaqueCaptureAddressAllocateInfoKHR = Volk.Vulkan.Types.MemoryOpaqueCaptureAddressAllocateInfo;
using DeviceMemoryOpaqueCaptureAddressInfoKHR = Volk.Vulkan.Types.DeviceMemoryOpaqueCaptureAddressInfo;
using AabbPositionsNV = Volk.Vulkan.Types.AabbPositionsKHR;
using TransformMatrixNV = Volk.Vulkan.Types.TransformMatrixKHR;
using AccelerationStructureInstanceNV = Volk.Vulkan.Types.AccelerationStructureInstanceKHR;

namespace Volk.Vulkan.Types {
	public struct BaseOutStructure {
		public unsafe StructureType sType;
		public unsafe BaseOutStructure* next;
	}

	public struct BaseInStructure {
		public unsafe StructureType sType;
		public unsafe BaseInStructure* next;
	}

	public struct Offset2D {
		public unsafe int x;
		public unsafe int y;
	}

	public struct Offset3D {
		public unsafe int x;
		public unsafe int y;
		public unsafe int z;
	}

	public struct Extent2D {
		public unsafe uint width;
		public unsafe uint height;
	}

	public struct Extent3D {
		public unsafe uint width;
		public unsafe uint height;
		public unsafe uint depth;
	}

	public struct Viewport {
		public unsafe float x;
		public unsafe float y;
		public unsafe float width;
		public unsafe float height;
		public unsafe float minDepth;
		public unsafe float maxDepth;
	}

	public struct Rect2D {
		public unsafe Offset2D offset;
		public unsafe Extent2D extent;
	}

	public struct ClearRect {
		public unsafe Rect2D rect;
		public unsafe uint baseArrayLayer;
		public unsafe uint layerCount;
	}

	public struct ComponentMapping {
		public unsafe ComponentSwizzle r;
		public unsafe ComponentSwizzle g;
		public unsafe ComponentSwizzle b;
		public unsafe ComponentSwizzle a;
	}

	public struct PhysicalDeviceProperties {
		public unsafe uint apiVersion;
		public unsafe uint driverVersion;
		public unsafe uint vendorID;
		public unsafe uint deviceID;
		public unsafe PhysicalDeviceType deviceType;
		public unsafe fixed byte deviceName[Constants.MaxPhysicalDeviceNameSize];
		public unsafe fixed byte pipelineCacheUUID[Constants.UuidSize];
		public unsafe PhysicalDeviceLimits limits;
		public unsafe PhysicalDeviceSparseProperties sparseProperties;
	}

	public struct ExtensionProperties {
		public unsafe fixed byte extensionName[Constants.MaxExtensionNameSize];
		public unsafe uint specVersion;
	}

	public struct LayerProperties {
		public unsafe fixed byte layerName[Constants.MaxExtensionNameSize];
		public unsafe uint specVersion;
		public unsafe uint implementationVersion;
		public unsafe fixed byte description[Constants.MaxDescriptionSize];
	}

	public struct ApplicationInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe byte* applicationName;
		public unsafe uint applicationVersion;
		public unsafe byte* engineName;
		public unsafe uint engineVersion;
		public unsafe uint apiVersion;
	}

	public struct AllocationCallbacks {
		public unsafe void* userData;
		public unsafe IntPtr pfnAllocation;
		public unsafe IntPtr pfnReallocation;
		public unsafe IntPtr pfnFree;
		public unsafe IntPtr pfnInternalAllocation;
		public unsafe IntPtr pfnInternalFree;
	}

	public struct DeviceQueueCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DeviceQueueCreateFlags flags;
		public unsafe uint queueFamilyIndex;
		public unsafe uint queueCount;
		public unsafe float* queuePriorities;
	}

	public struct DeviceCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DeviceCreateFlags flags;
		public unsafe uint queueCreateInfoCount;
		public unsafe DeviceQueueCreateInfo* queueCreateInfos;
		public unsafe uint enabledLayerCount;
		public unsafe byte** enabledLayerNames;
		public unsafe uint enabledExtensionCount;
		public unsafe byte** enabledExtensionNames;
		public unsafe PhysicalDeviceFeatures* enabledFeatures;
	}

	public struct InstanceCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe InstanceCreateFlags flags;
		public unsafe ApplicationInfo* applicationInfo;
		public unsafe uint enabledLayerCount;
		public unsafe byte** enabledLayerNames;
		public unsafe uint enabledExtensionCount;
		public unsafe byte** enabledExtensionNames;
	}

	public struct QueueFamilyProperties {
		public unsafe QueueFlags queueFlags;
		public unsafe uint queueCount;
		public unsafe uint timestampValidBits;
		public unsafe Extent3D minImageTransferGranularity;
	}

	public struct PhysicalDeviceMemoryProperties {
		public unsafe uint memoryTypeCount;
		public MemoryType memoryTypes_0;
		public MemoryType memoryTypes_1;
		public MemoryType memoryTypes_2;
		public MemoryType memoryTypes_3;
		public MemoryType memoryTypes_4;
		public MemoryType memoryTypes_5;
		public MemoryType memoryTypes_6;
		public MemoryType memoryTypes_7;
		public MemoryType memoryTypes_8;
		public MemoryType memoryTypes_9;
		public MemoryType memoryTypes_10;
		public MemoryType memoryTypes_11;
		public MemoryType memoryTypes_12;
		public MemoryType memoryTypes_13;
		public MemoryType memoryTypes_14;
		public MemoryType memoryTypes_15;
		public MemoryType memoryTypes_16;
		public MemoryType memoryTypes_17;
		public MemoryType memoryTypes_18;
		public MemoryType memoryTypes_19;
		public MemoryType memoryTypes_20;
		public MemoryType memoryTypes_21;
		public MemoryType memoryTypes_22;
		public MemoryType memoryTypes_23;
		public MemoryType memoryTypes_24;
		public MemoryType memoryTypes_25;
		public MemoryType memoryTypes_26;
		public MemoryType memoryTypes_27;
		public MemoryType memoryTypes_28;
		public MemoryType memoryTypes_29;
		public MemoryType memoryTypes_30;
		public MemoryType memoryTypes_31;
		public unsafe uint memoryHeapCount;
		public MemoryHeap memoryHeaps_0;
		public MemoryHeap memoryHeaps_1;
		public MemoryHeap memoryHeaps_2;
		public MemoryHeap memoryHeaps_3;
		public MemoryHeap memoryHeaps_4;
		public MemoryHeap memoryHeaps_5;
		public MemoryHeap memoryHeaps_6;
		public MemoryHeap memoryHeaps_7;
		public MemoryHeap memoryHeaps_8;
		public MemoryHeap memoryHeaps_9;
		public MemoryHeap memoryHeaps_10;
		public MemoryHeap memoryHeaps_11;
		public MemoryHeap memoryHeaps_12;
		public MemoryHeap memoryHeaps_13;
		public MemoryHeap memoryHeaps_14;
		public MemoryHeap memoryHeaps_15;
	}

	public struct MemoryAllocateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DeviceSize allocationSize;
		public unsafe uint memoryTypeIndex;
	}

	public struct MemoryRequirements {
		public unsafe DeviceSize size;
		public unsafe DeviceSize alignment;
		public unsafe uint memoryTypeBits;
	}

	public struct SparseImageFormatProperties {
		public unsafe ImageAspectFlags aspectMask;
		public unsafe Extent3D imageGranularity;
		public unsafe SparseImageFormatFlags flags;
	}

	public struct SparseImageMemoryRequirements {
		public unsafe SparseImageFormatProperties formatProperties;
		public unsafe uint imageMipTailFirstLod;
		public unsafe DeviceSize imageMipTailSize;
		public unsafe DeviceSize imageMipTailOffset;
		public unsafe DeviceSize imageMipTailStride;
	}

	public struct MemoryType {
		public unsafe MemoryPropertyFlags propertyFlags;
		public unsafe uint heapIndex;
	}

	public struct MemoryHeap {
		public unsafe DeviceSize size;
		public unsafe MemoryHeapFlags flags;
	}

	public struct MappedMemoryRange {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DeviceMemory memory;
		public unsafe DeviceSize offset;
		public unsafe DeviceSize size;
	}

	public struct FormatProperties {
		public unsafe FormatFeatureFlags linearTilingFeatures;
		public unsafe FormatFeatureFlags optimalTilingFeatures;
		public unsafe FormatFeatureFlags bufferFeatures;
	}

	public struct ImageFormatProperties {
		public unsafe Extent3D maxExtent;
		public unsafe uint maxMipLevels;
		public unsafe uint maxArrayLayers;
		public unsafe SampleCountFlags sampleCounts;
		public unsafe DeviceSize maxResourceSize;
	}

	public struct DescriptorBufferInfo {
		public unsafe Buffer buffer;
		public unsafe DeviceSize offset;
		public unsafe DeviceSize range;
	}

	public struct DescriptorImageInfo {
		public unsafe Sampler sampler;
		public unsafe ImageView imageView;
		public unsafe ImageLayout imageLayout;
	}

	public struct WriteDescriptorSet {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DescriptorSet dstSet;
		public unsafe uint dstBinding;
		public unsafe uint dstArrayElement;
		public unsafe uint descriptorCount;
		public unsafe DescriptorType descriptorType;
		public unsafe DescriptorImageInfo* imageInfo;
		public unsafe DescriptorBufferInfo* bufferInfo;
		public unsafe BufferView* texelBufferView;
	}

	public struct CopyDescriptorSet {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DescriptorSet srcSet;
		public unsafe uint srcBinding;
		public unsafe uint srcArrayElement;
		public unsafe DescriptorSet dstSet;
		public unsafe uint dstBinding;
		public unsafe uint dstArrayElement;
		public unsafe uint descriptorCount;
	}

	public struct BufferCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe BufferCreateFlags flags;
		public unsafe DeviceSize size;
		public unsafe BufferUsageFlags usage;
		public unsafe SharingMode sharingMode;
		public unsafe uint queueFamilyIndexCount;
		public unsafe uint* queueFamilyIndices;
	}

	public struct BufferViewCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe BufferViewCreateFlags flags;
		public unsafe Buffer buffer;
		public unsafe Format format;
		public unsafe DeviceSize offset;
		public unsafe DeviceSize range;
	}

	public struct ImageSubresource {
		public unsafe ImageAspectFlags aspectMask;
		public unsafe uint mipLevel;
		public unsafe uint arrayLayer;
	}

	public struct ImageSubresourceLayers {
		public unsafe ImageAspectFlags aspectMask;
		public unsafe uint mipLevel;
		public unsafe uint baseArrayLayer;
		public unsafe uint layerCount;
	}

	public struct ImageSubresourceRange {
		public unsafe ImageAspectFlags aspectMask;
		public unsafe uint baseMipLevel;
		public unsafe uint levelCount;
		public unsafe uint baseArrayLayer;
		public unsafe uint layerCount;
	}

	public struct MemoryBarrier {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe AccessFlags srcAccessMask;
		public unsafe AccessFlags dstAccessMask;
	}

	public struct BufferMemoryBarrier {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe AccessFlags srcAccessMask;
		public unsafe AccessFlags dstAccessMask;
		public unsafe uint srcQueueFamilyIndex;
		public unsafe uint dstQueueFamilyIndex;
		public unsafe Buffer buffer;
		public unsafe DeviceSize offset;
		public unsafe DeviceSize size;
	}

	public struct ImageMemoryBarrier {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe AccessFlags srcAccessMask;
		public unsafe AccessFlags dstAccessMask;
		public unsafe ImageLayout oldLayout;
		public unsafe ImageLayout newLayout;
		public unsafe uint srcQueueFamilyIndex;
		public unsafe uint dstQueueFamilyIndex;
		public unsafe Image image;
		public unsafe ImageSubresourceRange subresourceRange;
	}

	public struct ImageCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ImageCreateFlags flags;
		public unsafe ImageType imageType;
		public unsafe Format format;
		public unsafe Extent3D extent;
		public unsafe uint mipLevels;
		public unsafe uint arrayLayers;
		public unsafe SampleCountFlags samples;
		public unsafe ImageTiling tiling;
		public unsafe ImageUsageFlags usage;
		public unsafe SharingMode sharingMode;
		public unsafe uint queueFamilyIndexCount;
		public unsafe uint* queueFamilyIndices;
		public unsafe ImageLayout initialLayout;
	}

	public struct SubresourceLayout {
		public unsafe DeviceSize offset;
		public unsafe DeviceSize size;
		public unsafe DeviceSize rowPitch;
		public unsafe DeviceSize arrayPitch;
		public unsafe DeviceSize depthPitch;
	}

	public struct ImageViewCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ImageViewCreateFlags flags;
		public unsafe Image image;
		public unsafe ImageViewType viewType;
		public unsafe Format format;
		public unsafe ComponentMapping components;
		public unsafe ImageSubresourceRange subresourceRange;
	}

	public struct BufferCopy {
		public unsafe DeviceSize srcOffset;
		public unsafe DeviceSize dstOffset;
		public unsafe DeviceSize size;
	}

	public struct SparseMemoryBind {
		public unsafe DeviceSize resourceOffset;
		public unsafe DeviceSize size;
		public unsafe DeviceMemory memory;
		public unsafe DeviceSize memoryOffset;
		public unsafe SparseMemoryBindFlags flags;
	}

	public struct SparseImageMemoryBind {
		public unsafe ImageSubresource subresource;
		public unsafe Offset3D offset;
		public unsafe Extent3D extent;
		public unsafe DeviceMemory memory;
		public unsafe DeviceSize memoryOffset;
		public unsafe SparseMemoryBindFlags flags;
	}

	public struct SparseBufferMemoryBindInfo {
		public unsafe Buffer buffer;
		public unsafe uint bindCount;
		public unsafe SparseMemoryBind* binds;
	}

	public struct SparseImageOpaqueMemoryBindInfo {
		public unsafe Image image;
		public unsafe uint bindCount;
		public unsafe SparseMemoryBind* binds;
	}

	public struct SparseImageMemoryBindInfo {
		public unsafe Image image;
		public unsafe uint bindCount;
		public unsafe SparseImageMemoryBind* binds;
	}

	public struct BindSparseInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint waitSemaphoreCount;
		public unsafe Semaphore* waitSemaphores;
		public unsafe uint bufferBindCount;
		public unsafe SparseBufferMemoryBindInfo* bufferBinds;
		public unsafe uint imageOpaqueBindCount;
		public unsafe SparseImageOpaqueMemoryBindInfo* imageOpaqueBinds;
		public unsafe uint imageBindCount;
		public unsafe SparseImageMemoryBindInfo* imageBinds;
		public unsafe uint signalSemaphoreCount;
		public unsafe Semaphore* signalSemaphores;
	}

	public struct ImageCopy {
		public unsafe ImageSubresourceLayers srcSubresource;
		public unsafe Offset3D srcOffset;
		public unsafe ImageSubresourceLayers dstSubresource;
		public unsafe Offset3D dstOffset;
		public unsafe Extent3D extent;
	}

	public struct ImageBlit {
		public unsafe ImageSubresourceLayers srcSubresource;
		public Offset3D srcOffsets_0;
		public Offset3D srcOffsets_1;
		public unsafe ImageSubresourceLayers dstSubresource;
		public Offset3D dstOffsets_0;
		public Offset3D dstOffsets_1;
	}

	public struct BufferImageCopy {
		public unsafe DeviceSize bufferOffset;
		public unsafe uint bufferRowLength;
		public unsafe uint bufferImageHeight;
		public unsafe ImageSubresourceLayers imageSubresource;
		public unsafe Offset3D imageOffset;
		public unsafe Extent3D imageExtent;
	}

	public struct ImageResolve {
		public unsafe ImageSubresourceLayers srcSubresource;
		public unsafe Offset3D srcOffset;
		public unsafe ImageSubresourceLayers dstSubresource;
		public unsafe Offset3D dstOffset;
		public unsafe Extent3D extent;
	}

	public struct ShaderModuleCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ShaderModuleCreateFlags flags;
		public unsafe nuint codeSize;
		public unsafe uint* code;
	}

	public struct DescriptorSetLayoutBinding {
		public unsafe uint binding;
		public unsafe DescriptorType descriptorType;
		public unsafe uint descriptorCount;
		public unsafe ShaderStageFlags stageFlags;
		public unsafe Sampler* immutableSamplers;
	}

	public struct DescriptorSetLayoutCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DescriptorSetLayoutCreateFlags flags;
		public unsafe uint bindingCount;
		public unsafe DescriptorSetLayoutBinding* bindings;
	}

	public struct DescriptorPoolSize {
		public unsafe DescriptorType type;
		public unsafe uint descriptorCount;
	}

	public struct DescriptorPoolCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DescriptorPoolCreateFlags flags;
		public unsafe uint maxSets;
		public unsafe uint poolSizeCount;
		public unsafe DescriptorPoolSize* poolSizes;
	}

	public struct DescriptorSetAllocateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DescriptorPool descriptorPool;
		public unsafe uint descriptorSetCount;
		public unsafe DescriptorSetLayout* setLayouts;
	}

	public struct SpecializationMapEntry {
		public unsafe uint constantID;
		public unsafe uint offset;
		public unsafe nuint size;
	}

	public struct SpecializationInfo {
		public unsafe uint mapEntryCount;
		public unsafe SpecializationMapEntry* mapEntries;
		public unsafe nuint dataSize;
		public unsafe void* data;
	}

	public struct PipelineShaderStageCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineShaderStageCreateFlags flags;
		public unsafe ShaderStageFlags stage;
		public unsafe ShaderModule module;
		public unsafe byte* name;
		public unsafe SpecializationInfo* specializationInfo;
	}

	public struct ComputePipelineCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineCreateFlags flags;
		public unsafe PipelineShaderStageCreateInfo stage;
		public unsafe PipelineLayout layout;
		public unsafe Pipeline basePipelineHandle;
		public unsafe int basePipelineIndex;
	}

	public struct VertexInputBindingDescription {
		public unsafe uint binding;
		public unsafe uint stride;
		public unsafe VertexInputRate inputRate;
	}

	public struct VertexInputAttributeDescription {
		public unsafe uint location;
		public unsafe uint binding;
		public unsafe Format format;
		public unsafe uint offset;
	}

	public struct PipelineVertexInputStateCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineVertexInputStateCreateFlags flags;
		public unsafe uint vertexBindingDescriptionCount;
		public unsafe VertexInputBindingDescription* vertexBindingDescriptions;
		public unsafe uint vertexAttributeDescriptionCount;
		public unsafe VertexInputAttributeDescription* vertexAttributeDescriptions;
	}

	public struct PipelineInputAssemblyStateCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineInputAssemblyStateCreateFlags flags;
		public unsafe PrimitiveTopology topology;
		public unsafe Bool32 primitiveRestartEnable;
	}

	public struct PipelineTessellationStateCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineTessellationStateCreateFlags flags;
		public unsafe uint patchControlPoints;
	}

	public struct PipelineViewportStateCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineViewportStateCreateFlags flags;
		public unsafe uint viewportCount;
		public unsafe Viewport* viewports;
		public unsafe uint scissorCount;
		public unsafe Rect2D* scissors;
	}

	public struct PipelineRasterizationStateCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineRasterizationStateCreateFlags flags;
		public unsafe Bool32 depthClampEnable;
		public unsafe Bool32 rasterizerDiscardEnable;
		public unsafe PolygonMode polygonMode;
		public unsafe CullModeFlags cullMode;
		public unsafe FrontFace frontFace;
		public unsafe Bool32 depthBiasEnable;
		public unsafe float depthBiasConstantFactor;
		public unsafe float depthBiasClamp;
		public unsafe float depthBiasSlopeFactor;
		public unsafe float lineWidth;
	}

	public struct PipelineMultisampleStateCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineMultisampleStateCreateFlags flags;
		public unsafe SampleCountFlags rasterizationSamples;
		public unsafe Bool32 sampleShadingEnable;
		public unsafe float minSampleShading;
		public unsafe SampleMask* sampleMask;
		public unsafe Bool32 alphaToCoverageEnable;
		public unsafe Bool32 alphaToOneEnable;
	}

	public struct PipelineColorBlendAttachmentState {
		public unsafe Bool32 blendEnable;
		public unsafe BlendFactor srcColorBlendFactor;
		public unsafe BlendFactor dstColorBlendFactor;
		public unsafe BlendOp colorBlendOp;
		public unsafe BlendFactor srcAlphaBlendFactor;
		public unsafe BlendFactor dstAlphaBlendFactor;
		public unsafe BlendOp alphaBlendOp;
		public unsafe ColorComponentFlags colorWriteMask;
	}

	public struct PipelineColorBlendStateCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineColorBlendStateCreateFlags flags;
		public unsafe Bool32 logicOpEnable;
		public unsafe LogicOp logicOp;
		public unsafe uint attachmentCount;
		public unsafe PipelineColorBlendAttachmentState* attachments;
		public unsafe fixed float blendConstants[4];
	}

	public struct PipelineDynamicStateCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineDynamicStateCreateFlags flags;
		public unsafe uint dynamicStateCount;
		public unsafe DynamicState* dynamicStates;
	}

	public struct StencilOpState {
		public unsafe StencilOp failOp;
		public unsafe StencilOp passOp;
		public unsafe StencilOp depthFailOp;
		public unsafe CompareOp compareOp;
		public unsafe uint compareMask;
		public unsafe uint writeMask;
		public unsafe uint reference;
	}

	public struct PipelineDepthStencilStateCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineDepthStencilStateCreateFlags flags;
		public unsafe Bool32 depthTestEnable;
		public unsafe Bool32 depthWriteEnable;
		public unsafe CompareOp depthCompareOp;
		public unsafe Bool32 depthBoundsTestEnable;
		public unsafe Bool32 stencilTestEnable;
		public unsafe StencilOpState front;
		public unsafe StencilOpState back;
		public unsafe float minDepthBounds;
		public unsafe float maxDepthBounds;
	}

	public struct GraphicsPipelineCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineCreateFlags flags;
		public unsafe uint stageCount;
		public unsafe PipelineShaderStageCreateInfo* stages;
		public unsafe PipelineVertexInputStateCreateInfo* vertexInputState;
		public unsafe PipelineInputAssemblyStateCreateInfo* inputAssemblyState;
		public unsafe PipelineTessellationStateCreateInfo* tessellationState;
		public unsafe PipelineViewportStateCreateInfo* viewportState;
		public unsafe PipelineRasterizationStateCreateInfo* rasterizationState;
		public unsafe PipelineMultisampleStateCreateInfo* multisampleState;
		public unsafe PipelineDepthStencilStateCreateInfo* depthStencilState;
		public unsafe PipelineColorBlendStateCreateInfo* colorBlendState;
		public unsafe PipelineDynamicStateCreateInfo* dynamicState;
		public unsafe PipelineLayout layout;
		public unsafe RenderPass renderPass;
		public unsafe uint subpass;
		public unsafe Pipeline basePipelineHandle;
		public unsafe int basePipelineIndex;
	}

	public struct PipelineCacheCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineCacheCreateFlags flags;
		public unsafe nuint initialDataSize;
		public unsafe void* initialData;
	}

	public struct PushConstantRange {
		public unsafe ShaderStageFlags stageFlags;
		public unsafe uint offset;
		public unsafe uint size;
	}

	public struct PipelineLayoutCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineLayoutCreateFlags flags;
		public unsafe uint setLayoutCount;
		public unsafe DescriptorSetLayout* setLayouts;
		public unsafe uint pushConstantRangeCount;
		public unsafe PushConstantRange* pushConstantRanges;
	}

	public struct SamplerCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe SamplerCreateFlags flags;
		public unsafe Filter magFilter;
		public unsafe Filter minFilter;
		public unsafe SamplerMipmapMode mipmapMode;
		public unsafe SamplerAddressMode addressModeU;
		public unsafe SamplerAddressMode addressModeV;
		public unsafe SamplerAddressMode addressModeW;
		public unsafe float mipLodBias;
		public unsafe Bool32 anisotropyEnable;
		public unsafe float maxAnisotropy;
		public unsafe Bool32 compareEnable;
		public unsafe CompareOp compareOp;
		public unsafe float minLod;
		public unsafe float maxLod;
		public unsafe BorderColor borderColor;
		public unsafe Bool32 unnormalizedCoordinates;
	}

	public struct CommandPoolCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe CommandPoolCreateFlags flags;
		public unsafe uint queueFamilyIndex;
	}

	public struct CommandBufferAllocateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe CommandPool commandPool;
		public unsafe CommandBufferLevel level;
		public unsafe uint commandBufferCount;
	}

	public struct CommandBufferInheritanceInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe RenderPass renderPass;
		public unsafe uint subpass;
		public unsafe Framebuffer framebuffer;
		public unsafe Bool32 occlusionQueryEnable;
		public unsafe QueryControlFlags queryFlags;
		public unsafe QueryPipelineStatisticFlags pipelineStatistics;
	}

	public struct CommandBufferBeginInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe CommandBufferUsageFlags flags;
		public unsafe CommandBufferInheritanceInfo* inheritanceInfo;
	}

	public struct RenderPassBeginInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe RenderPass renderPass;
		public unsafe Framebuffer framebuffer;
		public unsafe Rect2D renderArea;
		public unsafe uint clearValueCount;
		public unsafe ClearValue* clearValues;
	}

	public struct ClearDepthStencilValue {
		public unsafe float depth;
		public unsafe uint stencil;
	}

	public struct ClearAttachment {
		public unsafe ImageAspectFlags aspectMask;
		public unsafe uint colorAttachment;
		public unsafe ClearValue clearValue;
	}

	public struct AttachmentDescription {
		public unsafe AttachmentDescriptionFlags flags;
		public unsafe Format format;
		public unsafe SampleCountFlags samples;
		public unsafe AttachmentLoadOp loadOp;
		public unsafe AttachmentStoreOp storeOp;
		public unsafe AttachmentLoadOp stencilLoadOp;
		public unsafe AttachmentStoreOp stencilStoreOp;
		public unsafe ImageLayout initialLayout;
		public unsafe ImageLayout finalLayout;
	}

	public struct AttachmentReference {
		public unsafe uint attachment;
		public unsafe ImageLayout layout;
	}

	public struct SubpassDescription {
		public unsafe SubpassDescriptionFlags flags;
		public unsafe PipelineBindPoint pipelineBindPoint;
		public unsafe uint inputAttachmentCount;
		public unsafe AttachmentReference* inputAttachments;
		public unsafe uint colorAttachmentCount;
		public unsafe AttachmentReference* colorAttachments;
		public unsafe AttachmentReference* resolveAttachments;
		public unsafe AttachmentReference* depthStencilAttachment;
		public unsafe uint preserveAttachmentCount;
		public unsafe uint* preserveAttachments;
	}

	public struct SubpassDependency {
		public unsafe uint srcSubpass;
		public unsafe uint dstSubpass;
		public unsafe PipelineStageFlags srcStageMask;
		public unsafe PipelineStageFlags dstStageMask;
		public unsafe AccessFlags srcAccessMask;
		public unsafe AccessFlags dstAccessMask;
		public unsafe DependencyFlags dependencyFlags;
	}

	public struct RenderPassCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe RenderPassCreateFlags flags;
		public unsafe uint attachmentCount;
		public unsafe AttachmentDescription* attachments;
		public unsafe uint subpassCount;
		public unsafe SubpassDescription* subpasses;
		public unsafe uint dependencyCount;
		public unsafe SubpassDependency* dependencies;
	}

	public struct EventCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe EventCreateFlags flags;
	}

	public struct FenceCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe FenceCreateFlags flags;
	}

	public struct PhysicalDeviceFeatures {
		public unsafe Bool32 robustBufferAccess;
		public unsafe Bool32 fullDrawIndexUint32;
		public unsafe Bool32 imageCubeArray;
		public unsafe Bool32 independentBlend;
		public unsafe Bool32 geometryShader;
		public unsafe Bool32 tessellationShader;
		public unsafe Bool32 sampleRateShading;
		public unsafe Bool32 dualSrcBlend;
		public unsafe Bool32 logicOp;
		public unsafe Bool32 multiDrawIndirect;
		public unsafe Bool32 drawIndirectFirstInstance;
		public unsafe Bool32 depthClamp;
		public unsafe Bool32 depthBiasClamp;
		public unsafe Bool32 fillModeNonSolid;
		public unsafe Bool32 depthBounds;
		public unsafe Bool32 wideLines;
		public unsafe Bool32 largePoints;
		public unsafe Bool32 alphaToOne;
		public unsafe Bool32 multiViewport;
		public unsafe Bool32 samplerAnisotropy;
		public unsafe Bool32 textureCompressionETC2;
		public unsafe Bool32 textureCompressionASTC_LDR;
		public unsafe Bool32 textureCompressionBC;
		public unsafe Bool32 occlusionQueryPrecise;
		public unsafe Bool32 pipelineStatisticsQuery;
		public unsafe Bool32 vertexPipelineStoresAndAtomics;
		public unsafe Bool32 fragmentStoresAndAtomics;
		public unsafe Bool32 shaderTessellationAndGeometryPointSize;
		public unsafe Bool32 shaderImageGatherExtended;
		public unsafe Bool32 shaderStorageImageExtendedFormats;
		public unsafe Bool32 shaderStorageImageMultisample;
		public unsafe Bool32 shaderStorageImageReadWithoutFormat;
		public unsafe Bool32 shaderStorageImageWriteWithoutFormat;
		public unsafe Bool32 shaderUniformBufferArrayDynamicIndexing;
		public unsafe Bool32 shaderSampledImageArrayDynamicIndexing;
		public unsafe Bool32 shaderStorageBufferArrayDynamicIndexing;
		public unsafe Bool32 shaderStorageImageArrayDynamicIndexing;
		public unsafe Bool32 shaderClipDistance;
		public unsafe Bool32 shaderCullDistance;
		public unsafe Bool32 shaderFloat64;
		public unsafe Bool32 shaderInt64;
		public unsafe Bool32 shaderInt16;
		public unsafe Bool32 shaderResourceResidency;
		public unsafe Bool32 shaderResourceMinLod;
		public unsafe Bool32 sparseBinding;
		public unsafe Bool32 sparseResidencyBuffer;
		public unsafe Bool32 sparseResidencyImage2D;
		public unsafe Bool32 sparseResidencyImage3D;
		public unsafe Bool32 sparseResidency2Samples;
		public unsafe Bool32 sparseResidency4Samples;
		public unsafe Bool32 sparseResidency8Samples;
		public unsafe Bool32 sparseResidency16Samples;
		public unsafe Bool32 sparseResidencyAliased;
		public unsafe Bool32 variableMultisampleRate;
		public unsafe Bool32 inheritedQueries;
	}

	public struct PhysicalDeviceSparseProperties {
		public unsafe Bool32 residencyStandard2DBlockShape;
		public unsafe Bool32 residencyStandard2DMultisampleBlockShape;
		public unsafe Bool32 residencyStandard3DBlockShape;
		public unsafe Bool32 residencyAlignedMipSize;
		public unsafe Bool32 residencyNonResidentStrict;
	}

	public struct PhysicalDeviceLimits {
		public unsafe uint maxImageDimension1D;
		public unsafe uint maxImageDimension2D;
		public unsafe uint maxImageDimension3D;
		public unsafe uint maxImageDimensionCube;
		public unsafe uint maxImageArrayLayers;
		public unsafe uint maxTexelBufferElements;
		public unsafe uint maxUniformBufferRange;
		public unsafe uint maxStorageBufferRange;
		public unsafe uint maxPushConstantsSize;
		public unsafe uint maxMemoryAllocationCount;
		public unsafe uint maxSamplerAllocationCount;
		public unsafe DeviceSize bufferImageGranularity;
		public unsafe DeviceSize sparseAddressSpaceSize;
		public unsafe uint maxBoundDescriptorSets;
		public unsafe uint maxPerStageDescriptorSamplers;
		public unsafe uint maxPerStageDescriptorUniformBuffers;
		public unsafe uint maxPerStageDescriptorStorageBuffers;
		public unsafe uint maxPerStageDescriptorSampledImages;
		public unsafe uint maxPerStageDescriptorStorageImages;
		public unsafe uint maxPerStageDescriptorInputAttachments;
		public unsafe uint maxPerStageResources;
		public unsafe uint maxDescriptorSetSamplers;
		public unsafe uint maxDescriptorSetUniformBuffers;
		public unsafe uint maxDescriptorSetUniformBuffersDynamic;
		public unsafe uint maxDescriptorSetStorageBuffers;
		public unsafe uint maxDescriptorSetStorageBuffersDynamic;
		public unsafe uint maxDescriptorSetSampledImages;
		public unsafe uint maxDescriptorSetStorageImages;
		public unsafe uint maxDescriptorSetInputAttachments;
		public unsafe uint maxVertexInputAttributes;
		public unsafe uint maxVertexInputBindings;
		public unsafe uint maxVertexInputAttributeOffset;
		public unsafe uint maxVertexInputBindingStride;
		public unsafe uint maxVertexOutputComponents;
		public unsafe uint maxTessellationGenerationLevel;
		public unsafe uint maxTessellationPatchSize;
		public unsafe uint maxTessellationControlPerVertexInputComponents;
		public unsafe uint maxTessellationControlPerVertexOutputComponents;
		public unsafe uint maxTessellationControlPerPatchOutputComponents;
		public unsafe uint maxTessellationControlTotalOutputComponents;
		public unsafe uint maxTessellationEvaluationInputComponents;
		public unsafe uint maxTessellationEvaluationOutputComponents;
		public unsafe uint maxGeometryShaderInvocations;
		public unsafe uint maxGeometryInputComponents;
		public unsafe uint maxGeometryOutputComponents;
		public unsafe uint maxGeometryOutputVertices;
		public unsafe uint maxGeometryTotalOutputComponents;
		public unsafe uint maxFragmentInputComponents;
		public unsafe uint maxFragmentOutputAttachments;
		public unsafe uint maxFragmentDualSrcAttachments;
		public unsafe uint maxFragmentCombinedOutputResources;
		public unsafe uint maxComputeSharedMemorySize;
		public unsafe fixed uint maxComputeWorkGroupCount[3];
		public unsafe uint maxComputeWorkGroupInvocations;
		public unsafe fixed uint maxComputeWorkGroupSize[3];
		public unsafe uint subPixelPrecisionBits;
		public unsafe uint subTexelPrecisionBits;
		public unsafe uint mipmapPrecisionBits;
		public unsafe uint maxDrawIndexedIndexValue;
		public unsafe uint maxDrawIndirectCount;
		public unsafe float maxSamplerLodBias;
		public unsafe float maxSamplerAnisotropy;
		public unsafe uint maxViewports;
		public unsafe fixed uint maxViewportDimensions[2];
		public unsafe fixed float viewportBoundsRange[2];
		public unsafe uint viewportSubPixelBits;
		public unsafe nuint minMemoryMapAlignment;
		public unsafe DeviceSize minTexelBufferOffsetAlignment;
		public unsafe DeviceSize minUniformBufferOffsetAlignment;
		public unsafe DeviceSize minStorageBufferOffsetAlignment;
		public unsafe int minTexelOffset;
		public unsafe uint maxTexelOffset;
		public unsafe int minTexelGatherOffset;
		public unsafe uint maxTexelGatherOffset;
		public unsafe float minInterpolationOffset;
		public unsafe float maxInterpolationOffset;
		public unsafe uint subPixelInterpolationOffsetBits;
		public unsafe uint maxFramebufferWidth;
		public unsafe uint maxFramebufferHeight;
		public unsafe uint maxFramebufferLayers;
		public unsafe SampleCountFlags framebufferColorSampleCounts;
		public unsafe SampleCountFlags framebufferDepthSampleCounts;
		public unsafe SampleCountFlags framebufferStencilSampleCounts;
		public unsafe SampleCountFlags framebufferNoAttachmentsSampleCounts;
		public unsafe uint maxColorAttachments;
		public unsafe SampleCountFlags sampledImageColorSampleCounts;
		public unsafe SampleCountFlags sampledImageIntegerSampleCounts;
		public unsafe SampleCountFlags sampledImageDepthSampleCounts;
		public unsafe SampleCountFlags sampledImageStencilSampleCounts;
		public unsafe SampleCountFlags storageImageSampleCounts;
		public unsafe uint maxSampleMaskWords;
		public unsafe Bool32 timestampComputeAndGraphics;
		public unsafe float timestampPeriod;
		public unsafe uint maxClipDistances;
		public unsafe uint maxCullDistances;
		public unsafe uint maxCombinedClipAndCullDistances;
		public unsafe uint discreteQueuePriorities;
		public unsafe fixed float pointSizeRange[2];
		public unsafe fixed float lineWidthRange[2];
		public unsafe float pointSizeGranularity;
		public unsafe float lineWidthGranularity;
		public unsafe Bool32 strictLines;
		public unsafe Bool32 standardSampleLocations;
		public unsafe DeviceSize optimalBufferCopyOffsetAlignment;
		public unsafe DeviceSize optimalBufferCopyRowPitchAlignment;
		public unsafe DeviceSize nonCoherentAtomSize;
	}

	public struct SemaphoreCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe SemaphoreCreateFlags flags;
	}

	public struct QueryPoolCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe QueryPoolCreateFlags flags;
		public unsafe QueryType queryType;
		public unsafe uint queryCount;
		public unsafe QueryPipelineStatisticFlags pipelineStatistics;
	}

	public struct FramebufferCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe FramebufferCreateFlags flags;
		public unsafe RenderPass renderPass;
		public unsafe uint attachmentCount;
		public unsafe ImageView* attachments;
		public unsafe uint width;
		public unsafe uint height;
		public unsafe uint layers;
	}

	public struct DrawIndirectCommand {
		public unsafe uint vertexCount;
		public unsafe uint instanceCount;
		public unsafe uint firstVertex;
		public unsafe uint firstInstance;
	}

	public struct DrawIndexedIndirectCommand {
		public unsafe uint indexCount;
		public unsafe uint instanceCount;
		public unsafe uint firstIndex;
		public unsafe int vertexOffset;
		public unsafe uint firstInstance;
	}

	public struct DispatchIndirectCommand {
		public unsafe uint x;
		public unsafe uint y;
		public unsafe uint z;
	}

	public struct SubmitInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint waitSemaphoreCount;
		public unsafe Semaphore* waitSemaphores;
		public unsafe PipelineStageFlags* waitDstStageMask;
		public unsafe uint commandBufferCount;
		public unsafe CommandBuffer* commandBuffers;
		public unsafe uint signalSemaphoreCount;
		public unsafe Semaphore* signalSemaphores;
	}

	public struct DisplayPropertiesKHR {
		public unsafe DisplayKHR display;
		public unsafe byte* displayName;
		public unsafe Extent2D physicalDimensions;
		public unsafe Extent2D physicalResolution;
		public unsafe SurfaceTransformFlagsKHR supportedTransforms;
		public unsafe Bool32 planeReorderPossible;
		public unsafe Bool32 persistentContent;
	}

	public struct DisplayPlanePropertiesKHR {
		public unsafe DisplayKHR currentDisplay;
		public unsafe uint currentStackIndex;
	}

	public struct DisplayModeParametersKHR {
		public unsafe Extent2D visibleRegion;
		public unsafe uint refreshRate;
	}

	public struct DisplayModePropertiesKHR {
		public unsafe DisplayModeKHR displayMode;
		public unsafe DisplayModeParametersKHR parameters;
	}

	public struct DisplayModeCreateInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DisplayModeCreateFlagsKHR flags;
		public unsafe DisplayModeParametersKHR parameters;
	}

	public struct DisplayPlaneCapabilitiesKHR {
		public unsafe DisplayPlaneAlphaFlagsKHR supportedAlpha;
		public unsafe Offset2D minSrcPosition;
		public unsafe Offset2D maxSrcPosition;
		public unsafe Extent2D minSrcExtent;
		public unsafe Extent2D maxSrcExtent;
		public unsafe Offset2D minDstPosition;
		public unsafe Offset2D maxDstPosition;
		public unsafe Extent2D minDstExtent;
		public unsafe Extent2D maxDstExtent;
	}

	public struct DisplaySurfaceCreateInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DisplaySurfaceCreateFlagsKHR flags;
		public unsafe DisplayModeKHR displayMode;
		public unsafe uint planeIndex;
		public unsafe uint planeStackIndex;
		public unsafe SurfaceTransformFlagsKHR transform;
		public unsafe float globalAlpha;
		public unsafe DisplayPlaneAlphaFlagsKHR alphaMode;
		public unsafe Extent2D imageExtent;
	}

	public struct DisplayPresentInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Rect2D srcRect;
		public unsafe Rect2D dstRect;
		public unsafe Bool32 persistent;
	}

	public struct SurfaceCapabilitiesKHR {
		public unsafe uint minImageCount;
		public unsafe uint maxImageCount;
		public unsafe Extent2D currentExtent;
		public unsafe Extent2D minImageExtent;
		public unsafe Extent2D maxImageExtent;
		public unsafe uint maxImageArrayLayers;
		public unsafe SurfaceTransformFlagsKHR supportedTransforms;
		public unsafe SurfaceTransformFlagsKHR currentTransform;
		public unsafe CompositeAlphaFlagsKHR supportedCompositeAlpha;
		public unsafe ImageUsageFlags supportedUsageFlags;
	}

	public struct AndroidSurfaceCreateInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe AndroidSurfaceCreateFlagsKHR flags;
		public unsafe void** window;
	}

	public struct ViSurfaceCreateInfoNN {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ViSurfaceCreateFlagsNN flags;
		public unsafe void* window;
	}

	public struct WaylandSurfaceCreateInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe WaylandSurfaceCreateFlagsKHR flags;
		public unsafe void** display;
		public unsafe void** surface;
	}

	public struct Win32SurfaceCreateInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Win32SurfaceCreateFlagsKHR flags;
		public unsafe void* hinstance;
		public unsafe void* hwnd;
	}

	public struct XlibSurfaceCreateInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe XlibSurfaceCreateFlagsKHR flags;
		public unsafe void** dpy;
		public unsafe ulong window;
	}

	public struct XcbSurfaceCreateInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe XcbSurfaceCreateFlagsKHR flags;
		public unsafe void** connection;
		public unsafe uint window;
	}

	public struct DirectFBSurfaceCreateInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DirectFBSurfaceCreateFlagsEXT flags;
		public unsafe void** dfb;
		public unsafe void** surface;
	}

	public struct ImagePipeSurfaceCreateInfoFUCHSIA {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ImagePipeSurfaceCreateFlagsFUCHSIA flags;
		public unsafe uint imagePipeHandle;
	}

	public struct StreamDescriptorSurfaceCreateInfoGGP {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe StreamDescriptorSurfaceCreateFlagsGGP flags;
		public unsafe int streamDescriptor;
	}

	public struct SurfaceFormatKHR {
		public unsafe Format format;
		public unsafe ColorSpaceKHR colorSpace;
	}

	public struct SwapchainCreateInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe SwapchainCreateFlagsKHR flags;
		public unsafe SurfaceKHR surface;
		public unsafe uint minImageCount;
		public unsafe Format imageFormat;
		public unsafe ColorSpaceKHR imageColorSpace;
		public unsafe Extent2D imageExtent;
		public unsafe uint imageArrayLayers;
		public unsafe ImageUsageFlags imageUsage;
		public unsafe SharingMode imageSharingMode;
		public unsafe uint queueFamilyIndexCount;
		public unsafe uint* queueFamilyIndices;
		public unsafe SurfaceTransformFlagsKHR preTransform;
		public unsafe CompositeAlphaFlagsKHR compositeAlpha;
		public unsafe PresentModeKHR presentMode;
		public unsafe Bool32 clipped;
		public unsafe SwapchainKHR oldSwapchain;
	}

	public struct PresentInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint waitSemaphoreCount;
		public unsafe Semaphore* waitSemaphores;
		public unsafe uint swapchainCount;
		public unsafe SwapchainKHR* swapchains;
		public unsafe uint* imageIndices;
		public unsafe Result* results;
	}

	public struct DebugReportCallbackCreateInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DebugReportFlagsEXT flags;
		public unsafe IntPtr pfnCallback;
		public unsafe void* userData;
	}

	public struct ValidationFlagsEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint disabledValidationCheckCount;
		public unsafe ValidationCheckEXT* disabledValidationChecks;
	}

	public struct ValidationFeaturesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint enabledValidationFeatureCount;
		public unsafe ValidationFeatureEnableEXT* enabledValidationFeatures;
		public unsafe uint disabledValidationFeatureCount;
		public unsafe ValidationFeatureDisableEXT* disabledValidationFeatures;
	}

	public struct PipelineRasterizationStateRasterizationOrderAMD {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe RasterizationOrderAMD rasterizationOrder;
	}

	public struct DebugMarkerObjectNameInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DebugReportObjectTypeEXT objectType;
		public unsafe ulong @object;
		public unsafe byte* objectName;
	}

	public struct DebugMarkerObjectTagInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DebugReportObjectTypeEXT objectType;
		public unsafe ulong @object;
		public unsafe ulong tagName;
		public unsafe nuint tagSize;
		public unsafe void* tag;
	}

	public struct DebugMarkerMarkerInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe byte* markerName;
		public unsafe fixed float color[4];
	}

	public struct DedicatedAllocationImageCreateInfoNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 dedicatedAllocation;
	}

	public struct DedicatedAllocationBufferCreateInfoNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 dedicatedAllocation;
	}

	public struct DedicatedAllocationMemoryAllocateInfoNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Image image;
		public unsafe Buffer buffer;
	}

	public struct ExternalImageFormatPropertiesNV {
		public unsafe ImageFormatProperties imageFormatProperties;
		public unsafe ExternalMemoryFeatureFlagsNV externalMemoryFeatures;
		public unsafe ExternalMemoryHandleTypeFlagsNV exportFromImportedHandleTypes;
		public unsafe ExternalMemoryHandleTypeFlagsNV compatibleHandleTypes;
	}

	public struct ExternalMemoryImageCreateInfoNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ExternalMemoryHandleTypeFlagsNV handleTypes;
	}

	public struct ExportMemoryAllocateInfoNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ExternalMemoryHandleTypeFlagsNV handleTypes;
	}

	public struct ImportMemoryWin32HandleInfoNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ExternalMemoryHandleTypeFlagsNV handleType;
		public unsafe void* handle;
	}

	public struct ExportMemoryWin32HandleInfoNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe SECURITY_ATTRIBUTES* attributes;
		public unsafe uint dwAccess;
	}

	public struct Win32KeyedMutexAcquireReleaseInfoNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint acquireCount;
		public unsafe DeviceMemory* acquireSyncs;
		public unsafe ulong* acquireKeys;
		public unsafe uint* acquireTimeoutMilliseconds;
		public unsafe uint releaseCount;
		public unsafe DeviceMemory* releaseSyncs;
		public unsafe ulong* releaseKeys;
	}

	public struct PhysicalDeviceDeviceGeneratedCommandsFeaturesNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 deviceGeneratedCommands;
	}

	public struct DevicePrivateDataCreateInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint privateDataSlotRequestCount;
	}

	public struct PrivateDataSlotCreateInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PrivateDataSlotCreateFlagsEXT flags;
	}

	public struct PhysicalDevicePrivateDataFeaturesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 privateData;
	}

	public struct PhysicalDeviceDeviceGeneratedCommandsPropertiesNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint maxGraphicsShaderGroupCount;
		public unsafe uint maxIndirectSequenceCount;
		public unsafe uint maxIndirectCommandsTokenCount;
		public unsafe uint maxIndirectCommandsStreamCount;
		public unsafe uint maxIndirectCommandsTokenOffset;
		public unsafe uint maxIndirectCommandsStreamStride;
		public unsafe uint minSequencesCountBufferOffsetAlignment;
		public unsafe uint minSequencesIndexBufferOffsetAlignment;
		public unsafe uint minIndirectCommandsBufferOffsetAlignment;
	}

	public struct GraphicsShaderGroupCreateInfoNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint stageCount;
		public unsafe PipelineShaderStageCreateInfo* stages;
		public unsafe PipelineVertexInputStateCreateInfo* vertexInputState;
		public unsafe PipelineTessellationStateCreateInfo* tessellationState;
	}

	public struct GraphicsPipelineShaderGroupsCreateInfoNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint groupCount;
		public unsafe GraphicsShaderGroupCreateInfoNV* groups;
		public unsafe uint pipelineCount;
		public unsafe Pipeline* pipelines;
	}

	public struct BindShaderGroupIndirectCommandNV {
		public unsafe uint groupIndex;
	}

	public struct BindIndexBufferIndirectCommandNV {
		public unsafe DeviceAddress bufferAddress;
		public unsafe uint size;
		public unsafe IndexType indexType;
	}

	public struct BindVertexBufferIndirectCommandNV {
		public unsafe DeviceAddress bufferAddress;
		public unsafe uint size;
		public unsafe uint stride;
	}

	public struct SetStateFlagsIndirectCommandNV {
		public unsafe uint data;
	}

	public struct IndirectCommandsStreamNV {
		public unsafe Buffer buffer;
		public unsafe DeviceSize offset;
	}

	public struct IndirectCommandsLayoutTokenNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe IndirectCommandsTokenTypeNV tokenType;
		public unsafe uint stream;
		public unsafe uint offset;
		public unsafe uint vertexBindingUnit;
		public unsafe Bool32 vertexDynamicStride;
		public unsafe PipelineLayout pushconstantPipelineLayout;
		public unsafe ShaderStageFlags pushconstantShaderStageFlags;
		public unsafe uint pushconstantOffset;
		public unsafe uint pushconstantSize;
		public unsafe IndirectStateFlagsNV indirectStateFlags;
		public unsafe uint indexTypeCount;
		public unsafe IndexType* indexTypes;
		public unsafe uint* indexTypeValues;
	}

	public struct IndirectCommandsLayoutCreateInfoNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe IndirectCommandsLayoutUsageFlagsNV flags;
		public unsafe PipelineBindPoint pipelineBindPoint;
		public unsafe uint tokenCount;
		public unsafe IndirectCommandsLayoutTokenNV* tokens;
		public unsafe uint streamCount;
		public unsafe uint* streamStrides;
	}

	public struct GeneratedCommandsInfoNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineBindPoint pipelineBindPoint;
		public unsafe Pipeline pipeline;
		public unsafe IndirectCommandsLayoutNV indirectCommandsLayout;
		public unsafe uint streamCount;
		public unsafe IndirectCommandsStreamNV* streams;
		public unsafe uint sequencesCount;
		public unsafe Buffer preprocessBuffer;
		public unsafe DeviceSize preprocessOffset;
		public unsafe DeviceSize preprocessSize;
		public unsafe Buffer sequencesCountBuffer;
		public unsafe DeviceSize sequencesCountOffset;
		public unsafe Buffer sequencesIndexBuffer;
		public unsafe DeviceSize sequencesIndexOffset;
	}

	public struct GeneratedCommandsMemoryRequirementsInfoNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineBindPoint pipelineBindPoint;
		public unsafe Pipeline pipeline;
		public unsafe IndirectCommandsLayoutNV indirectCommandsLayout;
		public unsafe uint maxSequencesCount;
	}

	public struct PhysicalDeviceFeatures2 {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PhysicalDeviceFeatures features;
	}

	public struct PhysicalDeviceProperties2 {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PhysicalDeviceProperties properties;
	}

	public struct FormatProperties2 {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe FormatProperties formatProperties;
	}

	public struct ImageFormatProperties2 {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ImageFormatProperties imageFormatProperties;
	}

	public struct PhysicalDeviceImageFormatInfo2 {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Format format;
		public unsafe ImageType type;
		public unsafe ImageTiling tiling;
		public unsafe ImageUsageFlags usage;
		public unsafe ImageCreateFlags flags;
	}

	public struct QueueFamilyProperties2 {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe QueueFamilyProperties queueFamilyProperties;
	}

	public struct PhysicalDeviceMemoryProperties2 {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PhysicalDeviceMemoryProperties memoryProperties;
	}

	public struct SparseImageFormatProperties2 {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe SparseImageFormatProperties properties;
	}

	public struct PhysicalDeviceSparseImageFormatInfo2 {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Format format;
		public unsafe ImageType type;
		public unsafe SampleCountFlags samples;
		public unsafe ImageUsageFlags usage;
		public unsafe ImageTiling tiling;
	}

	public struct PhysicalDevicePushDescriptorPropertiesKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint maxPushDescriptors;
	}

	public struct ConformanceVersion {
		public unsafe byte major;
		public unsafe byte minor;
		public unsafe byte subminor;
		public unsafe byte patch;
	}

	public struct PhysicalDeviceDriverProperties {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DriverId driverID;
		public unsafe fixed byte driverName[Constants.MaxDriverNameSize];
		public unsafe fixed byte driverInfo[Constants.MaxDriverInfoSize];
		public unsafe ConformanceVersion conformanceVersion;
	}

	public struct PresentRegionsKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint swapchainCount;
		public unsafe PresentRegionKHR* regions;
	}

	public struct PresentRegionKHR {
		public unsafe uint rectangleCount;
		public unsafe RectLayerKHR* rectangles;
	}

	public struct RectLayerKHR {
		public unsafe Offset2D offset;
		public unsafe Extent2D extent;
		public unsafe uint layer;
	}

	public struct PhysicalDeviceVariablePointersFeatures {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 variablePointersStorageBuffer;
		public unsafe Bool32 variablePointers;
	}

	public struct ExternalMemoryProperties {
		public unsafe ExternalMemoryFeatureFlags externalMemoryFeatures;
		public unsafe ExternalMemoryHandleTypeFlags exportFromImportedHandleTypes;
		public unsafe ExternalMemoryHandleTypeFlags compatibleHandleTypes;
	}

	public struct PhysicalDeviceExternalImageFormatInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ExternalMemoryHandleTypeFlags handleType;
	}

	public struct ExternalImageFormatProperties {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ExternalMemoryProperties externalMemoryProperties;
	}

	public struct PhysicalDeviceExternalBufferInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe BufferCreateFlags flags;
		public unsafe BufferUsageFlags usage;
		public unsafe ExternalMemoryHandleTypeFlags handleType;
	}

	public struct ExternalBufferProperties {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ExternalMemoryProperties externalMemoryProperties;
	}

	public struct PhysicalDeviceIDProperties {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe fixed byte deviceUUID[Constants.UuidSize];
		public unsafe fixed byte driverUUID[Constants.UuidSize];
		public unsafe fixed byte deviceLUID[Constants.LuidSize];
		public unsafe uint deviceNodeMask;
		public unsafe Bool32 deviceLUIDValid;
	}

	public struct ExternalMemoryImageCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ExternalMemoryHandleTypeFlags handleTypes;
	}

	public struct ExternalMemoryBufferCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ExternalMemoryHandleTypeFlags handleTypes;
	}

	public struct ExportMemoryAllocateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ExternalMemoryHandleTypeFlags handleTypes;
	}

	public struct ImportMemoryWin32HandleInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ExternalMemoryHandleTypeFlags handleType;
		public unsafe void* handle;
		public unsafe char* name;
	}

	public struct ExportMemoryWin32HandleInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe SECURITY_ATTRIBUTES* attributes;
		public unsafe uint dwAccess;
		public unsafe char* name;
	}

	public struct MemoryWin32HandlePropertiesKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint memoryTypeBits;
	}

	public struct MemoryGetWin32HandleInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DeviceMemory memory;
		public unsafe ExternalMemoryHandleTypeFlags handleType;
	}

	public struct ImportMemoryFdInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ExternalMemoryHandleTypeFlags handleType;
		public unsafe short fd;
	}

	public struct MemoryFdPropertiesKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint memoryTypeBits;
	}

	public struct MemoryGetFdInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DeviceMemory memory;
		public unsafe ExternalMemoryHandleTypeFlags handleType;
	}

	public struct Win32KeyedMutexAcquireReleaseInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint acquireCount;
		public unsafe DeviceMemory* acquireSyncs;
		public unsafe ulong* acquireKeys;
		public unsafe uint* acquireTimeouts;
		public unsafe uint releaseCount;
		public unsafe DeviceMemory* releaseSyncs;
		public unsafe ulong* releaseKeys;
	}

	public struct PhysicalDeviceExternalSemaphoreInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ExternalSemaphoreHandleTypeFlags handleType;
	}

	public struct ExternalSemaphoreProperties {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ExternalSemaphoreHandleTypeFlags exportFromImportedHandleTypes;
		public unsafe ExternalSemaphoreHandleTypeFlags compatibleHandleTypes;
		public unsafe ExternalSemaphoreFeatureFlags externalSemaphoreFeatures;
	}

	public struct ExportSemaphoreCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ExternalSemaphoreHandleTypeFlags handleTypes;
	}

	public struct ImportSemaphoreWin32HandleInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Semaphore semaphore;
		public unsafe SemaphoreImportFlags flags;
		public unsafe ExternalSemaphoreHandleTypeFlags handleType;
		public unsafe void* handle;
		public unsafe char* name;
	}

	public struct ExportSemaphoreWin32HandleInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe SECURITY_ATTRIBUTES* attributes;
		public unsafe uint dwAccess;
		public unsafe char* name;
	}

	public struct D3D12FenceSubmitInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint waitSemaphoreValuesCount;
		public unsafe ulong* waitSemaphoreValues;
		public unsafe uint signalSemaphoreValuesCount;
		public unsafe ulong* signalSemaphoreValues;
	}

	public struct SemaphoreGetWin32HandleInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Semaphore semaphore;
		public unsafe ExternalSemaphoreHandleTypeFlags handleType;
	}

	public struct ImportSemaphoreFdInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Semaphore semaphore;
		public unsafe SemaphoreImportFlags flags;
		public unsafe ExternalSemaphoreHandleTypeFlags handleType;
		public unsafe short fd;
	}

	public struct SemaphoreGetFdInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Semaphore semaphore;
		public unsafe ExternalSemaphoreHandleTypeFlags handleType;
	}

	public struct PhysicalDeviceExternalFenceInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ExternalFenceHandleTypeFlags handleType;
	}

	public struct ExternalFenceProperties {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ExternalFenceHandleTypeFlags exportFromImportedHandleTypes;
		public unsafe ExternalFenceHandleTypeFlags compatibleHandleTypes;
		public unsafe ExternalFenceFeatureFlags externalFenceFeatures;
	}

	public struct ExportFenceCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ExternalFenceHandleTypeFlags handleTypes;
	}

	public struct ImportFenceWin32HandleInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Fence fence;
		public unsafe FenceImportFlags flags;
		public unsafe ExternalFenceHandleTypeFlags handleType;
		public unsafe void* handle;
		public unsafe char* name;
	}

	public struct ExportFenceWin32HandleInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe SECURITY_ATTRIBUTES* attributes;
		public unsafe uint dwAccess;
		public unsafe char* name;
	}

	public struct FenceGetWin32HandleInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Fence fence;
		public unsafe ExternalFenceHandleTypeFlags handleType;
	}

	public struct ImportFenceFdInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Fence fence;
		public unsafe FenceImportFlags flags;
		public unsafe ExternalFenceHandleTypeFlags handleType;
		public unsafe short fd;
	}

	public struct FenceGetFdInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Fence fence;
		public unsafe ExternalFenceHandleTypeFlags handleType;
	}

	public struct PhysicalDeviceMultiviewFeatures {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 multiview;
		public unsafe Bool32 multiviewGeometryShader;
		public unsafe Bool32 multiviewTessellationShader;
	}

	public struct PhysicalDeviceMultiviewProperties {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint maxMultiviewViewCount;
		public unsafe uint maxMultiviewInstanceIndex;
	}

	public struct RenderPassMultiviewCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint subpassCount;
		public unsafe uint* viewMasks;
		public unsafe uint dependencyCount;
		public unsafe int* viewOffsets;
		public unsafe uint correlationMaskCount;
		public unsafe uint* correlationMasks;
	}

	public struct SurfaceCapabilities2EXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint minImageCount;
		public unsafe uint maxImageCount;
		public unsafe Extent2D currentExtent;
		public unsafe Extent2D minImageExtent;
		public unsafe Extent2D maxImageExtent;
		public unsafe uint maxImageArrayLayers;
		public unsafe SurfaceTransformFlagsKHR supportedTransforms;
		public unsafe SurfaceTransformFlagsKHR currentTransform;
		public unsafe CompositeAlphaFlagsKHR supportedCompositeAlpha;
		public unsafe ImageUsageFlags supportedUsageFlags;
		public unsafe SurfaceCounterFlagsEXT supportedSurfaceCounters;
	}

	public struct DisplayPowerInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DisplayPowerStateEXT powerState;
	}

	public struct DeviceEventInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DeviceEventTypeEXT deviceEvent;
	}

	public struct DisplayEventInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DisplayEventTypeEXT displayEvent;
	}

	public struct SwapchainCounterCreateInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe SurfaceCounterFlagsEXT surfaceCounters;
	}

	public struct PhysicalDeviceGroupProperties {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint physicalDeviceCount;
		public PhysicalDevice physicalDevices_0;
		public PhysicalDevice physicalDevices_1;
		public PhysicalDevice physicalDevices_2;
		public PhysicalDevice physicalDevices_3;
		public PhysicalDevice physicalDevices_4;
		public PhysicalDevice physicalDevices_5;
		public PhysicalDevice physicalDevices_6;
		public PhysicalDevice physicalDevices_7;
		public PhysicalDevice physicalDevices_8;
		public PhysicalDevice physicalDevices_9;
		public PhysicalDevice physicalDevices_10;
		public PhysicalDevice physicalDevices_11;
		public PhysicalDevice physicalDevices_12;
		public PhysicalDevice physicalDevices_13;
		public PhysicalDevice physicalDevices_14;
		public PhysicalDevice physicalDevices_15;
		public PhysicalDevice physicalDevices_16;
		public PhysicalDevice physicalDevices_17;
		public PhysicalDevice physicalDevices_18;
		public PhysicalDevice physicalDevices_19;
		public PhysicalDevice physicalDevices_20;
		public PhysicalDevice physicalDevices_21;
		public PhysicalDevice physicalDevices_22;
		public PhysicalDevice physicalDevices_23;
		public PhysicalDevice physicalDevices_24;
		public PhysicalDevice physicalDevices_25;
		public PhysicalDevice physicalDevices_26;
		public PhysicalDevice physicalDevices_27;
		public PhysicalDevice physicalDevices_28;
		public PhysicalDevice physicalDevices_29;
		public PhysicalDevice physicalDevices_30;
		public PhysicalDevice physicalDevices_31;
		public unsafe Bool32 subsetAllocation;
	}

	public struct MemoryAllocateFlagsInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe MemoryAllocateFlags flags;
		public unsafe uint deviceMask;
	}

	public struct BindBufferMemoryInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Buffer buffer;
		public unsafe DeviceMemory memory;
		public unsafe DeviceSize memoryOffset;
	}

	public struct BindBufferMemoryDeviceGroupInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint deviceIndexCount;
		public unsafe uint* deviceIndices;
	}

	public struct BindImageMemoryInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Image image;
		public unsafe DeviceMemory memory;
		public unsafe DeviceSize memoryOffset;
	}

	public struct BindImageMemoryDeviceGroupInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint deviceIndexCount;
		public unsafe uint* deviceIndices;
		public unsafe uint splitInstanceBindRegionCount;
		public unsafe Rect2D* splitInstanceBindRegions;
	}

	public struct DeviceGroupRenderPassBeginInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint deviceMask;
		public unsafe uint deviceRenderAreaCount;
		public unsafe Rect2D* deviceRenderAreas;
	}

	public struct DeviceGroupCommandBufferBeginInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint deviceMask;
	}

	public struct DeviceGroupSubmitInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint waitSemaphoreCount;
		public unsafe uint* waitSemaphoreDeviceIndices;
		public unsafe uint commandBufferCount;
		public unsafe uint* commandBufferDeviceMasks;
		public unsafe uint signalSemaphoreCount;
		public unsafe uint* signalSemaphoreDeviceIndices;
	}

	public struct DeviceGroupBindSparseInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint resourceDeviceIndex;
		public unsafe uint memoryDeviceIndex;
	}

	public struct DeviceGroupPresentCapabilitiesKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe fixed uint presentMask[Constants.MaxDeviceGroupSize];
		public unsafe DeviceGroupPresentModeFlagsKHR modes;
	}

	public struct ImageSwapchainCreateInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe SwapchainKHR swapchain;
	}

	public struct BindImageMemorySwapchainInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe SwapchainKHR swapchain;
		public unsafe uint imageIndex;
	}

	public struct AcquireNextImageInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe SwapchainKHR swapchain;
		public unsafe ulong timeout;
		public unsafe Semaphore semaphore;
		public unsafe Fence fence;
		public unsafe uint deviceMask;
	}

	public struct DeviceGroupPresentInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint swapchainCount;
		public unsafe uint* deviceMasks;
		public unsafe DeviceGroupPresentModeFlagsKHR mode;
	}

	public struct DeviceGroupDeviceCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint physicalDeviceCount;
		public unsafe PhysicalDevice* physicalDevices;
	}

	public struct DeviceGroupSwapchainCreateInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DeviceGroupPresentModeFlagsKHR modes;
	}

	public struct DescriptorUpdateTemplateEntry {
		public unsafe uint dstBinding;
		public unsafe uint dstArrayElement;
		public unsafe uint descriptorCount;
		public unsafe DescriptorType descriptorType;
		public unsafe nuint offset;
		public unsafe nuint stride;
	}

	public struct DescriptorUpdateTemplateCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DescriptorUpdateTemplateCreateFlags flags;
		public unsafe uint descriptorUpdateEntryCount;
		public unsafe DescriptorUpdateTemplateEntry* descriptorUpdateEntries;
		public unsafe DescriptorUpdateTemplateType templateType;
		public unsafe DescriptorSetLayout descriptorSetLayout;
		public unsafe PipelineBindPoint pipelineBindPoint;
		public unsafe PipelineLayout pipelineLayout;
		public unsafe uint set;
	}

	public struct XYColorEXT {
		public unsafe float x;
		public unsafe float y;
	}

	public struct HdrMetadataEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe XYColorEXT displayPrimaryRed;
		public unsafe XYColorEXT displayPrimaryGreen;
		public unsafe XYColorEXT displayPrimaryBlue;
		public unsafe XYColorEXT whitePoint;
		public unsafe float maxLuminance;
		public unsafe float minLuminance;
		public unsafe float maxContentLightLevel;
		public unsafe float maxFrameAverageLightLevel;
	}

	public struct DisplayNativeHdrSurfaceCapabilitiesAMD {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 localDimmingSupport;
	}

	public struct SwapchainDisplayNativeHdrCreateInfoAMD {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 localDimmingEnable;
	}

	public struct RefreshCycleDurationGOOGLE {
		public unsafe ulong refreshDuration;
	}

	public struct PastPresentationTimingGOOGLE {
		public unsafe uint presentID;
		public unsafe ulong desiredPresentTime;
		public unsafe ulong actualPresentTime;
		public unsafe ulong earliestPresentTime;
		public unsafe ulong presentMargin;
	}

	public struct PresentTimesInfoGOOGLE {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint swapchainCount;
		public unsafe PresentTimeGOOGLE* times;
	}

	public struct PresentTimeGOOGLE {
		public unsafe uint presentID;
		public unsafe ulong desiredPresentTime;
	}

	public struct IOSSurfaceCreateInfoMVK {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe IOSSurfaceCreateFlagsMVK flags;
		public unsafe void* view;
	}

	public struct MacOSSurfaceCreateInfoMVK {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe MacOSSurfaceCreateFlagsMVK flags;
		public unsafe void* view;
	}

	public struct MetalSurfaceCreateInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe MetalSurfaceCreateFlagsEXT flags;
		public unsafe void* layer;
	}

	public struct ViewportWScalingNV {
		public unsafe float xcoeff;
		public unsafe float ycoeff;
	}

	public struct PipelineViewportWScalingStateCreateInfoNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 viewportWScalingEnable;
		public unsafe uint viewportCount;
		public unsafe ViewportWScalingNV* viewportWScalings;
	}

	public struct ViewportSwizzleNV {
		public unsafe ViewportCoordinateSwizzleNV x;
		public unsafe ViewportCoordinateSwizzleNV y;
		public unsafe ViewportCoordinateSwizzleNV z;
		public unsafe ViewportCoordinateSwizzleNV w;
	}

	public struct PipelineViewportSwizzleStateCreateInfoNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineViewportSwizzleStateCreateFlagsNV flags;
		public unsafe uint viewportCount;
		public unsafe ViewportSwizzleNV* viewportSwizzles;
	}

	public struct PhysicalDeviceDiscardRectanglePropertiesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint maxDiscardRectangles;
	}

	public struct PipelineDiscardRectangleStateCreateInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineDiscardRectangleStateCreateFlagsEXT flags;
		public unsafe DiscardRectangleModeEXT discardRectangleMode;
		public unsafe uint discardRectangleCount;
		public unsafe Rect2D* discardRectangles;
	}

	public struct PhysicalDeviceMultiviewPerViewAttributesPropertiesNVX {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 perViewPositionAllComponents;
	}

	public struct InputAttachmentAspectReference {
		public unsafe uint subpass;
		public unsafe uint inputAttachmentIndex;
		public unsafe ImageAspectFlags aspectMask;
	}

	public struct RenderPassInputAttachmentAspectCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint aspectReferenceCount;
		public unsafe InputAttachmentAspectReference* aspectReferences;
	}

	public struct PhysicalDeviceSurfaceInfo2KHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe SurfaceKHR surface;
	}

	public struct SurfaceCapabilities2KHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe SurfaceCapabilitiesKHR surfaceCapabilities;
	}

	public struct SurfaceFormat2KHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe SurfaceFormatKHR surfaceFormat;
	}

	public struct DisplayProperties2KHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DisplayPropertiesKHR displayProperties;
	}

	public struct DisplayPlaneProperties2KHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DisplayPlanePropertiesKHR displayPlaneProperties;
	}

	public struct DisplayModeProperties2KHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DisplayModePropertiesKHR displayModeProperties;
	}

	public struct DisplayPlaneInfo2KHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DisplayModeKHR mode;
		public unsafe uint planeIndex;
	}

	public struct DisplayPlaneCapabilities2KHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DisplayPlaneCapabilitiesKHR capabilities;
	}

	public struct SharedPresentSurfaceCapabilitiesKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ImageUsageFlags sharedPresentSupportedUsageFlags;
	}

	public struct PhysicalDevice16BitStorageFeatures {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 storageBuffer16BitAccess;
		public unsafe Bool32 uniformAndStorageBuffer16BitAccess;
		public unsafe Bool32 storagePushConstant16;
		public unsafe Bool32 storageInputOutput16;
	}

	public struct PhysicalDeviceSubgroupProperties {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint subgroupSize;
		public unsafe ShaderStageFlags supportedStages;
		public unsafe SubgroupFeatureFlags supportedOperations;
		public unsafe Bool32 quadOperationsInAllStages;
	}

	public struct PhysicalDeviceShaderSubgroupExtendedTypesFeatures {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 shaderSubgroupExtendedTypes;
	}

	public struct BufferMemoryRequirementsInfo2 {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Buffer buffer;
	}

	public struct ImageMemoryRequirementsInfo2 {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Image image;
	}

	public struct ImageSparseMemoryRequirementsInfo2 {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Image image;
	}

	public struct MemoryRequirements2 {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe MemoryRequirements memoryRequirements;
	}

	public struct SparseImageMemoryRequirements2 {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe SparseImageMemoryRequirements memoryRequirements;
	}

	public struct PhysicalDevicePointClippingProperties {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PointClippingBehavior pointClippingBehavior;
	}

	public struct MemoryDedicatedRequirements {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 prefersDedicatedAllocation;
		public unsafe Bool32 requiresDedicatedAllocation;
	}

	public struct MemoryDedicatedAllocateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Image image;
		public unsafe Buffer buffer;
	}

	public struct ImageViewUsageCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ImageUsageFlags usage;
	}

	public struct PipelineTessellationDomainOriginStateCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe TessellationDomainOrigin domainOrigin;
	}

	public struct SamplerYcbcrConversionInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe SamplerYcbcrConversion conversion;
	}

	public struct SamplerYcbcrConversionCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Format format;
		public unsafe SamplerYcbcrModelConversion ycbcrModel;
		public unsafe SamplerYcbcrRange ycbcrRange;
		public unsafe ComponentMapping components;
		public unsafe ChromaLocation xChromaOffset;
		public unsafe ChromaLocation yChromaOffset;
		public unsafe Filter chromaFilter;
		public unsafe Bool32 forceExplicitReconstruction;
	}

	public struct BindImagePlaneMemoryInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ImageAspectFlags planeAspect;
	}

	public struct ImagePlaneMemoryRequirementsInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ImageAspectFlags planeAspect;
	}

	public struct PhysicalDeviceSamplerYcbcrConversionFeatures {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 samplerYcbcrConversion;
	}

	public struct SamplerYcbcrConversionImageFormatProperties {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint combinedImageSamplerDescriptorCount;
	}

	public struct TextureLODGatherFormatPropertiesAMD {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 supportsTextureGatherLODBiasAMD;
	}

	public struct ConditionalRenderingBeginInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Buffer buffer;
		public unsafe DeviceSize offset;
		public unsafe ConditionalRenderingFlagsEXT flags;
	}

	public struct ProtectedSubmitInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 protectedSubmit;
	}

	public struct PhysicalDeviceProtectedMemoryFeatures {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 protectedMemory;
	}

	public struct PhysicalDeviceProtectedMemoryProperties {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 protectedNoFault;
	}

	public struct DeviceQueueInfo2 {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DeviceQueueCreateFlags flags;
		public unsafe uint queueFamilyIndex;
		public unsafe uint queueIndex;
	}

	public struct PipelineCoverageToColorStateCreateInfoNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineCoverageToColorStateCreateFlagsNV flags;
		public unsafe Bool32 coverageToColorEnable;
		public unsafe uint coverageToColorLocation;
	}

	public struct PhysicalDeviceSamplerFilterMinmaxProperties {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 filterMinmaxSingleComponentFormats;
		public unsafe Bool32 filterMinmaxImageComponentMapping;
	}

	public struct SampleLocationEXT {
		public unsafe float x;
		public unsafe float y;
	}

	public struct SampleLocationsInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe SampleCountFlags sampleLocationsPerPixel;
		public unsafe Extent2D sampleLocationGridSize;
		public unsafe uint sampleLocationsCount;
		public unsafe SampleLocationEXT* sampleLocations;
	}

	public struct AttachmentSampleLocationsEXT {
		public unsafe uint attachmentIndex;
		public unsafe SampleLocationsInfoEXT sampleLocationsInfo;
	}

	public struct SubpassSampleLocationsEXT {
		public unsafe uint subpassIndex;
		public unsafe SampleLocationsInfoEXT sampleLocationsInfo;
	}

	public struct RenderPassSampleLocationsBeginInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint attachmentInitialSampleLocationsCount;
		public unsafe AttachmentSampleLocationsEXT* attachmentInitialSampleLocations;
		public unsafe uint postSubpassSampleLocationsCount;
		public unsafe SubpassSampleLocationsEXT* postSubpassSampleLocations;
	}

	public struct PipelineSampleLocationsStateCreateInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 sampleLocationsEnable;
		public unsafe SampleLocationsInfoEXT sampleLocationsInfo;
	}

	public struct PhysicalDeviceSampleLocationsPropertiesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe SampleCountFlags sampleLocationSampleCounts;
		public unsafe Extent2D maxSampleLocationGridSize;
		public unsafe fixed float sampleLocationCoordinateRange[2];
		public unsafe uint sampleLocationSubPixelBits;
		public unsafe Bool32 variableSampleLocations;
	}

	public struct MultisamplePropertiesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Extent2D maxSampleLocationGridSize;
	}

	public struct SamplerReductionModeCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe SamplerReductionMode reductionMode;
	}

	public struct PhysicalDeviceBlendOperationAdvancedFeaturesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 advancedBlendCoherentOperations;
	}

	public struct PhysicalDeviceBlendOperationAdvancedPropertiesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint advancedBlendMaxColorAttachments;
		public unsafe Bool32 advancedBlendIndependentBlend;
		public unsafe Bool32 advancedBlendNonPremultipliedSrcColor;
		public unsafe Bool32 advancedBlendNonPremultipliedDstColor;
		public unsafe Bool32 advancedBlendCorrelatedOverlap;
		public unsafe Bool32 advancedBlendAllOperations;
	}

	public struct PipelineColorBlendAdvancedStateCreateInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 srcPremultiplied;
		public unsafe Bool32 dstPremultiplied;
		public unsafe BlendOverlapEXT blendOverlap;
	}

	public struct PhysicalDeviceInlineUniformBlockFeaturesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 inlineUniformBlock;
		public unsafe Bool32 descriptorBindingInlineUniformBlockUpdateAfterBind;
	}

	public struct PhysicalDeviceInlineUniformBlockPropertiesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint maxInlineUniformBlockSize;
		public unsafe uint maxPerStageDescriptorInlineUniformBlocks;
		public unsafe uint maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
		public unsafe uint maxDescriptorSetInlineUniformBlocks;
		public unsafe uint maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
	}

	public struct WriteDescriptorSetInlineUniformBlockEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint dataSize;
		public unsafe void* data;
	}

	public struct DescriptorPoolInlineUniformBlockCreateInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint maxInlineUniformBlockBindings;
	}

	public struct PipelineCoverageModulationStateCreateInfoNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineCoverageModulationStateCreateFlagsNV flags;
		public unsafe CoverageModulationModeNV coverageModulationMode;
		public unsafe Bool32 coverageModulationTableEnable;
		public unsafe uint coverageModulationTableCount;
		public unsafe float* coverageModulationTable;
	}

	public struct ImageFormatListCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint viewFormatCount;
		public unsafe Format* viewFormats;
	}

	public struct ValidationCacheCreateInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ValidationCacheCreateFlagsEXT flags;
		public unsafe nuint initialDataSize;
		public unsafe void* initialData;
	}

	public struct ShaderModuleValidationCacheCreateInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ValidationCacheEXT validationCache;
	}

	public struct PhysicalDeviceMaintenance3Properties {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint maxPerSetDescriptors;
		public unsafe DeviceSize maxMemoryAllocationSize;
	}

	public struct DescriptorSetLayoutSupport {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 supported;
	}

	public struct PhysicalDeviceShaderDrawParametersFeatures {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 shaderDrawParameters;
	}

	public struct PhysicalDeviceShaderFloat16Int8Features {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 shaderFloat16;
		public unsafe Bool32 shaderInt8;
	}

	public struct PhysicalDeviceFloatControlsProperties {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ShaderFloatControlsIndependence denormBehaviorIndependence;
		public unsafe ShaderFloatControlsIndependence roundingModeIndependence;
		public unsafe Bool32 shaderSignedZeroInfNanPreserveFloat16;
		public unsafe Bool32 shaderSignedZeroInfNanPreserveFloat32;
		public unsafe Bool32 shaderSignedZeroInfNanPreserveFloat64;
		public unsafe Bool32 shaderDenormPreserveFloat16;
		public unsafe Bool32 shaderDenormPreserveFloat32;
		public unsafe Bool32 shaderDenormPreserveFloat64;
		public unsafe Bool32 shaderDenormFlushToZeroFloat16;
		public unsafe Bool32 shaderDenormFlushToZeroFloat32;
		public unsafe Bool32 shaderDenormFlushToZeroFloat64;
		public unsafe Bool32 shaderRoundingModeRTEFloat16;
		public unsafe Bool32 shaderRoundingModeRTEFloat32;
		public unsafe Bool32 shaderRoundingModeRTEFloat64;
		public unsafe Bool32 shaderRoundingModeRTZFloat16;
		public unsafe Bool32 shaderRoundingModeRTZFloat32;
		public unsafe Bool32 shaderRoundingModeRTZFloat64;
	}

	public struct PhysicalDeviceHostQueryResetFeatures {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 hostQueryReset;
	}

	public struct NativeBufferUsage2ANDROID {
		public unsafe ulong consumer;
		public unsafe ulong producer;
	}

	public struct NativeBufferANDROID {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe void* handle;
		public unsafe short stride;
		public unsafe short format;
		public unsafe short usage;
		public unsafe NativeBufferUsage2ANDROID usage2;
	}

	public struct SwapchainImageCreateInfoANDROID {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe SwapchainImageUsageFlagsANDROID usage;
	}

	public struct PhysicalDevicePresentationPropertiesANDROID {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 sharedImage;
	}

	public struct ShaderResourceUsageAMD {
		public unsafe uint numUsedVgprs;
		public unsafe uint numUsedSgprs;
		public unsafe uint ldsSizePerLocalWorkGroup;
		public unsafe nuint ldsUsageSizeInBytes;
		public unsafe nuint scratchMemUsageInBytes;
	}

	public struct ShaderStatisticsInfoAMD {
		public unsafe ShaderStageFlags shaderStageMask;
		public unsafe ShaderResourceUsageAMD resourceUsage;
		public unsafe uint numPhysicalVgprs;
		public unsafe uint numPhysicalSgprs;
		public unsafe uint numAvailableVgprs;
		public unsafe uint numAvailableSgprs;
		public unsafe fixed uint computeWorkGroupSize[3];
	}

	public struct DeviceQueueGlobalPriorityCreateInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe QueueGlobalPriorityEXT globalPriority;
	}

	public struct DebugUtilsObjectNameInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ObjectType objectType;
		public unsafe ulong objectHandle;
		public unsafe byte* objectName;
	}

	public struct DebugUtilsObjectTagInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ObjectType objectType;
		public unsafe ulong objectHandle;
		public unsafe ulong tagName;
		public unsafe nuint tagSize;
		public unsafe void* tag;
	}

	public struct DebugUtilsLabelEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe byte* labelName;
		public unsafe fixed float color[4];
	}

	public struct DebugUtilsMessengerCreateInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DebugUtilsMessengerCreateFlagsEXT flags;
		public unsafe DebugUtilsMessageSeverityFlagsEXT messageSeverity;
		public unsafe DebugUtilsMessageTypeFlagsEXT messageType;
		public unsafe IntPtr pfnUserCallback;
		public unsafe void* userData;
	}

	public struct DebugUtilsMessengerCallbackDataEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DebugUtilsMessengerCallbackDataFlagsEXT flags;
		public unsafe byte* messageIdName;
		public unsafe int messageIdNumber;
		public unsafe byte* message;
		public unsafe uint queueLabelCount;
		public unsafe DebugUtilsLabelEXT* queueLabels;
		public unsafe uint cmdBufLabelCount;
		public unsafe DebugUtilsLabelEXT* cmdBufLabels;
		public unsafe uint objectCount;
		public unsafe DebugUtilsObjectNameInfoEXT* objects;
	}

	public struct ImportMemoryHostPointerInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ExternalMemoryHandleTypeFlags handleType;
		public unsafe void* hostPointer;
	}

	public struct MemoryHostPointerPropertiesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint memoryTypeBits;
	}

	public struct PhysicalDeviceExternalMemoryHostPropertiesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DeviceSize minImportedHostPointerAlignment;
	}

	public struct PhysicalDeviceConservativeRasterizationPropertiesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe float primitiveOverestimationSize;
		public unsafe float maxExtraPrimitiveOverestimationSize;
		public unsafe float extraPrimitiveOverestimationSizeGranularity;
		public unsafe Bool32 primitiveUnderestimation;
		public unsafe Bool32 conservativePointAndLineRasterization;
		public unsafe Bool32 degenerateTrianglesRasterized;
		public unsafe Bool32 degenerateLinesRasterized;
		public unsafe Bool32 fullyCoveredFragmentShaderInputVariable;
		public unsafe Bool32 conservativeRasterizationPostDepthCoverage;
	}

	public struct CalibratedTimestampInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe TimeDomainEXT timeDomain;
	}

	public struct PhysicalDeviceShaderCorePropertiesAMD {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint shaderEngineCount;
		public unsafe uint shaderArraysPerEngineCount;
		public unsafe uint computeUnitsPerShaderArray;
		public unsafe uint simdPerComputeUnit;
		public unsafe uint wavefrontsPerSimd;
		public unsafe uint wavefrontSize;
		public unsafe uint sgprsPerSimd;
		public unsafe uint minSgprAllocation;
		public unsafe uint maxSgprAllocation;
		public unsafe uint sgprAllocationGranularity;
		public unsafe uint vgprsPerSimd;
		public unsafe uint minVgprAllocation;
		public unsafe uint maxVgprAllocation;
		public unsafe uint vgprAllocationGranularity;
	}

	public struct PhysicalDeviceShaderCoreProperties2AMD {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ShaderCorePropertiesFlagsAMD shaderCoreFeatures;
		public unsafe uint activeComputeUnitCount;
	}

	public struct PipelineRasterizationConservativeStateCreateInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineRasterizationConservativeStateCreateFlagsEXT flags;
		public unsafe ConservativeRasterizationModeEXT conservativeRasterizationMode;
		public unsafe float extraPrimitiveOverestimationSize;
	}

	public struct PhysicalDeviceDescriptorIndexingFeatures {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 shaderInputAttachmentArrayDynamicIndexing;
		public unsafe Bool32 shaderUniformTexelBufferArrayDynamicIndexing;
		public unsafe Bool32 shaderStorageTexelBufferArrayDynamicIndexing;
		public unsafe Bool32 shaderUniformBufferArrayNonUniformIndexing;
		public unsafe Bool32 shaderSampledImageArrayNonUniformIndexing;
		public unsafe Bool32 shaderStorageBufferArrayNonUniformIndexing;
		public unsafe Bool32 shaderStorageImageArrayNonUniformIndexing;
		public unsafe Bool32 shaderInputAttachmentArrayNonUniformIndexing;
		public unsafe Bool32 shaderUniformTexelBufferArrayNonUniformIndexing;
		public unsafe Bool32 shaderStorageTexelBufferArrayNonUniformIndexing;
		public unsafe Bool32 descriptorBindingUniformBufferUpdateAfterBind;
		public unsafe Bool32 descriptorBindingSampledImageUpdateAfterBind;
		public unsafe Bool32 descriptorBindingStorageImageUpdateAfterBind;
		public unsafe Bool32 descriptorBindingStorageBufferUpdateAfterBind;
		public unsafe Bool32 descriptorBindingUniformTexelBufferUpdateAfterBind;
		public unsafe Bool32 descriptorBindingStorageTexelBufferUpdateAfterBind;
		public unsafe Bool32 descriptorBindingUpdateUnusedWhilePending;
		public unsafe Bool32 descriptorBindingPartiallyBound;
		public unsafe Bool32 descriptorBindingVariableDescriptorCount;
		public unsafe Bool32 runtimeDescriptorArray;
	}

	public struct PhysicalDeviceDescriptorIndexingProperties {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint maxUpdateAfterBindDescriptorsInAllPools;
		public unsafe Bool32 shaderUniformBufferArrayNonUniformIndexingNative;
		public unsafe Bool32 shaderSampledImageArrayNonUniformIndexingNative;
		public unsafe Bool32 shaderStorageBufferArrayNonUniformIndexingNative;
		public unsafe Bool32 shaderStorageImageArrayNonUniformIndexingNative;
		public unsafe Bool32 shaderInputAttachmentArrayNonUniformIndexingNative;
		public unsafe Bool32 robustBufferAccessUpdateAfterBind;
		public unsafe Bool32 quadDivergentImplicitLod;
		public unsafe uint maxPerStageDescriptorUpdateAfterBindSamplers;
		public unsafe uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;
		public unsafe uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;
		public unsafe uint maxPerStageDescriptorUpdateAfterBindSampledImages;
		public unsafe uint maxPerStageDescriptorUpdateAfterBindStorageImages;
		public unsafe uint maxPerStageDescriptorUpdateAfterBindInputAttachments;
		public unsafe uint maxPerStageUpdateAfterBindResources;
		public unsafe uint maxDescriptorSetUpdateAfterBindSamplers;
		public unsafe uint maxDescriptorSetUpdateAfterBindUniformBuffers;
		public unsafe uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
		public unsafe uint maxDescriptorSetUpdateAfterBindStorageBuffers;
		public unsafe uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
		public unsafe uint maxDescriptorSetUpdateAfterBindSampledImages;
		public unsafe uint maxDescriptorSetUpdateAfterBindStorageImages;
		public unsafe uint maxDescriptorSetUpdateAfterBindInputAttachments;
	}

	public struct DescriptorSetLayoutBindingFlagsCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint bindingCount;
		public unsafe DescriptorBindingFlags* bindingFlags;
	}

	public struct DescriptorSetVariableDescriptorCountAllocateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint descriptorSetCount;
		public unsafe uint* descriptorCounts;
	}

	public struct DescriptorSetVariableDescriptorCountLayoutSupport {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint maxVariableDescriptorCount;
	}

	public struct AttachmentDescription2 {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe AttachmentDescriptionFlags flags;
		public unsafe Format format;
		public unsafe SampleCountFlags samples;
		public unsafe AttachmentLoadOp loadOp;
		public unsafe AttachmentStoreOp storeOp;
		public unsafe AttachmentLoadOp stencilLoadOp;
		public unsafe AttachmentStoreOp stencilStoreOp;
		public unsafe ImageLayout initialLayout;
		public unsafe ImageLayout finalLayout;
	}

	public struct AttachmentReference2 {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint attachment;
		public unsafe ImageLayout layout;
		public unsafe ImageAspectFlags aspectMask;
	}

	public struct SubpassDescription2 {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe SubpassDescriptionFlags flags;
		public unsafe PipelineBindPoint pipelineBindPoint;
		public unsafe uint viewMask;
		public unsafe uint inputAttachmentCount;
		public unsafe AttachmentReference2* inputAttachments;
		public unsafe uint colorAttachmentCount;
		public unsafe AttachmentReference2* colorAttachments;
		public unsafe AttachmentReference2* resolveAttachments;
		public unsafe AttachmentReference2* depthStencilAttachment;
		public unsafe uint preserveAttachmentCount;
		public unsafe uint* preserveAttachments;
	}

	public struct SubpassDependency2 {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint srcSubpass;
		public unsafe uint dstSubpass;
		public unsafe PipelineStageFlags srcStageMask;
		public unsafe PipelineStageFlags dstStageMask;
		public unsafe AccessFlags srcAccessMask;
		public unsafe AccessFlags dstAccessMask;
		public unsafe DependencyFlags dependencyFlags;
		public unsafe int viewOffset;
	}

	public struct RenderPassCreateInfo2 {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe RenderPassCreateFlags flags;
		public unsafe uint attachmentCount;
		public unsafe AttachmentDescription2* attachments;
		public unsafe uint subpassCount;
		public unsafe SubpassDescription2* subpasses;
		public unsafe uint dependencyCount;
		public unsafe SubpassDependency2* dependencies;
		public unsafe uint correlatedViewMaskCount;
		public unsafe uint* correlatedViewMasks;
	}

	public struct SubpassBeginInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe SubpassContents contents;
	}

	public struct SubpassEndInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
	}

	public struct PhysicalDeviceTimelineSemaphoreFeatures {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 timelineSemaphore;
	}

	public struct PhysicalDeviceTimelineSemaphoreProperties {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ulong maxTimelineSemaphoreValueDifference;
	}

	public struct SemaphoreTypeCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe SemaphoreType semaphoreType;
		public unsafe ulong initialValue;
	}

	public struct TimelineSemaphoreSubmitInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint waitSemaphoreValueCount;
		public unsafe ulong* waitSemaphoreValues;
		public unsafe uint signalSemaphoreValueCount;
		public unsafe ulong* signalSemaphoreValues;
	}

	public struct SemaphoreWaitInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe SemaphoreWaitFlags flags;
		public unsafe uint semaphoreCount;
		public unsafe Semaphore* semaphores;
		public unsafe ulong* values;
	}

	public struct SemaphoreSignalInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Semaphore semaphore;
		public unsafe ulong value;
	}

	public struct VertexInputBindingDivisorDescriptionEXT {
		public unsafe uint binding;
		public unsafe uint divisor;
	}

	public struct PipelineVertexInputDivisorStateCreateInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint vertexBindingDivisorCount;
		public unsafe VertexInputBindingDivisorDescriptionEXT* vertexBindingDivisors;
	}

	public struct PhysicalDeviceVertexAttributeDivisorPropertiesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint maxVertexAttribDivisor;
	}

	public struct PhysicalDevicePCIBusInfoPropertiesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint pciDomain;
		public unsafe uint pciBus;
		public unsafe uint pciDevice;
		public unsafe uint pciFunction;
	}

	public struct ImportAndroidHardwareBufferInfoANDROID {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe void** buffer;
	}

	public struct AndroidHardwareBufferUsageANDROID {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ulong androidHardwareBufferUsage;
	}

	public struct AndroidHardwareBufferPropertiesANDROID {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DeviceSize allocationSize;
		public unsafe uint memoryTypeBits;
	}

	public struct MemoryGetAndroidHardwareBufferInfoANDROID {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DeviceMemory memory;
	}

	public struct AndroidHardwareBufferFormatPropertiesANDROID {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Format format;
		public unsafe ulong externalFormat;
		public unsafe FormatFeatureFlags formatFeatures;
		public unsafe ComponentMapping samplerYcbcrConversionComponents;
		public unsafe SamplerYcbcrModelConversion suggestedYcbcrModel;
		public unsafe SamplerYcbcrRange suggestedYcbcrRange;
		public unsafe ChromaLocation suggestedXChromaOffset;
		public unsafe ChromaLocation suggestedYChromaOffset;
	}

	public struct CommandBufferInheritanceConditionalRenderingInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 conditionalRenderingEnable;
	}

	public struct ExternalFormatANDROID {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ulong externalFormat;
	}

	public struct PhysicalDevice8BitStorageFeatures {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 storageBuffer8BitAccess;
		public unsafe Bool32 uniformAndStorageBuffer8BitAccess;
		public unsafe Bool32 storagePushConstant8;
	}

	public struct PhysicalDeviceConditionalRenderingFeaturesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 conditionalRendering;
		public unsafe Bool32 inheritedConditionalRendering;
	}

	public struct PhysicalDeviceVulkanMemoryModelFeatures {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 vulkanMemoryModel;
		public unsafe Bool32 vulkanMemoryModelDeviceScope;
		public unsafe Bool32 vulkanMemoryModelAvailabilityVisibilityChains;
	}

	public struct PhysicalDeviceShaderAtomicInt64Features {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 shaderBufferInt64Atomics;
		public unsafe Bool32 shaderSharedInt64Atomics;
	}

	public struct PhysicalDeviceVertexAttributeDivisorFeaturesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 vertexAttributeInstanceRateDivisor;
		public unsafe Bool32 vertexAttributeInstanceRateZeroDivisor;
	}

	public struct QueueFamilyCheckpointPropertiesNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineStageFlags checkpointExecutionStageMask;
	}

	public struct CheckpointDataNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineStageFlags stage;
		public unsafe void* checkpointMarker;
	}

	public struct PhysicalDeviceDepthStencilResolveProperties {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ResolveModeFlags supportedDepthResolveModes;
		public unsafe ResolveModeFlags supportedStencilResolveModes;
		public unsafe Bool32 independentResolveNone;
		public unsafe Bool32 independentResolve;
	}

	public struct SubpassDescriptionDepthStencilResolve {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ResolveModeFlags depthResolveMode;
		public unsafe ResolveModeFlags stencilResolveMode;
		public unsafe AttachmentReference2* depthStencilResolveAttachment;
	}

	public struct ImageViewASTCDecodeModeEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Format decodeMode;
	}

	public struct PhysicalDeviceASTCDecodeFeaturesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 decodeModeSharedExponent;
	}

	public struct PhysicalDeviceTransformFeedbackFeaturesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 transformFeedback;
		public unsafe Bool32 geometryStreams;
	}

	public struct PhysicalDeviceTransformFeedbackPropertiesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint maxTransformFeedbackStreams;
		public unsafe uint maxTransformFeedbackBuffers;
		public unsafe DeviceSize maxTransformFeedbackBufferSize;
		public unsafe uint maxTransformFeedbackStreamDataSize;
		public unsafe uint maxTransformFeedbackBufferDataSize;
		public unsafe uint maxTransformFeedbackBufferDataStride;
		public unsafe Bool32 transformFeedbackQueries;
		public unsafe Bool32 transformFeedbackStreamsLinesTriangles;
		public unsafe Bool32 transformFeedbackRasterizationStreamSelect;
		public unsafe Bool32 transformFeedbackDraw;
	}

	public struct PipelineRasterizationStateStreamCreateInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineRasterizationStateStreamCreateFlagsEXT flags;
		public unsafe uint rasterizationStream;
	}

	public struct PhysicalDeviceRepresentativeFragmentTestFeaturesNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 representativeFragmentTest;
	}

	public struct PipelineRepresentativeFragmentTestStateCreateInfoNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 representativeFragmentTestEnable;
	}

	public struct PhysicalDeviceExclusiveScissorFeaturesNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 exclusiveScissor;
	}

	public struct PipelineViewportExclusiveScissorStateCreateInfoNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint exclusiveScissorCount;
		public unsafe Rect2D* exclusiveScissors;
	}

	public struct PhysicalDeviceCornerSampledImageFeaturesNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 cornerSampledImage;
	}

	public struct PhysicalDeviceComputeShaderDerivativesFeaturesNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 computeDerivativeGroupQuads;
		public unsafe Bool32 computeDerivativeGroupLinear;
	}

	public struct PhysicalDeviceFragmentShaderBarycentricFeaturesNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 fragmentShaderBarycentric;
	}

	public struct PhysicalDeviceShaderImageFootprintFeaturesNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 imageFootprint;
	}

	public struct PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 dedicatedAllocationImageAliasing;
	}

	public struct ShadingRatePaletteNV {
		public unsafe uint shadingRatePaletteEntryCount;
		public unsafe ShadingRatePaletteEntryNV* shadingRatePaletteEntries;
	}

	public struct PipelineViewportShadingRateImageStateCreateInfoNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 shadingRateImageEnable;
		public unsafe uint viewportCount;
		public unsafe ShadingRatePaletteNV* shadingRatePalettes;
	}

	public struct PhysicalDeviceShadingRateImageFeaturesNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 shadingRateImage;
		public unsafe Bool32 shadingRateCoarseSampleOrder;
	}

	public struct PhysicalDeviceShadingRateImagePropertiesNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Extent2D shadingRateTexelSize;
		public unsafe uint shadingRatePaletteSize;
		public unsafe uint shadingRateMaxCoarseSamples;
	}

	public struct CoarseSampleLocationNV {
		public unsafe uint pixelX;
		public unsafe uint pixelY;
		public unsafe uint sample;
	}

	public struct CoarseSampleOrderCustomNV {
		public unsafe ShadingRatePaletteEntryNV shadingRate;
		public unsafe uint sampleCount;
		public unsafe uint sampleLocationCount;
		public unsafe CoarseSampleLocationNV* sampleLocations;
	}

	public struct PipelineViewportCoarseSampleOrderStateCreateInfoNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe CoarseSampleOrderTypeNV sampleOrderType;
		public unsafe uint customSampleOrderCount;
		public unsafe CoarseSampleOrderCustomNV* customSampleOrders;
	}

	public struct PhysicalDeviceMeshShaderFeaturesNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 taskShader;
		public unsafe Bool32 meshShader;
	}

	public struct PhysicalDeviceMeshShaderPropertiesNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint maxDrawMeshTasksCount;
		public unsafe uint maxTaskWorkGroupInvocations;
		public unsafe fixed uint maxTaskWorkGroupSize[3];
		public unsafe uint maxTaskTotalMemorySize;
		public unsafe uint maxTaskOutputCount;
		public unsafe uint maxMeshWorkGroupInvocations;
		public unsafe fixed uint maxMeshWorkGroupSize[3];
		public unsafe uint maxMeshTotalMemorySize;
		public unsafe uint maxMeshOutputVertices;
		public unsafe uint maxMeshOutputPrimitives;
		public unsafe uint maxMeshMultiviewViewCount;
		public unsafe uint meshOutputPerVertexGranularity;
		public unsafe uint meshOutputPerPrimitiveGranularity;
	}

	public struct DrawMeshTasksIndirectCommandNV {
		public unsafe uint taskCount;
		public unsafe uint firstTask;
	}

	public struct RayTracingShaderGroupCreateInfoNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe RayTracingShaderGroupTypeKHR type;
		public unsafe uint generalShader;
		public unsafe uint closestHitShader;
		public unsafe uint anyHitShader;
		public unsafe uint intersectionShader;
	}

	public struct RayTracingShaderGroupCreateInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe RayTracingShaderGroupTypeKHR type;
		public unsafe uint generalShader;
		public unsafe uint closestHitShader;
		public unsafe uint anyHitShader;
		public unsafe uint intersectionShader;
		public unsafe void* shaderGroupCaptureReplayHandle;
	}

	public struct RayTracingPipelineCreateInfoNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineCreateFlags flags;
		public unsafe uint stageCount;
		public unsafe PipelineShaderStageCreateInfo* stages;
		public unsafe uint groupCount;
		public unsafe RayTracingShaderGroupCreateInfoNV* groups;
		public unsafe uint maxRecursionDepth;
		public unsafe PipelineLayout layout;
		public unsafe Pipeline basePipelineHandle;
		public unsafe int basePipelineIndex;
	}

	public struct RayTracingPipelineCreateInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineCreateFlags flags;
		public unsafe uint stageCount;
		public unsafe PipelineShaderStageCreateInfo* stages;
		public unsafe uint groupCount;
		public unsafe RayTracingShaderGroupCreateInfoKHR* groups;
		public unsafe uint maxRecursionDepth;
		public unsafe PipelineLibraryCreateInfoKHR libraries;
		public unsafe RayTracingPipelineInterfaceCreateInfoKHR* libraryInterface;
		public unsafe PipelineLayout layout;
		public unsafe Pipeline basePipelineHandle;
		public unsafe int basePipelineIndex;
	}

	public struct GeometryTrianglesNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Buffer vertexData;
		public unsafe DeviceSize vertexOffset;
		public unsafe uint vertexCount;
		public unsafe DeviceSize vertexStride;
		public unsafe Format vertexFormat;
		public unsafe Buffer indexData;
		public unsafe DeviceSize indexOffset;
		public unsafe uint indexCount;
		public unsafe IndexType indexType;
		public unsafe Buffer transformData;
		public unsafe DeviceSize transformOffset;
	}

	public struct GeometryAABBNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Buffer aabbData;
		public unsafe uint numAABBs;
		public unsafe uint stride;
		public unsafe DeviceSize offset;
	}

	public struct GeometryDataNV {
		public unsafe GeometryTrianglesNV triangles;
		public unsafe GeometryAABBNV aabbs;
	}

	public struct GeometryNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe GeometryTypeKHR geometryType;
		public unsafe GeometryDataNV geometry;
		public unsafe GeometryFlagsKHR flags;
	}

	public struct AccelerationStructureInfoNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe AccelerationStructureTypeNV type;
		public unsafe BuildAccelerationStructureFlagsNV flags;
		public unsafe uint instanceCount;
		public unsafe uint geometryCount;
		public unsafe GeometryNV* geometries;
	}

	public struct AccelerationStructureCreateInfoNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DeviceSize compactedSize;
		public unsafe AccelerationStructureInfoNV info;
	}

	public struct BindAccelerationStructureMemoryInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe AccelerationStructureKHR accelerationStructure;
		public unsafe DeviceMemory memory;
		public unsafe DeviceSize memoryOffset;
		public unsafe uint deviceIndexCount;
		public unsafe uint* deviceIndices;
	}

	public struct WriteDescriptorSetAccelerationStructureKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint accelerationStructureCount;
		public unsafe AccelerationStructureKHR* accelerationStructures;
	}

	public struct AccelerationStructureMemoryRequirementsInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe AccelerationStructureMemoryRequirementsTypeKHR type;
		public unsafe AccelerationStructureBuildTypeKHR buildType;
		public unsafe AccelerationStructureKHR accelerationStructure;
	}

	public struct AccelerationStructureMemoryRequirementsInfoNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe AccelerationStructureMemoryRequirementsTypeNV type;
		public unsafe AccelerationStructureNV accelerationStructure;
	}

	public struct PhysicalDeviceRayTracingFeaturesKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 rayTracing;
		public unsafe Bool32 rayTracingShaderGroupHandleCaptureReplay;
		public unsafe Bool32 rayTracingShaderGroupHandleCaptureReplayMixed;
		public unsafe Bool32 rayTracingAccelerationStructureCaptureReplay;
		public unsafe Bool32 rayTracingIndirectTraceRays;
		public unsafe Bool32 rayTracingIndirectAccelerationStructureBuild;
		public unsafe Bool32 rayTracingHostAccelerationStructureCommands;
		public unsafe Bool32 rayQuery;
		public unsafe Bool32 rayTracingPrimitiveCulling;
	}

	public struct PhysicalDeviceRayTracingPropertiesKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint shaderGroupHandleSize;
		public unsafe uint maxRecursionDepth;
		public unsafe uint maxShaderGroupStride;
		public unsafe uint shaderGroupBaseAlignment;
		public unsafe ulong maxGeometryCount;
		public unsafe ulong maxInstanceCount;
		public unsafe ulong maxPrimitiveCount;
		public unsafe uint maxDescriptorSetAccelerationStructures;
		public unsafe uint shaderGroupHandleCaptureReplaySize;
	}

	public struct PhysicalDeviceRayTracingPropertiesNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint shaderGroupHandleSize;
		public unsafe uint maxRecursionDepth;
		public unsafe uint maxShaderGroupStride;
		public unsafe uint shaderGroupBaseAlignment;
		public unsafe ulong maxGeometryCount;
		public unsafe ulong maxInstanceCount;
		public unsafe ulong maxTriangleCount;
		public unsafe uint maxDescriptorSetAccelerationStructures;
	}

	public struct StridedBufferRegionKHR {
		public unsafe Buffer buffer;
		public unsafe DeviceSize offset;
		public unsafe DeviceSize stride;
		public unsafe DeviceSize size;
	}

	public struct TraceRaysIndirectCommandKHR {
		public unsafe uint width;
		public unsafe uint height;
		public unsafe uint depth;
	}

	public struct DrmFormatModifierPropertiesListEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint drmFormatModifierCount;
		public unsafe DrmFormatModifierPropertiesEXT* drmFormatModifierProperties;
	}

	public struct DrmFormatModifierPropertiesEXT {
		public unsafe ulong drmFormatModifier;
		public unsafe uint drmFormatModifierPlaneCount;
		public unsafe FormatFeatureFlags drmFormatModifierTilingFeatures;
	}

	public struct PhysicalDeviceImageDrmFormatModifierInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ulong drmFormatModifier;
		public unsafe SharingMode sharingMode;
		public unsafe uint queueFamilyIndexCount;
		public unsafe uint* queueFamilyIndices;
	}

	public struct ImageDrmFormatModifierListCreateInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint drmFormatModifierCount;
		public unsafe ulong* drmFormatModifiers;
	}

	public struct ImageDrmFormatModifierExplicitCreateInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ulong drmFormatModifier;
		public unsafe uint drmFormatModifierPlaneCount;
		public unsafe SubresourceLayout* planeLayouts;
	}

	public struct ImageDrmFormatModifierPropertiesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ulong drmFormatModifier;
	}

	public struct ImageStencilUsageCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ImageUsageFlags stencilUsage;
	}

	public struct DeviceMemoryOverallocationCreateInfoAMD {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe MemoryOverallocationBehaviorAMD overallocationBehavior;
	}

	public struct PhysicalDeviceFragmentDensityMapFeaturesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 fragmentDensityMap;
		public unsafe Bool32 fragmentDensityMapDynamic;
		public unsafe Bool32 fragmentDensityMapNonSubsampledImages;
	}

	public struct PhysicalDeviceFragmentDensityMap2FeaturesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 fragmentDensityMapDeferred;
	}

	public struct PhysicalDeviceFragmentDensityMapPropertiesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Extent2D minFragmentDensityTexelSize;
		public unsafe Extent2D maxFragmentDensityTexelSize;
		public unsafe Bool32 fragmentDensityInvocations;
	}

	public struct PhysicalDeviceFragmentDensityMap2PropertiesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 subsampledLoads;
		public unsafe Bool32 subsampledCoarseReconstructionEarlyAccess;
		public unsafe uint maxSubsampledArrayLayers;
		public unsafe uint maxDescriptorSetSubsampledSamplers;
	}

	public struct RenderPassFragmentDensityMapCreateInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe AttachmentReference fragmentDensityMapAttachment;
	}

	public struct PhysicalDeviceScalarBlockLayoutFeatures {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 scalarBlockLayout;
	}

	public struct SurfaceProtectedCapabilitiesKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 supportsProtected;
	}

	public struct PhysicalDeviceUniformBufferStandardLayoutFeatures {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 uniformBufferStandardLayout;
	}

	public struct PhysicalDeviceDepthClipEnableFeaturesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 depthClipEnable;
	}

	public struct PipelineRasterizationDepthClipStateCreateInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineRasterizationDepthClipStateCreateFlagsEXT flags;
		public unsafe Bool32 depthClipEnable;
	}

	public struct PhysicalDeviceMemoryBudgetPropertiesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public DeviceSize heapBudget_0;
		public DeviceSize heapBudget_1;
		public DeviceSize heapBudget_2;
		public DeviceSize heapBudget_3;
		public DeviceSize heapBudget_4;
		public DeviceSize heapBudget_5;
		public DeviceSize heapBudget_6;
		public DeviceSize heapBudget_7;
		public DeviceSize heapBudget_8;
		public DeviceSize heapBudget_9;
		public DeviceSize heapBudget_10;
		public DeviceSize heapBudget_11;
		public DeviceSize heapBudget_12;
		public DeviceSize heapBudget_13;
		public DeviceSize heapBudget_14;
		public DeviceSize heapBudget_15;
		public DeviceSize heapUsage_0;
		public DeviceSize heapUsage_1;
		public DeviceSize heapUsage_2;
		public DeviceSize heapUsage_3;
		public DeviceSize heapUsage_4;
		public DeviceSize heapUsage_5;
		public DeviceSize heapUsage_6;
		public DeviceSize heapUsage_7;
		public DeviceSize heapUsage_8;
		public DeviceSize heapUsage_9;
		public DeviceSize heapUsage_10;
		public DeviceSize heapUsage_11;
		public DeviceSize heapUsage_12;
		public DeviceSize heapUsage_13;
		public DeviceSize heapUsage_14;
		public DeviceSize heapUsage_15;
	}

	public struct PhysicalDeviceMemoryPriorityFeaturesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 memoryPriority;
	}

	public struct MemoryPriorityAllocateInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe float priority;
	}

	public struct PhysicalDeviceBufferDeviceAddressFeatures {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 bufferDeviceAddress;
		public unsafe Bool32 bufferDeviceAddressCaptureReplay;
		public unsafe Bool32 bufferDeviceAddressMultiDevice;
	}

	public struct PhysicalDeviceBufferDeviceAddressFeaturesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 bufferDeviceAddress;
		public unsafe Bool32 bufferDeviceAddressCaptureReplay;
		public unsafe Bool32 bufferDeviceAddressMultiDevice;
	}

	public struct BufferDeviceAddressInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Buffer buffer;
	}

	public struct BufferOpaqueCaptureAddressCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ulong opaqueCaptureAddress;
	}

	public struct BufferDeviceAddressCreateInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DeviceAddress deviceAddress;
	}

	public struct PhysicalDeviceImageViewImageFormatInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ImageViewType imageViewType;
	}

	public struct FilterCubicImageViewImageFormatPropertiesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 filterCubic;
		public unsafe Bool32 filterCubicMinmax;
	}

	public struct PhysicalDeviceImagelessFramebufferFeatures {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 imagelessFramebuffer;
	}

	public struct FramebufferAttachmentsCreateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint attachmentImageInfoCount;
		public unsafe FramebufferAttachmentImageInfo* attachmentImageInfos;
	}

	public struct FramebufferAttachmentImageInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ImageCreateFlags flags;
		public unsafe ImageUsageFlags usage;
		public unsafe uint width;
		public unsafe uint height;
		public unsafe uint layerCount;
		public unsafe uint viewFormatCount;
		public unsafe Format* viewFormats;
	}

	public struct RenderPassAttachmentBeginInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint attachmentCount;
		public unsafe ImageView* attachments;
	}

	public struct PhysicalDeviceTextureCompressionASTCHDRFeaturesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 textureCompressionASTC_HDR;
	}

	public struct PhysicalDeviceCooperativeMatrixFeaturesNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 cooperativeMatrix;
		public unsafe Bool32 cooperativeMatrixRobustBufferAccess;
	}

	public struct PhysicalDeviceCooperativeMatrixPropertiesNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ShaderStageFlags cooperativeMatrixSupportedStages;
	}

	public struct CooperativeMatrixPropertiesNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint MSize;
		public unsafe uint NSize;
		public unsafe uint KSize;
		public unsafe ComponentTypeNV AType;
		public unsafe ComponentTypeNV BType;
		public unsafe ComponentTypeNV CType;
		public unsafe ComponentTypeNV DType;
		public unsafe ScopeNV scope;
	}

	public struct PhysicalDeviceYcbcrImageArraysFeaturesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 ycbcrImageArrays;
	}

	public struct ImageViewHandleInfoNVX {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ImageView imageView;
		public unsafe DescriptorType descriptorType;
		public unsafe Sampler sampler;
	}

	public struct ImageViewAddressPropertiesNVX {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DeviceAddress deviceAddress;
		public unsafe DeviceSize size;
	}

	public struct PresentFrameTokenGGP {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe int frameToken;
	}

	public struct PipelineCreationFeedbackEXT {
		public unsafe PipelineCreationFeedbackFlagsEXT flags;
		public unsafe ulong duration;
	}

	public struct PipelineCreationFeedbackCreateInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineCreationFeedbackEXT* pipelineCreationFeedback;
		public unsafe uint pipelineStageCreationFeedbackCount;
		public unsafe PipelineCreationFeedbackEXT* pipelineStageCreationFeedbacks;
	}

	public struct SurfaceFullScreenExclusiveInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe FullScreenExclusiveEXT fullScreenExclusive;
	}

	public struct SurfaceFullScreenExclusiveWin32InfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe void* hmonitor;
	}

	public struct SurfaceCapabilitiesFullScreenExclusiveEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 fullScreenExclusiveSupported;
	}

	public struct PhysicalDevicePerformanceQueryFeaturesKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 performanceCounterQueryPools;
		public unsafe Bool32 performanceCounterMultipleQueryPools;
	}

	public struct PhysicalDevicePerformanceQueryPropertiesKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 allowCommandBufferQueryCopies;
	}

	public struct PerformanceCounterKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PerformanceCounterUnitKHR unit;
		public unsafe PerformanceCounterScopeKHR scope;
		public unsafe PerformanceCounterStorageKHR storage;
		public unsafe fixed byte uuid[Constants.UuidSize];
	}

	public struct PerformanceCounterDescriptionKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PerformanceCounterDescriptionFlagsKHR flags;
		public unsafe fixed byte name[Constants.MaxDescriptionSize];
		public unsafe fixed byte category[Constants.MaxDescriptionSize];
		public unsafe fixed byte description[Constants.MaxDescriptionSize];
	}

	public struct QueryPoolPerformanceCreateInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint queueFamilyIndex;
		public unsafe uint counterIndexCount;
		public unsafe uint* counterIndices;
	}

	public struct AcquireProfilingLockInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe AcquireProfilingLockFlagsKHR flags;
		public unsafe ulong timeout;
	}

	public struct PerformanceQuerySubmitInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint counterPassIndex;
	}

	public struct HeadlessSurfaceCreateInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe HeadlessSurfaceCreateFlagsEXT flags;
	}

	public struct PhysicalDeviceCoverageReductionModeFeaturesNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 coverageReductionMode;
	}

	public struct PipelineCoverageReductionStateCreateInfoNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineCoverageReductionStateCreateFlagsNV flags;
		public unsafe CoverageReductionModeNV coverageReductionMode;
	}

	public struct FramebufferMixedSamplesCombinationNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe CoverageReductionModeNV coverageReductionMode;
		public unsafe SampleCountFlags rasterizationSamples;
		public unsafe SampleCountFlags depthStencilSamples;
		public unsafe SampleCountFlags colorSamples;
	}

	public struct PhysicalDeviceShaderIntegerFunctions2FeaturesINTEL {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 shaderIntegerFunctions2;
	}

	public struct PerformanceValueINTEL {
		public unsafe PerformanceValueTypeINTEL type;
		public unsafe PerformanceValueDataINTEL data;
	}

	public struct InitializePerformanceApiInfoINTEL {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe void* userData;
	}

	public struct QueryPoolPerformanceQueryCreateInfoINTEL {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe QueryPoolSamplingModeINTEL performanceCountersSampling;
	}

	public struct PerformanceMarkerInfoINTEL {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ulong marker;
	}

	public struct PerformanceStreamMarkerInfoINTEL {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint marker;
	}

	public struct PerformanceOverrideInfoINTEL {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PerformanceOverrideTypeINTEL type;
		public unsafe Bool32 enable;
		public unsafe ulong parameter;
	}

	public struct PerformanceConfigurationAcquireInfoINTEL {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PerformanceConfigurationTypeINTEL type;
	}

	public struct PhysicalDeviceShaderClockFeaturesKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 shaderSubgroupClock;
		public unsafe Bool32 shaderDeviceClock;
	}

	public struct PhysicalDeviceIndexTypeUint8FeaturesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 indexTypeUint8;
	}

	public struct PhysicalDeviceShaderSMBuiltinsPropertiesNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint shaderSMCount;
		public unsafe uint shaderWarpsPerSM;
	}

	public struct PhysicalDeviceShaderSMBuiltinsFeaturesNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 shaderSMBuiltins;
	}

	public struct PhysicalDeviceFragmentShaderInterlockFeaturesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 fragmentShaderSampleInterlock;
		public unsafe Bool32 fragmentShaderPixelInterlock;
		public unsafe Bool32 fragmentShaderShadingRateInterlock;
	}

	public struct PhysicalDeviceSeparateDepthStencilLayoutsFeatures {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 separateDepthStencilLayouts;
	}

	public struct AttachmentReferenceStencilLayout {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ImageLayout stencilLayout;
	}

	public struct AttachmentDescriptionStencilLayout {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ImageLayout stencilInitialLayout;
		public unsafe ImageLayout stencilFinalLayout;
	}

	public struct PhysicalDevicePipelineExecutablePropertiesFeaturesKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 pipelineExecutableInfo;
	}

	public struct PipelineInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Pipeline pipeline;
	}

	public struct PipelineExecutablePropertiesKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ShaderStageFlags stages;
		public unsafe fixed byte name[Constants.MaxDescriptionSize];
		public unsafe fixed byte description[Constants.MaxDescriptionSize];
		public unsafe uint subgroupSize;
	}

	public struct PipelineExecutableInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Pipeline pipeline;
		public unsafe uint executableIndex;
	}

	public struct PipelineExecutableStatisticKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe fixed byte name[Constants.MaxDescriptionSize];
		public unsafe fixed byte description[Constants.MaxDescriptionSize];
		public unsafe PipelineExecutableStatisticFormatKHR format;
		public unsafe PipelineExecutableStatisticValueKHR value;
	}

	public struct PipelineExecutableInternalRepresentationKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe fixed byte name[Constants.MaxDescriptionSize];
		public unsafe fixed byte description[Constants.MaxDescriptionSize];
		public unsafe Bool32 isText;
		public unsafe nuint dataSize;
		public unsafe void* data;
	}

	public struct PhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 shaderDemoteToHelperInvocation;
	}

	public struct PhysicalDeviceTexelBufferAlignmentFeaturesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 texelBufferAlignment;
	}

	public struct PhysicalDeviceTexelBufferAlignmentPropertiesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DeviceSize storageTexelBufferOffsetAlignmentBytes;
		public unsafe Bool32 storageTexelBufferOffsetSingleTexelAlignment;
		public unsafe DeviceSize uniformTexelBufferOffsetAlignmentBytes;
		public unsafe Bool32 uniformTexelBufferOffsetSingleTexelAlignment;
	}

	public struct PhysicalDeviceSubgroupSizeControlFeaturesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 subgroupSizeControl;
		public unsafe Bool32 computeFullSubgroups;
	}

	public struct PhysicalDeviceSubgroupSizeControlPropertiesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint minSubgroupSize;
		public unsafe uint maxSubgroupSize;
		public unsafe uint maxComputeWorkgroupSubgroups;
		public unsafe ShaderStageFlags requiredSubgroupSizeStages;
	}

	public struct PipelineShaderStageRequiredSubgroupSizeCreateInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint requiredSubgroupSize;
	}

	public struct MemoryOpaqueCaptureAddressAllocateInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ulong opaqueCaptureAddress;
	}

	public struct DeviceMemoryOpaqueCaptureAddressInfo {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DeviceMemory memory;
	}

	public struct PhysicalDeviceLineRasterizationFeaturesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 rectangularLines;
		public unsafe Bool32 bresenhamLines;
		public unsafe Bool32 smoothLines;
		public unsafe Bool32 stippledRectangularLines;
		public unsafe Bool32 stippledBresenhamLines;
		public unsafe Bool32 stippledSmoothLines;
	}

	public struct PhysicalDeviceLineRasterizationPropertiesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint lineSubPixelPrecisionBits;
	}

	public struct PipelineRasterizationLineStateCreateInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe LineRasterizationModeEXT lineRasterizationMode;
		public unsafe Bool32 stippledLineEnable;
		public unsafe uint lineStippleFactor;
		public unsafe ushort lineStipplePattern;
	}

	public struct PhysicalDevicePipelineCreationCacheControlFeaturesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 pipelineCreationCacheControl;
	}

	public struct PhysicalDeviceVulkan11Features {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 storageBuffer16BitAccess;
		public unsafe Bool32 uniformAndStorageBuffer16BitAccess;
		public unsafe Bool32 storagePushConstant16;
		public unsafe Bool32 storageInputOutput16;
		public unsafe Bool32 multiview;
		public unsafe Bool32 multiviewGeometryShader;
		public unsafe Bool32 multiviewTessellationShader;
		public unsafe Bool32 variablePointersStorageBuffer;
		public unsafe Bool32 variablePointers;
		public unsafe Bool32 protectedMemory;
		public unsafe Bool32 samplerYcbcrConversion;
		public unsafe Bool32 shaderDrawParameters;
	}

	public struct PhysicalDeviceVulkan11Properties {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe fixed byte deviceUUID[Constants.UuidSize];
		public unsafe fixed byte driverUUID[Constants.UuidSize];
		public unsafe fixed byte deviceLUID[Constants.LuidSize];
		public unsafe uint deviceNodeMask;
		public unsafe Bool32 deviceLUIDValid;
		public unsafe uint subgroupSize;
		public unsafe ShaderStageFlags subgroupSupportedStages;
		public unsafe SubgroupFeatureFlags subgroupSupportedOperations;
		public unsafe Bool32 subgroupQuadOperationsInAllStages;
		public unsafe PointClippingBehavior pointClippingBehavior;
		public unsafe uint maxMultiviewViewCount;
		public unsafe uint maxMultiviewInstanceIndex;
		public unsafe Bool32 protectedNoFault;
		public unsafe uint maxPerSetDescriptors;
		public unsafe DeviceSize maxMemoryAllocationSize;
	}

	public struct PhysicalDeviceVulkan12Features {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 samplerMirrorClampToEdge;
		public unsafe Bool32 drawIndirectCount;
		public unsafe Bool32 storageBuffer8BitAccess;
		public unsafe Bool32 uniformAndStorageBuffer8BitAccess;
		public unsafe Bool32 storagePushConstant8;
		public unsafe Bool32 shaderBufferInt64Atomics;
		public unsafe Bool32 shaderSharedInt64Atomics;
		public unsafe Bool32 shaderFloat16;
		public unsafe Bool32 shaderInt8;
		public unsafe Bool32 descriptorIndexing;
		public unsafe Bool32 shaderInputAttachmentArrayDynamicIndexing;
		public unsafe Bool32 shaderUniformTexelBufferArrayDynamicIndexing;
		public unsafe Bool32 shaderStorageTexelBufferArrayDynamicIndexing;
		public unsafe Bool32 shaderUniformBufferArrayNonUniformIndexing;
		public unsafe Bool32 shaderSampledImageArrayNonUniformIndexing;
		public unsafe Bool32 shaderStorageBufferArrayNonUniformIndexing;
		public unsafe Bool32 shaderStorageImageArrayNonUniformIndexing;
		public unsafe Bool32 shaderInputAttachmentArrayNonUniformIndexing;
		public unsafe Bool32 shaderUniformTexelBufferArrayNonUniformIndexing;
		public unsafe Bool32 shaderStorageTexelBufferArrayNonUniformIndexing;
		public unsafe Bool32 descriptorBindingUniformBufferUpdateAfterBind;
		public unsafe Bool32 descriptorBindingSampledImageUpdateAfterBind;
		public unsafe Bool32 descriptorBindingStorageImageUpdateAfterBind;
		public unsafe Bool32 descriptorBindingStorageBufferUpdateAfterBind;
		public unsafe Bool32 descriptorBindingUniformTexelBufferUpdateAfterBind;
		public unsafe Bool32 descriptorBindingStorageTexelBufferUpdateAfterBind;
		public unsafe Bool32 descriptorBindingUpdateUnusedWhilePending;
		public unsafe Bool32 descriptorBindingPartiallyBound;
		public unsafe Bool32 descriptorBindingVariableDescriptorCount;
		public unsafe Bool32 runtimeDescriptorArray;
		public unsafe Bool32 samplerFilterMinmax;
		public unsafe Bool32 scalarBlockLayout;
		public unsafe Bool32 imagelessFramebuffer;
		public unsafe Bool32 uniformBufferStandardLayout;
		public unsafe Bool32 shaderSubgroupExtendedTypes;
		public unsafe Bool32 separateDepthStencilLayouts;
		public unsafe Bool32 hostQueryReset;
		public unsafe Bool32 timelineSemaphore;
		public unsafe Bool32 bufferDeviceAddress;
		public unsafe Bool32 bufferDeviceAddressCaptureReplay;
		public unsafe Bool32 bufferDeviceAddressMultiDevice;
		public unsafe Bool32 vulkanMemoryModel;
		public unsafe Bool32 vulkanMemoryModelDeviceScope;
		public unsafe Bool32 vulkanMemoryModelAvailabilityVisibilityChains;
		public unsafe Bool32 shaderOutputViewportIndex;
		public unsafe Bool32 shaderOutputLayer;
		public unsafe Bool32 subgroupBroadcastDynamicId;
	}

	public struct PhysicalDeviceVulkan12Properties {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DriverId driverID;
		public unsafe fixed byte driverName[Constants.MaxDriverNameSize];
		public unsafe fixed byte driverInfo[Constants.MaxDriverInfoSize];
		public unsafe ConformanceVersion conformanceVersion;
		public unsafe ShaderFloatControlsIndependence denormBehaviorIndependence;
		public unsafe ShaderFloatControlsIndependence roundingModeIndependence;
		public unsafe Bool32 shaderSignedZeroInfNanPreserveFloat16;
		public unsafe Bool32 shaderSignedZeroInfNanPreserveFloat32;
		public unsafe Bool32 shaderSignedZeroInfNanPreserveFloat64;
		public unsafe Bool32 shaderDenormPreserveFloat16;
		public unsafe Bool32 shaderDenormPreserveFloat32;
		public unsafe Bool32 shaderDenormPreserveFloat64;
		public unsafe Bool32 shaderDenormFlushToZeroFloat16;
		public unsafe Bool32 shaderDenormFlushToZeroFloat32;
		public unsafe Bool32 shaderDenormFlushToZeroFloat64;
		public unsafe Bool32 shaderRoundingModeRTEFloat16;
		public unsafe Bool32 shaderRoundingModeRTEFloat32;
		public unsafe Bool32 shaderRoundingModeRTEFloat64;
		public unsafe Bool32 shaderRoundingModeRTZFloat16;
		public unsafe Bool32 shaderRoundingModeRTZFloat32;
		public unsafe Bool32 shaderRoundingModeRTZFloat64;
		public unsafe uint maxUpdateAfterBindDescriptorsInAllPools;
		public unsafe Bool32 shaderUniformBufferArrayNonUniformIndexingNative;
		public unsafe Bool32 shaderSampledImageArrayNonUniformIndexingNative;
		public unsafe Bool32 shaderStorageBufferArrayNonUniformIndexingNative;
		public unsafe Bool32 shaderStorageImageArrayNonUniformIndexingNative;
		public unsafe Bool32 shaderInputAttachmentArrayNonUniformIndexingNative;
		public unsafe Bool32 robustBufferAccessUpdateAfterBind;
		public unsafe Bool32 quadDivergentImplicitLod;
		public unsafe uint maxPerStageDescriptorUpdateAfterBindSamplers;
		public unsafe uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;
		public unsafe uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;
		public unsafe uint maxPerStageDescriptorUpdateAfterBindSampledImages;
		public unsafe uint maxPerStageDescriptorUpdateAfterBindStorageImages;
		public unsafe uint maxPerStageDescriptorUpdateAfterBindInputAttachments;
		public unsafe uint maxPerStageUpdateAfterBindResources;
		public unsafe uint maxDescriptorSetUpdateAfterBindSamplers;
		public unsafe uint maxDescriptorSetUpdateAfterBindUniformBuffers;
		public unsafe uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
		public unsafe uint maxDescriptorSetUpdateAfterBindStorageBuffers;
		public unsafe uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
		public unsafe uint maxDescriptorSetUpdateAfterBindSampledImages;
		public unsafe uint maxDescriptorSetUpdateAfterBindStorageImages;
		public unsafe uint maxDescriptorSetUpdateAfterBindInputAttachments;
		public unsafe ResolveModeFlags supportedDepthResolveModes;
		public unsafe ResolveModeFlags supportedStencilResolveModes;
		public unsafe Bool32 independentResolveNone;
		public unsafe Bool32 independentResolve;
		public unsafe Bool32 filterMinmaxSingleComponentFormats;
		public unsafe Bool32 filterMinmaxImageComponentMapping;
		public unsafe ulong maxTimelineSemaphoreValueDifference;
		public unsafe SampleCountFlags framebufferIntegerColorSampleCounts;
	}

	public struct PipelineCompilerControlCreateInfoAMD {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe PipelineCompilerControlFlagsAMD compilerControlFlags;
	}

	public struct PhysicalDeviceCoherentMemoryFeaturesAMD {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 deviceCoherentMemory;
	}

	public struct PhysicalDeviceToolPropertiesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe fixed byte name[Constants.MaxExtensionNameSize];
		public unsafe fixed byte version[Constants.MaxExtensionNameSize];
		public unsafe ToolPurposeFlagsEXT purposes;
		public unsafe fixed byte description[Constants.MaxDescriptionSize];
		public unsafe fixed byte layer[Constants.MaxExtensionNameSize];
	}

	public struct SamplerCustomBorderColorCreateInfoEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe ClearColorValue customBorderColor;
		public unsafe Format format;
	}

	public struct PhysicalDeviceCustomBorderColorPropertiesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint maxCustomBorderColorSamplers;
	}

	public struct PhysicalDeviceCustomBorderColorFeaturesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 customBorderColors;
		public unsafe Bool32 customBorderColorWithoutFormat;
	}

	public struct AccelerationStructureGeometryTrianglesDataKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Format vertexFormat;
		public unsafe DeviceOrHostAddressConstKHR vertexData;
		public unsafe DeviceSize vertexStride;
		public unsafe IndexType indexType;
		public unsafe DeviceOrHostAddressConstKHR indexData;
		public unsafe DeviceOrHostAddressConstKHR transformData;
	}

	public struct AccelerationStructureGeometryAabbsDataKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DeviceOrHostAddressConstKHR data;
		public unsafe DeviceSize stride;
	}

	public struct AccelerationStructureGeometryInstancesDataKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 arrayOfPointers;
		public unsafe DeviceOrHostAddressConstKHR data;
	}

	public struct AccelerationStructureGeometryKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe GeometryTypeKHR geometryType;
		public unsafe AccelerationStructureGeometryDataKHR geometry;
		public unsafe GeometryFlagsKHR flags;
	}

	public struct AccelerationStructureBuildGeometryInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe AccelerationStructureTypeKHR type;
		public unsafe BuildAccelerationStructureFlagsKHR flags;
		public unsafe Bool32 update;
		public unsafe AccelerationStructureKHR srcAccelerationStructure;
		public unsafe AccelerationStructureKHR dstAccelerationStructure;
		public unsafe Bool32 geometryArrayOfPointers;
		public unsafe uint geometryCount;
		public unsafe AccelerationStructureGeometryKHR** geometries;
		public unsafe DeviceOrHostAddressKHR scratchData;
	}

	public struct AccelerationStructureBuildOffsetInfoKHR {
		public unsafe uint primitiveCount;
		public unsafe uint primitiveOffset;
		public unsafe uint firstVertex;
		public unsafe uint transformOffset;
	}

	public struct AccelerationStructureCreateGeometryTypeInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe GeometryTypeKHR geometryType;
		public unsafe uint maxPrimitiveCount;
		public unsafe IndexType indexType;
		public unsafe uint maxVertexCount;
		public unsafe Format vertexFormat;
		public unsafe Bool32 allowsTransforms;
	}

	public struct AccelerationStructureCreateInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DeviceSize compactedSize;
		public unsafe AccelerationStructureTypeKHR type;
		public unsafe BuildAccelerationStructureFlagsKHR flags;
		public unsafe uint maxGeometryCount;
		public unsafe AccelerationStructureCreateGeometryTypeInfoKHR* geometryInfos;
		public unsafe DeviceAddress deviceAddress;
	}

	public struct AabbPositionsKHR {
		public unsafe float minX;
		public unsafe float minY;
		public unsafe float minZ;
		public unsafe float maxX;
		public unsafe float maxY;
		public unsafe float maxZ;
	}

	public struct TransformMatrixKHR {
		public unsafe float[][] matrix;
	}

	public struct AccelerationStructureInstanceKHR {
		public unsafe TransformMatrixKHR transform;
		public unsafe uint instanceCustomIndex;
		public unsafe uint mask;
		public unsafe uint instanceShaderBindingTableRecordOffset;
		public unsafe GeometryInstanceFlagsKHR flags;
		public unsafe ulong accelerationStructureReference;
	}

	public struct AccelerationStructureDeviceAddressInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe AccelerationStructureKHR accelerationStructure;
	}

	public struct AccelerationStructureVersionKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe byte* versionData;
	}

	public struct CopyAccelerationStructureInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe AccelerationStructureKHR src;
		public unsafe AccelerationStructureKHR dst;
		public unsafe CopyAccelerationStructureModeKHR mode;
	}

	public struct CopyAccelerationStructureToMemoryInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe AccelerationStructureKHR src;
		public unsafe DeviceOrHostAddressKHR dst;
		public unsafe CopyAccelerationStructureModeKHR mode;
	}

	public struct CopyMemoryToAccelerationStructureInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DeviceOrHostAddressConstKHR src;
		public unsafe AccelerationStructureKHR dst;
		public unsafe CopyAccelerationStructureModeKHR mode;
	}

	public struct RayTracingPipelineInterfaceCreateInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint maxPayloadSize;
		public unsafe uint maxAttributeSize;
		public unsafe uint maxCallableSize;
	}

	public struct DeferredOperationInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DeferredOperationKHR operationHandle;
	}

	public struct PipelineLibraryCreateInfoKHR {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe uint libraryCount;
		public unsafe Pipeline* libraries;
	}

	public struct PhysicalDeviceExtendedDynamicStateFeaturesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 extendedDynamicState;
	}

	public struct RenderPassTransformBeginInfoQCOM {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe SurfaceTransformFlagsKHR transform;
	}

	public struct CommandBufferInheritanceRenderPassTransformInfoQCOM {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe SurfaceTransformFlagsKHR transform;
		public unsafe Rect2D renderArea;
	}

	public struct PhysicalDeviceDiagnosticsConfigFeaturesNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 diagnosticsConfig;
	}

	public struct DeviceDiagnosticsConfigCreateInfoNV {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DeviceDiagnosticsConfigFlagsNV flags;
	}

	public struct PhysicalDeviceRobustness2FeaturesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe Bool32 robustBufferAccess2;
		public unsafe Bool32 robustImageAccess2;
		public unsafe Bool32 nullDescriptor;
	}

	public struct PhysicalDeviceRobustness2PropertiesEXT {
		public unsafe StructureType sType;
		public unsafe void* next;
		public unsafe DeviceSize robustStorageBufferAccessSizeAlignment;
		public unsafe DeviceSize robustUniformBufferAccessSizeAlignment;
	}
}
