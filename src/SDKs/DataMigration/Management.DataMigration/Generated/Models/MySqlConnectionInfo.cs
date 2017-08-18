// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataMigrationService.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.DataMigrationService;
    using System.Linq;

    /// <summary>
    /// Information for connecting to MySQL source
    /// </summary>
    public partial class MySqlConnectionInfo : ForeignConnectionInfoBase
    {
        /// <summary>
        /// Initializes a new instance of the MySqlConnectionInfo class.
        /// </summary>
        public MySqlConnectionInfo()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MySqlConnectionInfo class.
        /// </summary>
        /// <param name="serverName">Name of the server</param>
        /// <param name="portNumber">Port number</param>
        /// <param name="userName">User name</param>
        /// <param name="password">Password credential. It must be RSA
        /// encrypted by the public key of the VM, then base64 encoded. It must
        /// never be the plaintext! Cryptography class contains helper methods
        /// to perform the encryption.
        /// </param>
        public MySqlConnectionInfo(string serverName = default(string), int? portNumber = default(int?), string userName = default(string), string password = default(string))
            : base(serverName, portNumber, userName, password)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
