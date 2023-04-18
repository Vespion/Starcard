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
    /// Information to identify the instance where the backup has been taken from
    /// </summary>
    [OutputType]
    public sealed class BackupStatusInstanceid
    {
        /// <summary>
        /// The container ID
        /// </summary>
        public readonly string ContainerID;
        /// <summary>
        /// The pod name
        /// </summary>
        public readonly string PodName;

        [OutputConstructor]
        private BackupStatusInstanceid(
            string ContainerID,

            string podName)
        {
            this.ContainerID = ContainerID;
            PodName = podName;
        }
    }
}