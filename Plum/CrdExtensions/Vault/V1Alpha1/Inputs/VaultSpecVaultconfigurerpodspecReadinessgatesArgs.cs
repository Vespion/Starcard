// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1
{

    public class VaultSpecVaultconfigurerpodspecReadinessgatesArgs : global::Pulumi.ResourceArgs
    {
        [Input("conditionType", required: true)]
        public Input<string> ConditionType { get; set; } = null!;

        public VaultSpecVaultconfigurerpodspecReadinessgatesArgs()
        {
        }
        public static new VaultSpecVaultconfigurerpodspecReadinessgatesArgs Empty => new VaultSpecVaultconfigurerpodspecReadinessgatesArgs();
    }
}
