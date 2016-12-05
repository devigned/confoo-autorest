// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Azure.Models
{
    using System.Linq;

    /// <summary>
    /// Deployment operation information.
    /// </summary>
    public partial class DeploymentOperation
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentOperation class.
        /// </summary>
        public DeploymentOperation() { }

        /// <summary>
        /// Initializes a new instance of the DeploymentOperation class.
        /// </summary>
        /// <param name="id">Full deployment operation ID.</param>
        /// <param name="operationId">Deployment operation ID.</param>
        /// <param name="properties">Deployment properties.</param>
        public DeploymentOperation(string id = default(string), string operationId = default(string), DeploymentOperationProperties properties = default(DeploymentOperationProperties))
        {
            Id = id;
            OperationId = operationId;
            Properties = properties;
        }

        /// <summary>
        /// Gets full deployment operation ID.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets deployment operation ID.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "operationId")]
        public string OperationId { get; private set; }

        /// <summary>
        /// Gets or sets deployment properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties")]
        public DeploymentOperationProperties Properties { get; set; }

    }
}
