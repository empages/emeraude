using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Definux.Emeraude.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Definux.Emeraude.Application.Identity
{
    /// <summary>
    /// Emeraude wrapper of ASP.NET Core User Manager with additional functionalities.
    /// </summary>
    public interface IUserManager
    {
        /// <inheritdoc cref="UserManager{TUser}.Options"/>
        IdentityOptions Options { get; }

        /// <summary>
        /// Returns a flag that indicating whether the specified user is locked out or not.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Task<bool> IsLockedOutAsync(string email);

        /// <summary>
        /// Returns a flag indicating whether the given password is valid for the specified email.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<bool> CheckPasswordAsync(string email, string password);

        /// <summary>
        /// Gets a flag indicating whether the email address for the specified email has been verified, true if the email address is verified otherwise false.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Task<bool> IsEmailConfirmedAsync(string email);

        /// <summary>
        /// Create user object by email and name.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="name"></param>
        /// <param name="confirmedEmail"></param>
        /// <returns></returns>
        IUser CreateUserObject(string email, string name, bool confirmedEmail = false);

        /// <summary>
        /// Extract two factor authenticated user from request context.
        /// </summary>
        /// <returns></returns>
        Task<IUser> GetTwoFactorAuthenticationUserAsync();

        /// <inheritdoc cref="UserManager{TUser}.AccessFailedAsync"/>
        Task<IdentityResult> AccessFailedAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.AddClaimAsync"/>
        Task<IdentityResult> AddClaimAsync(IUser user, Claim claim);

        /// <inheritdoc cref="UserManager{TUser}.AddClaimsAsync"/>
        Task<IdentityResult> AddClaimsAsync(IUser user, IEnumerable<Claim> claims);

        /// <inheritdoc cref="UserManager{TUser}.AddLoginAsync"/>
        Task<IdentityResult> AddLoginAsync(IUser user, UserLoginInfo login);

        /// <inheritdoc cref="UserManager{TUser}.AddPasswordAsync"/>
        Task<IdentityResult> AddPasswordAsync(IUser user, string password);

        /// <inheritdoc cref="UserManager{TUser}.AddToRoleAsync"/>
        Task<IdentityResult> AddToRoleAsync(IUser user, string role);

        /// <inheritdoc cref="UserManager{TUser}.AddToRolesAsync"/>
        Task<IdentityResult> AddToRolesAsync(IUser user, IEnumerable<string> roles);

        /// <inheritdoc cref="UserManager{TUser}.ChangeEmailAsync"/>
        Task<IdentityResult> ChangeEmailAsync(IUser user, string newEmail, string token);

        /// <inheritdoc cref="UserManager{TUser}.ChangePasswordAsync"/>
        Task<IdentityResult> ChangePasswordAsync(IUser user, string currentPassword, string newPassword);

        /// <inheritdoc cref="UserManager{TUser}.ChangePhoneNumberAsync"/>
        Task<IdentityResult> ChangePhoneNumberAsync(IUser user, string phoneNumber, string token);

        /// <inheritdoc cref="UserManager{TUser}.CheckPasswordAsync"/>
        Task<bool> CheckPasswordAsync(IUser user, string password);

        /// <inheritdoc cref="UserManager{TUser}.ConfirmEmailAsync"/>
        Task<IdentityResult> ConfirmEmailAsync(IUser user, string token);

        /// <inheritdoc cref="UserManager{TUser}.CountRecoveryCodesAsync"/>
        Task<int> CountRecoveryCodesAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.CreateAsync"/>
        Task<IdentityResult> CreateAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.CreateAsync"/>
        Task<IdentityResult> CreateAsync(IUser user, string password);

        /// <inheritdoc cref="UserManager{TUser}.CreateSecurityTokenAsync"/>
        Task<byte[]> CreateSecurityTokenAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.DeleteAsync"/>
        Task<IdentityResult> DeleteAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.FindUserByEmailAsync"/>
        Task<IUser> FindUserByEmailAsync(string email);

        /// <inheritdoc cref="UserManager{TUser}.FindUserByIdAsync"/>
        Task<IUser> FindUserByIdAsync(Guid userId);

        /// <inheritdoc cref="UserManager{TUser}.FindUserByLoginAsync"/>
        Task<IUser> FindUserByLoginAsync(string loginProvider, string providerKey);

        /// <inheritdoc cref="UserManager{TUser}.FindUserByNameAsync"/>
        Task<IUser> FindUserByNameAsync(string userName);

        /// <inheritdoc cref="UserManager{TUser}.GenerateChangeEmailTokenAsync"/>
        Task<string> GenerateChangeEmailTokenAsync(IUser user, string newEmail);

        /// <inheritdoc cref="UserManager{TUser}.GenerateChangePhoneNumberTokenAsync"/>
        Task<string> GenerateChangePhoneNumberTokenAsync(IUser user, string phoneNumber);

        /// <inheritdoc cref="UserManager{TUser}.GenerateConcurrencyStampAsync"/>
        Task<string> GenerateConcurrencyStampAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.GenerateEmailConfirmationTokenAsync"/>
        Task<string> GenerateEmailConfirmationTokenAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.GenerateNewTwoFactorRecoveryCodesAsync"/>
        Task<IEnumerable<string>> GenerateNewTwoFactorRecoveryCodesAsync(IUser user, int number);

        /// <inheritdoc cref="UserManager{TUser}.GeneratePasswordResetTokenAsync"/>
        Task<string> GeneratePasswordResetTokenAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.GenerateTwoFactorTokenAsync"/>
        Task<string> GenerateTwoFactorTokenAsync(IUser user, string tokenProvider);

        /// <inheritdoc cref="UserManager{TUser}.GenerateUserTokenAsync"/>
        Task<string> GenerateUserTokenAsync(IUser user, string tokenProvider, string purpose);

        /// <inheritdoc cref="UserManager{TUser}.GetAccessFailedCountAsync"/>
        Task<int> GetAccessFailedCountAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.GetAuthenticationTokenAsync"/>
        Task<string> GetAuthenticationTokenAsync(IUser user, string loginProvider, string tokenName);

        /// <inheritdoc cref="UserManager{TUser}.GetAuthenticatorKeyAsync"/>
        Task<string> GetAuthenticatorKeyAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.GetClaimsAsync"/>
        Task<IList<Claim>> GetClaimsAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.GetEmailAsync"/>
        Task<string> GetEmailAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.GetLockoutEnabledAsync"/>
        Task<bool> GetLockoutEnabledAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.GetLockoutEndDateAsync"/>
        Task<DateTimeOffset?> GetLockoutEndDateAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.GetLoginsAsync"/>
        Task<IList<UserLoginInfo>> GetLoginsAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.GetPhoneNumberAsync"/>
        Task<string> GetPhoneNumberAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.GetRolesAsync"/>
        Task<IList<string>> GetRolesAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.GetSecurityStampAsync"/>
        Task<string> GetSecurityStampAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.GetTwoFactorEnabledAsync"/>
        Task<bool> GetTwoFactorEnabledAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.GetUserIdAsync"/>
        Task<string> GetUserIdAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.GetValidTwoFactorProvidersAsync"/>
        Task<IList<string>> GetValidTwoFactorProvidersAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.HasPasswordAsync"/>
        Task<bool> HasPasswordAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.IsEmailConfirmedAsync"/>
        Task<bool> IsEmailConfirmedAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.IsInRoleAsync"/>
        Task<bool> IsInRoleAsync(IUser user, string role);

        /// <inheritdoc cref="UserManager{TUser}.IsLockedOutAsync"/>
        Task<bool> IsLockedOutAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.IsPhoneNumberConfirmedAsync"/>
        Task<bool> IsPhoneNumberConfirmedAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.RedeemTwoFactorRecoveryCodeAsync"/>
        Task<IdentityResult> RedeemTwoFactorRecoveryCodeAsync(IUser user, string code);

        /// <inheritdoc cref="UserManager{TUser}.RegisterTokenProvider"/>
        void RegisterTokenProvider(string providerName, IUserTwoFactorTokenProvider<IUser> provider);

        /// <inheritdoc cref="UserManager{TUser}.RemoveAuthenticationTokenAsync"/>
        Task<IdentityResult> RemoveAuthenticationTokenAsync(IUser user, string loginProvider, string tokenName);

        /// <inheritdoc cref="UserManager{TUser}.RemoveClaimAsync"/>
        Task<IdentityResult> RemoveClaimAsync(IUser user, Claim claim);

        /// <inheritdoc cref="UserManager{TUser}.RemoveClaimsAsync"/>
        Task<IdentityResult> RemoveClaimsAsync(IUser user, IEnumerable<Claim> claims);

        /// <inheritdoc cref="UserManager{TUser}.RemoveFromRoleAsync"/>
        Task<IdentityResult> RemoveFromRoleAsync(IUser user, string role);

        /// <inheritdoc cref="UserManager{TUser}.RemoveFromRolesAsync"/>
        Task<IdentityResult> RemoveFromRolesAsync(IUser user, IEnumerable<string> roles);

        /// <inheritdoc cref="UserManager{TUser}.RemoveLoginAsync"/>
        Task<IdentityResult> RemoveLoginAsync(IUser user, string loginProvider, string providerKey);

        /// <inheritdoc cref="UserManager{TUser}.RemovePasswordAsync"/>
        Task<IdentityResult> RemovePasswordAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.ReplaceClaimAsync"/>
        Task<IdentityResult> ReplaceClaimAsync(IUser user, Claim claim, Claim newClaim);

        /// <inheritdoc cref="UserManager{TUser}.ResetAccessFailedCountAsync"/>
        Task<IdentityResult> ResetAccessFailedCountAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.ResetAuthenticatorKeyAsync"/>
        Task<IdentityResult> ResetAuthenticatorKeyAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.ResetPasswordAsync"/>
        Task<IdentityResult> ResetPasswordAsync(IUser user, string token, string newPassword);

        /// <inheritdoc cref="UserManager{TUser}.SetAuthenticationTokenAsync"/>
        Task<IdentityResult> SetAuthenticationTokenAsync(IUser user, string loginProvider, string tokenName, string tokenValue);

        /// <inheritdoc cref="UserManager{TUser}.SetEmailAsync"/>
        Task<IdentityResult> SetEmailAsync(IUser user, string email);

        /// <inheritdoc cref="UserManager{TUser}.SetLockoutEnabledAsync"/>
        Task<IdentityResult> SetLockoutEnabledAsync(IUser user, bool enabled);

        /// <inheritdoc cref="UserManager{TUser}.SetLockoutEndDateAsync"/>
        Task<IdentityResult> SetLockoutEndDateAsync(IUser user, DateTimeOffset? lockoutEnd);

        /// <inheritdoc cref="UserManager{TUser}.SetPhoneNumberAsync"/>
        Task<IdentityResult> SetPhoneNumberAsync(IUser user, string phoneNumber);

        /// <inheritdoc cref="UserManager{TUser}.SetTwoFactorEnabledAsync"/>
        Task<IdentityResult> SetTwoFactorEnabledAsync(IUser user, bool enabled);

        /// <inheritdoc cref="UserManager{TUser}.UpdateAsync"/>
        Task<IdentityResult> UpdateAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.UpdateSecurityStampAsync"/>
        Task<IdentityResult> UpdateSecurityStampAsync(IUser user);

        /// <inheritdoc cref="UserManager{TUser}.VerifyTwoFactorTokenAsync"/>
        Task<bool> VerifyTwoFactorTokenAsync(IUser user, string tokenProvider, string token);

        /// <inheritdoc cref="UserManager{TUser}.VerifyUserTokenAsync"/>
        Task<bool> VerifyUserTokenAsync(IUser user, string tokenProvider, string purpose, string token);
    }
}
