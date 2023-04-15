// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1
{

    public class VaultSpecIngressSpecArgs : global::Pulumi.ResourceArgs
    {
        [Input("defaultBackend")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecIngressSpecDefaultbackendArgs>? DefaultBackend { get; set; }

        [Input("ingressClassName")]
        public Input<string>? IngressClassName { get; set; }

        [Input("rules")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecIngressSpecRulesArgs>? _rules;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecIngressSpecRulesArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecIngressSpecRulesArgs>());
            set => _rules = value;
        }

        [Input("tls")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecIngressSpecTlsArgs>? _tls;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecIngressSpecTlsArgs> Tls
        {
            get => _tls ?? (_tls = new InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecIngressSpecTlsArgs>());
            set => _tls = value;
        }

        public VaultSpecIngressSpecArgs()
        {
        }
        public static new VaultSpecIngressSpecArgs Empty => new VaultSpecIngressSpecArgs();
    }
}
