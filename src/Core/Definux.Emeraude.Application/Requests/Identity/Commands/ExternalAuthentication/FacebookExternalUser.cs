using Newtonsoft.Json;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication
{
    public class FacebookExternalUser : IExternalUser
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string EmailAddress { get; set; }

        [JsonIgnore]
        public string Provider { get; set; }

        [JsonIgnore]
        public string PictureUrl 
        { 
            get
            {
                return Picture?.Data?.Url;
            }
        }

        [JsonProperty("picture")]
        public ProfilePicture Picture { get; set; }

        public class ProfilePicture
        {
            [JsonProperty("data")]
            public ProfilePictureData Data { get; set; }

            public class ProfilePictureData
            {
                [JsonProperty("url")]
                public string Url { get; set; }
            }
        }
    }
}
