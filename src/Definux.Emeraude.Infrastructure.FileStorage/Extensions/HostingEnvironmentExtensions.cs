using System.IO;
using Definux.Emeraude.Essentials.Base;
using Microsoft.AspNetCore.Hosting;

namespace Definux.Emeraude.Infrastructure.FileStorage.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IHostingEnvironment"/>.
    /// </summary>
    public static class HostingEnvironmentExtensions
    {
        /// <summary>
        /// Get temp directory for upload.
        /// </summary>
        /// <param name="hostingEnvironment"></param>
        /// <returns></returns>
        public static string GetTempUploadDirectory(this IHostingEnvironment hostingEnvironment)
        {
            return Path.Combine(hostingEnvironment.ContentRootPath, EmFolders.PrivateRootFolderName, EmFolders.UploadFolderName, EmFolders.TempFolderName);
        }
    }
}