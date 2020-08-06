using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Common.Interfaces.Logging
{
    public interface ILogger
    {
        void LogActivity(ActionExecutingContext context, bool hideParameters = false);

        Task LogErrorAsync(Exception exception, [CallerMemberName]string method = "");

        void LogError(Exception exception, [CallerMemberName]string method = "");

        Task LogEmailAsync(string receiver, string subject, string body, bool sent);
    }
}
