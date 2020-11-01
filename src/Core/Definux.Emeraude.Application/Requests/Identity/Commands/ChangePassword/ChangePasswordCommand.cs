using System;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Interfaces.Requests;
using MediatR;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword
{
    /// <summary>
    /// Command for changing password of a specified user.
    /// </summary>
    public class ChangePasswordCommand : IRequest<ChangePasswordRequestResult>, IChangePasswordRequest
    {
        /// <inheritdoc/>
        public Guid UserId { get; set; }

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
