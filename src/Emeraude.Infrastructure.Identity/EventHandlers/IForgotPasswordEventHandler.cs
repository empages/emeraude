namespace Emeraude.Infrastructure.Identity.EventHandlers;

/// <summary>
/// Event handler that handle succeeded forgot password request.
/// </summary>
public interface IForgotPasswordEventHandler : IIdentityEventHandler<ForgotPasswordEventArgs>
{
}