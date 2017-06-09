// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn
{
    using Azure;
    using Management;
    using Rest;
    using Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// CustomDomainsOperations operations.
    /// </summary>
    public partial interface ICustomDomainsOperations
    {
        /// <summary>
        /// Lists all of the existing custom domains within an endpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// Name of the CDN profile which is unique within the resource group.
        /// </param>
        /// <param name='endpointName'>
        /// Name of the endpoint under the profile which is unique globally.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<CustomDomain>>> ListByEndpointWithHttpMessagesAsync(string resourceGroupName, string profileName, string endpointName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets an exisitng custom domain within an endpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// Name of the CDN profile which is unique within the resource group.
        /// </param>
        /// <param name='endpointName'>
        /// Name of the endpoint under the profile which is unique globally.
        /// </param>
        /// <param name='customDomainName'>
        /// Name of the custom domain within an endpoint.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CustomDomain>> GetWithHttpMessagesAsync(string resourceGroupName, string profileName, string endpointName, string customDomainName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a new custom domain within an endpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// Name of the CDN profile which is unique within the resource group.
        /// </param>
        /// <param name='endpointName'>
        /// Name of the endpoint under the profile which is unique globally.
        /// </param>
        /// <param name='customDomainName'>
        /// Name of the custom domain within an endpoint.
        /// </param>
        /// <param name='hostName'>
        /// The host name of the custom domain. Must be a domain name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CustomDomain>> CreateWithHttpMessagesAsync(string resourceGroupName, string profileName, string endpointName, string customDomainName, string hostName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes an existing custom domain within an endpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// Name of the CDN profile which is unique within the resource group.
        /// </param>
        /// <param name='endpointName'>
        /// Name of the endpoint under the profile which is unique globally.
        /// </param>
        /// <param name='customDomainName'>
        /// Name of the custom domain within an endpoint.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CustomDomain>> DeleteWithHttpMessagesAsync(string resourceGroupName, string profileName, string endpointName, string customDomainName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Disable https delivery of the custom domain.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// Name of the CDN profile which is unique within the resource group.
        /// </param>
        /// <param name='endpointName'>
        /// Name of the endpoint under the profile which is unique globally.
        /// </param>
        /// <param name='customDomainName'>
        /// Name of the custom domain within an endpoint.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CustomDomain>> DisableCustomHttpsWithHttpMessagesAsync(string resourceGroupName, string profileName, string endpointName, string customDomainName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Enable https delivery of the custom domain.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// Name of the CDN profile which is unique within the resource group.
        /// </param>
        /// <param name='endpointName'>
        /// Name of the endpoint under the profile which is unique globally.
        /// </param>
        /// <param name='customDomainName'>
        /// Name of the custom domain within an endpoint.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CustomDomain>> EnableCustomHttpsWithHttpMessagesAsync(string resourceGroupName, string profileName, string endpointName, string customDomainName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a new custom domain within an endpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// Name of the CDN profile which is unique within the resource group.
        /// </param>
        /// <param name='endpointName'>
        /// Name of the endpoint under the profile which is unique globally.
        /// </param>
        /// <param name='customDomainName'>
        /// Name of the custom domain within an endpoint.
        /// </param>
        /// <param name='hostName'>
        /// The host name of the custom domain. Must be a domain name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CustomDomain>> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string profileName, string endpointName, string customDomainName, string hostName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes an existing custom domain within an endpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// Name of the CDN profile which is unique within the resource group.
        /// </param>
        /// <param name='endpointName'>
        /// Name of the endpoint under the profile which is unique globally.
        /// </param>
        /// <param name='customDomainName'>
        /// Name of the custom domain within an endpoint.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CustomDomain>> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string profileName, string endpointName, string customDomainName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all of the existing custom domains within an endpoint.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<CustomDomain>>> ListByEndpointNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}

