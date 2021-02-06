using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Definux.Emeraude.Application.EventHandlers
{
    /// <summary>
    /// Event handler that handle succeeded authentication request.
    /// </summary>
    public interface IIdentityEventHandler
    {
        /// <summary>
        /// Handle method that handle succeeded authentication request.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="httpContext"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        Task HandleAsync(Guid userId, HttpContext httpContext, params string[] args);
    }
}
