using System.Linq;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword;
using Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserAvatar;
using Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserName;
using Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword;
using Definux.Emeraude.Application.Requests.Identity.Commands.RemoveExternalLoginProvider;
using Definux.Emeraude.Application.Requests.Identity.Commands.RequestChangeEmail;
using Definux.Emeraude.Application.Requests.Identity.Queries.GetUserAvatar;
using Definux.Emeraude.Application.Requests.Identity.Queries.GetUserExternalLoginProviders;
using Definux.Emeraude.Client.Models;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Presentation.Attributes;
using Definux.Emeraude.Presentation.Controllers;
using Definux.Utilities.Objects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Client.Controllers.Api
{
    /// <summary>
    /// Client API user utilities controller.
    /// </summary>
    [Route("/api/users/")]
    [Authorize(AuthenticationSchemes = AuthenticationDefaults.ClientAuthenticationScheme)]
    [Authorize(AuthenticationSchemes = AuthenticationDefaults.BearerAuthenticationScheme)]
    [ApiEndpointsController]
    public sealed class ClientUsersApiController : ApiController
    {
        private readonly ICurrentUserProvider currentUserProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUsersApiController"/> class.
        /// </summary>
        /// <param name="currentUserProvider"></param>
        public ClientUsersApiController(
            ICurrentUserProvider currentUserProvider)
        {
            this.currentUserProvider = currentUserProvider;
            this.HideActivityLogParameters = true;
        }

        /// <summary>
        /// Gets the current user.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("current")]
        [AllowAnonymous]
        [Endpoint(typeof(RequestCurrentUser))]
        public async Task<IActionResult> GetCurrentUser()
        {
            var currentUser = await this.currentUserProvider.GetCurrentUserAsync();
            var user = new RequestCurrentUser
            {
                IsAuthenticated = this.User.Identity?.IsAuthenticated ?? false,
                Roles = new string[] { },
            };

            if (user.IsAuthenticated && currentUser != null)
            {
                user.Roles = this
                    .User
                    .Claims
                    .Where(x => x.Type == System.Security.Claims.ClaimTypes.Role)
                    .Select(x => x.Value)
                    .ToArray();
                user.Email = currentUser.Email;
                user.Name = currentUser.Name;
            }

            return this.Ok(user);
        }

        /// <summary>
        /// Gets the current user avatar file result.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("current/avatar")]
        [Endpoint(typeof(UserAvatarValue))]
        public async Task<IActionResult> GetCurrentUserAvatar()
        {
            var currentUser = await this.currentUserProvider.GetCurrentUserAsync();
            var avatarResult = await this.Mediator.Send(new GetUserAvatarQuery { UserId = currentUser.Id });

            return this.Ok(avatarResult.Avatar);
        }

        /// <summary>
        /// Gets flag result that indicates whether the avatar is default or not.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("current/avatar/type")]
        [Endpoint(typeof(UserAvatarTypeResult))]
        public async Task<IActionResult> GetUserAvatarType()
        {
            var currentUser = await this.currentUserProvider.GetCurrentUserAsync();
            var avatarResult = await this.Mediator.Send(new GetUserAvatarQuery
            {
                UserId = currentUser.Id,
            });

            return this.Ok(avatarResult.GetUserAvatarType());
        }

        /// <summary>
        /// Changes the avatar of current user.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("current/avatar/change")]
        [Endpoint(typeof(SimpleResult))]
        public async Task<IActionResult> ChangeUserAvatar([FromBody]ChangeUserAvatarCommand request)
        {
            if (request != null)
            {
                var currentUser = await this.currentUserProvider.GetCurrentUserAsync();
                request.UserId = currentUser.Id;
            }
            else
            {
                return this.BadRequest();
            }

            return this.Ok(await this.Mediator.Send(request));
        }

        /// <summary>
        /// Changes the password of the current user.
        /// </summary>
        /// <param name="request"></param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        [HttpPut]
        [Route("current/password/change")]
        [Endpoint(typeof(SimpleResult))]
        public async Task<IActionResult> ChangeUserPassword([FromBody]ChangePasswordCommand request)
        {
            if (request != null)
            {
                var currentUser = await this.currentUserProvider.GetCurrentUserAsync();
                request.UserId = currentUser.Id;
            }
            else
            {
                return this.BadRequest();
            }

            return this.Ok(await this.Mediator.Send(request));
        }

        /// <summary>
        /// Changes the name of the current user.
        /// </summary>
        /// <param name="request"></param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        [HttpPut]
        [Route("current/name/change")]
        [Endpoint(typeof(SimpleResult))]
        public async Task<IActionResult> ChangeUserName([FromBody]ChangeUserNameCommand request)
        {
            if (request != null)
            {
                var currentUser = await this.currentUserProvider.GetCurrentUserAsync();
                request.UserId = currentUser.Id;
            }
            else
            {
                return this.BadRequest();
            }

            return this.Ok(await this.Mediator.Send(request));
        }

        /// <summary>
        /// Gets collection of external login providers for the current user.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("current/external-login-providers")]
        [Endpoint(typeof(GetUserExternalLoginProvidersResult))]
        public async Task<IActionResult> GetCurrentUserExternalLoginProviders()
        {
            var currentUser = await this.currentUserProvider.GetCurrentUserAsync();
            var externalLoginProvidersResult = await this.Mediator.Send(new GetUserExternalLoginProvidersQuery
            {
                UserId = currentUser.Id,
            });

            return this.Ok(externalLoginProvidersResult);
        }

        /// <summary>
        /// Remove specified external login provider for the current user.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("current/remove-external-login-provider")]
        [Endpoint(typeof(SimpleResult))]
        public async Task<IActionResult> RemoveCurrentUserExternalLoginProvider([FromBody]RemoveExternalLoginProviderCommand request)
        {
            if (request != null)
            {
                var currentUser = await this.currentUserProvider.GetCurrentUserAsync();
                request.UserId = currentUser.Id;
            }
            else
            {
                return this.BadRequest();
            }

            return this.Ok(await this.Mediator.Send(request));
        }

        /// <summary>
        /// Make a request for change the email for the current user.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("current/request-change-email")]
        [Endpoint(typeof(SimpleResult))]
        public async Task<IActionResult> RequestChangeEmailForTheCurrentUser([FromBody]RequestChangeEmailCommand request)
        {
            if (request != null)
            {
                var currentUser = await this.currentUserProvider.GetCurrentUserAsync();
                request.UserId = currentUser.Id;
                request.ConfigureCallbackOptions("confirm-change-email", true);
            }
            else
            {
                return this.BadRequest();
            }

            return this.Ok(await this.Mediator.Send(request));
        }

        /// <summary>
        /// Make a request for reset password for the current user.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("current/reset-password")]
        [Endpoint(typeof(SimpleResult))]
        public async Task<IActionResult> RequestResetPasswordForTheCurrentUser()
        {
            var currentUser = await this.currentUserProvider.GetCurrentUserAsync();
            var request = new ForgotPasswordCommand
            {
                Email = currentUser.Email,
            };

            return this.Ok(await this.Mediator.Send(request));
        }
    }
}
