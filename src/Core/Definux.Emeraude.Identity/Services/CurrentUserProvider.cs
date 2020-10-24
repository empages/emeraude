using System;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Identity.Entities;
using Definux.Utilities.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Definux.Emeraude.Identity.Services
{
    /// <inheritdoc cref="ICurrentUserProvider"/>
    public class CurrentUserProvider : ICurrentUserProvider
    {
        private readonly UserManager<User> userManager;
        private readonly IEmLogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentUserProvider"/> class.
        /// </summary>
        /// <param name="httpAccessor"></param>
        /// <param name="userManager"></param>
        /// <param name="logger"></param>
        public CurrentUserProvider(
            IHttpContextAccessor httpAccessor,
            UserManager<User> userManager,
            IEmLogger logger)
        {
            this.CurrentUserId = httpAccessor.GetCurrentUserId();
            this.userManager = userManager;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public Guid? CurrentUserId { get; }

        /// <inheritdoc/>
        public async Task<IUser> GetCurrentUserAsync()
        {
            try
            {
                if (this.CurrentUserId.HasValue)
                {
                    return await this.userManager.FindByIdAsync(this.CurrentUserId.Value.ToString());
                }

                return null;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return default;
            }
        }
    }
}
