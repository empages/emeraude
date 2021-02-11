using System.Threading.Tasks;
using Definux.Emeraude.Admin.Models;
using Definux.Emeraude.Admin.Requests.GetAll;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Identity.Entities;
using Definux.Emeraude.Presentation.Controllers;
using Definux.Utilities.Objects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Admin.Controllers.Api
{
    /// <summary>
    /// Admin users API controller.
    /// </summary>
    [Route("/api/admin/users/")]
    [Authorize(AuthenticationSchemes = AuthenticationDefaults.AdminAuthenticationScheme)]
    [Authorize(Policy = AdminPermissions.AccessAdministrationPolicy)]
    public class AdminUsersApiController : ApiController
    {
        /// <summary>
        /// Fetch users for select purposes.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="searchQuery"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Fetch(
            [FromQuery] int page = 1,
            [FromQuery] string searchQuery = null)
        {
            return this.Ok(await this.Mediator.Send(new GetAllQuery<User, EntitySelectModel>(page, searchQuery)));
        }
    }
}