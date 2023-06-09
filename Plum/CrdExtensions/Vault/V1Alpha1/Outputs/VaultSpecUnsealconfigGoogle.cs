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
    public sealed class VaultSpecUnsealconfigGoogle
    {
        public readonly string KmsCryptoKey;
        public readonly string KmsKeyRing;
        public readonly string KmsLocation;
        public readonly string KmsProject;
        public readonly string StorageBucket;

        [OutputConstructor]
        private VaultSpecUnsealconfigGoogle(
            string kmsCryptoKey,

            string kmsKeyRing,

            string kmsLocation,

            string kmsProject,

            string storageBucket)
        {
            KmsCryptoKey = kmsCryptoKey;
            KmsKeyRing = kmsKeyRing;
            KmsLocation = kmsLocation;
            KmsProject = kmsProject;
            StorageBucket = storageBucket;
        }
    }
}
