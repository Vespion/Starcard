// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;

namespace Pulumi.Kubernetes.Types.Outputs.Monitoring.V1
{

    /// <summary>
    /// Rule describes an alerting or recording rule See Prometheus documentation: [alerting](https://www.prometheus.io/docs/prometheus/latest/configuration/alerting_rules/) or [recording](https://www.prometheus.io/docs/prometheus/latest/configuration/recording_rules/#recording-rules) rule
    /// </summary>
    [OutputType]
    public sealed class PrometheusRuleSpecGroupsRules
    {
        /// <summary>
        /// Name of the alert. Must be a valid label value. Only one of `record` and `alert` must be set.
        /// </summary>
        public readonly string Alert;
        /// <summary>
        /// Annotations to add to each alert. Only valid for alerting rules.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Annotations;
        /// <summary>
        /// PromQL expression to evaluate.
        /// </summary>
        public readonly Union<int, string> Expr;
        /// <summary>
        /// Alerts are considered firing once they have been returned for this long.
        /// </summary>
        public readonly string For;
        /// <summary>
        /// Labels to add or overwrite.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Labels;
        /// <summary>
        /// Name of the time series to output to. Must be a valid metric name. Only one of `record` and `alert` must be set.
        /// </summary>
        public readonly string Record;

        [OutputConstructor]
        private PrometheusRuleSpecGroupsRules(
            string alert,

            ImmutableDictionary<string, string> annotations,

            Union<int, string> expr,

            string @for,

            ImmutableDictionary<string, string> labels,

            string record)
        {
            Alert = alert;
            Annotations = annotations;
            Expr = expr;
            For = @for;
            Labels = labels;
            Record = record;
        }
    }
}
