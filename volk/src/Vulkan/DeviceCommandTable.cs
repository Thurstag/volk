// Copyright 2020-2020 Volk Project
// Licensed under Apache License 2.0 or any later version
// Refer to the LICENSE.md file included.

// This file is generated automatically by generator


namespace Volk.Vulkan {
    /// <summary>
    /// Table of device commands
    /// </summary>
    public class DeviceCommandTable {
        public Commands.DestroyDevice? DestroyDevice;

        public Commands.GetDeviceQueue? GetDeviceQueue;

        public Commands.QueueSubmit? QueueSubmit;

        public Commands.QueueWaitIdle? QueueWaitIdle;

        public Commands.DeviceWaitIdle? DeviceWaitIdle;

        public Commands.AllocateMemory? AllocateMemory;

        public Commands.FreeMemory? FreeMemory;

        public Commands.MapMemory? MapMemory;

        public Commands.UnmapMemory? UnmapMemory;

        public Commands.FlushMappedMemoryRanges? FlushMappedMemoryRanges;

        public Commands.InvalidateMappedMemoryRanges? InvalidateMappedMemoryRanges;

        public Commands.GetDeviceMemoryCommitment? GetDeviceMemoryCommitment;

        public Commands.GetBufferMemoryRequirements? GetBufferMemoryRequirements;

        public Commands.BindBufferMemory? BindBufferMemory;

        public Commands.GetImageMemoryRequirements? GetImageMemoryRequirements;

        public Commands.BindImageMemory? BindImageMemory;

        public Commands.GetImageSparseMemoryRequirements? GetImageSparseMemoryRequirements;

        public Commands.QueueBindSparse? QueueBindSparse;

        public Commands.CreateFence? CreateFence;

        public Commands.DestroyFence? DestroyFence;

        public Commands.ResetFences? ResetFences;

        public Commands.GetFenceStatus? GetFenceStatus;

        public Commands.WaitForFences? WaitForFences;

        public Commands.CreateSemaphore? CreateSemaphore;

        public Commands.DestroySemaphore? DestroySemaphore;

        public Commands.CreateEvent? CreateEvent;

        public Commands.DestroyEvent? DestroyEvent;

        public Commands.GetEventStatus? GetEventStatus;

        public Commands.SetEvent? SetEvent;

        public Commands.ResetEvent? ResetEvent;

        public Commands.CreateQueryPool? CreateQueryPool;

        public Commands.DestroyQueryPool? DestroyQueryPool;

        public Commands.GetQueryPoolResults? GetQueryPoolResults;

        public Commands.ResetQueryPool? ResetQueryPool;

        public Commands.CreateBuffer? CreateBuffer;

        public Commands.DestroyBuffer? DestroyBuffer;

        public Commands.CreateBufferView? CreateBufferView;

        public Commands.DestroyBufferView? DestroyBufferView;

        public Commands.CreateImage? CreateImage;

        public Commands.DestroyImage? DestroyImage;

        public Commands.GetImageSubresourceLayout? GetImageSubresourceLayout;

        public Commands.CreateImageView? CreateImageView;

        public Commands.DestroyImageView? DestroyImageView;

        public Commands.CreateShaderModule? CreateShaderModule;

        public Commands.DestroyShaderModule? DestroyShaderModule;

        public Commands.CreatePipelineCache? CreatePipelineCache;

        public Commands.DestroyPipelineCache? DestroyPipelineCache;

        public Commands.GetPipelineCacheData? GetPipelineCacheData;

        public Commands.MergePipelineCaches? MergePipelineCaches;

        public Commands.CreateGraphicsPipelines? CreateGraphicsPipelines;

        public Commands.CreateComputePipelines? CreateComputePipelines;

        public Commands.DestroyPipeline? DestroyPipeline;

        public Commands.CreatePipelineLayout? CreatePipelineLayout;

        public Commands.DestroyPipelineLayout? DestroyPipelineLayout;

        public Commands.CreateSampler? CreateSampler;

        public Commands.DestroySampler? DestroySampler;

        public Commands.CreateDescriptorSetLayout? CreateDescriptorSetLayout;

        public Commands.DestroyDescriptorSetLayout? DestroyDescriptorSetLayout;

        public Commands.CreateDescriptorPool? CreateDescriptorPool;

        public Commands.DestroyDescriptorPool? DestroyDescriptorPool;

        public Commands.ResetDescriptorPool? ResetDescriptorPool;

        public Commands.AllocateDescriptorSets? AllocateDescriptorSets;

        public Commands.FreeDescriptorSets? FreeDescriptorSets;

        public Commands.UpdateDescriptorSets? UpdateDescriptorSets;

        public Commands.CreateFramebuffer? CreateFramebuffer;

        public Commands.DestroyFramebuffer? DestroyFramebuffer;

        public Commands.CreateRenderPass? CreateRenderPass;

        public Commands.DestroyRenderPass? DestroyRenderPass;

        public Commands.GetRenderAreaGranularity? GetRenderAreaGranularity;

        public Commands.CreateCommandPool? CreateCommandPool;

        public Commands.DestroyCommandPool? DestroyCommandPool;

        public Commands.ResetCommandPool? ResetCommandPool;

        public Commands.AllocateCommandBuffers? AllocateCommandBuffers;

        public Commands.FreeCommandBuffers? FreeCommandBuffers;

        public Commands.BeginCommandBuffer? BeginCommandBuffer;

        public Commands.EndCommandBuffer? EndCommandBuffer;

        public Commands.ResetCommandBuffer? ResetCommandBuffer;

        public Commands.CmdBindPipeline? CmdBindPipeline;

        public Commands.CmdSetViewport? CmdSetViewport;

        public Commands.CmdSetScissor? CmdSetScissor;

        public Commands.CmdSetLineWidth? CmdSetLineWidth;

        public Commands.CmdSetDepthBias? CmdSetDepthBias;

        public Commands.CmdSetBlendConstants? CmdSetBlendConstants;

        public Commands.CmdSetDepthBounds? CmdSetDepthBounds;

        public Commands.CmdSetStencilCompareMask? CmdSetStencilCompareMask;

        public Commands.CmdSetStencilWriteMask? CmdSetStencilWriteMask;

        public Commands.CmdSetStencilReference? CmdSetStencilReference;

        public Commands.CmdBindDescriptorSets? CmdBindDescriptorSets;

        public Commands.CmdBindIndexBuffer? CmdBindIndexBuffer;

        public Commands.CmdBindVertexBuffers? CmdBindVertexBuffers;

        public Commands.CmdDraw? CmdDraw;

        public Commands.CmdDrawIndexed? CmdDrawIndexed;

        public Commands.CmdDrawIndirect? CmdDrawIndirect;

        public Commands.CmdDrawIndexedIndirect? CmdDrawIndexedIndirect;

        public Commands.CmdDispatch? CmdDispatch;

        public Commands.CmdDispatchIndirect? CmdDispatchIndirect;

        public Commands.CmdCopyBuffer? CmdCopyBuffer;

        public Commands.CmdCopyImage? CmdCopyImage;

        public Commands.CmdBlitImage? CmdBlitImage;

        public Commands.CmdCopyBufferToImage? CmdCopyBufferToImage;

        public Commands.CmdCopyImageToBuffer? CmdCopyImageToBuffer;

        public Commands.CmdUpdateBuffer? CmdUpdateBuffer;

        public Commands.CmdFillBuffer? CmdFillBuffer;

        public Commands.CmdClearColorImage? CmdClearColorImage;

        public Commands.CmdClearDepthStencilImage? CmdClearDepthStencilImage;

        public Commands.CmdClearAttachments? CmdClearAttachments;

        public Commands.CmdResolveImage? CmdResolveImage;

        public Commands.CmdSetEvent? CmdSetEvent;

        public Commands.CmdResetEvent? CmdResetEvent;

        public Commands.CmdWaitEvents? CmdWaitEvents;

        public Commands.CmdPipelineBarrier? CmdPipelineBarrier;

        public Commands.CmdBeginQuery? CmdBeginQuery;

        public Commands.CmdEndQuery? CmdEndQuery;

        public Commands.CmdBeginConditionalRenderingEXT? CmdBeginConditionalRenderingEXT;

        public Commands.CmdEndConditionalRenderingEXT? CmdEndConditionalRenderingEXT;

        public Commands.CmdResetQueryPool? CmdResetQueryPool;

        public Commands.CmdWriteTimestamp? CmdWriteTimestamp;

        public Commands.CmdCopyQueryPoolResults? CmdCopyQueryPoolResults;

        public Commands.CmdPushConstants? CmdPushConstants;

        public Commands.CmdBeginRenderPass? CmdBeginRenderPass;

        public Commands.CmdNextSubpass? CmdNextSubpass;

        public Commands.CmdEndRenderPass? CmdEndRenderPass;

        public Commands.CmdExecuteCommands? CmdExecuteCommands;

        public Commands.CreateSharedSwapchainsKHR? CreateSharedSwapchainsKHR;

        public Commands.CreateSwapchainKHR? CreateSwapchainKHR;

        public Commands.DestroySwapchainKHR? DestroySwapchainKHR;

        public Commands.GetSwapchainImagesKHR? GetSwapchainImagesKHR;

        public Commands.AcquireNextImageKHR? AcquireNextImageKHR;

        public Commands.QueuePresentKHR? QueuePresentKHR;

        public Commands.DebugMarkerSetObjectNameEXT? DebugMarkerSetObjectNameEXT;

        public Commands.DebugMarkerSetObjectTagEXT? DebugMarkerSetObjectTagEXT;

        public Commands.CmdDebugMarkerBeginEXT? CmdDebugMarkerBeginEXT;

        public Commands.CmdDebugMarkerEndEXT? CmdDebugMarkerEndEXT;

        public Commands.CmdDebugMarkerInsertEXT? CmdDebugMarkerInsertEXT;

        public Commands.GetMemoryWin32HandleNV? GetMemoryWin32HandleNV;

        public Commands.CmdExecuteGeneratedCommandsNV? CmdExecuteGeneratedCommandsNV;

        public Commands.CmdPreprocessGeneratedCommandsNV? CmdPreprocessGeneratedCommandsNV;

        public Commands.CmdBindPipelineShaderGroupNV? CmdBindPipelineShaderGroupNV;

        public Commands.GetGeneratedCommandsMemoryRequirementsNV? GetGeneratedCommandsMemoryRequirementsNV;

        public Commands.CreateIndirectCommandsLayoutNV? CreateIndirectCommandsLayoutNV;

        public Commands.DestroyIndirectCommandsLayoutNV? DestroyIndirectCommandsLayoutNV;

        public Commands.CmdPushDescriptorSetKHR? CmdPushDescriptorSetKHR;

        public Commands.TrimCommandPool? TrimCommandPool;

        public Commands.GetMemoryWin32HandleKHR? GetMemoryWin32HandleKHR;

        public Commands.GetMemoryWin32HandlePropertiesKHR? GetMemoryWin32HandlePropertiesKHR;

        public Commands.GetMemoryFdKHR? GetMemoryFdKHR;

        public Commands.GetMemoryFdPropertiesKHR? GetMemoryFdPropertiesKHR;

        public Commands.GetSemaphoreWin32HandleKHR? GetSemaphoreWin32HandleKHR;

        public Commands.ImportSemaphoreWin32HandleKHR? ImportSemaphoreWin32HandleKHR;

        public Commands.GetSemaphoreFdKHR? GetSemaphoreFdKHR;

        public Commands.ImportSemaphoreFdKHR? ImportSemaphoreFdKHR;

        public Commands.GetFenceWin32HandleKHR? GetFenceWin32HandleKHR;

        public Commands.ImportFenceWin32HandleKHR? ImportFenceWin32HandleKHR;

        public Commands.GetFenceFdKHR? GetFenceFdKHR;

        public Commands.ImportFenceFdKHR? ImportFenceFdKHR;

        public Commands.DisplayPowerControlEXT? DisplayPowerControlEXT;

        public Commands.RegisterDeviceEventEXT? RegisterDeviceEventEXT;

        public Commands.RegisterDisplayEventEXT? RegisterDisplayEventEXT;

        public Commands.GetSwapchainCounterEXT? GetSwapchainCounterEXT;

        public Commands.GetDeviceGroupPeerMemoryFeatures? GetDeviceGroupPeerMemoryFeatures;

        public Commands.BindBufferMemory2? BindBufferMemory2;

        public Commands.BindImageMemory2? BindImageMemory2;

        public Commands.CmdSetDeviceMask? CmdSetDeviceMask;

        public Commands.GetDeviceGroupPresentCapabilitiesKHR? GetDeviceGroupPresentCapabilitiesKHR;

        public Commands.GetDeviceGroupSurfacePresentModesKHR? GetDeviceGroupSurfacePresentModesKHR;

        public Commands.AcquireNextImage2KHR? AcquireNextImage2KHR;

        public Commands.CmdDispatchBase? CmdDispatchBase;

        public Commands.CreateDescriptorUpdateTemplate? CreateDescriptorUpdateTemplate;

        public Commands.DestroyDescriptorUpdateTemplate? DestroyDescriptorUpdateTemplate;

        public Commands.UpdateDescriptorSetWithTemplate? UpdateDescriptorSetWithTemplate;

        public Commands.CmdPushDescriptorSetWithTemplateKHR? CmdPushDescriptorSetWithTemplateKHR;

        public Commands.SetHdrMetadataEXT? SetHdrMetadataEXT;

        public Commands.GetSwapchainStatusKHR? GetSwapchainStatusKHR;

        public Commands.GetRefreshCycleDurationGOOGLE? GetRefreshCycleDurationGOOGLE;

        public Commands.GetPastPresentationTimingGOOGLE? GetPastPresentationTimingGOOGLE;

        public Commands.CmdSetViewportWScalingNV? CmdSetViewportWScalingNV;

        public Commands.CmdSetDiscardRectangleEXT? CmdSetDiscardRectangleEXT;

        public Commands.CmdSetSampleLocationsEXT? CmdSetSampleLocationsEXT;

        public Commands.GetBufferMemoryRequirements2? GetBufferMemoryRequirements2;

        public Commands.GetImageMemoryRequirements2? GetImageMemoryRequirements2;

        public Commands.GetImageSparseMemoryRequirements2? GetImageSparseMemoryRequirements2;

        public Commands.CreateSamplerYcbcrConversion? CreateSamplerYcbcrConversion;

        public Commands.DestroySamplerYcbcrConversion? DestroySamplerYcbcrConversion;

        public Commands.GetDeviceQueue2? GetDeviceQueue2;

        public Commands.CreateValidationCacheEXT? CreateValidationCacheEXT;

        public Commands.DestroyValidationCacheEXT? DestroyValidationCacheEXT;

        public Commands.GetValidationCacheDataEXT? GetValidationCacheDataEXT;

        public Commands.MergeValidationCachesEXT? MergeValidationCachesEXT;

        public Commands.GetDescriptorSetLayoutSupport? GetDescriptorSetLayoutSupport;

        public Commands.GetSwapchainGrallocUsageANDROID? GetSwapchainGrallocUsageANDROID;

        public Commands.GetSwapchainGrallocUsage2ANDROID? GetSwapchainGrallocUsage2ANDROID;

        public Commands.AcquireImageANDROID? AcquireImageANDROID;

        public Commands.QueueSignalReleaseImageANDROID? QueueSignalReleaseImageANDROID;

        public Commands.GetShaderInfoAMD? GetShaderInfoAMD;

        public Commands.SetLocalDimmingAMD? SetLocalDimmingAMD;

        public Commands.GetCalibratedTimestampsEXT? GetCalibratedTimestampsEXT;

        public Commands.SetDebugUtilsObjectNameEXT? SetDebugUtilsObjectNameEXT;

        public Commands.SetDebugUtilsObjectTagEXT? SetDebugUtilsObjectTagEXT;

        public Commands.QueueBeginDebugUtilsLabelEXT? QueueBeginDebugUtilsLabelEXT;

        public Commands.QueueEndDebugUtilsLabelEXT? QueueEndDebugUtilsLabelEXT;

        public Commands.QueueInsertDebugUtilsLabelEXT? QueueInsertDebugUtilsLabelEXT;

        public Commands.CmdBeginDebugUtilsLabelEXT? CmdBeginDebugUtilsLabelEXT;

        public Commands.CmdEndDebugUtilsLabelEXT? CmdEndDebugUtilsLabelEXT;

        public Commands.CmdInsertDebugUtilsLabelEXT? CmdInsertDebugUtilsLabelEXT;

        public Commands.GetMemoryHostPointerPropertiesEXT? GetMemoryHostPointerPropertiesEXT;

        public Commands.CmdWriteBufferMarkerAMD? CmdWriteBufferMarkerAMD;

        public Commands.CreateRenderPass2? CreateRenderPass2;

        public Commands.CmdBeginRenderPass2? CmdBeginRenderPass2;

        public Commands.CmdNextSubpass2? CmdNextSubpass2;

        public Commands.CmdEndRenderPass2? CmdEndRenderPass2;

        public Commands.GetSemaphoreCounterValue? GetSemaphoreCounterValue;

        public Commands.WaitSemaphores? WaitSemaphores;

        public Commands.SignalSemaphore? SignalSemaphore;

        public Commands.GetAndroidHardwareBufferPropertiesANDROID? GetAndroidHardwareBufferPropertiesANDROID;

        public Commands.GetMemoryAndroidHardwareBufferANDROID? GetMemoryAndroidHardwareBufferANDROID;

        public Commands.CmdDrawIndirectCount? CmdDrawIndirectCount;

        public Commands.CmdDrawIndexedIndirectCount? CmdDrawIndexedIndirectCount;

        public Commands.CmdSetCheckpointNV? CmdSetCheckpointNV;

        public Commands.GetQueueCheckpointDataNV? GetQueueCheckpointDataNV;

        public Commands.CmdBindTransformFeedbackBuffersEXT? CmdBindTransformFeedbackBuffersEXT;

        public Commands.CmdBeginTransformFeedbackEXT? CmdBeginTransformFeedbackEXT;

        public Commands.CmdEndTransformFeedbackEXT? CmdEndTransformFeedbackEXT;

        public Commands.CmdBeginQueryIndexedEXT? CmdBeginQueryIndexedEXT;

        public Commands.CmdEndQueryIndexedEXT? CmdEndQueryIndexedEXT;

        public Commands.CmdDrawIndirectByteCountEXT? CmdDrawIndirectByteCountEXT;

        public Commands.CmdSetExclusiveScissorNV? CmdSetExclusiveScissorNV;

        public Commands.CmdBindShadingRateImageNV? CmdBindShadingRateImageNV;

        public Commands.CmdSetViewportShadingRatePaletteNV? CmdSetViewportShadingRatePaletteNV;

        public Commands.CmdSetCoarseSampleOrderNV? CmdSetCoarseSampleOrderNV;

        public Commands.CmdDrawMeshTasksNV? CmdDrawMeshTasksNV;

        public Commands.CmdDrawMeshTasksIndirectNV? CmdDrawMeshTasksIndirectNV;

        public Commands.CmdDrawMeshTasksIndirectCountNV? CmdDrawMeshTasksIndirectCountNV;

        public Commands.CompileDeferredNV? CompileDeferredNV;

        public Commands.CreateAccelerationStructureNV? CreateAccelerationStructureNV;

        public Commands.DestroyAccelerationStructureKHR? DestroyAccelerationStructureKHR;

        public Commands.GetAccelerationStructureMemoryRequirementsKHR? GetAccelerationStructureMemoryRequirementsKHR;

        public Commands.GetAccelerationStructureMemoryRequirementsNV? GetAccelerationStructureMemoryRequirementsNV;

        public Commands.BindAccelerationStructureMemoryKHR? BindAccelerationStructureMemoryKHR;

        public Commands.CmdCopyAccelerationStructureNV? CmdCopyAccelerationStructureNV;

        public Commands.CmdCopyAccelerationStructureKHR? CmdCopyAccelerationStructureKHR;

        public Commands.CopyAccelerationStructureKHR? CopyAccelerationStructureKHR;

        public Commands.CmdCopyAccelerationStructureToMemoryKHR? CmdCopyAccelerationStructureToMemoryKHR;

        public Commands.CopyAccelerationStructureToMemoryKHR? CopyAccelerationStructureToMemoryKHR;

        public Commands.CmdCopyMemoryToAccelerationStructureKHR? CmdCopyMemoryToAccelerationStructureKHR;

        public Commands.CopyMemoryToAccelerationStructureKHR? CopyMemoryToAccelerationStructureKHR;

        public Commands.CmdWriteAccelerationStructuresPropertiesKHR? CmdWriteAccelerationStructuresPropertiesKHR;

        public Commands.CmdBuildAccelerationStructureNV? CmdBuildAccelerationStructureNV;

        public Commands.WriteAccelerationStructuresPropertiesKHR? WriteAccelerationStructuresPropertiesKHR;

        public Commands.CmdTraceRaysKHR? CmdTraceRaysKHR;

        public Commands.CmdTraceRaysNV? CmdTraceRaysNV;

        public Commands.GetRayTracingShaderGroupHandlesKHR? GetRayTracingShaderGroupHandlesKHR;

        public Commands.GetRayTracingCaptureReplayShaderGroupHandlesKHR? GetRayTracingCaptureReplayShaderGroupHandlesKHR;

        public Commands.GetAccelerationStructureHandleNV? GetAccelerationStructureHandleNV;

        public Commands.CreateRayTracingPipelinesNV? CreateRayTracingPipelinesNV;

        public Commands.CreateRayTracingPipelinesKHR? CreateRayTracingPipelinesKHR;

        public Commands.CmdTraceRaysIndirectKHR? CmdTraceRaysIndirectKHR;

        public Commands.GetDeviceAccelerationStructureCompatibilityKHR? GetDeviceAccelerationStructureCompatibilityKHR;

        public Commands.GetImageViewHandleNVX? GetImageViewHandleNVX;

        public Commands.GetImageViewAddressNVX? GetImageViewAddressNVX;

        public Commands.GetDeviceGroupSurfacePresentModes2EXT? GetDeviceGroupSurfacePresentModes2EXT;

        public Commands.AcquireFullScreenExclusiveModeEXT? AcquireFullScreenExclusiveModeEXT;

        public Commands.ReleaseFullScreenExclusiveModeEXT? ReleaseFullScreenExclusiveModeEXT;

        public Commands.AcquireProfilingLockKHR? AcquireProfilingLockKHR;

        public Commands.ReleaseProfilingLockKHR? ReleaseProfilingLockKHR;

        public Commands.GetImageDrmFormatModifierPropertiesEXT? GetImageDrmFormatModifierPropertiesEXT;

        public Commands.GetBufferOpaqueCaptureAddress? GetBufferOpaqueCaptureAddress;

        public Commands.GetBufferDeviceAddress? GetBufferDeviceAddress;

        public Commands.InitializePerformanceApiINTEL? InitializePerformanceApiINTEL;

        public Commands.UninitializePerformanceApiINTEL? UninitializePerformanceApiINTEL;

        public Commands.CmdSetPerformanceMarkerINTEL? CmdSetPerformanceMarkerINTEL;

        public Commands.CmdSetPerformanceStreamMarkerINTEL? CmdSetPerformanceStreamMarkerINTEL;

        public Commands.CmdSetPerformanceOverrideINTEL? CmdSetPerformanceOverrideINTEL;

        public Commands.AcquirePerformanceConfigurationINTEL? AcquirePerformanceConfigurationINTEL;

        public Commands.ReleasePerformanceConfigurationINTEL? ReleasePerformanceConfigurationINTEL;

        public Commands.QueueSetPerformanceConfigurationINTEL? QueueSetPerformanceConfigurationINTEL;

        public Commands.GetPerformanceParameterINTEL? GetPerformanceParameterINTEL;

        public Commands.GetDeviceMemoryOpaqueCaptureAddress? GetDeviceMemoryOpaqueCaptureAddress;

        public Commands.GetPipelineExecutablePropertiesKHR? GetPipelineExecutablePropertiesKHR;

        public Commands.GetPipelineExecutableStatisticsKHR? GetPipelineExecutableStatisticsKHR;

        public Commands.GetPipelineExecutableInternalRepresentationsKHR? GetPipelineExecutableInternalRepresentationsKHR;

        public Commands.CmdSetLineStippleEXT? CmdSetLineStippleEXT;

        public Commands.CreateAccelerationStructureKHR? CreateAccelerationStructureKHR;

        public Commands.CmdBuildAccelerationStructureKHR? CmdBuildAccelerationStructureKHR;

        public Commands.CmdBuildAccelerationStructureIndirectKHR? CmdBuildAccelerationStructureIndirectKHR;

        public Commands.BuildAccelerationStructureKHR? BuildAccelerationStructureKHR;

        public Commands.GetAccelerationStructureDeviceAddressKHR? GetAccelerationStructureDeviceAddressKHR;

        public Commands.CreateDeferredOperationKHR? CreateDeferredOperationKHR;

        public Commands.DestroyDeferredOperationKHR? DestroyDeferredOperationKHR;

        public Commands.GetDeferredOperationMaxConcurrencyKHR? GetDeferredOperationMaxConcurrencyKHR;

        public Commands.GetDeferredOperationResultKHR? GetDeferredOperationResultKHR;

        public Commands.DeferredOperationJoinKHR? DeferredOperationJoinKHR;

        public Commands.CmdSetCullModeEXT? CmdSetCullModeEXT;

        public Commands.CmdSetFrontFaceEXT? CmdSetFrontFaceEXT;

        public Commands.CmdSetPrimitiveTopologyEXT? CmdSetPrimitiveTopologyEXT;

        public Commands.CmdSetViewportWithCountEXT? CmdSetViewportWithCountEXT;

        public Commands.CmdSetScissorWithCountEXT? CmdSetScissorWithCountEXT;

        public Commands.CmdBindVertexBuffers2EXT? CmdBindVertexBuffers2EXT;

        public Commands.CmdSetDepthTestEnableEXT? CmdSetDepthTestEnableEXT;

        public Commands.CmdSetDepthWriteEnableEXT? CmdSetDepthWriteEnableEXT;

        public Commands.CmdSetDepthCompareOpEXT? CmdSetDepthCompareOpEXT;

        public Commands.CmdSetDepthBoundsTestEnableEXT? CmdSetDepthBoundsTestEnableEXT;

        public Commands.CmdSetStencilTestEnableEXT? CmdSetStencilTestEnableEXT;

        public Commands.CmdSetStencilOpEXT? CmdSetStencilOpEXT;

        public Commands.CreatePrivateDataSlotEXT? CreatePrivateDataSlotEXT;

        public Commands.DestroyPrivateDataSlotEXT? DestroyPrivateDataSlotEXT;

        public Commands.SetPrivateDataEXT? SetPrivateDataEXT;

        public Commands.GetPrivateDataEXT? GetPrivateDataEXT;
    }
}