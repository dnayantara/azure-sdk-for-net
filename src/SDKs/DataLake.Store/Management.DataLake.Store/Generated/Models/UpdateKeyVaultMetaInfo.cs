// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Azure.Management.DataLake.Store;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Key Vault update information used for user managed key rotation.
    /// </summary>
    public partial class UpdateKeyVaultMetaInfo
    {
        /// <summary>
        /// Initializes a new instance of the UpdateKeyVaultMetaInfo class.
        /// </summary>
        public UpdateKeyVaultMetaInfo()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateKeyVaultMetaInfo class.
        /// </summary>
        /// <param name="encryptionKeyVersion">The version of the user managed
        /// encryption key to update through a key rotation.</param>
        public UpdateKeyVaultMetaInfo(string encryptionKeyVersion = default(string))
        {
            EncryptionKeyVersion = encryptionKeyVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the version of the user managed encryption key to
        /// update through a key rotation.
        /// </summary>
        [JsonProperty(PropertyName = "encryptionKeyVersion")]
        public string EncryptionKeyVersion { get; set; }

    }
}
