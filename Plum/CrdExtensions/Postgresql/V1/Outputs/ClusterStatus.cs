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
    /// Most recently observed status of the cluster. This data may not be up to date. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
    /// </summary>
    [OutputType]
    public sealed class ClusterStatus
    {
        /// <summary>
        /// AzurePVCUpdateEnabled shows if the PVC online upgrade is enabled for this cluster
        /// </summary>
        public readonly bool AzurePVCUpdateEnabled;
        /// <summary>
        /// The configuration for the CA and related certificates, initialized with defaults.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterStatusCertificates Certificates;
        /// <summary>
        /// The commit hash number of which this operator running
        /// </summary>
        public readonly string CloudNativePGCommitHash;
        /// <summary>
        /// The hash of the binary of the operator
        /// </summary>
        public readonly string CloudNativePGOperatorHash;
        /// <summary>
        /// Conditions for cluster object
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterStatusConditions> Conditions;
        /// <summary>
        /// The list of resource versions of the configmaps, managed by the operator. Every change here is done in the interest of the instance manager, which will refresh the configmap data
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterStatusConfigmapresourceversion ConfigMapResourceVersion;
        /// <summary>
        /// Current primary instance
        /// </summary>
        public readonly string CurrentPrimary;
        /// <summary>
        /// The timestamp when the primary was detected to be unhealthy This field is reported when spec.failoverDelay is populated or during online upgrades
        /// </summary>
        public readonly string CurrentPrimaryFailingSinceTimestamp;
        /// <summary>
        /// The timestamp when the last actual promotion to primary has occurred
        /// </summary>
        public readonly string CurrentPrimaryTimestamp;
        /// <summary>
        /// List of all the PVCs created by this cluster and still available which are not attached to a Pod
        /// </summary>
        public readonly ImmutableArray<string> DanglingPVC;
        /// <summary>
        /// The first recoverability point, stored as a date in RFC3339 format
        /// </summary>
        public readonly string FirstRecoverabilityPoint;
        /// <summary>
        /// List of all the PVCs not dangling nor initializing
        /// </summary>
        public readonly ImmutableArray<string> HealthyPVC;
        /// <summary>
        /// List of all the PVCs that are being initialized by this cluster
        /// </summary>
        public readonly ImmutableArray<string> InitializingPVC;
        /// <summary>
        /// List of instance names in the cluster
        /// </summary>
        public readonly ImmutableArray<string> InstanceNames;
        /// <summary>
        /// Total number of instances in the cluster
        /// </summary>
        public readonly int Instances;
        /// <summary>
        /// the reported state of the instances during the last reconciliation loop
        /// </summary>
        public readonly ImmutableDictionary<string, Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterStatusInstancesreportedstate> InstancesReportedState;
        /// <summary>
        /// InstancesStatus indicates in which status the instances are
        /// </summary>
        public readonly ImmutableDictionary<string, ImmutableArray<string>> InstancesStatus;
        /// <summary>
        /// How many Jobs have been created by this cluster
        /// </summary>
        public readonly int JobCount;
        /// <summary>
        /// Stored as a date in RFC3339 format
        /// </summary>
        public readonly string LastFailedBackup;
        /// <summary>
        /// Stored as a date in RFC3339 format
        /// </summary>
        public readonly string LastSuccessfulBackup;
        /// <summary>
        /// ID of the latest generated node (used to avoid node name clashing)
        /// </summary>
        public readonly int LatestGeneratedNode;
        /// <summary>
        /// OnlineUpdateEnabled shows if the online upgrade is enabled inside the cluster
        /// </summary>
        public readonly bool OnlineUpdateEnabled;
        /// <summary>
        /// Current phase of the cluster
        /// </summary>
        public readonly string Phase;
        /// <summary>
        /// Reason for the current phase
        /// </summary>
        public readonly string PhaseReason;
        /// <summary>
        /// The integration needed by poolers referencing the cluster
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterStatusPoolerintegrations PoolerIntegrations;
        /// <summary>
        /// How many PVCs have been created by this cluster
        /// </summary>
        public readonly int PvcCount;
        /// <summary>
        /// Current list of read pods
        /// </summary>
        public readonly string ReadService;
        /// <summary>
        /// Total number of ready instances in the cluster
        /// </summary>
        public readonly int ReadyInstances;
        /// <summary>
        /// List of all the PVCs that have ResizingPVC condition.
        /// </summary>
        public readonly ImmutableArray<string> ResizingPVC;
        /// <summary>
        /// The list of resource versions of the secrets managed by the operator. Every change here is done in the interest of the instance manager, which will refresh the secret data
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterStatusSecretsresourceversion SecretsResourceVersion;
        /// <summary>
        /// Target primary instance, this is different from the previous one during a switchover or a failover
        /// </summary>
        public readonly string TargetPrimary;
        /// <summary>
        /// The timestamp when the last request for a new primary has occurred
        /// </summary>
        public readonly string TargetPrimaryTimestamp;
        /// <summary>
        /// The timeline of the Postgres cluster
        /// </summary>
        public readonly int TimelineID;
        /// <summary>
        /// Instances topology.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterStatusTopology Topology;
        /// <summary>
        /// List of all the PVCs that are unusable because another PVC is missing
        /// </summary>
        public readonly ImmutableArray<string> UnusablePVC;
        /// <summary>
        /// Current write pod
        /// </summary>
        public readonly string WriteService;

        [OutputConstructor]
        private ClusterStatus(
            bool azurePVCUpdateEnabled,

            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterStatusCertificates certificates,

            string cloudNativePGCommitHash,

            string cloudNativePGOperatorHash,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterStatusConditions> conditions,

            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterStatusConfigmapresourceversion configMapResourceVersion,

            string currentPrimary,

            string currentPrimaryFailingSinceTimestamp,

            string currentPrimaryTimestamp,

            ImmutableArray<string> danglingPVC,

            string firstRecoverabilityPoint,

            ImmutableArray<string> healthyPVC,

            ImmutableArray<string> initializingPVC,

            ImmutableArray<string> instanceNames,

            int instances,

            ImmutableDictionary<string, Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterStatusInstancesreportedstate> instancesReportedState,

            ImmutableDictionary<string, ImmutableArray<string>> instancesStatus,

            int jobCount,

            string lastFailedBackup,

            string lastSuccessfulBackup,

            int latestGeneratedNode,

            bool onlineUpdateEnabled,

            string phase,

            string phaseReason,

            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterStatusPoolerintegrations poolerIntegrations,

            int pvcCount,

            string readService,

            int readyInstances,

            ImmutableArray<string> resizingPVC,

            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterStatusSecretsresourceversion secretsResourceVersion,

            string targetPrimary,

            string targetPrimaryTimestamp,

            int timelineID,

            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterStatusTopology topology,

            ImmutableArray<string> unusablePVC,

            string writeService)
        {
            AzurePVCUpdateEnabled = azurePVCUpdateEnabled;
            Certificates = certificates;
            CloudNativePGCommitHash = cloudNativePGCommitHash;
            CloudNativePGOperatorHash = cloudNativePGOperatorHash;
            Conditions = conditions;
            ConfigMapResourceVersion = configMapResourceVersion;
            CurrentPrimary = currentPrimary;
            CurrentPrimaryFailingSinceTimestamp = currentPrimaryFailingSinceTimestamp;
            CurrentPrimaryTimestamp = currentPrimaryTimestamp;
            DanglingPVC = danglingPVC;
            FirstRecoverabilityPoint = firstRecoverabilityPoint;
            HealthyPVC = healthyPVC;
            InitializingPVC = initializingPVC;
            InstanceNames = instanceNames;
            Instances = instances;
            InstancesReportedState = instancesReportedState;
            InstancesStatus = instancesStatus;
            JobCount = jobCount;
            LastFailedBackup = lastFailedBackup;
            LastSuccessfulBackup = lastSuccessfulBackup;
            LatestGeneratedNode = latestGeneratedNode;
            OnlineUpdateEnabled = onlineUpdateEnabled;
            Phase = phase;
            PhaseReason = phaseReason;
            PoolerIntegrations = poolerIntegrations;
            PvcCount = pvcCount;
            ReadService = readService;
            ReadyInstances = readyInstances;
            ResizingPVC = resizingPVC;
            SecretsResourceVersion = secretsResourceVersion;
            TargetPrimary = targetPrimary;
            TargetPrimaryTimestamp = targetPrimaryTimestamp;
            TimelineID = timelineID;
            Topology = topology;
            UnusablePVC = unusablePVC;
            WriteService = writeService;
        }
    }
}
