using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Definux.Emeraude.Identity.Services
{
    public abstract class DefaultUserManager
    {
        protected readonly UserManager<User> userManager;

        public DefaultUserManager(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IdentityResult> AccessFailedAsync(IUser user) => await this.userManager.AccessFailedAsync((User)user);
        public async Task<IdentityResult> AddClaimAsync(IUser user, Claim claim) => await this.userManager.AddClaimAsync((User)user, claim);
        public async Task<IdentityResult> AddClaimsAsync(IUser user, IEnumerable<Claim> claims) => await this.userManager.AddClaimsAsync((User)user, claims);
        public async Task<IdentityResult> AddLoginAsync(IUser user, UserLoginInfo login) => await this.userManager.AddLoginAsync((User)user, login);
        public async Task<IdentityResult> AddPasswordAsync(IUser user, string password) => await this.userManager.AddPasswordAsync((User)user, password);
        public async Task<IdentityResult> AddToRoleAsync(IUser user, string role) => await this.userManager.AddToRoleAsync((User)user, role);
        public async Task<IdentityResult> AddToRolesAsync(IUser user, IEnumerable<string> roles) => await this.userManager.AddToRolesAsync((User)user, roles);
        public async Task<IdentityResult> ChangeEmailAsync(IUser user, string newEmail, string token) => await this.userManager.ChangeEmailAsync((User)user, newEmail, token);
        public async Task<IdentityResult> ChangePasswordAsync(IUser user, string currentPassword, string newPassword) => await this.userManager.ChangePasswordAsync((User)user, currentPassword, newPassword);
        public async Task<IdentityResult> ChangePhoneNumberAsync(IUser user, string phoneNumber, string token) => await this.userManager.ChangePhoneNumberAsync((User)user, phoneNumber, token);
        public async Task<bool> CheckPasswordAsync(IUser user, string password) => await this.userManager.CheckPasswordAsync((User)user, password);
        public async Task<IdentityResult> ConfirmEmailAsync(IUser user, string token) => await this.userManager.ConfirmEmailAsync((User)user, token);
        public async Task<int> CountRecoveryCodesAsync(IUser user) => await this.userManager.CountRecoveryCodesAsync((User)user);
        public async Task<IdentityResult> CreateAsync(IUser user) => await this.userManager.CreateAsync((User)user);
        public async Task<IdentityResult> CreateAsync(IUser user, string password) => await this.userManager.CreateAsync((User)user, password);
        public async Task<byte[]> CreateSecurityTokenAsync(IUser user) => await this.userManager.CreateSecurityTokenAsync((User)user);
        public async Task<IdentityResult> DeleteAsync(IUser user) => await this.userManager.DeleteAsync((User)user);
        public async Task<IUser> FindUserByEmailAsync(string email) => await this.userManager.FindByEmailAsync(email);
        public async Task<IUser> FindUserByIdAsync(Guid userId) => await this.userManager.FindByIdAsync(userId.ToString());
        public async Task<IUser> FindUserByLoginAsync(string loginProvider, string providerKey) => await this.userManager.FindByLoginAsync(loginProvider, providerKey);
        public async Task<IUser> FindUserByNameAsync(string userName) => await this.userManager.FindByNameAsync(userName);
        public async Task<string> GenerateChangeEmailTokenAsync(IUser user, string newEmail) => await this.userManager.GenerateChangeEmailTokenAsync((User)user, newEmail);
        public async Task<string> GenerateChangePhoneNumberTokenAsync(IUser user, string phoneNumber) => await this.userManager.GenerateChangePhoneNumberTokenAsync((User)user, phoneNumber);
        public async Task<string> GenerateConcurrencyStampAsync(IUser user) => await this.userManager.GenerateConcurrencyStampAsync((User)user);
        public async Task<string> GenerateEmailConfirmationTokenAsync(IUser user) => await this.userManager.GenerateEmailConfirmationTokenAsync((User)user);
        public async Task<IEnumerable<string>> GenerateNewTwoFactorRecoveryCodesAsync(IUser user, int number) => await this.userManager.GenerateNewTwoFactorRecoveryCodesAsync((User)user, number);
        public async Task<string> GeneratePasswordResetTokenAsync(IUser user) => await this.userManager.GeneratePasswordResetTokenAsync((User)user);
        public async Task<string> GenerateTwoFactorTokenAsync(IUser user, string tokenProvider) => await this.userManager.GenerateTwoFactorTokenAsync((User)user, tokenProvider);
        public async Task<string> GenerateUserTokenAsync(IUser user, string tokenProvider, string purpose) => await this.userManager.GenerateUserTokenAsync((User)user, tokenProvider, purpose);
        public async Task<int> GetAccessFailedCountAsync(IUser user) => await this.userManager.GetAccessFailedCountAsync((User)user);
        public async Task<string> GetAuthenticationTokenAsync(IUser user, string loginProvider, string tokenName) => await this.userManager.GetAuthenticationTokenAsync((User)user, loginProvider, tokenName);
        public async Task<string> GetAuthenticatorKeyAsync(IUser user) => await this.userManager.GetAuthenticatorKeyAsync((User)user);
        public async Task<IList<Claim>> GetClaimsAsync(IUser user) => await this.userManager.GetClaimsAsync((User)user);
        public async Task<string> GetEmailAsync(IUser user) => await this.userManager.GetEmailAsync((User)user);
        public async Task<bool> GetLockoutEnabledAsync(IUser user) => await this.userManager.GetLockoutEnabledAsync((User)user);
        public async Task<DateTimeOffset?> GetLockoutEndDateAsync(IUser user) => await this.userManager.GetLockoutEndDateAsync((User)user);
        public async Task<IList<UserLoginInfo>> GetLoginsAsync(IUser user) => await this.userManager.GetLoginsAsync((User)user);
        public async Task<string> GetPhoneNumberAsync(IUser user) => await this.userManager.GetPhoneNumberAsync((User)user);
        public async Task<IList<string>> GetRolesAsync(IUser user) => await this.userManager.GetRolesAsync((User)user);
        public async Task<string> GetSecurityStampAsync(IUser user) => await this.userManager.GetSecurityStampAsync((User)user);
        public async Task<bool> GetTwoFactorEnabledAsync(IUser user) => await this.userManager.GetTwoFactorEnabledAsync((User)user);
        public async Task<IUser> GetUserAsync(ClaimsPrincipal principal) => await this.userManager.GetUserAsync(principal);
        public async Task<string> GetUserIdAsync(IUser user) => await this.userManager.GetUserIdAsync((User)user);
        public async Task<IList<string>> GetValidTwoFactorProvidersAsync(IUser user) => await this.userManager.GetValidTwoFactorProvidersAsync((User)user);
        public async Task<bool> HasPasswordAsync(IUser user) => await this.userManager.HasPasswordAsync((User)user);
        public async Task<bool> IsEmailConfirmedAsync(IUser user) => await this.userManager.IsEmailConfirmedAsync((User)user);
        public async Task<bool> IsInRoleAsync(IUser user, string role) => await this.userManager.IsInRoleAsync((User)user, role);
        public async Task<bool> IsLockedOutAsync(IUser user) => await this.userManager.IsLockedOutAsync((User)user);
        public async Task<bool> IsPhoneNumberConfirmedAsync(IUser user) => await this.userManager.IsPhoneNumberConfirmedAsync((User)user);
        public async Task<IdentityResult> RedeemTwoFactorRecoveryCodeAsync(IUser user, string code) => await this.userManager.RedeemTwoFactorRecoveryCodeAsync((User)user, code);
        public async Task<IdentityResult> RemoveAuthenticationTokenAsync(IUser user, string loginProvider, string tokenName) => await this.userManager.RemoveAuthenticationTokenAsync((User)user, loginProvider, tokenName);
        public async Task<IdentityResult> RemoveClaimAsync(IUser user, Claim claim) => await this.userManager.RemoveClaimAsync((User)user, claim);
        public async Task<IdentityResult> RemoveClaimsAsync(IUser user, IEnumerable<Claim> claims) => await this.userManager.RemoveClaimsAsync((User)user, claims);
        public async Task<IdentityResult> RemoveFromRoleAsync(IUser user, string role) => await this.userManager.RemoveFromRoleAsync((User)user, role);
        public async Task<IdentityResult> RemoveFromRolesAsync(IUser user, IEnumerable<string> roles) => await this.userManager.RemoveFromRolesAsync((User)user, roles);
        public async Task<IdentityResult> RemoveLoginAsync(IUser user, string loginProvider, string providerKey) => await this.userManager.RemoveLoginAsync((User)user, loginProvider, providerKey);
        public async Task<IdentityResult> RemovePasswordAsync(IUser user) => await this.userManager.RemovePasswordAsync((User)user);
        public async Task<IdentityResult> ReplaceClaimAsync(IUser user, Claim claim, Claim newClaim) => await this.userManager.ReplaceClaimAsync((User)user, claim, newClaim);
        public async Task<IdentityResult> ResetAccessFailedCountAsync(IUser user) => await this.userManager.ResetAccessFailedCountAsync((User)user);
        public async Task<IdentityResult> ResetAuthenticatorKeyAsync(IUser user) => await this.userManager.ResetAuthenticatorKeyAsync((User)user);
        public async Task<IdentityResult> ResetPasswordAsync(IUser user, string token, string newPassword) => await this.userManager.ResetPasswordAsync((User)user, token, newPassword);
        public async Task<IdentityResult> SetAuthenticationTokenAsync(IUser user, string loginProvider, string tokenName, string tokenValue) => await this.userManager.SetAuthenticationTokenAsync((User)user, loginProvider, tokenName, tokenValue);
        public async Task<IdentityResult> SetEmailAsync(IUser user, string email) => await this.userManager.SetEmailAsync((User)user, email);
        public async Task<IdentityResult> SetLockoutEnabledAsync(IUser user, bool enabled) => await this.userManager.SetLockoutEnabledAsync((User)user, enabled);
        public async Task<IdentityResult> SetLockoutEndDateAsync(IUser user, DateTimeOffset? lockoutEnd) => await this.userManager.SetLockoutEndDateAsync((User)user, lockoutEnd);
        public async Task<IdentityResult> SetPhoneNumberAsync(IUser user, string phoneNumber) => await this.userManager.SetPhoneNumberAsync((User)user, phoneNumber);
        public async Task<IdentityResult> SetTwoFactorEnabledAsync(IUser user, bool enabled) => await this.userManager.SetTwoFactorEnabledAsync((User)user, enabled);
        public async Task<IdentityResult> UpdateAsync(IUser user) => await this.userManager.UpdateAsync((User)user);
        public async Task<IdentityResult> UpdateSecurityStampAsync(IUser user) => await this.userManager.UpdateSecurityStampAsync((User)user);
        public async Task<bool> VerifyTwoFactorTokenAsync(IUser user, string tokenProvider, string token) => await this.userManager.VerifyTwoFactorTokenAsync((User)user, tokenProvider, token);
        public async Task<bool> VerifyUserTokenAsync(IUser user, string tokenProvider, string purpose, string token) => await this.userManager.VerifyUserTokenAsync((User)user, tokenProvider, purpose, token);
        public void RegisterTokenProvider(string providerName, IUserTwoFactorTokenProvider<IUser> provider) => this.userManager.RegisterTokenProvider(providerName, (IUserTwoFactorTokenProvider<User>)provider);
    }
}
