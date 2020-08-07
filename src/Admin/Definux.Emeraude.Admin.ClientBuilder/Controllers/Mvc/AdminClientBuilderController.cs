using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Definux.Emeraude.Admin.ClientBuilder.Shared;
using Definux.Emeraude.Application.Common.Exceptions;
using Definux.Emeraude.Configuration.Authorization;

namespace Definux.Emeraude.Admin.ClientBuilder.Controllers.Mvc
{

    [Area("Admin")]
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(AuthenticationSchemes = AuthenticationDefaults.AdminAuthenticationScheme)]
    public class AdminClientBuilderController : Controller
    {
        public AdminClientBuilderController(IHostEnvironment hostEnvironment)
        {
            if (!hostEnvironment.IsDevelopment())
            {
                throw new DevelopmentOnlyException(ClientBuilderMessages.ProtectedControllerExceptionMessage);
            }
        }

        [HttpGet]
        [Route("/admin/client-builder/{**route}")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
