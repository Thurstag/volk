// Copyright 2020-2020 Volk Project
// Licensed under Apache License 2.0 or any later version
// Refer to the LICENSE.md file included.

using System;
using System.Text;
using Volk.Vulkan;

namespace Volk {
	public static partial class Functions {
		public static void LoadInstance(IntPtr instance) {
			if (CommandTable.GetInstanceProcAddr == null) {
				throw new Exception("GetInstanceProcAddr isn't loaded");
			}

			unsafe {
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyInstance")[0]) {
					CommandTable.DestroyInstance = FunctionPtrToDelegate<Commands.DestroyInstance>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkEnumeratePhysicalDevices")[0]) {
					CommandTable.EnumeratePhysicalDevices = FunctionPtrToDelegate<Commands.EnumeratePhysicalDevices>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDeviceProcAddr")[0]) {
					CommandTable.GetDeviceProcAddr = FunctionPtrToDelegate<Commands.GetDeviceProcAddr>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceProperties")[0]) {
					CommandTable.GetPhysicalDeviceProperties = FunctionPtrToDelegate<Commands.GetPhysicalDeviceProperties>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceQueueFamilyProperties")[0]) {
					CommandTable.GetPhysicalDeviceQueueFamilyProperties = FunctionPtrToDelegate<Commands.GetPhysicalDeviceQueueFamilyProperties>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceMemoryProperties")[0]) {
					CommandTable.GetPhysicalDeviceMemoryProperties = FunctionPtrToDelegate<Commands.GetPhysicalDeviceMemoryProperties>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceFeatures")[0]) {
					CommandTable.GetPhysicalDeviceFeatures = FunctionPtrToDelegate<Commands.GetPhysicalDeviceFeatures>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceFormatProperties")[0]) {
					CommandTable.GetPhysicalDeviceFormatProperties = FunctionPtrToDelegate<Commands.GetPhysicalDeviceFormatProperties>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceImageFormatProperties")[0]) {
					CommandTable.GetPhysicalDeviceImageFormatProperties = FunctionPtrToDelegate<Commands.GetPhysicalDeviceImageFormatProperties>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateDevice")[0]) {
					CommandTable.CreateDevice = FunctionPtrToDelegate<Commands.CreateDevice>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkEnumerateDeviceLayerProperties")[0]) {
					CommandTable.EnumerateDeviceLayerProperties = FunctionPtrToDelegate<Commands.EnumerateDeviceLayerProperties>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkEnumerateDeviceExtensionProperties")[0]) {
					CommandTable.EnumerateDeviceExtensionProperties = FunctionPtrToDelegate<Commands.EnumerateDeviceExtensionProperties>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceSparseImageFormatProperties")[0]) {
					CommandTable.GetPhysicalDeviceSparseImageFormatProperties = FunctionPtrToDelegate<Commands.GetPhysicalDeviceSparseImageFormatProperties>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateAndroidSurfaceKHR")[0]) {
					CommandTable.CreateAndroidSurfaceKHR = FunctionPtrToDelegate<Commands.CreateAndroidSurfaceKHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceDisplayPropertiesKHR")[0]) {
					CommandTable.GetPhysicalDeviceDisplayPropertiesKHR = FunctionPtrToDelegate<Commands.GetPhysicalDeviceDisplayPropertiesKHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceDisplayPlanePropertiesKHR")[0]) {
					CommandTable.GetPhysicalDeviceDisplayPlanePropertiesKHR = FunctionPtrToDelegate<Commands.GetPhysicalDeviceDisplayPlanePropertiesKHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDisplayPlaneSupportedDisplaysKHR")[0]) {
					CommandTable.GetDisplayPlaneSupportedDisplaysKHR = FunctionPtrToDelegate<Commands.GetDisplayPlaneSupportedDisplaysKHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDisplayModePropertiesKHR")[0]) {
					CommandTable.GetDisplayModePropertiesKHR = FunctionPtrToDelegate<Commands.GetDisplayModePropertiesKHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateDisplayModeKHR")[0]) {
					CommandTable.CreateDisplayModeKHR = FunctionPtrToDelegate<Commands.CreateDisplayModeKHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDisplayPlaneCapabilitiesKHR")[0]) {
					CommandTable.GetDisplayPlaneCapabilitiesKHR = FunctionPtrToDelegate<Commands.GetDisplayPlaneCapabilitiesKHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateDisplayPlaneSurfaceKHR")[0]) {
					CommandTable.CreateDisplayPlaneSurfaceKHR = FunctionPtrToDelegate<Commands.CreateDisplayPlaneSurfaceKHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroySurfaceKHR")[0]) {
					CommandTable.DestroySurfaceKHR = FunctionPtrToDelegate<Commands.DestroySurfaceKHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceSurfaceSupportKHR")[0]) {
					CommandTable.GetPhysicalDeviceSurfaceSupportKHR = FunctionPtrToDelegate<Commands.GetPhysicalDeviceSurfaceSupportKHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceSurfaceCapabilitiesKHR")[0]) {
					CommandTable.GetPhysicalDeviceSurfaceCapabilitiesKHR = FunctionPtrToDelegate<Commands.GetPhysicalDeviceSurfaceCapabilitiesKHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceSurfaceFormatsKHR")[0]) {
					CommandTable.GetPhysicalDeviceSurfaceFormatsKHR = FunctionPtrToDelegate<Commands.GetPhysicalDeviceSurfaceFormatsKHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceSurfacePresentModesKHR")[0]) {
					CommandTable.GetPhysicalDeviceSurfacePresentModesKHR = FunctionPtrToDelegate<Commands.GetPhysicalDeviceSurfacePresentModesKHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateViSurfaceNN")[0]) {
					CommandTable.CreateViSurfaceNN = FunctionPtrToDelegate<Commands.CreateViSurfaceNN>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateWaylandSurfaceKHR")[0]) {
					CommandTable.CreateWaylandSurfaceKHR = FunctionPtrToDelegate<Commands.CreateWaylandSurfaceKHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceWaylandPresentationSupportKHR")[0]) {
					CommandTable.GetPhysicalDeviceWaylandPresentationSupportKHR = FunctionPtrToDelegate<Commands.GetPhysicalDeviceWaylandPresentationSupportKHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateWin32SurfaceKHR")[0]) {
					CommandTable.CreateWin32SurfaceKHR = FunctionPtrToDelegate<Commands.CreateWin32SurfaceKHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceWin32PresentationSupportKHR")[0]) {
					CommandTable.GetPhysicalDeviceWin32PresentationSupportKHR = FunctionPtrToDelegate<Commands.GetPhysicalDeviceWin32PresentationSupportKHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateXlibSurfaceKHR")[0]) {
					CommandTable.CreateXlibSurfaceKHR = FunctionPtrToDelegate<Commands.CreateXlibSurfaceKHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceXlibPresentationSupportKHR")[0]) {
					CommandTable.GetPhysicalDeviceXlibPresentationSupportKHR = FunctionPtrToDelegate<Commands.GetPhysicalDeviceXlibPresentationSupportKHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateXcbSurfaceKHR")[0]) {
					CommandTable.CreateXcbSurfaceKHR = FunctionPtrToDelegate<Commands.CreateXcbSurfaceKHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceXcbPresentationSupportKHR")[0]) {
					CommandTable.GetPhysicalDeviceXcbPresentationSupportKHR = FunctionPtrToDelegate<Commands.GetPhysicalDeviceXcbPresentationSupportKHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateDirectFBSurfaceEXT")[0]) {
					CommandTable.CreateDirectFBSurfaceEXT = FunctionPtrToDelegate<Commands.CreateDirectFBSurfaceEXT>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceDirectFBPresentationSupportEXT")[0]) {
					CommandTable.GetPhysicalDeviceDirectFBPresentationSupportEXT = FunctionPtrToDelegate<Commands.GetPhysicalDeviceDirectFBPresentationSupportEXT>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateImagePipeSurfaceFUCHSIA")[0]) {
					CommandTable.CreateImagePipeSurfaceFUCHSIA = FunctionPtrToDelegate<Commands.CreateImagePipeSurfaceFUCHSIA>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateStreamDescriptorSurfaceGGP")[0]) {
					CommandTable.CreateStreamDescriptorSurfaceGGP = FunctionPtrToDelegate<Commands.CreateStreamDescriptorSurfaceGGP>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateDebugReportCallbackEXT")[0]) {
					CommandTable.CreateDebugReportCallbackEXT = FunctionPtrToDelegate<Commands.CreateDebugReportCallbackEXT>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyDebugReportCallbackEXT")[0]) {
					CommandTable.DestroyDebugReportCallbackEXT = FunctionPtrToDelegate<Commands.DestroyDebugReportCallbackEXT>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDebugReportMessageEXT")[0]) {
					CommandTable.DebugReportMessageEXT = FunctionPtrToDelegate<Commands.DebugReportMessageEXT>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceExternalImageFormatPropertiesNV")[0]) {
					CommandTable.GetPhysicalDeviceExternalImageFormatPropertiesNV = FunctionPtrToDelegate<Commands.GetPhysicalDeviceExternalImageFormatPropertiesNV>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceFeatures2")[0]) {
					CommandTable.GetPhysicalDeviceFeatures2 = FunctionPtrToDelegate<Commands.GetPhysicalDeviceFeatures2>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceProperties2")[0]) {
					CommandTable.GetPhysicalDeviceProperties2 = FunctionPtrToDelegate<Commands.GetPhysicalDeviceProperties2>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceFormatProperties2")[0]) {
					CommandTable.GetPhysicalDeviceFormatProperties2 = FunctionPtrToDelegate<Commands.GetPhysicalDeviceFormatProperties2>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceImageFormatProperties2")[0]) {
					CommandTable.GetPhysicalDeviceImageFormatProperties2 = FunctionPtrToDelegate<Commands.GetPhysicalDeviceImageFormatProperties2>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceQueueFamilyProperties2")[0]) {
					CommandTable.GetPhysicalDeviceQueueFamilyProperties2 = FunctionPtrToDelegate<Commands.GetPhysicalDeviceQueueFamilyProperties2>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceMemoryProperties2")[0]) {
					CommandTable.GetPhysicalDeviceMemoryProperties2 = FunctionPtrToDelegate<Commands.GetPhysicalDeviceMemoryProperties2>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceSparseImageFormatProperties2")[0]) {
					CommandTable.GetPhysicalDeviceSparseImageFormatProperties2 = FunctionPtrToDelegate<Commands.GetPhysicalDeviceSparseImageFormatProperties2>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceExternalBufferProperties")[0]) {
					CommandTable.GetPhysicalDeviceExternalBufferProperties = FunctionPtrToDelegate<Commands.GetPhysicalDeviceExternalBufferProperties>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceExternalSemaphoreProperties")[0]) {
					CommandTable.GetPhysicalDeviceExternalSemaphoreProperties = FunctionPtrToDelegate<Commands.GetPhysicalDeviceExternalSemaphoreProperties>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceExternalFenceProperties")[0]) {
					CommandTable.GetPhysicalDeviceExternalFenceProperties = FunctionPtrToDelegate<Commands.GetPhysicalDeviceExternalFenceProperties>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkReleaseDisplayEXT")[0]) {
					CommandTable.ReleaseDisplayEXT = FunctionPtrToDelegate<Commands.ReleaseDisplayEXT>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkAcquireXlibDisplayEXT")[0]) {
					CommandTable.AcquireXlibDisplayEXT = FunctionPtrToDelegate<Commands.AcquireXlibDisplayEXT>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetRandROutputDisplayEXT")[0]) {
					CommandTable.GetRandROutputDisplayEXT = FunctionPtrToDelegate<Commands.GetRandROutputDisplayEXT>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceSurfaceCapabilities2EXT")[0]) {
					CommandTable.GetPhysicalDeviceSurfaceCapabilities2EXT = FunctionPtrToDelegate<Commands.GetPhysicalDeviceSurfaceCapabilities2EXT>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkEnumeratePhysicalDeviceGroups")[0]) {
					CommandTable.EnumeratePhysicalDeviceGroups = FunctionPtrToDelegate<Commands.EnumeratePhysicalDeviceGroups>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDevicePresentRectanglesKHR")[0]) {
					CommandTable.GetPhysicalDevicePresentRectanglesKHR = FunctionPtrToDelegate<Commands.GetPhysicalDevicePresentRectanglesKHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateIOSSurfaceMVK")[0]) {
					CommandTable.CreateIOSSurfaceMVK = FunctionPtrToDelegate<Commands.CreateIOSSurfaceMVK>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateMacOSSurfaceMVK")[0]) {
					CommandTable.CreateMacOSSurfaceMVK = FunctionPtrToDelegate<Commands.CreateMacOSSurfaceMVK>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateMetalSurfaceEXT")[0]) {
					CommandTable.CreateMetalSurfaceEXT = FunctionPtrToDelegate<Commands.CreateMetalSurfaceEXT>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceMultisamplePropertiesEXT")[0]) {
					CommandTable.GetPhysicalDeviceMultisamplePropertiesEXT = FunctionPtrToDelegate<Commands.GetPhysicalDeviceMultisamplePropertiesEXT>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceSurfaceCapabilities2KHR")[0]) {
					CommandTable.GetPhysicalDeviceSurfaceCapabilities2KHR = FunctionPtrToDelegate<Commands.GetPhysicalDeviceSurfaceCapabilities2KHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceSurfaceFormats2KHR")[0]) {
					CommandTable.GetPhysicalDeviceSurfaceFormats2KHR = FunctionPtrToDelegate<Commands.GetPhysicalDeviceSurfaceFormats2KHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceDisplayProperties2KHR")[0]) {
					CommandTable.GetPhysicalDeviceDisplayProperties2KHR = FunctionPtrToDelegate<Commands.GetPhysicalDeviceDisplayProperties2KHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceDisplayPlaneProperties2KHR")[0]) {
					CommandTable.GetPhysicalDeviceDisplayPlaneProperties2KHR = FunctionPtrToDelegate<Commands.GetPhysicalDeviceDisplayPlaneProperties2KHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDisplayModeProperties2KHR")[0]) {
					CommandTable.GetDisplayModeProperties2KHR = FunctionPtrToDelegate<Commands.GetDisplayModeProperties2KHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDisplayPlaneCapabilities2KHR")[0]) {
					CommandTable.GetDisplayPlaneCapabilities2KHR = FunctionPtrToDelegate<Commands.GetDisplayPlaneCapabilities2KHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceCalibrateableTimeDomainsEXT")[0]) {
					CommandTable.GetPhysicalDeviceCalibrateableTimeDomainsEXT = FunctionPtrToDelegate<Commands.GetPhysicalDeviceCalibrateableTimeDomainsEXT>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateDebugUtilsMessengerEXT")[0]) {
					CommandTable.CreateDebugUtilsMessengerEXT = FunctionPtrToDelegate<Commands.CreateDebugUtilsMessengerEXT>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyDebugUtilsMessengerEXT")[0]) {
					CommandTable.DestroyDebugUtilsMessengerEXT = FunctionPtrToDelegate<Commands.DestroyDebugUtilsMessengerEXT>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkSubmitDebugUtilsMessageEXT")[0]) {
					CommandTable.SubmitDebugUtilsMessageEXT = FunctionPtrToDelegate<Commands.SubmitDebugUtilsMessageEXT>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceCooperativeMatrixPropertiesNV")[0]) {
					CommandTable.GetPhysicalDeviceCooperativeMatrixPropertiesNV = FunctionPtrToDelegate<Commands.GetPhysicalDeviceCooperativeMatrixPropertiesNV>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceSurfacePresentModes2EXT")[0]) {
					CommandTable.GetPhysicalDeviceSurfacePresentModes2EXT = FunctionPtrToDelegate<Commands.GetPhysicalDeviceSurfacePresentModes2EXT>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR")[0]) {
					CommandTable.EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR = FunctionPtrToDelegate<Commands.EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR")[0]) {
					CommandTable.GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR = FunctionPtrToDelegate<Commands.GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateHeadlessSurfaceEXT")[0]) {
					CommandTable.CreateHeadlessSurfaceEXT = FunctionPtrToDelegate<Commands.CreateHeadlessSurfaceEXT>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV")[0]) {
					CommandTable.GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV = FunctionPtrToDelegate<Commands.GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
				fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPhysicalDeviceToolPropertiesEXT")[0]) {
					CommandTable.GetPhysicalDeviceToolPropertiesEXT = FunctionPtrToDelegate<Commands.GetPhysicalDeviceToolPropertiesEXT>(CommandTable.GetInstanceProcAddr(instance, funcName));
				}
			}
		}
	}
}
