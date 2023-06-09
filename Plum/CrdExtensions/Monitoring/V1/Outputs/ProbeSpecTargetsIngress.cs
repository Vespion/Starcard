// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;

namespace Pulumi.Kubernetes.Types.Outputs.Monitoring.V1
{

    /// <summary>
    /// ingress defines the Ingress objects to probe and the relabeling configuration. If `staticConfig` is also defined, `staticConfig` takes precedence.
    /// </summary>
    [OutputType]
    public sealed class ProbeSpecTargetsIngress
    {
        /// <summary>
        /// From which namespaces to select Ingress objects.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ProbeSpecTargetsIngressNamespaceselector NamespaceSelector;
        /// <summary>
        /// RelabelConfigs to apply to the label set of the target before it gets scraped. The original ingress address is available via the `__tmp_prometheus_ingress_address` label. It can be used to customize the probed URL. The original scrape job's name is available via the `__tmp_prometheus_job_name` label. More info: https://prometheus.io/docs/prometheus/latest/configuration/configuration/#relabel_config
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ProbeSpecTargetsIngressRelabelingconfigs> RelabelingConfigs;
        /// <summary>
        /// Selector to select the Ingress objects.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ProbeSpecTargetsIngressSelector Selector;

        [OutputConstructor]
        private ProbeSpecTargetsIngress(
            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ProbeSpecTargetsIngressNamespaceselector namespaceSelector,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ProbeSpecTargetsIngressRelabelingconfigs> relabelingConfigs,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ProbeSpecTargetsIngressSelector selector)
        {
            NamespaceSelector = namespaceSelector;
            RelabelingConfigs = relabelingConfigs;
            Selector = selector;
        }
    }
}
