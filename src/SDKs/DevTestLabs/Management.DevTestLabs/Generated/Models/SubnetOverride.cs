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
    /// Property overrides on a subnet of a virtual network.
    /// </summary>
    public partial class SubnetOverride
    {
        /// <summary>
        /// Initializes a new instance of the SubnetOverride class.
        /// </summary>
        public SubnetOverride()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubnetOverride class.
        /// </summary>
        /// <param name="resourceId">The resource ID of the subnet.</param>
        /// <param name="labSubnetName">The name given to the subnet within the
        /// lab.</param>
        /// <param name="useInVmCreationPermission">Indicates whether this
        /// subnet can be used during virtual machine creation (i.e. Allow,
        /// Deny). Possible values include: 'Default', 'Deny', 'Allow'</param>
        /// <param name="usePublicIpAddressPermission">Indicates whether public
        /// IP addresses can be assigned to virtual machines on this subnet
        /// (i.e. Allow, Deny). Possible values include: 'Default', 'Deny',
        /// 'Allow'</param>
        /// <param name="sharedPublicIpAddressConfiguration">Properties that
        /// virtual machines on this subnet will share.</param>
        /// <param name="virtualNetworkPoolName">The virtual network pool
        /// associated with this subnet.</param>
        public SubnetOverride(string resourceId = default(string), string labSubnetName = default(string), string useInVmCreationPermission = default(string), string usePublicIpAddressPermission = default(string), SubnetSharedPublicIpAddressConfiguration sharedPublicIpAddressConfiguration = default(SubnetSharedPublicIpAddressConfiguration), string virtualNetworkPoolName = default(string))
        {
            ResourceId = resourceId;
            LabSubnetName = labSubnetName;
            UseInVmCreationPermission = useInVmCreationPermission;
            UsePublicIpAddressPermission = usePublicIpAddressPermission;
            SharedPublicIpAddressConfiguration = sharedPublicIpAddressConfiguration;
            VirtualNetworkPoolName = virtualNetworkPoolName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource ID of the subnet.
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the name given to the subnet within the lab.
        /// </summary>
        [JsonProperty(PropertyName = "labSubnetName")]
        public string LabSubnetName { get; set; }

        /// <summary>
        /// Gets or sets indicates whether this subnet can be used during
        /// virtual machine creation (i.e. Allow, Deny). Possible values
        /// include: 'Default', 'Deny', 'Allow'
        /// </summary>
        [JsonProperty(PropertyName = "useInVmCreationPermission")]
        public string UseInVmCreationPermission { get; set; }

        /// <summary>
        /// Gets or sets indicates whether public IP addresses can be assigned
        /// to virtual machines on this subnet (i.e. Allow, Deny). Possible
        /// values include: 'Default', 'Deny', 'Allow'
        /// </summary>
        [JsonProperty(PropertyName = "usePublicIpAddressPermission")]
        public string UsePublicIpAddressPermission { get; set; }

        /// <summary>
        /// Gets or sets properties that virtual machines on this subnet will
        /// share.
        /// </summary>
        [JsonProperty(PropertyName = "sharedPublicIpAddressConfiguration")]
        public SubnetSharedPublicIpAddressConfiguration SharedPublicIpAddressConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the virtual network pool associated with this subnet.
        /// </summary>
        [JsonProperty(PropertyName = "virtualNetworkPoolName")]
        public string VirtualNetworkPoolName { get; set; }

    }
}
