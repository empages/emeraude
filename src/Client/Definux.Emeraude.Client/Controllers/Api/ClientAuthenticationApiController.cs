using System.Threading.Tasks;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Client.Extensions;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Identity;
using Definux.Emeraude.Identity.Extensions;
using Definux.Emeraude.Presentation.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;

namespace Definux.Emeraude.Client.Controllers.Api
{
    /// <summary>
    /// Client API controller for authentication.
    /// </summary>
    [Route("/api/auth/")]
    public sealed partial class ClientAuthenticationApiController : ApiController
    {
        private readonly IUserClaimsService userClaimsService;
        private readonly IUserTokensService userTokensService;
        private readonly IExternalProviderAuthenticatorFactory externalProviderAuthenticatorFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientAuthenticationApiController"/> class.
        /// </summary>
        /// <param name="userClaimsService"></param>
        /// <param name="userTokensService"></param>
        /// <param name="externalProviderAuthenticatorFactory"></param>
        public ClientAuthenticationApiController(
            IUserClaimsService userClaimsService,
            IUserTokensService userTokensService,
            IExternalProviderAuthenticatorFactory externalProviderAuthenticatorFactory)
        {
            this.userClaimsService = userClaimsService;
            this.userTokensService = userTokensService;
            this.externalProviderAuthenticatorFactory = externalProviderAuthenticatorFactory;
            this.HideActivityLogParameters = true;
        }

        /// <inheritdoc/>
        public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!this.OptionsProvider.GetClientOptions().HasClientApiAuthentication)
            {
                context.Result = this.NotFound();
            }

            return base.OnActionExecutionAsync(context, next);
        }
    }
}
