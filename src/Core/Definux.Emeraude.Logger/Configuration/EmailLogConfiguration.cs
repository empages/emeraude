using Definux.Emeraude.Domain.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Definux.Emeraude.Logger.Configuration
{
    internal class EmailLogConfiguration : IEntityTypeConfiguration<EmailLog>
    {
        public void Configure(EntityTypeBuilder<EmailLog> builder)
        {
            builder.ConfigureLoggerEntity();

            builder
                .Property(x => x.Receiver)
                .HasColumnName("receiver");

            builder
                .Property(x => x.Subject)
                .HasColumnName("subject");

            builder
                .Property(x => x.Body)
                .HasColumnName("body");

            builder
                .Property(x => x.Sent)
                .HasColumnName("sent");
        }
    }
}