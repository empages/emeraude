namespace Emeraude.Infrastructure.Identity.EventHandlers;

/// <summary>
/// Event handler that handle request for change user email.
/// </summary>
public interface IRequestChangeEmailEventHandler : IIdentityEventHandler<RequestChangeEmailEventArgs>
{
}