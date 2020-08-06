using Definux.Emeraude.Application.Requests.Files.Commands.UploadImage;
using Definux.Emeraude.Application.Requests.Files.Commands.UploadVideo;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Presentation.Controllers;
using Definux.Emeraude.Presentation.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Definux.Emeraude.Client.Controllers.Api
{
    [Route("/api/client/upload/")]
    [Authorize(Policy = Policies.AuthorizedUploadPolicy)]
    public class ClientUploadApiController : ApiController
    {
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
