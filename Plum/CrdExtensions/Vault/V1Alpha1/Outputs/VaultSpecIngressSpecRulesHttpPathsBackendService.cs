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
    public sealed class VaultSpecIngressSpecRulesHttpPathsBackendService
    {
        public readonly string Name;
        public readonly Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecIngressSpecRulesHttpPathsBackendServicePort Port;

        [OutputConstructor]
        private VaultSpecIngressSpecRulesHttpPathsBackendService(
            string name,

            Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecIngressSpecRulesHttpPathsBackendServicePort port)
        {
            Name = name;
            Port = port;
        }
    }
}
