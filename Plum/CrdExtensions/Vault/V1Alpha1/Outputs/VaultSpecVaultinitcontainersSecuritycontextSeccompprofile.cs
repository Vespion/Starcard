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
    public sealed class VaultSpecVaultinitcontainersSecuritycontextSeccompprofile
    {
        public readonly string LocalhostProfile;
        public readonly string Type;

        [OutputConstructor]
        private VaultSpecVaultinitcontainersSecuritycontextSeccompprofile(
            string localhostProfile,

            string type)
        {
            LocalhostProfile = localhostProfile;
            Type = type;
        }
    }
}
