using System.Threading.Tasks;
using Definux.Emeraude.Application.Files;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Application.Requests.Identity.Queries.GetUserAvatar;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Presentation.Controllers;
using Definux.Utilities.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Client.Controllers.Utilities
{
    /// <summary>
    /// Client API user utilities controller.
    /// </summary>
    [Route("/utils/client/user/")]
    public sealed class ClientUserUtilitiesController : PublicController
    {
        private readonly ICurrentUserProvider currentUserProvider;
        private readonly ISystemFilesService systemFileService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUserUtilitiesController"/> class.
        /// </summary>
        /// <param name="currentUserProvider"></param>
        /// <param name="systemFileService"></param>
        public ClientUserUtilitiesController(
            ICurrentUserProvider currentUserProvider,
            ISystemFilesService systemFileService)
        {
            this.currentUserProvider = currentUserProvider;
            this.systemFileService = systemFileService;
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
