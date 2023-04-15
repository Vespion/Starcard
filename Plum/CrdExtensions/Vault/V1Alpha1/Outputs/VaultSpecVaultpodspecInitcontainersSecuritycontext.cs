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
    public sealed class VaultSpecVaultpodspecInitcontainersSecuritycontext
    {
        public readonly bool AllowPrivilegeEscalation;
        public readonly Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecInitcontainersSecuritycontextCapabilities Capabilities;
        public readonly bool Privileged;
        public readonly string ProcMount;
        public readonly bool ReadOnlyRootFilesystem;
        public readonly int RunAsGroup;
        public readonly bool RunAsNonRoot;
        public readonly int RunAsUser;
        public readonly Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecInitcontainersSecuritycontextSelinuxoptions SeLinuxOptions;
        public readonly Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecInitcontainersSecuritycontextSeccompprofile SeccompProfile;
        public readonly Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecInitcontainersSecuritycontextWindowsoptions WindowsOptions;

        [OutputConstructor]
        private VaultSpecVaultpodspecInitcontainersSecuritycontext(
            bool allowPrivilegeEscalation,

            Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecInitcontainersSecuritycontextCapabilities capabilities,

            bool privileged,

            string procMount,

            bool readOnlyRootFilesystem,

            int runAsGroup,

            bool runAsNonRoot,

            int runAsUser,

            Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecInitcontainersSecuritycontextSelinuxoptions seLinuxOptions,

            Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecInitcontainersSecuritycontextSeccompprofile seccompProfile,

            Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecInitcontainersSecuritycontextWindowsoptions windowsOptions)
        {
            AllowPrivilegeEscalation = allowPrivilegeEscalation;
            Capabilities = capabilities;
            Privileged = privileged;
            ProcMount = procMount;
            ReadOnlyRootFilesystem = readOnlyRootFilesystem;
            RunAsGroup = runAsGroup;
            RunAsNonRoot = runAsNonRoot;
            RunAsUser = runAsUser;
            SeLinuxOptions = seLinuxOptions;
            SeccompProfile = seccompProfile;
            WindowsOptions = windowsOptions;
        }
    }
}