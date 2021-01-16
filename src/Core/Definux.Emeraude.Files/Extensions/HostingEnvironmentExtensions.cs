using System.IO;
using System.Linq;
using Definux.Emeraude.Resources;
using Microsoft.AspNetCore.Hosting;

namespace Definux.Emeraude.Files.Extensions
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
            return Path.Combine(hostingEnvironment.ContentRootPath, Folders.PrivateRootFolderName, Folders.UploadFolderName, Folders.TempFolderName);
        }
    }
}