using Definux.Emeraude.Admin.UI.Adapters;
using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Application.Common.Interfaces.Logging;
using System;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.Adapters
{
    public class IdentityUserInfoAdapter : IIdentityUserInfoAdapter
    {
        private readonly ICurrentUserProvider currentUserProvider;
        private readonly ILogger logger;

        public IdentityUserInfoAdapter(
            ICurrentUserProvider currentUserProvider,
            ILogger logger)
        {
            this.currentUserProvider = currentUserProvider;
            this.logger = logger;
        }

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
                        Email = currentUser.Email
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
