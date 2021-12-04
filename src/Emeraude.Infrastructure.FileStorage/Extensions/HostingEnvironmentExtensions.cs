using System.IO;
using Emeraude.Essentials.Base;
using Emeraude.Infrastructure.FileStorage.Common;
using Microsoft.AspNetCore.Hosting;

namespace Emeraude.Infrastructure.FileStorage.Extensions;

/// <summary>
/// Extensions for <see cref="IHostingEnvironment"/>.
/// </summary>
public static class HostingEnvironmentExtensions
{
    /// <summary>
    /// Get temp directory for upload.
    /// </summary>
    /// <param name="hostEnvironment"></param>
    /// <returns></returns>
    public static string GetTempUploadDirectory(this IWebHostEnvironment hostEnvironment)
    {
        return Path.Combine(hostEnvironment.ContentRootPath, EmFolders.PrivateRootFolderName, EmFolders.UploadFolderName, EmFolders.TempFolderName);
    }
}