// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;

namespace Pulumi.Kubernetes.Types.Outputs.Traefik.V1Alpha1
{

    /// <summary>
    /// ErrorPage holds the custom error middleware configuration. This middleware returns a custom page in lieu of the default, according to configured ranges of HTTP Status codes. More info: https://doc.traefik.io/traefik/v2.9/middlewares/http/errorpages/
    /// </summary>
    [OutputType]
    public sealed class MiddlewareSpecErrors
    {
        /// <summary>
        /// Query defines the URL for the error page (hosted by service). The {status} variable can be used in order to insert the status code in the URL.
        /// </summary>
        public readonly string Query;
        /// <summary>
        /// Service defines the reference to a Kubernetes Service that will serve the error page. More info: https://doc.traefik.io/traefik/v2.9/middlewares/http/errorpages/#service
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Traefik.V1Alpha1.MiddlewareSpecErrorsService Service;
        /// <summary>
        /// Status defines which status or range of statuses should result in an error page. It can be either a status code as a number (500), as multiple comma-separated numbers (500,502), as ranges by separating two codes with a dash (500-599), or a combination of the two (404,418,500-599).
        /// </summary>
        public readonly ImmutableArray<string> Status;

        [OutputConstructor]
        private MiddlewareSpecErrors(
            string query,

            Pulumi.Kubernetes.Types.Outputs.Traefik.V1Alpha1.MiddlewareSpecErrorsService service,

            ImmutableArray<string> status)
        {
            Query = query;
            Service = service;
            Status = status;
        }
    }
}
