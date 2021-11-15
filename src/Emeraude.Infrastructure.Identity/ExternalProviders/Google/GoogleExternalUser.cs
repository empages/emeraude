using Emeraude.Infrastructure.Identity.Services;
using Newtonsoft.Json;

namespace Emeraude.Infrastructure.Identity.ExternalProviders.Google
{
    /// <summary>
    /// Google external user implementation.
    /// </summary>
    public class GoogleExternalUser : IExternalUser
    {
        /// <inheritdoc/>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <inheritdoc/>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <inheritdoc/>
        [JsonProperty("given_name")]
        public string FirstName { get; set; }

        /// <inheritdoc/>
        [JsonProperty("family_name")]
        public string LastName { get; set; }

        /// <inheritdoc/>
        [JsonProperty("email")]
        public string EmailAddress { get; set; }

        /// <inheritdoc/>
        [JsonIgnore]
        public string Provider { get; set; }

        /// <inheritdoc cref="PictureUrl"/>
        [JsonProperty("picture")]
        public string Picture { get; set; }

        /// <inheritdoc/>
        [JsonIgnore]
        public string PictureUrl => this.Picture;
    }
}
