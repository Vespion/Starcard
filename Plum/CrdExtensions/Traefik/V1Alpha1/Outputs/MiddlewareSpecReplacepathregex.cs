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
    /// ReplacePathRegex holds the replace path regex middleware configuration. This middleware replaces the path of a URL using regex matching and replacement. More info: https://doc.traefik.io/traefik/v2.9/middlewares/http/replacepathregex/
    /// </summary>
    [OutputType]
    public sealed class MiddlewareSpecReplacepathregex
    {
        /// <summary>
        /// Regex defines the regular expression used to match and capture the path from the request URL.
        /// </summary>
        public readonly string Regex;
        /// <summary>
        /// Replacement defines the replacement path format, which can include captured variables.
        /// </summary>
        public readonly string Replacement;

        [OutputConstructor]
        private MiddlewareSpecReplacepathregex(
            string regex,

            string replacement)
        {
            Regex = regex;
            Replacement = replacement;
        }
    }
}
