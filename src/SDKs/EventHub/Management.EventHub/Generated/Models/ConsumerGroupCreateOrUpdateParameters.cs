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
    /// Parameters supplied to the Create Or Update Consumer Group operation.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ConsumerGroupCreateOrUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ConsumerGroupCreateOrUpdateParameters class.
        /// </summary>
        public ConsumerGroupCreateOrUpdateParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ConsumerGroupCreateOrUpdateParameters class.
        /// </summary>
        /// <param name="location">Location of the resource.</param>
        /// <param name="type">ARM type of the Namespace.</param>
        /// <param name="name">Name of the consumer group.</param>
        /// <param name="createdAt">Exact time the message was created.</param>
        /// <param name="eventHubPath">The path of the Event Hub.</param>
        /// <param name="updatedAt">The exact time the message was
        /// updated.</param>
        /// <param name="userMetadata">The user metadata.</param>
        public ConsumerGroupCreateOrUpdateParameters(string location, string type = default(string), string name = default(string), System.DateTime? createdAt = default(System.DateTime?), string eventHubPath = default(string), System.DateTime? updatedAt = default(System.DateTime?), string userMetadata = default(string))
        {
            Location = location;
            Type = type;
            Name = name;
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
        /// Gets or sets location of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets ARM type of the Namespace.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets name of the consumer group.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

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

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
        }
    }
}
