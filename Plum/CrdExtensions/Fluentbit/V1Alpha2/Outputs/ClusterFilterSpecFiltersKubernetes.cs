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
    /// Kubernetes defines Kubernetes Filter configuration.
    /// </summary>
    [OutputType]
    public sealed class ClusterFilterSpecFiltersKubernetes
    {
        /// <summary>
        /// Alias for the plugin
        /// </summary>
        public readonly string Alias;
        /// <summary>
        /// Include Kubernetes resource annotations in the extra metadata.
        /// </summary>
        public readonly bool Annotations;
        /// <summary>
        /// Set the buffer size for HTTP client when reading responses from Kubernetes API server.
        /// </summary>
        public readonly string BufferSize;
        /// <summary>
        /// When enabled, metadata will be fetched from K8s when docker_id is changed.
        /// </summary>
        public readonly bool CacheUseDockerId;
        /// <summary>
        /// DNS lookup retries N times until the network start working
        /// </summary>
        public readonly int DnsRetries;
        /// <summary>
        /// DNS lookup interval between network status checks
        /// </summary>
        public readonly int DnsWaitTime;
        /// <summary>
        /// If set, use dummy-meta data (for test/dev purposes)
        /// </summary>
        public readonly bool DummyMeta;
        /// <summary>
        /// Allow Kubernetes Pods to exclude their logs from the log processor (read more about it in Kubernetes Annotations section).
        /// </summary>
        public readonly bool K8sLoggingExclude;
        /// <summary>
        /// Allow Kubernetes Pods to suggest a pre-defined Parser (read more about it in Kubernetes Annotations section)
        /// </summary>
        public readonly bool K8sLoggingParser;
        /// <summary>
        /// When Keep_Log is disabled, the log field is removed from the incoming message once it has been successfully merged (Merge_Log must be enabled as well).
        /// </summary>
        public readonly bool KeepLog;
        /// <summary>
        /// CA certificate file
        /// </summary>
        public readonly string KubeCAFile;
        /// <summary>
        /// Absolute path to scan for certificate files
        /// </summary>
        public readonly string KubeCAPath;
        /// <summary>
        /// configurable TTL for K8s cached metadata. By default, it is set to 0 which means TTL for cache entries is disabled and cache entries are evicted at random when capacity is reached. In order to enable this option, you should set the number to a time interval. For example, set this value to 60 or 60s and cache entries which have been created more than 60s will be evicted.
        /// </summary>
        public readonly string KubeMetaCacheTTL;
        /// <summary>
        /// If set, Kubernetes meta-data can be cached/pre-loaded from files in JSON format in this directory, named as namespace-pod.meta
        /// </summary>
        public readonly string KubeMetaPreloadCacheDir;
        /// <summary>
        /// When the source records comes from Tail input plugin, this option allows to specify what's the prefix used in Tail configuration.
        /// </summary>
        public readonly string KubeTagPrefix;
        /// <summary>
        /// Token file
        /// </summary>
        public readonly string KubeTokenFile;
        /// <summary>
        /// configurable 'time to live' for the K8s token. By default, it is set to 600 seconds. After this time, the token is reloaded from Kube_Token_File or the Kube_Token_Command.
        /// </summary>
        public readonly string KubeTokenTTL;
        /// <summary>
        /// API Server end-point
        /// </summary>
        public readonly string KubeURL;
        /// <summary>
        /// kubelet host using for HTTP request, this only works when Use_Kubelet set to On.
        /// </summary>
        public readonly string KubeletHost;
        /// <summary>
        /// kubelet port using for HTTP request, this only works when useKubelet is set to On.
        /// </summary>
        public readonly int KubeletPort;
        /// <summary>
        /// Include Kubernetes resource labels in the extra metadata.
        /// </summary>
        public readonly bool Labels;
        /// <summary>
        /// When enabled, it checks if the log field content is a JSON string map, if so, it append the map fields as part of the log structure.
        /// </summary>
        public readonly bool MergeLog;
        /// <summary>
        /// When Merge_Log is enabled, the filter tries to assume the log field from the incoming message is a JSON string message and make a structured representation of it at the same level of the log field in the map. Now if Merge_Log_Key is set (a string name), all the new structured fields taken from the original log content are inserted under the new key.
        /// </summary>
        public readonly string MergeLogKey;
        /// <summary>
        /// When Merge_Log is enabled, trim (remove possible \n or \r) field values.
        /// </summary>
        public readonly bool MergeLogTrim;
        /// <summary>
        /// Optional parser name to specify how to parse the data contained in the log key. Recommended use is for developers or testing only.
        /// </summary>
        public readonly string MergeParser;
        /// <summary>
        /// Set an alternative Parser to process record Tag and extract pod_name, namespace_name, container_name and docker_id. The parser must be registered in a parsers file (refer to parser filter-kube-test as an example).
        /// </summary>
        public readonly string RegexParser;
        /// <summary>
        /// RetryLimit describes how many times fluent-bit should retry to send data to a specific output. If set to false fluent-bit will try indefinetly. If set to any integer N&gt;0 it will try at most N+1 times. Leading zeros are not allowed (values such as 007, 0150, 01 do not work). If this property is not defined fluent-bit will use the default value: 1.
        /// </summary>
        public readonly string RetryLimit;
        /// <summary>
        /// Debug level between 0 (nothing) and 4 (every detail).
        /// </summary>
        public readonly int TlsDebug;
        /// <summary>
        /// When enabled, turns on certificate validation when connecting to the Kubernetes API server.
        /// </summary>
        public readonly bool TlsVerify;
        /// <summary>
        /// When enabled, the filter reads logs coming in Journald format.
        /// </summary>
        public readonly bool UseJournal;
        /// <summary>
        /// This is an optional feature flag to get metadata information from kubelet instead of calling Kube Server API to enhance the log. This could mitigate the Kube API heavy traffic issue for large cluster.
        /// </summary>
        public readonly bool UseKubelet;

        [OutputConstructor]
        private ClusterFilterSpecFiltersKubernetes(
            string alias,

            bool annotations,

            string bufferSize,

            bool cacheUseDockerId,

            int dnsRetries,

            int dnsWaitTime,

            bool dummyMeta,

            bool k8sLoggingExclude,

            bool k8sLoggingParser,

            bool keepLog,

            string kubeCAFile,

            string kubeCAPath,

            string kubeMetaCacheTTL,

            string kubeMetaPreloadCacheDir,

            string kubeTagPrefix,

            string kubeTokenFile,

            string kubeTokenTTL,

            string kubeURL,

            string kubeletHost,

            int kubeletPort,

            bool labels,

            bool mergeLog,

            string mergeLogKey,

            bool mergeLogTrim,

            string mergeParser,

            string regexParser,

            string retryLimit,

            int tlsDebug,

            bool tlsVerify,

            bool useJournal,

            bool useKubelet)
        {
            Alias = alias;
            Annotations = annotations;
            BufferSize = bufferSize;
            CacheUseDockerId = cacheUseDockerId;
            DnsRetries = dnsRetries;
            DnsWaitTime = dnsWaitTime;
            DummyMeta = dummyMeta;
            K8sLoggingExclude = k8sLoggingExclude;
            K8sLoggingParser = k8sLoggingParser;
            KeepLog = keepLog;
            KubeCAFile = kubeCAFile;
            KubeCAPath = kubeCAPath;
            KubeMetaCacheTTL = kubeMetaCacheTTL;
            KubeMetaPreloadCacheDir = kubeMetaPreloadCacheDir;
            KubeTagPrefix = kubeTagPrefix;
            KubeTokenFile = kubeTokenFile;
            KubeTokenTTL = kubeTokenTTL;
            KubeURL = kubeURL;
            KubeletHost = kubeletHost;
            KubeletPort = kubeletPort;
            Labels = labels;
            MergeLog = mergeLog;
            MergeLogKey = mergeLogKey;
            MergeLogTrim = mergeLogTrim;
            MergeParser = mergeParser;
            RegexParser = regexParser;
            RetryLimit = retryLimit;
            TlsDebug = tlsDebug;
            TlsVerify = tlsVerify;
            UseJournal = useJournal;
            UseKubelet = useKubelet;
        }
    }
}
