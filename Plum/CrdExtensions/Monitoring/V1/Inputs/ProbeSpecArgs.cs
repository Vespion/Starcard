// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Kubernetes.Types.Inputs.Monitoring.V1
{

    /// <summary>
    /// Specification of desired Ingress selection for target discovery by Prometheus.
    /// </summary>
    public class ProbeSpecArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Authorization section for this endpoint
        /// </summary>
        [Input("authorization")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ProbeSpecAuthorizationArgs>? Authorization { get; set; }

        /// <summary>
        /// BasicAuth allow an endpoint to authenticate over basic authentication. More info: https://prometheus.io/docs/operating/configuration/#endpoint
        /// </summary>
        [Input("basicAuth")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ProbeSpecBasicauthArgs>? BasicAuth { get; set; }

        /// <summary>
        /// Secret to mount to read bearer token for scraping targets. The secret needs to be in the same namespace as the probe and accessible by the Prometheus Operator.
        /// </summary>
        [Input("bearerTokenSecret")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ProbeSpecBearertokensecretArgs>? BearerTokenSecret { get; set; }

        /// <summary>
        /// Interval at which targets are probed using the configured prober. If not specified Prometheus' global scrape interval is used.
        /// </summary>
        [Input("interval")]
        public Input<string>? Interval { get; set; }

        /// <summary>
        /// The job name assigned to scraped metrics by default.
        /// </summary>
        [Input("jobName")]
        public Input<string>? JobName { get; set; }

        /// <summary>
        /// Per-scrape limit on number of labels that will be accepted for a sample. Only valid in Prometheus versions 2.27.0 and newer.
        /// </summary>
        [Input("labelLimit")]
        public Input<int>? LabelLimit { get; set; }

        /// <summary>
        /// Per-scrape limit on length of labels name that will be accepted for a sample. Only valid in Prometheus versions 2.27.0 and newer.
        /// </summary>
        [Input("labelNameLengthLimit")]
        public Input<int>? LabelNameLengthLimit { get; set; }

        /// <summary>
        /// Per-scrape limit on length of labels value that will be accepted for a sample. Only valid in Prometheus versions 2.27.0 and newer.
        /// </summary>
        [Input("labelValueLengthLimit")]
        public Input<int>? LabelValueLengthLimit { get; set; }

        [Input("metricRelabelings")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ProbeSpecMetricrelabelingsArgs>? _metricRelabelings;

        /// <summary>
        /// MetricRelabelConfigs to apply to samples before ingestion.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ProbeSpecMetricrelabelingsArgs> MetricRelabelings
        {
            get => _metricRelabelings ?? (_metricRelabelings = new InputList<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ProbeSpecMetricrelabelingsArgs>());
            set => _metricRelabelings = value;
        }

        /// <summary>
        /// The module to use for probing specifying how to probe the target. Example module configuring in the blackbox exporter: https://github.com/prometheus/blackbox_exporter/blob/master/example.yml
        /// </summary>
        [Input("module")]
        public Input<string>? Module { get; set; }

        /// <summary>
        /// OAuth2 for the URL. Only valid in Prometheus versions 2.27.0 and newer.
        /// </summary>
        [Input("oauth2")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ProbeSpecOauth2Args>? Oauth2 { get; set; }

        /// <summary>
        /// Specification for the prober to use for probing targets. The prober.URL parameter is required. Targets cannot be probed if left empty.
        /// </summary>
        [Input("prober")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ProbeSpecProberArgs>? Prober { get; set; }

        /// <summary>
        /// SampleLimit defines per-scrape limit on number of scraped samples that will be accepted.
        /// </summary>
        [Input("sampleLimit")]
        public Input<int>? SampleLimit { get; set; }

        /// <summary>
        /// Timeout for scraping metrics from the Prometheus exporter. If not specified, the Prometheus global scrape interval is used.
        /// </summary>
        [Input("scrapeTimeout")]
        public Input<string>? ScrapeTimeout { get; set; }

        /// <summary>
        /// TargetLimit defines a limit on the number of scraped targets that will be accepted.
        /// </summary>
        [Input("targetLimit")]
        public Input<int>? TargetLimit { get; set; }

        /// <summary>
        /// Targets defines a set of static or dynamically discovered targets to probe.
        /// </summary>
        [Input("targets")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ProbeSpecTargetsArgs>? Targets { get; set; }

        /// <summary>
        /// TLS configuration to use when scraping the endpoint.
        /// </summary>
        [Input("tlsConfig")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ProbeSpecTlsconfigArgs>? TlsConfig { get; set; }

        public ProbeSpecArgs()
        {
        }
        public static new ProbeSpecArgs Empty => new ProbeSpecArgs();
    }
}
