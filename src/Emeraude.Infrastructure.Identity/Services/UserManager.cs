using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Emeraude.Contracts;
using Emeraude.Infrastructure.Identity.Entities;
using Emeraude.Infrastructure.Identity.Helpers;
using Emeraude.Infrastructure.Identity.Persistence;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Emeraude.Infrastructure.Identity.Services
{
    /// <inheritdoc cref="IUserManager"/>
    public class UserManager : DefaultUserManager, IUserManager
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IIdentityContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserManager"/> class.
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="httpContextAccessor"></param>
        /// <param name="context"></param>
        public UserManager(
            UserManager<User> userManager,
            IHttpContextAccessor httpContextAccessor,
            IIdentityContext context)
            : base(userManager)
        {
            this.httpContextAccessor = httpContextAccessor;
            this.context = context;
        }

        /// <inheritdoc/>
        public IdentityOptions Options => this.UserManager?.Options;

        /// <inheritdoc/>
        public async Task ChangeUserNameAsync(IUser user, string newName)
        {
            user.Name = newName;
            await this.UserManager.UpdateAsync((User)user);
        }

        /// <inheritdoc/>
        public async Task<bool> IsLockedOutAsync(string email)
        {
            var user = await this.FindUserByEmailAsync(email);
            if (user != null)
            {
                return await this.IsLockedOutAsync(user);
            }

            return false;
        }

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
                LockoutEnabled = true,
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
