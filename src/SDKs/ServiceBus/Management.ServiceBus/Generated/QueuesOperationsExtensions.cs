// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceBus
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for QueuesOperations.
    /// </summary>
    public static partial class QueuesOperationsExtensions
    {
            /// <summary>
            /// Gets the queues within a namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639415.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            public static IPage<SBQueue> ListByNamespace(this IQueuesOperations operations, string resourceGroupName, string namespaceName)
            {
                return operations.ListByNamespaceAsync(resourceGroupName, namespaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the queues within a namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639415.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SBQueue>> ListByNamespaceAsync(this IQueuesOperations operations, string resourceGroupName, string namespaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByNamespaceWithHttpMessagesAsync(resourceGroupName, namespaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a Service Bus queue. This operation is idempotent.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639395.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create or update a queue resource.
            /// </param>
            public static SBQueue CreateOrUpdate(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, SBQueue parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, namespaceName, queueName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a Service Bus queue. This operation is idempotent.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639395.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create or update a queue resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SBQueue> CreateOrUpdateAsync(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, SBQueue parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, namespaceName, queueName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a queue from the specified namespace in a resource group.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639411.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            public static void Delete(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName)
            {
                operations.DeleteAsync(resourceGroupName, namespaceName, queueName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a queue from the specified namespace in a resource group.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639411.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, namespaceName, queueName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns a description for the specified queue.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639380.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            public static SBQueue Get(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName)
            {
                return operations.GetAsync(resourceGroupName, namespaceName, queueName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a description for the specified queue.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639380.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SBQueue> GetAsync(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, namespaceName, queueName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all authorization rules for a queue.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705607.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            public static IPage<SBAuthorizationRule> ListAuthorizationRules(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName)
            {
                return operations.ListAuthorizationRulesAsync(resourceGroupName, namespaceName, queueName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all authorization rules for a queue.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705607.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SBAuthorizationRule>> ListAuthorizationRulesAsync(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesWithHttpMessagesAsync(resourceGroupName, namespaceName, queueName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates an authorization rule for a queue.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            /// <param name='parameters'>
            /// The shared access authorization rule.
            /// </param>
            public static SBAuthorizationRule CreateOrUpdateAuthorizationRule(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName, SBAuthorizationRule parameters)
            {
                return operations.CreateOrUpdateAuthorizationRuleAsync(resourceGroupName, namespaceName, queueName, authorizationRuleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates an authorization rule for a queue.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            /// <param name='parameters'>
            /// The shared access authorization rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SBAuthorizationRule> CreateOrUpdateAuthorizationRuleAsync(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName, SBAuthorizationRule parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, queueName, authorizationRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a queue authorization rule.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705609.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            public static void DeleteAuthorizationRule(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName)
            {
                operations.DeleteAuthorizationRuleAsync(resourceGroupName, namespaceName, queueName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a queue authorization rule.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705609.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAuthorizationRuleAsync(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, queueName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets an authorization rule for a queue by rule name.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705611.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            public static SBAuthorizationRule GetAuthorizationRule(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName)
            {
                return operations.GetAuthorizationRuleAsync(resourceGroupName, namespaceName, queueName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an authorization rule for a queue by rule name.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705611.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SBAuthorizationRule> GetAuthorizationRuleAsync(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, queueName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Primary and secondary connection strings to the queue.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705608.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            public static AccessKeys ListKeys(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName)
            {
                return operations.ListKeysAsync(resourceGroupName, namespaceName, queueName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Primary and secondary connection strings to the queue.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705608.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccessKeys> ListKeysAsync(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, queueName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerates the primary or secondary connection strings to the queue.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705606.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to regenerate the authorization rule.
            /// </param>
            public static AccessKeys RegenerateKeys(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName, RegenerateAccessKeyParameters parameters)
            {
                return operations.RegenerateKeysAsync(resourceGroupName, namespaceName, queueName, authorizationRuleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates the primary or secondary connection strings to the queue.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705606.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to regenerate the authorization rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccessKeys> RegenerateKeysAsync(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName, RegenerateAccessKeyParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, queueName, authorizationRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the queues within a namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639415.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SBQueue> ListByNamespaceNext(this IQueuesOperations operations, string nextPageLink)
            {
                return operations.ListByNamespaceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the queues within a namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639415.aspx" />
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
            public static async Task<IPage<SBQueue>> ListByNamespaceNextAsync(this IQueuesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByNamespaceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all authorization rules for a queue.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705607.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SBAuthorizationRule> ListAuthorizationRulesNext(this IQueuesOperations operations, string nextPageLink)
            {
                return operations.ListAuthorizationRulesNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all authorization rules for a queue.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705607.aspx" />
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
            public static async Task<IPage<SBAuthorizationRule>> ListAuthorizationRulesNextAsync(this IQueuesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
