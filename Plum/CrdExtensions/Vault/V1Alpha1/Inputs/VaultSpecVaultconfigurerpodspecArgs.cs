// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1
{

    public class VaultSpecVaultconfigurerpodspecArgs : global::Pulumi.ResourceArgs
    {
        [Input("activeDeadlineSeconds")]
        public Input<int>? ActiveDeadlineSeconds { get; set; }

        [Input("affinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecAffinityArgs>? Affinity { get; set; }

        [Input("automountServiceAccountToken")]
        public Input<bool>? AutomountServiceAccountToken { get; set; }

        [Input("containers")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecContainersArgs>? _containers;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecContainersArgs> Containers
        {
            get => _containers ?? (_containers = new InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecContainersArgs>());
            set => _containers = value;
        }

        [Input("dnsConfig")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecDnsconfigArgs>? DnsConfig { get; set; }

        [Input("dnsPolicy")]
        public Input<string>? DnsPolicy { get; set; }

        [Input("enableServiceLinks")]
        public Input<bool>? EnableServiceLinks { get; set; }

        [Input("ephemeralContainers")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecEphemeralcontainersArgs>? _ephemeralContainers;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecEphemeralcontainersArgs> EphemeralContainers
        {
            get => _ephemeralContainers ?? (_ephemeralContainers = new InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecEphemeralcontainersArgs>());
            set => _ephemeralContainers = value;
        }

        [Input("hostAliases")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecHostaliasesArgs>? _hostAliases;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecHostaliasesArgs> HostAliases
        {
            get => _hostAliases ?? (_hostAliases = new InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecHostaliasesArgs>());
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
        private InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecImagepullsecretsArgs>? _imagePullSecrets;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecImagepullsecretsArgs> ImagePullSecrets
        {
            get => _imagePullSecrets ?? (_imagePullSecrets = new InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecImagepullsecretsArgs>());
            set => _imagePullSecrets = value;
        }

        [Input("initContainers")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecInitcontainersArgs>? _initContainers;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecInitcontainersArgs> InitContainers
        {
            get => _initContainers ?? (_initContainers = new InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecInitcontainersArgs>());
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
        private InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecReadinessgatesArgs>? _readinessGates;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecReadinessgatesArgs> ReadinessGates
        {
            get => _readinessGates ?? (_readinessGates = new InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecReadinessgatesArgs>());
            set => _readinessGates = value;
        }

        [Input("restartPolicy")]
        public Input<string>? RestartPolicy { get; set; }

        [Input("runtimeClassName")]
        public Input<string>? RuntimeClassName { get; set; }

        [Input("schedulerName")]
        public Input<string>? SchedulerName { get; set; }

        [Input("securityContext")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecSecuritycontextArgs>? SecurityContext { get; set; }

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
        private InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecTolerationsArgs>? _tolerations;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecTolerationsArgs> Tolerations
        {
            get => _tolerations ?? (_tolerations = new InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecTolerationsArgs>());
            set => _tolerations = value;
        }

        [Input("topologySpreadConstraints")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecTopologyspreadconstraintsArgs>? _topologySpreadConstraints;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecTopologyspreadconstraintsArgs> TopologySpreadConstraints
        {
            get => _topologySpreadConstraints ?? (_topologySpreadConstraints = new InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecTopologyspreadconstraintsArgs>());
            set => _topologySpreadConstraints = value;
        }

        [Input("volumes")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecVolumesArgs>? _volumes;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecVolumesArgs> Volumes
        {
            get => _volumes ?? (_volumes = new InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecVolumesArgs>());
            set => _volumes = value;
        }

        public VaultSpecVaultconfigurerpodspecArgs()
        {
        }
        public static new VaultSpecVaultconfigurerpodspecArgs Empty => new VaultSpecVaultconfigurerpodspecArgs();
    }
}
