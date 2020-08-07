using Definux.Emeraude.Application.Common.Interfaces.Identity.EventHandlers;
using Definux.Emeraude.Application.Common.Interfaces.Logging;
using System;
using System.Threading.Tasks;

namespace Definux.Emeraude.Identity.EventHandlers
{
    internal class IdentityEventManager : IIdentityEventManager
    {
        private readonly IServiceProvider serviceProvider;
        private readonly ILogger logger;

        public IdentityEventManager(IServiceProvider serviceProvider, ILogger logger)
        {
            this.serviceProvider = serviceProvider;
            this.logger = logger;
        }

        public async Task TriggerLoginEventAsync(Guid userId) => await TriggerEventAsync<ILoginEventHandler>(userId);

        public async Task TriggerExternalLoginEventAsync(Guid userId) => await TriggerEventAsync<IExternalLoginEventHandler>(userId);

        public async Task TriggerRegisterEventAsync(Guid userId) => await TriggerEventAsync<IRegisterEventHandler>(userId);

        public async Task TriggerExternalRegisterEventAsync(Guid userId) => await TriggerEventAsync<IExternalRegisterEventHandler>(userId);

        public async Task TriggerForgotPasswordEventAsync(Guid userId, string resetPasswordLink) => await TriggerEventAsync<IForgotPasswordEventHandler>(userId, resetPasswordLink);

        public async Task TriggerResetPasswordEventAsync(Guid userId) => await TriggerEventAsync<IResetPasswordEventHandler>(userId);

        public async Task TriggerConfirmedEmailEventAsync(Guid userId) => await TriggerEventAsync<IConfirmedEmailEventHandler>(userId);

        private async Task TriggerEventAsync<THandler>(Guid userId, params string[] args) where THandler : IIdentityEventHandler
        {
            try
            {
                if (TryGetEventHandler<THandler>(out IIdentityEventHandler handler))
                {
                    await handler.HandleAsync(userId, args);
                }
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
            }
        }

        private bool TryGetEventHandler<THandler>(out IIdentityEventHandler handler) where THandler : IIdentityEventHandler
        {
            try
            {
                handler = (IIdentityEventHandler)this.serviceProvider.GetService(typeof(THandler));
                return handler != null;
            }
            catch (Exception)
            {
                handler = null;
                return false;
            }
        }
    }
}
