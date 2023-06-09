// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1
{

    [OutputType]
    public sealed class VaultSpecVaultpodspec
    {
        public readonly int ActiveDeadlineSeconds;
        public readonly Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecAffinity Affinity;
        public readonly bool AutomountServiceAccountToken;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecContainers> Containers;
        public readonly Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecDnsconfig DnsConfig;
        public readonly string DnsPolicy;
        public readonly bool EnableServiceLinks;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecEphemeralcontainers> EphemeralContainers;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecHostaliases> HostAliases;
        public readonly bool HostIPC;
        public readonly bool HostNetwork;
        public readonly bool HostPID;
        public readonly string Hostname;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecImagepullsecrets> ImagePullSecrets;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecInitcontainers> InitContainers;
        public readonly string NodeName;
        public readonly ImmutableDictionary<string, string> NodeSelector;
        public readonly ImmutableDictionary<string, Union<int, string>> Overhead;
        public readonly string PreemptionPolicy;
        public readonly int Priority;
        public readonly string PriorityClassName;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecReadinessgates> ReadinessGates;
        public readonly string RestartPolicy;
        public readonly string RuntimeClassName;
        public readonly string SchedulerName;
        public readonly Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecSecuritycontext SecurityContext;
        public readonly string ServiceAccount;
        public readonly string ServiceAccountName;
        public readonly bool SetHostnameAsFQDN;
        public readonly bool ShareProcessNamespace;
        public readonly string Subdomain;
        public readonly int TerminationGracePeriodSeconds;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecTolerations> Tolerations;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecTopologyspreadconstraints> TopologySpreadConstraints;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecVolumes> Volumes;

        [OutputConstructor]
        private VaultSpecVaultpodspec(
            int activeDeadlineSeconds,

            Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecAffinity affinity,

            bool automountServiceAccountToken,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecContainers> containers,

            Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecDnsconfig dnsConfig,

            string dnsPolicy,

            bool enableServiceLinks,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecEphemeralcontainers> ephemeralContainers,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecHostaliases> hostAliases,

            bool hostIPC,

            bool hostNetwork,

            bool hostPID,

            string hostname,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecImagepullsecrets> imagePullSecrets,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecInitcontainers> initContainers,

            string nodeName,

            ImmutableDictionary<string, string> nodeSelector,

            ImmutableDictionary<string, Union<int, string>> overhead,

            string preemptionPolicy,

            int priority,

            string priorityClassName,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecReadinessgates> readinessGates,

            string restartPolicy,

            string runtimeClassName,

            string schedulerName,

            Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecSecuritycontext securityContext,

            string serviceAccount,

            string serviceAccountName,

            bool setHostnameAsFQDN,

            bool shareProcessNamespace,

            string subdomain,

            int terminationGracePeriodSeconds,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecTolerations> tolerations,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecTopologyspreadconstraints> topologySpreadConstraints,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecVolumes> volumes)
        {
            ActiveDeadlineSeconds = activeDeadlineSeconds;
            Affinity = affinity;
            AutomountServiceAccountToken = automountServiceAccountToken;
            Containers = containers;
            DnsConfig = dnsConfig;
            DnsPolicy = dnsPolicy;
            EnableServiceLinks = enableServiceLinks;
            EphemeralContainers = ephemeralContainers;
            HostAliases = hostAliases;
            HostIPC = hostIPC;
            HostNetwork = hostNetwork;
            HostPID = hostPID;
            Hostname = hostname;
            ImagePullSecrets = imagePullSecrets;
            InitContainers = initContainers;
            NodeName = nodeName;
            NodeSelector = nodeSelector;
            Overhead = overhead;
            PreemptionPolicy = preemptionPolicy;
            Priority = priority;
            PriorityClassName = priorityClassName;
            ReadinessGates = readinessGates;
            RestartPolicy = restartPolicy;
            RuntimeClassName = runtimeClassName;
            SchedulerName = schedulerName;
            SecurityContext = securityContext;
            ServiceAccount = serviceAccount;
            ServiceAccountName = serviceAccountName;
            SetHostnameAsFQDN = setHostnameAsFQDN;
            ShareProcessNamespace = shareProcessNamespace;
            Subdomain = subdomain;
            TerminationGracePeriodSeconds = terminationGracePeriodSeconds;
            Tolerations = tolerations;
            TopologySpreadConstraints = topologySpreadConstraints;
            Volumes = volumes;
        }
    }
}
