// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Logic;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The integration account schema.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class IntegrationAccountSchema : Resource
    {
        /// <summary>
        /// Initializes a new instance of the IntegrationAccountSchema class.
        /// </summary>
        public IntegrationAccountSchema()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IntegrationAccountSchema class.
        /// </summary>
        /// <param name="schemaType">The schema type. Possible values include:
        /// 'NotSpecified', 'Xml'</param>
        /// <param name="id">The resource id.</param>
        /// <param name="name">Gets the resource name.</param>
        /// <param name="type">Gets the resource type.</param>
        /// <param name="location">The resource location.</param>
        /// <param name="tags">The resource tags.</param>
        /// <param name="targetNamespace">The target namespace of the
        /// schema.</param>
        /// <param name="documentName">The document name.</param>
        /// <param name="fileName">The file name.</param>
        /// <param name="createdTime">The created time.</param>
        /// <param name="changedTime">The changed time.</param>
        /// <param name="metadata">The metadata.</param>
        /// <param name="content">The content.</param>
        /// <param name="contentType">The content type.</param>
        /// <param name="contentLink">The content link.</param>
        public IntegrationAccountSchema(SchemaType schemaType, string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string targetNamespace = default(string), string documentName = default(string), string fileName = default(string), System.DateTime? createdTime = default(System.DateTime?), System.DateTime? changedTime = default(System.DateTime?), object metadata = default(object), string content = default(string), string contentType = default(string), ContentLink contentLink = default(ContentLink))
            : base(id, name, type, location, tags)
        {
            SchemaType = schemaType;
            TargetNamespace = targetNamespace;
            DocumentName = documentName;
            FileName = fileName;
            CreatedTime = createdTime;
            ChangedTime = changedTime;
            Metadata = metadata;
            Content = content;
            ContentType = contentType;
            ContentLink = contentLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the schema type. Possible values include:
        /// 'NotSpecified', 'Xml'
        /// </summary>
        [JsonProperty(PropertyName = "properties.schemaType")]
        public SchemaType SchemaType { get; set; }

        /// <summary>
        /// Gets or sets the target namespace of the schema.
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetNamespace")]
        public string TargetNamespace { get; set; }

        /// <summary>
        /// Gets or sets the document name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.documentName")]
        public string DocumentName { get; set; }

        /// <summary>
        /// Gets or sets the file name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fileName")]
        public string FileName { get; set; }

        /// <summary>
        /// Gets the created time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdTime")]
        public System.DateTime? CreatedTime { get; private set; }

        /// <summary>
        /// Gets the changed time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.changedTime")]
        public System.DateTime? ChangedTime { get; private set; }

        /// <summary>
        /// Gets or sets the metadata.
        /// </summary>
        [JsonProperty(PropertyName = "properties.metadata")]
        public object Metadata { get; set; }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        [JsonProperty(PropertyName = "properties.content")]
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the content type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.contentType")]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets the content link.
        /// </summary>
        [JsonProperty(PropertyName = "properties.contentLink")]
        public ContentLink ContentLink { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
