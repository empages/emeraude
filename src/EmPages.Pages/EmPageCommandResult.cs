namespace EmPages.Pages;

/// <summary>
/// Implementation of command result.
/// </summary>
public class EmPageCommandResult
{
    /// <summary>
    /// Result message.
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Succeeded flag.
    /// </summary>
    public bool Succeeded { get; set; }

    /// <summary>
    /// Succeeded redirection URL.
    /// </summary>
    public string RedirectUrl { get; set; }
}