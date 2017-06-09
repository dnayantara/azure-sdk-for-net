// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Logic;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The integration account agreement filter for odata query.
    /// </summary>
    public partial class IntegrationAccountAgreementFilter
    {
        /// <summary>
        /// Initializes a new instance of the IntegrationAccountAgreementFilter
        /// class.
        /// </summary>
        public IntegrationAccountAgreementFilter()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IntegrationAccountAgreementFilter
        /// class.
        /// </summary>
        /// <param name="agreementType">The agreement type of integration
        /// account agreement. Possible values include: 'NotSpecified', 'AS2',
        /// 'X12', 'Edifact'</param>
        public IntegrationAccountAgreementFilter(AgreementType agreementType)
        {
            AgreementType = agreementType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the agreement type of integration account agreement.
        /// Possible values include: 'NotSpecified', 'AS2', 'X12', 'Edifact'
        /// </summary>
        [JsonProperty(PropertyName = "agreementType")]
        public AgreementType AgreementType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
