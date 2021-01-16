using System.Threading.Tasks;
using Definux.Emeraude.Domain.Logging;
using Microsoft.AspNetCore.Http;

namespace Definux.Emeraude.Application.Files
{
    /// <summary>
    /// Service that supports upload functionality of the files infrastructure.
    /// </summary>
    public interface IUploadService
    {
        /// <summary>
        /// Upload file as a temp file in private root.
        /// </summary>
        /// <param name="formFile"></param>
        /// <returns></returns>
        Task<TempFileLog> UploadFileAsync(IFormFile formFile);

        /// <summary>
        /// Upload file in specified directory.
        /// </summary>
        /// <param name="formFile"></param>
        /// <param name="saveDirectory"></param>
        /// <param name="publicRoot"></param>
        /// <returns></returns>
        Task<TempFileLog> UploadFileAsync(IFormFile formFile, string saveDirectory, bool publicRoot = false);
    }
}