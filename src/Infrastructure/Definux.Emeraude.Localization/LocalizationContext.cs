using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Emeraude.Domain.Localization;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Definux.Emeraude.Localization
{
    public class LocalizationContext : DbContext, ILocalizationContext
    {
        public LocalizationContext(DbContextOptions<LocalizationContext> options)
           : base(options)
        {
        }

        public DbSet<Language> Languages { get; set; }

        public DbSet<TranslationKey> Keys { get; set; }

        public DbSet<TranslationValue> Values { get; set; }

        public DbSet<ContentKey> ContentKeys { get; set; }

        public DbSet<StaticContent> StaticContent { get; set; }

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
