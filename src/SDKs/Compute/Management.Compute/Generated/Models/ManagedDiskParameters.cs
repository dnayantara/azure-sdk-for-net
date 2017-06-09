// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Azure;
    using Management;
    using Compute;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The parameters of a managed disk.
    /// </summary>
    public partial class ManagedDiskParameters : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ManagedDiskParameters class.
        /// </summary>
        public ManagedDiskParameters() { }

        /// <summary>
        /// Initializes a new instance of the ManagedDiskParameters class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="storageAccountType">The Storage Account type. Possible
        /// values include: 'Standard_LRS', 'Premium_LRS'</param>
        public ManagedDiskParameters(string id = default(string), StorageAccountTypes? storageAccountType = default(StorageAccountTypes?))
            : base(id)
        {
            StorageAccountType = storageAccountType;
        }

        /// <summary>
        /// Gets or sets the Storage Account type. Possible values include:
        /// 'Standard_LRS', 'Premium_LRS'
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountType")]
        public StorageAccountTypes? StorageAccountType { get; set; }

    }
}

