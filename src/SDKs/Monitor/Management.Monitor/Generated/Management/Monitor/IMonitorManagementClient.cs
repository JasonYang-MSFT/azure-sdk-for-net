// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Monitor.Management
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Monitor;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Monitor Management Client
    /// </summary>
    public partial interface IMonitorManagementClient : System.IDisposable
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
        /// The Azure subscription Id.
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
        /// Gets the IAutoscaleSettingsOperations.
        /// </summary>
        IAutoscaleSettingsOperations AutoscaleSettings { get; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the IAlertRuleIncidentsOperations.
        /// </summary>
        IAlertRuleIncidentsOperations AlertRuleIncidents { get; }

        /// <summary>
        /// Gets the IAlertRulesOperations.
        /// </summary>
        IAlertRulesOperations AlertRules { get; }

        /// <summary>
        /// Gets the ILogProfilesOperations.
        /// </summary>
        ILogProfilesOperations LogProfiles { get; }

        /// <summary>
        /// Gets the IDiagnosticSettingsOperations.
        /// </summary>
        IDiagnosticSettingsOperations DiagnosticSettings { get; }

        /// <summary>
        /// Gets the IDiagnosticSettingsCategoryOperations.
        /// </summary>
        IDiagnosticSettingsCategoryOperations DiagnosticSettingsCategory { get; }

        /// <summary>
        /// Gets the IActionGroupsOperations.
        /// </summary>
        IActionGroupsOperations ActionGroups { get; }

        /// <summary>
        /// Gets the IActivityLogAlertsOperations.
        /// </summary>
        IActivityLogAlertsOperations ActivityLogAlerts { get; }

    }
}
