using Definux.Emeraude.Configuration.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Definux.Emeraude.Admin.UI.Models
{
    /// <summary>
    /// Page model that defines the fallback Host page.
    /// </summary>
    [Authorize(Policy = AdminPermissions.AccessAdministrationPolicy)]
    public class EmHostPage : PageModel
    {
    }
}