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
    using System.Linq;

    /// <summary>
    /// Summary of database results in the migration
    /// </summary>
    public partial class DatabaseSummaryResult : DataItemMigrationSummaryResult
    {
        /// <summary>
        /// Initializes a new instance of the DatabaseSummaryResult class.
        /// </summary>
        public DatabaseSummaryResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatabaseSummaryResult class.
        /// </summary>
        /// <param name="name">Name of the item</param>
        /// <param name="startedOn">Migration start time</param>
        /// <param name="endedOn">Migration end time</param>
        /// <param name="state">Current state of migration. Possible values
        /// include: 'None', 'InProgress', 'Failed', 'Warning', 'Completed',
        /// 'Skipped'</param>
        /// <param name="statusMessage">Status message</param>
        /// <param name="itemsCount">Number of items</param>
        /// <param name="itemsCompletedCount">Number of successfully completed
        /// items</param>
        /// <param name="errorPrefix">Wildcard string prefix to use for
        /// querying all errors of the item</param>
        /// <param name="resultPrefix">Wildcard string prefix to use for
        /// querying all sub-tem results of the item</param>
        /// <param name="sizeMB">Size of the database in megabytes</param>
        public DatabaseSummaryResult(string name = default(string), System.DateTimeOffset? startedOn = default(System.DateTimeOffset?), System.DateTimeOffset? endedOn = default(System.DateTimeOffset?), MigrationState? state = default(MigrationState?), string statusMessage = default(string), long? itemsCount = default(long?), long? itemsCompletedCount = default(long?), string errorPrefix = default(string), string resultPrefix = default(string), double? sizeMB = default(double?))
            : base(name, startedOn, endedOn, state, statusMessage, itemsCount, itemsCompletedCount, errorPrefix, resultPrefix)
        {
            SizeMB = sizeMB;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets size of the database in megabytes
        /// </summary>
        [JsonProperty(PropertyName = "sizeMB")]
        public double? SizeMB { get; private set; }

    }
}
