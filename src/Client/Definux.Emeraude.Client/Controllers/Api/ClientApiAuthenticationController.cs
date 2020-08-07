using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Presentation.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Client.Controllers.Api
{
    [Route("/api/auth/")]
    public partial class ClientApiAuthenticationController : ApiController
    {
        private readonly IUserClaimsService userClaimsService;
        private readonly IUserTokensService userTokensService;

        public ClientApiAuthenticationController(
            IUserClaimsService userClaimsService,
            IUserTokensService userTokensService)
        {
            this.userClaimsService = userClaimsService;
            this.userTokensService = userTokensService;
        }
    }
}
