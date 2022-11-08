using System.ComponentModel.DataAnnotations;
using EmPages.Identity;

namespace EmPages.PortalGateway.Models;

/// <summary>
/// Implementation of MFA-based credentials request contract.
/// </summary>
public class EmTokenMfaBasedCredentialsRequest : IEmTokenMfaBasedCredentialsRequest
{
    /// <summary>
    /// <inheritdoc />
    /// </summary>
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    /// <summary>
    /// <inheritdoc />
    /// </summary>
    [Required]
    public string Code { get; set; }

    /// <summary>
    /// <inheritdoc />
    /// </summary>
    [Required]
    public string PostAuthenticationToken { get; set; }
}