// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1
{

    public class VaultSpecVaultpodspecArgs : global::Pulumi.ResourceArgs
    {
        [Input("activeDeadlineSeconds")]
        public Input<int>? ActiveDeadlineSeconds { get; set; }

        [Input("affinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecAffinityArgs>? Affinity { get; set; }

        [Input("automountServiceAccountToken")]
        public Input<bool>? AutomountServiceAccountToken { get; set; }

        [Input("containers")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecContainersArgs>? _containers;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecContainersArgs> Containers
        {
            get => _containers ?? (_containers = new InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecContainersArgs>());
            set => _containers = value;
        }

        [Input("dnsConfig")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecDnsconfigArgs>? DnsConfig { get; set; }

        [Input("dnsPolicy")]
        public Input<string>? DnsPolicy { get; set; }

        [Input("enableServiceLinks")]
        public Input<bool>? EnableServiceLinks { get; set; }

        [Input("ephemeralContainers")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecEphemeralcontainersArgs>? _ephemeralContainers;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecEphemeralcontainersArgs> EphemeralContainers
        {
            get => _ephemeralContainers ?? (_ephemeralContainers = new InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecEphemeralcontainersArgs>());
            set => _ephemeralContainers = value;
        }

        [Input("hostAliases")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecHostaliasesArgs>? _hostAliases;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecHostaliasesArgs> HostAliases
        {
            get => _hostAliases ?? (_hostAliases = new InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecHostaliasesArgs>());
            set => _hostAliases = value;
        }

        [Input("hostIPC")]
        public Input<bool>? HostIPC { get; set; }

        [Input("hostNetwork")]
        public Input<bool>? HostNetwork { get; set; }

        [Input("hostPID")]
        public Input<bool>? HostPID { get; set; }

        [Input("hostname")]
        public Input<string>? Hostname { get; set; }

        [Input("imagePullSecrets")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecImagepullsecretsArgs>? _imagePullSecrets;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecImagepullsecretsArgs> ImagePullSecrets
        {
            get => _imagePullSecrets ?? (_imagePullSecrets = new InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecImagepullsecretsArgs>());
            set => _imagePullSecrets = value;
        }

        [Input("initContainers")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecInitcontainersArgs>? _initContainers;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecInitcontainersArgs> InitContainers
        {
            get => _initContainers ?? (_initContainers = new InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecInitcontainersArgs>());
            set => _initContainers = value;
        }

        [Input("nodeName")]
        public Input<string>? NodeName { get; set; }

        [Input("nodeSelector")]
        private InputMap<string>? _nodeSelector;
        public InputMap<string> NodeSelector
        {
            get => _nodeSelector ?? (_nodeSelector = new InputMap<string>());
            set => _nodeSelector = value;
        }

        [Input("overhead")]
        private InputMap<Union<int, string>>? _overhead;
        public InputMap<Union<int, string>> Overhead
        {
            get => _overhead ?? (_overhead = new InputMap<Union<int, string>>());
            set => _overhead = value;
        }

        [Input("preemptionPolicy")]
        public Input<string>? PreemptionPolicy { get; set; }

        [Input("priority")]
        public Input<int>? Priority { get; set; }

        [Input("priorityClassName")]
        public Input<string>? PriorityClassName { get; set; }

        [Input("readinessGates")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecReadinessgatesArgs>? _readinessGates;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecReadinessgatesArgs> ReadinessGates
        {
            get => _readinessGates ?? (_readinessGates = new InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecReadinessgatesArgs>());
            set => _readinessGates = value;
        }

        [Input("restartPolicy")]
        public Input<string>? RestartPolicy { get; set; }

        [Input("runtimeClassName")]
        public Input<string>? RuntimeClassName { get; set; }

        [Input("schedulerName")]
        public Input<string>? SchedulerName { get; set; }

        [Input("securityContext")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecSecuritycontextArgs>? SecurityContext { get; set; }

        [Input("serviceAccount")]
        public Input<string>? ServiceAccount { get; set; }

        [Input("serviceAccountName")]
        public Input<string>? ServiceAccountName { get; set; }

        [Input("setHostnameAsFQDN")]
        public Input<bool>? SetHostnameAsFQDN { get; set; }

        [Input("shareProcessNamespace")]
        public Input<bool>? ShareProcessNamespace { get; set; }

        [Input("subdomain")]
        public Input<string>? Subdomain { get; set; }

        [Input("terminationGracePeriodSeconds")]
        public Input<int>? TerminationGracePeriodSeconds { get; set; }

        [Input("tolerations")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecTolerationsArgs>? _tolerations;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecTolerationsArgs> Tolerations
        {
            get => _tolerations ?? (_tolerations = new InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecTolerationsArgs>());
            set => _tolerations = value;
        }

        [Input("topologySpreadConstraints")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecTopologyspreadconstraintsArgs>? _topologySpreadConstraints;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecTopologyspreadconstraintsArgs> TopologySpreadConstraints
        {
            get => _topologySpreadConstraints ?? (_topologySpreadConstraints = new InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecTopologyspreadconstraintsArgs>());
            set => _topologySpreadConstraints = value;
        }

        [Input("volumes")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecVolumesArgs>? _volumes;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecVolumesArgs> Volumes
        {
            get => _volumes ?? (_volumes = new InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecVolumesArgs>());
            set => _volumes = value;
        }

        public VaultSpecVaultpodspecArgs()
        {
        }
        public static new VaultSpecVaultpodspecArgs Empty => new VaultSpecVaultpodspecArgs();
    }
}