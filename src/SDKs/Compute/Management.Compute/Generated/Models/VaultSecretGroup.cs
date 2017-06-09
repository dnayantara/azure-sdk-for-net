// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Azure;
    using Management;
    using Compute;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a set of certificates which are all in the same Key Vault.
    /// </summary>
    public partial class VaultSecretGroup
    {
        /// <summary>
        /// Initializes a new instance of the VaultSecretGroup class.
        /// </summary>
        public VaultSecretGroup() { }

        /// <summary>
        /// Initializes a new instance of the VaultSecretGroup class.
        /// </summary>
        /// <param name="sourceVault">The Relative URL of the Key Vault
        /// containing all of the certificates in VaultCertificates.</param>
        /// <param name="vaultCertificates">The list of key vault references in
        /// SourceVault which contain certificates.</param>
        public VaultSecretGroup(SubResource sourceVault = default(SubResource), IList<VaultCertificate> vaultCertificates = default(IList<VaultCertificate>))
        {
            SourceVault = sourceVault;
            VaultCertificates = vaultCertificates;
        }

        /// <summary>
        /// Gets or sets the Relative URL of the Key Vault containing all of
        /// the certificates in VaultCertificates.
        /// </summary>
        [JsonProperty(PropertyName = "sourceVault")]
        public SubResource SourceVault { get; set; }

        /// <summary>
        /// Gets or sets the list of key vault references in SourceVault which
        /// contain certificates.
        /// </summary>
        [JsonProperty(PropertyName = "vaultCertificates")]
        public IList<VaultCertificate> VaultCertificates { get; set; }

    }
}

