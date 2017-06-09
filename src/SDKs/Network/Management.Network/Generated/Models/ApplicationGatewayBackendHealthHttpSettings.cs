// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Application gateway BackendHealthHttp settings.
    /// </summary>
    public partial class ApplicationGatewayBackendHealthHttpSettings
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayBackendHealthHttpSettings class.
        /// </summary>
        public ApplicationGatewayBackendHealthHttpSettings()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayBackendHealthHttpSettings class.
        /// </summary>
        /// <param name="backendHttpSettings">Reference of an
        /// ApplicationGatewayBackendHttpSettings resource.</param>
        /// <param name="servers">List of ApplicationGatewayBackendHealthServer
        /// resources.</param>
        public ApplicationGatewayBackendHealthHttpSettings(ApplicationGatewayBackendHttpSettings backendHttpSettings = default(ApplicationGatewayBackendHttpSettings), IList<ApplicationGatewayBackendHealthServer> servers = default(IList<ApplicationGatewayBackendHealthServer>))
        {
            BackendHttpSettings = backendHttpSettings;
            Servers = servers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets reference of an ApplicationGatewayBackendHttpSettings
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "backendHttpSettings")]
        public ApplicationGatewayBackendHttpSettings BackendHttpSettings { get; set; }

        /// <summary>
        /// Gets or sets list of ApplicationGatewayBackendHealthServer
        /// resources.
        /// </summary>
        [JsonProperty(PropertyName = "servers")]
        public IList<ApplicationGatewayBackendHealthServer> Servers { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (BackendHttpSettings != null)
            {
                BackendHttpSettings.Validate();
            }
        }
    }
}
