// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Azure;
    using Management;
    using Cdn;
    using Rest;
    using Rest.Azure;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Origin to be added when creating a CDN endpoint.
    /// </summary>
    [JsonTransformation]
    public partial class DeepCreatedOrigin : IResource
    {
        /// <summary>
        /// Initializes a new instance of the DeepCreatedOrigin class.
        /// </summary>
        public DeepCreatedOrigin() { }

        /// <summary>
        /// Initializes a new instance of the DeepCreatedOrigin class.
        /// </summary>
        /// <param name="name">Origin name</param>
        /// <param name="hostName">The address of the origin. It can be a
        /// domain names, IPv4 address, or IPv6 address.</param>
        /// <param name="httpPort">The value of the HTTP port. Must be between
        /// 1 and 65535</param>
        /// <param name="httpsPort">The value of the HTTPS port. Must be
        /// between 1 and 65535</param>
        public DeepCreatedOrigin(string name, string hostName, int? httpPort = default(int?), int? httpsPort = default(int?))
        {
            Name = name;
            HostName = hostName;
            HttpPort = httpPort;
            HttpsPort = httpsPort;
        }

        /// <summary>
        /// Gets or sets origin name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the address of the origin. It can be a domain names,
        /// IPv4 address, or IPv6 address.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostName")]
        public string HostName { get; set; }

        /// <summary>
        /// Gets or sets the value of the HTTP port. Must be between 1 and
        /// 65535
        /// </summary>
        [JsonProperty(PropertyName = "properties.httpPort")]
        public int? HttpPort { get; set; }

        /// <summary>
        /// Gets or sets the value of the HTTPS port. Must be between 1 and
        /// 65535
        /// </summary>
        [JsonProperty(PropertyName = "properties.httpsPort")]
        public int? HttpsPort { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (HostName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "HostName");
            }
            if (HttpPort > 65535)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "HttpPort", 65535);
            }
            if (HttpPort < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "HttpPort", 1);
            }
            if (HttpsPort > 65535)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "HttpsPort", 65535);
            }
            if (HttpsPort < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "HttpsPort", 1);
            }
        }
    }
}

