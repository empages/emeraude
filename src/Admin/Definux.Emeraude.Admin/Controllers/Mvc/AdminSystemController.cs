using Definux.Emeraude.Admin.Controllers.Abstractions;
using Definux.Emeraude.Admin.Requests.DeleteErrorLog;
using Definux.Emeraude.Admin.Requests.GetErrorLogs;
using Definux.Emeraude.Admin.UI.Extensions;
using Definux.Emeraude.Configuration.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.Controllers.Mvc
{
    [Route("/admin/system/")]
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = AdminPermissions.AccessAdministrationPolicy)]
    public class AdminSystemController : AdminController
    {
        [Route("error-logs")]
        [HttpGet]
        public async Task<IActionResult> ErrorLogs(int page = 1, string searchQuery = null)
        {
            var model = await Mediator.Send(new GetErrorLogsQuery { Page = page, SearchQuery = searchQuery });
            ViewData.SetSearchQuery(searchQuery);

            return View(model);
        }

        [Route("error-logs/delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteErrorLog(
            [FromForm(Name = "LogId")]int logId,
            [FromForm(Name = "ReturnPage")]int page,
            [FromForm(Name = "ReturnSearchQuery")]string searchQuery)
        {
            var result = await Mediator.Send(new DeleteErrorLogCommand(logId));

            if (result.Successed)
            {
                ShowSuccessNotification("Log has been deleted successfully.");
            }
            else
            {
                ShowErrorNotification("Log has not been deleted successfully.");
            }

            return RedirectToAction(nameof(ErrorLogs), ControllerName, new 
            {
                searchQuery,
                page
            });
        }
    }
}
