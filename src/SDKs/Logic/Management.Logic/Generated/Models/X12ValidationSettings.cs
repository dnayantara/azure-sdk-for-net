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
    /// The X12 agreement validation settings.
    /// </summary>
    public partial class X12ValidationSettings
    {
        /// <summary>
        /// Initializes a new instance of the X12ValidationSettings class.
        /// </summary>
        public X12ValidationSettings()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the X12ValidationSettings class.
        /// </summary>
        /// <param name="validateCharacterSet">The value indicating whether to
        /// validate character set in the message.</param>
        /// <param name="checkDuplicateInterchangeControlNumber">The value
        /// indicating whether to check for duplicate interchange control
        /// number.</param>
        /// <param name="interchangeControlNumberValidityDays">The validity
        /// period of interchange control number.</param>
        /// <param name="checkDuplicateGroupControlNumber">The value indicating
        /// whether to check for duplicate group control number.</param>
        /// <param name="checkDuplicateTransactionSetControlNumber">The value
        /// indicating whether to check for duplicate transaction set control
        /// number.</param>
        /// <param name="validateEdiTypes">The value indicating whether to
        /// Whether to validate EDI types.</param>
        /// <param name="validateXsdTypes">The value indicating whether to
        /// Whether to validate XSD types.</param>
        /// <param name="allowLeadingAndTrailingSpacesAndZeroes">The value
        /// indicating whether to allow leading and trailing spaces and
        /// zeroes.</param>
        /// <param name="trimLeadingAndTrailingSpacesAndZeroes">The value
        /// indicating whether to trim leading and trailing spaces and
        /// zeroes.</param>
        /// <param name="trailingSeparatorPolicy">The trailing separator
        /// policy. Possible values include: 'NotSpecified', 'NotAllowed',
        /// 'Optional', 'Mandatory'</param>
        public X12ValidationSettings(bool validateCharacterSet, bool checkDuplicateInterchangeControlNumber, int interchangeControlNumberValidityDays, bool checkDuplicateGroupControlNumber, bool checkDuplicateTransactionSetControlNumber, bool validateEdiTypes, bool validateXsdTypes, bool allowLeadingAndTrailingSpacesAndZeroes, bool trimLeadingAndTrailingSpacesAndZeroes, TrailingSeparatorPolicy trailingSeparatorPolicy)
        {
            ValidateCharacterSet = validateCharacterSet;
            CheckDuplicateInterchangeControlNumber = checkDuplicateInterchangeControlNumber;
            InterchangeControlNumberValidityDays = interchangeControlNumberValidityDays;
            CheckDuplicateGroupControlNumber = checkDuplicateGroupControlNumber;
            CheckDuplicateTransactionSetControlNumber = checkDuplicateTransactionSetControlNumber;
            ValidateEdiTypes = validateEdiTypes;
            ValidateXsdTypes = validateXsdTypes;
            AllowLeadingAndTrailingSpacesAndZeroes = allowLeadingAndTrailingSpacesAndZeroes;
            TrimLeadingAndTrailingSpacesAndZeroes = trimLeadingAndTrailingSpacesAndZeroes;
            TrailingSeparatorPolicy = trailingSeparatorPolicy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the value indicating whether to validate character set
        /// in the message.
        /// </summary>
        [JsonProperty(PropertyName = "validateCharacterSet")]
        public bool ValidateCharacterSet { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to check for duplicate
        /// interchange control number.
        /// </summary>
        [JsonProperty(PropertyName = "checkDuplicateInterchangeControlNumber")]
        public bool CheckDuplicateInterchangeControlNumber { get; set; }

        /// <summary>
        /// Gets or sets the validity period of interchange control number.
        /// </summary>
        [JsonProperty(PropertyName = "interchangeControlNumberValidityDays")]
        public int InterchangeControlNumberValidityDays { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to check for duplicate
        /// group control number.
        /// </summary>
        [JsonProperty(PropertyName = "checkDuplicateGroupControlNumber")]
        public bool CheckDuplicateGroupControlNumber { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to check for duplicate
        /// transaction set control number.
        /// </summary>
        [JsonProperty(PropertyName = "checkDuplicateTransactionSetControlNumber")]
        public bool CheckDuplicateTransactionSetControlNumber { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to Whether to validate
        /// EDI types.
        /// </summary>
        [JsonProperty(PropertyName = "validateEdiTypes")]
        public bool ValidateEdiTypes { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to Whether to validate
        /// XSD types.
        /// </summary>
        [JsonProperty(PropertyName = "validateXsdTypes")]
        public bool ValidateXsdTypes { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to allow leading and
        /// trailing spaces and zeroes.
        /// </summary>
        [JsonProperty(PropertyName = "allowLeadingAndTrailingSpacesAndZeroes")]
        public bool AllowLeadingAndTrailingSpacesAndZeroes { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to trim leading and
        /// trailing spaces and zeroes.
        /// </summary>
        [JsonProperty(PropertyName = "trimLeadingAndTrailingSpacesAndZeroes")]
        public bool TrimLeadingAndTrailingSpacesAndZeroes { get; set; }

        /// <summary>
        /// Gets or sets the trailing separator policy. Possible values
        /// include: 'NotSpecified', 'NotAllowed', 'Optional', 'Mandatory'
        /// </summary>
        [JsonProperty(PropertyName = "trailingSeparatorPolicy")]
        public TrailingSeparatorPolicy TrailingSeparatorPolicy { get; set; }

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
