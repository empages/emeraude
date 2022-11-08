namespace EmPages.Identity;

/// <summary>
/// Contract for retrieve token request argument.
/// </summary>
public interface IEmTokenMfaBasedCredentialsRequest
{
    /// <summary>
    /// Email of the user.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Multi-factor authenticator code.
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Post authentication token retrieved by the base credentials request.
    /// </summary>
    public string PostAuthenticationToken { get; set; }
}