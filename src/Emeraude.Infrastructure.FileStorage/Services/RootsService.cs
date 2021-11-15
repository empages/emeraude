using System.IO;
using System.Linq;
using Emeraude.Essentials.Base;
using Microsoft.AspNetCore.Hosting;

namespace Emeraude.Infrastructure.FileStorage.Services
{
    /// <inheritdoc cref="IRootsService"/>
    public class RootsService : IRootsService
    {
        private readonly IWebHostEnvironment hostEnvironment;

        /// <summary>
        /// Initializes a new instance of the <see cref="RootsService"/> class.
        /// </summary>
        /// <param name="hostEnvironment"></param>
        public RootsService(IWebHostEnvironment hostEnvironment)
        {
            this.hostEnvironment = hostEnvironment;
        }

        /// <inheritdoc/>
        public string PublicRootDirectory => this.hostEnvironment.WebRootPath;

        /// <inheritdoc/>
        public string PrivateRootDirectory => Path.Combine(
            this.hostEnvironment.ContentRootPath,
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