using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Emeraude.Essentials.Helpers;
using Emeraude.Infrastructure.FileStorage.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Emeraude.Infrastructure.FileStorage.Services
{
    /// <inheritdoc cref="IUploadService"/>
    public class UploadService : IUploadService
    {
        private readonly ILogger<UploadService> logger;
        private readonly IWebHostEnvironment hostEnvironment;
        private readonly IRootsService rootsService;
        private readonly ITemporaryFilesService temporaryFilesService;

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadService"/> class.
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="hostEnvironment"></param>
        /// <param name="rootsService"></param>
        /// <param name="temporaryFilesService"></param>
        public UploadService(
            ILogger<UploadService> logger,
            IWebHostEnvironment hostEnvironment,
            IRootsService rootsService,
            ITemporaryFilesService temporaryFilesService)
        {
            this.logger = logger;
            this.hostEnvironment = hostEnvironment;
            this.rootsService = rootsService;
            this.temporaryFilesService = temporaryFilesService;
        }

        /// <inheritdoc/>
        public async Task<string> UploadFileAsync(IFormFile formFile)
        {
            try
            {
                var saveDirectory = this.hostEnvironment.GetTempUploadDirectory();
                var resultFileName = FilesUtilities.GetUniqueFileName();
                var resultFileExtension = formFile.FileName.Split('.').LastOrDefault();
                var fileFullPath = Path.Combine(saveDirectory, $"{resultFileName}.{resultFileExtension}");

                await using var stream = File.Create(fileFullPath);
                await formFile.CopyToAsync(stream);
                stream.Flush();

                this.temporaryFilesService.SaveFile(resultFileName);

                return resultFileName;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An unexpected error occured during upload file");
                return default;
            }
        }

        /// <inheritdoc/>
        public async Task<string> UploadFileAsync(IFormFile formFile, string saveDirectory, bool publicRoot = false)
        {
            try
            {
                var rootDirectory = publicRoot ? this.rootsService.PublicRootDirectory : this.rootsService.PrivateRootDirectory;
                var fullSaveDirectory = Path.Combine(rootDirectory, saveDirectory);
                var resultFileName = FilesUtilities.GetUniqueFileName();
                var resultFileExtension = formFile.FileName.Split('.').LastOrDefault();
                var fileFullPath = Path.Combine(fullSaveDirectory, $"{resultFileName}.{resultFileExtension}");

                await using var stream = File.Create(fileFullPath);
                await formFile.CopyToAsync(stream);
                stream.Flush();

                this.temporaryFilesService.SaveFile(resultFileName);

                return resultFileName;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An unexpected error occured during upload file");
                return default;
            }
        }
    }
}