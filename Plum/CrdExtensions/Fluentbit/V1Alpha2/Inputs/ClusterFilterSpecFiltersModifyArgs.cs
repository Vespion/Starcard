// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Fluentbit.V1Alpha2
{

    /// <summary>
    /// Modify defines Modify Filter configuration.
    /// </summary>
    public class ClusterFilterSpecFiltersModifyArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Alias for the plugin
        /// </summary>
        [Input("alias")]
        public Input<string>? Alias { get; set; }

        [Input("conditions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersModifyConditionsArgs>? _conditions;

        /// <summary>
        /// All conditions have to be true for the rules to be applied.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersModifyConditionsArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Pulumi.Kubernetes.Types.Inputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersModifyConditionsArgs>());
            set => _conditions = value;
        }

        /// <summary>
        /// RetryLimit describes how many times fluent-bit should retry to send data to a specific output. If set to false fluent-bit will try indefinetly. If set to any integer N&gt;0 it will try at most N+1 times. Leading zeros are not allowed (values such as 007, 0150, 01 do not work). If this property is not defined fluent-bit will use the default value: 1.
        /// </summary>
        [Input("retryLimit")]
        public Input<string>? RetryLimit { get; set; }

        [Input("rules")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersModifyRulesArgs>? _rules;

        /// <summary>
        /// Rules are applied in the order they appear, with each rule operating on the result of the previous rule.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersModifyRulesArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Pulumi.Kubernetes.Types.Inputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersModifyRulesArgs>());
            set => _rules = value;
        }

        public ClusterFilterSpecFiltersModifyArgs()
        {
        }
        public static new ClusterFilterSpecFiltersModifyArgs Empty => new ClusterFilterSpecFiltersModifyArgs();
    }
}
