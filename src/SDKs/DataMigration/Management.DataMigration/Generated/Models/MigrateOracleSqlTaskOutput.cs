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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Output for task that migrates Oracle databases to Azure and SQL Server
    /// databases
    /// </summary>
    public partial class MigrateOracleSqlTaskOutput : NonSqlMigrationTaskOutput
    {
        /// <summary>
        /// Initializes a new instance of the MigrateOracleSqlTaskOutput class.
        /// </summary>
        public MigrateOracleSqlTaskOutput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MigrateOracleSqlTaskOutput class.
        /// </summary>
        /// <param name="id">Result identifier</param>
        /// <param name="startedOn">Migration start time</param>
        /// <param name="endedOn">Migration end time</param>
        /// <param name="status">Current state of migration. Possible values
        /// include: 'Default', 'Connecting', 'SourceAndTargetSelected',
        /// 'SelectLogins', 'Configured', 'Running', 'Error', 'Stopped',
        /// 'Completed', 'CompletedWithWarnings'</param>
        /// <param name="dataMigrationTableResults">Results of the migration.
        /// The key contains the table name and the value the table result
        /// object</param>
        /// <param name="progressMessage">Message about the progress of the
        /// migration</param>
        /// <param name="sourceServerName">Name of source server</param>
        /// <param name="targetServerName">Name of target server</param>
        public MigrateOracleSqlTaskOutput(string id = default(string), System.DateTimeOffset? startedOn = default(System.DateTimeOffset?), System.DateTimeOffset? endedOn = default(System.DateTimeOffset?), MigrationStatus? status = default(MigrationStatus?), IDictionary<string, NonSqlDataMigrationTableResult> dataMigrationTableResults = default(IDictionary<string, NonSqlDataMigrationTableResult>), string progressMessage = default(string), string sourceServerName = default(string), string targetServerName = default(string))
            : base(id, startedOn, endedOn, status, dataMigrationTableResults, progressMessage, sourceServerName, targetServerName)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
