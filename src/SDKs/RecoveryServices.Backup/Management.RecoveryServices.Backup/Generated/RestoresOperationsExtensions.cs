// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RestoresOperations.
    /// </summary>
    public static partial class RestoresOperationsExtensions
    {
            /// <summary>
            /// Restores the specified backed up data. This is an asynchronous operation.
            /// To know the status of this API call, use GetProtectedItemOperationResult
            /// API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name associated with the backed up items.
            /// </param>
            /// <param name='containerName'>
            /// Container name associated with the backed up items.
            /// </param>
            /// <param name='protectedItemName'>
            /// Backed up item to be restored.
            /// </param>
            /// <param name='recoveryPointId'>
            /// Recovery point ID which represents the backed up data to be restored.
            /// </param>
            /// <param name='parameters'>
            /// resource restore request
            /// </param>
            public static void Trigger(this IRestoresOperations operations, string vaultName, string resourceGroupName, string fabricName, string containerName, string protectedItemName, string recoveryPointId, RestoreRequestResource parameters)
            {
                operations.TriggerAsync(vaultName, resourceGroupName, fabricName, containerName, protectedItemName, recoveryPointId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Restores the specified backed up data. This is an asynchronous operation.
            /// To know the status of this API call, use GetProtectedItemOperationResult
            /// API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name associated with the backed up items.
            /// </param>
            /// <param name='containerName'>
            /// Container name associated with the backed up items.
            /// </param>
            /// <param name='protectedItemName'>
            /// Backed up item to be restored.
            /// </param>
            /// <param name='recoveryPointId'>
            /// Recovery point ID which represents the backed up data to be restored.
            /// </param>
            /// <param name='parameters'>
            /// resource restore request
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task TriggerAsync(this IRestoresOperations operations, string vaultName, string resourceGroupName, string fabricName, string containerName, string protectedItemName, string recoveryPointId, RestoreRequestResource parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.TriggerWithHttpMessagesAsync(vaultName, resourceGroupName, fabricName, containerName, protectedItemName, recoveryPointId, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
