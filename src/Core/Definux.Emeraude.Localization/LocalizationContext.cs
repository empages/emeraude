using System.Reflection;
using Definux.Emeraude.Application.Localization;
using Definux.Emeraude.Domain.Localization;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Localization
{
    /// <inheritdoc cref="ILocalizationContext"/>
    public class LocalizationContext : DbContext, ILocalizationContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizationContext"/> class.
        /// </summary>
        /// <param name="options"></param>
        public LocalizationContext(DbContextOptions<LocalizationContext> options)
           : base(options)
        {
        }

        /// <inheritdoc/>
        public DbSet<Language> Languages { get; set; }

        /// <inheritdoc/>
        public DbSet<TranslationKey> Keys { get; set; }

        /// <inheritdoc/>
        public DbSet<TranslationValue> Values { get; set; }

        /// <inheritdoc/>
        public DbSet<ContentKey> ContentKeys { get; set; }

        /// <inheritdoc/>
        public DbSet<StaticContent> StaticContent { get; set; }

        /// <inheritdoc/>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder.Entity<Language>().ToTable("languages");
            builder.Entity<TranslationKey>().ToTable("keys");
            builder.Entity<TranslationValue>().ToTable("values");
            builder.Entity<StaticContent>().ToTable("static_content");
            builder.Entity<ContentKey>().ToTable("content_keys");

            base.OnModelCreating(builder);
        }
    }
}
