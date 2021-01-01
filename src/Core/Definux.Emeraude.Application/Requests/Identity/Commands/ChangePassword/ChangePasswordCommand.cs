using System;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Interfaces.Requests;
using Definux.Utilities.Objects;
using MediatR;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword
{
    /// <summary>
    /// Command for changing password of a specified user.
    /// </summary>
    public class ChangePasswordCommand : IRequest<ChangePasswordRequestResult>, IChangePasswordRequest
    {
        /// <inheritdoc/>
        public Guid? UserId { get; set; }

        /// <inheritdoc/>
        public string CurrentPassword { get; set; }

        /// <inheritdoc/>
        public string NewPassword { get; set; }

        /// <inheritdoc/>
        public string ConfirmedPassword { get; set; }

        /// <inheritdoc/>
        public class ChangePasswordCommandHandler : IRequestHandler<ChangePasswordCommand, ChangePasswordRequestResult>
        {
            private readonly IUserManager userManager;
            private readonly IEmLogger logger;

            /// <summary>
            /// Initializes a new instance of the <see cref="ChangePasswordCommandHandler"/> class.
            /// </summary>
            /// <param name="userManager"></param>
            public ChangePasswordCommandHandler(IUserManager userManager, IEmLogger logger)
            {
                this.userManager = userManager;
                this.logger = logger;
            }

            /// <inheritdoc/>
            public async Task<ChangePasswordRequestResult> Handle(ChangePasswordCommand request, CancellationToken cancellationToken)
            {
                try
                {
                    if (request.UserId != null)
                    {
                        var user = await this.userManager.FindUserByIdAsync(request.UserId.Value);
                        var changePasswordResult = await this.userManager.ChangePasswordAsync(user, request.CurrentPassword, request.NewPassword);

                        return new ChangePasswordRequestResult(changePasswordResult.Succeeded);
                    }

                    return new ChangePasswordRequestResult();
                }
                catch (Exception ex)
                {
                    await this.logger.LogErrorAsync(ex);
                    return new ChangePasswordRequestResult();
                }
            }
        }
    }
}
