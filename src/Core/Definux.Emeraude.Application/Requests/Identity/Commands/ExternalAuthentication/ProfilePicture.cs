using Newtonsoft.Json;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication
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