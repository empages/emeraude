using Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication;
using Newtonsoft.Json;

namespace Definux.Emeraude.Identity.ExternalProviders.Facebook
{
    /// <summary>
    /// Helper class for mapping Facebook profile picture.
    /// </summary>
    public class ProfilePicture
    {
        /// <summary>
        /// Profile picture data.
        /// </summary>
        [JsonProperty("data")]
        public ProfilePictureData Data { get; set; }
    }
}