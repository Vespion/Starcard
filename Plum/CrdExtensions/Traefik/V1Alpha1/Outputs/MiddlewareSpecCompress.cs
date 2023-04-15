// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;

namespace Pulumi.Kubernetes.Types.Outputs.Traefik.V1Alpha1
{

    /// <summary>
    /// Compress holds the compress middleware configuration. This middleware compresses responses before sending them to the client, using gzip compression. More info: https://doc.traefik.io/traefik/v2.9/middlewares/http/compress/
    /// </summary>
    [OutputType]
    public sealed class MiddlewareSpecCompress
    {
        /// <summary>
        /// ExcludedContentTypes defines the list of content types to compare the Content-Type header of the incoming requests and responses before compressing.
        /// </summary>
        public readonly ImmutableArray<string> ExcludedContentTypes;
        /// <summary>
        /// MinResponseBodyBytes defines the minimum amount of bytes a response body must have to be compressed. Default: 1024.
        /// </summary>
        public readonly int MinResponseBodyBytes;

        [OutputConstructor]
        private MiddlewareSpecCompress(
            ImmutableArray<string> excludedContentTypes,

            int minResponseBodyBytes)
        {
            ExcludedContentTypes = excludedContentTypes;
            MinResponseBodyBytes = minResponseBodyBytes;
        }
    }
}
