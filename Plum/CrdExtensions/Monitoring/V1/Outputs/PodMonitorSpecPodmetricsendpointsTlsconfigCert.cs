// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Kubernetes.Types.Outputs.Monitoring.V1
{

    /// <summary>
    /// Client certificate to present when doing client-authentication.
    /// </summary>
    [OutputType]
    public sealed class PodMonitorSpecPodmetricsendpointsTlsconfigCert
    {
        /// <summary>
        /// ConfigMap containing data to use for the targets.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PodMonitorSpecPodmetricsendpointsTlsconfigCertConfigmap ConfigMap;
        /// <summary>
        /// Secret containing data to use for the targets.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PodMonitorSpecPodmetricsendpointsTlsconfigCertSecret Secret;

        [OutputConstructor]
        private PodMonitorSpecPodmetricsendpointsTlsconfigCert(
            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PodMonitorSpecPodmetricsendpointsTlsconfigCertConfigmap configMap,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PodMonitorSpecPodmetricsendpointsTlsconfigCertSecret secret)
        {
            ConfigMap = configMap;
            Secret = secret;
        }
    }
}
