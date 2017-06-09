// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.EventHub.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.EventHub;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Single item in List or Get Consumer group operation
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ConsumerGroupResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ConsumerGroupResource class.
        /// </summary>
        public ConsumerGroupResource()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConsumerGroupResource class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="location">Resource location</param>
        /// <param name="type">Resource type</param>
        /// <param name="createdAt">Exact time the message was created.</param>
        /// <param name="eventHubPath">The path of the Event Hub.</param>
        /// <param name="updatedAt">The exact time the message was
        /// updated.</param>
        /// <param name="userMetadata">The user metadata.</param>
        public ConsumerGroupResource(string id = default(string), string name = default(string), string location = default(string), string type = default(string), System.DateTime? createdAt = default(System.DateTime?), string eventHubPath = default(string), System.DateTime? updatedAt = default(System.DateTime?), string userMetadata = default(string))
            : base(id, name, location, type)
        {
            CreatedAt = createdAt;
            EventHubPath = eventHubPath;
            UpdatedAt = updatedAt;
            UserMetadata = userMetadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets exact time the message was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdAt")]
        public System.DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Gets the path of the Event Hub.
        /// </summary>
        [JsonProperty(PropertyName = "properties.eventHubPath")]
        public string EventHubPath { get; private set; }

        /// <summary>
        /// Gets the exact time the message was updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updatedAt")]
        public System.DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Gets or sets the user metadata.
        /// </summary>
        [JsonProperty(PropertyName = "properties.userMetadata")]
        public string UserMetadata { get; set; }

    }
}
