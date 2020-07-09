// Copyright 2020-2020 Volk Project
// Licensed under Apache License 2.0 or any later version
// Refer to the LICENSE.md file included.

using SampleMask = System.UInt32;
using Bool32 = System.UInt32;
using Flags = System.UInt32;
using DeviceSize = System.UInt64;
using DeviceAddress = System.UInt64;

namespace Volk.Vulkan.Types {
	public enum AttachmentLoadOp {
		AttachmentLoadOpLoad = 0,
		AttachmentLoadOpClear = 1,
		AttachmentLoadOpDontCare = 2
	}

	public enum AttachmentStoreOp {
		AttachmentStoreOpStore = 0,
		AttachmentStoreOpDontCare = 1,
		AttachmentStoreOpNoneQcom = 1000301000
	}

	public enum BlendFactor {
		BlendFactorZero = 0,
		BlendFactorOne = 1,
		BlendFactorSrcColor = 2,
		BlendFactorOneMinusSrcColor = 3,
		BlendFactorDstColor = 4,
		BlendFactorOneMinusDstColor = 5,
		BlendFactorSrcAlpha = 6,
		BlendFactorOneMinusSrcAlpha = 7,
		BlendFactorDstAlpha = 8,
		BlendFactorOneMinusDstAlpha = 9,
		BlendFactorConstantColor = 10,
		BlendFactorOneMinusConstantColor = 11,
		BlendFactorConstantAlpha = 12,
		BlendFactorOneMinusConstantAlpha = 13,
		BlendFactorSrcAlphaSaturate = 14,
		BlendFactorSrc1Color = 15,
		BlendFactorOneMinusSrc1Color = 16,
		BlendFactorSrc1Alpha = 17,
		BlendFactorOneMinusSrc1Alpha = 18
	}

	public enum BlendOp {
		BlendOpAdd = 0,
		BlendOpSubtract = 1,
		BlendOpReverseSubtract = 2,
		BlendOpMin = 3,
		BlendOpMax = 4,
		BlendOpZeroExt = 1000148000,
		BlendOpSrcExt = 1000148001,
		BlendOpDstExt = 1000148002,
		BlendOpSrcOverExt = 1000148003,
		BlendOpDstOverExt = 1000148004,
		BlendOpSrcInExt = 1000148005,
		BlendOpDstInExt = 1000148006,
		BlendOpSrcOutExt = 1000148007,
		BlendOpDstOutExt = 1000148008,
		BlendOpSrcAtopExt = 1000148009,
		BlendOpDstAtopExt = 1000148010,
		BlendOpXorExt = 1000148011,
		BlendOpMultiplyExt = 1000148012,
		BlendOpScreenExt = 1000148013,
		BlendOpOverlayExt = 1000148014,
		BlendOpDarkenExt = 1000148015,
		BlendOpLightenExt = 1000148016,
		BlendOpColordodgeExt = 1000148017,
		BlendOpColorburnExt = 1000148018,
		BlendOpHardlightExt = 1000148019,
		BlendOpSoftlightExt = 1000148020,
		BlendOpDifferenceExt = 1000148021,
		BlendOpExclusionExt = 1000148022,
		BlendOpInvertExt = 1000148023,
		BlendOpInvertRgbExt = 1000148024,
		BlendOpLineardodgeExt = 1000148025,
		BlendOpLinearburnExt = 1000148026,
		BlendOpVividlightExt = 1000148027,
		BlendOpLinearlightExt = 1000148028,
		BlendOpPinlightExt = 1000148029,
		BlendOpHardmixExt = 1000148030,
		BlendOpHslHueExt = 1000148031,
		BlendOpHslSaturationExt = 1000148032,
		BlendOpHslColorExt = 1000148033,
		BlendOpHslLuminosityExt = 1000148034,
		BlendOpPlusExt = 1000148035,
		BlendOpPlusClampedExt = 1000148036,
		BlendOpPlusClampedAlphaExt = 1000148037,
		BlendOpPlusDarkerExt = 1000148038,
		BlendOpMinusExt = 1000148039,
		BlendOpMinusClampedExt = 1000148040,
		BlendOpContrastExt = 1000148041,
		BlendOpInvertOvgExt = 1000148042,
		BlendOpRedExt = 1000148043,
		BlendOpGreenExt = 1000148044,
		BlendOpBlueExt = 1000148045
	}

	public enum BorderColor {
		BorderColorFloatTransparentBlack = 0,
		BorderColorIntTransparentBlack = 1,
		BorderColorFloatOpaqueBlack = 2,
		BorderColorIntOpaqueBlack = 3,
		BorderColorFloatOpaqueWhite = 4,
		BorderColorIntOpaqueWhite = 5,
		BorderColorFloatCustomExt = 1000287003,
		BorderColorIntCustomExt = 1000287004
	}

	public enum QueryPoolCreateFlagBits {

	}

	public enum PipelineCacheHeaderVersion {
		PipelineCacheHeaderVersionOne = 1
	}

	public enum InstanceCreateFlagBits {

	}

	public enum ComponentSwizzle {
		ComponentSwizzleIdentity = 0,
		ComponentSwizzleZero = 1,
		ComponentSwizzleOne = 2,
		ComponentSwizzleR = 3,
		ComponentSwizzleG = 4,
		ComponentSwizzleB = 5,
		ComponentSwizzleA = 6
	}

	public enum CommandBufferLevel {
		CommandBufferLevelPrimary = 0,
		CommandBufferLevelSecondary = 1
	}

	public enum CompareOp {
		CompareOpNever = 0,
		CompareOpLess = 1,
		CompareOpEqual = 2,
		CompareOpLessOrEqual = 3,
		CompareOpGreater = 4,
		CompareOpNotEqual = 5,
		CompareOpGreaterOrEqual = 6,
		CompareOpAlways = 7
	}

	public enum DescriptorType {
		DescriptorTypeSampler = 0,
		DescriptorTypeCombinedImageSampler = 1,
		DescriptorTypeSampledImage = 2,
		DescriptorTypeStorageImage = 3,
		DescriptorTypeUniformTexelBuffer = 4,
		DescriptorTypeStorageTexelBuffer = 5,
		DescriptorTypeUniformBuffer = 6,
		DescriptorTypeStorageBuffer = 7,
		DescriptorTypeUniformBufferDynamic = 8,
		DescriptorTypeStorageBufferDynamic = 9,
		DescriptorTypeInputAttachment = 10,
		DescriptorTypeInlineUniformBlockExt = 1000138000,
		DescriptorTypeAccelerationStructureKhr = 1000165000,
		DescriptorTypeAccelerationStructureNv = DescriptorTypeAccelerationStructureKhr
	}

	public enum DeviceCreateFlagBits {

	}

	public enum DynamicState {
		DynamicStateViewport = 0,
		DynamicStateScissor = 1,
		DynamicStateLineWidth = 2,
		DynamicStateDepthBias = 3,
		DynamicStateBlendConstants = 4,
		DynamicStateDepthBounds = 5,
		DynamicStateStencilCompareMask = 6,
		DynamicStateStencilWriteMask = 7,
		DynamicStateStencilReference = 8,
		DynamicStateViewportWScalingNv = 1000087000,
		DynamicStateDiscardRectangleExt = 1000099000,
		DynamicStateSampleLocationsExt = 1000143000,
		DynamicStateViewportShadingRatePaletteNv = 1000164004,
		DynamicStateViewportCoarseSampleOrderNv = 1000164006,
		DynamicStateExclusiveScissorNv = 1000205001,
		DynamicStateLineStippleExt = 1000259000,
		DynamicStateCullModeExt = 1000267000,
		DynamicStateFrontFaceExt = 1000267001,
		DynamicStatePrimitiveTopologyExt = 1000267002,
		DynamicStateViewportWithCountExt = 1000267003,
		DynamicStateScissorWithCountExt = 1000267004,
		DynamicStateVertexInputBindingStrideExt = 1000267005,
		DynamicStateDepthTestEnableExt = 1000267006,
		DynamicStateDepthWriteEnableExt = 1000267007,
		DynamicStateDepthCompareOpExt = 1000267008,
		DynamicStateDepthBoundsTestEnableExt = 1000267009,
		DynamicStateStencilTestEnableExt = 1000267010,
		DynamicStateStencilOpExt = 1000267011
	}

	public enum PolygonMode {
		PolygonModeFill = 0,
		PolygonModeLine = 1,
		PolygonModePoint = 2,
		PolygonModeFillRectangleNv = 1000153000
	}

	public enum Format {
		FormatUndefined = 0,
		FormatR4g4UnormPack8 = 1,
		FormatR4g4b4a4UnormPack16 = 2,
		FormatB4g4r4a4UnormPack16 = 3,
		FormatR5g6b5UnormPack16 = 4,
		FormatB5g6r5UnormPack16 = 5,
		FormatR5g5b5a1UnormPack16 = 6,
		FormatB5g5r5a1UnormPack16 = 7,
		FormatA1r5g5b5UnormPack16 = 8,
		FormatR8Unorm = 9,
		FormatR8Snorm = 10,
		FormatR8Uscaled = 11,
		FormatR8Sscaled = 12,
		FormatR8Uint = 13,
		FormatR8Sint = 14,
		FormatR8Srgb = 15,
		FormatR8g8Unorm = 16,
		FormatR8g8Snorm = 17,
		FormatR8g8Uscaled = 18,
		FormatR8g8Sscaled = 19,
		FormatR8g8Uint = 20,
		FormatR8g8Sint = 21,
		FormatR8g8Srgb = 22,
		FormatR8g8b8Unorm = 23,
		FormatR8g8b8Snorm = 24,
		FormatR8g8b8Uscaled = 25,
		FormatR8g8b8Sscaled = 26,
		FormatR8g8b8Uint = 27,
		FormatR8g8b8Sint = 28,
		FormatR8g8b8Srgb = 29,
		FormatB8g8r8Unorm = 30,
		FormatB8g8r8Snorm = 31,
		FormatB8g8r8Uscaled = 32,
		FormatB8g8r8Sscaled = 33,
		FormatB8g8r8Uint = 34,
		FormatB8g8r8Sint = 35,
		FormatB8g8r8Srgb = 36,
		FormatR8g8b8a8Unorm = 37,
		FormatR8g8b8a8Snorm = 38,
		FormatR8g8b8a8Uscaled = 39,
		FormatR8g8b8a8Sscaled = 40,
		FormatR8g8b8a8Uint = 41,
		FormatR8g8b8a8Sint = 42,
		FormatR8g8b8a8Srgb = 43,
		FormatB8g8r8a8Unorm = 44,
		FormatB8g8r8a8Snorm = 45,
		FormatB8g8r8a8Uscaled = 46,
		FormatB8g8r8a8Sscaled = 47,
		FormatB8g8r8a8Uint = 48,
		FormatB8g8r8a8Sint = 49,
		FormatB8g8r8a8Srgb = 50,
		FormatA8b8g8r8UnormPack32 = 51,
		FormatA8b8g8r8SnormPack32 = 52,
		FormatA8b8g8r8UscaledPack32 = 53,
		FormatA8b8g8r8SscaledPack32 = 54,
		FormatA8b8g8r8UintPack32 = 55,
		FormatA8b8g8r8SintPack32 = 56,
		FormatA8b8g8r8SrgbPack32 = 57,
		FormatA2r10g10b10UnormPack32 = 58,
		FormatA2r10g10b10SnormPack32 = 59,
		FormatA2r10g10b10UscaledPack32 = 60,
		FormatA2r10g10b10SscaledPack32 = 61,
		FormatA2r10g10b10UintPack32 = 62,
		FormatA2r10g10b10SintPack32 = 63,
		FormatA2b10g10r10UnormPack32 = 64,
		FormatA2b10g10r10SnormPack32 = 65,
		FormatA2b10g10r10UscaledPack32 = 66,
		FormatA2b10g10r10SscaledPack32 = 67,
		FormatA2b10g10r10UintPack32 = 68,
		FormatA2b10g10r10SintPack32 = 69,
		FormatR16Unorm = 70,
		FormatR16Snorm = 71,
		FormatR16Uscaled = 72,
		FormatR16Sscaled = 73,
		FormatR16Uint = 74,
		FormatR16Sint = 75,
		FormatR16Sfloat = 76,
		FormatR16g16Unorm = 77,
		FormatR16g16Snorm = 78,
		FormatR16g16Uscaled = 79,
		FormatR16g16Sscaled = 80,
		FormatR16g16Uint = 81,
		FormatR16g16Sint = 82,
		FormatR16g16Sfloat = 83,
		FormatR16g16b16Unorm = 84,
		FormatR16g16b16Snorm = 85,
		FormatR16g16b16Uscaled = 86,
		FormatR16g16b16Sscaled = 87,
		FormatR16g16b16Uint = 88,
		FormatR16g16b16Sint = 89,
		FormatR16g16b16Sfloat = 90,
		FormatR16g16b16a16Unorm = 91,
		FormatR16g16b16a16Snorm = 92,
		FormatR16g16b16a16Uscaled = 93,
		FormatR16g16b16a16Sscaled = 94,
		FormatR16g16b16a16Uint = 95,
		FormatR16g16b16a16Sint = 96,
		FormatR16g16b16a16Sfloat = 97,
		FormatR32Uint = 98,
		FormatR32Sint = 99,
		FormatR32Sfloat = 100,
		FormatR32g32Uint = 101,
		FormatR32g32Sint = 102,
		FormatR32g32Sfloat = 103,
		FormatR32g32b32Uint = 104,
		FormatR32g32b32Sint = 105,
		FormatR32g32b32Sfloat = 106,
		FormatR32g32b32a32Uint = 107,
		FormatR32g32b32a32Sint = 108,
		FormatR32g32b32a32Sfloat = 109,
		FormatR64Uint = 110,
		FormatR64Sint = 111,
		FormatR64Sfloat = 112,
		FormatR64g64Uint = 113,
		FormatR64g64Sint = 114,
		FormatR64g64Sfloat = 115,
		FormatR64g64b64Uint = 116,
		FormatR64g64b64Sint = 117,
		FormatR64g64b64Sfloat = 118,
		FormatR64g64b64a64Uint = 119,
		FormatR64g64b64a64Sint = 120,
		FormatR64g64b64a64Sfloat = 121,
		FormatB10g11r11UfloatPack32 = 122,
		FormatE5b9g9r9UfloatPack32 = 123,
		FormatD16Unorm = 124,
		FormatX8D24UnormPack32 = 125,
		FormatD32Sfloat = 126,
		FormatS8Uint = 127,
		FormatD16UnormS8Uint = 128,
		FormatD24UnormS8Uint = 129,
		FormatD32SfloatS8Uint = 130,
		FormatBc1RgbUnormBlock = 131,
		FormatBc1RgbSrgbBlock = 132,
		FormatBc1RgbaUnormBlock = 133,
		FormatBc1RgbaSrgbBlock = 134,
		FormatBc2UnormBlock = 135,
		FormatBc2SrgbBlock = 136,
		FormatBc3UnormBlock = 137,
		FormatBc3SrgbBlock = 138,
		FormatBc4UnormBlock = 139,
		FormatBc4SnormBlock = 140,
		FormatBc5UnormBlock = 141,
		FormatBc5SnormBlock = 142,
		FormatBc6hUfloatBlock = 143,
		FormatBc6hSfloatBlock = 144,
		FormatBc7UnormBlock = 145,
		FormatBc7SrgbBlock = 146,
		FormatEtc2R8g8b8UnormBlock = 147,
		FormatEtc2R8g8b8SrgbBlock = 148,
		FormatEtc2R8g8b8a1UnormBlock = 149,
		FormatEtc2R8g8b8a1SrgbBlock = 150,
		FormatEtc2R8g8b8a8UnormBlock = 151,
		FormatEtc2R8g8b8a8SrgbBlock = 152,
		FormatEacR11UnormBlock = 153,
		FormatEacR11SnormBlock = 154,
		FormatEacR11g11UnormBlock = 155,
		FormatEacR11g11SnormBlock = 156,
		FormatAstc4x4UnormBlock = 157,
		FormatAstc4x4SrgbBlock = 158,
		FormatAstc5x4UnormBlock = 159,
		FormatAstc5x4SrgbBlock = 160,
		FormatAstc5x5UnormBlock = 161,
		FormatAstc5x5SrgbBlock = 162,
		FormatAstc6x5UnormBlock = 163,
		FormatAstc6x5SrgbBlock = 164,
		FormatAstc6x6UnormBlock = 165,
		FormatAstc6x6SrgbBlock = 166,
		FormatAstc8x5UnormBlock = 167,
		FormatAstc8x5SrgbBlock = 168,
		FormatAstc8x6UnormBlock = 169,
		FormatAstc8x6SrgbBlock = 170,
		FormatAstc8x8UnormBlock = 171,
		FormatAstc8x8SrgbBlock = 172,
		FormatAstc10x5UnormBlock = 173,
		FormatAstc10x5SrgbBlock = 174,
		FormatAstc10x6UnormBlock = 175,
		FormatAstc10x6SrgbBlock = 176,
		FormatAstc10x8UnormBlock = 177,
		FormatAstc10x8SrgbBlock = 178,
		FormatAstc10x10UnormBlock = 179,
		FormatAstc10x10SrgbBlock = 180,
		FormatAstc12x10UnormBlock = 181,
		FormatAstc12x10SrgbBlock = 182,
		FormatAstc12x12UnormBlock = 183,
		FormatAstc12x12SrgbBlock = 184,
		FormatG8b8g8r8422Unorm = 1000156000,
		FormatB8g8r8g8422Unorm = 1000156001,
		FormatG8B8R83plane420Unorm = 1000156002,
		FormatG8B8r82plane420Unorm = 1000156003,
		FormatG8B8R83plane422Unorm = 1000156004,
		FormatG8B8r82plane422Unorm = 1000156005,
		FormatG8B8R83plane444Unorm = 1000156006,
		FormatR10x6UnormPack16 = 1000156007,
		FormatR10x6g10x6Unorm2pack16 = 1000156008,
		FormatR10x6g10x6b10x6a10x6Unorm4pack16 = 1000156009,
		FormatG10x6b10x6g10x6r10x6422Unorm4pack16 = 1000156010,
		FormatB10x6g10x6r10x6g10x6422Unorm4pack16 = 1000156011,
		FormatG10x6B10x6R10x63plane420Unorm3pack16 = 1000156012,
		FormatG10x6B10x6r10x62plane420Unorm3pack16 = 1000156013,
		FormatG10x6B10x6R10x63plane422Unorm3pack16 = 1000156014,
		FormatG10x6B10x6r10x62plane422Unorm3pack16 = 1000156015,
		FormatG10x6B10x6R10x63plane444Unorm3pack16 = 1000156016,
		FormatR12x4UnormPack16 = 1000156017,
		FormatR12x4g12x4Unorm2pack16 = 1000156018,
		FormatR12x4g12x4b12x4a12x4Unorm4pack16 = 1000156019,
		FormatG12x4b12x4g12x4r12x4422Unorm4pack16 = 1000156020,
		FormatB12x4g12x4r12x4g12x4422Unorm4pack16 = 1000156021,
		FormatG12x4B12x4R12x43plane420Unorm3pack16 = 1000156022,
		FormatG12x4B12x4r12x42plane420Unorm3pack16 = 1000156023,
		FormatG12x4B12x4R12x43plane422Unorm3pack16 = 1000156024,
		FormatG12x4B12x4r12x42plane422Unorm3pack16 = 1000156025,
		FormatG12x4B12x4R12x43plane444Unorm3pack16 = 1000156026,
		FormatG16b16g16r16422Unorm = 1000156027,
		FormatB16g16r16g16422Unorm = 1000156028,
		FormatG16B16R163plane420Unorm = 1000156029,
		FormatG16B16r162plane420Unorm = 1000156030,
		FormatG16B16R163plane422Unorm = 1000156031,
		FormatG16B16r162plane422Unorm = 1000156032,
		FormatG16B16R163plane444Unorm = 1000156033,
		FormatPvrtc12bppUnormBlockImg = 1000054000,
		FormatPvrtc14bppUnormBlockImg = 1000054001,
		FormatPvrtc22bppUnormBlockImg = 1000054002,
		FormatPvrtc24bppUnormBlockImg = 1000054003,
		FormatPvrtc12bppSrgbBlockImg = 1000054004,
		FormatPvrtc14bppSrgbBlockImg = 1000054005,
		FormatPvrtc22bppSrgbBlockImg = 1000054006,
		FormatPvrtc24bppSrgbBlockImg = 1000054007,
		FormatAstc4x4SfloatBlockExt = 1000066000,
		FormatAstc5x4SfloatBlockExt = 1000066001,
		FormatAstc5x5SfloatBlockExt = 1000066002,
		FormatAstc6x5SfloatBlockExt = 1000066003,
		FormatAstc6x6SfloatBlockExt = 1000066004,
		FormatAstc8x5SfloatBlockExt = 1000066005,
		FormatAstc8x6SfloatBlockExt = 1000066006,
		FormatAstc8x8SfloatBlockExt = 1000066007,
		FormatAstc10x5SfloatBlockExt = 1000066008,
		FormatAstc10x6SfloatBlockExt = 1000066009,
		FormatAstc10x8SfloatBlockExt = 1000066010,
		FormatAstc10x10SfloatBlockExt = 1000066011,
		FormatAstc12x10SfloatBlockExt = 1000066012,
		FormatAstc12x12SfloatBlockExt = 1000066013,
		FormatG8b8g8r8422UnormKhr = FormatG8b8g8r8422Unorm,
		FormatB8g8r8g8422UnormKhr = FormatB8g8r8g8422Unorm,
		FormatG8B8R83plane420UnormKhr = FormatG8B8R83plane420Unorm,
		FormatG8B8r82plane420UnormKhr = FormatG8B8r82plane420Unorm,
		FormatG8B8R83plane422UnormKhr = FormatG8B8R83plane422Unorm,
		FormatG8B8r82plane422UnormKhr = FormatG8B8r82plane422Unorm,
		FormatG8B8R83plane444UnormKhr = FormatG8B8R83plane444Unorm,
		FormatR10x6UnormPack16Khr = FormatR10x6UnormPack16,
		FormatR10x6g10x6Unorm2pack16Khr = FormatR10x6g10x6Unorm2pack16,
		FormatR10x6g10x6b10x6a10x6Unorm4pack16Khr = FormatR10x6g10x6b10x6a10x6Unorm4pack16,
		FormatG10x6b10x6g10x6r10x6422Unorm4pack16Khr = FormatG10x6b10x6g10x6r10x6422Unorm4pack16,
		FormatB10x6g10x6r10x6g10x6422Unorm4pack16Khr = FormatB10x6g10x6r10x6g10x6422Unorm4pack16,
		FormatG10x6B10x6R10x63plane420Unorm3pack16Khr = FormatG10x6B10x6R10x63plane420Unorm3pack16,
		FormatG10x6B10x6r10x62plane420Unorm3pack16Khr = FormatG10x6B10x6r10x62plane420Unorm3pack16,
		FormatG10x6B10x6R10x63plane422Unorm3pack16Khr = FormatG10x6B10x6R10x63plane422Unorm3pack16,
		FormatG10x6B10x6r10x62plane422Unorm3pack16Khr = FormatG10x6B10x6r10x62plane422Unorm3pack16,
		FormatG10x6B10x6R10x63plane444Unorm3pack16Khr = FormatG10x6B10x6R10x63plane444Unorm3pack16,
		FormatR12x4UnormPack16Khr = FormatR12x4UnormPack16,
		FormatR12x4g12x4Unorm2pack16Khr = FormatR12x4g12x4Unorm2pack16,
		FormatR12x4g12x4b12x4a12x4Unorm4pack16Khr = FormatR12x4g12x4b12x4a12x4Unorm4pack16,
		FormatG12x4b12x4g12x4r12x4422Unorm4pack16Khr = FormatG12x4b12x4g12x4r12x4422Unorm4pack16,
		FormatB12x4g12x4r12x4g12x4422Unorm4pack16Khr = FormatB12x4g12x4r12x4g12x4422Unorm4pack16,
		FormatG12x4B12x4R12x43plane420Unorm3pack16Khr = FormatG12x4B12x4R12x43plane420Unorm3pack16,
		FormatG12x4B12x4r12x42plane420Unorm3pack16Khr = FormatG12x4B12x4r12x42plane420Unorm3pack16,
		FormatG12x4B12x4R12x43plane422Unorm3pack16Khr = FormatG12x4B12x4R12x43plane422Unorm3pack16,
		FormatG12x4B12x4r12x42plane422Unorm3pack16Khr = FormatG12x4B12x4r12x42plane422Unorm3pack16,
		FormatG12x4B12x4R12x43plane444Unorm3pack16Khr = FormatG12x4B12x4R12x43plane444Unorm3pack16,
		FormatG16b16g16r16422UnormKhr = FormatG16b16g16r16422Unorm,
		FormatB16g16r16g16422UnormKhr = FormatB16g16r16g16422Unorm,
		FormatG16B16R163plane420UnormKhr = FormatG16B16R163plane420Unorm,
		FormatG16B16r162plane420UnormKhr = FormatG16B16r162plane420Unorm,
		FormatG16B16R163plane422UnormKhr = FormatG16B16R163plane422Unorm,
		FormatG16B16r162plane422UnormKhr = FormatG16B16r162plane422Unorm,
		FormatG16B16R163plane444UnormKhr = FormatG16B16R163plane444Unorm,
		FormatAstc3x3x3UnormBlockExt = 1000288000,
		FormatAstc3x3x3SrgbBlockExt = 1000288001,
		FormatAstc3x3x3SfloatBlockExt = 1000288002,
		FormatAstc4x3x3UnormBlockExt = 1000288003,
		FormatAstc4x3x3SrgbBlockExt = 1000288004,
		FormatAstc4x3x3SfloatBlockExt = 1000288005,
		FormatAstc4x4x3UnormBlockExt = 1000288006,
		FormatAstc4x4x3SrgbBlockExt = 1000288007,
		FormatAstc4x4x3SfloatBlockExt = 1000288008,
		FormatAstc4x4x4UnormBlockExt = 1000288009,
		FormatAstc4x4x4SrgbBlockExt = 1000288010,
		FormatAstc4x4x4SfloatBlockExt = 1000288011,
		FormatAstc5x4x4UnormBlockExt = 1000288012,
		FormatAstc5x4x4SrgbBlockExt = 1000288013,
		FormatAstc5x4x4SfloatBlockExt = 1000288014,
		FormatAstc5x5x4UnormBlockExt = 1000288015,
		FormatAstc5x5x4SrgbBlockExt = 1000288016,
		FormatAstc5x5x4SfloatBlockExt = 1000288017,
		FormatAstc5x5x5UnormBlockExt = 1000288018,
		FormatAstc5x5x5SrgbBlockExt = 1000288019,
		FormatAstc5x5x5SfloatBlockExt = 1000288020,
		FormatAstc6x5x5UnormBlockExt = 1000288021,
		FormatAstc6x5x5SrgbBlockExt = 1000288022,
		FormatAstc6x5x5SfloatBlockExt = 1000288023,
		FormatAstc6x6x5UnormBlockExt = 1000288024,
		FormatAstc6x6x5SrgbBlockExt = 1000288025,
		FormatAstc6x6x5SfloatBlockExt = 1000288026,
		FormatAstc6x6x6UnormBlockExt = 1000288027,
		FormatAstc6x6x6SrgbBlockExt = 1000288028,
		FormatAstc6x6x6SfloatBlockExt = 1000288029
	}

	public enum FrontFace {
		FrontFaceCounterClockwise = 0,
		FrontFaceClockwise = 1
	}

	public enum ImageLayout {
		ImageLayoutUndefined = 0,
		ImageLayoutGeneral = 1,
		ImageLayoutColorAttachmentOptimal = 2,
		ImageLayoutDepthStencilAttachmentOptimal = 3,
		ImageLayoutDepthStencilReadOnlyOptimal = 4,
		ImageLayoutShaderReadOnlyOptimal = 5,
		ImageLayoutTransferSrcOptimal = 6,
		ImageLayoutTransferDstOptimal = 7,
		ImageLayoutPreinitialized = 8,
		ImageLayoutDepthReadOnlyStencilAttachmentOptimal = 1000117000,
		ImageLayoutDepthAttachmentStencilReadOnlyOptimal = 1000117001,
		ImageLayoutDepthAttachmentOptimal = 1000241000,
		ImageLayoutDepthReadOnlyOptimal = 1000241001,
		ImageLayoutStencilAttachmentOptimal = 1000241002,
		ImageLayoutStencilReadOnlyOptimal = 1000241003,
		ImageLayoutPresentSrcKhr = 1000001002,
		ImageLayoutSharedPresentKhr = 1000111000,
		ImageLayoutDepthReadOnlyStencilAttachmentOptimalKhr = ImageLayoutDepthReadOnlyStencilAttachmentOptimal,
		ImageLayoutDepthAttachmentStencilReadOnlyOptimalKhr = ImageLayoutDepthAttachmentStencilReadOnlyOptimal,
		ImageLayoutShadingRateOptimalNv = 1000164003,
		ImageLayoutFragmentDensityMapOptimalExt = 1000218000,
		ImageLayoutDepthAttachmentOptimalKhr = ImageLayoutDepthAttachmentOptimal,
		ImageLayoutDepthReadOnlyOptimalKhr = ImageLayoutDepthReadOnlyOptimal,
		ImageLayoutStencilAttachmentOptimalKhr = ImageLayoutStencilAttachmentOptimal,
		ImageLayoutStencilReadOnlyOptimalKhr = ImageLayoutStencilReadOnlyOptimal
	}

	public enum ImageTiling {
		ImageTilingOptimal = 0,
		ImageTilingLinear = 1,
		ImageTilingDrmFormatModifierExt = 1000158000
	}

	public enum ImageType {
		ImageType1d = 0,
		ImageType2d = 1,
		ImageType3d = 2
	}

	public enum ImageViewType {
		ImageViewType1d = 0,
		ImageViewType2d = 1,
		ImageViewType3d = 2,
		ImageViewTypeCube = 3,
		ImageViewType1dArray = 4,
		ImageViewType2dArray = 5,
		ImageViewTypeCubeArray = 6
	}

	public enum SharingMode {
		SharingModeExclusive = 0,
		SharingModeConcurrent = 1
	}

	public enum IndexType {
		IndexTypeUint16 = 0,
		IndexTypeUint32 = 1,
		IndexTypeNoneKhr = 1000165000,
		IndexTypeNoneNv = IndexTypeNoneKhr,
		IndexTypeUint8Ext = 1000265000
	}

	public enum LogicOp {
		LogicOpClear = 0,
		LogicOpAnd = 1,
		LogicOpAndReverse = 2,
		LogicOpCopy = 3,
		LogicOpAndInverted = 4,
		LogicOpNoOp = 5,
		LogicOpXor = 6,
		LogicOpOr = 7,
		LogicOpNor = 8,
		LogicOpEquivalent = 9,
		LogicOpInvert = 10,
		LogicOpOrReverse = 11,
		LogicOpCopyInverted = 12,
		LogicOpOrInverted = 13,
		LogicOpNand = 14,
		LogicOpSet = 15
	}

	public enum PhysicalDeviceType {
		PhysicalDeviceTypeOther = 0,
		PhysicalDeviceTypeIntegratedGpu = 1,
		PhysicalDeviceTypeDiscreteGpu = 2,
		PhysicalDeviceTypeVirtualGpu = 3,
		PhysicalDeviceTypeCpu = 4
	}

	public enum PipelineBindPoint {
		PipelineBindPointGraphics = 0,
		PipelineBindPointCompute = 1,
		PipelineBindPointRayTracingKhr = 1000165000,
		PipelineBindPointRayTracingNv = PipelineBindPointRayTracingKhr
	}

	public enum PrimitiveTopology {
		PrimitiveTopologyPointList = 0,
		PrimitiveTopologyLineList = 1,
		PrimitiveTopologyLineStrip = 2,
		PrimitiveTopologyTriangleList = 3,
		PrimitiveTopologyTriangleStrip = 4,
		PrimitiveTopologyTriangleFan = 5,
		PrimitiveTopologyLineListWithAdjacency = 6,
		PrimitiveTopologyLineStripWithAdjacency = 7,
		PrimitiveTopologyTriangleListWithAdjacency = 8,
		PrimitiveTopologyTriangleStripWithAdjacency = 9,
		PrimitiveTopologyPatchList = 10
	}

	public enum QueryType {
		QueryTypeOcclusion = 0,
		QueryTypePipelineStatistics = 1,
		QueryTypeTimestamp = 2,
		QueryTypeReserved8 = 1000023008,
		QueryTypeReserved4 = 1000024004,
		QueryTypeTransformFeedbackStreamExt = 1000028004,
		QueryTypePerformanceQueryKhr = 1000116000,
		QueryTypeAccelerationStructureCompactedSizeKhr = 1000165000,
		QueryTypeAccelerationStructureSerializationSizeKhr = 1000150000,
		QueryTypeAccelerationStructureCompactedSizeNv = QueryTypeAccelerationStructureCompactedSizeKhr,
		QueryTypePerformanceQueryIntel = 1000210000
	}

	public enum SubpassContents {
		SubpassContentsInline = 0,
		SubpassContentsSecondaryCommandBuffers = 1
	}

	public enum Result {
		Success = 0,
		NotReady = 1,
		Timeout = 2,
		EventSet = 3,
		EventReset = 4,
		Incomplete = 5,
		ErrorOutOfHostMemory = -1,
		ErrorOutOfDeviceMemory = -2,
		ErrorInitializationFailed = -3,
		ErrorDeviceLost = -4,
		ErrorMemoryMapFailed = -5,
		ErrorLayerNotPresent = -6,
		ErrorExtensionNotPresent = -7,
		ErrorFeatureNotPresent = -8,
		ErrorIncompatibleDriver = -9,
		ErrorTooManyObjects = -10,
		ErrorFormatNotSupported = -11,
		ErrorFragmentedPool = -12,
		ErrorUnknown = -13,
		ErrorOutOfPoolMemory = -1000069000,
		ErrorInvalidExternalHandle = -1000072003,
		ErrorFragmentation = -1000161000,
		ErrorInvalidOpaqueCaptureAddress = -1000257000,
		ErrorSurfaceLostKhr = -1000000000,
		ErrorNativeWindowInUseKhr = -1000000001,
		SuboptimalKhr = 1000001003,
		ErrorOutOfDateKhr = -1000001004,
		ErrorIncompatibleDisplayKhr = -1000003001,
		ErrorValidationFailedExt = -1000011001,
		ErrorInvalidShaderNv = -1000012000,
		ErrorOutOfPoolMemoryKhr = ErrorOutOfPoolMemory,
		ErrorInvalidExternalHandleKhr = ErrorInvalidExternalHandle,
		ErrorIncompatibleVersionKhr = -1000150000,
		ErrorInvalidDrmFormatModifierPlaneLayoutExt = -1000158000,
		ErrorFragmentationExt = ErrorFragmentation,
		ErrorNotPermittedExt = -1000174001,
		ErrorInvalidDeviceAddressExt = ErrorInvalidOpaqueCaptureAddress,
		ErrorFullScreenExclusiveModeLostExt = -1000255000,
		ErrorInvalidOpaqueCaptureAddressKhr = ErrorInvalidOpaqueCaptureAddress,
		ThreadIdleKhr = 1000268000,
		ThreadDoneKhr = 1000268001,
		OperationDeferredKhr = 1000268002,
		OperationNotDeferredKhr = 1000268003,
		PipelineCompileRequiredExt = 1000297000,
		ErrorPipelineCompileRequiredExt = PipelineCompileRequiredExt
	}

	public enum StencilOp {
		StencilOpKeep = 0,
		StencilOpZero = 1,
		StencilOpReplace = 2,
		StencilOpIncrementAndClamp = 3,
		StencilOpDecrementAndClamp = 4,
		StencilOpInvert = 5,
		StencilOpIncrementAndWrap = 6,
		StencilOpDecrementAndWrap = 7
	}

	public enum StructureType {
		StructureTypeApplicationInfo = 0,
		StructureTypeInstanceCreateInfo = 1,
		StructureTypeDeviceQueueCreateInfo = 2,
		StructureTypeDeviceCreateInfo = 3,
		StructureTypeSubmitInfo = 4,
		StructureTypeMemoryAllocateInfo = 5,
		StructureTypeMappedMemoryRange = 6,
		StructureTypeBindSparseInfo = 7,
		StructureTypeFenceCreateInfo = 8,
		StructureTypeSemaphoreCreateInfo = 9,
		StructureTypeEventCreateInfo = 10,
		StructureTypeQueryPoolCreateInfo = 11,
		StructureTypeBufferCreateInfo = 12,
		StructureTypeBufferViewCreateInfo = 13,
		StructureTypeImageCreateInfo = 14,
		StructureTypeImageViewCreateInfo = 15,
		StructureTypeShaderModuleCreateInfo = 16,
		StructureTypePipelineCacheCreateInfo = 17,
		StructureTypePipelineShaderStageCreateInfo = 18,
		StructureTypePipelineVertexInputStateCreateInfo = 19,
		StructureTypePipelineInputAssemblyStateCreateInfo = 20,
		StructureTypePipelineTessellationStateCreateInfo = 21,
		StructureTypePipelineViewportStateCreateInfo = 22,
		StructureTypePipelineRasterizationStateCreateInfo = 23,
		StructureTypePipelineMultisampleStateCreateInfo = 24,
		StructureTypePipelineDepthStencilStateCreateInfo = 25,
		StructureTypePipelineColorBlendStateCreateInfo = 26,
		StructureTypePipelineDynamicStateCreateInfo = 27,
		StructureTypeGraphicsPipelineCreateInfo = 28,
		StructureTypeComputePipelineCreateInfo = 29,
		StructureTypePipelineLayoutCreateInfo = 30,
		StructureTypeSamplerCreateInfo = 31,
		StructureTypeDescriptorSetLayoutCreateInfo = 32,
		StructureTypeDescriptorPoolCreateInfo = 33,
		StructureTypeDescriptorSetAllocateInfo = 34,
		StructureTypeWriteDescriptorSet = 35,
		StructureTypeCopyDescriptorSet = 36,
		StructureTypeFramebufferCreateInfo = 37,
		StructureTypeRenderPassCreateInfo = 38,
		StructureTypeCommandPoolCreateInfo = 39,
		StructureTypeCommandBufferAllocateInfo = 40,
		StructureTypeCommandBufferInheritanceInfo = 41,
		StructureTypeCommandBufferBeginInfo = 42,
		StructureTypeRenderPassBeginInfo = 43,
		StructureTypeBufferMemoryBarrier = 44,
		StructureTypeImageMemoryBarrier = 45,
		StructureTypeMemoryBarrier = 46,
		StructureTypeLoaderInstanceCreateInfo = 47,
		StructureTypeLoaderDeviceCreateInfo = 48,
		StructureTypePhysicalDeviceSubgroupProperties = 1000094000,
		StructureTypeBindBufferMemoryInfo = 1000157000,
		StructureTypeBindImageMemoryInfo = 1000157001,
		StructureTypePhysicalDevice16bitStorageFeatures = 1000083000,
		StructureTypeMemoryDedicatedRequirements = 1000127000,
		StructureTypeMemoryDedicatedAllocateInfo = 1000127001,
		StructureTypeMemoryAllocateFlagsInfo = 1000060000,
		StructureTypeDeviceGroupRenderPassBeginInfo = 1000060003,
		StructureTypeDeviceGroupCommandBufferBeginInfo = 1000060004,
		StructureTypeDeviceGroupSubmitInfo = 1000060005,
		StructureTypeDeviceGroupBindSparseInfo = 1000060006,
		StructureTypeBindBufferMemoryDeviceGroupInfo = 1000060013,
		StructureTypeBindImageMemoryDeviceGroupInfo = 1000060014,
		StructureTypePhysicalDeviceGroupProperties = 1000070000,
		StructureTypeDeviceGroupDeviceCreateInfo = 1000070001,
		StructureTypeBufferMemoryRequirementsInfo2 = 1000146000,
		StructureTypeImageMemoryRequirementsInfo2 = 1000146001,
		StructureTypeImageSparseMemoryRequirementsInfo2 = 1000146002,
		StructureTypeMemoryRequirements2 = 1000146003,
		StructureTypeSparseImageMemoryRequirements2 = 1000146004,
		StructureTypePhysicalDeviceFeatures2 = 1000059000,
		StructureTypePhysicalDeviceProperties2 = 1000059001,
		StructureTypeFormatProperties2 = 1000059002,
		StructureTypeImageFormatProperties2 = 1000059003,
		StructureTypePhysicalDeviceImageFormatInfo2 = 1000059004,
		StructureTypeQueueFamilyProperties2 = 1000059005,
		StructureTypePhysicalDeviceMemoryProperties2 = 1000059006,
		StructureTypeSparseImageFormatProperties2 = 1000059007,
		StructureTypePhysicalDeviceSparseImageFormatInfo2 = 1000059008,
		StructureTypePhysicalDevicePointClippingProperties = 1000117000,
		StructureTypeRenderPassInputAttachmentAspectCreateInfo = 1000117001,
		StructureTypeImageViewUsageCreateInfo = 1000117002,
		StructureTypePipelineTessellationDomainOriginStateCreateInfo = 1000117003,
		StructureTypeRenderPassMultiviewCreateInfo = 1000053000,
		StructureTypePhysicalDeviceMultiviewFeatures = 1000053001,
		StructureTypePhysicalDeviceMultiviewProperties = 1000053002,
		StructureTypePhysicalDeviceVariablePointersFeatures = 1000120000,
		StructureTypePhysicalDeviceVariablePointerFeatures = StructureTypePhysicalDeviceVariablePointersFeatures,
		StructureTypeProtectedSubmitInfo = 1000145000,
		StructureTypePhysicalDeviceProtectedMemoryFeatures = 1000145001,
		StructureTypePhysicalDeviceProtectedMemoryProperties = 1000145002,
		StructureTypeDeviceQueueInfo2 = 1000145003,
		StructureTypeSamplerYcbcrConversionCreateInfo = 1000156000,
		StructureTypeSamplerYcbcrConversionInfo = 1000156001,
		StructureTypeBindImagePlaneMemoryInfo = 1000156002,
		StructureTypeImagePlaneMemoryRequirementsInfo = 1000156003,
		StructureTypePhysicalDeviceSamplerYcbcrConversionFeatures = 1000156004,
		StructureTypeSamplerYcbcrConversionImageFormatProperties = 1000156005,
		StructureTypeDescriptorUpdateTemplateCreateInfo = 1000085000,
		StructureTypePhysicalDeviceExternalImageFormatInfo = 1000071000,
		StructureTypeExternalImageFormatProperties = 1000071001,
		StructureTypePhysicalDeviceExternalBufferInfo = 1000071002,
		StructureTypeExternalBufferProperties = 1000071003,
		StructureTypePhysicalDeviceIdProperties = 1000071004,
		StructureTypeExternalMemoryBufferCreateInfo = 1000072000,
		StructureTypeExternalMemoryImageCreateInfo = 1000072001,
		StructureTypeExportMemoryAllocateInfo = 1000072002,
		StructureTypePhysicalDeviceExternalFenceInfo = 1000112000,
		StructureTypeExternalFenceProperties = 1000112001,
		StructureTypeExportFenceCreateInfo = 1000113000,
		StructureTypeExportSemaphoreCreateInfo = 1000077000,
		StructureTypePhysicalDeviceExternalSemaphoreInfo = 1000076000,
		StructureTypeExternalSemaphoreProperties = 1000076001,
		StructureTypePhysicalDeviceMaintenance3Properties = 1000168000,
		StructureTypeDescriptorSetLayoutSupport = 1000168001,
		StructureTypePhysicalDeviceShaderDrawParametersFeatures = 1000063000,
		StructureTypePhysicalDeviceShaderDrawParameterFeatures = StructureTypePhysicalDeviceShaderDrawParametersFeatures,
		StructureTypePhysicalDeviceVulkan11Features = 49,
		StructureTypePhysicalDeviceVulkan11Properties = 50,
		StructureTypePhysicalDeviceVulkan12Features = 51,
		StructureTypePhysicalDeviceVulkan12Properties = 52,
		StructureTypeImageFormatListCreateInfo = 1000147000,
		StructureTypeAttachmentDescription2 = 1000109000,
		StructureTypeAttachmentReference2 = 1000109001,
		StructureTypeSubpassDescription2 = 1000109002,
		StructureTypeSubpassDependency2 = 1000109003,
		StructureTypeRenderPassCreateInfo2 = 1000109004,
		StructureTypeSubpassBeginInfo = 1000109005,
		StructureTypeSubpassEndInfo = 1000109006,
		StructureTypePhysicalDevice8bitStorageFeatures = 1000177000,
		StructureTypePhysicalDeviceDriverProperties = 1000196000,
		StructureTypePhysicalDeviceShaderAtomicInt64Features = 1000180000,
		StructureTypePhysicalDeviceShaderFloat16Int8Features = 1000082000,
		StructureTypePhysicalDeviceFloatControlsProperties = 1000197000,
		StructureTypeDescriptorSetLayoutBindingFlagsCreateInfo = 1000161000,
		StructureTypePhysicalDeviceDescriptorIndexingFeatures = 1000161001,
		StructureTypePhysicalDeviceDescriptorIndexingProperties = 1000161002,
		StructureTypeDescriptorSetVariableDescriptorCountAllocateInfo = 1000161003,
		StructureTypeDescriptorSetVariableDescriptorCountLayoutSupport = 1000161004,
		StructureTypePhysicalDeviceDepthStencilResolveProperties = 1000199000,
		StructureTypeSubpassDescriptionDepthStencilResolve = 1000199001,
		StructureTypePhysicalDeviceScalarBlockLayoutFeatures = 1000221000,
		StructureTypeImageStencilUsageCreateInfo = 1000246000,
		StructureTypePhysicalDeviceSamplerFilterMinmaxProperties = 1000130000,
		StructureTypeSamplerReductionModeCreateInfo = 1000130001,
		StructureTypePhysicalDeviceVulkanMemoryModelFeatures = 1000211000,
		StructureTypePhysicalDeviceImagelessFramebufferFeatures = 1000108000,
		StructureTypeFramebufferAttachmentsCreateInfo = 1000108001,
		StructureTypeFramebufferAttachmentImageInfo = 1000108002,
		StructureTypeRenderPassAttachmentBeginInfo = 1000108003,
		StructureTypePhysicalDeviceUniformBufferStandardLayoutFeatures = 1000253000,
		StructureTypePhysicalDeviceShaderSubgroupExtendedTypesFeatures = 1000175000,
		StructureTypePhysicalDeviceSeparateDepthStencilLayoutsFeatures = 1000241000,
		StructureTypeAttachmentReferenceStencilLayout = 1000241001,
		StructureTypeAttachmentDescriptionStencilLayout = 1000241002,
		StructureTypePhysicalDeviceHostQueryResetFeatures = 1000261000,
		StructureTypePhysicalDeviceTimelineSemaphoreFeatures = 1000207000,
		StructureTypePhysicalDeviceTimelineSemaphoreProperties = 1000207001,
		StructureTypeSemaphoreTypeCreateInfo = 1000207002,
		StructureTypeTimelineSemaphoreSubmitInfo = 1000207003,
		StructureTypeSemaphoreWaitInfo = 1000207004,
		StructureTypeSemaphoreSignalInfo = 1000207005,
		StructureTypePhysicalDeviceBufferDeviceAddressFeatures = 1000257000,
		StructureTypeBufferDeviceAddressInfo = 1000244001,
		StructureTypeBufferOpaqueCaptureAddressCreateInfo = 1000257002,
		StructureTypeMemoryOpaqueCaptureAddressAllocateInfo = 1000257003,
		StructureTypeDeviceMemoryOpaqueCaptureAddressInfo = 1000257004,
		StructureTypeSwapchainCreateInfoKhr = 1000001000,
		StructureTypePresentInfoKhr = 1000001001,
		StructureTypeDeviceGroupPresentCapabilitiesKhr = 1000060007,
		StructureTypeImageSwapchainCreateInfoKhr = 1000060008,
		StructureTypeBindImageMemorySwapchainInfoKhr = 1000060009,
		StructureTypeAcquireNextImageInfoKhr = 1000060010,
		StructureTypeDeviceGroupPresentInfoKhr = 1000060011,
		StructureTypeDeviceGroupSwapchainCreateInfoKhr = 1000060012,
		StructureTypeDisplayModeCreateInfoKhr = 1000002000,
		StructureTypeDisplaySurfaceCreateInfoKhr = 1000002001,
		StructureTypeDisplayPresentInfoKhr = 1000003000,
		StructureTypeXlibSurfaceCreateInfoKhr = 1000004000,
		StructureTypeXcbSurfaceCreateInfoKhr = 1000005000,
		StructureTypeWaylandSurfaceCreateInfoKhr = 1000006000,
		StructureTypeAndroidSurfaceCreateInfoKhr = 1000008000,
		StructureTypeWin32SurfaceCreateInfoKhr = 1000009000,
		StructureTypeNativeBufferAndroid = 1000010000,
		StructureTypeSwapchainImageCreateInfoAndroid = 1000010001,
		StructureTypePhysicalDevicePresentationPropertiesAndroid = 1000010002,
		StructureTypeDebugReportCallbackCreateInfoExt = 1000011000,
		StructureTypeDebugReportCreateInfoExt = StructureTypeDebugReportCallbackCreateInfoExt,
		StructureTypePipelineRasterizationStateRasterizationOrderAmd = 1000018000,
		StructureTypeDebugMarkerObjectNameInfoExt = 1000022000,
		StructureTypeDebugMarkerObjectTagInfoExt = 1000022001,
		StructureTypeDebugMarkerMarkerInfoExt = 1000022002,
		StructureTypeDedicatedAllocationImageCreateInfoNv = 1000026000,
		StructureTypeDedicatedAllocationBufferCreateInfoNv = 1000026001,
		StructureTypeDedicatedAllocationMemoryAllocateInfoNv = 1000026002,
		StructureTypePhysicalDeviceTransformFeedbackFeaturesExt = 1000028000,
		StructureTypePhysicalDeviceTransformFeedbackPropertiesExt = 1000028001,
		StructureTypePipelineRasterizationStateStreamCreateInfoExt = 1000028002,
		StructureTypeImageViewHandleInfoNvx = 1000030000,
		StructureTypeImageViewAddressPropertiesNvx = 1000030001,
		StructureTypeTextureLodGatherFormatPropertiesAmd = 1000041000,
		StructureTypeStreamDescriptorSurfaceCreateInfoGgp = 1000049000,
		StructureTypePhysicalDeviceCornerSampledImageFeaturesNv = 1000050000,
		StructureTypeRenderPassMultiviewCreateInfoKhr = StructureTypeRenderPassMultiviewCreateInfo,
		StructureTypePhysicalDeviceMultiviewFeaturesKhr = StructureTypePhysicalDeviceMultiviewFeatures,
		StructureTypePhysicalDeviceMultiviewPropertiesKhr = StructureTypePhysicalDeviceMultiviewProperties,
		StructureTypeExternalMemoryImageCreateInfoNv = 1000056000,
		StructureTypeExportMemoryAllocateInfoNv = 1000056001,
		StructureTypeImportMemoryWin32HandleInfoNv = 1000057000,
		StructureTypeExportMemoryWin32HandleInfoNv = 1000057001,
		StructureTypeWin32KeyedMutexAcquireReleaseInfoNv = 1000058000,
		StructureTypePhysicalDeviceFeatures2Khr = StructureTypePhysicalDeviceFeatures2,
		StructureTypePhysicalDeviceProperties2Khr = StructureTypePhysicalDeviceProperties2,
		StructureTypeFormatProperties2Khr = StructureTypeFormatProperties2,
		StructureTypeImageFormatProperties2Khr = StructureTypeImageFormatProperties2,
		StructureTypePhysicalDeviceImageFormatInfo2Khr = StructureTypePhysicalDeviceImageFormatInfo2,
		StructureTypeQueueFamilyProperties2Khr = StructureTypeQueueFamilyProperties2,
		StructureTypePhysicalDeviceMemoryProperties2Khr = StructureTypePhysicalDeviceMemoryProperties2,
		StructureTypeSparseImageFormatProperties2Khr = StructureTypeSparseImageFormatProperties2,
		StructureTypePhysicalDeviceSparseImageFormatInfo2Khr = StructureTypePhysicalDeviceSparseImageFormatInfo2,
		StructureTypeMemoryAllocateFlagsInfoKhr = StructureTypeMemoryAllocateFlagsInfo,
		StructureTypeDeviceGroupRenderPassBeginInfoKhr = StructureTypeDeviceGroupRenderPassBeginInfo,
		StructureTypeDeviceGroupCommandBufferBeginInfoKhr = StructureTypeDeviceGroupCommandBufferBeginInfo,
		StructureTypeDeviceGroupSubmitInfoKhr = StructureTypeDeviceGroupSubmitInfo,
		StructureTypeDeviceGroupBindSparseInfoKhr = StructureTypeDeviceGroupBindSparseInfo,
		StructureTypeBindBufferMemoryDeviceGroupInfoKhr = StructureTypeBindBufferMemoryDeviceGroupInfo,
		StructureTypeBindImageMemoryDeviceGroupInfoKhr = StructureTypeBindImageMemoryDeviceGroupInfo,
		StructureTypeValidationFlagsExt = 1000061000,
		StructureTypeViSurfaceCreateInfoNn = 1000062000,
		StructureTypePhysicalDeviceTextureCompressionAstcHdrFeaturesExt = 1000066000,
		StructureTypeImageViewAstcDecodeModeExt = 1000067000,
		StructureTypePhysicalDeviceAstcDecodeFeaturesExt = 1000067001,
		StructureTypePhysicalDeviceGroupPropertiesKhr = StructureTypePhysicalDeviceGroupProperties,
		StructureTypeDeviceGroupDeviceCreateInfoKhr = StructureTypeDeviceGroupDeviceCreateInfo,
		StructureTypePhysicalDeviceExternalImageFormatInfoKhr = StructureTypePhysicalDeviceExternalImageFormatInfo,
		StructureTypeExternalImageFormatPropertiesKhr = StructureTypeExternalImageFormatProperties,
		StructureTypePhysicalDeviceExternalBufferInfoKhr = StructureTypePhysicalDeviceExternalBufferInfo,
		StructureTypeExternalBufferPropertiesKhr = StructureTypeExternalBufferProperties,
		StructureTypePhysicalDeviceIdPropertiesKhr = StructureTypePhysicalDeviceIdProperties,
		StructureTypeExternalMemoryBufferCreateInfoKhr = StructureTypeExternalMemoryBufferCreateInfo,
		StructureTypeExternalMemoryImageCreateInfoKhr = StructureTypeExternalMemoryImageCreateInfo,
		StructureTypeExportMemoryAllocateInfoKhr = StructureTypeExportMemoryAllocateInfo,
		StructureTypeImportMemoryWin32HandleInfoKhr = 1000073000,
		StructureTypeExportMemoryWin32HandleInfoKhr = 1000073001,
		StructureTypeMemoryWin32HandlePropertiesKhr = 1000073002,
		StructureTypeMemoryGetWin32HandleInfoKhr = 1000073003,
		StructureTypeImportMemoryFdInfoKhr = 1000074000,
		StructureTypeMemoryFdPropertiesKhr = 1000074001,
		StructureTypeMemoryGetFdInfoKhr = 1000074002,
		StructureTypeWin32KeyedMutexAcquireReleaseInfoKhr = 1000075000,
		StructureTypePhysicalDeviceExternalSemaphoreInfoKhr = StructureTypePhysicalDeviceExternalSemaphoreInfo,
		StructureTypeExternalSemaphorePropertiesKhr = StructureTypeExternalSemaphoreProperties,
		StructureTypeExportSemaphoreCreateInfoKhr = StructureTypeExportSemaphoreCreateInfo,
		StructureTypeImportSemaphoreWin32HandleInfoKhr = 1000078000,
		StructureTypeExportSemaphoreWin32HandleInfoKhr = 1000078001,
		StructureTypeD3d12FenceSubmitInfoKhr = 1000078002,
		StructureTypeSemaphoreGetWin32HandleInfoKhr = 1000078003,
		StructureTypeImportSemaphoreFdInfoKhr = 1000079000,
		StructureTypeSemaphoreGetFdInfoKhr = 1000079001,
		StructureTypePhysicalDevicePushDescriptorPropertiesKhr = 1000080000,
		StructureTypeCommandBufferInheritanceConditionalRenderingInfoExt = 1000081000,
		StructureTypePhysicalDeviceConditionalRenderingFeaturesExt = 1000081001,
		StructureTypeConditionalRenderingBeginInfoExt = 1000081002,
		StructureTypePhysicalDeviceShaderFloat16Int8FeaturesKhr = StructureTypePhysicalDeviceShaderFloat16Int8Features,
		StructureTypePhysicalDeviceFloat16Int8FeaturesKhr = StructureTypePhysicalDeviceShaderFloat16Int8Features,
		StructureTypePhysicalDevice16bitStorageFeaturesKhr = StructureTypePhysicalDevice16bitStorageFeatures,
		StructureTypePresentRegionsKhr = 1000084000,
		StructureTypeDescriptorUpdateTemplateCreateInfoKhr = StructureTypeDescriptorUpdateTemplateCreateInfo,
		StructureTypePipelineViewportWScalingStateCreateInfoNv = 1000087000,
		StructureTypeSurfaceCapabilities2Ext = 1000090000,
		StructureTypeDisplayPowerInfoExt = 1000091000,
		StructureTypeDeviceEventInfoExt = 1000091001,
		StructureTypeDisplayEventInfoExt = 1000091002,
		StructureTypeSwapchainCounterCreateInfoExt = 1000091003,
		StructureTypePresentTimesInfoGoogle = 1000092000,
		StructureTypePhysicalDeviceMultiviewPerViewAttributesPropertiesNvx = 1000097000,
		StructureTypePipelineViewportSwizzleStateCreateInfoNv = 1000098000,
		StructureTypePhysicalDeviceDiscardRectanglePropertiesExt = 1000099000,
		StructureTypePipelineDiscardRectangleStateCreateInfoExt = 1000099001,
		StructureTypePhysicalDeviceConservativeRasterizationPropertiesExt = 1000101000,
		StructureTypePipelineRasterizationConservativeStateCreateInfoExt = 1000101001,
		StructureTypePhysicalDeviceDepthClipEnableFeaturesExt = 1000102000,
		StructureTypePipelineRasterizationDepthClipStateCreateInfoExt = 1000102001,
		StructureTypeHdrMetadataExt = 1000105000,
		StructureTypePhysicalDeviceImagelessFramebufferFeaturesKhr = StructureTypePhysicalDeviceImagelessFramebufferFeatures,
		StructureTypeFramebufferAttachmentsCreateInfoKhr = StructureTypeFramebufferAttachmentsCreateInfo,
		StructureTypeFramebufferAttachmentImageInfoKhr = StructureTypeFramebufferAttachmentImageInfo,
		StructureTypeRenderPassAttachmentBeginInfoKhr = StructureTypeRenderPassAttachmentBeginInfo,
		StructureTypeAttachmentDescription2Khr = StructureTypeAttachmentDescription2,
		StructureTypeAttachmentReference2Khr = StructureTypeAttachmentReference2,
		StructureTypeSubpassDescription2Khr = StructureTypeSubpassDescription2,
		StructureTypeSubpassDependency2Khr = StructureTypeSubpassDependency2,
		StructureTypeRenderPassCreateInfo2Khr = StructureTypeRenderPassCreateInfo2,
		StructureTypeSubpassBeginInfoKhr = StructureTypeSubpassBeginInfo,
		StructureTypeSubpassEndInfoKhr = StructureTypeSubpassEndInfo,
		StructureTypeSharedPresentSurfaceCapabilitiesKhr = 1000111000,
		StructureTypePhysicalDeviceExternalFenceInfoKhr = StructureTypePhysicalDeviceExternalFenceInfo,
		StructureTypeExternalFencePropertiesKhr = StructureTypeExternalFenceProperties,
		StructureTypeExportFenceCreateInfoKhr = StructureTypeExportFenceCreateInfo,
		StructureTypeImportFenceWin32HandleInfoKhr = 1000114000,
		StructureTypeExportFenceWin32HandleInfoKhr = 1000114001,
		StructureTypeFenceGetWin32HandleInfoKhr = 1000114002,
		StructureTypeImportFenceFdInfoKhr = 1000115000,
		StructureTypeFenceGetFdInfoKhr = 1000115001,
		StructureTypePhysicalDevicePerformanceQueryFeaturesKhr = 1000116000,
		StructureTypePhysicalDevicePerformanceQueryPropertiesKhr = 1000116001,
		StructureTypeQueryPoolPerformanceCreateInfoKhr = 1000116002,
		StructureTypePerformanceQuerySubmitInfoKhr = 1000116003,
		StructureTypeAcquireProfilingLockInfoKhr = 1000116004,
		StructureTypePerformanceCounterKhr = 1000116005,
		StructureTypePerformanceCounterDescriptionKhr = 1000116006,
		StructureTypePhysicalDevicePointClippingPropertiesKhr = StructureTypePhysicalDevicePointClippingProperties,
		StructureTypeRenderPassInputAttachmentAspectCreateInfoKhr = StructureTypeRenderPassInputAttachmentAspectCreateInfo,
		StructureTypeImageViewUsageCreateInfoKhr = StructureTypeImageViewUsageCreateInfo,
		StructureTypePipelineTessellationDomainOriginStateCreateInfoKhr = StructureTypePipelineTessellationDomainOriginStateCreateInfo,
		StructureTypePhysicalDeviceSurfaceInfo2Khr = 1000119000,
		StructureTypeSurfaceCapabilities2Khr = 1000119001,
		StructureTypeSurfaceFormat2Khr = 1000119002,
		StructureTypePhysicalDeviceVariablePointersFeaturesKhr = StructureTypePhysicalDeviceVariablePointersFeatures,
		StructureTypePhysicalDeviceVariablePointerFeaturesKhr = StructureTypePhysicalDeviceVariablePointersFeaturesKhr,
		StructureTypeDisplayProperties2Khr = 1000121000,
		StructureTypeDisplayPlaneProperties2Khr = 1000121001,
		StructureTypeDisplayModeProperties2Khr = 1000121002,
		StructureTypeDisplayPlaneInfo2Khr = 1000121003,
		StructureTypeDisplayPlaneCapabilities2Khr = 1000121004,
		StructureTypeIosSurfaceCreateInfoMvk = 1000122000,
		StructureTypeMacosSurfaceCreateInfoMvk = 1000123000,
		StructureTypeMemoryDedicatedRequirementsKhr = StructureTypeMemoryDedicatedRequirements,
		StructureTypeMemoryDedicatedAllocateInfoKhr = StructureTypeMemoryDedicatedAllocateInfo,
		StructureTypeDebugUtilsObjectNameInfoExt = 1000128000,
		StructureTypeDebugUtilsObjectTagInfoExt = 1000128001,
		StructureTypeDebugUtilsLabelExt = 1000128002,
		StructureTypeDebugUtilsMessengerCallbackDataExt = 1000128003,
		StructureTypeDebugUtilsMessengerCreateInfoExt = 1000128004,
		StructureTypeAndroidHardwareBufferUsageAndroid = 1000129000,
		StructureTypeAndroidHardwareBufferPropertiesAndroid = 1000129001,
		StructureTypeAndroidHardwareBufferFormatPropertiesAndroid = 1000129002,
		StructureTypeImportAndroidHardwareBufferInfoAndroid = 1000129003,
		StructureTypeMemoryGetAndroidHardwareBufferInfoAndroid = 1000129004,
		StructureTypeExternalFormatAndroid = 1000129005,
		StructureTypePhysicalDeviceSamplerFilterMinmaxPropertiesExt = StructureTypePhysicalDeviceSamplerFilterMinmaxProperties,
		StructureTypeSamplerReductionModeCreateInfoExt = StructureTypeSamplerReductionModeCreateInfo,
		StructureTypePhysicalDeviceInlineUniformBlockFeaturesExt = 1000138000,
		StructureTypePhysicalDeviceInlineUniformBlockPropertiesExt = 1000138001,
		StructureTypeWriteDescriptorSetInlineUniformBlockExt = 1000138002,
		StructureTypeDescriptorPoolInlineUniformBlockCreateInfoExt = 1000138003,
		StructureTypeSampleLocationsInfoExt = 1000143000,
		StructureTypeRenderPassSampleLocationsBeginInfoExt = 1000143001,
		StructureTypePipelineSampleLocationsStateCreateInfoExt = 1000143002,
		StructureTypePhysicalDeviceSampleLocationsPropertiesExt = 1000143003,
		StructureTypeMultisamplePropertiesExt = 1000143004,
		StructureTypeBufferMemoryRequirementsInfo2Khr = StructureTypeBufferMemoryRequirementsInfo2,
		StructureTypeImageMemoryRequirementsInfo2Khr = StructureTypeImageMemoryRequirementsInfo2,
		StructureTypeImageSparseMemoryRequirementsInfo2Khr = StructureTypeImageSparseMemoryRequirementsInfo2,
		StructureTypeMemoryRequirements2Khr = StructureTypeMemoryRequirements2,
		StructureTypeSparseImageMemoryRequirements2Khr = StructureTypeSparseImageMemoryRequirements2,
		StructureTypeImageFormatListCreateInfoKhr = StructureTypeImageFormatListCreateInfo,
		StructureTypePhysicalDeviceBlendOperationAdvancedFeaturesExt = 1000148000,
		StructureTypePhysicalDeviceBlendOperationAdvancedPropertiesExt = 1000148001,
		StructureTypePipelineColorBlendAdvancedStateCreateInfoExt = 1000148002,
		StructureTypePipelineCoverageToColorStateCreateInfoNv = 1000149000,
		StructureTypeBindAccelerationStructureMemoryInfoKhr = 1000165006,
		StructureTypeWriteDescriptorSetAccelerationStructureKhr = 1000165007,
		StructureTypeAccelerationStructureBuildGeometryInfoKhr = 1000150000,
		StructureTypeAccelerationStructureCreateGeometryTypeInfoKhr = 1000150001,
		StructureTypeAccelerationStructureDeviceAddressInfoKhr = 1000150002,
		StructureTypeAccelerationStructureGeometryAabbsDataKhr = 1000150003,
		StructureTypeAccelerationStructureGeometryInstancesDataKhr = 1000150004,
		StructureTypeAccelerationStructureGeometryTrianglesDataKhr = 1000150005,
		StructureTypeAccelerationStructureGeometryKhr = 1000150006,
		StructureTypeAccelerationStructureMemoryRequirementsInfoKhr = 1000150008,
		StructureTypeAccelerationStructureVersionKhr = 1000150009,
		StructureTypeCopyAccelerationStructureInfoKhr = 1000150010,
		StructureTypeCopyAccelerationStructureToMemoryInfoKhr = 1000150011,
		StructureTypeCopyMemoryToAccelerationStructureInfoKhr = 1000150012,
		StructureTypePhysicalDeviceRayTracingFeaturesKhr = 1000150013,
		StructureTypePhysicalDeviceRayTracingPropertiesKhr = 1000150014,
		StructureTypeRayTracingPipelineCreateInfoKhr = 1000150015,
		StructureTypeRayTracingShaderGroupCreateInfoKhr = 1000150016,
		StructureTypeAccelerationStructureCreateInfoKhr = 1000150017,
		StructureTypeRayTracingPipelineInterfaceCreateInfoKhr = 1000150018,
		StructureTypePipelineCoverageModulationStateCreateInfoNv = 1000152000,
		StructureTypePhysicalDeviceShaderSmBuiltinsFeaturesNv = 1000154000,
		StructureTypePhysicalDeviceShaderSmBuiltinsPropertiesNv = 1000154001,
		StructureTypeSamplerYcbcrConversionCreateInfoKhr = StructureTypeSamplerYcbcrConversionCreateInfo,
		StructureTypeSamplerYcbcrConversionInfoKhr = StructureTypeSamplerYcbcrConversionInfo,
		StructureTypeBindImagePlaneMemoryInfoKhr = StructureTypeBindImagePlaneMemoryInfo,
		StructureTypeImagePlaneMemoryRequirementsInfoKhr = StructureTypeImagePlaneMemoryRequirementsInfo,
		StructureTypePhysicalDeviceSamplerYcbcrConversionFeaturesKhr = StructureTypePhysicalDeviceSamplerYcbcrConversionFeatures,
		StructureTypeSamplerYcbcrConversionImageFormatPropertiesKhr = StructureTypeSamplerYcbcrConversionImageFormatProperties,
		StructureTypeBindBufferMemoryInfoKhr = StructureTypeBindBufferMemoryInfo,
		StructureTypeBindImageMemoryInfoKhr = StructureTypeBindImageMemoryInfo,
		StructureTypeDrmFormatModifierPropertiesListExt = 1000158000,
		StructureTypeDrmFormatModifierPropertiesExt = 1000158001,
		StructureTypePhysicalDeviceImageDrmFormatModifierInfoExt = 1000158002,
		StructureTypeImageDrmFormatModifierListCreateInfoExt = 1000158003,
		StructureTypeImageDrmFormatModifierExplicitCreateInfoExt = 1000158004,
		StructureTypeImageDrmFormatModifierPropertiesExt = 1000158005,
		StructureTypeValidationCacheCreateInfoExt = 1000160000,
		StructureTypeShaderModuleValidationCacheCreateInfoExt = 1000160001,
		StructureTypeDescriptorSetLayoutBindingFlagsCreateInfoExt = StructureTypeDescriptorSetLayoutBindingFlagsCreateInfo,
		StructureTypePhysicalDeviceDescriptorIndexingFeaturesExt = StructureTypePhysicalDeviceDescriptorIndexingFeatures,
		StructureTypePhysicalDeviceDescriptorIndexingPropertiesExt = StructureTypePhysicalDeviceDescriptorIndexingProperties,
		StructureTypeDescriptorSetVariableDescriptorCountAllocateInfoExt = StructureTypeDescriptorSetVariableDescriptorCountAllocateInfo,
		StructureTypeDescriptorSetVariableDescriptorCountLayoutSupportExt = StructureTypeDescriptorSetVariableDescriptorCountLayoutSupport,
		StructureTypePipelineViewportShadingRateImageStateCreateInfoNv = 1000164000,
		StructureTypePhysicalDeviceShadingRateImageFeaturesNv = 1000164001,
		StructureTypePhysicalDeviceShadingRateImagePropertiesNv = 1000164002,
		StructureTypePipelineViewportCoarseSampleOrderStateCreateInfoNv = 1000164005,
		StructureTypeRayTracingPipelineCreateInfoNv = 1000165000,
		StructureTypeAccelerationStructureCreateInfoNv = 1000165001,
		StructureTypeGeometryNv = 1000165003,
		StructureTypeGeometryTrianglesNv = 1000165004,
		StructureTypeGeometryAabbNv = 1000165005,
		StructureTypeBindAccelerationStructureMemoryInfoNv = StructureTypeBindAccelerationStructureMemoryInfoKhr,
		StructureTypeWriteDescriptorSetAccelerationStructureNv = StructureTypeWriteDescriptorSetAccelerationStructureKhr,
		StructureTypeAccelerationStructureMemoryRequirementsInfoNv = 1000165008,
		StructureTypePhysicalDeviceRayTracingPropertiesNv = 1000165009,
		StructureTypeRayTracingShaderGroupCreateInfoNv = 1000165011,
		StructureTypeAccelerationStructureInfoNv = 1000165012,
		StructureTypePhysicalDeviceRepresentativeFragmentTestFeaturesNv = 1000166000,
		StructureTypePipelineRepresentativeFragmentTestStateCreateInfoNv = 1000166001,
		StructureTypePhysicalDeviceMaintenance3PropertiesKhr = StructureTypePhysicalDeviceMaintenance3Properties,
		StructureTypeDescriptorSetLayoutSupportKhr = StructureTypeDescriptorSetLayoutSupport,
		StructureTypePhysicalDeviceImageViewImageFormatInfoExt = 1000170000,
		StructureTypeFilterCubicImageViewImageFormatPropertiesExt = 1000170001,
		StructureTypeDeviceQueueGlobalPriorityCreateInfoExt = 1000174000,
		StructureTypePhysicalDeviceShaderSubgroupExtendedTypesFeaturesKhr = StructureTypePhysicalDeviceShaderSubgroupExtendedTypesFeatures,
		StructureTypePhysicalDevice8bitStorageFeaturesKhr = StructureTypePhysicalDevice8bitStorageFeatures,
		StructureTypeImportMemoryHostPointerInfoExt = 1000178000,
		StructureTypeMemoryHostPointerPropertiesExt = 1000178001,
		StructureTypePhysicalDeviceExternalMemoryHostPropertiesExt = 1000178002,
		StructureTypePhysicalDeviceShaderAtomicInt64FeaturesKhr = StructureTypePhysicalDeviceShaderAtomicInt64Features,
		StructureTypePhysicalDeviceShaderClockFeaturesKhr = 1000181000,
		StructureTypePipelineCompilerControlCreateInfoAmd = 1000183000,
		StructureTypeCalibratedTimestampInfoExt = 1000184000,
		StructureTypePhysicalDeviceShaderCorePropertiesAmd = 1000185000,
		StructureTypeDeviceMemoryOverallocationCreateInfoAmd = 1000189000,
		StructureTypePhysicalDeviceVertexAttributeDivisorPropertiesExt = 1000190000,
		StructureTypePipelineVertexInputDivisorStateCreateInfoExt = 1000190001,
		StructureTypePhysicalDeviceVertexAttributeDivisorFeaturesExt = 1000190002,
		StructureTypePresentFrameTokenGgp = 1000191000,
		StructureTypePipelineCreationFeedbackCreateInfoExt = 1000192000,
		StructureTypePhysicalDeviceDriverPropertiesKhr = StructureTypePhysicalDeviceDriverProperties,
		StructureTypePhysicalDeviceFloatControlsPropertiesKhr = StructureTypePhysicalDeviceFloatControlsProperties,
		StructureTypePhysicalDeviceDepthStencilResolvePropertiesKhr = StructureTypePhysicalDeviceDepthStencilResolveProperties,
		StructureTypeSubpassDescriptionDepthStencilResolveKhr = StructureTypeSubpassDescriptionDepthStencilResolve,
		StructureTypePhysicalDeviceComputeShaderDerivativesFeaturesNv = 1000201000,
		StructureTypePhysicalDeviceMeshShaderFeaturesNv = 1000202000,
		StructureTypePhysicalDeviceMeshShaderPropertiesNv = 1000202001,
		StructureTypePhysicalDeviceFragmentShaderBarycentricFeaturesNv = 1000203000,
		StructureTypePhysicalDeviceShaderImageFootprintFeaturesNv = 1000204000,
		StructureTypePipelineViewportExclusiveScissorStateCreateInfoNv = 1000205000,
		StructureTypePhysicalDeviceExclusiveScissorFeaturesNv = 1000205002,
		StructureTypeCheckpointDataNv = 1000206000,
		StructureTypeQueueFamilyCheckpointPropertiesNv = 1000206001,
		StructureTypePhysicalDeviceTimelineSemaphoreFeaturesKhr = StructureTypePhysicalDeviceTimelineSemaphoreFeatures,
		StructureTypePhysicalDeviceTimelineSemaphorePropertiesKhr = StructureTypePhysicalDeviceTimelineSemaphoreProperties,
		StructureTypeSemaphoreTypeCreateInfoKhr = StructureTypeSemaphoreTypeCreateInfo,
		StructureTypeTimelineSemaphoreSubmitInfoKhr = StructureTypeTimelineSemaphoreSubmitInfo,
		StructureTypeSemaphoreWaitInfoKhr = StructureTypeSemaphoreWaitInfo,
		StructureTypeSemaphoreSignalInfoKhr = StructureTypeSemaphoreSignalInfo,
		StructureTypePhysicalDeviceShaderIntegerFunctions2FeaturesIntel = 1000209000,
		StructureTypeQueryPoolPerformanceQueryCreateInfoIntel = 1000210000,
		StructureTypeQueryPoolCreateInfoIntel = StructureTypeQueryPoolPerformanceQueryCreateInfoIntel,
		StructureTypeInitializePerformanceApiInfoIntel = 1000210001,
		StructureTypePerformanceMarkerInfoIntel = 1000210002,
		StructureTypePerformanceStreamMarkerInfoIntel = 1000210003,
		StructureTypePerformanceOverrideInfoIntel = 1000210004,
		StructureTypePerformanceConfigurationAcquireInfoIntel = 1000210005,
		StructureTypePhysicalDeviceVulkanMemoryModelFeaturesKhr = StructureTypePhysicalDeviceVulkanMemoryModelFeatures,
		StructureTypePhysicalDevicePciBusInfoPropertiesExt = 1000212000,
		StructureTypeDisplayNativeHdrSurfaceCapabilitiesAmd = 1000213000,
		StructureTypeSwapchainDisplayNativeHdrCreateInfoAmd = 1000213001,
		StructureTypeImagepipeSurfaceCreateInfoFuchsia = 1000214000,
		StructureTypeMetalSurfaceCreateInfoExt = 1000217000,
		StructureTypePhysicalDeviceFragmentDensityMapFeaturesExt = 1000218000,
		StructureTypePhysicalDeviceFragmentDensityMapPropertiesExt = 1000218001,
		StructureTypeRenderPassFragmentDensityMapCreateInfoExt = 1000218002,
		StructureTypePhysicalDeviceScalarBlockLayoutFeaturesExt = StructureTypePhysicalDeviceScalarBlockLayoutFeatures,
		StructureTypePhysicalDeviceSubgroupSizeControlPropertiesExt = 1000225000,
		StructureTypePipelineShaderStageRequiredSubgroupSizeCreateInfoExt = 1000225001,
		StructureTypePhysicalDeviceSubgroupSizeControlFeaturesExt = 1000225002,
		StructureTypePhysicalDeviceShaderCoreProperties2Amd = 1000227000,
		StructureTypePhysicalDeviceCoherentMemoryFeaturesAmd = 1000229000,
		StructureTypePhysicalDeviceMemoryBudgetPropertiesExt = 1000237000,
		StructureTypePhysicalDeviceMemoryPriorityFeaturesExt = 1000238000,
		StructureTypeMemoryPriorityAllocateInfoExt = 1000238001,
		StructureTypeSurfaceProtectedCapabilitiesKhr = 1000239000,
		StructureTypePhysicalDeviceDedicatedAllocationImageAliasingFeaturesNv = 1000240000,
		StructureTypePhysicalDeviceSeparateDepthStencilLayoutsFeaturesKhr = StructureTypePhysicalDeviceSeparateDepthStencilLayoutsFeatures,
		StructureTypeAttachmentReferenceStencilLayoutKhr = StructureTypeAttachmentReferenceStencilLayout,
		StructureTypeAttachmentDescriptionStencilLayoutKhr = StructureTypeAttachmentDescriptionStencilLayout,
		StructureTypePhysicalDeviceBufferDeviceAddressFeaturesExt = 1000244000,
		StructureTypePhysicalDeviceBufferAddressFeaturesExt = StructureTypePhysicalDeviceBufferDeviceAddressFeaturesExt,
		StructureTypeBufferDeviceAddressInfoExt = StructureTypeBufferDeviceAddressInfo,
		StructureTypeBufferDeviceAddressCreateInfoExt = 1000244002,
		StructureTypePhysicalDeviceToolPropertiesExt = 1000245000,
		StructureTypeImageStencilUsageCreateInfoExt = StructureTypeImageStencilUsageCreateInfo,
		StructureTypeValidationFeaturesExt = 1000247000,
		StructureTypePhysicalDeviceCooperativeMatrixFeaturesNv = 1000249000,
		StructureTypeCooperativeMatrixPropertiesNv = 1000249001,
		StructureTypePhysicalDeviceCooperativeMatrixPropertiesNv = 1000249002,
		StructureTypePhysicalDeviceCoverageReductionModeFeaturesNv = 1000250000,
		StructureTypePipelineCoverageReductionStateCreateInfoNv = 1000250001,
		StructureTypeFramebufferMixedSamplesCombinationNv = 1000250002,
		StructureTypePhysicalDeviceFragmentShaderInterlockFeaturesExt = 1000251000,
		StructureTypePhysicalDeviceYcbcrImageArraysFeaturesExt = 1000252000,
		StructureTypePhysicalDeviceUniformBufferStandardLayoutFeaturesKhr = StructureTypePhysicalDeviceUniformBufferStandardLayoutFeatures,
		StructureTypeSurfaceFullScreenExclusiveInfoExt = 1000255000,
		StructureTypeSurfaceCapabilitiesFullScreenExclusiveExt = 1000255002,
		StructureTypeSurfaceFullScreenExclusiveWin32InfoExt = 1000255001,
		StructureTypeHeadlessSurfaceCreateInfoExt = 1000256000,
		StructureTypePhysicalDeviceBufferDeviceAddressFeaturesKhr = StructureTypePhysicalDeviceBufferDeviceAddressFeatures,
		StructureTypeBufferDeviceAddressInfoKhr = StructureTypeBufferDeviceAddressInfo,
		StructureTypeBufferOpaqueCaptureAddressCreateInfoKhr = StructureTypeBufferOpaqueCaptureAddressCreateInfo,
		StructureTypeMemoryOpaqueCaptureAddressAllocateInfoKhr = StructureTypeMemoryOpaqueCaptureAddressAllocateInfo,
		StructureTypeDeviceMemoryOpaqueCaptureAddressInfoKhr = StructureTypeDeviceMemoryOpaqueCaptureAddressInfo,
		StructureTypePhysicalDeviceLineRasterizationFeaturesExt = 1000259000,
		StructureTypePipelineRasterizationLineStateCreateInfoExt = 1000259001,
		StructureTypePhysicalDeviceLineRasterizationPropertiesExt = 1000259002,
		StructureTypePhysicalDeviceHostQueryResetFeaturesExt = StructureTypePhysicalDeviceHostQueryResetFeatures,
		StructureTypePhysicalDeviceIndexTypeUint8FeaturesExt = 1000265000,
		StructureTypePhysicalDeviceExtendedDynamicStateFeaturesExt = 1000267000,
		StructureTypeDeferredOperationInfoKhr = 1000268000,
		StructureTypePhysicalDevicePipelineExecutablePropertiesFeaturesKhr = 1000269000,
		StructureTypePipelineInfoKhr = 1000269001,
		StructureTypePipelineExecutablePropertiesKhr = 1000269002,
		StructureTypePipelineExecutableInfoKhr = 1000269003,
		StructureTypePipelineExecutableStatisticKhr = 1000269004,
		StructureTypePipelineExecutableInternalRepresentationKhr = 1000269005,
		StructureTypePhysicalDeviceShaderDemoteToHelperInvocationFeaturesExt = 1000276000,
		StructureTypePhysicalDeviceDeviceGeneratedCommandsPropertiesNv = 1000277000,
		StructureTypeGraphicsShaderGroupCreateInfoNv = 1000277001,
		StructureTypeGraphicsPipelineShaderGroupsCreateInfoNv = 1000277002,
		StructureTypeIndirectCommandsLayoutTokenNv = 1000277003,
		StructureTypeIndirectCommandsLayoutCreateInfoNv = 1000277004,
		StructureTypeGeneratedCommandsInfoNv = 1000277005,
		StructureTypeGeneratedCommandsMemoryRequirementsInfoNv = 1000277006,
		StructureTypePhysicalDeviceDeviceGeneratedCommandsFeaturesNv = 1000277007,
		StructureTypePhysicalDeviceTexelBufferAlignmentFeaturesExt = 1000281000,
		StructureTypePhysicalDeviceTexelBufferAlignmentPropertiesExt = 1000281001,
		StructureTypeCommandBufferInheritanceRenderPassTransformInfoQcom = 1000282000,
		StructureTypeRenderPassTransformBeginInfoQcom = 1000282001,
		StructureTypePhysicalDeviceRobustness2FeaturesExt = 1000286000,
		StructureTypePhysicalDeviceRobustness2PropertiesExt = 1000286001,
		StructureTypeSamplerCustomBorderColorCreateInfoExt = 1000287000,
		StructureTypePhysicalDeviceCustomBorderColorPropertiesExt = 1000287001,
		StructureTypePhysicalDeviceCustomBorderColorFeaturesExt = 1000287002,
		StructureTypePipelineLibraryCreateInfoKhr = 1000290000,
		StructureTypePhysicalDevicePrivateDataFeaturesExt = 1000295000,
		StructureTypeDevicePrivateDataCreateInfoExt = 1000295001,
		StructureTypePrivateDataSlotCreateInfoExt = 1000295002,
		StructureTypePhysicalDevicePipelineCreationCacheControlFeaturesExt = 1000297000,
		StructureTypePhysicalDeviceDiagnosticsConfigFeaturesNv = 1000300000,
		StructureTypeDeviceDiagnosticsConfigCreateInfoNv = 1000300001,
		StructureTypeReservedQcom = 1000309000,
		StructureTypePhysicalDeviceFragmentDensityMap2FeaturesExt = 1000332000,
		StructureTypePhysicalDeviceFragmentDensityMap2PropertiesExt = 1000332001,
		StructureTypeDirectfbSurfaceCreateInfoExt = 1000346000
	}

	public enum SystemAllocationScope {
		SystemAllocationScopeCommand = 0,
		SystemAllocationScopeObject = 1,
		SystemAllocationScopeCache = 2,
		SystemAllocationScopeDevice = 3,
		SystemAllocationScopeInstance = 4
	}

	public enum InternalAllocationType {
		InternalAllocationTypeExecutable = 0
	}

	public enum SamplerAddressMode {
		SamplerAddressModeRepeat = 0,
		SamplerAddressModeMirroredRepeat = 1,
		SamplerAddressModeClampToEdge = 2,
		SamplerAddressModeClampToBorder = 3,
		SamplerAddressModeMirrorClampToEdge = 4,
		SamplerAddressModeMirrorClampToEdgeKhr = SamplerAddressModeMirrorClampToEdge
	}

	public enum Filter {
		FilterNearest = 0,
		FilterLinear = 1,
		FilterCubicImg = 1000015000,
		FilterCubicExt = FilterCubicImg
	}

	public enum SamplerMipmapMode {
		SamplerMipmapModeNearest = 0,
		SamplerMipmapModeLinear = 1
	}

	public enum VertexInputRate {
		VertexInputRateVertex = 0,
		VertexInputRateInstance = 1
	}

	public enum ObjectType {
		ObjectTypeUnknown = 0,
		ObjectTypeInstance = 1,
		ObjectTypePhysicalDevice = 2,
		ObjectTypeDevice = 3,
		ObjectTypeQueue = 4,
		ObjectTypeSemaphore = 5,
		ObjectTypeCommandBuffer = 6,
		ObjectTypeFence = 7,
		ObjectTypeDeviceMemory = 8,
		ObjectTypeBuffer = 9,
		ObjectTypeImage = 10,
		ObjectTypeEvent = 11,
		ObjectTypeQueryPool = 12,
		ObjectTypeBufferView = 13,
		ObjectTypeImageView = 14,
		ObjectTypeShaderModule = 15,
		ObjectTypePipelineCache = 16,
		ObjectTypePipelineLayout = 17,
		ObjectTypeRenderPass = 18,
		ObjectTypePipeline = 19,
		ObjectTypeDescriptorSetLayout = 20,
		ObjectTypeSampler = 21,
		ObjectTypeDescriptorPool = 22,
		ObjectTypeDescriptorSet = 23,
		ObjectTypeFramebuffer = 24,
		ObjectTypeCommandPool = 25,
		ObjectTypeSamplerYcbcrConversion = 1000156000,
		ObjectTypeDescriptorUpdateTemplate = 1000085000,
		ObjectTypeSurfaceKhr = 1000000000,
		ObjectTypeSwapchainKhr = 1000001000,
		ObjectTypeDisplayKhr = 1000002000,
		ObjectTypeDisplayModeKhr = 1000002001,
		ObjectTypeDebugReportCallbackExt = 1000011000,
		ObjectTypeDescriptorUpdateTemplateKhr = ObjectTypeDescriptorUpdateTemplate,
		ObjectTypeDebugUtilsMessengerExt = 1000128000,
		ObjectTypeAccelerationStructureKhr = 1000165000,
		ObjectTypeSamplerYcbcrConversionKhr = ObjectTypeSamplerYcbcrConversion,
		ObjectTypeValidationCacheExt = 1000160000,
		ObjectTypeAccelerationStructureNv = ObjectTypeAccelerationStructureKhr,
		ObjectTypePerformanceConfigurationIntel = 1000210000,
		ObjectTypeDeferredOperationKhr = 1000268000,
		ObjectTypeIndirectCommandsLayoutNv = 1000277000,
		ObjectTypePrivateDataSlotExt = 1000295000
	}

	public enum IndirectCommandsTokenTypeNV {
		IndirectCommandsTokenTypeShaderGroupNv = 0,
		IndirectCommandsTokenTypeStateFlagsNv = 1,
		IndirectCommandsTokenTypeIndexBufferNv = 2,
		IndirectCommandsTokenTypeVertexBufferNv = 3,
		IndirectCommandsTokenTypePushConstantNv = 4,
		IndirectCommandsTokenTypeDrawIndexedNv = 5,
		IndirectCommandsTokenTypeDrawNv = 6,
		IndirectCommandsTokenTypeDrawTasksNv = 7
	}

	public enum DescriptorUpdateTemplateType {
		DescriptorUpdateTemplateTypeDescriptorSet = 0,
		DescriptorUpdateTemplateTypePushDescriptorsKhr = 1,
		DescriptorUpdateTemplateTypeDescriptorSetKhr = DescriptorUpdateTemplateTypeDescriptorSet
	}

	public enum ViewportCoordinateSwizzleNV {
		ViewportCoordinateSwizzlePositiveXNv = 0,
		ViewportCoordinateSwizzleNegativeXNv = 1,
		ViewportCoordinateSwizzlePositiveYNv = 2,
		ViewportCoordinateSwizzleNegativeYNv = 3,
		ViewportCoordinateSwizzlePositiveZNv = 4,
		ViewportCoordinateSwizzleNegativeZNv = 5,
		ViewportCoordinateSwizzlePositiveWNv = 6,
		ViewportCoordinateSwizzleNegativeWNv = 7
	}

	public enum DiscardRectangleModeEXT {
		DiscardRectangleModeInclusiveExt = 0,
		DiscardRectangleModeExclusiveExt = 1
	}

	public enum PointClippingBehavior {
		PointClippingBehaviorAllClipPlanes = 0,
		PointClippingBehaviorUserClipPlanesOnly = 1,
		PointClippingBehaviorAllClipPlanesKhr = PointClippingBehaviorAllClipPlanes,
		PointClippingBehaviorUserClipPlanesOnlyKhr = PointClippingBehaviorUserClipPlanesOnly
	}

	public enum CoverageModulationModeNV {
		CoverageModulationModeNoneNv = 0,
		CoverageModulationModeRgbNv = 1,
		CoverageModulationModeAlphaNv = 2,
		CoverageModulationModeRgbaNv = 3
	}

	public enum CoverageReductionModeNV {
		CoverageReductionModeMergeNv = 0,
		CoverageReductionModeTruncateNv = 1
	}

	public enum ValidationCacheHeaderVersionEXT {
		ValidationCacheHeaderVersionOneExt = 1
	}

	public enum ShaderInfoTypeAMD {
		ShaderInfoTypeStatisticsAmd = 0,
		ShaderInfoTypeBinaryAmd = 1,
		ShaderInfoTypeDisassemblyAmd = 2
	}

	public enum QueueGlobalPriorityEXT {
		QueueGlobalPriorityLowExt = 128,
		QueueGlobalPriorityMediumExt = 256,
		QueueGlobalPriorityHighExt = 512,
		QueueGlobalPriorityRealtimeExt = 1024
	}

	public enum TimeDomainEXT {
		TimeDomainDeviceExt = 0,
		TimeDomainClockMonotonicExt = 1,
		TimeDomainClockMonotonicRawExt = 2,
		TimeDomainQueryPerformanceCounterExt = 3
	}

	public enum ConservativeRasterizationModeEXT {
		ConservativeRasterizationModeDisabledExt = 0,
		ConservativeRasterizationModeOverestimateExt = 1,
		ConservativeRasterizationModeUnderestimateExt = 2
	}

	public enum SemaphoreType {
		SemaphoreTypeBinary = 0,
		SemaphoreTypeTimeline = 1,
		SemaphoreTypeBinaryKhr = SemaphoreTypeBinary,
		SemaphoreTypeTimelineKhr = SemaphoreTypeTimeline
	}

	public enum CopyAccelerationStructureModeKHR {
		CopyAccelerationStructureModeCloneKhr = 0,
		CopyAccelerationStructureModeCompactKhr = 1,
		CopyAccelerationStructureModeSerializeKhr = 2,
		CopyAccelerationStructureModeDeserializeKhr = 3,
		CopyAccelerationStructureModeCloneNv = CopyAccelerationStructureModeCloneKhr,
		CopyAccelerationStructureModeCompactNv = CopyAccelerationStructureModeCompactKhr
	}

	public enum AccelerationStructureTypeKHR {
		AccelerationStructureTypeTopLevelKhr = 0,
		AccelerationStructureTypeBottomLevelKhr = 1,
		AccelerationStructureTypeTopLevelNv = AccelerationStructureTypeTopLevelKhr,
		AccelerationStructureTypeBottomLevelNv = AccelerationStructureTypeBottomLevelKhr
	}

	public enum GeometryTypeKHR {
		GeometryTypeTrianglesKhr = 0,
		GeometryTypeAabbsKhr = 1,
		GeometryTypeInstancesKhr = 1000150000,
		GeometryTypeTrianglesNv = GeometryTypeTrianglesKhr,
		GeometryTypeAabbsNv = GeometryTypeAabbsKhr
	}

	public enum RayTracingShaderGroupTypeKHR {
		RayTracingShaderGroupTypeGeneralKhr = 0,
		RayTracingShaderGroupTypeTrianglesHitGroupKhr = 1,
		RayTracingShaderGroupTypeProceduralHitGroupKhr = 2,
		RayTracingShaderGroupTypeGeneralNv = RayTracingShaderGroupTypeGeneralKhr,
		RayTracingShaderGroupTypeTrianglesHitGroupNv = RayTracingShaderGroupTypeTrianglesHitGroupKhr,
		RayTracingShaderGroupTypeProceduralHitGroupNv = RayTracingShaderGroupTypeProceduralHitGroupKhr
	}

	public enum AccelerationStructureMemoryRequirementsTypeKHR {
		AccelerationStructureMemoryRequirementsTypeObjectKhr = 0,
		AccelerationStructureMemoryRequirementsTypeBuildScratchKhr = 1,
		AccelerationStructureMemoryRequirementsTypeUpdateScratchKhr = 2,
		AccelerationStructureMemoryRequirementsTypeObjectNv = AccelerationStructureMemoryRequirementsTypeObjectKhr,
		AccelerationStructureMemoryRequirementsTypeBuildScratchNv = AccelerationStructureMemoryRequirementsTypeBuildScratchKhr,
		AccelerationStructureMemoryRequirementsTypeUpdateScratchNv = AccelerationStructureMemoryRequirementsTypeUpdateScratchKhr
	}

	public enum AccelerationStructureBuildTypeKHR {
		AccelerationStructureBuildTypeHostKhr = 0,
		AccelerationStructureBuildTypeDeviceKhr = 1,
		AccelerationStructureBuildTypeHostOrDeviceKhr = 2
	}

	public enum MemoryOverallocationBehaviorAMD {
		MemoryOverallocationBehaviorDefaultAmd = 0,
		MemoryOverallocationBehaviorAllowedAmd = 1,
		MemoryOverallocationBehaviorDisallowedAmd = 2
	}

	public enum ScopeNV {
		ScopeDeviceNv = 1,
		ScopeWorkgroupNv = 2,
		ScopeSubgroupNv = 3,
		ScopeQueueFamilyNv = 5
	}

	public enum ComponentTypeNV {
		ComponentTypeFloat16Nv = 0,
		ComponentTypeFloat32Nv = 1,
		ComponentTypeFloat64Nv = 2,
		ComponentTypeSint8Nv = 3,
		ComponentTypeSint16Nv = 4,
		ComponentTypeSint32Nv = 5,
		ComponentTypeSint64Nv = 6,
		ComponentTypeUint8Nv = 7,
		ComponentTypeUint16Nv = 8,
		ComponentTypeUint32Nv = 9,
		ComponentTypeUint64Nv = 10
	}

	public enum PerformanceCounterScopeKHR {
		PerformanceCounterScopeCommandBufferKhr = 0,
		PerformanceCounterScopeRenderPassKhr = 1,
		PerformanceCounterScopeCommandKhr = 2,
		QueryScopeCommandBufferKhr = PerformanceCounterScopeCommandBufferKhr,
		QueryScopeRenderPassKhr = PerformanceCounterScopeRenderPassKhr,
		QueryScopeCommandKhr = PerformanceCounterScopeCommandKhr
	}

	public enum PerformanceCounterUnitKHR {
		PerformanceCounterUnitGenericKhr = 0,
		PerformanceCounterUnitPercentageKhr = 1,
		PerformanceCounterUnitNanosecondsKhr = 2,
		PerformanceCounterUnitBytesKhr = 3,
		PerformanceCounterUnitBytesPerSecondKhr = 4,
		PerformanceCounterUnitKelvinKhr = 5,
		PerformanceCounterUnitWattsKhr = 6,
		PerformanceCounterUnitVoltsKhr = 7,
		PerformanceCounterUnitAmpsKhr = 8,
		PerformanceCounterUnitHertzKhr = 9,
		PerformanceCounterUnitCyclesKhr = 10
	}

	public enum PerformanceCounterStorageKHR {
		PerformanceCounterStorageInt32Khr = 0,
		PerformanceCounterStorageInt64Khr = 1,
		PerformanceCounterStorageUint32Khr = 2,
		PerformanceCounterStorageUint64Khr = 3,
		PerformanceCounterStorageFloat32Khr = 4,
		PerformanceCounterStorageFloat64Khr = 5
	}

	public enum PerformanceConfigurationTypeINTEL {
		PerformanceConfigurationTypeCommandQueueMetricsDiscoveryActivatedIntel = 0
	}

	public enum QueryPoolSamplingModeINTEL {
		QueryPoolSamplingModeManualIntel = 0
	}

	public enum PerformanceOverrideTypeINTEL {
		PerformanceOverrideTypeNullHardwareIntel = 0,
		PerformanceOverrideTypeFlushGpuCachesIntel = 1
	}

	public enum PerformanceParameterTypeINTEL {
		PerformanceParameterTypeHwCountersSupportedIntel = 0,
		PerformanceParameterTypeStreamMarkerValidBitsIntel = 1
	}

	public enum PerformanceValueTypeINTEL {
		PerformanceValueTypeUint32Intel = 0,
		PerformanceValueTypeUint64Intel = 1,
		PerformanceValueTypeFloatIntel = 2,
		PerformanceValueTypeBoolIntel = 3,
		PerformanceValueTypeStringIntel = 4
	}

	public enum LineRasterizationModeEXT {
		LineRasterizationModeDefaultExt = 0,
		LineRasterizationModeRectangularExt = 1,
		LineRasterizationModeBresenhamExt = 2,
		LineRasterizationModeRectangularSmoothExt = 3
	}

	public enum ColorSpaceKHR {
		ColorSpaceSrgbNonlinearKhr = 0,
		ColorspaceSrgbNonlinearKhr = ColorSpaceSrgbNonlinearKhr,
		ColorSpaceDisplayP3NonlinearExt = 1000104001,
		ColorSpaceExtendedSrgbLinearExt = 1000104002,
		ColorSpaceDisplayP3LinearExt = 1000104003,
		ColorSpaceDciP3NonlinearExt = 1000104004,
		ColorSpaceBt709LinearExt = 1000104005,
		ColorSpaceBt709NonlinearExt = 1000104006,
		ColorSpaceBt2020LinearExt = 1000104007,
		ColorSpaceHdr10St2084Ext = 1000104008,
		ColorSpaceDolbyvisionExt = 1000104009,
		ColorSpaceHdr10HlgExt = 1000104010,
		ColorSpaceAdobergbLinearExt = 1000104011,
		ColorSpaceAdobergbNonlinearExt = 1000104012,
		ColorSpacePassThroughExt = 1000104013,
		ColorSpaceExtendedSrgbNonlinearExt = 1000104014,
		ColorSpaceDciP3LinearExt = ColorSpaceDisplayP3LinearExt,
		ColorSpaceDisplayNativeAmd = 1000213000
	}

	public enum PresentModeKHR {
		PresentModeImmediateKhr = 0,
		PresentModeMailboxKhr = 1,
		PresentModeFifoKhr = 2,
		PresentModeFifoRelaxedKhr = 3,
		PresentModeSharedDemandRefreshKhr = 1000111000,
		PresentModeSharedContinuousRefreshKhr = 1000111001
	}

	public enum DebugReportObjectTypeEXT {
		DebugReportObjectTypeUnknownExt = 0,
		DebugReportObjectTypeInstanceExt = 1,
		DebugReportObjectTypePhysicalDeviceExt = 2,
		DebugReportObjectTypeDeviceExt = 3,
		DebugReportObjectTypeQueueExt = 4,
		DebugReportObjectTypeSemaphoreExt = 5,
		DebugReportObjectTypeCommandBufferExt = 6,
		DebugReportObjectTypeFenceExt = 7,
		DebugReportObjectTypeDeviceMemoryExt = 8,
		DebugReportObjectTypeBufferExt = 9,
		DebugReportObjectTypeImageExt = 10,
		DebugReportObjectTypeEventExt = 11,
		DebugReportObjectTypeQueryPoolExt = 12,
		DebugReportObjectTypeBufferViewExt = 13,
		DebugReportObjectTypeImageViewExt = 14,
		DebugReportObjectTypeShaderModuleExt = 15,
		DebugReportObjectTypePipelineCacheExt = 16,
		DebugReportObjectTypePipelineLayoutExt = 17,
		DebugReportObjectTypeRenderPassExt = 18,
		DebugReportObjectTypePipelineExt = 19,
		DebugReportObjectTypeDescriptorSetLayoutExt = 20,
		DebugReportObjectTypeSamplerExt = 21,
		DebugReportObjectTypeDescriptorPoolExt = 22,
		DebugReportObjectTypeDescriptorSetExt = 23,
		DebugReportObjectTypeFramebufferExt = 24,
		DebugReportObjectTypeCommandPoolExt = 25,
		DebugReportObjectTypeSurfaceKhrExt = 26,
		DebugReportObjectTypeSwapchainKhrExt = 27,
		DebugReportObjectTypeDebugReportCallbackExtExt = 28,
		DebugReportObjectTypeDebugReportExt = DebugReportObjectTypeDebugReportCallbackExtExt,
		DebugReportObjectTypeDisplayKhrExt = 29,
		DebugReportObjectTypeDisplayModeKhrExt = 30,
		DebugReportObjectTypeValidationCacheExtExt = 33,
		DebugReportObjectTypeValidationCacheExt = DebugReportObjectTypeValidationCacheExtExt,
		DebugReportObjectTypeSamplerYcbcrConversionExt = 1000156000,
		DebugReportObjectTypeDescriptorUpdateTemplateExt = 1000085000,
		DebugReportObjectTypeDescriptorUpdateTemplateKhrExt = DebugReportObjectTypeDescriptorUpdateTemplateExt,
		DebugReportObjectTypeAccelerationStructureKhrExt = 1000165000,
		DebugReportObjectTypeSamplerYcbcrConversionKhrExt = DebugReportObjectTypeSamplerYcbcrConversionExt,
		DebugReportObjectTypeAccelerationStructureNvExt = DebugReportObjectTypeAccelerationStructureKhrExt
	}

	public enum RasterizationOrderAMD {
		RasterizationOrderStrictAmd = 0,
		RasterizationOrderRelaxedAmd = 1
	}

	public enum ValidationCheckEXT {
		ValidationCheckAllExt = 0,
		ValidationCheckShadersExt = 1
	}

	public enum ValidationFeatureEnableEXT {
		ValidationFeatureEnableGpuAssistedExt = 0,
		ValidationFeatureEnableGpuAssistedReserveBindingSlotExt = 1,
		ValidationFeatureEnableBestPracticesExt = 2,
		ValidationFeatureEnableDebugPrintfExt = 3
	}

	public enum ValidationFeatureDisableEXT {
		ValidationFeatureDisableAllExt = 0,
		ValidationFeatureDisableShadersExt = 1,
		ValidationFeatureDisableThreadSafetyExt = 2,
		ValidationFeatureDisableApiParametersExt = 3,
		ValidationFeatureDisableObjectLifetimesExt = 4,
		ValidationFeatureDisableCoreChecksExt = 5,
		ValidationFeatureDisableUniqueHandlesExt = 6
	}

	public enum DisplayPowerStateEXT {
		DisplayPowerStateOffExt = 0,
		DisplayPowerStateSuspendExt = 1,
		DisplayPowerStateOnExt = 2
	}

	public enum DeviceEventTypeEXT {
		DeviceEventTypeDisplayHotplugExt = 0
	}

	public enum DisplayEventTypeEXT {
		DisplayEventTypeFirstPixelOutExt = 0
	}

	public enum TessellationDomainOrigin {
		TessellationDomainOriginUpperLeft = 0,
		TessellationDomainOriginLowerLeft = 1,
		TessellationDomainOriginUpperLeftKhr = TessellationDomainOriginUpperLeft,
		TessellationDomainOriginLowerLeftKhr = TessellationDomainOriginLowerLeft
	}

	public enum SamplerYcbcrModelConversion {
		SamplerYcbcrModelConversionRgbIdentity = 0,
		SamplerYcbcrModelConversionYcbcrIdentity = 1,
		SamplerYcbcrModelConversionYcbcr709 = 2,
		SamplerYcbcrModelConversionYcbcr601 = 3,
		SamplerYcbcrModelConversionYcbcr2020 = 4,
		SamplerYcbcrModelConversionRgbIdentityKhr = SamplerYcbcrModelConversionRgbIdentity,
		SamplerYcbcrModelConversionYcbcrIdentityKhr = SamplerYcbcrModelConversionYcbcrIdentity,
		SamplerYcbcrModelConversionYcbcr709Khr = SamplerYcbcrModelConversionYcbcr709,
		SamplerYcbcrModelConversionYcbcr601Khr = SamplerYcbcrModelConversionYcbcr601,
		SamplerYcbcrModelConversionYcbcr2020Khr = SamplerYcbcrModelConversionYcbcr2020
	}

	public enum SamplerYcbcrRange {
		SamplerYcbcrRangeItuFull = 0,
		SamplerYcbcrRangeItuNarrow = 1,
		SamplerYcbcrRangeItuFullKhr = SamplerYcbcrRangeItuFull,
		SamplerYcbcrRangeItuNarrowKhr = SamplerYcbcrRangeItuNarrow
	}

	public enum ChromaLocation {
		ChromaLocationCositedEven = 0,
		ChromaLocationMidpoint = 1,
		ChromaLocationCositedEvenKhr = ChromaLocationCositedEven,
		ChromaLocationMidpointKhr = ChromaLocationMidpoint
	}

	public enum SamplerReductionMode {
		SamplerReductionModeWeightedAverage = 0,
		SamplerReductionModeMin = 1,
		SamplerReductionModeMax = 2,
		SamplerReductionModeWeightedAverageExt = SamplerReductionModeWeightedAverage,
		SamplerReductionModeMinExt = SamplerReductionModeMin,
		SamplerReductionModeMaxExt = SamplerReductionModeMax
	}

	public enum BlendOverlapEXT {
		BlendOverlapUncorrelatedExt = 0,
		BlendOverlapDisjointExt = 1,
		BlendOverlapConjointExt = 2
	}

	public enum FullScreenExclusiveEXT {
		FullScreenExclusiveDefaultExt = 0,
		FullScreenExclusiveAllowedExt = 1,
		FullScreenExclusiveDisallowedExt = 2,
		FullScreenExclusiveApplicationControlledExt = 3
	}

	public enum ShaderFloatControlsIndependence {
		ShaderFloatControlsIndependence32BitOnly = 0,
		ShaderFloatControlsIndependenceAll = 1,
		ShaderFloatControlsIndependenceNone = 2,
		ShaderFloatControlsIndependence32BitOnlyKhr = ShaderFloatControlsIndependence32BitOnly,
		ShaderFloatControlsIndependenceAllKhr = ShaderFloatControlsIndependenceAll,
		ShaderFloatControlsIndependenceNoneKhr = ShaderFloatControlsIndependenceNone
	}

	public enum VendorId {
		VendorIdViv = 0x10001,
		VendorIdVsi = 0x10002,
		VendorIdKazan = 0x10003,
		VendorIdCodeplay = 0x10004,
		VendorIdMesa = 0x10005
	}

	public enum DriverId {
		DriverIdAmdProprietary = 1,
		DriverIdAmdOpenSource = 2,
		DriverIdMesaRadv = 3,
		DriverIdNvidiaProprietary = 4,
		DriverIdIntelProprietaryWindows = 5,
		DriverIdIntelOpenSourceMesa = 6,
		DriverIdImaginationProprietary = 7,
		DriverIdQualcommProprietary = 8,
		DriverIdArmProprietary = 9,
		DriverIdGoogleSwiftshader = 10,
		DriverIdGgpProprietary = 11,
		DriverIdBroadcomProprietary = 12,
		DriverIdMesaLlvmpipe = 13,
		DriverIdAmdProprietaryKhr = DriverIdAmdProprietary,
		DriverIdAmdOpenSourceKhr = DriverIdAmdOpenSource,
		DriverIdMesaRadvKhr = DriverIdMesaRadv,
		DriverIdNvidiaProprietaryKhr = DriverIdNvidiaProprietary,
		DriverIdIntelProprietaryWindowsKhr = DriverIdIntelProprietaryWindows,
		DriverIdIntelOpenSourceMesaKhr = DriverIdIntelOpenSourceMesa,
		DriverIdImaginationProprietaryKhr = DriverIdImaginationProprietary,
		DriverIdQualcommProprietaryKhr = DriverIdQualcommProprietary,
		DriverIdArmProprietaryKhr = DriverIdArmProprietary,
		DriverIdGoogleSwiftshaderKhr = DriverIdGoogleSwiftshader,
		DriverIdGgpProprietaryKhr = DriverIdGgpProprietary,
		DriverIdBroadcomProprietaryKhr = DriverIdBroadcomProprietary
	}

	public enum ShadingRatePaletteEntryNV {
		ShadingRatePaletteEntryNoInvocationsNv = 0,
		ShadingRatePaletteEntry16InvocationsPerPixelNv = 1,
		ShadingRatePaletteEntry8InvocationsPerPixelNv = 2,
		ShadingRatePaletteEntry4InvocationsPerPixelNv = 3,
		ShadingRatePaletteEntry2InvocationsPerPixelNv = 4,
		ShadingRatePaletteEntry1InvocationPerPixelNv = 5,
		ShadingRatePaletteEntry1InvocationPer2x1PixelsNv = 6,
		ShadingRatePaletteEntry1InvocationPer1x2PixelsNv = 7,
		ShadingRatePaletteEntry1InvocationPer2x2PixelsNv = 8,
		ShadingRatePaletteEntry1InvocationPer4x2PixelsNv = 9,
		ShadingRatePaletteEntry1InvocationPer2x4PixelsNv = 10,
		ShadingRatePaletteEntry1InvocationPer4x4PixelsNv = 11
	}

	public enum CoarseSampleOrderTypeNV {
		CoarseSampleOrderTypeDefaultNv = 0,
		CoarseSampleOrderTypeCustomNv = 1,
		CoarseSampleOrderTypePixelMajorNv = 2,
		CoarseSampleOrderTypeSampleMajorNv = 3
	}

	public enum PipelineExecutableStatisticFormatKHR {
		PipelineExecutableStatisticFormatBool32Khr = 0,
		PipelineExecutableStatisticFormatInt64Khr = 1,
		PipelineExecutableStatisticFormatUint64Khr = 2,
		PipelineExecutableStatisticFormatFloat64Khr = 3
	}
































































































































































}
