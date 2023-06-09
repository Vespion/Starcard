// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2
{

    /// <summary>
    /// Elasticsearch defines Elasticsearch Output configuration.
    /// </summary>
    [OutputType]
    public sealed class ClusterOutputSpecEs
    {
        /// <summary>
        /// Enable AWS Sigv4 Authentication for Amazon ElasticSearch Service.
        /// </summary>
        public readonly string AwsAuth;
        /// <summary>
        /// External ID for the AWS IAM Role specified with aws_role_arn.
        /// </summary>
        public readonly string AwsExternalID;
        /// <summary>
        /// Specify the AWS region for Amazon ElasticSearch Service.
        /// </summary>
        public readonly string AwsRegion;
        /// <summary>
        /// AWS IAM Role to assume to put records to your Amazon ES cluster.
        /// </summary>
        public readonly string AwsRoleARN;
        /// <summary>
        /// Specify the custom sts endpoint to be used with STS API for Amazon ElasticSearch Service.
        /// </summary>
        public readonly string AwsSTSEndpoint;
        /// <summary>
        /// Specify the buffer size used to read the response from the Elasticsearch HTTP service. This option is useful for debugging purposes where is required to read full responses, note that response size grows depending of the number of records inserted. To set an unlimited amount of memory set this value to False, otherwise the value must be according to the Unit Size specification.
        /// </summary>
        public readonly string BufferSize;
        /// <summary>
        /// Specify the credentials to use to connect to Elastic's Elasticsearch Service running on Elastic Cloud.
        /// </summary>
        public readonly string CloudAuth;
        /// <summary>
        /// If you are using Elastic's Elasticsearch Service you can specify the cloud_id of the cluster running.
        /// </summary>
        public readonly string CloudID;
        /// <summary>
        /// Use current time for index generation instead of message record
        /// </summary>
        public readonly bool CurrentTimeIndex;
        /// <summary>
        /// When enabled, generate _id for outgoing records. This prevents duplicate records when retrying ES.
        /// </summary>
        public readonly bool GenerateID;
        /// <summary>
        /// IP address or hostname of the target Elasticsearch instance
        /// </summary>
        public readonly string Host;
        /// <summary>
        /// Password for user defined in HTTP_User
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterOutputSpecEsHttppassword HttpPassword;
        /// <summary>
        /// Optional username credential for Elastic X-Pack access
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterOutputSpecEsHttpuser HttpUser;
        /// <summary>
        /// If set, _id will be the value of the key from incoming record and Generate_ID option is ignored.
        /// </summary>
        public readonly string IdKey;
        /// <summary>
        /// When enabled, it append the Tag name to the record.
        /// </summary>
        public readonly bool IncludeTagKey;
        /// <summary>
        /// Index name
        /// </summary>
        public readonly string Index;
        /// <summary>
        /// Time format (based on strftime) to generate the second part of the Index name.
        /// </summary>
        public readonly string LogstashDateFormat;
        /// <summary>
        /// Enable Logstash format compatibility. This option takes a boolean value: True/False, On/Off
        /// </summary>
        public readonly bool LogstashFormat;
        /// <summary>
        /// When Logstash_Format is enabled, the Index name is composed using a prefix and the date, e.g: If Logstash_Prefix is equals to 'mydata' your index will become 'mydata-YYYY.MM.DD'. The last string appended belongs to the date when the data is being generated.
        /// </summary>
        public readonly string LogstashPrefix;
        /// <summary>
        /// Prefix keys with this string
        /// </summary>
        public readonly string LogstashPrefixKey;
        /// <summary>
        /// Elasticsearch accepts new data on HTTP query path "/_bulk". But it is also possible to serve Elasticsearch behind a reverse proxy on a subpath. This option defines such path on the fluent-bit side. It simply adds a path prefix in the indexing HTTP POST URI.
        /// </summary>
        public readonly string Path;
        /// <summary>
        /// Newer versions of Elasticsearch allows setting up filters called pipelines. This option allows defining which pipeline the database should use. For performance reasons is strongly suggested parsing and filtering on Fluent Bit side, avoid pipelines.
        /// </summary>
        public readonly string Pipeline;
        /// <summary>
        /// TCP port of the target Elasticsearch instance
        /// </summary>
        public readonly int Port;
        /// <summary>
        /// When enabled, replace field name dots with underscore, required by Elasticsearch 2.0-2.3.
        /// </summary>
        public readonly bool ReplaceDots;
        /// <summary>
        /// When enabled, mapping types is removed and Type option is ignored. Types are deprecated in APIs in v7.0. This options is for v7.0 or later.
        /// </summary>
        public readonly string SuppressTypeName;
        /// <summary>
        /// When Include_Tag_Key is enabled, this property defines the key name for the tag.
        /// </summary>
        public readonly string TagKey;
        /// <summary>
        /// When Logstash_Format is enabled, each record will get a new timestamp field. The Time_Key property defines the name of that field.
        /// </summary>
        public readonly string TimeKey;
        /// <summary>
        /// When Logstash_Format is enabled, this property defines the format of the timestamp.
        /// </summary>
        public readonly string TimeKeyFormat;
        /// <summary>
        /// When Logstash_Format is enabled, enabling this property sends nanosecond precision timestamps.
        /// </summary>
        public readonly bool TimeKeyNanos;
        /// <summary>
        /// Fluent Bit provides integrated support for Transport Layer Security (TLS) and it predecessor Secure Sockets Layer (SSL) respectively.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterOutputSpecEsTls Tls;
        /// <summary>
        /// When enabled print the elasticsearch API calls to stdout when elasticsearch returns an error
        /// </summary>
        public readonly bool TraceError;
        /// <summary>
        /// When enabled print the elasticsearch API calls to stdout (for diag only)
        /// </summary>
        public readonly bool TraceOutput;
        /// <summary>
        /// Type name
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ClusterOutputSpecEs(
            string awsAuth,

            string awsExternalID,

            string awsRegion,

            string awsRoleARN,

            string awsSTSEndpoint,

            string bufferSize,

            string cloudAuth,

            string cloudID,

            bool currentTimeIndex,

            bool generateID,

            string host,

            Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterOutputSpecEsHttppassword httpPassword,

            Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterOutputSpecEsHttpuser httpUser,

            string idKey,

            bool includeTagKey,

            string index,

            string logstashDateFormat,

            bool logstashFormat,

            string logstashPrefix,

            string logstashPrefixKey,

            string path,

            string pipeline,

            int port,

            bool replaceDots,

            string suppressTypeName,

            string tagKey,

            string timeKey,

            string timeKeyFormat,

            bool timeKeyNanos,

            Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterOutputSpecEsTls tls,

            bool traceError,

            bool traceOutput,

            string type)
        {
            AwsAuth = awsAuth;
            AwsExternalID = awsExternalID;
            AwsRegion = awsRegion;
            AwsRoleARN = awsRoleARN;
            AwsSTSEndpoint = awsSTSEndpoint;
            BufferSize = bufferSize;
            CloudAuth = cloudAuth;
            CloudID = cloudID;
            CurrentTimeIndex = currentTimeIndex;
            GenerateID = generateID;
            Host = host;
            HttpPassword = httpPassword;
            HttpUser = httpUser;
            IdKey = idKey;
            IncludeTagKey = includeTagKey;
            Index = index;
            LogstashDateFormat = logstashDateFormat;
            LogstashFormat = logstashFormat;
            LogstashPrefix = logstashPrefix;
            LogstashPrefixKey = logstashPrefixKey;
            Path = path;
            Pipeline = pipeline;
            Port = port;
            ReplaceDots = replaceDots;
            SuppressTypeName = suppressTypeName;
            TagKey = tagKey;
            TimeKey = timeKey;
            TimeKeyFormat = timeKeyFormat;
            TimeKeyNanos = timeKeyNanos;
            Tls = tls;
            TraceError = traceError;
            TraceOutput = traceOutput;
            Type = type;
        }
    }
}
