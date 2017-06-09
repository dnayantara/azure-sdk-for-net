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
    /// A Data Lake Analytics catalog U-SQL package item.
    /// </summary>
    public partial class USqlPackage : CatalogItem
    {
        /// <summary>
        /// Initializes a new instance of the USqlPackage class.
        /// </summary>
        public USqlPackage()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the USqlPackage class.
        /// </summary>
        /// <param name="computeAccountName">the name of the Data Lake
        /// Analytics account.</param>
        /// <param name="version">the version of the catalog item.</param>
        /// <param name="databaseName">the name of the database containing the
        /// package.</param>
        /// <param name="schemaName">the name of the schema associated with
        /// this package and database.</param>
        /// <param name="name">the name of the package.</param>
        /// <param name="definition">the definition of the package.</param>
        public USqlPackage(string computeAccountName = default(string), System.Guid? version = default(System.Guid?), string databaseName = default(string), string schemaName = default(string), string name = default(string), string definition = default(string))
            : base(computeAccountName, version)
        {
            DatabaseName = databaseName;
            SchemaName = schemaName;
            Name = name;
            Definition = definition;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the database containing the package.
        /// </summary>
        [JsonProperty(PropertyName = "databaseName")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Gets or sets the name of the schema associated with this package
        /// and database.
        /// </summary>
        [JsonProperty(PropertyName = "schemaName")]
        public string SchemaName { get; set; }

        /// <summary>
        /// Gets or sets the name of the package.
        /// </summary>
        [JsonProperty(PropertyName = "packageName")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the definition of the package.
        /// </summary>
        [JsonProperty(PropertyName = "definition")]
        public string Definition { get; set; }

    }
}
