// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1
{

    public class VaultSpecIngressSpecRulesHttpPathsBackendArgs : global::Pulumi.ResourceArgs
    {
        [Input("resource")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecIngressSpecRulesHttpPathsBackendResourceArgs>? Resource { get; set; }

        [Input("service")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecIngressSpecRulesHttpPathsBackendServiceArgs>? Service { get; set; }

        public VaultSpecIngressSpecRulesHttpPathsBackendArgs()
        {
        }
        public static new VaultSpecIngressSpecRulesHttpPathsBackendArgs Empty => new VaultSpecIngressSpecRulesHttpPathsBackendArgs();
    }
}
