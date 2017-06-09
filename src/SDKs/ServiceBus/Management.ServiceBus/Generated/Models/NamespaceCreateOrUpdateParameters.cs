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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Parameters supplied to the Create Or Update Namespace operation.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class NamespaceCreateOrUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the NamespaceCreateOrUpdateParameters
        /// class.
        /// </summary>
        public NamespaceCreateOrUpdateParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NamespaceCreateOrUpdateParameters
        /// class.
        /// </summary>
        /// <param name="location">Namespace location.</param>
        /// <param name="tags">Namespace tags.</param>
        /// <param name="provisioningState">Provisioning state of the
        /// namespace.</param>
        /// <param name="status">State of the namespace. Possible values
        /// include: 'Unknown', 'Creating', 'Created', 'Activating',
        /// 'Enabling', 'Active', 'Disabling', 'Disabled', 'SoftDeleting',
        /// 'SoftDeleted', 'Removing', 'Removed', 'Failed'</param>
        /// <param name="createdAt">The time the namespace was created.</param>
        /// <param name="updatedAt">The time the namespace was updated.</param>
        /// <param name="serviceBusEndpoint">Endpoint you can use to perform
        /// Service Bus operations.</param>
        /// <param name="createACSNamespace">Indicates whether to create an ACS
        /// namespace.</param>
        /// <param name="enabled">Specifies whether this instance is
        /// enabled.</param>
        public NamespaceCreateOrUpdateParameters(string location, Sku sku = default(Sku), IDictionary<string, string> tags = default(IDictionary<string, string>), string provisioningState = default(string), NamespaceState? status = default(NamespaceState?), System.DateTime? createdAt = default(System.DateTime?), System.DateTime? updatedAt = default(System.DateTime?), string serviceBusEndpoint = default(string), bool? createACSNamespace = default(bool?), bool? enabled = default(bool?))
        {
            Location = location;
            Sku = sku;
            Tags = tags;
            ProvisioningState = provisioningState;
            Status = status;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            ServiceBusEndpoint = serviceBusEndpoint;
            CreateACSNamespace = createACSNamespace;
            Enabled = enabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets namespace location.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets namespace tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets provisioning state of the namespace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets state of the namespace. Possible values include:
        /// 'Unknown', 'Creating', 'Created', 'Activating', 'Enabling',
        /// 'Active', 'Disabling', 'Disabled', 'SoftDeleting', 'SoftDeleted',
        /// 'Removing', 'Removed', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public NamespaceState? Status { get; set; }

        /// <summary>
        /// Gets the time the namespace was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdAt")]
        public System.DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Gets the time the namespace was updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updatedAt")]
        public System.DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Gets endpoint you can use to perform Service Bus operations.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceBusEndpoint")]
        public string ServiceBusEndpoint { get; private set; }

        /// <summary>
        /// Gets or sets indicates whether to create an ACS namespace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createACSNamespace")]
        public bool? CreateACSNamespace { get; set; }

        /// <summary>
        /// Gets or sets specifies whether this instance is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabled")]
        public bool? Enabled { get; set; }

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
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
