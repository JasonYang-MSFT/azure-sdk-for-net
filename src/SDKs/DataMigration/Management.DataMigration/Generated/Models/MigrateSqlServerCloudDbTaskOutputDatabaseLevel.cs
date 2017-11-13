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

    [Newtonsoft.Json.JsonObject("DatabaseLevelOutput")]
    public partial class MigrateSqlServerCloudDbTaskOutputDatabaseLevel : MigrateSqlServerCloudDbTaskOutput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MigrateSqlServerCloudDbTaskOutputDatabaseLevel class.
        /// </summary>
        public MigrateSqlServerCloudDbTaskOutputDatabaseLevel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MigrateSqlServerCloudDbTaskOutputDatabaseLevel class.
        /// </summary>
        /// <param name="id">Result identifier</param>
        /// <param name="databaseName">Name of the database</param>
        /// <param name="state">Current state of migration. Possible values
        /// include: 'None', 'InProgress', 'Failed', 'Warning', 'Completed',
        /// 'Skipped', 'Stopped'</param>
        /// <param name="stage">Current stage of migration. Possible values
        /// include: 'None', 'Initialize', 'Backup', 'FileCopy', 'Restore',
        /// 'Completed'</param>
        /// <param name="startedOn">Migration start time</param>
        /// <param name="endedOn">Migration end time</param>
        /// <param name="message">Migration progress message</param>
        /// <param name="exceptionsAndWarnings">Migration exceptions and
        /// warnings</param>
        public MigrateSqlServerCloudDbTaskOutputDatabaseLevel(string id = default(string), string databaseName = default(string), MigrationState? state = default(MigrationState?), DatabaseMigrationStage? stage = default(DatabaseMigrationStage?), System.DateTimeOffset? startedOn = default(System.DateTimeOffset?), System.DateTimeOffset? endedOn = default(System.DateTimeOffset?), string message = default(string), IList<ReportableException> exceptionsAndWarnings = default(IList<ReportableException>))
            : base(id)
        {
            DatabaseName = databaseName;
            State = state;
            Stage = stage;
            StartedOn = startedOn;
            EndedOn = endedOn;
            Message = message;
            ExceptionsAndWarnings = exceptionsAndWarnings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the database
        /// </summary>
        [JsonProperty(PropertyName = "databaseName")]
        public string DatabaseName { get; private set; }

        /// <summary>
        /// Gets current state of migration. Possible values include: 'None',
        /// 'InProgress', 'Failed', 'Warning', 'Completed', 'Skipped',
        /// 'Stopped'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public MigrationState? State { get; private set; }

        /// <summary>
        /// Gets current stage of migration. Possible values include: 'None',
        /// 'Initialize', 'Backup', 'FileCopy', 'Restore', 'Completed'
        /// </summary>
        [JsonProperty(PropertyName = "stage")]
        public DatabaseMigrationStage? Stage { get; private set; }

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
        /// Gets migration progress message
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        /// <summary>
        /// Gets migration exceptions and warnings
        /// </summary>
        [JsonProperty(PropertyName = "exceptionsAndWarnings")]
        public IList<ReportableException> ExceptionsAndWarnings { get; private set; }

    }
}
