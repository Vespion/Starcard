// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1
{

    public class VaultSpecVaultinitcontainersSecuritycontextSeccompprofileArgs : global::Pulumi.ResourceArgs
    {
        [Input("localhostProfile")]
        public Input<string>? LocalhostProfile { get; set; }

        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public VaultSpecVaultinitcontainersSecuritycontextSeccompprofileArgs()
        {
        }
        public static new VaultSpecVaultinitcontainersSecuritycontextSeccompprofileArgs Empty => new VaultSpecVaultinitcontainersSecuritycontextSeccompprofileArgs();
    }
}
