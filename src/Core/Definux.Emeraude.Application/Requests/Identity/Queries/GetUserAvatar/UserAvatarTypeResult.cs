namespace Definux.Emeraude.Application.Requests.Identity.Queries.GetUserAvatar
{
    /// <summary>
    /// Result of <see cref="GetUserAvatarQuery"/>.
    /// </summary>
    public class UserAvatarTypeResult
    {
        /// <summary>
        /// Flag that indicates whether the result avatar is the system default or not.
        /// </summary>
        public bool IsDefault { get; set; }
    }
}