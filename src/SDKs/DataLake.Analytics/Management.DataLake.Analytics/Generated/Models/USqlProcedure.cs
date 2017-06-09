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
    /// A Data Lake Analytics catalog U-SQL procedure item.
    /// </summary>
    public partial class USqlProcedure : CatalogItem
    {
        /// <summary>
        /// Initializes a new instance of the USqlProcedure class.
        /// </summary>
        public USqlProcedure()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the USqlProcedure class.
        /// </summary>
        /// <param name="computeAccountName">the name of the Data Lake
        /// Analytics account.</param>
        /// <param name="version">the version of the catalog item.</param>
        /// <param name="databaseName">the name of the database.</param>
        /// <param name="schemaName">the name of the schema associated with
        /// this procedure and database.</param>
        /// <param name="name">the name of the procedure.</param>
        /// <param name="definition">the defined query of the
        /// procedure.</param>
        public USqlProcedure(string computeAccountName = default(string), System.Guid? version = default(System.Guid?), string databaseName = default(string), string schemaName = default(string), string name = default(string), string definition = default(string))
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
        /// Gets or sets the name of the database.
        /// </summary>
        [JsonProperty(PropertyName = "databaseName")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Gets or sets the name of the schema associated with this procedure
        /// and database.
        /// </summary>
        [JsonProperty(PropertyName = "schemaName")]
        public string SchemaName { get; set; }

        /// <summary>
        /// Gets or sets the name of the procedure.
        /// </summary>
        [JsonProperty(PropertyName = "procName")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the defined query of the procedure.
        /// </summary>
        [JsonProperty(PropertyName = "definition")]
        public string Definition { get; set; }

    }
}
