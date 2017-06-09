// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Search.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Search;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ProvisioningState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProvisioningState
    {
        [EnumMember(Value = "succeeded")]
        Succeeded,
        [EnumMember(Value = "provisioning")]
        Provisioning,
        [EnumMember(Value = "failed")]
        Failed
    }
}
