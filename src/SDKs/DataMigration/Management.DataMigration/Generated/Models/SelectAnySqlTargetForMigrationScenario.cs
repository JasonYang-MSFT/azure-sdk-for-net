// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataMigration;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Scenario that validates connection to any SQL Server
    /// </summary>
    [Newtonsoft.Json.JsonObject("DataMigration.SelectAnySqlMigrationTarget")]
    public partial class SelectAnySqlTargetForMigrationScenario : Scenario
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SelectAnySqlTargetForMigrationScenario class.
        /// </summary>
        public SelectAnySqlTargetForMigrationScenario()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SelectAnySqlTargetForMigrationScenario class.
        /// </summary>
        /// <param name="input">Scenario configuration</param>
        public SelectAnySqlTargetForMigrationScenario(SelectAnySqlTargetForMigrationScenarioInput input)
        {
            Input = input;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets scenario configuration
        /// </summary>
        [JsonProperty(PropertyName = "input")]
        public SelectAnySqlTargetForMigrationScenarioInput Input { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Input == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Input");
            }
            if (Input != null)
            {
                Input.Validate();
            }
        }
    }
}
