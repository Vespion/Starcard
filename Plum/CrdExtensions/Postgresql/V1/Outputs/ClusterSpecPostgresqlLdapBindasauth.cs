// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Postgresql.V1
{

    /// <summary>
    /// Bind as authentication configuration
    /// </summary>
    [OutputType]
    public sealed class ClusterSpecPostgresqlLdapBindasauth
    {
        /// <summary>
        /// Prefix for the bind authentication option
        /// </summary>
        public readonly string Prefix;
        /// <summary>
        /// Suffix for the bind authentication option
        /// </summary>
        public readonly string Suffix;

        [OutputConstructor]
        private ClusterSpecPostgresqlLdapBindasauth(
            string prefix,

            string suffix)
        {
            Prefix = prefix;
            Suffix = suffix;
        }
    }
}
