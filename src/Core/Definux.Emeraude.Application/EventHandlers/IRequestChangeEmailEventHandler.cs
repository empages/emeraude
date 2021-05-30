namespace Definux.Emeraude.Application.EventHandlers
{
    /// <summary>
    /// Event handler that handle request for change user email.
    /// </summary>
    public interface IRequestChangeEmailEventHandler : IIdentityEventHandler<RequestChangeEmailEventArgs>
    {
    }
}