using System;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.UI.Adapters;
using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Application.Common.Interfaces.Logging;

namespace Definux.Emeraude.Admin.Adapters
{
    /// <inheritdoc cref="IIdentityUserInfoAdapter"/>
    public class IdentityUserInfoAdapter : IIdentityUserInfoAdapter
    {
        private readonly ICurrentUserProvider currentUserProvider;
        private readonly ILogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityUserInfoAdapter"/> class.
        /// </summary>
        /// <param name="currentUserProvider"></param>
        /// <param name="logger"></param>
        public IdentityUserInfoAdapter(
            ICurrentUserProvider currentUserProvider,
            ILogger logger)
        {
            this.currentUserProvider = currentUserProvider;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public async Task<UserInfoResult?> GetCurrentUserInfoAsync()
        {
            try
            {
                var currentUser = await this.currentUserProvider.GetCurrentUserAsync();
                if (currentUser != null)
                {
                    return new UserInfoResult
                    {
                        Id = currentUser.Id,
                        Name = currentUser.Name,
                        Email = currentUser.Email,
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return null;
            }
        }
    }
}
