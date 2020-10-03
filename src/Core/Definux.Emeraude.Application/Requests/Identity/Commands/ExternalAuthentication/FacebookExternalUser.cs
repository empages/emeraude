using Newtonsoft.Json;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication
{
    /// <summary>
    /// Facebook external user implementation.
    /// </summary>
    public class FacebookExternalUser : IExternalUser
    {
        /// <inheritdoc/>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <inheritdoc/>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <inheritdoc/>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <inheritdoc/>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <inheritdoc/>
        [JsonProperty("email")]
        public string EmailAddress { get; set; }

        /// <inheritdoc/>
        [JsonIgnore]
        public string Provider { get; set; }

        /// <inheritdoc cref="Picture"/>
        [JsonIgnore]
        public string PictureUrl => this.Picture?.Data?.Url;

        /// <summary>
        /// Picture of the user.
        /// </summary>
        [JsonProperty("picture")]
        public ProfilePicture Picture { get; set; }
    }
}
