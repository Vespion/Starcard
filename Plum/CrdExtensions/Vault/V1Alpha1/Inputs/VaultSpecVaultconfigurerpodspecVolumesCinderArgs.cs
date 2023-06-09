// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1
{

    public class VaultSpecVaultconfigurerpodspecVolumesCinderArgs : global::Pulumi.ResourceArgs
    {
        [Input("fsType")]
        public Input<string>? FsType { get; set; }

        [Input("readOnly")]
        public Input<bool>? ReadOnly { get; set; }

        [Input("secretRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecVolumesCinderSecretrefArgs>? SecretRef { get; set; }

        [Input("volumeID", required: true)]
        public Input<string> VolumeID { get; set; } = null!;

        public VaultSpecVaultconfigurerpodspecVolumesCinderArgs()
        {
        }
        public static new VaultSpecVaultconfigurerpodspecVolumesCinderArgs Empty => new VaultSpecVaultconfigurerpodspecVolumesCinderArgs();
    }
}
