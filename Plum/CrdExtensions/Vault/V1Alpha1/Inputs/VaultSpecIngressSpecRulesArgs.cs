// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1
{

    public class VaultSpecIngressSpecRulesArgs : global::Pulumi.ResourceArgs
    {
        [Input("host")]
        public Input<string>? Host { get; set; }

        [Input("http")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecIngressSpecRulesHttpArgs>? Http { get; set; }

        public VaultSpecIngressSpecRulesArgs()
        {
        }
        public static new VaultSpecIngressSpecRulesArgs Empty => new VaultSpecIngressSpecRulesArgs();
    }
}