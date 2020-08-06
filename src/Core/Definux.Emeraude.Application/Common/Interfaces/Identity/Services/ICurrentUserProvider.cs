using Definux.Emeraude.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Common.Interfaces.Identity.Services
{
    public interface ICurrentUserProvider
    {
        Guid? CurrentUserId { get; }

        /// <summary>
        /// Returns current request user.
        /// </summary>
        /// <returns></returns>
        Task<IUser> GetCurrentUserAsync();
    }
}
