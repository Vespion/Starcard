// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1
{

    public class VaultSpecVaultconfigurerpodspecHostaliasesArgs : global::Pulumi.ResourceArgs
    {
        [Input("hostnames")]
        private InputList<string>? _hostnames;
        public InputList<string> Hostnames
        {
            get => _hostnames ?? (_hostnames = new InputList<string>());
            set => _hostnames = value;
        }

        [Input("ip")]
        public Input<string>? Ip { get; set; }

        public VaultSpecVaultconfigurerpodspecHostaliasesArgs()
        {
        }
        public static new VaultSpecVaultconfigurerpodspecHostaliasesArgs Empty => new VaultSpecVaultconfigurerpodspecHostaliasesArgs();
    }
}
