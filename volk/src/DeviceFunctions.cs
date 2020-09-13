// Copyright 2020-2020 Volk Project
// Licensed under Apache License 2.0 or any later version
// Refer to the LICENSE.md file included.

// This file is generated automatically by generator


using System;
using System.Text;
using Volk.Vulkan;

namespace Volk {
    public static partial class Functions {
        /// <summary>
        ///     Load device commands into <see cref="CommandTable" />
        /// </summary>
        /// <param name="device">Vulkan logical device</param>
        /// <exception cref="Exception">GetDeviceProcAddr isn't loaded</exception>
        public static void LoadDevice(IntPtr device) {
            if (CommandTable.GetDeviceProcAddr is null) {
                throw new Exception("GetDeviceProcAddr isn't loaded");
            }

            unsafe {
                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyDevice")[0]) {
                    CommandTable.DestroyDevice = FunctionPtrToDelegate<Commands.DestroyDevice>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDeviceQueue")[0]) {
                    CommandTable.GetDeviceQueue = FunctionPtrToDelegate<Commands.GetDeviceQueue>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkQueueSubmit")[0]) {
                    CommandTable.QueueSubmit = FunctionPtrToDelegate<Commands.QueueSubmit>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkQueueWaitIdle")[0]) {
                    CommandTable.QueueWaitIdle = FunctionPtrToDelegate<Commands.QueueWaitIdle>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDeviceWaitIdle")[0]) {
                    CommandTable.DeviceWaitIdle = FunctionPtrToDelegate<Commands.DeviceWaitIdle>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkAllocateMemory")[0]) {
                    CommandTable.AllocateMemory = FunctionPtrToDelegate<Commands.AllocateMemory>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkFreeMemory")[0]) {
                    CommandTable.FreeMemory = FunctionPtrToDelegate<Commands.FreeMemory>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkMapMemory")[0]) {
                    CommandTable.MapMemory = FunctionPtrToDelegate<Commands.MapMemory>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkUnmapMemory")[0]) {
                    CommandTable.UnmapMemory = FunctionPtrToDelegate<Commands.UnmapMemory>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkFlushMappedMemoryRanges")[0]) {
                    CommandTable.FlushMappedMemoryRanges =
                        FunctionPtrToDelegate<Commands.FlushMappedMemoryRanges>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkInvalidateMappedMemoryRanges")[0]) {
                    CommandTable.InvalidateMappedMemoryRanges =
                        FunctionPtrToDelegate<Commands.InvalidateMappedMemoryRanges>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDeviceMemoryCommitment")[0]) {
                    CommandTable.GetDeviceMemoryCommitment =
                        FunctionPtrToDelegate<Commands.GetDeviceMemoryCommitment>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetBufferMemoryRequirements")[0]) {
                    CommandTable.GetBufferMemoryRequirements =
                        FunctionPtrToDelegate<Commands.GetBufferMemoryRequirements>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkBindBufferMemory")[0]) {
                    CommandTable.BindBufferMemory =
                        FunctionPtrToDelegate<Commands.BindBufferMemory>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetImageMemoryRequirements")[0]) {
                    CommandTable.GetImageMemoryRequirements =
                        FunctionPtrToDelegate<Commands.GetImageMemoryRequirements>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkBindImageMemory")[0]) {
                    CommandTable.BindImageMemory = FunctionPtrToDelegate<Commands.BindImageMemory>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetImageSparseMemoryRequirements")[0]) {
                    CommandTable.GetImageSparseMemoryRequirements =
                        FunctionPtrToDelegate<Commands.GetImageSparseMemoryRequirements>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkQueueBindSparse")[0]) {
                    CommandTable.QueueBindSparse = FunctionPtrToDelegate<Commands.QueueBindSparse>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateFence")[0]) {
                    CommandTable.CreateFence = FunctionPtrToDelegate<Commands.CreateFence>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyFence")[0]) {
                    CommandTable.DestroyFence = FunctionPtrToDelegate<Commands.DestroyFence>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkResetFences")[0]) {
                    CommandTable.ResetFences = FunctionPtrToDelegate<Commands.ResetFences>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetFenceStatus")[0]) {
                    CommandTable.GetFenceStatus = FunctionPtrToDelegate<Commands.GetFenceStatus>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkWaitForFences")[0]) {
                    CommandTable.WaitForFences = FunctionPtrToDelegate<Commands.WaitForFences>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateSemaphore")[0]) {
                    CommandTable.CreateSemaphore = FunctionPtrToDelegate<Commands.CreateSemaphore>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroySemaphore")[0]) {
                    CommandTable.DestroySemaphore =
                        FunctionPtrToDelegate<Commands.DestroySemaphore>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateEvent")[0]) {
                    CommandTable.CreateEvent = FunctionPtrToDelegate<Commands.CreateEvent>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyEvent")[0]) {
                    CommandTable.DestroyEvent = FunctionPtrToDelegate<Commands.DestroyEvent>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetEventStatus")[0]) {
                    CommandTable.GetEventStatus = FunctionPtrToDelegate<Commands.GetEventStatus>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkSetEvent")[0]) {
                    CommandTable.SetEvent = FunctionPtrToDelegate<Commands.SetEvent>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkResetEvent")[0]) {
                    CommandTable.ResetEvent = FunctionPtrToDelegate<Commands.ResetEvent>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateQueryPool")[0]) {
                    CommandTable.CreateQueryPool = FunctionPtrToDelegate<Commands.CreateQueryPool>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyQueryPool")[0]) {
                    CommandTable.DestroyQueryPool =
                        FunctionPtrToDelegate<Commands.DestroyQueryPool>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetQueryPoolResults")[0]) {
                    CommandTable.GetQueryPoolResults =
                        FunctionPtrToDelegate<Commands.GetQueryPoolResults>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkResetQueryPool")[0]) {
                    CommandTable.ResetQueryPool = FunctionPtrToDelegate<Commands.ResetQueryPool>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateBuffer")[0]) {
                    CommandTable.CreateBuffer = FunctionPtrToDelegate<Commands.CreateBuffer>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyBuffer")[0]) {
                    CommandTable.DestroyBuffer = FunctionPtrToDelegate<Commands.DestroyBuffer>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateBufferView")[0]) {
                    CommandTable.CreateBufferView =
                        FunctionPtrToDelegate<Commands.CreateBufferView>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyBufferView")[0]) {
                    CommandTable.DestroyBufferView =
                        FunctionPtrToDelegate<Commands.DestroyBufferView>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateImage")[0]) {
                    CommandTable.CreateImage = FunctionPtrToDelegate<Commands.CreateImage>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyImage")[0]) {
                    CommandTable.DestroyImage = FunctionPtrToDelegate<Commands.DestroyImage>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetImageSubresourceLayout")[0]) {
                    CommandTable.GetImageSubresourceLayout =
                        FunctionPtrToDelegate<Commands.GetImageSubresourceLayout>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateImageView")[0]) {
                    CommandTable.CreateImageView = FunctionPtrToDelegate<Commands.CreateImageView>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyImageView")[0]) {
                    CommandTable.DestroyImageView =
                        FunctionPtrToDelegate<Commands.DestroyImageView>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateShaderModule")[0]) {
                    CommandTable.CreateShaderModule =
                        FunctionPtrToDelegate<Commands.CreateShaderModule>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyShaderModule")[0]) {
                    CommandTable.DestroyShaderModule =
                        FunctionPtrToDelegate<Commands.DestroyShaderModule>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreatePipelineCache")[0]) {
                    CommandTable.CreatePipelineCache =
                        FunctionPtrToDelegate<Commands.CreatePipelineCache>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyPipelineCache")[0]) {
                    CommandTable.DestroyPipelineCache =
                        FunctionPtrToDelegate<Commands.DestroyPipelineCache>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPipelineCacheData")[0]) {
                    CommandTable.GetPipelineCacheData =
                        FunctionPtrToDelegate<Commands.GetPipelineCacheData>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkMergePipelineCaches")[0]) {
                    CommandTable.MergePipelineCaches =
                        FunctionPtrToDelegate<Commands.MergePipelineCaches>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateGraphicsPipelines")[0]) {
                    CommandTable.CreateGraphicsPipelines =
                        FunctionPtrToDelegate<Commands.CreateGraphicsPipelines>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateComputePipelines")[0]) {
                    CommandTable.CreateComputePipelines =
                        FunctionPtrToDelegate<Commands.CreateComputePipelines>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyPipeline")[0]) {
                    CommandTable.DestroyPipeline = FunctionPtrToDelegate<Commands.DestroyPipeline>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreatePipelineLayout")[0]) {
                    CommandTable.CreatePipelineLayout =
                        FunctionPtrToDelegate<Commands.CreatePipelineLayout>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyPipelineLayout")[0]) {
                    CommandTable.DestroyPipelineLayout =
                        FunctionPtrToDelegate<Commands.DestroyPipelineLayout>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateSampler")[0]) {
                    CommandTable.CreateSampler = FunctionPtrToDelegate<Commands.CreateSampler>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroySampler")[0]) {
                    CommandTable.DestroySampler = FunctionPtrToDelegate<Commands.DestroySampler>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateDescriptorSetLayout")[0]) {
                    CommandTable.CreateDescriptorSetLayout =
                        FunctionPtrToDelegate<Commands.CreateDescriptorSetLayout>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyDescriptorSetLayout")[0]) {
                    CommandTable.DestroyDescriptorSetLayout =
                        FunctionPtrToDelegate<Commands.DestroyDescriptorSetLayout>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateDescriptorPool")[0]) {
                    CommandTable.CreateDescriptorPool =
                        FunctionPtrToDelegate<Commands.CreateDescriptorPool>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyDescriptorPool")[0]) {
                    CommandTable.DestroyDescriptorPool =
                        FunctionPtrToDelegate<Commands.DestroyDescriptorPool>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkResetDescriptorPool")[0]) {
                    CommandTable.ResetDescriptorPool =
                        FunctionPtrToDelegate<Commands.ResetDescriptorPool>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkAllocateDescriptorSets")[0]) {
                    CommandTable.AllocateDescriptorSets =
                        FunctionPtrToDelegate<Commands.AllocateDescriptorSets>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkFreeDescriptorSets")[0]) {
                    CommandTable.FreeDescriptorSets =
                        FunctionPtrToDelegate<Commands.FreeDescriptorSets>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkUpdateDescriptorSets")[0]) {
                    CommandTable.UpdateDescriptorSets =
                        FunctionPtrToDelegate<Commands.UpdateDescriptorSets>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateFramebuffer")[0]) {
                    CommandTable.CreateFramebuffer =
                        FunctionPtrToDelegate<Commands.CreateFramebuffer>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyFramebuffer")[0]) {
                    CommandTable.DestroyFramebuffer =
                        FunctionPtrToDelegate<Commands.DestroyFramebuffer>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateRenderPass")[0]) {
                    CommandTable.CreateRenderPass =
                        FunctionPtrToDelegate<Commands.CreateRenderPass>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyRenderPass")[0]) {
                    CommandTable.DestroyRenderPass =
                        FunctionPtrToDelegate<Commands.DestroyRenderPass>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetRenderAreaGranularity")[0]) {
                    CommandTable.GetRenderAreaGranularity =
                        FunctionPtrToDelegate<Commands.GetRenderAreaGranularity>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateCommandPool")[0]) {
                    CommandTable.CreateCommandPool =
                        FunctionPtrToDelegate<Commands.CreateCommandPool>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyCommandPool")[0]) {
                    CommandTable.DestroyCommandPool =
                        FunctionPtrToDelegate<Commands.DestroyCommandPool>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkResetCommandPool")[0]) {
                    CommandTable.ResetCommandPool =
                        FunctionPtrToDelegate<Commands.ResetCommandPool>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkAllocateCommandBuffers")[0]) {
                    CommandTable.AllocateCommandBuffers =
                        FunctionPtrToDelegate<Commands.AllocateCommandBuffers>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkFreeCommandBuffers")[0]) {
                    CommandTable.FreeCommandBuffers =
                        FunctionPtrToDelegate<Commands.FreeCommandBuffers>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkBeginCommandBuffer")[0]) {
                    CommandTable.BeginCommandBuffer =
                        FunctionPtrToDelegate<Commands.BeginCommandBuffer>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkEndCommandBuffer")[0]) {
                    CommandTable.EndCommandBuffer =
                        FunctionPtrToDelegate<Commands.EndCommandBuffer>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkResetCommandBuffer")[0]) {
                    CommandTable.ResetCommandBuffer =
                        FunctionPtrToDelegate<Commands.ResetCommandBuffer>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBindPipeline")[0]) {
                    CommandTable.CmdBindPipeline = FunctionPtrToDelegate<Commands.CmdBindPipeline>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetViewport")[0]) {
                    CommandTable.CmdSetViewport = FunctionPtrToDelegate<Commands.CmdSetViewport>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetScissor")[0]) {
                    CommandTable.CmdSetScissor = FunctionPtrToDelegate<Commands.CmdSetScissor>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetLineWidth")[0]) {
                    CommandTable.CmdSetLineWidth = FunctionPtrToDelegate<Commands.CmdSetLineWidth>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetDepthBias")[0]) {
                    CommandTable.CmdSetDepthBias = FunctionPtrToDelegate<Commands.CmdSetDepthBias>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetBlendConstants")[0]) {
                    CommandTable.CmdSetBlendConstants =
                        FunctionPtrToDelegate<Commands.CmdSetBlendConstants>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetDepthBounds")[0]) {
                    CommandTable.CmdSetDepthBounds =
                        FunctionPtrToDelegate<Commands.CmdSetDepthBounds>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetStencilCompareMask")[0]) {
                    CommandTable.CmdSetStencilCompareMask =
                        FunctionPtrToDelegate<Commands.CmdSetStencilCompareMask>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetStencilWriteMask")[0]) {
                    CommandTable.CmdSetStencilWriteMask =
                        FunctionPtrToDelegate<Commands.CmdSetStencilWriteMask>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetStencilReference")[0]) {
                    CommandTable.CmdSetStencilReference =
                        FunctionPtrToDelegate<Commands.CmdSetStencilReference>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBindDescriptorSets")[0]) {
                    CommandTable.CmdBindDescriptorSets =
                        FunctionPtrToDelegate<Commands.CmdBindDescriptorSets>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBindIndexBuffer")[0]) {
                    CommandTable.CmdBindIndexBuffer =
                        FunctionPtrToDelegate<Commands.CmdBindIndexBuffer>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBindVertexBuffers")[0]) {
                    CommandTable.CmdBindVertexBuffers =
                        FunctionPtrToDelegate<Commands.CmdBindVertexBuffers>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDraw")[0]) {
                    CommandTable.CmdDraw = FunctionPtrToDelegate<Commands.CmdDraw>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDrawIndexed")[0]) {
                    CommandTable.CmdDrawIndexed = FunctionPtrToDelegate<Commands.CmdDrawIndexed>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDrawIndirect")[0]) {
                    CommandTable.CmdDrawIndirect = FunctionPtrToDelegate<Commands.CmdDrawIndirect>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDrawIndexedIndirect")[0]) {
                    CommandTable.CmdDrawIndexedIndirect =
                        FunctionPtrToDelegate<Commands.CmdDrawIndexedIndirect>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDispatch")[0]) {
                    CommandTable.CmdDispatch = FunctionPtrToDelegate<Commands.CmdDispatch>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDispatchIndirect")[0]) {
                    CommandTable.CmdDispatchIndirect =
                        FunctionPtrToDelegate<Commands.CmdDispatchIndirect>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdCopyBuffer")[0]) {
                    CommandTable.CmdCopyBuffer = FunctionPtrToDelegate<Commands.CmdCopyBuffer>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdCopyImage")[0]) {
                    CommandTable.CmdCopyImage = FunctionPtrToDelegate<Commands.CmdCopyImage>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBlitImage")[0]) {
                    CommandTable.CmdBlitImage = FunctionPtrToDelegate<Commands.CmdBlitImage>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdCopyBufferToImage")[0]) {
                    CommandTable.CmdCopyBufferToImage =
                        FunctionPtrToDelegate<Commands.CmdCopyBufferToImage>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdCopyImageToBuffer")[0]) {
                    CommandTable.CmdCopyImageToBuffer =
                        FunctionPtrToDelegate<Commands.CmdCopyImageToBuffer>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdUpdateBuffer")[0]) {
                    CommandTable.CmdUpdateBuffer = FunctionPtrToDelegate<Commands.CmdUpdateBuffer>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdFillBuffer")[0]) {
                    CommandTable.CmdFillBuffer = FunctionPtrToDelegate<Commands.CmdFillBuffer>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdClearColorImage")[0]) {
                    CommandTable.CmdClearColorImage =
                        FunctionPtrToDelegate<Commands.CmdClearColorImage>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdClearDepthStencilImage")[0]) {
                    CommandTable.CmdClearDepthStencilImage =
                        FunctionPtrToDelegate<Commands.CmdClearDepthStencilImage>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdClearAttachments")[0]) {
                    CommandTable.CmdClearAttachments =
                        FunctionPtrToDelegate<Commands.CmdClearAttachments>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdResolveImage")[0]) {
                    CommandTable.CmdResolveImage = FunctionPtrToDelegate<Commands.CmdResolveImage>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetEvent")[0]) {
                    CommandTable.CmdSetEvent = FunctionPtrToDelegate<Commands.CmdSetEvent>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdResetEvent")[0]) {
                    CommandTable.CmdResetEvent = FunctionPtrToDelegate<Commands.CmdResetEvent>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdWaitEvents")[0]) {
                    CommandTable.CmdWaitEvents = FunctionPtrToDelegate<Commands.CmdWaitEvents>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdPipelineBarrier")[0]) {
                    CommandTable.CmdPipelineBarrier =
                        FunctionPtrToDelegate<Commands.CmdPipelineBarrier>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBeginQuery")[0]) {
                    CommandTable.CmdBeginQuery = FunctionPtrToDelegate<Commands.CmdBeginQuery>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdEndQuery")[0]) {
                    CommandTable.CmdEndQuery = FunctionPtrToDelegate<Commands.CmdEndQuery>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBeginConditionalRenderingEXT")[0]) {
                    CommandTable.CmdBeginConditionalRenderingEXT =
                        FunctionPtrToDelegate<Commands.CmdBeginConditionalRenderingEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdEndConditionalRenderingEXT")[0]) {
                    CommandTable.CmdEndConditionalRenderingEXT =
                        FunctionPtrToDelegate<Commands.CmdEndConditionalRenderingEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdResetQueryPool")[0]) {
                    CommandTable.CmdResetQueryPool =
                        FunctionPtrToDelegate<Commands.CmdResetQueryPool>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdWriteTimestamp")[0]) {
                    CommandTable.CmdWriteTimestamp =
                        FunctionPtrToDelegate<Commands.CmdWriteTimestamp>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdCopyQueryPoolResults")[0]) {
                    CommandTable.CmdCopyQueryPoolResults =
                        FunctionPtrToDelegate<Commands.CmdCopyQueryPoolResults>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdPushConstants")[0]) {
                    CommandTable.CmdPushConstants =
                        FunctionPtrToDelegate<Commands.CmdPushConstants>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBeginRenderPass")[0]) {
                    CommandTable.CmdBeginRenderPass =
                        FunctionPtrToDelegate<Commands.CmdBeginRenderPass>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdNextSubpass")[0]) {
                    CommandTable.CmdNextSubpass = FunctionPtrToDelegate<Commands.CmdNextSubpass>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdEndRenderPass")[0]) {
                    CommandTable.CmdEndRenderPass =
                        FunctionPtrToDelegate<Commands.CmdEndRenderPass>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdExecuteCommands")[0]) {
                    CommandTable.CmdExecuteCommands =
                        FunctionPtrToDelegate<Commands.CmdExecuteCommands>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateSharedSwapchainsKHR")[0]) {
                    CommandTable.CreateSharedSwapchainsKHR =
                        FunctionPtrToDelegate<Commands.CreateSharedSwapchainsKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateSwapchainKHR")[0]) {
                    CommandTable.CreateSwapchainKHR =
                        FunctionPtrToDelegate<Commands.CreateSwapchainKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroySwapchainKHR")[0]) {
                    CommandTable.DestroySwapchainKHR =
                        FunctionPtrToDelegate<Commands.DestroySwapchainKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetSwapchainImagesKHR")[0]) {
                    CommandTable.GetSwapchainImagesKHR =
                        FunctionPtrToDelegate<Commands.GetSwapchainImagesKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkAcquireNextImageKHR")[0]) {
                    CommandTable.AcquireNextImageKHR =
                        FunctionPtrToDelegate<Commands.AcquireNextImageKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkQueuePresentKHR")[0]) {
                    CommandTable.QueuePresentKHR = FunctionPtrToDelegate<Commands.QueuePresentKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDebugMarkerSetObjectNameEXT")[0]) {
                    CommandTable.DebugMarkerSetObjectNameEXT =
                        FunctionPtrToDelegate<Commands.DebugMarkerSetObjectNameEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDebugMarkerSetObjectTagEXT")[0]) {
                    CommandTable.DebugMarkerSetObjectTagEXT =
                        FunctionPtrToDelegate<Commands.DebugMarkerSetObjectTagEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDebugMarkerBeginEXT")[0]) {
                    CommandTable.CmdDebugMarkerBeginEXT =
                        FunctionPtrToDelegate<Commands.CmdDebugMarkerBeginEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDebugMarkerEndEXT")[0]) {
                    CommandTable.CmdDebugMarkerEndEXT =
                        FunctionPtrToDelegate<Commands.CmdDebugMarkerEndEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDebugMarkerInsertEXT")[0]) {
                    CommandTable.CmdDebugMarkerInsertEXT =
                        FunctionPtrToDelegate<Commands.CmdDebugMarkerInsertEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetMemoryWin32HandleNV")[0]) {
                    CommandTable.GetMemoryWin32HandleNV =
                        FunctionPtrToDelegate<Commands.GetMemoryWin32HandleNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdExecuteGeneratedCommandsNV")[0]) {
                    CommandTable.CmdExecuteGeneratedCommandsNV =
                        FunctionPtrToDelegate<Commands.CmdExecuteGeneratedCommandsNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdPreprocessGeneratedCommandsNV")[0]) {
                    CommandTable.CmdPreprocessGeneratedCommandsNV =
                        FunctionPtrToDelegate<Commands.CmdPreprocessGeneratedCommandsNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBindPipelineShaderGroupNV")[0]) {
                    CommandTable.CmdBindPipelineShaderGroupNV =
                        FunctionPtrToDelegate<Commands.CmdBindPipelineShaderGroupNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetGeneratedCommandsMemoryRequirementsNV")[0]) {
                    CommandTable.GetGeneratedCommandsMemoryRequirementsNV =
                        FunctionPtrToDelegate<Commands.GetGeneratedCommandsMemoryRequirementsNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateIndirectCommandsLayoutNV")[0]) {
                    CommandTable.CreateIndirectCommandsLayoutNV =
                        FunctionPtrToDelegate<Commands.CreateIndirectCommandsLayoutNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyIndirectCommandsLayoutNV")[0]) {
                    CommandTable.DestroyIndirectCommandsLayoutNV =
                        FunctionPtrToDelegate<Commands.DestroyIndirectCommandsLayoutNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdPushDescriptorSetKHR")[0]) {
                    CommandTable.CmdPushDescriptorSetKHR =
                        FunctionPtrToDelegate<Commands.CmdPushDescriptorSetKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkTrimCommandPool")[0]) {
                    CommandTable.TrimCommandPool = FunctionPtrToDelegate<Commands.TrimCommandPool>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetMemoryWin32HandleKHR")[0]) {
                    CommandTable.GetMemoryWin32HandleKHR =
                        FunctionPtrToDelegate<Commands.GetMemoryWin32HandleKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetMemoryWin32HandlePropertiesKHR")[0]) {
                    CommandTable.GetMemoryWin32HandlePropertiesKHR =
                        FunctionPtrToDelegate<Commands.GetMemoryWin32HandlePropertiesKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetMemoryFdKHR")[0]) {
                    CommandTable.GetMemoryFdKHR = FunctionPtrToDelegate<Commands.GetMemoryFdKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetMemoryFdPropertiesKHR")[0]) {
                    CommandTable.GetMemoryFdPropertiesKHR =
                        FunctionPtrToDelegate<Commands.GetMemoryFdPropertiesKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetSemaphoreWin32HandleKHR")[0]) {
                    CommandTable.GetSemaphoreWin32HandleKHR =
                        FunctionPtrToDelegate<Commands.GetSemaphoreWin32HandleKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkImportSemaphoreWin32HandleKHR")[0]) {
                    CommandTable.ImportSemaphoreWin32HandleKHR =
                        FunctionPtrToDelegate<Commands.ImportSemaphoreWin32HandleKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetSemaphoreFdKHR")[0]) {
                    CommandTable.GetSemaphoreFdKHR =
                        FunctionPtrToDelegate<Commands.GetSemaphoreFdKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkImportSemaphoreFdKHR")[0]) {
                    CommandTable.ImportSemaphoreFdKHR =
                        FunctionPtrToDelegate<Commands.ImportSemaphoreFdKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetFenceWin32HandleKHR")[0]) {
                    CommandTable.GetFenceWin32HandleKHR =
                        FunctionPtrToDelegate<Commands.GetFenceWin32HandleKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkImportFenceWin32HandleKHR")[0]) {
                    CommandTable.ImportFenceWin32HandleKHR =
                        FunctionPtrToDelegate<Commands.ImportFenceWin32HandleKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetFenceFdKHR")[0]) {
                    CommandTable.GetFenceFdKHR = FunctionPtrToDelegate<Commands.GetFenceFdKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkImportFenceFdKHR")[0]) {
                    CommandTable.ImportFenceFdKHR =
                        FunctionPtrToDelegate<Commands.ImportFenceFdKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDisplayPowerControlEXT")[0]) {
                    CommandTable.DisplayPowerControlEXT =
                        FunctionPtrToDelegate<Commands.DisplayPowerControlEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkRegisterDeviceEventEXT")[0]) {
                    CommandTable.RegisterDeviceEventEXT =
                        FunctionPtrToDelegate<Commands.RegisterDeviceEventEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkRegisterDisplayEventEXT")[0]) {
                    CommandTable.RegisterDisplayEventEXT =
                        FunctionPtrToDelegate<Commands.RegisterDisplayEventEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetSwapchainCounterEXT")[0]) {
                    CommandTable.GetSwapchainCounterEXT =
                        FunctionPtrToDelegate<Commands.GetSwapchainCounterEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDeviceGroupPeerMemoryFeatures")[0]) {
                    CommandTable.GetDeviceGroupPeerMemoryFeatures =
                        FunctionPtrToDelegate<Commands.GetDeviceGroupPeerMemoryFeatures>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkBindBufferMemory2")[0]) {
                    CommandTable.BindBufferMemory2 =
                        FunctionPtrToDelegate<Commands.BindBufferMemory2>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkBindImageMemory2")[0]) {
                    CommandTable.BindImageMemory2 =
                        FunctionPtrToDelegate<Commands.BindImageMemory2>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetDeviceMask")[0]) {
                    CommandTable.CmdSetDeviceMask =
                        FunctionPtrToDelegate<Commands.CmdSetDeviceMask>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDeviceGroupPresentCapabilitiesKHR")[0]) {
                    CommandTable.GetDeviceGroupPresentCapabilitiesKHR =
                        FunctionPtrToDelegate<Commands.GetDeviceGroupPresentCapabilitiesKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDeviceGroupSurfacePresentModesKHR")[0]) {
                    CommandTable.GetDeviceGroupSurfacePresentModesKHR =
                        FunctionPtrToDelegate<Commands.GetDeviceGroupSurfacePresentModesKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkAcquireNextImage2KHR")[0]) {
                    CommandTable.AcquireNextImage2KHR =
                        FunctionPtrToDelegate<Commands.AcquireNextImage2KHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDispatchBase")[0]) {
                    CommandTable.CmdDispatchBase = FunctionPtrToDelegate<Commands.CmdDispatchBase>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateDescriptorUpdateTemplate")[0]) {
                    CommandTable.CreateDescriptorUpdateTemplate =
                        FunctionPtrToDelegate<Commands.CreateDescriptorUpdateTemplate>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyDescriptorUpdateTemplate")[0]) {
                    CommandTable.DestroyDescriptorUpdateTemplate =
                        FunctionPtrToDelegate<Commands.DestroyDescriptorUpdateTemplate>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkUpdateDescriptorSetWithTemplate")[0]) {
                    CommandTable.UpdateDescriptorSetWithTemplate =
                        FunctionPtrToDelegate<Commands.UpdateDescriptorSetWithTemplate>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdPushDescriptorSetWithTemplateKHR")[0]) {
                    CommandTable.CmdPushDescriptorSetWithTemplateKHR =
                        FunctionPtrToDelegate<Commands.CmdPushDescriptorSetWithTemplateKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkSetHdrMetadataEXT")[0]) {
                    CommandTable.SetHdrMetadataEXT =
                        FunctionPtrToDelegate<Commands.SetHdrMetadataEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetSwapchainStatusKHR")[0]) {
                    CommandTable.GetSwapchainStatusKHR =
                        FunctionPtrToDelegate<Commands.GetSwapchainStatusKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetRefreshCycleDurationGOOGLE")[0]) {
                    CommandTable.GetRefreshCycleDurationGOOGLE =
                        FunctionPtrToDelegate<Commands.GetRefreshCycleDurationGOOGLE>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPastPresentationTimingGOOGLE")[0]) {
                    CommandTable.GetPastPresentationTimingGOOGLE =
                        FunctionPtrToDelegate<Commands.GetPastPresentationTimingGOOGLE>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetViewportWScalingNV")[0]) {
                    CommandTable.CmdSetViewportWScalingNV =
                        FunctionPtrToDelegate<Commands.CmdSetViewportWScalingNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetDiscardRectangleEXT")[0]) {
                    CommandTable.CmdSetDiscardRectangleEXT =
                        FunctionPtrToDelegate<Commands.CmdSetDiscardRectangleEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetSampleLocationsEXT")[0]) {
                    CommandTable.CmdSetSampleLocationsEXT =
                        FunctionPtrToDelegate<Commands.CmdSetSampleLocationsEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetBufferMemoryRequirements2")[0]) {
                    CommandTable.GetBufferMemoryRequirements2 =
                        FunctionPtrToDelegate<Commands.GetBufferMemoryRequirements2>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetImageMemoryRequirements2")[0]) {
                    CommandTable.GetImageMemoryRequirements2 =
                        FunctionPtrToDelegate<Commands.GetImageMemoryRequirements2>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetImageSparseMemoryRequirements2")[0]) {
                    CommandTable.GetImageSparseMemoryRequirements2 =
                        FunctionPtrToDelegate<Commands.GetImageSparseMemoryRequirements2>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateSamplerYcbcrConversion")[0]) {
                    CommandTable.CreateSamplerYcbcrConversion =
                        FunctionPtrToDelegate<Commands.CreateSamplerYcbcrConversion>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroySamplerYcbcrConversion")[0]) {
                    CommandTable.DestroySamplerYcbcrConversion =
                        FunctionPtrToDelegate<Commands.DestroySamplerYcbcrConversion>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDeviceQueue2")[0]) {
                    CommandTable.GetDeviceQueue2 = FunctionPtrToDelegate<Commands.GetDeviceQueue2>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateValidationCacheEXT")[0]) {
                    CommandTable.CreateValidationCacheEXT =
                        FunctionPtrToDelegate<Commands.CreateValidationCacheEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyValidationCacheEXT")[0]) {
                    CommandTable.DestroyValidationCacheEXT =
                        FunctionPtrToDelegate<Commands.DestroyValidationCacheEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetValidationCacheDataEXT")[0]) {
                    CommandTable.GetValidationCacheDataEXT =
                        FunctionPtrToDelegate<Commands.GetValidationCacheDataEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkMergeValidationCachesEXT")[0]) {
                    CommandTable.MergeValidationCachesEXT =
                        FunctionPtrToDelegate<Commands.MergeValidationCachesEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDescriptorSetLayoutSupport")[0]) {
                    CommandTable.GetDescriptorSetLayoutSupport =
                        FunctionPtrToDelegate<Commands.GetDescriptorSetLayoutSupport>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetSwapchainGrallocUsageANDROID")[0]) {
                    CommandTable.GetSwapchainGrallocUsageANDROID =
                        FunctionPtrToDelegate<Commands.GetSwapchainGrallocUsageANDROID>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetSwapchainGrallocUsage2ANDROID")[0]) {
                    CommandTable.GetSwapchainGrallocUsage2ANDROID =
                        FunctionPtrToDelegate<Commands.GetSwapchainGrallocUsage2ANDROID>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkAcquireImageANDROID")[0]) {
                    CommandTable.AcquireImageANDROID =
                        FunctionPtrToDelegate<Commands.AcquireImageANDROID>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkQueueSignalReleaseImageANDROID")[0]) {
                    CommandTable.QueueSignalReleaseImageANDROID =
                        FunctionPtrToDelegate<Commands.QueueSignalReleaseImageANDROID>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetShaderInfoAMD")[0]) {
                    CommandTable.GetShaderInfoAMD =
                        FunctionPtrToDelegate<Commands.GetShaderInfoAMD>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkSetLocalDimmingAMD")[0]) {
                    CommandTable.SetLocalDimmingAMD =
                        FunctionPtrToDelegate<Commands.SetLocalDimmingAMD>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetCalibratedTimestampsEXT")[0]) {
                    CommandTable.GetCalibratedTimestampsEXT =
                        FunctionPtrToDelegate<Commands.GetCalibratedTimestampsEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkSetDebugUtilsObjectNameEXT")[0]) {
                    CommandTable.SetDebugUtilsObjectNameEXT =
                        FunctionPtrToDelegate<Commands.SetDebugUtilsObjectNameEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkSetDebugUtilsObjectTagEXT")[0]) {
                    CommandTable.SetDebugUtilsObjectTagEXT =
                        FunctionPtrToDelegate<Commands.SetDebugUtilsObjectTagEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkQueueBeginDebugUtilsLabelEXT")[0]) {
                    CommandTable.QueueBeginDebugUtilsLabelEXT =
                        FunctionPtrToDelegate<Commands.QueueBeginDebugUtilsLabelEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkQueueEndDebugUtilsLabelEXT")[0]) {
                    CommandTable.QueueEndDebugUtilsLabelEXT =
                        FunctionPtrToDelegate<Commands.QueueEndDebugUtilsLabelEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkQueueInsertDebugUtilsLabelEXT")[0]) {
                    CommandTable.QueueInsertDebugUtilsLabelEXT =
                        FunctionPtrToDelegate<Commands.QueueInsertDebugUtilsLabelEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBeginDebugUtilsLabelEXT")[0]) {
                    CommandTable.CmdBeginDebugUtilsLabelEXT =
                        FunctionPtrToDelegate<Commands.CmdBeginDebugUtilsLabelEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdEndDebugUtilsLabelEXT")[0]) {
                    CommandTable.CmdEndDebugUtilsLabelEXT =
                        FunctionPtrToDelegate<Commands.CmdEndDebugUtilsLabelEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdInsertDebugUtilsLabelEXT")[0]) {
                    CommandTable.CmdInsertDebugUtilsLabelEXT =
                        FunctionPtrToDelegate<Commands.CmdInsertDebugUtilsLabelEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetMemoryHostPointerPropertiesEXT")[0]) {
                    CommandTable.GetMemoryHostPointerPropertiesEXT =
                        FunctionPtrToDelegate<Commands.GetMemoryHostPointerPropertiesEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdWriteBufferMarkerAMD")[0]) {
                    CommandTable.CmdWriteBufferMarkerAMD =
                        FunctionPtrToDelegate<Commands.CmdWriteBufferMarkerAMD>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateRenderPass2")[0]) {
                    CommandTable.CreateRenderPass2 =
                        FunctionPtrToDelegate<Commands.CreateRenderPass2>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBeginRenderPass2")[0]) {
                    CommandTable.CmdBeginRenderPass2 =
                        FunctionPtrToDelegate<Commands.CmdBeginRenderPass2>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdNextSubpass2")[0]) {
                    CommandTable.CmdNextSubpass2 = FunctionPtrToDelegate<Commands.CmdNextSubpass2>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdEndRenderPass2")[0]) {
                    CommandTable.CmdEndRenderPass2 =
                        FunctionPtrToDelegate<Commands.CmdEndRenderPass2>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetSemaphoreCounterValue")[0]) {
                    CommandTable.GetSemaphoreCounterValue =
                        FunctionPtrToDelegate<Commands.GetSemaphoreCounterValue>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkWaitSemaphores")[0]) {
                    CommandTable.WaitSemaphores = FunctionPtrToDelegate<Commands.WaitSemaphores>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkSignalSemaphore")[0]) {
                    CommandTable.SignalSemaphore = FunctionPtrToDelegate<Commands.SignalSemaphore>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetAndroidHardwareBufferPropertiesANDROID")[0]) {
                    CommandTable.GetAndroidHardwareBufferPropertiesANDROID =
                        FunctionPtrToDelegate<Commands.GetAndroidHardwareBufferPropertiesANDROID>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetMemoryAndroidHardwareBufferANDROID")[0]) {
                    CommandTable.GetMemoryAndroidHardwareBufferANDROID =
                        FunctionPtrToDelegate<Commands.GetMemoryAndroidHardwareBufferANDROID>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDrawIndirectCount")[0]) {
                    CommandTable.CmdDrawIndirectCount =
                        FunctionPtrToDelegate<Commands.CmdDrawIndirectCount>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDrawIndexedIndirectCount")[0]) {
                    CommandTable.CmdDrawIndexedIndirectCount =
                        FunctionPtrToDelegate<Commands.CmdDrawIndexedIndirectCount>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetCheckpointNV")[0]) {
                    CommandTable.CmdSetCheckpointNV =
                        FunctionPtrToDelegate<Commands.CmdSetCheckpointNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetQueueCheckpointDataNV")[0]) {
                    CommandTable.GetQueueCheckpointDataNV =
                        FunctionPtrToDelegate<Commands.GetQueueCheckpointDataNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBindTransformFeedbackBuffersEXT")[0]) {
                    CommandTable.CmdBindTransformFeedbackBuffersEXT =
                        FunctionPtrToDelegate<Commands.CmdBindTransformFeedbackBuffersEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBeginTransformFeedbackEXT")[0]) {
                    CommandTable.CmdBeginTransformFeedbackEXT =
                        FunctionPtrToDelegate<Commands.CmdBeginTransformFeedbackEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdEndTransformFeedbackEXT")[0]) {
                    CommandTable.CmdEndTransformFeedbackEXT =
                        FunctionPtrToDelegate<Commands.CmdEndTransformFeedbackEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBeginQueryIndexedEXT")[0]) {
                    CommandTable.CmdBeginQueryIndexedEXT =
                        FunctionPtrToDelegate<Commands.CmdBeginQueryIndexedEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdEndQueryIndexedEXT")[0]) {
                    CommandTable.CmdEndQueryIndexedEXT =
                        FunctionPtrToDelegate<Commands.CmdEndQueryIndexedEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDrawIndirectByteCountEXT")[0]) {
                    CommandTable.CmdDrawIndirectByteCountEXT =
                        FunctionPtrToDelegate<Commands.CmdDrawIndirectByteCountEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetExclusiveScissorNV")[0]) {
                    CommandTable.CmdSetExclusiveScissorNV =
                        FunctionPtrToDelegate<Commands.CmdSetExclusiveScissorNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBindShadingRateImageNV")[0]) {
                    CommandTable.CmdBindShadingRateImageNV =
                        FunctionPtrToDelegate<Commands.CmdBindShadingRateImageNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetViewportShadingRatePaletteNV")[0]) {
                    CommandTable.CmdSetViewportShadingRatePaletteNV =
                        FunctionPtrToDelegate<Commands.CmdSetViewportShadingRatePaletteNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetCoarseSampleOrderNV")[0]) {
                    CommandTable.CmdSetCoarseSampleOrderNV =
                        FunctionPtrToDelegate<Commands.CmdSetCoarseSampleOrderNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDrawMeshTasksNV")[0]) {
                    CommandTable.CmdDrawMeshTasksNV =
                        FunctionPtrToDelegate<Commands.CmdDrawMeshTasksNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDrawMeshTasksIndirectNV")[0]) {
                    CommandTable.CmdDrawMeshTasksIndirectNV =
                        FunctionPtrToDelegate<Commands.CmdDrawMeshTasksIndirectNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDrawMeshTasksIndirectCountNV")[0]) {
                    CommandTable.CmdDrawMeshTasksIndirectCountNV =
                        FunctionPtrToDelegate<Commands.CmdDrawMeshTasksIndirectCountNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCompileDeferredNV")[0]) {
                    CommandTable.CompileDeferredNV =
                        FunctionPtrToDelegate<Commands.CompileDeferredNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateAccelerationStructureNV")[0]) {
                    CommandTable.CreateAccelerationStructureNV =
                        FunctionPtrToDelegate<Commands.CreateAccelerationStructureNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyAccelerationStructureKHR")[0]) {
                    CommandTable.DestroyAccelerationStructureKHR =
                        FunctionPtrToDelegate<Commands.DestroyAccelerationStructureKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetAccelerationStructureMemoryRequirementsKHR")[0]) {
                    CommandTable.GetAccelerationStructureMemoryRequirementsKHR =
                        FunctionPtrToDelegate<Commands.GetAccelerationStructureMemoryRequirementsKHR>(
                            CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetAccelerationStructureMemoryRequirementsNV")[0]) {
                    CommandTable.GetAccelerationStructureMemoryRequirementsNV =
                        FunctionPtrToDelegate<Commands.GetAccelerationStructureMemoryRequirementsNV>(
                            CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkBindAccelerationStructureMemoryKHR")[0]) {
                    CommandTable.BindAccelerationStructureMemoryKHR =
                        FunctionPtrToDelegate<Commands.BindAccelerationStructureMemoryKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdCopyAccelerationStructureNV")[0]) {
                    CommandTable.CmdCopyAccelerationStructureNV =
                        FunctionPtrToDelegate<Commands.CmdCopyAccelerationStructureNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdCopyAccelerationStructureKHR")[0]) {
                    CommandTable.CmdCopyAccelerationStructureKHR =
                        FunctionPtrToDelegate<Commands.CmdCopyAccelerationStructureKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCopyAccelerationStructureKHR")[0]) {
                    CommandTable.CopyAccelerationStructureKHR =
                        FunctionPtrToDelegate<Commands.CopyAccelerationStructureKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdCopyAccelerationStructureToMemoryKHR")[0]) {
                    CommandTable.CmdCopyAccelerationStructureToMemoryKHR =
                        FunctionPtrToDelegate<Commands.CmdCopyAccelerationStructureToMemoryKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCopyAccelerationStructureToMemoryKHR")[0]) {
                    CommandTable.CopyAccelerationStructureToMemoryKHR =
                        FunctionPtrToDelegate<Commands.CopyAccelerationStructureToMemoryKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdCopyMemoryToAccelerationStructureKHR")[0]) {
                    CommandTable.CmdCopyMemoryToAccelerationStructureKHR =
                        FunctionPtrToDelegate<Commands.CmdCopyMemoryToAccelerationStructureKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCopyMemoryToAccelerationStructureKHR")[0]) {
                    CommandTable.CopyMemoryToAccelerationStructureKHR =
                        FunctionPtrToDelegate<Commands.CopyMemoryToAccelerationStructureKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdWriteAccelerationStructuresPropertiesKHR")[0]) {
                    CommandTable.CmdWriteAccelerationStructuresPropertiesKHR =
                        FunctionPtrToDelegate<Commands.CmdWriteAccelerationStructuresPropertiesKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBuildAccelerationStructureNV")[0]) {
                    CommandTable.CmdBuildAccelerationStructureNV =
                        FunctionPtrToDelegate<Commands.CmdBuildAccelerationStructureNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkWriteAccelerationStructuresPropertiesKHR")[0]) {
                    CommandTable.WriteAccelerationStructuresPropertiesKHR =
                        FunctionPtrToDelegate<Commands.WriteAccelerationStructuresPropertiesKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdTraceRaysKHR")[0]) {
                    CommandTable.CmdTraceRaysKHR = FunctionPtrToDelegate<Commands.CmdTraceRaysKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdTraceRaysNV")[0]) {
                    CommandTable.CmdTraceRaysNV = FunctionPtrToDelegate<Commands.CmdTraceRaysNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetRayTracingShaderGroupHandlesKHR")[0]) {
                    CommandTable.GetRayTracingShaderGroupHandlesKHR =
                        FunctionPtrToDelegate<Commands.GetRayTracingShaderGroupHandlesKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetRayTracingCaptureReplayShaderGroupHandlesKHR")[0]) {
                    CommandTable.GetRayTracingCaptureReplayShaderGroupHandlesKHR =
                        FunctionPtrToDelegate<Commands.GetRayTracingCaptureReplayShaderGroupHandlesKHR>(
                            CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetAccelerationStructureHandleNV")[0]) {
                    CommandTable.GetAccelerationStructureHandleNV =
                        FunctionPtrToDelegate<Commands.GetAccelerationStructureHandleNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateRayTracingPipelinesNV")[0]) {
                    CommandTable.CreateRayTracingPipelinesNV =
                        FunctionPtrToDelegate<Commands.CreateRayTracingPipelinesNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateRayTracingPipelinesKHR")[0]) {
                    CommandTable.CreateRayTracingPipelinesKHR =
                        FunctionPtrToDelegate<Commands.CreateRayTracingPipelinesKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdTraceRaysIndirectKHR")[0]) {
                    CommandTable.CmdTraceRaysIndirectKHR =
                        FunctionPtrToDelegate<Commands.CmdTraceRaysIndirectKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDeviceAccelerationStructureCompatibilityKHR")[0]) {
                    CommandTable.GetDeviceAccelerationStructureCompatibilityKHR =
                        FunctionPtrToDelegate<Commands.GetDeviceAccelerationStructureCompatibilityKHR>(
                            CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetImageViewHandleNVX")[0]) {
                    CommandTable.GetImageViewHandleNVX =
                        FunctionPtrToDelegate<Commands.GetImageViewHandleNVX>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetImageViewAddressNVX")[0]) {
                    CommandTable.GetImageViewAddressNVX =
                        FunctionPtrToDelegate<Commands.GetImageViewAddressNVX>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDeviceGroupSurfacePresentModes2EXT")[0]) {
                    CommandTable.GetDeviceGroupSurfacePresentModes2EXT =
                        FunctionPtrToDelegate<Commands.GetDeviceGroupSurfacePresentModes2EXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkAcquireFullScreenExclusiveModeEXT")[0]) {
                    CommandTable.AcquireFullScreenExclusiveModeEXT =
                        FunctionPtrToDelegate<Commands.AcquireFullScreenExclusiveModeEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkReleaseFullScreenExclusiveModeEXT")[0]) {
                    CommandTable.ReleaseFullScreenExclusiveModeEXT =
                        FunctionPtrToDelegate<Commands.ReleaseFullScreenExclusiveModeEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkAcquireProfilingLockKHR")[0]) {
                    CommandTable.AcquireProfilingLockKHR =
                        FunctionPtrToDelegate<Commands.AcquireProfilingLockKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkReleaseProfilingLockKHR")[0]) {
                    CommandTable.ReleaseProfilingLockKHR =
                        FunctionPtrToDelegate<Commands.ReleaseProfilingLockKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetImageDrmFormatModifierPropertiesEXT")[0]) {
                    CommandTable.GetImageDrmFormatModifierPropertiesEXT =
                        FunctionPtrToDelegate<Commands.GetImageDrmFormatModifierPropertiesEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetBufferOpaqueCaptureAddress")[0]) {
                    CommandTable.GetBufferOpaqueCaptureAddress =
                        FunctionPtrToDelegate<Commands.GetBufferOpaqueCaptureAddress>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetBufferDeviceAddress")[0]) {
                    CommandTable.GetBufferDeviceAddress =
                        FunctionPtrToDelegate<Commands.GetBufferDeviceAddress>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkInitializePerformanceApiINTEL")[0]) {
                    CommandTable.InitializePerformanceApiINTEL =
                        FunctionPtrToDelegate<Commands.InitializePerformanceApiINTEL>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkUninitializePerformanceApiINTEL")[0]) {
                    CommandTable.UninitializePerformanceApiINTEL =
                        FunctionPtrToDelegate<Commands.UninitializePerformanceApiINTEL>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetPerformanceMarkerINTEL")[0]) {
                    CommandTable.CmdSetPerformanceMarkerINTEL =
                        FunctionPtrToDelegate<Commands.CmdSetPerformanceMarkerINTEL>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetPerformanceStreamMarkerINTEL")[0]) {
                    CommandTable.CmdSetPerformanceStreamMarkerINTEL =
                        FunctionPtrToDelegate<Commands.CmdSetPerformanceStreamMarkerINTEL>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetPerformanceOverrideINTEL")[0]) {
                    CommandTable.CmdSetPerformanceOverrideINTEL =
                        FunctionPtrToDelegate<Commands.CmdSetPerformanceOverrideINTEL>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkAcquirePerformanceConfigurationINTEL")[0]) {
                    CommandTable.AcquirePerformanceConfigurationINTEL =
                        FunctionPtrToDelegate<Commands.AcquirePerformanceConfigurationINTEL>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkReleasePerformanceConfigurationINTEL")[0]) {
                    CommandTable.ReleasePerformanceConfigurationINTEL =
                        FunctionPtrToDelegate<Commands.ReleasePerformanceConfigurationINTEL>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkQueueSetPerformanceConfigurationINTEL")[0]) {
                    CommandTable.QueueSetPerformanceConfigurationINTEL =
                        FunctionPtrToDelegate<Commands.QueueSetPerformanceConfigurationINTEL>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPerformanceParameterINTEL")[0]) {
                    CommandTable.GetPerformanceParameterINTEL =
                        FunctionPtrToDelegate<Commands.GetPerformanceParameterINTEL>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDeviceMemoryOpaqueCaptureAddress")[0]) {
                    CommandTable.GetDeviceMemoryOpaqueCaptureAddress =
                        FunctionPtrToDelegate<Commands.GetDeviceMemoryOpaqueCaptureAddress>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPipelineExecutablePropertiesKHR")[0]) {
                    CommandTable.GetPipelineExecutablePropertiesKHR =
                        FunctionPtrToDelegate<Commands.GetPipelineExecutablePropertiesKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPipelineExecutableStatisticsKHR")[0]) {
                    CommandTable.GetPipelineExecutableStatisticsKHR =
                        FunctionPtrToDelegate<Commands.GetPipelineExecutableStatisticsKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPipelineExecutableInternalRepresentationsKHR")[0]) {
                    CommandTable.GetPipelineExecutableInternalRepresentationsKHR =
                        FunctionPtrToDelegate<Commands.GetPipelineExecutableInternalRepresentationsKHR>(
                            CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetLineStippleEXT")[0]) {
                    CommandTable.CmdSetLineStippleEXT =
                        FunctionPtrToDelegate<Commands.CmdSetLineStippleEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateAccelerationStructureKHR")[0]) {
                    CommandTable.CreateAccelerationStructureKHR =
                        FunctionPtrToDelegate<Commands.CreateAccelerationStructureKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBuildAccelerationStructureKHR")[0]) {
                    CommandTable.CmdBuildAccelerationStructureKHR =
                        FunctionPtrToDelegate<Commands.CmdBuildAccelerationStructureKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBuildAccelerationStructureIndirectKHR")[0]) {
                    CommandTable.CmdBuildAccelerationStructureIndirectKHR =
                        FunctionPtrToDelegate<Commands.CmdBuildAccelerationStructureIndirectKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkBuildAccelerationStructureKHR")[0]) {
                    CommandTable.BuildAccelerationStructureKHR =
                        FunctionPtrToDelegate<Commands.BuildAccelerationStructureKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetAccelerationStructureDeviceAddressKHR")[0]) {
                    CommandTable.GetAccelerationStructureDeviceAddressKHR =
                        FunctionPtrToDelegate<Commands.GetAccelerationStructureDeviceAddressKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateDeferredOperationKHR")[0]) {
                    CommandTable.CreateDeferredOperationKHR =
                        FunctionPtrToDelegate<Commands.CreateDeferredOperationKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyDeferredOperationKHR")[0]) {
                    CommandTable.DestroyDeferredOperationKHR =
                        FunctionPtrToDelegate<Commands.DestroyDeferredOperationKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDeferredOperationMaxConcurrencyKHR")[0]) {
                    CommandTable.GetDeferredOperationMaxConcurrencyKHR =
                        FunctionPtrToDelegate<Commands.GetDeferredOperationMaxConcurrencyKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDeferredOperationResultKHR")[0]) {
                    CommandTable.GetDeferredOperationResultKHR =
                        FunctionPtrToDelegate<Commands.GetDeferredOperationResultKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDeferredOperationJoinKHR")[0]) {
                    CommandTable.DeferredOperationJoinKHR =
                        FunctionPtrToDelegate<Commands.DeferredOperationJoinKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetCullModeEXT")[0]) {
                    CommandTable.CmdSetCullModeEXT =
                        FunctionPtrToDelegate<Commands.CmdSetCullModeEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetFrontFaceEXT")[0]) {
                    CommandTable.CmdSetFrontFaceEXT =
                        FunctionPtrToDelegate<Commands.CmdSetFrontFaceEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetPrimitiveTopologyEXT")[0]) {
                    CommandTable.CmdSetPrimitiveTopologyEXT =
                        FunctionPtrToDelegate<Commands.CmdSetPrimitiveTopologyEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetViewportWithCountEXT")[0]) {
                    CommandTable.CmdSetViewportWithCountEXT =
                        FunctionPtrToDelegate<Commands.CmdSetViewportWithCountEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetScissorWithCountEXT")[0]) {
                    CommandTable.CmdSetScissorWithCountEXT =
                        FunctionPtrToDelegate<Commands.CmdSetScissorWithCountEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBindVertexBuffers2EXT")[0]) {
                    CommandTable.CmdBindVertexBuffers2EXT =
                        FunctionPtrToDelegate<Commands.CmdBindVertexBuffers2EXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetDepthTestEnableEXT")[0]) {
                    CommandTable.CmdSetDepthTestEnableEXT =
                        FunctionPtrToDelegate<Commands.CmdSetDepthTestEnableEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetDepthWriteEnableEXT")[0]) {
                    CommandTable.CmdSetDepthWriteEnableEXT =
                        FunctionPtrToDelegate<Commands.CmdSetDepthWriteEnableEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetDepthCompareOpEXT")[0]) {
                    CommandTable.CmdSetDepthCompareOpEXT =
                        FunctionPtrToDelegate<Commands.CmdSetDepthCompareOpEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetDepthBoundsTestEnableEXT")[0]) {
                    CommandTable.CmdSetDepthBoundsTestEnableEXT =
                        FunctionPtrToDelegate<Commands.CmdSetDepthBoundsTestEnableEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetStencilTestEnableEXT")[0]) {
                    CommandTable.CmdSetStencilTestEnableEXT =
                        FunctionPtrToDelegate<Commands.CmdSetStencilTestEnableEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetStencilOpEXT")[0]) {
                    CommandTable.CmdSetStencilOpEXT =
                        FunctionPtrToDelegate<Commands.CmdSetStencilOpEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreatePrivateDataSlotEXT")[0]) {
                    CommandTable.CreatePrivateDataSlotEXT =
                        FunctionPtrToDelegate<Commands.CreatePrivateDataSlotEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyPrivateDataSlotEXT")[0]) {
                    CommandTable.DestroyPrivateDataSlotEXT =
                        FunctionPtrToDelegate<Commands.DestroyPrivateDataSlotEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkSetPrivateDataEXT")[0]) {
                    CommandTable.SetPrivateDataEXT =
                        FunctionPtrToDelegate<Commands.SetPrivateDataEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPrivateDataEXT")[0]) {
                    CommandTable.GetPrivateDataEXT =
                        FunctionPtrToDelegate<Commands.GetPrivateDataEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }
            }
        }

        /// <summary>
        ///     Load device commands into a local table
        /// </summary>
        /// <param name="device">Vulkan logical device</param>
        /// <returns>Device commands table</returns>
        /// <exception cref="Exception">GetDeviceProcAddr isn't loaded</exception>
        public static DeviceCommandTable LoadDeviceTable(IntPtr device) {
            if (CommandTable.GetDeviceProcAddr is null) {
                throw new Exception("GetDeviceProcAddr isn't loaded");
            }

            var deviceTable = new DeviceCommandTable();

            unsafe {
                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyDevice")[0]) {
                    deviceTable.DestroyDevice = FunctionPtrToDelegate<Commands.DestroyDevice>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDeviceQueue")[0]) {
                    deviceTable.GetDeviceQueue = FunctionPtrToDelegate<Commands.GetDeviceQueue>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkQueueSubmit")[0]) {
                    deviceTable.QueueSubmit = FunctionPtrToDelegate<Commands.QueueSubmit>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkQueueWaitIdle")[0]) {
                    deviceTable.QueueWaitIdle = FunctionPtrToDelegate<Commands.QueueWaitIdle>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDeviceWaitIdle")[0]) {
                    deviceTable.DeviceWaitIdle = FunctionPtrToDelegate<Commands.DeviceWaitIdle>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkAllocateMemory")[0]) {
                    deviceTable.AllocateMemory = FunctionPtrToDelegate<Commands.AllocateMemory>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkFreeMemory")[0]) {
                    deviceTable.FreeMemory = FunctionPtrToDelegate<Commands.FreeMemory>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkMapMemory")[0]) {
                    deviceTable.MapMemory = FunctionPtrToDelegate<Commands.MapMemory>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkUnmapMemory")[0]) {
                    deviceTable.UnmapMemory = FunctionPtrToDelegate<Commands.UnmapMemory>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkFlushMappedMemoryRanges")[0]) {
                    deviceTable.FlushMappedMemoryRanges =
                        FunctionPtrToDelegate<Commands.FlushMappedMemoryRanges>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkInvalidateMappedMemoryRanges")[0]) {
                    deviceTable.InvalidateMappedMemoryRanges =
                        FunctionPtrToDelegate<Commands.InvalidateMappedMemoryRanges>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDeviceMemoryCommitment")[0]) {
                    deviceTable.GetDeviceMemoryCommitment =
                        FunctionPtrToDelegate<Commands.GetDeviceMemoryCommitment>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetBufferMemoryRequirements")[0]) {
                    deviceTable.GetBufferMemoryRequirements =
                        FunctionPtrToDelegate<Commands.GetBufferMemoryRequirements>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkBindBufferMemory")[0]) {
                    deviceTable.BindBufferMemory = FunctionPtrToDelegate<Commands.BindBufferMemory>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetImageMemoryRequirements")[0]) {
                    deviceTable.GetImageMemoryRequirements =
                        FunctionPtrToDelegate<Commands.GetImageMemoryRequirements>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkBindImageMemory")[0]) {
                    deviceTable.BindImageMemory = FunctionPtrToDelegate<Commands.BindImageMemory>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetImageSparseMemoryRequirements")[0]) {
                    deviceTable.GetImageSparseMemoryRequirements =
                        FunctionPtrToDelegate<Commands.GetImageSparseMemoryRequirements>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkQueueBindSparse")[0]) {
                    deviceTable.QueueBindSparse = FunctionPtrToDelegate<Commands.QueueBindSparse>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateFence")[0]) {
                    deviceTable.CreateFence = FunctionPtrToDelegate<Commands.CreateFence>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyFence")[0]) {
                    deviceTable.DestroyFence = FunctionPtrToDelegate<Commands.DestroyFence>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkResetFences")[0]) {
                    deviceTable.ResetFences = FunctionPtrToDelegate<Commands.ResetFences>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetFenceStatus")[0]) {
                    deviceTable.GetFenceStatus = FunctionPtrToDelegate<Commands.GetFenceStatus>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkWaitForFences")[0]) {
                    deviceTable.WaitForFences = FunctionPtrToDelegate<Commands.WaitForFences>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateSemaphore")[0]) {
                    deviceTable.CreateSemaphore = FunctionPtrToDelegate<Commands.CreateSemaphore>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroySemaphore")[0]) {
                    deviceTable.DestroySemaphore = FunctionPtrToDelegate<Commands.DestroySemaphore>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateEvent")[0]) {
                    deviceTable.CreateEvent = FunctionPtrToDelegate<Commands.CreateEvent>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyEvent")[0]) {
                    deviceTable.DestroyEvent = FunctionPtrToDelegate<Commands.DestroyEvent>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetEventStatus")[0]) {
                    deviceTable.GetEventStatus = FunctionPtrToDelegate<Commands.GetEventStatus>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkSetEvent")[0]) {
                    deviceTable.SetEvent = FunctionPtrToDelegate<Commands.SetEvent>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkResetEvent")[0]) {
                    deviceTable.ResetEvent = FunctionPtrToDelegate<Commands.ResetEvent>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateQueryPool")[0]) {
                    deviceTable.CreateQueryPool = FunctionPtrToDelegate<Commands.CreateQueryPool>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyQueryPool")[0]) {
                    deviceTable.DestroyQueryPool = FunctionPtrToDelegate<Commands.DestroyQueryPool>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetQueryPoolResults")[0]) {
                    deviceTable.GetQueryPoolResults =
                        FunctionPtrToDelegate<Commands.GetQueryPoolResults>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkResetQueryPool")[0]) {
                    deviceTable.ResetQueryPool = FunctionPtrToDelegate<Commands.ResetQueryPool>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateBuffer")[0]) {
                    deviceTable.CreateBuffer = FunctionPtrToDelegate<Commands.CreateBuffer>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyBuffer")[0]) {
                    deviceTable.DestroyBuffer = FunctionPtrToDelegate<Commands.DestroyBuffer>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateBufferView")[0]) {
                    deviceTable.CreateBufferView = FunctionPtrToDelegate<Commands.CreateBufferView>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyBufferView")[0]) {
                    deviceTable.DestroyBufferView =
                        FunctionPtrToDelegate<Commands.DestroyBufferView>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateImage")[0]) {
                    deviceTable.CreateImage = FunctionPtrToDelegate<Commands.CreateImage>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyImage")[0]) {
                    deviceTable.DestroyImage = FunctionPtrToDelegate<Commands.DestroyImage>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetImageSubresourceLayout")[0]) {
                    deviceTable.GetImageSubresourceLayout =
                        FunctionPtrToDelegate<Commands.GetImageSubresourceLayout>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateImageView")[0]) {
                    deviceTable.CreateImageView = FunctionPtrToDelegate<Commands.CreateImageView>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyImageView")[0]) {
                    deviceTable.DestroyImageView = FunctionPtrToDelegate<Commands.DestroyImageView>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateShaderModule")[0]) {
                    deviceTable.CreateShaderModule =
                        FunctionPtrToDelegate<Commands.CreateShaderModule>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyShaderModule")[0]) {
                    deviceTable.DestroyShaderModule =
                        FunctionPtrToDelegate<Commands.DestroyShaderModule>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreatePipelineCache")[0]) {
                    deviceTable.CreatePipelineCache =
                        FunctionPtrToDelegate<Commands.CreatePipelineCache>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyPipelineCache")[0]) {
                    deviceTable.DestroyPipelineCache =
                        FunctionPtrToDelegate<Commands.DestroyPipelineCache>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPipelineCacheData")[0]) {
                    deviceTable.GetPipelineCacheData =
                        FunctionPtrToDelegate<Commands.GetPipelineCacheData>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkMergePipelineCaches")[0]) {
                    deviceTable.MergePipelineCaches =
                        FunctionPtrToDelegate<Commands.MergePipelineCaches>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateGraphicsPipelines")[0]) {
                    deviceTable.CreateGraphicsPipelines =
                        FunctionPtrToDelegate<Commands.CreateGraphicsPipelines>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateComputePipelines")[0]) {
                    deviceTable.CreateComputePipelines =
                        FunctionPtrToDelegate<Commands.CreateComputePipelines>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyPipeline")[0]) {
                    deviceTable.DestroyPipeline = FunctionPtrToDelegate<Commands.DestroyPipeline>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreatePipelineLayout")[0]) {
                    deviceTable.CreatePipelineLayout =
                        FunctionPtrToDelegate<Commands.CreatePipelineLayout>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyPipelineLayout")[0]) {
                    deviceTable.DestroyPipelineLayout =
                        FunctionPtrToDelegate<Commands.DestroyPipelineLayout>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateSampler")[0]) {
                    deviceTable.CreateSampler = FunctionPtrToDelegate<Commands.CreateSampler>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroySampler")[0]) {
                    deviceTable.DestroySampler = FunctionPtrToDelegate<Commands.DestroySampler>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateDescriptorSetLayout")[0]) {
                    deviceTable.CreateDescriptorSetLayout =
                        FunctionPtrToDelegate<Commands.CreateDescriptorSetLayout>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyDescriptorSetLayout")[0]) {
                    deviceTable.DestroyDescriptorSetLayout =
                        FunctionPtrToDelegate<Commands.DestroyDescriptorSetLayout>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateDescriptorPool")[0]) {
                    deviceTable.CreateDescriptorPool =
                        FunctionPtrToDelegate<Commands.CreateDescriptorPool>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyDescriptorPool")[0]) {
                    deviceTable.DestroyDescriptorPool =
                        FunctionPtrToDelegate<Commands.DestroyDescriptorPool>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkResetDescriptorPool")[0]) {
                    deviceTable.ResetDescriptorPool =
                        FunctionPtrToDelegate<Commands.ResetDescriptorPool>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkAllocateDescriptorSets")[0]) {
                    deviceTable.AllocateDescriptorSets =
                        FunctionPtrToDelegate<Commands.AllocateDescriptorSets>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkFreeDescriptorSets")[0]) {
                    deviceTable.FreeDescriptorSets =
                        FunctionPtrToDelegate<Commands.FreeDescriptorSets>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkUpdateDescriptorSets")[0]) {
                    deviceTable.UpdateDescriptorSets =
                        FunctionPtrToDelegate<Commands.UpdateDescriptorSets>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateFramebuffer")[0]) {
                    deviceTable.CreateFramebuffer =
                        FunctionPtrToDelegate<Commands.CreateFramebuffer>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyFramebuffer")[0]) {
                    deviceTable.DestroyFramebuffer =
                        FunctionPtrToDelegate<Commands.DestroyFramebuffer>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateRenderPass")[0]) {
                    deviceTable.CreateRenderPass = FunctionPtrToDelegate<Commands.CreateRenderPass>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyRenderPass")[0]) {
                    deviceTable.DestroyRenderPass =
                        FunctionPtrToDelegate<Commands.DestroyRenderPass>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetRenderAreaGranularity")[0]) {
                    deviceTable.GetRenderAreaGranularity =
                        FunctionPtrToDelegate<Commands.GetRenderAreaGranularity>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateCommandPool")[0]) {
                    deviceTable.CreateCommandPool =
                        FunctionPtrToDelegate<Commands.CreateCommandPool>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyCommandPool")[0]) {
                    deviceTable.DestroyCommandPool =
                        FunctionPtrToDelegate<Commands.DestroyCommandPool>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkResetCommandPool")[0]) {
                    deviceTable.ResetCommandPool = FunctionPtrToDelegate<Commands.ResetCommandPool>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkAllocateCommandBuffers")[0]) {
                    deviceTable.AllocateCommandBuffers =
                        FunctionPtrToDelegate<Commands.AllocateCommandBuffers>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkFreeCommandBuffers")[0]) {
                    deviceTable.FreeCommandBuffers =
                        FunctionPtrToDelegate<Commands.FreeCommandBuffers>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkBeginCommandBuffer")[0]) {
                    deviceTable.BeginCommandBuffer =
                        FunctionPtrToDelegate<Commands.BeginCommandBuffer>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkEndCommandBuffer")[0]) {
                    deviceTable.EndCommandBuffer = FunctionPtrToDelegate<Commands.EndCommandBuffer>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkResetCommandBuffer")[0]) {
                    deviceTable.ResetCommandBuffer =
                        FunctionPtrToDelegate<Commands.ResetCommandBuffer>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBindPipeline")[0]) {
                    deviceTable.CmdBindPipeline = FunctionPtrToDelegate<Commands.CmdBindPipeline>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetViewport")[0]) {
                    deviceTable.CmdSetViewport = FunctionPtrToDelegate<Commands.CmdSetViewport>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetScissor")[0]) {
                    deviceTable.CmdSetScissor = FunctionPtrToDelegate<Commands.CmdSetScissor>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetLineWidth")[0]) {
                    deviceTable.CmdSetLineWidth = FunctionPtrToDelegate<Commands.CmdSetLineWidth>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetDepthBias")[0]) {
                    deviceTable.CmdSetDepthBias = FunctionPtrToDelegate<Commands.CmdSetDepthBias>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetBlendConstants")[0]) {
                    deviceTable.CmdSetBlendConstants =
                        FunctionPtrToDelegate<Commands.CmdSetBlendConstants>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetDepthBounds")[0]) {
                    deviceTable.CmdSetDepthBounds =
                        FunctionPtrToDelegate<Commands.CmdSetDepthBounds>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetStencilCompareMask")[0]) {
                    deviceTable.CmdSetStencilCompareMask =
                        FunctionPtrToDelegate<Commands.CmdSetStencilCompareMask>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetStencilWriteMask")[0]) {
                    deviceTable.CmdSetStencilWriteMask =
                        FunctionPtrToDelegate<Commands.CmdSetStencilWriteMask>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetStencilReference")[0]) {
                    deviceTable.CmdSetStencilReference =
                        FunctionPtrToDelegate<Commands.CmdSetStencilReference>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBindDescriptorSets")[0]) {
                    deviceTable.CmdBindDescriptorSets =
                        FunctionPtrToDelegate<Commands.CmdBindDescriptorSets>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBindIndexBuffer")[0]) {
                    deviceTable.CmdBindIndexBuffer =
                        FunctionPtrToDelegate<Commands.CmdBindIndexBuffer>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBindVertexBuffers")[0]) {
                    deviceTable.CmdBindVertexBuffers =
                        FunctionPtrToDelegate<Commands.CmdBindVertexBuffers>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDraw")[0]) {
                    deviceTable.CmdDraw = FunctionPtrToDelegate<Commands.CmdDraw>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDrawIndexed")[0]) {
                    deviceTable.CmdDrawIndexed = FunctionPtrToDelegate<Commands.CmdDrawIndexed>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDrawIndirect")[0]) {
                    deviceTable.CmdDrawIndirect = FunctionPtrToDelegate<Commands.CmdDrawIndirect>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDrawIndexedIndirect")[0]) {
                    deviceTable.CmdDrawIndexedIndirect =
                        FunctionPtrToDelegate<Commands.CmdDrawIndexedIndirect>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDispatch")[0]) {
                    deviceTable.CmdDispatch = FunctionPtrToDelegate<Commands.CmdDispatch>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDispatchIndirect")[0]) {
                    deviceTable.CmdDispatchIndirect =
                        FunctionPtrToDelegate<Commands.CmdDispatchIndirect>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdCopyBuffer")[0]) {
                    deviceTable.CmdCopyBuffer = FunctionPtrToDelegate<Commands.CmdCopyBuffer>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdCopyImage")[0]) {
                    deviceTable.CmdCopyImage = FunctionPtrToDelegate<Commands.CmdCopyImage>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBlitImage")[0]) {
                    deviceTable.CmdBlitImage = FunctionPtrToDelegate<Commands.CmdBlitImage>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdCopyBufferToImage")[0]) {
                    deviceTable.CmdCopyBufferToImage =
                        FunctionPtrToDelegate<Commands.CmdCopyBufferToImage>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdCopyImageToBuffer")[0]) {
                    deviceTable.CmdCopyImageToBuffer =
                        FunctionPtrToDelegate<Commands.CmdCopyImageToBuffer>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdUpdateBuffer")[0]) {
                    deviceTable.CmdUpdateBuffer = FunctionPtrToDelegate<Commands.CmdUpdateBuffer>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdFillBuffer")[0]) {
                    deviceTable.CmdFillBuffer = FunctionPtrToDelegate<Commands.CmdFillBuffer>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdClearColorImage")[0]) {
                    deviceTable.CmdClearColorImage =
                        FunctionPtrToDelegate<Commands.CmdClearColorImage>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdClearDepthStencilImage")[0]) {
                    deviceTable.CmdClearDepthStencilImage =
                        FunctionPtrToDelegate<Commands.CmdClearDepthStencilImage>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdClearAttachments")[0]) {
                    deviceTable.CmdClearAttachments =
                        FunctionPtrToDelegate<Commands.CmdClearAttachments>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdResolveImage")[0]) {
                    deviceTable.CmdResolveImage = FunctionPtrToDelegate<Commands.CmdResolveImage>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetEvent")[0]) {
                    deviceTable.CmdSetEvent = FunctionPtrToDelegate<Commands.CmdSetEvent>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdResetEvent")[0]) {
                    deviceTable.CmdResetEvent = FunctionPtrToDelegate<Commands.CmdResetEvent>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdWaitEvents")[0]) {
                    deviceTable.CmdWaitEvents = FunctionPtrToDelegate<Commands.CmdWaitEvents>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdPipelineBarrier")[0]) {
                    deviceTable.CmdPipelineBarrier =
                        FunctionPtrToDelegate<Commands.CmdPipelineBarrier>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBeginQuery")[0]) {
                    deviceTable.CmdBeginQuery = FunctionPtrToDelegate<Commands.CmdBeginQuery>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdEndQuery")[0]) {
                    deviceTable.CmdEndQuery = FunctionPtrToDelegate<Commands.CmdEndQuery>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBeginConditionalRenderingEXT")[0]) {
                    deviceTable.CmdBeginConditionalRenderingEXT =
                        FunctionPtrToDelegate<Commands.CmdBeginConditionalRenderingEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdEndConditionalRenderingEXT")[0]) {
                    deviceTable.CmdEndConditionalRenderingEXT =
                        FunctionPtrToDelegate<Commands.CmdEndConditionalRenderingEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdResetQueryPool")[0]) {
                    deviceTable.CmdResetQueryPool =
                        FunctionPtrToDelegate<Commands.CmdResetQueryPool>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdWriteTimestamp")[0]) {
                    deviceTable.CmdWriteTimestamp =
                        FunctionPtrToDelegate<Commands.CmdWriteTimestamp>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdCopyQueryPoolResults")[0]) {
                    deviceTable.CmdCopyQueryPoolResults =
                        FunctionPtrToDelegate<Commands.CmdCopyQueryPoolResults>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdPushConstants")[0]) {
                    deviceTable.CmdPushConstants = FunctionPtrToDelegate<Commands.CmdPushConstants>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBeginRenderPass")[0]) {
                    deviceTable.CmdBeginRenderPass =
                        FunctionPtrToDelegate<Commands.CmdBeginRenderPass>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdNextSubpass")[0]) {
                    deviceTable.CmdNextSubpass = FunctionPtrToDelegate<Commands.CmdNextSubpass>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdEndRenderPass")[0]) {
                    deviceTable.CmdEndRenderPass = FunctionPtrToDelegate<Commands.CmdEndRenderPass>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdExecuteCommands")[0]) {
                    deviceTable.CmdExecuteCommands =
                        FunctionPtrToDelegate<Commands.CmdExecuteCommands>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateSharedSwapchainsKHR")[0]) {
                    deviceTable.CreateSharedSwapchainsKHR =
                        FunctionPtrToDelegate<Commands.CreateSharedSwapchainsKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateSwapchainKHR")[0]) {
                    deviceTable.CreateSwapchainKHR =
                        FunctionPtrToDelegate<Commands.CreateSwapchainKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroySwapchainKHR")[0]) {
                    deviceTable.DestroySwapchainKHR =
                        FunctionPtrToDelegate<Commands.DestroySwapchainKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetSwapchainImagesKHR")[0]) {
                    deviceTable.GetSwapchainImagesKHR =
                        FunctionPtrToDelegate<Commands.GetSwapchainImagesKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkAcquireNextImageKHR")[0]) {
                    deviceTable.AcquireNextImageKHR =
                        FunctionPtrToDelegate<Commands.AcquireNextImageKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkQueuePresentKHR")[0]) {
                    deviceTable.QueuePresentKHR = FunctionPtrToDelegate<Commands.QueuePresentKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDebugMarkerSetObjectNameEXT")[0]) {
                    deviceTable.DebugMarkerSetObjectNameEXT =
                        FunctionPtrToDelegate<Commands.DebugMarkerSetObjectNameEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDebugMarkerSetObjectTagEXT")[0]) {
                    deviceTable.DebugMarkerSetObjectTagEXT =
                        FunctionPtrToDelegate<Commands.DebugMarkerSetObjectTagEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDebugMarkerBeginEXT")[0]) {
                    deviceTable.CmdDebugMarkerBeginEXT =
                        FunctionPtrToDelegate<Commands.CmdDebugMarkerBeginEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDebugMarkerEndEXT")[0]) {
                    deviceTable.CmdDebugMarkerEndEXT =
                        FunctionPtrToDelegate<Commands.CmdDebugMarkerEndEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDebugMarkerInsertEXT")[0]) {
                    deviceTable.CmdDebugMarkerInsertEXT =
                        FunctionPtrToDelegate<Commands.CmdDebugMarkerInsertEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetMemoryWin32HandleNV")[0]) {
                    deviceTable.GetMemoryWin32HandleNV =
                        FunctionPtrToDelegate<Commands.GetMemoryWin32HandleNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdExecuteGeneratedCommandsNV")[0]) {
                    deviceTable.CmdExecuteGeneratedCommandsNV =
                        FunctionPtrToDelegate<Commands.CmdExecuteGeneratedCommandsNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdPreprocessGeneratedCommandsNV")[0]) {
                    deviceTable.CmdPreprocessGeneratedCommandsNV =
                        FunctionPtrToDelegate<Commands.CmdPreprocessGeneratedCommandsNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBindPipelineShaderGroupNV")[0]) {
                    deviceTable.CmdBindPipelineShaderGroupNV =
                        FunctionPtrToDelegate<Commands.CmdBindPipelineShaderGroupNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetGeneratedCommandsMemoryRequirementsNV")[0]) {
                    deviceTable.GetGeneratedCommandsMemoryRequirementsNV =
                        FunctionPtrToDelegate<Commands.GetGeneratedCommandsMemoryRequirementsNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateIndirectCommandsLayoutNV")[0]) {
                    deviceTable.CreateIndirectCommandsLayoutNV =
                        FunctionPtrToDelegate<Commands.CreateIndirectCommandsLayoutNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyIndirectCommandsLayoutNV")[0]) {
                    deviceTable.DestroyIndirectCommandsLayoutNV =
                        FunctionPtrToDelegate<Commands.DestroyIndirectCommandsLayoutNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdPushDescriptorSetKHR")[0]) {
                    deviceTable.CmdPushDescriptorSetKHR =
                        FunctionPtrToDelegate<Commands.CmdPushDescriptorSetKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkTrimCommandPool")[0]) {
                    deviceTable.TrimCommandPool = FunctionPtrToDelegate<Commands.TrimCommandPool>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetMemoryWin32HandleKHR")[0]) {
                    deviceTable.GetMemoryWin32HandleKHR =
                        FunctionPtrToDelegate<Commands.GetMemoryWin32HandleKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetMemoryWin32HandlePropertiesKHR")[0]) {
                    deviceTable.GetMemoryWin32HandlePropertiesKHR =
                        FunctionPtrToDelegate<Commands.GetMemoryWin32HandlePropertiesKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetMemoryFdKHR")[0]) {
                    deviceTable.GetMemoryFdKHR = FunctionPtrToDelegate<Commands.GetMemoryFdKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetMemoryFdPropertiesKHR")[0]) {
                    deviceTable.GetMemoryFdPropertiesKHR =
                        FunctionPtrToDelegate<Commands.GetMemoryFdPropertiesKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetSemaphoreWin32HandleKHR")[0]) {
                    deviceTable.GetSemaphoreWin32HandleKHR =
                        FunctionPtrToDelegate<Commands.GetSemaphoreWin32HandleKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkImportSemaphoreWin32HandleKHR")[0]) {
                    deviceTable.ImportSemaphoreWin32HandleKHR =
                        FunctionPtrToDelegate<Commands.ImportSemaphoreWin32HandleKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetSemaphoreFdKHR")[0]) {
                    deviceTable.GetSemaphoreFdKHR =
                        FunctionPtrToDelegate<Commands.GetSemaphoreFdKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkImportSemaphoreFdKHR")[0]) {
                    deviceTable.ImportSemaphoreFdKHR =
                        FunctionPtrToDelegate<Commands.ImportSemaphoreFdKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetFenceWin32HandleKHR")[0]) {
                    deviceTable.GetFenceWin32HandleKHR =
                        FunctionPtrToDelegate<Commands.GetFenceWin32HandleKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkImportFenceWin32HandleKHR")[0]) {
                    deviceTable.ImportFenceWin32HandleKHR =
                        FunctionPtrToDelegate<Commands.ImportFenceWin32HandleKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetFenceFdKHR")[0]) {
                    deviceTable.GetFenceFdKHR = FunctionPtrToDelegate<Commands.GetFenceFdKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkImportFenceFdKHR")[0]) {
                    deviceTable.ImportFenceFdKHR = FunctionPtrToDelegate<Commands.ImportFenceFdKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDisplayPowerControlEXT")[0]) {
                    deviceTable.DisplayPowerControlEXT =
                        FunctionPtrToDelegate<Commands.DisplayPowerControlEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkRegisterDeviceEventEXT")[0]) {
                    deviceTable.RegisterDeviceEventEXT =
                        FunctionPtrToDelegate<Commands.RegisterDeviceEventEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkRegisterDisplayEventEXT")[0]) {
                    deviceTable.RegisterDisplayEventEXT =
                        FunctionPtrToDelegate<Commands.RegisterDisplayEventEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetSwapchainCounterEXT")[0]) {
                    deviceTable.GetSwapchainCounterEXT =
                        FunctionPtrToDelegate<Commands.GetSwapchainCounterEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDeviceGroupPeerMemoryFeatures")[0]) {
                    deviceTable.GetDeviceGroupPeerMemoryFeatures =
                        FunctionPtrToDelegate<Commands.GetDeviceGroupPeerMemoryFeatures>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkBindBufferMemory2")[0]) {
                    deviceTable.BindBufferMemory2 =
                        FunctionPtrToDelegate<Commands.BindBufferMemory2>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkBindImageMemory2")[0]) {
                    deviceTable.BindImageMemory2 = FunctionPtrToDelegate<Commands.BindImageMemory2>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetDeviceMask")[0]) {
                    deviceTable.CmdSetDeviceMask = FunctionPtrToDelegate<Commands.CmdSetDeviceMask>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDeviceGroupPresentCapabilitiesKHR")[0]) {
                    deviceTable.GetDeviceGroupPresentCapabilitiesKHR =
                        FunctionPtrToDelegate<Commands.GetDeviceGroupPresentCapabilitiesKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDeviceGroupSurfacePresentModesKHR")[0]) {
                    deviceTable.GetDeviceGroupSurfacePresentModesKHR =
                        FunctionPtrToDelegate<Commands.GetDeviceGroupSurfacePresentModesKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkAcquireNextImage2KHR")[0]) {
                    deviceTable.AcquireNextImage2KHR =
                        FunctionPtrToDelegate<Commands.AcquireNextImage2KHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDispatchBase")[0]) {
                    deviceTable.CmdDispatchBase = FunctionPtrToDelegate<Commands.CmdDispatchBase>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateDescriptorUpdateTemplate")[0]) {
                    deviceTable.CreateDescriptorUpdateTemplate =
                        FunctionPtrToDelegate<Commands.CreateDescriptorUpdateTemplate>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyDescriptorUpdateTemplate")[0]) {
                    deviceTable.DestroyDescriptorUpdateTemplate =
                        FunctionPtrToDelegate<Commands.DestroyDescriptorUpdateTemplate>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkUpdateDescriptorSetWithTemplate")[0]) {
                    deviceTable.UpdateDescriptorSetWithTemplate =
                        FunctionPtrToDelegate<Commands.UpdateDescriptorSetWithTemplate>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdPushDescriptorSetWithTemplateKHR")[0]) {
                    deviceTable.CmdPushDescriptorSetWithTemplateKHR =
                        FunctionPtrToDelegate<Commands.CmdPushDescriptorSetWithTemplateKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkSetHdrMetadataEXT")[0]) {
                    deviceTable.SetHdrMetadataEXT =
                        FunctionPtrToDelegate<Commands.SetHdrMetadataEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetSwapchainStatusKHR")[0]) {
                    deviceTable.GetSwapchainStatusKHR =
                        FunctionPtrToDelegate<Commands.GetSwapchainStatusKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetRefreshCycleDurationGOOGLE")[0]) {
                    deviceTable.GetRefreshCycleDurationGOOGLE =
                        FunctionPtrToDelegate<Commands.GetRefreshCycleDurationGOOGLE>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPastPresentationTimingGOOGLE")[0]) {
                    deviceTable.GetPastPresentationTimingGOOGLE =
                        FunctionPtrToDelegate<Commands.GetPastPresentationTimingGOOGLE>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetViewportWScalingNV")[0]) {
                    deviceTable.CmdSetViewportWScalingNV =
                        FunctionPtrToDelegate<Commands.CmdSetViewportWScalingNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetDiscardRectangleEXT")[0]) {
                    deviceTable.CmdSetDiscardRectangleEXT =
                        FunctionPtrToDelegate<Commands.CmdSetDiscardRectangleEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetSampleLocationsEXT")[0]) {
                    deviceTable.CmdSetSampleLocationsEXT =
                        FunctionPtrToDelegate<Commands.CmdSetSampleLocationsEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetBufferMemoryRequirements2")[0]) {
                    deviceTable.GetBufferMemoryRequirements2 =
                        FunctionPtrToDelegate<Commands.GetBufferMemoryRequirements2>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetImageMemoryRequirements2")[0]) {
                    deviceTable.GetImageMemoryRequirements2 =
                        FunctionPtrToDelegate<Commands.GetImageMemoryRequirements2>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetImageSparseMemoryRequirements2")[0]) {
                    deviceTable.GetImageSparseMemoryRequirements2 =
                        FunctionPtrToDelegate<Commands.GetImageSparseMemoryRequirements2>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateSamplerYcbcrConversion")[0]) {
                    deviceTable.CreateSamplerYcbcrConversion =
                        FunctionPtrToDelegate<Commands.CreateSamplerYcbcrConversion>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroySamplerYcbcrConversion")[0]) {
                    deviceTable.DestroySamplerYcbcrConversion =
                        FunctionPtrToDelegate<Commands.DestroySamplerYcbcrConversion>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDeviceQueue2")[0]) {
                    deviceTable.GetDeviceQueue2 = FunctionPtrToDelegate<Commands.GetDeviceQueue2>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateValidationCacheEXT")[0]) {
                    deviceTable.CreateValidationCacheEXT =
                        FunctionPtrToDelegate<Commands.CreateValidationCacheEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyValidationCacheEXT")[0]) {
                    deviceTable.DestroyValidationCacheEXT =
                        FunctionPtrToDelegate<Commands.DestroyValidationCacheEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetValidationCacheDataEXT")[0]) {
                    deviceTable.GetValidationCacheDataEXT =
                        FunctionPtrToDelegate<Commands.GetValidationCacheDataEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkMergeValidationCachesEXT")[0]) {
                    deviceTable.MergeValidationCachesEXT =
                        FunctionPtrToDelegate<Commands.MergeValidationCachesEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDescriptorSetLayoutSupport")[0]) {
                    deviceTable.GetDescriptorSetLayoutSupport =
                        FunctionPtrToDelegate<Commands.GetDescriptorSetLayoutSupport>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetSwapchainGrallocUsageANDROID")[0]) {
                    deviceTable.GetSwapchainGrallocUsageANDROID =
                        FunctionPtrToDelegate<Commands.GetSwapchainGrallocUsageANDROID>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetSwapchainGrallocUsage2ANDROID")[0]) {
                    deviceTable.GetSwapchainGrallocUsage2ANDROID =
                        FunctionPtrToDelegate<Commands.GetSwapchainGrallocUsage2ANDROID>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkAcquireImageANDROID")[0]) {
                    deviceTable.AcquireImageANDROID =
                        FunctionPtrToDelegate<Commands.AcquireImageANDROID>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkQueueSignalReleaseImageANDROID")[0]) {
                    deviceTable.QueueSignalReleaseImageANDROID =
                        FunctionPtrToDelegate<Commands.QueueSignalReleaseImageANDROID>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetShaderInfoAMD")[0]) {
                    deviceTable.GetShaderInfoAMD = FunctionPtrToDelegate<Commands.GetShaderInfoAMD>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkSetLocalDimmingAMD")[0]) {
                    deviceTable.SetLocalDimmingAMD =
                        FunctionPtrToDelegate<Commands.SetLocalDimmingAMD>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetCalibratedTimestampsEXT")[0]) {
                    deviceTable.GetCalibratedTimestampsEXT =
                        FunctionPtrToDelegate<Commands.GetCalibratedTimestampsEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkSetDebugUtilsObjectNameEXT")[0]) {
                    deviceTable.SetDebugUtilsObjectNameEXT =
                        FunctionPtrToDelegate<Commands.SetDebugUtilsObjectNameEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkSetDebugUtilsObjectTagEXT")[0]) {
                    deviceTable.SetDebugUtilsObjectTagEXT =
                        FunctionPtrToDelegate<Commands.SetDebugUtilsObjectTagEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkQueueBeginDebugUtilsLabelEXT")[0]) {
                    deviceTable.QueueBeginDebugUtilsLabelEXT =
                        FunctionPtrToDelegate<Commands.QueueBeginDebugUtilsLabelEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkQueueEndDebugUtilsLabelEXT")[0]) {
                    deviceTable.QueueEndDebugUtilsLabelEXT =
                        FunctionPtrToDelegate<Commands.QueueEndDebugUtilsLabelEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkQueueInsertDebugUtilsLabelEXT")[0]) {
                    deviceTable.QueueInsertDebugUtilsLabelEXT =
                        FunctionPtrToDelegate<Commands.QueueInsertDebugUtilsLabelEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBeginDebugUtilsLabelEXT")[0]) {
                    deviceTable.CmdBeginDebugUtilsLabelEXT =
                        FunctionPtrToDelegate<Commands.CmdBeginDebugUtilsLabelEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdEndDebugUtilsLabelEXT")[0]) {
                    deviceTable.CmdEndDebugUtilsLabelEXT =
                        FunctionPtrToDelegate<Commands.CmdEndDebugUtilsLabelEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdInsertDebugUtilsLabelEXT")[0]) {
                    deviceTable.CmdInsertDebugUtilsLabelEXT =
                        FunctionPtrToDelegate<Commands.CmdInsertDebugUtilsLabelEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetMemoryHostPointerPropertiesEXT")[0]) {
                    deviceTable.GetMemoryHostPointerPropertiesEXT =
                        FunctionPtrToDelegate<Commands.GetMemoryHostPointerPropertiesEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdWriteBufferMarkerAMD")[0]) {
                    deviceTable.CmdWriteBufferMarkerAMD =
                        FunctionPtrToDelegate<Commands.CmdWriteBufferMarkerAMD>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateRenderPass2")[0]) {
                    deviceTable.CreateRenderPass2 =
                        FunctionPtrToDelegate<Commands.CreateRenderPass2>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBeginRenderPass2")[0]) {
                    deviceTable.CmdBeginRenderPass2 =
                        FunctionPtrToDelegate<Commands.CmdBeginRenderPass2>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdNextSubpass2")[0]) {
                    deviceTable.CmdNextSubpass2 = FunctionPtrToDelegate<Commands.CmdNextSubpass2>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdEndRenderPass2")[0]) {
                    deviceTable.CmdEndRenderPass2 =
                        FunctionPtrToDelegate<Commands.CmdEndRenderPass2>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetSemaphoreCounterValue")[0]) {
                    deviceTable.GetSemaphoreCounterValue =
                        FunctionPtrToDelegate<Commands.GetSemaphoreCounterValue>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkWaitSemaphores")[0]) {
                    deviceTable.WaitSemaphores = FunctionPtrToDelegate<Commands.WaitSemaphores>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkSignalSemaphore")[0]) {
                    deviceTable.SignalSemaphore = FunctionPtrToDelegate<Commands.SignalSemaphore>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetAndroidHardwareBufferPropertiesANDROID")[0]) {
                    deviceTable.GetAndroidHardwareBufferPropertiesANDROID =
                        FunctionPtrToDelegate<Commands.GetAndroidHardwareBufferPropertiesANDROID>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetMemoryAndroidHardwareBufferANDROID")[0]) {
                    deviceTable.GetMemoryAndroidHardwareBufferANDROID =
                        FunctionPtrToDelegate<Commands.GetMemoryAndroidHardwareBufferANDROID>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDrawIndirectCount")[0]) {
                    deviceTable.CmdDrawIndirectCount =
                        FunctionPtrToDelegate<Commands.CmdDrawIndirectCount>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDrawIndexedIndirectCount")[0]) {
                    deviceTable.CmdDrawIndexedIndirectCount =
                        FunctionPtrToDelegate<Commands.CmdDrawIndexedIndirectCount>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetCheckpointNV")[0]) {
                    deviceTable.CmdSetCheckpointNV =
                        FunctionPtrToDelegate<Commands.CmdSetCheckpointNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetQueueCheckpointDataNV")[0]) {
                    deviceTable.GetQueueCheckpointDataNV =
                        FunctionPtrToDelegate<Commands.GetQueueCheckpointDataNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBindTransformFeedbackBuffersEXT")[0]) {
                    deviceTable.CmdBindTransformFeedbackBuffersEXT =
                        FunctionPtrToDelegate<Commands.CmdBindTransformFeedbackBuffersEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBeginTransformFeedbackEXT")[0]) {
                    deviceTable.CmdBeginTransformFeedbackEXT =
                        FunctionPtrToDelegate<Commands.CmdBeginTransformFeedbackEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdEndTransformFeedbackEXT")[0]) {
                    deviceTable.CmdEndTransformFeedbackEXT =
                        FunctionPtrToDelegate<Commands.CmdEndTransformFeedbackEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBeginQueryIndexedEXT")[0]) {
                    deviceTable.CmdBeginQueryIndexedEXT =
                        FunctionPtrToDelegate<Commands.CmdBeginQueryIndexedEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdEndQueryIndexedEXT")[0]) {
                    deviceTable.CmdEndQueryIndexedEXT =
                        FunctionPtrToDelegate<Commands.CmdEndQueryIndexedEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDrawIndirectByteCountEXT")[0]) {
                    deviceTable.CmdDrawIndirectByteCountEXT =
                        FunctionPtrToDelegate<Commands.CmdDrawIndirectByteCountEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetExclusiveScissorNV")[0]) {
                    deviceTable.CmdSetExclusiveScissorNV =
                        FunctionPtrToDelegate<Commands.CmdSetExclusiveScissorNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBindShadingRateImageNV")[0]) {
                    deviceTable.CmdBindShadingRateImageNV =
                        FunctionPtrToDelegate<Commands.CmdBindShadingRateImageNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetViewportShadingRatePaletteNV")[0]) {
                    deviceTable.CmdSetViewportShadingRatePaletteNV =
                        FunctionPtrToDelegate<Commands.CmdSetViewportShadingRatePaletteNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetCoarseSampleOrderNV")[0]) {
                    deviceTable.CmdSetCoarseSampleOrderNV =
                        FunctionPtrToDelegate<Commands.CmdSetCoarseSampleOrderNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDrawMeshTasksNV")[0]) {
                    deviceTable.CmdDrawMeshTasksNV =
                        FunctionPtrToDelegate<Commands.CmdDrawMeshTasksNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDrawMeshTasksIndirectNV")[0]) {
                    deviceTable.CmdDrawMeshTasksIndirectNV =
                        FunctionPtrToDelegate<Commands.CmdDrawMeshTasksIndirectNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdDrawMeshTasksIndirectCountNV")[0]) {
                    deviceTable.CmdDrawMeshTasksIndirectCountNV =
                        FunctionPtrToDelegate<Commands.CmdDrawMeshTasksIndirectCountNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCompileDeferredNV")[0]) {
                    deviceTable.CompileDeferredNV =
                        FunctionPtrToDelegate<Commands.CompileDeferredNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateAccelerationStructureNV")[0]) {
                    deviceTable.CreateAccelerationStructureNV =
                        FunctionPtrToDelegate<Commands.CreateAccelerationStructureNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyAccelerationStructureKHR")[0]) {
                    deviceTable.DestroyAccelerationStructureKHR =
                        FunctionPtrToDelegate<Commands.DestroyAccelerationStructureKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetAccelerationStructureMemoryRequirementsKHR")[0]) {
                    deviceTable.GetAccelerationStructureMemoryRequirementsKHR =
                        FunctionPtrToDelegate<Commands.GetAccelerationStructureMemoryRequirementsKHR>(
                            CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetAccelerationStructureMemoryRequirementsNV")[0]) {
                    deviceTable.GetAccelerationStructureMemoryRequirementsNV =
                        FunctionPtrToDelegate<Commands.GetAccelerationStructureMemoryRequirementsNV>(
                            CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkBindAccelerationStructureMemoryKHR")[0]) {
                    deviceTable.BindAccelerationStructureMemoryKHR =
                        FunctionPtrToDelegate<Commands.BindAccelerationStructureMemoryKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdCopyAccelerationStructureNV")[0]) {
                    deviceTable.CmdCopyAccelerationStructureNV =
                        FunctionPtrToDelegate<Commands.CmdCopyAccelerationStructureNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdCopyAccelerationStructureKHR")[0]) {
                    deviceTable.CmdCopyAccelerationStructureKHR =
                        FunctionPtrToDelegate<Commands.CmdCopyAccelerationStructureKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCopyAccelerationStructureKHR")[0]) {
                    deviceTable.CopyAccelerationStructureKHR =
                        FunctionPtrToDelegate<Commands.CopyAccelerationStructureKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdCopyAccelerationStructureToMemoryKHR")[0]) {
                    deviceTable.CmdCopyAccelerationStructureToMemoryKHR =
                        FunctionPtrToDelegate<Commands.CmdCopyAccelerationStructureToMemoryKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCopyAccelerationStructureToMemoryKHR")[0]) {
                    deviceTable.CopyAccelerationStructureToMemoryKHR =
                        FunctionPtrToDelegate<Commands.CopyAccelerationStructureToMemoryKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdCopyMemoryToAccelerationStructureKHR")[0]) {
                    deviceTable.CmdCopyMemoryToAccelerationStructureKHR =
                        FunctionPtrToDelegate<Commands.CmdCopyMemoryToAccelerationStructureKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCopyMemoryToAccelerationStructureKHR")[0]) {
                    deviceTable.CopyMemoryToAccelerationStructureKHR =
                        FunctionPtrToDelegate<Commands.CopyMemoryToAccelerationStructureKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdWriteAccelerationStructuresPropertiesKHR")[0]) {
                    deviceTable.CmdWriteAccelerationStructuresPropertiesKHR =
                        FunctionPtrToDelegate<Commands.CmdWriteAccelerationStructuresPropertiesKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBuildAccelerationStructureNV")[0]) {
                    deviceTable.CmdBuildAccelerationStructureNV =
                        FunctionPtrToDelegate<Commands.CmdBuildAccelerationStructureNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkWriteAccelerationStructuresPropertiesKHR")[0]) {
                    deviceTable.WriteAccelerationStructuresPropertiesKHR =
                        FunctionPtrToDelegate<Commands.WriteAccelerationStructuresPropertiesKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdTraceRaysKHR")[0]) {
                    deviceTable.CmdTraceRaysKHR = FunctionPtrToDelegate<Commands.CmdTraceRaysKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdTraceRaysNV")[0]) {
                    deviceTable.CmdTraceRaysNV = FunctionPtrToDelegate<Commands.CmdTraceRaysNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetRayTracingShaderGroupHandlesKHR")[0]) {
                    deviceTable.GetRayTracingShaderGroupHandlesKHR =
                        FunctionPtrToDelegate<Commands.GetRayTracingShaderGroupHandlesKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetRayTracingCaptureReplayShaderGroupHandlesKHR")[0]) {
                    deviceTable.GetRayTracingCaptureReplayShaderGroupHandlesKHR =
                        FunctionPtrToDelegate<Commands.GetRayTracingCaptureReplayShaderGroupHandlesKHR>(
                            CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetAccelerationStructureHandleNV")[0]) {
                    deviceTable.GetAccelerationStructureHandleNV =
                        FunctionPtrToDelegate<Commands.GetAccelerationStructureHandleNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateRayTracingPipelinesNV")[0]) {
                    deviceTable.CreateRayTracingPipelinesNV =
                        FunctionPtrToDelegate<Commands.CreateRayTracingPipelinesNV>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateRayTracingPipelinesKHR")[0]) {
                    deviceTable.CreateRayTracingPipelinesKHR =
                        FunctionPtrToDelegate<Commands.CreateRayTracingPipelinesKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdTraceRaysIndirectKHR")[0]) {
                    deviceTable.CmdTraceRaysIndirectKHR =
                        FunctionPtrToDelegate<Commands.CmdTraceRaysIndirectKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDeviceAccelerationStructureCompatibilityKHR")[0]) {
                    deviceTable.GetDeviceAccelerationStructureCompatibilityKHR =
                        FunctionPtrToDelegate<Commands.GetDeviceAccelerationStructureCompatibilityKHR>(
                            CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetImageViewHandleNVX")[0]) {
                    deviceTable.GetImageViewHandleNVX =
                        FunctionPtrToDelegate<Commands.GetImageViewHandleNVX>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetImageViewAddressNVX")[0]) {
                    deviceTable.GetImageViewAddressNVX =
                        FunctionPtrToDelegate<Commands.GetImageViewAddressNVX>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDeviceGroupSurfacePresentModes2EXT")[0]) {
                    deviceTable.GetDeviceGroupSurfacePresentModes2EXT =
                        FunctionPtrToDelegate<Commands.GetDeviceGroupSurfacePresentModes2EXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkAcquireFullScreenExclusiveModeEXT")[0]) {
                    deviceTable.AcquireFullScreenExclusiveModeEXT =
                        FunctionPtrToDelegate<Commands.AcquireFullScreenExclusiveModeEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkReleaseFullScreenExclusiveModeEXT")[0]) {
                    deviceTable.ReleaseFullScreenExclusiveModeEXT =
                        FunctionPtrToDelegate<Commands.ReleaseFullScreenExclusiveModeEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkAcquireProfilingLockKHR")[0]) {
                    deviceTable.AcquireProfilingLockKHR =
                        FunctionPtrToDelegate<Commands.AcquireProfilingLockKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkReleaseProfilingLockKHR")[0]) {
                    deviceTable.ReleaseProfilingLockKHR =
                        FunctionPtrToDelegate<Commands.ReleaseProfilingLockKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetImageDrmFormatModifierPropertiesEXT")[0]) {
                    deviceTable.GetImageDrmFormatModifierPropertiesEXT =
                        FunctionPtrToDelegate<Commands.GetImageDrmFormatModifierPropertiesEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetBufferOpaqueCaptureAddress")[0]) {
                    deviceTable.GetBufferOpaqueCaptureAddress =
                        FunctionPtrToDelegate<Commands.GetBufferOpaqueCaptureAddress>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetBufferDeviceAddress")[0]) {
                    deviceTable.GetBufferDeviceAddress =
                        FunctionPtrToDelegate<Commands.GetBufferDeviceAddress>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkInitializePerformanceApiINTEL")[0]) {
                    deviceTable.InitializePerformanceApiINTEL =
                        FunctionPtrToDelegate<Commands.InitializePerformanceApiINTEL>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkUninitializePerformanceApiINTEL")[0]) {
                    deviceTable.UninitializePerformanceApiINTEL =
                        FunctionPtrToDelegate<Commands.UninitializePerformanceApiINTEL>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetPerformanceMarkerINTEL")[0]) {
                    deviceTable.CmdSetPerformanceMarkerINTEL =
                        FunctionPtrToDelegate<Commands.CmdSetPerformanceMarkerINTEL>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetPerformanceStreamMarkerINTEL")[0]) {
                    deviceTable.CmdSetPerformanceStreamMarkerINTEL =
                        FunctionPtrToDelegate<Commands.CmdSetPerformanceStreamMarkerINTEL>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetPerformanceOverrideINTEL")[0]) {
                    deviceTable.CmdSetPerformanceOverrideINTEL =
                        FunctionPtrToDelegate<Commands.CmdSetPerformanceOverrideINTEL>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkAcquirePerformanceConfigurationINTEL")[0]) {
                    deviceTable.AcquirePerformanceConfigurationINTEL =
                        FunctionPtrToDelegate<Commands.AcquirePerformanceConfigurationINTEL>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkReleasePerformanceConfigurationINTEL")[0]) {
                    deviceTable.ReleasePerformanceConfigurationINTEL =
                        FunctionPtrToDelegate<Commands.ReleasePerformanceConfigurationINTEL>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkQueueSetPerformanceConfigurationINTEL")[0]) {
                    deviceTable.QueueSetPerformanceConfigurationINTEL =
                        FunctionPtrToDelegate<Commands.QueueSetPerformanceConfigurationINTEL>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPerformanceParameterINTEL")[0]) {
                    deviceTable.GetPerformanceParameterINTEL =
                        FunctionPtrToDelegate<Commands.GetPerformanceParameterINTEL>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDeviceMemoryOpaqueCaptureAddress")[0]) {
                    deviceTable.GetDeviceMemoryOpaqueCaptureAddress =
                        FunctionPtrToDelegate<Commands.GetDeviceMemoryOpaqueCaptureAddress>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPipelineExecutablePropertiesKHR")[0]) {
                    deviceTable.GetPipelineExecutablePropertiesKHR =
                        FunctionPtrToDelegate<Commands.GetPipelineExecutablePropertiesKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPipelineExecutableStatisticsKHR")[0]) {
                    deviceTable.GetPipelineExecutableStatisticsKHR =
                        FunctionPtrToDelegate<Commands.GetPipelineExecutableStatisticsKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPipelineExecutableInternalRepresentationsKHR")[0]) {
                    deviceTable.GetPipelineExecutableInternalRepresentationsKHR =
                        FunctionPtrToDelegate<Commands.GetPipelineExecutableInternalRepresentationsKHR>(
                            CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetLineStippleEXT")[0]) {
                    deviceTable.CmdSetLineStippleEXT =
                        FunctionPtrToDelegate<Commands.CmdSetLineStippleEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateAccelerationStructureKHR")[0]) {
                    deviceTable.CreateAccelerationStructureKHR =
                        FunctionPtrToDelegate<Commands.CreateAccelerationStructureKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBuildAccelerationStructureKHR")[0]) {
                    deviceTable.CmdBuildAccelerationStructureKHR =
                        FunctionPtrToDelegate<Commands.CmdBuildAccelerationStructureKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBuildAccelerationStructureIndirectKHR")[0]) {
                    deviceTable.CmdBuildAccelerationStructureIndirectKHR =
                        FunctionPtrToDelegate<Commands.CmdBuildAccelerationStructureIndirectKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkBuildAccelerationStructureKHR")[0]) {
                    deviceTable.BuildAccelerationStructureKHR =
                        FunctionPtrToDelegate<Commands.BuildAccelerationStructureKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetAccelerationStructureDeviceAddressKHR")[0]) {
                    deviceTable.GetAccelerationStructureDeviceAddressKHR =
                        FunctionPtrToDelegate<Commands.GetAccelerationStructureDeviceAddressKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreateDeferredOperationKHR")[0]) {
                    deviceTable.CreateDeferredOperationKHR =
                        FunctionPtrToDelegate<Commands.CreateDeferredOperationKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyDeferredOperationKHR")[0]) {
                    deviceTable.DestroyDeferredOperationKHR =
                        FunctionPtrToDelegate<Commands.DestroyDeferredOperationKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDeferredOperationMaxConcurrencyKHR")[0]) {
                    deviceTable.GetDeferredOperationMaxConcurrencyKHR =
                        FunctionPtrToDelegate<Commands.GetDeferredOperationMaxConcurrencyKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetDeferredOperationResultKHR")[0]) {
                    deviceTable.GetDeferredOperationResultKHR =
                        FunctionPtrToDelegate<Commands.GetDeferredOperationResultKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDeferredOperationJoinKHR")[0]) {
                    deviceTable.DeferredOperationJoinKHR =
                        FunctionPtrToDelegate<Commands.DeferredOperationJoinKHR>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetCullModeEXT")[0]) {
                    deviceTable.CmdSetCullModeEXT =
                        FunctionPtrToDelegate<Commands.CmdSetCullModeEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetFrontFaceEXT")[0]) {
                    deviceTable.CmdSetFrontFaceEXT =
                        FunctionPtrToDelegate<Commands.CmdSetFrontFaceEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetPrimitiveTopologyEXT")[0]) {
                    deviceTable.CmdSetPrimitiveTopologyEXT =
                        FunctionPtrToDelegate<Commands.CmdSetPrimitiveTopologyEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetViewportWithCountEXT")[0]) {
                    deviceTable.CmdSetViewportWithCountEXT =
                        FunctionPtrToDelegate<Commands.CmdSetViewportWithCountEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetScissorWithCountEXT")[0]) {
                    deviceTable.CmdSetScissorWithCountEXT =
                        FunctionPtrToDelegate<Commands.CmdSetScissorWithCountEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdBindVertexBuffers2EXT")[0]) {
                    deviceTable.CmdBindVertexBuffers2EXT =
                        FunctionPtrToDelegate<Commands.CmdBindVertexBuffers2EXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetDepthTestEnableEXT")[0]) {
                    deviceTable.CmdSetDepthTestEnableEXT =
                        FunctionPtrToDelegate<Commands.CmdSetDepthTestEnableEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetDepthWriteEnableEXT")[0]) {
                    deviceTable.CmdSetDepthWriteEnableEXT =
                        FunctionPtrToDelegate<Commands.CmdSetDepthWriteEnableEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetDepthCompareOpEXT")[0]) {
                    deviceTable.CmdSetDepthCompareOpEXT =
                        FunctionPtrToDelegate<Commands.CmdSetDepthCompareOpEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetDepthBoundsTestEnableEXT")[0]) {
                    deviceTable.CmdSetDepthBoundsTestEnableEXT =
                        FunctionPtrToDelegate<Commands.CmdSetDepthBoundsTestEnableEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetStencilTestEnableEXT")[0]) {
                    deviceTable.CmdSetStencilTestEnableEXT =
                        FunctionPtrToDelegate<Commands.CmdSetStencilTestEnableEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCmdSetStencilOpEXT")[0]) {
                    deviceTable.CmdSetStencilOpEXT =
                        FunctionPtrToDelegate<Commands.CmdSetStencilOpEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkCreatePrivateDataSlotEXT")[0]) {
                    deviceTable.CreatePrivateDataSlotEXT =
                        FunctionPtrToDelegate<Commands.CreatePrivateDataSlotEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkDestroyPrivateDataSlotEXT")[0]) {
                    deviceTable.DestroyPrivateDataSlotEXT =
                        FunctionPtrToDelegate<Commands.DestroyPrivateDataSlotEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkSetPrivateDataEXT")[0]) {
                    deviceTable.SetPrivateDataEXT =
                        FunctionPtrToDelegate<Commands.SetPrivateDataEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }

                fixed (byte* funcName = &Encoding.UTF8.GetBytes("vkGetPrivateDataEXT")[0]) {
                    deviceTable.GetPrivateDataEXT =
                        FunctionPtrToDelegate<Commands.GetPrivateDataEXT>(CommandTable.GetDeviceProcAddr(device, funcName));
                }
            }

            return deviceTable;
        }
    }
}