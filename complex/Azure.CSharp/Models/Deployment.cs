// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Azure.Models
{
    using System.Linq;

    /// <summary>
    /// Deployment operation parameters.
    /// </summary>
    public partial class Deployment
    {
        /// <summary>
        /// Initializes a new instance of the Deployment class.
        /// </summary>
        public Deployment() { }

        /// <summary>
        /// Initializes a new instance of the Deployment class.
        /// </summary>
        /// <param name="properties">The deployment properties.</param>
        public Deployment(DeploymentProperties properties = default(DeploymentProperties))
        {
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets the deployment properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties")]
        public DeploymentProperties Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Properties != null)
            {
                this.Properties.Validate();
            }
        }
    }
}