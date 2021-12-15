using System;
using System.Collections.Generic;
using Emeraude.Infrastructure.Identity.EventHandlers;
using Emeraude.Infrastructure.Identity.ExternalProviders;
using Emeraude.Infrastructure.Identity.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace Emeraude.Infrastructure.Identity.Extensions;

/// <summary>
/// Extensions for <see cref="IServiceCollection"/>.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Registers Emeraude identity infrastructure.
    /// </summary>
    /// <param name="services"></param>
    public static void RegisterEmeraudeIdentity(this IServiceCollection services)
    {
        services.AddScoped<ICurrentUser, CurrentUser>();
        services.AddScoped<ICurrentUserProvider, CurrentUserProvider>();
        services.AddScoped<IUserManager, UserManager>();
        services.AddScoped<IRoleManager, RoleManager>();
        services.AddScoped<IUserAvatarService, UserAvatarService>();
        services.AddScoped<IUserClaimsService, UserClaimsService>();
        services.AddScoped<IUserTokensService, UserTokensService>();
        services.AddScoped<IIdentityEventManager, IdentityEventManager>();
        services.AddScoped<ITwoFactorAuthenticationService, TwoFactorAuthenticationService>();
    }

    /// <summary>
    /// Register external providers authenticators.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="authenticationBuilder"></param>
    /// <param name="authenticators"></param>
    public static void RegisterExternalProvidersAuthenticators(
        this IServiceCollection services,
        AuthenticationBuilder authenticationBuilder,
        List<IExternalProviderAuthenticator> authenticators)
    {
        services.AddSingleton<IExternalProviderAuthenticatorFactory>(new ExternalProviderAuthenticatorFactory(authenticators));
        services.AddScoped<IExternalAuthenticationProvider, ExternalAuthenticationProvider>();

        foreach (var authenticator in authenticators)
        {
            authenticator.RegisterAuthenticator(authenticationBuilder);
        }
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
        return services.SubscribeToIdentityEvent<ILoginEventHandler, TEventHandler, LoginEventArgs>();
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
        return services.SubscribeToIdentityEvent<IExternalLoginEventHandler, TEventHandler, ExternalLoginEventArgs>();
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
        return services.SubscribeToIdentityEvent<IRegisterEventHandler, TEventHandler, RegisterEventArgs>();
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
        return services.SubscribeToIdentityEvent<IExternalRegisterEventHandler, TEventHandler, ExternalRegisterEventArgs>();
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
        return services.SubscribeToIdentityEvent<IForgotPasswordEventHandler, TEventHandler, ForgotPasswordEventArgs>();
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
        return services.SubscribeToIdentityEvent<IResetPasswordEventHandler, TEventHandler, ResetPasswordEventArgs>();
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
        return services.SubscribeToIdentityEvent<IConfirmedEmailEventHandler, TEventHandler, ConfirmedEmailEventArgs>();
    }

    /// <summary>
    /// Register an event handler which will be triggered when a user has made a request for change its email.
    /// </summary>
    /// <typeparam name="TEventHandler">Request change email event handler.</typeparam>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection SubscribeToRequestChangeEmailEvent<TEventHandler>(this IServiceCollection services)
        where TEventHandler : class, IRequestChangeEmailEventHandler
    {
        return services.SubscribeToIdentityEvent<IRequestChangeEmailEventHandler, TEventHandler, RequestChangeEmailEventArgs>();
    }

    private static IServiceCollection SubscribeToIdentityEvent<TEventHandlerService, TEventHandlerImplementation, TEventHandlerEventArgs>(this IServiceCollection services)
        where TEventHandlerService : class, IIdentityEventHandler<TEventHandlerEventArgs>
        where TEventHandlerImplementation : class, TEventHandlerService
        where TEventHandlerEventArgs : IdentityEventArgs
    {
        services.AddTransient<TEventHandlerService, TEventHandlerImplementation>();

        return services;
    }
}