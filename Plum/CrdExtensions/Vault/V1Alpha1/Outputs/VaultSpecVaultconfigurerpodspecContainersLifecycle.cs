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
    public sealed class VaultSpecVaultconfigurerpodspecContainersLifecycle
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecContainersLifecyclePoststart PostStart;
        public readonly Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecContainersLifecyclePrestop PreStop;

        [OutputConstructor]
        private VaultSpecVaultconfigurerpodspecContainersLifecycle(
            Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecContainersLifecyclePoststart postStart,

            Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecContainersLifecyclePrestop preStop)
        {
            PostStart = postStart;
            PreStop = preStop;
        }
    }
}
