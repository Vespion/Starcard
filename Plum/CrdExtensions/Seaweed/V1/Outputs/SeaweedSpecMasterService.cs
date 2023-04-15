// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;

namespace Pulumi.Kubernetes.Types.Outputs.Seaweed.V1
{

    /// <summary>
    /// ServiceSpec is a subset of the original k8s spec
    /// </summary>
    [OutputType]
    public sealed class SeaweedSpecMasterService
    {
        /// <summary>
        /// Additional annotations of the kubernetes service object
        /// </summary>
        public readonly ImmutableDictionary<string, string> Annotations;
        /// <summary>
        /// ClusterIP is the clusterIP of service
        /// </summary>
        public readonly string ClusterIP;
        /// <summary>
        /// LoadBalancerIP is the loadBalancerIP of service
        /// </summary>
        public readonly string LoadBalancerIP;
        /// <summary>
        /// Type of the real kubernetes service
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private SeaweedSpecMasterService(
            ImmutableDictionary<string, string> annotations,

            string clusterIP,

            string loadBalancerIP,

            string type)
        {
            Annotations = annotations;
            ClusterIP = clusterIP;
            LoadBalancerIP = loadBalancerIP;
            Type = type;
        }
    }
}
