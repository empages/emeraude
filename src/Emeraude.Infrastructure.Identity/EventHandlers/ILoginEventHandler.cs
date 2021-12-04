namespace Emeraude.Infrastructure.Identity.EventHandlers;

/// <summary>
/// Event handler that handle succeeded login request.
/// </summary>
public interface ILoginEventHandler : IIdentityEventHandler<LoginEventArgs>
{
}