using System;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;
using Emeraude.Essentials.Extensions;
using Emeraude.Essentials.Models;
using Emeraude.Infrastructure.Identity.EventHandlers;
using Emeraude.Infrastructure.Identity.Services;
using Emeraude.Infrastructure.Localization.Services;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Emeraude.Application.Identity.Requests.Commands.RequestChangeEmail
{
    /// <summary>
    /// Command that send request for change email for specified user.
    /// </summary>
    public class RequestChangeEmailCommand : IRequest<SimpleResult>
    {
        /// <summary>
        /// Id of the target user.
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        /// New email of the target user.
        /// </summary>
        public string NewEmail { get; set; }

        /// <summary>
        /// Url that will be applied into the change email link.
        /// </summary>
        public string LocalCallbackUrl { get; private set; }

        /// <summary>
        /// Flag that indicates whether to apply localization parameter to change email link.
        /// </summary>
        public bool UseLocalization { get; private set; }

        /// <summary>
        /// Configure the callback options for change email link.
        /// </summary>
        /// <param name="localCallbackUrl"></param>
        /// <param name="useLocalization"></param>
        public void ConfigureCallbackOptions(string localCallbackUrl, bool useLocalization)
        {
            this.LocalCallbackUrl = localCallbackUrl;
            this.UseLocalization = useLocalization;
        }

        /// <inheritdoc />
        public class RequestChangeEmailCommandHandler : IRequestHandler<RequestChangeEmailCommand, SimpleResult>
        {
            private readonly IUserManager userManager;
            private readonly ILogger<RequestChangeEmailCommandHandler> logger;
            private readonly ICurrentLanguageProvider currentLanguageProvider;
            private readonly IIdentityEventManager identityEventManager;
            private readonly IHttpContextAccessor httpContextAccessor;
            private readonly UrlEncoder urlEncoder;

            /// <summary>
            /// Initializes a new instance of the <see cref="RequestChangeEmailCommandHandler"/> class.
            /// </summary>
            /// <param name="userManager"></param>
            /// <param name="logger"></param>
            /// <param name="currentLanguageProvider"></param>
            /// <param name="identityEventManager"></param>
            /// <param name="httpContextAccessor"></param>
            /// <param name="urlEncoder"></param>
            public RequestChangeEmailCommandHandler(
                IUserManager userManager,
                ILogger<RequestChangeEmailCommandHandler> logger,
                ICurrentLanguageProvider currentLanguageProvider,
                IIdentityEventManager identityEventManager,
                IHttpContextAccessor httpContextAccessor,
                UrlEncoder urlEncoder)
            {
                this.userManager = userManager;
                this.logger = logger;
                this.currentLanguageProvider = currentLanguageProvider;
                this.identityEventManager = identityEventManager;
                this.httpContextAccessor = httpContextAccessor;
                this.urlEncoder = urlEncoder;
            }

            /// <inheritdoc />
            public async Task<SimpleResult> Handle(RequestChangeEmailCommand request, CancellationToken cancellationToken)
            {
                try
                {
                    var user = await this.userManager.FindUserByIdAsync(request.UserId ?? Guid.Empty);
                    if (user != null)
                    {
                        string languageUrlPrefix = string.Empty;
                        if (request.UseLocalization)
                        {
                            var currentLanguage = await this.currentLanguageProvider.GetCurrentLanguageAsync();
                            languageUrlPrefix = currentLanguage.IsDefault ? string.Empty : $"/{currentLanguage.Code.ToLower()}";
                        }

                        var changeEmailToken = this.urlEncoder.Encode(await this.userManager.GenerateChangeEmailTokenAsync(user, request.NewEmail));
                        string changeEmailLink = this.httpContextAccessor.HttpContext.GetAbsoluteRoute($"{languageUrlPrefix}/{request.LocalCallbackUrl}?token={changeEmailToken}&email={request.NewEmail}");
                        await this.identityEventManager.TriggerRequestChangeEmailEventAsync(user.Id, request.NewEmail, changeEmailLink);

                        return SimpleResult.SuccessfulResult;
                    }

                    return SimpleResult.UnsuccessfulResult;
                }
                catch (Exception ex)
                {
                    this.logger.LogError(ex, "Request change email command fails");
                    return SimpleResult.UnsuccessfulResult;
                }
            }
        }
    }
}