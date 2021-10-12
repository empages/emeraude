using System;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.EventHandlers;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using ClaimTypes = System.Security.Claims.ClaimTypes;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication
{
    /// <summary>
    /// Command for external authentication of user.
    /// </summary>
    public class ExternalAuthenticationCommand : IRequest<ExternalAuthenticationRequestResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalAuthenticationCommand"/> class.
        /// </summary>
        /// <param name="claimsPrincipal"></param>
        public ExternalAuthenticationCommand(ClaimsPrincipal claimsPrincipal)
        {
            this.ClaimsPrincipal = claimsPrincipal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalAuthenticationCommand"/> class.
        /// </summary>
        /// <param name="externalAuthenticationData"></param>
        public ExternalAuthenticationCommand(ExternalAuthenticationData externalAuthenticationData)
        {
            this.ExternalAuthenticationData = externalAuthenticationData;
        }

        /// <summary>
        /// Name of the target external provider.
        /// </summary>
        public string ExternalProvider
        {
            get
            {
                string externalProvider = null;
                if (this.ClaimsPrincipal != null)
                {
                    externalProvider = this
                        .ClaimsPrincipal
                        .Claims
                        .FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?
                        .Issuer;
                }
                else if (this.ExternalAuthenticationData != null)
                {
                    externalProvider = this.ExternalAuthenticationData.Provider;
                }

                return externalProvider;
            }
        }

        /// <inheritdoc cref="System.Security.Claims.ClaimsPrincipal"/>
        public ClaimsPrincipal ClaimsPrincipal { get; set; }

        /// <inheritdoc cref="ExternalAuthentication.ExternalAuthenticationData"/>
        public ExternalAuthenticationData ExternalAuthenticationData { get; set; }

        /// <inheritdoc/>
        public class ExternalAuthenticationCommandHandler : IRequestHandler<ExternalAuthenticationCommand, ExternalAuthenticationRequestResult>
        {
            private readonly ILogger<ExternalAuthenticationCommandHandler> logger;
            private readonly IUserManager userManager;
            private readonly IUserAvatarService userAvatarService;
            private readonly IExternalProviderAuthenticatorFactory externalProviderAuthenticatorFactory;
            private readonly IIdentityEventManager eventManager;

            /// <summary>
            /// Initializes a new instance of the <see cref="ExternalAuthenticationCommandHandler"/> class.
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="userManager"></param>
            /// <param name="userAvatarService"></param>
            /// <param name="externalProviderAuthenticatorFactory"></param>
            /// <param name="eventManager"></param>
            public ExternalAuthenticationCommandHandler(
                ILogger<ExternalAuthenticationCommandHandler> logger,
                IUserManager userManager,
                IUserAvatarService userAvatarService,
                IExternalProviderAuthenticatorFactory externalProviderAuthenticatorFactory,
                IIdentityEventManager eventManager)
            {
                this.logger = logger;
                this.userManager = userManager;
                this.userAvatarService = userAvatarService;
                this.externalProviderAuthenticatorFactory = externalProviderAuthenticatorFactory;
                this.eventManager = eventManager;
            }

            /// <inheritdoc/>
            public async Task<ExternalAuthenticationRequestResult> Handle(ExternalAuthenticationCommand request, CancellationToken cancellationToken)
            {
                if (string.IsNullOrEmpty(request.ExternalProvider))
                {
                    throw new ArgumentException("Provided external provider is invalid.");
                }

                if (!this.externalProviderAuthenticatorFactory.ContainsProvider(request.ExternalProvider))
                {
                    throw new ArgumentNullException("ExternalProvider", "Requested external provider is not registered.");
                }

                var externalUser = await this.GetExternalUserAsync(request);
                var user = await this.userManager.FindUserByLoginAsync(externalUser.Provider, externalUser.Id) ?? await this.userManager.FindUserByEmailAsync(externalUser.EmailAddress);
                var result = new ExternalAuthenticationRequestResult
                {
                    Result = SignInResult.Failed,
                    User = user,
                };

                if (user != null)
                {
                    bool isProviderRegistered = await this.userManager.FindUserByLoginAsync(externalUser.Provider, externalUser.Id) != null;
                    if (!isProviderRegistered)
                    {
                        await this.AddExternalProviderToUserAsync(user.Id, externalUser);
                    }

                    result.Result = SignInResult.Success;
                    await this.eventManager.TriggerExternalLoginEventAsync(user.Id);
                }
                else
                {
                    var newUser = await this.RegisterUserViaExternalProviderUserAsync(externalUser);
                    if (newUser != null)
                    {
                        result.Result = SignInResult.Success;
                        result.User = newUser;
                        await this.eventManager.TriggerExternalRegisterEventAsync(newUser.Id);
                    }
                }

                return result;
            }

            private async Task<IExternalUser> GetExternalUserAsync(ExternalAuthenticationCommand command)
            {
                IExternalUser externalUser = null;
                try
                {
                    var externalProviderAuthenticator = this.externalProviderAuthenticatorFactory.GetAuthenticator(command.ExternalProvider);

                    if (command.ClaimsPrincipal != null)
                    {
                        externalUser = await externalProviderAuthenticator.GetExternalUserAsync(command.ClaimsPrincipal);
                    }

                    if (command.ExternalAuthenticationData != null)
                    {
                        externalUser = await externalProviderAuthenticator.GetExternalUserAsync(
                            command.ExternalAuthenticationData.Provider,
                            command.ExternalAuthenticationData.AccessToken);
                    }
                }
                catch (Exception ex)
                {
                    this.logger.LogError(ex, "Get external user fails");
                }

                return externalUser;
            }

            private async Task AddExternalProviderToUserAsync(Guid userId, IExternalUser externalUser)
            {
                try
                {
                    var userLoginInfo = new UserLoginInfo(externalUser.Provider, externalUser.Id, externalUser.Provider);
                    var user = await this.userManager.FindUserByIdAsync(userId);
                    await this.userManager.AddLoginAsync(user, userLoginInfo);
                }
                catch (Exception ex)
                {
                    this.logger.LogError(ex, "Add external provider to user fails");
                }
            }

            private async Task<IUser> RegisterUserViaExternalProviderUserAsync(IExternalUser externalUser)
            {
                try
                {
                    var user = this.userManager.CreateUserObject(externalUser.EmailAddress, externalUser.Name, true);

                    var registerResult = await this.userManager.CreateAsync(user);
                    if (registerResult.Succeeded)
                    {
                        await this.AddExternalProviderToUserAsync(user.Id, externalUser);
                        await this.userManager.AddToRoleAsync(user, ApplicationRoles.User);

                        // apply avatar
                        var avatarUrl = await this.userAvatarService.CreateAvatarFromUrlAsync(externalUser.PictureUrl);
                        await this.userAvatarService.ApplyAvatarToUserAsync(user.Id, avatarUrl);

                        return user;
                    }

                    return default;
                }
                catch (Exception ex)
                {
                    this.logger.LogError(ex, "Register user via external provider user fails");
                    return default;
                }
            }
        }
    }
}
