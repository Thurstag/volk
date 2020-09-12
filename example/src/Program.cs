// This code is an adaptation of the example provided by
// https://vulkan-tutorial.com/ (https://vulkan-tutorial.com/code/15_hello_triangle.cpp)

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using DotNetCross.NativeInts;
using GLFW;
using Volk.Vulkan;
using Volk.Vulkan.Types;
using Constants = GLFW.Constants;
using Exception = System.Exception;

namespace Volk.Example {
    /// <summary>
    /// Entry point
    /// </summary>
    internal static class Program {
        private const int WindowWidth = 800;
        private const int WindowHeight = 600;

        private static Window _window;
        private static IntPtr _instance;
        private static IntPtr _physicalDevice;
        private static IntPtr _device;
        private static IntPtr _surface;
        private static IntPtr _renderPass;
        private static IntPtr _pipelineLayout;
        private static IntPtr _graphicsPipeline;
        private static IntPtr _commandPool;
        private static IntPtr _graphicsQueue, _presentQueue;

        private static IntPtr[] _swapChainImageViews;
        private static IntPtr[] _swapChainImages;
        private static Format _swapChainImageFormat;
        private static Extent2D _swapChainExtent;
        private static IntPtr _swapchain;

        private static IntPtr[] _swapChainFramebuffers;
        private static IntPtr[] _commandBuffers;

        private static IntPtr[] _imageAvailableSemaphores;
        private static IntPtr[] _renderFinishedSemaphores;
        private static IntPtr[] _inFlightFences;
        private static IntPtr[] _imagesInFlight;

        private static bool _vsyncEnabled;
        private static bool _extraStatsEnabled;

        private static IntPtr _timestampQueryPool;
        private static float _gpuPeriod;

        private static int _currentFrame;
        private static ulong _frameCount;
        private static Stopwatch _stopwatch;

        private struct QueueFamilyIndices {
            public uint? GraphicsFamily;
            public uint? PresentFamily;

            public bool IsComplete() {
                return GraphicsFamily != null && PresentFamily != null;
            }
        }

        private struct SwapChainSupportDetails {
            public SurfaceCapabilitiesKHR Capabilities;
            public SurfaceFormatKHR[] Formats;
            public PresentModeKHR[] PresentModes;
        }

        private static void Main(string[] args) {
            // Initialize volk
            Functions.Initialize();

            // Check args
            if (args.Contains("-vsync")) {
                _vsyncEnabled = true;
            }

            if (args.Contains("-stats")) {
                _extraStatsEnabled = true;
            }

            // Init GLFW and Vulkan
            InitWindow();
            InitVulkan();

            // Draw frames
            MainLoop();

            // Clean-up
            Cleanup();
        }

        private static unsafe void Cleanup() {
            for (var i = 0; i < _swapChainImages.Length; i++) {
                CommandTable.DestroySemaphore(_device, _renderFinishedSemaphores[i], (AllocationCallbacks*) IntPtr.Zero);
                CommandTable.DestroySemaphore(_device, _imageAvailableSemaphores[i], (AllocationCallbacks*) IntPtr.Zero);
                CommandTable.DestroyFence(_device, _inFlightFences[i], (AllocationCallbacks*) IntPtr.Zero);
            }

            CommandTable.DestroyCommandPool(_device, _commandPool, (AllocationCallbacks*) IntPtr.Zero);

            foreach (var framebuffer in _swapChainFramebuffers) {
                CommandTable.DestroyFramebuffer(_device, framebuffer, (AllocationCallbacks*) IntPtr.Zero);
            }

            CommandTable.DestroyPipeline(_device, _graphicsPipeline, (AllocationCallbacks*) IntPtr.Zero);
            CommandTable.DestroyPipelineLayout(_device, _pipelineLayout, (AllocationCallbacks*) IntPtr.Zero);
            CommandTable.DestroyRenderPass(_device, _renderPass, (AllocationCallbacks*) IntPtr.Zero);

            foreach (var imageView in _swapChainImageViews) {
                CommandTable.DestroyImageView(_device, imageView, (AllocationCallbacks*) IntPtr.Zero);
            }

            CommandTable.DestroyQueryPool(_device, _timestampQueryPool, (AllocationCallbacks*) IntPtr.Zero);

            CommandTable.DestroySwapchainKHR(_device, _swapchain, (AllocationCallbacks*) IntPtr.Zero);
            CommandTable.DestroyDevice(_device, (AllocationCallbacks*) IntPtr.Zero);

            CommandTable.DestroySurfaceKHR(_instance, _surface, (AllocationCallbacks*) IntPtr.Zero);
            CommandTable.DestroyInstance(_instance, (AllocationCallbacks*) IntPtr.Zero);

            Glfw.DestroyWindow(_window);
            Glfw.Terminate();

            Functions.Destroy();
        }

        private static void InitVulkan() {
            CreateInstance();
            Functions.LoadInstance(_instance);
            CreateSurface();
            PickPhysicalDevice();
            CreateLogicalDevice();
            CreateSwapChain();
            CreateImageViews();
            CreateRenderPass();
            CreateGraphicsPipeline();
            CreateFramebuffers();
            CreateCommandPool();

            // Create timestamp query pool
            unsafe {
                fixed (IntPtr* ptr = &_timestampQueryPool) {
                    var createInfo = new QueryPoolCreateInfo {
                        sType = StructureType.StructureTypeQueryPoolCreateInfo,
                        queryCount = 128,
                        queryType = QueryType.QueryTypeTimestamp
                    };
                    CommandTable.CreateQueryPool(_device, &createInfo, (AllocationCallbacks*) IntPtr.Zero, ptr);
                }
            }

            CreateCommandBuffers();
            CreateSyncObjects();
        }

        private static unsafe void CreateSyncObjects() {
            _imageAvailableSemaphores = new IntPtr[_swapChainImages.Length];
            _renderFinishedSemaphores = new IntPtr[_swapChainImages.Length];
            _inFlightFences = new IntPtr[_swapChainImages.Length];
            _imagesInFlight = Enumerable.Range(0, _swapChainImages.Length).Select(i => IntPtr.Zero).ToArray();

            var semaphoreInfo = new SemaphoreCreateInfo {
                sType = StructureType.StructureTypeSemaphoreCreateInfo
            };

            var fenceInfo = new FenceCreateInfo {
                sType = StructureType.StructureTypeFenceCreateInfo,
                flags = FenceCreateFlags.FenceCreateSignaledBit
            };

            for (var i = 0; i < _swapChainImages.Length; i++) {
                fixed (IntPtr* availablePtr = &_imageAvailableSemaphores[i]) {
                    Assert(CommandTable.CreateSemaphore(_device, &semaphoreInfo, (AllocationCallbacks*) IntPtr.Zero, availablePtr), Result.Success,
                           "Image available semaphore creation");
                }

                fixed (IntPtr* renderPtr = &_renderFinishedSemaphores[i]) {
                    Assert(CommandTable.CreateSemaphore(_device, &semaphoreInfo, (AllocationCallbacks*) IntPtr.Zero, renderPtr), Result.Success,
                           "Rendering end semaphore creation");
                }

                fixed (IntPtr* flightPtr = &_inFlightFences[i]) {
                    Assert(CommandTable.CreateFence(_device, &fenceInfo, (AllocationCallbacks*) IntPtr.Zero, flightPtr), Result.Success,
                           "Frame fence creation");
                }
            }
        }

        private static unsafe void CreateCommandBuffers() {
            _commandBuffers = new IntPtr[_swapChainFramebuffers.Length];

            var allocInfo = new CommandBufferAllocateInfo {
                sType = StructureType.StructureTypeCommandBufferAllocateInfo,
                commandPool = _commandPool,
                level = CommandBufferLevel.CommandBufferLevelPrimary,
                commandBufferCount = (uint) _commandBuffers.Length
            };

            fixed (IntPtr* commandPtr = _commandBuffers) {
                Assert(CommandTable.AllocateCommandBuffers(_device, &allocInfo, commandPtr), Result.Success, "Command buffers allocation");
            }

            for (var i = 0; i < _commandBuffers.Length; i++) {
                var beginInfo = new CommandBufferBeginInfo {
                    sType = StructureType.StructureTypeCommandBufferBeginInfo
                };

                Assert(CommandTable.BeginCommandBuffer(_commandBuffers[i], &beginInfo), Result.Success, "Command buffer record beginning");
                {
                    var renderPassInfo = new RenderPassBeginInfo {
                        sType = StructureType.StructureTypeRenderPassBeginInfo,
                        renderPass = _renderPass,
                        framebuffer = _swapChainFramebuffers[i],
                        renderArea = new Rect2D {
                            extent = _swapChainExtent,
                            offset = new Offset2D {
                                x = 0,
                                y = 0
                            }
                        }
                    };

                    var clearValue = new ClearValue();
                    clearValue.color.float32[3] = 1.0f;
                    renderPassInfo.clearValueCount = 1;
                    renderPassInfo.clearValues = &clearValue;

                    CommandTable.CmdBeginRenderPass(_commandBuffers[i], &renderPassInfo, SubpassContents.SubpassContentsInline);
                    {
                        // Record timestamp start
                        if (_extraStatsEnabled) {
                            CommandTable.ResetQueryPool(_device, _timestampQueryPool, (uint) (i * 2), 2);
                            CommandTable.CmdWriteTimestamp(_commandBuffers[i], PipelineStageFlags.PipelineStageBottomOfPipeBit, _timestampQueryPool,
                                                           (uint) (i * 2));
                        }

                        CommandTable.CmdBindPipeline(_commandBuffers[i], PipelineBindPoint.PipelineBindPointGraphics, _graphicsPipeline);

                        CommandTable.CmdDraw(_commandBuffers[i], 3, 1, 0, 0);

                        if (_extraStatsEnabled) {
                            CommandTable.CmdWriteTimestamp(_commandBuffers[i], PipelineStageFlags.PipelineStageBottomOfPipeBit, _timestampQueryPool,
                                                           (uint) (i * 2) + 1);
                        }
                    }
                    CommandTable.CmdEndRenderPass(_commandBuffers[i]);
                }
                Assert(CommandTable.EndCommandBuffer(_commandBuffers[i]), Result.Success, "Command buffer record ending");
            }
        }

        private static unsafe void CreateCommandPool() {
            var queueFamilyIndices = FindQueueFamilies(_physicalDevice);

            var poolInfo = new CommandPoolCreateInfo {
                sType = StructureType.StructureTypeCommandPoolCreateInfo,
                queueFamilyIndex = queueFamilyIndices.GraphicsFamily.Value
            };

            IntPtr commandPool = new IntPtr();
            Assert(CommandTable.CreateCommandPool(_device, &poolInfo, (AllocationCallbacks*) IntPtr.Zero, &commandPool), Result.Success,
                   "Command pool creation");

            _commandPool = commandPool;
        }

        private static unsafe void CreateFramebuffers() {
            _swapChainFramebuffers = new IntPtr[_swapChainImageViews.Length];

            for (int i = 0; i < _swapChainFramebuffers.Length; i++) {
                var framebufferInfo = new FramebufferCreateInfo {
                    sType = StructureType.StructureTypeFramebufferCreateInfo,
                    renderPass = _renderPass,
                    attachmentCount = 1,
                    width = _swapChainExtent.width,
                    height = _swapChainExtent.height,
                    layers = 1
                };

                fixed (IntPtr* framePtr = &_swapChainFramebuffers[i], attachmentPtr = &_swapChainImageViews[i]) {
                    framebufferInfo.attachments = attachmentPtr;
                    Assert(CommandTable.CreateFramebuffer(_device, &framebufferInfo, (AllocationCallbacks*) IntPtr.Zero, framePtr), Result.Success,
                           "Framebuffer creation");
                }
            }
        }

        private static unsafe IntPtr CreateShaderModule(byte[] code) {
            var createInfo = new ShaderModuleCreateInfo {
                sType = StructureType.StructureTypeShaderModuleCreateInfo,
                codeSize = new nuint((uint) code.Length)
            };

            fixed (byte* codePtr = code) {
                createInfo.code = (uint*) codePtr;

                IntPtr shaderModule;
                Assert(CommandTable.CreateShaderModule(_device, &createInfo, (AllocationCallbacks*) IntPtr.Zero, &shaderModule), Result.Success,
                       "Shader module creation");

                return shaderModule;
            }
        }

        private static unsafe void CreateGraphicsPipeline() {
            var vertShaderCode = File.ReadAllBytes("./vert.spv");
            var fragShaderCode = File.ReadAllBytes("./frag.spv");

            var vertShaderModule = CreateShaderModule(vertShaderCode);
            var fragShaderModule = CreateShaderModule(fragShaderCode);

            var vertShaderStageInfo = new PipelineShaderStageCreateInfo {
                sType = StructureType.StructureTypePipelineShaderStageCreateInfo,
                stage = ShaderStageFlags.ShaderStageVertexBit,
                module = vertShaderModule,
                name = (byte*) Marshal.StringToHGlobalAnsi("main").ToPointer()
            };

            var fragShaderStageInfo = new PipelineShaderStageCreateInfo {
                sType = StructureType.StructureTypePipelineShaderStageCreateInfo,
                stage = ShaderStageFlags.ShaderStageFragmentBit,
                module = fragShaderModule,
                name = (byte*) Marshal.StringToHGlobalAnsi("main").ToPointer()
            };

            var shaderStages = new[] { vertShaderStageInfo, fragShaderStageInfo };

            var vertexInputInfo = new PipelineVertexInputStateCreateInfo {
                sType = StructureType.StructureTypePipelineVertexInputStateCreateInfo,
                vertexBindingDescriptionCount = 0,
                vertexAttributeDescriptionCount = 0
            };

            var inputAssembly = new PipelineInputAssemblyStateCreateInfo {
                sType = StructureType.StructureTypePipelineInputAssemblyStateCreateInfo,
                topology = PrimitiveTopology.PrimitiveTopologyTriangleList,
                primitiveRestartEnable = Vulkan.Constants.False
            };

            var viewport = new Viewport {
                x = 0.0f,
                y = 0.0f,
                width = _swapChainExtent.width,
                height = _swapChainExtent.height,
                minDepth = 0.0f,
                maxDepth = 1.0f
            };

            var scissor = new Rect2D {
                offset = new Offset2D {
                    x = 0,
                    y = 0
                },
                extent = _swapChainExtent
            };

            var viewportState = new PipelineViewportStateCreateInfo {
                sType = StructureType.StructureTypePipelineViewportStateCreateInfo,
                viewportCount = 1,
                viewports = &viewport,
                scissorCount = 1,
                scissors = &scissor
            };

            var rasterizer = new PipelineRasterizationStateCreateInfo {
                sType = StructureType.StructureTypePipelineRasterizationStateCreateInfo,
                depthClampEnable = Vulkan.Constants.False,
                rasterizerDiscardEnable = Vulkan.Constants.False,
                polygonMode = PolygonMode.PolygonModeFill,
                lineWidth = 1.0f,
                cullMode = CullModeFlags.CullModeBackBit,
                frontFace = FrontFace.FrontFaceClockwise,
                depthBiasEnable = Vulkan.Constants.False
            };

            var multisampling = new PipelineMultisampleStateCreateInfo {
                sType = StructureType.StructureTypePipelineMultisampleStateCreateInfo,
                sampleShadingEnable = Vulkan.Constants.False,
                rasterizationSamples = SampleCountFlags.SampleCount1Bit
            };

            var colorBlendAttachment = new PipelineColorBlendAttachmentState {
                colorWriteMask = ColorComponentFlags.ColorComponentRBit | ColorComponentFlags.ColorComponentGBit |
                                 ColorComponentFlags.ColorComponentBBit | ColorComponentFlags.ColorComponentABit,
                blendEnable = Vulkan.Constants.False
            };

            var colorBlending = new PipelineColorBlendStateCreateInfo {
                sType = StructureType.StructureTypePipelineColorBlendStateCreateInfo,
                logicOpEnable = Vulkan.Constants.False,
                logicOp = LogicOp.LogicOpCopy,
                attachmentCount = 1,
                attachments = &colorBlendAttachment
            };
            colorBlending.blendConstants[0] = 0.0f;
            colorBlending.blendConstants[1] = 0.0f;
            colorBlending.blendConstants[2] = 0.0f;
            colorBlending.blendConstants[3] = 0.0f;

            var pipelineLayoutInfo = new PipelineLayoutCreateInfo {
                sType = StructureType.StructureTypePipelineLayoutCreateInfo,
                setLayoutCount = 0,
                pushConstantRangeCount = 0
            };

            var pipelineLayout = new IntPtr();
            Assert(CommandTable.CreatePipelineLayout(_device, &pipelineLayoutInfo, (AllocationCallbacks*) IntPtr.Zero, &pipelineLayout),
                   Result.Success, "Pipeline layout creation");

            _pipelineLayout = pipelineLayout;

            var pipelineInfo = new GraphicsPipelineCreateInfo {
                sType = StructureType.StructureTypeGraphicsPipelineCreateInfo,
                stageCount = 2,
                vertexInputState = &vertexInputInfo,
                inputAssemblyState = &inputAssembly,
                viewportState = &viewportState,
                rasterizationState = &rasterizer,
                multisampleState = &multisampling,
                colorBlendState = &colorBlending,
                layout = _pipelineLayout,
                renderPass = _renderPass,
                subpass = 0,
                basePipelineHandle = IntPtr.Zero
            };

            fixed (PipelineShaderStageCreateInfo* shaderStagePtr = shaderStages) {
                pipelineInfo.stages = shaderStagePtr;

                var graphicsPipeline = new IntPtr();
                Assert(CommandTable.CreateGraphicsPipelines(_device, IntPtr.Zero, 1, &pipelineInfo, (AllocationCallbacks*) IntPtr.Zero,
                                                            &graphicsPipeline), Result.Success, "Graphics pipeline creation");

                _graphicsPipeline = graphicsPipeline;
            }

            CommandTable.DestroyShaderModule(_device, fragShaderModule, (AllocationCallbacks*) IntPtr.Zero);
            CommandTable.DestroyShaderModule(_device, vertShaderModule, (AllocationCallbacks*) IntPtr.Zero);
        }

        private static unsafe void CreateRenderPass() {
            var colorAttachment = new AttachmentDescription {
                format = _swapChainImageFormat,
                samples = SampleCountFlags.SampleCount1Bit,
                loadOp = AttachmentLoadOp.AttachmentLoadOpClear,
                storeOp = AttachmentStoreOp.AttachmentStoreOpStore,
                stencilLoadOp = AttachmentLoadOp.AttachmentLoadOpDontCare,
                stencilStoreOp = AttachmentStoreOp.AttachmentStoreOpDontCare,
                initialLayout = ImageLayout.ImageLayoutUndefined,
                finalLayout = ImageLayout.ImageLayoutPresentSrcKhr
            };

            var colorAttachmentRef = new AttachmentReference {
                attachment = 0,
                layout = ImageLayout.ImageLayoutColorAttachmentOptimal
            };

            var subpass = new SubpassDescription {
                pipelineBindPoint = PipelineBindPoint.PipelineBindPointGraphics,
                colorAttachmentCount = 1,
                colorAttachments = &colorAttachmentRef
            };

            var dependency = new SubpassDependency {
                srcSubpass = Vulkan.Constants.SubpassExternal,
                dstSubpass = 0,
                srcStageMask = PipelineStageFlags.PipelineStageColorAttachmentOutputBit,
                srcAccessMask = 0,
                dstStageMask = PipelineStageFlags.PipelineStageColorAttachmentOutputBit,
                dstAccessMask = AccessFlags.AccessColorAttachmentWriteBit
            };

            var renderPassInfo = new RenderPassCreateInfo {
                sType = StructureType.StructureTypeRenderPassCreateInfo,
                attachmentCount = 1,
                attachments = &colorAttachment,
                subpassCount = 1,
                subpasses = &subpass,
                dependencyCount = 1,
                dependencies = &dependency
            };

            var renderPass = new IntPtr();
            Assert(CommandTable.CreateRenderPass(_device, &renderPassInfo, (AllocationCallbacks*) IntPtr.Zero, &renderPass), Result.Success,
                   "Render pass creation");

            _renderPass = renderPass;
        }

        private static unsafe void CreateImageViews() {
            _swapChainImageViews = new IntPtr[_swapChainImages.Length];

            for (var i = 0; i < _swapChainImages.Length; i++) {
                var createInfo = new ImageViewCreateInfo {
                    sType = StructureType.StructureTypeImageViewCreateInfo,
                    image = _swapChainImages[i],
                    viewType = ImageViewType.ImageViewType2d,
                    format = _swapChainImageFormat,
                    components = new ComponentMapping {
                        r = ComponentSwizzle.ComponentSwizzleIdentity,
                        g = ComponentSwizzle.ComponentSwizzleIdentity,
                        b = ComponentSwizzle.ComponentSwizzleIdentity,
                        a = ComponentSwizzle.ComponentSwizzleIdentity
                    },
                    subresourceRange = new ImageSubresourceRange {
                        aspectMask = ImageAspectFlags.ImageAspectColorBit,
                        baseMipLevel = 0,
                        levelCount = 1,
                        baseArrayLayer = 0,
                        layerCount = 1
                    }
                };

                fixed (IntPtr* imageViewPtr = &_swapChainImageViews[i]) {
                    Assert(CommandTable.CreateImageView(_device, &createInfo, (AllocationCallbacks*) IntPtr.Zero, imageViewPtr), Result.Success,
                           "Image views creation");
                }
            }
        }

        private static unsafe void CreateSwapChain() {
            var swapChainSupport = QuerySwapChainSupport(_physicalDevice);

            var surfaceFormat = ChooseSwapSurfaceFormat(swapChainSupport.Formats);
            var presentMode = ChooseSwapPresentMode(swapChainSupport.PresentModes);
            var extent = ChooseSwapExtent(swapChainSupport.Capabilities);

            var imageCount = swapChainSupport.Capabilities.minImageCount + 1;
            if (swapChainSupport.Capabilities.maxImageCount > 0 && imageCount > swapChainSupport.Capabilities.maxImageCount) {
                imageCount = swapChainSupport.Capabilities.maxImageCount;
            }

            var createInfo = new SwapchainCreateInfoKHR {
                sType = StructureType.StructureTypeSwapchainCreateInfoKhr,
                surface = _surface,
                minImageCount = imageCount,
                imageFormat = surfaceFormat.format,
                imageColorSpace = surfaceFormat.colorSpace,
                imageExtent = extent,
                imageArrayLayers = 1,
                imageUsage = ImageUsageFlags.ImageUsageColorAttachmentBit
            };

            var indices = FindQueueFamilies(_physicalDevice);
            var queueFamilyIndices = new[] { indices.GraphicsFamily.Value, indices.PresentFamily.Value };

            fixed (uint* queueFamilyPtr = queueFamilyIndices) {
                if (indices.GraphicsFamily != indices.PresentFamily) {
                    createInfo.imageSharingMode = SharingMode.SharingModeConcurrent;
                    createInfo.queueFamilyIndexCount = 2;
                    createInfo.queueFamilyIndices = queueFamilyPtr;
                } else {
                    createInfo.imageSharingMode = SharingMode.SharingModeExclusive;
                }

                createInfo.preTransform = swapChainSupport.Capabilities.currentTransform;
                createInfo.compositeAlpha = CompositeAlphaFlagsKHR.CompositeAlphaOpaqueBitKhr;
                createInfo.presentMode = presentMode;
                createInfo.clipped = Vulkan.Constants.True;
                createInfo.oldSwapchain = IntPtr.Zero;

                var swapChain = new IntPtr();
                Assert(CommandTable.CreateSwapchainKHR(_device, &createInfo, (AllocationCallbacks*) IntPtr.Zero, &swapChain), Result.Success,
                       "Swapchain creation");

                _swapchain = swapChain;
            }

            CommandTable.GetSwapchainImagesKHR(_device, _swapchain, &imageCount, (IntPtr*) IntPtr.Zero);
            _swapChainImages = new IntPtr[imageCount];
            fixed (IntPtr* imagePtr = _swapChainImages) {
                CommandTable.GetSwapchainImagesKHR(_device, _swapchain, &imageCount, imagePtr);
            }

            _swapChainImageFormat = surfaceFormat.format;
            _swapChainExtent = extent;

            Console.WriteLine($"Create a swapchain with {imageCount} frames and {presentMode} mode");
        }

        private static SurfaceFormatKHR ChooseSwapSurfaceFormat(IReadOnlyList<SurfaceFormatKHR> availableFormats) {
            foreach (var availableFormat in availableFormats) {
                if (availableFormat.format == Format.FormatB8g8r8a8Srgb && availableFormat.colorSpace == ColorSpaceKHR.ColorspaceSrgbNonlinearKhr) {
                    return availableFormat;
                }
            }

            return availableFormats[0];
        }

        private static PresentModeKHR ChooseSwapPresentMode(IEnumerable<PresentModeKHR> availablePresentModes) {
            if (!_vsyncEnabled) {
                return PresentModeKHR.PresentModeImmediateKhr;
            }

            foreach (var availablePresentMode in availablePresentModes) {
                if (availablePresentMode == PresentModeKHR.PresentModeMailboxKhr) {
                    return availablePresentMode;
                }
            }

            return PresentModeKHR.PresentModeFifoKhr;
        }

        private static Extent2D ChooseSwapExtent(SurfaceCapabilitiesKHR capabilities) {
            if (capabilities.currentExtent.width != uint.MaxValue) {
                return capabilities.currentExtent;
            } else {
                var actualExtent = new Extent2D {
                    width = WindowWidth,
                    height = WindowHeight
                };

                actualExtent.width = Math.Max(capabilities.minImageExtent.width, Math.Min(capabilities.maxImageExtent.width, actualExtent.width));
                actualExtent.height = Math.Max(capabilities.minImageExtent.height, Math.Min(capabilities.maxImageExtent.height, actualExtent.height));

                return actualExtent;
            }
        }

        private static unsafe SwapChainSupportDetails QuerySwapChainSupport(IntPtr device) {
            var details = new SwapChainSupportDetails();

            CommandTable.GetPhysicalDeviceSurfaceCapabilitiesKHR(device, _surface, &details.Capabilities);

            uint formatCount;
            CommandTable.GetPhysicalDeviceSurfaceFormatsKHR(device, _surface, &formatCount, (SurfaceFormatKHR*) IntPtr.Zero);

            if (formatCount != 0) {
                details.Formats = new SurfaceFormatKHR[formatCount];
                fixed (SurfaceFormatKHR* formatPtr = details.Formats) {
                    CommandTable.GetPhysicalDeviceSurfaceFormatsKHR(device, _surface, &formatCount, formatPtr);
                }
            }

            uint presentModeCount;
            CommandTable.GetPhysicalDeviceSurfacePresentModesKHR(device, _surface, &presentModeCount, (PresentModeKHR*) IntPtr.Zero);

            if (presentModeCount != 0) {
                details.PresentModes = new PresentModeKHR[presentModeCount];
                fixed (PresentModeKHR* modePtr = details.PresentModes) {
                    CommandTable.GetPhysicalDeviceSurfacePresentModesKHR(device, _surface, &presentModeCount, modePtr);
                }
            }

            return details;
        }

        private static unsafe void CreateLogicalDevice() {
            var indices = FindQueueFamilies(_physicalDevice);

            var uniqueQueueFamilies = new[] { indices.GraphicsFamily.Value, indices.PresentFamily.Value };
            var queueCreateInfos = new DeviceQueueCreateInfo[uniqueQueueFamilies.Length];

            var queuePriority = 1.0f;
            for (int i = 0; i < uniqueQueueFamilies.Length; i++) {
                queueCreateInfos[i] = new DeviceQueueCreateInfo {
                    sType = StructureType.StructureTypeDeviceQueueCreateInfo,
                    queueFamilyIndex = uniqueQueueFamilies[i],
                    queueCount = 1,
                    queuePriorities = &queuePriority
                };
            }

            var deviceFeatures = new PhysicalDeviceFeatures();
            var deviceExtensions = new[] { (byte*) Marshal.StringToHGlobalAnsi("VK_KHR_swapchain").ToPointer() };

            var createInfo = new DeviceCreateInfo {
                sType = StructureType.StructureTypeDeviceCreateInfo,
                queueCreateInfoCount = (uint) queueCreateInfos.Length,
                enabledFeatures = &deviceFeatures,
                enabledExtensionCount = (uint) deviceExtensions.Length,
                enabledLayerCount = 0
            };

            fixed (void* extensionPtr = deviceExtensions, infoPtr = queueCreateInfos) {
                createInfo.queueCreateInfos = (DeviceQueueCreateInfo*) infoPtr;
                createInfo.enabledExtensionNames = (byte**) extensionPtr;

                var device = new IntPtr();
                Assert(CommandTable.CreateDevice(_physicalDevice, &createInfo, (AllocationCallbacks*) IntPtr.Zero, &device), Result.Success,
                       "Logical device creation");

                _device = device;
            }

            // Load devices functions
            Functions.LoadDevice(_device);

            var queues = new IntPtr[2];
            fixed (IntPtr* graphicsQueue = queues, presentQueue = &queues[1]) {
                CommandTable.GetDeviceQueue(_device, indices.GraphicsFamily.Value, 0, graphicsQueue);
                CommandTable.GetDeviceQueue(_device, indices.PresentFamily.Value, 0, presentQueue);
            }

            _graphicsQueue = queues[0];
            _presentQueue = queues[1];
        }

        private static unsafe QueueFamilyIndices FindQueueFamilies(IntPtr device) {
            var indices = new QueueFamilyIndices();

            uint queueFamilyCount = 0;
            CommandTable.GetPhysicalDeviceQueueFamilyProperties(device, &queueFamilyCount, (QueueFamilyProperties*) IntPtr.Zero.ToPointer());

            var queueFamilies = new QueueFamilyProperties[queueFamilyCount];
            fixed (QueueFamilyProperties* queueFamiliesPtr = queueFamilies) {
                CommandTable.GetPhysicalDeviceQueueFamilyProperties(device, &queueFamilyCount, queueFamiliesPtr);
            }

            uint i = 0;
            foreach (var queueFamily in queueFamilies) {
                if ((queueFamily.queueFlags & QueueFlags.QueueGraphicsBit) == QueueFlags.QueueGraphicsBit) {
                    indices.GraphicsFamily = i;
                }

                uint presentSupport = 0;
                CommandTable.GetPhysicalDeviceSurfaceSupportKHR(device, i, _surface, &presentSupport);

                if (presentSupport == Vulkan.Constants.True) {
                    indices.PresentFamily = i;
                }

                if (indices.IsComplete()) {
                    break;
                }

                i++;
            }

            return indices;
        }

        private static unsafe void PickPhysicalDevice() {
            uint deviceCount = 0;
            CommandTable.EnumeratePhysicalDevices(_instance, &deviceCount, (IntPtr*) IntPtr.Zero);

            if (deviceCount == 0) {
                throw new Exception("failed to find GPUs with Vulkan support!");
            }

            var devices = new IntPtr[deviceCount];
            fixed (IntPtr* devicesPtr = devices) {
                CommandTable.EnumeratePhysicalDevices(_instance, &deviceCount, devicesPtr);
            }

            if (devices.Length == 0) {
                throw new Exception("failed to find a suitable GPU!");
            }

            _physicalDevice = devices[0];

            var properties = new PhysicalDeviceProperties();
            CommandTable.GetPhysicalDeviceProperties(_physicalDevice, &properties);

            Console.WriteLine($"Select device: {ToString(properties.deviceName)} ({properties.deviceType})");
            _gpuPeriod = properties.limits.timestampPeriod;
        }

        private static unsafe string ToString(byte* str) {
            var bytes = Enumerable.Range(0, Vulkan.Constants.MaxPhysicalDeviceNameSize).Select(index => str[index]).Where(c => c != 0).ToArray();

            return Encoding.ASCII.GetString(bytes);
        }

        private static void CreateSurface() {
            Assert((Result) GLFW.Vulkan.CreateWindowSurface(_instance, _window, IntPtr.Zero, out _surface), Result.Success,
                   "Window surface creation");
        }

        private static unsafe void CreateInstance() {
            var appInfo = new ApplicationInfo {
                sType = StructureType.StructureTypeApplicationInfo,
                applicationVersion = Utilities.MakeVersion(1, 0, 0),
                engineVersion = Utilities.MakeVersion(1, 0, 0),
                apiVersion = Utilities.MakeVersion(1, 0, 0),
                applicationName = (byte*) IntPtr.Zero.ToPointer(),
                engineName = (byte*) IntPtr.Zero.ToPointer()
            };

            var createInfo = new InstanceCreateInfo {
                sType = StructureType.StructureTypeInstanceCreateInfo,
                applicationInfo = &appInfo
            };

            var extensions = GLFW.Vulkan.GetRequiredInstanceExtensions().Select(Marshal.StringToHGlobalAnsi).ToArray();
            fixed (void* ptr = extensions) {
                createInfo.enabledExtensionCount = 2;
                createInfo.enabledExtensionNames = (byte**) ptr;
                createInfo.enabledLayerCount = 0;
                createInfo.next = IntPtr.Zero.ToPointer();

                var instance = IntPtr.Zero;
                Assert(CommandTable.CreateInstance(&createInfo, (AllocationCallbacks*) IntPtr.Zero.ToPointer(), &instance), Result.Success,
                       "Instance creation");

                _instance = instance;
            }
        }

        private static void MainLoop() {
            while (!Glfw.WindowShouldClose(_window)) {
                Glfw.PollEvents();
                DrawFrame();
            }

            CommandTable.DeviceWaitIdle(_device);
        }

        private static unsafe void DrawFrame() {
            fixed (IntPtr* fencePtr = &_inFlightFences[_currentFrame]) {
                CommandTable.WaitForFences(_device, 1, fencePtr, Vulkan.Constants.True, ulong.MaxValue);
            }

            uint imageIndex;
            CommandTable.AcquireNextImageKHR(_device, _swapchain, ulong.MaxValue, _imageAvailableSemaphores[_currentFrame], IntPtr.Zero, &imageIndex);

            if (_imagesInFlight[imageIndex] != IntPtr.Zero) {
                fixed (IntPtr* fencePtr = &_imagesInFlight[imageIndex]) {
                    CommandTable.WaitForFences(_device, 1, fencePtr, Vulkan.Constants.True, ulong.MaxValue);
                }
            }

            _imagesInFlight[imageIndex] = _inFlightFences[_currentFrame];

            var submitInfo = new SubmitInfo {
                sType = StructureType.StructureTypeSubmitInfo
            };

            fixed (IntPtr* fencePtr = &_inFlightFences[_currentFrame]) {
                CommandTable.ResetFences(_device, 1, fencePtr);
            }

            var waitStages = new[] { PipelineStageFlags.PipelineStageColorAttachmentOutputBit };
            submitInfo.waitSemaphoreCount = 1;
            fixed (void* semaphorePtr = &_imageAvailableSemaphores[_currentFrame], stagePtr = waitStages, commandPtr =
                &_commandBuffers[imageIndex], renderSemaphorePtr = &_renderFinishedSemaphores[_currentFrame]) {
                submitInfo.waitSemaphores = (IntPtr*) semaphorePtr;
                submitInfo.waitDstStageMask = (PipelineStageFlags*) stagePtr;
                submitInfo.commandBufferCount = 1;
                submitInfo.commandBuffers = (IntPtr*) commandPtr;
                submitInfo.signalSemaphoreCount = 1;
                submitInfo.signalSemaphores = (IntPtr*) renderSemaphorePtr;

                Assert(CommandTable.QueueSubmit(_graphicsQueue, 1, &submitInfo, _inFlightFences[_currentFrame]), Result.Success,
                       "Draw command submission");
            }

            var presentInfo = new PresentInfoKHR {
                sType = StructureType.StructureTypePresentInfoKhr,
                waitSemaphoreCount = 1,
                swapchainCount = 1,
                imageIndices = &imageIndex
            };
            fixed (IntPtr* swapchainPtr = &_swapchain, semaphorePtr = &_renderFinishedSemaphores[_currentFrame]) {
                presentInfo.swapchains = swapchainPtr;
                presentInfo.waitSemaphores = semaphorePtr;

                CommandTable.QueuePresentKHR(_presentQueue, &presentInfo);
            }

            // Monitoring
            if (_stopwatch == null || _stopwatch.Elapsed.Seconds > 0) {
                if (_stopwatch != null) {
                    if (_extraStatsEnabled) {
                        var results = new ulong[2];
                        fixed (void* ptr = results) {
                            Assert(CommandTable.GetQueryPoolResults(_device, _timestampQueryPool, (uint) (_currentFrame * 2), 2, 2 * sizeof(ulong), ptr, sizeof(ulong),
                                                                    QueryResultFlags.QueryResult64Bit | QueryResultFlags.QueryResultWaitBit),
                                   Result.Success, "Query pool results gathering");
                        }

                        var frameTime = _stopwatch.Elapsed.TotalMilliseconds / _frameCount;
                        Glfw.SetWindowTitle(
                            _window,
                            $"Volk Example - VSync ({_vsyncEnabled}) - Fps ({1000 / frameTime:0}) - CPU/GPU Frame time ({frameTime:0.####} ms/{(results[1] - results[0]) * _gpuPeriod * 0.000001:0.####} ms)");
                    } else {
                        Glfw.SetWindowTitle(_window, $"Volk Example - VSync ({_vsyncEnabled})");
                    }
                }

                _stopwatch = new Stopwatch();
                _frameCount = 0;
                _stopwatch.Start();
            }
            
            _currentFrame = (_currentFrame + 1) % _swapChainImages.Length;
            _frameCount += 1;
        }

        private static void InitWindow() {
            Glfw.Init();

            Glfw.WindowHint(Hint.ClientApi, ClientApi.None);
            Glfw.WindowHint(Hint.Resizable, Constants.False);

            _window = Glfw.CreateWindow(WindowWidth, WindowHeight, "Volk Example", Monitor.None, GLFW.Window.None);
            Console.WriteLine($"Init a {WindowWidth}x{WindowHeight} window");
        }

        private static void Assert(Result actual, Result expected, string message) {
            if (actual != expected) {
                throw new Exception($"Expected {expected} and got {actual} for: {message}");
            }
        }
    }
}