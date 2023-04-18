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
    /// Name of the secret containing the initial credentials for the owner of the user database. If empty a new secret will be created from scratch
    /// </summary>
    [OutputType]
    public sealed class ClusterSpecBootstrapPg_basebackupSecret
    {
        /// <summary>
        /// Name of the referent.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private ClusterSpecBootstrapPg_basebackupSecret(string name)
        {
            Name = name;
        }
    }
}
