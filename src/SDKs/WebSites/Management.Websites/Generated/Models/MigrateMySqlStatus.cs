// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Azure;
    using Management;
    using WebSites;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// MySQL migration status.
    /// </summary>
    [JsonTransformation]
    public partial class MigrateMySqlStatus : Resource
    {
        /// <summary>
        /// Initializes a new instance of the MigrateMySqlStatus class.
        /// </summary>
        public MigrateMySqlStatus() { }

        /// <summary>
        /// Initializes a new instance of the MigrateMySqlStatus class.
        /// </summary>
        /// <param name="location">Resource Location.</param>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="migrationOperationStatus">Status of the migration
        /// task. Possible values include: 'InProgress', 'Failed', 'Succeeded',
        /// 'TimedOut', 'Created'</param>
        /// <param name="operationId">Operation ID for the migration
        /// task.</param>
        /// <param name="localMySqlEnabled">True if the web app has in app
        /// MySql enabled</param>
        public MigrateMySqlStatus(string location, string id = default(string), string name = default(string), string kind = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), OperationStatus? migrationOperationStatus = default(OperationStatus?), string operationId = default(string), bool? localMySqlEnabled = default(bool?))
            : base(location, id, name, kind, type, tags)
        {
            MigrationOperationStatus = migrationOperationStatus;
            OperationId = operationId;
            LocalMySqlEnabled = localMySqlEnabled;
        }

        /// <summary>
        /// Gets status of the migration task. Possible values include:
        /// 'InProgress', 'Failed', 'Succeeded', 'TimedOut', 'Created'
        /// </summary>
        [JsonProperty(PropertyName = "properties.migrationOperationStatus")]
        public OperationStatus? MigrationOperationStatus { get; protected set; }

        /// <summary>
        /// Gets operation ID for the migration task.
        /// </summary>
        [JsonProperty(PropertyName = "properties.operationId")]
        public string OperationId { get; protected set; }

        /// <summary>
        /// Gets true if the web app has in app MySql enabled
        /// </summary>
        [JsonProperty(PropertyName = "properties.localMySqlEnabled")]
        public bool? LocalMySqlEnabled { get; protected set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}

