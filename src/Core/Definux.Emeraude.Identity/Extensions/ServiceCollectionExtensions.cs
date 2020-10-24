using Definux.Emeraude.Application.EventHandlers;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Identity.EventHandlers;
using Definux.Emeraude.Identity.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Identity.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Registers Emeraude identity infrastructure.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterEmeraudeIdentity(this IServiceCollection services)
        {
            services.AddScoped<ICurrentUserProvider, CurrentUserProvider>();
            services.AddScoped<IUserManager, UserManager>();
            services.AddScoped<IRoleManager, RoleManager>();
            services.AddScoped<IUserAvatarService, UserAvatarService>();
            services.AddScoped<IUserClaimsService, UserClaimsService>();
            services.AddScoped<IUserTokensService, UserTokensService>();
            services.AddScoped<IIdentityEventManager, IdentityEventManager>();
            services.AddScoped<ITwoFactorAuthenticationService, TwoFactorAuthenticationService>();

            return services;
        }

        /// <summary>
        /// Register an event handler which will be triggered when a user has logged in the application via email/password form.
        /// </summary>
        /// <typeparam name="TEventHandler">Login event handler.</typeparam>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection SubscribeToLoginEvent<TEventHandler>(this IServiceCollection services)
            where TEventHandler : class, ILoginEventHandler
        {
            return services.SubscribeToIdentityEvent<ILoginEventHandler, TEventHandler>();
        }

        /// <summary>
        /// Register an event handler which will be triggered when a user has logged in the application via external authentication provider.
        /// </summary>
        /// <typeparam name="TEventHandler">External login event handler.</typeparam>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection SubscribeToExternalLoginEvent<TEventHandler>(this IServiceCollection services)
            where TEventHandler : class, IExternalLoginEventHandler
        {
            return services.SubscribeToIdentityEvent<IExternalLoginEventHandler, TEventHandler>();
        }

        /// <summary>
        /// Register an event handler which will be triggered when a user has registered in the application via email/password form.
        /// </summary>
        /// <typeparam name="TEventHandler">Event handler.</typeparam>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection SubscribeToRegisterEvent<TEventHandler>(this IServiceCollection services)
            where TEventHandler : class, IRegisterEventHandler
        {
            return services.SubscribeToIdentityEvent<IRegisterEventHandler, TEventHandler>();
        }

        /// <summary>
        /// Register an event handler which will be triggered when a user has registered in the application via external authentication provider.
        /// </summary>
        /// <typeparam name="TEventHandler">External register event handler.</typeparam>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection SubscribeToExternalRegisterEvent<TEventHandler>(this IServiceCollection services)
            where TEventHandler : class, IExternalRegisterEventHandler
        {
            return services.SubscribeToIdentityEvent<IExternalRegisterEventHandler, TEventHandler>();
        }

        /// <summary>
        /// Register an event handler which will be triggered when a user has made a request to reset his/her password.
        /// </summary>
        /// <typeparam name="TEventHandler">Forgot password event handler.</typeparam>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection SubscribeToForgotPasswordEvent<TEventHandler>(this IServiceCollection services)
            where TEventHandler : class, IForgotPasswordEventHandler
        {
            return services.SubscribeToIdentityEvent<IForgotPasswordEventHandler, TEventHandler>();
        }

        /// <summary>
        /// Register an event handler which will be triggered when a user has reset his/her password.
        /// </summary>
        /// <typeparam name="TEventHandler">Reset password event handler.</typeparam>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection SubscribeToResetPasswordEvent<TEventHandler>(this IServiceCollection services)
            where TEventHandler : class, IResetPasswordEventHandler
        {
            return services.SubscribeToIdentityEvent<IResetPasswordEventHandler, TEventHandler>();
        }

        /// <summary>
        /// Register an event handler which will be triggered when a user has confirmed his email.
        /// </summary>
        /// <typeparam name="TEventHandler">Confirmed email event handler.</typeparam>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection SubscribeToConfirmedEmailEvent<TEventHandler>(this IServiceCollection services)
            where TEventHandler : class, IConfirmedEmailEventHandler
        {
            return services.SubscribeToIdentityEvent<IConfirmedEmailEventHandler, TEventHandler>();
        }

        private static IServiceCollection SubscribeToIdentityEvent<TEventHandlerService, TEventHandlerImplementation>(this IServiceCollection services)
            where TEventHandlerService : class, IIdentityEventHandler
            where TEventHandlerImplementation : class, TEventHandlerService
        {
            services.AddTransient<TEventHandlerService, TEventHandlerImplementation>();

            return services;
        }
    }
}
