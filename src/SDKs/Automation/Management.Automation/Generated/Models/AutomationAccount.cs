// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Automation;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Definition of the automation account type.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AutomationAccount : Resource
    {
        /// <summary>
        /// Initializes a new instance of the AutomationAccount class.
        /// </summary>
        public AutomationAccount()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutomationAccount class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="sku">Gets or sets the SKU of account.</param>
        /// <param name="lastModifiedBy">Gets or sets the last modified
        /// by.</param>
        /// <param name="state">Gets status of account. Possible values
        /// include: 'Ok', 'Unavailable', 'Suspended'</param>
        /// <param name="creationTime">Gets the creation time.</param>
        /// <param name="lastModifiedTime">Gets the last modified time.</param>
        /// <param name="description">Gets or sets the description.</param>
        /// <param name="etag">Gets or sets the etag of the resource.</param>
        public AutomationAccount(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Sku sku = default(Sku), string lastModifiedBy = default(string), string state = default(string), System.DateTime? creationTime = default(System.DateTime?), System.DateTime? lastModifiedTime = default(System.DateTime?), string description = default(string), string etag = default(string))
            : base(location, id, name, type, tags)
        {
            Sku = sku;
            LastModifiedBy = lastModifiedBy;
            State = state;
            CreationTime = creationTime;
            LastModifiedTime = lastModifiedTime;
            Description = description;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the SKU of account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets the last modified by.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Gets status of account. Possible values include: 'Ok',
        /// 'Unavailable', 'Suspended'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; private set; }

        /// <summary>
        /// Gets the creation time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTime? CreationTime { get; private set; }

        /// <summary>
        /// Gets the last modified time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; private set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the etag of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
