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
    /// The integration needed by poolers referencing the cluster
    /// </summary>
    [OutputType]
    public sealed class ClusterStatusPoolerintegrations
    {
        /// <summary>
        /// PgBouncerIntegrationStatus encapsulates the needed integration for the pgbouncer poolers referencing the cluster
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterStatusPoolerintegrationsPgbouncerintegration PgBouncerIntegration;

        [OutputConstructor]
        private ClusterStatusPoolerintegrations(Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterStatusPoolerintegrationsPgbouncerintegration pgBouncerIntegration)
        {
            PgBouncerIntegration = pgBouncerIntegration;
        }
    }
}
