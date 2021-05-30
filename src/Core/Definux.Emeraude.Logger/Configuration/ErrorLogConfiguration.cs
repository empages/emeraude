using Definux.Emeraude.Domain.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Definux.Emeraude.Logger.Configuration
{
    /// <inheritdoc cref="IEntityTypeConfiguration{TEntity}"/>
    internal class ErrorLogConfiguration : IEntityTypeConfiguration<ErrorLog>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<ErrorLog> builder)
        {
            builder.ConfigureLoggerEntity();
        }
    }
}