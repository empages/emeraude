using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Common.Interfaces.Identity.Services
{
    /// <summary>
    /// Service for accessing and mutation of user claims.
    /// </summary>
    public interface IUserClaimsService
    {
        /// <summary>
        /// Function that returns true or false based on the user rights to access administration panel.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Task<bool> CheckUserForAccessAdministrationPermissionAsync(string email);

        /// <summary>
        /// Get user claims which can be applied into the session cookie.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<List<Claim>> GetUserClaimsForCookieAsync(Guid userId);

        /// <summary>
        /// Get user claims which can be applied into the JSON web token.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<List<Claim>> GetUserClaimsForJwtTokenAsync(Guid userId);
    }
}
