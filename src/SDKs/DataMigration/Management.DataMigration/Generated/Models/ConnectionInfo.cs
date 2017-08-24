// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataMigration;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information for connecting to database server
    /// </summary>
    public partial class ConnectionInfo
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionInfo class.
        /// </summary>
        public ConnectionInfo()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionInfo class.
        /// </summary>
        /// <param name="dataSource">Data source in the format
        /// MachineName\SQLServerInstanceName,PortNumber</param>
        /// <param name="machineName">Machine name for the server
        /// connection</param>
        /// <param name="serverName">Server name in the format
        /// MachineName\InstanceName</param>
        /// <param name="portNumber">Port number of the server</param>
        /// <param name="userName">User name credential</param>
        /// <param name="password">Password credential. It must be RSA
        /// encrypted by the public key of the VM, then base64 encoded. It must
        /// never be the plaintext! Cryptography class contains helper methods
        /// to perform the encryption.
        /// </param>
        /// <param name="authentication">Authentication type to use for
        /// connection. Possible values include: 'None',
        /// 'WindowsAuthentication', 'SqlAuthentication',
        /// 'ActiveDirectoryIntegrated', 'ActiveDirectoryPassword'</param>
        /// <param name="impersonateAsUser">User name to impersonate as</param>
        /// <param name="impersonateAsPassword">Password to impersonate with.
        /// It must be RSA encrypted by the public key of the VM, then base64
        /// encoded. It must never be the plaintext! Cryptography class
        /// contains helper methods to perform the encryption.
        /// </param>
        /// <param name="shouldImpersonate">Whether to impersonate before
        /// connecting</param>
        /// <param name="encryptConnection">Whether to encrypt the
        /// connection</param>
        /// <param name="additionalSettings">Additional connection
        /// settings</param>
        /// <param name="platform">Platform of the server. Possible values
        /// include: 'SqlOnPrem'</param>
        /// <param name="trustServerCertificate">Whether to trust the server
        /// certificate</param>
        public ConnectionInfo(string dataSource = default(string), string machineName = default(string), string serverName = default(string), int? portNumber = default(int?), string userName = default(string), string password = default(string), AuthenticationType? authentication = default(AuthenticationType?), string impersonateAsUser = default(string), string impersonateAsPassword = default(string), bool? shouldImpersonate = default(bool?), bool? encryptConnection = default(bool?), string additionalSettings = default(string), SourcePlatform? platform = default(SourcePlatform?), bool? trustServerCertificate = default(bool?))
        {
            DataSource = dataSource;
            MachineName = machineName;
            ServerName = serverName;
            PortNumber = portNumber;
            UserName = userName;
            Password = password;
            Authentication = authentication;
            ImpersonateAsUser = impersonateAsUser;
            ImpersonateAsPassword = impersonateAsPassword;
            ShouldImpersonate = shouldImpersonate;
            EncryptConnection = encryptConnection;
            AdditionalSettings = additionalSettings;
            Platform = platform;
            TrustServerCertificate = trustServerCertificate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets data source in the format
        /// MachineName\SQLServerInstanceName,PortNumber
        /// </summary>
        [JsonProperty(PropertyName = "dataSource")]
        public string DataSource { get; set; }

        /// <summary>
        /// Gets or sets machine name for the server connection
        /// </summary>
        [JsonProperty(PropertyName = "machineName")]
        public string MachineName { get; set; }

        /// <summary>
        /// Gets or sets server name in the format MachineName\InstanceName
        /// </summary>
        [JsonProperty(PropertyName = "serverName")]
        public string ServerName { get; set; }

        /// <summary>
        /// Gets or sets port number of the server
        /// </summary>
        [JsonProperty(PropertyName = "portNumber")]
        public int? PortNumber { get; set; }

        /// <summary>
        /// Gets or sets user name credential
        /// </summary>
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets password credential. It must be RSA encrypted by the
        /// public key of the VM, then base64 encoded. It must never be the
        /// plaintext! Cryptography class contains helper methods to perform
        /// the encryption.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets authentication type to use for connection. Possible
        /// values include: 'None', 'WindowsAuthentication',
        /// 'SqlAuthentication', 'ActiveDirectoryIntegrated',
        /// 'ActiveDirectoryPassword'
        /// </summary>
        [JsonProperty(PropertyName = "authentication")]
        public AuthenticationType? Authentication { get; set; }

        /// <summary>
        /// Gets or sets user name to impersonate as
        /// </summary>
        [JsonProperty(PropertyName = "impersonateAsUser")]
        public string ImpersonateAsUser { get; set; }

        /// <summary>
        /// Gets or sets password to impersonate with. It must be RSA encrypted
        /// by the public key of the VM, then base64 encoded. It must never be
        /// the plaintext! Cryptography class contains helper methods to
        /// perform the encryption.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "impersonateAsPassword")]
        public string ImpersonateAsPassword { get; set; }

        /// <summary>
        /// Gets or sets whether to impersonate before connecting
        /// </summary>
        [JsonProperty(PropertyName = "shouldImpersonate")]
        public bool? ShouldImpersonate { get; set; }

        /// <summary>
        /// Gets or sets whether to encrypt the connection
        /// </summary>
        [JsonProperty(PropertyName = "encryptConnection")]
        public bool? EncryptConnection { get; set; }

        /// <summary>
        /// Gets or sets additional connection settings
        /// </summary>
        [JsonProperty(PropertyName = "additionalSettings")]
        public string AdditionalSettings { get; set; }

        /// <summary>
        /// Gets or sets platform of the server. Possible values include:
        /// 'SqlOnPrem'
        /// </summary>
        [JsonProperty(PropertyName = "platform")]
        public SourcePlatform? Platform { get; set; }

        /// <summary>
        /// Gets or sets whether to trust the server certificate
        /// </summary>
        [JsonProperty(PropertyName = "trustServerCertificate")]
        public bool? TrustServerCertificate { get; set; }

    }
}
