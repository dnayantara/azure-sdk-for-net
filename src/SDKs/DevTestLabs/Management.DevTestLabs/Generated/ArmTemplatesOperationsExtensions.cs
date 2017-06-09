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
    /// Extension methods for ArmTemplatesOperations.
    /// </summary>
    public static partial class ArmTemplatesOperationsExtensions
    {
            /// <summary>
            /// List azure resource manager templates in a given artifact source.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='artifactSourceName'>
            /// The name of the artifact source.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<ArmTemplate> List(this IArmTemplatesOperations operations, string resourceGroupName, string labName, string artifactSourceName, ODataQuery<ArmTemplate> odataQuery = default(ODataQuery<ArmTemplate>))
            {
                return ((IArmTemplatesOperations)operations).ListAsync(resourceGroupName, labName, artifactSourceName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List azure resource manager templates in a given artifact source.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='artifactSourceName'>
            /// The name of the artifact source.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ArmTemplate>> ListAsync(this IArmTemplatesOperations operations, string resourceGroupName, string labName, string artifactSourceName, ODataQuery<ArmTemplate> odataQuery = default(ODataQuery<ArmTemplate>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, labName, artifactSourceName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get azure resource manager template.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='artifactSourceName'>
            /// The name of the artifact source.
            /// </param>
            /// <param name='name'>
            /// The name of the azure Resource Manager template.
            /// </param>
            /// <param name='expand'>
            /// Specify the $expand query. Example: 'properties($select=displayName)'
            /// </param>
            public static ArmTemplate Get(this IArmTemplatesOperations operations, string resourceGroupName, string labName, string artifactSourceName, string name, string expand = default(string))
            {
                return operations.GetAsync(resourceGroupName, labName, artifactSourceName, name, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get azure resource manager template.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='artifactSourceName'>
            /// The name of the artifact source.
            /// </param>
            /// <param name='name'>
            /// The name of the azure Resource Manager template.
            /// </param>
            /// <param name='expand'>
            /// Specify the $expand query. Example: 'properties($select=displayName)'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ArmTemplate> GetAsync(this IArmTemplatesOperations operations, string resourceGroupName, string labName, string artifactSourceName, string name, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, labName, artifactSourceName, name, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List azure resource manager templates in a given artifact source.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ArmTemplate> ListNext(this IArmTemplatesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List azure resource manager templates in a given artifact source.
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
            public static async Task<IPage<ArmTemplate>> ListNextAsync(this IArmTemplatesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
