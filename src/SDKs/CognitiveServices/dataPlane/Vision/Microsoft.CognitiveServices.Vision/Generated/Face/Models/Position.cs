// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.CognitiveServices.Vision.Face.Models
{
    using Microsoft.CognitiveServices;
    using Microsoft.CognitiveServices.Vision;
    using Microsoft.CognitiveServices.Vision.Face;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Coordinates within an image
    /// </summary>
    public partial class Position
    {
        /// <summary>
        /// Initializes a new instance of the Position class.
        /// </summary>
        public Position()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Position class.
        /// </summary>
        /// <param name="x">The horizontal component, in pixels.</param>
        /// <param name="y">The vertical component, in pixels.</param>
        public Position(int x, int y)
        {
            X = x;
            Y = y;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the horizontal component, in pixels.
        /// </summary>
        [JsonProperty(PropertyName = "x")]
        public int X { get; set; }

        /// <summary>
        /// Gets or sets the vertical component, in pixels.
        /// </summary>
        [JsonProperty(PropertyName = "y")]
        public int Y { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
