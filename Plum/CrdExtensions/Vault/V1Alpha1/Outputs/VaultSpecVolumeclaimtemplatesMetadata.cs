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
    public sealed class VaultSpecVolumeclaimtemplatesMetadata
    {
        public readonly ImmutableDictionary<string, string> Annotations;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly string Name;

        [OutputConstructor]
        private VaultSpecVolumeclaimtemplatesMetadata(
            ImmutableDictionary<string, string> annotations,

            ImmutableDictionary<string, string> labels,

            string name)
        {
            Annotations = annotations;
            Labels = labels;
            Name = name;
        }
    }
}
