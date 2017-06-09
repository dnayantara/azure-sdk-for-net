// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.Backup;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Error information associated with operation status call.
    /// </summary>
    public partial class OperationStatusError
    {
        /// <summary>
        /// Initializes a new instance of the OperationStatusError class.
        /// </summary>
        public OperationStatusError()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationStatusError class.
        /// </summary>
        /// <param name="code">Error code of the operation failure.</param>
        /// <param name="message">Error message displayed if the operation
        /// failure.</param>
        public OperationStatusError(string code = default(string), string message = default(string))
        {
            Code = code;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets error code of the operation failure.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets error message displayed if the operation failure.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
