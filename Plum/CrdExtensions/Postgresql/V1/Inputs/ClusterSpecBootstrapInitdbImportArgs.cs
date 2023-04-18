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
    /// Bootstraps the new cluster by importing data from an existing PostgreSQL instance using logical backup (`pg_dump` and `pg_restore`)
    /// </summary>
    public class ClusterSpecBootstrapInitdbImportArgs : global::Pulumi.ResourceArgs
    {
        [Input("databases", required: true)]
        private InputList<string>? _databases;

        /// <summary>
        /// The databases to import
        /// </summary>
        public InputList<string> Databases
        {
            get => _databases ?? (_databases = new InputList<string>());
            set => _databases = value;
        }

        [Input("postImportApplicationSQL")]
        private InputList<string>? _postImportApplicationSQL;

        /// <summary>
        /// List of SQL queries to be executed as a superuser in the application database right after is imported - to be used with extreme care (by default empty). Only available in microservice type.
        /// </summary>
        public InputList<string> PostImportApplicationSQL
        {
            get => _postImportApplicationSQL ?? (_postImportApplicationSQL = new InputList<string>());
            set => _postImportApplicationSQL = value;
        }

        [Input("roles")]
        private InputList<string>? _roles;

        /// <summary>
        /// The roles to import
        /// </summary>
        public InputList<string> Roles
        {
            get => _roles ?? (_roles = new InputList<string>());
            set => _roles = value;
        }

        /// <summary>
        /// The source of the import
        /// </summary>
        [Input("source", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.ClusterSpecBootstrapInitdbImportSourceArgs> Source { get; set; } = null!;

        /// <summary>
        /// The import type. Can be `microservice` or `monolith`.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public ClusterSpecBootstrapInitdbImportArgs()
        {
        }
        public static new ClusterSpecBootstrapInitdbImportArgs Empty => new ClusterSpecBootstrapInitdbImportArgs();
    }
}