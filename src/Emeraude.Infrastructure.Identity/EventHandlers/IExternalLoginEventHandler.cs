namespace Emeraude.Infrastructure.Identity.EventHandlers;

/// <summary>
/// Event handler that handle succeeded external login request.
/// </summary>
public interface IExternalLoginEventHandler : IIdentityEventHandler<ExternalLoginEventArgs>
{
}