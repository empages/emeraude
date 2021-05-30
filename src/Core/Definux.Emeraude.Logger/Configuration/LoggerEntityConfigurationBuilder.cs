using Definux.Emeraude.Domain.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Definux.Emeraude.Logger.Configuration
{
    /// <summary>
    /// Extensions for <see cref="EntityTypeBuilder{TEntity}"/>.
    /// </summary>
    internal static class LoggerEntityConfigurationBuilder
    {
        /// <summary>
        /// Configure abstract logger entity properties.
        /// </summary>
        /// <typeparam name="TEntity">Target entity.</typeparam>
        /// <param name="builder"></param>
        /// <returns></returns>
        internal static EntityTypeBuilder<TEntity> ConfigureLoggerEntity<TEntity>(this EntityTypeBuilder<TEntity> builder)
            where TEntity : LoggerEntity
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            return builder;
        }
    }
}
