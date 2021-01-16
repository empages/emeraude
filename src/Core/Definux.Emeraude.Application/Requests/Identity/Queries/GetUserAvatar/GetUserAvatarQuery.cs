using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Files;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Application.Logger;
using MediatR;
using Microsoft.AspNetCore.Hosting;

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
            private readonly IEmLogger logger;

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
                IEmLogger logger)
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
                        result.Avatar = await this.systemFilesService.GetFileAsync(avatarPath);
                        if (result.Avatar == null)
                        {
                            result = this.GetDefaultAvatarResult();
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
                    await this.logger.LogErrorAsync(ex);
                    return this.GetDefaultAvatarResult();
                }
            }

            private GetUserAvatarResult GetDefaultAvatarResult()
            {
                return new GetUserAvatarResult
                {
                    Avatar = new SystemFileResult
                    {
                        Stream = new MemoryStream(Resources.Images.default_avatar),
                        ContentType = "image/png",
                    },
                    IsDefault = true,
                };
            }
        }
    }
}
