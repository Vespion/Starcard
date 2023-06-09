// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Kubernetes.Types.Outputs.Traefik.V1Alpha1
{

    /// <summary>
    /// SourceCriterion defines what criterion is used to group requests as originating from a common source. If several strategies are defined at the same time, an error will be raised. If none are set, the default is to use the request's remote address field (as an ipStrategy).
    /// </summary>
    [OutputType]
    public sealed class MiddlewareSpecRatelimitSourcecriterion
    {
        /// <summary>
        /// IPStrategy holds the IP strategy configuration used by Traefik to determine the client IP. More info: https://doc.traefik.io/traefik/v2.9/middlewares/http/ipwhitelist/#ipstrategy
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Traefik.V1Alpha1.MiddlewareSpecRatelimitSourcecriterionIpstrategy IpStrategy;
        /// <summary>
        /// RequestHeaderName defines the name of the header used to group incoming requests.
        /// </summary>
        public readonly string RequestHeaderName;
        /// <summary>
        /// RequestHost defines whether to consider the request Host as the source.
        /// </summary>
        public readonly bool RequestHost;

        [OutputConstructor]
        private MiddlewareSpecRatelimitSourcecriterion(
            Pulumi.Kubernetes.Types.Outputs.Traefik.V1Alpha1.MiddlewareSpecRatelimitSourcecriterionIpstrategy ipStrategy,

            string requestHeaderName,

            bool requestHost)
        {
            IpStrategy = ipStrategy;
            RequestHeaderName = requestHeaderName;
            RequestHost = requestHost;
        }
    }
}
