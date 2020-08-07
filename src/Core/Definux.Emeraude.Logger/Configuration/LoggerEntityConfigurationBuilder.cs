using Definux.Emeraude.Domain.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Definux.Emeraude.Logger.Configuration
{
    internal static class LoggerEntityConfigurationBuilder
    {
        internal static EntityTypeBuilder<TEntity> ConfigureLoggerEntity<TEntity>(this EntityTypeBuilder<TEntity> builder)
            where TEntity : LoggerEntity
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            builder
                .Property(x => x.CreatedBy)
                .HasColumnName("created_by");

            builder
                .Property(x => x.CreatedOn)
                .HasColumnName("created_on");

            return builder;
        }
    }
}
