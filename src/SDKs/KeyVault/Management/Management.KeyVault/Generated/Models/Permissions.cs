// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.KeyVault.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.KeyVault;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Permissions the identity has for keys, secrets, certificates and
    /// storage.
    /// </summary>
    public partial class Permissions
    {
        /// <summary>
        /// Initializes a new instance of the Permissions class.
        /// </summary>
        public Permissions()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Permissions class.
        /// </summary>
        /// <param name="keys">Permissions to keys</param>
        /// <param name="secrets">Permissions to secrets</param>
        /// <param name="certificates">Permissions to certificates</param>
        /// <param name="storage">Permissions to storage accounts</param>
        public Permissions(IList<string> keys = default(IList<string>), IList<string> secrets = default(IList<string>), IList<string> certificates = default(IList<string>), IList<string> storage = default(IList<string>))
        {
            Keys = keys;
            Secrets = secrets;
            Certificates = certificates;
            Storage = storage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets permissions to keys
        /// </summary>
        [JsonProperty(PropertyName = "keys")]
        public IList<string> Keys { get; set; }

        /// <summary>
        /// Gets or sets permissions to secrets
        /// </summary>
        [JsonProperty(PropertyName = "secrets")]
        public IList<string> Secrets { get; set; }

        /// <summary>
        /// Gets or sets permissions to certificates
        /// </summary>
        [JsonProperty(PropertyName = "certificates")]
        public IList<string> Certificates { get; set; }

        /// <summary>
        /// Gets or sets permissions to storage accounts
        /// </summary>
        [JsonProperty(PropertyName = "storage")]
        public IList<string> Storage { get; set; }

    }
}
