// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Scheduler.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Scheduler;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for HttpAuthenticationType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HttpAuthenticationType
    {
        [EnumMember(Value = "NotSpecified")]
        NotSpecified,
        [EnumMember(Value = "ClientCertificate")]
        ClientCertificate,
        [EnumMember(Value = "ActiveDirectoryOAuth")]
        ActiveDirectoryOAuth,
        [EnumMember(Value = "Basic")]
        Basic
    }
}
