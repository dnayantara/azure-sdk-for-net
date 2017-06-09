// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DevTestLabs;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Disk.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Disk : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Disk class.
        /// </summary>
        public Disk()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Disk class.
        /// </summary>
        /// <param name="id">The identifier of the resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="location">The location of the resource.</param>
        /// <param name="tags">The tags of the resource.</param>
        /// <param name="diskType">The storage type for the disk (i.e.
        /// Standard, Premium). Possible values include: 'Standard',
        /// 'Premium'</param>
        /// <param name="diskSizeGiB">The size of the disk in
        /// GibiBytes.</param>
        /// <param name="leasedByLabVmId">The resource ID of the VM to which
        /// this disk is leased.</param>
        /// <param name="diskBlobName">When backed by a blob, the name of the
        /// VHD blob without extension.</param>
        /// <param name="diskUri">When backed by a blob, the URI of underlying
        /// blob.</param>
        /// <param name="createdDate">The creation date of the disk.</param>
        /// <param name="hostCaching">The host caching policy of the disk (i.e.
        /// None, ReadOnly, ReadWrite).</param>
        /// <param name="managedDiskId">When backed by managed disk, this is
        /// the ID of the compute disk resource.</param>
        /// <param name="provisioningState">The provisioning status of the
        /// resource.</param>
        /// <param name="uniqueIdentifier">The unique immutable identifier of a
        /// resource (Guid).</param>
        public Disk(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string diskType = default(string), int? diskSizeGiB = default(int?), string leasedByLabVmId = default(string), string diskBlobName = default(string), string diskUri = default(string), System.DateTime? createdDate = default(System.DateTime?), string hostCaching = default(string), string managedDiskId = default(string), string provisioningState = default(string), string uniqueIdentifier = default(string))
            : base(id, name, type, location, tags)
        {
            DiskType = diskType;
            DiskSizeGiB = diskSizeGiB;
            LeasedByLabVmId = leasedByLabVmId;
            DiskBlobName = diskBlobName;
            DiskUri = diskUri;
            CreatedDate = createdDate;
            HostCaching = hostCaching;
            ManagedDiskId = managedDiskId;
            ProvisioningState = provisioningState;
            UniqueIdentifier = uniqueIdentifier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the storage type for the disk (i.e. Standard,
        /// Premium). Possible values include: 'Standard', 'Premium'
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskType")]
        public string DiskType { get; set; }

        /// <summary>
        /// Gets or sets the size of the disk in GibiBytes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskSizeGiB")]
        public int? DiskSizeGiB { get; set; }

        /// <summary>
        /// Gets or sets the resource ID of the VM to which this disk is
        /// leased.
        /// </summary>
        [JsonProperty(PropertyName = "properties.leasedByLabVmId")]
        public string LeasedByLabVmId { get; set; }

        /// <summary>
        /// Gets or sets when backed by a blob, the name of the VHD blob
        /// without extension.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskBlobName")]
        public string DiskBlobName { get; set; }

        /// <summary>
        /// Gets or sets when backed by a blob, the URI of underlying blob.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskUri")]
        public string DiskUri { get; set; }

        /// <summary>
        /// Gets the creation date of the disk.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdDate")]
        public System.DateTime? CreatedDate { get; private set; }

        /// <summary>
        /// Gets or sets the host caching policy of the disk (i.e. None,
        /// ReadOnly, ReadWrite).
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostCaching")]
        public string HostCaching { get; set; }

        /// <summary>
        /// Gets or sets when backed by managed disk, this is the ID of the
        /// compute disk resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.managedDiskId")]
        public string ManagedDiskId { get; set; }

        /// <summary>
        /// Gets or sets the provisioning status of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the unique immutable identifier of a resource (Guid).
        /// </summary>
        [JsonProperty(PropertyName = "properties.uniqueIdentifier")]
        public string UniqueIdentifier { get; set; }

    }
}
