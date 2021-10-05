using System.Threading.Tasks;
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

namespace Definux.Emeraude.Client.Controllers.Api
{
    /// <summary>
    /// Client API upload controller.
    /// </summary>
    [Route("/api/client/upload/")]
    [Authorize(AuthenticationSchemes = AuthenticationDefaults.ClientAuthenticationScheme)]
    [Authorize(AuthenticationSchemes = AuthenticationDefaults.BearerAuthenticationScheme)]
    public sealed class ClientUploadApiController : EmApiController
    {
        private readonly EmFilesOptions filesOptions;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUploadApiController"/> class.
        /// </summary>
        /// <param name="optionsProvider"></param>
        public ClientUploadApiController(IEmOptionsProvider optionsProvider)
        {
            this.filesOptions = optionsProvider.GetFilesOptions();
        }

        /// <summary>
        /// Upload image action.
        /// </summary>
        /// <param name="formFile"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("image")]
        public async Task<IActionResult> Image([FromForm(Name = "file")]IFormFile formFile)
        {
            if (!this.filesOptions.AllowImageUpload)
            {
                return this.NotFound();
            }

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
            if (!this.filesOptions.AllowVideoUpload)
            {
                return this.NotFound();
            }

            return this.UploadFileResponse(await this.Mediator.Send(new UploadVideoCommand(formFile)));
        }
    }
}
