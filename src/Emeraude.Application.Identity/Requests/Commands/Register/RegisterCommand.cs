using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;
using Emeraude.Essentials.Extensions;
using Emeraude.Infrastructure.Identity.Common;
using Emeraude.Infrastructure.Identity.EventHandlers;
using Emeraude.Infrastructure.Identity.Services;
using Emeraude.Infrastructure.Localization.Services;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Emeraude.Application.Identity.Requests.Commands.Register;

/// <summary>
/// Command for client user registration.
/// </summary>
public class RegisterCommand : IdentityCommand, IRequest<RegisterRequestResult>
{
    /// <summary>
    /// Name of the user.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Email of the user.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Password of the user.
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// Confirmed password of the user.
    /// </summary>
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
                await this.userManager.AddToRoleAsync(user, EmRoles.User);

                var currentLanguage = await this.currentLanguageProvider.GetCurrentLanguageAsync();
                string languageUrlPrefix = currentLanguage.IsDefault ? string.Empty : $"/{currentLanguage.Code.ToLower()}";
                string confirmationToken = this.urlEncoder.Encode(await this.userManager.GenerateEmailConfirmationTokenAsync(user));
                string confirmationLink = this.httpContextAccessor.HttpContext.GetAbsoluteRoute($"{languageUrlPrefix}/confirm-email?token={confirmationToken}&email={user.Email}");

                await this.eventManager.TriggerEventAsync<IRegisterEventHandler, RegisterEventArgs>(new RegisterEventArgs
                {
                    UserId = user.Id,
                    EmailConfirmationLink = confirmationLink,
                    AdditionalArgs = request.AdditionalParameters,
                });
                result.User = user;
            }

            return result;
        }
    }
}