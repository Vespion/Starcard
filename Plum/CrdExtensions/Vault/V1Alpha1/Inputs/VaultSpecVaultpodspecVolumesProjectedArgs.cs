// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1
{

    public class VaultSpecVaultpodspecVolumesProjectedArgs : global::Pulumi.ResourceArgs
    {
        [Input("defaultMode")]
        public Input<int>? DefaultMode { get; set; }

        [Input("sources")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecVolumesProjectedSourcesArgs>? _sources;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecVolumesProjectedSourcesArgs> Sources
        {
            get => _sources ?? (_sources = new InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecVolumesProjectedSourcesArgs>());
            set => _sources = value;
        }

        public VaultSpecVaultpodspecVolumesProjectedArgs()
        {
        }
        public static new VaultSpecVaultpodspecVolumesProjectedArgs Empty => new VaultSpecVaultpodspecVolumesProjectedArgs();
    }
}
