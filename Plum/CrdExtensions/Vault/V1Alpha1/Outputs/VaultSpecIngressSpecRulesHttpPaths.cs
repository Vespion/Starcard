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
    public sealed class VaultSpecIngressSpecRulesHttpPaths
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecIngressSpecRulesHttpPathsBackend Backend;
        public readonly string Path;
        public readonly string PathType;

        [OutputConstructor]
        private VaultSpecIngressSpecRulesHttpPaths(
            Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecIngressSpecRulesHttpPathsBackend backend,

            string path,

            string pathType)
        {
            Backend = backend;
            Path = path;
            PathType = pathType;
        }
    }
}