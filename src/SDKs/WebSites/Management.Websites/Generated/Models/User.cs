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
    /// User crendentials used for publishing activity.
    /// </summary>
    [JsonTransformation]
    public partial class User : Resource
    {
        /// <summary>
        /// Initializes a new instance of the User class.
        /// </summary>
        public User() { }

        /// <summary>
        /// Initializes a new instance of the User class.
        /// </summary>
        /// <param name="location">Resource Location.</param>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="userName">Username</param>
        /// <param name="publishingUserName">Username used for
        /// publishing.</param>
        /// <param name="publishingPassword">Password used for
        /// publishing.</param>
        /// <param name="publishingPasswordHash">Password hash used for
        /// publishing.</param>
        /// <param name="publishingPasswordHashSalt">Password hash salt used
        /// for publishing.</param>
        public User(string location, string id = default(string), string name = default(string), string kind = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string userName = default(string), string publishingUserName = default(string), string publishingPassword = default(string), string publishingPasswordHash = default(string), string publishingPasswordHashSalt = default(string))
            : base(location, id, name, kind, type, tags)
        {
            UserName = userName;
            PublishingUserName = publishingUserName;
            PublishingPassword = publishingPassword;
            PublishingPasswordHash = publishingPasswordHash;
            PublishingPasswordHashSalt = publishingPasswordHashSalt;
        }

        /// <summary>
        /// Gets or sets username
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets username used for publishing.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publishingUserName")]
        public string PublishingUserName { get; set; }

        /// <summary>
        /// Gets or sets password used for publishing.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publishingPassword")]
        public string PublishingPassword { get; set; }

        /// <summary>
        /// Gets or sets password hash used for publishing.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publishingPasswordHash")]
        public string PublishingPasswordHash { get; set; }

        /// <summary>
        /// Gets or sets password hash salt used for publishing.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publishingPasswordHashSalt")]
        public string PublishingPasswordHashSalt { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}

