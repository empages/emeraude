using System;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Common.Interfaces.Identity.EventHandlers;
using Definux.Emeraude.Application.Common.Interfaces.Logging;

namespace Definux.Emeraude.Identity.EventHandlers
{
    /// <inheritdoc cref="IIdentityEventManager"/>
    internal class IdentityEventManager : IIdentityEventManager
    {
        private readonly IServiceProvider serviceProvider;
        private readonly ILogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityEventManager"/> class.
        /// </summary>
        /// <param name="serviceProvider"></param>
        /// <param name="logger"></param>
        public IdentityEventManager(IServiceProvider serviceProvider, ILogger logger)
        {
            this.serviceProvider = serviceProvider;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public async Task TriggerLoginEventAsync(Guid userId) => await this.TriggerEventAsync<ILoginEventHandler>(userId);

        /// <inheritdoc/>
        public async Task TriggerExternalLoginEventAsync(Guid userId) => await this.TriggerEventAsync<IExternalLoginEventHandler>(userId);

        /// <inheritdoc/>
        public async Task TriggerRegisterEventAsync(Guid userId) => await this.TriggerEventAsync<IRegisterEventHandler>(userId);

        /// <inheritdoc/>
        public async Task TriggerExternalRegisterEventAsync(Guid userId) => await this.TriggerEventAsync<IExternalRegisterEventHandler>(userId);

        /// <inheritdoc/>
        public async Task TriggerForgotPasswordEventAsync(Guid userId, string resetPasswordLink) => await this.TriggerEventAsync<IForgotPasswordEventHandler>(userId, resetPasswordLink);

        /// <inheritdoc/>
        public async Task TriggerResetPasswordEventAsync(Guid userId) => await this.TriggerEventAsync<IResetPasswordEventHandler>(userId);

        /// <inheritdoc/>
        public async Task TriggerConfirmedEmailEventAsync(Guid userId) => await this.TriggerEventAsync<IConfirmedEmailEventHandler>(userId);

        private async Task TriggerEventAsync<THandler>(Guid userId, params string[] args)
            where THandler : IIdentityEventHandler
        {
            try
            {
                if (this.TryGetEventHandler<THandler>(out IIdentityEventHandler handler))
                {
                    await handler.HandleAsync(userId, args);
                }
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
            }
        }

        private bool TryGetEventHandler<THandler>(out IIdentityEventHandler handler)
            where THandler : IIdentityEventHandler
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
