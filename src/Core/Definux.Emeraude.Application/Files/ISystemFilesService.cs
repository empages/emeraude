using System.Collections.Generic;
using System.Threading.Tasks;
using Definux.Emeraude.Domain.Logging;
using Microsoft.AspNetCore.Http;

namespace Definux.Emeraude.Application.Files
{
    /// <summary>
    /// System files service that access and process files and folders from the public and private root of the system.
    /// </summary>
    public interface ISystemFilesService
    {
        /// <summary>
        /// Get public root files with its relative paths from a path.
        /// </summary>
        /// <param name="paths"></param>
        /// <returns></returns>
        List<string> GetPublicRootFolderFilesRelativePaths(params string[] paths);

        /// <summary>
        /// Scan directory (public or private roots) for system items.
        /// </summary>
        /// <param name="directory"></param>
        /// <param name="baseDirectory">Must be <see cref="PublicRootDirectory"/> or <see cref="PrivateRootDirectory"/>.</param>
        /// <returns></returns>
        IEnumerable<SystemItem> ScanDirectory(string directory, string baseDirectory = "");

        /// <summary>
        /// Scan public root directory for system items.
        /// </summary>
        /// <returns></returns>
        IEnumerable<SystemItem> ScanPublicDirectory();

        /// <summary>
        /// Scan private root directory for system items.
        /// </summary>
        /// <returns></returns>
        IEnumerable<SystemItem> ScanPrivateDirectory();

        /// <summary>
        /// Get system file by file bath.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        Task<SystemFileResult> GetFileAsync(string filePath);

        /// <summary>
        /// Get file (<see cref="TempFileLog"/>) by temp file log id (async execution).
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TempFileLog> GetFileByIdAsync(int id);

        /// <summary>
        /// Get file (<see cref="TempFileLog"/>) by temp file log id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TempFileLog GetFileById(int id);

        /// <summary>
        /// Get files (<see cref="TempFileLog"/>) by temp file log ids.
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        IEnumerable<TempFileLog> GetFilesByIds(IEnumerable<int> ids);

        /// <summary>
        /// Get files (<see cref="TempFileLog"/>) by temp file log ids (async execution).
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task<IEnumerable<TempFileLog>> GetFilesByIdsAsync(IEnumerable<int> ids);

        /// <summary>
        /// Apply temp file (<see cref="TempFileLog"/>) into specified private root directory (async execution).
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="targetDirectory"></param>
        /// <returns></returns>
        Task<TempFileLog> ApplyTempFileToPrivateDirectoryAsync(int fileId, string targetDirectory);

        /// <summary>
        /// Apply temp file (<see cref="TempFileLog"/>) into specified public root directory (async execution).
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="targetDirectory"></param>
        /// <returns></returns>
        Task<TempFileLog> ApplyTempFileToPublicDirectoryAsync(int fileId, string targetDirectory);

        /// <summary>
        /// Apply temp files (<see cref="TempFileLog"/>) into specified private root directory (async execution).
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="targetDirectory"></param>
        /// <returns></returns>
        Task<bool> ApplyTempFilesToPrivateDirectoryAsync(IEnumerable<int> ids, string targetDirectory);

        /// <summary>
        /// Apply temp files (<see cref="TempFileLog"/>) into specified public root directory (async execution).
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="targetDirectory"></param>
        /// <returns></returns>
        Task<bool> ApplyTempFilesToPublicDirectoryAsync(IEnumerable<int> ids, string targetDirectory);

        /// <summary>
        /// Create folder.
        /// </summary>
        /// <param name="folderName"></param>
        /// <param name="folderPath"></param>
        /// <returns></returns>
        Task<bool> CreateFolderAsync(string folderName, string folderPath);
    }
}
