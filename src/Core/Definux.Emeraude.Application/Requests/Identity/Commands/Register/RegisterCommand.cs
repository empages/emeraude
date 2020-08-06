using Definux.Emeraude.Application.Common.Interfaces.Identity.EventHandlers;
using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Configuration.Authorization;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.Register
{
    public class RegisterCommand : RegisterRequest, IRequest<RegisterRequestResult>
    {
        public RegisterCommand(RegisterRequest request)
        {
            Name = request.Name;
            Email = request.Email;
            Password = request.Password;
            ConfirmedPassword = request.ConfirmedPassword;
        }

        public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisterRequestResult>
        {
            private readonly IUserManager userManager;
            private readonly IIdentityEventManager eventManager;

            public RegisterCommandHandler(IUserManager userManager, IIdentityEventManager eventManager)
            {
                this.userManager = userManager;
                this.eventManager = eventManager;
            }

            public async Task<RegisterRequestResult> Handle(RegisterCommand request, CancellationToken cancellationToken)
            {
                var user = this.userManager.CreateUserObject(request.Email, request.Name);

                var result = new RegisterRequestResult();
                result.Result = await this.userManager.CreateAsync(user, request.Password);
                if (result.Result.Succeeded)
                {
                    await this.userManager.AddToRoleAsync(user, ApplicationRoles.User);
                    await this.eventManager.TriggerRegisterEventAsync(user.Id);
                    result.User = user;
                }

                return result;
            }
        }
    }

}
