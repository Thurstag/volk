// Copyright 2020-2020 Volk Project
// Licensed under Apache License 2.0 or any later version
// Refer to the LICENSE.md file included.

namespace Volk.Vulkan {
    /// <summary>
    ///     Utility class for vulkan
    /// </summary>
    public static class Utilities {
        /// <summary>
        ///     Generate a version supported by vulkan
        /// </summary>
        /// <param name="major">Major version</param>
        /// <param name="minor">Minor version</param>
        /// <param name="patch">Path version</param>
        /// <returns>Version</returns>
        public static uint MakeVersion(uint major, uint minor, uint patch) {
            return (major << 22) | (minor << 12) | patch;
        }

        /// <summary>
        ///     Extract major version from a version generated by <see cref="MakeVersion" />
        /// </summary>
        /// <param name="version">Version</param>
        /// <returns>Major version</returns>
        public static uint VersionMajor(uint version) {
            return version >> 22;
        }

        /// <summary>
        ///     Extract minor version from a version generated by <see cref="MakeVersion" />
        /// </summary>
        /// <param name="version">Version</param>
        /// <returns>Minor version</returns>
        public static uint VersionMinor(uint version) {
            return (version >> 12) & 0x3ff;
        }

        /// <summary>
        ///     Extract patch version from a version generated by <see cref="MakeVersion" />
        /// </summary>
        /// <param name="version">Version</param>
        /// <returns>Patch version</returns>
        public static uint VersionPatch(uint version) {
            return version & 0xfff;
        }

        /// <summary>
        ///     Generate string representation of a vulkan version
        /// </summary>
        /// <param name="version">Version generated by <see cref="MakeVersion" /></param>
        /// <returns>String</returns>
        public static string VersionToString(uint version) {
            return $"{VersionMajor(version)}.{VersionMinor(version)}.{VersionPatch(version)}";
        }
    }
}