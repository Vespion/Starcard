// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1
{

    public class VaultSpecAffinityPodaffinityRequiredduringschedulingignoredduringexecutionLabelselectorMatchexpressionsArgs : global::Pulumi.ResourceArgs
    {
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        [Input("operator", required: true)]
        public Input<string> Operator { get; set; } = null!;

        [Input("values")]
        private InputList<string>? _values;
        public InputList<string> Values
        {
            get => _values ?? (_values = new InputList<string>());
            set => _values = value;
        }

        public VaultSpecAffinityPodaffinityRequiredduringschedulingignoredduringexecutionLabelselectorMatchexpressionsArgs()
        {
        }
        public static new VaultSpecAffinityPodaffinityRequiredduringschedulingignoredduringexecutionLabelselectorMatchexpressionsArgs Empty => new VaultSpecAffinityPodaffinityRequiredduringschedulingignoredduringexecutionLabelselectorMatchexpressionsArgs();
    }
}
