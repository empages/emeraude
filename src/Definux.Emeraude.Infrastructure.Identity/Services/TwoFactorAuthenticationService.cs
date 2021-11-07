using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Definux.Emeraude.Configuration.Extensions;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Contracts;
using Definux.Emeraude.Infrastructure.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace Definux.Emeraude.Infrastructure.Identity.Services
{
    /// <inheritdoc cref="ITwoFactorAuthenticationService"/>
    public class TwoFactorAuthenticationService : ITwoFactorAuthenticationService
    {
        private const string AuthenticatorUriFormat = "otpauth://totp/{0}:{1}?secret={2}&issuer={0}&digits=6";
        private readonly UserManager<User> userManager;
        private readonly UrlEncoder urlEncoder;
        private readonly EmMainOptions mainOptions;

        /// <summary>
        /// Initializes a new instance of the <see cref="TwoFactorAuthenticationService"/> class.
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="urlEncoder"></param>
        /// <param name="optionsProvider"></param>
        public TwoFactorAuthenticationService(UserManager<User> userManager, UrlEncoder urlEncoder, IEmOptionsProvider optionsProvider)
        {
            this.userManager = userManager;
            this.urlEncoder = urlEncoder;
            this.mainOptions = optionsProvider.GetMainOptions();
        }

        /// <inheritdoc/>
        public async Task<string> GetFormattedKeyAsync(IUser user)
        {
            string unformattedKey = await this.GetUnformattedKeyAsync(user);

            var result = new StringBuilder();
            int currentPosition = 0;
            while (currentPosition + 4 < unformattedKey.Length)
            {
                result.Append(unformattedKey.Substring(currentPosition, 4)).Append(" ");
                currentPosition += 4;
            }

            if (currentPosition < unformattedKey.Length)
            {
                result.Append(unformattedKey.Substring(currentPosition));
            }

            return result.ToString().ToLowerInvariant();
        }

        /// <inheritdoc/>
        public async Task<string> GenerateQrCodeUriAsync(IUser user)
        {
            string unformattedKey = await this.GetUnformattedKeyAsync(user);

            return string.Format(
                AuthenticatorUriFormat,
                this.urlEncoder.Encode(this.mainOptions.ProjectName),
                this.urlEncoder.Encode(user.Email),
                unformattedKey);
        }

        /// <inheritdoc/>
        public bool IsTwoFactorEnabled(IUser user)
        {
            return ((User)user).TwoFactorEnabled;
        }

        private async Task<string> GetUnformattedKeyAsync(IUser user)
        {
            var identityUser = (User)user;
            var unformattedKey = await this.userManager.GetAuthenticatorKeyAsync(identityUser);
            if (string.IsNullOrEmpty(unformattedKey))
            {
                await this.userManager.ResetAuthenticatorKeyAsync(identityUser);
                unformattedKey = await this.userManager.GetAuthenticatorKeyAsync(identityUser);
            }

            return unformattedKey;
        }
    }
}
