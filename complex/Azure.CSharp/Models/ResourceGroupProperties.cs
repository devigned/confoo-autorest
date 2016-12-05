// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Azure.Models
{
    using System.Linq;

    /// <summary>
    /// The resource group properties.
    /// </summary>
    public partial class ResourceGroupProperties
    {
        /// <summary>
        /// Initializes a new instance of the ResourceGroupProperties class.
        /// </summary>
        public ResourceGroupProperties() { }

        /// <summary>
        /// Initializes a new instance of the ResourceGroupProperties class.
        /// </summary>
        /// <param name="provisioningState">The provisioning state. </param>
        public ResourceGroupProperties(string provisioningState = default(string))
        {
            ProvisioningState = provisioningState;
        }

        /// <summary>
        /// Gets the provisioning state.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

    }
}
