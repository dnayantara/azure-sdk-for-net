// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Azure;
    using Management;
    using WebSites;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for KeyVaultSecretStatus.
    /// </summary>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum KeyVaultSecretStatus
    {
        [EnumMember(Value = "Initialized")]
        Initialized,
        [EnumMember(Value = "WaitingOnCertificateOrder")]
        WaitingOnCertificateOrder,
        [EnumMember(Value = "Succeeded")]
        Succeeded,
        [EnumMember(Value = "CertificateOrderFailed")]
        CertificateOrderFailed,
        [EnumMember(Value = "OperationNotPermittedOnKeyVault")]
        OperationNotPermittedOnKeyVault,
        [EnumMember(Value = "AzureServiceUnauthorizedToAccessKeyVault")]
        AzureServiceUnauthorizedToAccessKeyVault,
        [EnumMember(Value = "KeyVaultDoesNotExist")]
        KeyVaultDoesNotExist,
        [EnumMember(Value = "KeyVaultSecretDoesNotExist")]
        KeyVaultSecretDoesNotExist,
        [EnumMember(Value = "UnknownError")]
        UnknownError,
        [EnumMember(Value = "ExternalPrivateKey")]
        ExternalPrivateKey,
        [EnumMember(Value = "Unknown")]
        Unknown
    }
}

