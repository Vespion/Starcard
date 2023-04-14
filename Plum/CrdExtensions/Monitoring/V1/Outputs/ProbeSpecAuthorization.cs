// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Monitoring.V1
{

    /// <summary>
    /// Authorization section for this endpoint
    /// </summary>
    [OutputType]
    public sealed class ProbeSpecAuthorization
    {
        /// <summary>
        /// The secret's key that contains the credentials of the request
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ProbeSpecAuthorizationCredentials Credentials;
        /// <summary>
        /// Set the authentication type. Defaults to Bearer, Basic will cause an error
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ProbeSpecAuthorization(
            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ProbeSpecAuthorizationCredentials credentials,

            string type)
        {
            Credentials = credentials;
            Type = type;
        }
    }
}