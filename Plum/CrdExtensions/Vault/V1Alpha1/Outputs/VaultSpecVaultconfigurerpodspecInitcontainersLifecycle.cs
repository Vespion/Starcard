// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1
{

    [OutputType]
    public sealed class VaultSpecVaultconfigurerpodspecInitcontainersLifecycle
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecInitcontainersLifecyclePoststart PostStart;
        public readonly Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecInitcontainersLifecyclePrestop PreStop;

        [OutputConstructor]
        private VaultSpecVaultconfigurerpodspecInitcontainersLifecycle(
            Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecInitcontainersLifecyclePoststart postStart,

            Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecInitcontainersLifecyclePrestop preStop)
        {
            PostStart = postStart;
            PreStop = preStop;
        }
    }
}