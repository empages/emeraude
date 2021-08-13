<a name='assembly'></a>
# Definux.Emeraude.Client

## Contents

- [ApplicationPartManagerExtensions](#T-Definux-Emeraude-Client-Extensions-ApplicationPartManagerExtensions 'Definux.Emeraude.Client.Extensions.ApplicationPartManagerExtensions')
  - [AddClientUIApplicationParts(applicationPartManager)](#M-Definux-Emeraude-Client-Extensions-ApplicationPartManagerExtensions-AddClientUIApplicationParts-Microsoft-AspNetCore-Mvc-ApplicationParts-ApplicationPartManager- 'Definux.Emeraude.Client.Extensions.ApplicationPartManagerExtensions.AddClientUIApplicationParts(Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager)')
- [ClientAssemblyMappingProfile](#T-Definux-Emeraude-Client-Mapping-ClientAssemblyMappingProfile 'Definux.Emeraude.Client.Mapping.ClientAssemblyMappingProfile')
  - [#ctor()](#M-Definux-Emeraude-Client-Mapping-ClientAssemblyMappingProfile-#ctor 'Definux.Emeraude.Client.Mapping.ClientAssemblyMappingProfile.#ctor')
- [ClientAuthenticationApiController](#T-Definux-Emeraude-Client-Controllers-Api-ClientAuthenticationApiController 'Definux.Emeraude.Client.Controllers.Api.ClientAuthenticationApiController')
  - [#ctor(userClaimsService,userTokensService,externalProviderAuthenticatorFactory)](#M-Definux-Emeraude-Client-Controllers-Api-ClientAuthenticationApiController-#ctor-Definux-Emeraude-Application-Identity-IUserClaimsService,Definux-Emeraude-Application-Identity-IUserTokensService,Definux-Emeraude-Application-Identity-IExternalProviderAuthenticatorFactory- 'Definux.Emeraude.Client.Controllers.Api.ClientAuthenticationApiController.#ctor(Definux.Emeraude.Application.Identity.IUserClaimsService,Definux.Emeraude.Application.Identity.IUserTokensService,Definux.Emeraude.Application.Identity.IExternalProviderAuthenticatorFactory)')
  - [ExternalAuthentication(authData)](#M-Definux-Emeraude-Client-Controllers-Api-ClientAuthenticationApiController-ExternalAuthentication-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationData- 'Definux.Emeraude.Client.Controllers.Api.ClientAuthenticationApiController.ExternalAuthentication(Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationData)')
  - [ForgotPassword(request)](#M-Definux-Emeraude-Client-Controllers-Api-ClientAuthenticationApiController-ForgotPassword-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommand- 'Definux.Emeraude.Client.Controllers.Api.ClientAuthenticationApiController.ForgotPassword(Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword.ForgotPasswordCommand)')
  - [Login(request)](#M-Definux-Emeraude-Client-Controllers-Api-ClientAuthenticationApiController-Login-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommand- 'Definux.Emeraude.Client.Controllers.Api.ClientAuthenticationApiController.Login(Definux.Emeraude.Application.Requests.Identity.Commands.Login.LoginCommand)')
  - [OnActionExecutionAsync()](#M-Definux-Emeraude-Client-Controllers-Api-ClientAuthenticationApiController-OnActionExecutionAsync-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext,Microsoft-AspNetCore-Mvc-Filters-ActionExecutionDelegate- 'Definux.Emeraude.Client.Controllers.Api.ClientAuthenticationApiController.OnActionExecutionAsync(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext,Microsoft.AspNetCore.Mvc.Filters.ActionExecutionDelegate)')
  - [RefreshAccessToken(request)](#M-Definux-Emeraude-Client-Controllers-Api-ClientAuthenticationApiController-RefreshAccessToken-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommand- 'Definux.Emeraude.Client.Controllers.Api.ClientAuthenticationApiController.RefreshAccessToken(Definux.Emeraude.Application.Requests.Identity.Commands.RefreshAccessToken.RefreshAccessTokenCommand)')
  - [Register(request)](#M-Definux-Emeraude-Client-Controllers-Api-ClientAuthenticationApiController-Register-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand- 'Definux.Emeraude.Client.Controllers.Api.ClientAuthenticationApiController.Register(Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterCommand)')
- [ClientAuthenticationController](#T-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController 'Definux.Emeraude.Client.Controllers.Mvc.ClientAuthenticationController')
  - [#ctor(userClaimsService,urlEncoder,signInManager,externalProviderAuthenticatorFactory)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-#ctor-Definux-Emeraude-Application-Identity-IUserClaimsService,System-Text-Encodings-Web-UrlEncoder,Microsoft-AspNetCore-Identity-SignInManager{Definux-Emeraude-Identity-Entities-User},Definux-Emeraude-Application-Identity-IExternalProviderAuthenticatorFactory- 'Definux.Emeraude.Client.Controllers.Mvc.ClientAuthenticationController.#ctor(Definux.Emeraude.Application.Identity.IUserClaimsService,System.Text.Encodings.Web.UrlEncoder,Microsoft.AspNetCore.Identity.SignInManager{Definux.Emeraude.Identity.Entities.User},Definux.Emeraude.Application.Identity.IExternalProviderAuthenticatorFactory)')
  - [ConfirmEmail(email,token)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-ConfirmEmail-System-String,System-String- 'Definux.Emeraude.Client.Controllers.Mvc.ClientAuthenticationController.ConfirmEmail(System.String,System.String)')
  - [ExternalLogin(externalProvider,returnUrl)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-ExternalLogin-System-String,System-String- 'Definux.Emeraude.Client.Controllers.Mvc.ClientAuthenticationController.ExternalLogin(System.String,System.String)')
  - [ExternalLoginCallback(returnUrl)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-ExternalLoginCallback-System-String- 'Definux.Emeraude.Client.Controllers.Mvc.ClientAuthenticationController.ExternalLoginCallback(System.String)')
  - [ForgotPassword()](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-ForgotPassword 'Definux.Emeraude.Client.Controllers.Mvc.ClientAuthenticationController.ForgotPassword')
  - [ForgotPassword(request)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-ForgotPassword-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommand- 'Definux.Emeraude.Client.Controllers.Mvc.ClientAuthenticationController.ForgotPassword(Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword.ForgotPasswordCommand)')
  - [Login(returnUrl)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-Login-System-String- 'Definux.Emeraude.Client.Controllers.Mvc.ClientAuthenticationController.Login(System.String)')
  - [Login(request,returnUrl)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-Login-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommand,System-String- 'Definux.Emeraude.Client.Controllers.Mvc.ClientAuthenticationController.Login(Definux.Emeraude.Application.Requests.Identity.Commands.Login.LoginCommand,System.String)')
  - [Logout()](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-Logout 'Definux.Emeraude.Client.Controllers.Mvc.ClientAuthenticationController.Logout')
  - [OnActionExecutionAsync()](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-OnActionExecutionAsync-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext,Microsoft-AspNetCore-Mvc-Filters-ActionExecutionDelegate- 'Definux.Emeraude.Client.Controllers.Mvc.ClientAuthenticationController.OnActionExecutionAsync(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext,Microsoft.AspNetCore.Mvc.Filters.ActionExecutionDelegate)')
  - [Register()](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-Register 'Definux.Emeraude.Client.Controllers.Mvc.ClientAuthenticationController.Register')
  - [Register(request)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-Register-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand- 'Definux.Emeraude.Client.Controllers.Mvc.ClientAuthenticationController.Register(Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterCommand)')
  - [ResetPassword(token,email)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-ResetPassword-System-String,System-String- 'Definux.Emeraude.Client.Controllers.Mvc.ClientAuthenticationController.ResetPassword(System.String,System.String)')
  - [ResetPassword(request)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-ResetPassword-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommand- 'Definux.Emeraude.Client.Controllers.Mvc.ClientAuthenticationController.ResetPassword(Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword.ResetPasswordCommand)')
  - [View()](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-View-System-String,System-Object- 'Definux.Emeraude.Client.Controllers.Mvc.ClientAuthenticationController.View(System.String,System.Object)')
- [ClientController](#T-Definux-Emeraude-Client-Controllers-Mvc-ClientController 'Definux.Emeraude.Client.Controllers.Mvc.ClientController')
  - [RedirectToExecutionResultAsync(succeeded,successTitle,failedTitle,successMessage,failedMessage,reference)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientController-RedirectToExecutionResultAsync-System-Boolean,System-String,System-String,System-String,System-String,System-String- 'Definux.Emeraude.Client.Controllers.Mvc.ClientController.RedirectToExecutionResultAsync(System.Boolean,System.String,System.String,System.String,System.String,System.String)')
  - [RedirectToSucceededExecutionResultAsync(title,message,reference)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientController-RedirectToSucceededExecutionResultAsync-System-String,System-String,System-String- 'Definux.Emeraude.Client.Controllers.Mvc.ClientController.RedirectToSucceededExecutionResultAsync(System.String,System.String,System.String)')
- [ClientEnumsApiController](#T-Definux-Emeraude-Client-Controllers-Api-ClientEnumsApiController 'Definux.Emeraude.Client.Controllers.Api.ClientEnumsApiController')
  - [GetEnumValue(enumTypeName,value)](#M-Definux-Emeraude-Client-Controllers-Api-ClientEnumsApiController-GetEnumValue-System-String,System-Int32- 'Definux.Emeraude.Client.Controllers.Api.ClientEnumsApiController.GetEnumValue(System.String,System.Int32)')
  - [GetEnumValueList(enumTypeName)](#M-Definux-Emeraude-Client-Controllers-Api-ClientEnumsApiController-GetEnumValueList-System-String- 'Definux.Emeraude.Client.Controllers.Api.ClientEnumsApiController.GetEnumValueList(System.String)')
- [ClientExecutionResultController](#T-Definux-Emeraude-Client-Controllers-Mvc-ClientExecutionResultController 'Definux.Emeraude.Client.Controllers.Mvc.ClientExecutionResultController')
  - [Handle(title,message,succeeded,reference)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientExecutionResultController-Handle-System-String,System-String,System-Boolean,System-String- 'Definux.Emeraude.Client.Controllers.Mvc.ClientExecutionResultController.Handle(System.String,System.String,System.Boolean,System.String)')
  - [Index(reference)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientExecutionResultController-Index-System-String- 'Definux.Emeraude.Client.Controllers.Mvc.ClientExecutionResultController.Index(System.String)')
- [ClientLoggerApiController](#T-Definux-Emeraude-Client-Controllers-Api-ClientLoggerApiController 'Definux.Emeraude.Client.Controllers.Api.ClientLoggerApiController')
  - [#ctor(logger)](#M-Definux-Emeraude-Client-Controllers-Api-ClientLoggerApiController-#ctor-Definux-Emeraude-Application-Logger-IEmLogger- 'Definux.Emeraude.Client.Controllers.Api.ClientLoggerApiController.#ctor(Definux.Emeraude.Application.Logger.IEmLogger)')
  - [LogClientError(request)](#M-Definux-Emeraude-Client-Controllers-Api-ClientLoggerApiController-LogClientError-Definux-Emeraude-Client-Requests-Logging-Commands-LogFrontEndError-LogFrontEndErrorCommand- 'Definux.Emeraude.Client.Controllers.Api.ClientLoggerApiController.LogClientError(Definux.Emeraude.Client.Requests.Logging.Commands.LogFrontEndError.LogFrontEndErrorCommand)')
- [ClientMaintenanceController](#T-Definux-Emeraude-Client-Controllers-Mvc-ClientMaintenanceController 'Definux.Emeraude.Client.Controllers.Mvc.ClientMaintenanceController')
  - [#ctor()](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientMaintenanceController-#ctor 'Definux.Emeraude.Client.Controllers.Mvc.ClientMaintenanceController.#ctor')
  - [Index()](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientMaintenanceController-Index 'Definux.Emeraude.Client.Controllers.Mvc.ClientMaintenanceController.Index')
- [ClientManagementController](#T-Definux-Emeraude-Client-Controllers-Mvc-ClientManagementController 'Definux.Emeraude.Client.Controllers.Mvc.ClientManagementController')
  - [ConfirmChangeEmail(email,token)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientManagementController-ConfirmChangeEmail-System-String,System-String- 'Definux.Emeraude.Client.Controllers.Mvc.ClientManagementController.ConfirmChangeEmail(System.String,System.String)')
- [ClientUploadApiController](#T-Definux-Emeraude-Client-Controllers-Api-ClientUploadApiController 'Definux.Emeraude.Client.Controllers.Api.ClientUploadApiController')
  - [#ctor(emeraudeOptionsAccessor)](#M-Definux-Emeraude-Client-Controllers-Api-ClientUploadApiController-#ctor-Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions}- 'Definux.Emeraude.Client.Controllers.Api.ClientUploadApiController.#ctor(Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions})')
  - [Image(formFile)](#M-Definux-Emeraude-Client-Controllers-Api-ClientUploadApiController-Image-Microsoft-AspNetCore-Http-IFormFile- 'Definux.Emeraude.Client.Controllers.Api.ClientUploadApiController.Image(Microsoft.AspNetCore.Http.IFormFile)')
  - [Video(formFile)](#M-Definux-Emeraude-Client-Controllers-Api-ClientUploadApiController-Video-Microsoft-AspNetCore-Http-IFormFile- 'Definux.Emeraude.Client.Controllers.Api.ClientUploadApiController.Video(Microsoft.AspNetCore.Http.IFormFile)')
- [ClientUsersApiController](#T-Definux-Emeraude-Client-Controllers-Api-ClientUsersApiController 'Definux.Emeraude.Client.Controllers.Api.ClientUsersApiController')
  - [#ctor(currentUserProvider)](#M-Definux-Emeraude-Client-Controllers-Api-ClientUsersApiController-#ctor-Definux-Emeraude-Application-Identity-ICurrentUserProvider- 'Definux.Emeraude.Client.Controllers.Api.ClientUsersApiController.#ctor(Definux.Emeraude.Application.Identity.ICurrentUserProvider)')
  - [ChangeUserAvatar(request)](#M-Definux-Emeraude-Client-Controllers-Api-ClientUsersApiController-ChangeUserAvatar-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserAvatar-ChangeUserAvatarCommand- 'Definux.Emeraude.Client.Controllers.Api.ClientUsersApiController.ChangeUserAvatar(Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserAvatar.ChangeUserAvatarCommand)')
  - [ChangeUserName(request)](#M-Definux-Emeraude-Client-Controllers-Api-ClientUsersApiController-ChangeUserName-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserName-ChangeUserNameCommand- 'Definux.Emeraude.Client.Controllers.Api.ClientUsersApiController.ChangeUserName(Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserName.ChangeUserNameCommand)')
  - [ChangeUserPassword(request)](#M-Definux-Emeraude-Client-Controllers-Api-ClientUsersApiController-ChangeUserPassword-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommand- 'Definux.Emeraude.Client.Controllers.Api.ClientUsersApiController.ChangeUserPassword(Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword.ChangePasswordCommand)')
  - [GetCurrentUserAvatar()](#M-Definux-Emeraude-Client-Controllers-Api-ClientUsersApiController-GetCurrentUserAvatar 'Definux.Emeraude.Client.Controllers.Api.ClientUsersApiController.GetCurrentUserAvatar')
  - [GetCurrentUserExternalLoginProviders()](#M-Definux-Emeraude-Client-Controllers-Api-ClientUsersApiController-GetCurrentUserExternalLoginProviders 'Definux.Emeraude.Client.Controllers.Api.ClientUsersApiController.GetCurrentUserExternalLoginProviders')
  - [GetUserAvatarType()](#M-Definux-Emeraude-Client-Controllers-Api-ClientUsersApiController-GetUserAvatarType 'Definux.Emeraude.Client.Controllers.Api.ClientUsersApiController.GetUserAvatarType')
  - [RemoveCurrentUserExternalLoginProvider(request)](#M-Definux-Emeraude-Client-Controllers-Api-ClientUsersApiController-RemoveCurrentUserExternalLoginProvider-Definux-Emeraude-Application-Requests-Identity-Commands-RemoveExternalLoginProvider-RemoveExternalLoginProviderCommand- 'Definux.Emeraude.Client.Controllers.Api.ClientUsersApiController.RemoveCurrentUserExternalLoginProvider(Definux.Emeraude.Application.Requests.Identity.Commands.RemoveExternalLoginProvider.RemoveExternalLoginProviderCommand)')
  - [RequestChangeEmailForTheCurrentUser(request)](#M-Definux-Emeraude-Client-Controllers-Api-ClientUsersApiController-RequestChangeEmailForTheCurrentUser-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommand- 'Definux.Emeraude.Client.Controllers.Api.ClientUsersApiController.RequestChangeEmailForTheCurrentUser(Definux.Emeraude.Application.Requests.Identity.Commands.RequestChangeEmail.RequestChangeEmailCommand)')
  - [RequestResetPasswordForTheCurrentUser()](#M-Definux-Emeraude-Client-Controllers-Api-ClientUsersApiController-RequestResetPasswordForTheCurrentUser 'Definux.Emeraude.Client.Controllers.Api.ClientUsersApiController.RequestResetPasswordForTheCurrentUser')
- [ExternalAuthenticationProvidersCollection](#T-Definux-Emeraude-Client-Adapters-ExternalAuthenticationProvidersCollection 'Definux.Emeraude.Client.Adapters.ExternalAuthenticationProvidersCollection')
  - [#ctor(externalProviderAuthenticatorFactory)](#M-Definux-Emeraude-Client-Adapters-ExternalAuthenticationProvidersCollection-#ctor-Definux-Emeraude-Application-Identity-IExternalProviderAuthenticatorFactory- 'Definux.Emeraude.Client.Adapters.ExternalAuthenticationProvidersCollection.#ctor(Definux.Emeraude.Application.Identity.IExternalProviderAuthenticatorFactory)')
  - [ExternalProviders](#P-Definux-Emeraude-Client-Adapters-ExternalAuthenticationProvidersCollection-ExternalProviders 'Definux.Emeraude.Client.Adapters.ExternalAuthenticationProvidersCollection.ExternalProviders')
- [LogFrontEndErrorCommand](#T-Definux-Emeraude-Client-Requests-Logging-Commands-LogFrontEndError-LogFrontEndErrorCommand 'Definux.Emeraude.Client.Requests.Logging.Commands.LogFrontEndError.LogFrontEndErrorCommand')
  - [Message](#P-Definux-Emeraude-Client-Requests-Logging-Commands-LogFrontEndError-LogFrontEndErrorCommand-Message 'Definux.Emeraude.Client.Requests.Logging.Commands.LogFrontEndError.LogFrontEndErrorCommand.Message')
  - [Method](#P-Definux-Emeraude-Client-Requests-Logging-Commands-LogFrontEndError-LogFrontEndErrorCommand-Method 'Definux.Emeraude.Client.Requests.Logging.Commands.LogFrontEndError.LogFrontEndErrorCommand.Method')
  - [Source](#P-Definux-Emeraude-Client-Requests-Logging-Commands-LogFrontEndError-LogFrontEndErrorCommand-Source 'Definux.Emeraude.Client.Requests.Logging.Commands.LogFrontEndError.LogFrontEndErrorCommand.Source')
  - [StackTrace](#P-Definux-Emeraude-Client-Requests-Logging-Commands-LogFrontEndError-LogFrontEndErrorCommand-StackTrace 'Definux.Emeraude.Client.Requests.Logging.Commands.LogFrontEndError.LogFrontEndErrorCommand.StackTrace')
- [LogFrontEndErrorCommandHandler](#T-Definux-Emeraude-Client-Requests-Logging-Commands-LogFrontEndError-LogFrontEndErrorCommand-LogFrontEndErrorCommandHandler 'Definux.Emeraude.Client.Requests.Logging.Commands.LogFrontEndError.LogFrontEndErrorCommand.LogFrontEndErrorCommandHandler')
  - [#ctor(logger,loggerContext,mapper)](#M-Definux-Emeraude-Client-Requests-Logging-Commands-LogFrontEndError-LogFrontEndErrorCommand-LogFrontEndErrorCommandHandler-#ctor-Definux-Emeraude-Application-Logger-IEmLogger,Definux-Emeraude-Application-Logger-ILoggerContext,AutoMapper-IMapper- 'Definux.Emeraude.Client.Requests.Logging.Commands.LogFrontEndError.LogFrontEndErrorCommand.LogFrontEndErrorCommandHandler.#ctor(Definux.Emeraude.Application.Logger.IEmLogger,Definux.Emeraude.Application.Logger.ILoggerContext,AutoMapper.IMapper)')
  - [Handle()](#M-Definux-Emeraude-Client-Requests-Logging-Commands-LogFrontEndError-LogFrontEndErrorCommand-LogFrontEndErrorCommandHandler-Handle-Definux-Emeraude-Client-Requests-Logging-Commands-LogFrontEndError-LogFrontEndErrorCommand,System-Threading-CancellationToken- 'Definux.Emeraude.Client.Requests.Logging.Commands.LogFrontEndError.LogFrontEndErrorCommand.LogFrontEndErrorCommandHandler.Handle(Definux.Emeraude.Client.Requests.Logging.Commands.LogFrontEndError.LogFrontEndErrorCommand,System.Threading.CancellationToken)')
- [ServiceCollectionExtensions](#T-Definux-Emeraude-Client-Extensions-ServiceCollectionExtensions 'Definux.Emeraude.Client.Extensions.ServiceCollectionExtensions')
  - [AddClientCookie(builder)](#M-Definux-Emeraude-Client-Extensions-ServiceCollectionExtensions-AddClientCookie-Microsoft-AspNetCore-Authentication-AuthenticationBuilder- 'Definux.Emeraude.Client.Extensions.ServiceCollectionExtensions.AddClientCookie(Microsoft.AspNetCore.Authentication.AuthenticationBuilder)')
  - [AddClientMapperConfiguration(configuration)](#M-Definux-Emeraude-Client-Extensions-ServiceCollectionExtensions-AddClientMapperConfiguration-AutoMapper-IMapperConfigurationExpression- 'Definux.Emeraude.Client.Extensions.ServiceCollectionExtensions.AddClientMapperConfiguration(AutoMapper.IMapperConfigurationExpression)')
  - [AddEmeraudeClient(services)](#M-Definux-Emeraude-Client-Extensions-ServiceCollectionExtensions-AddEmeraudeClient-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Definux.Emeraude.Client.Extensions.ServiceCollectionExtensions.AddEmeraudeClient(Microsoft.Extensions.DependencyInjection.IServiceCollection)')

<a name='T-Definux-Emeraude-Client-Extensions-ApplicationPartManagerExtensions'></a>
## ApplicationPartManagerExtensions `type`

##### Namespace

Definux.Emeraude.Client.Extensions

##### Summary

Extensions for [ApplicationPartManager](#T-Microsoft-AspNetCore-Mvc-ApplicationParts-ApplicationPartManager 'Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager').

<a name='M-Definux-Emeraude-Client-Extensions-ApplicationPartManagerExtensions-AddClientUIApplicationParts-Microsoft-AspNetCore-Mvc-ApplicationParts-ApplicationPartManager-'></a>
### AddClientUIApplicationParts(applicationPartManager) `method`

##### Summary

Add Client UI application parts.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| applicationPartManager | [Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager](#T-Microsoft-AspNetCore-Mvc-ApplicationParts-ApplicationPartManager 'Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager') |  |

<a name='T-Definux-Emeraude-Client-Mapping-ClientAssemblyMappingProfile'></a>
## ClientAssemblyMappingProfile `type`

##### Namespace

Definux.Emeraude.Client.Mapping

##### Summary

Assembly mapping profile for registration of all mappings configurations for administration.

<a name='M-Definux-Emeraude-Client-Mapping-ClientAssemblyMappingProfile-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [ClientAssemblyMappingProfile](#T-Definux-Emeraude-Client-Mapping-ClientAssemblyMappingProfile 'Definux.Emeraude.Client.Mapping.ClientAssemblyMappingProfile') class.

##### Parameters

This constructor has no parameters.

<a name='T-Definux-Emeraude-Client-Controllers-Api-ClientAuthenticationApiController'></a>
## ClientAuthenticationApiController `type`

##### Namespace

Definux.Emeraude.Client.Controllers.Api

##### Summary

*Inherit from parent.*

##### Summary

Client API controller for authentication.

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientAuthenticationApiController-#ctor-Definux-Emeraude-Application-Identity-IUserClaimsService,Definux-Emeraude-Application-Identity-IUserTokensService,Definux-Emeraude-Application-Identity-IExternalProviderAuthenticatorFactory-'></a>
### #ctor(userClaimsService,userTokensService,externalProviderAuthenticatorFactory) `constructor`

##### Summary

Initializes a new instance of the [ClientAuthenticationApiController](#T-Definux-Emeraude-Client-Controllers-Api-ClientAuthenticationApiController 'Definux.Emeraude.Client.Controllers.Api.ClientAuthenticationApiController') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userClaimsService | [Definux.Emeraude.Application.Identity.IUserClaimsService](#T-Definux-Emeraude-Application-Identity-IUserClaimsService 'Definux.Emeraude.Application.Identity.IUserClaimsService') |  |
| userTokensService | [Definux.Emeraude.Application.Identity.IUserTokensService](#T-Definux-Emeraude-Application-Identity-IUserTokensService 'Definux.Emeraude.Application.Identity.IUserTokensService') |  |
| externalProviderAuthenticatorFactory | [Definux.Emeraude.Application.Identity.IExternalProviderAuthenticatorFactory](#T-Definux-Emeraude-Application-Identity-IExternalProviderAuthenticatorFactory 'Definux.Emeraude.Application.Identity.IExternalProviderAuthenticatorFactory') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientAuthenticationApiController-ExternalAuthentication-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationData-'></a>
### ExternalAuthentication(authData) `method`

##### Summary

External login provider authentication action.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| authData | [Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationData](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationData 'Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationData') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientAuthenticationApiController-ForgotPassword-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommand-'></a>
### ForgotPassword(request) `method`

##### Summary

Forgot password action.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword.ForgotPasswordCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword.ForgotPasswordCommand') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientAuthenticationApiController-Login-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommand-'></a>
### Login(request) `method`

##### Summary

Login action.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Definux.Emeraude.Application.Requests.Identity.Commands.Login.LoginCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.Login.LoginCommand') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientAuthenticationApiController-OnActionExecutionAsync-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext,Microsoft-AspNetCore-Mvc-Filters-ActionExecutionDelegate-'></a>
### OnActionExecutionAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientAuthenticationApiController-RefreshAccessToken-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommand-'></a>
### RefreshAccessToken(request) `method`

##### Summary

Refresh JWT token action.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Definux.Emeraude.Application.Requests.Identity.Commands.RefreshAccessToken.RefreshAccessTokenCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.RefreshAccessToken.RefreshAccessTokenCommand') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientAuthenticationApiController-Register-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand-'></a>
### Register(request) `method`

##### Summary

Register action.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterCommand') |  |

<a name='T-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController'></a>
## ClientAuthenticationController `type`

##### Namespace

Definux.Emeraude.Client.Controllers.Mvc

##### Summary

*Inherit from parent.*

##### Summary

Client controller for MVC authentication.

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-#ctor-Definux-Emeraude-Application-Identity-IUserClaimsService,System-Text-Encodings-Web-UrlEncoder,Microsoft-AspNetCore-Identity-SignInManager{Definux-Emeraude-Identity-Entities-User},Definux-Emeraude-Application-Identity-IExternalProviderAuthenticatorFactory-'></a>
### #ctor(userClaimsService,urlEncoder,signInManager,externalProviderAuthenticatorFactory) `constructor`

##### Summary

Initializes a new instance of the [ClientAuthenticationController](#T-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController 'Definux.Emeraude.Client.Controllers.Mvc.ClientAuthenticationController') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userClaimsService | [Definux.Emeraude.Application.Identity.IUserClaimsService](#T-Definux-Emeraude-Application-Identity-IUserClaimsService 'Definux.Emeraude.Application.Identity.IUserClaimsService') |  |
| urlEncoder | [System.Text.Encodings.Web.UrlEncoder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encodings.Web.UrlEncoder 'System.Text.Encodings.Web.UrlEncoder') |  |
| signInManager | [Microsoft.AspNetCore.Identity.SignInManager{Definux.Emeraude.Identity.Entities.User}](#T-Microsoft-AspNetCore-Identity-SignInManager{Definux-Emeraude-Identity-Entities-User} 'Microsoft.AspNetCore.Identity.SignInManager{Definux.Emeraude.Identity.Entities.User}') |  |
| externalProviderAuthenticatorFactory | [Definux.Emeraude.Application.Identity.IExternalProviderAuthenticatorFactory](#T-Definux-Emeraude-Application-Identity-IExternalProviderAuthenticatorFactory 'Definux.Emeraude.Application.Identity.IExternalProviderAuthenticatorFactory') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-ConfirmEmail-System-String,System-String-'></a>
### ConfirmEmail(email,token) `method`

##### Summary

Confirm email action.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| email | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| token | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-ExternalLogin-System-String,System-String-'></a>
### ExternalLogin(externalProvider,returnUrl) `method`

##### Summary

External login action.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| externalProvider | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| returnUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-ExternalLoginCallback-System-String-'></a>
### ExternalLoginCallback(returnUrl) `method`

##### Summary

External login callback action.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| returnUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-ForgotPassword'></a>
### ForgotPassword() `method`

##### Summary

Forgot password action for GET request.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-ForgotPassword-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommand-'></a>
### ForgotPassword(request) `method`

##### Summary

Forgot password action for POST request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword.ForgotPasswordCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword.ForgotPasswordCommand') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-Login-System-String-'></a>
### Login(returnUrl) `method`

##### Summary

Login action for GET request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| returnUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-Login-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommand,System-String-'></a>
### Login(request,returnUrl) `method`

##### Summary

Login action for GET request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Definux.Emeraude.Application.Requests.Identity.Commands.Login.LoginCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.Login.LoginCommand') |  |
| returnUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-Logout'></a>
### Logout() `method`

##### Summary

Logout action for GET and POST requests.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-OnActionExecutionAsync-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext,Microsoft-AspNetCore-Mvc-Filters-ActionExecutionDelegate-'></a>
### OnActionExecutionAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-Register'></a>
### Register() `method`

##### Summary

Register action for GET request.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-Register-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand-'></a>
### Register(request) `method`

##### Summary

Register action for POST request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterCommand') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-ResetPassword-System-String,System-String-'></a>
### ResetPassword(token,email) `method`

##### Summary

Reset password action for GET request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| token | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| email | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-ResetPassword-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommand-'></a>
### ResetPassword(request) `method`

##### Summary

Reset password action for POST request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword.ResetPasswordCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword.ResetPasswordCommand') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientAuthenticationController-View-System-String,System-Object-'></a>
### View() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Client-Controllers-Mvc-ClientController'></a>
## ClientController `type`

##### Namespace

Definux.Emeraude.Client.Controllers.Mvc

##### Summary

Simple extended controller of [PublicController](#T-Definux-Emeraude-Presentation-Controllers-PublicController 'Definux.Emeraude.Presentation.Controllers.PublicController').

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientController-RedirectToExecutionResultAsync-System-Boolean,System-String,System-String,System-String,System-String,System-String-'></a>
### RedirectToExecutionResultAsync(succeeded,successTitle,failedTitle,successMessage,failedMessage,reference) `method`

##### Summary

Redirects to execution result page.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| succeeded | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
| successTitle | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| failedTitle | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| successMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| failedMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| reference | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientController-RedirectToSucceededExecutionResultAsync-System-String,System-String,System-String-'></a>
### RedirectToSucceededExecutionResultAsync(title,message,reference) `method`

##### Summary

Redirects to succeeded execution result page.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| title | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| reference | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Client-Controllers-Api-ClientEnumsApiController'></a>
## ClientEnumsApiController `type`

##### Namespace

Definux.Emeraude.Client.Controllers.Api

##### Summary

Enumeration API controller that provide access to enumeration types and their values.

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientEnumsApiController-GetEnumValue-System-String,System-Int32-'></a>
### GetEnumValue(enumTypeName,value) `method`

##### Summary

Get a specified enumeration by the enumeration type and value.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumTypeName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientEnumsApiController-GetEnumValueList-System-String-'></a>
### GetEnumValueList(enumTypeName) `method`

##### Summary

Get all enumerations with their values.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumTypeName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Client-Controllers-Mvc-ClientExecutionResultController'></a>
## ClientExecutionResultController `type`

##### Namespace

Definux.Emeraude.Client.Controllers.Mvc

##### Summary

Client controller for MVC execution results.

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientExecutionResultController-Handle-System-String,System-String,System-Boolean,System-String-'></a>
### Handle(title,message,succeeded,reference) `method`

##### Summary

Handle the invocation for execution result page then redirect to page.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| title | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| succeeded | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
| reference | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientExecutionResultController-Index-System-String-'></a>
### Index(reference) `method`

##### Summary

Main action for the execution result page.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reference | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Client-Controllers-Api-ClientLoggerApiController'></a>
## ClientLoggerApiController `type`

##### Namespace

Definux.Emeraude.Client.Controllers.Api

##### Summary

Client API logger controller.

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientLoggerApiController-#ctor-Definux-Emeraude-Application-Logger-IEmLogger-'></a>
### #ctor(logger) `constructor`

##### Summary

Initializes a new instance of the [ClientLoggerApiController](#T-Definux-Emeraude-Client-Controllers-Api-ClientLoggerApiController 'Definux.Emeraude.Client.Controllers.Api.ClientLoggerApiController') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientLoggerApiController-LogClientError-Definux-Emeraude-Client-Requests-Logging-Commands-LogFrontEndError-LogFrontEndErrorCommand-'></a>
### LogClientError(request) `method`

##### Summary

Log error to server.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Definux.Emeraude.Client.Requests.Logging.Commands.LogFrontEndError.LogFrontEndErrorCommand](#T-Definux-Emeraude-Client-Requests-Logging-Commands-LogFrontEndError-LogFrontEndErrorCommand 'Definux.Emeraude.Client.Requests.Logging.Commands.LogFrontEndError.LogFrontEndErrorCommand') |  |

<a name='T-Definux-Emeraude-Client-Controllers-Mvc-ClientMaintenanceController'></a>
## ClientMaintenanceController `type`

##### Namespace

Definux.Emeraude.Client.Controllers.Mvc

##### Summary

Maintenance controller for the static page of maintenance mode of the application.

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientMaintenanceController-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [ClientMaintenanceController](#T-Definux-Emeraude-Client-Controllers-Mvc-ClientMaintenanceController 'Definux.Emeraude.Client.Controllers.Mvc.ClientMaintenanceController') class.

##### Parameters

This constructor has no parameters.

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientMaintenanceController-Index'></a>
### Index() `method`

##### Summary

Index action of the maintenance controller.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Client-Controllers-Mvc-ClientManagementController'></a>
## ClientManagementController `type`

##### Namespace

Definux.Emeraude.Client.Controllers.Mvc

##### Summary

Client controller for MVC user management.

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientManagementController-ConfirmChangeEmail-System-String,System-String-'></a>
### ConfirmChangeEmail(email,token) `method`

##### Summary

Confirms change email request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| email | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| token | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Client-Controllers-Api-ClientUploadApiController'></a>
## ClientUploadApiController `type`

##### Namespace

Definux.Emeraude.Client.Controllers.Api

##### Summary

Client API upload controller.

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientUploadApiController-#ctor-Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions}-'></a>
### #ctor(emeraudeOptionsAccessor) `constructor`

##### Summary

Initializes a new instance of the [ClientUploadApiController](#T-Definux-Emeraude-Client-Controllers-Api-ClientUploadApiController 'Definux.Emeraude.Client.Controllers.Api.ClientUploadApiController') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| emeraudeOptionsAccessor | [Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions}](#T-Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions} 'Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions}') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientUploadApiController-Image-Microsoft-AspNetCore-Http-IFormFile-'></a>
### Image(formFile) `method`

##### Summary

Upload image action.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| formFile | [Microsoft.AspNetCore.Http.IFormFile](#T-Microsoft-AspNetCore-Http-IFormFile 'Microsoft.AspNetCore.Http.IFormFile') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientUploadApiController-Video-Microsoft-AspNetCore-Http-IFormFile-'></a>
### Video(formFile) `method`

##### Summary

Upload video action.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| formFile | [Microsoft.AspNetCore.Http.IFormFile](#T-Microsoft-AspNetCore-Http-IFormFile 'Microsoft.AspNetCore.Http.IFormFile') |  |

<a name='T-Definux-Emeraude-Client-Controllers-Api-ClientUsersApiController'></a>
## ClientUsersApiController `type`

##### Namespace

Definux.Emeraude.Client.Controllers.Api

##### Summary

Client API user utilities controller.

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientUsersApiController-#ctor-Definux-Emeraude-Application-Identity-ICurrentUserProvider-'></a>
### #ctor(currentUserProvider) `constructor`

##### Summary

Initializes a new instance of the [ClientUsersApiController](#T-Definux-Emeraude-Client-Controllers-Api-ClientUsersApiController 'Definux.Emeraude.Client.Controllers.Api.ClientUsersApiController') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| currentUserProvider | [Definux.Emeraude.Application.Identity.ICurrentUserProvider](#T-Definux-Emeraude-Application-Identity-ICurrentUserProvider 'Definux.Emeraude.Application.Identity.ICurrentUserProvider') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientUsersApiController-ChangeUserAvatar-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserAvatar-ChangeUserAvatarCommand-'></a>
### ChangeUserAvatar(request) `method`

##### Summary

Changes the avatar of current user.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserAvatar.ChangeUserAvatarCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserAvatar-ChangeUserAvatarCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserAvatar.ChangeUserAvatarCommand') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientUsersApiController-ChangeUserName-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserName-ChangeUserNameCommand-'></a>
### ChangeUserName(request) `method`

##### Summary

Changes the name of the current user.

##### Returns

A [Task\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task`1 'System.Threading.Tasks.Task`1') representing the result of the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserName.ChangeUserNameCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserName-ChangeUserNameCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserName.ChangeUserNameCommand') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientUsersApiController-ChangeUserPassword-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommand-'></a>
### ChangeUserPassword(request) `method`

##### Summary

Changes the password of the current user.

##### Returns

A [Task\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task`1 'System.Threading.Tasks.Task`1') representing the result of the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword.ChangePasswordCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword.ChangePasswordCommand') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientUsersApiController-GetCurrentUserAvatar'></a>
### GetCurrentUserAvatar() `method`

##### Summary

Gets the current user avatar file result.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientUsersApiController-GetCurrentUserExternalLoginProviders'></a>
### GetCurrentUserExternalLoginProviders() `method`

##### Summary

Gets collection of external login providers for the current user.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientUsersApiController-GetUserAvatarType'></a>
### GetUserAvatarType() `method`

##### Summary

Gets flag result that indicates whether the avatar is default or not.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientUsersApiController-RemoveCurrentUserExternalLoginProvider-Definux-Emeraude-Application-Requests-Identity-Commands-RemoveExternalLoginProvider-RemoveExternalLoginProviderCommand-'></a>
### RemoveCurrentUserExternalLoginProvider(request) `method`

##### Summary

Remove specified external login provider for the current user.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Definux.Emeraude.Application.Requests.Identity.Commands.RemoveExternalLoginProvider.RemoveExternalLoginProviderCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-RemoveExternalLoginProvider-RemoveExternalLoginProviderCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.RemoveExternalLoginProvider.RemoveExternalLoginProviderCommand') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientUsersApiController-RequestChangeEmailForTheCurrentUser-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommand-'></a>
### RequestChangeEmailForTheCurrentUser(request) `method`

##### Summary

Make a request for change the email for the current user.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Definux.Emeraude.Application.Requests.Identity.Commands.RequestChangeEmail.RequestChangeEmailCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.RequestChangeEmail.RequestChangeEmailCommand') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientUsersApiController-RequestResetPasswordForTheCurrentUser'></a>
### RequestResetPasswordForTheCurrentUser() `method`

##### Summary

Make a request for reset password for the current user.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Client-Adapters-ExternalAuthenticationProvidersCollection'></a>
## ExternalAuthenticationProvidersCollection `type`

##### Namespace

Definux.Emeraude.Client.Adapters

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Client-Adapters-ExternalAuthenticationProvidersCollection-#ctor-Definux-Emeraude-Application-Identity-IExternalProviderAuthenticatorFactory-'></a>
### #ctor(externalProviderAuthenticatorFactory) `constructor`

##### Summary

Initializes a new instance of the [ExternalAuthenticationProvidersCollection](#T-Definux-Emeraude-Client-Adapters-ExternalAuthenticationProvidersCollection 'Definux.Emeraude.Client.Adapters.ExternalAuthenticationProvidersCollection') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| externalProviderAuthenticatorFactory | [Definux.Emeraude.Application.Identity.IExternalProviderAuthenticatorFactory](#T-Definux-Emeraude-Application-Identity-IExternalProviderAuthenticatorFactory 'Definux.Emeraude.Application.Identity.IExternalProviderAuthenticatorFactory') |  |

<a name='P-Definux-Emeraude-Client-Adapters-ExternalAuthenticationProvidersCollection-ExternalProviders'></a>
### ExternalProviders `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Client-Requests-Logging-Commands-LogFrontEndError-LogFrontEndErrorCommand'></a>
## LogFrontEndErrorCommand `type`

##### Namespace

Definux.Emeraude.Client.Requests.Logging.Commands.LogFrontEndError

##### Summary

Command for log front-end error.

<a name='P-Definux-Emeraude-Client-Requests-Logging-Commands-LogFrontEndError-LogFrontEndErrorCommand-Message'></a>
### Message `property`

##### Summary

Message of the error.

<a name='P-Definux-Emeraude-Client-Requests-Logging-Commands-LogFrontEndError-LogFrontEndErrorCommand-Method'></a>
### Method `property`

##### Summary

The method where the error occured.

<a name='P-Definux-Emeraude-Client-Requests-Logging-Commands-LogFrontEndError-LogFrontEndErrorCommand-Source'></a>
### Source `property`

##### Summary

Error source.

<a name='P-Definux-Emeraude-Client-Requests-Logging-Commands-LogFrontEndError-LogFrontEndErrorCommand-StackTrace'></a>
### StackTrace `property`

##### Summary

Stack trace of the error.

<a name='T-Definux-Emeraude-Client-Requests-Logging-Commands-LogFrontEndError-LogFrontEndErrorCommand-LogFrontEndErrorCommandHandler'></a>
## LogFrontEndErrorCommandHandler `type`

##### Namespace

Definux.Emeraude.Client.Requests.Logging.Commands.LogFrontEndError.LogFrontEndErrorCommand

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Client-Requests-Logging-Commands-LogFrontEndError-LogFrontEndErrorCommand-LogFrontEndErrorCommandHandler-#ctor-Definux-Emeraude-Application-Logger-IEmLogger,Definux-Emeraude-Application-Logger-ILoggerContext,AutoMapper-IMapper-'></a>
### #ctor(logger,loggerContext,mapper) `constructor`

##### Summary

Initializes a new instance of the [LogFrontEndErrorCommandHandler](#T-Definux-Emeraude-Client-Requests-Logging-Commands-LogFrontEndError-LogFrontEndErrorCommand-LogFrontEndErrorCommandHandler 'Definux.Emeraude.Client.Requests.Logging.Commands.LogFrontEndError.LogFrontEndErrorCommand.LogFrontEndErrorCommandHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |
| loggerContext | [Definux.Emeraude.Application.Logger.ILoggerContext](#T-Definux-Emeraude-Application-Logger-ILoggerContext 'Definux.Emeraude.Application.Logger.ILoggerContext') |  |
| mapper | [AutoMapper.IMapper](#T-AutoMapper-IMapper 'AutoMapper.IMapper') |  |

<a name='M-Definux-Emeraude-Client-Requests-Logging-Commands-LogFrontEndError-LogFrontEndErrorCommand-LogFrontEndErrorCommandHandler-Handle-Definux-Emeraude-Client-Requests-Logging-Commands-LogFrontEndError-LogFrontEndErrorCommand,System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Client-Extensions-ServiceCollectionExtensions'></a>
## ServiceCollectionExtensions `type`

##### Namespace

Definux.Emeraude.Client.Extensions

##### Summary

Extensions for [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection').

<a name='M-Definux-Emeraude-Client-Extensions-ServiceCollectionExtensions-AddClientCookie-Microsoft-AspNetCore-Authentication-AuthenticationBuilder-'></a>
### AddClientCookie(builder) `method`

##### Summary

Register client authentication scheme.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Authentication.AuthenticationBuilder](#T-Microsoft-AspNetCore-Authentication-AuthenticationBuilder 'Microsoft.AspNetCore.Authentication.AuthenticationBuilder') |  |

<a name='M-Definux-Emeraude-Client-Extensions-ServiceCollectionExtensions-AddClientMapperConfiguration-AutoMapper-IMapperConfigurationExpression-'></a>
### AddClientMapperConfiguration(configuration) `method`

##### Summary

Register client mapper configuration.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [AutoMapper.IMapperConfigurationExpression](#T-AutoMapper-IMapperConfigurationExpression 'AutoMapper.IMapperConfigurationExpression') |  |

<a name='M-Definux-Emeraude-Client-Extensions-ServiceCollectionExtensions-AddEmeraudeClient-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### AddEmeraudeClient(services) `method`

##### Summary

Register client features.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |
