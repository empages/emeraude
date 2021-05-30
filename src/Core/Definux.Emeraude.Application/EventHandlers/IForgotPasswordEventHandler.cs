namespace Definux.Emeraude.Application.EventHandlers
{
    /// <summary>
    /// Event handler that handle succeeded forgot password request.
    /// </summary>
    public interface IForgotPasswordEventHandler : IIdentityEventHandler<ForgotPasswordEventArgs>
    {
    }
}
