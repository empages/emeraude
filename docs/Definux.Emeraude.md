<a name='assembly'></a>
# Definux.Emeraude

## Contents

- [ApplicationAssemblyPart](#T-Definux-Emeraude-ApplicationAssemblyPart 'Definux.Emeraude.ApplicationAssemblyPart')
  - [Assembly](#P-Definux-Emeraude-ApplicationAssemblyPart-Assembly 'Definux.Emeraude.ApplicationAssemblyPart.Assembly')
  - [AssemblyPart](#P-Definux-Emeraude-ApplicationAssemblyPart-AssemblyPart 'Definux.Emeraude.ApplicationAssemblyPart.AssemblyPart')
- [ApplicationBuilderExtensions](#T-Definux-Emeraude-Extensions-ApplicationBuilderExtensions 'Definux.Emeraude.Extensions.ApplicationBuilderExtensions')
  - [UseEmeraude(app,environment,forseProduction)](#M-Definux-Emeraude-Extensions-ApplicationBuilderExtensions-UseEmeraude-Microsoft-AspNetCore-Builder-IApplicationBuilder,Microsoft-AspNetCore-Hosting-IWebHostEnvironment,System-Boolean- 'Definux.Emeraude.Extensions.ApplicationBuilderExtensions.UseEmeraude(Microsoft.AspNetCore.Builder.IApplicationBuilder,Microsoft.AspNetCore.Hosting.IWebHostEnvironment,System.Boolean)')
- [DateTimeModelBinderProvider](#T-Definux-Emeraude-ModelBinders-DateTimeModelBinderProvider 'Definux.Emeraude.ModelBinders.DateTimeModelBinderProvider')
  - [GetBinder()](#M-Definux-Emeraude-ModelBinders-DateTimeModelBinderProvider-GetBinder-Microsoft-AspNetCore-Mvc-ModelBinding-ModelBinderProviderContext- 'Definux.Emeraude.ModelBinders.DateTimeModelBinderProvider.GetBinder(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBinderProviderContext)')
- [DateTimeModelBinder\`1](#T-Definux-Emeraude-ModelBinders-DateTimeModelBinder`1 'Definux.Emeraude.ModelBinders.DateTimeModelBinder`1')
  - [AllowNullValue](#P-Definux-Emeraude-ModelBinders-DateTimeModelBinder`1-AllowNullValue 'Definux.Emeraude.ModelBinders.DateTimeModelBinder`1.AllowNullValue')
  - [BindModelAsync()](#M-Definux-Emeraude-ModelBinders-DateTimeModelBinder`1-BindModelAsync-Microsoft-AspNetCore-Mvc-ModelBinding-ModelBindingContext- 'Definux.Emeraude.ModelBinders.DateTimeModelBinder`1.BindModelAsync(Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext)')
- [EmStartup](#T-Definux-Emeraude-EmStartup 'Definux.Emeraude.EmStartup')
  - [RunEmeraude(hostBuilder)](#M-Definux-Emeraude-EmStartup-RunEmeraude-Microsoft-Extensions-Hosting-IHostBuilder- 'Definux.Emeraude.EmStartup.RunEmeraude(Microsoft.Extensions.Hosting.IHostBuilder)')
- [EmeraudeSettingsBuilder](#T-Definux-Emeraude-EmeraudeSettingsBuilder 'Definux.Emeraude.EmeraudeSettingsBuilder')
  - [AuthenticationBuilder](#P-Definux-Emeraude-EmeraudeSettingsBuilder-AuthenticationBuilder 'Definux.Emeraude.EmeraudeSettingsBuilder.AuthenticationBuilder')
  - [Services](#P-Definux-Emeraude-EmeraudeSettingsBuilder-Services 'Definux.Emeraude.EmeraudeSettingsBuilder.Services')
- [EmeraudeSettingsBuilderExtensions](#T-Definux-Emeraude-Extensions-EmeraudeSettingsBuilderExtensions 'Definux.Emeraude.Extensions.EmeraudeSettingsBuilderExtensions')
  - [AddExternalProvidersAuthenticators(builder,authenticatorsAction)](#M-Definux-Emeraude-Extensions-EmeraudeSettingsBuilderExtensions-AddExternalProvidersAuthenticators-Definux-Emeraude-EmeraudeSettingsBuilder,System-Action{System-Collections-Generic-List{Definux-Emeraude-Application-Identity-IExternalProviderAuthenticator}}- 'Definux.Emeraude.Extensions.EmeraudeSettingsBuilderExtensions.AddExternalProvidersAuthenticators(Definux.Emeraude.EmeraudeSettingsBuilder,System.Action{System.Collections.Generic.List{Definux.Emeraude.Application.Identity.IExternalProviderAuthenticator}})')
- [EnumsApiController](#T-Definux-Emeraude-Controllers-Api-EnumsApiController 'Definux.Emeraude.Controllers.Api.EnumsApiController')
  - [GetEnumValue(enumTypeName,value)](#M-Definux-Emeraude-Controllers-Api-EnumsApiController-GetEnumValue-System-String,System-Int32- 'Definux.Emeraude.Controllers.Api.EnumsApiController.GetEnumValue(System.String,System.Int32)')
  - [GetEnumValueList(enumTypeName)](#M-Definux-Emeraude-Controllers-Api-EnumsApiController-GetEnumValueList-System-String- 'Definux.Emeraude.Controllers.Api.EnumsApiController.GetEnumValueList(System.String)')
- [ErrorController](#T-Definux-Emeraude-Controllers-ErrorController 'Definux.Emeraude.Controllers.ErrorController')
  - [Index(statusCode,compositeViewEngine)](#M-Definux-Emeraude-Controllers-ErrorController-Index-System-Int32,Microsoft-AspNetCore-Mvc-ViewEngines-ICompositeViewEngine- 'Definux.Emeraude.Controllers.ErrorController.Index(System.Int32,Microsoft.AspNetCore.Mvc.ViewEngines.ICompositeViewEngine)')
- [LoggerApiController](#T-Definux-Emeraude-Controllers-Api-LoggerApiController 'Definux.Emeraude.Controllers.Api.LoggerApiController')
  - [#ctor(logger)](#M-Definux-Emeraude-Controllers-Api-LoggerApiController-#ctor-Definux-Emeraude-Application-Logger-IEmLogger- 'Definux.Emeraude.Controllers.Api.LoggerApiController.#ctor(Definux.Emeraude.Application.Logger.IEmLogger)')
  - [LogClientError(request)](#M-Definux-Emeraude-Controllers-Api-LoggerApiController-LogClientError-Definux-Emeraude-Application-Requests-Logging-Commands-LogFrontEndError-LogFrontEndErrorCommand- 'Definux.Emeraude.Controllers.Api.LoggerApiController.LogClientError(Definux.Emeraude.Application.Requests.Logging.Commands.LogFrontEndError.LogFrontEndErrorCommand)')
- [RequestExceptionFilter](#T-Definux-Emeraude-ActionFilters-RequestExceptionFilter 'Definux.Emeraude.ActionFilters.RequestExceptionFilter')
  - [#ctor()](#M-Definux-Emeraude-ActionFilters-RequestExceptionFilter-#ctor 'Definux.Emeraude.ActionFilters.RequestExceptionFilter.#ctor')
  - [OnException()](#M-Definux-Emeraude-ActionFilters-RequestExceptionFilter-OnException-Microsoft-AspNetCore-Mvc-Filters-ExceptionContext- 'Definux.Emeraude.ActionFilters.RequestExceptionFilter.OnException(Microsoft.AspNetCore.Mvc.Filters.ExceptionContext)')
- [ServiceCollectionExtensions](#T-Definux-Emeraude-Extensions-ServiceCollectionExtensions 'Definux.Emeraude.Extensions.ServiceCollectionExtensions')
  - [AddEmeraude\`\`2(services,optionsAction,seoOptionsAction)](#M-Definux-Emeraude-Extensions-ServiceCollectionExtensions-AddEmeraude``2-Microsoft-Extensions-DependencyInjection-IServiceCollection,System-Action{Definux-Emeraude-Configuration-Options-EmOptions},System-Action{Definux-Seo-Options-DefinuxSeoOptions}- 'Definux.Emeraude.Extensions.ServiceCollectionExtensions.AddEmeraude``2(Microsoft.Extensions.DependencyInjection.IServiceCollection,System.Action{Definux.Emeraude.Configuration.Options.EmOptions},System.Action{Definux.Seo.Options.DefinuxSeoOptions})')
  - [ApplyAuthenticationSessionToPrivateRoot(services)](#M-Definux-Emeraude-Extensions-ServiceCollectionExtensions-ApplyAuthenticationSessionToPrivateRoot-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Definux.Emeraude.Extensions.ServiceCollectionExtensions.ApplyAuthenticationSessionToPrivateRoot(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [ApplyEmeraudeBaseOptions(options)](#M-Definux-Emeraude-Extensions-ServiceCollectionExtensions-ApplyEmeraudeBaseOptions-Definux-Emeraude-Configuration-Options-EmOptions- 'Definux.Emeraude.Extensions.ServiceCollectionExtensions.ApplyEmeraudeBaseOptions(Definux.Emeraude.Configuration.Options.EmOptions)')
- [TimeSpanConverter](#T-Definux-Emeraude-Converters-TimeSpanConverter 'Definux.Emeraude.Converters.TimeSpanConverter')
  - [Read()](#M-Definux-Emeraude-Converters-TimeSpanConverter-Read-System-Text-Json-Utf8JsonReader@,System-Type,System-Text-Json-JsonSerializerOptions- 'Definux.Emeraude.Converters.TimeSpanConverter.Read(System.Text.Json.Utf8JsonReader@,System.Type,System.Text.Json.JsonSerializerOptions)')
  - [Write()](#M-Definux-Emeraude-Converters-TimeSpanConverter-Write-System-Text-Json-Utf8JsonWriter,System-TimeSpan,System-Text-Json-JsonSerializerOptions- 'Definux.Emeraude.Converters.TimeSpanConverter.Write(System.Text.Json.Utf8JsonWriter,System.TimeSpan,System.Text.Json.JsonSerializerOptions)')
- [UsersApiController](#T-Definux-Emeraude-Controllers-Api-UsersApiController 'Definux.Emeraude.Controllers.Api.UsersApiController')
  - [#ctor(currentUserProvider)](#M-Definux-Emeraude-Controllers-Api-UsersApiController-#ctor-Definux-Emeraude-Application-Identity-ICurrentUserProvider- 'Definux.Emeraude.Controllers.Api.UsersApiController.#ctor(Definux.Emeraude.Application.Identity.ICurrentUserProvider)')
  - [ChangeUserAvatar(request)](#M-Definux-Emeraude-Controllers-Api-UsersApiController-ChangeUserAvatar-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserAvatar-ChangeUserAvatarCommand- 'Definux.Emeraude.Controllers.Api.UsersApiController.ChangeUserAvatar(Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserAvatar.ChangeUserAvatarCommand)')
  - [ChangeUserName(request)](#M-Definux-Emeraude-Controllers-Api-UsersApiController-ChangeUserName-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserName-ChangeUserNameCommand- 'Definux.Emeraude.Controllers.Api.UsersApiController.ChangeUserName(Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserName.ChangeUserNameCommand)')
  - [ChangeUserPassword(request)](#M-Definux-Emeraude-Controllers-Api-UsersApiController-ChangeUserPassword-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommand- 'Definux.Emeraude.Controllers.Api.UsersApiController.ChangeUserPassword(Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword.ChangePasswordCommand)')
  - [GetCurrentUserAvatar()](#M-Definux-Emeraude-Controllers-Api-UsersApiController-GetCurrentUserAvatar 'Definux.Emeraude.Controllers.Api.UsersApiController.GetCurrentUserAvatar')
  - [GetCurrentUserExternalLoginProviders()](#M-Definux-Emeraude-Controllers-Api-UsersApiController-GetCurrentUserExternalLoginProviders 'Definux.Emeraude.Controllers.Api.UsersApiController.GetCurrentUserExternalLoginProviders')
  - [GetUserAvatarType()](#M-Definux-Emeraude-Controllers-Api-UsersApiController-GetUserAvatarType 'Definux.Emeraude.Controllers.Api.UsersApiController.GetUserAvatarType')
  - [RemoveCurrentUserExternalLoginProvider(request)](#M-Definux-Emeraude-Controllers-Api-UsersApiController-RemoveCurrentUserExternalLoginProvider-Definux-Emeraude-Application-Requests-Identity-Commands-RemoveExternalLoginProvider-RemoveExternalLoginProviderCommand- 'Definux.Emeraude.Controllers.Api.UsersApiController.RemoveCurrentUserExternalLoginProvider(Definux.Emeraude.Application.Requests.Identity.Commands.RemoveExternalLoginProvider.RemoveExternalLoginProviderCommand)')
  - [RequestChangeEmailForTheCurrentUser(request)](#M-Definux-Emeraude-Controllers-Api-UsersApiController-RequestChangeEmailForTheCurrentUser-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommand- 'Definux.Emeraude.Controllers.Api.UsersApiController.RequestChangeEmailForTheCurrentUser(Definux.Emeraude.Application.Requests.Identity.Commands.RequestChangeEmail.RequestChangeEmailCommand)')
  - [RequestResetPasswordForTheCurrentUser()](#M-Definux-Emeraude-Controllers-Api-UsersApiController-RequestResetPasswordForTheCurrentUser 'Definux.Emeraude.Controllers.Api.UsersApiController.RequestResetPasswordForTheCurrentUser')

<a name='T-Definux-Emeraude-ApplicationAssemblyPart'></a>
## ApplicationAssemblyPart `type`

##### Namespace

Definux.Emeraude

##### Summary

Static class that provides access to the Emeraude asembly information.

<a name='P-Definux-Emeraude-ApplicationAssemblyPart-Assembly'></a>
### Assembly `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-ApplicationAssemblyPart-AssemblyPart'></a>
### AssemblyPart `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Extensions-ApplicationBuilderExtensions'></a>
## ApplicationBuilderExtensions `type`

##### Namespace

Definux.Emeraude.Extensions

##### Summary

Extensions for [IApplicationBuilder](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder 'Microsoft.AspNetCore.Builder.IApplicationBuilder').

<a name='M-Definux-Emeraude-Extensions-ApplicationBuilderExtensions-UseEmeraude-Microsoft-AspNetCore-Builder-IApplicationBuilder,Microsoft-AspNetCore-Hosting-IWebHostEnvironment,System-Boolean-'></a>
### UseEmeraude(app,environment,forseProduction) `method`

##### Summary

Registers and configures Emeraude required middlewares.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| app | [Microsoft.AspNetCore.Builder.IApplicationBuilder](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder 'Microsoft.AspNetCore.Builder.IApplicationBuilder') |  |
| environment | [Microsoft.AspNetCore.Hosting.IWebHostEnvironment](#T-Microsoft-AspNetCore-Hosting-IWebHostEnvironment 'Microsoft.AspNetCore.Hosting.IWebHostEnvironment') |  |
| forseProduction | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-Definux-Emeraude-ModelBinders-DateTimeModelBinderProvider'></a>
## DateTimeModelBinderProvider `type`

##### Namespace

Definux.Emeraude.ModelBinders

##### Summary

Customized [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') model binder provider for the needs of Emeraude.

<a name='M-Definux-Emeraude-ModelBinders-DateTimeModelBinderProvider-GetBinder-Microsoft-AspNetCore-Mvc-ModelBinding-ModelBinderProviderContext-'></a>
### GetBinder() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-ModelBinders-DateTimeModelBinder`1'></a>
## DateTimeModelBinder\`1 `type`

##### Namespace

Definux.Emeraude.ModelBinders

##### Summary

Customized [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') model binder for the needs of Emeraude.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TDateTime | DateTime or DateTimeOffset type. |

<a name='P-Definux-Emeraude-ModelBinders-DateTimeModelBinder`1-AllowNullValue'></a>
### AllowNullValue `property`

##### Summary

Flag that indicates whether the model can be null.

<a name='M-Definux-Emeraude-ModelBinders-DateTimeModelBinder`1-BindModelAsync-Microsoft-AspNetCore-Mvc-ModelBinding-ModelBindingContext-'></a>
### BindModelAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-EmStartup'></a>
## EmStartup `type`

##### Namespace

Definux.Emeraude

##### Summary

Emeraude startup base class used for initial point of the application.

<a name='M-Definux-Emeraude-EmStartup-RunEmeraude-Microsoft-Extensions-Hosting-IHostBuilder-'></a>
### RunEmeraude(hostBuilder) `method`

##### Summary

The main method of application which must be called by the Main method of the application.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hostBuilder | [Microsoft.Extensions.Hosting.IHostBuilder](#T-Microsoft-Extensions-Hosting-IHostBuilder 'Microsoft.Extensions.Hosting.IHostBuilder') |  |

<a name='T-Definux-Emeraude-EmeraudeSettingsBuilder'></a>
## EmeraudeSettingsBuilder `type`

##### Namespace

Definux.Emeraude

##### Summary

Helper class that contains all additional registration models for applying additional settings.

<a name='P-Definux-Emeraude-EmeraudeSettingsBuilder-AuthenticationBuilder'></a>
### AuthenticationBuilder `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-EmeraudeSettingsBuilder-Services'></a>
### Services `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Extensions-EmeraudeSettingsBuilderExtensions'></a>
## EmeraudeSettingsBuilderExtensions `type`

##### Namespace

Definux.Emeraude.Extensions

##### Summary

Extensions for [EmeraudeSettingsBuilder](#T-Definux-Emeraude-EmeraudeSettingsBuilder 'Definux.Emeraude.EmeraudeSettingsBuilder').

<a name='M-Definux-Emeraude-Extensions-EmeraudeSettingsBuilderExtensions-AddExternalProvidersAuthenticators-Definux-Emeraude-EmeraudeSettingsBuilder,System-Action{System-Collections-Generic-List{Definux-Emeraude-Application-Identity-IExternalProviderAuthenticator}}-'></a>
### AddExternalProvidersAuthenticators(builder,authenticatorsAction) `method`

##### Summary

Add external providers authenticators and invoke their registration methods.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Definux.Emeraude.EmeraudeSettingsBuilder](#T-Definux-Emeraude-EmeraudeSettingsBuilder 'Definux.Emeraude.EmeraudeSettingsBuilder') |  |
| authenticatorsAction | [System.Action{System.Collections.Generic.List{Definux.Emeraude.Application.Identity.IExternalProviderAuthenticator}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Collections.Generic.List{Definux.Emeraude.Application.Identity.IExternalProviderAuthenticator}}') |  |

<a name='T-Definux-Emeraude-Controllers-Api-EnumsApiController'></a>
## EnumsApiController `type`

##### Namespace

Definux.Emeraude.Controllers.Api

##### Summary

Enumeration API controller that provide access to enumeration types and their values.

<a name='M-Definux-Emeraude-Controllers-Api-EnumsApiController-GetEnumValue-System-String,System-Int32-'></a>
### GetEnumValue(enumTypeName,value) `method`

##### Summary

Get a specified enumeration by the enumeration type and value.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumTypeName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Definux-Emeraude-Controllers-Api-EnumsApiController-GetEnumValueList-System-String-'></a>
### GetEnumValueList(enumTypeName) `method`

##### Summary

Get all enumerations with their values.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumTypeName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Controllers-ErrorController'></a>
## ErrorController `type`

##### Namespace

Definux.Emeraude.Controllers

##### Summary

Generic error controller which is triggered by the error interceptor.

<a name='M-Definux-Emeraude-Controllers-ErrorController-Index-System-Int32,Microsoft-AspNetCore-Mvc-ViewEngines-ICompositeViewEngine-'></a>
### Index(statusCode,compositeViewEngine) `method`

##### Summary

Error index action that returns a status code result if there no defined error view or the view placed on 'Views/Client/Error/Index.cshtml'.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| statusCode | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| compositeViewEngine | [Microsoft.AspNetCore.Mvc.ViewEngines.ICompositeViewEngine](#T-Microsoft-AspNetCore-Mvc-ViewEngines-ICompositeViewEngine 'Microsoft.AspNetCore.Mvc.ViewEngines.ICompositeViewEngine') |  |

<a name='T-Definux-Emeraude-Controllers-Api-LoggerApiController'></a>
## LoggerApiController `type`

##### Namespace

Definux.Emeraude.Controllers.Api

##### Summary

Client API logger controller.

<a name='M-Definux-Emeraude-Controllers-Api-LoggerApiController-#ctor-Definux-Emeraude-Application-Logger-IEmLogger-'></a>
### #ctor(logger) `constructor`

##### Summary

Initializes a new instance of the [LoggerApiController](#T-Definux-Emeraude-Controllers-Api-LoggerApiController 'Definux.Emeraude.Controllers.Api.LoggerApiController') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |

<a name='M-Definux-Emeraude-Controllers-Api-LoggerApiController-LogClientError-Definux-Emeraude-Application-Requests-Logging-Commands-LogFrontEndError-LogFrontEndErrorCommand-'></a>
### LogClientError(request) `method`

##### Summary

Log error to server.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Definux.Emeraude.Application.Requests.Logging.Commands.LogFrontEndError.LogFrontEndErrorCommand](#T-Definux-Emeraude-Application-Requests-Logging-Commands-LogFrontEndError-LogFrontEndErrorCommand 'Definux.Emeraude.Application.Requests.Logging.Commands.LogFrontEndError.LogFrontEndErrorCommand') |  |

<a name='T-Definux-Emeraude-ActionFilters-RequestExceptionFilter'></a>
## RequestExceptionFilter `type`

##### Namespace

Definux.Emeraude.ActionFilters

##### Summary

Filter for catching specific exceptions during request execution.

<a name='M-Definux-Emeraude-ActionFilters-RequestExceptionFilter-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [RequestExceptionFilter](#T-Definux-Emeraude-ActionFilters-RequestExceptionFilter 'Definux.Emeraude.ActionFilters.RequestExceptionFilter') class.

##### Parameters

This constructor has no parameters.

<a name='M-Definux-Emeraude-ActionFilters-RequestExceptionFilter-OnException-Microsoft-AspNetCore-Mvc-Filters-ExceptionContext-'></a>
### OnException() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Extensions-ServiceCollectionExtensions'></a>
## ServiceCollectionExtensions `type`

##### Namespace

Definux.Emeraude.Extensions

##### Summary

Extensions for [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection').

<a name='M-Definux-Emeraude-Extensions-ServiceCollectionExtensions-AddEmeraude``2-Microsoft-Extensions-DependencyInjection-IServiceCollection,System-Action{Definux-Emeraude-Configuration-Options-EmOptions},System-Action{Definux-Seo-Options-DefinuxSeoOptions}-'></a>
### AddEmeraude\`\`2(services,optionsAction,seoOptionsAction) `method`

##### Summary

Configure Emeraude framework required services and functionalities.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |
| optionsAction | [System.Action{Definux.Emeraude.Configuration.Options.EmOptions}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Definux.Emeraude.Configuration.Options.EmOptions}') |  |
| seoOptionsAction | [System.Action{Definux.Seo.Options.DefinuxSeoOptions}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Definux.Seo.Options.DefinuxSeoOptions}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TContextInterface | Interface of the application database context. |
| TContextImplementation | Implementation of the application database context. |

<a name='M-Definux-Emeraude-Extensions-ServiceCollectionExtensions-ApplyAuthenticationSessionToPrivateRoot-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### ApplyAuthenticationSessionToPrivateRoot(services) `method`

##### Summary

Configure [IDataProtectionBuilder](#T-Microsoft-AspNetCore-DataProtection-IDataProtectionBuilder 'Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder') to use 'privateroot' as directory for session storage.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |

<a name='M-Definux-Emeraude-Extensions-ServiceCollectionExtensions-ApplyEmeraudeBaseOptions-Definux-Emeraude-Configuration-Options-EmOptions-'></a>
### ApplyEmeraudeBaseOptions(options) `method`

##### Summary

Apply Emeraude base options. In case you want to override the method check the documentation first.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [Definux.Emeraude.Configuration.Options.EmOptions](#T-Definux-Emeraude-Configuration-Options-EmOptions 'Definux.Emeraude.Configuration.Options.EmOptions') |  |

<a name='T-Definux-Emeraude-Converters-TimeSpanConverter'></a>
## TimeSpanConverter `type`

##### Namespace

Definux.Emeraude.Converters

##### Summary

Convertor for transform timespan to a JSON.

<a name='M-Definux-Emeraude-Converters-TimeSpanConverter-Read-System-Text-Json-Utf8JsonReader@,System-Type,System-Text-Json-JsonSerializerOptions-'></a>
### Read() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Converters-TimeSpanConverter-Write-System-Text-Json-Utf8JsonWriter,System-TimeSpan,System-Text-Json-JsonSerializerOptions-'></a>
### Write() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Controllers-Api-UsersApiController'></a>
## UsersApiController `type`

##### Namespace

Definux.Emeraude.Controllers.Api

##### Summary

Client API user utilities controller.

<a name='M-Definux-Emeraude-Controllers-Api-UsersApiController-#ctor-Definux-Emeraude-Application-Identity-ICurrentUserProvider-'></a>
### #ctor(currentUserProvider) `constructor`

##### Summary

Initializes a new instance of the [UsersApiController](#T-Definux-Emeraude-Controllers-Api-UsersApiController 'Definux.Emeraude.Controllers.Api.UsersApiController') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| currentUserProvider | [Definux.Emeraude.Application.Identity.ICurrentUserProvider](#T-Definux-Emeraude-Application-Identity-ICurrentUserProvider 'Definux.Emeraude.Application.Identity.ICurrentUserProvider') |  |

<a name='M-Definux-Emeraude-Controllers-Api-UsersApiController-ChangeUserAvatar-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserAvatar-ChangeUserAvatarCommand-'></a>
### ChangeUserAvatar(request) `method`

##### Summary

Changes the avatar of current user.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserAvatar.ChangeUserAvatarCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserAvatar-ChangeUserAvatarCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserAvatar.ChangeUserAvatarCommand') |  |

<a name='M-Definux-Emeraude-Controllers-Api-UsersApiController-ChangeUserName-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserName-ChangeUserNameCommand-'></a>
### ChangeUserName(request) `method`

##### Summary

Changes the name of the current user.

##### Returns

A [Task\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task`1 'System.Threading.Tasks.Task`1') representing the result of the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserName.ChangeUserNameCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserName-ChangeUserNameCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserName.ChangeUserNameCommand') |  |

<a name='M-Definux-Emeraude-Controllers-Api-UsersApiController-ChangeUserPassword-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommand-'></a>
### ChangeUserPassword(request) `method`

##### Summary

Changes the password of the current user.

##### Returns

A [Task\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task`1 'System.Threading.Tasks.Task`1') representing the result of the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword.ChangePasswordCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword.ChangePasswordCommand') |  |

<a name='M-Definux-Emeraude-Controllers-Api-UsersApiController-GetCurrentUserAvatar'></a>
### GetCurrentUserAvatar() `method`

##### Summary

Gets the current user avatar file result.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Controllers-Api-UsersApiController-GetCurrentUserExternalLoginProviders'></a>
### GetCurrentUserExternalLoginProviders() `method`

##### Summary

Gets collection of external login providers for the current user.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Controllers-Api-UsersApiController-GetUserAvatarType'></a>
### GetUserAvatarType() `method`

##### Summary

Gets flag result that indicates whether the avatar is default or not.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Controllers-Api-UsersApiController-RemoveCurrentUserExternalLoginProvider-Definux-Emeraude-Application-Requests-Identity-Commands-RemoveExternalLoginProvider-RemoveExternalLoginProviderCommand-'></a>
### RemoveCurrentUserExternalLoginProvider(request) `method`

##### Summary

Remove specified external login provider for the current user.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Definux.Emeraude.Application.Requests.Identity.Commands.RemoveExternalLoginProvider.RemoveExternalLoginProviderCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-RemoveExternalLoginProvider-RemoveExternalLoginProviderCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.RemoveExternalLoginProvider.RemoveExternalLoginProviderCommand') |  |

<a name='M-Definux-Emeraude-Controllers-Api-UsersApiController-RequestChangeEmailForTheCurrentUser-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommand-'></a>
### RequestChangeEmailForTheCurrentUser(request) `method`

##### Summary

Make a request for change the email for the current user.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Definux.Emeraude.Application.Requests.Identity.Commands.RequestChangeEmail.RequestChangeEmailCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.RequestChangeEmail.RequestChangeEmailCommand') |  |

<a name='M-Definux-Emeraude-Controllers-Api-UsersApiController-RequestResetPasswordForTheCurrentUser'></a>
### RequestResetPasswordForTheCurrentUser() `method`

##### Summary

Make a request for reset password for the current user.

##### Returns



##### Parameters

This method has no parameters.
