using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Identity.Entities;
using Definux.Emeraude.Identity.Helpers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Definux.Emeraude.Identity.Services
{
    /// <inheritdoc cref="IUserManager"/>
    public class UserManager : DefaultUserManager, IUserManager
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserManager"/> class.
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="httpContextAccessor"></param>
        public UserManager(UserManager<User> userManager, IHttpContextAccessor httpContextAccessor)
            : base(userManager)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        /// <inheritdoc/>
        public IdentityOptions Options => this.UserManager?.Options;

        /// <inheritdoc/>
        public async Task<bool> IsEmailConfirmedAsync(string email)
        {
            var user = await this.FindUserByEmailAsync(email);
            if (user != null)
            {
                return await this.IsEmailConfirmedAsync(user);
            }

            return false;
        }

        /// <inheritdoc/>
        public async Task<bool> CheckPasswordAsync(string email, string password)
        {
            var user = await this.FindUserByEmailAsync(email);
            if (user != null)
            {
                bool correctPassword = await this.CheckPasswordAsync(user, password);
                if (correctPassword)
                {
                    await this.ResetAccessFailedCountAsync(user);
                }
                else
                {
                    await this.AccessFailedAsync(user);
                }

                return correctPassword;
            }

            return false;
        }

        /// <inheritdoc/>
        public IUser CreateUserObject(string email, string name, bool confirmedEmail = false)
        {
            return new User
            {
                UserName = email,
                Email = email,
                Name = name,
                EmailConfirmed = confirmedEmail,
                RegistrationDate = DateTime.Now,
            };
        }

        /// <inheritdoc/>
        public async Task<IUser> GetTwoFactorAuthenticationUserAsync()
        {
            try
            {
                var info = await this.RetrieveTwoFactorInfoAsync();
                if (info == null)
                {
                    return null;
                }

                return await this.UserManager.FindByIdAsync(info.UserId);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private async Task<TwoFactorAuthenticationInfo> RetrieveTwoFactorInfoAsync()
        {
            var result = await this.httpContextAccessor.HttpContext.AuthenticateAsync(IdentityConstants.TwoFactorUserIdScheme);
            if (result?.Principal != null)
            {
                return new TwoFactorAuthenticationInfo
                {
                    UserId = result.Principal.FindFirstValue(ClaimTypes.Name),
                    LoginProvider = result.Principal.FindFirstValue(ClaimTypes.AuthenticationMethod),
                };
            }

            return null;
        }
    }
}
