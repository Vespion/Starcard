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
    public sealed class VaultSpecIngressSpecRulesHttpPathsBackendServicePort
    {
        public readonly string Name;
        public readonly int Number;

        [OutputConstructor]
        private VaultSpecIngressSpecRulesHttpPathsBackendServicePort(
            string name,

            int number)
        {
            Name = name;
            Number = number;
        }
    }
}
