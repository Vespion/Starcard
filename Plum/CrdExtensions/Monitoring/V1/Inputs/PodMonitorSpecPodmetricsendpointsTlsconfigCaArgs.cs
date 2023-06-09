// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Kubernetes.Types.Inputs.Monitoring.V1
{

    /// <summary>
    /// Certificate authority used when verifying server certificates.
    /// </summary>
    public class PodMonitorSpecPodmetricsendpointsTlsconfigCaArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// ConfigMap containing data to use for the targets.
        /// </summary>
        [Input("configMap")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.PodMonitorSpecPodmetricsendpointsTlsconfigCaConfigmapArgs>? ConfigMap { get; set; }

        /// <summary>
        /// Secret containing data to use for the targets.
        /// </summary>
        [Input("secret")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.PodMonitorSpecPodmetricsendpointsTlsconfigCaSecretArgs>? Secret { get; set; }

        public PodMonitorSpecPodmetricsendpointsTlsconfigCaArgs()
        {
        }
        public static new PodMonitorSpecPodmetricsendpointsTlsconfigCaArgs Empty => new PodMonitorSpecPodmetricsendpointsTlsconfigCaArgs();
    }
}
