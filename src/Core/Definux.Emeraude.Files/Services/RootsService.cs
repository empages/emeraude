using System.IO;
using System.Linq;
using Definux.Emeraude.Application.Files;
using Definux.Emeraude.Essentials.Base;
using Microsoft.AspNetCore.Hosting;

namespace Definux.Emeraude.Files.Services
{
    /// <inheritdoc cref="IRootsService"/>
    public class RootsService : IRootsService
    {
        private readonly IHostingEnvironment hostingEnvironment;

        /// <summary>
        /// Initializes a new instance of the <see cref="RootsService"/> class.
        /// </summary>
        /// <param name="hostingEnvironment"></param>
        public RootsService(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
        }

        /// <inheritdoc/>
        public string PublicRootDirectory => this.hostingEnvironment.WebRootPath;

        /// <inheritdoc/>
        public string PrivateRootDirectory => Path.Combine(
            this.hostingEnvironment.ContentRootPath,
            EmFolders.PrivateRootFolderName);

        /// <inheritdoc/>
        public string GetPathFromPublicRoot(params string[] paths)
        {
            var resultPaths = paths.ToList();
            resultPaths.Insert(0, this.PublicRootDirectory);

            return Path.Combine(resultPaths.ToArray());
        }

        /// <inheritdoc/>
        public string GetPathFromPrivateRoot(params string[] paths)
        {
            var resultPaths = paths.ToList();
            resultPaths.Insert(0, this.PrivateRootDirectory);

            return Path.Combine(resultPaths.ToArray());
        }
    }
}