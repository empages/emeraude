using System.Threading.Tasks;
using Definux.Emeraude.Application.Requests.Files.Commands.UploadFile;
using Definux.Emeraude.Application.Requests.Files.Commands.UploadImage;
using Definux.Emeraude.Application.Requests.Files.Commands.UploadVideo;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Presentation.Controllers;
using Definux.Emeraude.Presentation.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Admin.Controllers.Api
{
    /// <summary>
    /// Admin upload API controller.
    /// </summary>
    [Route("/api/admin/upload/")]
    [Authorize(Policy = Policies.AuthorizedUploadPolicy)]
    public sealed class AdminUploadApiController : ApiController
    {
        /// <summary>
        /// Action for file upload.
        /// </summary>
        /// <param name="formFile"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("file")]
        public async Task<IActionResult> File([FromForm(Name = "file")]IFormFile formFile)
        {
            return this.UploadFileResponse(await this.Mediator.Send(new UploadFileCommand(formFile)));
        }

        /// <summary>
        /// Action for image upload.
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
        /// Action for video upload.
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
