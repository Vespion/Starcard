// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;

namespace Pulumi.Kubernetes.Types.Outputs.Seaweed.V1
{

    /// <summary>
    /// Volume
    /// </summary>
    [OutputType]
    public sealed class SeaweedSpecVolume
    {
        /// <summary>
        /// Affinity of the component. Override the cluster-level one if present
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecVolumeAffinity Affinity;
        /// <summary>
        /// Annotations of the component. Merged into the cluster-level annotations if non-empty
        /// </summary>
        public readonly ImmutableDictionary<string, string> Annotations;
        public readonly int CompactionMBps;
        /// <summary>
        /// List of environment variables to set in the container, like v1.Container.Env. Note that following env names cannot be used and may be overrided by operators - NAMESPACE - POD_IP - POD_NAME
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecVolumeEnv> Env;
        public readonly int FileSizeLimitMB;
        public readonly bool FixJpgOrientation;
        /// <summary>
        /// Whether Hostnetwork of the component is enabled. Override the cluster-level setting if present
        /// </summary>
        public readonly bool HostNetwork;
        public readonly int IdleTimeout;
        /// <summary>
        /// ImagePullPolicy of the component. Override the cluster-level imagePullPolicy if present
        /// </summary>
        public readonly string ImagePullPolicy;
        /// <summary>
        /// ImagePullSecrets is an optional list of references to secrets in the same namespace to use for pulling any of the images.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecVolumeImagepullsecrets> ImagePullSecrets;
        /// <summary>
        /// Limits describes the maximum amount of compute resources allowed. More info: https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/
        /// </summary>
        public readonly ImmutableDictionary<string, Union<int, string>> Limits;
        public readonly int MaxVolumeCounts;
        public readonly int MetricsPort;
        public readonly int MinFreeSpacePercent;
        /// <summary>
        /// NodeSelector of the component. Merged into the cluster-level nodeSelector if non-empty
        /// </summary>
        public readonly ImmutableDictionary<string, string> NodeSelector;
        /// <summary>
        /// PriorityClassName of the component. Override the cluster-level one if present
        /// </summary>
        public readonly string PriorityClassName;
        /// <summary>
        /// The desired ready replicas
        /// </summary>
        public readonly int Replicas;
        /// <summary>
        /// Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. More info: https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/
        /// </summary>
        public readonly ImmutableDictionary<string, Union<int, string>> Requests;
        /// <summary>
        /// SchedulerName of the component. Override the cluster-level one if present
        /// </summary>
        public readonly string SchedulerName;
        /// <summary>
        /// ServiceSpec is a subset of the original k8s spec
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecVolumeService Service;
        /// <summary>
        /// StatefulSetUpdateStrategy indicates the StatefulSetUpdateStrategy that will be employed to update Pods in the StatefulSet when a revision is made to Template.
        /// </summary>
        public readonly string StatefulSetUpdateStrategy;
        public readonly string StorageClassName;
        /// <summary>
        /// Optional duration in seconds the pod needs to terminate gracefully. May be decreased in delete request. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period will be used instead. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. Defaults to 30 seconds.
        /// </summary>
        public readonly int TerminationGracePeriodSeconds;
        /// <summary>
        /// Tolerations of the component. Override the cluster-level tolerations if non-empty
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecVolumeTolerations> Tolerations;
        /// <summary>
        /// Version of the component. Override the cluster-level version if non-empty
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private SeaweedSpecVolume(
            Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecVolumeAffinity affinity,

            ImmutableDictionary<string, string> annotations,

            int compactionMBps,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecVolumeEnv> env,

            int fileSizeLimitMB,

            bool fixJpgOrientation,

            bool hostNetwork,

            int idleTimeout,

            string imagePullPolicy,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecVolumeImagepullsecrets> imagePullSecrets,

            ImmutableDictionary<string, Union<int, string>> limits,

            int maxVolumeCounts,

            int metricsPort,

            int minFreeSpacePercent,

            ImmutableDictionary<string, string> nodeSelector,

            string priorityClassName,

            int replicas,

            ImmutableDictionary<string, Union<int, string>> requests,

            string schedulerName,

            Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecVolumeService service,

            string statefulSetUpdateStrategy,

            string storageClassName,

            int terminationGracePeriodSeconds,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecVolumeTolerations> tolerations,

            string version)
        {
            Affinity = affinity;
            Annotations = annotations;
            CompactionMBps = compactionMBps;
            Env = env;
            FileSizeLimitMB = fileSizeLimitMB;
            FixJpgOrientation = fixJpgOrientation;
            HostNetwork = hostNetwork;
            IdleTimeout = idleTimeout;
            ImagePullPolicy = imagePullPolicy;
            ImagePullSecrets = imagePullSecrets;
            Limits = limits;
            MaxVolumeCounts = maxVolumeCounts;
            MetricsPort = metricsPort;
            MinFreeSpacePercent = minFreeSpacePercent;
            NodeSelector = nodeSelector;
            PriorityClassName = priorityClassName;
            Replicas = replicas;
            Requests = requests;
            SchedulerName = schedulerName;
            Service = service;
            StatefulSetUpdateStrategy = statefulSetUpdateStrategy;
            StorageClassName = storageClassName;
            TerminationGracePeriodSeconds = terminationGracePeriodSeconds;
            Tolerations = tolerations;
            Version = version;
        }
    }
}
