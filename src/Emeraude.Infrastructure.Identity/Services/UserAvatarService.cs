using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Emeraude.Contracts;
using Emeraude.Essentials.Base;
using Emeraude.Essentials.Helpers;
using Emeraude.Infrastructure.FileStorage.Common;
using Emeraude.Infrastructure.FileStorage.Services;
using Emeraude.Infrastructure.Identity.Entities;
using Emeraude.Infrastructure.Identity.Persistence;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace Emeraude.Infrastructure.Identity.Services
{
    /// <inheritdoc cref="IUserAvatarService"/>
    public class UserAvatarService : IUserAvatarService
    {
        private readonly IIdentityContext context;
        private readonly UserManager<User> userManager;
        private readonly IWebHostEnvironment hostEnvironment;
        private readonly ISystemFilesService systemFilesService;
        private readonly IRootsService rootsService;
        private readonly ILogger<UserAvatarService> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAvatarService"/> class.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="userManager"></param>
        /// <param name="hostEnvironment"></param>
        /// <param name="systemFilesService"></param>
        /// <param name="rootsService"></param>
        /// <param name="logger"></param>
        public UserAvatarService(
            IIdentityContext context,
            UserManager<User> userManager,
            IWebHostEnvironment hostEnvironment,
            ISystemFilesService systemFilesService,
            IRootsService rootsService,
            ILogger<UserAvatarService> logger)
        {
            this.context = context;
            this.userManager = userManager;
            this.hostEnvironment = hostEnvironment;
            this.systemFilesService = systemFilesService;
            this.rootsService = rootsService;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public async Task ApplyAvatarToUserAsync(Guid userId, string avatarUrl)
        {
            try
            {
                var user = await this.userManager.FindByIdAsync(userId.ToString());
                if (user != null)
                {
                    user.AvatarUrl = avatarUrl;
                    await this.userManager.UpdateAsync(user);
                }
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occured during applying avatar to a user");
            }
        }

        /// <inheritdoc/>
        public async Task<string> CreateAvatarFromUrlAsync(string externalSourceAvatarUrl)
        {
            try
            {
                string targetFileDirectoryPath = this.rootsService.GetPathFromPublicRoot(EmFolders.UploadFolderName, EmFolders.ImagesFolderName);
                string avatarName = FilesUtilities.GetUniqueFileName();
                string avatarNameWithExtension = $"{avatarName}.jpg";
                string targetFilePath = Path.Combine(targetFileDirectoryPath, avatarNameWithExtension);

                using (var client = new HttpClient())
                using (var response = await client.GetAsync(externalSourceAvatarUrl))
                using (Stream stream = await response.Content.ReadAsStreamAsync())
                using (FileStream fileStream = System.IO.File.Create(targetFilePath))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        await stream.CopyToAsync(fileStream);

                        return $"/{EmFolders.UploadFolderName}/{EmFolders.ImagesFolderName}/{avatarNameWithExtension}";
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occured during applying avatar to a user");
                return null;
            }
        }

        /// <inheritdoc/>
        public async Task<string> CreateUserAvatarAsync(byte[] avatarFileByteArray)
        {
            try
            {
                string avatarRelativePath = Path.Combine(EmFolders.UploadFolderName, EmFolders.ImagesFolderName);
                string targetFileDirectoryPath = Path.Combine(this.hostEnvironment.ContentRootPath, EmFolders.PublicRootFolderName, avatarRelativePath);
                string avatarName = FilesUtilities.GetUniqueFileName();
                string avatarNameWithExtension = $"{avatarName}.jpg";
                string targetFilePath = Path.Combine(targetFileDirectoryPath, avatarNameWithExtension);

                using (Stream stream = new MemoryStream(avatarFileByteArray))
                using (FileStream fileStream = System.IO.File.Create(targetFilePath))
                {
                    await stream.CopyToAsync(fileStream);

                    return $"/{EmFolders.UploadFolderName}/{EmFolders.ImagesFolderName}/{avatarNameWithExtension}";
                }
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occured during creating user avatar");
                return null;
            }
        }

        /// <inheritdoc/>
        public string GetUserAvatarRelativePath(IUser user)
        {
            return ((User)user)?.AvatarRelativePath;
        }
    }
}
