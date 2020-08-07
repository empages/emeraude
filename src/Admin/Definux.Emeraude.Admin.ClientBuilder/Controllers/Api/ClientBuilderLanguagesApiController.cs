using Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.CreateContentKeyWithContent;
using Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.CreateKeyWithValues;
using Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.CreateLanguage;
using Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.DeleteContentKey;
using Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.DeleteKey;
using Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.DeleteLanguage;
using Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.EditContentKeyWithContent;
using Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.EditTranslation;
using Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.EditTranslationKey;
using Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.MakeLanguageDefault;
using Definux.Emeraude.Admin.ClientBuilder.Requests.Queries.GetLanguages;
using Definux.Emeraude.Admin.ClientBuilder.Requests.Queries.GetStaticContentKey;
using Definux.Emeraude.Admin.ClientBuilder.Requests.Queries.GetStaticContentKeys;
using Definux.Emeraude.Admin.ClientBuilder.Requests.Queries.GetTranslationsGridData;
using Definux.Emeraude.Admin.ClientBuilder.Shared;
using Definux.Emeraude.Application.Common.Exceptions;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Presentation.Controllers;
using Definux.Utilities.Objects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.ClientBuilder.Controllers.Api
{
    [Route("/api/client-builder/languages/")]
    [Authorize(AuthenticationSchemes = AuthenticationDefaults.AdminAuthenticationScheme)]
    public class ClientBuilderLanguagesApiController : ApiController
    {
        public ClientBuilderLanguagesApiController(IHostEnvironment hostEnvironment)
        {
            if (!hostEnvironment.IsDevelopment())
            {
                throw new DevelopmentOnlyException(ClientBuilderMessages.ProtectedControllerExceptionMessage);
            }
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetLanguages()
        {
            return Ok(await Mediator.Send(new GetLanguagesQuery()));
        }

        [HttpGet]
        [Route("grid-data")]
        public async Task<IActionResult> GetTranslationsGridData()
        {
            return Ok(await Mediator.Send(new GetTranslationGridDataQuery()));
        }

        [HttpGet]
        [Route("content-keys")]
        public async Task<IActionResult> GetContentKeys()
        {
            return Ok(await Mediator.Send(new GetStaticContentKeysQuery()));
        }

        [HttpGet]
        [Route("content-keys/{keyId}")]
        public async Task<IActionResult> GetContentKeys(int keyId)
        {
            return Ok(await Mediator.Send(new GetStaticContentKeyQuery { KeyId = keyId }));
        }

        [HttpPost]
        [Route("keys")]
        public async Task<IActionResult> CreateKeyWithValues([FromBody]NewKeyWithValuesRequest request)
        {
            return Ok(await Mediator.Send(new CreateKeyWithValuesCommand(request)));
        }

        [HttpPost]
        [Route("content-keys")]
        public async Task<IActionResult> CreateContentKeyWithValues([FromBody]NewContentKeyWithContentRequest request)
        {
            return Ok(await Mediator.Send(new CreateContentKeyWithContentCommand(request)));
        }

        [HttpPut]
        [Route("keys/{keyId}/edit")]
        public async Task<IActionResult> EditKey(int keyId, [FromBody]SingleValueObject<string> newValue)
        {
            return Ok(await Mediator.Send(new EditTranslationKeyCommand 
            { 
                KeyId = keyId,
                NewValue = newValue.Value
            }));
        }

        [HttpPut]
        [Route("content-keys/{keyId}")]
        public async Task<IActionResult> EditContentKey(int keyId, [FromBody]ContentKeyWithContentRequest request)
        {
            return Ok(await Mediator.Send(new EditContentKeyWithContentCommand(keyId, request)));
        }

        [HttpPut]
        [Route("translations/{translationId}/edit")]
        public async Task<IActionResult> EditTranslation(int translationId, [FromBody]SingleValueObject<string> newValue)
        {
            return Ok(await Mediator.Send(new EditTranslationCommand 
            { 
                TranslationId = translationId,
                NewValue = newValue.Value
            }));
        }

        [HttpDelete]
        [Route("keys/{keyId}")]
        public async Task<IActionResult> DeleteKey(int keyId)
        {
            return Ok(await Mediator.Send(new DeleteKeyCommand
            {
                KeyId = keyId
            }));
        }

        [HttpDelete]
        [Route("content-keys/{keyId}")]
        public async Task<IActionResult> DeleteContentKey(int keyId)
        {
            return Ok(await Mediator.Send(new DeleteContentKeyCommand
            {
                KeyId = keyId
            }));
        }

        [HttpPost]
        [Route("default")]
        public async Task<IActionResult> MakeLanguageDefault([FromBody]SingleValueObject<int> request)
        {
            return Ok(await Mediator.Send(new MakeLanguageDefaultCommand
            {
                LanguageId = request.Value
            }));
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateLanguage([FromBody]CreateLanguageRequest request)
        {
            return Ok(await Mediator.Send(new CreateLanguageCommand(request)));
        }

        [HttpDelete]
        [Route("{languageId}")]
        public async Task<IActionResult> DeleteLanguage(int languageId)
        {
            return Ok(await Mediator.Send(new DeleteLanguageCommand
            {
                LanguageId = languageId
            }));
        }
    }
}
