// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DevTestLabs;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Configuration for public IP address sharing.
    /// </summary>
    public partial class SubnetSharedPublicIpAddressConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SubnetSharedPublicIpAddressConfiguration class.
        /// </summary>
        public SubnetSharedPublicIpAddressConfiguration()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SubnetSharedPublicIpAddressConfiguration class.
        /// </summary>
        /// <param name="allowedPorts">Backend ports that virtual machines on
        /// this subnet are allowed to expose</param>
        public SubnetSharedPublicIpAddressConfiguration(IList<Port> allowedPorts = default(IList<Port>))
        {
            AllowedPorts = allowedPorts;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets backend ports that virtual machines on this subnet are
        /// allowed to expose
        /// </summary>
        [JsonProperty(PropertyName = "allowedPorts")]
        public IList<Port> AllowedPorts { get; set; }

    }
}
