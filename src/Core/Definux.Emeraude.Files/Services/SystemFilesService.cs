using System;
using System.Collections.Generic;
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
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Files.Services
{
    /// <inheritdoc cref="ISystemFilesService"/>
    public class SystemFilesService : ISystemFilesService
    {
        private readonly IEmLogger logger;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly ILoggerContext loggerContext;
        private readonly IRootsService rootsService;

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemFilesService"/> class.
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="hostingEnvironment"></param>
        /// <param name="loggerContext"></param>
        /// <param name="rootsService"></param>
        public SystemFilesService(
            IEmLogger logger,
            IHostingEnvironment hostingEnvironment,
            ILoggerContext loggerContext,
            IRootsService rootsService)
        {
            this.logger = logger;
            this.hostingEnvironment = hostingEnvironment;
            this.loggerContext = loggerContext;
            this.rootsService = rootsService;
        }

        /// <inheritdoc/>
        public bool CreateFolder(string folderName, string folderPath)
        {
            try
            {
                return this.CreateFolderAction(folderName, folderPath);
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex);
                return false;
            }
        }

        /// <inheritdoc/>
        public async Task<bool> CreateFolderAsync(string folderName, string folderPath)
        {
            try
            {
                return this.CreateFolderAction(folderName, folderPath);
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return false;
            }
        }

        /// <inheritdoc/>
        public async Task<SystemFileResult> GetFileAsync(string filePath)
        {
            if (File.Exists(filePath))
            {
                SystemFileResult fileSystemResult = new SystemFileResult();
                var fileInfo = new FileInfo(filePath);
                string contentType = string.Empty;
                new FileExtensionContentTypeProvider().TryGetContentType(fileInfo.Name, out contentType);
                fileSystemResult.ContentType = contentType;
                fileSystemResult.Stream = File.OpenRead(filePath);

                return fileSystemResult;
            }

            return null;
        }

        /// <inheritdoc/>
        public async Task<TempFileLog> GetFileByIdAsync(int id)
        {
            try
            {
                var file = await this.loggerContext.TempFileLogs.AsQueryable().FirstOrDefaultAsync(x => x.Id == id);

                return file;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return default;
            }
        }

        /// <inheritdoc/>
        public TempFileLog GetFileById(int id)
        {
            try
            {
                var file = this.loggerContext.TempFileLogs.FirstOrDefault(x => x.Id == id);

                return file;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex);
                return default;
            }
        }

        /// <inheritdoc/>
        public IEnumerable<TempFileLog> GetFilesByIds(IEnumerable<int> ids)
        {
            var resultFiles = new List<TempFileLog>();
            foreach (var fileid in ids)
            {
                var currentFile = this.GetFileById(fileid);
                if (currentFile != null)
                {
                    resultFiles.Add(currentFile);
                }
            }

            return resultFiles;
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<TempFileLog>> GetFilesByIdsAsync(IEnumerable<int> ids)
        {
            var resultFiles = new List<TempFileLog>();
            foreach (var fileid in ids)
            {
                var currentFile = await this.GetFileByIdAsync(fileid);
                if (currentFile != null)
                {
                    resultFiles.Add(currentFile);
                }
            }

            return resultFiles;
        }

        /// <inheritdoc/>
        public IEnumerable<SystemItem> ScanDirectory(string directory, string baseDirectory = "")
        {
            if (!(directory.StartsWith(this.rootsService.PublicRootDirectory) || directory.StartsWith(this.rootsService.PrivateRootDirectory)))
            {
                return null;
            }

            List<SystemItem> fileSystemItems = new List<SystemItem>();
            var files = Directory.GetFiles(directory);
            var folders = Directory.GetDirectories(directory);

            foreach (var folder in folders)
            {
                SystemItem currentFileSystemItem = new SystemItem();
                if (Directory.Exists(folder))
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(folder);
                    currentFileSystemItem.Type = FileSystemItemType.Folder;
                    currentFileSystemItem.Name = directoryInfo.Name;
                    currentFileSystemItem.Path = folder;
                    currentFileSystemItem.RelativePath = folder.Replace(baseDirectory, string.Empty);
                    currentFileSystemItem.CreatedOn = directoryInfo.CreationTime;
                    currentFileSystemItem.LastModifiedOn = directoryInfo.LastWriteTime;
                }

                fileSystemItems.Add(currentFileSystemItem);
            }

            foreach (var file in files)
            {
                SystemItem currentFileSystemItem = new SystemItem();
                if (File.Exists(file))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    currentFileSystemItem.Type = FileSystemItemType.File;
                    currentFileSystemItem.Name = fileInfo.Name;
                    currentFileSystemItem.Path = file;
                    currentFileSystemItem.RelativePath = file.Replace(baseDirectory, string.Empty);
                    currentFileSystemItem.FileSize = fileInfo.Length;
                    currentFileSystemItem.CreatedOn = fileInfo.CreationTime;
                    currentFileSystemItem.LastModifiedOn = fileInfo.LastWriteTime;
                }

                fileSystemItems.Add(currentFileSystemItem);
            }

            return fileSystemItems;
        }

        /// <inheritdoc/>
        public IEnumerable<SystemItem> ScanPrivateDirectory()
        {
            return this.ScanDirectory(this.rootsService.PrivateRootDirectory, this.rootsService.PrivateRootDirectory);
        }

        /// <inheritdoc/>
        public IEnumerable<SystemItem> ScanPublicDirectory()
        {
            return this.ScanDirectory(this.rootsService.PublicRootDirectory, this.rootsService.PublicRootDirectory);
        }

        /// <inheritdoc/>
        public async Task<TempFileLog> ApplyTempFileToPrivateDirectoryAsync(int fileId, string targetDirectory)
        {
            return await this.ApplyTempFileToDirectoryAsync(fileId, targetDirectory, Folders.PrivateRootFolderName);
        }

        /// <inheritdoc/>
        public async Task<TempFileLog> ApplyTempFileToPublicDirectoryAsync(int fileId, string targetDirectory)
        {
            return await this.ApplyTempFileToDirectoryAsync(fileId, targetDirectory, Folders.PublicRootFolderName);
        }

        /// <inheritdoc/>
        public List<string> GetPublicRootFolderFilesRelativePaths(params string[] paths)
        {
            try
            {
                var targetPaths = paths.ToList();
                string publicRootPath = this.rootsService.PublicRootDirectory;
                targetPaths.Insert(0, publicRootPath);
                string folderPath = Path.Combine(targetPaths.ToArray());
                List<string> resultFiles = Directory
                    .GetFiles(folderPath, "*", SearchOption.TopDirectoryOnly)
                    .Select(x => x.Replace(publicRootPath, string.Empty).Replace(Path.DirectorySeparatorChar, '/'))
                    .ToList();

                return resultFiles;
            }
            catch (Exception)
            {
                return new List<string>();
            }
        }

        /// <inheritdoc/>
        public async Task<bool> ApplyTempFilesToPrivateDirectoryAsync(IEnumerable<int> ids, string targetDirectory)
        {
            try
            {
                foreach (var fileId in ids)
                {
                    await this.ApplyTempFileToPrivateDirectoryAsync(fileId, targetDirectory);
                }

                return true;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return false;
            }
        }

        /// <inheritdoc/>
        public async Task<bool> ApplyTempFilesToPublicDirectoryAsync(IEnumerable<int> ids, string targetDirectory)
        {
            try
            {
                foreach (var fileId in ids)
                {
                    await this.ApplyTempFileToPublicDirectoryAsync(fileId, targetDirectory);
                }

                return true;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return false;
            }
        }

        private async Task<TempFileLog> ApplyTempFileToDirectoryAsync(int fileId, string targetDirectory, string rootFolder)
        {
            try
            {
                var file = await this.GetFileByIdAsync(fileId);
                var targetFilePath = Path.Combine(targetDirectory, file.NameWithExtension);
                if (file != null && Directory.Exists(targetDirectory) && !File.Exists(targetFilePath))
                {
                    string sourceFilePath = Path.Combine(this.hostingEnvironment.GetTempUploadDirectory(), file.NameWithExtension);
                    File.Move(sourceFilePath, targetFilePath);

                    file.Applied = true;
                    file.Path = Path.Combine(rootFolder, targetFilePath);

                    this.loggerContext.TempFileLogs.Update(file);
                    await this.loggerContext.SaveChangesAsync();

                    File.Delete(sourceFilePath);

                    return file;
                }

                return default;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return default;
            }
        }

        private bool CreateFolderAction(string folderName, string folderPath)
        {
            if (!(folderPath.StartsWith(this.rootsService.PublicRootDirectory) || folderPath.StartsWith(this.rootsService.PrivateRootDirectory)))
            {
                return false;
            }

            string newFolderPath = Path.Combine(folderPath, folderName);

            if (Directory.Exists(newFolderPath))
            {
                return false;
            }

            Directory.CreateDirectory(newFolderPath);

            return true;
        }
    }
}