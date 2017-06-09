// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.Backup;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Additional information of the container.
    /// </summary>
    public partial class MabContainerExtendedInfo
    {
        /// <summary>
        /// Initializes a new instance of the MabContainerExtendedInfo class.
        /// </summary>
        public MabContainerExtendedInfo()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MabContainerExtendedInfo class.
        /// </summary>
        /// <param name="lastRefreshedAt">Time stamp when this container was
        /// refreshed.</param>
        /// <param name="backupItemType">Type of backup items associated with
        /// this container. Possible values include: 'Invalid', 'VM',
        /// 'FileFolder', 'AzureSqlDb', 'SQLDB', 'Exchange', 'Sharepoint',
        /// 'VMwareVM', 'SystemState', 'Client', 'GenericDataSource'</param>
        /// <param name="backupItems">List of backup items associated with this
        /// container.</param>
        /// <param name="policyName">Backup policy associated with this
        /// container.</param>
        /// <param name="lastBackupStatus">Latest backup status of this
        /// container.</param>
        public MabContainerExtendedInfo(System.DateTime? lastRefreshedAt = default(System.DateTime?), string backupItemType = default(string), IList<string> backupItems = default(IList<string>), string policyName = default(string), string lastBackupStatus = default(string))
        {
            LastRefreshedAt = lastRefreshedAt;
            BackupItemType = backupItemType;
            BackupItems = backupItems;
            PolicyName = policyName;
            LastBackupStatus = lastBackupStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets time stamp when this container was refreshed.
        /// </summary>
        [JsonProperty(PropertyName = "lastRefreshedAt")]
        public System.DateTime? LastRefreshedAt { get; set; }

        /// <summary>
        /// Gets or sets type of backup items associated with this container.
        /// Possible values include: 'Invalid', 'VM', 'FileFolder',
        /// 'AzureSqlDb', 'SQLDB', 'Exchange', 'Sharepoint', 'VMwareVM',
        /// 'SystemState', 'Client', 'GenericDataSource'
        /// </summary>
        [JsonProperty(PropertyName = "backupItemType")]
        public string BackupItemType { get; set; }

        /// <summary>
        /// Gets or sets list of backup items associated with this container.
        /// </summary>
        [JsonProperty(PropertyName = "backupItems")]
        public IList<string> BackupItems { get; set; }

        /// <summary>
        /// Gets or sets backup policy associated with this container.
        /// </summary>
        [JsonProperty(PropertyName = "policyName")]
        public string PolicyName { get; set; }

        /// <summary>
        /// Gets or sets latest backup status of this container.
        /// </summary>
        [JsonProperty(PropertyName = "lastBackupStatus")]
        public string LastBackupStatus { get; set; }

    }
}
