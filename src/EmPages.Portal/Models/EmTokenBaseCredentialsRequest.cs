using System.ComponentModel.DataAnnotations;
using EmPages.Identity;

namespace EmPages.Portal.Models;

/// <summary>
/// Implementation of base credentials request contract.
/// </summary>
public class EmTokenBaseCredentialsRequest : IEmTokenBaseCredentialsRequest
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
    public string Password { get; set; }
}