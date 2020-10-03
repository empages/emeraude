using System.Threading.Tasks;
using Definux.Emeraude.Application.Requests.Files.Commands.UploadImage;
using Definux.Emeraude.Application.Requests.Files.Commands.UploadVideo;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Presentation.Controllers;
using Definux.Emeraude.Presentation.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Client.Controllers.Api
{
    /// <summary>
    /// Client API upload controller.
    /// </summary>
    [Route("/api/client/upload/")]
    [Authorize(Policy = Policies.AuthorizedUploadPolicy)]
    public sealed class ClientUploadApiController : ApiController
    {
        /// <summary>
        /// Upload image action.
        /// </summary>
        /// <param name="formFile"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("image")]
        public async Task<IActionResult> Image([FromForm(Name = "file")]IFormFile formFile)
        {
            return this.UploadFileResponse(await this.Mediator.Send(new UploadImageCommand(formFile)));
        }

        /// <summary>
        /// Upload video action.
        /// </summary>
        /// <param name="formFile"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("video")]
        public async Task<IActionResult> Video([FromForm(Name = "file")]IFormFile formFile)
        {
            return this.UploadFileResponse(await this.Mediator.Send(new UploadVideoCommand(formFile)));
        }
    }
}
