// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for OperationOperations.
    /// </summary>
    public static partial class OperationOperationsExtensions
    {
            /// <summary>
            /// Lists a collection of operations associated with tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='apiId'>
            /// API identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<TagResourceContract> ListByTags(this IOperationOperations operations, string resourceGroupName, string serviceName, string apiId, ODataQuery<TagResourceContract> odataQuery = default(ODataQuery<TagResourceContract>))
            {
                return operations.ListByTagsAsync(resourceGroupName, serviceName, apiId, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists a collection of operations associated with tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='apiId'>
            /// API identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<TagResourceContract>> ListByTagsAsync(this IOperationOperations operations, string resourceGroupName, string serviceName, string apiId, ODataQuery<TagResourceContract> odataQuery = default(ODataQuery<TagResourceContract>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByTagsWithHttpMessagesAsync(resourceGroupName, serviceName, apiId, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists a collection of operations associated with tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<TagResourceContract> ListByTagsNext(this IOperationOperations operations, string nextPageLink)
            {
                return operations.ListByTagsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists a collection of operations associated with tags.
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
            public static async Task<IPage<TagResourceContract>> ListByTagsNextAsync(this IOperationOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByTagsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
