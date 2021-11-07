using System.Threading.Tasks;
using Definux.Emeraude.Application.Admin.Adapters;
using Definux.Emeraude.Configuration.Extensions;
using Definux.Emeraude.Essentials.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Presentation.PortalGateway.Controllers.Admin
{
    /// <summary>
    /// Admin authentication API controller.
    /// </summary>
    [Route("/_em/api/admin/general/")]
    [Authorize(Policy = EmPermissions.AccessAdministrationPolicy)]
    public class AdminGeneralApiController : EmPortalGatewayApiController
    {
        private readonly IAdminMenusBuilder adminMenusBuilder;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminGeneralApiController"/> class.
        /// </summary>
        /// <param name="adminMenusBuilder"></param>
        public AdminGeneralApiController(IAdminMenusBuilder adminMenusBuilder)
        {
            this.adminMenusBuilder = adminMenusBuilder;
        }

        /// <summary>
        /// Gets admin menus.
        /// </summary>
        /// <returns></returns>
        [HttpGet("admin-menus")]
        public async Task<IActionResult> GetAdminMenus()
        {
            var adminMenus = await this.adminMenusBuilder.BuildAsync();
            return this.Ok(adminMenus);
        }

        /// <summary>
        /// Gets framework version.
        /// </summary>
        /// <returns></returns>
        [HttpGet("version")]
        public IActionResult GetFrameworkVersion()
        {
            var version = this.OptionsProvider.GetMainOptions().EmeraudeVersion;
            return this.Ok(new { Version = version });
        }
    }
}