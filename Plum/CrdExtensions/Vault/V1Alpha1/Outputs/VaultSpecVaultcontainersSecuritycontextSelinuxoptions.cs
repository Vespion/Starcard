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
    public sealed class VaultSpecVaultcontainersSecuritycontextSelinuxoptions
    {
        public readonly string Level;
        public readonly string Role;
        public readonly string Type;
        public readonly string User;

        [OutputConstructor]
        private VaultSpecVaultcontainersSecuritycontextSelinuxoptions(
            string level,

            string role,

            string type,

            string user)
        {
            Level = level;
            Role = role;
            Type = type;
            User = user;
        }
    }
}
