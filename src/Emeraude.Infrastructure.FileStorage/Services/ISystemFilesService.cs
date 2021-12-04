using System;
using System.Collections.Generic;
using Emeraude.Infrastructure.FileStorage.Models;

namespace Emeraude.Infrastructure.FileStorage.Services;

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
    /// <param name="baseDirectory">Must be <see cref="IRootsService.PublicRootDirectory"/> or <see cref="IRootsService.PrivateRootDirectory"/>.</param>
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
    /// Get system file by file path.
    /// </summary>
    /// <param name="filePath"></param>
    /// <returns></returns>
    SystemFileResult GetFile(string filePath);

    /// <summary>
    /// Get temporary file stored in the memory cache.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    string GetTemporaryFile(Guid id);

    /// <summary>
    /// Get temporary files stored in the memory cache.
    /// </summary>
    /// <param name="ids"></param>
    /// <returns></returns>
    IEnumerable<string> GetTemporaryFiles(IEnumerable<Guid> ids);

    /// <summary>
    /// Apply temporary file into specified private root directory.
    /// </summary>
    /// <param name="fileId"></param>
    /// <param name="targetDirectory"></param>
    /// <returns></returns>
    bool MoveTemporaryFileToPrivateDirectory(Guid fileId, string targetDirectory);

    /// <summary>
    /// Apply temporary files into specified private root directory.
    /// </summary>
    /// <param name="ids"></param>
    /// <param name="targetDirectory"></param>
    /// <returns></returns>
    bool MoveTemporaryFilesToPrivateDirectory(IEnumerable<Guid> ids, string targetDirectory);

    /// <summary>
    /// Apply temporary file into specified public root directory.
    /// </summary>
    /// <param name="fileId"></param>
    /// <param name="targetDirectory"></param>
    /// <returns></returns>
    bool MoveTemporaryFileToPublicDirectory(Guid fileId, string targetDirectory);

    /// <summary>
    /// Apply temporary files into specified public root directory.
    /// </summary>
    /// <param name="ids"></param>
    /// <param name="targetDirectory"></param>
    /// <returns></returns>
    bool MoveTemporaryFilesToPublicDirectory(IEnumerable<Guid> ids, string targetDirectory);

    /// <summary>
    /// Create folder.
    /// </summary>
    /// <param name="folderName"></param>
    /// <param name="folderPath"></param>
    /// <returns></returns>
    bool CreateFolder(string folderName, string folderPath);
}