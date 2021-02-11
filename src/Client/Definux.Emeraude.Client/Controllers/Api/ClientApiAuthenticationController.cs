using System.Threading.Tasks;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Configuration.Options;
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
    public sealed partial class ClientApiAuthenticationController : ApiController
    {
        private readonly IUserClaimsService userClaimsService;
        private readonly IUserTokensService userTokensService;
        private readonly EmOptions emeraudeOptions;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientApiAuthenticationController"/> class.
        /// </summary>
        /// <param name="userClaimsService"></param>
        /// <param name="userTokensService"></param>
        /// <param name="emeraudeOptionsAccessor"></param>
        public ClientApiAuthenticationController(
            IUserClaimsService userClaimsService,
            IUserTokensService userTokensService,
            IOptions<EmOptions> emeraudeOptionsAccessor)
        {
            this.userClaimsService = userClaimsService;
            this.userTokensService = userTokensService;
            this.emeraudeOptions = emeraudeOptionsAccessor.Value;
            this.HideActivityLogParameters = true;
        }

        /// <inheritdoc/>
        public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!this.emeraudeOptions.Account.HasClientApiAuthentication)
            {
                context.Result = this.NotFound();
            }

            return base.OnActionExecutionAsync(context, next);
        }
    }
}
