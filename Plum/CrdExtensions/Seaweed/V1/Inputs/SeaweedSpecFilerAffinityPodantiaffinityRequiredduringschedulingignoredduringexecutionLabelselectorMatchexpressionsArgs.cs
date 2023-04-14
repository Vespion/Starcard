// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Seaweed.V1
{

    /// <summary>
    /// A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.
    /// </summary>
    public class SeaweedSpecFilerAffinityPodantiaffinityRequiredduringschedulingignoredduringexecutionLabelselectorMatchexpressionsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// key is the label key that the selector applies to.
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.
        /// </summary>
        [Input("operator", required: true)]
        public Input<string> Operator { get; set; } = null!;

        [Input("values")]
        private InputList<string>? _values;

        /// <summary>
        /// values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.
        /// </summary>
        public InputList<string> Values
        {
            get => _values ?? (_values = new InputList<string>());
            set => _values = value;
        }

        public SeaweedSpecFilerAffinityPodantiaffinityRequiredduringschedulingignoredduringexecutionLabelselectorMatchexpressionsArgs()
        {
        }
        public static new SeaweedSpecFilerAffinityPodantiaffinityRequiredduringschedulingignoredduringexecutionLabelselectorMatchexpressionsArgs Empty => new SeaweedSpecFilerAffinityPodantiaffinityRequiredduringschedulingignoredduringexecutionLabelselectorMatchexpressionsArgs();
    }
}
