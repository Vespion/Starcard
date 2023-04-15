// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1
{

    public class VaultSpecVaultconfigurerpodspecVolumesSecretArgs : global::Pulumi.ResourceArgs
    {
        [Input("defaultMode")]
        public Input<int>? DefaultMode { get; set; }

        [Input("items")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecVolumesSecretItemsArgs>? _items;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecVolumesSecretItemsArgs> Items
        {
            get => _items ?? (_items = new InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecVolumesSecretItemsArgs>());
            set => _items = value;
        }

        [Input("optional")]
        public Input<bool>? Optional { get; set; }

        [Input("secretName")]
        public Input<string>? SecretName { get; set; }

        public VaultSpecVaultconfigurerpodspecVolumesSecretArgs()
        {
        }
        public static new VaultSpecVaultconfigurerpodspecVolumesSecretArgs Empty => new VaultSpecVaultconfigurerpodspecVolumesSecretArgs();
    }
}
