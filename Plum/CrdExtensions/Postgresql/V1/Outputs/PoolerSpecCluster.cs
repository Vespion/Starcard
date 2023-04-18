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
    /// This is the cluster reference on which the Pooler will work. Pooler name should never match with any cluster name within the same namespace.
    /// </summary>
    [OutputType]
    public sealed class PoolerSpecCluster
    {
        /// <summary>
        /// Name of the referent.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private PoolerSpecCluster(string name)
        {
            Name = name;
        }
    }
}