// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Azure;
    using Management;
    using Compute;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Resource Id.
    /// </summary>
    [JsonTransformation]
    public partial class VirtualMachineCaptureResult : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineCaptureResult
        /// class.
        /// </summary>
        public VirtualMachineCaptureResult() { }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineCaptureResult
        /// class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="output">Operation output data (raw JSON)</param>
        public VirtualMachineCaptureResult(string id = default(string), object output = default(object))
            : base(id)
        {
            Output = output;
        }

        /// <summary>
        /// Gets or sets operation output data (raw JSON)
        /// </summary>
        [JsonProperty(PropertyName = "properties.output")]
        public object Output { get; set; }

    }
}

