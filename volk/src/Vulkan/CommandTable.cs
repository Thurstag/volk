// Copyright 2020-2020 Volk Project
// Licensed under Apache License 2.0 or any later version
// Refer to the LICENSE.md file included.

namespace Volk.Vulkan {

	/// <summary>
	/// Global table of commands
	/// </summary>
    public static class CommandTable {
        public static Commands.CreateInstance? CreateInstance;

        public static Commands.DestroyInstance? DestroyInstance;

        public static Commands.EnumeratePhysicalDevices? EnumeratePhysicalDevices;

        public static Commands.GetDeviceProcAddr? GetDeviceProcAddr;

        public static Commands.GetInstanceProcAddr? GetInstanceProcAddr;

        public static Commands.GetPhysicalDeviceProperties? GetPhysicalDeviceProperties;

        public static Commands.GetPhysicalDeviceQueueFamilyProperties? GetPhysicalDeviceQueueFamilyProperties;

        public static Commands.GetPhysicalDeviceMemoryProperties? GetPhysicalDeviceMemoryProperties;

        public static Commands.GetPhysicalDeviceFeatures? GetPhysicalDeviceFeatures;

        public static Commands.GetPhysicalDeviceFormatProperties? GetPhysicalDeviceFormatProperties;

        public static Commands.GetPhysicalDeviceImageFormatProperties? GetPhysicalDeviceImageFormatProperties;

        public static Commands.CreateDevice? CreateDevice;

        public static Commands.DestroyDevice? DestroyDevice;

        public static Commands.EnumerateInstanceVersion? EnumerateInstanceVersion;

        public static Commands.EnumerateInstanceLayerProperties? EnumerateInstanceLayerProperties;

        public static Commands.EnumerateInstanceExtensionProperties? EnumerateInstanceExtensionProperties;

        public static Commands.EnumerateDeviceLayerProperties? EnumerateDeviceLayerProperties;

        public static Commands.EnumerateDeviceExtensionProperties? EnumerateDeviceExtensionProperties;

        public static Commands.GetDeviceQueue? GetDeviceQueue;

        public static Commands.QueueSubmit? QueueSubmit;

        public static Commands.QueueWaitIdle? QueueWaitIdle;

        public static Commands.DeviceWaitIdle? DeviceWaitIdle;

        public static Commands.AllocateMemory? AllocateMemory;

        public static Commands.FreeMemory? FreeMemory;

        public static Commands.MapMemory? MapMemory;

        public static Commands.UnmapMemory? UnmapMemory;

        public static Commands.FlushMappedMemoryRanges? FlushMappedMemoryRanges;

        public static Commands.InvalidateMappedMemoryRanges? InvalidateMappedMemoryRanges;

        public static Commands.GetDeviceMemoryCommitment? GetDeviceMemoryCommitment;

        public static Commands.GetBufferMemoryRequirements? GetBufferMemoryRequirements;

        public static Commands.BindBufferMemory? BindBufferMemory;

        public static Commands.GetImageMemoryRequirements? GetImageMemoryRequirements;

        public static Commands.BindImageMemory? BindImageMemory;

        public static Commands.GetImageSparseMemoryRequirements? GetImageSparseMemoryRequirements;

        public static Commands.GetPhysicalDeviceSparseImageFormatProperties? GetPhysicalDeviceSparseImageFormatProperties;

        public static Commands.QueueBindSparse? QueueBindSparse;

        public static Commands.CreateFence? CreateFence;

        public static Commands.DestroyFence? DestroyFence;

        public static Commands.ResetFences? ResetFences;

        public static Commands.GetFenceStatus? GetFenceStatus;

        public static Commands.WaitForFences? WaitForFences;

        public static Commands.CreateSemaphore? CreateSemaphore;

        public static Commands.DestroySemaphore? DestroySemaphore;

        public static Commands.CreateEvent? CreateEvent;

        public static Commands.DestroyEvent? DestroyEvent;

        public static Commands.GetEventStatus? GetEventStatus;

        public static Commands.SetEvent? SetEvent;

        public static Commands.ResetEvent? ResetEvent;

        public static Commands.CreateQueryPool? CreateQueryPool;

        public static Commands.DestroyQueryPool? DestroyQueryPool;

        public static Commands.GetQueryPoolResults? GetQueryPoolResults;

        public static Commands.ResetQueryPool? ResetQueryPool;

        public static Commands.CreateBuffer? CreateBuffer;

        public static Commands.DestroyBuffer? DestroyBuffer;

        public static Commands.CreateBufferView? CreateBufferView;

        public static Commands.DestroyBufferView? DestroyBufferView;

        public static Commands.CreateImage? CreateImage;

        public static Commands.DestroyImage? DestroyImage;

        public static Commands.GetImageSubresourceLayout? GetImageSubresourceLayout;

        public static Commands.CreateImageView? CreateImageView;

        public static Commands.DestroyImageView? DestroyImageView;

        public static Commands.CreateShaderModule? CreateShaderModule;

        public static Commands.DestroyShaderModule? DestroyShaderModule;

        public static Commands.CreatePipelineCache? CreatePipelineCache;

        public static Commands.DestroyPipelineCache? DestroyPipelineCache;

        public static Commands.GetPipelineCacheData? GetPipelineCacheData;

        public static Commands.MergePipelineCaches? MergePipelineCaches;

        public static Commands.CreateGraphicsPipelines? CreateGraphicsPipelines;

        public static Commands.CreateComputePipelines? CreateComputePipelines;

        public static Commands.DestroyPipeline? DestroyPipeline;

        public static Commands.CreatePipelineLayout? CreatePipelineLayout;

        public static Commands.DestroyPipelineLayout? DestroyPipelineLayout;

        public static Commands.CreateSampler? CreateSampler;

        public static Commands.DestroySampler? DestroySampler;

        public static Commands.CreateDescriptorSetLayout? CreateDescriptorSetLayout;

        public static Commands.DestroyDescriptorSetLayout? DestroyDescriptorSetLayout;

        public static Commands.CreateDescriptorPool? CreateDescriptorPool;

        public static Commands.DestroyDescriptorPool? DestroyDescriptorPool;

        public static Commands.ResetDescriptorPool? ResetDescriptorPool;

        public static Commands.AllocateDescriptorSets? AllocateDescriptorSets;

        public static Commands.FreeDescriptorSets? FreeDescriptorSets;

        public static Commands.UpdateDescriptorSets? UpdateDescriptorSets;

        public static Commands.CreateFramebuffer? CreateFramebuffer;

        public static Commands.DestroyFramebuffer? DestroyFramebuffer;

        public static Commands.CreateRenderPass? CreateRenderPass;

        public static Commands.DestroyRenderPass? DestroyRenderPass;

        public static Commands.GetRenderAreaGranularity? GetRenderAreaGranularity;

        public static Commands.CreateCommandPool? CreateCommandPool;

        public static Commands.DestroyCommandPool? DestroyCommandPool;

        public static Commands.ResetCommandPool? ResetCommandPool;

        public static Commands.AllocateCommandBuffers? AllocateCommandBuffers;

        public static Commands.FreeCommandBuffers? FreeCommandBuffers;

        public static Commands.BeginCommandBuffer? BeginCommandBuffer;

        public static Commands.EndCommandBuffer? EndCommandBuffer;

        public static Commands.ResetCommandBuffer? ResetCommandBuffer;

        public static Commands.CmdBindPipeline? CmdBindPipeline;

        public static Commands.CmdSetViewport? CmdSetViewport;

        public static Commands.CmdSetScissor? CmdSetScissor;

        public static Commands.CmdSetLineWidth? CmdSetLineWidth;

        public static Commands.CmdSetDepthBias? CmdSetDepthBias;

        public static Commands.CmdSetBlendConstants? CmdSetBlendConstants;

        public static Commands.CmdSetDepthBounds? CmdSetDepthBounds;

        public static Commands.CmdSetStencilCompareMask? CmdSetStencilCompareMask;

        public static Commands.CmdSetStencilWriteMask? CmdSetStencilWriteMask;

        public static Commands.CmdSetStencilReference? CmdSetStencilReference;

        public static Commands.CmdBindDescriptorSets? CmdBindDescriptorSets;

        public static Commands.CmdBindIndexBuffer? CmdBindIndexBuffer;

        public static Commands.CmdBindVertexBuffers? CmdBindVertexBuffers;

        public static Commands.CmdDraw? CmdDraw;

        public static Commands.CmdDrawIndexed? CmdDrawIndexed;

        public static Commands.CmdDrawIndirect? CmdDrawIndirect;

        public static Commands.CmdDrawIndexedIndirect? CmdDrawIndexedIndirect;

        public static Commands.CmdDispatch? CmdDispatch;

        public static Commands.CmdDispatchIndirect? CmdDispatchIndirect;

        public static Commands.CmdCopyBuffer? CmdCopyBuffer;

        public static Commands.CmdCopyImage? CmdCopyImage;

        public static Commands.CmdBlitImage? CmdBlitImage;

        public static Commands.CmdCopyBufferToImage? CmdCopyBufferToImage;

        public static Commands.CmdCopyImageToBuffer? CmdCopyImageToBuffer;

        public static Commands.CmdUpdateBuffer? CmdUpdateBuffer;

        public static Commands.CmdFillBuffer? CmdFillBuffer;

        public static Commands.CmdClearColorImage? CmdClearColorImage;

        public static Commands.CmdClearDepthStencilImage? CmdClearDepthStencilImage;

        public static Commands.CmdClearAttachments? CmdClearAttachments;

        public static Commands.CmdResolveImage? CmdResolveImage;

        public static Commands.CmdSetEvent? CmdSetEvent;

        public static Commands.CmdResetEvent? CmdResetEvent;

        public static Commands.CmdWaitEvents? CmdWaitEvents;

        public static Commands.CmdPipelineBarrier? CmdPipelineBarrier;

        public static Commands.CmdBeginQuery? CmdBeginQuery;

        public static Commands.CmdEndQuery? CmdEndQuery;

        public static Commands.CmdBeginConditionalRenderingEXT? CmdBeginConditionalRenderingEXT;

        public static Commands.CmdEndConditionalRenderingEXT? CmdEndConditionalRenderingEXT;

        public static Commands.CmdResetQueryPool? CmdResetQueryPool;

        public static Commands.CmdWriteTimestamp? CmdWriteTimestamp;

        public static Commands.CmdCopyQueryPoolResults? CmdCopyQueryPoolResults;

        public static Commands.CmdPushConstants? CmdPushConstants;

        public static Commands.CmdBeginRenderPass? CmdBeginRenderPass;

        public static Commands.CmdNextSubpass? CmdNextSubpass;

        public static Commands.CmdEndRenderPass? CmdEndRenderPass;

        public static Commands.CmdExecuteCommands? CmdExecuteCommands;

        public static Commands.CreateAndroidSurfaceKHR? CreateAndroidSurfaceKHR;

        public static Commands.GetPhysicalDeviceDisplayPropertiesKHR? GetPhysicalDeviceDisplayPropertiesKHR;

        public static Commands.GetPhysicalDeviceDisplayPlanePropertiesKHR? GetPhysicalDeviceDisplayPlanePropertiesKHR;

        public static Commands.GetDisplayPlaneSupportedDisplaysKHR? GetDisplayPlaneSupportedDisplaysKHR;

        public static Commands.GetDisplayModePropertiesKHR? GetDisplayModePropertiesKHR;

        public static Commands.CreateDisplayModeKHR? CreateDisplayModeKHR;

        public static Commands.GetDisplayPlaneCapabilitiesKHR? GetDisplayPlaneCapabilitiesKHR;

        public static Commands.CreateDisplayPlaneSurfaceKHR? CreateDisplayPlaneSurfaceKHR;

        public static Commands.CreateSharedSwapchainsKHR? CreateSharedSwapchainsKHR;

        public static Commands.DestroySurfaceKHR? DestroySurfaceKHR;

        public static Commands.GetPhysicalDeviceSurfaceSupportKHR? GetPhysicalDeviceSurfaceSupportKHR;

        public static Commands.GetPhysicalDeviceSurfaceCapabilitiesKHR? GetPhysicalDeviceSurfaceCapabilitiesKHR;

        public static Commands.GetPhysicalDeviceSurfaceFormatsKHR? GetPhysicalDeviceSurfaceFormatsKHR;

        public static Commands.GetPhysicalDeviceSurfacePresentModesKHR? GetPhysicalDeviceSurfacePresentModesKHR;

        public static Commands.CreateSwapchainKHR? CreateSwapchainKHR;

        public static Commands.DestroySwapchainKHR? DestroySwapchainKHR;

        public static Commands.GetSwapchainImagesKHR? GetSwapchainImagesKHR;

        public static Commands.AcquireNextImageKHR? AcquireNextImageKHR;

        public static Commands.QueuePresentKHR? QueuePresentKHR;

        public static Commands.CreateViSurfaceNN? CreateViSurfaceNN;

        public static Commands.CreateWaylandSurfaceKHR? CreateWaylandSurfaceKHR;

        public static Commands.GetPhysicalDeviceWaylandPresentationSupportKHR? GetPhysicalDeviceWaylandPresentationSupportKHR;

        public static Commands.CreateWin32SurfaceKHR? CreateWin32SurfaceKHR;

        public static Commands.GetPhysicalDeviceWin32PresentationSupportKHR? GetPhysicalDeviceWin32PresentationSupportKHR;

        public static Commands.CreateXlibSurfaceKHR? CreateXlibSurfaceKHR;

        public static Commands.GetPhysicalDeviceXlibPresentationSupportKHR? GetPhysicalDeviceXlibPresentationSupportKHR;

        public static Commands.CreateXcbSurfaceKHR? CreateXcbSurfaceKHR;

        public static Commands.GetPhysicalDeviceXcbPresentationSupportKHR? GetPhysicalDeviceXcbPresentationSupportKHR;

        public static Commands.CreateDirectFBSurfaceEXT? CreateDirectFBSurfaceEXT;

        public static Commands.GetPhysicalDeviceDirectFBPresentationSupportEXT? GetPhysicalDeviceDirectFBPresentationSupportEXT;

        public static Commands.CreateImagePipeSurfaceFUCHSIA? CreateImagePipeSurfaceFUCHSIA;

        public static Commands.CreateStreamDescriptorSurfaceGGP? CreateStreamDescriptorSurfaceGGP;

        public static Commands.CreateDebugReportCallbackEXT? CreateDebugReportCallbackEXT;

        public static Commands.DestroyDebugReportCallbackEXT? DestroyDebugReportCallbackEXT;

        public static Commands.DebugReportMessageEXT? DebugReportMessageEXT;

        public static Commands.DebugMarkerSetObjectNameEXT? DebugMarkerSetObjectNameEXT;

        public static Commands.DebugMarkerSetObjectTagEXT? DebugMarkerSetObjectTagEXT;

        public static Commands.CmdDebugMarkerBeginEXT? CmdDebugMarkerBeginEXT;

        public static Commands.CmdDebugMarkerEndEXT? CmdDebugMarkerEndEXT;

        public static Commands.CmdDebugMarkerInsertEXT? CmdDebugMarkerInsertEXT;

        public static Commands.GetPhysicalDeviceExternalImageFormatPropertiesNV? GetPhysicalDeviceExternalImageFormatPropertiesNV;

        public static Commands.GetMemoryWin32HandleNV? GetMemoryWin32HandleNV;

        public static Commands.CmdExecuteGeneratedCommandsNV? CmdExecuteGeneratedCommandsNV;

        public static Commands.CmdPreprocessGeneratedCommandsNV? CmdPreprocessGeneratedCommandsNV;

        public static Commands.CmdBindPipelineShaderGroupNV? CmdBindPipelineShaderGroupNV;

        public static Commands.GetGeneratedCommandsMemoryRequirementsNV? GetGeneratedCommandsMemoryRequirementsNV;

        public static Commands.CreateIndirectCommandsLayoutNV? CreateIndirectCommandsLayoutNV;

        public static Commands.DestroyIndirectCommandsLayoutNV? DestroyIndirectCommandsLayoutNV;

        public static Commands.GetPhysicalDeviceFeatures2? GetPhysicalDeviceFeatures2;

        public static Commands.GetPhysicalDeviceProperties2? GetPhysicalDeviceProperties2;

        public static Commands.GetPhysicalDeviceFormatProperties2? GetPhysicalDeviceFormatProperties2;

        public static Commands.GetPhysicalDeviceImageFormatProperties2? GetPhysicalDeviceImageFormatProperties2;

        public static Commands.GetPhysicalDeviceQueueFamilyProperties2? GetPhysicalDeviceQueueFamilyProperties2;

        public static Commands.GetPhysicalDeviceMemoryProperties2? GetPhysicalDeviceMemoryProperties2;

        public static Commands.GetPhysicalDeviceSparseImageFormatProperties2? GetPhysicalDeviceSparseImageFormatProperties2;

        public static Commands.CmdPushDescriptorSetKHR? CmdPushDescriptorSetKHR;

        public static Commands.TrimCommandPool? TrimCommandPool;

        public static Commands.GetPhysicalDeviceExternalBufferProperties? GetPhysicalDeviceExternalBufferProperties;

        public static Commands.GetMemoryWin32HandleKHR? GetMemoryWin32HandleKHR;

        public static Commands.GetMemoryWin32HandlePropertiesKHR? GetMemoryWin32HandlePropertiesKHR;

        public static Commands.GetMemoryFdKHR? GetMemoryFdKHR;

        public static Commands.GetMemoryFdPropertiesKHR? GetMemoryFdPropertiesKHR;

        public static Commands.GetPhysicalDeviceExternalSemaphoreProperties? GetPhysicalDeviceExternalSemaphoreProperties;

        public static Commands.GetSemaphoreWin32HandleKHR? GetSemaphoreWin32HandleKHR;

        public static Commands.ImportSemaphoreWin32HandleKHR? ImportSemaphoreWin32HandleKHR;

        public static Commands.GetSemaphoreFdKHR? GetSemaphoreFdKHR;

        public static Commands.ImportSemaphoreFdKHR? ImportSemaphoreFdKHR;

        public static Commands.GetPhysicalDeviceExternalFenceProperties? GetPhysicalDeviceExternalFenceProperties;

        public static Commands.GetFenceWin32HandleKHR? GetFenceWin32HandleKHR;

        public static Commands.ImportFenceWin32HandleKHR? ImportFenceWin32HandleKHR;

        public static Commands.GetFenceFdKHR? GetFenceFdKHR;

        public static Commands.ImportFenceFdKHR? ImportFenceFdKHR;

        public static Commands.ReleaseDisplayEXT? ReleaseDisplayEXT;

        public static Commands.AcquireXlibDisplayEXT? AcquireXlibDisplayEXT;

        public static Commands.GetRandROutputDisplayEXT? GetRandROutputDisplayEXT;

        public static Commands.DisplayPowerControlEXT? DisplayPowerControlEXT;

        public static Commands.RegisterDeviceEventEXT? RegisterDeviceEventEXT;

        public static Commands.RegisterDisplayEventEXT? RegisterDisplayEventEXT;

        public static Commands.GetSwapchainCounterEXT? GetSwapchainCounterEXT;

        public static Commands.GetPhysicalDeviceSurfaceCapabilities2EXT? GetPhysicalDeviceSurfaceCapabilities2EXT;

        public static Commands.EnumeratePhysicalDeviceGroups? EnumeratePhysicalDeviceGroups;

        public static Commands.GetDeviceGroupPeerMemoryFeatures? GetDeviceGroupPeerMemoryFeatures;

        public static Commands.BindBufferMemory2? BindBufferMemory2;

        public static Commands.BindImageMemory2? BindImageMemory2;

        public static Commands.CmdSetDeviceMask? CmdSetDeviceMask;

        public static Commands.GetDeviceGroupPresentCapabilitiesKHR? GetDeviceGroupPresentCapabilitiesKHR;

        public static Commands.GetDeviceGroupSurfacePresentModesKHR? GetDeviceGroupSurfacePresentModesKHR;

        public static Commands.AcquireNextImage2KHR? AcquireNextImage2KHR;

        public static Commands.CmdDispatchBase? CmdDispatchBase;

        public static Commands.GetPhysicalDevicePresentRectanglesKHR? GetPhysicalDevicePresentRectanglesKHR;

        public static Commands.CreateDescriptorUpdateTemplate? CreateDescriptorUpdateTemplate;

        public static Commands.DestroyDescriptorUpdateTemplate? DestroyDescriptorUpdateTemplate;

        public static Commands.UpdateDescriptorSetWithTemplate? UpdateDescriptorSetWithTemplate;

        public static Commands.CmdPushDescriptorSetWithTemplateKHR? CmdPushDescriptorSetWithTemplateKHR;

        public static Commands.SetHdrMetadataEXT? SetHdrMetadataEXT;

        public static Commands.GetSwapchainStatusKHR? GetSwapchainStatusKHR;

        public static Commands.GetRefreshCycleDurationGOOGLE? GetRefreshCycleDurationGOOGLE;

        public static Commands.GetPastPresentationTimingGOOGLE? GetPastPresentationTimingGOOGLE;

        public static Commands.CreateIOSSurfaceMVK? CreateIOSSurfaceMVK;

        public static Commands.CreateMacOSSurfaceMVK? CreateMacOSSurfaceMVK;

        public static Commands.CreateMetalSurfaceEXT? CreateMetalSurfaceEXT;

        public static Commands.CmdSetViewportWScalingNV? CmdSetViewportWScalingNV;

        public static Commands.CmdSetDiscardRectangleEXT? CmdSetDiscardRectangleEXT;

        public static Commands.CmdSetSampleLocationsEXT? CmdSetSampleLocationsEXT;

        public static Commands.GetPhysicalDeviceMultisamplePropertiesEXT? GetPhysicalDeviceMultisamplePropertiesEXT;

        public static Commands.GetPhysicalDeviceSurfaceCapabilities2KHR? GetPhysicalDeviceSurfaceCapabilities2KHR;

        public static Commands.GetPhysicalDeviceSurfaceFormats2KHR? GetPhysicalDeviceSurfaceFormats2KHR;

        public static Commands.GetPhysicalDeviceDisplayProperties2KHR? GetPhysicalDeviceDisplayProperties2KHR;

        public static Commands.GetPhysicalDeviceDisplayPlaneProperties2KHR? GetPhysicalDeviceDisplayPlaneProperties2KHR;

        public static Commands.GetDisplayModeProperties2KHR? GetDisplayModeProperties2KHR;

        public static Commands.GetDisplayPlaneCapabilities2KHR? GetDisplayPlaneCapabilities2KHR;

        public static Commands.GetBufferMemoryRequirements2? GetBufferMemoryRequirements2;

        public static Commands.GetImageMemoryRequirements2? GetImageMemoryRequirements2;

        public static Commands.GetImageSparseMemoryRequirements2? GetImageSparseMemoryRequirements2;

        public static Commands.CreateSamplerYcbcrConversion? CreateSamplerYcbcrConversion;

        public static Commands.DestroySamplerYcbcrConversion? DestroySamplerYcbcrConversion;

        public static Commands.GetDeviceQueue2? GetDeviceQueue2;

        public static Commands.CreateValidationCacheEXT? CreateValidationCacheEXT;

        public static Commands.DestroyValidationCacheEXT? DestroyValidationCacheEXT;

        public static Commands.GetValidationCacheDataEXT? GetValidationCacheDataEXT;

        public static Commands.MergeValidationCachesEXT? MergeValidationCachesEXT;

        public static Commands.GetDescriptorSetLayoutSupport? GetDescriptorSetLayoutSupport;

        public static Commands.GetSwapchainGrallocUsageANDROID? GetSwapchainGrallocUsageANDROID;

        public static Commands.GetSwapchainGrallocUsage2ANDROID? GetSwapchainGrallocUsage2ANDROID;

        public static Commands.AcquireImageANDROID? AcquireImageANDROID;

        public static Commands.QueueSignalReleaseImageANDROID? QueueSignalReleaseImageANDROID;

        public static Commands.GetShaderInfoAMD? GetShaderInfoAMD;

        public static Commands.SetLocalDimmingAMD? SetLocalDimmingAMD;

        public static Commands.GetPhysicalDeviceCalibrateableTimeDomainsEXT? GetPhysicalDeviceCalibrateableTimeDomainsEXT;

        public static Commands.GetCalibratedTimestampsEXT? GetCalibratedTimestampsEXT;

        public static Commands.SetDebugUtilsObjectNameEXT? SetDebugUtilsObjectNameEXT;

        public static Commands.SetDebugUtilsObjectTagEXT? SetDebugUtilsObjectTagEXT;

        public static Commands.QueueBeginDebugUtilsLabelEXT? QueueBeginDebugUtilsLabelEXT;

        public static Commands.QueueEndDebugUtilsLabelEXT? QueueEndDebugUtilsLabelEXT;

        public static Commands.QueueInsertDebugUtilsLabelEXT? QueueInsertDebugUtilsLabelEXT;

        public static Commands.CmdBeginDebugUtilsLabelEXT? CmdBeginDebugUtilsLabelEXT;

        public static Commands.CmdEndDebugUtilsLabelEXT? CmdEndDebugUtilsLabelEXT;

        public static Commands.CmdInsertDebugUtilsLabelEXT? CmdInsertDebugUtilsLabelEXT;

        public static Commands.CreateDebugUtilsMessengerEXT? CreateDebugUtilsMessengerEXT;

        public static Commands.DestroyDebugUtilsMessengerEXT? DestroyDebugUtilsMessengerEXT;

        public static Commands.SubmitDebugUtilsMessageEXT? SubmitDebugUtilsMessageEXT;

        public static Commands.GetMemoryHostPointerPropertiesEXT? GetMemoryHostPointerPropertiesEXT;

        public static Commands.CmdWriteBufferMarkerAMD? CmdWriteBufferMarkerAMD;

        public static Commands.CreateRenderPass2? CreateRenderPass2;

        public static Commands.CmdBeginRenderPass2? CmdBeginRenderPass2;

        public static Commands.CmdNextSubpass2? CmdNextSubpass2;

        public static Commands.CmdEndRenderPass2? CmdEndRenderPass2;

        public static Commands.GetSemaphoreCounterValue? GetSemaphoreCounterValue;

        public static Commands.WaitSemaphores? WaitSemaphores;

        public static Commands.SignalSemaphore? SignalSemaphore;

        public static Commands.GetAndroidHardwareBufferPropertiesANDROID? GetAndroidHardwareBufferPropertiesANDROID;

        public static Commands.GetMemoryAndroidHardwareBufferANDROID? GetMemoryAndroidHardwareBufferANDROID;

        public static Commands.CmdDrawIndirectCount? CmdDrawIndirectCount;

        public static Commands.CmdDrawIndexedIndirectCount? CmdDrawIndexedIndirectCount;

        public static Commands.CmdSetCheckpointNV? CmdSetCheckpointNV;

        public static Commands.GetQueueCheckpointDataNV? GetQueueCheckpointDataNV;

        public static Commands.CmdBindTransformFeedbackBuffersEXT? CmdBindTransformFeedbackBuffersEXT;

        public static Commands.CmdBeginTransformFeedbackEXT? CmdBeginTransformFeedbackEXT;

        public static Commands.CmdEndTransformFeedbackEXT? CmdEndTransformFeedbackEXT;

        public static Commands.CmdBeginQueryIndexedEXT? CmdBeginQueryIndexedEXT;

        public static Commands.CmdEndQueryIndexedEXT? CmdEndQueryIndexedEXT;

        public static Commands.CmdDrawIndirectByteCountEXT? CmdDrawIndirectByteCountEXT;

        public static Commands.CmdSetExclusiveScissorNV? CmdSetExclusiveScissorNV;

        public static Commands.CmdBindShadingRateImageNV? CmdBindShadingRateImageNV;

        public static Commands.CmdSetViewportShadingRatePaletteNV? CmdSetViewportShadingRatePaletteNV;

        public static Commands.CmdSetCoarseSampleOrderNV? CmdSetCoarseSampleOrderNV;

        public static Commands.CmdDrawMeshTasksNV? CmdDrawMeshTasksNV;

        public static Commands.CmdDrawMeshTasksIndirectNV? CmdDrawMeshTasksIndirectNV;

        public static Commands.CmdDrawMeshTasksIndirectCountNV? CmdDrawMeshTasksIndirectCountNV;

        public static Commands.CompileDeferredNV? CompileDeferredNV;

        public static Commands.CreateAccelerationStructureNV? CreateAccelerationStructureNV;

        public static Commands.DestroyAccelerationStructureKHR? DestroyAccelerationStructureKHR;

        public static Commands.GetAccelerationStructureMemoryRequirementsKHR? GetAccelerationStructureMemoryRequirementsKHR;

        public static Commands.GetAccelerationStructureMemoryRequirementsNV? GetAccelerationStructureMemoryRequirementsNV;

        public static Commands.BindAccelerationStructureMemoryKHR? BindAccelerationStructureMemoryKHR;

        public static Commands.CmdCopyAccelerationStructureNV? CmdCopyAccelerationStructureNV;

        public static Commands.CmdCopyAccelerationStructureKHR? CmdCopyAccelerationStructureKHR;

        public static Commands.CopyAccelerationStructureKHR? CopyAccelerationStructureKHR;

        public static Commands.CmdCopyAccelerationStructureToMemoryKHR? CmdCopyAccelerationStructureToMemoryKHR;

        public static Commands.CopyAccelerationStructureToMemoryKHR? CopyAccelerationStructureToMemoryKHR;

        public static Commands.CmdCopyMemoryToAccelerationStructureKHR? CmdCopyMemoryToAccelerationStructureKHR;

        public static Commands.CopyMemoryToAccelerationStructureKHR? CopyMemoryToAccelerationStructureKHR;

        public static Commands.CmdWriteAccelerationStructuresPropertiesKHR? CmdWriteAccelerationStructuresPropertiesKHR;

        public static Commands.CmdBuildAccelerationStructureNV? CmdBuildAccelerationStructureNV;

        public static Commands.WriteAccelerationStructuresPropertiesKHR? WriteAccelerationStructuresPropertiesKHR;

        public static Commands.CmdTraceRaysKHR? CmdTraceRaysKHR;

        public static Commands.CmdTraceRaysNV? CmdTraceRaysNV;

        public static Commands.GetRayTracingShaderGroupHandlesKHR? GetRayTracingShaderGroupHandlesKHR;

        public static Commands.GetRayTracingCaptureReplayShaderGroupHandlesKHR? GetRayTracingCaptureReplayShaderGroupHandlesKHR;

        public static Commands.GetAccelerationStructureHandleNV? GetAccelerationStructureHandleNV;

        public static Commands.CreateRayTracingPipelinesNV? CreateRayTracingPipelinesNV;

        public static Commands.CreateRayTracingPipelinesKHR? CreateRayTracingPipelinesKHR;

        public static Commands.GetPhysicalDeviceCooperativeMatrixPropertiesNV? GetPhysicalDeviceCooperativeMatrixPropertiesNV;

        public static Commands.CmdTraceRaysIndirectKHR? CmdTraceRaysIndirectKHR;

        public static Commands.GetDeviceAccelerationStructureCompatibilityKHR? GetDeviceAccelerationStructureCompatibilityKHR;

        public static Commands.GetImageViewHandleNVX? GetImageViewHandleNVX;

        public static Commands.GetImageViewAddressNVX? GetImageViewAddressNVX;

        public static Commands.GetPhysicalDeviceSurfacePresentModes2EXT? GetPhysicalDeviceSurfacePresentModes2EXT;

        public static Commands.GetDeviceGroupSurfacePresentModes2EXT? GetDeviceGroupSurfacePresentModes2EXT;

        public static Commands.AcquireFullScreenExclusiveModeEXT? AcquireFullScreenExclusiveModeEXT;

        public static Commands.ReleaseFullScreenExclusiveModeEXT? ReleaseFullScreenExclusiveModeEXT;

        public static Commands.EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR? EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR;

        public static Commands.GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR? GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR;

        public static Commands.AcquireProfilingLockKHR? AcquireProfilingLockKHR;

        public static Commands.ReleaseProfilingLockKHR? ReleaseProfilingLockKHR;

        public static Commands.GetImageDrmFormatModifierPropertiesEXT? GetImageDrmFormatModifierPropertiesEXT;

        public static Commands.GetBufferOpaqueCaptureAddress? GetBufferOpaqueCaptureAddress;

        public static Commands.GetBufferDeviceAddress? GetBufferDeviceAddress;

        public static Commands.CreateHeadlessSurfaceEXT? CreateHeadlessSurfaceEXT;

        public static Commands.GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV? GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV;

        public static Commands.InitializePerformanceApiINTEL? InitializePerformanceApiINTEL;

        public static Commands.UninitializePerformanceApiINTEL? UninitializePerformanceApiINTEL;

        public static Commands.CmdSetPerformanceMarkerINTEL? CmdSetPerformanceMarkerINTEL;

        public static Commands.CmdSetPerformanceStreamMarkerINTEL? CmdSetPerformanceStreamMarkerINTEL;

        public static Commands.CmdSetPerformanceOverrideINTEL? CmdSetPerformanceOverrideINTEL;

        public static Commands.AcquirePerformanceConfigurationINTEL? AcquirePerformanceConfigurationINTEL;

        public static Commands.ReleasePerformanceConfigurationINTEL? ReleasePerformanceConfigurationINTEL;

        public static Commands.QueueSetPerformanceConfigurationINTEL? QueueSetPerformanceConfigurationINTEL;

        public static Commands.GetPerformanceParameterINTEL? GetPerformanceParameterINTEL;

        public static Commands.GetDeviceMemoryOpaqueCaptureAddress? GetDeviceMemoryOpaqueCaptureAddress;

        public static Commands.GetPipelineExecutablePropertiesKHR? GetPipelineExecutablePropertiesKHR;

        public static Commands.GetPipelineExecutableStatisticsKHR? GetPipelineExecutableStatisticsKHR;

        public static Commands.GetPipelineExecutableInternalRepresentationsKHR? GetPipelineExecutableInternalRepresentationsKHR;

        public static Commands.CmdSetLineStippleEXT? CmdSetLineStippleEXT;

        public static Commands.GetPhysicalDeviceToolPropertiesEXT? GetPhysicalDeviceToolPropertiesEXT;

        public static Commands.CreateAccelerationStructureKHR? CreateAccelerationStructureKHR;

        public static Commands.CmdBuildAccelerationStructureKHR? CmdBuildAccelerationStructureKHR;

        public static Commands.CmdBuildAccelerationStructureIndirectKHR? CmdBuildAccelerationStructureIndirectKHR;

        public static Commands.BuildAccelerationStructureKHR? BuildAccelerationStructureKHR;

        public static Commands.GetAccelerationStructureDeviceAddressKHR? GetAccelerationStructureDeviceAddressKHR;

        public static Commands.CreateDeferredOperationKHR? CreateDeferredOperationKHR;

        public static Commands.DestroyDeferredOperationKHR? DestroyDeferredOperationKHR;

        public static Commands.GetDeferredOperationMaxConcurrencyKHR? GetDeferredOperationMaxConcurrencyKHR;

        public static Commands.GetDeferredOperationResultKHR? GetDeferredOperationResultKHR;

        public static Commands.DeferredOperationJoinKHR? DeferredOperationJoinKHR;

        public static Commands.CmdSetCullModeEXT? CmdSetCullModeEXT;

        public static Commands.CmdSetFrontFaceEXT? CmdSetFrontFaceEXT;

        public static Commands.CmdSetPrimitiveTopologyEXT? CmdSetPrimitiveTopologyEXT;

        public static Commands.CmdSetViewportWithCountEXT? CmdSetViewportWithCountEXT;

        public static Commands.CmdSetScissorWithCountEXT? CmdSetScissorWithCountEXT;

        public static Commands.CmdBindVertexBuffers2EXT? CmdBindVertexBuffers2EXT;

        public static Commands.CmdSetDepthTestEnableEXT? CmdSetDepthTestEnableEXT;

        public static Commands.CmdSetDepthWriteEnableEXT? CmdSetDepthWriteEnableEXT;

        public static Commands.CmdSetDepthCompareOpEXT? CmdSetDepthCompareOpEXT;

        public static Commands.CmdSetDepthBoundsTestEnableEXT? CmdSetDepthBoundsTestEnableEXT;

        public static Commands.CmdSetStencilTestEnableEXT? CmdSetStencilTestEnableEXT;

        public static Commands.CmdSetStencilOpEXT? CmdSetStencilOpEXT;

        public static Commands.CreatePrivateDataSlotEXT? CreatePrivateDataSlotEXT;

        public static Commands.DestroyPrivateDataSlotEXT? DestroyPrivateDataSlotEXT;

        public static Commands.SetPrivateDataEXT? SetPrivateDataEXT;

        public static Commands.GetPrivateDataEXT? GetPrivateDataEXT;
    }
}
