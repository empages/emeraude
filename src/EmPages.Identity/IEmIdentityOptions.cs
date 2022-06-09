using System;
using Microsoft.EntityFrameworkCore;

namespace EmPages.Identity;

/// <summary>
/// Options for configuring EmPages identity.
/// </summary>
public interface IEmIdentityOptions
{
    /// <summary>
    /// Identity database context options builder.
    /// </summary>
    Action<DbContextOptionsBuilder> DbContextOptionsBuilder { get; }

    /// <summary>
    /// Default password used for creation of new users. Framework default is 'Admin123!'.
    /// </summary>
    string DefaultUserPassword { get; }
}