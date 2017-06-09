// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Insights.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Insights;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Email notification of an autoscale event.
    /// </summary>
    public partial class EmailNotification
    {
        /// <summary>
        /// Initializes a new instance of the EmailNotification class.
        /// </summary>
        public EmailNotification()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EmailNotification class.
        /// </summary>
        /// <param name="sendToSubscriptionAdministrator">a value indicating
        /// whether to send email to subscription administrator.</param>
        /// <param name="sendToSubscriptionCoAdministrators">a value indicating
        /// whether to send email to subscription co-administrators.</param>
        /// <param name="customEmails">the custom e-mails list. This value can
        /// be null or empty, in which case this attribute will be
        /// ignored.</param>
        public EmailNotification(bool? sendToSubscriptionAdministrator = default(bool?), bool? sendToSubscriptionCoAdministrators = default(bool?), IList<string> customEmails = default(IList<string>))
        {
            SendToSubscriptionAdministrator = sendToSubscriptionAdministrator;
            SendToSubscriptionCoAdministrators = sendToSubscriptionCoAdministrators;
            CustomEmails = customEmails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a value indicating whether to send email to
        /// subscription administrator.
        /// </summary>
        [JsonProperty(PropertyName = "sendToSubscriptionAdministrator")]
        public bool? SendToSubscriptionAdministrator { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to send email to
        /// subscription co-administrators.
        /// </summary>
        [JsonProperty(PropertyName = "sendToSubscriptionCoAdministrators")]
        public bool? SendToSubscriptionCoAdministrators { get; set; }

        /// <summary>
        /// Gets or sets the custom e-mails list. This value can be null or
        /// empty, in which case this attribute will be ignored.
        /// </summary>
        [JsonProperty(PropertyName = "customEmails")]
        public IList<string> CustomEmails { get; set; }

    }
}
