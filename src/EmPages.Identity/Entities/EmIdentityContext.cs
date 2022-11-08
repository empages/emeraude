using System;
using System.Linq;
using Essentials.Functions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmPages.Identity.Entities;

/// <summary>
/// Identity database context.
/// </summary>
internal class EmIdentityContext : IdentityUserContext<EmIdentityUser, Guid, EmIdentityUserClaim, EmIdentityUserLogin, EmIdentityUserToken>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmIdentityContext"/> class.
    /// </summary>
    /// <param name="options"></param>
    public EmIdentityContext(DbContextOptions<EmIdentityContext> options)
        : base(options)
    {
    }

    /// <inheritdoc/>
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        this.ConfigureTableNames<EmIdentityUser>(builder);
        this.ConfigureTableNames<EmIdentityUserClaim>(builder);
        this.ConfigureTableNames<EmIdentityUserLogin>(builder);
        this.ConfigureTableNames<EmIdentityUserToken>(builder);
    }

    private void ConfigureTableNames<TEntity>(ModelBuilder builder)
        where TEntity : class
    {
        var tableName = StringFunctions
            .SplitStringByCapitalLetters(typeof(TEntity).Name)
            .Replace(" ", "_")
            .ToLower();

        builder.Entity<TEntity>().ToTable(tableName);
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