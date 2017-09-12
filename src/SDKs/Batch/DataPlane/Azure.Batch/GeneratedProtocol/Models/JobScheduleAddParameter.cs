// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Batch;
    using Microsoft.Azure.Batch.Protocol;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A job schedule that allows recurring jobs by specifying when to run
    /// jobs and a specification used to create each job.
    /// </summary>
    public partial class JobScheduleAddParameter
    {
        /// <summary>
        /// Initializes a new instance of the JobScheduleAddParameter class.
        /// </summary>
        public JobScheduleAddParameter()
        {
            JobSpecification = new JobSpecification();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobScheduleAddParameter class.
        /// </summary>
        /// <param name="id">A string that uniquely identifies the schedule
        /// within the account.</param>
        /// <param name="schedule">The schedule according to which jobs will be
        /// created.</param>
        /// <param name="jobSpecification">The details of the jobs to be
        /// created on this schedule.</param>
        /// <param name="displayName">The display name for the
        /// schedule.</param>
        /// <param name="metadata">A list of name-value pairs associated with
        /// the schedule as metadata.</param>
        public JobScheduleAddParameter(string id, Schedule schedule, JobSpecification jobSpecification, string displayName = default(string), IList<MetadataItem> metadata = default(IList<MetadataItem>))
        {
            JobSpecification = new JobSpecification();
            Id = id;
            DisplayName = displayName;
            Schedule = schedule;
            JobSpecification = jobSpecification;
            Metadata = metadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a string that uniquely identifies the schedule within
        /// the account.
        /// </summary>
        /// <remarks>
        /// The ID can contain any combination of alphanumeric characters
        /// including hyphens and underscores, and cannot contain more than 64
        /// characters. The ID is case-preserving and case-insensitive (that
        /// is, you may not have two IDs within an account that differ only by
        /// case).
        /// </remarks>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the display name for the schedule.
        /// </summary>
        /// <remarks>
        /// The display name need not be unique and can contain any Unicode
        /// characters up to a maximum length of 1024.
        /// </remarks>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the schedule according to which jobs will be created.
        /// </summary>
        [JsonProperty(PropertyName = "schedule")]
        public Schedule Schedule { get; set; }

        /// <summary>
        /// Gets or sets the details of the jobs to be created on this
        /// schedule.
        /// </summary>
        [JsonProperty(PropertyName = "jobSpecification")]
        public JobSpecification JobSpecification { get; set; }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with the
        /// schedule as metadata.
        /// </summary>
        /// <remarks>
        /// The Batch service does not assign any meaning to metadata; it is
        /// solely for the use of user code.
        /// </remarks>
        [JsonProperty(PropertyName = "metadata")]
        public IList<MetadataItem> Metadata { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (Schedule == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Schedule");
            }
            if (JobSpecification == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "JobSpecification");
            }
            if (JobSpecification != null)
            {
                JobSpecification.Validate();
            }
            if (Metadata != null)
            {
                foreach (var element in Metadata)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
