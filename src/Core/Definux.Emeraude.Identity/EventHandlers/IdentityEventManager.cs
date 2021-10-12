using System;
using System.Threading.Tasks;
using Definux.Emeraude.Application.EventHandlers;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Definux.Emeraude.Identity.EventHandlers
{
    /// <inheritdoc cref="IIdentityEventManager"/>
    internal class IdentityEventManager : IIdentityEventManager
    {
        private readonly IServiceProvider serviceProvider;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ILogger<IdentityEventManager> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityEventManager"/> class.
        /// </summary>
        /// <param name="serviceProvider"></param>
        /// <param name="httpContextAccessor"></param>
        /// <param name="logger"></param>
        public IdentityEventManager(IServiceProvider serviceProvider, IHttpContextAccessor httpContextAccessor, ILogger<IdentityEventManager> logger)
        {
            this.serviceProvider = serviceProvider;
            this.httpContextAccessor = httpContextAccessor;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public async Task TriggerLoginEventAsync(Guid userId)
        {
            await this.TriggerEventAsync<ILoginEventHandler, LoginEventArgs>(new LoginEventArgs
            {
                UserId = userId,
                HttpContext = this.httpContextAccessor.HttpContext,
            });
        }

        /// <inheritdoc/>
        public async Task TriggerExternalLoginEventAsync(Guid userId)
        {
            await this.TriggerEventAsync<IExternalLoginEventHandler, ExternalLoginEventArgs>(new ExternalLoginEventArgs
            {
                UserId = userId,
                HttpContext = this.httpContextAccessor.HttpContext,
            });
        }

        /// <inheritdoc/>
        public async Task TriggerRegisterEventAsync(Guid userId, string confirmationLink)
        {
            await this.TriggerEventAsync<IRegisterEventHandler, RegisterEventArgs>(new RegisterEventArgs
            {
                UserId = userId,
                HttpContext = this.httpContextAccessor.HttpContext,
                EmailConfirmationLink = confirmationLink,
            });
        }

        /// <inheritdoc/>
        public async Task TriggerExternalRegisterEventAsync(Guid userId)
        {
            await this.TriggerEventAsync<IExternalRegisterEventHandler, ExternalRegisterEventArgs>(new ExternalRegisterEventArgs
            {
                UserId = userId,
                HttpContext = this.httpContextAccessor.HttpContext,
            });
        }

        /// <inheritdoc/>
        public async Task TriggerForgotPasswordEventAsync(Guid userId, string resetPasswordLink)
        {
            await this.TriggerEventAsync<IForgotPasswordEventHandler, ForgotPasswordEventArgs>(new ForgotPasswordEventArgs
            {
                UserId = userId,
                HttpContext = this.httpContextAccessor.HttpContext,
                ResetPasswordLink = resetPasswordLink,
            });
        }

        /// <inheritdoc/>
        public async Task TriggerResetPasswordEventAsync(Guid userId)
        {
            await this.TriggerEventAsync<IResetPasswordEventHandler, ResetPasswordEventArgs>(new ResetPasswordEventArgs
            {
                UserId = userId,
                HttpContext = this.httpContextAccessor.HttpContext,
            });
        }

        /// <inheritdoc/>
        public async Task TriggerConfirmedEmailEventAsync(Guid userId)
        {
            await this.TriggerEventAsync<IConfirmedEmailEventHandler, ConfirmedEmailEventArgs>(new ConfirmedEmailEventArgs
            {
                UserId = userId,
                HttpContext = this.httpContextAccessor.HttpContext,
            });
        }

        /// <inheritdoc/>
        public Task TriggerRequestChangeEmailEventAsync(Guid userId, string newEmail, string changeEmailConfirmationLink)
        {
            return this.TriggerEventAsync<IRequestChangeEmailEventHandler, RequestChangeEmailEventArgs>(new RequestChangeEmailEventArgs
            {
                UserId = userId,
                HttpContext = this.httpContextAccessor.HttpContext,
                EmailConfirmationLink = changeEmailConfirmationLink,
                NewEmail = newEmail,
            });
        }

        private async Task TriggerEventAsync<THandler, TEventArgs>(TEventArgs args)
            where THandler : class, IIdentityEventHandler<TEventArgs>
            where TEventArgs : IdentityEventArgs
        {
            try
            {
                if (this.TryGetEventHandler<THandler, TEventArgs>(out THandler handler))
                {
                    await handler.HandleAsync(args);
                }
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occured during identity event triggering");
            }
        }

        private bool TryGetEventHandler<THandler, TEventArgs>(out THandler handler)
            where THandler : class, IIdentityEventHandler<TEventArgs>
            where TEventArgs : IdentityEventArgs
        {
            try
            {
                handler = (THandler)this.serviceProvider.GetService(typeof(THandler));
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
