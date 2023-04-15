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
    public sealed class VaultSpecVaultpodspecInitcontainersLivenessprobeHttpget
    {
        public readonly string Host;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecInitcontainersLivenessprobeHttpgetHttpheaders> HttpHeaders;
        public readonly string Path;
        public readonly Union<int, string> Port;
        public readonly string Scheme;

        [OutputConstructor]
        private VaultSpecVaultpodspecInitcontainersLivenessprobeHttpget(
            string host,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecInitcontainersLivenessprobeHttpgetHttpheaders> httpHeaders,

            string path,

            Union<int, string> port,

            string scheme)
        {
            Host = host;
            HttpHeaders = httpHeaders;
            Path = path;
            Port = port;
            Scheme = scheme;
        }
    }
}
