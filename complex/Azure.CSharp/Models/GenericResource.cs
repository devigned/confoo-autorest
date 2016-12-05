// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Azure.Models
{
    using System.Linq;

    /// <summary>
    /// Resource information.
    /// </summary>
    public partial class GenericResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the GenericResource class.
        /// </summary>
        public GenericResource() { }

        /// <summary>
        /// Initializes a new instance of the GenericResource class.
        /// </summary>
        /// <param name="id">Resource ID</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="location">Resource location</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="plan">The plan of the resource.</param>
        /// <param name="properties">The resource properties.</param>
        /// <param name="kind">The kind of the resource.</param>
        /// <param name="managedBy">ID of the resource that manages this
        /// resource.</param>
        /// <param name="sku">The SKU of the resource.</param>
        /// <param name="identity">The identity of the resource.</param>
        public GenericResource(string id = default(string), string name = default(string), string type = default(string), string location = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), Plan plan = default(Plan), object properties = default(object), string kind = default(string), string managedBy = default(string), Sku sku = default(Sku), Identity identity = default(Identity))
            : base(id, name, type, location, tags)
        {
            Plan = plan;
            Properties = properties;
            Kind = kind;
            ManagedBy = managedBy;
            Sku = sku;
            Identity = identity;
        }

        /// <summary>
        /// Gets or sets the plan of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "plan")]
        public Plan Plan { get; set; }

        /// <summary>
        /// Gets or sets the resource properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties")]
        public object Properties { get; set; }

        /// <summary>
        /// Gets or sets the kind of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets ID of the resource that manages this resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "managedBy")]
        public string ManagedBy { get; set; }

        /// <summary>
        /// Gets or sets the SKU of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets the identity of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "identity")]
        public Identity Identity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Kind != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(this.Kind, "^[-\\w\\._,\\(\\)]+$"))
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.Pattern, "Kind", "^[-\\w\\._,\\(\\)]+$");
                }
            }
        }
    }
}
