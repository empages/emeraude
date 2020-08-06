using Definux.Emeraude.Domain.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Definux.Emeraude.Logger.Configuration
{
    internal class ErrorLogConfiguration : IEntityTypeConfiguration<ErrorLog>
    {
        public void Configure(EntityTypeBuilder<ErrorLog> builder)
        {
            builder.ConfigureLoggerEntity();

            builder
                .Property(x => x.StackTrace)
                .HasColumnName("stack_trace");

            builder
                .Property(x => x.Source)
                .HasColumnName("source");

            builder
                .Property(x => x.Message)
                .HasColumnName("message");

            builder
                .Property(x => x.Method)
                .HasColumnName("method");

            builder
                .Property(x => x.Class)
                .HasColumnName("class");
        }
    }
}