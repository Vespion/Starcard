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
    public sealed class VaultSpecVaultconfigurerpodspecVolumesEphemeralVolumeclaimtemplateSpecResources
    {
        public readonly ImmutableDictionary<string, Union<int, string>> Limits;
        public readonly ImmutableDictionary<string, Union<int, string>> Requests;

        [OutputConstructor]
        private VaultSpecVaultconfigurerpodspecVolumesEphemeralVolumeclaimtemplateSpecResources(
            ImmutableDictionary<string, Union<int, string>> limits,

            ImmutableDictionary<string, Union<int, string>> requests)
        {
            Limits = limits;
            Requests = requests;
        }
    }
}
