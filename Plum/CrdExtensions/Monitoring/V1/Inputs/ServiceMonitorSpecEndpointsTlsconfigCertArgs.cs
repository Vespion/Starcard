// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Kubernetes.Types.Inputs.Monitoring.V1
{

    /// <summary>
    /// Client certificate to present when doing client-authentication.
    /// </summary>
    public class ServiceMonitorSpecEndpointsTlsconfigCertArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// ConfigMap containing data to use for the targets.
        /// </summary>
        [Input("configMap")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ServiceMonitorSpecEndpointsTlsconfigCertConfigmapArgs>? ConfigMap { get; set; }

        /// <summary>
        /// Secret containing data to use for the targets.
        /// </summary>
        [Input("secret")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ServiceMonitorSpecEndpointsTlsconfigCertSecretArgs>? Secret { get; set; }

        public ServiceMonitorSpecEndpointsTlsconfigCertArgs()
        {
        }
        public static new ServiceMonitorSpecEndpointsTlsconfigCertArgs Empty => new ServiceMonitorSpecEndpointsTlsconfigCertArgs();
    }
}
