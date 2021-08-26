using System.Text.Json.Serialization;
using Definux.Emeraude.Application.Files;

namespace Definux.Emeraude.Application.Requests.Identity.Queries.GetUserAvatar
{
    /// <summary>
    /// Result of <see cref="GetUserAvatarQuery"/>.
    /// </summary>
    public class GetUserAvatarResult : UserAvatarTypeResult
    {
        /// <summary>
        /// Avatar result in base64.
        /// </summary>
        public UserAvatarValue Avatar { get; set; }

        /// <summary>
        /// Gets the user avatar type result.
        /// </summary>
        /// <returns></returns>
        public UserAvatarTypeResult GetUserAvatarType()
        {
            return new UserAvatarTypeResult
            {
                IsDefault = this.IsDefault,
            };
        }
    }
}