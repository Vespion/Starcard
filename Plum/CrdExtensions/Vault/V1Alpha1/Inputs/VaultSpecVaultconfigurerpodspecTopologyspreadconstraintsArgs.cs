// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1
{

    public class VaultSpecVaultconfigurerpodspecTopologyspreadconstraintsArgs : global::Pulumi.ResourceArgs
    {
        [Input("labelSelector")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecTopologyspreadconstraintsLabelselectorArgs>? LabelSelector { get; set; }

        [Input("maxSkew", required: true)]
        public Input<int> MaxSkew { get; set; } = null!;

        [Input("topologyKey", required: true)]
        public Input<string> TopologyKey { get; set; } = null!;

        [Input("whenUnsatisfiable", required: true)]
        public Input<string> WhenUnsatisfiable { get; set; } = null!;

        public VaultSpecVaultconfigurerpodspecTopologyspreadconstraintsArgs()
        {
        }
        public static new VaultSpecVaultconfigurerpodspecTopologyspreadconstraintsArgs Empty => new VaultSpecVaultconfigurerpodspecTopologyspreadconstraintsArgs();
    }
}
