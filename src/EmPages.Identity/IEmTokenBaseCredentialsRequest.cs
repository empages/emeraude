namespace EmPages.Identity;

/// <summary>
/// Contract for retrieve token request argument.
/// </summary>
public interface IEmTokenBaseCredentialsRequest
{
    /// <summary>
    /// Email of the user.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Password of the user.
    /// </summary>
    public string Password { get; set; }
}