// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Azure;
    using Management;
    using Compute;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DiskCreateOptionTypes.
    /// </summary>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DiskCreateOptionTypes
    {
        [EnumMember(Value = "fromImage")]
        FromImage,
        [EnumMember(Value = "empty")]
        Empty,
        [EnumMember(Value = "attach")]
        Attach
    }
}

