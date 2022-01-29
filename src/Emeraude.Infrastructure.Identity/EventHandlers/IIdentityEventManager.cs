using System;
using System.Threading.Tasks;

namespace Emeraude.Infrastructure.Identity.EventHandlers;

/// <summary>
/// Event manager that trigger all identity related events on successful execution of authentication operation.
/// </summary>
public interface IIdentityEventManager
{
    /// <summary>
    /// Generic trigger for identity events.
    /// </summary>
    /// <param name="args"></param>
    /// <typeparam name="THandler">Event handler type.</typeparam>
    /// <typeparam name="TEventArgs">Event args type.</typeparam>
    /// <returns></returns>
    Task TriggerEventAsync<THandler, TEventArgs>(TEventArgs args)
        where THandler : class, IIdentityEventHandler<TEventArgs>
        where TEventArgs : IdentityEventArgs;
}