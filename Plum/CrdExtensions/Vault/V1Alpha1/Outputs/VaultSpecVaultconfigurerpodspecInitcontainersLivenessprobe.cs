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
    public sealed class VaultSpecVaultconfigurerpodspecInitcontainersLivenessprobe
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecInitcontainersLivenessprobeExec Exec;
        public readonly int FailureThreshold;
        public readonly Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecInitcontainersLivenessprobeHttpget HttpGet;
        public readonly int InitialDelaySeconds;
        public readonly int PeriodSeconds;
        public readonly int SuccessThreshold;
        public readonly Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecInitcontainersLivenessprobeTcpsocket TcpSocket;
        public readonly int TerminationGracePeriodSeconds;
        public readonly int TimeoutSeconds;

        [OutputConstructor]
        private VaultSpecVaultconfigurerpodspecInitcontainersLivenessprobe(
            Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecInitcontainersLivenessprobeExec exec,

            int failureThreshold,

            Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecInitcontainersLivenessprobeHttpget httpGet,

            int initialDelaySeconds,

            int periodSeconds,

            int successThreshold,

            Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecInitcontainersLivenessprobeTcpsocket tcpSocket,

            int terminationGracePeriodSeconds,

            int timeoutSeconds)
        {
            Exec = exec;
            FailureThreshold = failureThreshold;
            HttpGet = httpGet;
            InitialDelaySeconds = initialDelaySeconds;
            PeriodSeconds = periodSeconds;
            SuccessThreshold = successThreshold;
            TcpSocket = tcpSocket;
            TerminationGracePeriodSeconds = terminationGracePeriodSeconds;
            TimeoutSeconds = timeoutSeconds;
        }
    }
}