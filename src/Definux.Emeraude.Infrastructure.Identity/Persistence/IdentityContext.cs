using System;
using Definux.Emeraude.Infrastructure.Identity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Infrastructure.Identity.Persistence
{
    /// <summary>
    /// Implementation of <see cref="IdentityDbContext"/> that wrap the identity functionality of ASP.NET Core for the purposes of Emeraude.
    /// </summary>
    /// <typeparam name="TContext"><see cref="IdentityContext{TContext}"/>.</typeparam>
    public abstract class IdentityContext<TContext> : IdentityDbContext<User, Role, Guid, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>, IIdentityContext
        where TContext : IdentityContext<TContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityContext{TContext}"/> class.
        /// </summary>
        /// <param name="options"></param>
        public IdentityContext(DbContextOptions<TContext> options)
            : base(options)
        {
        }

        /// <inheritdoc/>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>().ToTable("Users");
            builder.Entity<Role>().ToTable("Roles");
            builder.Entity<RoleClaim>().ToTable("RoleClaims");
            builder.Entity<UserClaim>().ToTable("UserClaims");
            builder.Entity<UserLogin>().ToTable("UserLogins");
            builder.Entity<UserRole>().ToTable("UserRoles");
            builder.Entity<UserToken>().ToTable("UserTokens");
        }
    }
}
