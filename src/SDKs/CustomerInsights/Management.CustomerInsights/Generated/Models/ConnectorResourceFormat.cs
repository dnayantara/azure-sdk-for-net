// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CustomerInsights.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.CustomerInsights;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The connector resource format.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ConnectorResourceFormat : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the ConnectorResourceFormat class.
        /// </summary>
        public ConnectorResourceFormat()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectorResourceFormat class.
        /// </summary>
        /// <param name="connectorType">Type of connector. Possible values
        /// include: 'None', 'CRM', 'AzureBlob', 'Salesforce',
        /// 'ExchangeOnline', 'Outbound'</param>
        /// <param name="connectorProperties">The connector properties.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="connectorId">ID of the connector.</param>
        /// <param name="connectorName">Name of the connector.</param>
        /// <param name="displayName">Display name of the connector.</param>
        /// <param name="description">Description of the connector.</param>
        /// <param name="created">The created time.</param>
        /// <param name="lastModified">The last monified time.</param>
        /// <param name="state">State of connector. Possible values include:
        /// 'Creating', 'Created', 'Ready', 'Expiring', 'Deleting',
        /// 'Failed'</param>
        /// <param name="tenantId">The hub name.</param>
        /// <param name="isInternal">If this is an internal connector.</param>
        public ConnectorResourceFormat(string connectorType, IDictionary<string, object> connectorProperties, string id = default(string), string name = default(string), string type = default(string), int? connectorId = default(int?), string connectorName = default(string), string displayName = default(string), string description = default(string), System.DateTime? created = default(System.DateTime?), System.DateTime? lastModified = default(System.DateTime?), ConnectorStates? state = default(ConnectorStates?), string tenantId = default(string), bool? isInternal = default(bool?))
            : base(id, name, type)
        {
            ConnectorId = connectorId;
            ConnectorName = connectorName;
            ConnectorType = connectorType;
            DisplayName = displayName;
            Description = description;
            ConnectorProperties = connectorProperties;
            Created = created;
            LastModified = lastModified;
            State = state;
            TenantId = tenantId;
            IsInternal = isInternal;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets ID of the connector.
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectorId")]
        public int? ConnectorId { get; private set; }

        /// <summary>
        /// Gets or sets name of the connector.
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectorName")]
        public string ConnectorName { get; set; }

        /// <summary>
        /// Gets or sets type of connector. Possible values include: 'None',
        /// 'CRM', 'AzureBlob', 'Salesforce', 'ExchangeOnline', 'Outbound'
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectorType")]
        public string ConnectorType { get; set; }

        /// <summary>
        /// Gets or sets display name of the connector.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets description of the connector.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the connector properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectorProperties")]
        public IDictionary<string, object> ConnectorProperties { get; set; }

        /// <summary>
        /// Gets the created time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.created")]
        public System.DateTime? Created { get; private set; }

        /// <summary>
        /// Gets the last monified time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModified")]
        public System.DateTime? LastModified { get; private set; }

        /// <summary>
        /// Gets state of connector. Possible values include: 'Creating',
        /// 'Created', 'Ready', 'Expiring', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public ConnectorStates? State { get; private set; }

        /// <summary>
        /// Gets the hub name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tenantId")]
        public string TenantId { get; private set; }

        /// <summary>
        /// Gets or sets if this is an internal connector.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isInternal")]
        public bool? IsInternal { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ConnectorType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConnectorType");
            }
            if (ConnectorProperties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConnectorProperties");
            }
        }
    }
}
