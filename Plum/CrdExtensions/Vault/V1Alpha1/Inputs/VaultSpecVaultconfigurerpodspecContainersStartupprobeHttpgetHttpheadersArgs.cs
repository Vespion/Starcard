// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1
{

    public class VaultSpecVaultconfigurerpodspecContainersStartupprobeHttpgetHttpheadersArgs : global::Pulumi.ResourceArgs
    {
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public VaultSpecVaultconfigurerpodspecContainersStartupprobeHttpgetHttpheadersArgs()
        {
        }
        public static new VaultSpecVaultconfigurerpodspecContainersStartupprobeHttpgetHttpheadersArgs Empty => new VaultSpecVaultconfigurerpodspecContainersStartupprobeHttpgetHttpheadersArgs();
    }
}
