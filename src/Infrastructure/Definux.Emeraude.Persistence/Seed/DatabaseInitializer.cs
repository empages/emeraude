using Definux.Emeraude.Application.Common.Interfaces.Files;
using Definux.Emeraude.Application.Common.Interfaces.Persistence;
using Definux.Emeraude.Application.Common.Interfaces.Persistence.Seed;
using Microsoft.Extensions.Hosting;
using System.IO;
using System.Threading.Tasks;

namespace Definux.Emeraude.Persistence.Seed
{
    public abstract class DatabaseInitializer<TContext> : IDatabaseInitializer
        where TContext : IEmContext
    {
        protected readonly IHostEnvironment hostingEnvironment;
        protected readonly TContext entityContext;
        protected readonly ISystemFilesService systemFilesService;

        protected readonly string dataFolderPath = string.Empty;

        public DatabaseInitializer(IHostEnvironment hostingEnvironment, TContext entityContext, ISystemFilesService systemFilesService)
        {
            this.hostingEnvironment = hostingEnvironment;
            this.entityContext = entityContext;
            this.systemFilesService = systemFilesService;
            this.dataFolderPath = this.systemFilesService.GetPathFromPrivateRoot("seed");

            if (!Directory.Exists(this.dataFolderPath))
            {
                throw new DirectoryNotFoundException($"Directory '{this.dataFolderPath}' not found.");
            }
        }

        public abstract Task SeedAsync();
    }
}
