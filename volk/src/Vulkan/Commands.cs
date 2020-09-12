// Copyright 2020-2020 Volk Project
// Licensed under Apache License 2.0 or any later version
// Refer to the LICENSE.md file included.

// This file is generated automatically by generator


using IntPtr = System.IntPtr;
using Volk.Vulkan.Types;
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

namespace Volk.Vulkan {
    public static class Commands {
        public unsafe delegate Result CreateInstance(InstanceCreateInfo* createInfo, AllocationCallbacks* allocator, Instance* instance);

        public unsafe delegate void DestroyInstance(Instance instance, AllocationCallbacks* allocator);

        public unsafe delegate Result EnumeratePhysicalDevices(Instance instance, uint* physicalDeviceCount, PhysicalDevice* physicalDevices);

        public unsafe delegate IntPtr GetDeviceProcAddr(Device device, byte* name);

        public unsafe delegate IntPtr GetInstanceProcAddr(Instance instance, byte* name);

        public unsafe delegate void GetPhysicalDeviceProperties(PhysicalDevice physicalDevice, PhysicalDeviceProperties* properties);

        public unsafe delegate void GetPhysicalDeviceQueueFamilyProperties(PhysicalDevice physicalDevice, uint* queueFamilyPropertyCount,
                                                                           QueueFamilyProperties* queueFamilyProperties);

        public unsafe delegate void
            GetPhysicalDeviceMemoryProperties(PhysicalDevice physicalDevice, PhysicalDeviceMemoryProperties* memoryProperties);

        public unsafe delegate void GetPhysicalDeviceFeatures(PhysicalDevice physicalDevice, PhysicalDeviceFeatures* features);

        public unsafe delegate void GetPhysicalDeviceFormatProperties(PhysicalDevice physicalDevice, Format format,
                                                                      FormatProperties* formatProperties);

        public unsafe delegate Result GetPhysicalDeviceImageFormatProperties(PhysicalDevice physicalDevice, Format format, ImageType type,
                                                                             ImageTiling tiling, ImageUsageFlags usage, ImageCreateFlags flags,
                                                                             ImageFormatProperties* imageFormatProperties);

        public unsafe delegate Result CreateDevice(PhysicalDevice physicalDevice, DeviceCreateInfo* createInfo, AllocationCallbacks* allocator,
                                                   Device* device);

        public unsafe delegate void DestroyDevice(Device device, AllocationCallbacks* allocator);

        public unsafe delegate Result EnumerateInstanceVersion(uint* apiVersion);

        public unsafe delegate Result EnumerateInstanceLayerProperties(uint* propertyCount, LayerProperties* properties);

        public unsafe delegate Result EnumerateInstanceExtensionProperties(byte* layerName, uint* propertyCount, ExtensionProperties* properties);

        public unsafe delegate Result EnumerateDeviceLayerProperties(PhysicalDevice physicalDevice, uint* propertyCount, LayerProperties* properties);

        public unsafe delegate Result EnumerateDeviceExtensionProperties(PhysicalDevice physicalDevice, byte* layerName, uint* propertyCount,
                                                                         ExtensionProperties* properties);

        public unsafe delegate void GetDeviceQueue(Device device, uint queueFamilyIndex, uint queueIndex, Queue* queue);

        public unsafe delegate Result QueueSubmit(Queue queue, uint submitCount, SubmitInfo* submits, Fence fence);

        public unsafe delegate Result QueueWaitIdle(Queue queue);

        public unsafe delegate Result DeviceWaitIdle(Device device);

        public unsafe delegate Result AllocateMemory(Device device, MemoryAllocateInfo* allocateInfo, AllocationCallbacks* allocator,
                                                     DeviceMemory* memory);

        public unsafe delegate void FreeMemory(Device device, DeviceMemory memory, AllocationCallbacks* allocator);

        public unsafe delegate Result MapMemory(Device device, DeviceMemory memory, DeviceSize offset, DeviceSize size, MemoryMapFlags flags,
                                                void** data);

        public unsafe delegate void UnmapMemory(Device device, DeviceMemory memory);

        public unsafe delegate Result FlushMappedMemoryRanges(Device device, uint memoryRangeCount, MappedMemoryRange* memoryRanges);

        public unsafe delegate Result InvalidateMappedMemoryRanges(Device device, uint memoryRangeCount, MappedMemoryRange* memoryRanges);

        public unsafe delegate void GetDeviceMemoryCommitment(Device device, DeviceMemory memory, DeviceSize* committedMemoryInBytes);

        public unsafe delegate void GetBufferMemoryRequirements(Device device, Buffer buffer, MemoryRequirements* memoryRequirements);

        public unsafe delegate Result BindBufferMemory(Device device, Buffer buffer, DeviceMemory memory, DeviceSize memoryOffset);

        public unsafe delegate void GetImageMemoryRequirements(Device device, Image image, MemoryRequirements* memoryRequirements);

        public unsafe delegate Result BindImageMemory(Device device, Image image, DeviceMemory memory, DeviceSize memoryOffset);

        public unsafe delegate void GetImageSparseMemoryRequirements(Device device, Image image, uint* sparseMemoryRequirementCount,
                                                                     SparseImageMemoryRequirements* sparseMemoryRequirements);

        public unsafe delegate void GetPhysicalDeviceSparseImageFormatProperties(PhysicalDevice physicalDevice, Format format, ImageType type,
                                                                                 SampleCountFlags samples, ImageUsageFlags usage, ImageTiling tiling,
                                                                                 uint* propertyCount, SparseImageFormatProperties* properties);

        public unsafe delegate Result QueueBindSparse(Queue queue, uint bindInfoCount, BindSparseInfo* bindInfo, Fence fence);

        public unsafe delegate Result CreateFence(Device device, FenceCreateInfo* createInfo, AllocationCallbacks* allocator, Fence* fence);

        public unsafe delegate void DestroyFence(Device device, Fence fence, AllocationCallbacks* allocator);

        public unsafe delegate Result ResetFences(Device device, uint fenceCount, Fence* fences);

        public unsafe delegate Result GetFenceStatus(Device device, Fence fence);

        public unsafe delegate Result WaitForFences(Device device, uint fenceCount, Fence* fences, Bool32 waitAll, ulong timeout);

        public unsafe delegate Result CreateSemaphore(Device device, SemaphoreCreateInfo* createInfo, AllocationCallbacks* allocator,
                                                      Semaphore* semaphore);

        public unsafe delegate void DestroySemaphore(Device device, Semaphore semaphore, AllocationCallbacks* allocator);

        public unsafe delegate Result CreateEvent(Device device, EventCreateInfo* createInfo, AllocationCallbacks* allocator, Event* @event);

        public unsafe delegate void DestroyEvent(Device device, Event @event, AllocationCallbacks* allocator);

        public unsafe delegate Result GetEventStatus(Device device, Event @event);

        public unsafe delegate Result SetEvent(Device device, Event @event);

        public unsafe delegate Result ResetEvent(Device device, Event @event);

        public unsafe delegate Result CreateQueryPool(Device device, QueryPoolCreateInfo* createInfo, AllocationCallbacks* allocator,
                                                      QueryPool* queryPool);

        public unsafe delegate void DestroyQueryPool(Device device, QueryPool queryPool, AllocationCallbacks* allocator);

        public unsafe delegate Result GetQueryPoolResults(Device device, QueryPool queryPool, uint firstQuery, uint queryCount, nuint dataSize,
                                                          void* data, DeviceSize stride, QueryResultFlags flags);

        public unsafe delegate void ResetQueryPool(Device device, QueryPool queryPool, uint firstQuery, uint queryCount);

        public unsafe delegate Result CreateBuffer(Device device, BufferCreateInfo* createInfo, AllocationCallbacks* allocator, Buffer* buffer);

        public unsafe delegate void DestroyBuffer(Device device, Buffer buffer, AllocationCallbacks* allocator);

        public unsafe delegate Result CreateBufferView(Device device, BufferViewCreateInfo* createInfo, AllocationCallbacks* allocator,
                                                       BufferView* view);

        public unsafe delegate void DestroyBufferView(Device device, BufferView bufferView, AllocationCallbacks* allocator);

        public unsafe delegate Result CreateImage(Device device, ImageCreateInfo* createInfo, AllocationCallbacks* allocator, Image* image);

        public unsafe delegate void DestroyImage(Device device, Image image, AllocationCallbacks* allocator);

        public unsafe delegate void GetImageSubresourceLayout(Device device, Image image, ImageSubresource* subresource, SubresourceLayout* layout);

        public unsafe delegate Result CreateImageView(Device device, ImageViewCreateInfo* createInfo, AllocationCallbacks* allocator,
                                                      ImageView* view);

        public unsafe delegate void DestroyImageView(Device device, ImageView imageView, AllocationCallbacks* allocator);

        public unsafe delegate Result CreateShaderModule(Device device, ShaderModuleCreateInfo* createInfo, AllocationCallbacks* allocator,
                                                         ShaderModule* shaderModule);

        public unsafe delegate void DestroyShaderModule(Device device, ShaderModule shaderModule, AllocationCallbacks* allocator);

        public unsafe delegate Result CreatePipelineCache(Device device, PipelineCacheCreateInfo* createInfo, AllocationCallbacks* allocator,
                                                          PipelineCache* pipelineCache);

        public unsafe delegate void DestroyPipelineCache(Device device, PipelineCache pipelineCache, AllocationCallbacks* allocator);

        public unsafe delegate Result GetPipelineCacheData(Device device, PipelineCache pipelineCache, nuint* dataSize, void* data);

        public unsafe delegate Result MergePipelineCaches(Device device, PipelineCache dstCache, uint srcCacheCount, PipelineCache* srcCaches);

        public unsafe delegate Result CreateGraphicsPipelines(Device device, PipelineCache pipelineCache, uint createInfoCount,
                                                              GraphicsPipelineCreateInfo* createInfos, AllocationCallbacks* allocator,
                                                              Pipeline* pipelines);

        public unsafe delegate Result CreateComputePipelines(Device device, PipelineCache pipelineCache, uint createInfoCount,
                                                             ComputePipelineCreateInfo* createInfos, AllocationCallbacks* allocator,
                                                             Pipeline* pipelines);

        public unsafe delegate void DestroyPipeline(Device device, Pipeline pipeline, AllocationCallbacks* allocator);

        public unsafe delegate Result CreatePipelineLayout(Device device, PipelineLayoutCreateInfo* createInfo, AllocationCallbacks* allocator,
                                                           PipelineLayout* pipelineLayout);

        public unsafe delegate void DestroyPipelineLayout(Device device, PipelineLayout pipelineLayout, AllocationCallbacks* allocator);

        public unsafe delegate Result CreateSampler(Device device, SamplerCreateInfo* createInfo, AllocationCallbacks* allocator, Sampler* sampler);

        public unsafe delegate void DestroySampler(Device device, Sampler sampler, AllocationCallbacks* allocator);

        public unsafe delegate Result CreateDescriptorSetLayout(Device device, DescriptorSetLayoutCreateInfo* createInfo,
                                                                AllocationCallbacks* allocator, DescriptorSetLayout* setLayout);

        public unsafe delegate void
            DestroyDescriptorSetLayout(Device device, DescriptorSetLayout descriptorSetLayout, AllocationCallbacks* allocator);

        public unsafe delegate Result CreateDescriptorPool(Device device, DescriptorPoolCreateInfo* createInfo, AllocationCallbacks* allocator,
                                                           DescriptorPool* descriptorPool);

        public unsafe delegate void DestroyDescriptorPool(Device device, DescriptorPool descriptorPool, AllocationCallbacks* allocator);

        public unsafe delegate Result ResetDescriptorPool(Device device, DescriptorPool descriptorPool, DescriptorPoolResetFlags flags);

        public unsafe delegate Result AllocateDescriptorSets(Device device, DescriptorSetAllocateInfo* allocateInfo, DescriptorSet* descriptorSets);

        public unsafe delegate Result FreeDescriptorSets(Device device, DescriptorPool descriptorPool, uint descriptorSetCount,
                                                         DescriptorSet* descriptorSets);

        public unsafe delegate void UpdateDescriptorSets(Device device, uint descriptorWriteCount, WriteDescriptorSet* descriptorWrites,
                                                         uint descriptorCopyCount, CopyDescriptorSet* descriptorCopies);

        public unsafe delegate Result CreateFramebuffer(Device device, FramebufferCreateInfo* createInfo, AllocationCallbacks* allocator,
                                                        Framebuffer* framebuffer);

        public unsafe delegate void DestroyFramebuffer(Device device, Framebuffer framebuffer, AllocationCallbacks* allocator);

        public unsafe delegate Result CreateRenderPass(Device device, RenderPassCreateInfo* createInfo, AllocationCallbacks* allocator,
                                                       RenderPass* renderPass);

        public unsafe delegate void DestroyRenderPass(Device device, RenderPass renderPass, AllocationCallbacks* allocator);

        public unsafe delegate void GetRenderAreaGranularity(Device device, RenderPass renderPass, Extent2D* granularity);

        public unsafe delegate Result CreateCommandPool(Device device, CommandPoolCreateInfo* createInfo, AllocationCallbacks* allocator,
                                                        CommandPool* commandPool);

        public unsafe delegate void DestroyCommandPool(Device device, CommandPool commandPool, AllocationCallbacks* allocator);

        public unsafe delegate Result ResetCommandPool(Device device, CommandPool commandPool, CommandPoolResetFlags flags);

        public unsafe delegate Result AllocateCommandBuffers(Device device, CommandBufferAllocateInfo* allocateInfo, CommandBuffer* commandBuffers);

        public unsafe delegate void FreeCommandBuffers(Device device, CommandPool commandPool, uint commandBufferCount,
                                                       CommandBuffer* commandBuffers);

        public unsafe delegate Result BeginCommandBuffer(CommandBuffer commandBuffer, CommandBufferBeginInfo* beginInfo);

        public unsafe delegate Result EndCommandBuffer(CommandBuffer commandBuffer);

        public unsafe delegate Result ResetCommandBuffer(CommandBuffer commandBuffer, CommandBufferResetFlags flags);

        public unsafe delegate void CmdBindPipeline(CommandBuffer commandBuffer, PipelineBindPoint pipelineBindPoint, Pipeline pipeline);

        public unsafe delegate void CmdSetViewport(CommandBuffer commandBuffer, uint firstViewport, uint viewportCount, Viewport* viewports);

        public unsafe delegate void CmdSetScissor(CommandBuffer commandBuffer, uint firstScissor, uint scissorCount, Rect2D* scissors);

        public unsafe delegate void CmdSetLineWidth(CommandBuffer commandBuffer, float lineWidth);

        public unsafe delegate void CmdSetDepthBias(CommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp,
                                                    float depthBiasSlopeFactor);

        public unsafe delegate void CmdSetBlendConstants(CommandBuffer commandBuffer, float[] blendConstants);

        public unsafe delegate void CmdSetDepthBounds(CommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds);

        public unsafe delegate void CmdSetStencilCompareMask(CommandBuffer commandBuffer, StencilFaceFlags faceMask, uint compareMask);

        public unsafe delegate void CmdSetStencilWriteMask(CommandBuffer commandBuffer, StencilFaceFlags faceMask, uint writeMask);

        public unsafe delegate void CmdSetStencilReference(CommandBuffer commandBuffer, StencilFaceFlags faceMask, uint reference);

        public unsafe delegate void CmdBindDescriptorSets(CommandBuffer commandBuffer, PipelineBindPoint pipelineBindPoint, PipelineLayout layout,
                                                          uint firstSet, uint descriptorSetCount, DescriptorSet* descriptorSets,
                                                          uint dynamicOffsetCount, uint* dynamicOffsets);

        public unsafe delegate void CmdBindIndexBuffer(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, IndexType indexType);

        public unsafe delegate void CmdBindVertexBuffers(CommandBuffer commandBuffer, uint firstBinding, uint bindingCount, Buffer* buffers,
                                                         DeviceSize* offsets);

        public unsafe delegate void CmdDraw(CommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);

        public unsafe delegate void CmdDrawIndexed(CommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex,
                                                   int vertexOffset, uint firstInstance);

        public unsafe delegate void CmdDrawIndirect(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, uint drawCount, uint stride);

        public unsafe delegate void CmdDrawIndexedIndirect(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, uint drawCount,
                                                           uint stride);

        public unsafe delegate void CmdDispatch(CommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ);

        public unsafe delegate void CmdDispatchIndirect(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset);

        public unsafe delegate void CmdCopyBuffer(CommandBuffer commandBuffer, Buffer srcBuffer, Buffer dstBuffer, uint regionCount,
                                                  BufferCopy* regions);

        public unsafe delegate void CmdCopyImage(CommandBuffer commandBuffer, Image srcImage, ImageLayout srcImageLayout, Image dstImage,
                                                 ImageLayout dstImageLayout, uint regionCount, ImageCopy* regions);

        public unsafe delegate void CmdBlitImage(CommandBuffer commandBuffer, Image srcImage, ImageLayout srcImageLayout, Image dstImage,
                                                 ImageLayout dstImageLayout, uint regionCount, ImageBlit* regions, Filter filter);

        public unsafe delegate void CmdCopyBufferToImage(CommandBuffer commandBuffer, Buffer srcBuffer, Image dstImage, ImageLayout dstImageLayout,
                                                         uint regionCount, BufferImageCopy* regions);

        public unsafe delegate void CmdCopyImageToBuffer(CommandBuffer commandBuffer, Image srcImage, ImageLayout srcImageLayout, Buffer dstBuffer,
                                                         uint regionCount, BufferImageCopy* regions);

        public unsafe delegate void CmdUpdateBuffer(CommandBuffer commandBuffer, Buffer dstBuffer, DeviceSize dstOffset, DeviceSize dataSize,
                                                    void* data);

        public unsafe delegate void CmdFillBuffer(CommandBuffer commandBuffer, Buffer dstBuffer, DeviceSize dstOffset, DeviceSize size, uint data);

        public unsafe delegate void CmdClearColorImage(CommandBuffer commandBuffer, Image image, ImageLayout imageLayout, ClearColorValue* color,
                                                       uint rangeCount, ImageSubresourceRange* ranges);

        public unsafe delegate void CmdClearDepthStencilImage(CommandBuffer commandBuffer, Image image, ImageLayout imageLayout,
                                                              ClearDepthStencilValue* depthStencil, uint rangeCount, ImageSubresourceRange* ranges);

        public unsafe delegate void CmdClearAttachments(CommandBuffer commandBuffer, uint attachmentCount, ClearAttachment* attachments,
                                                        uint rectCount, ClearRect* rects);

        public unsafe delegate void CmdResolveImage(CommandBuffer commandBuffer, Image srcImage, ImageLayout srcImageLayout, Image dstImage,
                                                    ImageLayout dstImageLayout, uint regionCount, ImageResolve* regions);

        public unsafe delegate void CmdSetEvent(CommandBuffer commandBuffer, Event @event, PipelineStageFlags stageMask);

        public unsafe delegate void CmdResetEvent(CommandBuffer commandBuffer, Event @event, PipelineStageFlags stageMask);

        public unsafe delegate void CmdWaitEvents(CommandBuffer commandBuffer, uint eventCount, Event* events, PipelineStageFlags srcStageMask,
                                                  PipelineStageFlags dstStageMask, uint memoryBarrierCount, MemoryBarrier* memoryBarriers,
                                                  uint bufferMemoryBarrierCount, BufferMemoryBarrier* bufferMemoryBarriers,
                                                  uint imageMemoryBarrierCount, ImageMemoryBarrier* imageMemoryBarriers);

        public unsafe delegate void CmdPipelineBarrier(CommandBuffer commandBuffer, PipelineStageFlags srcStageMask, PipelineStageFlags dstStageMask,
                                                       DependencyFlags dependencyFlags, uint memoryBarrierCount, MemoryBarrier* memoryBarriers,
                                                       uint bufferMemoryBarrierCount, BufferMemoryBarrier* bufferMemoryBarriers,
                                                       uint imageMemoryBarrierCount, ImageMemoryBarrier* imageMemoryBarriers);

        public unsafe delegate void CmdBeginQuery(CommandBuffer commandBuffer, QueryPool queryPool, uint query, QueryControlFlags flags);

        public unsafe delegate void CmdEndQuery(CommandBuffer commandBuffer, QueryPool queryPool, uint query);

        public unsafe delegate void CmdBeginConditionalRenderingEXT(CommandBuffer commandBuffer,
                                                                    ConditionalRenderingBeginInfoEXT* conditionalRenderingBegin);

        public unsafe delegate void CmdEndConditionalRenderingEXT(CommandBuffer commandBuffer);

        public unsafe delegate void CmdResetQueryPool(CommandBuffer commandBuffer, QueryPool queryPool, uint firstQuery, uint queryCount);

        public unsafe delegate void CmdWriteTimestamp(CommandBuffer commandBuffer, PipelineStageFlags pipelineStage, QueryPool queryPool, uint query);

        public unsafe delegate void CmdCopyQueryPoolResults(CommandBuffer commandBuffer, QueryPool queryPool, uint firstQuery, uint queryCount,
                                                            Buffer dstBuffer, DeviceSize dstOffset, DeviceSize stride, QueryResultFlags flags);

        public unsafe delegate void CmdPushConstants(CommandBuffer commandBuffer, PipelineLayout layout, ShaderStageFlags stageFlags, uint offset,
                                                     uint size, void* values);

        public unsafe delegate void CmdBeginRenderPass(CommandBuffer commandBuffer, RenderPassBeginInfo* renderPassBegin, SubpassContents contents);

        public unsafe delegate void CmdNextSubpass(CommandBuffer commandBuffer, SubpassContents contents);

        public unsafe delegate void CmdEndRenderPass(CommandBuffer commandBuffer);

        public unsafe delegate void CmdExecuteCommands(CommandBuffer commandBuffer, uint commandBufferCount, CommandBuffer* commandBuffers);

        public unsafe delegate Result CreateAndroidSurfaceKHR(Instance instance, AndroidSurfaceCreateInfoKHR* createInfo,
                                                              AllocationCallbacks* allocator, SurfaceKHR* surface);

        public unsafe delegate Result GetPhysicalDeviceDisplayPropertiesKHR(PhysicalDevice physicalDevice, uint* propertyCount,
                                                                            DisplayPropertiesKHR* properties);

        public unsafe delegate Result GetPhysicalDeviceDisplayPlanePropertiesKHR(PhysicalDevice physicalDevice, uint* propertyCount,
                                                                                 DisplayPlanePropertiesKHR* properties);

        public unsafe delegate Result GetDisplayPlaneSupportedDisplaysKHR(PhysicalDevice physicalDevice, uint planeIndex, uint* displayCount,
                                                                          DisplayKHR* displays);

        public unsafe delegate Result GetDisplayModePropertiesKHR(PhysicalDevice physicalDevice, DisplayKHR display, uint* propertyCount,
                                                                  DisplayModePropertiesKHR* properties);

        public unsafe delegate Result CreateDisplayModeKHR(PhysicalDevice physicalDevice, DisplayKHR display, DisplayModeCreateInfoKHR* createInfo,
                                                           AllocationCallbacks* allocator, DisplayModeKHR* mode);

        public unsafe delegate Result GetDisplayPlaneCapabilitiesKHR(PhysicalDevice physicalDevice, DisplayModeKHR mode, uint planeIndex,
                                                                     DisplayPlaneCapabilitiesKHR* capabilities);

        public unsafe delegate Result CreateDisplayPlaneSurfaceKHR(Instance instance, DisplaySurfaceCreateInfoKHR* createInfo,
                                                                   AllocationCallbacks* allocator, SurfaceKHR* surface);

        public unsafe delegate Result CreateSharedSwapchainsKHR(Device device, uint swapchainCount, SwapchainCreateInfoKHR* createInfos,
                                                                AllocationCallbacks* allocator, SwapchainKHR* swapchains);

        public unsafe delegate void DestroySurfaceKHR(Instance instance, SurfaceKHR surface, AllocationCallbacks* allocator);

        public unsafe delegate Result GetPhysicalDeviceSurfaceSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex, SurfaceKHR surface,
                                                                         Bool32* supported);

        public unsafe delegate Result GetPhysicalDeviceSurfaceCapabilitiesKHR(PhysicalDevice physicalDevice, SurfaceKHR surface,
                                                                              SurfaceCapabilitiesKHR* surfaceCapabilities);

        public unsafe delegate Result GetPhysicalDeviceSurfaceFormatsKHR(PhysicalDevice physicalDevice, SurfaceKHR surface, uint* surfaceFormatCount,
                                                                         SurfaceFormatKHR* surfaceFormats);

        public unsafe delegate Result GetPhysicalDeviceSurfacePresentModesKHR(PhysicalDevice physicalDevice, SurfaceKHR surface,
                                                                              uint* presentModeCount, PresentModeKHR* presentModes);

        public unsafe delegate Result CreateSwapchainKHR(Device device, SwapchainCreateInfoKHR* createInfo, AllocationCallbacks* allocator,
                                                         SwapchainKHR* swapchain);

        public unsafe delegate void DestroySwapchainKHR(Device device, SwapchainKHR swapchain, AllocationCallbacks* allocator);

        public unsafe delegate Result GetSwapchainImagesKHR(Device device, SwapchainKHR swapchain, uint* swapchainImageCount, Image* swapchainImages);

        public unsafe delegate Result AcquireNextImageKHR(Device device, SwapchainKHR swapchain, ulong timeout, Semaphore semaphore, Fence fence,
                                                          uint* imageIndex);

        public unsafe delegate Result QueuePresentKHR(Queue queue, PresentInfoKHR* presentInfo);

        public unsafe delegate Result CreateViSurfaceNN(Instance instance, ViSurfaceCreateInfoNN* createInfo, AllocationCallbacks* allocator,
                                                        SurfaceKHR* surface);

        public unsafe delegate Result CreateWaylandSurfaceKHR(Instance instance, WaylandSurfaceCreateInfoKHR* createInfo,
                                                              AllocationCallbacks* allocator, SurfaceKHR* surface);

        public unsafe delegate Bool32 GetPhysicalDeviceWaylandPresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex,
                                                                                     void** display);

        public unsafe delegate Result CreateWin32SurfaceKHR(Instance instance, Win32SurfaceCreateInfoKHR* createInfo, AllocationCallbacks* allocator,
                                                            SurfaceKHR* surface);

        public unsafe delegate Bool32 GetPhysicalDeviceWin32PresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex);

        public unsafe delegate Result CreateXlibSurfaceKHR(Instance instance, XlibSurfaceCreateInfoKHR* createInfo, AllocationCallbacks* allocator,
                                                           SurfaceKHR* surface);

        public unsafe delegate Bool32 GetPhysicalDeviceXlibPresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex, void** dpy,
                                                                                  void* visualID);

        public unsafe delegate Result CreateXcbSurfaceKHR(Instance instance, XcbSurfaceCreateInfoKHR* createInfo, AllocationCallbacks* allocator,
                                                          SurfaceKHR* surface);

        public unsafe delegate Bool32 GetPhysicalDeviceXcbPresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex,
                                                                                 void** connection, void* visual_id);

        public unsafe delegate Result CreateDirectFBSurfaceEXT(Instance instance, DirectFBSurfaceCreateInfoEXT* createInfo,
                                                               AllocationCallbacks* allocator, SurfaceKHR* surface);

        public unsafe delegate Bool32 GetPhysicalDeviceDirectFBPresentationSupportEXT(PhysicalDevice physicalDevice, uint queueFamilyIndex,
                                                                                      void** dfb);

        public unsafe delegate Result CreateImagePipeSurfaceFUCHSIA(Instance instance, ImagePipeSurfaceCreateInfoFUCHSIA* createInfo,
                                                                    AllocationCallbacks* allocator, SurfaceKHR* surface);

        public unsafe delegate Result CreateStreamDescriptorSurfaceGGP(Instance instance, StreamDescriptorSurfaceCreateInfoGGP* createInfo,
                                                                       AllocationCallbacks* allocator, SurfaceKHR* surface);

        public unsafe delegate Result CreateDebugReportCallbackEXT(Instance instance, DebugReportCallbackCreateInfoEXT* createInfo,
                                                                   AllocationCallbacks* allocator, DebugReportCallbackEXT* callback);

        public unsafe delegate void DestroyDebugReportCallbackEXT(Instance instance, DebugReportCallbackEXT callback, AllocationCallbacks* allocator);

        public unsafe delegate void DebugReportMessageEXT(Instance instance, DebugReportFlagsEXT flags, DebugReportObjectTypeEXT objectType,
                                                          ulong @object, nuint location, int messageCode, byte* layerPrefix, byte* message);

        public unsafe delegate Result DebugMarkerSetObjectNameEXT(Device device, DebugMarkerObjectNameInfoEXT* nameInfo);

        public unsafe delegate Result DebugMarkerSetObjectTagEXT(Device device, DebugMarkerObjectTagInfoEXT* tagInfo);

        public unsafe delegate void CmdDebugMarkerBeginEXT(CommandBuffer commandBuffer, DebugMarkerMarkerInfoEXT* markerInfo);

        public unsafe delegate void CmdDebugMarkerEndEXT(CommandBuffer commandBuffer);

        public unsafe delegate void CmdDebugMarkerInsertEXT(CommandBuffer commandBuffer, DebugMarkerMarkerInfoEXT* markerInfo);

        public unsafe delegate Result GetPhysicalDeviceExternalImageFormatPropertiesNV(PhysicalDevice physicalDevice, Format format, ImageType type,
                                                                                       ImageTiling tiling, ImageUsageFlags usage,
                                                                                       ImageCreateFlags flags,
                                                                                       ExternalMemoryHandleTypeFlagsNV externalHandleType,
                                                                                       ExternalImageFormatPropertiesNV*
                                                                                           externalImageFormatProperties);

        public unsafe delegate Result GetMemoryWin32HandleNV(Device device, DeviceMemory memory, ExternalMemoryHandleTypeFlagsNV handleType,
                                                             void** handle);

        public unsafe delegate void CmdExecuteGeneratedCommandsNV(CommandBuffer commandBuffer, Bool32 isPreprocessed,
                                                                  GeneratedCommandsInfoNV* generatedCommandsInfo);

        public unsafe delegate void CmdPreprocessGeneratedCommandsNV(CommandBuffer commandBuffer, GeneratedCommandsInfoNV* generatedCommandsInfo);

        public unsafe delegate void CmdBindPipelineShaderGroupNV(CommandBuffer commandBuffer, PipelineBindPoint pipelineBindPoint, Pipeline pipeline,
                                                                 uint groupIndex);

        public unsafe delegate void GetGeneratedCommandsMemoryRequirementsNV(Device device, GeneratedCommandsMemoryRequirementsInfoNV* info,
                                                                             MemoryRequirements2* memoryRequirements);

        public unsafe delegate Result CreateIndirectCommandsLayoutNV(Device device, IndirectCommandsLayoutCreateInfoNV* createInfo,
                                                                     AllocationCallbacks* allocator,
                                                                     IndirectCommandsLayoutNV* indirectCommandsLayout);

        public unsafe delegate void DestroyIndirectCommandsLayoutNV(Device device, IndirectCommandsLayoutNV indirectCommandsLayout,
                                                                    AllocationCallbacks* allocator);

        public unsafe delegate void GetPhysicalDeviceFeatures2(PhysicalDevice physicalDevice, PhysicalDeviceFeatures2* features);

        public unsafe delegate void GetPhysicalDeviceProperties2(PhysicalDevice physicalDevice, PhysicalDeviceProperties2* properties);

        public unsafe delegate void GetPhysicalDeviceFormatProperties2(PhysicalDevice physicalDevice, Format format,
                                                                       FormatProperties2* formatProperties);

        public unsafe delegate Result GetPhysicalDeviceImageFormatProperties2(PhysicalDevice physicalDevice,
                                                                              PhysicalDeviceImageFormatInfo2* imageFormatInfo,
                                                                              ImageFormatProperties2* imageFormatProperties);

        public unsafe delegate void GetPhysicalDeviceQueueFamilyProperties2(PhysicalDevice physicalDevice, uint* queueFamilyPropertyCount,
                                                                            QueueFamilyProperties2* queueFamilyProperties);

        public unsafe delegate void GetPhysicalDeviceMemoryProperties2(PhysicalDevice physicalDevice,
                                                                       PhysicalDeviceMemoryProperties2* memoryProperties);

        public unsafe delegate void GetPhysicalDeviceSparseImageFormatProperties2(PhysicalDevice physicalDevice,
                                                                                  PhysicalDeviceSparseImageFormatInfo2* formatInfo,
                                                                                  uint* propertyCount, SparseImageFormatProperties2* properties);

        public unsafe delegate void CmdPushDescriptorSetKHR(CommandBuffer commandBuffer, PipelineBindPoint pipelineBindPoint, PipelineLayout layout,
                                                            uint set, uint descriptorWriteCount, WriteDescriptorSet* descriptorWrites);

        public unsafe delegate void TrimCommandPool(Device device, CommandPool commandPool, CommandPoolTrimFlags flags);

        public unsafe delegate void GetPhysicalDeviceExternalBufferProperties(PhysicalDevice physicalDevice,
                                                                              PhysicalDeviceExternalBufferInfo* externalBufferInfo,
                                                                              ExternalBufferProperties* externalBufferProperties);

        public unsafe delegate Result GetMemoryWin32HandleKHR(Device device, MemoryGetWin32HandleInfoKHR* getWin32HandleInfo, void** handle);

        public unsafe delegate Result GetMemoryWin32HandlePropertiesKHR(Device device, ExternalMemoryHandleTypeFlags handleType, void* handle,
                                                                        MemoryWin32HandlePropertiesKHR* memoryWin32HandleProperties);

        public unsafe delegate Result GetMemoryFdKHR(Device device, MemoryGetFdInfoKHR* getFdInfo, short* fd);

        public unsafe delegate Result GetMemoryFdPropertiesKHR(Device device, ExternalMemoryHandleTypeFlags handleType, short fd,
                                                               MemoryFdPropertiesKHR* memoryFdProperties);

        public unsafe delegate void GetPhysicalDeviceExternalSemaphoreProperties(PhysicalDevice physicalDevice,
                                                                                 PhysicalDeviceExternalSemaphoreInfo* externalSemaphoreInfo,
                                                                                 ExternalSemaphoreProperties* externalSemaphoreProperties);

        public unsafe delegate Result GetSemaphoreWin32HandleKHR(Device device, SemaphoreGetWin32HandleInfoKHR* getWin32HandleInfo, void** handle);

        public unsafe delegate Result ImportSemaphoreWin32HandleKHR(Device device, ImportSemaphoreWin32HandleInfoKHR* importSemaphoreWin32HandleInfo);

        public unsafe delegate Result GetSemaphoreFdKHR(Device device, SemaphoreGetFdInfoKHR* getFdInfo, short* fd);

        public unsafe delegate Result ImportSemaphoreFdKHR(Device device, ImportSemaphoreFdInfoKHR* importSemaphoreFdInfo);

        public unsafe delegate void GetPhysicalDeviceExternalFenceProperties(PhysicalDevice physicalDevice,
                                                                             PhysicalDeviceExternalFenceInfo* externalFenceInfo,
                                                                             ExternalFenceProperties* externalFenceProperties);

        public unsafe delegate Result GetFenceWin32HandleKHR(Device device, FenceGetWin32HandleInfoKHR* getWin32HandleInfo, void** handle);

        public unsafe delegate Result ImportFenceWin32HandleKHR(Device device, ImportFenceWin32HandleInfoKHR* importFenceWin32HandleInfo);

        public unsafe delegate Result GetFenceFdKHR(Device device, FenceGetFdInfoKHR* getFdInfo, short* fd);

        public unsafe delegate Result ImportFenceFdKHR(Device device, ImportFenceFdInfoKHR* importFenceFdInfo);

        public unsafe delegate Result ReleaseDisplayEXT(PhysicalDevice physicalDevice, DisplayKHR display);

        public unsafe delegate Result AcquireXlibDisplayEXT(PhysicalDevice physicalDevice, void** dpy, DisplayKHR display);

        public unsafe delegate Result GetRandROutputDisplayEXT(PhysicalDevice physicalDevice, void** dpy, ulong rrOutput, DisplayKHR* display);

        public unsafe delegate Result DisplayPowerControlEXT(Device device, DisplayKHR display, DisplayPowerInfoEXT* displayPowerInfo);

        public unsafe delegate Result RegisterDeviceEventEXT(Device device, DeviceEventInfoEXT* deviceEventInfo, AllocationCallbacks* allocator,
                                                             Fence* fence);

        public unsafe delegate Result RegisterDisplayEventEXT(Device device, DisplayKHR display, DisplayEventInfoEXT* displayEventInfo,
                                                              AllocationCallbacks* allocator, Fence* fence);

        public unsafe delegate Result GetSwapchainCounterEXT(Device device, SwapchainKHR swapchain, SurfaceCounterFlagsEXT counter,
                                                             ulong* counterValue);

        public unsafe delegate Result GetPhysicalDeviceSurfaceCapabilities2EXT(PhysicalDevice physicalDevice, SurfaceKHR surface,
                                                                               SurfaceCapabilities2EXT* surfaceCapabilities);

        public unsafe delegate Result EnumeratePhysicalDeviceGroups(Instance instance, uint* physicalDeviceGroupCount,
                                                                    PhysicalDeviceGroupProperties* physicalDeviceGroupProperties);

        public unsafe delegate void GetDeviceGroupPeerMemoryFeatures(Device device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex,
                                                                     PeerMemoryFeatureFlags* peerMemoryFeatures);

        public unsafe delegate Result BindBufferMemory2(Device device, uint bindInfoCount, BindBufferMemoryInfo* bindInfos);

        public unsafe delegate Result BindImageMemory2(Device device, uint bindInfoCount, BindImageMemoryInfo* bindInfos);

        public unsafe delegate void CmdSetDeviceMask(CommandBuffer commandBuffer, uint deviceMask);

        public unsafe delegate Result GetDeviceGroupPresentCapabilitiesKHR(
            Device device, DeviceGroupPresentCapabilitiesKHR* deviceGroupPresentCapabilities);

        public unsafe delegate Result GetDeviceGroupSurfacePresentModesKHR(Device device, SurfaceKHR surface, DeviceGroupPresentModeFlagsKHR* modes);

        public unsafe delegate Result AcquireNextImage2KHR(Device device, AcquireNextImageInfoKHR* acquireInfo, uint* imageIndex);

        public unsafe delegate void CmdDispatchBase(CommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX,
                                                    uint groupCountY, uint groupCountZ);

        public unsafe delegate Result GetPhysicalDevicePresentRectanglesKHR(PhysicalDevice physicalDevice, SurfaceKHR surface, uint* rectCount,
                                                                            Rect2D* rects);

        public unsafe delegate Result CreateDescriptorUpdateTemplate(Device device, DescriptorUpdateTemplateCreateInfo* createInfo,
                                                                     AllocationCallbacks* allocator,
                                                                     DescriptorUpdateTemplate* descriptorUpdateTemplate);

        public unsafe delegate void DestroyDescriptorUpdateTemplate(Device device, DescriptorUpdateTemplate descriptorUpdateTemplate,
                                                                    AllocationCallbacks* allocator);

        public unsafe delegate void UpdateDescriptorSetWithTemplate(Device device, DescriptorSet descriptorSet,
                                                                    DescriptorUpdateTemplate descriptorUpdateTemplate, void* data);

        public unsafe delegate void CmdPushDescriptorSetWithTemplateKHR(CommandBuffer commandBuffer,
                                                                        DescriptorUpdateTemplate descriptorUpdateTemplate, PipelineLayout layout,
                                                                        uint set, void* data);

        public unsafe delegate void SetHdrMetadataEXT(Device device, uint swapchainCount, SwapchainKHR* swapchains, HdrMetadataEXT* metadata);

        public unsafe delegate Result GetSwapchainStatusKHR(Device device, SwapchainKHR swapchain);

        public unsafe delegate Result GetRefreshCycleDurationGOOGLE(Device device, SwapchainKHR swapchain,
                                                                    RefreshCycleDurationGOOGLE* displayTimingProperties);

        public unsafe delegate Result GetPastPresentationTimingGOOGLE(Device device, SwapchainKHR swapchain, uint* presentationTimingCount,
                                                                      PastPresentationTimingGOOGLE* presentationTimings);

        public unsafe delegate Result CreateIOSSurfaceMVK(Instance instance, IOSSurfaceCreateInfoMVK* createInfo, AllocationCallbacks* allocator,
                                                          SurfaceKHR* surface);

        public unsafe delegate Result CreateMacOSSurfaceMVK(Instance instance, MacOSSurfaceCreateInfoMVK* createInfo, AllocationCallbacks* allocator,
                                                            SurfaceKHR* surface);

        public unsafe delegate Result CreateMetalSurfaceEXT(Instance instance, MetalSurfaceCreateInfoEXT* createInfo, AllocationCallbacks* allocator,
                                                            SurfaceKHR* surface);

        public unsafe delegate void CmdSetViewportWScalingNV(CommandBuffer commandBuffer, uint firstViewport, uint viewportCount,
                                                             ViewportWScalingNV* viewportWScalings);

        public unsafe delegate void CmdSetDiscardRectangleEXT(CommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount,
                                                              Rect2D* discardRectangles);

        public unsafe delegate void CmdSetSampleLocationsEXT(CommandBuffer commandBuffer, SampleLocationsInfoEXT* sampleLocationsInfo);

        public unsafe delegate void GetPhysicalDeviceMultisamplePropertiesEXT(PhysicalDevice physicalDevice, SampleCountFlags samples,
                                                                              MultisamplePropertiesEXT* multisampleProperties);

        public unsafe delegate Result GetPhysicalDeviceSurfaceCapabilities2KHR(PhysicalDevice physicalDevice,
                                                                               PhysicalDeviceSurfaceInfo2KHR* surfaceInfo,
                                                                               SurfaceCapabilities2KHR* surfaceCapabilities);

        public unsafe delegate Result GetPhysicalDeviceSurfaceFormats2KHR(PhysicalDevice physicalDevice, PhysicalDeviceSurfaceInfo2KHR* surfaceInfo,
                                                                          uint* surfaceFormatCount, SurfaceFormat2KHR* surfaceFormats);

        public unsafe delegate Result GetPhysicalDeviceDisplayProperties2KHR(PhysicalDevice physicalDevice, uint* propertyCount,
                                                                             DisplayProperties2KHR* properties);

        public unsafe delegate Result GetPhysicalDeviceDisplayPlaneProperties2KHR(PhysicalDevice physicalDevice, uint* propertyCount,
                                                                                  DisplayPlaneProperties2KHR* properties);

        public unsafe delegate Result GetDisplayModeProperties2KHR(PhysicalDevice physicalDevice, DisplayKHR display, uint* propertyCount,
                                                                   DisplayModeProperties2KHR* properties);

        public unsafe delegate Result GetDisplayPlaneCapabilities2KHR(PhysicalDevice physicalDevice, DisplayPlaneInfo2KHR* displayPlaneInfo,
                                                                      DisplayPlaneCapabilities2KHR* capabilities);

        public unsafe delegate void GetBufferMemoryRequirements2(Device device, BufferMemoryRequirementsInfo2* info,
                                                                 MemoryRequirements2* memoryRequirements);

        public unsafe delegate void GetImageMemoryRequirements2(Device device, ImageMemoryRequirementsInfo2* info,
                                                                MemoryRequirements2* memoryRequirements);

        public unsafe delegate void GetImageSparseMemoryRequirements2(Device device, ImageSparseMemoryRequirementsInfo2* info,
                                                                      uint* sparseMemoryRequirementCount,
                                                                      SparseImageMemoryRequirements2* sparseMemoryRequirements);

        public unsafe delegate Result CreateSamplerYcbcrConversion(Device device, SamplerYcbcrConversionCreateInfo* createInfo,
                                                                   AllocationCallbacks* allocator, SamplerYcbcrConversion* ycbcrConversion);

        public unsafe delegate void DestroySamplerYcbcrConversion(Device device, SamplerYcbcrConversion ycbcrConversion,
                                                                  AllocationCallbacks* allocator);

        public unsafe delegate void GetDeviceQueue2(Device device, DeviceQueueInfo2* queueInfo, Queue* queue);

        public unsafe delegate Result CreateValidationCacheEXT(Device device, ValidationCacheCreateInfoEXT* createInfo,
                                                               AllocationCallbacks* allocator, ValidationCacheEXT* validationCache);

        public unsafe delegate void DestroyValidationCacheEXT(Device device, ValidationCacheEXT validationCache, AllocationCallbacks* allocator);

        public unsafe delegate Result GetValidationCacheDataEXT(Device device, ValidationCacheEXT validationCache, nuint* dataSize, void* data);

        public unsafe delegate Result MergeValidationCachesEXT(Device device, ValidationCacheEXT dstCache, uint srcCacheCount,
                                                               ValidationCacheEXT* srcCaches);

        public unsafe delegate void GetDescriptorSetLayoutSupport(Device device, DescriptorSetLayoutCreateInfo* createInfo,
                                                                  DescriptorSetLayoutSupport* support);

        public unsafe delegate Result GetSwapchainGrallocUsageANDROID(Device device, Format format, ImageUsageFlags imageUsage, short* grallocUsage);

        public unsafe delegate Result GetSwapchainGrallocUsage2ANDROID(Device device, Format format, ImageUsageFlags imageUsage,
                                                                       SwapchainImageUsageFlagsANDROID swapchainImageUsage,
                                                                       ulong* grallocConsumerUsage, ulong* grallocProducerUsage);

        public unsafe delegate Result AcquireImageANDROID(Device device, Image image, short nativeFenceFd, Semaphore semaphore, Fence fence);

        public unsafe delegate Result QueueSignalReleaseImageANDROID(Queue queue, uint waitSemaphoreCount, Semaphore* waitSemaphores, Image image,
                                                                     short* nativeFenceFd);

        public unsafe delegate Result GetShaderInfoAMD(Device device, Pipeline pipeline, ShaderStageFlags shaderStage, ShaderInfoTypeAMD infoType,
                                                       nuint* infoSize, void* info);

        public unsafe delegate void SetLocalDimmingAMD(Device device, SwapchainKHR swapChain, Bool32 localDimmingEnable);

        public unsafe delegate Result GetPhysicalDeviceCalibrateableTimeDomainsEXT(PhysicalDevice physicalDevice, uint* timeDomainCount,
                                                                                   TimeDomainEXT* timeDomains);

        public unsafe delegate Result GetCalibratedTimestampsEXT(Device device, uint timestampCount, CalibratedTimestampInfoEXT* timestampInfos,
                                                                 ulong* timestamps, ulong* maxDeviation);

        public unsafe delegate Result SetDebugUtilsObjectNameEXT(Device device, DebugUtilsObjectNameInfoEXT* nameInfo);

        public unsafe delegate Result SetDebugUtilsObjectTagEXT(Device device, DebugUtilsObjectTagInfoEXT* tagInfo);

        public unsafe delegate void QueueBeginDebugUtilsLabelEXT(Queue queue, DebugUtilsLabelEXT* labelInfo);

        public unsafe delegate void QueueEndDebugUtilsLabelEXT(Queue queue);

        public unsafe delegate void QueueInsertDebugUtilsLabelEXT(Queue queue, DebugUtilsLabelEXT* labelInfo);

        public unsafe delegate void CmdBeginDebugUtilsLabelEXT(CommandBuffer commandBuffer, DebugUtilsLabelEXT* labelInfo);

        public unsafe delegate void CmdEndDebugUtilsLabelEXT(CommandBuffer commandBuffer);

        public unsafe delegate void CmdInsertDebugUtilsLabelEXT(CommandBuffer commandBuffer, DebugUtilsLabelEXT* labelInfo);

        public unsafe delegate Result CreateDebugUtilsMessengerEXT(Instance instance, DebugUtilsMessengerCreateInfoEXT* createInfo,
                                                                   AllocationCallbacks* allocator, DebugUtilsMessengerEXT* messenger);

        public unsafe delegate void
            DestroyDebugUtilsMessengerEXT(Instance instance, DebugUtilsMessengerEXT messenger, AllocationCallbacks* allocator);

        public unsafe delegate void SubmitDebugUtilsMessageEXT(Instance instance, DebugUtilsMessageSeverityFlagsEXT messageSeverity,
                                                               DebugUtilsMessageTypeFlagsEXT messageTypes,
                                                               DebugUtilsMessengerCallbackDataEXT* callbackData);

        public unsafe delegate Result GetMemoryHostPointerPropertiesEXT(Device device, ExternalMemoryHandleTypeFlags handleType, void* hostPointer,
                                                                        MemoryHostPointerPropertiesEXT* memoryHostPointerProperties);

        public unsafe delegate void CmdWriteBufferMarkerAMD(CommandBuffer commandBuffer, PipelineStageFlags pipelineStage, Buffer dstBuffer,
                                                            DeviceSize dstOffset, uint marker);

        public unsafe delegate Result CreateRenderPass2(Device device, RenderPassCreateInfo2* createInfo, AllocationCallbacks* allocator,
                                                        RenderPass* renderPass);

        public unsafe delegate void CmdBeginRenderPass2(CommandBuffer commandBuffer, RenderPassBeginInfo* renderPassBegin,
                                                        SubpassBeginInfo* subpassBeginInfo);

        public unsafe delegate void CmdNextSubpass2(CommandBuffer commandBuffer, SubpassBeginInfo* subpassBeginInfo, SubpassEndInfo* subpassEndInfo);

        public unsafe delegate void CmdEndRenderPass2(CommandBuffer commandBuffer, SubpassEndInfo* subpassEndInfo);

        public unsafe delegate Result GetSemaphoreCounterValue(Device device, Semaphore semaphore, ulong* value);

        public unsafe delegate Result WaitSemaphores(Device device, SemaphoreWaitInfo* waitInfo, ulong timeout);

        public unsafe delegate Result SignalSemaphore(Device device, SemaphoreSignalInfo* signalInfo);

        public unsafe delegate Result GetAndroidHardwareBufferPropertiesANDROID(Device device, void** buffer,
                                                                                AndroidHardwareBufferPropertiesANDROID* properties);

        public unsafe delegate Result GetMemoryAndroidHardwareBufferANDROID(Device device, MemoryGetAndroidHardwareBufferInfoANDROID* info,
                                                                            void*** buffer);

        public unsafe delegate void CmdDrawIndirectCount(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, Buffer countBuffer,
                                                         DeviceSize countBufferOffset, uint maxDrawCount, uint stride);

        public unsafe delegate void CmdDrawIndexedIndirectCount(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, Buffer countBuffer,
                                                                DeviceSize countBufferOffset, uint maxDrawCount, uint stride);

        public unsafe delegate void CmdSetCheckpointNV(CommandBuffer commandBuffer, void* checkpointMarker);

        public unsafe delegate void GetQueueCheckpointDataNV(Queue queue, uint* checkpointDataCount, CheckpointDataNV* checkpointData);

        public unsafe delegate void CmdBindTransformFeedbackBuffersEXT(CommandBuffer commandBuffer, uint firstBinding, uint bindingCount,
                                                                       Buffer* buffers, DeviceSize* offsets, DeviceSize* sizes);

        public unsafe delegate void CmdBeginTransformFeedbackEXT(CommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount,
                                                                 Buffer* counterBuffers, DeviceSize* counterBufferOffsets);

        public unsafe delegate void CmdEndTransformFeedbackEXT(CommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount,
                                                               Buffer* counterBuffers, DeviceSize* counterBufferOffsets);

        public unsafe delegate void CmdBeginQueryIndexedEXT(CommandBuffer commandBuffer, QueryPool queryPool, uint query, QueryControlFlags flags,
                                                            uint index);

        public unsafe delegate void CmdEndQueryIndexedEXT(CommandBuffer commandBuffer, QueryPool queryPool, uint query, uint index);

        public unsafe delegate void CmdDrawIndirectByteCountEXT(CommandBuffer commandBuffer, uint instanceCount, uint firstInstance,
                                                                Buffer counterBuffer, DeviceSize counterBufferOffset, uint counterOffset,
                                                                uint vertexStride);

        public unsafe delegate void CmdSetExclusiveScissorNV(CommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount,
                                                             Rect2D* exclusiveScissors);

        public unsafe delegate void CmdBindShadingRateImageNV(CommandBuffer commandBuffer, ImageView imageView, ImageLayout imageLayout);

        public unsafe delegate void CmdSetViewportShadingRatePaletteNV(CommandBuffer commandBuffer, uint firstViewport, uint viewportCount,
                                                                       ShadingRatePaletteNV* shadingRatePalettes);

        public unsafe delegate void CmdSetCoarseSampleOrderNV(CommandBuffer commandBuffer, CoarseSampleOrderTypeNV sampleOrderType,
                                                              uint customSampleOrderCount, CoarseSampleOrderCustomNV* customSampleOrders);

        public unsafe delegate void CmdDrawMeshTasksNV(CommandBuffer commandBuffer, uint taskCount, uint firstTask);

        public unsafe delegate void CmdDrawMeshTasksIndirectNV(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, uint drawCount,
                                                               uint stride);

        public unsafe delegate void CmdDrawMeshTasksIndirectCountNV(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, Buffer countBuffer,
                                                                    DeviceSize countBufferOffset, uint maxDrawCount, uint stride);

        public unsafe delegate Result CompileDeferredNV(Device device, Pipeline pipeline, uint shader);

        public unsafe delegate Result CreateAccelerationStructureNV(Device device, AccelerationStructureCreateInfoNV* createInfo,
                                                                    AllocationCallbacks* allocator, AccelerationStructureNV* accelerationStructure);

        public unsafe delegate void DestroyAccelerationStructureKHR(Device device, AccelerationStructureKHR accelerationStructure,
                                                                    AllocationCallbacks* allocator);

        public unsafe delegate void GetAccelerationStructureMemoryRequirementsKHR(Device device, AccelerationStructureMemoryRequirementsInfoKHR* info,
                                                                                  MemoryRequirements2* memoryRequirements);

        public unsafe delegate void GetAccelerationStructureMemoryRequirementsNV(Device device, AccelerationStructureMemoryRequirementsInfoNV* info,
                                                                                 MemoryRequirements2KHR* memoryRequirements);

        public unsafe delegate Result BindAccelerationStructureMemoryKHR(Device device, uint bindInfoCount,
                                                                         BindAccelerationStructureMemoryInfoKHR* bindInfos);

        public unsafe delegate void CmdCopyAccelerationStructureNV(CommandBuffer commandBuffer, AccelerationStructureKHR dst,
                                                                   AccelerationStructureKHR src, CopyAccelerationStructureModeKHR mode);

        public unsafe delegate void CmdCopyAccelerationStructureKHR(CommandBuffer commandBuffer, CopyAccelerationStructureInfoKHR* info);

        public unsafe delegate Result CopyAccelerationStructureKHR(Device device, CopyAccelerationStructureInfoKHR* info);

        public unsafe delegate void CmdCopyAccelerationStructureToMemoryKHR(CommandBuffer commandBuffer,
                                                                            CopyAccelerationStructureToMemoryInfoKHR* info);

        public unsafe delegate Result CopyAccelerationStructureToMemoryKHR(Device device, CopyAccelerationStructureToMemoryInfoKHR* info);

        public unsafe delegate void CmdCopyMemoryToAccelerationStructureKHR(CommandBuffer commandBuffer,
                                                                            CopyMemoryToAccelerationStructureInfoKHR* info);

        public unsafe delegate Result CopyMemoryToAccelerationStructureKHR(Device device, CopyMemoryToAccelerationStructureInfoKHR* info);

        public unsafe delegate void CmdWriteAccelerationStructuresPropertiesKHR(CommandBuffer commandBuffer, uint accelerationStructureCount,
                                                                                AccelerationStructureKHR* accelerationStructures, QueryType queryType,
                                                                                QueryPool queryPool, uint firstQuery);

        public unsafe delegate void CmdBuildAccelerationStructureNV(CommandBuffer commandBuffer, AccelerationStructureInfoNV* info,
                                                                    Buffer instanceData, DeviceSize instanceOffset, Bool32 update,
                                                                    AccelerationStructureKHR dst, AccelerationStructureKHR src, Buffer scratch,
                                                                    DeviceSize scratchOffset);

        public unsafe delegate Result WriteAccelerationStructuresPropertiesKHR(Device device, uint accelerationStructureCount,
                                                                               AccelerationStructureKHR* accelerationStructures, QueryType queryType,
                                                                               nuint dataSize, void* data, nuint stride);

        public unsafe delegate void CmdTraceRaysKHR(CommandBuffer commandBuffer, StridedBufferRegionKHR* raygenShaderBindingTable,
                                                    StridedBufferRegionKHR* missShaderBindingTable, StridedBufferRegionKHR* hitShaderBindingTable,
                                                    StridedBufferRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth);

        public unsafe delegate void CmdTraceRaysNV(CommandBuffer commandBuffer, Buffer raygenShaderBindingTableBuffer,
                                                   DeviceSize raygenShaderBindingOffset, Buffer missShaderBindingTableBuffer,
                                                   DeviceSize missShaderBindingOffset, DeviceSize missShaderBindingStride,
                                                   Buffer hitShaderBindingTableBuffer, DeviceSize hitShaderBindingOffset,
                                                   DeviceSize hitShaderBindingStride, Buffer callableShaderBindingTableBuffer,
                                                   DeviceSize callableShaderBindingOffset, DeviceSize callableShaderBindingStride, uint width,
                                                   uint height, uint depth);

        public unsafe delegate Result GetRayTracingShaderGroupHandlesKHR(Device device, Pipeline pipeline, uint firstGroup, uint groupCount,
                                                                         nuint dataSize, void* data);

        public unsafe delegate Result GetRayTracingCaptureReplayShaderGroupHandlesKHR(Device device, Pipeline pipeline, uint firstGroup,
                                                                                      uint groupCount, nuint dataSize, void* data);

        public unsafe delegate Result GetAccelerationStructureHandleNV(Device device, AccelerationStructureKHR accelerationStructure, nuint dataSize,
                                                                       void* data);

        public unsafe delegate Result CreateRayTracingPipelinesNV(Device device, PipelineCache pipelineCache, uint createInfoCount,
                                                                  RayTracingPipelineCreateInfoNV* createInfos, AllocationCallbacks* allocator,
                                                                  Pipeline* pipelines);

        public unsafe delegate Result CreateRayTracingPipelinesKHR(Device device, PipelineCache pipelineCache, uint createInfoCount,
                                                                   RayTracingPipelineCreateInfoKHR* createInfos, AllocationCallbacks* allocator,
                                                                   Pipeline* pipelines);

        public unsafe delegate Result GetPhysicalDeviceCooperativeMatrixPropertiesNV(PhysicalDevice physicalDevice, uint* propertyCount,
                                                                                     CooperativeMatrixPropertiesNV* properties);

        public unsafe delegate void CmdTraceRaysIndirectKHR(CommandBuffer commandBuffer, StridedBufferRegionKHR* raygenShaderBindingTable,
                                                            StridedBufferRegionKHR* missShaderBindingTable,
                                                            StridedBufferRegionKHR* hitShaderBindingTable,
                                                            StridedBufferRegionKHR* callableShaderBindingTable, Buffer buffer, DeviceSize offset);

        public unsafe delegate Result GetDeviceAccelerationStructureCompatibilityKHR(Device device, AccelerationStructureVersionKHR* version);

        public unsafe delegate uint GetImageViewHandleNVX(Device device, ImageViewHandleInfoNVX* info);

        public unsafe delegate Result GetImageViewAddressNVX(Device device, ImageView imageView, ImageViewAddressPropertiesNVX* properties);

        public unsafe delegate Result GetPhysicalDeviceSurfacePresentModes2EXT(PhysicalDevice physicalDevice,
                                                                               PhysicalDeviceSurfaceInfo2KHR* surfaceInfo, uint* presentModeCount,
                                                                               PresentModeKHR* presentModes);

        public unsafe delegate Result GetDeviceGroupSurfacePresentModes2EXT(Device device, PhysicalDeviceSurfaceInfo2KHR* surfaceInfo,
                                                                            DeviceGroupPresentModeFlagsKHR* modes);

        public unsafe delegate Result AcquireFullScreenExclusiveModeEXT(Device device, SwapchainKHR swapchain);

        public unsafe delegate Result ReleaseFullScreenExclusiveModeEXT(Device device, SwapchainKHR swapchain);

        public unsafe delegate Result EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(
            PhysicalDevice physicalDevice, uint queueFamilyIndex, uint* counterCount, PerformanceCounterKHR* counters,
            PerformanceCounterDescriptionKHR* counterDescriptions);

        public unsafe delegate void GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(
            PhysicalDevice physicalDevice, QueryPoolPerformanceCreateInfoKHR* performanceQueryCreateInfo, uint* numPasses);

        public unsafe delegate Result AcquireProfilingLockKHR(Device device, AcquireProfilingLockInfoKHR* info);

        public unsafe delegate void ReleaseProfilingLockKHR(Device device);

        public unsafe delegate Result GetImageDrmFormatModifierPropertiesEXT(Device device, Image image,
                                                                             ImageDrmFormatModifierPropertiesEXT* properties);

        public unsafe delegate ulong GetBufferOpaqueCaptureAddress(Device device, BufferDeviceAddressInfo* info);

        public unsafe delegate DeviceAddress GetBufferDeviceAddress(Device device, BufferDeviceAddressInfo* info);

        public unsafe delegate Result CreateHeadlessSurfaceEXT(Instance instance, HeadlessSurfaceCreateInfoEXT* createInfo,
                                                               AllocationCallbacks* allocator, SurfaceKHR* surface);

        public unsafe delegate Result GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(
            PhysicalDevice physicalDevice, uint* combinationCount, FramebufferMixedSamplesCombinationNV* combinations);

        public unsafe delegate Result InitializePerformanceApiINTEL(Device device, InitializePerformanceApiInfoINTEL* initializeInfo);

        public unsafe delegate void UninitializePerformanceApiINTEL(Device device);

        public unsafe delegate Result CmdSetPerformanceMarkerINTEL(CommandBuffer commandBuffer, PerformanceMarkerInfoINTEL* markerInfo);

        public unsafe delegate Result CmdSetPerformanceStreamMarkerINTEL(CommandBuffer commandBuffer, PerformanceStreamMarkerInfoINTEL* markerInfo);

        public unsafe delegate Result CmdSetPerformanceOverrideINTEL(CommandBuffer commandBuffer, PerformanceOverrideInfoINTEL* overrideInfo);

        public unsafe delegate Result AcquirePerformanceConfigurationINTEL(Device device, PerformanceConfigurationAcquireInfoINTEL* acquireInfo,
                                                                           PerformanceConfigurationINTEL* configuration);

        public unsafe delegate Result ReleasePerformanceConfigurationINTEL(Device device, PerformanceConfigurationINTEL configuration);

        public unsafe delegate Result QueueSetPerformanceConfigurationINTEL(Queue queue, PerformanceConfigurationINTEL configuration);

        public unsafe delegate Result GetPerformanceParameterINTEL(Device device, PerformanceParameterTypeINTEL parameter,
                                                                   PerformanceValueINTEL* value);

        public unsafe delegate ulong GetDeviceMemoryOpaqueCaptureAddress(Device device, DeviceMemoryOpaqueCaptureAddressInfo* info);

        public unsafe delegate Result GetPipelineExecutablePropertiesKHR(Device device, PipelineInfoKHR* pipelineInfo, uint* executableCount,
                                                                         PipelineExecutablePropertiesKHR* properties);

        public unsafe delegate Result GetPipelineExecutableStatisticsKHR(Device device, PipelineExecutableInfoKHR* executableInfo,
                                                                         uint* statisticCount, PipelineExecutableStatisticKHR* statistics);

        public unsafe delegate Result GetPipelineExecutableInternalRepresentationsKHR(Device device, PipelineExecutableInfoKHR* executableInfo,
                                                                                      uint* internalRepresentationCount,
                                                                                      PipelineExecutableInternalRepresentationKHR*
                                                                                          internalRepresentations);

        public unsafe delegate void CmdSetLineStippleEXT(CommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern);

        public unsafe delegate Result GetPhysicalDeviceToolPropertiesEXT(PhysicalDevice physicalDevice, uint* toolCount,
                                                                         PhysicalDeviceToolPropertiesEXT* toolProperties);

        public unsafe delegate Result CreateAccelerationStructureKHR(Device device, AccelerationStructureCreateInfoKHR* createInfo,
                                                                     AllocationCallbacks* allocator, AccelerationStructureKHR* accelerationStructure);

        public unsafe delegate void CmdBuildAccelerationStructureKHR(CommandBuffer commandBuffer, uint infoCount,
                                                                     AccelerationStructureBuildGeometryInfoKHR* infos,
                                                                     AccelerationStructureBuildOffsetInfoKHR** offsetInfos);

        public unsafe delegate void CmdBuildAccelerationStructureIndirectKHR(CommandBuffer commandBuffer,
                                                                             AccelerationStructureBuildGeometryInfoKHR* info, Buffer indirectBuffer,
                                                                             DeviceSize indirectOffset, uint indirectStride);

        public unsafe delegate Result BuildAccelerationStructureKHR(Device device, uint infoCount, AccelerationStructureBuildGeometryInfoKHR* infos,
                                                                    AccelerationStructureBuildOffsetInfoKHR** offsetInfos);

        public unsafe delegate DeviceAddress GetAccelerationStructureDeviceAddressKHR(Device device, AccelerationStructureDeviceAddressInfoKHR* info);

        public unsafe delegate Result CreateDeferredOperationKHR(Device device, AllocationCallbacks* allocator,
                                                                 DeferredOperationKHR* deferredOperation);

        public unsafe delegate void DestroyDeferredOperationKHR(Device device, DeferredOperationKHR operation, AllocationCallbacks* allocator);

        public unsafe delegate uint GetDeferredOperationMaxConcurrencyKHR(Device device, DeferredOperationKHR operation);

        public unsafe delegate Result GetDeferredOperationResultKHR(Device device, DeferredOperationKHR operation);

        public unsafe delegate Result DeferredOperationJoinKHR(Device device, DeferredOperationKHR operation);

        public unsafe delegate void CmdSetCullModeEXT(CommandBuffer commandBuffer, CullModeFlags cullMode);

        public unsafe delegate void CmdSetFrontFaceEXT(CommandBuffer commandBuffer, FrontFace frontFace);

        public unsafe delegate void CmdSetPrimitiveTopologyEXT(CommandBuffer commandBuffer, PrimitiveTopology primitiveTopology);

        public unsafe delegate void CmdSetViewportWithCountEXT(CommandBuffer commandBuffer, uint viewportCount, Viewport* viewports);

        public unsafe delegate void CmdSetScissorWithCountEXT(CommandBuffer commandBuffer, uint scissorCount, Rect2D* scissors);

        public unsafe delegate void CmdBindVertexBuffers2EXT(CommandBuffer commandBuffer, uint firstBinding, uint bindingCount, Buffer* buffers,
                                                             DeviceSize* offsets, DeviceSize* sizes, DeviceSize* strides);

        public unsafe delegate void CmdSetDepthTestEnableEXT(CommandBuffer commandBuffer, Bool32 depthTestEnable);

        public unsafe delegate void CmdSetDepthWriteEnableEXT(CommandBuffer commandBuffer, Bool32 depthWriteEnable);

        public unsafe delegate void CmdSetDepthCompareOpEXT(CommandBuffer commandBuffer, CompareOp depthCompareOp);

        public unsafe delegate void CmdSetDepthBoundsTestEnableEXT(CommandBuffer commandBuffer, Bool32 depthBoundsTestEnable);

        public unsafe delegate void CmdSetStencilTestEnableEXT(CommandBuffer commandBuffer, Bool32 stencilTestEnable);

        public unsafe delegate void CmdSetStencilOpEXT(CommandBuffer commandBuffer, StencilFaceFlags faceMask, StencilOp failOp, StencilOp passOp,
                                                       StencilOp depthFailOp, CompareOp compareOp);

        public unsafe delegate Result CreatePrivateDataSlotEXT(Device device, PrivateDataSlotCreateInfoEXT* createInfo,
                                                               AllocationCallbacks* allocator, PrivateDataSlotEXT* privateDataSlot);

        public unsafe delegate void DestroyPrivateDataSlotEXT(Device device, PrivateDataSlotEXT privateDataSlot, AllocationCallbacks* allocator);

        public unsafe delegate Result SetPrivateDataEXT(Device device, ObjectType objectType, ulong objectHandle, PrivateDataSlotEXT privateDataSlot,
                                                        ulong data);

        public unsafe delegate void GetPrivateDataEXT(Device device, ObjectType objectType, ulong objectHandle, PrivateDataSlotEXT privateDataSlot,
                                                      ulong* data);
    }
}