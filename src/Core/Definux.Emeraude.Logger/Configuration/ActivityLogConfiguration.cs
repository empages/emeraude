using Definux.Emeraude.Domain.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Definux.Emeraude.Logger.Configuration
{
    /// <inheritdoc cref="IEntityTypeConfiguration{TEntity}"/>
    public class ActivityLogConfiguration : IEntityTypeConfiguration<ActivityLog>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<ActivityLog> builder)
        {
            builder.ConfigureLoggerEntity();
        }
    }
}