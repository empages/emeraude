using System.Threading.Tasks;
using Definux.Emeraude.Admin.Controllers.Abstractions;
using Definux.Emeraude.Admin.Requests.DeleteErrorLog;
using Definux.Emeraude.Admin.Requests.GetErrorLogs;
using Definux.Emeraude.Admin.UI.Extensions;
using Definux.Emeraude.Configuration.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Admin.Controllers.Mvc
{
    /// <summary>
    /// Admin controller that contains system settings actions.
    /// </summary>
    [Route("/admin/system/")]
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = AdminPermissions.AccessAdministrationPolicy)]
    public sealed class AdminSystemController : AdminController
    {
        /// <summary>
        /// Error logs action.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="searchQuery"></param>
        /// <returns></returns>
        [Route("error-logs")]
        [HttpGet]
        [Authorize(Policy = AdminPermissions.AccessErrorLogsPolicy)]
        public async Task<IActionResult> ErrorLogs(int page = 1, string searchQuery = null)
        {
            var model = await this.Mediator.Send(new GetErrorLogsQuery { Page = page, SearchQuery = searchQuery });
            this.ViewData.SetSearchQuery(searchQuery);

            return this.View(model);
        }

        /// <summary>
        /// Action for delete error log.
        /// </summary>
        /// <param name="logId"></param>
        /// <param name="page"></param>
        /// <param name="searchQuery"></param>
        /// <returns></returns>
        [Route("error-logs/delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = AdminPermissions.AccessErrorLogsPolicy)]
        public async Task<IActionResult> DeleteErrorLog(
            [FromForm(Name = "LogId")]int logId,
            [FromForm(Name = "ReturnPage")]int page,
            [FromForm(Name = "ReturnSearchQuery")]string searchQuery)
        {
            var result = await this.Mediator.Send(new DeleteErrorLogCommand(logId));

            if (result.Successed)
            {
                this.ShowSuccessNotification("Log has been deleted successfully.");
            }
            else
            {
                this.ShowErrorNotification("Log has not been deleted successfully.");
            }

            return this.RedirectToAction(nameof(this.ErrorLogs), this.ControllerName, new
            {
                searchQuery,
                page,
            });
        }
    }
}
