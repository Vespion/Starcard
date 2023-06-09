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
    public sealed class VaultSpecUnsealconfigVault
    {
        public readonly string Address;
        public readonly string AuthPath;
        public readonly string Role;
        public readonly string Token;
        public readonly string TokenPath;
        public readonly string UnsealKeysPath;

        [OutputConstructor]
        private VaultSpecUnsealconfigVault(
            string address,

            string authPath,

            string role,

            string token,

            string tokenPath,

            string unsealKeysPath)
        {
            Address = address;
            AuthPath = authPath;
            Role = role;
            Token = token;
            TokenPath = tokenPath;
            UnsealKeysPath = unsealKeysPath;
        }
    }
}
