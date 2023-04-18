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
    /// The credentials to use to upload data to Azure Blob Storage
    /// </summary>
    public class ClusterSpecBackupBarmanobjectstoreAzurecredentialsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The connection string to be used
        /// </summary>
        [Input("connectionString")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.ClusterSpecBackupBarmanobjectstoreAzurecredentialsConnectionstringArgs>? ConnectionString { get; set; }

        /// <summary>
        /// Use the Azure AD based authentication without providing explicitly the keys.
        /// </summary>
        [Input("inheritFromAzureAD")]
        public Input<bool>? InheritFromAzureAD { get; set; }

        /// <summary>
        /// The storage account where to upload data
        /// </summary>
        [Input("storageAccount")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.ClusterSpecBackupBarmanobjectstoreAzurecredentialsStorageaccountArgs>? StorageAccount { get; set; }

        /// <summary>
        /// The storage account key to be used in conjunction with the storage account name
        /// </summary>
        [Input("storageKey")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.ClusterSpecBackupBarmanobjectstoreAzurecredentialsStoragekeyArgs>? StorageKey { get; set; }

        /// <summary>
        /// A shared-access-signature to be used in conjunction with the storage account name
        /// </summary>
        [Input("storageSasToken")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.ClusterSpecBackupBarmanobjectstoreAzurecredentialsStoragesastokenArgs>? StorageSasToken { get; set; }

        public ClusterSpecBackupBarmanobjectstoreAzurecredentialsArgs()
        {
        }
        public static new ClusterSpecBackupBarmanobjectstoreAzurecredentialsArgs Empty => new ClusterSpecBackupBarmanobjectstoreAzurecredentialsArgs();
    }
}
