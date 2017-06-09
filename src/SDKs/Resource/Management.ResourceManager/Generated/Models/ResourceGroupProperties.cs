// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ResourceManager;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The resource group properties.
    /// </summary>
    public partial class ResourceGroupProperties
    {
        /// <summary>
        /// Initializes a new instance of the ResourceGroupProperties class.
        /// </summary>
        public ResourceGroupProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceGroupProperties class.
        /// </summary>
        /// <param name="provisioningState">The provisioning state. </param>
        public ResourceGroupProperties(string provisioningState = default(string))
        {
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the provisioning state.
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

    }
}
