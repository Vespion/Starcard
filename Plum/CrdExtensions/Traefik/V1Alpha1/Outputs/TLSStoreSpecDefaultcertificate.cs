// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Kubernetes.Types.Outputs.Traefik.V1Alpha1
{

    /// <summary>
    /// DefaultCertificate defines the default certificate configuration.
    /// </summary>
    [OutputType]
    public sealed class TLSStoreSpecDefaultcertificate
    {
        /// <summary>
        /// SecretName is the name of the referenced Kubernetes Secret to specify the certificate details.
        /// </summary>
        public readonly string SecretName;

        [OutputConstructor]
        private TLSStoreSpecDefaultcertificate(string secretName)
        {
            SecretName = secretName;
        }
    }
}
