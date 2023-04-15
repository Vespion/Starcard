// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;

namespace Pulumi.Kubernetes.Types.Outputs.Traefik.V1Alpha1
{

    /// <summary>
    /// Weighted defines the Weighted Round Robin configuration.
    /// </summary>
    [OutputType]
    public sealed class TraefikServiceSpecWeighted
    {
        /// <summary>
        /// Services defines the list of Kubernetes Service and/or TraefikService to load-balance, with weight.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Traefik.V1Alpha1.TraefikServiceSpecWeightedServices> Services;
        /// <summary>
        /// Sticky defines whether sticky sessions are enabled. More info: https://doc.traefik.io/traefik/v2.9/routing/providers/kubernetes-crd/#stickiness-and-load-balancing
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Traefik.V1Alpha1.TraefikServiceSpecWeightedSticky Sticky;

        [OutputConstructor]
        private TraefikServiceSpecWeighted(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Traefik.V1Alpha1.TraefikServiceSpecWeightedServices> services,

            Pulumi.Kubernetes.Types.Outputs.Traefik.V1Alpha1.TraefikServiceSpecWeightedSticky sticky)
        {
            Services = services;
            Sticky = sticky;
        }
    }
}
