// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.IotHub.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.IotHub;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The routing related properties of the IoT hub. See:
    /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging
    /// </summary>
    public partial class RoutingProperties
    {
        /// <summary>
        /// Initializes a new instance of the RoutingProperties class.
        /// </summary>
        public RoutingProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoutingProperties class.
        /// </summary>
        /// <param name="routes">The list of user-provided routing rules that
        /// the IoT hub uses to route messages to built-in and custom
        /// endpoints. A maximum of 100 routing rules are allowed for paid hubs
        /// and a maximum of 5 routing rules are allowed for free hubs.</param>
        /// <param name="fallbackRoute">The properties of the route that is
        /// used as a fall-back route when none of the conditions specified in
        /// the 'routes' section are met. This is an optional parameter. When
        /// this property is not set, the messages which do not meet any of the
        /// conditions specified in the 'routes' section get routed to the
        /// built-in eventhub endpoint.</param>
        public RoutingProperties(RoutingEndpoints endpoints = default(RoutingEndpoints), IList<RouteProperties> routes = default(IList<RouteProperties>), FallbackRouteProperties fallbackRoute = default(FallbackRouteProperties))
        {
            Endpoints = endpoints;
            Routes = routes;
            FallbackRoute = fallbackRoute;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "endpoints")]
        public RoutingEndpoints Endpoints { get; set; }

        /// <summary>
        /// Gets or sets the list of user-provided routing rules that the IoT
        /// hub uses to route messages to built-in and custom endpoints. A
        /// maximum of 100 routing rules are allowed for paid hubs and a
        /// maximum of 5 routing rules are allowed for free hubs.
        /// </summary>
        [JsonProperty(PropertyName = "routes")]
        public IList<RouteProperties> Routes { get; set; }

        /// <summary>
        /// Gets or sets the properties of the route that is used as a
        /// fall-back route when none of the conditions specified in the
        /// 'routes' section are met. This is an optional parameter. When this
        /// property is not set, the messages which do not meet any of the
        /// conditions specified in the 'routes' section get routed to the
        /// built-in eventhub endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "fallbackRoute")]
        public FallbackRouteProperties FallbackRoute { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Routes != null)
            {
                foreach (var element in Routes)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (FallbackRoute != null)
            {
                FallbackRoute.Validate();
            }
        }
    }
}
