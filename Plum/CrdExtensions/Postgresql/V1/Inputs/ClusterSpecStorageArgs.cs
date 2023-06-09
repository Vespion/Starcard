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
    /// Configuration of the storage of the instances
    /// </summary>
    public class ClusterSpecStorageArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Template to be used to generate the Persistent Volume Claim
        /// </summary>
        [Input("pvcTemplate")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.ClusterSpecStoragePvctemplateArgs>? PvcTemplate { get; set; }

        /// <summary>
        /// Resize existent PVCs, defaults to true
        /// </summary>
        [Input("resizeInUseVolumes")]
        public Input<bool>? ResizeInUseVolumes { get; set; }

        /// <summary>
        /// Size of the storage. Required if not already specified in the PVC template. Changes to this field are automatically reapplied to the created PVCs. Size cannot be decreased.
        /// </summary>
        [Input("size")]
        public Input<string>? Size { get; set; }

        /// <summary>
        /// StorageClass to use for database data (`PGDATA`). Applied after evaluating the PVC template, if available. If not specified, generated PVCs will be satisfied by the default storage class
        /// </summary>
        [Input("storageClass")]
        public Input<string>? StorageClass { get; set; }

        public ClusterSpecStorageArgs()
        {
            ResizeInUseVolumes = true;
        }
        public static new ClusterSpecStorageArgs Empty => new ClusterSpecStorageArgs();
    }
}
