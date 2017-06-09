// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Azure.Management.DataLake.Analytics;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A Data Lake Analytics catalog U-SQL credential item.
    /// </summary>
    public partial class USqlCredential : CatalogItem
    {
        /// <summary>
        /// Initializes a new instance of the USqlCredential class.
        /// </summary>
        public USqlCredential()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the USqlCredential class.
        /// </summary>
        /// <param name="computeAccountName">the name of the Data Lake
        /// Analytics account.</param>
        /// <param name="version">the version of the catalog item.</param>
        /// <param name="name">the name of the credential.</param>
        public USqlCredential(string computeAccountName = default(string), System.Guid? version = default(System.Guid?), string name = default(string))
            : base(computeAccountName, version)
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the credential.
        /// </summary>
        [JsonProperty(PropertyName = "credentialName")]
        public string Name { get; set; }

    }
}
