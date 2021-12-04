using Emeraude.Infrastructure.Identity.Entities;
using Microsoft.EntityFrameworkCore;

namespace Emeraude.Infrastructure.Identity.Persistence;

/// <summary>
/// Database context for storing the identity entities.
/// </summary>
public interface IIdentityContext
{
    /// <summary>
    /// Gets or sets the <see cref="DbSet{User}"/> of Users.
    /// </summary>
    DbSet<User> Users { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="DbSet{UserClaim}"/> of User claims.
    /// </summary>
    DbSet<UserClaim> UserClaims { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="DbSet{UserLogin}"/> of User logins.
    /// </summary>
    DbSet<UserLogin> UserLogins { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="DbSet{UserToken}"/> of User tokens.
    /// </summary>
    DbSet<UserToken> UserTokens { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="DbSet{UserRole}"/> of User roles.
    /// </summary>
    DbSet<UserRole> UserRoles { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="DbSet{Role}"/> of roles.
    /// </summary>
    DbSet<Role> Roles { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="DbSet{RoleClaim}"/> of role claims.
    /// </summary>
    DbSet<RoleClaim> RoleClaims { get; set; }
}