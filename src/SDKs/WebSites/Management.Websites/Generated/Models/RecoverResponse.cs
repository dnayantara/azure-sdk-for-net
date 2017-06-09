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
    /// Response for an app recovery request.
    /// </summary>
    [JsonTransformation]
    public partial class RecoverResponse : Resource
    {
        /// <summary>
        /// Initializes a new instance of the RecoverResponse class.
        /// </summary>
        public RecoverResponse() { }

        /// <summary>
        /// Initializes a new instance of the RecoverResponse class.
        /// </summary>
        /// <param name="location">Resource Location.</param>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="operationId">ID of the recovery operation. Can be used
        /// to check the status of the corresponding operation.</param>
        public RecoverResponse(string location, string id = default(string), string name = default(string), string kind = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string operationId = default(string))
            : base(location, id, name, kind, type, tags)
        {
            OperationId = operationId;
        }

        /// <summary>
        /// Gets ID of the recovery operation. Can be used to check the status
        /// of the corresponding operation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.operationId")]
        public string OperationId { get; protected set; }

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

