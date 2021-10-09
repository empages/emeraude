using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Definux.Emeraude.Application.Logger
{
    /// <summary>
    /// Emeraude default logger.
    /// </summary>
    public interface IEmLogger
    {
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
        /// Save information for specific error without existing exception.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="message"></param>
        /// <param name="method"></param>
        void LogErrorWithoutAnException(string source, string message, [CallerMemberName]string method = "");

        /// <summary>
        /// Register information about current request without saving.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="hideParameters"></param>
        void LogActivity(ActionExecutingContext context, bool hideParameters = false);

        /// <summary>
        /// Save information about sent/unsent email.
        /// </summary>
        /// <param name="emailAddress"></param>
        /// <param name="receiver"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <param name="sent"></param>
        /// <returns></returns>
        Task LogEmailAsync(string emailAddress, string receiver, string subject, string body, bool sent);
    }
}
