using Newtonsoft.Json;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication
{
    public class GoogleExternalUser : IExternalUser
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("given_name")]
        public string FirstName { get; set; }

        [JsonProperty("family_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string EmailAddress { get; set; }

        [JsonIgnore]
        public string Provider { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonIgnore]
        public string PictureUrl => Picture;
    }
}
