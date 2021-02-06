using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Identity.Entities;
using Microsoft.AspNetCore.Identity;

namespace Definux.Emeraude.Identity.Services
{
    /// <summary>
    /// ASP.NET Core user manager wrapper for the purposes of Emeraude user manager.
    /// </summary>
    public abstract class DefaultUserManager
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultUserManager"/> class.
        /// </summary>
        /// <param name="userManager"></param>
        public DefaultUserManager(UserManager<User> userManager)
        {
            this.UserManager = userManager;
        }

        /// <summary>
        /// ASP.NET Core User Manager instance.
        /// </summary>
        protected UserManager<User> UserManager { get; set; }

        /// <inheritdoc cref="UserManager{TUser}.AccessFailedAsync"/>
        public async Task<IdentityResult> AccessFailedAsync(IUser user) => await this.UserManager.AccessFailedAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.AddClaimAsync"/>
        public async Task<IdentityResult> AddClaimAsync(IUser user, Claim claim) => await this.UserManager.AddClaimAsync((User)user, claim);

        /// <inheritdoc cref="UserManager{TUser}.AddClaimsAsync"/>
        public async Task<IdentityResult> AddClaimsAsync(IUser user, IEnumerable<Claim> claims) => await this.UserManager.AddClaimsAsync((User)user, claims);

        /// <inheritdoc cref="UserManager{TUser}.AddLoginAsync"/>
        public async Task<IdentityResult> AddLoginAsync(IUser user, UserLoginInfo login) => await this.UserManager.AddLoginAsync((User)user, login);

        /// <inheritdoc cref="UserManager{TUser}.AddPasswordAsync)"/>
        public async Task<IdentityResult> AddPasswordAsync(IUser user, string password) => await this.UserManager.AddPasswordAsync((User)user, password);

        /// <inheritdoc cref="UserManager{TUser}.AddToRoleAsync"/>
        public async Task<IdentityResult> AddToRoleAsync(IUser user, string role) => await this.UserManager.AddToRoleAsync((User)user, role);

        /// <inheritdoc cref="UserManager{TUser}.AddToRolesAsync"/>
        public async Task<IdentityResult> AddToRolesAsync(IUser user, IEnumerable<string> roles) => await this.UserManager.AddToRolesAsync((User)user, roles);

        /// <inheritdoc cref="UserManager{TUser}.ChangeEmailAsync"/>
        public async Task<IdentityResult> ChangeEmailAsync(IUser user, string newEmail, string token)
        {
            var identityUser = (User)user;
            var result = await this.UserManager.ChangeEmailAsync(identityUser, newEmail, token);
            if (result.Succeeded)
            {
                identityUser.UserName = identityUser.Email;
                identityUser.NormalizedUserName = identityUser.NormalizedEmail;
                result = await this.UserManager.UpdateAsync(identityUser);
            }

            return result;
        }

        /// <inheritdoc cref="UserManager{TUser}.ChangePasswordAsync"/>
        public async Task<IdentityResult> ChangePasswordAsync(IUser user, string currentPassword, string newPassword) => await this.UserManager.ChangePasswordAsync((User)user, currentPassword, newPassword);

        /// <inheritdoc cref="UserManager{TUser}.ChangePhoneNumberAsync"/>
        public async Task<IdentityResult> ChangePhoneNumberAsync(IUser user, string phoneNumber, string token) => await this.UserManager.ChangePhoneNumberAsync((User)user, phoneNumber, token);

        /// <inheritdoc cref="UserManager{TUser}.CheckPasswordAsync"/>
        public async Task<bool> CheckPasswordAsync(IUser user, string password) => await this.UserManager.CheckPasswordAsync((User)user, password);

        /// <inheritdoc cref="UserManager{TUser}.ConfirmEmailAsync/>
        public async Task<IdentityResult> ConfirmEmailAsync(IUser user, string token) => await this.UserManager.ConfirmEmailAsync((User)user, token);

        /// <inheritdoc cref="UserManager{TUser}.CountRecoveryCodesAsync"/>
        public async Task<int> CountRecoveryCodesAsync(IUser user) => await this.UserManager.CountRecoveryCodesAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.CreateAsync"/>
        public async Task<IdentityResult> CreateAsync(IUser user) => await this.UserManager.CreateAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.CreateAsync"/>
        public async Task<IdentityResult> CreateAsync(IUser user, string password) => await this.UserManager.CreateAsync((User)user, password);

        /// <inheritdoc cref="UserManager{TUser}.CreateSecurityTokenAsync"/>
        public async Task<byte[]> CreateSecurityTokenAsync(IUser user) => await this.UserManager.CreateSecurityTokenAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.DeleteAsync"/>
        public async Task<IdentityResult> DeleteAsync(IUser user) => await this.UserManager.DeleteAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.FindUserByEmailAsync"/>
        public async Task<IUser> FindUserByEmailAsync(string email) => await this.UserManager.FindByEmailAsync(email);

        /// <inheritdoc cref="UserManager{TUser}.FindUserByIdAsync"/>
        public async Task<IUser> FindUserByIdAsync(Guid userId) => await this.UserManager.FindByIdAsync(userId.ToString());

        /// <inheritdoc cref="UserManager{TUser}.FindUserByLoginAsync"/>
        public async Task<IUser> FindUserByLoginAsync(string loginProvider, string providerKey) => await this.UserManager.FindByLoginAsync(loginProvider, providerKey);

        /// <inheritdoc cref="UserManager{TUser}.FindUserByNameAsync"/>
        public async Task<IUser> FindUserByNameAsync(string userName) => await this.UserManager.FindByNameAsync(userName);

        /// <inheritdoc cref="UserManager{TUser}.GenerateChangeEmailTokenAsync"/>
        public async Task<string> GenerateChangeEmailTokenAsync(IUser user, string newEmail) => await this.UserManager.GenerateChangeEmailTokenAsync((User)user, newEmail);

        /// <inheritdoc cref="UserManager{TUser}.GenerateChangePhoneNumberTokenAsync"/>
        public async Task<string> GenerateChangePhoneNumberTokenAsync(IUser user, string phoneNumber) => await this.UserManager.GenerateChangePhoneNumberTokenAsync((User)user, phoneNumber);

        /// <inheritdoc cref="UserManager{TUser}.GenerateConcurrencyStampAsync"/>
        public async Task<string> GenerateConcurrencyStampAsync(IUser user) => await this.UserManager.GenerateConcurrencyStampAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.GenerateEmailConfirmationTokenAsync"/>
        public async Task<string> GenerateEmailConfirmationTokenAsync(IUser user) => await this.UserManager.GenerateEmailConfirmationTokenAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.GenerateNewTwoFactorRecoveryCodesAsync"/>
        public async Task<IEnumerable<string>> GenerateNewTwoFactorRecoveryCodesAsync(IUser user, int number) => await this.UserManager.GenerateNewTwoFactorRecoveryCodesAsync((User)user, number);

        /// <inheritdoc cref="UserManager{TUser}.GeneratePasswordResetTokenAsync"/>
        public async Task<string> GeneratePasswordResetTokenAsync(IUser user) => await this.UserManager.GeneratePasswordResetTokenAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.GenerateTwoFactorTokenAsync"/>
        public async Task<string> GenerateTwoFactorTokenAsync(IUser user, string tokenProvider) => await this.UserManager.GenerateTwoFactorTokenAsync((User)user, tokenProvider);

        /// <inheritdoc cref="UserManager{TUser}.GenerateUserTokenAsync"/>
        public async Task<string> GenerateUserTokenAsync(IUser user, string tokenProvider, string purpose) => await this.UserManager.GenerateUserTokenAsync((User)user, tokenProvider, purpose);

        /// <inheritdoc cref="UserManager{TUser}.GetAccessFailedCountAsync"/>
        public async Task<int> GetAccessFailedCountAsync(IUser user) => await this.UserManager.GetAccessFailedCountAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.GetAuthenticationTokenAsync"/>
        public async Task<string> GetAuthenticationTokenAsync(IUser user, string loginProvider, string tokenName) => await this.UserManager.GetAuthenticationTokenAsync((User)user, loginProvider, tokenName);

        /// <inheritdoc cref="UserManager{TUser}.GetAuthenticatorKeyAsync"/>
        public async Task<string> GetAuthenticatorKeyAsync(IUser user) => await this.UserManager.GetAuthenticatorKeyAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.GetClaimsAsync"/>
        public async Task<IList<Claim>> GetClaimsAsync(IUser user) => await this.UserManager.GetClaimsAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.GetEmailAsync"/>
        public async Task<string> GetEmailAsync(IUser user) => await this.UserManager.GetEmailAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.GetLockoutEnabledAsync"/>
        public async Task<bool> GetLockoutEnabledAsync(IUser user) => await this.UserManager.GetLockoutEnabledAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.GetLockoutEndDateAsync"/>
        public async Task<DateTimeOffset?> GetLockoutEndDateAsync(IUser user) => await this.UserManager.GetLockoutEndDateAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.GetLoginsAsync"/>
        public async Task<IList<UserLoginInfo>> GetLoginsAsync(IUser user) => await this.UserManager.GetLoginsAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.GetPhoneNumberAsync"/>
        public async Task<string> GetPhoneNumberAsync(IUser user) => await this.UserManager.GetPhoneNumberAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.GetRolesAsync"/>
        public async Task<IList<string>> GetRolesAsync(IUser user) => await this.UserManager.GetRolesAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.GetSecurityStampAsync"/>
        public async Task<string> GetSecurityStampAsync(IUser user) => await this.UserManager.GetSecurityStampAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.GetTwoFactorEnabledAsync"/>
        public async Task<bool> GetTwoFactorEnabledAsync(IUser user) => await this.UserManager.GetTwoFactorEnabledAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.GetUserAsync"/>
        public async Task<IUser> GetUserAsync(ClaimsPrincipal principal) => await this.UserManager.GetUserAsync(principal);

        /// <inheritdoc cref="UserManager{TUser}.GetUserIdAsync"/>
        public async Task<string> GetUserIdAsync(IUser user) => await this.UserManager.GetUserIdAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.GetValidTwoFactorProvidersAsync"/>
        public async Task<IList<string>> GetValidTwoFactorProvidersAsync(IUser user) => await this.UserManager.GetValidTwoFactorProvidersAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.HasPasswordAsync"/>
        public async Task<bool> HasPasswordAsync(IUser user) => await this.UserManager.HasPasswordAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.IsEmailConfirmedAsync"/>
        public async Task<bool> IsEmailConfirmedAsync(IUser user) => await this.UserManager.IsEmailConfirmedAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.IsInRoleAsync"/>
        public async Task<bool> IsInRoleAsync(IUser user, string role) => await this.UserManager.IsInRoleAsync((User)user, role);

        /// <inheritdoc cref="UserManager{TUser}.IsLockedOutAsync"/>
        public async Task<bool> IsLockedOutAsync(IUser user) => await this.UserManager.IsLockedOutAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.IsPhoneNumberConfirmedAsync"/>
        public async Task<bool> IsPhoneNumberConfirmedAsync(IUser user) => await this.UserManager.IsPhoneNumberConfirmedAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.RedeemTwoFactorRecoveryCodeAsync"/>
        public async Task<IdentityResult> RedeemTwoFactorRecoveryCodeAsync(IUser user, string code) => await this.UserManager.RedeemTwoFactorRecoveryCodeAsync((User)user, code);

        /// <inheritdoc cref="UserManager{TUser}.RemoveAuthenticationTokenAsync"/>
        public async Task<IdentityResult> RemoveAuthenticationTokenAsync(IUser user, string loginProvider, string tokenName) => await this.UserManager.RemoveAuthenticationTokenAsync((User)user, loginProvider, tokenName);

        /// <inheritdoc cref="UserManager{TUser}.RemoveClaimAsync"/>
        public async Task<IdentityResult> RemoveClaimAsync(IUser user, Claim claim) => await this.UserManager.RemoveClaimAsync((User)user, claim);

        /// <inheritdoc cref="UserManager{TUser}.RemoveClaimsAsync"/>
        public async Task<IdentityResult> RemoveClaimsAsync(IUser user, IEnumerable<Claim> claims) => await this.UserManager.RemoveClaimsAsync((User)user, claims);

        /// <inheritdoc cref="UserManager{TUser}.RemoveFromRoleAsync"/>
        public async Task<IdentityResult> RemoveFromRoleAsync(IUser user, string role) => await this.UserManager.RemoveFromRoleAsync((User)user, role);

        /// <inheritdoc cref="UserManager{TUser}.RemoveFromRolesAsync"/>
        public async Task<IdentityResult> RemoveFromRolesAsync(IUser user, IEnumerable<string> roles) => await this.UserManager.RemoveFromRolesAsync((User)user, roles);

        /// <inheritdoc cref="UserManager{TUser}.RemoveLoginAsync"/>
        public async Task<IdentityResult> RemoveLoginAsync(IUser user, string loginProvider, string providerKey) => await this.UserManager.RemoveLoginAsync((User)user, loginProvider, providerKey);

        /// <inheritdoc cref="UserManager{TUser}.RemovePasswordAsync"/>
        public async Task<IdentityResult> RemovePasswordAsync(IUser user) => await this.UserManager.RemovePasswordAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.ReplaceClaimAsync"/>
        public async Task<IdentityResult> ReplaceClaimAsync(IUser user, Claim claim, Claim newClaim) => await this.UserManager.ReplaceClaimAsync((User)user, claim, newClaim);

        /// <inheritdoc cref="UserManager{TUser}.ResetAccessFailedCountAsync"/>
        public async Task<IdentityResult> ResetAccessFailedCountAsync(IUser user) => await this.UserManager.ResetAccessFailedCountAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.ResetAuthenticatorKeyAsync"/>
        public async Task<IdentityResult> ResetAuthenticatorKeyAsync(IUser user) => await this.UserManager.ResetAuthenticatorKeyAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.ResetPasswordAsync"/>
        public async Task<IdentityResult> ResetPasswordAsync(IUser user, string token, string newPassword) => await this.UserManager.ResetPasswordAsync((User)user, token, newPassword);

        /// <inheritdoc cref="UserManager{TUser}.SetAuthenticationTokenAsync"/>
        public async Task<IdentityResult> SetAuthenticationTokenAsync(IUser user, string loginProvider, string tokenName, string tokenValue) => await this.UserManager.SetAuthenticationTokenAsync((User)user, loginProvider, tokenName, tokenValue);

        /// <inheritdoc cref="UserManager{TUser}.SetEmailAsync"/>
        public async Task<IdentityResult> SetEmailAsync(IUser user, string email) => await this.UserManager.SetEmailAsync((User)user, email);

        /// <inheritdoc cref="UserManager{TUser}.SetLockoutEnabledAsync"/>
        public async Task<IdentityResult> SetLockoutEnabledAsync(IUser user, bool enabled) => await this.UserManager.SetLockoutEnabledAsync((User)user, enabled);

        /// <inheritdoc cref="UserManager{TUser}.SetLockoutEndDateAsync"/>
        public async Task<IdentityResult> SetLockoutEndDateAsync(IUser user, DateTimeOffset? lockoutEnd) => await this.UserManager.SetLockoutEndDateAsync((User)user, lockoutEnd);

        /// <inheritdoc cref="UserManager{TUser}.SetPhoneNumberAsync"/>
        public async Task<IdentityResult> SetPhoneNumberAsync(IUser user, string phoneNumber) => await this.UserManager.SetPhoneNumberAsync((User)user, phoneNumber);

        /// <inheritdoc cref="UserManager{TUser}.SetTwoFactorEnabledAsync"/>
        public async Task<IdentityResult> SetTwoFactorEnabledAsync(IUser user, bool enabled) => await this.UserManager.SetTwoFactorEnabledAsync((User)user, enabled);

        /// <inheritdoc cref="UserManager{TUser}.UpdateAsync"/>
        public async Task<IdentityResult> UpdateAsync(IUser user) => await this.UserManager.UpdateAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.UpdateSecurityStampAsync"/>
        public async Task<IdentityResult> UpdateSecurityStampAsync(IUser user) => await this.UserManager.UpdateSecurityStampAsync((User)user);

        /// <inheritdoc cref="UserManager{TUser}.VerifyTwoFactorTokenAsync"/>
        public async Task<bool> VerifyTwoFactorTokenAsync(IUser user, string tokenProvider, string token) => await this.UserManager.VerifyTwoFactorTokenAsync((User)user, tokenProvider, token);

        /// <inheritdoc cref="UserManager{TUser}.VerifyUserTokenAsync"/>
        public async Task<bool> VerifyUserTokenAsync(IUser user, string tokenProvider, string purpose, string token) => await this.UserManager.VerifyUserTokenAsync((User)user, tokenProvider, purpose, token);

        /// <inheritdoc cref="UserManager{TUser}.RegisterTokenProvider"/>
        public void RegisterTokenProvider(string providerName, IUserTwoFactorTokenProvider<IUser> provider) => this.UserManager.RegisterTokenProvider(providerName, (IUserTwoFactorTokenProvider<User>)provider);
    }
}
