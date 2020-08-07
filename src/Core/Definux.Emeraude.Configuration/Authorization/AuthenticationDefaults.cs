namespace Definux.Emeraude.Configuration.Authorization
{
    public static class AuthenticationDefaults
    {
        public const string AdminAuthenticationScheme = "AdminCookie";
        public const string AdminCookieName = "em_admin";

        public const string ClientAuthenticationScheme = "ClientCookie";
        public const string ClientCookieName = "em_client";

        public const string JwtBearerAuthenticationScheme = "Bearer";
    }
}
