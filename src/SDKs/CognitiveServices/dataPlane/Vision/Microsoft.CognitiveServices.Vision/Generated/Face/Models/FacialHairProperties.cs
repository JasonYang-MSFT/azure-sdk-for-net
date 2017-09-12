// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
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
    /// Properties describing facial hair attributes.
    /// </summary>
    public partial class FacialHairProperties
    {
        /// <summary>
        /// Initializes a new instance of the FacialHairProperties class.
        /// </summary>
        public FacialHairProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FacialHairProperties class.
        /// </summary>
        public FacialHairProperties(double? mustache = default(double?), double? beard = default(double?), double? sideburns = default(double?))
        {
            Mustache = mustache;
            Beard = beard;
            Sideburns = sideburns;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mustache")]
        public double? Mustache { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "beard")]
        public double? Beard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sideburns")]
        public double? Sideburns { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Mustache > 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Mustache", 1);
            }
            if (Mustache < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Mustache", 0);
            }
            if (Beard > 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Beard", 1);
            }
            if (Beard < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Beard", 0);
            }
            if (Sideburns > 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Sideburns", 1);
            }
            if (Sideburns < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Sideburns", 0);
            }
        }
    }
}
