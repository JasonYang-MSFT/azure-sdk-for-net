// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataMigration
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for TasksOperations.
    /// </summary>
    public static partial class TasksOperationsExtensions
    {
            /// <summary>
            /// Get tasks in a service
            /// </summary>
            /// <remarks>
            /// The services resource is the top-level resource that represents the Data
            /// Migration Service. This method returns a list of tasks owned by a service
            /// resource. Some tasks may have a status of Unknown, which indicates that an
            /// error occurred while querying the status of that task.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='resourceName'>
            /// Name of the resource
            /// </param>
            /// <param name='scenarioId'>
            /// Filter tasks by scenario ID
            /// </param>
            public static IPage<ServiceTask> List(this ITasksOperations operations, string groupName, string resourceName, string scenarioId = default(string))
            {
                return operations.ListAsync(groupName, resourceName, scenarioId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get tasks in a service
            /// </summary>
            /// <remarks>
            /// The services resource is the top-level resource that represents the Data
            /// Migration Service. This method returns a list of tasks owned by a service
            /// resource. Some tasks may have a status of Unknown, which indicates that an
            /// error occurred while querying the status of that task.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='resourceName'>
            /// Name of the resource
            /// </param>
            /// <param name='scenarioId'>
            /// Filter tasks by scenario ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ServiceTask>> ListAsync(this ITasksOperations operations, string groupName, string resourceName, string scenarioId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(groupName, resourceName, scenarioId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update task
            /// </summary>
            /// <remarks>
            /// The tasks resource is a nested, proxy-only resource representing work
            /// performed by a DMS instance. The PUT method creates a new task or updates
            /// an existing one, although since tasks have no mutable custom properties,
            /// there is little reason to update an exising one.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Information about the task to create
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='resourceName'>
            /// Name of the resource
            /// </param>
            public static ServiceTask CreateOrUpdate(this ITasksOperations operations, NewServiceTask parameters, string groupName, string serviceName, string resourceName)
            {
                return operations.CreateOrUpdateAsync(parameters, groupName, serviceName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update task
            /// </summary>
            /// <remarks>
            /// The tasks resource is a nested, proxy-only resource representing work
            /// performed by a DMS instance. The PUT method creates a new task or updates
            /// an existing one, although since tasks have no mutable custom properties,
            /// there is little reason to update an exising one.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Information about the task to create
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='resourceName'>
            /// Name of the resource
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceTask> CreateOrUpdateAsync(this ITasksOperations operations, NewServiceTask parameters, string groupName, string serviceName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(parameters, groupName, serviceName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get task information
            /// </summary>
            /// <remarks>
            /// The tasks resource is a nested, proxy-only resource representing work
            /// performed by a DMS instance. The GET method retrieves information about a
            /// task.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='resourceName'>
            /// Name of the resource
            /// </param>
            /// <param name='expand'>
            /// Expand the response
            /// </param>
            public static ServiceTask Get(this ITasksOperations operations, string groupName, string serviceName, string resourceName, string expand = default(string))
            {
                return operations.GetAsync(groupName, serviceName, resourceName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get task information
            /// </summary>
            /// <remarks>
            /// The tasks resource is a nested, proxy-only resource representing work
            /// performed by a DMS instance. The GET method retrieves information about a
            /// task.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='resourceName'>
            /// Name of the resource
            /// </param>
            /// <param name='expand'>
            /// Expand the response
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceTask> GetAsync(this ITasksOperations operations, string groupName, string serviceName, string resourceName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(groupName, serviceName, resourceName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete task
            /// </summary>
            /// <remarks>
            /// The tasks resource is a nested, proxy-only resource representing work
            /// performed by a DMS instance. The DELETE method deletes a task, canceling it
            /// first if it's running.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='resourceName'>
            /// Name of the resource
            /// </param>
            public static void Delete(this ITasksOperations operations, string groupName, string serviceName, string resourceName)
            {
                operations.DeleteAsync(groupName, serviceName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete task
            /// </summary>
            /// <remarks>
            /// The tasks resource is a nested, proxy-only resource representing work
            /// performed by a DMS instance. The DELETE method deletes a task, canceling it
            /// first if it's running.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='resourceName'>
            /// Name of the resource
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ITasksOperations operations, string groupName, string serviceName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(groupName, serviceName, resourceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Create or update task
            /// </summary>
            /// <remarks>
            /// The tasks resource is a nested, proxy-only resource representing work
            /// performed by a DMS instance. The PATCH method updates an existing task, but
            /// since tasks have no mutable custom properties, there is little reason to do
            /// so.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Information about the task
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='resourceName'>
            /// Name of the resource
            /// </param>
            public static ServiceTask Update(this ITasksOperations operations, ServiceTask parameters, string groupName, string serviceName, string resourceName)
            {
                return operations.UpdateAsync(parameters, groupName, serviceName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update task
            /// </summary>
            /// <remarks>
            /// The tasks resource is a nested, proxy-only resource representing work
            /// performed by a DMS instance. The PATCH method updates an existing task, but
            /// since tasks have no mutable custom properties, there is little reason to do
            /// so.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Information about the task
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='resourceName'>
            /// Name of the resource
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceTask> UpdateAsync(this ITasksOperations operations, ServiceTask parameters, string groupName, string serviceName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(parameters, groupName, serviceName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancel a task
            /// </summary>
            /// <remarks>
            /// The tasks resource is a nested, proxy-only resource representing work
            /// performed by a DMS instance. This method cancels a task if it's currently
            /// queued or running.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='resourceName'>
            /// Name of the resource
            /// </param>
            public static ServiceTask Cancel(this ITasksOperations operations, string groupName, string serviceName, string resourceName)
            {
                return operations.CancelAsync(groupName, serviceName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancel a task
            /// </summary>
            /// <remarks>
            /// The tasks resource is a nested, proxy-only resource representing work
            /// performed by a DMS instance. This method cancels a task if it's currently
            /// queued or running.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='resourceName'>
            /// Name of the resource
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceTask> CancelAsync(this ITasksOperations operations, string groupName, string serviceName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CancelWithHttpMessagesAsync(groupName, serviceName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get tasks in a service
            /// </summary>
            /// <remarks>
            /// The services resource is the top-level resource that represents the Data
            /// Migration Service. This method returns a list of tasks owned by a service
            /// resource. Some tasks may have a status of Unknown, which indicates that an
            /// error occurred while querying the status of that task.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ServiceTask> ListNext(this ITasksOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get tasks in a service
            /// </summary>
            /// <remarks>
            /// The services resource is the top-level resource that represents the Data
            /// Migration Service. This method returns a list of tasks owned by a service
            /// resource. Some tasks may have a status of Unknown, which indicates that an
            /// error occurred while querying the status of that task.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ServiceTask>> ListNextAsync(this ITasksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
