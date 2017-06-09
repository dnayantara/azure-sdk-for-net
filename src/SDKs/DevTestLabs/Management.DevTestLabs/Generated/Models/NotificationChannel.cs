// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DevTestLabs;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A notification.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class NotificationChannel : Resource
    {
        /// <summary>
        /// Initializes a new instance of the NotificationChannel class.
        /// </summary>
        public NotificationChannel()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NotificationChannel class.
        /// </summary>
        /// <param name="id">The identifier of the resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="location">The location of the resource.</param>
        /// <param name="tags">The tags of the resource.</param>
        /// <param name="webHookUrl">The webhook URL to send notifications
        /// to.</param>
        /// <param name="description">Description of notification.</param>
        /// <param name="events">The list of event for which this notification
        /// is enabled.</param>
        /// <param name="createdDate">The creation date of the notification
        /// channel.</param>
        /// <param name="provisioningState">The provisioning status of the
        /// resource.</param>
        /// <param name="uniqueIdentifier">The unique immutable identifier of a
        /// resource (Guid).</param>
        public NotificationChannel(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string webHookUrl = default(string), string description = default(string), IList<EventModel> events = default(IList<EventModel>), System.DateTime? createdDate = default(System.DateTime?), string provisioningState = default(string), string uniqueIdentifier = default(string))
            : base(id, name, type, location, tags)
        {
            WebHookUrl = webHookUrl;
            Description = description;
            Events = events;
            CreatedDate = createdDate;
            ProvisioningState = provisioningState;
            UniqueIdentifier = uniqueIdentifier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the webhook URL to send notifications to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.webHookUrl")]
        public string WebHookUrl { get; set; }

        /// <summary>
        /// Gets or sets description of notification.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the list of event for which this notification is
        /// enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.events")]
        public IList<EventModel> Events { get; set; }

        /// <summary>
        /// Gets the creation date of the notification channel.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdDate")]
        public System.DateTime? CreatedDate { get; private set; }

        /// <summary>
        /// Gets or sets the provisioning status of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the unique immutable identifier of a resource (Guid).
        /// </summary>
        [JsonProperty(PropertyName = "properties.uniqueIdentifier")]
        public string UniqueIdentifier { get; set; }

    }
}
