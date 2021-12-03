namespace Emeraude.Presentation
{
    /// <summary>
    /// List of all authentication constants into the system.
    /// </summary>
    public static class EmAuthenticationDefaults
    {
        /// <summary>
        /// Name of the cookie authentication scheme.
        /// </summary>
        public const string CookieAuthenticationScheme = "_CookieAuthentication";

        /// <summary>
        /// Name of the session cookie.
        /// </summary>
        public const string SessionCookieName = "em_auth_session";

        /// <summary>
        /// Name of the Bearer authentication scheme.
        /// </summary>
        public const string BearerAuthenticationScheme = "_BearerAuthentication";
    }
}
