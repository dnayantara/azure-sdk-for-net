// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DevTestLabs;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters for creating multiple virtual machines as a single action.
    /// </summary>
    public partial class BulkCreationParameters
    {
        /// <summary>
        /// Initializes a new instance of the BulkCreationParameters class.
        /// </summary>
        public BulkCreationParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BulkCreationParameters class.
        /// </summary>
        /// <param name="instanceCount">The number of virtual machine instances
        /// to create.</param>
        public BulkCreationParameters(int? instanceCount = default(int?))
        {
            InstanceCount = instanceCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the number of virtual machine instances to create.
        /// </summary>
        [JsonProperty(PropertyName = "instanceCount")]
        public int? InstanceCount { get; set; }

    }
}
