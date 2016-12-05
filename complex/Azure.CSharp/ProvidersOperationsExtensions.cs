// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Azure
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for ProvidersOperations.
    /// </summary>
    public static partial class ProvidersOperationsExtensions
    {
            /// <summary>
            /// Unregisters a subscription from a resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider to unregister.
            /// </param>
            public static Provider Unregister(this IProvidersOperations operations, string resourceProviderNamespace)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IProvidersOperations)s).UnregisterAsync(resourceProviderNamespace), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Unregisters a subscription from a resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider to unregister.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Provider> UnregisterAsync(this IProvidersOperations operations, string resourceProviderNamespace, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.UnregisterWithHttpMessagesAsync(resourceProviderNamespace, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Registers a subscription with a resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider to register.
            /// </param>
            public static Provider Register(this IProvidersOperations operations, string resourceProviderNamespace)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IProvidersOperations)s).RegisterAsync(resourceProviderNamespace), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Registers a subscription with a resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider to register.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Provider> RegisterAsync(this IProvidersOperations operations, string resourceProviderNamespace, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.RegisterWithHttpMessagesAsync(resourceProviderNamespace, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all resource providers for a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// The number of results to return. If null is passed returns all deployments.
            /// </param>
            /// <param name='expand'>
            /// The properties to include in the results. For example, use
            /// &amp;$expand=metadata in the query string to retrieve resource provider
            /// metadata. To include property aliases in response, use
            /// $expand=resourceTypes/aliases.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<Provider> List(this IProvidersOperations operations, int? top = default(int?), string expand = default(string))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IProvidersOperations)s).ListAsync(top, expand), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all resource providers for a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// The number of results to return. If null is passed returns all deployments.
            /// </param>
            /// <param name='expand'>
            /// The properties to include in the results. For example, use
            /// &amp;$expand=metadata in the query string to retrieve resource provider
            /// metadata. To include property aliases in response, use
            /// $expand=resourceTypes/aliases.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<Provider>> ListAsync(this IProvidersOperations operations, int? top = default(int?), string expand = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(top, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the specified resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider.
            /// </param>
            /// <param name='expand'>
            /// The $expand query parameter. For example, to include property aliases in
            /// response, use $expand=resourceTypes/aliases.
            /// </param>
            public static Provider Get(this IProvidersOperations operations, string resourceProviderNamespace, string expand = default(string))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IProvidersOperations)s).GetAsync(resourceProviderNamespace, expand), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider.
            /// </param>
            /// <param name='expand'>
            /// The $expand query parameter. For example, to include property aliases in
            /// response, use $expand=resourceTypes/aliases.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Provider> GetAsync(this IProvidersOperations operations, string resourceProviderNamespace, string expand = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceProviderNamespace, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all resource providers for a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<Provider> ListNext(this IProvidersOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IProvidersOperations)s).ListNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all resource providers for a subscription.
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
            public static async Task<Microsoft.Rest.Azure.IPage<Provider>> ListNextAsync(this IProvidersOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
