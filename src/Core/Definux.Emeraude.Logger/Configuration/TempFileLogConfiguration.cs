using Definux.Emeraude.Domain.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Definux.Emeraude.Logger.Configuration
{
    /// <inheritdoc cref="IEntityTypeConfiguration{TEntity}"/>
    internal class TempFileLogConfiguration : IEntityTypeConfiguration<TempFileLog>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<TempFileLog> builder)
        {
            builder.ConfigureLoggerEntity();
        }
    }
}