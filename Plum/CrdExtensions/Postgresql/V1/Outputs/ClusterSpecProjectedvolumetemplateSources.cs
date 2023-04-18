// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Postgresql.V1
{

    /// <summary>
    /// Projection that may be projected along with other supported volume types
    /// </summary>
    [OutputType]
    public sealed class ClusterSpecProjectedvolumetemplateSources
    {
        /// <summary>
        /// configMap information about the configMap data to project
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterSpecProjectedvolumetemplateSourcesConfigmap ConfigMap;
        /// <summary>
        /// downwardAPI information about the downwardAPI data to project
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterSpecProjectedvolumetemplateSourcesDownwardapi DownwardAPI;
        /// <summary>
        /// secret information about the secret data to project
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterSpecProjectedvolumetemplateSourcesSecret Secret;
        /// <summary>
        /// serviceAccountToken is information about the serviceAccountToken data to project
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterSpecProjectedvolumetemplateSourcesServiceaccounttoken ServiceAccountToken;

        [OutputConstructor]
        private ClusterSpecProjectedvolumetemplateSources(
            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterSpecProjectedvolumetemplateSourcesConfigmap configMap,

            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterSpecProjectedvolumetemplateSourcesDownwardapi downwardAPI,

            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterSpecProjectedvolumetemplateSourcesSecret secret,

            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterSpecProjectedvolumetemplateSourcesServiceaccounttoken serviceAccountToken)
        {
            ConfigMap = configMap;
            DownwardAPI = downwardAPI;
            Secret = secret;
            ServiceAccountToken = serviceAccountToken;
        }
    }
}
