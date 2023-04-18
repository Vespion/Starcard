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
    /// GRPC specifies an action involving a GRPC port. This is a beta field and requires enabling GRPCContainerProbe feature gate.
    /// </summary>
    [OutputType]
    public sealed class PoolerSpecTemplateSpecEphemeralcontainersStartupprobeGrpc
    {
        /// <summary>
        /// Port number of the gRPC service. Number must be in the range 1 to 65535.
        /// </summary>
        public readonly int Port;
        /// <summary>
        /// Service is the name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md). 
        ///  If this is not specified, the default behavior is defined by gRPC.
        /// </summary>
        public readonly string Service;

        [OutputConstructor]
        private PoolerSpecTemplateSpecEphemeralcontainersStartupprobeGrpc(
            int port,

            string service)
        {
            Port = port;
            Service = service;
        }
    }
}
