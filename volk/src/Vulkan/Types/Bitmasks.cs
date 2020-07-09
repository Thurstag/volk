// Copyright 2020-2020 Volk Project
// Licensed under Apache License 2.0 or any later version
// Refer to the LICENSE.md file included.

using FlagsAttribute = System.FlagsAttribute;
using SampleMask = System.UInt32;
using Bool32 = System.UInt32;
using Flags = System.UInt32;
using DeviceSize = System.UInt64;
using DeviceAddress = System.UInt64;

namespace Volk.Vulkan.Types {
	[FlagsAttribute]
	public enum FramebufferCreateFlags : Flags {
		FramebufferCreateImagelessBit = 1 << 0,
		FramebufferCreateImagelessBitKhr = FramebufferCreateImagelessBit
	}

	[FlagsAttribute]
	public enum QueryPoolCreateFlags : Flags {

	}

	[FlagsAttribute]
	public enum RenderPassCreateFlags : Flags {
		RenderPassCreateReserved0BitKhr = 1 << 0,
		RenderPassCreateTransformBitQcom = 1 << 1
	}

	[FlagsAttribute]
	public enum SamplerCreateFlags : Flags {
		SamplerCreateSubsampledBitExt = 1 << 0,
		SamplerCreateSubsampledCoarseReconstructionBitExt = 1 << 1
	}

	[FlagsAttribute]
	public enum PipelineLayoutCreateFlags : Flags {

	}

	[FlagsAttribute]
	public enum PipelineCacheCreateFlags : Flags {
		PipelineCacheCreateExternallySynchronizedBitExt = 1 << 0
	}

	[FlagsAttribute]
	public enum PipelineDepthStencilStateCreateFlags : Flags {

	}

	[FlagsAttribute]
	public enum PipelineDynamicStateCreateFlags : Flags {

	}

	[FlagsAttribute]
	public enum PipelineColorBlendStateCreateFlags : Flags {

	}

	[FlagsAttribute]
	public enum PipelineMultisampleStateCreateFlags : Flags {

	}

	[FlagsAttribute]
	public enum PipelineRasterizationStateCreateFlags : Flags {

	}

	[FlagsAttribute]
	public enum PipelineViewportStateCreateFlags : Flags {

	}

	[FlagsAttribute]
	public enum PipelineTessellationStateCreateFlags : Flags {

	}

	[FlagsAttribute]
	public enum PipelineInputAssemblyStateCreateFlags : Flags {

	}

	[FlagsAttribute]
	public enum PipelineVertexInputStateCreateFlags : Flags {

	}

	[FlagsAttribute]
	public enum PipelineShaderStageCreateFlags : Flags {
		PipelineShaderStageCreateReserved2BitNv = 1 << 2,
		PipelineShaderStageCreateAllowVaryingSubgroupSizeBitExt = 1 << 0,
		PipelineShaderStageCreateRequireFullSubgroupsBitExt = 1 << 1,
		PipelineShaderStageCreateReserved3BitKhr = 1 << 3
	}

	[FlagsAttribute]
	public enum DescriptorSetLayoutCreateFlags : Flags {
		DescriptorSetLayoutCreateUpdateAfterBindPoolBit = 1 << 1,
		DescriptorSetLayoutCreatePushDescriptorBitKhr = 1 << 0,
		DescriptorSetLayoutCreateUpdateAfterBindPoolBitExt = DescriptorSetLayoutCreateUpdateAfterBindPoolBit
	}

	[FlagsAttribute]
	public enum BufferViewCreateFlags : Flags {

	}

	[FlagsAttribute]
	public enum InstanceCreateFlags : Flags {

	}

	[FlagsAttribute]
	public enum DeviceCreateFlags : Flags {

	}

	[FlagsAttribute]
	public enum DeviceQueueCreateFlags : Flags {
		DeviceQueueCreateProtectedBit = 1 << 0
	}

	[FlagsAttribute]
	public enum QueueFlags : Flags {
		QueueGraphicsBit = 1 << 0,
		QueueComputeBit = 1 << 1,
		QueueTransferBit = 1 << 2,
		QueueSparseBindingBit = 1 << 3,
		QueueProtectedBit = 1 << 4,
		QueueReserved6BitKhr = 1 << 6,
		QueueReserved5BitKhr = 1 << 5
	}

	[FlagsAttribute]
	public enum MemoryPropertyFlags : Flags {
		MemoryPropertyDeviceLocalBit = 1 << 0,
		MemoryPropertyHostVisibleBit = 1 << 1,
		MemoryPropertyHostCoherentBit = 1 << 2,
		MemoryPropertyHostCachedBit = 1 << 3,
		MemoryPropertyLazilyAllocatedBit = 1 << 4,
		MemoryPropertyProtectedBit = 1 << 5,
		MemoryPropertyDeviceCoherentBitAmd = 1 << 6,
		MemoryPropertyDeviceUncachedBitAmd = 1 << 7
	}

	[FlagsAttribute]
	public enum MemoryHeapFlags : Flags {
		MemoryHeapDeviceLocalBit = 1 << 0,
		MemoryHeapMultiInstanceBit = 1 << 1,
		MemoryHeapMultiInstanceBitKhr = MemoryHeapMultiInstanceBit,
		MemoryHeapReserved2BitKhr = 1 << 2
	}

	[FlagsAttribute]
	public enum AccessFlags : Flags {
		AccessIndirectCommandReadBit = 1 << 0,
		AccessIndexReadBit = 1 << 1,
		AccessVertexAttributeReadBit = 1 << 2,
		AccessUniformReadBit = 1 << 3,
		AccessInputAttachmentReadBit = 1 << 4,
		AccessShaderReadBit = 1 << 5,
		AccessShaderWriteBit = 1 << 6,
		AccessColorAttachmentReadBit = 1 << 7,
		AccessColorAttachmentWriteBit = 1 << 8,
		AccessDepthStencilAttachmentReadBit = 1 << 9,
		AccessDepthStencilAttachmentWriteBit = 1 << 10,
		AccessTransferReadBit = 1 << 11,
		AccessTransferWriteBit = 1 << 12,
		AccessHostReadBit = 1 << 13,
		AccessHostWriteBit = 1 << 14,
		AccessMemoryReadBit = 1 << 15,
		AccessMemoryWriteBit = 1 << 16,
		AccessReserved30BitKhr = 1 << 30,
		AccessReserved28BitKhr = 1 << 28,
		AccessReserved29BitKhr = 1 << 29,
		AccessTransformFeedbackWriteBitExt = 1 << 25,
		AccessTransformFeedbackCounterReadBitExt = 1 << 26,
		AccessTransformFeedbackCounterWriteBitExt = 1 << 27,
		AccessConditionalRenderingReadBitExt = 1 << 20,
		AccessColorAttachmentReadNoncoherentBitExt = 1 << 19,
		AccessAccelerationStructureReadBitKhr = 1 << 21,
		AccessAccelerationStructureWriteBitKhr = 1 << 22,
		AccessShadingRateImageReadBitNv = 1 << 23,
		AccessAccelerationStructureReadBitNv = AccessAccelerationStructureReadBitKhr,
		AccessAccelerationStructureWriteBitNv = AccessAccelerationStructureWriteBitKhr,
		AccessFragmentDensityMapReadBitExt = 1 << 24,
		AccessCommandPreprocessReadBitNv = 1 << 17,
		AccessCommandPreprocessWriteBitNv = 1 << 18
	}

	[FlagsAttribute]
	public enum BufferUsageFlags : Flags {
		BufferUsageTransferSrcBit = 1 << 0,
		BufferUsageTransferDstBit = 1 << 1,
		BufferUsageUniformTexelBufferBit = 1 << 2,
		BufferUsageStorageTexelBufferBit = 1 << 3,
		BufferUsageUniformBufferBit = 1 << 4,
		BufferUsageStorageBufferBit = 1 << 5,
		BufferUsageIndexBufferBit = 1 << 6,
		BufferUsageVertexBufferBit = 1 << 7,
		BufferUsageIndirectBufferBit = 1 << 8,
		BufferUsageShaderDeviceAddressBit = 1 << 17,
		BufferUsageReserved15BitKhr = 1 << 15,
		BufferUsageReserved16BitKhr = 1 << 16,
		BufferUsageReserved13BitKhr = 1 << 13,
		BufferUsageReserved14BitKhr = 1 << 14,
		BufferUsageTransformFeedbackBufferBitExt = 1 << 11,
		BufferUsageTransformFeedbackCounterBufferBitExt = 1 << 12,
		BufferUsageConditionalRenderingBitExt = 1 << 9,
		BufferUsageRayTracingBitKhr = 1 << 10,
		BufferUsageRayTracingBitNv = BufferUsageRayTracingBitKhr,
		BufferUsageReserved19BitKhr = 1 << 19,
		BufferUsageReserved20BitKhr = 1 << 20,
		BufferUsageReserved18BitQcom = 1 << 18,
		BufferUsageShaderDeviceAddressBitExt = BufferUsageShaderDeviceAddressBit,
		BufferUsageShaderDeviceAddressBitKhr = BufferUsageShaderDeviceAddressBit
	}

	[FlagsAttribute]
	public enum BufferCreateFlags : Flags {
		BufferCreateSparseBindingBit = 1 << 0,
		BufferCreateSparseResidencyBit = 1 << 1,
		BufferCreateSparseAliasedBit = 1 << 2,
		BufferCreateProtectedBit = 1 << 3,
		BufferCreateDeviceAddressCaptureReplayBit = 1 << 4,
		BufferCreateDeviceAddressCaptureReplayBitExt = BufferCreateDeviceAddressCaptureReplayBit,
		BufferCreateDeviceAddressCaptureReplayBitKhr = BufferCreateDeviceAddressCaptureReplayBit
	}

	[FlagsAttribute]
	public enum ShaderStageFlags : Flags {
		ShaderStageVertexBit = 1 << 0,
		ShaderStageTessellationControlBit = 1 << 1,
		ShaderStageTessellationEvaluationBit = 1 << 2,
		ShaderStageGeometryBit = 1 << 3,
		ShaderStageFragmentBit = 1 << 4,
		ShaderStageComputeBit = 1 << 5,
		ShaderStageAllGraphics = 0x0000001F,
		ShaderStageAll = 0x7FFFFFFF,
		ShaderStageRaygenBitKhr = 1 << 8,
		ShaderStageAnyHitBitKhr = 1 << 9,
		ShaderStageClosestHitBitKhr = 1 << 10,
		ShaderStageMissBitKhr = 1 << 11,
		ShaderStageIntersectionBitKhr = 1 << 12,
		ShaderStageCallableBitKhr = 1 << 13,
		ShaderStageRaygenBitNv = ShaderStageRaygenBitKhr,
		ShaderStageAnyHitBitNv = ShaderStageAnyHitBitKhr,
		ShaderStageClosestHitBitNv = ShaderStageClosestHitBitKhr,
		ShaderStageMissBitNv = ShaderStageMissBitKhr,
		ShaderStageIntersectionBitNv = ShaderStageIntersectionBitKhr,
		ShaderStageCallableBitNv = ShaderStageCallableBitKhr,
		ShaderStageTaskBitNv = 1 << 6,
		ShaderStageMeshBitNv = 1 << 7
	}

	[FlagsAttribute]
	public enum ImageUsageFlags : Flags {
		ImageUsageTransferSrcBit = 1 << 0,
		ImageUsageTransferDstBit = 1 << 1,
		ImageUsageSampledBit = 1 << 2,
		ImageUsageStorageBit = 1 << 3,
		ImageUsageColorAttachmentBit = 1 << 4,
		ImageUsageDepthStencilAttachmentBit = 1 << 5,
		ImageUsageTransientAttachmentBit = 1 << 6,
		ImageUsageInputAttachmentBit = 1 << 7,
		ImageUsageReserved13BitKhr = 1 << 13,
		ImageUsageReserved14BitKhr = 1 << 14,
		ImageUsageReserved15BitKhr = 1 << 15,
		ImageUsageReserved10BitKhr = 1 << 10,
		ImageUsageReserved11BitKhr = 1 << 11,
		ImageUsageReserved12BitKhr = 1 << 12,
		ImageUsageShadingRateImageBitNv = 1 << 8,
		ImageUsageReserved16BitQcom = 1 << 16,
		ImageUsageReserved17BitQcom = 1 << 17,
		ImageUsageFragmentDensityMapBitExt = 1 << 9
	}

	[FlagsAttribute]
	public enum ImageCreateFlags : Flags {
		ImageCreateSparseBindingBit = 1 << 0,
		ImageCreateSparseResidencyBit = 1 << 1,
		ImageCreateSparseAliasedBit = 1 << 2,
		ImageCreateMutableFormatBit = 1 << 3,
		ImageCreateCubeCompatibleBit = 1 << 4,
		ImageCreateAliasBit = 1 << 10,
		ImageCreateSplitInstanceBindRegionsBit = 1 << 6,
		ImageCreate2dArrayCompatibleBit = 1 << 5,
		ImageCreateBlockTexelViewCompatibleBit = 1 << 7,
		ImageCreateExtendedUsageBit = 1 << 8,
		ImageCreateProtectedBit = 1 << 11,
		ImageCreateDisjointBit = 1 << 9,
		ImageCreateCornerSampledBitNv = 1 << 13,
		ImageCreateSplitInstanceBindRegionsBitKhr = ImageCreateSplitInstanceBindRegionsBit,
		ImageCreate2dArrayCompatibleBitKhr = ImageCreate2dArrayCompatibleBit,
		ImageCreateBlockTexelViewCompatibleBitKhr = ImageCreateBlockTexelViewCompatibleBit,
		ImageCreateExtendedUsageBitKhr = ImageCreateExtendedUsageBit,
		ImageCreateSampleLocationsCompatibleDepthBitExt = 1 << 12,
		ImageCreateDisjointBitKhr = ImageCreateDisjointBit,
		ImageCreateAliasBitKhr = ImageCreateAliasBit,
		ImageCreateSubsampledBitExt = 1 << 14
	}

	[FlagsAttribute]
	public enum ImageViewCreateFlags : Flags {
		ImageViewCreateFragmentDensityMapDynamicBitExt = 1 << 0,
		ImageViewCreateFragmentDensityMapDeferredBitExt = 1 << 1
	}

	[FlagsAttribute]
	public enum PipelineCreateFlags : Flags {
		PipelineCreateDisableOptimizationBit = 1 << 0,
		PipelineCreateAllowDerivativesBit = 1 << 1,
		PipelineCreateDerivativeBit = 1 << 2,
		PipelineCreateViewIndexFromDeviceIndexBit = 1 << 3,
		PipelineCreateDispatchBaseBit = 1 << 4,
		PipelineCreateDispatchBase = PipelineCreateDispatchBaseBit,
		PipelineCreateViewIndexFromDeviceIndexBitKhr = PipelineCreateViewIndexFromDeviceIndexBit,
		PipelineCreateDispatchBaseKhr = PipelineCreateDispatchBase,
		PipelineCreateRayTracingNoNullAnyHitShadersBitKhr = 1 << 14,
		PipelineCreateRayTracingNoNullClosestHitShadersBitKhr = 1 << 15,
		PipelineCreateRayTracingNoNullMissShadersBitKhr = 1 << 16,
		PipelineCreateRayTracingNoNullIntersectionShadersBitKhr = 1 << 17,
		PipelineCreateRayTracingSkipTrianglesBitKhr = 1 << 12,
		PipelineCreateRayTracingSkipAabbsBitKhr = 1 << 13,
		PipelineCreateDeferCompileBitNv = 1 << 5,
		PipelineCreateReserved19BitKhr = 1 << 19,
		PipelineCreateCaptureStatisticsBitKhr = 1 << 6,
		PipelineCreateCaptureInternalRepresentationsBitKhr = 1 << 7,
		PipelineCreateIndirectBindableBitNv = 1 << 18,
		PipelineCreateLibraryBitKhr = 1 << 11,
		PipelineCreateFailOnPipelineCompileRequiredBitExt = 1 << 8,
		PipelineCreateEarlyReturnOnFailureBitExt = 1 << 9
	}

	[FlagsAttribute]
	public enum ColorComponentFlags : Flags {
		ColorComponentRBit = 1 << 0,
		ColorComponentGBit = 1 << 1,
		ColorComponentBBit = 1 << 2,
		ColorComponentABit = 1 << 3
	}

	[FlagsAttribute]
	public enum FenceCreateFlags : Flags {
		FenceCreateSignaledBit = 1 << 0
	}

	[FlagsAttribute]
	public enum SemaphoreCreateFlags : Flags {

	}

	[FlagsAttribute]
	public enum FormatFeatureFlags : Flags {
		FormatFeatureSampledImageBit = 1 << 0,
		FormatFeatureStorageImageBit = 1 << 1,
		FormatFeatureStorageImageAtomicBit = 1 << 2,
		FormatFeatureUniformTexelBufferBit = 1 << 3,
		FormatFeatureStorageTexelBufferBit = 1 << 4,
		FormatFeatureStorageTexelBufferAtomicBit = 1 << 5,
		FormatFeatureVertexBufferBit = 1 << 6,
		FormatFeatureColorAttachmentBit = 1 << 7,
		FormatFeatureColorAttachmentBlendBit = 1 << 8,
		FormatFeatureDepthStencilAttachmentBit = 1 << 9,
		FormatFeatureBlitSrcBit = 1 << 10,
		FormatFeatureBlitDstBit = 1 << 11,
		FormatFeatureSampledImageFilterLinearBit = 1 << 12,
		FormatFeatureTransferSrcBit = 1 << 14,
		FormatFeatureTransferDstBit = 1 << 15,
		FormatFeatureMidpointChromaSamplesBit = 1 << 17,
		FormatFeatureSampledImageYcbcrConversionLinearFilterBit = 1 << 18,
		FormatFeatureSampledImageYcbcrConversionSeparateReconstructionFilterBit = 1 << 19,
		FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitBit = 1 << 20,
		FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitForceableBit = 1 << 21,
		FormatFeatureDisjointBit = 1 << 22,
		FormatFeatureCositedChromaSamplesBit = 1 << 23,
		FormatFeatureSampledImageFilterMinmaxBit = 1 << 16,
		FormatFeatureSampledImageFilterCubicBitImg = 1 << 13,
		FormatFeatureReserved27BitKhr = 1 << 27,
		FormatFeatureReserved28BitKhr = 1 << 28,
		FormatFeatureReserved25BitKhr = 1 << 25,
		FormatFeatureReserved26BitKhr = 1 << 26,
		FormatFeatureTransferSrcBitKhr = FormatFeatureTransferSrcBit,
		FormatFeatureTransferDstBitKhr = FormatFeatureTransferDstBit,
		FormatFeatureSampledImageFilterMinmaxBitExt = FormatFeatureSampledImageFilterMinmaxBit,
		FormatFeatureAccelerationStructureVertexBufferBitKhr = 1 << 29,
		FormatFeatureMidpointChromaSamplesBitKhr = FormatFeatureMidpointChromaSamplesBit,
		FormatFeatureSampledImageYcbcrConversionLinearFilterBitKhr = FormatFeatureSampledImageYcbcrConversionLinearFilterBit,
		FormatFeatureSampledImageYcbcrConversionSeparateReconstructionFilterBitKhr = FormatFeatureSampledImageYcbcrConversionSeparateReconstructionFilterBit,
		FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitBitKhr = FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitBit,
		FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitForceableBitKhr = FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitForceableBit,
		FormatFeatureDisjointBitKhr = FormatFeatureDisjointBit,
		FormatFeatureCositedChromaSamplesBitKhr = FormatFeatureCositedChromaSamplesBit,
		FormatFeatureSampledImageFilterCubicBitExt = FormatFeatureSampledImageFilterCubicBitImg,
		FormatFeatureFragmentDensityMapBitExt = 1 << 24,
		FormatFeatureAmdReserved30Bit = 1 << 30
	}

	[FlagsAttribute]
	public enum QueryControlFlags : Flags {
		QueryControlPreciseBit = 1 << 0
	}

	[FlagsAttribute]
	public enum QueryResultFlags : Flags {
		QueryResult64Bit = 1 << 0,
		QueryResultWaitBit = 1 << 1,
		QueryResultWithAvailabilityBit = 1 << 2,
		QueryResultPartialBit = 1 << 3
	}

	[FlagsAttribute]
	public enum ShaderModuleCreateFlags : Flags {
		ShaderModuleCreateReserved0BitNv = 1 << 0
	}

	[FlagsAttribute]
	public enum EventCreateFlags : Flags {

	}

	[FlagsAttribute]
	public enum CommandPoolCreateFlags : Flags {
		CommandPoolCreateTransientBit = 1 << 0,
		CommandPoolCreateResetCommandBufferBit = 1 << 1,
		CommandPoolCreateProtectedBit = 1 << 2
	}

	[FlagsAttribute]
	public enum CommandPoolResetFlags : Flags {
		CommandPoolResetReleaseResourcesBit = 1 << 0
	}

	[FlagsAttribute]
	public enum CommandBufferResetFlags : Flags {
		CommandBufferResetReleaseResourcesBit = 1 << 0
	}

	[FlagsAttribute]
	public enum CommandBufferUsageFlags : Flags {
		CommandBufferUsageOneTimeSubmitBit = 1 << 0,
		CommandBufferUsageRenderPassContinueBit = 1 << 1,
		CommandBufferUsageSimultaneousUseBit = 1 << 2
	}

	[FlagsAttribute]
	public enum QueryPipelineStatisticFlags : Flags {
		QueryPipelineStatisticInputAssemblyVerticesBit = 1 << 0,
		QueryPipelineStatisticInputAssemblyPrimitivesBit = 1 << 1,
		QueryPipelineStatisticVertexShaderInvocationsBit = 1 << 2,
		QueryPipelineStatisticGeometryShaderInvocationsBit = 1 << 3,
		QueryPipelineStatisticGeometryShaderPrimitivesBit = 1 << 4,
		QueryPipelineStatisticClippingInvocationsBit = 1 << 5,
		QueryPipelineStatisticClippingPrimitivesBit = 1 << 6,
		QueryPipelineStatisticFragmentShaderInvocationsBit = 1 << 7,
		QueryPipelineStatisticTessellationControlShaderPatchesBit = 1 << 8,
		QueryPipelineStatisticTessellationEvaluationShaderInvocationsBit = 1 << 9,
		QueryPipelineStatisticComputeShaderInvocationsBit = 1 << 10
	}

	[FlagsAttribute]
	public enum MemoryMapFlags : Flags {

	}

	[FlagsAttribute]
	public enum ImageAspectFlags : Flags {
		ImageAspectColorBit = 1 << 0,
		ImageAspectDepthBit = 1 << 1,
		ImageAspectStencilBit = 1 << 2,
		ImageAspectMetadataBit = 1 << 3,
		ImageAspectPlane0Bit = 1 << 4,
		ImageAspectPlane1Bit = 1 << 5,
		ImageAspectPlane2Bit = 1 << 6,
		ImageAspectPlane0BitKhr = ImageAspectPlane0Bit,
		ImageAspectPlane1BitKhr = ImageAspectPlane1Bit,
		ImageAspectPlane2BitKhr = ImageAspectPlane2Bit,
		ImageAspectMemoryPlane0BitExt = 1 << 7,
		ImageAspectMemoryPlane1BitExt = 1 << 8,
		ImageAspectMemoryPlane2BitExt = 1 << 9,
		ImageAspectMemoryPlane3BitExt = 1 << 10
	}

	[FlagsAttribute]
	public enum SparseMemoryBindFlags : Flags {
		SparseMemoryBindMetadataBit = 1 << 0
	}

	[FlagsAttribute]
	public enum SparseImageFormatFlags : Flags {
		SparseImageFormatSingleMiptailBit = 1 << 0,
		SparseImageFormatAlignedMipSizeBit = 1 << 1,
		SparseImageFormatNonstandardBlockSizeBit = 1 << 2
	}

	[FlagsAttribute]
	public enum SubpassDescriptionFlags : Flags {
		SubpassDescriptionPerViewAttributesBitNvx = 1 << 0,
		SubpassDescriptionPerViewPositionXOnlyBitNvx = 1 << 1,
		SubpassDescriptionFragmentRegionBitQcom = 1 << 2,
		SubpassDescriptionShaderResolveBitQcom = 1 << 3
	}

	[FlagsAttribute]
	public enum PipelineStageFlags : Flags {
		PipelineStageTopOfPipeBit = 1 << 0,
		PipelineStageDrawIndirectBit = 1 << 1,
		PipelineStageVertexInputBit = 1 << 2,
		PipelineStageVertexShaderBit = 1 << 3,
		PipelineStageTessellationControlShaderBit = 1 << 4,
		PipelineStageTessellationEvaluationShaderBit = 1 << 5,
		PipelineStageGeometryShaderBit = 1 << 6,
		PipelineStageFragmentShaderBit = 1 << 7,
		PipelineStageEarlyFragmentTestsBit = 1 << 8,
		PipelineStageLateFragmentTestsBit = 1 << 9,
		PipelineStageColorAttachmentOutputBit = 1 << 10,
		PipelineStageComputeShaderBit = 1 << 11,
		PipelineStageTransferBit = 1 << 12,
		PipelineStageBottomOfPipeBit = 1 << 13,
		PipelineStageHostBit = 1 << 14,
		PipelineStageAllGraphicsBit = 1 << 15,
		PipelineStageAllCommandsBit = 1 << 16,
		PipelineStageReserved27BitKhr = 1 << 27,
		PipelineStageReserved26BitKhr = 1 << 26,
		PipelineStageTransformFeedbackBitExt = 1 << 24,
		PipelineStageConditionalRenderingBitExt = 1 << 18,
		PipelineStageRayTracingShaderBitKhr = 1 << 21,
		PipelineStageAccelerationStructureBuildBitKhr = 1 << 25,
		PipelineStageShadingRateImageBitNv = 1 << 22,
		PipelineStageRayTracingShaderBitNv = PipelineStageRayTracingShaderBitKhr,
		PipelineStageAccelerationStructureBuildBitNv = PipelineStageAccelerationStructureBuildBitKhr,
		PipelineStageTaskShaderBitNv = 1 << 19,
		PipelineStageMeshShaderBitNv = 1 << 20,
		PipelineStageFragmentDensityProcessBitExt = 1 << 23,
		PipelineStageCommandPreprocessBitNv = 1 << 17
	}

	[FlagsAttribute]
	public enum SampleCountFlags : Flags {
		SampleCount1Bit = 1 << 0,
		SampleCount2Bit = 1 << 1,
		SampleCount4Bit = 1 << 2,
		SampleCount8Bit = 1 << 3,
		SampleCount16Bit = 1 << 4,
		SampleCount32Bit = 1 << 5,
		SampleCount64Bit = 1 << 6
	}

	[FlagsAttribute]
	public enum AttachmentDescriptionFlags : Flags {
		AttachmentDescriptionMayAliasBit = 1 << 0
	}

	[FlagsAttribute]
	public enum StencilFaceFlags : Flags {
		StencilFaceFrontBit = 1 << 0,
		StencilFaceBackBit = 1 << 1,
		StencilFaceFrontAndBack = 0x00000003,
		StencilFrontAndBack = StencilFaceFrontAndBack
	}

	[FlagsAttribute]
	public enum CullModeFlags : Flags {
		CullModeNone = 0,
		CullModeFrontBit = 1 << 0,
		CullModeBackBit = 1 << 1,
		CullModeFrontAndBack = 0x00000003
	}

	[FlagsAttribute]
	public enum DescriptorPoolCreateFlags : Flags {
		DescriptorPoolCreateFreeDescriptorSetBit = 1 << 0,
		DescriptorPoolCreateUpdateAfterBindBit = 1 << 1,
		DescriptorPoolCreateUpdateAfterBindBitExt = DescriptorPoolCreateUpdateAfterBindBit
	}

	[FlagsAttribute]
	public enum DescriptorPoolResetFlags : Flags {

	}

	[FlagsAttribute]
	public enum DependencyFlags : Flags {
		DependencyByRegionBit = 1 << 0,
		DependencyDeviceGroupBit = 1 << 2,
		DependencyViewLocalBit = 1 << 1,
		DependencyViewLocalBitKhr = DependencyViewLocalBit,
		DependencyDeviceGroupBitKhr = DependencyDeviceGroupBit
	}

	[FlagsAttribute]
	public enum SubgroupFeatureFlags : Flags {
		SubgroupFeatureBasicBit = 1 << 0,
		SubgroupFeatureVoteBit = 1 << 1,
		SubgroupFeatureArithmeticBit = 1 << 2,
		SubgroupFeatureBallotBit = 1 << 3,
		SubgroupFeatureShuffleBit = 1 << 4,
		SubgroupFeatureShuffleRelativeBit = 1 << 5,
		SubgroupFeatureClusteredBit = 1 << 6,
		SubgroupFeatureQuadBit = 1 << 7,
		SubgroupFeaturePartitionedBitNv = 1 << 8
	}

	[FlagsAttribute]
	public enum IndirectCommandsLayoutUsageFlagsNV : Flags {
		IndirectCommandsLayoutUsageExplicitPreprocessBitNv = 1 << 0,
		IndirectCommandsLayoutUsageIndexedSequencesBitNv = 1 << 1,
		IndirectCommandsLayoutUsageUnorderedSequencesBitNv = 1 << 2
	}

	[FlagsAttribute]
	public enum IndirectStateFlagsNV : Flags {
		IndirectStateFlagFrontfaceBitNv = 1 << 0
	}

	[FlagsAttribute]
	public enum GeometryFlagsKHR : Flags {
		GeometryOpaqueBitKhr = 1 << 0,
		GeometryNoDuplicateAnyHitInvocationBitKhr = 1 << 1,
		GeometryOpaqueBitNv = GeometryOpaqueBitKhr,
		GeometryNoDuplicateAnyHitInvocationBitNv = GeometryNoDuplicateAnyHitInvocationBitKhr
	}

	[FlagsAttribute]
	public enum GeometryInstanceFlagsKHR : Flags {
		GeometryInstanceTriangleFacingCullDisableBitKhr = 1 << 0,
		GeometryInstanceTriangleFrontCounterclockwiseBitKhr = 1 << 1,
		GeometryInstanceForceOpaqueBitKhr = 1 << 2,
		GeometryInstanceForceNoOpaqueBitKhr = 1 << 3,
		GeometryInstanceTriangleCullDisableBitNv = GeometryInstanceTriangleFacingCullDisableBitKhr,
		GeometryInstanceTriangleFrontCounterclockwiseBitNv = GeometryInstanceTriangleFrontCounterclockwiseBitKhr,
		GeometryInstanceForceOpaqueBitNv = GeometryInstanceForceOpaqueBitKhr,
		GeometryInstanceForceNoOpaqueBitNv = GeometryInstanceForceNoOpaqueBitKhr
	}

	[FlagsAttribute]
	public enum BuildAccelerationStructureFlagsKHR : Flags {
		BuildAccelerationStructureAllowUpdateBitKhr = 1 << 0,
		BuildAccelerationStructureAllowCompactionBitKhr = 1 << 1,
		BuildAccelerationStructurePreferFastTraceBitKhr = 1 << 2,
		BuildAccelerationStructurePreferFastBuildBitKhr = 1 << 3,
		BuildAccelerationStructureLowMemoryBitKhr = 1 << 4,
		BuildAccelerationStructureAllowUpdateBitNv = BuildAccelerationStructureAllowUpdateBitKhr,
		BuildAccelerationStructureAllowCompactionBitNv = BuildAccelerationStructureAllowCompactionBitKhr,
		BuildAccelerationStructurePreferFastTraceBitNv = BuildAccelerationStructurePreferFastTraceBitKhr,
		BuildAccelerationStructurePreferFastBuildBitNv = BuildAccelerationStructurePreferFastBuildBitKhr,
		BuildAccelerationStructureLowMemoryBitNv = BuildAccelerationStructureLowMemoryBitKhr
	}

	[FlagsAttribute]
	public enum PrivateDataSlotCreateFlagsEXT : Flags {

	}

	[FlagsAttribute]
	public enum DescriptorUpdateTemplateCreateFlags : Flags {

	}

	[FlagsAttribute]
	public enum PipelineCreationFeedbackFlagsEXT : Flags {
		PipelineCreationFeedbackValidBitExt = 1 << 0,
		PipelineCreationFeedbackApplicationPipelineCacheHitBitExt = 1 << 1,
		PipelineCreationFeedbackBasePipelineAccelerationBitExt = 1 << 2
	}

	[FlagsAttribute]
	public enum PerformanceCounterDescriptionFlagsKHR : Flags {
		PerformanceCounterDescriptionPerformanceImpactingKhr = 1 << 0,
		PerformanceCounterDescriptionConcurrentlyImpactedKhr = 1 << 1
	}

	[FlagsAttribute]
	public enum AcquireProfilingLockFlagsKHR : Flags {

	}

	[FlagsAttribute]
	public enum SemaphoreWaitFlags : Flags {
		SemaphoreWaitAnyBit = 1 << 0,
		SemaphoreWaitAnyBitKhr = SemaphoreWaitAnyBit
	}

	[FlagsAttribute]
	public enum PipelineCompilerControlFlagsAMD : Flags {

	}

	[FlagsAttribute]
	public enum ShaderCorePropertiesFlagsAMD : Flags {

	}

	[FlagsAttribute]
	public enum DeviceDiagnosticsConfigFlagsNV : Flags {
		DeviceDiagnosticsConfigEnableShaderDebugInfoBitNv = 1 << 0,
		DeviceDiagnosticsConfigEnableResourceTrackingBitNv = 1 << 1,
		DeviceDiagnosticsConfigEnableAutomaticCheckpointsBitNv = 1 << 2
	}

	[FlagsAttribute]
	public enum CompositeAlphaFlagsKHR : Flags {
		CompositeAlphaOpaqueBitKhr = 1 << 0,
		CompositeAlphaPreMultipliedBitKhr = 1 << 1,
		CompositeAlphaPostMultipliedBitKhr = 1 << 2,
		CompositeAlphaInheritBitKhr = 1 << 3
	}

	[FlagsAttribute]
	public enum DisplayPlaneAlphaFlagsKHR : Flags {
		DisplayPlaneAlphaOpaqueBitKhr = 1 << 0,
		DisplayPlaneAlphaGlobalBitKhr = 1 << 1,
		DisplayPlaneAlphaPerPixelBitKhr = 1 << 2,
		DisplayPlaneAlphaPerPixelPremultipliedBitKhr = 1 << 3
	}

	[FlagsAttribute]
	public enum SurfaceTransformFlagsKHR : Flags {
		SurfaceTransformIdentityBitKhr = 1 << 0,
		SurfaceTransformRotate90BitKhr = 1 << 1,
		SurfaceTransformRotate180BitKhr = 1 << 2,
		SurfaceTransformRotate270BitKhr = 1 << 3,
		SurfaceTransformHorizontalMirrorBitKhr = 1 << 4,
		SurfaceTransformHorizontalMirrorRotate90BitKhr = 1 << 5,
		SurfaceTransformHorizontalMirrorRotate180BitKhr = 1 << 6,
		SurfaceTransformHorizontalMirrorRotate270BitKhr = 1 << 7,
		SurfaceTransformInheritBitKhr = 1 << 8
	}

	[FlagsAttribute]
	public enum SwapchainCreateFlagsKHR : Flags {
		SwapchainCreateSplitInstanceBindRegionsBitKhr = 1 << 0,
		SwapchainCreateProtectedBitKhr = 1 << 1,
		SwapchainCreateMutableFormatBitKhr = 1 << 2
	}

	[FlagsAttribute]
	public enum DisplayModeCreateFlagsKHR : Flags {

	}

	[FlagsAttribute]
	public enum DisplaySurfaceCreateFlagsKHR : Flags {

	}

	[FlagsAttribute]
	public enum AndroidSurfaceCreateFlagsKHR : Flags {

	}

	[FlagsAttribute]
	public enum ViSurfaceCreateFlagsNN : Flags {

	}

	[FlagsAttribute]
	public enum WaylandSurfaceCreateFlagsKHR : Flags {

	}

	[FlagsAttribute]
	public enum Win32SurfaceCreateFlagsKHR : Flags {

	}

	[FlagsAttribute]
	public enum XlibSurfaceCreateFlagsKHR : Flags {

	}

	[FlagsAttribute]
	public enum XcbSurfaceCreateFlagsKHR : Flags {

	}

	[FlagsAttribute]
	public enum DirectFBSurfaceCreateFlagsEXT : Flags {

	}

	[FlagsAttribute]
	public enum IOSSurfaceCreateFlagsMVK : Flags {

	}

	[FlagsAttribute]
	public enum MacOSSurfaceCreateFlagsMVK : Flags {

	}

	[FlagsAttribute]
	public enum MetalSurfaceCreateFlagsEXT : Flags {

	}

	[FlagsAttribute]
	public enum ImagePipeSurfaceCreateFlagsFUCHSIA : Flags {

	}

	[FlagsAttribute]
	public enum StreamDescriptorSurfaceCreateFlagsGGP : Flags {

	}

	[FlagsAttribute]
	public enum HeadlessSurfaceCreateFlagsEXT : Flags {

	}

	[FlagsAttribute]
	public enum PeerMemoryFeatureFlags : Flags {
		PeerMemoryFeatureCopySrcBit = 1 << 0,
		PeerMemoryFeatureCopyDstBit = 1 << 1,
		PeerMemoryFeatureGenericSrcBit = 1 << 2,
		PeerMemoryFeatureGenericDstBit = 1 << 3,
		PeerMemoryFeatureCopySrcBitKhr = PeerMemoryFeatureCopySrcBit,
		PeerMemoryFeatureCopyDstBitKhr = PeerMemoryFeatureCopyDstBit,
		PeerMemoryFeatureGenericSrcBitKhr = PeerMemoryFeatureGenericSrcBit,
		PeerMemoryFeatureGenericDstBitKhr = PeerMemoryFeatureGenericDstBit
	}

	[FlagsAttribute]
	public enum MemoryAllocateFlags : Flags {
		MemoryAllocateDeviceMaskBit = 1 << 0,
		MemoryAllocateDeviceAddressBit = 1 << 1,
		MemoryAllocateDeviceAddressCaptureReplayBit = 1 << 2,
		MemoryAllocateDeviceMaskBitKhr = MemoryAllocateDeviceMaskBit,
		MemoryAllocateDeviceAddressBitKhr = MemoryAllocateDeviceAddressBit,
		MemoryAllocateDeviceAddressCaptureReplayBitKhr = MemoryAllocateDeviceAddressCaptureReplayBit
	}

	[FlagsAttribute]
	public enum DeviceGroupPresentModeFlagsKHR : Flags {
		DeviceGroupPresentModeLocalBitKhr = 1 << 0,
		DeviceGroupPresentModeRemoteBitKhr = 1 << 1,
		DeviceGroupPresentModeSumBitKhr = 1 << 2,
		DeviceGroupPresentModeLocalMultiDeviceBitKhr = 1 << 3
	}

	[FlagsAttribute]
	public enum DebugReportFlagsEXT : Flags {
		DebugReportInformationBitExt = 1 << 0,
		DebugReportWarningBitExt = 1 << 1,
		DebugReportPerformanceWarningBitExt = 1 << 2,
		DebugReportErrorBitExt = 1 << 3,
		DebugReportDebugBitExt = 1 << 4
	}

	[FlagsAttribute]
	public enum CommandPoolTrimFlags : Flags {

	}

	[FlagsAttribute]
	public enum ExternalMemoryHandleTypeFlagsNV : Flags {
		ExternalMemoryHandleTypeOpaqueWin32BitNv = 1 << 0,
		ExternalMemoryHandleTypeOpaqueWin32KmtBitNv = 1 << 1,
		ExternalMemoryHandleTypeD3d11ImageBitNv = 1 << 2,
		ExternalMemoryHandleTypeD3d11ImageKmtBitNv = 1 << 3
	}

	[FlagsAttribute]
	public enum ExternalMemoryFeatureFlagsNV : Flags {
		ExternalMemoryFeatureDedicatedOnlyBitNv = 1 << 0,
		ExternalMemoryFeatureExportableBitNv = 1 << 1,
		ExternalMemoryFeatureImportableBitNv = 1 << 2
	}

	[FlagsAttribute]
	public enum ExternalMemoryHandleTypeFlags : Flags {
		ExternalMemoryHandleTypeOpaqueFdBit = 1 << 0,
		ExternalMemoryHandleTypeOpaqueWin32Bit = 1 << 1,
		ExternalMemoryHandleTypeOpaqueWin32KmtBit = 1 << 2,
		ExternalMemoryHandleTypeD3d11TextureBit = 1 << 3,
		ExternalMemoryHandleTypeD3d11TextureKmtBit = 1 << 4,
		ExternalMemoryHandleTypeD3d12HeapBit = 1 << 5,
		ExternalMemoryHandleTypeD3d12ResourceBit = 1 << 6,
		ExternalMemoryHandleTypeOpaqueFdBitKhr = ExternalMemoryHandleTypeOpaqueFdBit,
		ExternalMemoryHandleTypeOpaqueWin32BitKhr = ExternalMemoryHandleTypeOpaqueWin32Bit,
		ExternalMemoryHandleTypeOpaqueWin32KmtBitKhr = ExternalMemoryHandleTypeOpaqueWin32KmtBit,
		ExternalMemoryHandleTypeD3d11TextureBitKhr = ExternalMemoryHandleTypeD3d11TextureBit,
		ExternalMemoryHandleTypeD3d11TextureKmtBitKhr = ExternalMemoryHandleTypeD3d11TextureKmtBit,
		ExternalMemoryHandleTypeD3d12HeapBitKhr = ExternalMemoryHandleTypeD3d12HeapBit,
		ExternalMemoryHandleTypeD3d12ResourceBitKhr = ExternalMemoryHandleTypeD3d12ResourceBit,
		ExternalMemoryHandleTypeDmaBufBitExt = 1 << 9,
		ExternalMemoryHandleTypeAndroidHardwareBufferBitAndroid = 1 << 10,
		ExternalMemoryHandleTypeHostAllocationBitExt = 1 << 7,
		ExternalMemoryHandleTypeHostMappedForeignMemoryBitExt = 1 << 8
	}

	[FlagsAttribute]
	public enum ExternalMemoryFeatureFlags : Flags {
		ExternalMemoryFeatureDedicatedOnlyBit = 1 << 0,
		ExternalMemoryFeatureExportableBit = 1 << 1,
		ExternalMemoryFeatureImportableBit = 1 << 2,
		ExternalMemoryFeatureDedicatedOnlyBitKhr = ExternalMemoryFeatureDedicatedOnlyBit,
		ExternalMemoryFeatureExportableBitKhr = ExternalMemoryFeatureExportableBit,
		ExternalMemoryFeatureImportableBitKhr = ExternalMemoryFeatureImportableBit
	}

	[FlagsAttribute]
	public enum ExternalSemaphoreHandleTypeFlags : Flags {
		ExternalSemaphoreHandleTypeOpaqueFdBit = 1 << 0,
		ExternalSemaphoreHandleTypeOpaqueWin32Bit = 1 << 1,
		ExternalSemaphoreHandleTypeOpaqueWin32KmtBit = 1 << 2,
		ExternalSemaphoreHandleTypeD3d12FenceBit = 1 << 3,
		ExternalSemaphoreHandleTypeSyncFdBit = 1 << 4,
		ExternalSemaphoreHandleTypeOpaqueFdBitKhr = ExternalSemaphoreHandleTypeOpaqueFdBit,
		ExternalSemaphoreHandleTypeOpaqueWin32BitKhr = ExternalSemaphoreHandleTypeOpaqueWin32Bit,
		ExternalSemaphoreHandleTypeOpaqueWin32KmtBitKhr = ExternalSemaphoreHandleTypeOpaqueWin32KmtBit,
		ExternalSemaphoreHandleTypeD3d12FenceBitKhr = ExternalSemaphoreHandleTypeD3d12FenceBit,
		ExternalSemaphoreHandleTypeSyncFdBitKhr = ExternalSemaphoreHandleTypeSyncFdBit
	}

	[FlagsAttribute]
	public enum ExternalSemaphoreFeatureFlags : Flags {
		ExternalSemaphoreFeatureExportableBit = 1 << 0,
		ExternalSemaphoreFeatureImportableBit = 1 << 1,
		ExternalSemaphoreFeatureExportableBitKhr = ExternalSemaphoreFeatureExportableBit,
		ExternalSemaphoreFeatureImportableBitKhr = ExternalSemaphoreFeatureImportableBit
	}

	[FlagsAttribute]
	public enum SemaphoreImportFlags : Flags {
		SemaphoreImportTemporaryBit = 1 << 0,
		SemaphoreImportTemporaryBitKhr = SemaphoreImportTemporaryBit
	}

	[FlagsAttribute]
	public enum ExternalFenceHandleTypeFlags : Flags {
		ExternalFenceHandleTypeOpaqueFdBit = 1 << 0,
		ExternalFenceHandleTypeOpaqueWin32Bit = 1 << 1,
		ExternalFenceHandleTypeOpaqueWin32KmtBit = 1 << 2,
		ExternalFenceHandleTypeSyncFdBit = 1 << 3,
		ExternalFenceHandleTypeOpaqueFdBitKhr = ExternalFenceHandleTypeOpaqueFdBit,
		ExternalFenceHandleTypeOpaqueWin32BitKhr = ExternalFenceHandleTypeOpaqueWin32Bit,
		ExternalFenceHandleTypeOpaqueWin32KmtBitKhr = ExternalFenceHandleTypeOpaqueWin32KmtBit,
		ExternalFenceHandleTypeSyncFdBitKhr = ExternalFenceHandleTypeSyncFdBit
	}

	[FlagsAttribute]
	public enum ExternalFenceFeatureFlags : Flags {
		ExternalFenceFeatureExportableBit = 1 << 0,
		ExternalFenceFeatureImportableBit = 1 << 1,
		ExternalFenceFeatureExportableBitKhr = ExternalFenceFeatureExportableBit,
		ExternalFenceFeatureImportableBitKhr = ExternalFenceFeatureImportableBit
	}

	[FlagsAttribute]
	public enum FenceImportFlags : Flags {
		FenceImportTemporaryBit = 1 << 0,
		FenceImportTemporaryBitKhr = FenceImportTemporaryBit
	}

	[FlagsAttribute]
	public enum SurfaceCounterFlagsEXT : Flags {
		SurfaceCounterVblankExt = 1 << 0
	}

	[FlagsAttribute]
	public enum PipelineViewportSwizzleStateCreateFlagsNV : Flags {

	}

	[FlagsAttribute]
	public enum PipelineDiscardRectangleStateCreateFlagsEXT : Flags {

	}

	[FlagsAttribute]
	public enum PipelineCoverageToColorStateCreateFlagsNV : Flags {

	}

	[FlagsAttribute]
	public enum PipelineCoverageModulationStateCreateFlagsNV : Flags {

	}

	[FlagsAttribute]
	public enum PipelineCoverageReductionStateCreateFlagsNV : Flags {

	}

	[FlagsAttribute]
	public enum ValidationCacheCreateFlagsEXT : Flags {

	}

	[FlagsAttribute]
	public enum DebugUtilsMessageSeverityFlagsEXT : Flags {
		DebugUtilsMessageSeverityVerboseBitExt = 1 << 0,
		DebugUtilsMessageSeverityInfoBitExt = 1 << 4,
		DebugUtilsMessageSeverityWarningBitExt = 1 << 8,
		DebugUtilsMessageSeverityErrorBitExt = 1 << 12
	}

	[FlagsAttribute]
	public enum DebugUtilsMessageTypeFlagsEXT : Flags {
		DebugUtilsMessageTypeGeneralBitExt = 1 << 0,
		DebugUtilsMessageTypeValidationBitExt = 1 << 1,
		DebugUtilsMessageTypePerformanceBitExt = 1 << 2
	}

	[FlagsAttribute]
	public enum DebugUtilsMessengerCreateFlagsEXT : Flags {

	}

	[FlagsAttribute]
	public enum DebugUtilsMessengerCallbackDataFlagsEXT : Flags {

	}

	[FlagsAttribute]
	public enum PipelineRasterizationConservativeStateCreateFlagsEXT : Flags {

	}

	[FlagsAttribute]
	public enum DescriptorBindingFlags : Flags {
		DescriptorBindingUpdateAfterBindBit = 1 << 0,
		DescriptorBindingUpdateUnusedWhilePendingBit = 1 << 1,
		DescriptorBindingPartiallyBoundBit = 1 << 2,
		DescriptorBindingVariableDescriptorCountBit = 1 << 3,
		DescriptorBindingUpdateAfterBindBitExt = DescriptorBindingUpdateAfterBindBit,
		DescriptorBindingUpdateUnusedWhilePendingBitExt = DescriptorBindingUpdateUnusedWhilePendingBit,
		DescriptorBindingPartiallyBoundBitExt = DescriptorBindingPartiallyBoundBit,
		DescriptorBindingVariableDescriptorCountBitExt = DescriptorBindingVariableDescriptorCountBit
	}

	[FlagsAttribute]
	public enum ConditionalRenderingFlagsEXT : Flags {
		ConditionalRenderingInvertedBitExt = 1 << 0
	}

	[FlagsAttribute]
	public enum ResolveModeFlags : Flags {
		ResolveModeNone = 0,
		ResolveModeSampleZeroBit = 1 << 0,
		ResolveModeAverageBit = 1 << 1,
		ResolveModeMinBit = 1 << 2,
		ResolveModeMaxBit = 1 << 3,
		ResolveModeNoneKhr = ResolveModeNone,
		ResolveModeSampleZeroBitKhr = ResolveModeSampleZeroBit,
		ResolveModeAverageBitKhr = ResolveModeAverageBit,
		ResolveModeMinBitKhr = ResolveModeMinBit,
		ResolveModeMaxBitKhr = ResolveModeMaxBit
	}

	[FlagsAttribute]
	public enum PipelineRasterizationStateStreamCreateFlagsEXT : Flags {

	}

	[FlagsAttribute]
	public enum PipelineRasterizationDepthClipStateCreateFlagsEXT : Flags {

	}

	[FlagsAttribute]
	public enum SwapchainImageUsageFlagsANDROID : Flags {
		SwapchainImageUsageSharedBitAndroid = 1 << 0
	}

	[FlagsAttribute]
	public enum ToolPurposeFlagsEXT : Flags {
		ToolPurposeValidationBitExt = 1 << 0,
		ToolPurposeProfilingBitExt = 1 << 1,
		ToolPurposeTracingBitExt = 1 << 2,
		ToolPurposeAdditionalFeaturesBitExt = 1 << 3,
		ToolPurposeModifyingFeaturesBitExt = 1 << 4,
		ToolPurposeDebugReportingBitExt = 1 << 5,
		ToolPurposeDebugMarkersBitExt = 1 << 6
	}
}
