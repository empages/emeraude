<a name='assembly'></a>
# Definux.Emeraude.Client

## Contents

- [ApplicationPartManagerExtensions](#T-Definux-Emeraude-Client-Extensions-ApplicationPartManagerExtensions 'Definux.Emeraude.Client.Extensions.ApplicationPartManagerExtensions')
  - [AddClientUIApplicationParts(applicationPartManager)](#M-Definux-Emeraude-Client-Extensions-ApplicationPartManagerExtensions-AddClientUIApplicationParts-Microsoft-AspNetCore-Mvc-ApplicationParts-ApplicationPartManager- 'Definux.Emeraude.Client.Extensions.ApplicationPartManagerExtensions.AddClientUIApplicationParts(Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager)')
- [ClientApiAuthenticationController](#T-Definux-Emeraude-Client-Controllers-Api-ClientApiAuthenticationController 'Definux.Emeraude.Client.Controllers.Api.ClientApiAuthenticationController')
  - [#ctor(userClaimsService,userTokensService,emeraudeOptionsAccessor)](#M-Definux-Emeraude-Client-Controllers-Api-ClientApiAuthenticationController-#ctor-Definux-Emeraude-Application-Identity-IUserClaimsService,Definux-Emeraude-Application-Identity-IUserTokensService,Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions}- 'Definux.Emeraude.Client.Controllers.Api.ClientApiAuthenticationController.#ctor(Definux.Emeraude.Application.Identity.IUserClaimsService,Definux.Emeraude.Application.Identity.IUserTokensService,Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions})')
  - [ExternalAuthentication(authData)](#M-Definux-Emeraude-Client-Controllers-Api-ClientApiAuthenticationController-ExternalAuthentication-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationData- 'Definux.Emeraude.Client.Controllers.Api.ClientApiAuthenticationController.ExternalAuthentication(Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationData)')
  - [ForgotPassword(request)](#M-Definux-Emeraude-Client-Controllers-Api-ClientApiAuthenticationController-ForgotPassword-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommand- 'Definux.Emeraude.Client.Controllers.Api.ClientApiAuthenticationController.ForgotPassword(Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword.ForgotPasswordCommand)')
  - [Login(request)](#M-Definux-Emeraude-Client-Controllers-Api-ClientApiAuthenticationController-Login-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommand- 'Definux.Emeraude.Client.Controllers.Api.ClientApiAuthenticationController.Login(Definux.Emeraude.Application.Requests.Identity.Commands.Login.LoginCommand)')
  - [OnActionExecutionAsync()](#M-Definux-Emeraude-Client-Controllers-Api-ClientApiAuthenticationController-OnActionExecutionAsync-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext,Microsoft-AspNetCore-Mvc-Filters-ActionExecutionDelegate- 'Definux.Emeraude.Client.Controllers.Api.ClientApiAuthenticationController.OnActionExecutionAsync(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext,Microsoft.AspNetCore.Mvc.Filters.ActionExecutionDelegate)')
  - [RefreshAccessToken(request)](#M-Definux-Emeraude-Client-Controllers-Api-ClientApiAuthenticationController-RefreshAccessToken-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommand- 'Definux.Emeraude.Client.Controllers.Api.ClientApiAuthenticationController.RefreshAccessToken(Definux.Emeraude.Application.Requests.Identity.Commands.RefreshAccessToken.RefreshAccessTokenCommand)')
  - [Register(request)](#M-Definux-Emeraude-Client-Controllers-Api-ClientApiAuthenticationController-Register-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand- 'Definux.Emeraude.Client.Controllers.Api.ClientApiAuthenticationController.Register(Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterCommand)')
- [ClientController](#T-Definux-Emeraude-Client-Controllers-Mvc-ClientController 'Definux.Emeraude.Client.Controllers.Mvc.ClientController')
  - [RedirectToExecutionResultAsync(succeeded,successTitle,failedTitle,successMessage,failedMessage,reference)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientController-RedirectToExecutionResultAsync-System-Boolean,System-String,System-String,System-String,System-String,System-String- 'Definux.Emeraude.Client.Controllers.Mvc.ClientController.RedirectToExecutionResultAsync(System.Boolean,System.String,System.String,System.String,System.String,System.String)')
  - [RedirectToSucceededExecutionResultAsync(title,message,reference)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientController-RedirectToSucceededExecutionResultAsync-System-String,System-String,System-String- 'Definux.Emeraude.Client.Controllers.Mvc.ClientController.RedirectToSucceededExecutionResultAsync(System.String,System.String,System.String)')
- [ClientExecutionResultController](#T-Definux-Emeraude-Client-Controllers-Mvc-ClientExecutionResultController 'Definux.Emeraude.Client.Controllers.Mvc.ClientExecutionResultController')
  - [Handle(title,message,succeeded,reference)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientExecutionResultController-Handle-System-String,System-String,System-Boolean,System-String- 'Definux.Emeraude.Client.Controllers.Mvc.ClientExecutionResultController.Handle(System.String,System.String,System.Boolean,System.String)')
  - [Index(reference)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientExecutionResultController-Index-System-String- 'Definux.Emeraude.Client.Controllers.Mvc.ClientExecutionResultController.Index(System.String)')
- [ClientMaintenanceController](#T-Definux-Emeraude-Client-Controllers-Mvc-ClientMaintenanceController 'Definux.Emeraude.Client.Controllers.Mvc.ClientMaintenanceController')
  - [#ctor()](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientMaintenanceController-#ctor 'Definux.Emeraude.Client.Controllers.Mvc.ClientMaintenanceController.#ctor')
  - [Index()](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientMaintenanceController-Index 'Definux.Emeraude.Client.Controllers.Mvc.ClientMaintenanceController.Index')
- [ClientManagementController](#T-Definux-Emeraude-Client-Controllers-Mvc-ClientManagementController 'Definux.Emeraude.Client.Controllers.Mvc.ClientManagementController')
  - [ConfirmChangeEmail(email,token)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientManagementController-ConfirmChangeEmail-System-String,System-String- 'Definux.Emeraude.Client.Controllers.Mvc.ClientManagementController.ConfirmChangeEmail(System.String,System.String)')
- [ClientMvcAuthenticationController](#T-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController 'Definux.Emeraude.Client.Controllers.Mvc.ClientMvcAuthenticationController')
  - [#ctor(userClaimsService,urlEncoder,emeraudeOptionsAccessor,signInManager,externalProviderAuthenticatorFactory)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-#ctor-Definux-Emeraude-Application-Identity-IUserClaimsService,System-Text-Encodings-Web-UrlEncoder,Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions},Microsoft-AspNetCore-Identity-SignInManager{Definux-Emeraude-Identity-Entities-User},Definux-Emeraude-Application-Identity-IExternalProviderAuthenticatorFactory- 'Definux.Emeraude.Client.Controllers.Mvc.ClientMvcAuthenticationController.#ctor(Definux.Emeraude.Application.Identity.IUserClaimsService,System.Text.Encodings.Web.UrlEncoder,Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions},Microsoft.AspNetCore.Identity.SignInManager{Definux.Emeraude.Identity.Entities.User},Definux.Emeraude.Application.Identity.IExternalProviderAuthenticatorFactory)')
  - [ConfirmEmail(email,token)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-ConfirmEmail-System-String,System-String- 'Definux.Emeraude.Client.Controllers.Mvc.ClientMvcAuthenticationController.ConfirmEmail(System.String,System.String)')
  - [ExternalLogin(externalProvider,returnUrl)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-ExternalLogin-System-String,System-String- 'Definux.Emeraude.Client.Controllers.Mvc.ClientMvcAuthenticationController.ExternalLogin(System.String,System.String)')
  - [ExternalLoginCallback(returnUrl)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-ExternalLoginCallback-System-String- 'Definux.Emeraude.Client.Controllers.Mvc.ClientMvcAuthenticationController.ExternalLoginCallback(System.String)')
  - [ForgotPassword()](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-ForgotPassword 'Definux.Emeraude.Client.Controllers.Mvc.ClientMvcAuthenticationController.ForgotPassword')
  - [ForgotPassword(request)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-ForgotPassword-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommand- 'Definux.Emeraude.Client.Controllers.Mvc.ClientMvcAuthenticationController.ForgotPassword(Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword.ForgotPasswordCommand)')
  - [Login(returnUrl)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-Login-System-String- 'Definux.Emeraude.Client.Controllers.Mvc.ClientMvcAuthenticationController.Login(System.String)')
  - [Login(request,returnUrl)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-Login-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommand,System-String- 'Definux.Emeraude.Client.Controllers.Mvc.ClientMvcAuthenticationController.Login(Definux.Emeraude.Application.Requests.Identity.Commands.Login.LoginCommand,System.String)')
  - [Logout()](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-Logout 'Definux.Emeraude.Client.Controllers.Mvc.ClientMvcAuthenticationController.Logout')
  - [OnActionExecutionAsync()](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-OnActionExecutionAsync-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext,Microsoft-AspNetCore-Mvc-Filters-ActionExecutionDelegate- 'Definux.Emeraude.Client.Controllers.Mvc.ClientMvcAuthenticationController.OnActionExecutionAsync(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext,Microsoft.AspNetCore.Mvc.Filters.ActionExecutionDelegate)')
  - [Register()](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-Register 'Definux.Emeraude.Client.Controllers.Mvc.ClientMvcAuthenticationController.Register')
  - [Register(request)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-Register-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand- 'Definux.Emeraude.Client.Controllers.Mvc.ClientMvcAuthenticationController.Register(Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterCommand)')
  - [ResetPassword(token,email)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-ResetPassword-System-String,System-String- 'Definux.Emeraude.Client.Controllers.Mvc.ClientMvcAuthenticationController.ResetPassword(System.String,System.String)')
  - [ResetPassword(request)](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-ResetPassword-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommand- 'Definux.Emeraude.Client.Controllers.Mvc.ClientMvcAuthenticationController.ResetPassword(Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword.ResetPasswordCommand)')
  - [View()](#M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-View-System-String,System-Object- 'Definux.Emeraude.Client.Controllers.Mvc.ClientMvcAuthenticationController.View(System.String,System.Object)')
- [ClientUploadApiController](#T-Definux-Emeraude-Client-Controllers-Api-ClientUploadApiController 'Definux.Emeraude.Client.Controllers.Api.ClientUploadApiController')
  - [Image(formFile)](#M-Definux-Emeraude-Client-Controllers-Api-ClientUploadApiController-Image-Microsoft-AspNetCore-Http-IFormFile- 'Definux.Emeraude.Client.Controllers.Api.ClientUploadApiController.Image(Microsoft.AspNetCore.Http.IFormFile)')
  - [Video(formFile)](#M-Definux-Emeraude-Client-Controllers-Api-ClientUploadApiController-Video-Microsoft-AspNetCore-Http-IFormFile- 'Definux.Emeraude.Client.Controllers.Api.ClientUploadApiController.Video(Microsoft.AspNetCore.Http.IFormFile)')
- [ExternalAuthenticationProvidersCollection](#T-Definux-Emeraude-Client-Adapters-ExternalAuthenticationProvidersCollection 'Definux.Emeraude.Client.Adapters.ExternalAuthenticationProvidersCollection')
  - [#ctor(externalProviderAuthenticatorFactory)](#M-Definux-Emeraude-Client-Adapters-ExternalAuthenticationProvidersCollection-#ctor-Definux-Emeraude-Application-Identity-IExternalProviderAuthenticatorFactory- 'Definux.Emeraude.Client.Adapters.ExternalAuthenticationProvidersCollection.#ctor(Definux.Emeraude.Application.Identity.IExternalProviderAuthenticatorFactory)')
  - [ExternalProviders](#P-Definux-Emeraude-Client-Adapters-ExternalAuthenticationProvidersCollection-ExternalProviders 'Definux.Emeraude.Client.Adapters.ExternalAuthenticationProvidersCollection.ExternalProviders')
- [ServiceCollectionExtensions](#T-Definux-Emeraude-Client-Extensions-ServiceCollectionExtensions 'Definux.Emeraude.Client.Extensions.ServiceCollectionExtensions')
  - [AddClientCookie(builder)](#M-Definux-Emeraude-Client-Extensions-ServiceCollectionExtensions-AddClientCookie-Microsoft-AspNetCore-Authentication-AuthenticationBuilder- 'Definux.Emeraude.Client.Extensions.ServiceCollectionExtensions.AddClientCookie(Microsoft.AspNetCore.Authentication.AuthenticationBuilder)')
  - [AddClientMapperConfiguration(configuration)](#M-Definux-Emeraude-Client-Extensions-ServiceCollectionExtensions-AddClientMapperConfiguration-AutoMapper-IMapperConfigurationExpression- 'Definux.Emeraude.Client.Extensions.ServiceCollectionExtensions.AddClientMapperConfiguration(AutoMapper.IMapperConfigurationExpression)')
  - [AddEmeraudeClient(services)](#M-Definux-Emeraude-Client-Extensions-ServiceCollectionExtensions-AddEmeraudeClient-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Definux.Emeraude.Client.Extensions.ServiceCollectionExtensions.AddEmeraudeClient(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [UseCentralEmPagesRoutePrefix(options)](#M-Definux-Emeraude-Client-Extensions-ServiceCollectionExtensions-UseCentralEmPagesRoutePrefix-Microsoft-AspNetCore-Mvc-MvcOptions- 'Definux.Emeraude.Client.Extensions.ServiceCollectionExtensions.UseCentralEmPagesRoutePrefix(Microsoft.AspNetCore.Mvc.MvcOptions)')

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

<a name='T-Definux-Emeraude-Client-Controllers-Api-ClientApiAuthenticationController'></a>
## ClientApiAuthenticationController `type`

##### Namespace

Definux.Emeraude.Client.Controllers.Api

##### Summary

*Inherit from parent.*

##### Summary

Client API controller for authentication.

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientApiAuthenticationController-#ctor-Definux-Emeraude-Application-Identity-IUserClaimsService,Definux-Emeraude-Application-Identity-IUserTokensService,Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions}-'></a>
### #ctor(userClaimsService,userTokensService,emeraudeOptionsAccessor) `constructor`

##### Summary

Initializes a new instance of the [ClientApiAuthenticationController](#T-Definux-Emeraude-Client-Controllers-Api-ClientApiAuthenticationController 'Definux.Emeraude.Client.Controllers.Api.ClientApiAuthenticationController') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userClaimsService | [Definux.Emeraude.Application.Identity.IUserClaimsService](#T-Definux-Emeraude-Application-Identity-IUserClaimsService 'Definux.Emeraude.Application.Identity.IUserClaimsService') |  |
| userTokensService | [Definux.Emeraude.Application.Identity.IUserTokensService](#T-Definux-Emeraude-Application-Identity-IUserTokensService 'Definux.Emeraude.Application.Identity.IUserTokensService') |  |
| emeraudeOptionsAccessor | [Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions}](#T-Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions} 'Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions}') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientApiAuthenticationController-ExternalAuthentication-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationData-'></a>
### ExternalAuthentication(authData) `method`

##### Summary

External login provider authentication action.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| authData | [Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationData](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationData 'Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationData') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientApiAuthenticationController-ForgotPassword-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommand-'></a>
### ForgotPassword(request) `method`

##### Summary

Forgot password action.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword.ForgotPasswordCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword.ForgotPasswordCommand') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientApiAuthenticationController-Login-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommand-'></a>
### Login(request) `method`

##### Summary

Login action.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Definux.Emeraude.Application.Requests.Identity.Commands.Login.LoginCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.Login.LoginCommand') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientApiAuthenticationController-OnActionExecutionAsync-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext,Microsoft-AspNetCore-Mvc-Filters-ActionExecutionDelegate-'></a>
### OnActionExecutionAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientApiAuthenticationController-RefreshAccessToken-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommand-'></a>
### RefreshAccessToken(request) `method`

##### Summary

Refresh JWT token action.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Definux.Emeraude.Application.Requests.Identity.Commands.RefreshAccessToken.RefreshAccessTokenCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.RefreshAccessToken.RefreshAccessTokenCommand') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Api-ClientApiAuthenticationController-Register-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand-'></a>
### Register(request) `method`

##### Summary

Register action.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterCommand') |  |

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

<a name='T-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController'></a>
## ClientMvcAuthenticationController `type`

##### Namespace

Definux.Emeraude.Client.Controllers.Mvc

##### Summary

*Inherit from parent.*

##### Summary

Client controller for MVC authentication.

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-#ctor-Definux-Emeraude-Application-Identity-IUserClaimsService,System-Text-Encodings-Web-UrlEncoder,Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions},Microsoft-AspNetCore-Identity-SignInManager{Definux-Emeraude-Identity-Entities-User},Definux-Emeraude-Application-Identity-IExternalProviderAuthenticatorFactory-'></a>
### #ctor(userClaimsService,urlEncoder,emeraudeOptionsAccessor,signInManager,externalProviderAuthenticatorFactory) `constructor`

##### Summary

Initializes a new instance of the [ClientMvcAuthenticationController](#T-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController 'Definux.Emeraude.Client.Controllers.Mvc.ClientMvcAuthenticationController') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userClaimsService | [Definux.Emeraude.Application.Identity.IUserClaimsService](#T-Definux-Emeraude-Application-Identity-IUserClaimsService 'Definux.Emeraude.Application.Identity.IUserClaimsService') |  |
| urlEncoder | [System.Text.Encodings.Web.UrlEncoder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encodings.Web.UrlEncoder 'System.Text.Encodings.Web.UrlEncoder') |  |
| emeraudeOptionsAccessor | [Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions}](#T-Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions} 'Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions}') |  |
| signInManager | [Microsoft.AspNetCore.Identity.SignInManager{Definux.Emeraude.Identity.Entities.User}](#T-Microsoft-AspNetCore-Identity-SignInManager{Definux-Emeraude-Identity-Entities-User} 'Microsoft.AspNetCore.Identity.SignInManager{Definux.Emeraude.Identity.Entities.User}') |  |
| externalProviderAuthenticatorFactory | [Definux.Emeraude.Application.Identity.IExternalProviderAuthenticatorFactory](#T-Definux-Emeraude-Application-Identity-IExternalProviderAuthenticatorFactory 'Definux.Emeraude.Application.Identity.IExternalProviderAuthenticatorFactory') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-ConfirmEmail-System-String,System-String-'></a>
### ConfirmEmail(email,token) `method`

##### Summary

Confirm email action.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| email | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| token | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-ExternalLogin-System-String,System-String-'></a>
### ExternalLogin(externalProvider,returnUrl) `method`

##### Summary

External login action.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| externalProvider | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| returnUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-ExternalLoginCallback-System-String-'></a>
### ExternalLoginCallback(returnUrl) `method`

##### Summary

External login callback action.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| returnUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-ForgotPassword'></a>
### ForgotPassword() `method`

##### Summary

Forgot password action for GET request.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-ForgotPassword-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommand-'></a>
### ForgotPassword(request) `method`

##### Summary

Forgot password action for POST request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword.ForgotPasswordCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword.ForgotPasswordCommand') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-Login-System-String-'></a>
### Login(returnUrl) `method`

##### Summary

Login action for GET request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| returnUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-Login-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommand,System-String-'></a>
### Login(request,returnUrl) `method`

##### Summary

Login action for GET request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Definux.Emeraude.Application.Requests.Identity.Commands.Login.LoginCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.Login.LoginCommand') |  |
| returnUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-Logout'></a>
### Logout() `method`

##### Summary

Logout action for GET and POST requests.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-OnActionExecutionAsync-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext,Microsoft-AspNetCore-Mvc-Filters-ActionExecutionDelegate-'></a>
### OnActionExecutionAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-Register'></a>
### Register() `method`

##### Summary

Register action for GET request.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-Register-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand-'></a>
### Register(request) `method`

##### Summary

Register action for POST request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterCommand') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-ResetPassword-System-String,System-String-'></a>
### ResetPassword(token,email) `method`

##### Summary

Reset password action for GET request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| token | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| email | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-ResetPassword-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommand-'></a>
### ResetPassword(request) `method`

##### Summary

Reset password action for POST request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword.ResetPasswordCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword.ResetPasswordCommand') |  |

<a name='M-Definux-Emeraude-Client-Controllers-Mvc-ClientMvcAuthenticationController-View-System-String,System-Object-'></a>
### View() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Client-Controllers-Api-ClientUploadApiController'></a>
## ClientUploadApiController `type`

##### Namespace

Definux.Emeraude.Client.Controllers.Api

##### Summary

Client API upload controller.

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

Register client features (EmPages, language based routes).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |

<a name='M-Definux-Emeraude-Client-Extensions-ServiceCollectionExtensions-UseCentralEmPagesRoutePrefix-Microsoft-AspNetCore-Mvc-MvcOptions-'></a>
### UseCentralEmPagesRoutePrefix(options) `method`

##### Summary

Configure EmPages routes.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [Microsoft.AspNetCore.Mvc.MvcOptions](#T-Microsoft-AspNetCore-Mvc-MvcOptions 'Microsoft.AspNetCore.Mvc.MvcOptions') |  |
