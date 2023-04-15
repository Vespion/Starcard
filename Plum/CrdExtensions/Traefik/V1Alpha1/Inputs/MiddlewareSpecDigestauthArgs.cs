// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Kubernetes.Types.Inputs.Traefik.V1Alpha1
{

    /// <summary>
    /// DigestAuth holds the digest auth middleware configuration. This middleware restricts access to your services to known users. More info: https://doc.traefik.io/traefik/v2.9/middlewares/http/digestauth/
    /// </summary>
    public class MiddlewareSpecDigestauthArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// HeaderField defines a header field to store the authenticated user. More info: https://doc.traefik.io/traefik/v2.9/middlewares/http/basicauth/#headerfield
        /// </summary>
        [Input("headerField")]
        public Input<string>? HeaderField { get; set; }

        /// <summary>
        /// Realm allows the protected resources on a server to be partitioned into a set of protection spaces, each with its own authentication scheme. Default: traefik.
        /// </summary>
        [Input("realm")]
        public Input<string>? Realm { get; set; }

        /// <summary>
        /// RemoveHeader defines whether to remove the authorization header before forwarding the request to the backend.
        /// </summary>
        [Input("removeHeader")]
        public Input<bool>? RemoveHeader { get; set; }

        /// <summary>
        /// Secret is the name of the referenced Kubernetes Secret containing user credentials.
        /// </summary>
        [Input("secret")]
        public Input<string>? Secret { get; set; }

        public MiddlewareSpecDigestauthArgs()
        {
        }
        public static new MiddlewareSpecDigestauthArgs Empty => new MiddlewareSpecDigestauthArgs();
    }
}
