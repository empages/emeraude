using System.Threading.Tasks;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Application.Requests.Identity.Queries.GetUserAvatar;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Presentation.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Client.Controllers.Utilities
{
    /// <summary>
    /// Client API user utilities controller.
    /// </summary>
    [Route("/utils/client/users/")]
    public sealed class ClientUsersUtilitiesController : PublicController
    {
        private readonly ICurrentUserProvider currentUserProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUsersUtilitiesController"/> class.
        /// </summary>
        /// <param name="currentUserProvider"></param>
        public ClientUsersUtilitiesController(
            ICurrentUserProvider currentUserProvider)
        {
            this.currentUserProvider = currentUserProvider;
        }

        /// <summary>
        /// Gets the current user avatar file result.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("current/avatar")]
        [Authorize(AuthenticationSchemes = AuthenticationDefaults.ClientAuthenticationScheme)]
        public async Task<IActionResult> GetCurrentUserAvatar()
        {
            var currentUser = await this.currentUserProvider.GetCurrentUserAsync();
            var avatarFileResult = await this.Mediator.Send(new GetUserAvatarQuery { UserId = currentUser.Id });

            return this.File(avatarFileResult.Stream, avatarFileResult.ContentType);
        }
    }
}
