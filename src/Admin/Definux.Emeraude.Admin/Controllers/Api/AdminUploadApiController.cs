using Definux.Emeraude.Application.Requests.Files.Commands.UploadFile;
using Definux.Emeraude.Application.Requests.Files.Commands.UploadImage;
using Definux.Emeraude.Application.Requests.Files.Commands.UploadVideo;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Presentation.Controllers;
using Definux.Emeraude.Presentation.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.Controllers.Api
{
    [Route("/api/admin/upload/")]
    [Authorize(Policy = Policies.AuthorizedUploadPolicy)]
    public class AdminUploadApiController : ApiController
    {
        [HttpPost]
        [Route("file")]
        public async Task<IActionResult> File([FromForm(Name = "file")]IFormFile formFile)
        {
            return this.UploadFileResponse(await Mediator.Send(new UploadFileCommand(formFile)));
        }

        [HttpPost]
        [Route("image")]
        public async Task<IActionResult> Image([FromForm(Name = "file")]IFormFile formFile)
        {
            return this.UploadFileResponse(await Mediator.Send(new UploadImageCommand(formFile)));
        }

        [HttpPost]
        [Route("video")]
        public async Task<IActionResult> Video([FromForm(Name = "file")]IFormFile formFile)
        {
            return this.UploadFileResponse(await Mediator.Send(new UploadVideoCommand(formFile)));
        }
    }
}
