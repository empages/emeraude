namespace Emeraude.Infrastructure.Identity.EventHandlers
{
    /// <summary>
    /// Event handler that handle succeeded register request.
    /// </summary>
    public interface IRegisterEventHandler : IIdentityEventHandler<RegisterEventArgs>
    {
    }
}
