using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Emeraude.Infrastructure.Identity.EventHandlers;

/// <inheritdoc cref="IIdentityEventManager"/>
public class IdentityEventManager : IIdentityEventManager
{
    private readonly IServiceProvider serviceProvider;
    private readonly IHttpContextAccessor httpContextAccessor;
    private readonly ILogger<IdentityEventManager> logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="IdentityEventManager"/> class.
    /// </summary>
    /// <param name="serviceProvider"></param>
    /// <param name="httpContextAccessor"></param>
    /// <param name="logger"></param>
    public IdentityEventManager(
        IServiceProvider serviceProvider,
        IHttpContextAccessor httpContextAccessor,
        ILogger<IdentityEventManager> logger)
    {
        this.serviceProvider = serviceProvider;
        this.httpContextAccessor = httpContextAccessor;
        this.logger = logger;
    }

    /// <inheritdoc/>
    public async Task TriggerEventAsync<THandler, TEventArgs>(TEventArgs args)
        where THandler : class, IIdentityEventHandler<TEventArgs>
        where TEventArgs : IdentityEventArgs
    {
        try
        {
            if (this.TryGetEventHandler<THandler, TEventArgs>(out THandler handler))
            {
                args.HttpContext = this.httpContextAccessor.HttpContext;

                await handler.HandleAsync(args);
            }
        }
        catch (Exception ex)
        {
            this.logger.LogError(ex, "An error occured during identity event triggering");
        }
    }

    private bool TryGetEventHandler<THandler, TEventArgs>(out THandler handler)
        where THandler : class, IIdentityEventHandler<TEventArgs>
        where TEventArgs : IdentityEventArgs
    {
        try
        {
            handler = (THandler)this.serviceProvider.GetService(typeof(THandler));
            return handler != null;
        }
        catch (Exception)
        {
            this.logger.LogDebug("An event handler ({Type}) with no implementation has been requested", typeof(THandler).FullName);
            handler = null;
            return false;
        }
    }
}