using Definux.Emeraude.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Common.Interfaces.Identity.Services
{
    public interface IUserClaimsService
    {

        /// <summary>
        /// Function that returns true or false based on the user rights to access administration panel.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Task<bool> CheckUserForAccessAdministrationPermissionAsync(string email);

        Task<List<Claim>> GetUserClaimsForCookieAsync(Guid userId);

        Task<List<Claim>> GetUserClaimsForJwtTokenAsync(Guid userId);
    }
}
