// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Azure;
    using Management;
    using Compute;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a hardware profile.
    /// </summary>
    public partial class HardwareProfile
    {
        /// <summary>
        /// Initializes a new instance of the HardwareProfile class.
        /// </summary>
        public HardwareProfile() { }

        /// <summary>
        /// Initializes a new instance of the HardwareProfile class.
        /// </summary>
        /// <param name="vmSize">The virtual machine size name. Possible values
        /// include: 'Basic_A0', 'Basic_A1', 'Basic_A2', 'Basic_A3',
        /// 'Basic_A4', 'Standard_A0', 'Standard_A1', 'Standard_A2',
        /// 'Standard_A3', 'Standard_A4', 'Standard_A5', 'Standard_A6',
        /// 'Standard_A7', 'Standard_A8', 'Standard_A9', 'Standard_A10',
        /// 'Standard_A11', 'Standard_D1', 'Standard_D2', 'Standard_D3',
        /// 'Standard_D4', 'Standard_D11', 'Standard_D12', 'Standard_D13',
        /// 'Standard_D14', 'Standard_D1_v2', 'Standard_D2_v2',
        /// 'Standard_D3_v2', 'Standard_D4_v2', 'Standard_D5_v2',
        /// 'Standard_D11_v2', 'Standard_D12_v2', 'Standard_D13_v2',
        /// 'Standard_D14_v2', 'Standard_D15_v2', 'Standard_DS1',
        /// 'Standard_DS2', 'Standard_DS3', 'Standard_DS4', 'Standard_DS11',
        /// 'Standard_DS12', 'Standard_DS13', 'Standard_DS14',
        /// 'Standard_DS1_v2', 'Standard_DS2_v2', 'Standard_DS3_v2',
        /// 'Standard_DS4_v2', 'Standard_DS5_v2', 'Standard_DS11_v2',
        /// 'Standard_DS12_v2', 'Standard_DS13_v2', 'Standard_DS14_v2',
        /// 'Standard_DS15_v2', 'Standard_G1', 'Standard_G2', 'Standard_G3',
        /// 'Standard_G4', 'Standard_G5', 'Standard_GS1', 'Standard_GS2',
        /// 'Standard_GS3', 'Standard_GS4', 'Standard_GS5'</param>
        public HardwareProfile(string vmSize = default(string))
        {
            VmSize = vmSize;
        }

        /// <summary>
        /// Gets or sets the virtual machine size name. Possible values
        /// include: 'Basic_A0', 'Basic_A1', 'Basic_A2', 'Basic_A3',
        /// 'Basic_A4', 'Standard_A0', 'Standard_A1', 'Standard_A2',
        /// 'Standard_A3', 'Standard_A4', 'Standard_A5', 'Standard_A6',
        /// 'Standard_A7', 'Standard_A8', 'Standard_A9', 'Standard_A10',
        /// 'Standard_A11', 'Standard_D1', 'Standard_D2', 'Standard_D3',
        /// 'Standard_D4', 'Standard_D11', 'Standard_D12', 'Standard_D13',
        /// 'Standard_D14', 'Standard_D1_v2', 'Standard_D2_v2',
        /// 'Standard_D3_v2', 'Standard_D4_v2', 'Standard_D5_v2',
        /// 'Standard_D11_v2', 'Standard_D12_v2', 'Standard_D13_v2',
        /// 'Standard_D14_v2', 'Standard_D15_v2', 'Standard_DS1',
        /// 'Standard_DS2', 'Standard_DS3', 'Standard_DS4', 'Standard_DS11',
        /// 'Standard_DS12', 'Standard_DS13', 'Standard_DS14',
        /// 'Standard_DS1_v2', 'Standard_DS2_v2', 'Standard_DS3_v2',
        /// 'Standard_DS4_v2', 'Standard_DS5_v2', 'Standard_DS11_v2',
        /// 'Standard_DS12_v2', 'Standard_DS13_v2', 'Standard_DS14_v2',
        /// 'Standard_DS15_v2', 'Standard_G1', 'Standard_G2', 'Standard_G3',
        /// 'Standard_G4', 'Standard_G5', 'Standard_GS1', 'Standard_GS2',
        /// 'Standard_GS3', 'Standard_GS4', 'Standard_GS5'
        /// </summary>
        [JsonProperty(PropertyName = "vmSize")]
        public string VmSize { get; set; }

    }
}

