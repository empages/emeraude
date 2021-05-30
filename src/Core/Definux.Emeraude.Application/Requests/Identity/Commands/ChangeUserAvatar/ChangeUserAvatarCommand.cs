using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Application.Logger;
using Definux.Utilities.Objects;
using MediatR;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserAvatar
{
    /// <summary>
    /// Command that change the user avatar.
    /// </summary>
    public class ChangeUserAvatarCommand : IRequest<SimpleResult>
    {
        /// <summary>
        /// User avatar image in base64 format.
        /// </summary>
        public string AvatarFileBase64 { get; set; }

        /// <summary>
        /// Id of the user.
        /// </summary>
        public Guid? UserId { get; set; }

        /// <inheritdoc/>
        public class ChangeUserAvatarCommandHandler : IRequestHandler<ChangeUserAvatarCommand, SimpleResult>
        {
            private readonly IUserAvatarService userAvatarService;
            private readonly IEmLogger logger;

            /// <summary>
            /// Initializes a new instance of the <see cref="ChangeUserAvatarCommandHandler"/> class.
            /// </summary>
            /// <param name="userAvatarService"></param>
            /// <param name="logger"></param>
            public ChangeUserAvatarCommandHandler(IUserAvatarService userAvatarService, IEmLogger logger)
            {
                this.userAvatarService = userAvatarService;
                this.logger = logger;
            }

            /// <inheritdoc/>
            public async Task<SimpleResult> Handle(ChangeUserAvatarCommand request, CancellationToken cancellationToken)
            {
                try
                {
                    if (request.UserId.HasValue)
                    {
                        string avatarUrl = null;
                        if (!string.IsNullOrWhiteSpace(request.AvatarFileBase64))
                        {
                            byte[] avatarBytes = Convert.FromBase64String(request.AvatarFileBase64.Substring(request.AvatarFileBase64.IndexOf(',') + 1));
                            avatarUrl = await this.userAvatarService.CreateUserAvatarAsync(avatarBytes);
                        }

                        await this.userAvatarService.ApplyAvatarToUserAsync(request.UserId.Value, avatarUrl);
                        return SimpleResult.SuccessfulResult;
                    }

                    return SimpleResult.UnsuccessfulResult;
                }
                catch (Exception ex)
                {
                    await this.logger.LogErrorAsync(ex);
                    return SimpleResult.UnsuccessfulResult;
                }
            }
        }
    }
}