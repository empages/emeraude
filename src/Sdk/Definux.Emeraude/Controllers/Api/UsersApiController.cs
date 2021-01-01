﻿using System.Threading.Tasks;
using Definux.Emeraude.Admin.ClientBuilder.DataAnnotations;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword;
using Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserAvatar;
using Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserName;
using Definux.Emeraude.Application.Requests.Identity.Queries.GetUserAvatar;
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
    }
}
