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
    public sealed class VaultSpecVaultpodspecVolumesEphemeralVolumeclaimtemplate
    {
        public readonly ImmutableDictionary<string, object> Metadata;
        public readonly Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecVolumesEphemeralVolumeclaimtemplateSpec Spec;

        [OutputConstructor]
        private VaultSpecVaultpodspecVolumesEphemeralVolumeclaimtemplate(
            ImmutableDictionary<string, object> metadata,

            Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecVolumesEphemeralVolumeclaimtemplateSpec spec)
        {
            Metadata = metadata;
            Spec = spec;
        }
    }
}
