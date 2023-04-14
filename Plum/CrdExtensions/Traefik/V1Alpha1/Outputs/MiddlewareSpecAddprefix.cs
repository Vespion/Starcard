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
    /// AddPrefix holds the add prefix middleware configuration. This middleware updates the path of a request before forwarding it. More info: https://doc.traefik.io/traefik/v2.9/middlewares/http/addprefix/
    /// </summary>
    [OutputType]
    public sealed class MiddlewareSpecAddprefix
    {
        /// <summary>
        /// Prefix is the string to add before the current path in the requested URL. It should include a leading slash (/).
        /// </summary>
        public readonly string Prefix;

        [OutputConstructor]
        private MiddlewareSpecAddprefix(string prefix)
        {
            Prefix = prefix;
        }
    }
}
