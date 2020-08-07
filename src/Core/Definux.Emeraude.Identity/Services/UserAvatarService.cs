using Definux.Emeraude.Application.Common.Interfaces.Files;
using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Emeraude.Application.Common.Interfaces.Persistence;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Identity.Entities;
using Definux.Emeraude.Resources;
using Definux.Utilities.Functions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Definux.Emeraude.Identity.Services
{
    public class UserAvatarService : IUserAvatarService
    {
        private readonly ILogger logger;
        private readonly IEmContext context;
        private readonly UserManager<User> userManager;
        private readonly IHostingEnvironment hostEnvironment;
        private readonly ISystemFilesService systemFilesService;

        public UserAvatarService(
            IEmContext context,
            UserManager<User> userManager,
            IHostingEnvironment hostEnvironment,
            ISystemFilesService systemFilesService)
        {
            this.context = context;
            this.userManager = userManager;
            this.hostEnvironment = hostEnvironment;
            this.systemFilesService = systemFilesService;
        }
        
        public async Task ApplyAvatarToUserAsync(Guid userId, string avatarUrl)
        {
            try
            {
                var user = await this.userManager.FindByIdAsync(userId.ToString());
                if (user != null)
                {
                    user.AvatarUrl = avatarUrl;
                    this.context.Set<User>().Update(user);

                    await this.context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
            }
        }

        public async Task<string> CreateAvatarFromUrlAsync(string externalSourceAvatarUrl)
        {
            try
            {
                string targetFileDirectoryPath = this.systemFilesService.GetPathFromPublicRoot(Folders.UploadFolderName, Folders.ImagesFolderName);
                string avatarName = FilesFunctions.GetUniqueFileName();
                string avatarNameWithExtension = $"{avatarName}.jpg";
                string targetFilePath = Path.Combine(targetFileDirectoryPath, avatarNameWithExtension);

                using (var client = new HttpClient())
                using (var response = await client.GetAsync(externalSourceAvatarUrl))
                using (Stream stream = await response.Content.ReadAsStreamAsync())
                using (FileStream fileStream = System.IO.File.Create(targetFilePath))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        stream.CopyTo(fileStream);

                        return $"/{Folders.UploadFolderName}/{Folders.ImagesFolderName}/{avatarNameWithExtension}";
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return null;
            }
        }

        public async Task<string> CreateUserAvatarAsync(byte[] avatarFileByteArray)
        {
            try
            {
                string avatarRelativePath = Path.Combine(Folders.UploadFolderName, Folders.ImagesFolderName);
                string targetFileDirectoryPath = Path.Combine(this.hostEnvironment.ContentRootPath, Folders.PublicRootFolderName, avatarRelativePath);
                string avatarName = FilesFunctions.GetUniqueFileName();
                string avatarNameWithExtension = $"{avatarName}.jpg";
                string targetFilePath = Path.Combine(targetFileDirectoryPath, avatarNameWithExtension);

                using (Stream stream = new MemoryStream(avatarFileByteArray))
                using (FileStream fileStream = System.IO.File.Create(targetFilePath))
                {
                    stream.CopyTo(fileStream);

                    return $"/{Folders.UploadFolderName}/{Folders.ImagesFolderName}/{avatarNameWithExtension}";
                }
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return null;
            }
        }

        public string GetUserAvatarRelativePath(IUser user)
        {
            return ((User)user)?.AvatarRelativePath;
        }
    }
}
