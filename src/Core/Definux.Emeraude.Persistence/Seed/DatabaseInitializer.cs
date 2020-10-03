using System.IO;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Common.Interfaces.Files;
using Definux.Emeraude.Application.Common.Interfaces.Persistence;
using Definux.Emeraude.Application.Common.Interfaces.Persistence.Seed;
using Microsoft.Extensions.Hosting;

namespace Definux.Emeraude.Persistence.Seed
{
    /// <summary>
    /// Implementation of <see cref="IDatabaseInitializer"/> for the specified <see cref="IEmContext"/>.
    /// </summary>
    /// <typeparam name="TContext"><see cref="IEmContext"/>.</typeparam>
    public abstract class DatabaseInitializer<TContext> : IDatabaseInitializer
        where TContext : IEmContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseInitializer{TContext}"/> class.
        /// </summary>
        /// <param name="hostingEnvironment"></param>
        /// <param name="entityContext"></param>
        /// <param name="systemFilesService"></param>
        public DatabaseInitializer(IHostEnvironment hostingEnvironment, TContext entityContext, ISystemFilesService systemFilesService)
        {
            this.HostingEnvironment = hostingEnvironment;
            this.EntityContext = entityContext;
            this.SystemFilesService = systemFilesService;
            this.DataFolderPath = this.SystemFilesService.GetPathFromPrivateRoot("seed");

            if (!Directory.Exists(this.DataFolderPath))
            {
                throw new DirectoryNotFoundException($"Directory '{this.DataFolderPath}' not found.");
            }
        }

        /// <summary>
        /// Path of the folder that contains all data files used for data seed.
        /// </summary>
        protected string DataFolderPath { get; private set; } = string.Empty;

        /// <inheritdoc cref="IHostEnvironment"/>
        protected IHostEnvironment HostingEnvironment { get; private set; }

        /// <inheritdoc cref="IEmContext"/>
        protected TContext EntityContext { get; private set; }

        /// <inheritdoc cref="ISystemFilesService"/>
        protected ISystemFilesService SystemFilesService { get; private set; }

        /// <inheritdoc/>
        public abstract Task SeedAsync();
    }
}
