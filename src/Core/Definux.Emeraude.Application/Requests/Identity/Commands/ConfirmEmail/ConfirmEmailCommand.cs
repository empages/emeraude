using Definux.Emeraude.Application.Common.Interfaces.Identity.EventHandlers;
using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail
{
    public class ConfirmEmailCommand : ConfirmEmailRequest, IRequest<ConfirmEmailRequestResult>
    {
        public ConfirmEmailCommand(string email, string token)
        {
            Email = email;
            Token = token;
        }

        public class ConfirmEmailCommandHandler : IRequestHandler<ConfirmEmailCommand, ConfirmEmailRequestResult>
        {
            private readonly IUserManager userManager;
            private readonly IIdentityEventManager identityEventManager;

            public ConfirmEmailCommandHandler(IUserManager userManager, IIdentityEventManager identityEventManager)
            {
                this.userManager = userManager;
                this.identityEventManager = identityEventManager;
            }

            public async Task<ConfirmEmailRequestResult> Handle(ConfirmEmailCommand request, CancellationToken cancellationToken)
            {
                var user = await this.userManager.FindUserByEmailAsync(request.Email);
                if (user != null)
                {
                    var result = await this.userManager.ConfirmEmailAsync(user, request.Token);
                    if (result.Succeeded)
                    {
                        await this.identityEventManager.TriggerConfirmedEmailEventAsync(user.Id);
                        return new ConfirmEmailRequestResult(true);
                    }
                }

                return new ConfirmEmailRequestResult(false);
            }
        }
    }

}
