// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Azure;
    using Management;
    using ContainerRegistry;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters for creating a container registry.
    /// </summary>
    [JsonTransformation]
    public partial class RegistryCreateParameters
    {
        /// <summary>
        /// Initializes a new instance of the RegistryCreateParameters class.
        /// </summary>
        public RegistryCreateParameters() { }

        /// <summary>
        /// Initializes a new instance of the RegistryCreateParameters class.
        /// </summary>
        /// <param name="location">The location of the container registry. This
        /// cannot be changed after the resource is created.</param>
        /// <param name="sku">The SKU of the container registry.</param>
        /// <param name="storageAccount">The parameters of a storage account
        /// for the container registry. If specified, the storage account must
        /// be in the same physical location as the container registry.</param>
        /// <param name="tags">The tags for the container registry.</param>
        /// <param name="adminUserEnabled">The value that indicates whether the
        /// admin user is enabled. This value is false by default.</param>
        public RegistryCreateParameters(string location, Sku sku, StorageAccountParameters storageAccount, IDictionary<string, string> tags = default(IDictionary<string, string>), bool? adminUserEnabled = default(bool?))
        {
            Tags = tags;
            Location = location;
            Sku = sku;
            AdminUserEnabled = adminUserEnabled;
            StorageAccount = storageAccount;
        }

        /// <summary>
        /// Gets or sets the tags for the container registry.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the location of the container registry. This cannot be
        /// changed after the resource is created.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the SKU of the container registry.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets the value that indicates whether the admin user is
        /// enabled. This value is false by default.
        /// </summary>
        [JsonProperty(PropertyName = "properties.adminUserEnabled")]
        public bool? AdminUserEnabled { get; set; }

        /// <summary>
        /// Gets or sets the parameters of a storage account for the container
        /// registry. If specified, the storage account must be in the same
        /// physical location as the container registry.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccount")]
        public StorageAccountParameters StorageAccount { get; set; }

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
            if (Sku == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sku");
            }
            if (StorageAccount == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageAccount");
            }
            if (Sku != null)
            {
                Sku.Validate();
            }
            if (StorageAccount != null)
            {
                StorageAccount.Validate();
            }
        }
    }
}

