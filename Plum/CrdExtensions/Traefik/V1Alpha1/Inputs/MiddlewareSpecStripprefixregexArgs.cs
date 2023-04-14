// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Traefik.V1Alpha1
{

    /// <summary>
    /// StripPrefixRegex holds the strip prefix regex middleware configuration. This middleware removes the matching prefixes from the URL path. More info: https://doc.traefik.io/traefik/v2.9/middlewares/http/stripprefixregex/
    /// </summary>
    public class MiddlewareSpecStripprefixregexArgs : global::Pulumi.ResourceArgs
    {
        [Input("regex")]
        private InputList<string>? _regex;

        /// <summary>
        /// Regex defines the regular expression to match the path prefix from the request URL.
        /// </summary>
        public InputList<string> Regex
        {
            get => _regex ?? (_regex = new InputList<string>());
            set => _regex = value;
        }

        public MiddlewareSpecStripprefixregexArgs()
        {
        }
        public static new MiddlewareSpecStripprefixregexArgs Empty => new MiddlewareSpecStripprefixregexArgs();
    }
}
