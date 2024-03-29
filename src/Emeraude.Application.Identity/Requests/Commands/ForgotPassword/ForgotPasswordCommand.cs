﻿using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;
using Emeraude.Essentials.Extensions;
using Emeraude.Infrastructure.Identity.EventHandlers;
using Emeraude.Infrastructure.Identity.Services;
using Emeraude.Infrastructure.Localization.Services;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Emeraude.Application.Identity.Requests.Commands.ForgotPassword;

/// <summary>
/// Command for forgot password request.
/// </summary>
public class ForgotPasswordCommand : IdentityCommand, IRequest<ForgotPasswordRequestResult>
{
    /// <summary>
    /// Email of the user.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Reset password route used for confirmation link generation.
    /// </summary>
    public string ResetPasswordRoutePart { get; set; }

    /// <inheritdoc/>
    public class ForgotPasswordCommandHandler : IRequestHandler<ForgotPasswordCommand, ForgotPasswordRequestResult>
    {
        private readonly IUserManager userManager;
        private readonly IIdentityEventManager identityEventManager;
        private readonly UrlEncoder urlEncoder;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ICurrentLanguageProvider currentLanguageProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="ForgotPasswordCommandHandler"/> class.
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="identityEventManager"></param>
        /// <param name="urlEncoder"></param>
        /// <param name="httpContextAccessor"></param>
        /// <param name="currentLanguageProvider"></param>
        public ForgotPasswordCommandHandler(
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

        /// <inheritdoc/>
        public async Task<ForgotPasswordRequestResult> Handle(ForgotPasswordCommand request, CancellationToken cancellationToken)
        {
            var user = await this.userManager.FindUserByEmailAsync(request.Email);
            if (user != null)
            {
                var currentLanguage = await this.currentLanguageProvider.GetCurrentLanguageAsync();
                string languageUrlPrefix = currentLanguage.IsDefault ? string.Empty : $"/{currentLanguage.Code.ToLower()}";

                string passwordResetToken = this.urlEncoder.Encode(await this.userManager.GeneratePasswordResetTokenAsync(user));
                string resetPasswordLink = this.httpContextAccessor.HttpContext.GetAbsoluteRoute($"{languageUrlPrefix}/{request.ResetPasswordRoutePart}?token={passwordResetToken}&email={user.Email}");
                await this.identityEventManager.TriggerEventAsync<IForgotPasswordEventHandler, ForgotPasswordEventArgs>(
                    new ForgotPasswordEventArgs
                    {
                        UserId = user.Id,
                        ResetPasswordLink = resetPasswordLink,
                        AdditionalArgs = request.AdditionalParameters,
                    });
            }

            return new ForgotPasswordRequestResult(true);
        }
    }
}