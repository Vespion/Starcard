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
    /// Specification of the desired behavior of the backup. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
    /// </summary>
    [OutputType]
    public sealed class BackupSpec
    {
        /// <summary>
        /// The cluster to backup
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.BackupSpecCluster Cluster;
        /// <summary>
        /// The policy to decide which instance should perform this backup. If empty, it defaults to `cluster.spec.backup.target`. Available options are empty string, which will default to `primary` policy, `primary` to have backups run always on primary instances, `prefer-standby` to have backups run preferably on the most updated standby, if available.
        /// </summary>
        public readonly string Target;

        [OutputConstructor]
        private BackupSpec(
            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.BackupSpecCluster cluster,

            string target)
        {
            Cluster = cluster;
            Target = target;
        }
    }
}