using System;
using System.Threading.Tasks;

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
        /// <param name="args"></param>
        /// <returns></returns>
        Task HandleAsync(Guid userId, params string[] args);
    }
}
