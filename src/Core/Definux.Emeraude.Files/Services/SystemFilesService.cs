﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Files;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Domain.Logging;
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

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemFilesService"/> class.
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="hostingEnvironment"></param>
        /// <param name="loggerContext"></param>
        public SystemFilesService(
            IEmLogger logger,
            IHostingEnvironment hostingEnvironment,
            ILoggerContext loggerContext)
        {
            this.logger = logger;
            this.hostingEnvironment = hostingEnvironment;
            this.loggerContext = loggerContext;
        }

        /// <inheritdoc/>
        public string PublicRootDirectory => this.hostingEnvironment.WebRootPath;

        /// <inheritdoc/>
        public string PrivateRootDirectory => Path.Combine(this.hostingEnvironment.ContentRootPath, Folders.PrivateRootFolderName);

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

        /// <inheritdoc/>
        public async Task<bool> CreateFolderAsync(string folderName, string folderPath)
        {
            try
            {
                if (!(folderPath.StartsWith(this.PublicRootDirectory) || folderPath.StartsWith(this.PrivateRootDirectory)))
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
            if (!(directory.StartsWith(this.PublicRootDirectory) || directory.StartsWith(this.PrivateRootDirectory)))
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
            return this.ScanDirectory(this.PrivateRootDirectory, this.PrivateRootDirectory);
        }

        /// <inheritdoc/>
        public IEnumerable<SystemItem> ScanPublicDirectory()
        {
            return this.ScanDirectory(this.PublicRootDirectory, this.PublicRootDirectory);
        }

        /// <inheritdoc/>
        public async Task<TempFileLog> UploadFileAsync(IFormFile formFile)
        {
            try
            {
                string saveDirectory = Path.Combine(this.hostingEnvironment.ContentRootPath, Folders.PrivateRootFolderName, Folders.UploadFolderName, Folders.TempFolderName);
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
                string rootDirectory = publicRoot ? this.PublicRootDirectory : this.PrivateRootDirectory;
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

        /// <inheritdoc/>
        public async Task<TempFileLog> ApplyTempFileToPrivateDirectoryAsync(int fileId, string targetDirectory)
        {
            try
            {
                var file = await this.GetFileByIdAsync(fileId);
                var targetFilePath = Path.Combine(targetDirectory, file.NameWithExtension);
                if (file != null && Directory.Exists(targetDirectory) && !File.Exists(targetFilePath))
                {
                    string privateRootTempUploadDirectory = Path.Combine(this.hostingEnvironment.ContentRootPath, Folders.PrivateRootFolderName, Folders.UploadFolderName, Folders.TempFolderName);
                    string sourceFilePath = Path.Combine(privateRootTempUploadDirectory, file.NameWithExtension);
                    File.Move(sourceFilePath, targetFilePath);

                    file.Applied = true;
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

        /// <inheritdoc/>
        public async Task<TempFileLog> ApplyTempFileToPublicDirectoryAsync(int fileId, string targetDirectory)
        {
            try
            {
                var file = await this.GetFileByIdAsync(fileId);
                var targetFilePath = Path.Combine(targetDirectory, file.NameWithExtension);
                if (file != null && Directory.Exists(targetDirectory) && !File.Exists(targetFilePath))
                {
                    string publicRootTempUploadDirectory = Path.Combine(this.hostingEnvironment.ContentRootPath, Folders.PublicRootFolderName);
                    string sourceFilePath = Path.Combine(publicRootTempUploadDirectory, file.NameWithExtension);
                    File.Move(sourceFilePath, targetFilePath);

                    file.Applied = true;
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

        /// <inheritdoc/>
        public List<string> GetPublicRootFolderFilesRelativePaths(params string[] paths)
        {
            try
            {
                var targetPaths = paths.ToList();
                string publicRootPath = this.PublicRootDirectory;
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
    }
}