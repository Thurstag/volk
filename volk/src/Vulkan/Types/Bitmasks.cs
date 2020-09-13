// Copyright 2020-2020 Volk Project
// Licensed under Apache License 2.0 or any later version
// Refer to the LICENSE.md file included.

// This file is generated automatically by generator


using System;
using SampleMask = System.UInt32;
using Bool32 = System.UInt32;
using Flags = System.UInt32;
using DeviceSize = System.UInt64;
using DeviceAddress = System.UInt64;

namespace Volk.Vulkan.Types {
    [FlagsAttribute]
    public enum FramebufferCreateFlags : uint {
        FramebufferCreateImagelessBit = 1 << 0,
        FramebufferCreateImagelessBitKhr = FramebufferCreateImagelessBit
    }

    [FlagsAttribute]
    public enum QueryPoolCreateFlags : uint { }

    [FlagsAttribute]
    public enum RenderPassCreateFlags : uint {
        RenderPassCreateReserved0BitKhr = 1 << 0,
        RenderPassCreateTransformBitQcom = 1 << 1
    }

    [FlagsAttribute]
    public enum SamplerCreateFlags : uint {
        SamplerCreateSubsampledBitExt = 1 << 0,
        SamplerCreateSubsampledCoarseReconstructionBitExt = 1 << 1
    }

    [FlagsAttribute]
    public enum PipelineLayoutCreateFlags : uint { }

    [FlagsAttribute]
    public enum PipelineCacheCreateFlags : uint {
        PipelineCacheCreateReserved1BitExt = 1 << 1,
        PipelineCacheCreateExternallySynchronizedBitExt = 1 << 0
    }

    [FlagsAttribute]
    public enum PipelineDepthStencilStateCreateFlags : uint { }

    [FlagsAttribute]
    public enum PipelineDynamicStateCreateFlags : uint { }

    [FlagsAttribute]
    public enum PipelineColorBlendStateCreateFlags : uint { }

    [FlagsAttribute]
    public enum PipelineMultisampleStateCreateFlags : uint { }

    [FlagsAttribute]
    public enum PipelineRasterizationStateCreateFlags : uint { }

    [FlagsAttribute]
    public enum PipelineViewportStateCreateFlags : uint { }

    [FlagsAttribute]
    public enum PipelineTessellationStateCreateFlags : uint { }

    [FlagsAttribute]
    public enum PipelineInputAssemblyStateCreateFlags : uint { }

    [FlagsAttribute]
    public enum PipelineVertexInputStateCreateFlags : uint { }

    [FlagsAttribute]
    public enum PipelineShaderStageCreateFlags : uint {
        PipelineShaderStageCreateReserved2BitNv = 1 << 2,
        PipelineShaderStageCreateAllowVaryingSubgroupSizeBitExt = 1 << 0,
        PipelineShaderStageCreateRequireFullSubgroupsBitExt = 1 << 1,
        PipelineShaderStageCreateReserved3BitKhr = 1 << 3
    }

    [FlagsAttribute]
    public enum DescriptorSetLayoutCreateFlags : uint {
        DescriptorSetLayoutCreateUpdateAfterBindPoolBit = 1 << 1,
        DescriptorSetLayoutCreatePushDescriptorBitKhr = 1 << 0,
        DescriptorSetLayoutCreateUpdateAfterBindPoolBitExt = DescriptorSetLayoutCreateUpdateAfterBindPoolBit
    }

    [FlagsAttribute]
    public enum BufferViewCreateFlags : uint { }

    [FlagsAttribute]
    public enum InstanceCreateFlags : uint { }

    [FlagsAttribute]
    public enum DeviceCreateFlags : uint { }

    [FlagsAttribute]
    public enum DeviceQueueCreateFlags : uint {
        DeviceQueueCreateProtectedBit = 1 << 0
    }

    [FlagsAttribute]
    public enum QueueFlags : uint {
        QueueGraphicsBit = 1 << 0,
        QueueComputeBit = 1 << 1,
        QueueTransferBit = 1 << 2,
        QueueSparseBindingBit = 1 << 3,
        QueueProtectedBit = 1 << 4,
        QueueReserved6BitKhr = 1 << 6,
        QueueReserved5BitKhr = 1 << 5
    }

    [FlagsAttribute]
    public enum MemoryPropertyFlags : uint {
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
    public enum MemoryHeapFlags : uint {
        MemoryHeapDeviceLocalBit = 1 << 0,
        MemoryHeapMultiInstanceBit = 1 << 1,
        MemoryHeapMultiInstanceBitKhr = MemoryHeapMultiInstanceBit,
        MemoryHeapReserved2BitKhr = 1 << 2
    }

    [FlagsAttribute]
    public enum AccessFlags : uint {
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
    public enum BufferUsageFlags : uint {
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
    public enum BufferCreateFlags : uint {
        BufferCreateSparseBindingBit = 1 << 0,
        BufferCreateSparseResidencyBit = 1 << 1,
        BufferCreateSparseAliasedBit = 1 << 2,
        BufferCreateProtectedBit = 1 << 3,
        BufferCreateDeviceAddressCaptureReplayBit = 1 << 4,
        BufferCreateDeviceAddressCaptureReplayBitExt = BufferCreateDeviceAddressCaptureReplayBit,
        BufferCreateDeviceAddressCaptureReplayBitKhr = BufferCreateDeviceAddressCaptureReplayBit
    }

    [FlagsAttribute]
    public enum ShaderStageFlags : uint {
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
    public enum ImageUsageFlags : uint {
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
    public enum ImageCreateFlags : uint {
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
    public enum ImageViewCreateFlags : uint {
        ImageViewCreateFragmentDensityMapDynamicBitExt = 1 << 0,
        ImageViewCreateFragmentDensityMapDeferredBitExt = 1 << 1
    }

    [FlagsAttribute]
    public enum PipelineCreateFlags : uint {
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
    public enum ColorComponentFlags : uint {
        ColorComponentRBit = 1 << 0,
        ColorComponentGBit = 1 << 1,
        ColorComponentBBit = 1 << 2,
        ColorComponentABit = 1 << 3
    }

    [FlagsAttribute]
    public enum FenceCreateFlags : uint {
        FenceCreateSignaledBit = 1 << 0
    }

    [FlagsAttribute]
    public enum SemaphoreCreateFlags : uint { }

    [FlagsAttribute]
    public enum FormatFeatureFlags : uint {
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

        FormatFeatureSampledImageYcbcrConversionSeparateReconstructionFilterBitKhr =
            FormatFeatureSampledImageYcbcrConversionSeparateReconstructionFilterBit,

        FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitBitKhr =
            FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitBit,

        FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitForceableBitKhr =
            FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitForceableBit,
        FormatFeatureDisjointBitKhr = FormatFeatureDisjointBit,
        FormatFeatureCositedChromaSamplesBitKhr = FormatFeatureCositedChromaSamplesBit,
        FormatFeatureSampledImageFilterCubicBitExt = FormatFeatureSampledImageFilterCubicBitImg,
        FormatFeatureFragmentDensityMapBitExt = 1 << 24,
        FormatFeatureAmdReserved30Bit = 1 << 30
    }

    [FlagsAttribute]
    public enum QueryControlFlags : uint {
        QueryControlPreciseBit = 1 << 0
    }

    [FlagsAttribute]
    public enum QueryResultFlags : uint {
        QueryResult64Bit = 1 << 0,
        QueryResultWaitBit = 1 << 1,
        QueryResultWithAvailabilityBit = 1 << 2,
        QueryResultPartialBit = 1 << 3
    }

    [FlagsAttribute]
    public enum ShaderModuleCreateFlags : uint {
        ShaderModuleCreateReserved0BitNv = 1 << 0
    }

    [FlagsAttribute]
    public enum EventCreateFlags : uint { }

    [FlagsAttribute]
    public enum CommandPoolCreateFlags : uint {
        CommandPoolCreateTransientBit = 1 << 0,
        CommandPoolCreateResetCommandBufferBit = 1 << 1,
        CommandPoolCreateProtectedBit = 1 << 2
    }

    [FlagsAttribute]
    public enum CommandPoolResetFlags : uint {
        CommandPoolResetReleaseResourcesBit = 1 << 0
    }

    [FlagsAttribute]
    public enum CommandBufferResetFlags : uint {
        CommandBufferResetReleaseResourcesBit = 1 << 0
    }

    [FlagsAttribute]
    public enum CommandBufferUsageFlags : uint {
        CommandBufferUsageOneTimeSubmitBit = 1 << 0,
        CommandBufferUsageRenderPassContinueBit = 1 << 1,
        CommandBufferUsageSimultaneousUseBit = 1 << 2
    }

    [FlagsAttribute]
    public enum QueryPipelineStatisticFlags : uint {
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
    public enum MemoryMapFlags : uint { }

    [FlagsAttribute]
    public enum ImageAspectFlags : uint {
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
    public enum SparseMemoryBindFlags : uint {
        SparseMemoryBindMetadataBit = 1 << 0
    }

    [FlagsAttribute]
    public enum SparseImageFormatFlags : uint {
        SparseImageFormatSingleMiptailBit = 1 << 0,
        SparseImageFormatAlignedMipSizeBit = 1 << 1,
        SparseImageFormatNonstandardBlockSizeBit = 1 << 2
    }

    [FlagsAttribute]
    public enum SubpassDescriptionFlags : uint {
        SubpassDescriptionPerViewAttributesBitNvx = 1 << 0,
        SubpassDescriptionPerViewPositionXOnlyBitNvx = 1 << 1,
        SubpassDescriptionFragmentRegionBitQcom = 1 << 2,
        SubpassDescriptionShaderResolveBitQcom = 1 << 3
    }

    [FlagsAttribute]
    public enum PipelineStageFlags : uint {
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
    public enum SampleCountFlags : uint {
        SampleCount1Bit = 1 << 0,
        SampleCount2Bit = 1 << 1,
        SampleCount4Bit = 1 << 2,
        SampleCount8Bit = 1 << 3,
        SampleCount16Bit = 1 << 4,
        SampleCount32Bit = 1 << 5,
        SampleCount64Bit = 1 << 6
    }

    [FlagsAttribute]
    public enum AttachmentDescriptionFlags : uint {
        AttachmentDescriptionMayAliasBit = 1 << 0
    }

    [FlagsAttribute]
    public enum StencilFaceFlags : uint {
        StencilFaceFrontBit = 1 << 0,
        StencilFaceBackBit = 1 << 1,
        StencilFaceFrontAndBack = 0x00000003,
        StencilFrontAndBack = StencilFaceFrontAndBack
    }

    [FlagsAttribute]
    public enum CullModeFlags : uint {
        CullModeNone = 0,
        CullModeFrontBit = 1 << 0,
        CullModeBackBit = 1 << 1,
        CullModeFrontAndBack = 0x00000003
    }

    [FlagsAttribute]
    public enum DescriptorPoolCreateFlags : uint {
        DescriptorPoolCreateFreeDescriptorSetBit = 1 << 0,
        DescriptorPoolCreateUpdateAfterBindBit = 1 << 1,
        DescriptorPoolCreateUpdateAfterBindBitExt = DescriptorPoolCreateUpdateAfterBindBit
    }

    [FlagsAttribute]
    public enum DescriptorPoolResetFlags : uint { }

    [FlagsAttribute]
    public enum DependencyFlags : uint {
        DependencyByRegionBit = 1 << 0,
        DependencyDeviceGroupBit = 1 << 2,
        DependencyViewLocalBit = 1 << 1,
        DependencyViewLocalBitKhr = DependencyViewLocalBit,
        DependencyDeviceGroupBitKhr = DependencyDeviceGroupBit
    }

    [FlagsAttribute]
    public enum SubgroupFeatureFlags : uint {
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
    public enum IndirectCommandsLayoutUsageFlagsNV : uint {
        IndirectCommandsLayoutUsageExplicitPreprocessBitNv = 1 << 0,
        IndirectCommandsLayoutUsageIndexedSequencesBitNv = 1 << 1,
        IndirectCommandsLayoutUsageUnorderedSequencesBitNv = 1 << 2
    }

    [FlagsAttribute]
    public enum IndirectStateFlagsNV : uint {
        IndirectStateFlagFrontfaceBitNv = 1 << 0
    }

    [FlagsAttribute]
    public enum GeometryFlagsKHR : uint {
        GeometryOpaqueBitKhr = 1 << 0,
        GeometryNoDuplicateAnyHitInvocationBitKhr = 1 << 1,
        GeometryOpaqueBitNv = GeometryOpaqueBitKhr,
        GeometryNoDuplicateAnyHitInvocationBitNv = GeometryNoDuplicateAnyHitInvocationBitKhr
    }

    [FlagsAttribute]
    public enum GeometryInstanceFlagsKHR : uint {
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
    public enum BuildAccelerationStructureFlagsKHR : uint {
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
    public enum PrivateDataSlotCreateFlagsEXT : uint { }

    [FlagsAttribute]
    public enum DescriptorUpdateTemplateCreateFlags : uint { }

    [FlagsAttribute]
    public enum PipelineCreationFeedbackFlagsEXT : uint {
        PipelineCreationFeedbackValidBitExt = 1 << 0,
        PipelineCreationFeedbackApplicationPipelineCacheHitBitExt = 1 << 1,
        PipelineCreationFeedbackBasePipelineAccelerationBitExt = 1 << 2
    }

    [FlagsAttribute]
    public enum PerformanceCounterDescriptionFlagsKHR : uint {
        PerformanceCounterDescriptionPerformanceImpactingKhr = 1 << 0,
        PerformanceCounterDescriptionConcurrentlyImpactedKhr = 1 << 1
    }

    [FlagsAttribute]
    public enum AcquireProfilingLockFlagsKHR : uint { }

    [FlagsAttribute]
    public enum SemaphoreWaitFlags : uint {
        SemaphoreWaitAnyBit = 1 << 0,
        SemaphoreWaitAnyBitKhr = SemaphoreWaitAnyBit
    }

    [FlagsAttribute]
    public enum PipelineCompilerControlFlagsAMD : uint { }

    [FlagsAttribute]
    public enum ShaderCorePropertiesFlagsAMD : uint { }

    [FlagsAttribute]
    public enum DeviceDiagnosticsConfigFlagsNV : uint {
        DeviceDiagnosticsConfigEnableShaderDebugInfoBitNv = 1 << 0,
        DeviceDiagnosticsConfigEnableResourceTrackingBitNv = 1 << 1,
        DeviceDiagnosticsConfigEnableAutomaticCheckpointsBitNv = 1 << 2
    }

    [FlagsAttribute]
    public enum CompositeAlphaFlagsKHR : uint {
        CompositeAlphaOpaqueBitKhr = 1 << 0,
        CompositeAlphaPreMultipliedBitKhr = 1 << 1,
        CompositeAlphaPostMultipliedBitKhr = 1 << 2,
        CompositeAlphaInheritBitKhr = 1 << 3
    }

    [FlagsAttribute]
    public enum DisplayPlaneAlphaFlagsKHR : uint {
        DisplayPlaneAlphaOpaqueBitKhr = 1 << 0,
        DisplayPlaneAlphaGlobalBitKhr = 1 << 1,
        DisplayPlaneAlphaPerPixelBitKhr = 1 << 2,
        DisplayPlaneAlphaPerPixelPremultipliedBitKhr = 1 << 3
    }

    [FlagsAttribute]
    public enum SurfaceTransformFlagsKHR : uint {
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
    public enum SwapchainCreateFlagsKHR : uint {
        SwapchainCreateSplitInstanceBindRegionsBitKhr = 1 << 0,
        SwapchainCreateProtectedBitKhr = 1 << 1,
        SwapchainCreateMutableFormatBitKhr = 1 << 2
    }

    [FlagsAttribute]
    public enum DisplayModeCreateFlagsKHR : uint { }

    [FlagsAttribute]
    public enum DisplaySurfaceCreateFlagsKHR : uint { }

    [FlagsAttribute]
    public enum AndroidSurfaceCreateFlagsKHR : uint { }

    [FlagsAttribute]
    public enum ViSurfaceCreateFlagsNN : uint { }

    [FlagsAttribute]
    public enum WaylandSurfaceCreateFlagsKHR : uint { }

    [FlagsAttribute]
    public enum Win32SurfaceCreateFlagsKHR : uint { }

    [FlagsAttribute]
    public enum XlibSurfaceCreateFlagsKHR : uint { }

    [FlagsAttribute]
    public enum XcbSurfaceCreateFlagsKHR : uint { }

    [FlagsAttribute]
    public enum DirectFBSurfaceCreateFlagsEXT : uint { }

    [FlagsAttribute]
    public enum IOSSurfaceCreateFlagsMVK : uint { }

    [FlagsAttribute]
    public enum MacOSSurfaceCreateFlagsMVK : uint { }

    [FlagsAttribute]
    public enum MetalSurfaceCreateFlagsEXT : uint { }

    [FlagsAttribute]
    public enum ImagePipeSurfaceCreateFlagsFUCHSIA : uint { }

    [FlagsAttribute]
    public enum StreamDescriptorSurfaceCreateFlagsGGP : uint { }

    [FlagsAttribute]
    public enum HeadlessSurfaceCreateFlagsEXT : uint { }

    [FlagsAttribute]
    public enum PeerMemoryFeatureFlags : uint {
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
    public enum MemoryAllocateFlags : uint {
        MemoryAllocateDeviceMaskBit = 1 << 0,
        MemoryAllocateDeviceAddressBit = 1 << 1,
        MemoryAllocateDeviceAddressCaptureReplayBit = 1 << 2,
        MemoryAllocateDeviceMaskBitKhr = MemoryAllocateDeviceMaskBit,
        MemoryAllocateDeviceAddressBitKhr = MemoryAllocateDeviceAddressBit,
        MemoryAllocateDeviceAddressCaptureReplayBitKhr = MemoryAllocateDeviceAddressCaptureReplayBit
    }

    [FlagsAttribute]
    public enum DeviceGroupPresentModeFlagsKHR : uint {
        DeviceGroupPresentModeLocalBitKhr = 1 << 0,
        DeviceGroupPresentModeRemoteBitKhr = 1 << 1,
        DeviceGroupPresentModeSumBitKhr = 1 << 2,
        DeviceGroupPresentModeLocalMultiDeviceBitKhr = 1 << 3
    }

    [FlagsAttribute]
    public enum DebugReportFlagsEXT : uint {
        DebugReportInformationBitExt = 1 << 0,
        DebugReportWarningBitExt = 1 << 1,
        DebugReportPerformanceWarningBitExt = 1 << 2,
        DebugReportErrorBitExt = 1 << 3,
        DebugReportDebugBitExt = 1 << 4
    }

    [FlagsAttribute]
    public enum CommandPoolTrimFlags : uint { }

    [FlagsAttribute]
    public enum ExternalMemoryHandleTypeFlagsNV : uint {
        ExternalMemoryHandleTypeOpaqueWin32BitNv = 1 << 0,
        ExternalMemoryHandleTypeOpaqueWin32KmtBitNv = 1 << 1,
        ExternalMemoryHandleTypeD3d11ImageBitNv = 1 << 2,
        ExternalMemoryHandleTypeD3d11ImageKmtBitNv = 1 << 3
    }

    [FlagsAttribute]
    public enum ExternalMemoryFeatureFlagsNV : uint {
        ExternalMemoryFeatureDedicatedOnlyBitNv = 1 << 0,
        ExternalMemoryFeatureExportableBitNv = 1 << 1,
        ExternalMemoryFeatureImportableBitNv = 1 << 2
    }

    [FlagsAttribute]
    public enum ExternalMemoryHandleTypeFlags : uint {
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
    public enum ExternalMemoryFeatureFlags : uint {
        ExternalMemoryFeatureDedicatedOnlyBit = 1 << 0,
        ExternalMemoryFeatureExportableBit = 1 << 1,
        ExternalMemoryFeatureImportableBit = 1 << 2,
        ExternalMemoryFeatureDedicatedOnlyBitKhr = ExternalMemoryFeatureDedicatedOnlyBit,
        ExternalMemoryFeatureExportableBitKhr = ExternalMemoryFeatureExportableBit,
        ExternalMemoryFeatureImportableBitKhr = ExternalMemoryFeatureImportableBit
    }

    [FlagsAttribute]
    public enum ExternalSemaphoreHandleTypeFlags : uint {
        ExternalSemaphoreHandleTypeOpaqueFdBit = 1 << 0,
        ExternalSemaphoreHandleTypeOpaqueWin32Bit = 1 << 1,
        ExternalSemaphoreHandleTypeOpaqueWin32KmtBit = 1 << 2,
        ExternalSemaphoreHandleTypeD3d12FenceBit = 1 << 3,
        ExternalSemaphoreHandleTypeD3d11FenceBit = ExternalSemaphoreHandleTypeD3d12FenceBit,
        ExternalSemaphoreHandleTypeSyncFdBit = 1 << 4,
        ExternalSemaphoreHandleTypeOpaqueFdBitKhr = ExternalSemaphoreHandleTypeOpaqueFdBit,
        ExternalSemaphoreHandleTypeOpaqueWin32BitKhr = ExternalSemaphoreHandleTypeOpaqueWin32Bit,
        ExternalSemaphoreHandleTypeOpaqueWin32KmtBitKhr = ExternalSemaphoreHandleTypeOpaqueWin32KmtBit,
        ExternalSemaphoreHandleTypeD3d12FenceBitKhr = ExternalSemaphoreHandleTypeD3d12FenceBit,
        ExternalSemaphoreHandleTypeSyncFdBitKhr = ExternalSemaphoreHandleTypeSyncFdBit
    }

    [FlagsAttribute]
    public enum ExternalSemaphoreFeatureFlags : uint {
        ExternalSemaphoreFeatureExportableBit = 1 << 0,
        ExternalSemaphoreFeatureImportableBit = 1 << 1,
        ExternalSemaphoreFeatureExportableBitKhr = ExternalSemaphoreFeatureExportableBit,
        ExternalSemaphoreFeatureImportableBitKhr = ExternalSemaphoreFeatureImportableBit
    }

    [FlagsAttribute]
    public enum SemaphoreImportFlags : uint {
        SemaphoreImportTemporaryBit = 1 << 0,
        SemaphoreImportTemporaryBitKhr = SemaphoreImportTemporaryBit
    }

    [FlagsAttribute]
    public enum ExternalFenceHandleTypeFlags : uint {
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
    public enum ExternalFenceFeatureFlags : uint {
        ExternalFenceFeatureExportableBit = 1 << 0,
        ExternalFenceFeatureImportableBit = 1 << 1,
        ExternalFenceFeatureExportableBitKhr = ExternalFenceFeatureExportableBit,
        ExternalFenceFeatureImportableBitKhr = ExternalFenceFeatureImportableBit
    }

    [FlagsAttribute]
    public enum FenceImportFlags : uint {
        FenceImportTemporaryBit = 1 << 0,
        FenceImportTemporaryBitKhr = FenceImportTemporaryBit
    }

    [FlagsAttribute]
    public enum SurfaceCounterFlagsEXT : uint {
        SurfaceCounterVblankExt = 1 << 0
    }

    [FlagsAttribute]
    public enum PipelineViewportSwizzleStateCreateFlagsNV : uint { }

    [FlagsAttribute]
    public enum PipelineDiscardRectangleStateCreateFlagsEXT : uint { }

    [FlagsAttribute]
    public enum PipelineCoverageToColorStateCreateFlagsNV : uint { }

    [FlagsAttribute]
    public enum PipelineCoverageModulationStateCreateFlagsNV : uint { }

    [FlagsAttribute]
    public enum PipelineCoverageReductionStateCreateFlagsNV : uint { }

    [FlagsAttribute]
    public enum ValidationCacheCreateFlagsEXT : uint { }

    [FlagsAttribute]
    public enum DebugUtilsMessageSeverityFlagsEXT : uint {
        DebugUtilsMessageSeverityVerboseBitExt = 1 << 0,
        DebugUtilsMessageSeverityInfoBitExt = 1 << 4,
        DebugUtilsMessageSeverityWarningBitExt = 1 << 8,
        DebugUtilsMessageSeverityErrorBitExt = 1 << 12
    }

    [FlagsAttribute]
    public enum DebugUtilsMessageTypeFlagsEXT : uint {
        DebugUtilsMessageTypeGeneralBitExt = 1 << 0,
        DebugUtilsMessageTypeValidationBitExt = 1 << 1,
        DebugUtilsMessageTypePerformanceBitExt = 1 << 2
    }

    [FlagsAttribute]
    public enum DebugUtilsMessengerCreateFlagsEXT : uint { }

    [FlagsAttribute]
    public enum DebugUtilsMessengerCallbackDataFlagsEXT : uint { }

    [FlagsAttribute]
    public enum PipelineRasterizationConservativeStateCreateFlagsEXT : uint { }

    [FlagsAttribute]
    public enum DescriptorBindingFlags : uint {
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
    public enum ConditionalRenderingFlagsEXT : uint {
        ConditionalRenderingInvertedBitExt = 1 << 0
    }

    [FlagsAttribute]
    public enum ResolveModeFlags : uint {
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
    public enum PipelineRasterizationStateStreamCreateFlagsEXT : uint { }

    [FlagsAttribute]
    public enum PipelineRasterizationDepthClipStateCreateFlagsEXT : uint { }

    [FlagsAttribute]
    public enum SwapchainImageUsageFlagsANDROID : uint {
        SwapchainImageUsageSharedBitAndroid = 1 << 0
    }

    [FlagsAttribute]
    public enum ToolPurposeFlagsEXT : uint {
        ToolPurposeValidationBitExt = 1 << 0,
        ToolPurposeProfilingBitExt = 1 << 1,
        ToolPurposeTracingBitExt = 1 << 2,
        ToolPurposeAdditionalFeaturesBitExt = 1 << 3,
        ToolPurposeModifyingFeaturesBitExt = 1 << 4,
        ToolPurposeDebugReportingBitExt = 1 << 5,
        ToolPurposeDebugMarkersBitExt = 1 << 6
    }
}