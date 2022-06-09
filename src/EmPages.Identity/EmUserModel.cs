using System;
using System.Collections.Generic;

namespace EmPages.Identity;

/// <summary>
/// Public identity user model.
/// </summary>
public class EmUserModel
{
    /// <summary>
    /// Identifier of the user.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Name of the user.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Email of the user.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Flag that indicates whether the user is with enabled two factor authentication.
    /// </summary>
    public bool TwoFactorEnabled { get; set; }

    /// <summary>
    /// Flag that indicates whether the user is locked out.
    /// </summary>
    public bool IsLockedOut { get; set; }

    /// <summary>
    /// Collection of all user permissions.
    /// </summary>
    public IEnumerable<string> Permissions { get; set; }
}