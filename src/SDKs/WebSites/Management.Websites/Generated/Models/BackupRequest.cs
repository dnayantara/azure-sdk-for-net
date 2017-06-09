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
    /// Description of a backup which will be performed.
    /// </summary>
    [JsonTransformation]
    public partial class BackupRequest : Resource
    {
        /// <summary>
        /// Initializes a new instance of the BackupRequest class.
        /// </summary>
        public BackupRequest() { }

        /// <summary>
        /// Initializes a new instance of the BackupRequest class.
        /// </summary>
        /// <param name="location">Resource Location.</param>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="backupRequestName">Name of the backup.</param>
        /// <param name="enabled">True if the backup schedule is enabled (must
        /// be included in that case), false if the backup schedule should be
        /// disabled.</param>
        /// <param name="storageAccountUrl">SAS URL to the container.</param>
        /// <param name="backupSchedule">Schedule for the backup if it is
        /// executed periodically.</param>
        /// <param name="databases">Databases included in the backup.</param>
        /// <param name="backupRequestType">Type of the backup. Possible values
        /// include: 'Default', 'Clone', 'Relocation'</param>
        public BackupRequest(string location, string id = default(string), string name = default(string), string kind = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string backupRequestName = default(string), bool? enabled = default(bool?), string storageAccountUrl = default(string), BackupSchedule backupSchedule = default(BackupSchedule), IList<DatabaseBackupSetting> databases = default(IList<DatabaseBackupSetting>), BackupRestoreOperationType? backupRequestType = default(BackupRestoreOperationType?))
            : base(location, id, name, kind, type, tags)
        {
            BackupRequestName = backupRequestName;
            Enabled = enabled;
            StorageAccountUrl = storageAccountUrl;
            BackupSchedule = backupSchedule;
            Databases = databases;
            BackupRequestType = backupRequestType;
        }

        /// <summary>
        /// Gets or sets name of the backup.
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string BackupRequestName { get; set; }

        /// <summary>
        /// Gets or sets true if the backup schedule is enabled (must be
        /// included in that case), false if the backup schedule should be
        /// disabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets SAS URL to the container.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccountUrl")]
        public string StorageAccountUrl { get; set; }

        /// <summary>
        /// Gets or sets schedule for the backup if it is executed
        /// periodically.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backupSchedule")]
        public BackupSchedule BackupSchedule { get; set; }

        /// <summary>
        /// Gets or sets databases included in the backup.
        /// </summary>
        [JsonProperty(PropertyName = "properties.databases")]
        public IList<DatabaseBackupSetting> Databases { get; set; }

        /// <summary>
        /// Gets or sets type of the backup. Possible values include:
        /// 'Default', 'Clone', 'Relocation'
        /// </summary>
        [JsonProperty(PropertyName = "properties.type")]
        public BackupRestoreOperationType? BackupRequestType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (BackupSchedule != null)
            {
                BackupSchedule.Validate();
            }
            if (Databases != null)
            {
                foreach (var element in Databases)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}

