namespace Emeraude.Infrastructure.Identity.EventHandlers
{
    /// <summary>
    /// Event handler that handle succeeded external register request.
    /// </summary>
    public interface IExternalRegisterEventHandler : IIdentityEventHandler<ExternalRegisterEventArgs>
    {
    }
}
