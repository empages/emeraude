namespace Definux.Emeraude.Configuration.Authorization
{
    /// <summary>
    /// List of all authentication constants into the system.
    /// </summary>
    public static class AuthenticationDefaults
    {
        /// <summary>
        /// Name of the admin authentication scheme.
        /// </summary>
        public const string AdminAuthenticationScheme = "AdminCookie";

        /// <summary>
        /// Name of the admin session cookie.
        /// </summary>
        public const string AdminCookieName = "em_admin";

        /// <summary>
        /// Name of the client authentication scheme.
        /// </summary>
        public const string ClientAuthenticationScheme = "ClientCookie";

        /// <summary>
        /// Name of the client session cookie.
        /// </summary>
        public const string ClientCookieName = "em_client";

        /// <summary>
        /// Name of the JSON web token Bearer authentication scheme.
        /// </summary>
        public const string JwtBearerAuthenticationScheme = "Bearer";
    }
}
