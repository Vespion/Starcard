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
    /// File defines File Output configuration.
    /// </summary>
    [OutputType]
    public sealed class ClusterOutputSpecFile
    {
        /// <summary>
        /// The character to separate each pair. Applicable only if format is csv or ltsv.
        /// </summary>
        public readonly string Delimiter;
        /// <summary>
        /// Set file name to store the records. If not set, the file name will be the tag associated with the records.
        /// </summary>
        public readonly string File;
        /// <summary>
        /// The format of the file content. See also Format section. Default: out_file.
        /// </summary>
        public readonly string Format;
        /// <summary>
        /// The character to separate each pair. Applicable only if format is ltsv.
        /// </summary>
        public readonly string LabelDelimiter;
        /// <summary>
        /// Absolute directory path to store files. If not set, Fluent Bit will write the files on it's own positioned directory.
        /// </summary>
        public readonly string Path;
        /// <summary>
        /// The format string. Applicable only if format is template.
        /// </summary>
        public readonly string Template;

        [OutputConstructor]
        private ClusterOutputSpecFile(
            string delimiter,

            string file,

            string format,

            string labelDelimiter,

            string path,

            string template)
        {
            Delimiter = delimiter;
            File = file;
            Format = format;
            LabelDelimiter = labelDelimiter;
            Path = path;
            Template = template;
        }
    }
}
