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
    /// The instance view of a virtual machine boot diagnostics.
    /// </summary>
    public partial class BootDiagnosticsInstanceView
    {
        /// <summary>
        /// Initializes a new instance of the BootDiagnosticsInstanceView
        /// class.
        /// </summary>
        public BootDiagnosticsInstanceView() { }

        /// <summary>
        /// Initializes a new instance of the BootDiagnosticsInstanceView
        /// class.
        /// </summary>
        /// <param name="consoleScreenshotBlobUri">The console screenshot blob
        /// URI.</param>
        /// <param name="serialConsoleLogBlobUri">The Linux serial console log
        /// blob Uri.</param>
        public BootDiagnosticsInstanceView(string consoleScreenshotBlobUri = default(string), string serialConsoleLogBlobUri = default(string))
        {
            ConsoleScreenshotBlobUri = consoleScreenshotBlobUri;
            SerialConsoleLogBlobUri = serialConsoleLogBlobUri;
        }

        /// <summary>
        /// Gets or sets the console screenshot blob URI.
        /// </summary>
        [JsonProperty(PropertyName = "consoleScreenshotBlobUri")]
        public string ConsoleScreenshotBlobUri { get; set; }

        /// <summary>
        /// Gets or sets the Linux serial console log blob Uri.
        /// </summary>
        [JsonProperty(PropertyName = "serialConsoleLogBlobUri")]
        public string SerialConsoleLogBlobUri { get; set; }

    }
}

