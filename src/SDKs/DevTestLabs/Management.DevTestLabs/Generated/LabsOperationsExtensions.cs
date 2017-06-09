// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for LabsOperations.
    /// </summary>
    public static partial class LabsOperationsExtensions
    {
            /// <summary>
            /// List labs in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<Lab> ListBySubscription(this ILabsOperations operations, ODataQuery<Lab> odataQuery = default(ODataQuery<Lab>))
            {
                return ((ILabsOperations)operations).ListBySubscriptionAsync(odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List labs in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Lab>> ListBySubscriptionAsync(this ILabsOperations operations, ODataQuery<Lab> odataQuery = default(ODataQuery<Lab>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List labs in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<Lab> ListByResourceGroup(this ILabsOperations operations, string resourceGroupName, ODataQuery<Lab> odataQuery = default(ODataQuery<Lab>))
            {
                return ((ILabsOperations)operations).ListByResourceGroupAsync(resourceGroupName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List labs in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Lab>> ListByResourceGroupAsync(this ILabsOperations operations, string resourceGroupName, ODataQuery<Lab> odataQuery = default(ODataQuery<Lab>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get lab.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the lab.
            /// </param>
            /// <param name='expand'>
            /// Specify the $expand query. Example:
            /// 'properties($select=defaultStorageAccount)'
            /// </param>
            public static Lab Get(this ILabsOperations operations, string resourceGroupName, string name, string expand = default(string))
            {
                return operations.GetAsync(resourceGroupName, name, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get lab.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the lab.
            /// </param>
            /// <param name='expand'>
            /// Specify the $expand query. Example:
            /// 'properties($select=defaultStorageAccount)'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Lab> GetAsync(this ILabsOperations operations, string resourceGroupName, string name, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, name, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or replace an existing lab. This operation can take a while to
            /// complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the lab.
            /// </param>
            /// <param name='lab'>
            /// A lab.
            /// </param>
            public static Lab CreateOrUpdate(this ILabsOperations operations, string resourceGroupName, string name, Lab lab)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, name, lab).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or replace an existing lab. This operation can take a while to
            /// complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the lab.
            /// </param>
            /// <param name='lab'>
            /// A lab.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Lab> CreateOrUpdateAsync(this ILabsOperations operations, string resourceGroupName, string name, Lab lab, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, name, lab, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete lab. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the lab.
            /// </param>
            public static void Delete(this ILabsOperations operations, string resourceGroupName, string name)
            {
                operations.DeleteAsync(resourceGroupName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete lab. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the lab.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ILabsOperations operations, string resourceGroupName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Modify properties of labs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the lab.
            /// </param>
            /// <param name='lab'>
            /// A lab.
            /// </param>
            public static Lab Update(this ILabsOperations operations, string resourceGroupName, string name, LabFragment lab)
            {
                return operations.UpdateAsync(resourceGroupName, name, lab).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Modify properties of labs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the lab.
            /// </param>
            /// <param name='lab'>
            /// A lab.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Lab> UpdateAsync(this ILabsOperations operations, string resourceGroupName, string name, LabFragment lab, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, name, lab, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Claim a random claimable virtual machine in the lab. This operation can
            /// take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the lab.
            /// </param>
            public static void ClaimAnyVm(this ILabsOperations operations, string resourceGroupName, string name)
            {
                operations.ClaimAnyVmAsync(resourceGroupName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Claim a random claimable virtual machine in the lab. This operation can
            /// take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the lab.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ClaimAnyVmAsync(this ILabsOperations operations, string resourceGroupName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ClaimAnyVmWithHttpMessagesAsync(resourceGroupName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Create virtual machines in a lab. This operation can take a while to
            /// complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the lab.
            /// </param>
            /// <param name='labVirtualMachineCreationParameter'>
            /// Properties for creating a virtual machine.
            /// </param>
            public static void CreateEnvironment(this ILabsOperations operations, string resourceGroupName, string name, LabVirtualMachineCreationParameter labVirtualMachineCreationParameter)
            {
                operations.CreateEnvironmentAsync(resourceGroupName, name, labVirtualMachineCreationParameter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create virtual machines in a lab. This operation can take a while to
            /// complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the lab.
            /// </param>
            /// <param name='labVirtualMachineCreationParameter'>
            /// Properties for creating a virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CreateEnvironmentAsync(this ILabsOperations operations, string resourceGroupName, string name, LabVirtualMachineCreationParameter labVirtualMachineCreationParameter, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CreateEnvironmentWithHttpMessagesAsync(resourceGroupName, name, labVirtualMachineCreationParameter, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Exports the lab resource usage into a storage account This operation can
            /// take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the lab.
            /// </param>
            /// <param name='exportResourceUsageParameters'>
            /// The parameters of the export operation.
            /// </param>
            public static void ExportResourceUsage(this ILabsOperations operations, string resourceGroupName, string name, ExportResourceUsageParameters exportResourceUsageParameters)
            {
                operations.ExportResourceUsageAsync(resourceGroupName, name, exportResourceUsageParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Exports the lab resource usage into a storage account This operation can
            /// take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the lab.
            /// </param>
            /// <param name='exportResourceUsageParameters'>
            /// The parameters of the export operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ExportResourceUsageAsync(this ILabsOperations operations, string resourceGroupName, string name, ExportResourceUsageParameters exportResourceUsageParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ExportResourceUsageWithHttpMessagesAsync(resourceGroupName, name, exportResourceUsageParameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Generate a URI for uploading custom disk images to a Lab.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the lab.
            /// </param>
            /// <param name='generateUploadUriParameter'>
            /// Properties for generating an upload URI.
            /// </param>
            public static GenerateUploadUriResponse GenerateUploadUri(this ILabsOperations operations, string resourceGroupName, string name, GenerateUploadUriParameter generateUploadUriParameter)
            {
                return operations.GenerateUploadUriAsync(resourceGroupName, name, generateUploadUriParameter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Generate a URI for uploading custom disk images to a Lab.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the lab.
            /// </param>
            /// <param name='generateUploadUriParameter'>
            /// Properties for generating an upload URI.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GenerateUploadUriResponse> GenerateUploadUriAsync(this ILabsOperations operations, string resourceGroupName, string name, GenerateUploadUriParameter generateUploadUriParameter, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GenerateUploadUriWithHttpMessagesAsync(resourceGroupName, name, generateUploadUriParameter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List disk images available for custom image creation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the lab.
            /// </param>
            public static IPage<LabVhd> ListVhds(this ILabsOperations operations, string resourceGroupName, string name)
            {
                return operations.ListVhdsAsync(resourceGroupName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List disk images available for custom image creation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the lab.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<LabVhd>> ListVhdsAsync(this ILabsOperations operations, string resourceGroupName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListVhdsWithHttpMessagesAsync(resourceGroupName, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or replace an existing lab. This operation can take a while to
            /// complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the lab.
            /// </param>
            /// <param name='lab'>
            /// A lab.
            /// </param>
            public static Lab BeginCreateOrUpdate(this ILabsOperations operations, string resourceGroupName, string name, Lab lab)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, name, lab).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or replace an existing lab. This operation can take a while to
            /// complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the lab.
            /// </param>
            /// <param name='lab'>
            /// A lab.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Lab> BeginCreateOrUpdateAsync(this ILabsOperations operations, string resourceGroupName, string name, Lab lab, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, name, lab, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete lab. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the lab.
            /// </param>
            public static void BeginDelete(this ILabsOperations operations, string resourceGroupName, string name)
            {
                operations.BeginDeleteAsync(resourceGroupName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete lab. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the lab.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this ILabsOperations operations, string resourceGroupName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Claim a random claimable virtual machine in the lab. This operation can
            /// take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the lab.
            /// </param>
            public static void BeginClaimAnyVm(this ILabsOperations operations, string resourceGroupName, string name)
            {
                operations.BeginClaimAnyVmAsync(resourceGroupName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Claim a random claimable virtual machine in the lab. This operation can
            /// take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the lab.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginClaimAnyVmAsync(this ILabsOperations operations, string resourceGroupName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginClaimAnyVmWithHttpMessagesAsync(resourceGroupName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Create virtual machines in a lab. This operation can take a while to
            /// complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the lab.
            /// </param>
            /// <param name='labVirtualMachineCreationParameter'>
            /// Properties for creating a virtual machine.
            /// </param>
            public static void BeginCreateEnvironment(this ILabsOperations operations, string resourceGroupName, string name, LabVirtualMachineCreationParameter labVirtualMachineCreationParameter)
            {
                operations.BeginCreateEnvironmentAsync(resourceGroupName, name, labVirtualMachineCreationParameter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create virtual machines in a lab. This operation can take a while to
            /// complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the lab.
            /// </param>
            /// <param name='labVirtualMachineCreationParameter'>
            /// Properties for creating a virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginCreateEnvironmentAsync(this ILabsOperations operations, string resourceGroupName, string name, LabVirtualMachineCreationParameter labVirtualMachineCreationParameter, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginCreateEnvironmentWithHttpMessagesAsync(resourceGroupName, name, labVirtualMachineCreationParameter, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Exports the lab resource usage into a storage account This operation can
            /// take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the lab.
            /// </param>
            /// <param name='exportResourceUsageParameters'>
            /// The parameters of the export operation.
            /// </param>
            public static void BeginExportResourceUsage(this ILabsOperations operations, string resourceGroupName, string name, ExportResourceUsageParameters exportResourceUsageParameters)
            {
                operations.BeginExportResourceUsageAsync(resourceGroupName, name, exportResourceUsageParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Exports the lab resource usage into a storage account This operation can
            /// take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the lab.
            /// </param>
            /// <param name='exportResourceUsageParameters'>
            /// The parameters of the export operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginExportResourceUsageAsync(this ILabsOperations operations, string resourceGroupName, string name, ExportResourceUsageParameters exportResourceUsageParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginExportResourceUsageWithHttpMessagesAsync(resourceGroupName, name, exportResourceUsageParameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List labs in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Lab> ListBySubscriptionNext(this ILabsOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List labs in a subscription.
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
            public static async Task<IPage<Lab>> ListBySubscriptionNextAsync(this ILabsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List labs in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Lab> ListByResourceGroupNext(this ILabsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List labs in a resource group.
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
            public static async Task<IPage<Lab>> ListByResourceGroupNextAsync(this ILabsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List disk images available for custom image creation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<LabVhd> ListVhdsNext(this ILabsOperations operations, string nextPageLink)
            {
                return operations.ListVhdsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List disk images available for custom image creation.
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
            public static async Task<IPage<LabVhd>> ListVhdsNextAsync(this ILabsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListVhdsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
