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
    /// Types of validations to run after the migration
    /// </summary>
    public partial class MigrationValidationOptions
    {
        /// <summary>
        /// Initializes a new instance of the MigrationValidationOptions class.
        /// </summary>
        public MigrationValidationOptions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MigrationValidationOptions class.
        /// </summary>
        /// <param name="enableSchemaValidation">Allows to compare the schema
        /// information between source and target.</param>
        /// <param name="enableDataIntegrityCheck">Allows to performs a
        /// checksum based data integrity check between source and target for
        /// the selected database / tables .</param>
        /// <param name="enableQueryAnalysisValidation">Allows to perform a
        /// quick and intelligent query analysis in the source database and
        /// compares the performance for those queries in the target
        /// database.</param>
        public MigrationValidationOptions(bool? enableSchemaValidation = default(bool?), bool? enableDataIntegrityCheck = default(bool?), bool? enableQueryAnalysisValidation = default(bool?))
        {
            EnableSchemaValidation = enableSchemaValidation;
            EnableDataIntegrityCheck = enableDataIntegrityCheck;
            EnableQueryAnalysisValidation = enableQueryAnalysisValidation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets allows to compare the schema information between
        /// source and target.
        /// </summary>
        [JsonProperty(PropertyName = "enableSchemaValidation")]
        public bool? EnableSchemaValidation { get; set; }

        /// <summary>
        /// Gets or sets allows to performs a checksum based data integrity
        /// check between source and target for the selected database / tables
        /// .
        /// </summary>
        [JsonProperty(PropertyName = "enableDataIntegrityCheck")]
        public bool? EnableDataIntegrityCheck { get; set; }

        /// <summary>
        /// Gets or sets allows to perform a quick and intelligent query
        /// analysis in the source database and compares the performance for
        /// those queries in the target database.
        /// </summary>
        [JsonProperty(PropertyName = "enableQueryAnalysisValidation")]
        public bool? EnableQueryAnalysisValidation { get; set; }

    }
}
