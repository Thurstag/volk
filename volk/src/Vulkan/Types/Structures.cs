// Copyright 2020-2020 Volk Project
// Licensed under Apache License 2.0 or any later version
// Refer to the LICENSE.md file included.

// This file is generated automatically by generator


using DotNetCross.NativeInts;
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
        public StructureType sType;
        public unsafe BaseOutStructure* next;
    }

    public struct BaseInStructure {
        public StructureType sType;
        public unsafe BaseInStructure* next;
    }

    public struct Offset2D {
        public int x;
        public int y;
    }

    public struct Offset3D {
        public int x;
        public int y;
        public int z;
    }

    public struct Extent2D {
        public uint width;
        public uint height;
    }

    public struct Extent3D {
        public uint width;
        public uint height;
        public uint depth;
    }

    public struct Viewport {
        public float x;
        public float y;
        public float width;
        public float height;
        public float minDepth;
        public float maxDepth;
    }

    public struct Rect2D {
        public Offset2D offset;
        public Extent2D extent;
    }

    public struct ClearRect {
        public Rect2D rect;
        public uint baseArrayLayer;
        public uint layerCount;
    }

    public struct ComponentMapping {
        public ComponentSwizzle r;
        public ComponentSwizzle g;
        public ComponentSwizzle b;
        public ComponentSwizzle a;
    }

    public struct PhysicalDeviceProperties {
        public uint apiVersion;
        public uint driverVersion;
        public uint vendorID;
        public uint deviceID;
        public PhysicalDeviceType deviceType;
        public unsafe fixed byte deviceName[Constants.MaxPhysicalDeviceNameSize];
        public unsafe fixed byte pipelineCacheUUID[Constants.UuidSize];
        public PhysicalDeviceLimits limits;
        public PhysicalDeviceSparseProperties sparseProperties;
    }

    public struct ExtensionProperties {
        public unsafe fixed byte extensionName[Constants.MaxExtensionNameSize];
        public uint specVersion;
    }

    public struct LayerProperties {
        public unsafe fixed byte layerName[Constants.MaxExtensionNameSize];
        public uint specVersion;
        public uint implementationVersion;
        public unsafe fixed byte description[Constants.MaxDescriptionSize];
    }

    public struct ApplicationInfo {
        public StructureType sType;
        public unsafe void* next;
        public unsafe byte* applicationName;
        public uint applicationVersion;
        public unsafe byte* engineName;
        public uint engineVersion;
        public uint apiVersion;
    }

    public struct AllocationCallbacks {
        public unsafe void* userData;
        public Instance pfnAllocation;
        public Instance pfnReallocation;
        public Instance pfnFree;
        public Instance pfnInternalAllocation;
        public Instance pfnInternalFree;
    }

    public struct DeviceQueueCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public DeviceQueueCreateFlags flags;
        public uint queueFamilyIndex;
        public uint queueCount;
        public unsafe float* queuePriorities;
    }

    public struct DeviceCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public DeviceCreateFlags flags;
        public uint queueCreateInfoCount;
        public unsafe DeviceQueueCreateInfo* queueCreateInfos;
        public uint enabledLayerCount;
        public unsafe byte** enabledLayerNames;
        public uint enabledExtensionCount;
        public unsafe byte** enabledExtensionNames;
        public unsafe PhysicalDeviceFeatures* enabledFeatures;
    }

    public struct InstanceCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public InstanceCreateFlags flags;
        public unsafe ApplicationInfo* applicationInfo;
        public uint enabledLayerCount;
        public unsafe byte** enabledLayerNames;
        public uint enabledExtensionCount;
        public unsafe byte** enabledExtensionNames;
    }

    public struct QueueFamilyProperties {
        public QueueFlags queueFlags;
        public uint queueCount;
        public uint timestampValidBits;
        public Extent3D minImageTransferGranularity;
    }

    public struct PhysicalDeviceMemoryProperties {
        public uint memoryTypeCount;
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
        public uint memoryHeapCount;
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
        public StructureType sType;
        public unsafe void* next;
        public ulong allocationSize;
        public uint memoryTypeIndex;
    }

    public struct MemoryRequirements {
        public ulong size;
        public ulong alignment;
        public uint memoryTypeBits;
    }

    public struct SparseImageFormatProperties {
        public ImageAspectFlags aspectMask;
        public Extent3D imageGranularity;
        public SparseImageFormatFlags flags;
    }

    public struct SparseImageMemoryRequirements {
        public SparseImageFormatProperties formatProperties;
        public uint imageMipTailFirstLod;
        public ulong imageMipTailSize;
        public ulong imageMipTailOffset;
        public ulong imageMipTailStride;
    }

    public struct MemoryType {
        public MemoryPropertyFlags propertyFlags;
        public uint heapIndex;
    }

    public struct MemoryHeap {
        public ulong size;
        public MemoryHeapFlags flags;
    }

    public struct MappedMemoryRange {
        public StructureType sType;
        public unsafe void* next;
        public DeviceMemory memory;
        public ulong offset;
        public ulong size;
    }

    public struct FormatProperties {
        public FormatFeatureFlags linearTilingFeatures;
        public FormatFeatureFlags optimalTilingFeatures;
        public FormatFeatureFlags bufferFeatures;
    }

    public struct ImageFormatProperties {
        public Extent3D maxExtent;
        public uint maxMipLevels;
        public uint maxArrayLayers;
        public SampleCountFlags sampleCounts;
        public ulong maxResourceSize;
    }

    public struct DescriptorBufferInfo {
        public Buffer buffer;
        public ulong offset;
        public ulong range;
    }

    public struct DescriptorImageInfo {
        public Sampler sampler;
        public ImageView imageView;
        public ImageLayout imageLayout;
    }

    public struct WriteDescriptorSet {
        public StructureType sType;
        public unsafe void* next;
        public DescriptorSet dstSet;
        public uint dstBinding;
        public uint dstArrayElement;
        public uint descriptorCount;
        public DescriptorType descriptorType;
        public unsafe DescriptorImageInfo* imageInfo;
        public unsafe DescriptorBufferInfo* bufferInfo;
        public unsafe BufferView* texelBufferView;
    }

    public struct CopyDescriptorSet {
        public StructureType sType;
        public unsafe void* next;
        public DescriptorSet srcSet;
        public uint srcBinding;
        public uint srcArrayElement;
        public DescriptorSet dstSet;
        public uint dstBinding;
        public uint dstArrayElement;
        public uint descriptorCount;
    }

    public struct BufferCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public BufferCreateFlags flags;
        public ulong size;
        public BufferUsageFlags usage;
        public SharingMode sharingMode;
        public uint queueFamilyIndexCount;
        public unsafe uint* queueFamilyIndices;
    }

    public struct BufferViewCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public BufferViewCreateFlags flags;
        public Buffer buffer;
        public Format format;
        public ulong offset;
        public ulong range;
    }

    public struct ImageSubresource {
        public ImageAspectFlags aspectMask;
        public uint mipLevel;
        public uint arrayLayer;
    }

    public struct ImageSubresourceLayers {
        public ImageAspectFlags aspectMask;
        public uint mipLevel;
        public uint baseArrayLayer;
        public uint layerCount;
    }

    public struct ImageSubresourceRange {
        public ImageAspectFlags aspectMask;
        public uint baseMipLevel;
        public uint levelCount;
        public uint baseArrayLayer;
        public uint layerCount;
    }

    public struct MemoryBarrier {
        public StructureType sType;
        public unsafe void* next;
        public AccessFlags srcAccessMask;
        public AccessFlags dstAccessMask;
    }

    public struct BufferMemoryBarrier {
        public StructureType sType;
        public unsafe void* next;
        public AccessFlags srcAccessMask;
        public AccessFlags dstAccessMask;
        public uint srcQueueFamilyIndex;
        public uint dstQueueFamilyIndex;
        public Buffer buffer;
        public ulong offset;
        public ulong size;
    }

    public struct ImageMemoryBarrier {
        public StructureType sType;
        public unsafe void* next;
        public AccessFlags srcAccessMask;
        public AccessFlags dstAccessMask;
        public ImageLayout oldLayout;
        public ImageLayout newLayout;
        public uint srcQueueFamilyIndex;
        public uint dstQueueFamilyIndex;
        public Image image;
        public ImageSubresourceRange subresourceRange;
    }

    public struct ImageCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public ImageCreateFlags flags;
        public ImageType imageType;
        public Format format;
        public Extent3D extent;
        public uint mipLevels;
        public uint arrayLayers;
        public SampleCountFlags samples;
        public ImageTiling tiling;
        public ImageUsageFlags usage;
        public SharingMode sharingMode;
        public uint queueFamilyIndexCount;
        public unsafe uint* queueFamilyIndices;
        public ImageLayout initialLayout;
    }

    public struct SubresourceLayout {
        public ulong offset;
        public ulong size;
        public ulong rowPitch;
        public ulong arrayPitch;
        public ulong depthPitch;
    }

    public struct ImageViewCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public ImageViewCreateFlags flags;
        public Image image;
        public ImageViewType viewType;
        public Format format;
        public ComponentMapping components;
        public ImageSubresourceRange subresourceRange;
    }

    public struct BufferCopy {
        public ulong srcOffset;
        public ulong dstOffset;
        public ulong size;
    }

    public struct SparseMemoryBind {
        public ulong resourceOffset;
        public ulong size;
        public DeviceMemory memory;
        public ulong memoryOffset;
        public SparseMemoryBindFlags flags;
    }

    public struct SparseImageMemoryBind {
        public ImageSubresource subresource;
        public Offset3D offset;
        public Extent3D extent;
        public DeviceMemory memory;
        public ulong memoryOffset;
        public SparseMemoryBindFlags flags;
    }

    public struct SparseBufferMemoryBindInfo {
        public Buffer buffer;
        public uint bindCount;
        public unsafe SparseMemoryBind* binds;
    }

    public struct SparseImageOpaqueMemoryBindInfo {
        public Image image;
        public uint bindCount;
        public unsafe SparseMemoryBind* binds;
    }

    public struct SparseImageMemoryBindInfo {
        public Image image;
        public uint bindCount;
        public unsafe SparseImageMemoryBind* binds;
    }

    public struct BindSparseInfo {
        public StructureType sType;
        public unsafe void* next;
        public uint waitSemaphoreCount;
        public unsafe Semaphore* waitSemaphores;
        public uint bufferBindCount;
        public unsafe SparseBufferMemoryBindInfo* bufferBinds;
        public uint imageOpaqueBindCount;
        public unsafe SparseImageOpaqueMemoryBindInfo* imageOpaqueBinds;
        public uint imageBindCount;
        public unsafe SparseImageMemoryBindInfo* imageBinds;
        public uint signalSemaphoreCount;
        public unsafe Semaphore* signalSemaphores;
    }

    public struct ImageCopy {
        public ImageSubresourceLayers srcSubresource;
        public Offset3D srcOffset;
        public ImageSubresourceLayers dstSubresource;
        public Offset3D dstOffset;
        public Extent3D extent;
    }

    public struct ImageBlit {
        public ImageSubresourceLayers srcSubresource;
        public Offset3D srcOffsets_0;
        public Offset3D srcOffsets_1;
        public ImageSubresourceLayers dstSubresource;
        public Offset3D dstOffsets_0;
        public Offset3D dstOffsets_1;
    }

    public struct BufferImageCopy {
        public ulong bufferOffset;
        public uint bufferRowLength;
        public uint bufferImageHeight;
        public ImageSubresourceLayers imageSubresource;
        public Offset3D imageOffset;
        public Extent3D imageExtent;
    }

    public struct ImageResolve {
        public ImageSubresourceLayers srcSubresource;
        public Offset3D srcOffset;
        public ImageSubresourceLayers dstSubresource;
        public Offset3D dstOffset;
        public Extent3D extent;
    }

    public struct ShaderModuleCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public ShaderModuleCreateFlags flags;
        public nuint codeSize;
        public unsafe uint* code;
    }

    public struct DescriptorSetLayoutBinding {
        public uint binding;
        public DescriptorType descriptorType;
        public uint descriptorCount;
        public ShaderStageFlags stageFlags;
        public unsafe Sampler* immutableSamplers;
    }

    public struct DescriptorSetLayoutCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public DescriptorSetLayoutCreateFlags flags;
        public uint bindingCount;
        public unsafe DescriptorSetLayoutBinding* bindings;
    }

    public struct DescriptorPoolSize {
        public DescriptorType type;
        public uint descriptorCount;
    }

    public struct DescriptorPoolCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public DescriptorPoolCreateFlags flags;
        public uint maxSets;
        public uint poolSizeCount;
        public unsafe DescriptorPoolSize* poolSizes;
    }

    public struct DescriptorSetAllocateInfo {
        public StructureType sType;
        public unsafe void* next;
        public DescriptorPool descriptorPool;
        public uint descriptorSetCount;
        public unsafe DescriptorSetLayout* setLayouts;
    }

    public struct SpecializationMapEntry {
        public uint constantID;
        public uint offset;
        public nuint size;
    }

    public struct SpecializationInfo {
        public uint mapEntryCount;
        public unsafe SpecializationMapEntry* mapEntries;
        public nuint dataSize;
        public unsafe void* data;
    }

    public struct PipelineShaderStageCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public PipelineShaderStageCreateFlags flags;
        public ShaderStageFlags stage;
        public ShaderModule module;
        public unsafe byte* name;
        public unsafe SpecializationInfo* specializationInfo;
    }

    public struct ComputePipelineCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public PipelineCreateFlags flags;
        public PipelineShaderStageCreateInfo stage;
        public PipelineLayout layout;
        public Pipeline basePipelineHandle;
        public int basePipelineIndex;
    }

    public struct VertexInputBindingDescription {
        public uint binding;
        public uint stride;
        public VertexInputRate inputRate;
    }

    public struct VertexInputAttributeDescription {
        public uint location;
        public uint binding;
        public Format format;
        public uint offset;
    }

    public struct PipelineVertexInputStateCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public PipelineVertexInputStateCreateFlags flags;
        public uint vertexBindingDescriptionCount;
        public unsafe VertexInputBindingDescription* vertexBindingDescriptions;
        public uint vertexAttributeDescriptionCount;
        public unsafe VertexInputAttributeDescription* vertexAttributeDescriptions;
    }

    public struct PipelineInputAssemblyStateCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public PipelineInputAssemblyStateCreateFlags flags;
        public PrimitiveTopology topology;
        public uint primitiveRestartEnable;
    }

    public struct PipelineTessellationStateCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public PipelineTessellationStateCreateFlags flags;
        public uint patchControlPoints;
    }

    public struct PipelineViewportStateCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public PipelineViewportStateCreateFlags flags;
        public uint viewportCount;
        public unsafe Viewport* viewports;
        public uint scissorCount;
        public unsafe Rect2D* scissors;
    }

    public struct PipelineRasterizationStateCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public PipelineRasterizationStateCreateFlags flags;
        public uint depthClampEnable;
        public uint rasterizerDiscardEnable;
        public PolygonMode polygonMode;
        public CullModeFlags cullMode;
        public FrontFace frontFace;
        public uint depthBiasEnable;
        public float depthBiasConstantFactor;
        public float depthBiasClamp;
        public float depthBiasSlopeFactor;
        public float lineWidth;
    }

    public struct PipelineMultisampleStateCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public PipelineMultisampleStateCreateFlags flags;
        public SampleCountFlags rasterizationSamples;
        public uint sampleShadingEnable;
        public float minSampleShading;
        public unsafe uint* sampleMask;
        public uint alphaToCoverageEnable;
        public uint alphaToOneEnable;
    }

    public struct PipelineColorBlendAttachmentState {
        public uint blendEnable;
        public BlendFactor srcColorBlendFactor;
        public BlendFactor dstColorBlendFactor;
        public BlendOp colorBlendOp;
        public BlendFactor srcAlphaBlendFactor;
        public BlendFactor dstAlphaBlendFactor;
        public BlendOp alphaBlendOp;
        public ColorComponentFlags colorWriteMask;
    }

    public struct PipelineColorBlendStateCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public PipelineColorBlendStateCreateFlags flags;
        public uint logicOpEnable;
        public LogicOp logicOp;
        public uint attachmentCount;
        public unsafe PipelineColorBlendAttachmentState* attachments;
        public unsafe fixed float blendConstants[4];
    }

    public struct PipelineDynamicStateCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public PipelineDynamicStateCreateFlags flags;
        public uint dynamicStateCount;
        public unsafe DynamicState* dynamicStates;
    }

    public struct StencilOpState {
        public StencilOp failOp;
        public StencilOp passOp;
        public StencilOp depthFailOp;
        public CompareOp compareOp;
        public uint compareMask;
        public uint writeMask;
        public uint reference;
    }

    public struct PipelineDepthStencilStateCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public PipelineDepthStencilStateCreateFlags flags;
        public uint depthTestEnable;
        public uint depthWriteEnable;
        public CompareOp depthCompareOp;
        public uint depthBoundsTestEnable;
        public uint stencilTestEnable;
        public StencilOpState front;
        public StencilOpState back;
        public float minDepthBounds;
        public float maxDepthBounds;
    }

    public struct GraphicsPipelineCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public PipelineCreateFlags flags;
        public uint stageCount;
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
        public PipelineLayout layout;
        public RenderPass renderPass;
        public uint subpass;
        public Pipeline basePipelineHandle;
        public int basePipelineIndex;
    }

    public struct PipelineCacheCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public PipelineCacheCreateFlags flags;
        public nuint initialDataSize;
        public unsafe void* initialData;
    }

    public struct PushConstantRange {
        public ShaderStageFlags stageFlags;
        public uint offset;
        public uint size;
    }

    public struct PipelineLayoutCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public PipelineLayoutCreateFlags flags;
        public uint setLayoutCount;
        public unsafe DescriptorSetLayout* setLayouts;
        public uint pushConstantRangeCount;
        public unsafe PushConstantRange* pushConstantRanges;
    }

    public struct SamplerCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public SamplerCreateFlags flags;
        public Filter magFilter;
        public Filter minFilter;
        public SamplerMipmapMode mipmapMode;
        public SamplerAddressMode addressModeU;
        public SamplerAddressMode addressModeV;
        public SamplerAddressMode addressModeW;
        public float mipLodBias;
        public uint anisotropyEnable;
        public float maxAnisotropy;
        public uint compareEnable;
        public CompareOp compareOp;
        public float minLod;
        public float maxLod;
        public BorderColor borderColor;
        public uint unnormalizedCoordinates;
    }

    public struct CommandPoolCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public CommandPoolCreateFlags flags;
        public uint queueFamilyIndex;
    }

    public struct CommandBufferAllocateInfo {
        public StructureType sType;
        public unsafe void* next;
        public CommandPool commandPool;
        public CommandBufferLevel level;
        public uint commandBufferCount;
    }

    public struct CommandBufferInheritanceInfo {
        public StructureType sType;
        public unsafe void* next;
        public RenderPass renderPass;
        public uint subpass;
        public Framebuffer framebuffer;
        public uint occlusionQueryEnable;
        public QueryControlFlags queryFlags;
        public QueryPipelineStatisticFlags pipelineStatistics;
    }

    public struct CommandBufferBeginInfo {
        public StructureType sType;
        public unsafe void* next;
        public CommandBufferUsageFlags flags;
        public unsafe CommandBufferInheritanceInfo* inheritanceInfo;
    }

    public struct RenderPassBeginInfo {
        public StructureType sType;
        public unsafe void* next;
        public RenderPass renderPass;
        public Framebuffer framebuffer;
        public Rect2D renderArea;
        public uint clearValueCount;
        public unsafe ClearValue* clearValues;
    }

    public struct ClearDepthStencilValue {
        public float depth;
        public uint stencil;
    }

    public struct ClearAttachment {
        public ImageAspectFlags aspectMask;
        public uint colorAttachment;
        public ClearValue clearValue;
    }

    public struct AttachmentDescription {
        public AttachmentDescriptionFlags flags;
        public Format format;
        public SampleCountFlags samples;
        public AttachmentLoadOp loadOp;
        public AttachmentStoreOp storeOp;
        public AttachmentLoadOp stencilLoadOp;
        public AttachmentStoreOp stencilStoreOp;
        public ImageLayout initialLayout;
        public ImageLayout finalLayout;
    }

    public struct AttachmentReference {
        public uint attachment;
        public ImageLayout layout;
    }

    public struct SubpassDescription {
        public SubpassDescriptionFlags flags;
        public PipelineBindPoint pipelineBindPoint;
        public uint inputAttachmentCount;
        public unsafe AttachmentReference* inputAttachments;
        public uint colorAttachmentCount;
        public unsafe AttachmentReference* colorAttachments;
        public unsafe AttachmentReference* resolveAttachments;
        public unsafe AttachmentReference* depthStencilAttachment;
        public uint preserveAttachmentCount;
        public unsafe uint* preserveAttachments;
    }

    public struct SubpassDependency {
        public uint srcSubpass;
        public uint dstSubpass;
        public PipelineStageFlags srcStageMask;
        public PipelineStageFlags dstStageMask;
        public AccessFlags srcAccessMask;
        public AccessFlags dstAccessMask;
        public DependencyFlags dependencyFlags;
    }

    public struct RenderPassCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public RenderPassCreateFlags flags;
        public uint attachmentCount;
        public unsafe AttachmentDescription* attachments;
        public uint subpassCount;
        public unsafe SubpassDescription* subpasses;
        public uint dependencyCount;
        public unsafe SubpassDependency* dependencies;
    }

    public struct EventCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public EventCreateFlags flags;
    }

    public struct FenceCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public FenceCreateFlags flags;
    }

    public struct PhysicalDeviceFeatures {
        public uint robustBufferAccess;
        public uint fullDrawIndexUint32;
        public uint imageCubeArray;
        public uint independentBlend;
        public uint geometryShader;
        public uint tessellationShader;
        public uint sampleRateShading;
        public uint dualSrcBlend;
        public uint logicOp;
        public uint multiDrawIndirect;
        public uint drawIndirectFirstInstance;
        public uint depthClamp;
        public uint depthBiasClamp;
        public uint fillModeNonSolid;
        public uint depthBounds;
        public uint wideLines;
        public uint largePoints;
        public uint alphaToOne;
        public uint multiViewport;
        public uint samplerAnisotropy;
        public uint textureCompressionETC2;
        public uint textureCompressionASTC_LDR;
        public uint textureCompressionBC;
        public uint occlusionQueryPrecise;
        public uint pipelineStatisticsQuery;
        public uint vertexPipelineStoresAndAtomics;
        public uint fragmentStoresAndAtomics;
        public uint shaderTessellationAndGeometryPointSize;
        public uint shaderImageGatherExtended;
        public uint shaderStorageImageExtendedFormats;
        public uint shaderStorageImageMultisample;
        public uint shaderStorageImageReadWithoutFormat;
        public uint shaderStorageImageWriteWithoutFormat;
        public uint shaderUniformBufferArrayDynamicIndexing;
        public uint shaderSampledImageArrayDynamicIndexing;
        public uint shaderStorageBufferArrayDynamicIndexing;
        public uint shaderStorageImageArrayDynamicIndexing;
        public uint shaderClipDistance;
        public uint shaderCullDistance;
        public uint shaderFloat64;
        public uint shaderInt64;
        public uint shaderInt16;
        public uint shaderResourceResidency;
        public uint shaderResourceMinLod;
        public uint sparseBinding;
        public uint sparseResidencyBuffer;
        public uint sparseResidencyImage2D;
        public uint sparseResidencyImage3D;
        public uint sparseResidency2Samples;
        public uint sparseResidency4Samples;
        public uint sparseResidency8Samples;
        public uint sparseResidency16Samples;
        public uint sparseResidencyAliased;
        public uint variableMultisampleRate;
        public uint inheritedQueries;
    }

    public struct PhysicalDeviceSparseProperties {
        public uint residencyStandard2DBlockShape;
        public uint residencyStandard2DMultisampleBlockShape;
        public uint residencyStandard3DBlockShape;
        public uint residencyAlignedMipSize;
        public uint residencyNonResidentStrict;
    }

    public struct PhysicalDeviceLimits {
        public uint maxImageDimension1D;
        public uint maxImageDimension2D;
        public uint maxImageDimension3D;
        public uint maxImageDimensionCube;
        public uint maxImageArrayLayers;
        public uint maxTexelBufferElements;
        public uint maxUniformBufferRange;
        public uint maxStorageBufferRange;
        public uint maxPushConstantsSize;
        public uint maxMemoryAllocationCount;
        public uint maxSamplerAllocationCount;
        public ulong bufferImageGranularity;
        public ulong sparseAddressSpaceSize;
        public uint maxBoundDescriptorSets;
        public uint maxPerStageDescriptorSamplers;
        public uint maxPerStageDescriptorUniformBuffers;
        public uint maxPerStageDescriptorStorageBuffers;
        public uint maxPerStageDescriptorSampledImages;
        public uint maxPerStageDescriptorStorageImages;
        public uint maxPerStageDescriptorInputAttachments;
        public uint maxPerStageResources;
        public uint maxDescriptorSetSamplers;
        public uint maxDescriptorSetUniformBuffers;
        public uint maxDescriptorSetUniformBuffersDynamic;
        public uint maxDescriptorSetStorageBuffers;
        public uint maxDescriptorSetStorageBuffersDynamic;
        public uint maxDescriptorSetSampledImages;
        public uint maxDescriptorSetStorageImages;
        public uint maxDescriptorSetInputAttachments;
        public uint maxVertexInputAttributes;
        public uint maxVertexInputBindings;
        public uint maxVertexInputAttributeOffset;
        public uint maxVertexInputBindingStride;
        public uint maxVertexOutputComponents;
        public uint maxTessellationGenerationLevel;
        public uint maxTessellationPatchSize;
        public uint maxTessellationControlPerVertexInputComponents;
        public uint maxTessellationControlPerVertexOutputComponents;
        public uint maxTessellationControlPerPatchOutputComponents;
        public uint maxTessellationControlTotalOutputComponents;
        public uint maxTessellationEvaluationInputComponents;
        public uint maxTessellationEvaluationOutputComponents;
        public uint maxGeometryShaderInvocations;
        public uint maxGeometryInputComponents;
        public uint maxGeometryOutputComponents;
        public uint maxGeometryOutputVertices;
        public uint maxGeometryTotalOutputComponents;
        public uint maxFragmentInputComponents;
        public uint maxFragmentOutputAttachments;
        public uint maxFragmentDualSrcAttachments;
        public uint maxFragmentCombinedOutputResources;
        public uint maxComputeSharedMemorySize;
        public unsafe fixed uint maxComputeWorkGroupCount[3];
        public uint maxComputeWorkGroupInvocations;
        public unsafe fixed uint maxComputeWorkGroupSize[3];
        public uint subPixelPrecisionBits;
        public uint subTexelPrecisionBits;
        public uint mipmapPrecisionBits;
        public uint maxDrawIndexedIndexValue;
        public uint maxDrawIndirectCount;
        public float maxSamplerLodBias;
        public float maxSamplerAnisotropy;
        public uint maxViewports;
        public unsafe fixed uint maxViewportDimensions[2];
        public unsafe fixed float viewportBoundsRange[2];
        public uint viewportSubPixelBits;
        public nuint minMemoryMapAlignment;
        public ulong minTexelBufferOffsetAlignment;
        public ulong minUniformBufferOffsetAlignment;
        public ulong minStorageBufferOffsetAlignment;
        public int minTexelOffset;
        public uint maxTexelOffset;
        public int minTexelGatherOffset;
        public uint maxTexelGatherOffset;
        public float minInterpolationOffset;
        public float maxInterpolationOffset;
        public uint subPixelInterpolationOffsetBits;
        public uint maxFramebufferWidth;
        public uint maxFramebufferHeight;
        public uint maxFramebufferLayers;
        public SampleCountFlags framebufferColorSampleCounts;
        public SampleCountFlags framebufferDepthSampleCounts;
        public SampleCountFlags framebufferStencilSampleCounts;
        public SampleCountFlags framebufferNoAttachmentsSampleCounts;
        public uint maxColorAttachments;
        public SampleCountFlags sampledImageColorSampleCounts;
        public SampleCountFlags sampledImageIntegerSampleCounts;
        public SampleCountFlags sampledImageDepthSampleCounts;
        public SampleCountFlags sampledImageStencilSampleCounts;
        public SampleCountFlags storageImageSampleCounts;
        public uint maxSampleMaskWords;
        public uint timestampComputeAndGraphics;
        public float timestampPeriod;
        public uint maxClipDistances;
        public uint maxCullDistances;
        public uint maxCombinedClipAndCullDistances;
        public uint discreteQueuePriorities;
        public unsafe fixed float pointSizeRange[2];
        public unsafe fixed float lineWidthRange[2];
        public float pointSizeGranularity;
        public float lineWidthGranularity;
        public uint strictLines;
        public uint standardSampleLocations;
        public ulong optimalBufferCopyOffsetAlignment;
        public ulong optimalBufferCopyRowPitchAlignment;
        public ulong nonCoherentAtomSize;
    }

    public struct SemaphoreCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public SemaphoreCreateFlags flags;
    }

    public struct QueryPoolCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public QueryPoolCreateFlags flags;
        public QueryType queryType;
        public uint queryCount;
        public QueryPipelineStatisticFlags pipelineStatistics;
    }

    public struct FramebufferCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public FramebufferCreateFlags flags;
        public RenderPass renderPass;
        public uint attachmentCount;
        public unsafe ImageView* attachments;
        public uint width;
        public uint height;
        public uint layers;
    }

    public struct DrawIndirectCommand {
        public uint vertexCount;
        public uint instanceCount;
        public uint firstVertex;
        public uint firstInstance;
    }

    public struct DrawIndexedIndirectCommand {
        public uint indexCount;
        public uint instanceCount;
        public uint firstIndex;
        public int vertexOffset;
        public uint firstInstance;
    }

    public struct DispatchIndirectCommand {
        public uint x;
        public uint y;
        public uint z;
    }

    public struct SubmitInfo {
        public StructureType sType;
        public unsafe void* next;
        public uint waitSemaphoreCount;
        public unsafe Semaphore* waitSemaphores;
        public unsafe PipelineStageFlags* waitDstStageMask;
        public uint commandBufferCount;
        public unsafe CommandBuffer* commandBuffers;
        public uint signalSemaphoreCount;
        public unsafe Semaphore* signalSemaphores;
    }

    public struct DisplayPropertiesKHR {
        public DisplayKHR display;
        public unsafe byte* displayName;
        public Extent2D physicalDimensions;
        public Extent2D physicalResolution;
        public SurfaceTransformFlagsKHR supportedTransforms;
        public uint planeReorderPossible;
        public uint persistentContent;
    }

    public struct DisplayPlanePropertiesKHR {
        public DisplayKHR currentDisplay;
        public uint currentStackIndex;
    }

    public struct DisplayModeParametersKHR {
        public Extent2D visibleRegion;
        public uint refreshRate;
    }

    public struct DisplayModePropertiesKHR {
        public DisplayModeKHR displayMode;
        public DisplayModeParametersKHR parameters;
    }

    public struct DisplayModeCreateInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public DisplayModeCreateFlagsKHR flags;
        public DisplayModeParametersKHR parameters;
    }

    public struct DisplayPlaneCapabilitiesKHR {
        public DisplayPlaneAlphaFlagsKHR supportedAlpha;
        public Offset2D minSrcPosition;
        public Offset2D maxSrcPosition;
        public Extent2D minSrcExtent;
        public Extent2D maxSrcExtent;
        public Offset2D minDstPosition;
        public Offset2D maxDstPosition;
        public Extent2D minDstExtent;
        public Extent2D maxDstExtent;
    }

    public struct DisplaySurfaceCreateInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public DisplaySurfaceCreateFlagsKHR flags;
        public DisplayModeKHR displayMode;
        public uint planeIndex;
        public uint planeStackIndex;
        public SurfaceTransformFlagsKHR transform;
        public float globalAlpha;
        public DisplayPlaneAlphaFlagsKHR alphaMode;
        public Extent2D imageExtent;
    }

    public struct DisplayPresentInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public Rect2D srcRect;
        public Rect2D dstRect;
        public uint persistent;
    }

    public struct SurfaceCapabilitiesKHR {
        public uint minImageCount;
        public uint maxImageCount;
        public Extent2D currentExtent;
        public Extent2D minImageExtent;
        public Extent2D maxImageExtent;
        public uint maxImageArrayLayers;
        public SurfaceTransformFlagsKHR supportedTransforms;
        public SurfaceTransformFlagsKHR currentTransform;
        public CompositeAlphaFlagsKHR supportedCompositeAlpha;
        public ImageUsageFlags supportedUsageFlags;
    }

    public struct AndroidSurfaceCreateInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public AndroidSurfaceCreateFlagsKHR flags;
        public unsafe void** window;
    }

    public struct ViSurfaceCreateInfoNN {
        public StructureType sType;
        public unsafe void* next;
        public ViSurfaceCreateFlagsNN flags;
        public unsafe void* window;
    }

    public struct WaylandSurfaceCreateInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public WaylandSurfaceCreateFlagsKHR flags;
        public unsafe void** display;
        public unsafe void** surface;
    }

    public struct Win32SurfaceCreateInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public Win32SurfaceCreateFlagsKHR flags;
        public unsafe void* hinstance;
        public unsafe void* hwnd;
    }

    public struct XlibSurfaceCreateInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public XlibSurfaceCreateFlagsKHR flags;
        public unsafe void** dpy;
        public ulong window;
    }

    public struct XcbSurfaceCreateInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public XcbSurfaceCreateFlagsKHR flags;
        public unsafe void** connection;
        public uint window;
    }

    public struct DirectFBSurfaceCreateInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public DirectFBSurfaceCreateFlagsEXT flags;
        public unsafe void** dfb;
        public unsafe void** surface;
    }

    public struct ImagePipeSurfaceCreateInfoFUCHSIA {
        public StructureType sType;
        public unsafe void* next;
        public ImagePipeSurfaceCreateFlagsFUCHSIA flags;
        public uint imagePipeHandle;
    }

    public struct StreamDescriptorSurfaceCreateInfoGGP {
        public StructureType sType;
        public unsafe void* next;
        public StreamDescriptorSurfaceCreateFlagsGGP flags;
        public int streamDescriptor;
    }

    public struct SurfaceFormatKHR {
        public Format format;
        public ColorSpaceKHR colorSpace;
    }

    public struct SwapchainCreateInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public SwapchainCreateFlagsKHR flags;
        public SurfaceKHR surface;
        public uint minImageCount;
        public Format imageFormat;
        public ColorSpaceKHR imageColorSpace;
        public Extent2D imageExtent;
        public uint imageArrayLayers;
        public ImageUsageFlags imageUsage;
        public SharingMode imageSharingMode;
        public uint queueFamilyIndexCount;
        public unsafe uint* queueFamilyIndices;
        public SurfaceTransformFlagsKHR preTransform;
        public CompositeAlphaFlagsKHR compositeAlpha;
        public PresentModeKHR presentMode;
        public uint clipped;
        public SwapchainKHR oldSwapchain;
    }

    public struct PresentInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public uint waitSemaphoreCount;
        public unsafe Semaphore* waitSemaphores;
        public uint swapchainCount;
        public unsafe SwapchainKHR* swapchains;
        public unsafe uint* imageIndices;
        public unsafe Result* results;
    }

    public struct DebugReportCallbackCreateInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public DebugReportFlagsEXT flags;
        public Instance pfnCallback;
        public unsafe void* userData;
    }

    public struct ValidationFlagsEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint disabledValidationCheckCount;
        public unsafe ValidationCheckEXT* disabledValidationChecks;
    }

    public struct ValidationFeaturesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint enabledValidationFeatureCount;
        public unsafe ValidationFeatureEnableEXT* enabledValidationFeatures;
        public uint disabledValidationFeatureCount;
        public unsafe ValidationFeatureDisableEXT* disabledValidationFeatures;
    }

    public struct PipelineRasterizationStateRasterizationOrderAMD {
        public StructureType sType;
        public unsafe void* next;
        public RasterizationOrderAMD rasterizationOrder;
    }

    public struct DebugMarkerObjectNameInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public DebugReportObjectTypeEXT objectType;
        public ulong @object;
        public unsafe byte* objectName;
    }

    public struct DebugMarkerObjectTagInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public DebugReportObjectTypeEXT objectType;
        public ulong @object;
        public ulong tagName;
        public nuint tagSize;
        public unsafe void* tag;
    }

    public struct DebugMarkerMarkerInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public unsafe byte* markerName;
        public unsafe fixed float color[4];
    }

    public struct DedicatedAllocationImageCreateInfoNV {
        public StructureType sType;
        public unsafe void* next;
        public uint dedicatedAllocation;
    }

    public struct DedicatedAllocationBufferCreateInfoNV {
        public StructureType sType;
        public unsafe void* next;
        public uint dedicatedAllocation;
    }

    public struct DedicatedAllocationMemoryAllocateInfoNV {
        public StructureType sType;
        public unsafe void* next;
        public Image image;
        public Buffer buffer;
    }

    public struct ExternalImageFormatPropertiesNV {
        public ImageFormatProperties imageFormatProperties;
        public ExternalMemoryFeatureFlagsNV externalMemoryFeatures;
        public ExternalMemoryHandleTypeFlagsNV exportFromImportedHandleTypes;
        public ExternalMemoryHandleTypeFlagsNV compatibleHandleTypes;
    }

    public struct ExternalMemoryImageCreateInfoNV {
        public StructureType sType;
        public unsafe void* next;
        public ExternalMemoryHandleTypeFlagsNV handleTypes;
    }

    public struct ExportMemoryAllocateInfoNV {
        public StructureType sType;
        public unsafe void* next;
        public ExternalMemoryHandleTypeFlagsNV handleTypes;
    }

    public struct ImportMemoryWin32HandleInfoNV {
        public StructureType sType;
        public unsafe void* next;
        public ExternalMemoryHandleTypeFlagsNV handleType;
        public unsafe void* handle;
    }

    public struct ExportMemoryWin32HandleInfoNV {
        public StructureType sType;
        public unsafe void* next;
        public unsafe SECURITY_ATTRIBUTES* attributes;
        public uint dwAccess;
    }

    public struct Win32KeyedMutexAcquireReleaseInfoNV {
        public StructureType sType;
        public unsafe void* next;
        public uint acquireCount;
        public unsafe DeviceMemory* acquireSyncs;
        public unsafe ulong* acquireKeys;
        public unsafe uint* acquireTimeoutMilliseconds;
        public uint releaseCount;
        public unsafe DeviceMemory* releaseSyncs;
        public unsafe ulong* releaseKeys;
    }

    public struct PhysicalDeviceDeviceGeneratedCommandsFeaturesNV {
        public StructureType sType;
        public unsafe void* next;
        public uint deviceGeneratedCommands;
    }

    public struct DevicePrivateDataCreateInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint privateDataSlotRequestCount;
    }

    public struct PrivateDataSlotCreateInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public PrivateDataSlotCreateFlagsEXT flags;
    }

    public struct PhysicalDevicePrivateDataFeaturesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint privateData;
    }

    public struct PhysicalDeviceDeviceGeneratedCommandsPropertiesNV {
        public StructureType sType;
        public unsafe void* next;
        public uint maxGraphicsShaderGroupCount;
        public uint maxIndirectSequenceCount;
        public uint maxIndirectCommandsTokenCount;
        public uint maxIndirectCommandsStreamCount;
        public uint maxIndirectCommandsTokenOffset;
        public uint maxIndirectCommandsStreamStride;
        public uint minSequencesCountBufferOffsetAlignment;
        public uint minSequencesIndexBufferOffsetAlignment;
        public uint minIndirectCommandsBufferOffsetAlignment;
    }

    public struct GraphicsShaderGroupCreateInfoNV {
        public StructureType sType;
        public unsafe void* next;
        public uint stageCount;
        public unsafe PipelineShaderStageCreateInfo* stages;
        public unsafe PipelineVertexInputStateCreateInfo* vertexInputState;
        public unsafe PipelineTessellationStateCreateInfo* tessellationState;
    }

    public struct GraphicsPipelineShaderGroupsCreateInfoNV {
        public StructureType sType;
        public unsafe void* next;
        public uint groupCount;
        public unsafe GraphicsShaderGroupCreateInfoNV* groups;
        public uint pipelineCount;
        public unsafe Pipeline* pipelines;
    }

    public struct BindShaderGroupIndirectCommandNV {
        public uint groupIndex;
    }

    public struct BindIndexBufferIndirectCommandNV {
        public ulong bufferAddress;
        public uint size;
        public IndexType indexType;
    }

    public struct BindVertexBufferIndirectCommandNV {
        public ulong bufferAddress;
        public uint size;
        public uint stride;
    }

    public struct SetStateFlagsIndirectCommandNV {
        public uint data;
    }

    public struct IndirectCommandsStreamNV {
        public Buffer buffer;
        public ulong offset;
    }

    public struct IndirectCommandsLayoutTokenNV {
        public StructureType sType;
        public unsafe void* next;
        public IndirectCommandsTokenTypeNV tokenType;
        public uint stream;
        public uint offset;
        public uint vertexBindingUnit;
        public uint vertexDynamicStride;
        public PipelineLayout pushconstantPipelineLayout;
        public ShaderStageFlags pushconstantShaderStageFlags;
        public uint pushconstantOffset;
        public uint pushconstantSize;
        public IndirectStateFlagsNV indirectStateFlags;
        public uint indexTypeCount;
        public unsafe IndexType* indexTypes;
        public unsafe uint* indexTypeValues;
    }

    public struct IndirectCommandsLayoutCreateInfoNV {
        public StructureType sType;
        public unsafe void* next;
        public IndirectCommandsLayoutUsageFlagsNV flags;
        public PipelineBindPoint pipelineBindPoint;
        public uint tokenCount;
        public unsafe IndirectCommandsLayoutTokenNV* tokens;
        public uint streamCount;
        public unsafe uint* streamStrides;
    }

    public struct GeneratedCommandsInfoNV {
        public StructureType sType;
        public unsafe void* next;
        public PipelineBindPoint pipelineBindPoint;
        public Pipeline pipeline;
        public IndirectCommandsLayoutNV indirectCommandsLayout;
        public uint streamCount;
        public unsafe IndirectCommandsStreamNV* streams;
        public uint sequencesCount;
        public Buffer preprocessBuffer;
        public ulong preprocessOffset;
        public ulong preprocessSize;
        public Buffer sequencesCountBuffer;
        public ulong sequencesCountOffset;
        public Buffer sequencesIndexBuffer;
        public ulong sequencesIndexOffset;
    }

    public struct GeneratedCommandsMemoryRequirementsInfoNV {
        public StructureType sType;
        public unsafe void* next;
        public PipelineBindPoint pipelineBindPoint;
        public Pipeline pipeline;
        public IndirectCommandsLayoutNV indirectCommandsLayout;
        public uint maxSequencesCount;
    }

    public struct PhysicalDeviceFeatures2 {
        public StructureType sType;
        public unsafe void* next;
        public PhysicalDeviceFeatures features;
    }

    public struct PhysicalDeviceProperties2 {
        public StructureType sType;
        public unsafe void* next;
        public PhysicalDeviceProperties properties;
    }

    public struct FormatProperties2 {
        public StructureType sType;
        public unsafe void* next;
        public FormatProperties formatProperties;
    }

    public struct ImageFormatProperties2 {
        public StructureType sType;
        public unsafe void* next;
        public ImageFormatProperties imageFormatProperties;
    }

    public struct PhysicalDeviceImageFormatInfo2 {
        public StructureType sType;
        public unsafe void* next;
        public Format format;
        public ImageType type;
        public ImageTiling tiling;
        public ImageUsageFlags usage;
        public ImageCreateFlags flags;
    }

    public struct QueueFamilyProperties2 {
        public StructureType sType;
        public unsafe void* next;
        public QueueFamilyProperties queueFamilyProperties;
    }

    public struct PhysicalDeviceMemoryProperties2 {
        public StructureType sType;
        public unsafe void* next;
        public PhysicalDeviceMemoryProperties memoryProperties;
    }

    public struct SparseImageFormatProperties2 {
        public StructureType sType;
        public unsafe void* next;
        public SparseImageFormatProperties properties;
    }

    public struct PhysicalDeviceSparseImageFormatInfo2 {
        public StructureType sType;
        public unsafe void* next;
        public Format format;
        public ImageType type;
        public SampleCountFlags samples;
        public ImageUsageFlags usage;
        public ImageTiling tiling;
    }

    public struct PhysicalDevicePushDescriptorPropertiesKHR {
        public StructureType sType;
        public unsafe void* next;
        public uint maxPushDescriptors;
    }

    public struct ConformanceVersion {
        public byte major;
        public byte minor;
        public byte subminor;
        public byte patch;
    }

    public struct PhysicalDeviceDriverProperties {
        public StructureType sType;
        public unsafe void* next;
        public DriverId driverID;
        public unsafe fixed byte driverName[Constants.MaxDriverNameSize];
        public unsafe fixed byte driverInfo[Constants.MaxDriverInfoSize];
        public ConformanceVersion conformanceVersion;
    }

    public struct PresentRegionsKHR {
        public StructureType sType;
        public unsafe void* next;
        public uint swapchainCount;
        public unsafe PresentRegionKHR* regions;
    }

    public struct PresentRegionKHR {
        public uint rectangleCount;
        public unsafe RectLayerKHR* rectangles;
    }

    public struct RectLayerKHR {
        public Offset2D offset;
        public Extent2D extent;
        public uint layer;
    }

    public struct PhysicalDeviceVariablePointersFeatures {
        public StructureType sType;
        public unsafe void* next;
        public uint variablePointersStorageBuffer;
        public uint variablePointers;
    }

    public struct ExternalMemoryProperties {
        public ExternalMemoryFeatureFlags externalMemoryFeatures;
        public ExternalMemoryHandleTypeFlags exportFromImportedHandleTypes;
        public ExternalMemoryHandleTypeFlags compatibleHandleTypes;
    }

    public struct PhysicalDeviceExternalImageFormatInfo {
        public StructureType sType;
        public unsafe void* next;
        public ExternalMemoryHandleTypeFlags handleType;
    }

    public struct ExternalImageFormatProperties {
        public StructureType sType;
        public unsafe void* next;
        public ExternalMemoryProperties externalMemoryProperties;
    }

    public struct PhysicalDeviceExternalBufferInfo {
        public StructureType sType;
        public unsafe void* next;
        public BufferCreateFlags flags;
        public BufferUsageFlags usage;
        public ExternalMemoryHandleTypeFlags handleType;
    }

    public struct ExternalBufferProperties {
        public StructureType sType;
        public unsafe void* next;
        public ExternalMemoryProperties externalMemoryProperties;
    }

    public struct PhysicalDeviceIDProperties {
        public StructureType sType;
        public unsafe void* next;
        public unsafe fixed byte deviceUUID[Constants.UuidSize];
        public unsafe fixed byte driverUUID[Constants.UuidSize];
        public unsafe fixed byte deviceLUID[Constants.LuidSize];
        public uint deviceNodeMask;
        public uint deviceLUIDValid;
    }

    public struct ExternalMemoryImageCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public ExternalMemoryHandleTypeFlags handleTypes;
    }

    public struct ExternalMemoryBufferCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public ExternalMemoryHandleTypeFlags handleTypes;
    }

    public struct ExportMemoryAllocateInfo {
        public StructureType sType;
        public unsafe void* next;
        public ExternalMemoryHandleTypeFlags handleTypes;
    }

    public struct ImportMemoryWin32HandleInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public ExternalMemoryHandleTypeFlags handleType;
        public unsafe void* handle;
        public unsafe char* name;
    }

    public struct ExportMemoryWin32HandleInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public unsafe SECURITY_ATTRIBUTES* attributes;
        public uint dwAccess;
        public unsafe char* name;
    }

    public struct MemoryWin32HandlePropertiesKHR {
        public StructureType sType;
        public unsafe void* next;
        public uint memoryTypeBits;
    }

    public struct MemoryGetWin32HandleInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public DeviceMemory memory;
        public ExternalMemoryHandleTypeFlags handleType;
    }

    public struct ImportMemoryFdInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public ExternalMemoryHandleTypeFlags handleType;
        public short fd;
    }

    public struct MemoryFdPropertiesKHR {
        public StructureType sType;
        public unsafe void* next;
        public uint memoryTypeBits;
    }

    public struct MemoryGetFdInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public DeviceMemory memory;
        public ExternalMemoryHandleTypeFlags handleType;
    }

    public struct Win32KeyedMutexAcquireReleaseInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public uint acquireCount;
        public unsafe DeviceMemory* acquireSyncs;
        public unsafe ulong* acquireKeys;
        public unsafe uint* acquireTimeouts;
        public uint releaseCount;
        public unsafe DeviceMemory* releaseSyncs;
        public unsafe ulong* releaseKeys;
    }

    public struct PhysicalDeviceExternalSemaphoreInfo {
        public StructureType sType;
        public unsafe void* next;
        public ExternalSemaphoreHandleTypeFlags handleType;
    }

    public struct ExternalSemaphoreProperties {
        public StructureType sType;
        public unsafe void* next;
        public ExternalSemaphoreHandleTypeFlags exportFromImportedHandleTypes;
        public ExternalSemaphoreHandleTypeFlags compatibleHandleTypes;
        public ExternalSemaphoreFeatureFlags externalSemaphoreFeatures;
    }

    public struct ExportSemaphoreCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public ExternalSemaphoreHandleTypeFlags handleTypes;
    }

    public struct ImportSemaphoreWin32HandleInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public Semaphore semaphore;
        public SemaphoreImportFlags flags;
        public ExternalSemaphoreHandleTypeFlags handleType;
        public unsafe void* handle;
        public unsafe char* name;
    }

    public struct ExportSemaphoreWin32HandleInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public unsafe SECURITY_ATTRIBUTES* attributes;
        public uint dwAccess;
        public unsafe char* name;
    }

    public struct D3D12FenceSubmitInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public uint waitSemaphoreValuesCount;
        public unsafe ulong* waitSemaphoreValues;
        public uint signalSemaphoreValuesCount;
        public unsafe ulong* signalSemaphoreValues;
    }

    public struct SemaphoreGetWin32HandleInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public Semaphore semaphore;
        public ExternalSemaphoreHandleTypeFlags handleType;
    }

    public struct ImportSemaphoreFdInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public Semaphore semaphore;
        public SemaphoreImportFlags flags;
        public ExternalSemaphoreHandleTypeFlags handleType;
        public short fd;
    }

    public struct SemaphoreGetFdInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public Semaphore semaphore;
        public ExternalSemaphoreHandleTypeFlags handleType;
    }

    public struct PhysicalDeviceExternalFenceInfo {
        public StructureType sType;
        public unsafe void* next;
        public ExternalFenceHandleTypeFlags handleType;
    }

    public struct ExternalFenceProperties {
        public StructureType sType;
        public unsafe void* next;
        public ExternalFenceHandleTypeFlags exportFromImportedHandleTypes;
        public ExternalFenceHandleTypeFlags compatibleHandleTypes;
        public ExternalFenceFeatureFlags externalFenceFeatures;
    }

    public struct ExportFenceCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public ExternalFenceHandleTypeFlags handleTypes;
    }

    public struct ImportFenceWin32HandleInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public Fence fence;
        public FenceImportFlags flags;
        public ExternalFenceHandleTypeFlags handleType;
        public unsafe void* handle;
        public unsafe char* name;
    }

    public struct ExportFenceWin32HandleInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public unsafe SECURITY_ATTRIBUTES* attributes;
        public uint dwAccess;
        public unsafe char* name;
    }

    public struct FenceGetWin32HandleInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public Fence fence;
        public ExternalFenceHandleTypeFlags handleType;
    }

    public struct ImportFenceFdInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public Fence fence;
        public FenceImportFlags flags;
        public ExternalFenceHandleTypeFlags handleType;
        public short fd;
    }

    public struct FenceGetFdInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public Fence fence;
        public ExternalFenceHandleTypeFlags handleType;
    }

    public struct PhysicalDeviceMultiviewFeatures {
        public StructureType sType;
        public unsafe void* next;
        public uint multiview;
        public uint multiviewGeometryShader;
        public uint multiviewTessellationShader;
    }

    public struct PhysicalDeviceMultiviewProperties {
        public StructureType sType;
        public unsafe void* next;
        public uint maxMultiviewViewCount;
        public uint maxMultiviewInstanceIndex;
    }

    public struct RenderPassMultiviewCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public uint subpassCount;
        public unsafe uint* viewMasks;
        public uint dependencyCount;
        public unsafe int* viewOffsets;
        public uint correlationMaskCount;
        public unsafe uint* correlationMasks;
    }

    public struct SurfaceCapabilities2EXT {
        public StructureType sType;
        public unsafe void* next;
        public uint minImageCount;
        public uint maxImageCount;
        public Extent2D currentExtent;
        public Extent2D minImageExtent;
        public Extent2D maxImageExtent;
        public uint maxImageArrayLayers;
        public SurfaceTransformFlagsKHR supportedTransforms;
        public SurfaceTransformFlagsKHR currentTransform;
        public CompositeAlphaFlagsKHR supportedCompositeAlpha;
        public ImageUsageFlags supportedUsageFlags;
        public SurfaceCounterFlagsEXT supportedSurfaceCounters;
    }

    public struct DisplayPowerInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public DisplayPowerStateEXT powerState;
    }

    public struct DeviceEventInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public DeviceEventTypeEXT deviceEvent;
    }

    public struct DisplayEventInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public DisplayEventTypeEXT displayEvent;
    }

    public struct SwapchainCounterCreateInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public SurfaceCounterFlagsEXT surfaceCounters;
    }

    public struct PhysicalDeviceGroupProperties {
        public StructureType sType;
        public unsafe void* next;
        public uint physicalDeviceCount;
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
        public uint subsetAllocation;
    }

    public struct MemoryAllocateFlagsInfo {
        public StructureType sType;
        public unsafe void* next;
        public MemoryAllocateFlags flags;
        public uint deviceMask;
    }

    public struct BindBufferMemoryInfo {
        public StructureType sType;
        public unsafe void* next;
        public Buffer buffer;
        public DeviceMemory memory;
        public ulong memoryOffset;
    }

    public struct BindBufferMemoryDeviceGroupInfo {
        public StructureType sType;
        public unsafe void* next;
        public uint deviceIndexCount;
        public unsafe uint* deviceIndices;
    }

    public struct BindImageMemoryInfo {
        public StructureType sType;
        public unsafe void* next;
        public Image image;
        public DeviceMemory memory;
        public ulong memoryOffset;
    }

    public struct BindImageMemoryDeviceGroupInfo {
        public StructureType sType;
        public unsafe void* next;
        public uint deviceIndexCount;
        public unsafe uint* deviceIndices;
        public uint splitInstanceBindRegionCount;
        public unsafe Rect2D* splitInstanceBindRegions;
    }

    public struct DeviceGroupRenderPassBeginInfo {
        public StructureType sType;
        public unsafe void* next;
        public uint deviceMask;
        public uint deviceRenderAreaCount;
        public unsafe Rect2D* deviceRenderAreas;
    }

    public struct DeviceGroupCommandBufferBeginInfo {
        public StructureType sType;
        public unsafe void* next;
        public uint deviceMask;
    }

    public struct DeviceGroupSubmitInfo {
        public StructureType sType;
        public unsafe void* next;
        public uint waitSemaphoreCount;
        public unsafe uint* waitSemaphoreDeviceIndices;
        public uint commandBufferCount;
        public unsafe uint* commandBufferDeviceMasks;
        public uint signalSemaphoreCount;
        public unsafe uint* signalSemaphoreDeviceIndices;
    }

    public struct DeviceGroupBindSparseInfo {
        public StructureType sType;
        public unsafe void* next;
        public uint resourceDeviceIndex;
        public uint memoryDeviceIndex;
    }

    public struct DeviceGroupPresentCapabilitiesKHR {
        public StructureType sType;
        public unsafe void* next;
        public unsafe fixed uint presentMask[Constants.MaxDeviceGroupSize];
        public DeviceGroupPresentModeFlagsKHR modes;
    }

    public struct ImageSwapchainCreateInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public SwapchainKHR swapchain;
    }

    public struct BindImageMemorySwapchainInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public SwapchainKHR swapchain;
        public uint imageIndex;
    }

    public struct AcquireNextImageInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public SwapchainKHR swapchain;
        public ulong timeout;
        public Semaphore semaphore;
        public Fence fence;
        public uint deviceMask;
    }

    public struct DeviceGroupPresentInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public uint swapchainCount;
        public unsafe uint* deviceMasks;
        public DeviceGroupPresentModeFlagsKHR mode;
    }

    public struct DeviceGroupDeviceCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public uint physicalDeviceCount;
        public unsafe PhysicalDevice* physicalDevices;
    }

    public struct DeviceGroupSwapchainCreateInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public DeviceGroupPresentModeFlagsKHR modes;
    }

    public struct DescriptorUpdateTemplateEntry {
        public uint dstBinding;
        public uint dstArrayElement;
        public uint descriptorCount;
        public DescriptorType descriptorType;
        public nuint offset;
        public nuint stride;
    }

    public struct DescriptorUpdateTemplateCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public DescriptorUpdateTemplateCreateFlags flags;
        public uint descriptorUpdateEntryCount;
        public unsafe DescriptorUpdateTemplateEntry* descriptorUpdateEntries;
        public DescriptorUpdateTemplateType templateType;
        public DescriptorSetLayout descriptorSetLayout;
        public PipelineBindPoint pipelineBindPoint;
        public PipelineLayout pipelineLayout;
        public uint set;
    }

    public struct XYColorEXT {
        public float x;
        public float y;
    }

    public struct HdrMetadataEXT {
        public StructureType sType;
        public unsafe void* next;
        public XYColorEXT displayPrimaryRed;
        public XYColorEXT displayPrimaryGreen;
        public XYColorEXT displayPrimaryBlue;
        public XYColorEXT whitePoint;
        public float maxLuminance;
        public float minLuminance;
        public float maxContentLightLevel;
        public float maxFrameAverageLightLevel;
    }

    public struct DisplayNativeHdrSurfaceCapabilitiesAMD {
        public StructureType sType;
        public unsafe void* next;
        public uint localDimmingSupport;
    }

    public struct SwapchainDisplayNativeHdrCreateInfoAMD {
        public StructureType sType;
        public unsafe void* next;
        public uint localDimmingEnable;
    }

    public struct RefreshCycleDurationGOOGLE {
        public ulong refreshDuration;
    }

    public struct PastPresentationTimingGOOGLE {
        public uint presentID;
        public ulong desiredPresentTime;
        public ulong actualPresentTime;
        public ulong earliestPresentTime;
        public ulong presentMargin;
    }

    public struct PresentTimesInfoGOOGLE {
        public StructureType sType;
        public unsafe void* next;
        public uint swapchainCount;
        public unsafe PresentTimeGOOGLE* times;
    }

    public struct PresentTimeGOOGLE {
        public uint presentID;
        public ulong desiredPresentTime;
    }

    public struct IOSSurfaceCreateInfoMVK {
        public StructureType sType;
        public unsafe void* next;
        public IOSSurfaceCreateFlagsMVK flags;
        public unsafe void* view;
    }

    public struct MacOSSurfaceCreateInfoMVK {
        public StructureType sType;
        public unsafe void* next;
        public MacOSSurfaceCreateFlagsMVK flags;
        public unsafe void* view;
    }

    public struct MetalSurfaceCreateInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public MetalSurfaceCreateFlagsEXT flags;
        public unsafe void* layer;
    }

    public struct ViewportWScalingNV {
        public float xcoeff;
        public float ycoeff;
    }

    public struct PipelineViewportWScalingStateCreateInfoNV {
        public StructureType sType;
        public unsafe void* next;
        public uint viewportWScalingEnable;
        public uint viewportCount;
        public unsafe ViewportWScalingNV* viewportWScalings;
    }

    public struct ViewportSwizzleNV {
        public ViewportCoordinateSwizzleNV x;
        public ViewportCoordinateSwizzleNV y;
        public ViewportCoordinateSwizzleNV z;
        public ViewportCoordinateSwizzleNV w;
    }

    public struct PipelineViewportSwizzleStateCreateInfoNV {
        public StructureType sType;
        public unsafe void* next;
        public PipelineViewportSwizzleStateCreateFlagsNV flags;
        public uint viewportCount;
        public unsafe ViewportSwizzleNV* viewportSwizzles;
    }

    public struct PhysicalDeviceDiscardRectanglePropertiesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint maxDiscardRectangles;
    }

    public struct PipelineDiscardRectangleStateCreateInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public PipelineDiscardRectangleStateCreateFlagsEXT flags;
        public DiscardRectangleModeEXT discardRectangleMode;
        public uint discardRectangleCount;
        public unsafe Rect2D* discardRectangles;
    }

    public struct PhysicalDeviceMultiviewPerViewAttributesPropertiesNVX {
        public StructureType sType;
        public unsafe void* next;
        public uint perViewPositionAllComponents;
    }

    public struct InputAttachmentAspectReference {
        public uint subpass;
        public uint inputAttachmentIndex;
        public ImageAspectFlags aspectMask;
    }

    public struct RenderPassInputAttachmentAspectCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public uint aspectReferenceCount;
        public unsafe InputAttachmentAspectReference* aspectReferences;
    }

    public struct PhysicalDeviceSurfaceInfo2KHR {
        public StructureType sType;
        public unsafe void* next;
        public SurfaceKHR surface;
    }

    public struct SurfaceCapabilities2KHR {
        public StructureType sType;
        public unsafe void* next;
        public SurfaceCapabilitiesKHR surfaceCapabilities;
    }

    public struct SurfaceFormat2KHR {
        public StructureType sType;
        public unsafe void* next;
        public SurfaceFormatKHR surfaceFormat;
    }

    public struct DisplayProperties2KHR {
        public StructureType sType;
        public unsafe void* next;
        public DisplayPropertiesKHR displayProperties;
    }

    public struct DisplayPlaneProperties2KHR {
        public StructureType sType;
        public unsafe void* next;
        public DisplayPlanePropertiesKHR displayPlaneProperties;
    }

    public struct DisplayModeProperties2KHR {
        public StructureType sType;
        public unsafe void* next;
        public DisplayModePropertiesKHR displayModeProperties;
    }

    public struct DisplayPlaneInfo2KHR {
        public StructureType sType;
        public unsafe void* next;
        public DisplayModeKHR mode;
        public uint planeIndex;
    }

    public struct DisplayPlaneCapabilities2KHR {
        public StructureType sType;
        public unsafe void* next;
        public DisplayPlaneCapabilitiesKHR capabilities;
    }

    public struct SharedPresentSurfaceCapabilitiesKHR {
        public StructureType sType;
        public unsafe void* next;
        public ImageUsageFlags sharedPresentSupportedUsageFlags;
    }

    public struct PhysicalDevice16BitStorageFeatures {
        public StructureType sType;
        public unsafe void* next;
        public uint storageBuffer16BitAccess;
        public uint uniformAndStorageBuffer16BitAccess;
        public uint storagePushConstant16;
        public uint storageInputOutput16;
    }

    public struct PhysicalDeviceSubgroupProperties {
        public StructureType sType;
        public unsafe void* next;
        public uint subgroupSize;
        public ShaderStageFlags supportedStages;
        public SubgroupFeatureFlags supportedOperations;
        public uint quadOperationsInAllStages;
    }

    public struct PhysicalDeviceShaderSubgroupExtendedTypesFeatures {
        public StructureType sType;
        public unsafe void* next;
        public uint shaderSubgroupExtendedTypes;
    }

    public struct BufferMemoryRequirementsInfo2 {
        public StructureType sType;
        public unsafe void* next;
        public Buffer buffer;
    }

    public struct ImageMemoryRequirementsInfo2 {
        public StructureType sType;
        public unsafe void* next;
        public Image image;
    }

    public struct ImageSparseMemoryRequirementsInfo2 {
        public StructureType sType;
        public unsafe void* next;
        public Image image;
    }

    public struct MemoryRequirements2 {
        public StructureType sType;
        public unsafe void* next;
        public MemoryRequirements memoryRequirements;
    }

    public struct SparseImageMemoryRequirements2 {
        public StructureType sType;
        public unsafe void* next;
        public SparseImageMemoryRequirements memoryRequirements;
    }

    public struct PhysicalDevicePointClippingProperties {
        public StructureType sType;
        public unsafe void* next;
        public PointClippingBehavior pointClippingBehavior;
    }

    public struct MemoryDedicatedRequirements {
        public StructureType sType;
        public unsafe void* next;
        public uint prefersDedicatedAllocation;
        public uint requiresDedicatedAllocation;
    }

    public struct MemoryDedicatedAllocateInfo {
        public StructureType sType;
        public unsafe void* next;
        public Image image;
        public Buffer buffer;
    }

    public struct ImageViewUsageCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public ImageUsageFlags usage;
    }

    public struct PipelineTessellationDomainOriginStateCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public TessellationDomainOrigin domainOrigin;
    }

    public struct SamplerYcbcrConversionInfo {
        public StructureType sType;
        public unsafe void* next;
        public SamplerYcbcrConversion conversion;
    }

    public struct SamplerYcbcrConversionCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public Format format;
        public SamplerYcbcrModelConversion ycbcrModel;
        public SamplerYcbcrRange ycbcrRange;
        public ComponentMapping components;
        public ChromaLocation xChromaOffset;
        public ChromaLocation yChromaOffset;
        public Filter chromaFilter;
        public uint forceExplicitReconstruction;
    }

    public struct BindImagePlaneMemoryInfo {
        public StructureType sType;
        public unsafe void* next;
        public ImageAspectFlags planeAspect;
    }

    public struct ImagePlaneMemoryRequirementsInfo {
        public StructureType sType;
        public unsafe void* next;
        public ImageAspectFlags planeAspect;
    }

    public struct PhysicalDeviceSamplerYcbcrConversionFeatures {
        public StructureType sType;
        public unsafe void* next;
        public uint samplerYcbcrConversion;
    }

    public struct SamplerYcbcrConversionImageFormatProperties {
        public StructureType sType;
        public unsafe void* next;
        public uint combinedImageSamplerDescriptorCount;
    }

    public struct TextureLODGatherFormatPropertiesAMD {
        public StructureType sType;
        public unsafe void* next;
        public uint supportsTextureGatherLODBiasAMD;
    }

    public struct ConditionalRenderingBeginInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public Buffer buffer;
        public ulong offset;
        public ConditionalRenderingFlagsEXT flags;
    }

    public struct ProtectedSubmitInfo {
        public StructureType sType;
        public unsafe void* next;
        public uint protectedSubmit;
    }

    public struct PhysicalDeviceProtectedMemoryFeatures {
        public StructureType sType;
        public unsafe void* next;
        public uint protectedMemory;
    }

    public struct PhysicalDeviceProtectedMemoryProperties {
        public StructureType sType;
        public unsafe void* next;
        public uint protectedNoFault;
    }

    public struct DeviceQueueInfo2 {
        public StructureType sType;
        public unsafe void* next;
        public DeviceQueueCreateFlags flags;
        public uint queueFamilyIndex;
        public uint queueIndex;
    }

    public struct PipelineCoverageToColorStateCreateInfoNV {
        public StructureType sType;
        public unsafe void* next;
        public PipelineCoverageToColorStateCreateFlagsNV flags;
        public uint coverageToColorEnable;
        public uint coverageToColorLocation;
    }

    public struct PhysicalDeviceSamplerFilterMinmaxProperties {
        public StructureType sType;
        public unsafe void* next;
        public uint filterMinmaxSingleComponentFormats;
        public uint filterMinmaxImageComponentMapping;
    }

    public struct SampleLocationEXT {
        public float x;
        public float y;
    }

    public struct SampleLocationsInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public SampleCountFlags sampleLocationsPerPixel;
        public Extent2D sampleLocationGridSize;
        public uint sampleLocationsCount;
        public unsafe SampleLocationEXT* sampleLocations;
    }

    public struct AttachmentSampleLocationsEXT {
        public uint attachmentIndex;
        public SampleLocationsInfoEXT sampleLocationsInfo;
    }

    public struct SubpassSampleLocationsEXT {
        public uint subpassIndex;
        public SampleLocationsInfoEXT sampleLocationsInfo;
    }

    public struct RenderPassSampleLocationsBeginInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint attachmentInitialSampleLocationsCount;
        public unsafe AttachmentSampleLocationsEXT* attachmentInitialSampleLocations;
        public uint postSubpassSampleLocationsCount;
        public unsafe SubpassSampleLocationsEXT* postSubpassSampleLocations;
    }

    public struct PipelineSampleLocationsStateCreateInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint sampleLocationsEnable;
        public SampleLocationsInfoEXT sampleLocationsInfo;
    }

    public struct PhysicalDeviceSampleLocationsPropertiesEXT {
        public StructureType sType;
        public unsafe void* next;
        public SampleCountFlags sampleLocationSampleCounts;
        public Extent2D maxSampleLocationGridSize;
        public unsafe fixed float sampleLocationCoordinateRange[2];
        public uint sampleLocationSubPixelBits;
        public uint variableSampleLocations;
    }

    public struct MultisamplePropertiesEXT {
        public StructureType sType;
        public unsafe void* next;
        public Extent2D maxSampleLocationGridSize;
    }

    public struct SamplerReductionModeCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public SamplerReductionMode reductionMode;
    }

    public struct PhysicalDeviceBlendOperationAdvancedFeaturesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint advancedBlendCoherentOperations;
    }

    public struct PhysicalDeviceBlendOperationAdvancedPropertiesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint advancedBlendMaxColorAttachments;
        public uint advancedBlendIndependentBlend;
        public uint advancedBlendNonPremultipliedSrcColor;
        public uint advancedBlendNonPremultipliedDstColor;
        public uint advancedBlendCorrelatedOverlap;
        public uint advancedBlendAllOperations;
    }

    public struct PipelineColorBlendAdvancedStateCreateInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint srcPremultiplied;
        public uint dstPremultiplied;
        public BlendOverlapEXT blendOverlap;
    }

    public struct PhysicalDeviceInlineUniformBlockFeaturesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint inlineUniformBlock;
        public uint descriptorBindingInlineUniformBlockUpdateAfterBind;
    }

    public struct PhysicalDeviceInlineUniformBlockPropertiesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint maxInlineUniformBlockSize;
        public uint maxPerStageDescriptorInlineUniformBlocks;
        public uint maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
        public uint maxDescriptorSetInlineUniformBlocks;
        public uint maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
    }

    public struct WriteDescriptorSetInlineUniformBlockEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint dataSize;
        public unsafe void* data;
    }

    public struct DescriptorPoolInlineUniformBlockCreateInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint maxInlineUniformBlockBindings;
    }

    public struct PipelineCoverageModulationStateCreateInfoNV {
        public StructureType sType;
        public unsafe void* next;
        public PipelineCoverageModulationStateCreateFlagsNV flags;
        public CoverageModulationModeNV coverageModulationMode;
        public uint coverageModulationTableEnable;
        public uint coverageModulationTableCount;
        public unsafe float* coverageModulationTable;
    }

    public struct ImageFormatListCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public uint viewFormatCount;
        public unsafe Format* viewFormats;
    }

    public struct ValidationCacheCreateInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public ValidationCacheCreateFlagsEXT flags;
        public nuint initialDataSize;
        public unsafe void* initialData;
    }

    public struct ShaderModuleValidationCacheCreateInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public ValidationCacheEXT validationCache;
    }

    public struct PhysicalDeviceMaintenance3Properties {
        public StructureType sType;
        public unsafe void* next;
        public uint maxPerSetDescriptors;
        public ulong maxMemoryAllocationSize;
    }

    public struct DescriptorSetLayoutSupport {
        public StructureType sType;
        public unsafe void* next;
        public uint supported;
    }

    public struct PhysicalDeviceShaderDrawParametersFeatures {
        public StructureType sType;
        public unsafe void* next;
        public uint shaderDrawParameters;
    }

    public struct PhysicalDeviceShaderFloat16Int8Features {
        public StructureType sType;
        public unsafe void* next;
        public uint shaderFloat16;
        public uint shaderInt8;
    }

    public struct PhysicalDeviceFloatControlsProperties {
        public StructureType sType;
        public unsafe void* next;
        public ShaderFloatControlsIndependence denormBehaviorIndependence;
        public ShaderFloatControlsIndependence roundingModeIndependence;
        public uint shaderSignedZeroInfNanPreserveFloat16;
        public uint shaderSignedZeroInfNanPreserveFloat32;
        public uint shaderSignedZeroInfNanPreserveFloat64;
        public uint shaderDenormPreserveFloat16;
        public uint shaderDenormPreserveFloat32;
        public uint shaderDenormPreserveFloat64;
        public uint shaderDenormFlushToZeroFloat16;
        public uint shaderDenormFlushToZeroFloat32;
        public uint shaderDenormFlushToZeroFloat64;
        public uint shaderRoundingModeRTEFloat16;
        public uint shaderRoundingModeRTEFloat32;
        public uint shaderRoundingModeRTEFloat64;
        public uint shaderRoundingModeRTZFloat16;
        public uint shaderRoundingModeRTZFloat32;
        public uint shaderRoundingModeRTZFloat64;
    }

    public struct PhysicalDeviceHostQueryResetFeatures {
        public StructureType sType;
        public unsafe void* next;
        public uint hostQueryReset;
    }

    public struct NativeBufferUsage2ANDROID {
        public ulong consumer;
        public ulong producer;
    }

    public struct NativeBufferANDROID {
        public StructureType sType;
        public unsafe void* next;
        public unsafe void* handle;
        public short stride;
        public short format;
        public short usage;
        public NativeBufferUsage2ANDROID usage2;
    }

    public struct SwapchainImageCreateInfoANDROID {
        public StructureType sType;
        public unsafe void* next;
        public SwapchainImageUsageFlagsANDROID usage;
    }

    public struct PhysicalDevicePresentationPropertiesANDROID {
        public StructureType sType;
        public unsafe void* next;
        public uint sharedImage;
    }

    public struct ShaderResourceUsageAMD {
        public uint numUsedVgprs;
        public uint numUsedSgprs;
        public uint ldsSizePerLocalWorkGroup;
        public nuint ldsUsageSizeInBytes;
        public nuint scratchMemUsageInBytes;
    }

    public struct ShaderStatisticsInfoAMD {
        public ShaderStageFlags shaderStageMask;
        public ShaderResourceUsageAMD resourceUsage;
        public uint numPhysicalVgprs;
        public uint numPhysicalSgprs;
        public uint numAvailableVgprs;
        public uint numAvailableSgprs;
        public unsafe fixed uint computeWorkGroupSize[3];
    }

    public struct DeviceQueueGlobalPriorityCreateInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public QueueGlobalPriorityEXT globalPriority;
    }

    public struct DebugUtilsObjectNameInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public ObjectType objectType;
        public ulong objectHandle;
        public unsafe byte* objectName;
    }

    public struct DebugUtilsObjectTagInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public ObjectType objectType;
        public ulong objectHandle;
        public ulong tagName;
        public nuint tagSize;
        public unsafe void* tag;
    }

    public struct DebugUtilsLabelEXT {
        public StructureType sType;
        public unsafe void* next;
        public unsafe byte* labelName;
        public unsafe fixed float color[4];
    }

    public struct DebugUtilsMessengerCreateInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public DebugUtilsMessengerCreateFlagsEXT flags;
        public DebugUtilsMessageSeverityFlagsEXT messageSeverity;
        public DebugUtilsMessageTypeFlagsEXT messageType;
        public Instance pfnUserCallback;
        public unsafe void* userData;
    }

    public struct DebugUtilsMessengerCallbackDataEXT {
        public StructureType sType;
        public unsafe void* next;
        public DebugUtilsMessengerCallbackDataFlagsEXT flags;
        public unsafe byte* messageIdName;
        public int messageIdNumber;
        public unsafe byte* message;
        public uint queueLabelCount;
        public unsafe DebugUtilsLabelEXT* queueLabels;
        public uint cmdBufLabelCount;
        public unsafe DebugUtilsLabelEXT* cmdBufLabels;
        public uint objectCount;
        public unsafe DebugUtilsObjectNameInfoEXT* objects;
    }

    public struct ImportMemoryHostPointerInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public ExternalMemoryHandleTypeFlags handleType;
        public unsafe void* hostPointer;
    }

    public struct MemoryHostPointerPropertiesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint memoryTypeBits;
    }

    public struct PhysicalDeviceExternalMemoryHostPropertiesEXT {
        public StructureType sType;
        public unsafe void* next;
        public ulong minImportedHostPointerAlignment;
    }

    public struct PhysicalDeviceConservativeRasterizationPropertiesEXT {
        public StructureType sType;
        public unsafe void* next;
        public float primitiveOverestimationSize;
        public float maxExtraPrimitiveOverestimationSize;
        public float extraPrimitiveOverestimationSizeGranularity;
        public uint primitiveUnderestimation;
        public uint conservativePointAndLineRasterization;
        public uint degenerateTrianglesRasterized;
        public uint degenerateLinesRasterized;
        public uint fullyCoveredFragmentShaderInputVariable;
        public uint conservativeRasterizationPostDepthCoverage;
    }

    public struct CalibratedTimestampInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public TimeDomainEXT timeDomain;
    }

    public struct PhysicalDeviceShaderCorePropertiesAMD {
        public StructureType sType;
        public unsafe void* next;
        public uint shaderEngineCount;
        public uint shaderArraysPerEngineCount;
        public uint computeUnitsPerShaderArray;
        public uint simdPerComputeUnit;
        public uint wavefrontsPerSimd;
        public uint wavefrontSize;
        public uint sgprsPerSimd;
        public uint minSgprAllocation;
        public uint maxSgprAllocation;
        public uint sgprAllocationGranularity;
        public uint vgprsPerSimd;
        public uint minVgprAllocation;
        public uint maxVgprAllocation;
        public uint vgprAllocationGranularity;
    }

    public struct PhysicalDeviceShaderCoreProperties2AMD {
        public StructureType sType;
        public unsafe void* next;
        public ShaderCorePropertiesFlagsAMD shaderCoreFeatures;
        public uint activeComputeUnitCount;
    }

    public struct PipelineRasterizationConservativeStateCreateInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public PipelineRasterizationConservativeStateCreateFlagsEXT flags;
        public ConservativeRasterizationModeEXT conservativeRasterizationMode;
        public float extraPrimitiveOverestimationSize;
    }

    public struct PhysicalDeviceDescriptorIndexingFeatures {
        public StructureType sType;
        public unsafe void* next;
        public uint shaderInputAttachmentArrayDynamicIndexing;
        public uint shaderUniformTexelBufferArrayDynamicIndexing;
        public uint shaderStorageTexelBufferArrayDynamicIndexing;
        public uint shaderUniformBufferArrayNonUniformIndexing;
        public uint shaderSampledImageArrayNonUniformIndexing;
        public uint shaderStorageBufferArrayNonUniformIndexing;
        public uint shaderStorageImageArrayNonUniformIndexing;
        public uint shaderInputAttachmentArrayNonUniformIndexing;
        public uint shaderUniformTexelBufferArrayNonUniformIndexing;
        public uint shaderStorageTexelBufferArrayNonUniformIndexing;
        public uint descriptorBindingUniformBufferUpdateAfterBind;
        public uint descriptorBindingSampledImageUpdateAfterBind;
        public uint descriptorBindingStorageImageUpdateAfterBind;
        public uint descriptorBindingStorageBufferUpdateAfterBind;
        public uint descriptorBindingUniformTexelBufferUpdateAfterBind;
        public uint descriptorBindingStorageTexelBufferUpdateAfterBind;
        public uint descriptorBindingUpdateUnusedWhilePending;
        public uint descriptorBindingPartiallyBound;
        public uint descriptorBindingVariableDescriptorCount;
        public uint runtimeDescriptorArray;
    }

    public struct PhysicalDeviceDescriptorIndexingProperties {
        public StructureType sType;
        public unsafe void* next;
        public uint maxUpdateAfterBindDescriptorsInAllPools;
        public uint shaderUniformBufferArrayNonUniformIndexingNative;
        public uint shaderSampledImageArrayNonUniformIndexingNative;
        public uint shaderStorageBufferArrayNonUniformIndexingNative;
        public uint shaderStorageImageArrayNonUniformIndexingNative;
        public uint shaderInputAttachmentArrayNonUniformIndexingNative;
        public uint robustBufferAccessUpdateAfterBind;
        public uint quadDivergentImplicitLod;
        public uint maxPerStageDescriptorUpdateAfterBindSamplers;
        public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;
        public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;
        public uint maxPerStageDescriptorUpdateAfterBindSampledImages;
        public uint maxPerStageDescriptorUpdateAfterBindStorageImages;
        public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;
        public uint maxPerStageUpdateAfterBindResources;
        public uint maxDescriptorSetUpdateAfterBindSamplers;
        public uint maxDescriptorSetUpdateAfterBindUniformBuffers;
        public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindStorageBuffers;
        public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindSampledImages;
        public uint maxDescriptorSetUpdateAfterBindStorageImages;
        public uint maxDescriptorSetUpdateAfterBindInputAttachments;
    }

    public struct DescriptorSetLayoutBindingFlagsCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public uint bindingCount;
        public unsafe DescriptorBindingFlags* bindingFlags;
    }

    public struct DescriptorSetVariableDescriptorCountAllocateInfo {
        public StructureType sType;
        public unsafe void* next;
        public uint descriptorSetCount;
        public unsafe uint* descriptorCounts;
    }

    public struct DescriptorSetVariableDescriptorCountLayoutSupport {
        public StructureType sType;
        public unsafe void* next;
        public uint maxVariableDescriptorCount;
    }

    public struct AttachmentDescription2 {
        public StructureType sType;
        public unsafe void* next;
        public AttachmentDescriptionFlags flags;
        public Format format;
        public SampleCountFlags samples;
        public AttachmentLoadOp loadOp;
        public AttachmentStoreOp storeOp;
        public AttachmentLoadOp stencilLoadOp;
        public AttachmentStoreOp stencilStoreOp;
        public ImageLayout initialLayout;
        public ImageLayout finalLayout;
    }

    public struct AttachmentReference2 {
        public StructureType sType;
        public unsafe void* next;
        public uint attachment;
        public ImageLayout layout;
        public ImageAspectFlags aspectMask;
    }

    public struct SubpassDescription2 {
        public StructureType sType;
        public unsafe void* next;
        public SubpassDescriptionFlags flags;
        public PipelineBindPoint pipelineBindPoint;
        public uint viewMask;
        public uint inputAttachmentCount;
        public unsafe AttachmentReference2* inputAttachments;
        public uint colorAttachmentCount;
        public unsafe AttachmentReference2* colorAttachments;
        public unsafe AttachmentReference2* resolveAttachments;
        public unsafe AttachmentReference2* depthStencilAttachment;
        public uint preserveAttachmentCount;
        public unsafe uint* preserveAttachments;
    }

    public struct SubpassDependency2 {
        public StructureType sType;
        public unsafe void* next;
        public uint srcSubpass;
        public uint dstSubpass;
        public PipelineStageFlags srcStageMask;
        public PipelineStageFlags dstStageMask;
        public AccessFlags srcAccessMask;
        public AccessFlags dstAccessMask;
        public DependencyFlags dependencyFlags;
        public int viewOffset;
    }

    public struct RenderPassCreateInfo2 {
        public StructureType sType;
        public unsafe void* next;
        public RenderPassCreateFlags flags;
        public uint attachmentCount;
        public unsafe AttachmentDescription2* attachments;
        public uint subpassCount;
        public unsafe SubpassDescription2* subpasses;
        public uint dependencyCount;
        public unsafe SubpassDependency2* dependencies;
        public uint correlatedViewMaskCount;
        public unsafe uint* correlatedViewMasks;
    }

    public struct SubpassBeginInfo {
        public StructureType sType;
        public unsafe void* next;
        public SubpassContents contents;
    }

    public struct SubpassEndInfo {
        public StructureType sType;
        public unsafe void* next;
    }

    public struct PhysicalDeviceTimelineSemaphoreFeatures {
        public StructureType sType;
        public unsafe void* next;
        public uint timelineSemaphore;
    }

    public struct PhysicalDeviceTimelineSemaphoreProperties {
        public StructureType sType;
        public unsafe void* next;
        public ulong maxTimelineSemaphoreValueDifference;
    }

    public struct SemaphoreTypeCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public SemaphoreType semaphoreType;
        public ulong initialValue;
    }

    public struct TimelineSemaphoreSubmitInfo {
        public StructureType sType;
        public unsafe void* next;
        public uint waitSemaphoreValueCount;
        public unsafe ulong* waitSemaphoreValues;
        public uint signalSemaphoreValueCount;
        public unsafe ulong* signalSemaphoreValues;
    }

    public struct SemaphoreWaitInfo {
        public StructureType sType;
        public unsafe void* next;
        public SemaphoreWaitFlags flags;
        public uint semaphoreCount;
        public unsafe Semaphore* semaphores;
        public unsafe ulong* values;
    }

    public struct SemaphoreSignalInfo {
        public StructureType sType;
        public unsafe void* next;
        public Semaphore semaphore;
        public ulong value;
    }

    public struct VertexInputBindingDivisorDescriptionEXT {
        public uint binding;
        public uint divisor;
    }

    public struct PipelineVertexInputDivisorStateCreateInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint vertexBindingDivisorCount;
        public unsafe VertexInputBindingDivisorDescriptionEXT* vertexBindingDivisors;
    }

    public struct PhysicalDeviceVertexAttributeDivisorPropertiesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint maxVertexAttribDivisor;
    }

    public struct PhysicalDevicePCIBusInfoPropertiesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint pciDomain;
        public uint pciBus;
        public uint pciDevice;
        public uint pciFunction;
    }

    public struct ImportAndroidHardwareBufferInfoANDROID {
        public StructureType sType;
        public unsafe void* next;
        public unsafe void** buffer;
    }

    public struct AndroidHardwareBufferUsageANDROID {
        public StructureType sType;
        public unsafe void* next;
        public ulong androidHardwareBufferUsage;
    }

    public struct AndroidHardwareBufferPropertiesANDROID {
        public StructureType sType;
        public unsafe void* next;
        public ulong allocationSize;
        public uint memoryTypeBits;
    }

    public struct MemoryGetAndroidHardwareBufferInfoANDROID {
        public StructureType sType;
        public unsafe void* next;
        public DeviceMemory memory;
    }

    public struct AndroidHardwareBufferFormatPropertiesANDROID {
        public StructureType sType;
        public unsafe void* next;
        public Format format;
        public ulong externalFormat;
        public FormatFeatureFlags formatFeatures;
        public ComponentMapping samplerYcbcrConversionComponents;
        public SamplerYcbcrModelConversion suggestedYcbcrModel;
        public SamplerYcbcrRange suggestedYcbcrRange;
        public ChromaLocation suggestedXChromaOffset;
        public ChromaLocation suggestedYChromaOffset;
    }

    public struct CommandBufferInheritanceConditionalRenderingInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint conditionalRenderingEnable;
    }

    public struct ExternalFormatANDROID {
        public StructureType sType;
        public unsafe void* next;
        public ulong externalFormat;
    }

    public struct PhysicalDevice8BitStorageFeatures {
        public StructureType sType;
        public unsafe void* next;
        public uint storageBuffer8BitAccess;
        public uint uniformAndStorageBuffer8BitAccess;
        public uint storagePushConstant8;
    }

    public struct PhysicalDeviceConditionalRenderingFeaturesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint conditionalRendering;
        public uint inheritedConditionalRendering;
    }

    public struct PhysicalDeviceVulkanMemoryModelFeatures {
        public StructureType sType;
        public unsafe void* next;
        public uint vulkanMemoryModel;
        public uint vulkanMemoryModelDeviceScope;
        public uint vulkanMemoryModelAvailabilityVisibilityChains;
    }

    public struct PhysicalDeviceShaderAtomicInt64Features {
        public StructureType sType;
        public unsafe void* next;
        public uint shaderBufferInt64Atomics;
        public uint shaderSharedInt64Atomics;
    }

    public struct PhysicalDeviceShaderAtomicFloatFeaturesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint shaderBufferFloat32Atomics;
        public uint shaderBufferFloat32AtomicAdd;
        public uint shaderBufferFloat64Atomics;
        public uint shaderBufferFloat64AtomicAdd;
        public uint shaderSharedFloat32Atomics;
        public uint shaderSharedFloat32AtomicAdd;
        public uint shaderSharedFloat64Atomics;
        public uint shaderSharedFloat64AtomicAdd;
        public uint shaderImageFloat32Atomics;
        public uint shaderImageFloat32AtomicAdd;
        public uint sparseImageFloat32Atomics;
        public uint sparseImageFloat32AtomicAdd;
    }

    public struct PhysicalDeviceVertexAttributeDivisorFeaturesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint vertexAttributeInstanceRateDivisor;
        public uint vertexAttributeInstanceRateZeroDivisor;
    }

    public struct QueueFamilyCheckpointPropertiesNV {
        public StructureType sType;
        public unsafe void* next;
        public PipelineStageFlags checkpointExecutionStageMask;
    }

    public struct CheckpointDataNV {
        public StructureType sType;
        public unsafe void* next;
        public PipelineStageFlags stage;
        public unsafe void* checkpointMarker;
    }

    public struct PhysicalDeviceDepthStencilResolveProperties {
        public StructureType sType;
        public unsafe void* next;
        public ResolveModeFlags supportedDepthResolveModes;
        public ResolveModeFlags supportedStencilResolveModes;
        public uint independentResolveNone;
        public uint independentResolve;
    }

    public struct SubpassDescriptionDepthStencilResolve {
        public StructureType sType;
        public unsafe void* next;
        public ResolveModeFlags depthResolveMode;
        public ResolveModeFlags stencilResolveMode;
        public unsafe AttachmentReference2* depthStencilResolveAttachment;
    }

    public struct ImageViewASTCDecodeModeEXT {
        public StructureType sType;
        public unsafe void* next;
        public Format decodeMode;
    }

    public struct PhysicalDeviceASTCDecodeFeaturesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint decodeModeSharedExponent;
    }

    public struct PhysicalDeviceTransformFeedbackFeaturesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint transformFeedback;
        public uint geometryStreams;
    }

    public struct PhysicalDeviceTransformFeedbackPropertiesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint maxTransformFeedbackStreams;
        public uint maxTransformFeedbackBuffers;
        public ulong maxTransformFeedbackBufferSize;
        public uint maxTransformFeedbackStreamDataSize;
        public uint maxTransformFeedbackBufferDataSize;
        public uint maxTransformFeedbackBufferDataStride;
        public uint transformFeedbackQueries;
        public uint transformFeedbackStreamsLinesTriangles;
        public uint transformFeedbackRasterizationStreamSelect;
        public uint transformFeedbackDraw;
    }

    public struct PipelineRasterizationStateStreamCreateInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public PipelineRasterizationStateStreamCreateFlagsEXT flags;
        public uint rasterizationStream;
    }

    public struct PhysicalDeviceRepresentativeFragmentTestFeaturesNV {
        public StructureType sType;
        public unsafe void* next;
        public uint representativeFragmentTest;
    }

    public struct PipelineRepresentativeFragmentTestStateCreateInfoNV {
        public StructureType sType;
        public unsafe void* next;
        public uint representativeFragmentTestEnable;
    }

    public struct PhysicalDeviceExclusiveScissorFeaturesNV {
        public StructureType sType;
        public unsafe void* next;
        public uint exclusiveScissor;
    }

    public struct PipelineViewportExclusiveScissorStateCreateInfoNV {
        public StructureType sType;
        public unsafe void* next;
        public uint exclusiveScissorCount;
        public unsafe Rect2D* exclusiveScissors;
    }

    public struct PhysicalDeviceCornerSampledImageFeaturesNV {
        public StructureType sType;
        public unsafe void* next;
        public uint cornerSampledImage;
    }

    public struct PhysicalDeviceComputeShaderDerivativesFeaturesNV {
        public StructureType sType;
        public unsafe void* next;
        public uint computeDerivativeGroupQuads;
        public uint computeDerivativeGroupLinear;
    }

    public struct PhysicalDeviceFragmentShaderBarycentricFeaturesNV {
        public StructureType sType;
        public unsafe void* next;
        public uint fragmentShaderBarycentric;
    }

    public struct PhysicalDeviceShaderImageFootprintFeaturesNV {
        public StructureType sType;
        public unsafe void* next;
        public uint imageFootprint;
    }

    public struct PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV {
        public StructureType sType;
        public unsafe void* next;
        public uint dedicatedAllocationImageAliasing;
    }

    public struct ShadingRatePaletteNV {
        public uint shadingRatePaletteEntryCount;
        public unsafe ShadingRatePaletteEntryNV* shadingRatePaletteEntries;
    }

    public struct PipelineViewportShadingRateImageStateCreateInfoNV {
        public StructureType sType;
        public unsafe void* next;
        public uint shadingRateImageEnable;
        public uint viewportCount;
        public unsafe ShadingRatePaletteNV* shadingRatePalettes;
    }

    public struct PhysicalDeviceShadingRateImageFeaturesNV {
        public StructureType sType;
        public unsafe void* next;
        public uint shadingRateImage;
        public uint shadingRateCoarseSampleOrder;
    }

    public struct PhysicalDeviceShadingRateImagePropertiesNV {
        public StructureType sType;
        public unsafe void* next;
        public Extent2D shadingRateTexelSize;
        public uint shadingRatePaletteSize;
        public uint shadingRateMaxCoarseSamples;
    }

    public struct CoarseSampleLocationNV {
        public uint pixelX;
        public uint pixelY;
        public uint sample;
    }

    public struct CoarseSampleOrderCustomNV {
        public ShadingRatePaletteEntryNV shadingRate;
        public uint sampleCount;
        public uint sampleLocationCount;
        public unsafe CoarseSampleLocationNV* sampleLocations;
    }

    public struct PipelineViewportCoarseSampleOrderStateCreateInfoNV {
        public StructureType sType;
        public unsafe void* next;
        public CoarseSampleOrderTypeNV sampleOrderType;
        public uint customSampleOrderCount;
        public unsafe CoarseSampleOrderCustomNV* customSampleOrders;
    }

    public struct PhysicalDeviceMeshShaderFeaturesNV {
        public StructureType sType;
        public unsafe void* next;
        public uint taskShader;
        public uint meshShader;
    }

    public struct PhysicalDeviceMeshShaderPropertiesNV {
        public StructureType sType;
        public unsafe void* next;
        public uint maxDrawMeshTasksCount;
        public uint maxTaskWorkGroupInvocations;
        public unsafe fixed uint maxTaskWorkGroupSize[3];
        public uint maxTaskTotalMemorySize;
        public uint maxTaskOutputCount;
        public uint maxMeshWorkGroupInvocations;
        public unsafe fixed uint maxMeshWorkGroupSize[3];
        public uint maxMeshTotalMemorySize;
        public uint maxMeshOutputVertices;
        public uint maxMeshOutputPrimitives;
        public uint maxMeshMultiviewViewCount;
        public uint meshOutputPerVertexGranularity;
        public uint meshOutputPerPrimitiveGranularity;
    }

    public struct DrawMeshTasksIndirectCommandNV {
        public uint taskCount;
        public uint firstTask;
    }

    public struct RayTracingShaderGroupCreateInfoNV {
        public StructureType sType;
        public unsafe void* next;
        public RayTracingShaderGroupTypeKHR type;
        public uint generalShader;
        public uint closestHitShader;
        public uint anyHitShader;
        public uint intersectionShader;
    }

    public struct RayTracingShaderGroupCreateInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public RayTracingShaderGroupTypeKHR type;
        public uint generalShader;
        public uint closestHitShader;
        public uint anyHitShader;
        public uint intersectionShader;
        public unsafe void* shaderGroupCaptureReplayHandle;
    }

    public struct RayTracingPipelineCreateInfoNV {
        public StructureType sType;
        public unsafe void* next;
        public PipelineCreateFlags flags;
        public uint stageCount;
        public unsafe PipelineShaderStageCreateInfo* stages;
        public uint groupCount;
        public unsafe RayTracingShaderGroupCreateInfoNV* groups;
        public uint maxRecursionDepth;
        public PipelineLayout layout;
        public Pipeline basePipelineHandle;
        public int basePipelineIndex;
    }

    public struct RayTracingPipelineCreateInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public PipelineCreateFlags flags;
        public uint stageCount;
        public unsafe PipelineShaderStageCreateInfo* stages;
        public uint groupCount;
        public unsafe RayTracingShaderGroupCreateInfoKHR* groups;
        public uint maxRecursionDepth;
        public PipelineLibraryCreateInfoKHR libraries;
        public unsafe RayTracingPipelineInterfaceCreateInfoKHR* libraryInterface;
        public PipelineLayout layout;
        public Pipeline basePipelineHandle;
        public int basePipelineIndex;
    }

    public struct GeometryTrianglesNV {
        public StructureType sType;
        public unsafe void* next;
        public Buffer vertexData;
        public ulong vertexOffset;
        public uint vertexCount;
        public ulong vertexStride;
        public Format vertexFormat;
        public Buffer indexData;
        public ulong indexOffset;
        public uint indexCount;
        public IndexType indexType;
        public Buffer transformData;
        public ulong transformOffset;
    }

    public struct GeometryAABBNV {
        public StructureType sType;
        public unsafe void* next;
        public Buffer aabbData;
        public uint numAABBs;
        public uint stride;
        public ulong offset;
    }

    public struct GeometryDataNV {
        public GeometryTrianglesNV triangles;
        public GeometryAABBNV aabbs;
    }

    public struct GeometryNV {
        public StructureType sType;
        public unsafe void* next;
        public GeometryTypeKHR geometryType;
        public GeometryDataNV geometry;
        public GeometryFlagsKHR flags;
    }

    public struct AccelerationStructureInfoNV {
        public StructureType sType;
        public unsafe void* next;
        public AccelerationStructureTypeNV type;
        public BuildAccelerationStructureFlagsNV flags;
        public uint instanceCount;
        public uint geometryCount;
        public unsafe GeometryNV* geometries;
    }

    public struct AccelerationStructureCreateInfoNV {
        public StructureType sType;
        public unsafe void* next;
        public ulong compactedSize;
        public AccelerationStructureInfoNV info;
    }

    public struct BindAccelerationStructureMemoryInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public AccelerationStructureKHR accelerationStructure;
        public DeviceMemory memory;
        public ulong memoryOffset;
        public uint deviceIndexCount;
        public unsafe uint* deviceIndices;
    }

    public struct WriteDescriptorSetAccelerationStructureKHR {
        public StructureType sType;
        public unsafe void* next;
        public uint accelerationStructureCount;
        public unsafe AccelerationStructureKHR* accelerationStructures;
    }

    public struct AccelerationStructureMemoryRequirementsInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public AccelerationStructureMemoryRequirementsTypeKHR type;
        public AccelerationStructureBuildTypeKHR buildType;
        public AccelerationStructureKHR accelerationStructure;
    }

    public struct AccelerationStructureMemoryRequirementsInfoNV {
        public StructureType sType;
        public unsafe void* next;
        public AccelerationStructureMemoryRequirementsTypeNV type;
        public AccelerationStructureNV accelerationStructure;
    }

    public struct PhysicalDeviceRayTracingFeaturesKHR {
        public StructureType sType;
        public unsafe void* next;
        public uint rayTracing;
        public uint rayTracingShaderGroupHandleCaptureReplay;
        public uint rayTracingShaderGroupHandleCaptureReplayMixed;
        public uint rayTracingAccelerationStructureCaptureReplay;
        public uint rayTracingIndirectTraceRays;
        public uint rayTracingIndirectAccelerationStructureBuild;
        public uint rayTracingHostAccelerationStructureCommands;
        public uint rayQuery;
        public uint rayTracingPrimitiveCulling;
    }

    public struct PhysicalDeviceRayTracingPropertiesKHR {
        public StructureType sType;
        public unsafe void* next;
        public uint shaderGroupHandleSize;
        public uint maxRecursionDepth;
        public uint maxShaderGroupStride;
        public uint shaderGroupBaseAlignment;
        public ulong maxGeometryCount;
        public ulong maxInstanceCount;
        public ulong maxPrimitiveCount;
        public uint maxDescriptorSetAccelerationStructures;
        public uint shaderGroupHandleCaptureReplaySize;
    }

    public struct PhysicalDeviceRayTracingPropertiesNV {
        public StructureType sType;
        public unsafe void* next;
        public uint shaderGroupHandleSize;
        public uint maxRecursionDepth;
        public uint maxShaderGroupStride;
        public uint shaderGroupBaseAlignment;
        public ulong maxGeometryCount;
        public ulong maxInstanceCount;
        public ulong maxTriangleCount;
        public uint maxDescriptorSetAccelerationStructures;
    }

    public struct StridedBufferRegionKHR {
        public Buffer buffer;
        public ulong offset;
        public ulong stride;
        public ulong size;
    }

    public struct TraceRaysIndirectCommandKHR {
        public uint width;
        public uint height;
        public uint depth;
    }

    public struct DrmFormatModifierPropertiesListEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint drmFormatModifierCount;
        public unsafe DrmFormatModifierPropertiesEXT* drmFormatModifierProperties;
    }

    public struct DrmFormatModifierPropertiesEXT {
        public ulong drmFormatModifier;
        public uint drmFormatModifierPlaneCount;
        public FormatFeatureFlags drmFormatModifierTilingFeatures;
    }

    public struct PhysicalDeviceImageDrmFormatModifierInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public ulong drmFormatModifier;
        public SharingMode sharingMode;
        public uint queueFamilyIndexCount;
        public unsafe uint* queueFamilyIndices;
    }

    public struct ImageDrmFormatModifierListCreateInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint drmFormatModifierCount;
        public unsafe ulong* drmFormatModifiers;
    }

    public struct ImageDrmFormatModifierExplicitCreateInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public ulong drmFormatModifier;
        public uint drmFormatModifierPlaneCount;
        public unsafe SubresourceLayout* planeLayouts;
    }

    public struct ImageDrmFormatModifierPropertiesEXT {
        public StructureType sType;
        public unsafe void* next;
        public ulong drmFormatModifier;
    }

    public struct ImageStencilUsageCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public ImageUsageFlags stencilUsage;
    }

    public struct DeviceMemoryOverallocationCreateInfoAMD {
        public StructureType sType;
        public unsafe void* next;
        public MemoryOverallocationBehaviorAMD overallocationBehavior;
    }

    public struct PhysicalDeviceFragmentDensityMapFeaturesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint fragmentDensityMap;
        public uint fragmentDensityMapDynamic;
        public uint fragmentDensityMapNonSubsampledImages;
    }

    public struct PhysicalDeviceFragmentDensityMap2FeaturesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint fragmentDensityMapDeferred;
    }

    public struct PhysicalDeviceFragmentDensityMapPropertiesEXT {
        public StructureType sType;
        public unsafe void* next;
        public Extent2D minFragmentDensityTexelSize;
        public Extent2D maxFragmentDensityTexelSize;
        public uint fragmentDensityInvocations;
    }

    public struct PhysicalDeviceFragmentDensityMap2PropertiesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint subsampledLoads;
        public uint subsampledCoarseReconstructionEarlyAccess;
        public uint maxSubsampledArrayLayers;
        public uint maxDescriptorSetSubsampledSamplers;
    }

    public struct RenderPassFragmentDensityMapCreateInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public AttachmentReference fragmentDensityMapAttachment;
    }

    public struct PhysicalDeviceScalarBlockLayoutFeatures {
        public StructureType sType;
        public unsafe void* next;
        public uint scalarBlockLayout;
    }

    public struct SurfaceProtectedCapabilitiesKHR {
        public StructureType sType;
        public unsafe void* next;
        public uint supportsProtected;
    }

    public struct PhysicalDeviceUniformBufferStandardLayoutFeatures {
        public StructureType sType;
        public unsafe void* next;
        public uint uniformBufferStandardLayout;
    }

    public struct PhysicalDeviceDepthClipEnableFeaturesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint depthClipEnable;
    }

    public struct PipelineRasterizationDepthClipStateCreateInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public PipelineRasterizationDepthClipStateCreateFlagsEXT flags;
        public uint depthClipEnable;
    }

    public struct PhysicalDeviceMemoryBudgetPropertiesEXT {
        public StructureType sType;
        public unsafe void* next;
        public ulong heapBudget_0;
        public ulong heapBudget_1;
        public ulong heapBudget_2;
        public ulong heapBudget_3;
        public ulong heapBudget_4;
        public ulong heapBudget_5;
        public ulong heapBudget_6;
        public ulong heapBudget_7;
        public ulong heapBudget_8;
        public ulong heapBudget_9;
        public ulong heapBudget_10;
        public ulong heapBudget_11;
        public ulong heapBudget_12;
        public ulong heapBudget_13;
        public ulong heapBudget_14;
        public ulong heapBudget_15;
        public ulong heapUsage_0;
        public ulong heapUsage_1;
        public ulong heapUsage_2;
        public ulong heapUsage_3;
        public ulong heapUsage_4;
        public ulong heapUsage_5;
        public ulong heapUsage_6;
        public ulong heapUsage_7;
        public ulong heapUsage_8;
        public ulong heapUsage_9;
        public ulong heapUsage_10;
        public ulong heapUsage_11;
        public ulong heapUsage_12;
        public ulong heapUsage_13;
        public ulong heapUsage_14;
        public ulong heapUsage_15;
    }

    public struct PhysicalDeviceMemoryPriorityFeaturesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint memoryPriority;
    }

    public struct MemoryPriorityAllocateInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public float priority;
    }

    public struct PhysicalDeviceBufferDeviceAddressFeatures {
        public StructureType sType;
        public unsafe void* next;
        public uint bufferDeviceAddress;
        public uint bufferDeviceAddressCaptureReplay;
        public uint bufferDeviceAddressMultiDevice;
    }

    public struct PhysicalDeviceBufferDeviceAddressFeaturesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint bufferDeviceAddress;
        public uint bufferDeviceAddressCaptureReplay;
        public uint bufferDeviceAddressMultiDevice;
    }

    public struct BufferDeviceAddressInfo {
        public StructureType sType;
        public unsafe void* next;
        public Buffer buffer;
    }

    public struct BufferOpaqueCaptureAddressCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public ulong opaqueCaptureAddress;
    }

    public struct BufferDeviceAddressCreateInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public ulong deviceAddress;
    }

    public struct PhysicalDeviceImageViewImageFormatInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public ImageViewType imageViewType;
    }

    public struct FilterCubicImageViewImageFormatPropertiesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint filterCubic;
        public uint filterCubicMinmax;
    }

    public struct PhysicalDeviceImagelessFramebufferFeatures {
        public StructureType sType;
        public unsafe void* next;
        public uint imagelessFramebuffer;
    }

    public struct FramebufferAttachmentsCreateInfo {
        public StructureType sType;
        public unsafe void* next;
        public uint attachmentImageInfoCount;
        public unsafe FramebufferAttachmentImageInfo* attachmentImageInfos;
    }

    public struct FramebufferAttachmentImageInfo {
        public StructureType sType;
        public unsafe void* next;
        public ImageCreateFlags flags;
        public ImageUsageFlags usage;
        public uint width;
        public uint height;
        public uint layerCount;
        public uint viewFormatCount;
        public unsafe Format* viewFormats;
    }

    public struct RenderPassAttachmentBeginInfo {
        public StructureType sType;
        public unsafe void* next;
        public uint attachmentCount;
        public unsafe ImageView* attachments;
    }

    public struct PhysicalDeviceTextureCompressionASTCHDRFeaturesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint textureCompressionASTC_HDR;
    }

    public struct PhysicalDeviceCooperativeMatrixFeaturesNV {
        public StructureType sType;
        public unsafe void* next;
        public uint cooperativeMatrix;
        public uint cooperativeMatrixRobustBufferAccess;
    }

    public struct PhysicalDeviceCooperativeMatrixPropertiesNV {
        public StructureType sType;
        public unsafe void* next;
        public ShaderStageFlags cooperativeMatrixSupportedStages;
    }

    public struct CooperativeMatrixPropertiesNV {
        public StructureType sType;
        public unsafe void* next;
        public uint MSize;
        public uint NSize;
        public uint KSize;
        public ComponentTypeNV AType;
        public ComponentTypeNV BType;
        public ComponentTypeNV CType;
        public ComponentTypeNV DType;
        public ScopeNV scope;
    }

    public struct PhysicalDeviceYcbcrImageArraysFeaturesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint ycbcrImageArrays;
    }

    public struct ImageViewHandleInfoNVX {
        public StructureType sType;
        public unsafe void* next;
        public ImageView imageView;
        public DescriptorType descriptorType;
        public Sampler sampler;
    }

    public struct ImageViewAddressPropertiesNVX {
        public StructureType sType;
        public unsafe void* next;
        public ulong deviceAddress;
        public ulong size;
    }

    public struct PresentFrameTokenGGP {
        public StructureType sType;
        public unsafe void* next;
        public int frameToken;
    }

    public struct PipelineCreationFeedbackEXT {
        public PipelineCreationFeedbackFlagsEXT flags;
        public ulong duration;
    }

    public struct PipelineCreationFeedbackCreateInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public unsafe PipelineCreationFeedbackEXT* pipelineCreationFeedback;
        public uint pipelineStageCreationFeedbackCount;
        public unsafe PipelineCreationFeedbackEXT* pipelineStageCreationFeedbacks;
    }

    public struct SurfaceFullScreenExclusiveInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public FullScreenExclusiveEXT fullScreenExclusive;
    }

    public struct SurfaceFullScreenExclusiveWin32InfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public unsafe void* hmonitor;
    }

    public struct SurfaceCapabilitiesFullScreenExclusiveEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint fullScreenExclusiveSupported;
    }

    public struct PhysicalDevicePerformanceQueryFeaturesKHR {
        public StructureType sType;
        public unsafe void* next;
        public uint performanceCounterQueryPools;
        public uint performanceCounterMultipleQueryPools;
    }

    public struct PhysicalDevicePerformanceQueryPropertiesKHR {
        public StructureType sType;
        public unsafe void* next;
        public uint allowCommandBufferQueryCopies;
    }

    public struct PerformanceCounterKHR {
        public StructureType sType;
        public unsafe void* next;
        public PerformanceCounterUnitKHR unit;
        public PerformanceCounterScopeKHR scope;
        public PerformanceCounterStorageKHR storage;
        public unsafe fixed byte uuid[Constants.UuidSize];
    }

    public struct PerformanceCounterDescriptionKHR {
        public StructureType sType;
        public unsafe void* next;
        public PerformanceCounterDescriptionFlagsKHR flags;
        public unsafe fixed byte name[Constants.MaxDescriptionSize];
        public unsafe fixed byte category[Constants.MaxDescriptionSize];
        public unsafe fixed byte description[Constants.MaxDescriptionSize];
    }

    public struct QueryPoolPerformanceCreateInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public uint queueFamilyIndex;
        public uint counterIndexCount;
        public unsafe uint* counterIndices;
    }

    public struct AcquireProfilingLockInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public AcquireProfilingLockFlagsKHR flags;
        public ulong timeout;
    }

    public struct PerformanceQuerySubmitInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public uint counterPassIndex;
    }

    public struct HeadlessSurfaceCreateInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public HeadlessSurfaceCreateFlagsEXT flags;
    }

    public struct PhysicalDeviceCoverageReductionModeFeaturesNV {
        public StructureType sType;
        public unsafe void* next;
        public uint coverageReductionMode;
    }

    public struct PipelineCoverageReductionStateCreateInfoNV {
        public StructureType sType;
        public unsafe void* next;
        public PipelineCoverageReductionStateCreateFlagsNV flags;
        public CoverageReductionModeNV coverageReductionMode;
    }

    public struct FramebufferMixedSamplesCombinationNV {
        public StructureType sType;
        public unsafe void* next;
        public CoverageReductionModeNV coverageReductionMode;
        public SampleCountFlags rasterizationSamples;
        public SampleCountFlags depthStencilSamples;
        public SampleCountFlags colorSamples;
    }

    public struct PhysicalDeviceShaderIntegerFunctions2FeaturesINTEL {
        public StructureType sType;
        public unsafe void* next;
        public uint shaderIntegerFunctions2;
    }

    public struct PerformanceValueINTEL {
        public PerformanceValueTypeINTEL type;
        public PerformanceValueDataINTEL data;
    }

    public struct InitializePerformanceApiInfoINTEL {
        public StructureType sType;
        public unsafe void* next;
        public unsafe void* userData;
    }

    public struct QueryPoolPerformanceQueryCreateInfoINTEL {
        public StructureType sType;
        public unsafe void* next;
        public QueryPoolSamplingModeINTEL performanceCountersSampling;
    }

    public struct PerformanceMarkerInfoINTEL {
        public StructureType sType;
        public unsafe void* next;
        public ulong marker;
    }

    public struct PerformanceStreamMarkerInfoINTEL {
        public StructureType sType;
        public unsafe void* next;
        public uint marker;
    }

    public struct PerformanceOverrideInfoINTEL {
        public StructureType sType;
        public unsafe void* next;
        public PerformanceOverrideTypeINTEL type;
        public uint enable;
        public ulong parameter;
    }

    public struct PerformanceConfigurationAcquireInfoINTEL {
        public StructureType sType;
        public unsafe void* next;
        public PerformanceConfigurationTypeINTEL type;
    }

    public struct PhysicalDeviceShaderClockFeaturesKHR {
        public StructureType sType;
        public unsafe void* next;
        public uint shaderSubgroupClock;
        public uint shaderDeviceClock;
    }

    public struct PhysicalDeviceIndexTypeUint8FeaturesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint indexTypeUint8;
    }

    public struct PhysicalDeviceShaderSMBuiltinsPropertiesNV {
        public StructureType sType;
        public unsafe void* next;
        public uint shaderSMCount;
        public uint shaderWarpsPerSM;
    }

    public struct PhysicalDeviceShaderSMBuiltinsFeaturesNV {
        public StructureType sType;
        public unsafe void* next;
        public uint shaderSMBuiltins;
    }

    public struct PhysicalDeviceFragmentShaderInterlockFeaturesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint fragmentShaderSampleInterlock;
        public uint fragmentShaderPixelInterlock;
        public uint fragmentShaderShadingRateInterlock;
    }

    public struct PhysicalDeviceSeparateDepthStencilLayoutsFeatures {
        public StructureType sType;
        public unsafe void* next;
        public uint separateDepthStencilLayouts;
    }

    public struct AttachmentReferenceStencilLayout {
        public StructureType sType;
        public unsafe void* next;
        public ImageLayout stencilLayout;
    }

    public struct AttachmentDescriptionStencilLayout {
        public StructureType sType;
        public unsafe void* next;
        public ImageLayout stencilInitialLayout;
        public ImageLayout stencilFinalLayout;
    }

    public struct PhysicalDevicePipelineExecutablePropertiesFeaturesKHR {
        public StructureType sType;
        public unsafe void* next;
        public uint pipelineExecutableInfo;
    }

    public struct PipelineInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public Pipeline pipeline;
    }

    public struct PipelineExecutablePropertiesKHR {
        public StructureType sType;
        public unsafe void* next;
        public ShaderStageFlags stages;
        public unsafe fixed byte name[Constants.MaxDescriptionSize];
        public unsafe fixed byte description[Constants.MaxDescriptionSize];
        public uint subgroupSize;
    }

    public struct PipelineExecutableInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public Pipeline pipeline;
        public uint executableIndex;
    }

    public struct PipelineExecutableStatisticKHR {
        public StructureType sType;
        public unsafe void* next;
        public unsafe fixed byte name[Constants.MaxDescriptionSize];
        public unsafe fixed byte description[Constants.MaxDescriptionSize];
        public PipelineExecutableStatisticFormatKHR format;
        public PipelineExecutableStatisticValueKHR value;
    }

    public struct PipelineExecutableInternalRepresentationKHR {
        public StructureType sType;
        public unsafe void* next;
        public unsafe fixed byte name[Constants.MaxDescriptionSize];
        public unsafe fixed byte description[Constants.MaxDescriptionSize];
        public uint isText;
        public nuint dataSize;
        public unsafe void* data;
    }

    public struct PhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint shaderDemoteToHelperInvocation;
    }

    public struct PhysicalDeviceTexelBufferAlignmentFeaturesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint texelBufferAlignment;
    }

    public struct PhysicalDeviceTexelBufferAlignmentPropertiesEXT {
        public StructureType sType;
        public unsafe void* next;
        public ulong storageTexelBufferOffsetAlignmentBytes;
        public uint storageTexelBufferOffsetSingleTexelAlignment;
        public ulong uniformTexelBufferOffsetAlignmentBytes;
        public uint uniformTexelBufferOffsetSingleTexelAlignment;
    }

    public struct PhysicalDeviceSubgroupSizeControlFeaturesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint subgroupSizeControl;
        public uint computeFullSubgroups;
    }

    public struct PhysicalDeviceSubgroupSizeControlPropertiesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint minSubgroupSize;
        public uint maxSubgroupSize;
        public uint maxComputeWorkgroupSubgroups;
        public ShaderStageFlags requiredSubgroupSizeStages;
    }

    public struct PipelineShaderStageRequiredSubgroupSizeCreateInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint requiredSubgroupSize;
    }

    public struct MemoryOpaqueCaptureAddressAllocateInfo {
        public StructureType sType;
        public unsafe void* next;
        public ulong opaqueCaptureAddress;
    }

    public struct DeviceMemoryOpaqueCaptureAddressInfo {
        public StructureType sType;
        public unsafe void* next;
        public DeviceMemory memory;
    }

    public struct PhysicalDeviceLineRasterizationFeaturesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint rectangularLines;
        public uint bresenhamLines;
        public uint smoothLines;
        public uint stippledRectangularLines;
        public uint stippledBresenhamLines;
        public uint stippledSmoothLines;
    }

    public struct PhysicalDeviceLineRasterizationPropertiesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint lineSubPixelPrecisionBits;
    }

    public struct PipelineRasterizationLineStateCreateInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public LineRasterizationModeEXT lineRasterizationMode;
        public uint stippledLineEnable;
        public uint lineStippleFactor;
        public ushort lineStipplePattern;
    }

    public struct PhysicalDevicePipelineCreationCacheControlFeaturesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint pipelineCreationCacheControl;
    }

    public struct PhysicalDeviceVulkan11Features {
        public StructureType sType;
        public unsafe void* next;
        public uint storageBuffer16BitAccess;
        public uint uniformAndStorageBuffer16BitAccess;
        public uint storagePushConstant16;
        public uint storageInputOutput16;
        public uint multiview;
        public uint multiviewGeometryShader;
        public uint multiviewTessellationShader;
        public uint variablePointersStorageBuffer;
        public uint variablePointers;
        public uint protectedMemory;
        public uint samplerYcbcrConversion;
        public uint shaderDrawParameters;
    }

    public struct PhysicalDeviceVulkan11Properties {
        public StructureType sType;
        public unsafe void* next;
        public unsafe fixed byte deviceUUID[Constants.UuidSize];
        public unsafe fixed byte driverUUID[Constants.UuidSize];
        public unsafe fixed byte deviceLUID[Constants.LuidSize];
        public uint deviceNodeMask;
        public uint deviceLUIDValid;
        public uint subgroupSize;
        public ShaderStageFlags subgroupSupportedStages;
        public SubgroupFeatureFlags subgroupSupportedOperations;
        public uint subgroupQuadOperationsInAllStages;
        public PointClippingBehavior pointClippingBehavior;
        public uint maxMultiviewViewCount;
        public uint maxMultiviewInstanceIndex;
        public uint protectedNoFault;
        public uint maxPerSetDescriptors;
        public ulong maxMemoryAllocationSize;
    }

    public struct PhysicalDeviceVulkan12Features {
        public StructureType sType;
        public unsafe void* next;
        public uint samplerMirrorClampToEdge;
        public uint drawIndirectCount;
        public uint storageBuffer8BitAccess;
        public uint uniformAndStorageBuffer8BitAccess;
        public uint storagePushConstant8;
        public uint shaderBufferInt64Atomics;
        public uint shaderSharedInt64Atomics;
        public uint shaderFloat16;
        public uint shaderInt8;
        public uint descriptorIndexing;
        public uint shaderInputAttachmentArrayDynamicIndexing;
        public uint shaderUniformTexelBufferArrayDynamicIndexing;
        public uint shaderStorageTexelBufferArrayDynamicIndexing;
        public uint shaderUniformBufferArrayNonUniformIndexing;
        public uint shaderSampledImageArrayNonUniformIndexing;
        public uint shaderStorageBufferArrayNonUniformIndexing;
        public uint shaderStorageImageArrayNonUniformIndexing;
        public uint shaderInputAttachmentArrayNonUniformIndexing;
        public uint shaderUniformTexelBufferArrayNonUniformIndexing;
        public uint shaderStorageTexelBufferArrayNonUniformIndexing;
        public uint descriptorBindingUniformBufferUpdateAfterBind;
        public uint descriptorBindingSampledImageUpdateAfterBind;
        public uint descriptorBindingStorageImageUpdateAfterBind;
        public uint descriptorBindingStorageBufferUpdateAfterBind;
        public uint descriptorBindingUniformTexelBufferUpdateAfterBind;
        public uint descriptorBindingStorageTexelBufferUpdateAfterBind;
        public uint descriptorBindingUpdateUnusedWhilePending;
        public uint descriptorBindingPartiallyBound;
        public uint descriptorBindingVariableDescriptorCount;
        public uint runtimeDescriptorArray;
        public uint samplerFilterMinmax;
        public uint scalarBlockLayout;
        public uint imagelessFramebuffer;
        public uint uniformBufferStandardLayout;
        public uint shaderSubgroupExtendedTypes;
        public uint separateDepthStencilLayouts;
        public uint hostQueryReset;
        public uint timelineSemaphore;
        public uint bufferDeviceAddress;
        public uint bufferDeviceAddressCaptureReplay;
        public uint bufferDeviceAddressMultiDevice;
        public uint vulkanMemoryModel;
        public uint vulkanMemoryModelDeviceScope;
        public uint vulkanMemoryModelAvailabilityVisibilityChains;
        public uint shaderOutputViewportIndex;
        public uint shaderOutputLayer;
        public uint subgroupBroadcastDynamicId;
    }

    public struct PhysicalDeviceVulkan12Properties {
        public StructureType sType;
        public unsafe void* next;
        public DriverId driverID;
        public unsafe fixed byte driverName[Constants.MaxDriverNameSize];
        public unsafe fixed byte driverInfo[Constants.MaxDriverInfoSize];
        public ConformanceVersion conformanceVersion;
        public ShaderFloatControlsIndependence denormBehaviorIndependence;
        public ShaderFloatControlsIndependence roundingModeIndependence;
        public uint shaderSignedZeroInfNanPreserveFloat16;
        public uint shaderSignedZeroInfNanPreserveFloat32;
        public uint shaderSignedZeroInfNanPreserveFloat64;
        public uint shaderDenormPreserveFloat16;
        public uint shaderDenormPreserveFloat32;
        public uint shaderDenormPreserveFloat64;
        public uint shaderDenormFlushToZeroFloat16;
        public uint shaderDenormFlushToZeroFloat32;
        public uint shaderDenormFlushToZeroFloat64;
        public uint shaderRoundingModeRTEFloat16;
        public uint shaderRoundingModeRTEFloat32;
        public uint shaderRoundingModeRTEFloat64;
        public uint shaderRoundingModeRTZFloat16;
        public uint shaderRoundingModeRTZFloat32;
        public uint shaderRoundingModeRTZFloat64;
        public uint maxUpdateAfterBindDescriptorsInAllPools;
        public uint shaderUniformBufferArrayNonUniformIndexingNative;
        public uint shaderSampledImageArrayNonUniformIndexingNative;
        public uint shaderStorageBufferArrayNonUniformIndexingNative;
        public uint shaderStorageImageArrayNonUniformIndexingNative;
        public uint shaderInputAttachmentArrayNonUniformIndexingNative;
        public uint robustBufferAccessUpdateAfterBind;
        public uint quadDivergentImplicitLod;
        public uint maxPerStageDescriptorUpdateAfterBindSamplers;
        public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;
        public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;
        public uint maxPerStageDescriptorUpdateAfterBindSampledImages;
        public uint maxPerStageDescriptorUpdateAfterBindStorageImages;
        public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;
        public uint maxPerStageUpdateAfterBindResources;
        public uint maxDescriptorSetUpdateAfterBindSamplers;
        public uint maxDescriptorSetUpdateAfterBindUniformBuffers;
        public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindStorageBuffers;
        public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindSampledImages;
        public uint maxDescriptorSetUpdateAfterBindStorageImages;
        public uint maxDescriptorSetUpdateAfterBindInputAttachments;
        public ResolveModeFlags supportedDepthResolveModes;
        public ResolveModeFlags supportedStencilResolveModes;
        public uint independentResolveNone;
        public uint independentResolve;
        public uint filterMinmaxSingleComponentFormats;
        public uint filterMinmaxImageComponentMapping;
        public ulong maxTimelineSemaphoreValueDifference;
        public SampleCountFlags framebufferIntegerColorSampleCounts;
    }

    public struct PipelineCompilerControlCreateInfoAMD {
        public StructureType sType;
        public unsafe void* next;
        public PipelineCompilerControlFlagsAMD compilerControlFlags;
    }

    public struct PhysicalDeviceCoherentMemoryFeaturesAMD {
        public StructureType sType;
        public unsafe void* next;
        public uint deviceCoherentMemory;
    }

    public struct PhysicalDeviceToolPropertiesEXT {
        public StructureType sType;
        public unsafe void* next;
        public unsafe fixed byte name[Constants.MaxExtensionNameSize];
        public unsafe fixed byte version[Constants.MaxExtensionNameSize];
        public ToolPurposeFlagsEXT purposes;
        public unsafe fixed byte description[Constants.MaxDescriptionSize];
        public unsafe fixed byte layer[Constants.MaxExtensionNameSize];
    }

    public struct SamplerCustomBorderColorCreateInfoEXT {
        public StructureType sType;
        public unsafe void* next;
        public ClearColorValue customBorderColor;
        public Format format;
    }

    public struct PhysicalDeviceCustomBorderColorPropertiesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint maxCustomBorderColorSamplers;
    }

    public struct PhysicalDeviceCustomBorderColorFeaturesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint customBorderColors;
        public uint customBorderColorWithoutFormat;
    }

    public struct AccelerationStructureGeometryTrianglesDataKHR {
        public StructureType sType;
        public unsafe void* next;
        public Format vertexFormat;
        public DeviceOrHostAddressConstKHR vertexData;
        public ulong vertexStride;
        public IndexType indexType;
        public DeviceOrHostAddressConstKHR indexData;
        public DeviceOrHostAddressConstKHR transformData;
    }

    public struct AccelerationStructureGeometryAabbsDataKHR {
        public StructureType sType;
        public unsafe void* next;
        public DeviceOrHostAddressConstKHR data;
        public ulong stride;
    }

    public struct AccelerationStructureGeometryInstancesDataKHR {
        public StructureType sType;
        public unsafe void* next;
        public uint arrayOfPointers;
        public DeviceOrHostAddressConstKHR data;
    }

    public struct AccelerationStructureGeometryKHR {
        public StructureType sType;
        public unsafe void* next;
        public GeometryTypeKHR geometryType;
        public AccelerationStructureGeometryDataKHR geometry;
        public GeometryFlagsKHR flags;
    }

    public struct AccelerationStructureBuildGeometryInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public AccelerationStructureTypeKHR type;
        public BuildAccelerationStructureFlagsKHR flags;
        public uint update;
        public AccelerationStructureKHR srcAccelerationStructure;
        public AccelerationStructureKHR dstAccelerationStructure;
        public uint geometryArrayOfPointers;
        public uint geometryCount;
        public unsafe AccelerationStructureGeometryKHR** geometries;
        public DeviceOrHostAddressKHR scratchData;
    }

    public struct AccelerationStructureBuildOffsetInfoKHR {
        public uint primitiveCount;
        public uint primitiveOffset;
        public uint firstVertex;
        public uint transformOffset;
    }

    public struct AccelerationStructureCreateGeometryTypeInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public GeometryTypeKHR geometryType;
        public uint maxPrimitiveCount;
        public IndexType indexType;
        public uint maxVertexCount;
        public Format vertexFormat;
        public uint allowsTransforms;
    }

    public struct AccelerationStructureCreateInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public ulong compactedSize;
        public AccelerationStructureTypeKHR type;
        public BuildAccelerationStructureFlagsKHR flags;
        public uint maxGeometryCount;
        public unsafe AccelerationStructureCreateGeometryTypeInfoKHR* geometryInfos;
        public ulong deviceAddress;
    }

    public struct AabbPositionsKHR {
        public float minX;
        public float minY;
        public float minZ;
        public float maxX;
        public float maxY;
        public float maxZ;
    }

    public struct TransformMatrixKHR {
        public float[][] matrix;
    }

    public struct AccelerationStructureInstanceKHR {
        public TransformMatrixKHR transform;
        public uint instanceCustomIndexAndMask;
        public uint instanceShaderBindingTableRecordOffsetAndFlags;
        public ulong accelerationStructureReference;
    }

    public struct AccelerationStructureDeviceAddressInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public AccelerationStructureKHR accelerationStructure;
    }

    public struct AccelerationStructureVersionKHR {
        public StructureType sType;
        public unsafe void* next;
        public unsafe byte* versionData;
    }

    public struct CopyAccelerationStructureInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public AccelerationStructureKHR src;
        public AccelerationStructureKHR dst;
        public CopyAccelerationStructureModeKHR mode;
    }

    public struct CopyAccelerationStructureToMemoryInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public AccelerationStructureKHR src;
        public DeviceOrHostAddressKHR dst;
        public CopyAccelerationStructureModeKHR mode;
    }

    public struct CopyMemoryToAccelerationStructureInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public DeviceOrHostAddressConstKHR src;
        public AccelerationStructureKHR dst;
        public CopyAccelerationStructureModeKHR mode;
    }

    public struct RayTracingPipelineInterfaceCreateInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public uint maxPayloadSize;
        public uint maxAttributeSize;
        public uint maxCallableSize;
    }

    public struct DeferredOperationInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public DeferredOperationKHR operationHandle;
    }

    public struct PipelineLibraryCreateInfoKHR {
        public StructureType sType;
        public unsafe void* next;
        public uint libraryCount;
        public unsafe Pipeline* libraries;
    }

    public struct PhysicalDeviceExtendedDynamicStateFeaturesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint extendedDynamicState;
    }

    public struct RenderPassTransformBeginInfoQCOM {
        public StructureType sType;
        public unsafe void* next;
        public SurfaceTransformFlagsKHR transform;
    }

    public struct CommandBufferInheritanceRenderPassTransformInfoQCOM {
        public StructureType sType;
        public unsafe void* next;
        public SurfaceTransformFlagsKHR transform;
        public Rect2D renderArea;
    }

    public struct PhysicalDeviceDiagnosticsConfigFeaturesNV {
        public StructureType sType;
        public unsafe void* next;
        public uint diagnosticsConfig;
    }

    public struct DeviceDiagnosticsConfigCreateInfoNV {
        public StructureType sType;
        public unsafe void* next;
        public DeviceDiagnosticsConfigFlagsNV flags;
    }

    public struct PhysicalDeviceRobustness2FeaturesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint robustBufferAccess2;
        public uint robustImageAccess2;
        public uint nullDescriptor;
    }

    public struct PhysicalDeviceRobustness2PropertiesEXT {
        public StructureType sType;
        public unsafe void* next;
        public ulong robustStorageBufferAccessSizeAlignment;
        public ulong robustUniformBufferAccessSizeAlignment;
    }

    public struct PhysicalDeviceImageRobustnessFeaturesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint robustImageAccess;
    }

    public struct PhysicalDevice4444FormatsFeaturesEXT {
        public StructureType sType;
        public unsafe void* next;
        public uint formatA4R4G4B4;
        public uint formatA4B4G4R4;
    }
}