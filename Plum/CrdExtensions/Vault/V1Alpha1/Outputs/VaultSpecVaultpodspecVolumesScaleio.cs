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
    public sealed class VaultSpecVaultpodspecVolumesScaleio
    {
        public readonly string FsType;
        public readonly string Gateway;
        public readonly string ProtectionDomain;
        public readonly bool ReadOnly;
        public readonly Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecVolumesScaleioSecretref SecretRef;
        public readonly bool SslEnabled;
        public readonly string StorageMode;
        public readonly string StoragePool;
        public readonly string System;
        public readonly string VolumeName;

        [OutputConstructor]
        private VaultSpecVaultpodspecVolumesScaleio(
            string fsType,

            string gateway,

            string protectionDomain,

            bool readOnly,

            Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecVolumesScaleioSecretref secretRef,

            bool sslEnabled,

            string storageMode,

            string storagePool,

            string system,

            string volumeName)
        {
            FsType = fsType;
            Gateway = gateway;
            ProtectionDomain = protectionDomain;
            ReadOnly = readOnly;
            SecretRef = secretRef;
            SslEnabled = sslEnabled;
            StorageMode = storageMode;
            StoragePool = storagePool;
            System = system;
            VolumeName = volumeName;
        }
    }
}
