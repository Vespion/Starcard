// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Monitoring.V1
{

    /// <summary>
    /// RelabelConfig allows dynamic rewriting of the label set, being applied to samples before ingestion. It defines `&lt;metric_relabel_configs&gt;`-section of Prometheus configuration. More info: https://prometheus.io/docs/prometheus/latest/configuration/configuration/#metric_relabel_configs
    /// </summary>
    [OutputType]
    public sealed class ProbeSpecTargetsIngressRelabelingconfigs
    {
        /// <summary>
        /// Action to perform based on regex matching. Default is 'replace'. uppercase and lowercase actions require Prometheus &gt;= 2.36.
        /// </summary>
        public readonly string Action;
        /// <summary>
        /// Modulus to take of the hash of the source label values.
        /// </summary>
        public readonly int Modulus;
        /// <summary>
        /// Regular expression against which the extracted value is matched. Default is '(.*)'
        /// </summary>
        public readonly string Regex;
        /// <summary>
        /// Replacement value against which a regex replace is performed if the regular expression matches. Regex capture groups are available. Default is '$1'
        /// </summary>
        public readonly string Replacement;
        /// <summary>
        /// Separator placed between concatenated source label values. default is ';'.
        /// </summary>
        public readonly string Separator;
        /// <summary>
        /// The source labels select values from existing labels. Their content is concatenated using the configured separator and matched against the configured regular expression for the replace, keep, and drop actions.
        /// </summary>
        public readonly ImmutableArray<string> SourceLabels;
        /// <summary>
        /// Label to which the resulting value is written in a replace action. It is mandatory for replace actions. Regex capture groups are available.
        /// </summary>
        public readonly string TargetLabel;

        [OutputConstructor]
        private ProbeSpecTargetsIngressRelabelingconfigs(
            string action,

            int modulus,

            string regex,

            string replacement,

            string separator,

            ImmutableArray<string> sourceLabels,

            string targetLabel)
        {
            Action = action;
            Modulus = modulus;
            Regex = regex;
            Replacement = replacement;
            Separator = separator;
            SourceLabels = sourceLabels;
            TargetLabel = targetLabel;
        }
    }
}
