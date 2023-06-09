// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Postgresql.V1
{

    /// <summary>
    /// The configuration to be used for backups
    /// </summary>
    public class ClusterSpecBackupArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The configuration for the barman-cloud tool suite
        /// </summary>
        [Input("barmanObjectStore")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.ClusterSpecBackupBarmanobjectstoreArgs>? BarmanObjectStore { get; set; }

        /// <summary>
        /// RetentionPolicy is the retention policy to be used for backups and WALs (i.e. '60d'). The retention policy is expressed in the form of `XXu` where `XX` is a positive integer and `u` is in `[dwm]` - days, weeks, months.
        /// </summary>
        [Input("retentionPolicy")]
        public Input<string>? RetentionPolicy { get; set; }

        /// <summary>
        /// The policy to decide which instance should perform backups. Available options are empty string, which will default to `primary` policy, `primary` to have backups run always on primary instances, `prefer-standby` to have backups run preferably on the most updated standby, if available.
        /// </summary>
        [Input("target")]
        public Input<string>? Target { get; set; }

        public ClusterSpecBackupArgs()
        {
            Target = "primary";
        }
        public static new ClusterSpecBackupArgs Empty => new ClusterSpecBackupArgs();
    }
}
