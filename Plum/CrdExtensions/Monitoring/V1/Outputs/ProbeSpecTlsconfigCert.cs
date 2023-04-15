// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Kubernetes.Types.Outputs.Monitoring.V1
{

    /// <summary>
    /// Client certificate to present when doing client-authentication.
    /// </summary>
    [OutputType]
    public sealed class ProbeSpecTlsconfigCert
    {
        /// <summary>
        /// ConfigMap containing data to use for the targets.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ProbeSpecTlsconfigCertConfigmap ConfigMap;
        /// <summary>
        /// Secret containing data to use for the targets.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ProbeSpecTlsconfigCertSecret Secret;

        [OutputConstructor]
        private ProbeSpecTlsconfigCert(
            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ProbeSpecTlsconfigCertConfigmap configMap,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ProbeSpecTlsconfigCertSecret secret)
        {
            ConfigMap = configMap;
            Secret = secret;
        }
    }
}
