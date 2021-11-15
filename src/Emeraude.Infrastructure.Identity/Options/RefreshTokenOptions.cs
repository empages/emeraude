namespace Emeraude.Infrastructure.Identity.Options
{
    /// <summary>
    /// Implementation of refresh token options.
    /// </summary>
    public class RefreshTokenOptions
    {
        /// <summary>
        /// Flag that indicates whether the refresh token can be used by unauthorized users.
        /// If set to 'true' only authenticated users can refresh their access token.
        /// </summary>
        public bool RequireAuthentication { get; set; }

        /// <summary>
        /// Seconds that indicate the valid time of the refresh token. Default is 31536000 (365 days).
        /// </summary>
        public int Expiration { get; set; } = 31536000;
    }
}