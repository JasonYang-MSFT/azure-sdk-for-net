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
    /// Properties for task that validates migration input for SQL to Cloud DB
    /// migrations
    /// </summary>
    [Newtonsoft.Json.JsonObject("ValidateMigrationInput.SqlServer.CloudDb")]
    public partial class ValidateMigrationInputSqlServerCloudDbTaskProperties : ProjectTaskProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ValidateMigrationInputSqlServerCloudDbTaskProperties class.
        /// </summary>
        public ValidateMigrationInputSqlServerCloudDbTaskProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ValidateMigrationInputSqlServerCloudDbTaskProperties class.
        /// </summary>
        /// <param name="errors">Array of errors. This is ignored if
        /// submitted.</param>
        /// <param name="state">The state of the task. This is ignored if
        /// submitted. Possible values include: 'Canceled', 'Failed',
        /// 'FailedValidation', 'Faulted', 'Queued', 'Running', 'Succeeded',
        /// 'Unknown'</param>
        /// <param name="input">Task input</param>
        /// <param name="output">Task output. This is ignored if
        /// submitted.</param>
        public ValidateMigrationInputSqlServerCloudDbTaskProperties(IList<ODataError> errors = default(IList<ODataError>), TaskState? state = default(TaskState?), ValidateMigrationInputSqlServerCloudDbTaskInput input = default(ValidateMigrationInputSqlServerCloudDbTaskInput), IList<ValidateMigrationInputSqlServerCloudDbTaskOutput> output = default(IList<ValidateMigrationInputSqlServerCloudDbTaskOutput>))
            : base(errors, state)
        {
            Input = input;
            Output = output;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets task input
        /// </summary>
        [JsonProperty(PropertyName = "input")]
        public ValidateMigrationInputSqlServerCloudDbTaskInput Input { get; set; }

        /// <summary>
        /// Gets task output. This is ignored if submitted.
        /// </summary>
        [JsonProperty(PropertyName = "output")]
        public IList<ValidateMigrationInputSqlServerCloudDbTaskOutput> Output { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Input != null)
            {
                Input.Validate();
            }
        }
    }
}
