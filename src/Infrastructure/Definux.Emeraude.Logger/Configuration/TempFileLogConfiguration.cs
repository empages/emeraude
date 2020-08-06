using Definux.Emeraude.Domain.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Definux.Emeraude.Logger.Configuration
{
    internal class TempFileLogConfiguration : IEntityTypeConfiguration<TempFileLog>
    {
        public void Configure(EntityTypeBuilder<TempFileLog> builder)
        {
            builder.ConfigureLoggerEntity();

            builder
                .Property(x => x.Name)
                .HasColumnName("name");

            builder
                .Property(x => x.Path)
                .HasColumnName("path");

            builder
                .Property(x => x.FileType)
                .HasColumnName("file_type");

            builder
                .Property(x => x.FileExtension)
                .HasColumnName("file_extension");

            builder
                .Property(x => x.Applied)
                .HasColumnName("applied");
        }
    }
}