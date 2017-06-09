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
    using System.Linq;

    /// <summary>
    /// Azure SQL workload-specific backup policy.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureSql")]
    public partial class AzureSqlProtectionPolicy : ProtectionPolicy
    {
        /// <summary>
        /// Initializes a new instance of the AzureSqlProtectionPolicy class.
        /// </summary>
        public AzureSqlProtectionPolicy()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureSqlProtectionPolicy class.
        /// </summary>
        /// <param name="protectedItemsCount">Number of items associated with
        /// this policy.</param>
        /// <param name="retentionPolicy">Retention policy details.</param>
        public AzureSqlProtectionPolicy(int? protectedItemsCount = default(int?), RetentionPolicy retentionPolicy = default(RetentionPolicy))
            : base(protectedItemsCount)
        {
            RetentionPolicy = retentionPolicy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets retention policy details.
        /// </summary>
        [JsonProperty(PropertyName = "retentionPolicy")]
        public RetentionPolicy RetentionPolicy { get; set; }

    }
}
