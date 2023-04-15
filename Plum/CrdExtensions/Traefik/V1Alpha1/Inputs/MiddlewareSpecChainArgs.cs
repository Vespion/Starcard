// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Kubernetes.Types.Inputs.Traefik.V1Alpha1
{

    /// <summary>
    /// Chain holds the configuration of the chain middleware. This middleware enables to define reusable combinations of other pieces of middleware. More info: https://doc.traefik.io/traefik/v2.9/middlewares/http/chain/
    /// </summary>
    public class MiddlewareSpecChainArgs : global::Pulumi.ResourceArgs
    {
        [Input("middlewares")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Traefik.V1Alpha1.MiddlewareSpecChainMiddlewaresArgs>? _middlewares;

        /// <summary>
        /// Middlewares is the list of MiddlewareRef which composes the chain.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Traefik.V1Alpha1.MiddlewareSpecChainMiddlewaresArgs> Middlewares
        {
            get => _middlewares ?? (_middlewares = new InputList<Pulumi.Kubernetes.Types.Inputs.Traefik.V1Alpha1.MiddlewareSpecChainMiddlewaresArgs>());
            set => _middlewares = value;
        }

        public MiddlewareSpecChainArgs()
        {
        }
        public static new MiddlewareSpecChainArgs Empty => new MiddlewareSpecChainArgs();
    }
}
