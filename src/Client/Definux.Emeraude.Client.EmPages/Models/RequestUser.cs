using Newtonsoft.Json;

namespace Definux.Emeraude.Client.EmPages.Models
{
    public class RequestUser
    {
        [JsonProperty("isAuthenticated")]
        public bool IsAuthenticated { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }
    }
}
