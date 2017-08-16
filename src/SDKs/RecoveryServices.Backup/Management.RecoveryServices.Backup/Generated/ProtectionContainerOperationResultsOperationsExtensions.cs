// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
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
    /// Extension methods for ProtectionContainerOperationResultsOperations.
    /// </summary>
    public static partial class ProtectionContainerOperationResultsOperationsExtensions
    {
            /// <summary>
            /// Fetches the result of any operation on the container.
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
            /// Fabric name associated with the container.
            /// </param>
            /// <param name='containerName'>
            /// Container name whose information should be fetched.
            /// </param>
            /// <param name='operationId'>
            /// Operation ID which represents the operation whose result needs to be
            /// fetched.
            /// </param>
            public static ProtectionContainerResource Get(this IProtectionContainerOperationResultsOperations operations, string vaultName, string resourceGroupName, string fabricName, string containerName, string operationId)
            {
                return operations.GetAsync(vaultName, resourceGroupName, fabricName, containerName, operationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Fetches the result of any operation on the container.
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
            /// Fabric name associated with the container.
            /// </param>
            /// <param name='containerName'>
            /// Container name whose information should be fetched.
            /// </param>
            /// <param name='operationId'>
            /// Operation ID which represents the operation whose result needs to be
            /// fetched.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProtectionContainerResource> GetAsync(this IProtectionContainerOperationResultsOperations operations, string vaultName, string resourceGroupName, string fabricName, string containerName, string operationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(vaultName, resourceGroupName, fabricName, containerName, operationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
