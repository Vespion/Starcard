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
    /// The connection string to be used
    /// </summary>
    [OutputType]
    public sealed class ClusterSpecExternalclustersBarmanobjectstoreAzurecredentialsConnectionstring
    {
        /// <summary>
        /// The key to select
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// Name of the referent.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private ClusterSpecExternalclustersBarmanobjectstoreAzurecredentialsConnectionstring(
            string key,

            string name)
        {
            Key = key;
            Name = name;
        }
    }
}
