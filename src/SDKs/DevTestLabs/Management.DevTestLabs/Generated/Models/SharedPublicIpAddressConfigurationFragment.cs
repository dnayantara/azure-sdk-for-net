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
    /// Properties of a virtual machine that determine how it is connected to a
    /// load balancer.
    /// </summary>
    public partial class SharedPublicIpAddressConfigurationFragment
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SharedPublicIpAddressConfigurationFragment class.
        /// </summary>
        public SharedPublicIpAddressConfigurationFragment()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SharedPublicIpAddressConfigurationFragment class.
        /// </summary>
        /// <param name="inboundNatRules">The incoming NAT rules</param>
        public SharedPublicIpAddressConfigurationFragment(IList<InboundNatRuleFragment> inboundNatRules = default(IList<InboundNatRuleFragment>))
        {
            InboundNatRules = inboundNatRules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the incoming NAT rules
        /// </summary>
        [JsonProperty(PropertyName = "inboundNatRules")]
        public IList<InboundNatRuleFragment> InboundNatRules { get; set; }

    }
}
