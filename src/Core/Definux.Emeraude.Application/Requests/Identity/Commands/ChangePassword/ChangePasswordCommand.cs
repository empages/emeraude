using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using MediatR;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword
{
    /// <summary>
    /// Command for changing password of a specified user.
    /// </summary>
    public class ChangePasswordCommand : ChangePasswordRequest, IRequest<ChangePasswordRequestResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePasswordCommand"/> class.
        /// </summary>
        /// <param name="request"></param>
        public ChangePasswordCommand(ChangePasswordRequest request)
        {
            this.UserId = request.UserId;
            this.CurrentPassword = request.CurrentPassword;
            this.NewPassword = request.NewPassword;
            this.ConfirmedPassword = request.ConfirmedPassword;
        }

        /// <inheritdoc/>
        public class ChangePasswordCommandHandler : IRequestHandler<ChangePasswordCommand, ChangePasswordRequestResult>
        {
            private readonly IUserManager userManager;

            /// <summary>
            /// Initializes a new instance of the <see cref="ChangePasswordCommandHandler"/> class.
            /// </summary>
            /// <param name="userManager"></param>
            public ChangePasswordCommandHandler(IUserManager userManager)
            {
                this.userManager = userManager;
            }

            /// <inheritdoc/>
            public async Task<ChangePasswordRequestResult> Handle(ChangePasswordCommand request, CancellationToken cancellationToken)
            {
                var user = await this.userManager.FindUserByIdAsync(request.UserId);
                var changePasswordResult = await this.userManager.ChangePasswordAsync(user, request.CurrentPassword, request.NewPassword);

                return new ChangePasswordRequestResult(changePasswordResult.Succeeded);
            }
        }
    }
}
