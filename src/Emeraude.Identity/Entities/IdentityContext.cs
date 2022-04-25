using System;
using System.Linq;
using Essentials.Functions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Emeraude.Identity.Entities;

/// <summary>
/// Identity database context.
/// </summary>
internal class IdentityContext : IdentityUserContext<User, Guid, UserClaim, UserLogin, UserToken>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IdentityContext"/> class.
    /// </summary>
    /// <param name="options"></param>
    public IdentityContext(DbContextOptions<IdentityContext> options)
        : base(options)
    {
    }

    /// <inheritdoc/>
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder
            .Entity<User>()
            .Property(x => x.Name)
            .IsRequired();

        this.ConfigureTableNames<User>(builder);
        this.ConfigureTableNames<UserClaim>(builder);
        this.ConfigureTableNames<UserLogin>(builder);
        this.ConfigureTableNames<UserToken>(builder);
    }

    private void ConfigureTableNames<TEntity>(ModelBuilder builder)
        where TEntity : class
    {
        var tableName = StringFunctions
            .SplitStringByCapitalLetters(typeof(TEntity).Name)
            .Replace(" ", "_")
            .ToLower();

        builder.Entity<TEntity>().ToTable($"em_{tableName}");
        var propertiesNames = typeof(TEntity).GetProperties().Select(x => x.Name);
        foreach (var propertyName in propertiesNames)
        {
            var columnName = StringFunctions
                .SplitStringByCapitalLetters(propertyName)
                .Replace(" ", "_")
                .ToLower();
            builder.Entity<TEntity>().Property(propertyName).HasColumnName(columnName);
        }
    }
}