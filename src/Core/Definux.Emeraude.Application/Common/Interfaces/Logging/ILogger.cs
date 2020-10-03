using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Definux.Emeraude.Application.Common.Interfaces.Logging
{
    /// <summary>
    /// Emeraude default logger. Store all logs in separate SQLite database.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Save information about current request.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="hideParameters"></param>
        void LogActivity(ActionExecutingContext context, bool hideParameters = false);

        /// <summary>
        /// Save information (async execution) for thrown exception.
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="method"></param>
        /// <returns></returns>
        Task LogErrorAsync(Exception exception, [CallerMemberName]string method = "");

        /// <summary>
        /// Save information for thrown exception.
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="method"></param>
        void LogError(Exception exception, [CallerMemberName]string method = "");

        /// <summary>
        /// Save information about sent/unsent email.
        /// </summary>
        /// <param name="receiver"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <param name="sent"></param>
        /// <returns></returns>
        Task LogEmailAsync(string receiver, string subject, string body, bool sent);
    }
}
