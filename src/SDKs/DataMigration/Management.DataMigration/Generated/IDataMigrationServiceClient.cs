// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataMigrationService
{
    using Microsoft.Azure;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// The Data Migration Service helps people migrate their data from
    /// on-premise database servers to Azure, or from older database software
    /// to newer software. The service manages one or more workers that are
    /// joined to a customer's virtual network, which is assumed to provide
    /// connectivity to their databases. To avoid frequent updates to the
    /// resource provider, data migration tasks are implemented by the resource
    /// provider in a generic way as task resources, each of which has a
    /// scenario ID (which identifies the type of work to run), input, and
    /// output. The client is responsible for providing appropriate scenario
    /// IDs and inputs, which will be passed through unexamined to the machines
    /// that implement the functionality, and for understanding the output,
    /// which is passed back unexamined to the client.
    ///
    /// </summary>
    public partial interface IDataMigrationServiceClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Version of the API
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// Identifier of the subscription
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running
        /// Operations. Default value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is generated
        /// and included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IServicesOperations.
        /// </summary>
        IServicesOperations Services { get; }

        /// <summary>
        /// Gets the ITasksOperations.
        /// </summary>
        ITasksOperations Tasks { get; }

        /// <summary>
        /// Gets the IProjectsOperations.
        /// </summary>
        IProjectsOperations Projects { get; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

    }
}
