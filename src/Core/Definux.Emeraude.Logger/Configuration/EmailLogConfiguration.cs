using Definux.Emeraude.Domain.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Definux.Emeraude.Logger.Configuration
{
    /// <inheritdoc cref="IEntityTypeConfiguration{TEntity}"/>
    internal class EmailLogConfiguration : IEntityTypeConfiguration<EmailLog>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<EmailLog> builder)
        {
            builder.ConfigureLoggerEntity();
        }
    }
}