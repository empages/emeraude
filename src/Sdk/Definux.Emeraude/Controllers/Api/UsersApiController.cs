using System.Threading.Tasks;
using Definux.Emeraude.Admin.ClientBuilder.DataAnnotations;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword;
using Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserAvatar;
using Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserName;
using Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword;
using Definux.Emeraude.Application.Requests.Identity.Commands.RemoveExternalLoginProvider;
using Definux.Emeraude.Application.Requests.Identity.Commands.RequestChangeEmail;
using Definux.Emeraude.Application.Requests.Identity.Queries.GetUserAvatar;
using Definux.Emeraude.Application.Requests.Identity.Queries.GetUserExternalLoginProviders;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Presentation.Controllers;
using Definux.Utilities.Objects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Controllers.Api
{
    /// <summary>
    /// Client API user utilities controller.
    /// </summary>
    [Route("/api/users/")]
    [Authorize(AuthenticationSchemes = AuthenticationDefaults.ClientAuthenticationScheme)]
    [Authorize(AuthenticationSchemes = AuthenticationDefaults.JwtBearerAuthenticationScheme)]
    [ApiEndpointsController]
    public sealed class UsersApiController : ApiController
    {
        private readonly ICurrentUserProvider currentUserProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApiController"/> class.
        /// </summary>
        /// <param name="currentUserProvider"></param>
        public UsersApiController(
            ICurrentUserProvider currentUserProvider)
        {
            this.currentUserProvider = currentUserProvider;
            this.HideActivityLogParameters = true;
        }

        /// <summary>
        /// Gets the current user avatar file result.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("current/avatar")]
        public async Task<IActionResult> GetCurrentUserAvatar()
        {
            var currentUser = await this.currentUserProvider.GetCurrentUserAsync();
            var avatarResult = await this.Mediator.Send(new GetUserAvatarQuery { UserId = currentUser.Id });

            return this.File(avatarResult.Avatar.Stream, avatarResult.Avatar.ContentType);
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
        [HttpDelete]
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
