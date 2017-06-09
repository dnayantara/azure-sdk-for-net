// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{
    using Azure;
    using Management;
    using Batch;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A set of Azure Batch account keys.
    /// </summary>
    public partial class BatchAccountKeys
    {
        /// <summary>
        /// Initializes a new instance of the BatchAccountKeys class.
        /// </summary>
        public BatchAccountKeys() { }

        /// <summary>
        /// Initializes a new instance of the BatchAccountKeys class.
        /// </summary>
        /// <param name="accountName">The Batch account name.</param>
        /// <param name="primary">The primary key associated with the
        /// account.</param>
        /// <param name="secondary">The secondary key associated with the
        /// account.</param>
        public BatchAccountKeys(string accountName = default(string), string primary = default(string), string secondary = default(string))
        {
            AccountName = accountName;
            Primary = primary;
            Secondary = secondary;
        }

        /// <summary>
        /// Gets the Batch account name.
        /// </summary>
        [JsonProperty(PropertyName = "accountName")]
        public string AccountName { get; protected set; }

        /// <summary>
        /// Gets the primary key associated with the account.
        /// </summary>
        [JsonProperty(PropertyName = "primary")]
        public string Primary { get; protected set; }

        /// <summary>
        /// Gets the secondary key associated with the account.
        /// </summary>
        [JsonProperty(PropertyName = "secondary")]
        public string Secondary { get; protected set; }

    }
}

