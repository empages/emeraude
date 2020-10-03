using Newtonsoft.Json;

namespace Definux.Emeraude.Client.EmPages.Models
{
    /// <summary>
    /// Encapsulated class that contains information about the identity user for the current request.
    /// </summary>
    public class RequestUser
    {
        /// <summary>
        /// Flag that indicates whether user is authenticated or not.
        /// </summary>
        [JsonProperty("isAuthenticated")]
        public bool IsAuthenticated { get; set; }

        /// <summary>
        /// Full name of the user.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Email address of the user.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Array with the roles of the user.
        /// </summary>
        [JsonProperty("roles")]
        public string[] Roles { get; set; }
    }
}
