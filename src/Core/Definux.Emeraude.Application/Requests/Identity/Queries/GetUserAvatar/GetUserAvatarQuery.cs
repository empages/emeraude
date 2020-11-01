using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Files;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Application.Logger;
using MediatR;

namespace Definux.Emeraude.Application.Requests.Identity.Queries.GetUserAvatar
{
    /// <summary>
    /// Query that returns the avatar stream of specified user.
    /// </summary>
    public class GetUserAvatarQuery : IRequest<SystemFileResult>
    {
        /// <summary>
        /// Id of the user.
        /// </summary>
        public Guid UserId { get; set; }

        /// <inheritdoc/>
        public class GetUserAvatarQueryHandler : IRequestHandler<GetUserAvatarQuery, SystemFileResult>
        {
            private readonly ISystemFilesService systemFilesService;
            private readonly IUserManager userManager;
            private readonly IUserAvatarService userAvatarService;
            private readonly IEmLogger logger;

            /// <summary>
            /// Initializes a new instance of the <see cref="GetUserAvatarQueryHandler"/> class.
            /// </summary>
            /// <param name="systemFilesService"></param>
            /// <param name="userManager"></param>
            /// <param name="userAvatarService"></param>
            /// <param name="logger"></param>
            public GetUserAvatarQueryHandler(
                ISystemFilesService systemFilesService,
                IUserManager userManager,
                IUserAvatarService userAvatarService,
                IEmLogger logger)
            {
                this.systemFilesService = systemFilesService;
                this.userManager = userManager;
                this.userAvatarService = userAvatarService;
                this.logger = logger;
            }

            /// <inheritdoc/>
            public async Task<SystemFileResult> Handle(GetUserAvatarQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var user = await this.userManager.FindUserByIdAsync(request.UserId);

                    SystemFileResult avatarFileResult = null;
                    if (user != null && !string.IsNullOrEmpty(user.AvatarUrl))
                    {
                        string userAvatarRelativePath = this.userAvatarService.GetUserAvatarRelativePath(user);
                        string avatarPath = this.systemFilesService.GetPathFromPublicRoot(userAvatarRelativePath.Substring(1));
                        avatarFileResult = await this.systemFilesService.GetFileAsync(avatarPath);
                        if (avatarFileResult == null)
                        {
                            avatarFileResult = this.GetDefaultAvatarResult();
                        }
                    }
                    else
                    {
                        avatarFileResult = this.GetDefaultAvatarResult();
                    }

                    return avatarFileResult;
                }
                catch (Exception ex)
                {
                    await this.logger.LogErrorAsync(ex);
                    return this.GetDefaultAvatarResult();
                }
            }

            private SystemFileResult GetDefaultAvatarResult()
            {
                return new SystemFileResult
                {
                    Stream = new MemoryStream(Resources.Images.default_avatar),
                    ContentType = "image/png",
                };
            }
        }
    }
}
