using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Presentation.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Admin.Controllers
{
    /// <summary>
    /// Abstract admin controller that provides all required services and methods you need in the administration panel.
    /// </summary>
    [Area(EmAdminConstants.AreaName)]
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = AdminPermissions.AccessAdministrationPolicy)]
    public abstract class EmAdminController : EmController
    {
    }
}
