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
    /// PoolerStatus defines the observed state of Pooler
    /// </summary>
    [OutputType]
    public sealed class PoolerStatus
    {
        /// <summary>
        /// The number of pods trying to be scheduled
        /// </summary>
        public readonly int Instances;
        /// <summary>
        /// The resource version of the config object
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerStatusSecrets Secrets;

        [OutputConstructor]
        private PoolerStatus(
            int instances,

            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerStatusSecrets secrets)
        {
            Instances = instances;
            Secrets = secrets;
        }
    }
}
