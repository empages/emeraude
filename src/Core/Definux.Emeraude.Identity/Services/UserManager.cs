using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Identity.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Definux.Emeraude.Identity.Services
{
    public class UserManager : DefaultUserManager, IUserManager
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public UserManager(UserManager<User> userManager, IHttpContextAccessor httpContextAccessor)
            : base(userManager)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public IdentityOptions Options => userManager?.Options;

        public async Task<bool> IsEmailConfirmedAsync(string email)
        {
            var user = await FindUserByEmailAsync(email);
            if (user != null)
            {
                return await IsEmailConfirmedAsync(user);
            }

            return false;
        }

        public async Task<bool> CheckPasswordAsync(string email, string password)
        {
            var user = await FindUserByEmailAsync(email);
            if (user != null)
            {
                bool correctPassword = await CheckPasswordAsync(user, password);
                if (correctPassword)
                {
                    await ResetAccessFailedCountAsync(user);

                }
                else
                {
                    await AccessFailedAsync(user);
                }

                return correctPassword;
            }

            return false;
        }

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

        public async Task<IUser> GetTwoFactorAuthenticationUserAsync()
        {
            try
            {
                var info = await RetrieveTwoFactorInfoAsync();
                if (info == null)
                {
                    return null;
                }

                return await this.userManager.FindByIdAsync(info.UserId);
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
                    LoginProvider = result.Principal.FindFirstValue(ClaimTypes.AuthenticationMethod)
                };
            }
            return null;
        }
    }

    public class TwoFactorAuthenticationInfo
    {
        public string UserId { get; set; }
        public string LoginProvider { get; set; }
    }
}
