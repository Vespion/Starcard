// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1
{

    public class VaultSpecVaultconfigurerpodspecInitcontainersEnvValuefromArgs : global::Pulumi.ResourceArgs
    {
        [Input("configMapKeyRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecInitcontainersEnvValuefromConfigmapkeyrefArgs>? ConfigMapKeyRef { get; set; }

        [Input("fieldRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecInitcontainersEnvValuefromFieldrefArgs>? FieldRef { get; set; }

        [Input("resourceFieldRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecInitcontainersEnvValuefromResourcefieldrefArgs>? ResourceFieldRef { get; set; }

        [Input("secretKeyRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecInitcontainersEnvValuefromSecretkeyrefArgs>? SecretKeyRef { get; set; }

        public VaultSpecVaultconfigurerpodspecInitcontainersEnvValuefromArgs()
        {
        }
        public static new VaultSpecVaultconfigurerpodspecInitcontainersEnvValuefromArgs Empty => new VaultSpecVaultconfigurerpodspecInitcontainersEnvValuefromArgs();
    }
}
