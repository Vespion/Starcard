// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;

namespace Pulumi.Crds.Seaweed.V1
{
    /// <summary>
    /// Seaweed is the Schema for the seaweeds API
    /// </summary>
    [CrdsResourceType("kubernetes:seaweed.seaweedfs.com/v1:Seaweed")]
    public partial class Seaweed : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// SeaweedSpec defines the desired state of Seaweed
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// SeaweedStatus defines the observed state of Seaweed
        /// </summary>
        [Output("status")]
        public Output<ImmutableDictionary<string, object>> Status { get; private set; } = null!;


        /// <summary>
        /// Create a Seaweed resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Seaweed(string name, Pulumi.Kubernetes.Types.Inputs.Seaweed.V1.SeaweedArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:seaweed.seaweedfs.com/v1:Seaweed", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal Seaweed(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:seaweed.seaweedfs.com/v1:Seaweed", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private Seaweed(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:seaweed.seaweedfs.com/v1:Seaweed", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Seaweed.V1.SeaweedArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Seaweed.V1.SeaweedArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Seaweed.V1.SeaweedArgs();
            args.ApiVersion = "seaweed.seaweedfs.com/v1";
            args.Kind = "Seaweed";
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
        /// Get an existing Seaweed resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Seaweed Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Seaweed(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Seaweed.V1
{

    public class SeaweedArgs : global::Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// SeaweedSpec defines the desired state of Seaweed
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Seaweed.V1.SeaweedSpecArgs>? Spec { get; set; }

        [Input("status")]
        private InputMap<object>? _status;

        /// <summary>
        /// SeaweedStatus defines the observed state of Seaweed
        /// </summary>
        public InputMap<object> Status
        {
            get => _status ?? (_status = new InputMap<object>());
            set => _status = value;
        }

        public SeaweedArgs()
        {
        }
        public static new SeaweedArgs Empty => new SeaweedArgs();
    }
}
