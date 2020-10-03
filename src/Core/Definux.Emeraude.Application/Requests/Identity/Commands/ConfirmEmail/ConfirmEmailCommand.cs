using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Common.Interfaces.Identity.EventHandlers;
using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using MediatR;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail
{
    /// <summary>
    /// Command for confirming email of specified user.
    /// </summary>
    public class ConfirmEmailCommand : ConfirmEmailRequest, IRequest<ConfirmEmailRequestResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmEmailCommand"/> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="token"></param>
        public ConfirmEmailCommand(string email, string token)
        {
            this.Email = email;
            this.Token = token;
        }

        /// <inheritdoc/>
        public class ConfirmEmailCommandHandler : IRequestHandler<ConfirmEmailCommand, ConfirmEmailRequestResult>
        {
            private readonly IUserManager userManager;
            private readonly IIdentityEventManager identityEventManager;

            /// <summary>
            /// Initializes a new instance of the <see cref="ConfirmEmailCommandHandler"/> class.
            /// </summary>
            /// <param name="userManager"></param>
            /// <param name="identityEventManager"></param>
            public ConfirmEmailCommandHandler(IUserManager userManager, IIdentityEventManager identityEventManager)
            {
                this.userManager = userManager;
                this.identityEventManager = identityEventManager;
            }

            /// <inheritdoc/>
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
