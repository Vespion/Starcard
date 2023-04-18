// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Postgresql.V1
{

    /// <summary>
    /// scaleIO represents a ScaleIO persistent volume attached and mounted on Kubernetes nodes.
    /// </summary>
    public class PoolerSpecTemplateSpecVolumesScaleioArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// fsType is the filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Default is "xfs".
        /// </summary>
        [Input("fsType")]
        public Input<string>? FsType { get; set; }

        /// <summary>
        /// gateway is the host address of the ScaleIO API Gateway.
        /// </summary>
        [Input("gateway", required: true)]
        public Input<string> Gateway { get; set; } = null!;

        /// <summary>
        /// protectionDomain is the name of the ScaleIO Protection Domain for the configured storage.
        /// </summary>
        [Input("protectionDomain")]
        public Input<string>? ProtectionDomain { get; set; }

        /// <summary>
        /// readOnly Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
        /// </summary>
        [Input("readOnly")]
        public Input<bool>? ReadOnly { get; set; }

        /// <summary>
        /// secretRef references to the secret for ScaleIO user and other sensitive information. If this is not provided, Login operation will fail.
        /// </summary>
        [Input("secretRef", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateSpecVolumesScaleioSecretrefArgs> SecretRef { get; set; } = null!;

        /// <summary>
        /// sslEnabled Flag enable/disable SSL communication with Gateway, default false
        /// </summary>
        [Input("sslEnabled")]
        public Input<bool>? SslEnabled { get; set; }

        /// <summary>
        /// storageMode indicates whether the storage for a volume should be ThickProvisioned or ThinProvisioned. Default is ThinProvisioned.
        /// </summary>
        [Input("storageMode")]
        public Input<string>? StorageMode { get; set; }

        /// <summary>
        /// storagePool is the ScaleIO Storage Pool associated with the protection domain.
        /// </summary>
        [Input("storagePool")]
        public Input<string>? StoragePool { get; set; }

        /// <summary>
        /// system is the name of the storage system as configured in ScaleIO.
        /// </summary>
        [Input("system", required: true)]
        public Input<string> System { get; set; } = null!;

        /// <summary>
        /// volumeName is the name of a volume already created in the ScaleIO system that is associated with this volume source.
        /// </summary>
        [Input("volumeName")]
        public Input<string>? VolumeName { get; set; }

        public PoolerSpecTemplateSpecVolumesScaleioArgs()
        {
        }
        public static new PoolerSpecTemplateSpecVolumesScaleioArgs Empty => new PoolerSpecTemplateSpecVolumesScaleioArgs();
    }
}
