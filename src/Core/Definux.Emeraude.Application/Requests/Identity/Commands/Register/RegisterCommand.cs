using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.EventHandlers;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Application.Localization;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Interfaces.Requests;
using Definux.Utilities.Extensions;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.Register
{
    /// <summary>
    /// Command for client user registration.
    /// </summary>
    public class RegisterCommand : IRequest<RegisterRequestResult>, IRegisterRequest
    {
        /// <inheritdoc/>
        public string Name { get; set; }

        /// <inheritdoc/>
        public string Email { get; set; }

        /// <inheritdoc/>
        public string Password { get; set; }

        /// <inheritdoc/>
        public string ConfirmedPassword { get; set; }

        /// <inheritdoc/>
        public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisterRequestResult>
        {
            private readonly IUserManager userManager;
            private readonly IIdentityEventManager eventManager;
            private readonly UrlEncoder urlEncoder;
            private readonly IHttpContextAccessor httpContextAccessor;
            private readonly ICurrentLanguageProvider currentLanguageProvider;

            /// <summary>
            /// Initializes a new instance of the <see cref="RegisterCommandHandler"/> class.
            /// </summary>
            /// <param name="userManager"></param>
            /// <param name="eventManager"></param>
            /// <param name="urlEncoder"></param>
            /// <param name="httpContextAccessor"></param>
            /// <param name="currentLanguageProvider"></param>
            public RegisterCommandHandler(
                IUserManager userManager,
                IIdentityEventManager eventManager,
                UrlEncoder urlEncoder,
                IHttpContextAccessor httpContextAccessor,
                ICurrentLanguageProvider currentLanguageProvider)
            {
                this.userManager = userManager;
                this.eventManager = eventManager;
                this.urlEncoder = urlEncoder;
                this.httpContextAccessor = httpContextAccessor;
                this.currentLanguageProvider = currentLanguageProvider;
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

                    var currentLanguage = await this.currentLanguageProvider.GetCurrentLanguageAsync();
                    string languageUrlPrefix = currentLanguage.IsDefault ? string.Empty : $"/{currentLanguage.Code.ToLower()}";
                    string confirmationToken = this.urlEncoder.Encode(await this.userManager.GenerateEmailConfirmationTokenAsync(user));
                    string confirmationLink = this.httpContextAccessor.HttpContext.GetAbsoluteRoute($"{languageUrlPrefix}/confirm-email?token={confirmationToken}&email={user.Email}");

                    await this.eventManager.TriggerRegisterEventAsync(user.Id, confirmationLink);
                    result.User = user;
                }

                return result;
            }
        }
    }
}
