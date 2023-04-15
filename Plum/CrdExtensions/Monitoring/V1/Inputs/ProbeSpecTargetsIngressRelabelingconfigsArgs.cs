// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Kubernetes.Types.Inputs.Monitoring.V1
{

    /// <summary>
    /// RelabelConfig allows dynamic rewriting of the label set, being applied to samples before ingestion. It defines `&lt;metric_relabel_configs&gt;`-section of Prometheus configuration. More info: https://prometheus.io/docs/prometheus/latest/configuration/configuration/#metric_relabel_configs
    /// </summary>
    public class ProbeSpecTargetsIngressRelabelingconfigsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Action to perform based on regex matching. Default is 'replace'. uppercase and lowercase actions require Prometheus &gt;= 2.36.
        /// </summary>
        [Input("action")]
        public Input<string>? Action { get; set; }

        /// <summary>
        /// Modulus to take of the hash of the source label values.
        /// </summary>
        [Input("modulus")]
        public Input<int>? Modulus { get; set; }

        /// <summary>
        /// Regular expression against which the extracted value is matched. Default is '(.*)'
        /// </summary>
        [Input("regex")]
        public Input<string>? Regex { get; set; }

        /// <summary>
        /// Replacement value against which a regex replace is performed if the regular expression matches. Regex capture groups are available. Default is '$1'
        /// </summary>
        [Input("replacement")]
        public Input<string>? Replacement { get; set; }

        /// <summary>
        /// Separator placed between concatenated source label values. default is ';'.
        /// </summary>
        [Input("separator")]
        public Input<string>? Separator { get; set; }

        [Input("sourceLabels")]
        private InputList<string>? _sourceLabels;

        /// <summary>
        /// The source labels select values from existing labels. Their content is concatenated using the configured separator and matched against the configured regular expression for the replace, keep, and drop actions.
        /// </summary>
        public InputList<string> SourceLabels
        {
            get => _sourceLabels ?? (_sourceLabels = new InputList<string>());
            set => _sourceLabels = value;
        }

        /// <summary>
        /// Label to which the resulting value is written in a replace action. It is mandatory for replace actions. Regex capture groups are available.
        /// </summary>
        [Input("targetLabel")]
        public Input<string>? TargetLabel { get; set; }

        public ProbeSpecTargetsIngressRelabelingconfigsArgs()
        {
            Action = "replace";
        }
        public static new ProbeSpecTargetsIngressRelabelingconfigsArgs Empty => new ProbeSpecTargetsIngressRelabelingconfigsArgs();
    }
}
