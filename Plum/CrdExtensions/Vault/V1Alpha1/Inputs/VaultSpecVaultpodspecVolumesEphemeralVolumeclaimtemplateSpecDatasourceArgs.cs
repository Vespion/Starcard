// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1
{

    public class VaultSpecVaultpodspecVolumesEphemeralVolumeclaimtemplateSpecDatasourceArgs : global::Pulumi.ResourceArgs
    {
        [Input("apiGroup")]
        public Input<string>? ApiGroup { get; set; }

        [Input("kind", required: true)]
        public Input<string> Kind { get; set; } = null!;

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public VaultSpecVaultpodspecVolumesEphemeralVolumeclaimtemplateSpecDatasourceArgs()
        {
        }
        public static new VaultSpecVaultpodspecVolumesEphemeralVolumeclaimtemplateSpecDatasourceArgs Empty => new VaultSpecVaultpodspecVolumesEphemeralVolumeclaimtemplateSpecDatasourceArgs();
    }
}
