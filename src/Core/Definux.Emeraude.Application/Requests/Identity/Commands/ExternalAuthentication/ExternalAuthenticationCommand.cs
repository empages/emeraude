using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.EventHandlers;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

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

        /// <inheritdoc cref="System.Security.Claims.ClaimsPrincipal"/>
        public ClaimsPrincipal ClaimsPrincipal { get; set; }

        /// <inheritdoc cref="ExternalAuthentication.ExternalAuthenticationData"/>
        public ExternalAuthenticationData ExternalAuthenticationData { get; set; }

        /// <inheritdoc/>
        public class ExternalAuthenticationCommandHandler : IRequestHandler<ExternalAuthenticationCommand, ExternalAuthenticationRequestResult>
        {
            /// <summary>
            /// Name of the Facebook external provider.
            /// </summary>
            public const string FacebookExternalProvider = "Facebook";

            /// <summary>
            /// Name of the Google external provider.
            /// </summary>
            public const string GoogleExternalProvider = "Google";

            private readonly IEmLogger logger;
            private readonly IUserManager userManager;
            private readonly IUserAvatarService userAvatarService;
            private readonly IIdentityEventManager eventManager;

            /// <summary>
            /// Initializes a new instance of the <see cref="ExternalAuthenticationCommandHandler"/> class.
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="context"></param>
            /// <param name="userManager"></param>
            /// <param name="userAvatarService"></param>
            /// <param name="eventManager"></param>
            public ExternalAuthenticationCommandHandler(
                IEmLogger logger,
                IUserManager userManager,
                IUserAvatarService userAvatarService,
                IIdentityEventManager eventManager)
            {
                this.logger = logger;
                this.userManager = userManager;
                this.userAvatarService = userAvatarService;
                this.eventManager = eventManager;
            }

            /// <inheritdoc/>
            public async Task<ExternalAuthenticationRequestResult> Handle(ExternalAuthenticationCommand request, CancellationToken cancellationToken)
            {
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
                if (command.ClaimsPrincipal != null)
                {
                    return await this.GetExternalUserAsync(command.ClaimsPrincipal);
                }
                else if (command.ExternalAuthenticationData != null)
                {
                    return await this.GetExternalUserAsync(command.ExternalAuthenticationData);
                }

                return null;
            }

            private async Task<IExternalUser> GetExternalUserAsync(ClaimsPrincipal principal)
            {
                try
                {
                    IExternalUser externalUser = null;

                    string provider = principal.Claims.FirstOrDefault(x => x.Type == System.Security.Claims.ClaimTypes.NameIdentifier)?.Issuer;
                    string nameIdentifier = principal.Claims.FirstOrDefault(x => x.Type == System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                    string name = principal.Claims.FirstOrDefault(x => x.Type == System.Security.Claims.ClaimTypes.Name)?.Value;
                    string firstName = principal.Claims.FirstOrDefault(x => x.Type == System.Security.Claims.ClaimTypes.GivenName)?.Value;
                    string lastName = principal.Claims.FirstOrDefault(x => x.Type == System.Security.Claims.ClaimTypes.Surname)?.Value;
                    string email = principal.Claims.FirstOrDefault(x => x.Type == System.Security.Claims.ClaimTypes.Email)?.Value;
                    string picture = string.Empty;

                    if (provider == FacebookExternalProvider)
                    {
                        externalUser = new FacebookExternalUser();
                        ((FacebookExternalUser)externalUser).Picture = new ProfilePicture();
                        ((FacebookExternalUser)externalUser).Picture.Data = new ProfilePictureData();
                        ((FacebookExternalUser)externalUser).Picture.Data.Url = $"https://graph.facebook.com/{nameIdentifier}/picture?type=large";
                    }
                    else if (provider == GoogleExternalProvider)
                    {
                        externalUser = new GoogleExternalUser();
                        ((GoogleExternalUser)externalUser).Picture = principal.Claims.FirstOrDefault(x => x.Type == Definux.Emeraude.Configuration.Authorization.ClaimTypes.Picture)?.Value;
                    }

                    externalUser.Id = nameIdentifier;
                    externalUser.Name = name;
                    externalUser.FirstName = firstName;
                    externalUser.LastName = lastName;
                    externalUser.EmailAddress = email;
                    externalUser.Provider = provider;

                    return externalUser;
                }
                catch (Exception ex)
                {
                    await this.logger.LogErrorAsync(ex);
                    return null;
                }
            }

            private async Task<IExternalUser> GetExternalUserAsync(ExternalAuthenticationData externalLoginData)
            {
                try
                {
                    IExternalUser externalUser = null;

                    if (externalLoginData.Provider == FacebookExternalProvider)
                    {
                        using (HttpClient httpClient = new HttpClient())
                        {
                            var facebookResponse = await httpClient.GetAsync($"https://graph.facebook.com/me?access_token={externalLoginData.AccessToken}&fields=id,name,first_name,last_name,email,picture.type(large)");
                            string responseString = await facebookResponse.Content.ReadAsStringAsync();
                            externalUser = JsonConvert.DeserializeObject<FacebookExternalUser>(responseString);
                            externalUser.Provider = externalLoginData.Provider;
                        }
                    }
                    else if (externalLoginData.Provider == GoogleExternalProvider)
                    {
                        using (HttpClient httpClient = new HttpClient())
                        {
                            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", externalLoginData.AccessToken);
                            var googleResponse = await httpClient.GetAsync("https://www.googleapis.com/oauth2/v2/userinfo");
                            string responseString = await googleResponse.Content.ReadAsStringAsync();
                            externalUser = JsonConvert.DeserializeObject<GoogleExternalUser>(responseString);
                            externalUser.Provider = externalLoginData.Provider;
                        }
                    }

                    return externalUser;
                }
                catch (Exception ex)
                {
                    await this.logger.LogErrorAsync(ex);
                    return null;
                }
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
                    await this.logger.LogErrorAsync(ex);
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
                    await this.logger.LogErrorAsync(ex);
                    return default;
                }
            }
        }
    }
}
