// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataMigrationService
{
    using Microsoft.Azure;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ServicesOperations operations.
    /// </summary>
    public partial interface IServicesOperations
    {
        /// <summary>
        /// Create or update DMS Instance
        /// </summary>
        /// <remarks>
        /// The services resource is the top-level resource that represents the
        /// Data Migration Service. The PUT method creates a new service or
        /// updates an existing one. When a service is updated, existing child
        /// resources (i.e. tasks) are unaffected. Services currently support a
        /// single kind, "vm", which refers to a VM-based service, although
        /// other kinds may be added in the future. This method can change the
        /// kind, SKU, and network of the service, but if tasks are currently
        /// running (i.e. the service is busy), this will fail with 400 Bad
        /// Request ("ServiceIsBusy"). The provider will reply when successful
        /// with 200 OK or 201 Created. Long-running operations use the
        /// provisioningState property.
        ///
        /// </remarks>
        /// <param name='parameters'>
        /// Information about the service
        /// </param>
        /// <param name='groupName'>
        /// Name of the resource group
        /// </param>
        /// <param name='resourceName'>
        /// Name of the resource
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DataMigrationServiceModel>> CreateOrUpdateWithHttpMessagesAsync(DataMigrationServiceModel parameters, string groupName, string resourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get DMS Service Instance
        /// </summary>
        /// <remarks>
        /// The services resource is the top-level resource that represents the
        /// Data Migration Service. The GET method retrieves information about
        /// a service instance.
        ///
        /// </remarks>
        /// <param name='groupName'>
        /// Name of the resource group
        /// </param>
        /// <param name='resourceName'>
        /// Name of the resource
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DataMigrationServiceModel>> GetWithHttpMessagesAsync(string groupName, string resourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete DMS Service Instance
        /// </summary>
        /// <remarks>
        /// The services resource is the top-level resource that represents the
        /// Data Migration Service. The DELETE method deletes a service. Any
        /// running tasks will be canceled.
        ///
        /// </remarks>
        /// <param name='groupName'>
        /// Name of the resource group
        /// </param>
        /// <param name='resourceName'>
        /// Name of the resource
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string groupName, string resourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update DMS Service Instance
        /// </summary>
        /// <remarks>
        /// The services resource is the top-level resource that represents the
        /// Data Migration Service. The PATCH method updates an existing
        /// service. This method can change the kind, SKU, and network of the
        /// service, but if tasks are currently running (i.e. the service is
        /// busy), this will fail with 400 Bad Request ("ServiceIsBusy").
        ///
        /// </remarks>
        /// <param name='parameters'>
        /// Information about the service
        /// </param>
        /// <param name='groupName'>
        /// Name of the resource group
        /// </param>
        /// <param name='resourceName'>
        /// Name of the resource
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DataMigrationServiceModel>> UpdateWithHttpMessagesAsync(DataMigrationServiceModel parameters, string groupName, string resourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Check service health status
        /// </summary>
        /// <remarks>
        /// The services resource is the top-level resource that represents the
        /// Data Migration Service. This action performs a health check and
        /// returns the status of the service and virtual machine size.
        /// </remarks>
        /// <param name='groupName'>
        /// Name of the resource group
        /// </param>
        /// <param name='resourceName'>
        /// Name of the resource
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DataMigrationServiceStatusResponse>> CheckStatusWithHttpMessagesAsync(string groupName, string resourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get compatible SKUs
        /// </summary>
        /// <remarks>
        /// The services resource is the top-level resource that represents the
        /// Data Migration Service. The skus action returns the list of SKUs
        /// that a service resource can be updated to.
        /// </remarks>
        /// <param name='groupName'>
        /// Name of the resource group
        /// </param>
        /// <param name='resourceName'>
        /// Name of the resource
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<AvailableServiceSku>>> ListSkusWithHttpMessagesAsync(string groupName, string resourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Check nested resource name validity and availability
        /// </summary>
        /// <remarks>
        /// This method checks whether a proposed nested resource name is valid
        /// and available.
        /// </remarks>
        /// <param name='groupName'>
        /// Name of the resource group
        /// </param>
        /// <param name='resourceName'>
        /// Name of the resource
        /// </param>
        /// <param name='parameters'>
        /// Requested name to validate
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<NameAvailabilityResponse>> CheckChildrenNameAvailabilityWithHttpMessagesAsync(string groupName, string resourceName, NameAvailabilityRequest parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Run a task synchronously
        /// </summary>
        /// <remarks>
        /// The services resource is the top-level resource that represents the
        /// Data Migration Service. This method runs a task, returns the
        /// response, and deletes the associated storage in a single operation.
        /// It is intended to be used for short-running, transient scenarios
        /// (such as "validate this input") that should not require the
        /// overhead and complexity of creating a new task resource, polling
        /// for results, and deleting it on the client side.
        /// </remarks>
        /// <param name='groupName'>
        /// Name of the resource group
        /// </param>
        /// <param name='resourceName'>
        /// Name of the resource
        /// </param>
        /// <param name='parameters'>
        /// Information about the task to create
        /// </param>
        /// <param name='timeoutMs'>
        /// The number of milliseconds the task is allowed to run, up to 20000
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ServiceTaskProperties>> RunTaskWithHttpMessagesAsync(string groupName, string resourceName, NewServiceTask parameters, int? timeoutMs = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get services in resource group
        /// </summary>
        /// <remarks>
        /// The Services resource is the top-level resource that represents the
        /// Data Migration Service. This method returns a list of service
        /// resources in a resource group.
        /// </remarks>
        /// <param name='groupName'>
        /// Name of the resource group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<DataMigrationServiceModel>>> ListByResourceGroupWithHttpMessagesAsync(string groupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get services in subscription
        /// </summary>
        /// <remarks>
        /// The services resource is the top-level resource that represents the
        /// Data Migration Service. This method returns a list of service
        /// resources in a subscription.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<DataMigrationServiceModel>>> ListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Check name validity and availability
        /// </summary>
        /// <remarks>
        /// This method checks whether a proposed top-level resource name is
        /// valid and available.
        /// </remarks>
        /// <param name='parameters'>
        /// Requested name to validate
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<NameAvailabilityResponse>> CheckNameAvailabilityWithHttpMessagesAsync(NameAvailabilityRequest parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update DMS Instance
        /// </summary>
        /// <remarks>
        /// The services resource is the top-level resource that represents the
        /// Data Migration Service. The PUT method creates a new service or
        /// updates an existing one. When a service is updated, existing child
        /// resources (i.e. tasks) are unaffected. Services currently support a
        /// single kind, "vm", which refers to a VM-based service, although
        /// other kinds may be added in the future. This method can change the
        /// kind, SKU, and network of the service, but if tasks are currently
        /// running (i.e. the service is busy), this will fail with 400 Bad
        /// Request ("ServiceIsBusy"). The provider will reply when successful
        /// with 200 OK or 201 Created. Long-running operations use the
        /// provisioningState property.
        ///
        /// </remarks>
        /// <param name='parameters'>
        /// Information about the service
        /// </param>
        /// <param name='groupName'>
        /// Name of the resource group
        /// </param>
        /// <param name='resourceName'>
        /// Name of the resource
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DataMigrationServiceModel>> BeginCreateOrUpdateWithHttpMessagesAsync(DataMigrationServiceModel parameters, string groupName, string resourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete DMS Service Instance
        /// </summary>
        /// <remarks>
        /// The services resource is the top-level resource that represents the
        /// Data Migration Service. The DELETE method deletes a service. Any
        /// running tasks will be canceled.
        ///
        /// </remarks>
        /// <param name='groupName'>
        /// Name of the resource group
        /// </param>
        /// <param name='resourceName'>
        /// Name of the resource
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string groupName, string resourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update DMS Service Instance
        /// </summary>
        /// <remarks>
        /// The services resource is the top-level resource that represents the
        /// Data Migration Service. The PATCH method updates an existing
        /// service. This method can change the kind, SKU, and network of the
        /// service, but if tasks are currently running (i.e. the service is
        /// busy), this will fail with 400 Bad Request ("ServiceIsBusy").
        ///
        /// </remarks>
        /// <param name='parameters'>
        /// Information about the service
        /// </param>
        /// <param name='groupName'>
        /// Name of the resource group
        /// </param>
        /// <param name='resourceName'>
        /// Name of the resource
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DataMigrationServiceModel>> BeginUpdateWithHttpMessagesAsync(DataMigrationServiceModel parameters, string groupName, string resourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get compatible SKUs
        /// </summary>
        /// <remarks>
        /// The services resource is the top-level resource that represents the
        /// Data Migration Service. The skus action returns the list of SKUs
        /// that a service resource can be updated to.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<AvailableServiceSku>>> ListSkusNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get services in resource group
        /// </summary>
        /// <remarks>
        /// The Services resource is the top-level resource that represents the
        /// Data Migration Service. This method returns a list of service
        /// resources in a resource group.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<DataMigrationServiceModel>>> ListByResourceGroupNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get services in subscription
        /// </summary>
        /// <remarks>
        /// The services resource is the top-level resource that represents the
        /// Data Migration Service. This method returns a list of service
        /// resources in a subscription.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<DataMigrationServiceModel>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
