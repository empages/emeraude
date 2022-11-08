using System;

namespace EmPages.Identity;

/// <summary>
/// Result instance of authentication operation.
/// </summary>
public class EmAuthResult
{
    /// <summary>
    /// Indicates whether the result is succeeded or not.
    /// </summary>
    public bool Succeeded { get; set; }

    /// <summary>
    /// Result message.
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// JSON web token for access to the application resources.
    /// </summary>
    public string AccessToken { get; set; }

    /// <summary>
    /// Post authentication token for validate the multi-factor authentication.
    /// </summary>
    public string PostAuthenticationToken { get; set; }
}