// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceBus.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ServiceBus;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Description of subscription resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SubscriptionResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionResource class.
        /// </summary>
        public SubscriptionResource()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptionResource class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="location">Resource location.</param>
        /// <param name="type">Resource type</param>
        /// <param name="accessedAt">Last time there was a receive request to
        /// this subscription.</param>
        /// <param name="autoDeleteOnIdle">TimeSpan idle interval after which
        /// the topic is automatically deleted. The minimum duration is 5
        /// minutes.</param>
        /// <param name="createdAt">Exact time the message was created.</param>
        /// <param name="defaultMessageTimeToLive">Default message time to live
        /// value. This is the duration after which the message expires,
        /// starting from when the message is sent to Service Bus. This is the
        /// default value used when TimeToLive is not set on a message
        /// itself.</param>
        /// <param name="deadLetteringOnFilterEvaluationExceptions">Value that
        /// indicates whether a subscription has dead letter support on filter
        /// evaluation exceptions.</param>
        /// <param name="deadLetteringOnMessageExpiration">Value that indicates
        /// whether a subscription has dead letter support when a message
        /// expires.</param>
        /// <param name="enableBatchedOperations">Value that indicates whether
        /// server-side batched operations are enabled.</param>
        /// <param name="entityAvailabilityStatus">Entity availability status
        /// for the topic. Possible values include: 'Available', 'Limited',
        /// 'Renaming', 'Restoring', 'Unknown'</param>
        /// <param name="isReadOnly">Value that indicates whether the entity
        /// description is read-only.</param>
        /// <param name="lockDuration">The lock duration time span for the
        /// subscription.</param>
        /// <param name="maxDeliveryCount">Number of maximum
        /// deliveries.</param>
        /// <param name="messageCount">Number of messages.</param>
        /// <param name="requiresSession">Value indicating if a subscription
        /// supports the concept of sessions.</param>
        /// <param name="status">Enumerates the possible values for the status
        /// of a messaging entity. Possible values include: 'Active',
        /// 'Creating', 'Deleting', 'Disabled', 'ReceiveDisabled', 'Renaming',
        /// 'Restoring', 'SendDisabled', 'Unknown'</param>
        /// <param name="updatedAt">The exact time the message was
        /// updated.</param>
        public SubscriptionResource(string id = default(string), string name = default(string), string location = default(string), string type = default(string), System.DateTime? accessedAt = default(System.DateTime?), string autoDeleteOnIdle = default(string), MessageCountDetails countDetails = default(MessageCountDetails), System.DateTime? createdAt = default(System.DateTime?), string defaultMessageTimeToLive = default(string), bool? deadLetteringOnFilterEvaluationExceptions = default(bool?), bool? deadLetteringOnMessageExpiration = default(bool?), bool? enableBatchedOperations = default(bool?), EntityAvailabilityStatus? entityAvailabilityStatus = default(EntityAvailabilityStatus?), bool? isReadOnly = default(bool?), string lockDuration = default(string), int? maxDeliveryCount = default(int?), long? messageCount = default(long?), bool? requiresSession = default(bool?), EntityStatus? status = default(EntityStatus?), System.DateTime? updatedAt = default(System.DateTime?))
            : base(id, name, location, type)
        {
            AccessedAt = accessedAt;
            AutoDeleteOnIdle = autoDeleteOnIdle;
            CountDetails = countDetails;
            CreatedAt = createdAt;
            DefaultMessageTimeToLive = defaultMessageTimeToLive;
            DeadLetteringOnFilterEvaluationExceptions = deadLetteringOnFilterEvaluationExceptions;
            DeadLetteringOnMessageExpiration = deadLetteringOnMessageExpiration;
            EnableBatchedOperations = enableBatchedOperations;
            EntityAvailabilityStatus = entityAvailabilityStatus;
            IsReadOnly = isReadOnly;
            LockDuration = lockDuration;
            MaxDeliveryCount = maxDeliveryCount;
            MessageCount = messageCount;
            RequiresSession = requiresSession;
            Status = status;
            UpdatedAt = updatedAt;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets last time there was a receive request to this subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accessedAt")]
        public System.DateTime? AccessedAt { get; private set; }

        /// <summary>
        /// Gets or sets timeSpan idle interval after which the topic is
        /// automatically deleted. The minimum duration is 5 minutes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoDeleteOnIdle")]
        public string AutoDeleteOnIdle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.countDetails")]
        public MessageCountDetails CountDetails { get; private set; }

        /// <summary>
        /// Gets exact time the message was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdAt")]
        public System.DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Gets or sets default message time to live value. This is the
        /// duration after which the message expires, starting from when the
        /// message is sent to Service Bus. This is the default value used when
        /// TimeToLive is not set on a message itself.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultMessageTimeToLive")]
        public string DefaultMessageTimeToLive { get; set; }

        /// <summary>
        /// Gets or sets value that indicates whether a subscription has dead
        /// letter support on filter evaluation exceptions.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deadLetteringOnFilterEvaluationExceptions")]
        public bool? DeadLetteringOnFilterEvaluationExceptions { get; set; }

        /// <summary>
        /// Gets or sets value that indicates whether a subscription has dead
        /// letter support when a message expires.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deadLetteringOnMessageExpiration")]
        public bool? DeadLetteringOnMessageExpiration { get; set; }

        /// <summary>
        /// Gets or sets value that indicates whether server-side batched
        /// operations are enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableBatchedOperations")]
        public bool? EnableBatchedOperations { get; set; }

        /// <summary>
        /// Gets or sets entity availability status for the topic. Possible
        /// values include: 'Available', 'Limited', 'Renaming', 'Restoring',
        /// 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "properties.entityAvailabilityStatus")]
        public EntityAvailabilityStatus? EntityAvailabilityStatus { get; set; }

        /// <summary>
        /// Gets or sets value that indicates whether the entity description is
        /// read-only.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isReadOnly")]
        public bool? IsReadOnly { get; set; }

        /// <summary>
        /// Gets or sets the lock duration time span for the subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lockDuration")]
        public string LockDuration { get; set; }

        /// <summary>
        /// Gets or sets number of maximum deliveries.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxDeliveryCount")]
        public int? MaxDeliveryCount { get; set; }

        /// <summary>
        /// Gets number of messages.
        /// </summary>
        [JsonProperty(PropertyName = "properties.messageCount")]
        public long? MessageCount { get; private set; }

        /// <summary>
        /// Gets or sets value indicating if a subscription supports the
        /// concept of sessions.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requiresSession")]
        public bool? RequiresSession { get; set; }

        /// <summary>
        /// Gets or sets enumerates the possible values for the status of a
        /// messaging entity. Possible values include: 'Active', 'Creating',
        /// 'Deleting', 'Disabled', 'ReceiveDisabled', 'Renaming', 'Restoring',
        /// 'SendDisabled', 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public EntityStatus? Status { get; set; }

        /// <summary>
        /// Gets the exact time the message was updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updatedAt")]
        public System.DateTime? UpdatedAt { get; private set; }

    }
}
