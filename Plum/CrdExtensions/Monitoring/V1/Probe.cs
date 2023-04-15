// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;

namespace Pulumi.Crds.Monitoring.V1
{
    /// <summary>
    /// Probe defines monitoring for a set of static targets or ingresses.
    /// </summary>
    [CrdsResourceType("kubernetes:monitoring.coreos.com/v1:Probe")]
    public partial class Probe : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// Specification of desired Ingress selection for target discovery by Prometheus.
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ProbeSpec> Spec { get; private set; } = null!;


        /// <summary>
        /// Create a Probe resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Probe(string name, Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ProbeArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:monitoring.coreos.com/v1:Probe", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal Probe(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:monitoring.coreos.com/v1:Probe", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private Probe(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:monitoring.coreos.com/v1:Probe", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ProbeArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ProbeArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ProbeArgs();
            args.ApiVersion = "monitoring.coreos.com/v1";
            args.Kind = "Probe";
            return args;
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Probe resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Probe Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Probe(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Monitoring.V1
{

    public class ProbeArgs : global::Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// Specification of desired Ingress selection for target discovery by Prometheus.
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ProbeSpecArgs>? Spec { get; set; }

        public ProbeArgs()
        {
        }
        public static new ProbeArgs Empty => new ProbeArgs();
    }
}
