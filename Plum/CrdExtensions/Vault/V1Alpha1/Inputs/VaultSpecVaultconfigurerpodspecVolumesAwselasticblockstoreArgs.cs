// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1
{

    public class VaultSpecVaultconfigurerpodspecVolumesAwselasticblockstoreArgs : global::Pulumi.ResourceArgs
    {
        [Input("fsType")]
        public Input<string>? FsType { get; set; }

        [Input("partition")]
        public Input<int>? Partition { get; set; }

        [Input("readOnly")]
        public Input<bool>? ReadOnly { get; set; }

        [Input("volumeID", required: true)]
        public Input<string> VolumeID { get; set; } = null!;

        public VaultSpecVaultconfigurerpodspecVolumesAwselasticblockstoreArgs()
        {
        }
        public static new VaultSpecVaultconfigurerpodspecVolumesAwselasticblockstoreArgs Empty => new VaultSpecVaultconfigurerpodspecVolumesAwselasticblockstoreArgs();
    }
}
