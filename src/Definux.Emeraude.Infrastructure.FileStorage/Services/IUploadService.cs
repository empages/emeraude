using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Definux.Emeraude.Infrastructure.FileStorage.Services
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
        Task<string> UploadFileAsync(IFormFile formFile);

        /// <summary>
        /// Upload file in specified directory.
        /// </summary>
        /// <param name="formFile"></param>
        /// <param name="saveDirectory"></param>
        /// <param name="publicRoot"></param>
        /// <returns></returns>
        Task<string> UploadFileAsync(IFormFile formFile, string saveDirectory, bool publicRoot = false);
    }
}