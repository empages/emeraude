using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Emeraude.Application.Common.Interfaces.Persistence;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Identity.Entities;
using Definux.Utilities.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Definux.Emeraude.Identity.Services
{
    public class CurrentUserProvider : ICurrentUserProvider
    {
        private readonly UserManager<User> userManager;
        private readonly ILogger logger;

        public CurrentUserProvider(
            IHttpContextAccessor httpAccessor, 
            UserManager<User> userManager, 
            ILogger logger)
        {
            this.CurrentUserId = httpAccessor.GetCurrentUserId();
            this.userManager = userManager;
            this.logger = logger;
        }

        public Guid? CurrentUserId { get; }

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
