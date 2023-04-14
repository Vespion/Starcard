// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Traefik.V1Alpha1
{

    /// <summary>
    /// Sticky defines the sticky sessions configuration. More info: https://doc.traefik.io/traefik/v2.9/routing/services/#sticky-sessions
    /// </summary>
    [OutputType]
    public sealed class IngressRouteSpecRoutesServicesSticky
    {
        /// <summary>
        /// Cookie defines the sticky cookie configuration.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Traefik.V1Alpha1.IngressRouteSpecRoutesServicesStickyCookie Cookie;

        [OutputConstructor]
        private IngressRouteSpecRoutesServicesSticky(Pulumi.Kubernetes.Types.Outputs.Traefik.V1Alpha1.IngressRouteSpecRoutesServicesStickyCookie cookie)
        {
            Cookie = cookie;
        }
    }
}
