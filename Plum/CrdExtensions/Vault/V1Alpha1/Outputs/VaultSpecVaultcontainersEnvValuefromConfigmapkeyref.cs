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
    public sealed class VaultSpecVaultcontainersEnvValuefromConfigmapkeyref
    {
        public readonly string Key;
        public readonly string Name;
        public readonly bool Optional;

        [OutputConstructor]
        private VaultSpecVaultcontainersEnvValuefromConfigmapkeyref(
            string key,

            string name,

            bool optional)
        {
            Key = key;
            Name = name;
            Optional = optional;
        }
    }
}
