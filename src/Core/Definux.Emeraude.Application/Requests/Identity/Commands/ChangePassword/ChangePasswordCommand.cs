using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword
{
    public class ChangePasswordCommand : ChangePasswordRequest, IRequest<ChangePasswordRequestResult>
    {
        public ChangePasswordCommand(ChangePasswordRequest request)
        {
            UserId = request.UserId;
            CurrentPassword = request.CurrentPassword;
            NewPassword = request.NewPassword;
            ConfirmedPassword = request.ConfirmedPassword;
        }

        public class ChangePasswordCommandHandler : IRequestHandler<ChangePasswordCommand, ChangePasswordRequestResult>
        {
            private readonly IUserManager userManager;

            public ChangePasswordCommandHandler(IUserManager userManager)
            {
                this.userManager = userManager;
            }

            public async Task<ChangePasswordRequestResult> Handle(ChangePasswordCommand request, CancellationToken cancellationToken)
            {
                var user = await this.userManager.FindUserByIdAsync(request.UserId);
                var changePasswordResult = await this.userManager.ChangePasswordAsync(user, request.CurrentPassword, request.NewPassword);

                return new ChangePasswordRequestResult(changePasswordResult.Succeeded);
            }
        }
    }

}
