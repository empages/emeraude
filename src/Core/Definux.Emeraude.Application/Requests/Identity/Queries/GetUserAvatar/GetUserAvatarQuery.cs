using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Files;
using Definux.Emeraude.Application.Identity;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Definux.Emeraude.Application.Requests.Identity.Queries.GetUserAvatar
{
    /// <summary>
    /// Query that returns the avatar stream of specified user.
    /// </summary>
    public class GetUserAvatarQuery : IRequest<GetUserAvatarResult>
    {
        /// <summary>
        /// Id of the user.
        /// </summary>
        public Guid UserId { get; set; }

        /// <inheritdoc/>
        public class GetUserAvatarQueryHandler : IRequestHandler<GetUserAvatarQuery, GetUserAvatarResult>
        {
            private readonly ISystemFilesService systemFilesService;
            private readonly IUserManager userManager;
            private readonly IUserAvatarService userAvatarService;
            private readonly IRootsService rootsService;
            private readonly ILogger<GetUserAvatarQueryHandler> logger;

            /// <summary>
            /// Initializes a new instance of the <see cref="GetUserAvatarQueryHandler"/> class.
            /// </summary>
            /// <param name="systemFilesService"></param>
            /// <param name="userManager"></param>
            /// <param name="userAvatarService"></param>
            /// <param name="rootsService"></param>
            /// <param name="logger"></param>
            public GetUserAvatarQueryHandler(
                ISystemFilesService systemFilesService,
                IUserManager userManager,
                IUserAvatarService userAvatarService,
                IRootsService rootsService,
                ILogger<GetUserAvatarQueryHandler> logger)
            {
                this.systemFilesService = systemFilesService;
                this.userManager = userManager;
                this.userAvatarService = userAvatarService;
                this.rootsService = rootsService;
                this.logger = logger;
            }

            /// <inheritdoc/>
            public async Task<GetUserAvatarResult> Handle(GetUserAvatarQuery request, CancellationToken cancellationToken)
            {
                GetUserAvatarResult result = new GetUserAvatarResult();
                try
                {
                    var user = await this.userManager.FindUserByIdAsync(request.UserId);

                    if (user != null && !string.IsNullOrEmpty(user.AvatarUrl))
                    {
                        string userAvatarRelativePath = this.userAvatarService.GetUserAvatarRelativePath(user);
                        string avatarPath = this.rootsService.GetPathFromPublicRoot(userAvatarRelativePath.Substring(1));
                        var avatarFileResult = this.systemFilesService.GetFile(avatarPath);
                        if (avatarFileResult == null)
                        {
                            result = this.GetDefaultAvatarResult();
                        }
                        else
                        {
                            result.Avatar = this.ConvertStreamToAvatarValue(avatarFileResult.Stream);
                        }
                    }
                    else
                    {
                        result = this.GetDefaultAvatarResult();
                    }

                    return result;
                }
                catch (Exception ex)
                {
                    this.logger.LogError(ex, "Get user avatar query fails");
                    return this.GetDefaultAvatarResult();
                }
            }

            private GetUserAvatarResult GetDefaultAvatarResult()
            {
                return new GetUserAvatarResult
                {
                    Avatar = this.ConvertStreamToAvatarValue(new MemoryStream(Resources.Images.default_avatar)),
                    IsDefault = true,
                };
            }

            private UserAvatarValue ConvertStreamToAvatarValue(Stream stream)
            {
                byte[] bytes;
                using (var memoryStream = new MemoryStream())
                {
                    stream.CopyTo(memoryStream);
                    bytes = memoryStream.ToArray();
                }

                return new UserAvatarValue
                {
                    Value = Convert.ToBase64String(bytes),
                };
            }
        }
    }
}
