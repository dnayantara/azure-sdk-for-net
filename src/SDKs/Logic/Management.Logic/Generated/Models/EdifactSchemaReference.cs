// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Logic;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Edifact schema reference.
    /// </summary>
    public partial class EdifactSchemaReference
    {
        /// <summary>
        /// Initializes a new instance of the EdifactSchemaReference class.
        /// </summary>
        public EdifactSchemaReference()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EdifactSchemaReference class.
        /// </summary>
        /// <param name="messageId">The message id.</param>
        /// <param name="messageVersion">The message version.</param>
        /// <param name="messageRelease">The message release version.</param>
        /// <param name="schemaName">The schema name.</param>
        /// <param name="senderApplicationId">The sender application
        /// id.</param>
        /// <param name="senderApplicationQualifier">The sender application
        /// qualifier.</param>
        /// <param name="associationAssignedCode">The association assigned
        /// code.</param>
        public EdifactSchemaReference(string messageId, string messageVersion, string messageRelease, string schemaName, string senderApplicationId = default(string), string senderApplicationQualifier = default(string), string associationAssignedCode = default(string))
        {
            MessageId = messageId;
            MessageVersion = messageVersion;
            MessageRelease = messageRelease;
            SenderApplicationId = senderApplicationId;
            SenderApplicationQualifier = senderApplicationQualifier;
            AssociationAssignedCode = associationAssignedCode;
            SchemaName = schemaName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the message id.
        /// </summary>
        [JsonProperty(PropertyName = "messageId")]
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or sets the message version.
        /// </summary>
        [JsonProperty(PropertyName = "messageVersion")]
        public string MessageVersion { get; set; }

        /// <summary>
        /// Gets or sets the message release version.
        /// </summary>
        [JsonProperty(PropertyName = "messageRelease")]
        public string MessageRelease { get; set; }

        /// <summary>
        /// Gets or sets the sender application id.
        /// </summary>
        [JsonProperty(PropertyName = "senderApplicationId")]
        public string SenderApplicationId { get; set; }

        /// <summary>
        /// Gets or sets the sender application qualifier.
        /// </summary>
        [JsonProperty(PropertyName = "senderApplicationQualifier")]
        public string SenderApplicationQualifier { get; set; }

        /// <summary>
        /// Gets or sets the association assigned code.
        /// </summary>
        [JsonProperty(PropertyName = "associationAssignedCode")]
        public string AssociationAssignedCode { get; set; }

        /// <summary>
        /// Gets or sets the schema name.
        /// </summary>
        [JsonProperty(PropertyName = "schemaName")]
        public string SchemaName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MessageId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MessageId");
            }
            if (MessageVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MessageVersion");
            }
            if (MessageRelease == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MessageRelease");
            }
            if (SchemaName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SchemaName");
            }
        }
    }
}
