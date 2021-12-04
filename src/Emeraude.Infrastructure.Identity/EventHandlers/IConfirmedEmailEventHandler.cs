namespace Emeraude.Infrastructure.Identity.EventHandlers;

/// <summary>
/// Event handler that handle succeeded confirmed email request.
/// </summary>
public interface IConfirmedEmailEventHandler : IIdentityEventHandler<ConfirmedEmailEventArgs>
{
}