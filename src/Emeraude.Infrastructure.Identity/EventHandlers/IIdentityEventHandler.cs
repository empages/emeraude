using System.Threading.Tasks;

namespace Emeraude.Infrastructure.Identity.EventHandlers
{
    /// <summary>
    /// Event handler that handle succeeded authentication request.
    /// </summary>
    /// <typeparam name="TIdentityEventArgs">Event args of the handler.</typeparam>
    public interface IIdentityEventHandler<in TIdentityEventArgs>
        where TIdentityEventArgs : IdentityEventArgs
    {
        /// <summary>
        /// Method that handles succeeded identity request.
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        Task HandleAsync(TIdentityEventArgs args);
    }
}
