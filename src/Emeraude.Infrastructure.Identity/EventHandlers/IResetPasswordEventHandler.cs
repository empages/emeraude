namespace Emeraude.Infrastructure.Identity.EventHandlers;

/// <summary>
/// Event handler that handle succeeded reset password request.
/// </summary>
public interface IResetPasswordEventHandler : IIdentityEventHandler<ResetPasswordEventArgs>
{
}