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

            builder
                .Property(x => x.Action)
                .HasColumnName("action");

            builder
                .Property(x => x.Controller)
                .HasColumnName("controller");

            builder
                .Property(x => x.Area)
                .HasColumnName("area");

            builder
                .Property(x => x.Parameters)
                .HasColumnName("parameters");

            builder
                .Property(x => x.Headers)
                .HasColumnName("headers");

            builder
                .Property(x => x.Route)
                .HasColumnName("route");

            builder
                .Property(x => x.Method)
                .HasColumnName("method");

            builder
                .Property(x => x.TraceId)
                .HasColumnName("trace_id");

            builder
                .Property(x => x.UserAgent)
                .HasColumnName("user_agent");
        }
    }
}