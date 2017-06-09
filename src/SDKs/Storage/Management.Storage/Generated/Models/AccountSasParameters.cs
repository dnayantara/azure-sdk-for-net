// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Storage.Models
{
    using Azure;
    using Management;
    using Storage;
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The parameters to list SAS credentials of a storage account.
    /// </summary>
    public partial class AccountSasParameters
    {
        /// <summary>
        /// Initializes a new instance of the AccountSasParameters class.
        /// </summary>
        public AccountSasParameters() { }

        /// <summary>
        /// Initializes a new instance of the AccountSasParameters class.
        /// </summary>
        /// <param name="services">The signed services accessible with the
        /// account SAS. Possible values include: Blob (b), Queue (q), Table
        /// (t), File (f). Possible values include: 'b', 'q', 't', 'f'</param>
        /// <param name="resourceTypes">The signed resource types that are
        /// accessible with the account SAS. Service (s): Access to
        /// service-level APIs; Container (c): Access to container-level APIs;
        /// Object (o): Access to object-level APIs for blobs, queue messages,
        /// table entities, and files. Possible values include: 's', 'c',
        /// 'o'</param>
        /// <param name="permissions">The signed permissions for the account
        /// SAS. Possible values include: Read (r), Write (w), Delete (d), List
        /// (l), Add (a), Create (c), Update (u) and Process (p). Possible
        /// values include: 'r', 'd', 'w', 'l', 'a', 'c', 'u', 'p'</param>
        /// <param name="sharedAccessExpiryTime">The time at which the shared
        /// access signature becomes invalid.</param>
        /// <param name="iPAddressOrRange">An IP address or a range of IP
        /// addresses from which to accept requests.</param>
        /// <param name="protocols">The protocol permitted for a request made
        /// with the account SAS. Possible values include: 'https,http',
        /// 'https'</param>
        /// <param name="sharedAccessStartTime">The time at which the SAS
        /// becomes valid.</param>
        /// <param name="keyToSign">The key to sign the account SAS token
        /// with.</param>
        public AccountSasParameters(string services, string resourceTypes, string permissions, System.DateTime sharedAccessExpiryTime, string iPAddressOrRange = default(string), HttpProtocol? protocols = default(HttpProtocol?), System.DateTime? sharedAccessStartTime = default(System.DateTime?), string keyToSign = default(string))
        {
            Services = services;
            ResourceTypes = resourceTypes;
            Permissions = permissions;
            IPAddressOrRange = iPAddressOrRange;
            Protocols = protocols;
            SharedAccessStartTime = sharedAccessStartTime;
            SharedAccessExpiryTime = sharedAccessExpiryTime;
            KeyToSign = keyToSign;
        }

        /// <summary>
        /// Gets or sets the signed services accessible with the account SAS.
        /// Possible values include: Blob (b), Queue (q), Table (t), File (f).
        /// Possible values include: 'b', 'q', 't', 'f'
        /// </summary>
        [JsonProperty(PropertyName = "signedServices")]
        public string Services { get; set; }

        /// <summary>
        /// Gets or sets the signed resource types that are accessible with the
        /// account SAS. Service (s): Access to service-level APIs; Container
        /// (c): Access to container-level APIs; Object (o): Access to
        /// object-level APIs for blobs, queue messages, table entities, and
        /// files. Possible values include: 's', 'c', 'o'
        /// </summary>
        [JsonProperty(PropertyName = "signedResourceTypes")]
        public string ResourceTypes { get; set; }

        /// <summary>
        /// Gets or sets the signed permissions for the account SAS. Possible
        /// values include: Read (r), Write (w), Delete (d), List (l), Add (a),
        /// Create (c), Update (u) and Process (p). Possible values include:
        /// 'r', 'd', 'w', 'l', 'a', 'c', 'u', 'p'
        /// </summary>
        [JsonProperty(PropertyName = "signedPermission")]
        public string Permissions { get; set; }

        /// <summary>
        /// Gets or sets an IP address or a range of IP addresses from which to
        /// accept requests.
        /// </summary>
        [JsonProperty(PropertyName = "signedIp")]
        public string IPAddressOrRange { get; set; }

        /// <summary>
        /// Gets or sets the protocol permitted for a request made with the
        /// account SAS. Possible values include: 'https,http', 'https'
        /// </summary>
        [JsonProperty(PropertyName = "signedProtocol")]
        public HttpProtocol? Protocols { get; set; }

        /// <summary>
        /// Gets or sets the time at which the SAS becomes valid.
        /// </summary>
        [JsonProperty(PropertyName = "signedStart")]
        public System.DateTime? SharedAccessStartTime { get; set; }

        /// <summary>
        /// Gets or sets the time at which the shared access signature becomes
        /// invalid.
        /// </summary>
        [JsonProperty(PropertyName = "signedExpiry")]
        public System.DateTime SharedAccessExpiryTime { get; set; }

        /// <summary>
        /// Gets or sets the key to sign the account SAS token with.
        /// </summary>
        [JsonProperty(PropertyName = "keyToSign")]
        public string KeyToSign { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Services == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Services");
            }
            if (ResourceTypes == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceTypes");
            }
            if (Permissions == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Permissions");
            }
        }
    }
}

