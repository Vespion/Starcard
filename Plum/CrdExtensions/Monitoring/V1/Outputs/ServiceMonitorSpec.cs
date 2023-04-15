// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;

namespace Pulumi.Kubernetes.Types.Outputs.Monitoring.V1
{

    /// <summary>
    /// Specification of desired Service selection for target discovery by Prometheus.
    /// </summary>
    [OutputType]
    public sealed class ServiceMonitorSpec
    {
        /// <summary>
        /// Attaches node metadata to discovered targets. Requires Prometheus v2.37.0 and above.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecAttachmetadata AttachMetadata;
        /// <summary>
        /// A list of endpoints allowed as part of this ServiceMonitor.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecEndpoints> Endpoints;
        /// <summary>
        /// JobLabel selects the label from the associated Kubernetes service which will be used as the `job` label for all metrics. 
        ///  For example: If in `ServiceMonitor.spec.jobLabel: foo` and in `Service.metadata.labels.foo: bar`, then the `job="bar"` label is added to all metrics. 
        ///  If the value of this field is empty or if the label doesn't exist for the given Service, the `job` label of the metrics defaults to the name of the Kubernetes Service.
        /// </summary>
        public readonly string JobLabel;
        /// <summary>
        /// Per-scrape limit on number of labels that will be accepted for a sample. Only valid in Prometheus versions 2.27.0 and newer.
        /// </summary>
        public readonly int LabelLimit;
        /// <summary>
        /// Per-scrape limit on length of labels name that will be accepted for a sample. Only valid in Prometheus versions 2.27.0 and newer.
        /// </summary>
        public readonly int LabelNameLengthLimit;
        /// <summary>
        /// Per-scrape limit on length of labels value that will be accepted for a sample. Only valid in Prometheus versions 2.27.0 and newer.
        /// </summary>
        public readonly int LabelValueLengthLimit;
        /// <summary>
        /// Selector to select which namespaces the Kubernetes Endpoints objects are discovered from.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecNamespaceselector NamespaceSelector;
        /// <summary>
        /// PodTargetLabels transfers labels on the Kubernetes `Pod` onto the created metrics.
        /// </summary>
        public readonly ImmutableArray<string> PodTargetLabels;
        /// <summary>
        /// SampleLimit defines per-scrape limit on number of scraped samples that will be accepted.
        /// </summary>
        public readonly int SampleLimit;
        /// <summary>
        /// Selector to select Endpoints objects.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecSelector Selector;
        /// <summary>
        /// TargetLabels transfers labels from the Kubernetes `Service` onto the created metrics.
        /// </summary>
        public readonly ImmutableArray<string> TargetLabels;
        /// <summary>
        /// TargetLimit defines a limit on the number of scraped targets that will be accepted.
        /// </summary>
        public readonly int TargetLimit;

        [OutputConstructor]
        private ServiceMonitorSpec(
            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecAttachmetadata attachMetadata,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecEndpoints> endpoints,

            string jobLabel,

            int labelLimit,

            int labelNameLengthLimit,

            int labelValueLengthLimit,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecNamespaceselector namespaceSelector,

            ImmutableArray<string> podTargetLabels,

            int sampleLimit,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecSelector selector,

            ImmutableArray<string> targetLabels,

            int targetLimit)
        {
            AttachMetadata = attachMetadata;
            Endpoints = endpoints;
            JobLabel = jobLabel;
            LabelLimit = labelLimit;
            LabelNameLengthLimit = labelNameLengthLimit;
            LabelValueLengthLimit = labelValueLengthLimit;
            NamespaceSelector = namespaceSelector;
            PodTargetLabels = podTargetLabels;
            SampleLimit = sampleLimit;
            Selector = selector;
            TargetLabels = targetLabels;
            TargetLimit = targetLimit;
        }
    }
}
