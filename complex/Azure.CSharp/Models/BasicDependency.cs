// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Azure.Models
{
    using System.Linq;

    /// <summary>
    /// Deployment dependency information.
    /// </summary>
    public partial class BasicDependency
    {
        /// <summary>
        /// Initializes a new instance of the BasicDependency class.
        /// </summary>
        public BasicDependency() { }

        /// <summary>
        /// Initializes a new instance of the BasicDependency class.
        /// </summary>
        /// <param name="id">The ID of the dependency.</param>
        /// <param name="resourceType">The dependency resource type.</param>
        /// <param name="resourceName">The dependency resource name.</param>
        public BasicDependency(string id = default(string), string resourceType = default(string), string resourceName = default(string))
        {
            Id = id;
            ResourceType = resourceType;
            ResourceName = resourceName;
        }

        /// <summary>
        /// Gets or sets the ID of the dependency.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the dependency resource type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }

        /// <summary>
        /// Gets or sets the dependency resource name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }

    }
}
