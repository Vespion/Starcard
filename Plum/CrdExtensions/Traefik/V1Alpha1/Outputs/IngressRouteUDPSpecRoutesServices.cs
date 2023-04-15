// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Kubernetes.Types.Outputs.Traefik.V1Alpha1
{

    /// <summary>
    /// ServiceUDP defines an upstream UDP service to proxy traffic to.
    /// </summary>
    [OutputType]
    public sealed class IngressRouteUDPSpecRoutesServices
    {
        /// <summary>
        /// Name defines the name of the referenced Kubernetes Service.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Namespace defines the namespace of the referenced Kubernetes Service.
        /// </summary>
        public readonly string Namespace;
        /// <summary>
        /// Port defines the port of a Kubernetes Service. This can be a reference to a named port.
        /// </summary>
        public readonly Union<int, string> Port;
        /// <summary>
        /// Weight defines the weight used when balancing requests between multiple Kubernetes Service.
        /// </summary>
        public readonly int Weight;

        [OutputConstructor]
        private IngressRouteUDPSpecRoutesServices(
            string name,

            string @namespace,

            Union<int, string> port,

            int weight)
        {
            Name = name;
            Namespace = @namespace;
            Port = port;
            Weight = weight;
        }
    }
}
