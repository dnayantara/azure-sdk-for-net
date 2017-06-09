// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VirtualNetworkGatewayConnectionsOperations.
    /// </summary>
    public static partial class VirtualNetworkGatewayConnectionsOperationsExtensions
    {
            /// <summary>
            /// Creates or updates a virtual network gateway connection in the specified
            /// resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayConnectionName'>
            /// The name of the virtual network gateway connection.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update virtual network gateway
            /// connection operation.
            /// </param>
            public static VirtualNetworkGatewayConnection CreateOrUpdate(this IVirtualNetworkGatewayConnectionsOperations operations, string resourceGroupName, string virtualNetworkGatewayConnectionName, VirtualNetworkGatewayConnection parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, virtualNetworkGatewayConnectionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a virtual network gateway connection in the specified
            /// resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayConnectionName'>
            /// The name of the virtual network gateway connection.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update virtual network gateway
            /// connection operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetworkGatewayConnection> CreateOrUpdateAsync(this IVirtualNetworkGatewayConnectionsOperations operations, string resourceGroupName, string virtualNetworkGatewayConnectionName, VirtualNetworkGatewayConnection parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayConnectionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the specified virtual network gateway connection by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayConnectionName'>
            /// The name of the virtual network gateway connection.
            /// </param>
            public static VirtualNetworkGatewayConnection Get(this IVirtualNetworkGatewayConnectionsOperations operations, string resourceGroupName, string virtualNetworkGatewayConnectionName)
            {
                return operations.GetAsync(resourceGroupName, virtualNetworkGatewayConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified virtual network gateway connection by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayConnectionName'>
            /// The name of the virtual network gateway connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetworkGatewayConnection> GetAsync(this IVirtualNetworkGatewayConnectionsOperations operations, string resourceGroupName, string virtualNetworkGatewayConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayConnectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified virtual network Gateway connection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayConnectionName'>
            /// The name of the virtual network gateway connection.
            /// </param>
            public static void Delete(this IVirtualNetworkGatewayConnectionsOperations operations, string resourceGroupName, string virtualNetworkGatewayConnectionName)
            {
                operations.DeleteAsync(resourceGroupName, virtualNetworkGatewayConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified virtual network Gateway connection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayConnectionName'>
            /// The name of the virtual network gateway connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IVirtualNetworkGatewayConnectionsOperations operations, string resourceGroupName, string virtualNetworkGatewayConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayConnectionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// The Put VirtualNetworkGatewayConnectionSharedKey operation sets the virtual
            /// network gateway connection shared key for passed virtual network gateway
            /// connection in the specified resource group through Network resource
            /// provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayConnectionName'>
            /// The virtual network gateway connection name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Begin Set Virtual Network Gateway connection
            /// Shared key operation throughNetwork resource provider.
            /// </param>
            public static ConnectionSharedKey SetSharedKey(this IVirtualNetworkGatewayConnectionsOperations operations, string resourceGroupName, string virtualNetworkGatewayConnectionName, ConnectionSharedKey parameters)
            {
                return operations.SetSharedKeyAsync(resourceGroupName, virtualNetworkGatewayConnectionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put VirtualNetworkGatewayConnectionSharedKey operation sets the virtual
            /// network gateway connection shared key for passed virtual network gateway
            /// connection in the specified resource group through Network resource
            /// provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayConnectionName'>
            /// The virtual network gateway connection name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Begin Set Virtual Network Gateway connection
            /// Shared key operation throughNetwork resource provider.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConnectionSharedKey> SetSharedKeyAsync(this IVirtualNetworkGatewayConnectionsOperations operations, string resourceGroupName, string virtualNetworkGatewayConnectionName, ConnectionSharedKey parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SetSharedKeyWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayConnectionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Get VirtualNetworkGatewayConnectionSharedKey operation retrieves
            /// information about the specified virtual network gateway connection shared
            /// key through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayConnectionName'>
            /// The virtual network gateway connection shared key name.
            /// </param>
            public static ConnectionSharedKey GetSharedKey(this IVirtualNetworkGatewayConnectionsOperations operations, string resourceGroupName, string virtualNetworkGatewayConnectionName)
            {
                return operations.GetSharedKeyAsync(resourceGroupName, virtualNetworkGatewayConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Get VirtualNetworkGatewayConnectionSharedKey operation retrieves
            /// information about the specified virtual network gateway connection shared
            /// key through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayConnectionName'>
            /// The virtual network gateway connection shared key name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConnectionSharedKey> GetSharedKeyAsync(this IVirtualNetworkGatewayConnectionsOperations operations, string resourceGroupName, string virtualNetworkGatewayConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSharedKeyWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayConnectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List VirtualNetworkGatewayConnections operation retrieves all the
            /// virtual network gateways connections created.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<VirtualNetworkGatewayConnection> List(this IVirtualNetworkGatewayConnectionsOperations operations, string resourceGroupName)
            {
                return operations.ListAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List VirtualNetworkGatewayConnections operation retrieves all the
            /// virtual network gateways connections created.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualNetworkGatewayConnection>> ListAsync(this IVirtualNetworkGatewayConnectionsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The VirtualNetworkGatewayConnectionResetSharedKey operation resets the
            /// virtual network gateway connection shared key for passed virtual network
            /// gateway connection in the specified resource group through Network resource
            /// provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayConnectionName'>
            /// The virtual network gateway connection reset shared key Name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the begin reset virtual network gateway connection
            /// shared key operation through network resource provider.
            /// </param>
            public static ConnectionResetSharedKey ResetSharedKey(this IVirtualNetworkGatewayConnectionsOperations operations, string resourceGroupName, string virtualNetworkGatewayConnectionName, ConnectionResetSharedKey parameters)
            {
                return operations.ResetSharedKeyAsync(resourceGroupName, virtualNetworkGatewayConnectionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The VirtualNetworkGatewayConnectionResetSharedKey operation resets the
            /// virtual network gateway connection shared key for passed virtual network
            /// gateway connection in the specified resource group through Network resource
            /// provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayConnectionName'>
            /// The virtual network gateway connection reset shared key Name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the begin reset virtual network gateway connection
            /// shared key operation through network resource provider.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConnectionResetSharedKey> ResetSharedKeyAsync(this IVirtualNetworkGatewayConnectionsOperations operations, string resourceGroupName, string virtualNetworkGatewayConnectionName, ConnectionResetSharedKey parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ResetSharedKeyWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayConnectionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a virtual network gateway connection in the specified
            /// resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayConnectionName'>
            /// The name of the virtual network gateway connection.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update virtual network gateway
            /// connection operation.
            /// </param>
            public static VirtualNetworkGatewayConnection BeginCreateOrUpdate(this IVirtualNetworkGatewayConnectionsOperations operations, string resourceGroupName, string virtualNetworkGatewayConnectionName, VirtualNetworkGatewayConnection parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, virtualNetworkGatewayConnectionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a virtual network gateway connection in the specified
            /// resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayConnectionName'>
            /// The name of the virtual network gateway connection.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update virtual network gateway
            /// connection operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetworkGatewayConnection> BeginCreateOrUpdateAsync(this IVirtualNetworkGatewayConnectionsOperations operations, string resourceGroupName, string virtualNetworkGatewayConnectionName, VirtualNetworkGatewayConnection parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayConnectionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified virtual network Gateway connection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayConnectionName'>
            /// The name of the virtual network gateway connection.
            /// </param>
            public static void BeginDelete(this IVirtualNetworkGatewayConnectionsOperations operations, string resourceGroupName, string virtualNetworkGatewayConnectionName)
            {
                operations.BeginDeleteAsync(resourceGroupName, virtualNetworkGatewayConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified virtual network Gateway connection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayConnectionName'>
            /// The name of the virtual network gateway connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IVirtualNetworkGatewayConnectionsOperations operations, string resourceGroupName, string virtualNetworkGatewayConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayConnectionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// The Put VirtualNetworkGatewayConnectionSharedKey operation sets the virtual
            /// network gateway connection shared key for passed virtual network gateway
            /// connection in the specified resource group through Network resource
            /// provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayConnectionName'>
            /// The virtual network gateway connection name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Begin Set Virtual Network Gateway connection
            /// Shared key operation throughNetwork resource provider.
            /// </param>
            public static ConnectionSharedKey BeginSetSharedKey(this IVirtualNetworkGatewayConnectionsOperations operations, string resourceGroupName, string virtualNetworkGatewayConnectionName, ConnectionSharedKey parameters)
            {
                return operations.BeginSetSharedKeyAsync(resourceGroupName, virtualNetworkGatewayConnectionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put VirtualNetworkGatewayConnectionSharedKey operation sets the virtual
            /// network gateway connection shared key for passed virtual network gateway
            /// connection in the specified resource group through Network resource
            /// provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayConnectionName'>
            /// The virtual network gateway connection name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Begin Set Virtual Network Gateway connection
            /// Shared key operation throughNetwork resource provider.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConnectionSharedKey> BeginSetSharedKeyAsync(this IVirtualNetworkGatewayConnectionsOperations operations, string resourceGroupName, string virtualNetworkGatewayConnectionName, ConnectionSharedKey parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginSetSharedKeyWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayConnectionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The VirtualNetworkGatewayConnectionResetSharedKey operation resets the
            /// virtual network gateway connection shared key for passed virtual network
            /// gateway connection in the specified resource group through Network resource
            /// provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayConnectionName'>
            /// The virtual network gateway connection reset shared key Name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the begin reset virtual network gateway connection
            /// shared key operation through network resource provider.
            /// </param>
            public static ConnectionResetSharedKey BeginResetSharedKey(this IVirtualNetworkGatewayConnectionsOperations operations, string resourceGroupName, string virtualNetworkGatewayConnectionName, ConnectionResetSharedKey parameters)
            {
                return operations.BeginResetSharedKeyAsync(resourceGroupName, virtualNetworkGatewayConnectionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The VirtualNetworkGatewayConnectionResetSharedKey operation resets the
            /// virtual network gateway connection shared key for passed virtual network
            /// gateway connection in the specified resource group through Network resource
            /// provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayConnectionName'>
            /// The virtual network gateway connection reset shared key Name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the begin reset virtual network gateway connection
            /// shared key operation through network resource provider.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConnectionResetSharedKey> BeginResetSharedKeyAsync(this IVirtualNetworkGatewayConnectionsOperations operations, string resourceGroupName, string virtualNetworkGatewayConnectionName, ConnectionResetSharedKey parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginResetSharedKeyWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayConnectionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List VirtualNetworkGatewayConnections operation retrieves all the
            /// virtual network gateways connections created.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VirtualNetworkGatewayConnection> ListNext(this IVirtualNetworkGatewayConnectionsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List VirtualNetworkGatewayConnections operation retrieves all the
            /// virtual network gateways connections created.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualNetworkGatewayConnection>> ListNextAsync(this IVirtualNetworkGatewayConnectionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
