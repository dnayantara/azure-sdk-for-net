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
    /// Describes the parameters of a ScaleSet managed disk.
    /// </summary>
    public partial class VirtualMachineScaleSetManagedDiskParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetManagedDiskParameters class.
        /// </summary>
        public VirtualMachineScaleSetManagedDiskParameters() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetManagedDiskParameters class.
        /// </summary>
        /// <param name="storageAccountType">The Storage Account type. Possible
        /// values include: 'Standard_LRS', 'Premium_LRS'</param>
        public VirtualMachineScaleSetManagedDiskParameters(StorageAccountTypes? storageAccountType = default(StorageAccountTypes?))
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

