// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Kubernetes.Types.Inputs.Monitoring.V1
{

    /// <summary>
    /// staticConfig defines the static list of targets to probe and the relabeling configuration. If `ingress` is also defined, `staticConfig` takes precedence. More info: https://prometheus.io/docs/prometheus/latest/configuration/configuration/#static_config.
    /// </summary>
    public class ProbeSpecTargetsStaticconfigArgs : global::Pulumi.ResourceArgs
    {
        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// Labels assigned to all metrics scraped from the targets.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("relabelingConfigs")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ProbeSpecTargetsStaticconfigRelabelingconfigsArgs>? _relabelingConfigs;

        /// <summary>
        /// RelabelConfigs to apply to the label set of the targets before it gets scraped. More info: https://prometheus.io/docs/prometheus/latest/configuration/configuration/#relabel_config
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ProbeSpecTargetsStaticconfigRelabelingconfigsArgs> RelabelingConfigs
        {
            get => _relabelingConfigs ?? (_relabelingConfigs = new InputList<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ProbeSpecTargetsStaticconfigRelabelingconfigsArgs>());
            set => _relabelingConfigs = value;
        }

        [Input("static")]
        private InputList<string>? _static;

        /// <summary>
        /// The list of hosts to probe.
        /// </summary>
        public InputList<string> Static
        {
            get => _static ?? (_static = new InputList<string>());
            set => _static = value;
        }

        public ProbeSpecTargetsStaticconfigArgs()
        {
        }
        public static new ProbeSpecTargetsStaticconfigArgs Empty => new ProbeSpecTargetsStaticconfigArgs();
    }
}
