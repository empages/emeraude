namespace Emeraude.Infrastructure.Identity.EventHandlers;

/// <summary>
/// Event arguments for forgot password event handler.
/// </summary>
public class ForgotPasswordEventArgs : IdentityEventArgs
{
    /// <summary>
    /// Reset password link.
    /// </summary>
    public string ResetPasswordLink { get; set; }
}