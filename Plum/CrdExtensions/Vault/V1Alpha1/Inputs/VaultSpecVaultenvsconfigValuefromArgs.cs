// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1
{

    public class VaultSpecVaultenvsconfigValuefromArgs : global::Pulumi.ResourceArgs
    {
        [Input("configMapKeyRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultenvsconfigValuefromConfigmapkeyrefArgs>? ConfigMapKeyRef { get; set; }

        [Input("fieldRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultenvsconfigValuefromFieldrefArgs>? FieldRef { get; set; }

        [Input("resourceFieldRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultenvsconfigValuefromResourcefieldrefArgs>? ResourceFieldRef { get; set; }

        [Input("secretKeyRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultenvsconfigValuefromSecretkeyrefArgs>? SecretKeyRef { get; set; }

        public VaultSpecVaultenvsconfigValuefromArgs()
        {
        }
        public static new VaultSpecVaultenvsconfigValuefromArgs Empty => new VaultSpecVaultenvsconfigValuefromArgs();
    }
}
