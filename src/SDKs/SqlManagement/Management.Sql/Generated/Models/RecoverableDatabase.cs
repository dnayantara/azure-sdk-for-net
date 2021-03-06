// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A recoverable database
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RecoverableDatabase : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the RecoverableDatabase class.
        /// </summary>
        public RecoverableDatabase()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecoverableDatabase class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="edition">The edition of the database</param>
        /// <param name="serviceLevelObjective">The service level objective
        /// name of the database</param>
        /// <param name="elasticPoolName">The elastic pool name of the
        /// database</param>
        /// <param name="lastAvailableBackupDate">The last available backup
        /// date of the database (ISO8601 format)</param>
        public RecoverableDatabase(string id = default(string), string name = default(string), string type = default(string), string edition = default(string), string serviceLevelObjective = default(string), string elasticPoolName = default(string), System.DateTime? lastAvailableBackupDate = default(System.DateTime?))
            : base(id, name, type)
        {
            Edition = edition;
            ServiceLevelObjective = serviceLevelObjective;
            ElasticPoolName = elasticPoolName;
            LastAvailableBackupDate = lastAvailableBackupDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the edition of the database
        /// </summary>
        [JsonProperty(PropertyName = "properties.edition")]
        public string Edition { get; private set; }

        /// <summary>
        /// Gets the service level objective name of the database
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceLevelObjective")]
        public string ServiceLevelObjective { get; private set; }

        /// <summary>
        /// Gets the elastic pool name of the database
        /// </summary>
        [JsonProperty(PropertyName = "properties.elasticPoolName")]
        public string ElasticPoolName { get; private set; }

        /// <summary>
        /// Gets the last available backup date of the database (ISO8601
        /// format)
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastAvailableBackupDate")]
        public System.DateTime? LastAvailableBackupDate { get; private set; }

    }
}
