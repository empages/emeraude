using Definux.Emeraude.Application.Common.Interfaces.Files;
using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Emeraude.Application.Common.Results.Files;
using Definux.Emeraude.Domain.Logging;
using Definux.Emeraude.Resources;
using Definux.Utilities.Functions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Definux.Emeraude.Files.Services
{
    public class SystemFilesService : ISystemFilesService
    {
        private readonly ILogger logger;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly ILoggerContext loggerContext;

        public SystemFilesService(
            ILogger logger,
            IHostingEnvironment hostingEnvironment,
            ILoggerContext loggerContext)
        {
            this.logger = logger;
            this.hostingEnvironment = hostingEnvironment;
            this.loggerContext = loggerContext;
        }

        public string PublicRootDirectory => this.hostingEnvironment.WebRootPath;

        public string PrivateRootDirectory => Path.Combine(this.hostingEnvironment.ContentRootPath, Folders.PrivateRootFolderName);

        public string GetPathFromPublicRoot(params string[] paths)
        {
            var resultPaths = paths.ToList();
            resultPaths.Insert(0, PublicRootDirectory);

            return Path.Combine(resultPaths.ToArray());
        }

        public string GetPathFromPrivateRoot(params string[] paths)
        {
            var resultPaths = paths.ToList();
            resultPaths.Insert(0, PrivateRootDirectory);

            return Path.Combine(resultPaths.ToArray());
        }

        public async Task<bool> CreateFolderAsync(string folderName, string folderPath)
        {
            try
            {
                if (!(folderPath.StartsWith(PublicRootDirectory) || folderPath.StartsWith(PrivateRootDirectory)))
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

        public IEnumerable<SystemFileItem> ScanDirectory(string directory, string baseDirectory = "")
        {
            if (!(directory.StartsWith(PublicRootDirectory) || directory.StartsWith(PrivateRootDirectory)))
            {
                return null;
            }

            List<SystemFileItem> fileSystemItems = new List<SystemFileItem>();
            var files = Directory.GetFiles(directory);
            var folders = Directory.GetDirectories(directory);

            foreach (var folder in folders)
            {
                SystemFileItem currentFileSystemItem = new SystemFileItem();
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
                SystemFileItem currentFileSystemItem = new SystemFileItem();
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

        public IEnumerable<SystemFileItem> ScanPrivateDirectory()
        {
            return ScanDirectory(PrivateRootDirectory, PrivateRootDirectory);
        }

        public IEnumerable<SystemFileItem> ScanPublicDirectory()
        {
            return ScanDirectory(PublicRootDirectory, PublicRootDirectory);
        }

        public async Task<TempFileLog> UploadFileAsync(IFormFile formFile)
        {
            try
            {
                string saveDirectory = Path.Combine(hostingEnvironment.ContentRootPath, Folders.PrivateRootFolderName, Folders.UploadFolderName, Folders.TempFolderName);
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
                    FileExtension = FilesFunctions.GetFileExtension(resultFileExtension)
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

        public async Task<TempFileLog> UploadFileAsync(IFormFile formFile, string saveDirectory, bool publicRoot = false)
        {
            try
            {
                string rootDirectory = publicRoot ? PublicRootDirectory : PrivateRootDirectory;
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
                    Applied = true
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

        public async Task<TempFileLog> MoveFileToPrivateDirectoryAsync(int fileId, string targetDirectory)
        {
            try
            {
                var file = await GetFileByIdAsync(fileId);
                var targetFilePath = Path.Combine(targetDirectory, file.NameWithExtension);
                if (file != null && Directory.Exists(targetDirectory) && !File.Exists(targetFilePath))
                {
                    string privateRootTempUploadDirectory = Path.Combine(hostingEnvironment.ContentRootPath, Folders.PrivateRootFolderName, Folders.UploadFolderName, Folders.TempFolderName);
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

        public async Task<TempFileLog> MoveFileToPublicDirectoryAsync(int fileId, string targetDirectory)
        {
            try
            {
                var file = await GetFileByIdAsync(fileId);
                var targetFilePath = Path.Combine(targetDirectory, file.NameWithExtension);
                if (file != null && Directory.Exists(targetDirectory) && !File.Exists(targetFilePath))
                {
                    string publicRootTempUploadDirectory = Path.Combine(hostingEnvironment.ContentRootPath, Folders.PublicRootFolderName);
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

        public List<string> GetPublicRootFolderFilesRelativePaths(params string[] paths)
        {
            try
            {
                var targetPaths = paths.ToList();
                string publicRootPath = PublicRootDirectory;
                targetPaths.Insert(0, publicRootPath);
                string folderPath = Path.Combine(targetPaths.ToArray());
                List<string> resultPictures = Directory
                    .GetFiles(folderPath, "*", SearchOption.TopDirectoryOnly)
                    .Select(x => x.Replace(publicRootPath, string.Empty).Replace(Path.DirectorySeparatorChar, '/'))
                    .ToList();

                return resultPictures;
            }
            catch (Exception)
            {
                return new List<string>();
            }
        }
    }
}
