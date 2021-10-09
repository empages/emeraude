using System.Threading.Tasks;
using Definux.Emeraude.Application.Files;
using Definux.Emeraude.Application.Persistence;
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
        /// <param name="uploadService"></param>
        /// <param name="rootsService"></param>
        public DatabaseInitializer(
            IHostEnvironment hostingEnvironment,
            TContext entityContext,
            ISystemFilesService systemFilesService,
            IUploadService uploadService,
            IRootsService rootsService)
        {
            this.HostingEnvironment = hostingEnvironment;
            this.EntityContext = entityContext;
            this.SystemFilesService = systemFilesService;
            this.UploadService = uploadService;
            this.RootsService = rootsService;
            this.DataFolderPath = this.RootsService.GetPathFromPrivateRoot("seed");
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

        /// <inheritdoc cref="IUploadService"/>
        protected IUploadService UploadService { get; private set; }

        /// <inheritdoc cref="IRootsService"/>
        protected IRootsService RootsService { get; private set; }

        /// <inheritdoc/>
        public abstract Task SeedAsync();
    }
}
