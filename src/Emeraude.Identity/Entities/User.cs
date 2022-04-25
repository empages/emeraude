using System;
using Microsoft.AspNetCore.Identity;

namespace Emeraude.Identity.Entities;

/// <summary>
/// <inheritdoc cref="IdentityUser{TKey}"/>
/// </summary>
internal class User : IdentityUser<Guid>
{
    /// <summary>
    /// Name of the user.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Normalized name of the user.
    /// </summary>
    public string NormalizedName { get; set; }
}