using Definux.Emeraude.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Common.Interfaces.Identity.Services
{
    public interface IUserManager
    {
        // Custom user manager methods
        Task<bool> CheckPasswordAsync(string email, string password);
        Task<bool> IsEmailConfirmedAsync(string email);
        IUser CreateUserObject(string email, string name, bool confirmedEmail = false);
        Task<IUser> GetTwoFactorAuthenticationUserAsync();
        // Default user manager methods
        IdentityOptions Options { get; }
        Task<IdentityResult> AccessFailedAsync(IUser user);
        Task<IdentityResult> AddClaimAsync(IUser user, Claim claim);
        Task<IdentityResult> AddClaimsAsync(IUser user, IEnumerable<Claim> claims);
        Task<IdentityResult> AddLoginAsync(IUser user, UserLoginInfo login);
        Task<IdentityResult> AddPasswordAsync(IUser user, string password);
        Task<IdentityResult> AddToRoleAsync(IUser user, string role);
        Task<IdentityResult> AddToRolesAsync(IUser user, IEnumerable<string> roles);
        Task<IdentityResult> ChangeEmailAsync(IUser user, string newEmail, string token);
        Task<IdentityResult> ChangePasswordAsync(IUser user, string currentPassword, string newPassword);
        Task<IdentityResult> ChangePhoneNumberAsync(IUser user, string phoneNumber, string token);
        Task<bool> CheckPasswordAsync(IUser user, string password);
        Task<IdentityResult> ConfirmEmailAsync(IUser user, string token);
        Task<int> CountRecoveryCodesAsync(IUser user);
        Task<IdentityResult> CreateAsync(IUser user);
        Task<IdentityResult> CreateAsync(IUser user, string password);
        Task<byte[]> CreateSecurityTokenAsync(IUser user);
        Task<IdentityResult> DeleteAsync(IUser user);
        Task<IUser> FindUserByEmailAsync(string email);
        Task<IUser> FindUserByIdAsync(Guid userId);
        Task<IUser> FindUserByLoginAsync(string loginProvider, string providerKey);
        Task<IUser> FindUserByNameAsync(string userName);
        Task<string> GenerateChangeEmailTokenAsync(IUser user, string newEmail);
        Task<string> GenerateChangePhoneNumberTokenAsync(IUser user, string phoneNumber);
        Task<string> GenerateConcurrencyStampAsync(IUser user);
        Task<string> GenerateEmailConfirmationTokenAsync(IUser user);
        Task<IEnumerable<string>> GenerateNewTwoFactorRecoveryCodesAsync(IUser user, int number);
        Task<string> GeneratePasswordResetTokenAsync(IUser user);
        Task<string> GenerateTwoFactorTokenAsync(IUser user, string tokenProvider);
        Task<string> GenerateUserTokenAsync(IUser user, string tokenProvider, string purpose);
        Task<int> GetAccessFailedCountAsync(IUser user);
        Task<string> GetAuthenticationTokenAsync(IUser user, string loginProvider, string tokenName);
        Task<string> GetAuthenticatorKeyAsync(IUser user);
        Task<IList<Claim>> GetClaimsAsync(IUser user);
        Task<string> GetEmailAsync(IUser user);
        Task<bool> GetLockoutEnabledAsync(IUser user);
        Task<DateTimeOffset?> GetLockoutEndDateAsync(IUser user);
        Task<IList<UserLoginInfo>> GetLoginsAsync(IUser user);
        Task<string> GetPhoneNumberAsync(IUser user);
        Task<IList<string>> GetRolesAsync(IUser user);
        Task<string> GetSecurityStampAsync(IUser user);
        Task<bool> GetTwoFactorEnabledAsync(IUser user);
        Task<string> GetUserIdAsync(IUser user);
        Task<IList<string>> GetValidTwoFactorProvidersAsync(IUser user);
        Task<bool> HasPasswordAsync(IUser user);
        Task<bool> IsEmailConfirmedAsync(IUser user);
        Task<bool> IsInRoleAsync(IUser user, string role);
        Task<bool> IsLockedOutAsync(IUser user);
        Task<bool> IsPhoneNumberConfirmedAsync(IUser user);
        Task<IdentityResult> RedeemTwoFactorRecoveryCodeAsync(IUser user, string code);
        void RegisterTokenProvider(string providerName, IUserTwoFactorTokenProvider<IUser> provider);
        Task<IdentityResult> RemoveAuthenticationTokenAsync(IUser user, string loginProvider, string tokenName);
        Task<IdentityResult> RemoveClaimAsync(IUser user, Claim claim);
        Task<IdentityResult> RemoveClaimsAsync(IUser user, IEnumerable<Claim> claims);
        Task<IdentityResult> RemoveFromRoleAsync(IUser user, string role);
        Task<IdentityResult> RemoveFromRolesAsync(IUser user, IEnumerable<string> roles);
        Task<IdentityResult> RemoveLoginAsync(IUser user, string loginProvider, string providerKey);
        Task<IdentityResult> RemovePasswordAsync(IUser user);
        Task<IdentityResult> ReplaceClaimAsync(IUser user, Claim claim, Claim newClaim);
        Task<IdentityResult> ResetAccessFailedCountAsync(IUser user);
        Task<IdentityResult> ResetAuthenticatorKeyAsync(IUser user);
        Task<IdentityResult> ResetPasswordAsync(IUser user, string token, string newPassword);
        Task<IdentityResult> SetAuthenticationTokenAsync(IUser user, string loginProvider, string tokenName, string tokenValue);
        Task<IdentityResult> SetEmailAsync(IUser user, string email);
        Task<IdentityResult> SetLockoutEnabledAsync(IUser user, bool enabled);
        Task<IdentityResult> SetLockoutEndDateAsync(IUser user, DateTimeOffset? lockoutEnd);
        Task<IdentityResult> SetPhoneNumberAsync(IUser user, string phoneNumber);
        Task<IdentityResult> SetTwoFactorEnabledAsync(IUser user, bool enabled);
        Task<IdentityResult> UpdateAsync(IUser user);
        Task<IdentityResult> UpdateSecurityStampAsync(IUser user);
        Task<bool> VerifyTwoFactorTokenAsync(IUser user, string tokenProvider, string token);
        Task<bool> VerifyUserTokenAsync(IUser user, string tokenProvider, string purpose, string token);
    }
}
