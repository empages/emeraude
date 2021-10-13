using Definux.Emeraude.Essentials.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Definux.Emeraude.Admin.EmPages.UI.Models
{
    /// <summary>
    /// Page model that defines the fallback Host page.
    /// </summary>
    [Authorize(Policy = EmPermissions.AccessAdministrationPolicy)]
    public class EmHostPage : PageModel
    {
    }
}