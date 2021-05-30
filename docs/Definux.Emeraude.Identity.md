<a name='assembly'></a>
# Definux.Emeraude.Identity

## Contents

- [CurrentUserProvider](#T-Definux-Emeraude-Identity-Services-CurrentUserProvider 'Definux.Emeraude.Identity.Services.CurrentUserProvider')
  - [#ctor(httpAccessor,userManager,logger)](#M-Definux-Emeraude-Identity-Services-CurrentUserProvider-#ctor-Microsoft-AspNetCore-Http-IHttpContextAccessor,Microsoft-AspNetCore-Identity-UserManager{Definux-Emeraude-Identity-Entities-User},Definux-Emeraude-Application-Logger-IEmLogger- 'Definux.Emeraude.Identity.Services.CurrentUserProvider.#ctor(Microsoft.AspNetCore.Http.IHttpContextAccessor,Microsoft.AspNetCore.Identity.UserManager{Definux.Emeraude.Identity.Entities.User},Definux.Emeraude.Application.Logger.IEmLogger)')
  - [CurrentUserId](#P-Definux-Emeraude-Identity-Services-CurrentUserProvider-CurrentUserId 'Definux.Emeraude.Identity.Services.CurrentUserProvider.CurrentUserId')
  - [GetCurrentUserAsync()](#M-Definux-Emeraude-Identity-Services-CurrentUserProvider-GetCurrentUserAsync 'Definux.Emeraude.Identity.Services.CurrentUserProvider.GetCurrentUserAsync')
- [DatabaseContextExtensions](#T-Definux-Emeraude-Identity-Extensions-DatabaseContextExtensions 'Definux.Emeraude.Identity.Extensions.DatabaseContextExtensions')
  - [BuildRefreshToken(context,user)](#M-Definux-Emeraude-Identity-Extensions-DatabaseContextExtensions-BuildRefreshToken-Definux-Emeraude-Application-Persistence-IEmContext,Definux-Emeraude-Identity-Entities-User- 'Definux.Emeraude.Identity.Extensions.DatabaseContextExtensions.BuildRefreshToken(Definux.Emeraude.Application.Persistence.IEmContext,Definux.Emeraude.Identity.Entities.User)')
  - [ResetRefreshToken(context,user)](#M-Definux-Emeraude-Identity-Extensions-DatabaseContextExtensions-ResetRefreshToken-Definux-Emeraude-Application-Persistence-IEmContext,Definux-Emeraude-Identity-Entities-User- 'Definux.Emeraude.Identity.Extensions.DatabaseContextExtensions.ResetRefreshToken(Definux.Emeraude.Application.Persistence.IEmContext,Definux.Emeraude.Identity.Entities.User)')
- [DefaultUserManager](#T-Definux-Emeraude-Identity-Services-DefaultUserManager 'Definux.Emeraude.Identity.Services.DefaultUserManager')
  - [#ctor(userManager)](#M-Definux-Emeraude-Identity-Services-DefaultUserManager-#ctor-Microsoft-AspNetCore-Identity-UserManager{Definux-Emeraude-Identity-Entities-User}- 'Definux.Emeraude.Identity.Services.DefaultUserManager.#ctor(Microsoft.AspNetCore.Identity.UserManager{Definux.Emeraude.Identity.Entities.User})')
  - [UserManager](#P-Definux-Emeraude-Identity-Services-DefaultUserManager-UserManager 'Definux.Emeraude.Identity.Services.DefaultUserManager.UserManager')
- [ExternalProviderAuthenticatorFactory](#T-Definux-Emeraude-Identity-ExternalProviders-ExternalProviderAuthenticatorFactory 'Definux.Emeraude.Identity.ExternalProviders.ExternalProviderAuthenticatorFactory')
  - [#ctor(authenticators)](#M-Definux-Emeraude-Identity-ExternalProviders-ExternalProviderAuthenticatorFactory-#ctor-System-Collections-Generic-List{Definux-Emeraude-Application-Identity-IExternalProviderAuthenticator}- 'Definux.Emeraude.Identity.ExternalProviders.ExternalProviderAuthenticatorFactory.#ctor(System.Collections.Generic.List{Definux.Emeraude.Application.Identity.IExternalProviderAuthenticator})')
  - [Providers](#P-Definux-Emeraude-Identity-ExternalProviders-ExternalProviderAuthenticatorFactory-Providers 'Definux.Emeraude.Identity.ExternalProviders.ExternalProviderAuthenticatorFactory.Providers')
  - [ContainsProvider()](#M-Definux-Emeraude-Identity-ExternalProviders-ExternalProviderAuthenticatorFactory-ContainsProvider-System-String- 'Definux.Emeraude.Identity.ExternalProviders.ExternalProviderAuthenticatorFactory.ContainsProvider(System.String)')
  - [GetAuthenticator()](#M-Definux-Emeraude-Identity-ExternalProviders-ExternalProviderAuthenticatorFactory-GetAuthenticator-System-String- 'Definux.Emeraude.Identity.ExternalProviders.ExternalProviderAuthenticatorFactory.GetAuthenticator(System.String)')
- [FacebookAuthenticator](#T-Definux-Emeraude-Identity-ExternalProviders-Facebook-FacebookAuthenticator 'Definux.Emeraude.Identity.ExternalProviders.Facebook.FacebookAuthenticator')
  - [Name](#P-Definux-Emeraude-Identity-ExternalProviders-Facebook-FacebookAuthenticator-Name 'Definux.Emeraude.Identity.ExternalProviders.Facebook.FacebookAuthenticator.Name')
  - [GetExternalUserAsync()](#M-Definux-Emeraude-Identity-ExternalProviders-Facebook-FacebookAuthenticator-GetExternalUserAsync-System-Security-Claims-ClaimsPrincipal- 'Definux.Emeraude.Identity.ExternalProviders.Facebook.FacebookAuthenticator.GetExternalUserAsync(System.Security.Claims.ClaimsPrincipal)')
  - [GetExternalUserAsync()](#M-Definux-Emeraude-Identity-ExternalProviders-Facebook-FacebookAuthenticator-GetExternalUserAsync-System-String,System-String- 'Definux.Emeraude.Identity.ExternalProviders.Facebook.FacebookAuthenticator.GetExternalUserAsync(System.String,System.String)')
  - [RegisterAuthenticator()](#M-Definux-Emeraude-Identity-ExternalProviders-Facebook-FacebookAuthenticator-RegisterAuthenticator-Microsoft-AspNetCore-Authentication-AuthenticationBuilder- 'Definux.Emeraude.Identity.ExternalProviders.Facebook.FacebookAuthenticator.RegisterAuthenticator(Microsoft.AspNetCore.Authentication.AuthenticationBuilder)')
- [FacebookExternalUser](#T-Definux-Emeraude-Identity-ExternalProviders-Facebook-FacebookExternalUser 'Definux.Emeraude.Identity.ExternalProviders.Facebook.FacebookExternalUser')
  - [EmailAddress](#P-Definux-Emeraude-Identity-ExternalProviders-Facebook-FacebookExternalUser-EmailAddress 'Definux.Emeraude.Identity.ExternalProviders.Facebook.FacebookExternalUser.EmailAddress')
  - [FirstName](#P-Definux-Emeraude-Identity-ExternalProviders-Facebook-FacebookExternalUser-FirstName 'Definux.Emeraude.Identity.ExternalProviders.Facebook.FacebookExternalUser.FirstName')
  - [Id](#P-Definux-Emeraude-Identity-ExternalProviders-Facebook-FacebookExternalUser-Id 'Definux.Emeraude.Identity.ExternalProviders.Facebook.FacebookExternalUser.Id')
  - [LastName](#P-Definux-Emeraude-Identity-ExternalProviders-Facebook-FacebookExternalUser-LastName 'Definux.Emeraude.Identity.ExternalProviders.Facebook.FacebookExternalUser.LastName')
  - [Name](#P-Definux-Emeraude-Identity-ExternalProviders-Facebook-FacebookExternalUser-Name 'Definux.Emeraude.Identity.ExternalProviders.Facebook.FacebookExternalUser.Name')
  - [Picture](#P-Definux-Emeraude-Identity-ExternalProviders-Facebook-FacebookExternalUser-Picture 'Definux.Emeraude.Identity.ExternalProviders.Facebook.FacebookExternalUser.Picture')
  - [PictureUrl](#P-Definux-Emeraude-Identity-ExternalProviders-Facebook-FacebookExternalUser-PictureUrl 'Definux.Emeraude.Identity.ExternalProviders.Facebook.FacebookExternalUser.PictureUrl')
  - [Provider](#P-Definux-Emeraude-Identity-ExternalProviders-Facebook-FacebookExternalUser-Provider 'Definux.Emeraude.Identity.ExternalProviders.Facebook.FacebookExternalUser.Provider')
- [GoogleAuthenticator](#T-Definux-Emeraude-Identity-ExternalProviders-Google-GoogleAuthenticator 'Definux.Emeraude.Identity.ExternalProviders.Google.GoogleAuthenticator')
  - [Name](#P-Definux-Emeraude-Identity-ExternalProviders-Google-GoogleAuthenticator-Name 'Definux.Emeraude.Identity.ExternalProviders.Google.GoogleAuthenticator.Name')
  - [GetExternalUserAsync()](#M-Definux-Emeraude-Identity-ExternalProviders-Google-GoogleAuthenticator-GetExternalUserAsync-System-Security-Claims-ClaimsPrincipal- 'Definux.Emeraude.Identity.ExternalProviders.Google.GoogleAuthenticator.GetExternalUserAsync(System.Security.Claims.ClaimsPrincipal)')
  - [GetExternalUserAsync()](#M-Definux-Emeraude-Identity-ExternalProviders-Google-GoogleAuthenticator-GetExternalUserAsync-System-String,System-String- 'Definux.Emeraude.Identity.ExternalProviders.Google.GoogleAuthenticator.GetExternalUserAsync(System.String,System.String)')
  - [RegisterAuthenticator()](#M-Definux-Emeraude-Identity-ExternalProviders-Google-GoogleAuthenticator-RegisterAuthenticator-Microsoft-AspNetCore-Authentication-AuthenticationBuilder- 'Definux.Emeraude.Identity.ExternalProviders.Google.GoogleAuthenticator.RegisterAuthenticator(Microsoft.AspNetCore.Authentication.AuthenticationBuilder)')
- [GoogleExternalUser](#T-Definux-Emeraude-Identity-ExternalProviders-Google-GoogleExternalUser 'Definux.Emeraude.Identity.ExternalProviders.Google.GoogleExternalUser')
  - [EmailAddress](#P-Definux-Emeraude-Identity-ExternalProviders-Google-GoogleExternalUser-EmailAddress 'Definux.Emeraude.Identity.ExternalProviders.Google.GoogleExternalUser.EmailAddress')
  - [FirstName](#P-Definux-Emeraude-Identity-ExternalProviders-Google-GoogleExternalUser-FirstName 'Definux.Emeraude.Identity.ExternalProviders.Google.GoogleExternalUser.FirstName')
  - [Id](#P-Definux-Emeraude-Identity-ExternalProviders-Google-GoogleExternalUser-Id 'Definux.Emeraude.Identity.ExternalProviders.Google.GoogleExternalUser.Id')
  - [LastName](#P-Definux-Emeraude-Identity-ExternalProviders-Google-GoogleExternalUser-LastName 'Definux.Emeraude.Identity.ExternalProviders.Google.GoogleExternalUser.LastName')
  - [Name](#P-Definux-Emeraude-Identity-ExternalProviders-Google-GoogleExternalUser-Name 'Definux.Emeraude.Identity.ExternalProviders.Google.GoogleExternalUser.Name')
  - [Picture](#P-Definux-Emeraude-Identity-ExternalProviders-Google-GoogleExternalUser-Picture 'Definux.Emeraude.Identity.ExternalProviders.Google.GoogleExternalUser.Picture')
  - [PictureUrl](#P-Definux-Emeraude-Identity-ExternalProviders-Google-GoogleExternalUser-PictureUrl 'Definux.Emeraude.Identity.ExternalProviders.Google.GoogleExternalUser.PictureUrl')
  - [Provider](#P-Definux-Emeraude-Identity-ExternalProviders-Google-GoogleExternalUser-Provider 'Definux.Emeraude.Identity.ExternalProviders.Google.GoogleExternalUser.Provider')
- [IdentityContext\`1](#T-Definux-Emeraude-Identity-IdentityContext`1 'Definux.Emeraude.Identity.IdentityContext`1')
  - [#ctor(options)](#M-Definux-Emeraude-Identity-IdentityContext`1-#ctor-Microsoft-EntityFrameworkCore-DbContextOptions{`0}- 'Definux.Emeraude.Identity.IdentityContext`1.#ctor(Microsoft.EntityFrameworkCore.DbContextOptions{`0})')
  - [OnModelCreating()](#M-Definux-Emeraude-Identity-IdentityContext`1-OnModelCreating-Microsoft-EntityFrameworkCore-ModelBuilder- 'Definux.Emeraude.Identity.IdentityContext`1.OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder)')
- [IdentityEventManager](#T-Definux-Emeraude-Identity-EventHandlers-IdentityEventManager 'Definux.Emeraude.Identity.EventHandlers.IdentityEventManager')
  - [#ctor(serviceProvider,httpContextAccessor,logger)](#M-Definux-Emeraude-Identity-EventHandlers-IdentityEventManager-#ctor-System-IServiceProvider,Microsoft-AspNetCore-Http-IHttpContextAccessor,Definux-Emeraude-Application-Logger-IEmLogger- 'Definux.Emeraude.Identity.EventHandlers.IdentityEventManager.#ctor(System.IServiceProvider,Microsoft.AspNetCore.Http.IHttpContextAccessor,Definux.Emeraude.Application.Logger.IEmLogger)')
  - [TriggerConfirmedEmailEventAsync()](#M-Definux-Emeraude-Identity-EventHandlers-IdentityEventManager-TriggerConfirmedEmailEventAsync-System-Guid- 'Definux.Emeraude.Identity.EventHandlers.IdentityEventManager.TriggerConfirmedEmailEventAsync(System.Guid)')
  - [TriggerExternalLoginEventAsync()](#M-Definux-Emeraude-Identity-EventHandlers-IdentityEventManager-TriggerExternalLoginEventAsync-System-Guid- 'Definux.Emeraude.Identity.EventHandlers.IdentityEventManager.TriggerExternalLoginEventAsync(System.Guid)')
  - [TriggerExternalRegisterEventAsync()](#M-Definux-Emeraude-Identity-EventHandlers-IdentityEventManager-TriggerExternalRegisterEventAsync-System-Guid- 'Definux.Emeraude.Identity.EventHandlers.IdentityEventManager.TriggerExternalRegisterEventAsync(System.Guid)')
  - [TriggerForgotPasswordEventAsync()](#M-Definux-Emeraude-Identity-EventHandlers-IdentityEventManager-TriggerForgotPasswordEventAsync-System-Guid,System-String- 'Definux.Emeraude.Identity.EventHandlers.IdentityEventManager.TriggerForgotPasswordEventAsync(System.Guid,System.String)')
  - [TriggerLoginEventAsync()](#M-Definux-Emeraude-Identity-EventHandlers-IdentityEventManager-TriggerLoginEventAsync-System-Guid- 'Definux.Emeraude.Identity.EventHandlers.IdentityEventManager.TriggerLoginEventAsync(System.Guid)')
  - [TriggerRegisterEventAsync()](#M-Definux-Emeraude-Identity-EventHandlers-IdentityEventManager-TriggerRegisterEventAsync-System-Guid,System-String- 'Definux.Emeraude.Identity.EventHandlers.IdentityEventManager.TriggerRegisterEventAsync(System.Guid,System.String)')
  - [TriggerRequestChangeEmailEventAsync()](#M-Definux-Emeraude-Identity-EventHandlers-IdentityEventManager-TriggerRequestChangeEmailEventAsync-System-Guid,System-String,System-String- 'Definux.Emeraude.Identity.EventHandlers.IdentityEventManager.TriggerRequestChangeEmailEventAsync(System.Guid,System.String,System.String)')
  - [TriggerResetPasswordEventAsync()](#M-Definux-Emeraude-Identity-EventHandlers-IdentityEventManager-TriggerResetPasswordEventAsync-System-Guid- 'Definux.Emeraude.Identity.EventHandlers.IdentityEventManager.TriggerResetPasswordEventAsync(System.Guid)')
- [ProfilePicture](#T-Definux-Emeraude-Identity-ExternalProviders-Facebook-ProfilePicture 'Definux.Emeraude.Identity.ExternalProviders.Facebook.ProfilePicture')
  - [Data](#P-Definux-Emeraude-Identity-ExternalProviders-Facebook-ProfilePicture-Data 'Definux.Emeraude.Identity.ExternalProviders.Facebook.ProfilePicture.Data')
- [ProfilePictureData](#T-Definux-Emeraude-Identity-ExternalProviders-Facebook-ProfilePictureData 'Definux.Emeraude.Identity.ExternalProviders.Facebook.ProfilePictureData')
  - [Url](#P-Definux-Emeraude-Identity-ExternalProviders-Facebook-ProfilePictureData-Url 'Definux.Emeraude.Identity.ExternalProviders.Facebook.ProfilePictureData.Url')
- [Role](#T-Definux-Emeraude-Identity-Entities-Role 'Definux.Emeraude.Identity.Entities.Role')
  - [#ctor()](#M-Definux-Emeraude-Identity-Entities-Role-#ctor 'Definux.Emeraude.Identity.Entities.Role.#ctor')
  - [#ctor(roleName)](#M-Definux-Emeraude-Identity-Entities-Role-#ctor-System-String- 'Definux.Emeraude.Identity.Entities.Role.#ctor(System.String)')
  - [#ctor(roleName,description)](#M-Definux-Emeraude-Identity-Entities-Role-#ctor-System-String,System-String- 'Definux.Emeraude.Identity.Entities.Role.#ctor(System.String,System.String)')
  - [Description](#P-Definux-Emeraude-Identity-Entities-Role-Description 'Definux.Emeraude.Identity.Entities.Role.Description')
- [RoleClaim](#T-Definux-Emeraude-Identity-Entities-RoleClaim 'Definux.Emeraude.Identity.Entities.RoleClaim')
- [RoleManager](#T-Definux-Emeraude-Identity-Services-RoleManager 'Definux.Emeraude.Identity.Services.RoleManager')
  - [#ctor(roleManager,userManager,context,logger)](#M-Definux-Emeraude-Identity-Services-RoleManager-#ctor-Microsoft-AspNetCore-Identity-RoleManager{Definux-Emeraude-Identity-Entities-Role},Microsoft-AspNetCore-Identity-UserManager{Definux-Emeraude-Identity-Entities-User},Definux-Emeraude-Application-Persistence-IEmContext,Definux-Emeraude-Application-Logger-IEmLogger- 'Definux.Emeraude.Identity.Services.RoleManager.#ctor(Microsoft.AspNetCore.Identity.RoleManager{Definux.Emeraude.Identity.Entities.Role},Microsoft.AspNetCore.Identity.UserManager{Definux.Emeraude.Identity.Entities.User},Definux.Emeraude.Application.Persistence.IEmContext,Definux.Emeraude.Application.Logger.IEmLogger)')
  - [AssignRolesToUserAsync()](#M-Definux-Emeraude-Identity-Services-RoleManager-AssignRolesToUserAsync-Definux-Emeraude-Domain-Entities-IUser,System-Collections-Generic-IEnumerable{System-Guid}- 'Definux.Emeraude.Identity.Services.RoleManager.AssignRolesToUserAsync(Definux.Emeraude.Domain.Entities.IUser,System.Collections.Generic.IEnumerable{System.Guid})')
  - [CreateRoleAsync()](#M-Definux-Emeraude-Identity-Services-RoleManager-CreateRoleAsync-System-String,System-Collections-Generic-IEnumerable{System-String}- 'Definux.Emeraude.Identity.Services.RoleManager.CreateRoleAsync(System.String,System.Collections.Generic.IEnumerable{System.String})')
  - [DeleteRoleAsync()](#M-Definux-Emeraude-Identity-Services-RoleManager-DeleteRoleAsync-System-String- 'Definux.Emeraude.Identity.Services.RoleManager.DeleteRoleAsync(System.String)')
  - [GetRolesAsync()](#M-Definux-Emeraude-Identity-Services-RoleManager-GetRolesAsync 'Definux.Emeraude.Identity.Services.RoleManager.GetRolesAsync')
  - [GetUserRolesAsync()](#M-Definux-Emeraude-Identity-Services-RoleManager-GetUserRolesAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Identity.Services.RoleManager.GetUserRolesAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [UnassignAllRolesFromUserAsync()](#M-Definux-Emeraude-Identity-Services-RoleManager-UnassignAllRolesFromUserAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Identity.Services.RoleManager.UnassignAllRolesFromUserAsync(Definux.Emeraude.Domain.Entities.IUser)')
- [ServiceCollectionExtensions](#T-Definux-Emeraude-Identity-Extensions-ServiceCollectionExtensions 'Definux.Emeraude.Identity.Extensions.ServiceCollectionExtensions')
  - [RegisterEmeraudeIdentity(services)](#M-Definux-Emeraude-Identity-Extensions-ServiceCollectionExtensions-RegisterEmeraudeIdentity-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Definux.Emeraude.Identity.Extensions.ServiceCollectionExtensions.RegisterEmeraudeIdentity(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [RegisterExternalProvidersAuthenticators(services,authenticationBuilder,authenticatorsAction)](#M-Definux-Emeraude-Identity-Extensions-ServiceCollectionExtensions-RegisterExternalProvidersAuthenticators-Microsoft-Extensions-DependencyInjection-IServiceCollection,Microsoft-AspNetCore-Authentication-AuthenticationBuilder,System-Action{System-Collections-Generic-List{Definux-Emeraude-Application-Identity-IExternalProviderAuthenticator}}- 'Definux.Emeraude.Identity.Extensions.ServiceCollectionExtensions.RegisterExternalProvidersAuthenticators(Microsoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.AspNetCore.Authentication.AuthenticationBuilder,System.Action{System.Collections.Generic.List{Definux.Emeraude.Application.Identity.IExternalProviderAuthenticator}})')
  - [SubscribeToConfirmedEmailEvent\`\`1(services)](#M-Definux-Emeraude-Identity-Extensions-ServiceCollectionExtensions-SubscribeToConfirmedEmailEvent``1-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Definux.Emeraude.Identity.Extensions.ServiceCollectionExtensions.SubscribeToConfirmedEmailEvent``1(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [SubscribeToExternalLoginEvent\`\`1(services)](#M-Definux-Emeraude-Identity-Extensions-ServiceCollectionExtensions-SubscribeToExternalLoginEvent``1-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Definux.Emeraude.Identity.Extensions.ServiceCollectionExtensions.SubscribeToExternalLoginEvent``1(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [SubscribeToExternalRegisterEvent\`\`1(services)](#M-Definux-Emeraude-Identity-Extensions-ServiceCollectionExtensions-SubscribeToExternalRegisterEvent``1-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Definux.Emeraude.Identity.Extensions.ServiceCollectionExtensions.SubscribeToExternalRegisterEvent``1(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [SubscribeToForgotPasswordEvent\`\`1(services)](#M-Definux-Emeraude-Identity-Extensions-ServiceCollectionExtensions-SubscribeToForgotPasswordEvent``1-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Definux.Emeraude.Identity.Extensions.ServiceCollectionExtensions.SubscribeToForgotPasswordEvent``1(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [SubscribeToLoginEvent\`\`1(services)](#M-Definux-Emeraude-Identity-Extensions-ServiceCollectionExtensions-SubscribeToLoginEvent``1-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Definux.Emeraude.Identity.Extensions.ServiceCollectionExtensions.SubscribeToLoginEvent``1(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [SubscribeToRegisterEvent\`\`1(services)](#M-Definux-Emeraude-Identity-Extensions-ServiceCollectionExtensions-SubscribeToRegisterEvent``1-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Definux.Emeraude.Identity.Extensions.ServiceCollectionExtensions.SubscribeToRegisterEvent``1(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [SubscribeToRequestChangeEmailEvent\`\`1(services)](#M-Definux-Emeraude-Identity-Extensions-ServiceCollectionExtensions-SubscribeToRequestChangeEmailEvent``1-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Definux.Emeraude.Identity.Extensions.ServiceCollectionExtensions.SubscribeToRequestChangeEmailEvent``1(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [SubscribeToResetPasswordEvent\`\`1(services)](#M-Definux-Emeraude-Identity-Extensions-ServiceCollectionExtensions-SubscribeToResetPasswordEvent``1-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Definux.Emeraude.Identity.Extensions.ServiceCollectionExtensions.SubscribeToResetPasswordEvent``1(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
- [StaticFunctions](#T-Definux-Emeraude-Identity-Common-StaticFunctions 'Definux.Emeraude.Identity.Common.StaticFunctions')
  - [GenerateRefreshToken()](#M-Definux-Emeraude-Identity-Common-StaticFunctions-GenerateRefreshToken 'Definux.Emeraude.Identity.Common.StaticFunctions.GenerateRefreshToken')
- [TwoFactorAuthenticationInfo](#T-Definux-Emeraude-Identity-Helpers-TwoFactorAuthenticationInfo 'Definux.Emeraude.Identity.Helpers.TwoFactorAuthenticationInfo')
  - [LoginProvider](#P-Definux-Emeraude-Identity-Helpers-TwoFactorAuthenticationInfo-LoginProvider 'Definux.Emeraude.Identity.Helpers.TwoFactorAuthenticationInfo.LoginProvider')
  - [UserId](#P-Definux-Emeraude-Identity-Helpers-TwoFactorAuthenticationInfo-UserId 'Definux.Emeraude.Identity.Helpers.TwoFactorAuthenticationInfo.UserId')
- [TwoFactorAuthenticationService](#T-Definux-Emeraude-Identity-Services-TwoFactorAuthenticationService 'Definux.Emeraude.Identity.Services.TwoFactorAuthenticationService')
  - [#ctor(userManager,urlEncoder,optionsAccessor)](#M-Definux-Emeraude-Identity-Services-TwoFactorAuthenticationService-#ctor-Microsoft-AspNetCore-Identity-UserManager{Definux-Emeraude-Identity-Entities-User},System-Text-Encodings-Web-UrlEncoder,Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions}- 'Definux.Emeraude.Identity.Services.TwoFactorAuthenticationService.#ctor(Microsoft.AspNetCore.Identity.UserManager{Definux.Emeraude.Identity.Entities.User},System.Text.Encodings.Web.UrlEncoder,Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions})')
  - [GenerateQrCodeUriAsync()](#M-Definux-Emeraude-Identity-Services-TwoFactorAuthenticationService-GenerateQrCodeUriAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Identity.Services.TwoFactorAuthenticationService.GenerateQrCodeUriAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [GetFormattedKeyAsync()](#M-Definux-Emeraude-Identity-Services-TwoFactorAuthenticationService-GetFormattedKeyAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Identity.Services.TwoFactorAuthenticationService.GetFormattedKeyAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [IsTwoFactorEnabled()](#M-Definux-Emeraude-Identity-Services-TwoFactorAuthenticationService-IsTwoFactorEnabled-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Identity.Services.TwoFactorAuthenticationService.IsTwoFactorEnabled(Definux.Emeraude.Domain.Entities.IUser)')
- [User](#T-Definux-Emeraude-Identity-Entities-User 'Definux.Emeraude.Identity.Entities.User')
  - [AvatarRelativePath](#P-Definux-Emeraude-Identity-Entities-User-AvatarRelativePath 'Definux.Emeraude.Identity.Entities.User.AvatarRelativePath')
  - [AvatarUrl](#P-Definux-Emeraude-Identity-Entities-User-AvatarUrl 'Definux.Emeraude.Identity.Entities.User.AvatarUrl')
  - [IsLockedOut](#P-Definux-Emeraude-Identity-Entities-User-IsLockedOut 'Definux.Emeraude.Identity.Entities.User.IsLockedOut')
  - [Name](#P-Definux-Emeraude-Identity-Entities-User-Name 'Definux.Emeraude.Identity.Entities.User.Name')
  - [RefreshToken](#P-Definux-Emeraude-Identity-Entities-User-RefreshToken 'Definux.Emeraude.Identity.Entities.User.RefreshToken')
  - [RefreshTokenExpiration](#P-Definux-Emeraude-Identity-Entities-User-RefreshTokenExpiration 'Definux.Emeraude.Identity.Entities.User.RefreshTokenExpiration')
  - [RegistrationDate](#P-Definux-Emeraude-Identity-Entities-User-RegistrationDate 'Definux.Emeraude.Identity.Entities.User.RegistrationDate')
- [UserAvatarService](#T-Definux-Emeraude-Identity-Services-UserAvatarService 'Definux.Emeraude.Identity.Services.UserAvatarService')
  - [#ctor(context,userManager,hostEnvironment,systemFilesService,rootsService,logger)](#M-Definux-Emeraude-Identity-Services-UserAvatarService-#ctor-Definux-Emeraude-Application-Persistence-IEmContext,Microsoft-AspNetCore-Identity-UserManager{Definux-Emeraude-Identity-Entities-User},Microsoft-AspNetCore-Hosting-IWebHostEnvironment,Definux-Emeraude-Application-Files-ISystemFilesService,Definux-Emeraude-Application-Files-IRootsService,Definux-Emeraude-Application-Logger-IEmLogger- 'Definux.Emeraude.Identity.Services.UserAvatarService.#ctor(Definux.Emeraude.Application.Persistence.IEmContext,Microsoft.AspNetCore.Identity.UserManager{Definux.Emeraude.Identity.Entities.User},Microsoft.AspNetCore.Hosting.IWebHostEnvironment,Definux.Emeraude.Application.Files.ISystemFilesService,Definux.Emeraude.Application.Files.IRootsService,Definux.Emeraude.Application.Logger.IEmLogger)')
  - [ApplyAvatarToUserAsync()](#M-Definux-Emeraude-Identity-Services-UserAvatarService-ApplyAvatarToUserAsync-System-Guid,System-String- 'Definux.Emeraude.Identity.Services.UserAvatarService.ApplyAvatarToUserAsync(System.Guid,System.String)')
  - [CreateAvatarFromUrlAsync()](#M-Definux-Emeraude-Identity-Services-UserAvatarService-CreateAvatarFromUrlAsync-System-String- 'Definux.Emeraude.Identity.Services.UserAvatarService.CreateAvatarFromUrlAsync(System.String)')
  - [CreateUserAvatarAsync()](#M-Definux-Emeraude-Identity-Services-UserAvatarService-CreateUserAvatarAsync-System-Byte[]- 'Definux.Emeraude.Identity.Services.UserAvatarService.CreateUserAvatarAsync(System.Byte[])')
  - [GetUserAvatarRelativePath()](#M-Definux-Emeraude-Identity-Services-UserAvatarService-GetUserAvatarRelativePath-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Identity.Services.UserAvatarService.GetUserAvatarRelativePath(Definux.Emeraude.Domain.Entities.IUser)')
- [UserClaim](#T-Definux-Emeraude-Identity-Entities-UserClaim 'Definux.Emeraude.Identity.Entities.UserClaim')
- [UserClaimsService](#T-Definux-Emeraude-Identity-Services-UserClaimsService 'Definux.Emeraude.Identity.Services.UserClaimsService')
  - [#ctor(userManager,roleManager,logger)](#M-Definux-Emeraude-Identity-Services-UserClaimsService-#ctor-Microsoft-AspNetCore-Identity-UserManager{Definux-Emeraude-Identity-Entities-User},Microsoft-AspNetCore-Identity-RoleManager{Definux-Emeraude-Identity-Entities-Role},Definux-Emeraude-Application-Logger-IEmLogger- 'Definux.Emeraude.Identity.Services.UserClaimsService.#ctor(Microsoft.AspNetCore.Identity.UserManager{Definux.Emeraude.Identity.Entities.User},Microsoft.AspNetCore.Identity.RoleManager{Definux.Emeraude.Identity.Entities.Role},Definux.Emeraude.Application.Logger.IEmLogger)')
  - [CheckUserForAccessAdministrationPermissionAsync()](#M-Definux-Emeraude-Identity-Services-UserClaimsService-CheckUserForAccessAdministrationPermissionAsync-System-String- 'Definux.Emeraude.Identity.Services.UserClaimsService.CheckUserForAccessAdministrationPermissionAsync(System.String)')
  - [GetAllUserClaimsAsync()](#M-Definux-Emeraude-Identity-Services-UserClaimsService-GetAllUserClaimsAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Identity.Services.UserClaimsService.GetAllUserClaimsAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [GetUserClaimsForCookieAsync()](#M-Definux-Emeraude-Identity-Services-UserClaimsService-GetUserClaimsForCookieAsync-System-Guid- 'Definux.Emeraude.Identity.Services.UserClaimsService.GetUserClaimsForCookieAsync(System.Guid)')
  - [GetUserClaimsForJwtTokenAsync()](#M-Definux-Emeraude-Identity-Services-UserClaimsService-GetUserClaimsForJwtTokenAsync-System-Guid- 'Definux.Emeraude.Identity.Services.UserClaimsService.GetUserClaimsForJwtTokenAsync(System.Guid)')
- [UserLogin](#T-Definux-Emeraude-Identity-Entities-UserLogin 'Definux.Emeraude.Identity.Entities.UserLogin')
- [UserManager](#T-Definux-Emeraude-Identity-Services-UserManager 'Definux.Emeraude.Identity.Services.UserManager')
  - [#ctor(userManager,httpContextAccessor,context)](#M-Definux-Emeraude-Identity-Services-UserManager-#ctor-Microsoft-AspNetCore-Identity-UserManager{Definux-Emeraude-Identity-Entities-User},Microsoft-AspNetCore-Http-IHttpContextAccessor,Definux-Emeraude-Application-Persistence-IEmContext- 'Definux.Emeraude.Identity.Services.UserManager.#ctor(Microsoft.AspNetCore.Identity.UserManager{Definux.Emeraude.Identity.Entities.User},Microsoft.AspNetCore.Http.IHttpContextAccessor,Definux.Emeraude.Application.Persistence.IEmContext)')
  - [Options](#P-Definux-Emeraude-Identity-Services-UserManager-Options 'Definux.Emeraude.Identity.Services.UserManager.Options')
  - [ChangeUserNameAsync()](#M-Definux-Emeraude-Identity-Services-UserManager-ChangeUserNameAsync-Definux-Emeraude-Domain-Entities-IUser,System-String- 'Definux.Emeraude.Identity.Services.UserManager.ChangeUserNameAsync(Definux.Emeraude.Domain.Entities.IUser,System.String)')
  - [CheckPasswordAsync()](#M-Definux-Emeraude-Identity-Services-UserManager-CheckPasswordAsync-System-String,System-String- 'Definux.Emeraude.Identity.Services.UserManager.CheckPasswordAsync(System.String,System.String)')
  - [CreateUserObject()](#M-Definux-Emeraude-Identity-Services-UserManager-CreateUserObject-System-String,System-String,System-Boolean- 'Definux.Emeraude.Identity.Services.UserManager.CreateUserObject(System.String,System.String,System.Boolean)')
  - [GetTwoFactorAuthenticationUserAsync()](#M-Definux-Emeraude-Identity-Services-UserManager-GetTwoFactorAuthenticationUserAsync 'Definux.Emeraude.Identity.Services.UserManager.GetTwoFactorAuthenticationUserAsync')
  - [IsEmailConfirmedAsync()](#M-Definux-Emeraude-Identity-Services-UserManager-IsEmailConfirmedAsync-System-String- 'Definux.Emeraude.Identity.Services.UserManager.IsEmailConfirmedAsync(System.String)')
  - [IsLockedOutAsync()](#M-Definux-Emeraude-Identity-Services-UserManager-IsLockedOutAsync-System-String- 'Definux.Emeraude.Identity.Services.UserManager.IsLockedOutAsync(System.String)')
- [UserRole](#T-Definux-Emeraude-Identity-Entities-UserRole 'Definux.Emeraude.Identity.Entities.UserRole')
- [UserToken](#T-Definux-Emeraude-Identity-Entities-UserToken 'Definux.Emeraude.Identity.Entities.UserToken')
- [UserTokensService](#T-Definux-Emeraude-Identity-Services-UserTokensService 'Definux.Emeraude.Identity.Services.UserTokensService')
  - [#ctor(userManager,context,userClaimsService,jsonWebTokenOptions,logger)](#M-Definux-Emeraude-Identity-Services-UserTokensService-#ctor-Microsoft-AspNetCore-Identity-UserManager{Definux-Emeraude-Identity-Entities-User},Definux-Emeraude-Application-Persistence-IEmContext,Definux-Emeraude-Application-Identity-IUserClaimsService,Microsoft-Extensions-Options-IOptions{Definux-Utilities-Options-JsonWebTokenOptions},Definux-Emeraude-Application-Logger-IEmLogger- 'Definux.Emeraude.Identity.Services.UserTokensService.#ctor(Microsoft.AspNetCore.Identity.UserManager{Definux.Emeraude.Identity.Entities.User},Definux.Emeraude.Application.Persistence.IEmContext,Definux.Emeraude.Application.Identity.IUserClaimsService,Microsoft.Extensions.Options.IOptions{Definux.Utilities.Options.JsonWebTokenOptions},Definux.Emeraude.Application.Logger.IEmLogger)')
  - [BuildJwtTokenForExternalUserAsync()](#M-Definux-Emeraude-Identity-Services-UserTokensService-BuildJwtTokenForExternalUserAsync-Definux-Emeraude-Application-Identity-IExternalUser- 'Definux.Emeraude.Identity.Services.UserTokensService.BuildJwtTokenForExternalUserAsync(Definux.Emeraude.Application.Identity.IExternalUser)')
  - [BuildJwtTokenForUserAsync()](#M-Definux-Emeraude-Identity-Services-UserTokensService-BuildJwtTokenForUserAsync-System-Guid- 'Definux.Emeraude.Identity.Services.UserTokensService.BuildJwtTokenForUserAsync(System.Guid)')
  - [RefreshJwtTokenAsync()](#M-Definux-Emeraude-Identity-Services-UserTokensService-RefreshJwtTokenAsync-System-Nullable{System-Guid},System-String- 'Definux.Emeraude.Identity.Services.UserTokensService.RefreshJwtTokenAsync(System.Nullable{System.Guid},System.String)')
  - [ResetRefreshTokenAsync()](#M-Definux-Emeraude-Identity-Services-UserTokensService-ResetRefreshTokenAsync-System-Guid- 'Definux.Emeraude.Identity.Services.UserTokensService.ResetRefreshTokenAsync(System.Guid)')

<a name='T-Definux-Emeraude-Identity-Services-CurrentUserProvider'></a>
## CurrentUserProvider `type`

##### Namespace

Definux.Emeraude.Identity.Services

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Identity-Services-CurrentUserProvider-#ctor-Microsoft-AspNetCore-Http-IHttpContextAccessor,Microsoft-AspNetCore-Identity-UserManager{Definux-Emeraude-Identity-Entities-User},Definux-Emeraude-Application-Logger-IEmLogger-'></a>
### #ctor(httpAccessor,userManager,logger) `constructor`

##### Summary

Initializes a new instance of the [CurrentUserProvider](#T-Definux-Emeraude-Identity-Services-CurrentUserProvider 'Definux.Emeraude.Identity.Services.CurrentUserProvider') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| httpAccessor | [Microsoft.AspNetCore.Http.IHttpContextAccessor](#T-Microsoft-AspNetCore-Http-IHttpContextAccessor 'Microsoft.AspNetCore.Http.IHttpContextAccessor') |  |
| userManager | [Microsoft.AspNetCore.Identity.UserManager{Definux.Emeraude.Identity.Entities.User}](#T-Microsoft-AspNetCore-Identity-UserManager{Definux-Emeraude-Identity-Entities-User} 'Microsoft.AspNetCore.Identity.UserManager{Definux.Emeraude.Identity.Entities.User}') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |

<a name='P-Definux-Emeraude-Identity-Services-CurrentUserProvider-CurrentUserId'></a>
### CurrentUserId `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Identity-Services-CurrentUserProvider-GetCurrentUserAsync'></a>
### GetCurrentUserAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Identity-Extensions-DatabaseContextExtensions'></a>
## DatabaseContextExtensions `type`

##### Namespace

Definux.Emeraude.Identity.Extensions

##### Summary

Extensions for [IEmContext](#T-Definux-Emeraude-Application-Persistence-IEmContext 'Definux.Emeraude.Application.Persistence.IEmContext').

<a name='M-Definux-Emeraude-Identity-Extensions-DatabaseContextExtensions-BuildRefreshToken-Definux-Emeraude-Application-Persistence-IEmContext,Definux-Emeraude-Identity-Entities-User-'></a>
### BuildRefreshToken(context,user) `method`

##### Summary

Build refresh token for a user.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Definux.Emeraude.Application.Persistence.IEmContext](#T-Definux-Emeraude-Application-Persistence-IEmContext 'Definux.Emeraude.Application.Persistence.IEmContext') |  |
| user | [Definux.Emeraude.Identity.Entities.User](#T-Definux-Emeraude-Identity-Entities-User 'Definux.Emeraude.Identity.Entities.User') |  |

<a name='M-Definux-Emeraude-Identity-Extensions-DatabaseContextExtensions-ResetRefreshToken-Definux-Emeraude-Application-Persistence-IEmContext,Definux-Emeraude-Identity-Entities-User-'></a>
### ResetRefreshToken(context,user) `method`

##### Summary

Reset refresh token for a user.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Definux.Emeraude.Application.Persistence.IEmContext](#T-Definux-Emeraude-Application-Persistence-IEmContext 'Definux.Emeraude.Application.Persistence.IEmContext') |  |
| user | [Definux.Emeraude.Identity.Entities.User](#T-Definux-Emeraude-Identity-Entities-User 'Definux.Emeraude.Identity.Entities.User') |  |

<a name='T-Definux-Emeraude-Identity-Services-DefaultUserManager'></a>
## DefaultUserManager `type`

##### Namespace

Definux.Emeraude.Identity.Services

##### Summary

ASP.NET Core user manager wrapper for the purposes of Emeraude user manager.

<a name='M-Definux-Emeraude-Identity-Services-DefaultUserManager-#ctor-Microsoft-AspNetCore-Identity-UserManager{Definux-Emeraude-Identity-Entities-User}-'></a>
### #ctor(userManager) `constructor`

##### Summary

Initializes a new instance of the [DefaultUserManager](#T-Definux-Emeraude-Identity-Services-DefaultUserManager 'Definux.Emeraude.Identity.Services.DefaultUserManager') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userManager | [Microsoft.AspNetCore.Identity.UserManager{Definux.Emeraude.Identity.Entities.User}](#T-Microsoft-AspNetCore-Identity-UserManager{Definux-Emeraude-Identity-Entities-User} 'Microsoft.AspNetCore.Identity.UserManager{Definux.Emeraude.Identity.Entities.User}') |  |

<a name='P-Definux-Emeraude-Identity-Services-DefaultUserManager-UserManager'></a>
### UserManager `property`

##### Summary

ASP.NET Core User Manager instance.

<a name='T-Definux-Emeraude-Identity-ExternalProviders-ExternalProviderAuthenticatorFactory'></a>
## ExternalProviderAuthenticatorFactory `type`

##### Namespace

Definux.Emeraude.Identity.ExternalProviders

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Identity-ExternalProviders-ExternalProviderAuthenticatorFactory-#ctor-System-Collections-Generic-List{Definux-Emeraude-Application-Identity-IExternalProviderAuthenticator}-'></a>
### #ctor(authenticators) `constructor`

##### Summary

Initializes a new instance of the [ExternalProviderAuthenticatorFactory](#T-Definux-Emeraude-Identity-ExternalProviders-ExternalProviderAuthenticatorFactory 'Definux.Emeraude.Identity.ExternalProviders.ExternalProviderAuthenticatorFactory') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| authenticators | [System.Collections.Generic.List{Definux.Emeraude.Application.Identity.IExternalProviderAuthenticator}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{Definux.Emeraude.Application.Identity.IExternalProviderAuthenticator}') |  |

<a name='P-Definux-Emeraude-Identity-ExternalProviders-ExternalProviderAuthenticatorFactory-Providers'></a>
### Providers `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Identity-ExternalProviders-ExternalProviderAuthenticatorFactory-ContainsProvider-System-String-'></a>
### ContainsProvider() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-ExternalProviders-ExternalProviderAuthenticatorFactory-GetAuthenticator-System-String-'></a>
### GetAuthenticator() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Identity-ExternalProviders-Facebook-FacebookAuthenticator'></a>
## FacebookAuthenticator `type`

##### Namespace

Definux.Emeraude.Identity.ExternalProviders.Facebook

##### Summary

Facebook authenticator for external authentication.

<a name='P-Definux-Emeraude-Identity-ExternalProviders-Facebook-FacebookAuthenticator-Name'></a>
### Name `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Identity-ExternalProviders-Facebook-FacebookAuthenticator-GetExternalUserAsync-System-Security-Claims-ClaimsPrincipal-'></a>
### GetExternalUserAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-ExternalProviders-Facebook-FacebookAuthenticator-GetExternalUserAsync-System-String,System-String-'></a>
### GetExternalUserAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-ExternalProviders-Facebook-FacebookAuthenticator-RegisterAuthenticator-Microsoft-AspNetCore-Authentication-AuthenticationBuilder-'></a>
### RegisterAuthenticator() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Identity-ExternalProviders-Facebook-FacebookExternalUser'></a>
## FacebookExternalUser `type`

##### Namespace

Definux.Emeraude.Identity.ExternalProviders.Facebook

##### Summary

Facebook external user implementation.

<a name='P-Definux-Emeraude-Identity-ExternalProviders-Facebook-FacebookExternalUser-EmailAddress'></a>
### EmailAddress `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Identity-ExternalProviders-Facebook-FacebookExternalUser-FirstName'></a>
### FirstName `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Identity-ExternalProviders-Facebook-FacebookExternalUser-Id'></a>
### Id `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Identity-ExternalProviders-Facebook-FacebookExternalUser-LastName'></a>
### LastName `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Identity-ExternalProviders-Facebook-FacebookExternalUser-Name'></a>
### Name `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Identity-ExternalProviders-Facebook-FacebookExternalUser-Picture'></a>
### Picture `property`

##### Summary

Picture of the user.

<a name='P-Definux-Emeraude-Identity-ExternalProviders-Facebook-FacebookExternalUser-PictureUrl'></a>
### PictureUrl `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Identity-ExternalProviders-Facebook-FacebookExternalUser-Provider'></a>
### Provider `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Identity-ExternalProviders-Google-GoogleAuthenticator'></a>
## GoogleAuthenticator `type`

##### Namespace

Definux.Emeraude.Identity.ExternalProviders.Google

##### Summary

Google authenticator for external authentication.

<a name='P-Definux-Emeraude-Identity-ExternalProviders-Google-GoogleAuthenticator-Name'></a>
### Name `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Identity-ExternalProviders-Google-GoogleAuthenticator-GetExternalUserAsync-System-Security-Claims-ClaimsPrincipal-'></a>
### GetExternalUserAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-ExternalProviders-Google-GoogleAuthenticator-GetExternalUserAsync-System-String,System-String-'></a>
### GetExternalUserAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-ExternalProviders-Google-GoogleAuthenticator-RegisterAuthenticator-Microsoft-AspNetCore-Authentication-AuthenticationBuilder-'></a>
### RegisterAuthenticator() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Identity-ExternalProviders-Google-GoogleExternalUser'></a>
## GoogleExternalUser `type`

##### Namespace

Definux.Emeraude.Identity.ExternalProviders.Google

##### Summary

Google external user implementation.

<a name='P-Definux-Emeraude-Identity-ExternalProviders-Google-GoogleExternalUser-EmailAddress'></a>
### EmailAddress `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Identity-ExternalProviders-Google-GoogleExternalUser-FirstName'></a>
### FirstName `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Identity-ExternalProviders-Google-GoogleExternalUser-Id'></a>
### Id `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Identity-ExternalProviders-Google-GoogleExternalUser-LastName'></a>
### LastName `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Identity-ExternalProviders-Google-GoogleExternalUser-Name'></a>
### Name `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Identity-ExternalProviders-Google-GoogleExternalUser-Picture'></a>
### Picture `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Identity-ExternalProviders-Google-GoogleExternalUser-PictureUrl'></a>
### PictureUrl `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Identity-ExternalProviders-Google-GoogleExternalUser-Provider'></a>
### Provider `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Identity-IdentityContext`1'></a>
## IdentityContext\`1 `type`

##### Namespace

Definux.Emeraude.Identity

##### Summary

Implementation of [IdentityDbContext](#T-Microsoft-AspNetCore-Identity-EntityFrameworkCore-IdentityDbContext 'Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext') that wrap the identity functionality of ASP.NET Core for the purposes of Emeraude.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TContext | [IdentityContext\`1](#T-Definux-Emeraude-Identity-IdentityContext`1 'Definux.Emeraude.Identity.IdentityContext`1'). |

<a name='M-Definux-Emeraude-Identity-IdentityContext`1-#ctor-Microsoft-EntityFrameworkCore-DbContextOptions{`0}-'></a>
### #ctor(options) `constructor`

##### Summary

Initializes a new instance of the [IdentityContext\`1](#T-Definux-Emeraude-Identity-IdentityContext`1 'Definux.Emeraude.Identity.IdentityContext`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [Microsoft.EntityFrameworkCore.DbContextOptions{\`0}](#T-Microsoft-EntityFrameworkCore-DbContextOptions{`0} 'Microsoft.EntityFrameworkCore.DbContextOptions{`0}') |  |

<a name='M-Definux-Emeraude-Identity-IdentityContext`1-OnModelCreating-Microsoft-EntityFrameworkCore-ModelBuilder-'></a>
### OnModelCreating() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Identity-EventHandlers-IdentityEventManager'></a>
## IdentityEventManager `type`

##### Namespace

Definux.Emeraude.Identity.EventHandlers

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Identity-EventHandlers-IdentityEventManager-#ctor-System-IServiceProvider,Microsoft-AspNetCore-Http-IHttpContextAccessor,Definux-Emeraude-Application-Logger-IEmLogger-'></a>
### #ctor(serviceProvider,httpContextAccessor,logger) `constructor`

##### Summary

Initializes a new instance of the [IdentityEventManager](#T-Definux-Emeraude-Identity-EventHandlers-IdentityEventManager 'Definux.Emeraude.Identity.EventHandlers.IdentityEventManager') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceProvider | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') |  |
| httpContextAccessor | [Microsoft.AspNetCore.Http.IHttpContextAccessor](#T-Microsoft-AspNetCore-Http-IHttpContextAccessor 'Microsoft.AspNetCore.Http.IHttpContextAccessor') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |

<a name='M-Definux-Emeraude-Identity-EventHandlers-IdentityEventManager-TriggerConfirmedEmailEventAsync-System-Guid-'></a>
### TriggerConfirmedEmailEventAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-EventHandlers-IdentityEventManager-TriggerExternalLoginEventAsync-System-Guid-'></a>
### TriggerExternalLoginEventAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-EventHandlers-IdentityEventManager-TriggerExternalRegisterEventAsync-System-Guid-'></a>
### TriggerExternalRegisterEventAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-EventHandlers-IdentityEventManager-TriggerForgotPasswordEventAsync-System-Guid,System-String-'></a>
### TriggerForgotPasswordEventAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-EventHandlers-IdentityEventManager-TriggerLoginEventAsync-System-Guid-'></a>
### TriggerLoginEventAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-EventHandlers-IdentityEventManager-TriggerRegisterEventAsync-System-Guid,System-String-'></a>
### TriggerRegisterEventAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-EventHandlers-IdentityEventManager-TriggerRequestChangeEmailEventAsync-System-Guid,System-String,System-String-'></a>
### TriggerRequestChangeEmailEventAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-EventHandlers-IdentityEventManager-TriggerResetPasswordEventAsync-System-Guid-'></a>
### TriggerResetPasswordEventAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Identity-ExternalProviders-Facebook-ProfilePicture'></a>
## ProfilePicture `type`

##### Namespace

Definux.Emeraude.Identity.ExternalProviders.Facebook

##### Summary

Helper class for mapping Facebook profile picture.

<a name='P-Definux-Emeraude-Identity-ExternalProviders-Facebook-ProfilePicture-Data'></a>
### Data `property`

##### Summary

Profile picture data.

<a name='T-Definux-Emeraude-Identity-ExternalProviders-Facebook-ProfilePictureData'></a>
## ProfilePictureData `type`

##### Namespace

Definux.Emeraude.Identity.ExternalProviders.Facebook

##### Summary

Helper class for mapping Facebook profile picture data.

<a name='P-Definux-Emeraude-Identity-ExternalProviders-Facebook-ProfilePictureData-Url'></a>
### Url `property`

##### Summary

Url of the picture.

<a name='T-Definux-Emeraude-Identity-Entities-Role'></a>
## Role `type`

##### Namespace

Definux.Emeraude.Identity.Entities

##### Summary

Role entity used from the application that implements ASP.NET Core [IdentityRole\`1](#T-Microsoft-AspNetCore-Identity-IdentityRole`1 'Microsoft.AspNetCore.Identity.IdentityRole`1').

<a name='M-Definux-Emeraude-Identity-Entities-Role-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [Role](#T-Definux-Emeraude-Identity-Entities-Role 'Definux.Emeraude.Identity.Entities.Role') class.

##### Parameters

This constructor has no parameters.

<a name='M-Definux-Emeraude-Identity-Entities-Role-#ctor-System-String-'></a>
### #ctor(roleName) `constructor`

##### Summary

Initializes a new instance of the [Role](#T-Definux-Emeraude-Identity-Entities-Role 'Definux.Emeraude.Identity.Entities.Role') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| roleName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Identity-Entities-Role-#ctor-System-String,System-String-'></a>
### #ctor(roleName,description) `constructor`

##### Summary

Initializes a new instance of the [Role](#T-Definux-Emeraude-Identity-Entities-Role 'Definux.Emeraude.Identity.Entities.Role') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| roleName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='P-Definux-Emeraude-Identity-Entities-Role-Description'></a>
### Description `property`

##### Summary

Description of the role.

<a name='T-Definux-Emeraude-Identity-Entities-RoleClaim'></a>
## RoleClaim `type`

##### Namespace

Definux.Emeraude.Identity.Entities

##### Summary

Role claim entity used from the application that implements ASP.NET Core [IdentityRoleClaim\`1](#T-Microsoft-AspNetCore-Identity-IdentityRoleClaim`1 'Microsoft.AspNetCore.Identity.IdentityRoleClaim`1').

<a name='T-Definux-Emeraude-Identity-Services-RoleManager'></a>
## RoleManager `type`

##### Namespace

Definux.Emeraude.Identity.Services

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Identity-Services-RoleManager-#ctor-Microsoft-AspNetCore-Identity-RoleManager{Definux-Emeraude-Identity-Entities-Role},Microsoft-AspNetCore-Identity-UserManager{Definux-Emeraude-Identity-Entities-User},Definux-Emeraude-Application-Persistence-IEmContext,Definux-Emeraude-Application-Logger-IEmLogger-'></a>
### #ctor(roleManager,userManager,context,logger) `constructor`

##### Summary

Initializes a new instance of the [RoleManager](#T-Definux-Emeraude-Identity-Services-RoleManager 'Definux.Emeraude.Identity.Services.RoleManager') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| roleManager | [Microsoft.AspNetCore.Identity.RoleManager{Definux.Emeraude.Identity.Entities.Role}](#T-Microsoft-AspNetCore-Identity-RoleManager{Definux-Emeraude-Identity-Entities-Role} 'Microsoft.AspNetCore.Identity.RoleManager{Definux.Emeraude.Identity.Entities.Role}') |  |
| userManager | [Microsoft.AspNetCore.Identity.UserManager{Definux.Emeraude.Identity.Entities.User}](#T-Microsoft-AspNetCore-Identity-UserManager{Definux-Emeraude-Identity-Entities-User} 'Microsoft.AspNetCore.Identity.UserManager{Definux.Emeraude.Identity.Entities.User}') |  |
| context | [Definux.Emeraude.Application.Persistence.IEmContext](#T-Definux-Emeraude-Application-Persistence-IEmContext 'Definux.Emeraude.Application.Persistence.IEmContext') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |

<a name='M-Definux-Emeraude-Identity-Services-RoleManager-AssignRolesToUserAsync-Definux-Emeraude-Domain-Entities-IUser,System-Collections-Generic-IEnumerable{System-Guid}-'></a>
### AssignRolesToUserAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-Services-RoleManager-CreateRoleAsync-System-String,System-Collections-Generic-IEnumerable{System-String}-'></a>
### CreateRoleAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-Services-RoleManager-DeleteRoleAsync-System-String-'></a>
### DeleteRoleAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-Services-RoleManager-GetRolesAsync'></a>
### GetRolesAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-Services-RoleManager-GetUserRolesAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### GetUserRolesAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-Services-RoleManager-UnassignAllRolesFromUserAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### UnassignAllRolesFromUserAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Identity-Extensions-ServiceCollectionExtensions'></a>
## ServiceCollectionExtensions `type`

##### Namespace

Definux.Emeraude.Identity.Extensions

##### Summary

Extensions for [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection').

<a name='M-Definux-Emeraude-Identity-Extensions-ServiceCollectionExtensions-RegisterEmeraudeIdentity-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### RegisterEmeraudeIdentity(services) `method`

##### Summary

Registers Emeraude identity infrastructure.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |

<a name='M-Definux-Emeraude-Identity-Extensions-ServiceCollectionExtensions-RegisterExternalProvidersAuthenticators-Microsoft-Extensions-DependencyInjection-IServiceCollection,Microsoft-AspNetCore-Authentication-AuthenticationBuilder,System-Action{System-Collections-Generic-List{Definux-Emeraude-Application-Identity-IExternalProviderAuthenticator}}-'></a>
### RegisterExternalProvidersAuthenticators(services,authenticationBuilder,authenticatorsAction) `method`

##### Summary

Register external providers authenticators.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |
| authenticationBuilder | [Microsoft.AspNetCore.Authentication.AuthenticationBuilder](#T-Microsoft-AspNetCore-Authentication-AuthenticationBuilder 'Microsoft.AspNetCore.Authentication.AuthenticationBuilder') |  |
| authenticatorsAction | [System.Action{System.Collections.Generic.List{Definux.Emeraude.Application.Identity.IExternalProviderAuthenticator}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Collections.Generic.List{Definux.Emeraude.Application.Identity.IExternalProviderAuthenticator}}') |  |

<a name='M-Definux-Emeraude-Identity-Extensions-ServiceCollectionExtensions-SubscribeToConfirmedEmailEvent``1-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### SubscribeToConfirmedEmailEvent\`\`1(services) `method`

##### Summary

Register an event handler which will be triggered when a user has confirmed his email.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEventHandler | Confirmed email event handler. |

<a name='M-Definux-Emeraude-Identity-Extensions-ServiceCollectionExtensions-SubscribeToExternalLoginEvent``1-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### SubscribeToExternalLoginEvent\`\`1(services) `method`

##### Summary

Register an event handler which will be triggered when a user has logged in the application via external authentication provider.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEventHandler | External login event handler. |

<a name='M-Definux-Emeraude-Identity-Extensions-ServiceCollectionExtensions-SubscribeToExternalRegisterEvent``1-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### SubscribeToExternalRegisterEvent\`\`1(services) `method`

##### Summary

Register an event handler which will be triggered when a user has registered in the application via external authentication provider.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEventHandler | External register event handler. |

<a name='M-Definux-Emeraude-Identity-Extensions-ServiceCollectionExtensions-SubscribeToForgotPasswordEvent``1-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### SubscribeToForgotPasswordEvent\`\`1(services) `method`

##### Summary

Register an event handler which will be triggered when a user has made a request to reset his/her password.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEventHandler | Forgot password event handler. |

<a name='M-Definux-Emeraude-Identity-Extensions-ServiceCollectionExtensions-SubscribeToLoginEvent``1-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### SubscribeToLoginEvent\`\`1(services) `method`

##### Summary

Register an event handler which will be triggered when a user has logged in the application via email/password form.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEventHandler | Login event handler. |

<a name='M-Definux-Emeraude-Identity-Extensions-ServiceCollectionExtensions-SubscribeToRegisterEvent``1-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### SubscribeToRegisterEvent\`\`1(services) `method`

##### Summary

Register an event handler which will be triggered when a user has registered in the application via email/password form.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEventHandler | Event handler. |

<a name='M-Definux-Emeraude-Identity-Extensions-ServiceCollectionExtensions-SubscribeToRequestChangeEmailEvent``1-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### SubscribeToRequestChangeEmailEvent\`\`1(services) `method`

##### Summary

Register an event handler which will be triggered when a user has made a request for change its email.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEventHandler | Request change email event handler. |

<a name='M-Definux-Emeraude-Identity-Extensions-ServiceCollectionExtensions-SubscribeToResetPasswordEvent``1-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### SubscribeToResetPasswordEvent\`\`1(services) `method`

##### Summary

Register an event handler which will be triggered when a user has reset his/her password.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEventHandler | Reset password event handler. |

<a name='T-Definux-Emeraude-Identity-Common-StaticFunctions'></a>
## StaticFunctions `type`

##### Namespace

Definux.Emeraude.Identity.Common

##### Summary

Static functions used from identity infrastructure.

<a name='M-Definux-Emeraude-Identity-Common-StaticFunctions-GenerateRefreshToken'></a>
### GenerateRefreshToken() `method`

##### Summary

Generate random string used for refresh token string.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Identity-Helpers-TwoFactorAuthenticationInfo'></a>
## TwoFactorAuthenticationInfo `type`

##### Namespace

Definux.Emeraude.Identity.Helpers

##### Summary

Help class that contains user id and two factor authentication login provider.

<a name='P-Definux-Emeraude-Identity-Helpers-TwoFactorAuthenticationInfo-LoginProvider'></a>
### LoginProvider `property`

##### Summary

Login provider.

<a name='P-Definux-Emeraude-Identity-Helpers-TwoFactorAuthenticationInfo-UserId'></a>
### UserId `property`

##### Summary

Id of the user.

<a name='T-Definux-Emeraude-Identity-Services-TwoFactorAuthenticationService'></a>
## TwoFactorAuthenticationService `type`

##### Namespace

Definux.Emeraude.Identity.Services

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Identity-Services-TwoFactorAuthenticationService-#ctor-Microsoft-AspNetCore-Identity-UserManager{Definux-Emeraude-Identity-Entities-User},System-Text-Encodings-Web-UrlEncoder,Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions}-'></a>
### #ctor(userManager,urlEncoder,optionsAccessor) `constructor`

##### Summary

Initializes a new instance of the [TwoFactorAuthenticationService](#T-Definux-Emeraude-Identity-Services-TwoFactorAuthenticationService 'Definux.Emeraude.Identity.Services.TwoFactorAuthenticationService') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userManager | [Microsoft.AspNetCore.Identity.UserManager{Definux.Emeraude.Identity.Entities.User}](#T-Microsoft-AspNetCore-Identity-UserManager{Definux-Emeraude-Identity-Entities-User} 'Microsoft.AspNetCore.Identity.UserManager{Definux.Emeraude.Identity.Entities.User}') |  |
| urlEncoder | [System.Text.Encodings.Web.UrlEncoder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encodings.Web.UrlEncoder 'System.Text.Encodings.Web.UrlEncoder') |  |
| optionsAccessor | [Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions}](#T-Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions} 'Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions}') |  |

<a name='M-Definux-Emeraude-Identity-Services-TwoFactorAuthenticationService-GenerateQrCodeUriAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### GenerateQrCodeUriAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-Services-TwoFactorAuthenticationService-GetFormattedKeyAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### GetFormattedKeyAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-Services-TwoFactorAuthenticationService-IsTwoFactorEnabled-Definux-Emeraude-Domain-Entities-IUser-'></a>
### IsTwoFactorEnabled() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Identity-Entities-User'></a>
## User `type`

##### Namespace

Definux.Emeraude.Identity.Entities

##### Summary

Emeraude application user that implements ASP.NET Core [IdentityUser\`1](#T-Microsoft-AspNetCore-Identity-IdentityUser`1 'Microsoft.AspNetCore.Identity.IdentityUser`1').

<a name='P-Definux-Emeraude-Identity-Entities-User-AvatarRelativePath'></a>
### AvatarRelativePath `property`

##### Summary

User avatar relative path.

<a name='P-Definux-Emeraude-Identity-Entities-User-AvatarUrl'></a>
### AvatarUrl `property`

##### Summary

User avatar url.

<a name='P-Definux-Emeraude-Identity-Entities-User-IsLockedOut'></a>
### IsLockedOut `property`

##### Summary

Property that indicates whether the user is locked out.

<a name='P-Definux-Emeraude-Identity-Entities-User-Name'></a>
### Name `property`

##### Summary

Name of the user.

<a name='P-Definux-Emeraude-Identity-Entities-User-RefreshToken'></a>
### RefreshToken `property`

##### Summary

Refresh token used for requesting new Json Web Token.

<a name='P-Definux-Emeraude-Identity-Entities-User-RefreshTokenExpiration'></a>
### RefreshTokenExpiration `property`

##### Summary

Refresh token expiration date.

<a name='P-Definux-Emeraude-Identity-Entities-User-RegistrationDate'></a>
### RegistrationDate `property`

##### Summary

Registration date of the user.

<a name='T-Definux-Emeraude-Identity-Services-UserAvatarService'></a>
## UserAvatarService `type`

##### Namespace

Definux.Emeraude.Identity.Services

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Identity-Services-UserAvatarService-#ctor-Definux-Emeraude-Application-Persistence-IEmContext,Microsoft-AspNetCore-Identity-UserManager{Definux-Emeraude-Identity-Entities-User},Microsoft-AspNetCore-Hosting-IWebHostEnvironment,Definux-Emeraude-Application-Files-ISystemFilesService,Definux-Emeraude-Application-Files-IRootsService,Definux-Emeraude-Application-Logger-IEmLogger-'></a>
### #ctor(context,userManager,hostEnvironment,systemFilesService,rootsService,logger) `constructor`

##### Summary

Initializes a new instance of the [UserAvatarService](#T-Definux-Emeraude-Identity-Services-UserAvatarService 'Definux.Emeraude.Identity.Services.UserAvatarService') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Definux.Emeraude.Application.Persistence.IEmContext](#T-Definux-Emeraude-Application-Persistence-IEmContext 'Definux.Emeraude.Application.Persistence.IEmContext') |  |
| userManager | [Microsoft.AspNetCore.Identity.UserManager{Definux.Emeraude.Identity.Entities.User}](#T-Microsoft-AspNetCore-Identity-UserManager{Definux-Emeraude-Identity-Entities-User} 'Microsoft.AspNetCore.Identity.UserManager{Definux.Emeraude.Identity.Entities.User}') |  |
| hostEnvironment | [Microsoft.AspNetCore.Hosting.IWebHostEnvironment](#T-Microsoft-AspNetCore-Hosting-IWebHostEnvironment 'Microsoft.AspNetCore.Hosting.IWebHostEnvironment') |  |
| systemFilesService | [Definux.Emeraude.Application.Files.ISystemFilesService](#T-Definux-Emeraude-Application-Files-ISystemFilesService 'Definux.Emeraude.Application.Files.ISystemFilesService') |  |
| rootsService | [Definux.Emeraude.Application.Files.IRootsService](#T-Definux-Emeraude-Application-Files-IRootsService 'Definux.Emeraude.Application.Files.IRootsService') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |

<a name='M-Definux-Emeraude-Identity-Services-UserAvatarService-ApplyAvatarToUserAsync-System-Guid,System-String-'></a>
### ApplyAvatarToUserAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-Services-UserAvatarService-CreateAvatarFromUrlAsync-System-String-'></a>
### CreateAvatarFromUrlAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-Services-UserAvatarService-CreateUserAvatarAsync-System-Byte[]-'></a>
### CreateUserAvatarAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-Services-UserAvatarService-GetUserAvatarRelativePath-Definux-Emeraude-Domain-Entities-IUser-'></a>
### GetUserAvatarRelativePath() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Identity-Entities-UserClaim'></a>
## UserClaim `type`

##### Namespace

Definux.Emeraude.Identity.Entities

##### Summary

User claim entity used from the application that implements ASP.NET Core [IdentityUserClaim\`1](#T-Microsoft-AspNetCore-Identity-IdentityUserClaim`1 'Microsoft.AspNetCore.Identity.IdentityUserClaim`1').

<a name='T-Definux-Emeraude-Identity-Services-UserClaimsService'></a>
## UserClaimsService `type`

##### Namespace

Definux.Emeraude.Identity.Services

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Identity-Services-UserClaimsService-#ctor-Microsoft-AspNetCore-Identity-UserManager{Definux-Emeraude-Identity-Entities-User},Microsoft-AspNetCore-Identity-RoleManager{Definux-Emeraude-Identity-Entities-Role},Definux-Emeraude-Application-Logger-IEmLogger-'></a>
### #ctor(userManager,roleManager,logger) `constructor`

##### Summary

Initializes a new instance of the [UserClaimsService](#T-Definux-Emeraude-Identity-Services-UserClaimsService 'Definux.Emeraude.Identity.Services.UserClaimsService') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userManager | [Microsoft.AspNetCore.Identity.UserManager{Definux.Emeraude.Identity.Entities.User}](#T-Microsoft-AspNetCore-Identity-UserManager{Definux-Emeraude-Identity-Entities-User} 'Microsoft.AspNetCore.Identity.UserManager{Definux.Emeraude.Identity.Entities.User}') |  |
| roleManager | [Microsoft.AspNetCore.Identity.RoleManager{Definux.Emeraude.Identity.Entities.Role}](#T-Microsoft-AspNetCore-Identity-RoleManager{Definux-Emeraude-Identity-Entities-Role} 'Microsoft.AspNetCore.Identity.RoleManager{Definux.Emeraude.Identity.Entities.Role}') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |

<a name='M-Definux-Emeraude-Identity-Services-UserClaimsService-CheckUserForAccessAdministrationPermissionAsync-System-String-'></a>
### CheckUserForAccessAdministrationPermissionAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-Services-UserClaimsService-GetAllUserClaimsAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### GetAllUserClaimsAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-Services-UserClaimsService-GetUserClaimsForCookieAsync-System-Guid-'></a>
### GetUserClaimsForCookieAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-Services-UserClaimsService-GetUserClaimsForJwtTokenAsync-System-Guid-'></a>
### GetUserClaimsForJwtTokenAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Identity-Entities-UserLogin'></a>
## UserLogin `type`

##### Namespace

Definux.Emeraude.Identity.Entities

##### Summary

User login entity used from the application that implements ASP.NET Core [IdentityUserLogin\`1](#T-Microsoft-AspNetCore-Identity-IdentityUserLogin`1 'Microsoft.AspNetCore.Identity.IdentityUserLogin`1').

<a name='T-Definux-Emeraude-Identity-Services-UserManager'></a>
## UserManager `type`

##### Namespace

Definux.Emeraude.Identity.Services

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Identity-Services-UserManager-#ctor-Microsoft-AspNetCore-Identity-UserManager{Definux-Emeraude-Identity-Entities-User},Microsoft-AspNetCore-Http-IHttpContextAccessor,Definux-Emeraude-Application-Persistence-IEmContext-'></a>
### #ctor(userManager,httpContextAccessor,context) `constructor`

##### Summary

Initializes a new instance of the [UserManager](#T-Definux-Emeraude-Identity-Services-UserManager 'Definux.Emeraude.Identity.Services.UserManager') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userManager | [Microsoft.AspNetCore.Identity.UserManager{Definux.Emeraude.Identity.Entities.User}](#T-Microsoft-AspNetCore-Identity-UserManager{Definux-Emeraude-Identity-Entities-User} 'Microsoft.AspNetCore.Identity.UserManager{Definux.Emeraude.Identity.Entities.User}') |  |
| httpContextAccessor | [Microsoft.AspNetCore.Http.IHttpContextAccessor](#T-Microsoft-AspNetCore-Http-IHttpContextAccessor 'Microsoft.AspNetCore.Http.IHttpContextAccessor') |  |
| context | [Definux.Emeraude.Application.Persistence.IEmContext](#T-Definux-Emeraude-Application-Persistence-IEmContext 'Definux.Emeraude.Application.Persistence.IEmContext') |  |

<a name='P-Definux-Emeraude-Identity-Services-UserManager-Options'></a>
### Options `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Identity-Services-UserManager-ChangeUserNameAsync-Definux-Emeraude-Domain-Entities-IUser,System-String-'></a>
### ChangeUserNameAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-Services-UserManager-CheckPasswordAsync-System-String,System-String-'></a>
### CheckPasswordAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-Services-UserManager-CreateUserObject-System-String,System-String,System-Boolean-'></a>
### CreateUserObject() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-Services-UserManager-GetTwoFactorAuthenticationUserAsync'></a>
### GetTwoFactorAuthenticationUserAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-Services-UserManager-IsEmailConfirmedAsync-System-String-'></a>
### IsEmailConfirmedAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-Services-UserManager-IsLockedOutAsync-System-String-'></a>
### IsLockedOutAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Identity-Entities-UserRole'></a>
## UserRole `type`

##### Namespace

Definux.Emeraude.Identity.Entities

##### Summary

User role entity used from the application that implements ASP.NET Core [IdentityUserRole\`1](#T-Microsoft-AspNetCore-Identity-IdentityUserRole`1 'Microsoft.AspNetCore.Identity.IdentityUserRole`1').

<a name='T-Definux-Emeraude-Identity-Entities-UserToken'></a>
## UserToken `type`

##### Namespace

Definux.Emeraude.Identity.Entities

##### Summary

User token entity used from the application that implements ASP.NET Core [IdentityUserToken\`1](#T-Microsoft-AspNetCore-Identity-IdentityUserToken`1 'Microsoft.AspNetCore.Identity.IdentityUserToken`1').

<a name='T-Definux-Emeraude-Identity-Services-UserTokensService'></a>
## UserTokensService `type`

##### Namespace

Definux.Emeraude.Identity.Services

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Identity-Services-UserTokensService-#ctor-Microsoft-AspNetCore-Identity-UserManager{Definux-Emeraude-Identity-Entities-User},Definux-Emeraude-Application-Persistence-IEmContext,Definux-Emeraude-Application-Identity-IUserClaimsService,Microsoft-Extensions-Options-IOptions{Definux-Utilities-Options-JsonWebTokenOptions},Definux-Emeraude-Application-Logger-IEmLogger-'></a>
### #ctor(userManager,context,userClaimsService,jsonWebTokenOptions,logger) `constructor`

##### Summary

Initializes a new instance of the [UserTokensService](#T-Definux-Emeraude-Identity-Services-UserTokensService 'Definux.Emeraude.Identity.Services.UserTokensService') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userManager | [Microsoft.AspNetCore.Identity.UserManager{Definux.Emeraude.Identity.Entities.User}](#T-Microsoft-AspNetCore-Identity-UserManager{Definux-Emeraude-Identity-Entities-User} 'Microsoft.AspNetCore.Identity.UserManager{Definux.Emeraude.Identity.Entities.User}') |  |
| context | [Definux.Emeraude.Application.Persistence.IEmContext](#T-Definux-Emeraude-Application-Persistence-IEmContext 'Definux.Emeraude.Application.Persistence.IEmContext') |  |
| userClaimsService | [Definux.Emeraude.Application.Identity.IUserClaimsService](#T-Definux-Emeraude-Application-Identity-IUserClaimsService 'Definux.Emeraude.Application.Identity.IUserClaimsService') |  |
| jsonWebTokenOptions | [Microsoft.Extensions.Options.IOptions{Definux.Utilities.Options.JsonWebTokenOptions}](#T-Microsoft-Extensions-Options-IOptions{Definux-Utilities-Options-JsonWebTokenOptions} 'Microsoft.Extensions.Options.IOptions{Definux.Utilities.Options.JsonWebTokenOptions}') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |

<a name='M-Definux-Emeraude-Identity-Services-UserTokensService-BuildJwtTokenForExternalUserAsync-Definux-Emeraude-Application-Identity-IExternalUser-'></a>
### BuildJwtTokenForExternalUserAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-Services-UserTokensService-BuildJwtTokenForUserAsync-System-Guid-'></a>
### BuildJwtTokenForUserAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-Services-UserTokensService-RefreshJwtTokenAsync-System-Nullable{System-Guid},System-String-'></a>
### RefreshJwtTokenAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Identity-Services-UserTokensService-ResetRefreshTokenAsync-System-Guid-'></a>
### ResetRefreshTokenAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.
