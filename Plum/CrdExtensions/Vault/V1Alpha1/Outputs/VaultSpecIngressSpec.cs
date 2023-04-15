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
    public sealed class VaultSpecIngressSpec
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecIngressSpecDefaultbackend DefaultBackend;
        public readonly string IngressClassName;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecIngressSpecRules> Rules;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecIngressSpecTls> Tls;

        [OutputConstructor]
        private VaultSpecIngressSpec(
            Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecIngressSpecDefaultbackend defaultBackend,

            string ingressClassName,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecIngressSpecRules> rules,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecIngressSpecTls> tls)
        {
            DefaultBackend = defaultBackend;
            IngressClassName = ingressClassName;
            Rules = rules;
            Tls = tls;
        }
    }
}
