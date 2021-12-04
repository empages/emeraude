namespace Emeraude.Configuration.Options;

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
}