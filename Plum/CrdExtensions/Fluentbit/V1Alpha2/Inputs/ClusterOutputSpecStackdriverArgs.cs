// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Fluentbit.V1Alpha2
{

    /// <summary>
    /// Stackdriver defines Stackdriver Output Configuration
    /// </summary>
    public class ClusterOutputSpecStackdriverArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Rewrite the trace field to be formatted for use with GCP Cloud Trace
        /// </summary>
        [Input("autoformatStackdriverTrace")]
        public Input<bool>? AutoformatStackdriverTrace { get; set; }

        /// <summary>
        /// A custom regex to extract fields from the local_resource_id of the logs
        /// </summary>
        [Input("customK8sRegex")]
        public Input<string>? CustomK8sRegex { get; set; }

        /// <summary>
        /// The GCP Project that should receive the logs
        /// </summary>
        [Input("exportToProjectID")]
        public Input<string>? ExportToProjectID { get; set; }

        /// <summary>
        /// Path to GCP Credentials JSON file
        /// </summary>
        [Input("googleServiceCredentials")]
        public Input<string>? GoogleServiceCredentials { get; set; }

        /// <summary>
        /// Identifier for a grouping of tasks. Required if Resource is generic_task
        /// </summary>
        [Input("job")]
        public Input<string>? Job { get; set; }

        /// <summary>
        /// Location of the cluster that contains the pods/nodes. Required if Resource is k8s_container, k8s_node, or k8s_pod
        /// </summary>
        [Input("k8sClusterLocation")]
        public Input<string>? K8sClusterLocation { get; set; }

        /// <summary>
        /// Name of the cluster that the pod is running in. Required if Resource is k8s_container, k8s_node, or k8s_pod
        /// </summary>
        [Input("k8sClusterName")]
        public Input<string>? K8sClusterName { get; set; }

        [Input("labels")]
        private InputList<string>? _labels;

        /// <summary>
        /// Optional list of comma separated of strings for key/value pairs
        /// </summary>
        public InputList<string> Labels
        {
            get => _labels ?? (_labels = new InputList<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Used by Stackdriver to find related labels and extract them to LogEntry Labels
        /// </summary>
        [Input("labelsKey")]
        public Input<string>? LabelsKey { get; set; }

        /// <summary>
        /// GCP/AWS region to store data. Required if Resource is generic_node or generic_task
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The value of this field is set as the logName field in Stackdriver
        /// </summary>
        [Input("logNameKey")]
        public Input<string>? LogNameKey { get; set; }

        /// <summary>
        /// Metadata Server Prefix
        /// </summary>
        [Input("metadataServer")]
        public Input<string>? MetadataServer { get; set; }

        /// <summary>
        /// Namespace identifier. Required if Resource is generic_node or generic_task
        /// </summary>
        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        /// <summary>
        /// Node identifier within the namespace. Required if Resource is generic_node or generic_task
        /// </summary>
        [Input("nodeID")]
        public Input<string>? NodeID { get; set; }

        /// <summary>
        /// Set resource types of data
        /// </summary>
        [Input("resource")]
        public Input<string>? Resource { get; set; }

        [Input("resourceLabels")]
        private InputList<string>? _resourceLabels;

        /// <summary>
        /// Optional list of comma seperated strings. Setting these fields overrides the Stackdriver monitored resource API values
        /// </summary>
        public InputList<string> ResourceLabels
        {
            get => _resourceLabels ?? (_resourceLabels = new InputList<string>());
            set => _resourceLabels = value;
        }

        /// <summary>
        /// Email associated with the service
        /// </summary>
        [Input("serviceAccountEmail")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Fluentbit.V1Alpha2.ClusterOutputSpecStackdriverServiceaccountemailArgs>? ServiceAccountEmail { get; set; }

        /// <summary>
        /// Private Key associated with the service
        /// </summary>
        [Input("serviceAccountSecret")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Fluentbit.V1Alpha2.ClusterOutputSpecStackdriverServiceaccountsecretArgs>? ServiceAccountSecret { get; set; }

        /// <summary>
        /// Specify the key that contains the severity information for the logs
        /// </summary>
        [Input("severityKey")]
        public Input<string>? SeverityKey { get; set; }

        /// <summary>
        /// Used to validate the tags of logs that when the Resource is k8s_container, k8s_node, or k8s_pod
        /// </summary>
        [Input("tagPrefix")]
        public Input<string>? TagPrefix { get; set; }

        /// <summary>
        /// Identifier for a task within a namespace. Required if Resource is generic_task
        /// </summary>
        [Input("taskID")]
        public Input<string>? TaskID { get; set; }

        /// <summary>
        /// Number of dedicated threads for the Stackdriver Output Plugin
        /// </summary>
        [Input("workers")]
        public Input<int>? Workers { get; set; }

        public ClusterOutputSpecStackdriverArgs()
        {
        }
        public static new ClusterOutputSpecStackdriverArgs Empty => new ClusterOutputSpecStackdriverArgs();
    }
}