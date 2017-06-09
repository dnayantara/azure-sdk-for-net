// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServerManagement.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ServerManagement;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The session object.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SessionResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the SessionResource class.
        /// </summary>
        public SessionResource()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SessionResource class.
        /// </summary>
        /// <param name="id">Resource Manager Resource ID.</param>
        /// <param name="type">Resource Manager Resource Type.</param>
        /// <param name="name">Resource Manager Resource Name.</param>
        /// <param name="location">Resource Manager Resource Location.</param>
        /// <param name="tags">Resource Manager Resource Tags.</param>
        /// <param name="userName">The username connecting to the
        /// session.</param>
        /// <param name="created">UTC date and time when node was first added
        /// to management service.</param>
        /// <param name="updated">UTC date and time when node was last
        /// updated.</param>
        public SessionResource(string id = default(string), string type = default(string), string name = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string etag = default(string), string userName = default(string), System.DateTime? created = default(System.DateTime?), System.DateTime? updated = default(System.DateTime?))
            : base(id, type, name, location, tags, etag)
        {
            UserName = userName;
            Created = created;
            Updated = updated;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the username connecting to the session.
        /// </summary>
        [JsonProperty(PropertyName = "properties.userName")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets UTC date and time when node was first added to
        /// management service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.created")]
        public System.DateTime? Created { get; set; }

        /// <summary>
        /// Gets or sets UTC date and time when node was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updated")]
        public System.DateTime? Updated { get; set; }

    }
}
