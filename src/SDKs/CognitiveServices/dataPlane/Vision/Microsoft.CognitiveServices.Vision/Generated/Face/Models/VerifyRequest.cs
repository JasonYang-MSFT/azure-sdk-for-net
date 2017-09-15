// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.CognitiveServices.Vision.Face.Models
{
    using Microsoft.CognitiveServices;
    using Microsoft.CognitiveServices.Vision;
    using Microsoft.CognitiveServices.Vision.Face;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Request body for verify operation.
    /// </summary>
    public partial class VerifyRequest
    {
        /// <summary>
        /// Initializes a new instance of the VerifyRequest class.
        /// </summary>
        public VerifyRequest()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VerifyRequest class.
        /// </summary>
        /// <param name="faceId">faceId the face, comes from Face -
        /// Detect</param>
        /// <param name="personId">Specify a certain person in a person group.
        /// personId is created in Persons.Create.</param>
        /// <param name="personGroupId">Using existing personGroupId and
        /// personId for fast loading a specified person. personGroupId is
        /// created in Person Groups.Create.</param>
        public VerifyRequest(string faceId, string personId, string personGroupId)
        {
            FaceId = faceId;
            PersonId = personId;
            PersonGroupId = personGroupId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets faceId the face, comes from Face - Detect
        /// </summary>
        [JsonProperty(PropertyName = "faceId")]
        public string FaceId { get; set; }

        /// <summary>
        /// Gets or sets specify a certain person in a person group. personId
        /// is created in Persons.Create.
        /// </summary>
        [JsonProperty(PropertyName = "personId")]
        public string PersonId { get; set; }

        /// <summary>
        /// Gets or sets using existing personGroupId and personId for fast
        /// loading a specified person. personGroupId is created in Person
        /// Groups.Create.
        /// </summary>
        [JsonProperty(PropertyName = "personGroupId")]
        public string PersonGroupId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FaceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FaceId");
            }
            if (PersonId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PersonId");
            }
            if (PersonGroupId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PersonGroupId");
            }
            if (FaceId != null)
            {
                if (FaceId.Length > 64)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "FaceId", 64);
                }
            }
        }
    }
}
