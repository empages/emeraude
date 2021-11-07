using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using Definux.Emeraude.Essentials.Base;
using Definux.Emeraude.Infrastructure.Identity.Options;
using Definux.Emeraude.Infrastructure.Identity.Services;
using Definux.Utilities.Extensions;
using IdentityServer4;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace Definux.Emeraude.Infrastructure.Identity.ExternalProviders.Facebook
{
    /// <summary>
    /// Facebook authenticator for external authentication.
    /// </summary>
    public class FacebookAuthenticator : IExternalProviderAuthenticator
    {
        /// <inheritdoc />
        public string Name => "Facebook";

        /// <inheritdoc />
        public async Task<IExternalUser> GetExternalUserAsync(ClaimsPrincipal principal)
        {
            var externalUser = new FacebookExternalUser();
            externalUser.Provider = principal.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Issuer;
            externalUser.Id = principal.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            externalUser.Name = principal.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value;
            externalUser.FirstName = principal.Claims.FirstOrDefault(x => x.Type == ClaimTypes.GivenName)?.Value;
            externalUser.LastName = principal.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Surname)?.Value;
            externalUser.EmailAddress = principal.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value;
            externalUser.Picture = new ProfilePicture();
            externalUser.Picture.Data = new ProfilePictureData();
            externalUser.Picture.Data.Url = principal.Claims.FirstOrDefault(x => x.Type == EmClaimTypes.Picture)?.Value;

            return externalUser;
        }

        /// <inheritdoc />
        public async Task<IExternalUser> GetExternalUserAsync(string provider, string accessToken)
        {
            FacebookExternalUser externalUser;
            using (var httpClient = new HttpClient())
            {
                var facebookResponse = await httpClient.GetAsync($"https://graph.facebook.com/me?access_token={accessToken}&fields=id,name,first_name,last_name,email,picture.type(large)");
                var responseString = await facebookResponse.Content.ReadAsStringAsync();
                externalUser = JsonConvert.DeserializeObject<FacebookExternalUser>(responseString);
                externalUser.Provider = provider;
            }

            return externalUser;
        }

        /// <inheritdoc />
        public void RegisterAuthenticator(AuthenticationBuilder builder)
        {
            var settings = builder
                .Services
                .GetOptions<ExternalOAuth2ProvidersOptions>()
                .GetOauth2Settings("Facebook");

            builder.AddFacebook(options =>
            {
                options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;
                options.AppId = settings.ClientId;
                options.AppSecret = settings.ClientSecret;
                options.Fields.Add("picture.type(large)");

                options.Events = new OAuthEvents
                {
                    OnCreatingTicket = (context) =>
                    {
                        ClaimsIdentity identity = (ClaimsIdentity)context.Principal.Identity;
                        string profileImage = context
                            .User
                            .GetProperty("picture")
                            .GetProperty("data")
                            .GetProperty("url")
                            .ToString();

                        identity.AddClaim(new Claim(EmClaimTypes.Picture, profileImage));
                        return Task.CompletedTask;
                    },
                };
            });
        }
    }
}