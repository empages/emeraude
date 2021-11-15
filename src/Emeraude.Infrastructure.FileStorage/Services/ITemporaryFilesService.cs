using System;

namespace Emeraude.Infrastructure.FileStorage.Services
{
    /// <summary>
    /// Temporary files service that provides functionalities for access and save files references to the cache memory.
    /// </summary>
    public interface ITemporaryFilesService
    {
        /// <summary>
        /// Gets a file from the cache.
        /// </summary>
        /// <param name="fileId"></param>
        /// <returns></returns>
        string GetFile(Guid fileId);

        /// <summary>
        /// Save a file into the cache.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        Guid SaveFile(string filePath);

        /// <summary>
        /// Deletes a file from the cache.
        /// </summary>
        /// <param name="fileId"></param>
        void DeleteFile(Guid fileId);
    }
}