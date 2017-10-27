// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    [Newtonsoft.Json.JsonObject("MigrationLevelOutput")]
    public partial class MigrateSqlServerCloudDbTaskOutputMigrationLevel : MigrateSqlServerCloudDbTaskOutput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MigrateSqlServerCloudDbTaskOutputMigrationLevel class.
        /// </summary>
        public MigrateSqlServerCloudDbTaskOutputMigrationLevel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MigrateSqlServerCloudDbTaskOutputMigrationLevel class.
        /// </summary>
        /// <param name="id">Result identifier</param>
        /// <param name="startedOn">Migration start time</param>
        /// <param name="endedOn">Migration end time</param>
        /// <param name="status">Current status of migration. Possible values
        /// include: 'Default', 'Connecting', 'SourceAndTargetSelected',
        /// 'SelectLogins', 'Configured', 'Running', 'Error', 'Cancelled',
        /// 'Completed', 'CompletedWithWarnings'</param>
        /// <param name="state">Current state of migration. Possible values
        /// include: 'None', 'InProgress', 'Failed', 'Warning', 'Completed',
        /// 'Skipped'</param>
        /// <param name="statusMessage">Migration status message</param>
        /// <param name="message">Migration progress message</param>
        /// <param name="databases">Selected databases as a map from database
        /// name to database id</param>
        /// <param name="databaseSummary">Summary of database results in the
        /// migration</param>
        /// <param name="sourceServerVersion">Source server version</param>
        /// <param name="sourceServerBrandVersion">Source server brand
        /// version</param>
        /// <param name="targetServerVersion">Target server version</param>
        /// <param name="targetServerBrandVersion">Target server brand
        /// version</param>
        /// <param name="exceptionsAndWarnings">Migration exceptions and
        /// warnings.</param>
        public MigrateSqlServerCloudDbTaskOutputMigrationLevel(string id = default(string), System.DateTimeOffset? startedOn = default(System.DateTimeOffset?), System.DateTimeOffset? endedOn = default(System.DateTimeOffset?), MigrationStatus? status = default(MigrationStatus?), MigrationState? state = default(MigrationState?), string statusMessage = default(string), string message = default(string), IDictionary<string, string> databases = default(IDictionary<string, string>), IDictionary<string, DataItemMigrationSummaryResult> databaseSummary = default(IDictionary<string, DataItemMigrationSummaryResult>), string sourceServerVersion = default(string), string sourceServerBrandVersion = default(string), string targetServerVersion = default(string), string targetServerBrandVersion = default(string), IList<ReportableException> exceptionsAndWarnings = default(IList<ReportableException>))
            : base(id)
        {
            StartedOn = startedOn;
            EndedOn = endedOn;
            Status = status;
            State = state;
            StatusMessage = statusMessage;
            Message = message;
            Databases = databases;
            DatabaseSummary = databaseSummary;
            SourceServerVersion = sourceServerVersion;
            SourceServerBrandVersion = sourceServerBrandVersion;
            TargetServerVersion = targetServerVersion;
            TargetServerBrandVersion = targetServerBrandVersion;
            ExceptionsAndWarnings = exceptionsAndWarnings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets migration start time
        /// </summary>
        [JsonProperty(PropertyName = "startedOn")]
        public System.DateTimeOffset? StartedOn { get; private set; }

        /// <summary>
        /// Gets migration end time
        /// </summary>
        [JsonProperty(PropertyName = "endedOn")]
        public System.DateTimeOffset? EndedOn { get; private set; }

        /// <summary>
        /// Gets current status of migration. Possible values include:
        /// 'Default', 'Connecting', 'SourceAndTargetSelected', 'SelectLogins',
        /// 'Configured', 'Running', 'Error', 'Cancelled', 'Completed',
        /// 'CompletedWithWarnings'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public MigrationStatus? Status { get; private set; }

        /// <summary>
        /// Gets current state of migration. Possible values include: 'None',
        /// 'InProgress', 'Failed', 'Warning', 'Completed', 'Skipped'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public MigrationState? State { get; private set; }

        /// <summary>
        /// Gets migration status message
        /// </summary>
        [JsonProperty(PropertyName = "statusMessage")]
        public string StatusMessage { get; private set; }

        /// <summary>
        /// Gets migration progress message
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        /// <summary>
        /// Gets selected databases as a map from database name to database id
        /// </summary>
        [JsonProperty(PropertyName = "databases")]
        public IDictionary<string, string> Databases { get; private set; }

        /// <summary>
        /// Gets summary of database results in the migration
        /// </summary>
        [JsonProperty(PropertyName = "databaseSummary")]
        public IDictionary<string, DataItemMigrationSummaryResult> DatabaseSummary { get; private set; }

        /// <summary>
        /// Gets source server version
        /// </summary>
        [JsonProperty(PropertyName = "sourceServerVersion")]
        public string SourceServerVersion { get; private set; }

        /// <summary>
        /// Gets source server brand version
        /// </summary>
        [JsonProperty(PropertyName = "sourceServerBrandVersion")]
        public string SourceServerBrandVersion { get; private set; }

        /// <summary>
        /// Gets target server version
        /// </summary>
        [JsonProperty(PropertyName = "targetServerVersion")]
        public string TargetServerVersion { get; private set; }

        /// <summary>
        /// Gets target server brand version
        /// </summary>
        [JsonProperty(PropertyName = "targetServerBrandVersion")]
        public string TargetServerBrandVersion { get; private set; }

        /// <summary>
        /// Gets migration exceptions and warnings.
        /// </summary>
        [JsonProperty(PropertyName = "exceptionsAndWarnings")]
        public IList<ReportableException> ExceptionsAndWarnings { get; private set; }

    }
}
