namespace Definux.Emeraude.Infrastructure.Identity.Helpers
{
    /// <summary>
    /// Help class that contains user id and two factor authentication login provider.
    /// </summary>
    public class TwoFactorAuthenticationInfo
    {
        /// <summary>
        /// Id of the user.
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Login provider.
        /// </summary>
        public string LoginProvider { get; set; }
    }
}