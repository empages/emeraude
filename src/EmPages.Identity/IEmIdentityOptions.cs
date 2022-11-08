using System;
using Microsoft.AspNetCore.Identity;
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

    /// <summary>
    /// Access token security key.
    /// </summary>
    string AccessTokenSecurityKey { get; }

    /// <summary>
    /// Access token issuer.
    /// </summary>
    string AccessTokenIssuer { get; }

    /// <summary>
    /// Access token expiration time.
    /// </summary>
    TimeSpan AccessTokenExpirationSpan { get; }

    /// <summary>
    /// Internal ASP.NET identity options for the purposes of the framework.
    /// </summary>
    IdentityOptions IdentityOptions { get; }
}