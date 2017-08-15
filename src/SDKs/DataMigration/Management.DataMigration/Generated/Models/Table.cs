// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataMigrationService.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.DataMigrationService;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Table properties
    /// </summary>
    public partial class Table
    {
        /// <summary>
        /// Initializes a new instance of the Table class.
        /// </summary>
        public Table()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Table class.
        /// </summary>
        /// <param name="hasRows">True if table has rows</param>
        /// <param name="name">Schema-qualified name of the table</param>
        public Table(bool? hasRows = default(bool?), string name = default(string))
        {
            HasRows = hasRows;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets true if table has rows
        /// </summary>
        [JsonProperty(PropertyName = "hasRows")]
        public bool? HasRows { get; set; }

        /// <summary>
        /// Gets or sets schema-qualified name of the table
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
