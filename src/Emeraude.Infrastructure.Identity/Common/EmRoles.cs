﻿namespace Emeraude.Infrastructure.Identity.Common;

/// <summary>
/// List of all built-in application roles.
/// </summary>
public static class EmRoles
{
    /// <summary>
    /// Role 'Admin' represent user with absolute all rights in the system.
    /// </summary>
    public const string Admin = "Admin";

    /// <summary>
    /// Role 'User' represent user with access only in client part of the system.
    /// </summary>
    public const string User = "User";
}