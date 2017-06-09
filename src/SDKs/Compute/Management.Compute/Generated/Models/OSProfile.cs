// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Azure;
    using Management;
    using Compute;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes an OS profile.
    /// </summary>
    public partial class OSProfile
    {
        /// <summary>
        /// Initializes a new instance of the OSProfile class.
        /// </summary>
        public OSProfile() { }

        /// <summary>
        /// Initializes a new instance of the OSProfile class.
        /// </summary>
        /// <param name="computerName">Specifies the host OS name of the
        /// virtual machine.</param>
        /// <param name="adminUsername">Specifies the name of the administrator
        /// account.</param>
        /// <param name="adminPassword">Specifies the password of the
        /// administrator account.</param>
        /// <param name="customData">Specifies a base-64 encoded string of
        /// custom data. The base-64 encoded string is decoded to a binary
        /// array that is saved as a file on the Virtual Machine. The maximum
        /// length of the binary array is 65535 bytes</param>
        /// <param name="windowsConfiguration">The Windows configuration of the
        /// OS profile.</param>
        /// <param name="linuxConfiguration">The Linux configuration of the OS
        /// profile.</param>
        /// <param name="secrets">The list of certificates for addition to the
        /// VM.</param>
        public OSProfile(string computerName = default(string), string adminUsername = default(string), string adminPassword = default(string), string customData = default(string), WindowsConfiguration windowsConfiguration = default(WindowsConfiguration), LinuxConfiguration linuxConfiguration = default(LinuxConfiguration), IList<VaultSecretGroup> secrets = default(IList<VaultSecretGroup>))
        {
            ComputerName = computerName;
            AdminUsername = adminUsername;
            AdminPassword = adminPassword;
            CustomData = customData;
            WindowsConfiguration = windowsConfiguration;
            LinuxConfiguration = linuxConfiguration;
            Secrets = secrets;
        }

        /// <summary>
        /// Gets or sets specifies the host OS name of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "computerName")]
        public string ComputerName { get; set; }

        /// <summary>
        /// Gets or sets specifies the name of the administrator account.
        /// </summary>
        [JsonProperty(PropertyName = "adminUsername")]
        public string AdminUsername { get; set; }

        /// <summary>
        /// Gets or sets specifies the password of the administrator account.
        /// </summary>
        [JsonProperty(PropertyName = "adminPassword")]
        public string AdminPassword { get; set; }

        /// <summary>
        /// Gets or sets specifies a base-64 encoded string of custom data. The
        /// base-64 encoded string is decoded to a binary array that is saved
        /// as a file on the Virtual Machine. The maximum length of the binary
        /// array is 65535 bytes
        /// </summary>
        [JsonProperty(PropertyName = "customData")]
        public string CustomData { get; set; }

        /// <summary>
        /// Gets or sets the Windows configuration of the OS profile.
        /// </summary>
        [JsonProperty(PropertyName = "windowsConfiguration")]
        public WindowsConfiguration WindowsConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the Linux configuration of the OS profile.
        /// </summary>
        [JsonProperty(PropertyName = "linuxConfiguration")]
        public LinuxConfiguration LinuxConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the list of certificates for addition to the VM.
        /// </summary>
        [JsonProperty(PropertyName = "secrets")]
        public IList<VaultSecretGroup> Secrets { get; set; }

    }
}

