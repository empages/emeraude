using System.Threading.Tasks;
using Definux.Emeraude.Application.Requests.Files.Commands.UploadFile;
using Definux.Emeraude.Application.Requests.Files.Commands.UploadImage;
using Definux.Emeraude.Application.Requests.Files.Commands.UploadVideo;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Files;
using Definux.Emeraude.Files.Extensions;
using Definux.Emeraude.Presentation.Controllers;
using Definux.Emeraude.Presentation.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Definux.Emeraude.Admin.Controllers.Api
{
    /// <summary>
    /// Admin upload API controller.
    /// </summary>
    [Route("/api/admin/upload/")]
    public sealed class AdminUploadApiController : EmAdminApiController
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
            if (!this.OptionsProvider.GetFilesOptions().AllowFileUpload)
            {
                return this.NotFound();
            }

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
            if (!this.OptionsProvider.GetFilesOptions().AllowImageUpload)
            {
                return this.NotFound();
            }

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
            if (!this.OptionsProvider.GetFilesOptions().AllowVideoUpload)
            {
                return this.NotFound();
            }

            return this.UploadFileResponse(await this.Mediator.Send(new UploadVideoCommand(formFile)));
        }
    }
}
