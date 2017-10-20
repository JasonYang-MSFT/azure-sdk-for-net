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

    /// <summary>
    /// Output for the task that validates connection to SQL Server and target
    /// server requirements
    /// </summary>
    public partial class ConnectToTargetSqlServerTaskOutput : TaskOutput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ConnectToTargetSqlServerTaskOutput class.
        /// </summary>
        public ConnectToTargetSqlServerTaskOutput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ConnectToTargetSqlServerTaskOutput class.
        /// </summary>
        /// <param name="id">Result identifier</param>
        /// <param name="targetServerVersion">Target server version</param>
        /// <param name="targetServerBrandVersion">Target server brand
        /// version</param>
        /// <param name="serverDefaultDataPath">Default path of the data
        /// files</param>
        /// <param name="serverDefaultLogPath">Default path of the log
        /// files</param>
        /// <param name="validationErrors">Validation errors</param>
        public ConnectToTargetSqlServerTaskOutput(string id = default(string), string targetServerVersion = default(string), string targetServerBrandVersion = default(string), string serverDefaultDataPath = default(string), string serverDefaultLogPath = default(string), IList<ReportableException> validationErrors = default(IList<ReportableException>))
            : base(id)
        {
            TargetServerVersion = targetServerVersion;
            TargetServerBrandVersion = targetServerBrandVersion;
            ServerDefaultDataPath = serverDefaultDataPath;
            ServerDefaultLogPath = serverDefaultLogPath;
            ValidationErrors = validationErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

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
        /// Gets default path of the data files
        /// </summary>
        [JsonProperty(PropertyName = "serverDefaultDataPath")]
        public string ServerDefaultDataPath { get; private set; }

        /// <summary>
        /// Gets default path of the log files
        /// </summary>
        [JsonProperty(PropertyName = "serverDefaultLogPath")]
        public string ServerDefaultLogPath { get; private set; }

        /// <summary>
        /// Gets validation errors
        /// </summary>
        [JsonProperty(PropertyName = "validationErrors")]
        public IList<ReportableException> ValidationErrors { get; private set; }

    }
}
