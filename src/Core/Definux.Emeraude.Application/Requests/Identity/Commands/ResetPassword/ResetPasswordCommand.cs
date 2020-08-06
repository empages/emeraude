using Definux.Emeraude.Application.Common.Interfaces.Identity.EventHandlers;
using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Utilities.Extensions;
using MediatR;
using Microsoft.AspNetCore.Http;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword
{
    public class ResetPasswordCommand : ResetPasswordRequest, IRequest<ResetPasswordRequestResult>
    {
        public ResetPasswordCommand(ResetPasswordRequest request)
        {
            Email = request.Email;
            Password = request.Password;
            ConfirmedPassword = request.ConfirmedPassword;
            Token = request.Token;
        }

        public class ResetPasswordCommandHandler : IRequestHandler<ResetPasswordCommand, ResetPasswordRequestResult>
        {
            private readonly IUserManager userManager;
            private readonly IIdentityEventManager identityEventManager;
            private readonly UrlEncoder urlEncoder;
            private readonly IHttpContextAccessor httpContextAccessor;
            private readonly ICurrentLanguageProvider currentLanguageProvider;

            public ResetPasswordCommandHandler(
                IUserManager userManager,
                IIdentityEventManager identityEventManager,
                UrlEncoder urlEncoder,
                IHttpContextAccessor httpContextAccessor,
                ICurrentLanguageProvider currentLanguageProvider)
            {
                this.userManager = userManager;
                this.identityEventManager = identityEventManager;
                this.urlEncoder = urlEncoder;
                this.httpContextAccessor = httpContextAccessor;
                this.currentLanguageProvider = currentLanguageProvider;
            }

            public async Task<ResetPasswordRequestResult> Handle(ResetPasswordCommand request, CancellationToken cancellationToken)
            {
                var user = await this.userManager.FindUserByEmailAsync(request.Email);
                if (user != null)
                {
                    var resetPasswordResult = await this.userManager.ResetPasswordAsync(user, request.Token, request.Password);
                    if (resetPasswordResult.Succeeded)
                    {
                        var currentLanguage = await this.currentLanguageProvider.GetCurrentLanguageAsync();
                        string languageUrlPrefix = currentLanguage.IsDefault ? string.Empty : $"/{currentLanguage.Code.ToLower()}";

                        string passwordResetToken = this.urlEncoder.Encode(await this.userManager.GeneratePasswordResetTokenAsync(user));
                        string resetPasswordLink = this.httpContextAccessor.HttpContext.GetAbsoluteRoute($"{languageUrlPrefix}/reset-password?token={passwordResetToken}&email={user.Email}");
                        await this.identityEventManager.TriggerForgotPasswordEventAsync(user.Id, resetPasswordLink);

                        return new ResetPasswordRequestResult(true);
                    }
                }

                return new ResetPasswordRequestResult(false);
            }
        }
    }

}
