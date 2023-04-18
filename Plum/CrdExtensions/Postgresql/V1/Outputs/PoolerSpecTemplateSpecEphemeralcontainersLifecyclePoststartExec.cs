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
    /// Exec specifies the action to take.
    /// </summary>
    [OutputType]
    public sealed class PoolerSpecTemplateSpecEphemeralcontainersLifecyclePoststartExec
    {
        /// <summary>
        /// Command is the command line to execute inside the container, the working directory for the command  is root ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.
        /// </summary>
        public readonly ImmutableArray<string> Command;

        [OutputConstructor]
        private PoolerSpecTemplateSpecEphemeralcontainersLifecyclePoststartExec(ImmutableArray<string> command)
        {
            Command = command;
        }
    }
}
