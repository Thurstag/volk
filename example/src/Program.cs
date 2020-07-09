// This code is an adaptation of the example provided by
// https://vulkan-tutorial.com/ (https://vulkan-tutorial.com/code/15_hello_triangle.cpp)

using System;
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
    class Program {
        const int MaxFramesInFlight = 2;

        const int WindowWidth = 800;
        const int WindowHeight = 600;

        static Window _window;
        static IntPtr _instance;
        static IntPtr _physicalDevice;
        static IntPtr _device;
        static IntPtr _surface;
        static IntPtr _renderPass;
        static IntPtr _pipelineLayout;
        static IntPtr _graphicsPipeline;
        static IntPtr _commandPool;
        static IntPtr _graphicsQueue, _presentQueue;

        static IntPtr[] _swapChainImageViews;
        static IntPtr[] _swapChainImages;
        static Format _swapChainImageFormat;
        static Extent2D _swapChainExtent;
        static IntPtr _swapchain;

        static IntPtr[] _swapChainFramebuffers;
        static IntPtr[] _commandBuffers;

        static IntPtr[] _imageAvailableSemaphores;
        static IntPtr[] _renderFinishedSemaphores;
        static IntPtr[] _inFlightFences;
        static IntPtr[] _imagesInFlight;

        static int _currentFrame;
        static ulong _frameCount;
        static Stopwatch _stopwatch;

        struct QueueFamilyIndices {
            public uint? GraphicsFamily;
            public uint? PresentFamily;

            public bool IsComplete() {
                return GraphicsFamily != null && PresentFamily != null;
            }
        }

        struct SwapChainSupportDetails {
            public SurfaceCapabilitiesKHR Capabilities;
            public SurfaceFormatKHR[] Formats;
            public PresentModeKHR[] PresentModes;
        }

        static void Main() {
            // Initialize volk
            Functions.Initialize();

            InitWindow();
            InitVulkan();
            MainLoop();
            Cleanup();
        }

        private static unsafe void Cleanup() {
            for (int i = 0; i < MaxFramesInFlight; i++) {
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

            CommandTable.DestroySwapchainKHR(_device, _swapchain, (AllocationCallbacks*) IntPtr.Zero);
            CommandTable.DestroyDevice(_device, (AllocationCallbacks*) IntPtr.Zero);

            CommandTable.DestroySurfaceKHR(_instance, _surface, (AllocationCallbacks*) IntPtr.Zero);
            CommandTable.DestroyInstance(_instance, (AllocationCallbacks*) IntPtr.Zero);

            Glfw.DestroyWindow(_window);
            Glfw.Terminate();

            Functions.Destroy();
        }

        static void InitVulkan() {
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
            CreateCommandBuffers();
            CreateSyncObjects();
        }

        private static unsafe void CreateSyncObjects() {
            _imageAvailableSemaphores = new IntPtr[MaxFramesInFlight];
            _renderFinishedSemaphores = new IntPtr[MaxFramesInFlight];
            _inFlightFences = new IntPtr[MaxFramesInFlight];
            _imagesInFlight = Enumerable.Range(0, _swapChainImages.Length).Select(i => IntPtr.Zero).ToArray();

            var semaphoreInfo = new SemaphoreCreateInfo {
                sType = StructureType.StructureTypeSemaphoreCreateInfo
            };

            var fenceInfo = new FenceCreateInfo {
                sType = StructureType.StructureTypeFenceCreateInfo,
                flags = FenceCreateFlags.FenceCreateSignaledBit
            };

            for (int i = 0; i < MaxFramesInFlight; i++) {
                fixed (IntPtr* availablePtr = &_imageAvailableSemaphores[i]) {
                    if (CommandTable.CreateSemaphore(_device, &semaphoreInfo, (AllocationCallbacks*) IntPtr.Zero, availablePtr) != Result.Success) {
                        throw new Exception("failed to create synchronization objects for a frame!");
                    }
                }

                fixed (IntPtr* renderPtr = &_renderFinishedSemaphores[i]) {
                    if (CommandTable.CreateSemaphore(_device, &semaphoreInfo, (AllocationCallbacks*) IntPtr.Zero, renderPtr) != Result.Success) {
                        throw new Exception("failed to create synchronization objects for a frame!");
                    }
                }

                fixed (IntPtr* flightPtr = &_inFlightFences[i]) {
                    if (CommandTable.CreateFence(_device, &fenceInfo, (AllocationCallbacks*) IntPtr.Zero, flightPtr) != Result.Success) {
                        throw new Exception("failed to create synchronization objects for a frame!");
                    }
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

            fixed (IntPtr* commandPtr = &_commandBuffers[0]) {
                if (CommandTable.AllocateCommandBuffers(_device, &allocInfo, commandPtr) != Result.Success) {
                    throw new Exception("failed to allocate command buffers!");
                }
            }

            for (int i = 0; i < _commandBuffers.Length; i++) {
                var beginInfo = new CommandBufferBeginInfo {
                    sType = StructureType.StructureTypeCommandBufferBeginInfo
                };

                if (CommandTable.BeginCommandBuffer(_commandBuffers[i], &beginInfo) != Result.Success) {
                    throw new Exception("failed to begin recording command buffer!");
                }

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

                CommandTable.CmdBindPipeline(_commandBuffers[i], PipelineBindPoint.PipelineBindPointGraphics, _graphicsPipeline);

                CommandTable.CmdDraw(_commandBuffers[i], 3, 1, 0, 0);

                CommandTable.CmdEndRenderPass(_commandBuffers[i]);

                if (CommandTable.EndCommandBuffer(_commandBuffers[i]) != Result.Success) {
                    throw new Exception("failed to record command buffer!");
                }
            }
        }

        private static unsafe void CreateCommandPool() {
            QueueFamilyIndices queueFamilyIndices = FindQueueFamilies(_physicalDevice);

            var poolInfo = new CommandPoolCreateInfo {
                sType = StructureType.StructureTypeCommandPoolCreateInfo,
                queueFamilyIndex = queueFamilyIndices.GraphicsFamily.Value
            };

            IntPtr commandPool = new IntPtr();
            if (CommandTable.CreateCommandPool(_device, &poolInfo, (AllocationCallbacks*) IntPtr.Zero, &commandPool) != Result.Success) {
                throw new Exception("failed to create command pool!");
            }

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

                    if (CommandTable.CreateFramebuffer(_device, &framebufferInfo, (AllocationCallbacks*) IntPtr.Zero, framePtr) != Result.Success) {
                        throw new Exception("failed to create framebuffer!");
                    }
                }
            }
        }

        static unsafe IntPtr CreateShaderModule(byte[] code) {
            var createInfo = new ShaderModuleCreateInfo {
                sType = StructureType.StructureTypeShaderModuleCreateInfo,
                codeSize = new nuint((uint) code.Length)
            };

            fixed (byte* codePtr = &code[0]) {
                createInfo.code = (uint*) codePtr;

                IntPtr shaderModule;
                if (CommandTable.CreateShaderModule(_device, &createInfo, (AllocationCallbacks*) IntPtr.Zero, &shaderModule) != Result.Success) {
                    throw new Exception("failed to create shader module!");
                }

                return shaderModule;
            }
        }

        private static unsafe void CreateGraphicsPipeline() {
            var vertShaderCode = File.ReadAllBytes("./vert.spv");
            var fragShaderCode = File.ReadAllBytes("./frag.spv");

            IntPtr vertShaderModule = CreateShaderModule(vertShaderCode);
            IntPtr fragShaderModule = CreateShaderModule(fragShaderCode);

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

            var shaderStages = new[] {vertShaderStageInfo, fragShaderStageInfo};

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

            IntPtr pipelineLayout = new IntPtr();
            if (CommandTable.CreatePipelineLayout(_device, &pipelineLayoutInfo, (AllocationCallbacks*) IntPtr.Zero, &pipelineLayout) !=
                Result.Success) {
                throw new Exception("failed to create pipeline layout!");
            }

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

            fixed (PipelineShaderStageCreateInfo* shaderStagePtr = &shaderStages[0]) {
                pipelineInfo.stages = shaderStagePtr;

                IntPtr graphicsPipeline = new IntPtr();
                if (CommandTable.CreateGraphicsPipelines(_device, IntPtr.Zero, 1, &pipelineInfo, (AllocationCallbacks*) IntPtr.Zero,
                        &graphicsPipeline) !=
                    Result.Success) {
                    throw new Exception("failed to create graphics pipeline!");
                }

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

            IntPtr renderPass = new IntPtr();
            if (CommandTable.CreateRenderPass(_device, &renderPassInfo, (AllocationCallbacks*) IntPtr.Zero, &renderPass) != Result.Success) {
                throw new Exception("failed to create render pass!");
            }

            _renderPass = renderPass;
        }

        private static unsafe void CreateImageViews() {
            _swapChainImageViews = new IntPtr[_swapChainImages.Length];

            for (int i = 0; i < _swapChainImages.Length; i++) {
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
                    if (CommandTable.CreateImageView(_device, &createInfo, (AllocationCallbacks*) IntPtr.Zero, imageViewPtr) != Result.Success) {
                        throw new Exception("failed to create image views!");
                    }
                }
            }
        }

        private static unsafe void CreateSwapChain() {
            SwapChainSupportDetails swapChainSupport = QuerySwapChainSupport(_physicalDevice);

            SurfaceFormatKHR surfaceFormat = ChooseSwapSurfaceFormat(swapChainSupport.Formats);
            PresentModeKHR presentMode = ChooseSwapPresentMode(swapChainSupport.PresentModes);
            Extent2D extent = ChooseSwapExtent(swapChainSupport.Capabilities);

            uint imageCount = swapChainSupport.Capabilities.minImageCount + 1;
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

            QueueFamilyIndices indices = FindQueueFamilies(_physicalDevice);
            var queueFamilyIndices = new[] {indices.GraphicsFamily.Value, indices.PresentFamily.Value};

            fixed (uint* queueFamilyPtr = &queueFamilyIndices[0]) {
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

                IntPtr swapChain = new IntPtr();
                if (CommandTable.CreateSwapchainKHR(_device, &createInfo, (AllocationCallbacks*) IntPtr.Zero, &swapChain) != Result.Success) {
                    throw new Exception("failed to create swap chain!");
                }

                _swapchain = swapChain;
            }

            CommandTable.GetSwapchainImagesKHR(_device, _swapchain, &imageCount, (IntPtr*) IntPtr.Zero);
            _swapChainImages = new IntPtr[imageCount];
            fixed (IntPtr* imagePtr = &_swapChainImages[0]) {
                CommandTable.GetSwapchainImagesKHR(_device, _swapchain, &imageCount, imagePtr);
            }

            _swapChainImageFormat = surfaceFormat.format;
            _swapChainExtent = extent;

            Console.WriteLine($"Create a swapchain with {imageCount} frames and {presentMode} mode");
        }

        static SurfaceFormatKHR ChooseSwapSurfaceFormat(SurfaceFormatKHR[] availableFormats) {
            foreach (var availableFormat in availableFormats) {
                if (availableFormat.format == Format.FormatB8g8r8a8Srgb && availableFormat.colorSpace == ColorSpaceKHR.ColorspaceSrgbNonlinearKhr) {
                    return availableFormat;
                }
            }

            return availableFormats[0];
        }

        static PresentModeKHR ChooseSwapPresentMode(PresentModeKHR[] availablePresentModes) {
            foreach (var availablePresentMode in availablePresentModes) {
                if (availablePresentMode == PresentModeKHR.PresentModeMailboxKhr) {
                    return availablePresentMode;
                }
            }

            return PresentModeKHR.PresentModeFifoKhr;
        }

        static Extent2D ChooseSwapExtent(SurfaceCapabilitiesKHR capabilities) {
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

        static unsafe SwapChainSupportDetails QuerySwapChainSupport(IntPtr device) {
            var details = new SwapChainSupportDetails();

            CommandTable.GetPhysicalDeviceSurfaceCapabilitiesKHR(device, _surface, &details.Capabilities);

            uint formatCount;
            CommandTable.GetPhysicalDeviceSurfaceFormatsKHR(device, _surface, &formatCount, (SurfaceFormatKHR*) IntPtr.Zero);

            if (formatCount != 0) {
                details.Formats = new SurfaceFormatKHR[formatCount];
                fixed (SurfaceFormatKHR* formatPtr = &details.Formats[0]) {
                    CommandTable.GetPhysicalDeviceSurfaceFormatsKHR(device, _surface, &formatCount, formatPtr);
                }
            }

            uint presentModeCount;
            CommandTable.GetPhysicalDeviceSurfacePresentModesKHR(device, _surface, &presentModeCount, (PresentModeKHR*) IntPtr.Zero);

            if (presentModeCount != 0) {
                details.PresentModes = new PresentModeKHR[presentModeCount];
                fixed (PresentModeKHR* modePtr = &details.PresentModes[0]) {
                    CommandTable.GetPhysicalDeviceSurfacePresentModesKHR(device, _surface, &presentModeCount, modePtr);
                }
            }

            return details;
        }

        private static unsafe void CreateLogicalDevice() {
            QueueFamilyIndices indices = FindQueueFamilies(_physicalDevice);

            var uniqueQueueFamilies = new[] {indices.GraphicsFamily.Value, indices.PresentFamily.Value};
            var queueCreateInfos = new DeviceQueueCreateInfo[uniqueQueueFamilies.Length];

            float queuePriority = 1.0f;
            for (int i = 0; i < uniqueQueueFamilies.Length; i++) {
                queueCreateInfos[i] = new DeviceQueueCreateInfo {
                    sType = StructureType.StructureTypeDeviceQueueCreateInfo,
                    queueFamilyIndex = uniqueQueueFamilies[i],
                    queueCount = 1,
                    queuePriorities = &queuePriority
                };
            }

            var deviceFeatures = new PhysicalDeviceFeatures();
            var deviceExtensions = new[] {(byte*) Marshal.StringToHGlobalAnsi("VK_KHR_swapchain").ToPointer()};

            var createInfo = new DeviceCreateInfo {
                sType = StructureType.StructureTypeDeviceCreateInfo,
                queueCreateInfoCount = (uint) queueCreateInfos.Length,
                enabledFeatures = &deviceFeatures,
                enabledExtensionCount = (uint) deviceExtensions.Length,
                enabledLayerCount = 0
            };

            fixed (void* extensionPtr = &deviceExtensions[0], infoPtr = &queueCreateInfos[0]) {
                createInfo.queueCreateInfos = (DeviceQueueCreateInfo*) infoPtr;
                createInfo.enabledExtensionNames = (byte**) extensionPtr;

                IntPtr device = new IntPtr();
                if (CommandTable.CreateDevice(_physicalDevice, &createInfo, (AllocationCallbacks*) IntPtr.Zero, &device) != Result.Success) {
                    throw new Exception("failed to create logical device!");
                }

                _device = device;
            }

            // Load devices functions
            Functions.LoadDevice(_device);

            var queues = new IntPtr[2];
            fixed (IntPtr* graphicsQueue = &queues[0], presentQueue = &queues[1]) {
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
            fixed (QueueFamilyProperties* queueFamiliesPtr = &queueFamilies[0]) {
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
            fixed (IntPtr* devicesPtr = &devices[0]) {
                CommandTable.EnumeratePhysicalDevices(_instance, &deviceCount, devicesPtr);
            }

            if (devices.Length == 0) {
                throw new Exception("failed to find a suitable GPU!");
            }

            _physicalDevice = devices[0];

            var properties = new PhysicalDeviceProperties();
            CommandTable.GetPhysicalDeviceProperties(_physicalDevice, &properties);

            Console.WriteLine($"Select device: {ToString(properties.deviceName)} ({properties.deviceType})");
        }

        private static unsafe string ToString(byte* str) {
            var bytes = Enumerable.Range(0, Vulkan.Constants.MaxPhysicalDeviceNameSize).Select(index => str[index]).Where(c => c != 0).ToArray();

            return Encoding.ASCII.GetString(bytes);
        }

        private static void CreateSurface() {
            if (GLFW.Vulkan.CreateWindowSurface(_instance, _window, IntPtr.Zero, out _surface) != (int) Result.Success) {
                throw new Exception("failed to create window surface");
            }
        }

        static unsafe void CreateInstance() {
            ApplicationInfo appInfo = new ApplicationInfo {
                sType = StructureType.StructureTypeApplicationInfo,
                applicationVersion = Utilities.MakeVersion(1, 0, 0),
                engineVersion = Utilities.MakeVersion(1, 0, 0),
                apiVersion = Utilities.MakeVersion(1, 0, 0),
                applicationName = (byte*) IntPtr.Zero.ToPointer(),
                engineName = (byte*) IntPtr.Zero.ToPointer()
            };

            InstanceCreateInfo createInfo = new InstanceCreateInfo {
                sType = StructureType.StructureTypeInstanceCreateInfo,
                applicationInfo = &appInfo
            };

            fixed (void* extensions =
                &(new[] {Marshal.StringToHGlobalAnsi("VK_KHR_win32_surface"), Marshal.StringToHGlobalAnsi("VK_KHR_surface")})[0]) {
                // TODO: Use GLFW.Vulkan.GetRequiredInstanceExtensions(); when it's fixed
                createInfo.enabledExtensionCount = 2;
                createInfo.enabledExtensionNames = (byte**) extensions;
                createInfo.enabledLayerCount = 0;
                createInfo.next = IntPtr.Zero.ToPointer();

                IntPtr instance = IntPtr.Zero;
                if (CommandTable.CreateInstance(&createInfo, (AllocationCallbacks*) IntPtr.Zero.ToPointer(), &instance) != Result.Success) {
                    throw new Exception("failed to create instance!");
                }

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

            var waitStages = new[] {PipelineStageFlags.PipelineStageColorAttachmentOutputBit};
            submitInfo.waitSemaphoreCount = 1;
            fixed (void* semaphorePtr = &_imageAvailableSemaphores[_currentFrame], stagePtr = &waitStages[0], commandPtr =
                &_commandBuffers[imageIndex], renderSemaphorePtr = &_renderFinishedSemaphores[_currentFrame]) {
                submitInfo.waitSemaphores = (IntPtr*) semaphorePtr;
                submitInfo.waitDstStageMask = (PipelineStageFlags*) stagePtr;
                submitInfo.commandBufferCount = 1;
                submitInfo.commandBuffers = (IntPtr*) commandPtr;
                submitInfo.signalSemaphoreCount = 1;
                submitInfo.signalSemaphores = (IntPtr*) renderSemaphorePtr;

                if (CommandTable.QueueSubmit(_graphicsQueue, 1, &submitInfo, _inFlightFences[_currentFrame]) != Result.Success) {
                    throw new Exception("failed to submit draw command buffer!");
                }
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

            _currentFrame = (_currentFrame + 1) % MaxFramesInFlight;
            _frameCount += 1;

            // Frame monitoring
            if (_stopwatch == null || _stopwatch.Elapsed.Seconds > 1) {
                Glfw.SetWindowTitle(_window, $"Vulkan ({_frameCount} fps)");

                _stopwatch = new Stopwatch();
                _frameCount = 0;
                _stopwatch.Start();
            }
        }

        private static void InitWindow() {
            Glfw.Init();

            Glfw.WindowHint(Hint.ClientApi, ClientApi.None);
            Glfw.WindowHint(Hint.Resizable, Constants.False);

            _window = Glfw.CreateWindow(WindowWidth, WindowHeight, "Vulkan", Monitor.None, GLFW.Window.None);
            Console.WriteLine($"Init a {WindowWidth}x{WindowHeight} window");
        }
    }
}