// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;

namespace Pulumi.Kubernetes.Types.Outputs.Monitoring.V1
{

    /// <summary>
    /// RuleGroup is a list of sequentially evaluated recording and alerting rules.
    /// </summary>
    [OutputType]
    public sealed class PrometheusRuleSpecGroups
    {
        /// <summary>
        /// Interval determines how often rules in the group are evaluated.
        /// </summary>
        public readonly string Interval;
        /// <summary>
        /// Name of the rule group.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// PartialResponseStrategy is only used by ThanosRuler and will be ignored by Prometheus instances. More info: https://github.com/thanos-io/thanos/blob/main/docs/components/rule.md#partial-response
        /// </summary>
        public readonly string Partial_response_strategy;
        /// <summary>
        /// List of alerting and recording rules.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusRuleSpecGroupsRules> Rules;

        [OutputConstructor]
        private PrometheusRuleSpecGroups(
            string interval,

            string name,

            string partial_response_strategy,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusRuleSpecGroupsRules> rules)
        {
            Interval = interval;
            Name = name;
            Partial_response_strategy = partial_response_strategy;
            Rules = rules;
        }
    }
}
