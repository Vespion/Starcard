// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Postgresql.V1
{

    /// <summary>
    /// vsphereVolume represents a vSphere volume attached and mounted on kubelets host machine
    /// </summary>
    [OutputType]
    public sealed class PoolerSpecTemplateSpecVolumesVspherevolume
    {
        /// <summary>
        /// fsType is filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.
        /// </summary>
        public readonly string FsType;
        /// <summary>
        /// storagePolicyID is the storage Policy Based Management (SPBM) profile ID associated with the StoragePolicyName.
        /// </summary>
        public readonly string StoragePolicyID;
        /// <summary>
        /// storagePolicyName is the storage Policy Based Management (SPBM) profile name.
        /// </summary>
        public readonly string StoragePolicyName;
        /// <summary>
        /// volumePath is the path that identifies vSphere volume vmdk
        /// </summary>
        public readonly string VolumePath;

        [OutputConstructor]
        private PoolerSpecTemplateSpecVolumesVspherevolume(
            string fsType,

            string storagePolicyID,

            string storagePolicyName,

            string volumePath)
        {
            FsType = fsType;
            StoragePolicyID = storagePolicyID;
            StoragePolicyName = storagePolicyName;
            VolumePath = volumePath;
        }
    }
}