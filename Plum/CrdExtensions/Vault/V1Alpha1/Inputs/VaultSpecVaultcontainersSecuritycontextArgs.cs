// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1
{

    public class VaultSpecVaultcontainersSecuritycontextArgs : global::Pulumi.ResourceArgs
    {
        [Input("allowPrivilegeEscalation")]
        public Input<bool>? AllowPrivilegeEscalation { get; set; }

        [Input("capabilities")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultcontainersSecuritycontextCapabilitiesArgs>? Capabilities { get; set; }

        [Input("privileged")]
        public Input<bool>? Privileged { get; set; }

        [Input("procMount")]
        public Input<string>? ProcMount { get; set; }

        [Input("readOnlyRootFilesystem")]
        public Input<bool>? ReadOnlyRootFilesystem { get; set; }

        [Input("runAsGroup")]
        public Input<int>? RunAsGroup { get; set; }

        [Input("runAsNonRoot")]
        public Input<bool>? RunAsNonRoot { get; set; }

        [Input("runAsUser")]
        public Input<int>? RunAsUser { get; set; }

        [Input("seLinuxOptions")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultcontainersSecuritycontextSelinuxoptionsArgs>? SeLinuxOptions { get; set; }

        [Input("seccompProfile")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultcontainersSecuritycontextSeccompprofileArgs>? SeccompProfile { get; set; }

        [Input("windowsOptions")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultcontainersSecuritycontextWindowsoptionsArgs>? WindowsOptions { get; set; }

        public VaultSpecVaultcontainersSecuritycontextArgs()
        {
        }
        public static new VaultSpecVaultcontainersSecuritycontextArgs Empty => new VaultSpecVaultcontainersSecuritycontextArgs();
    }
}