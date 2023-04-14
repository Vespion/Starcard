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
    /// ClientAuth defines the server's policy for TLS Client Authentication.
    /// </summary>
    [OutputType]
    public sealed class TLSOptionSpecClientauth
    {
        /// <summary>
        /// ClientAuthType defines the client authentication type to apply.
        /// </summary>
        public readonly string ClientAuthType;
        /// <summary>
        /// SecretNames defines the names of the referenced Kubernetes Secret storing certificate details.
        /// </summary>
        public readonly ImmutableArray<string> SecretNames;

        [OutputConstructor]
        private TLSOptionSpecClientauth(
            string clientAuthType,

            ImmutableArray<string> secretNames)
        {
            ClientAuthType = clientAuthType;
            SecretNames = secretNames;
        }
    }
}
