using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Presentation.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace Definux.Emeraude.Client.Controllers.Api
{
    [Route("/api/auth/")]
    public partial class ClientApiAuthenticationController : ApiController
    {
        private readonly IUserClaimsService userClaimsService;
        private readonly IUserTokensService userTokensService;
        private readonly EmOptions emeraudeOptions;

        public ClientApiAuthenticationController(
            IUserClaimsService userClaimsService,
            IUserTokensService userTokensService,
            IOptions<EmOptions> emeraudeOptionsAccessor)
        {
            this.userClaimsService = userClaimsService;
            this.userTokensService = userTokensService;
            this.emeraudeOptions = emeraudeOptionsAccessor.Value;
        }

        public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!this.emeraudeOptions.Account.HasClientApiAuthentication)
            {
                context.Result = NotFound();
            }

            return base.OnActionExecutionAsync(context, next);
        }
    }
}
