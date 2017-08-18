// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataMigrationService.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.DataMigrationService;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Oracle migration project metadata
    /// </summary>
    public partial class OracleDataMigrationProjectMetadata : DataMigrationProjectMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// OracleDataMigrationProjectMetadata class.
        /// </summary>
        public OracleDataMigrationProjectMetadata()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// OracleDataMigrationProjectMetadata class.
        /// </summary>
        /// <param name="sourceServerName">Source server name</param>
        /// <param name="sourceServerPort">Source server port number</param>
        /// <param name="sourceUsername">Source username</param>
        /// <param name="targetServerName">Target server name</param>
        /// <param name="targetUsername">Target username</param>
        /// <param name="targetDbName">Target database name</param>
        /// <param name="targetUsingWinAuth">Whether target connection is
        /// Windows authentication</param>
        /// <param name="selectedMigrationTables">List of tables selected for
        /// migration</param>
        /// <param name="sourceSID">Source SID value</param>
        public OracleDataMigrationProjectMetadata(string sourceServerName = default(string), string sourceServerPort = default(string), string sourceUsername = default(string), string targetServerName = default(string), string targetUsername = default(string), string targetDbName = default(string), bool? targetUsingWinAuth = default(bool?), IList<MigrationTableMetadata> selectedMigrationTables = default(IList<MigrationTableMetadata>), string sourceSID = default(string))
            : base(sourceServerName, sourceServerPort, sourceUsername, targetServerName, targetUsername, targetDbName, targetUsingWinAuth, selectedMigrationTables)
        {
            SourceSID = sourceSID;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets source SID value
        /// </summary>
        [JsonProperty(PropertyName = "sourceSID")]
        public string SourceSID { get; set; }

    }
}
