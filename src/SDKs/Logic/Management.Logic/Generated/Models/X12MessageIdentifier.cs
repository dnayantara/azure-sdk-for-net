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
    /// The X12 message identifier.
    /// </summary>
    public partial class X12MessageIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the X12MessageIdentifier class.
        /// </summary>
        public X12MessageIdentifier()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the X12MessageIdentifier class.
        /// </summary>
        /// <param name="messageId">The message id.</param>
        public X12MessageIdentifier(string messageId)
        {
            MessageId = messageId;
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
        }
    }
}
