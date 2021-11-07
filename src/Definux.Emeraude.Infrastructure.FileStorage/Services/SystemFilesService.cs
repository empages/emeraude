using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Definux.Emeraude.Infrastructure.FileStorage.Common;
using Definux.Emeraude.Infrastructure.FileStorage.Extensions;
using Definux.Emeraude.Infrastructure.FileStorage.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Logging;

namespace Definux.Emeraude.Infrastructure.FileStorage.Services
{
    /// <inheritdoc cref="ISystemFilesService"/>
    public class SystemFilesService : ISystemFilesService
    {
        private readonly ILogger<SystemFilesService> logger;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly IRootsService rootsService;
        private readonly ITemporaryFilesService temporaryFilesService;

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemFilesService"/> class.
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="hostingEnvironment"></param>
        /// <param name="rootsService"></param>
        /// <param name="temporaryFilesService"></param>
        public SystemFilesService(
            ILogger<SystemFilesService> logger,
            IHostingEnvironment hostingEnvironment,
            IRootsService rootsService,
            ITemporaryFilesService temporaryFilesService)
        {
            this.logger = logger;
            this.hostingEnvironment = hostingEnvironment;
            this.rootsService = rootsService;
            this.temporaryFilesService = temporaryFilesService;
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
                this.logger.LogError(ex, "An error occured during folder creation");
                return false;
            }
        }

        /// <inheritdoc/>
        public SystemFileResult GetFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return null;
            }

            SystemFileResult fileSystemResult = new SystemFileResult();
            var fileInfo = new FileInfo(filePath);
            new FileExtensionContentTypeProvider().TryGetContentType(fileInfo.Name, out var contentType);
            fileSystemResult.ContentType = contentType;
            fileSystemResult.Stream = File.OpenRead(filePath);

            return fileSystemResult;
        }

        /// <inheritdoc/>
        public string GetTemporaryFile(Guid id)
        {
            try
            {
                var tempFile = this.temporaryFilesService.GetFile(id);
                if (string.IsNullOrWhiteSpace(tempFile))
                {
                    this.logger.LogWarning("No temporary file is found", id);
                }

                return tempFile;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occured during getting temporary file");
                return default;
            }
        }

        /// <inheritdoc/>
        public IEnumerable<string> GetTemporaryFiles(IEnumerable<Guid> ids)
        {
            try
            {
                List<string> files = new List<string>();
                foreach (var id in ids)
                {
                    this.GetTemporaryFile(id);
                }

                return default;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occured during getting temporary files");
                return new List<string>();
            }
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
        public bool MoveTemporaryFilesToPrivateDirectory(IEnumerable<Guid> ids, string targetDirectory)
        {
            var result = true;
            foreach (var fileId in ids)
            {
                result = result && this.MoveTemporaryFileToDirectory(fileId, targetDirectory, this.rootsService.PrivateRootDirectory);
            }

            return result;
        }

        /// <inheritdoc/>
        public bool MoveTemporaryFilesToPublicDirectory(IEnumerable<Guid> ids, string targetDirectory)
        {
            var result = true;
            foreach (var fileId in ids)
            {
                result = result && this.MoveTemporaryFileToDirectory(fileId, targetDirectory, this.rootsService.PublicRootDirectory);
            }

            return result;
        }

        private bool MoveTemporaryFileToDirectory(Guid fileId, string targetDirectory, string rootFolder)
        {
            try
            {
                var fileName = this.GetTemporaryFile(fileId); // with extension
                var targetFilePath = Path.Combine(targetDirectory, fileName);
                if (!string.IsNullOrWhiteSpace(fileName) && Directory.Exists(targetDirectory) && !File.Exists(targetFilePath))
                {
                    string sourceFilePath = Path.Combine(this.hostingEnvironment.GetTempUploadDirectory(), fileName);
                    File.Move(sourceFilePath, targetFilePath);
                    File.Delete(sourceFilePath);

                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occured during temporary file ");
                return false;
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