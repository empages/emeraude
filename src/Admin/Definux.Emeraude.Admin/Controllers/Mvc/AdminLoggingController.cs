using System;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.Requests.DeleteLog;
using Definux.Emeraude.Admin.Requests.FetchLogs;
using Definux.Emeraude.Admin.Requests.GetEmailBody;
using Definux.Emeraude.Admin.UI.Extensions;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Application.Models;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Domain.Entities;
using Definux.Utilities.Objects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Admin.Controllers.Mvc
{
    /// <summary>
    /// Admin controller that contains system settings actions.
    /// </summary>
    [Route("/admin/logging/")]
    [Authorize(Policy = AdminPermissions.AccessLogsPolicy)]
    public sealed class AdminLoggingController : EmAdminController
    {
        private const string ActivityLogsRouteParam = "activity";
        private const string ErrorsLogsRouteParam = "errors";
        private const string EmailsLogsRouteParam = "emails";
        private const string TempFilesLogsRouteParam = "temp-files";

        private readonly IUserManager userManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminLoggingController"/> class.
        /// </summary>
        /// <param name="userManager"></param>
        public AdminLoggingController(IUserManager userManager)
        {
            this.userManager = userManager;
            this.DisableActivityLog = true;
        }

        /// <summary>
        /// Action for delete error log.
        /// </summary>
        /// <param name="logType"></param>
        /// <param name="logId"></param>
        /// <param name="returnUrl"></param>
        /// <returns></returns>
        [Route("{logType}/delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = AdminPermissions.AccessLogsPolicy)]
        public async Task<IActionResult> DeleteLog(
            [FromRoute]string logType,
            [FromForm(Name = "LogId")]int logId,
            [FromForm(Name = "ReturnUrl")]string returnUrl)
        {
            var result = logType switch
            {
                ActivityLogsRouteParam => await this.Mediator.Send(new DeleteActivityLogCommand(logId)),
                ErrorsLogsRouteParam => await this.Mediator.Send(new DeleteErrorLogCommand(logId)),
                EmailsLogsRouteParam => await this.Mediator.Send(new DeleteEmailLogCommand(logId)),
                TempFilesLogsRouteParam => await this.Mediator.Send(new DeleteTempFileLogCommand(logId)),
                _ => SimpleResult.UnsuccessfulResult
            };

            // if (result.Succeeded)
            // {
            //     this.ShowSuccessNotification("Log has been deleted successfully.");
            // }
            // else
            // {
            //     this.ShowErrorNotification("Log has not been deleted successfully.");
            // }

            return this.LocalRedirect(returnUrl);
        }

        /// <summary>
        /// Fetch logs action.
        /// </summary>
        /// <param name="logType"></param>
        /// <param name="page"></param>
        /// <param name="searchQuery"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        [Route("{logType}")]
        [HttpGet]
        public async Task<IActionResult> FetchLogs(
            [FromRoute]string logType,
            [FromQuery]int page = 1,
            [FromQuery]string searchQuery = null,
            [FromQuery]DateModel? fromDate = null,
            [FromQuery]DateModel? toDate = null,
            [FromQuery]string user = null)
        {
            return logType switch
            {
                ActivityLogsRouteParam => await this.LogsActionAsync<FetchActivityLogsQuery>("ActivityLogs", page, searchQuery, fromDate, toDate, user),
                ErrorsLogsRouteParam => await this.LogsActionAsync<FetchErrorLogsQuery>("ErrorsLogs", page, searchQuery, fromDate, toDate, user),
                EmailsLogsRouteParam => await this.LogsActionAsync<FetchEmailLogsQuery>("EmailsLogs", page, searchQuery, fromDate, toDate, user),
                TempFilesLogsRouteParam => await this.LogsActionAsync<FetchTempFileLogsQuery>("TempFilesLogs", page, searchQuery, fromDate, toDate, user),
                _ => this.NotFound()
            };
        }

        /// <summary>
        /// Returns email body from specified email log.
        /// </summary>
        /// <param name="emailLogId"></param>
        /// <returns></returns>
        [Route("emails/{emailLogId}/body")]
        [HttpGet]
        public async Task<IActionResult> EmailBody([FromRoute] int emailLogId)
        {
            try
            {
                return this.View(nameof(this.EmailBody), await this.Mediator.Send(new GetEmailBodyQuery(emailLogId)));
            }
            catch (Exception)
            {
                return this.NotFound();
            }
        }

        private async Task<IActionResult> LogsActionAsync<TFetchQuery>(
            string viewName,
            int page,
            string searchQuery,
            DateModel? fromDate,
            DateModel? toDate,
            string user)
            where TFetchQuery : IFetchLogsQuery, new()
        {
            var model = await this.Mediator.Send(new TFetchQuery
            {
                Page = page,
                SearchQuery = searchQuery?.Trim(),
                FromDate = fromDate,
                ToDate = toDate,
                User = user,
            });

            if (model == null)
            {
                this.NotFound();
            }

            this.ViewData.SetSearchQuery(searchQuery);
            this.ViewData["FromDate"] = fromDate;
            this.ViewData["ToDate"] = toDate;
            if (!string.IsNullOrWhiteSpace(user) && Guid.TryParse(user, out var queriedUserId) && queriedUserId != Guid.Empty)
            {
                var queriedUser = await this.userManager.FindUserByIdAsync(queriedUserId);
                if (queriedUser != null)
                {
                    this.ViewData["QueriedUserName"] = queriedUser.Name;
                }
            }

            return this.View(viewName, model);
        }
    }
}
