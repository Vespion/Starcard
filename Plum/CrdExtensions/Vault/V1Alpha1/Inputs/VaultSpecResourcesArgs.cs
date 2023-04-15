// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1
{

    public class VaultSpecResourcesArgs : global::Pulumi.ResourceArgs
    {
        [Input("bankVaults")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecResourcesBankvaultsArgs>? BankVaults { get; set; }

        [Input("fluentd")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecResourcesFluentdArgs>? Fluentd { get; set; }

        [Input("hsmDaemon")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecResourcesHsmdaemonArgs>? HsmDaemon { get; set; }

        [Input("prometheusExporter")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecResourcesPrometheusexporterArgs>? PrometheusExporter { get; set; }

        [Input("vault")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecResourcesVaultArgs>? Vault { get; set; }

        public VaultSpecResourcesArgs()
        {
        }
        public static new VaultSpecResourcesArgs Empty => new VaultSpecResourcesArgs();
    }
}