namespace Definux.Emeraude.Configuration.Options
{
    /// <summary>
    /// List of Emeraude identity constants.
    /// </summary>
    public static class EmIdentityConstants
    {
        /// <summary>
        /// Default required password length.
        /// </summary>
        public const int PasswordRequiredLength = 6;

        /// <summary>
        /// Default lockout time in minutes.
        /// </summary>
        public const int DefaultLockoutTimeSpanMinutes = 30;

        /// <summary>
        /// Default max failed access attempts.
        /// </summary>
        public const int MaxFailedAccessAttempts = 5;

        /// <summary>
        /// Default Emeraude admin password.
        /// </summary>
        public const string DefaultEmeraudeAdminPassword = "Admin123!";

        /// <summary>
        /// Default Emeraude user password.
        /// </summary>
        public const string DefaultEmeraudeUserPassword = "User123!";

        /// <summary>
        /// Default Emeraude admin name.
        /// </summary>
        public const string DefaultEmeraudeAdminName = "Admin";

        /// <summary>
        /// Default Emeraude user name.
        /// </summary>
        public const string DefaultEmeraudeUserName = "User";

        /// <summary>
        /// Default Emeraude admin email.
        /// </summary>
        public const string DefaultEmeraudeAdminEmail = "admin@example.com";

        /// <summary>
        /// Default Emeraude user email.
        /// </summary>
        public const string DefaultEmeraudeUserEmail = "user@example.com";
    }
}
