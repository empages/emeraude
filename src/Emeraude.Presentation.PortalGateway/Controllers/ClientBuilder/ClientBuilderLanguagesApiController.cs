using System.Threading.Tasks;
using Emeraude.Application.ClientBuilder.Extensions;
using Emeraude.Application.ClientBuilder.Requests.Commands.CreateContentKeyWithContent;
using Emeraude.Application.ClientBuilder.Requests.Commands.CreateKeyWithValues;
using Emeraude.Application.ClientBuilder.Requests.Commands.CreateLanguage;
using Emeraude.Application.ClientBuilder.Requests.Commands.DeleteContentKey;
using Emeraude.Application.ClientBuilder.Requests.Commands.DeleteKey;
using Emeraude.Application.ClientBuilder.Requests.Commands.DeleteLanguage;
using Emeraude.Application.ClientBuilder.Requests.Commands.EditContentKeyWithContent;
using Emeraude.Application.ClientBuilder.Requests.Commands.EditLanguage;
using Emeraude.Application.ClientBuilder.Requests.Commands.EditTranslationKeyWithValues;
using Emeraude.Application.ClientBuilder.Requests.Commands.MakeLanguageDefault;
using Emeraude.Application.ClientBuilder.Requests.Queries.GetLanguages;
using Emeraude.Application.ClientBuilder.Requests.Queries.GetStaticContentKey;
using Emeraude.Application.ClientBuilder.Requests.Queries.GetStaticContentKeys;
using Emeraude.Application.ClientBuilder.Requests.Queries.GetTranslationsGridData;
using Emeraude.Application.ClientBuilder.Shared;
using Emeraude.Application.Exceptions;
using Emeraude.Configuration.Options;
using Emeraude.Essentials.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Hosting;

namespace Emeraude.Presentation.PortalGateway.Controllers.ClientBuilder
{
    /// <summary>
    /// Client builder controller that manages the languages, translations and static content items of the application.
    /// </summary>
    [Route("/_em/api/client-builder/languages/")]
    public sealed class ClientBuilderLanguagesApiController : EmPortalGatewayApiController
    {
        private readonly IEmOptionsProvider optionsProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientBuilderLanguagesApiController"/> class.
        /// </summary>
        /// <param name="hostEnvironment"></param>
        /// <param name="optionsProvider"></param>
        public ClientBuilderLanguagesApiController(
            IHostEnvironment hostEnvironment,
            IEmOptionsProvider optionsProvider)
        {
            if (!hostEnvironment.IsDevelopment())
            {
                throw new DevelopmentOnlyException(ClientBuilderMessages.ProtectedControllerExceptionMessage);
            }

            this.optionsProvider = optionsProvider;
        }

        /// <summary>
        /// Get list of all supported languages.
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<IActionResult> GetLanguages()
        {
            return this.Ok(await this.Mediator.Send(new GetLanguagesQuery()));
        }

        /// <summary>
        /// Get all language keys and their translations into grid format.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="searchQuery"></param>
        /// <returns></returns>
        [HttpGet("grid-data")]
        public async Task<IActionResult> GetTranslationsGridData([FromQuery]int page = 1, [FromQuery]string searchQuery = "")
        {
            return this.Ok(await this.Mediator.Send(new GetTranslationGridDataQuery
            {
                Page = page,
                SearchQuery = searchQuery,
            }));
        }

        /// <summary>
        /// Gets all static content keys.
        /// </summary>
        /// <returns></returns>
        [HttpGet("content-keys")]
        public async Task<IActionResult> GetContentKeys()
        {
            return this.Ok(await this.Mediator.Send(new GetStaticContentKeysQuery()));
        }

        /// <summary>
        /// Gets a specified static content key.
        /// </summary>
        /// <param name="keyId"></param>
        /// <returns></returns>
        [HttpGet("content-keys/{keyId}")]
        public async Task<IActionResult> GetContentKeys(int keyId)
        {
            return this.Ok(await this.Mediator.Send(new GetStaticContentKeyQuery { KeyId = keyId }));
        }

        /// <summary>
        /// Creates a translation key with values.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("keys")]
        public async Task<IActionResult> CreateKeyWithValues([FromBody]NewKeyWithValuesRequest request)
        {
            return this.Ok(await this.Mediator.Send(new CreateKeyWithValuesCommand(request)));
        }

        /// <summary>
        /// Creates a static content key with values.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("content-keys")]
        public async Task<IActionResult> CreateContentKeyWithValues([FromBody]NewContentKeyWithContentRequest request)
        {
            return this.Ok(await this.Mediator.Send(new CreateContentKeyWithContentCommand(request)));
        }

        /// <summary>
        /// Edits a translation key.
        /// </summary>
        /// <param name="keyId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut("keys/{keyId}/edit")]
        public async Task<IActionResult> EditKey([FromRoute]int keyId, [FromBody]EditTranslationKeyWithValuesCommand request)
        {
            request.Id = keyId;
            return this.Ok(await this.Mediator.Send(request));
        }

        /// <summary>
        /// Edits a static content key.
        /// </summary>
        /// <param name="keyId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut("content-keys/{keyId}")]
        public async Task<IActionResult> EditContentKey([FromRoute]int keyId, [FromBody]ContentKeyWithContentRequest request)
        {
            return this.Ok(await this.Mediator.Send(new EditContentKeyWithContentCommand(keyId, request)));
        }

        /// <summary>
        /// Deletes a translation key.
        /// </summary>
        /// <param name="keyId"></param>
        /// <returns></returns>
        [HttpDelete("keys/{keyId}")]
        public async Task<IActionResult> DeleteKey(int keyId)
        {
            return this.Ok(await this.Mediator.Send(new DeleteKeyCommand
            {
                KeyId = keyId,
            }));
        }

        /// <summary>
        /// Deletes a static content key.
        /// </summary>
        /// <param name="keyId"></param>
        /// <returns></returns>
        [HttpDelete("content-keys/{keyId}")]
        public async Task<IActionResult> DeleteContentKey(int keyId)
        {
            return this.Ok(await this.Mediator.Send(new DeleteContentKeyCommand
            {
                KeyId = keyId,
            }));
        }

        /// <summary>
        /// Makes a language default.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("default")]
        public async Task<IActionResult> MakeLanguageDefault([FromBody]SingleValueObject<int> request)
        {
            return this.Ok(await this.Mediator.Send(new MakeLanguageDefaultCommand
            {
                LanguageId = request.Value,
            }));
        }

        /// <summary>
        /// Creates a language.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<IActionResult> CreateLanguage([FromBody]CreateLanguageRequest request)
        {
            return this.Ok(await this.Mediator.Send(new CreateLanguageCommand(request)));
        }

        /// <summary>
        /// Edits a language.
        /// </summary>
        /// <param name="languageId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut("{languageId}")]
        public async Task<IActionResult> EditLanguage([FromRoute]int languageId, [FromBody]EditLanguageRequest request)
        {
            if (request != null)
            {
                request.Id = languageId;
                return this.Ok(await this.Mediator.Send(new EditLanguageCommand(request)));
            }

            return this.BadRequest();
        }

        /// <summary>
        /// Deletes a language.
        /// </summary>
        /// <param name="languageId"></param>
        /// <returns></returns>
        [HttpDelete("{languageId}")]
        public async Task<IActionResult> DeleteLanguage(int languageId)
        {
            return this.Ok(await this.Mediator.Send(new DeleteLanguageCommand
            {
                LanguageId = languageId,
            }));
        }

        /// <inheritdoc />
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!this.optionsProvider.GetClientBuilderOptions().EnableClientBuilder)
            {
                context.Result = this.NotFound();
            }

            base.OnActionExecuting(context);
        }
    }
}
