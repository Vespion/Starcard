// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Certmanager.V1
{

    /// <summary>
    /// CertificateAdditionalOutputFormat defines an additional output format of a Certificate resource. These contain supplementary data formats of the signed certificate chain and paired private key.
    /// </summary>
    [OutputType]
    public sealed class CertificateSpecAdditionaloutputformats
    {
        /// <summary>
        /// Type is the name of the format type that should be written to the Certificate's target Secret.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private CertificateSpecAdditionaloutputformats(string type)
        {
            Type = type;
        }
    }
}
