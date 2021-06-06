﻿using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Identity;
using Definux.Utilities.Extensions;
using IdentityServer4;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace Definux.Emeraude.Identity.ExternalProviders.Google
{
    /// <summary>
    /// Google authenticator for external authentication.
    /// </summary>
    public class GoogleAuthenticator : IExternalProviderAuthenticator
    {
        /// <inheritdoc />
        public string Name => "Google";

        /// <inheritdoc />
        public async Task<IExternalUser> GetExternalUserAsync(ClaimsPrincipal principal)
        {
            var externalUser = new GoogleExternalUser();
            externalUser.Provider = principal.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Issuer;
            externalUser.Id = principal.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            externalUser.Name = principal.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value;
            externalUser.FirstName = principal.Claims.FirstOrDefault(x => x.Type == ClaimTypes.GivenName)?.Value;
            externalUser.LastName = principal.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Surname)?.Value;
            externalUser.EmailAddress = principal.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value;
            externalUser.Picture = principal.Claims.FirstOrDefault(x => x.Type == Configuration.Authorization.ClaimTypes.Picture)?.Value;

            return externalUser;
        }

        /// <inheritdoc />
        public async Task<IExternalUser> GetExternalUserAsync(string provider, string accessToken)
        {
            GoogleExternalUser externalUser;
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                var googleResponse = await httpClient.GetAsync("https://www.googleapis.com/oauth2/v2/userinfo");
                string responseString = await googleResponse.Content.ReadAsStringAsync();
                externalUser = JsonConvert.DeserializeObject<GoogleExternalUser>(responseString);
                externalUser.Provider = provider;
            }

            return externalUser;
        }

        /// <inheritdoc />
        public void RegisterAuthenticator(AuthenticationBuilder builder)
        {
            var settings = builder
                .Services
                .GetOAuth2Options()
                .GetOauth2Settings("Google");

            builder.AddGoogle(options =>
            {
                options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;
                options.ClientId = settings.ClientId;
                options.ClientSecret = settings.ClientSecret;
                options.Scope.Add("profile");
                options.Events.OnCreatingTicket = (context) =>
                {
                    var claim = new Claim(Configuration.Authorization.ClaimTypes.Picture, context.User.GetProperty("picture").GetString());
                    context.Identity.AddClaim(claim);

                    return Task.CompletedTask;
                };
            });
        }
    }
}