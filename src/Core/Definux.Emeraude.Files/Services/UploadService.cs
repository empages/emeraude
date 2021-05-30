using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Files;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Domain.Logging;
using Definux.Emeraude.Files.Extensions;
using Definux.Emeraude.Resources;
using Definux.Utilities.Functions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Definux.Emeraude.Files.Services
{
    /// <inheritdoc cref="IUploadService"/>
    public class UploadService : IUploadService
    {
        private readonly ILoggerContext loggerContext;
        private readonly IEmLogger logger;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly IRootsService rootsService;

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadService"/> class.
        /// </summary>
        /// <param name="loggerContext"></param>
        /// <param name="logger"></param>
        /// <param name="hostingEnvironment"></param>
        /// <param name="rootsService"></param>
        public UploadService(
            ILoggerContext loggerContext,
            IEmLogger logger,
            IHostingEnvironment hostingEnvironment,
            IRootsService rootsService)
        {
            this.loggerContext = loggerContext;
            this.logger = logger;
            this.hostingEnvironment = hostingEnvironment;
            this.rootsService = rootsService;
        }

        /// <inheritdoc/>
        public async Task<TempFileLog> UploadFileAsync(IFormFile formFile)
        {
            try
            {
                string saveDirectory = this.hostingEnvironment.GetTempUploadDirectory();
                string resultFileName = FilesFunctions.GetUniqueFileName();
                string resultFileExtension = formFile.FileName.Split('.').LastOrDefault();
                string relativeSaveDirectory = Path.Combine(Folders.PrivateRootFolderName, Folders.UploadFolderName, Folders.TempFolderName);
                string fileFullPath = Path.Combine(saveDirectory, $"{resultFileName}.{resultFileExtension}");
                string fileRelativePath = Path.Combine(relativeSaveDirectory, $"{resultFileName}.{resultFileExtension}");

                using (FileStream stream = System.IO.File.Create(fileFullPath))
                {
                    formFile.CopyTo(stream);
                    stream.Flush();
                }

                TempFileLog fileEntity = new TempFileLog
                {
                    Name = resultFileName,
                    Path = fileRelativePath,
                    FileExtension = FilesFunctions.GetFileExtension(resultFileExtension),
                };
                fileEntity.FileType = FilesFunctions.GetFileType(fileEntity.FileExtension);

                this.loggerContext.TempFileLogs.Add(fileEntity);
                await this.loggerContext.SaveChangesAsync();

                return fileEntity;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return default;
            }
        }

        /// <inheritdoc/>
        public async Task<TempFileLog> UploadFileAsync(IFormFile formFile, string saveDirectory, bool publicRoot = false)
        {
            try
            {
                string rootDirectory = publicRoot ? this.rootsService.PublicRootDirectory : this.rootsService.PrivateRootDirectory;
                string fullSaveDirectory = Path.Combine(rootDirectory, saveDirectory);
                string rootFolderName = publicRoot ? Folders.PublicRootFolderName : Folders.PrivateRootFolderName;
                string resultFileName = FilesFunctions.GetUniqueFileName();
                string resultFileExtension = formFile.FileName.Split('.').LastOrDefault();
                string relativeSaveDirectory = Path.Combine(rootFolderName, saveDirectory);
                string fileFullPath = Path.Combine(fullSaveDirectory, $"{resultFileName}.{resultFileExtension}");
                string fileRelativePath = Path.Combine(relativeSaveDirectory, $"{resultFileName}.{resultFileExtension}");

                using (FileStream stream = System.IO.File.Create(fileFullPath))
                {
                    formFile.CopyTo(stream);
                    stream.Flush();
                }

                TempFileLog fileEntity = new TempFileLog
                {
                    Name = resultFileName,
                    Path = fileRelativePath,
                    FileExtension = FilesFunctions.GetFileExtension(resultFileExtension),
                    Applied = true,
                };
                fileEntity.FileType = FilesFunctions.GetFileType(fileEntity.FileExtension);

                this.loggerContext.TempFileLogs.Add(fileEntity);
                await this.loggerContext.SaveChangesAsync();

                return fileEntity;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return default;
            }
        }
    }
}