using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Common.Interfaces.Identity.EventHandlers;
using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Configuration.Authorization;
using MediatR;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.Register
{
    /// <summary>
    /// Command for client user registration.
    /// </summary>
    public class RegisterCommand : RegisterRequest, IRequest<RegisterRequestResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterCommand"/> class.
        /// </summary>
        /// <param name="request"></param>
        public RegisterCommand(RegisterRequest request)
        {
            this.Name = request.Name;
            this.Email = request.Email;
            this.Password = request.Password;
            this.ConfirmedPassword = request.ConfirmedPassword;
        }

        /// <inheritdoc/>
        public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisterRequestResult>
        {
            private readonly IUserManager userManager;
            private readonly IIdentityEventManager eventManager;

            /// <summary>
            /// Initializes a new instance of the <see cref="RegisterCommandHandler"/> class.
            /// </summary>
            /// <param name="userManager"></param>
            /// <param name="eventManager"></param>
            public RegisterCommandHandler(IUserManager userManager, IIdentityEventManager eventManager)
            {
                this.userManager = userManager;
                this.eventManager = eventManager;
            }

            /// <inheritdoc/>
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
