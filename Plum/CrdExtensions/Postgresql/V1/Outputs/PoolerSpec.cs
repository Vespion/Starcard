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
    /// PoolerSpec defines the desired state of Pooler
    /// </summary>
    [OutputType]
    public sealed class PoolerSpec
    {
        /// <summary>
        /// This is the cluster reference on which the Pooler will work. Pooler name should never match with any cluster name within the same namespace.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerSpecCluster Cluster;
        /// <summary>
        /// The number of replicas we want
        /// </summary>
        public readonly int Instances;
        /// <summary>
        /// The PgBouncer configuration
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerSpecPgbouncer Pgbouncer;
        /// <summary>
        /// The template of the Pod to be created
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerSpecTemplate Template;
        /// <summary>
        /// Which instances we must forward traffic to?
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private PoolerSpec(
            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerSpecCluster cluster,

            int instances,

            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerSpecPgbouncer pgbouncer,

            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerSpecTemplate template,

            string type)
        {
            Cluster = cluster;
            Instances = instances;
            Pgbouncer = pgbouncer;
            Template = template;
            Type = type;
        }
    }
}
