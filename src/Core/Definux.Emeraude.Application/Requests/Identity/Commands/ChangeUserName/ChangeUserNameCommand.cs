using System;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserAvatar;
using Definux.Utilities.Objects;
using MediatR;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserName
{
    /// <summary>
    /// Command that change the user's name.
    /// </summary>
    public class ChangeUserNameCommand : IRequest<SimpleResult>
    {
        /// <summary>
        /// Id of the user.
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        /// New name of the user.
        /// </summary>
        public string NewName { get; set; }

        /// <inheritdoc/>
        public class ChangeUserNameCommandHandler : IRequestHandler<ChangeUserNameCommand, SimpleResult>
        {
            private readonly IUserManager userManager;
            private readonly IEmLogger logger;

            /// <summary>
            /// Initializes a new instance of the <see cref="ChangeUserNameCommandHandler"/> class.
            /// </summary>
            /// <param name="userManager"></param>
            /// <param name="logger"></param>
            public ChangeUserNameCommandHandler(IUserManager userManager, IEmLogger logger)
            {
                this.userManager = userManager;
                this.logger = logger;
            }

            /// <inheritdoc/>
            public async Task<SimpleResult> Handle(ChangeUserNameCommand request, CancellationToken cancellationToken)
            {
                try
                {
                    if (request.UserId.HasValue)
                    {
                        var user = await this.userManager.FindUserByIdAsync(request.UserId.Value);
                        await this.userManager.ChangeUserNameAsync(user, request.NewName);
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