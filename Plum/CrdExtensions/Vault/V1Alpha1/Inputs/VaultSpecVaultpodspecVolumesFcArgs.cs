// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1
{

    public class VaultSpecVaultpodspecVolumesFcArgs : global::Pulumi.ResourceArgs
    {
        [Input("fsType")]
        public Input<string>? FsType { get; set; }

        [Input("lun")]
        public Input<int>? Lun { get; set; }

        [Input("readOnly")]
        public Input<bool>? ReadOnly { get; set; }

        [Input("targetWWNs")]
        private InputList<string>? _targetWWNs;
        public InputList<string> TargetWWNs
        {
            get => _targetWWNs ?? (_targetWWNs = new InputList<string>());
            set => _targetWWNs = value;
        }

        [Input("wwids")]
        private InputList<string>? _wwids;
        public InputList<string> Wwids
        {
            get => _wwids ?? (_wwids = new InputList<string>());
            set => _wwids = value;
        }

        public VaultSpecVaultpodspecVolumesFcArgs()
        {
        }
        public static new VaultSpecVaultpodspecVolumesFcArgs Empty => new VaultSpecVaultpodspecVolumesFcArgs();
    }
}
