<a name='assembly'></a>
# Definux.Emeraude.Presentation

## Contents

- [ApiController](#T-Definux-Emeraude-Presentation-Controllers-ApiController 'Definux.Emeraude.Presentation.Controllers.ApiController')
  - [DisableActivityLog](#P-Definux-Emeraude-Presentation-Controllers-ApiController-DisableActivityLog 'Definux.Emeraude.Presentation.Controllers.ApiController.DisableActivityLog')
  - [HideActivityLogParameters](#P-Definux-Emeraude-Presentation-Controllers-ApiController-HideActivityLogParameters 'Definux.Emeraude.Presentation.Controllers.ApiController.HideActivityLogParameters')
  - [Logger](#P-Definux-Emeraude-Presentation-Controllers-ApiController-Logger 'Definux.Emeraude.Presentation.Controllers.ApiController.Logger')
  - [Mediator](#P-Definux-Emeraude-Presentation-Controllers-ApiController-Mediator 'Definux.Emeraude.Presentation.Controllers.ApiController.Mediator')
  - [GetSimpleResponse(success)](#M-Definux-Emeraude-Presentation-Controllers-ApiController-GetSimpleResponse-System-Boolean- 'Definux.Emeraude.Presentation.Controllers.ApiController.GetSimpleResponse(System.Boolean)')
  - [GetSuccessResponse(success)](#M-Definux-Emeraude-Presentation-Controllers-ApiController-GetSuccessResponse-System-Boolean- 'Definux.Emeraude.Presentation.Controllers.ApiController.GetSuccessResponse(System.Boolean)')
  - [OnActionExecuting()](#M-Definux-Emeraude-Presentation-Controllers-ApiController-OnActionExecuting-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext- 'Definux.Emeraude.Presentation.Controllers.ApiController.OnActionExecuting(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext)')
- [ControllerExtensions](#T-Definux-Emeraude-Presentation-Extensions-ControllerExtensions 'Definux.Emeraude.Presentation.Extensions.ControllerExtensions')
  - [BadRequestWithModelErrors(controller)](#M-Definux-Emeraude-Presentation-Extensions-ControllerExtensions-BadRequestWithModelErrors-Microsoft-AspNetCore-Mvc-Controller- 'Definux.Emeraude.Presentation.Extensions.ControllerExtensions.BadRequestWithModelErrors(Microsoft.AspNetCore.Mvc.Controller)')
  - [UploadFileResponse(controller,result)](#M-Definux-Emeraude-Presentation-Extensions-ControllerExtensions-UploadFileResponse-Microsoft-AspNetCore-Mvc-Controller,Definux-Emeraude-Application-Requests-Files-Commands-Shared-UploadResult- 'Definux.Emeraude.Presentation.Extensions.ControllerExtensions.UploadFileResponse(Microsoft.AspNetCore.Mvc.Controller,Definux.Emeraude.Application.Requests.Files.Commands.Shared.UploadResult)')
- [IChildController](#T-Definux-Emeraude-Presentation-Controllers-IChildController 'Definux.Emeraude.Presentation.Controllers.IChildController')
  - [ParentController](#P-Definux-Emeraude-Presentation-Controllers-IChildController-ParentController 'Definux.Emeraude.Presentation.Controllers.IChildController.ParentController')
- [ModelStateDictionaryExtensions](#T-Definux-Emeraude-Presentation-Extensions-ModelStateDictionaryExtensions 'Definux.Emeraude.Presentation.Extensions.ModelStateDictionaryExtensions')
  - [ApplyValidationException(modelState,exception,skipTranslationKey)](#M-Definux-Emeraude-Presentation-Extensions-ModelStateDictionaryExtensions-ApplyValidationException-Microsoft-AspNetCore-Mvc-ModelBinding-ModelStateDictionary,Definux-Emeraude-Application-Exceptions-ValidationException,System-Boolean- 'Definux.Emeraude.Presentation.Extensions.ModelStateDictionaryExtensions.ApplyValidationException(Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary,Definux.Emeraude.Application.Exceptions.ValidationException,System.Boolean)')
  - [GetValidationErrors(modelState)](#M-Definux-Emeraude-Presentation-Extensions-ModelStateDictionaryExtensions-GetValidationErrors-Microsoft-AspNetCore-Mvc-ModelBinding-ModelStateDictionary- 'Definux.Emeraude.Presentation.Extensions.ModelStateDictionaryExtensions.GetValidationErrors(Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary)')
- [PublicController](#T-Definux-Emeraude-Presentation-Controllers-PublicController 'Definux.Emeraude.Presentation.Controllers.PublicController')
  - [CurrentLanguageProvider](#P-Definux-Emeraude-Presentation-Controllers-PublicController-CurrentLanguageProvider 'Definux.Emeraude.Presentation.Controllers.PublicController.CurrentLanguageProvider')
  - [CurrentUserProvider](#P-Definux-Emeraude-Presentation-Controllers-PublicController-CurrentUserProvider 'Definux.Emeraude.Presentation.Controllers.PublicController.CurrentUserProvider')
  - [DisableActivityLog](#P-Definux-Emeraude-Presentation-Controllers-PublicController-DisableActivityLog 'Definux.Emeraude.Presentation.Controllers.PublicController.DisableActivityLog')
  - [HideActivityLogParameters](#P-Definux-Emeraude-Presentation-Controllers-PublicController-HideActivityLogParameters 'Definux.Emeraude.Presentation.Controllers.PublicController.HideActivityLogParameters')
  - [IgnoreMaintenanceMode](#P-Definux-Emeraude-Presentation-Controllers-PublicController-IgnoreMaintenanceMode 'Definux.Emeraude.Presentation.Controllers.PublicController.IgnoreMaintenanceMode')
  - [Localizer](#P-Definux-Emeraude-Presentation-Controllers-PublicController-Localizer 'Definux.Emeraude.Presentation.Controllers.PublicController.Localizer')
  - [Logger](#P-Definux-Emeraude-Presentation-Controllers-PublicController-Logger 'Definux.Emeraude.Presentation.Controllers.PublicController.Logger')
  - [Mediator](#P-Definux-Emeraude-Presentation-Controllers-PublicController-Mediator 'Definux.Emeraude.Presentation.Controllers.PublicController.Mediator')
  - [Options](#P-Definux-Emeraude-Presentation-Controllers-PublicController-Options 'Definux.Emeraude.Presentation.Controllers.PublicController.Options')
  - [UserManager](#P-Definux-Emeraude-Presentation-Controllers-PublicController-UserManager 'Definux.Emeraude.Presentation.Controllers.PublicController.UserManager')
  - [AddTranslatedValueIntoViewData(key,value)](#M-Definux-Emeraude-Presentation-Controllers-PublicController-AddTranslatedValueIntoViewData-System-String,System-String- 'Definux.Emeraude.Presentation.Controllers.PublicController.AddTranslatedValueIntoViewData(System.String,System.String)')
  - [GetBooleanRouteParameterOrNull(name)](#M-Definux-Emeraude-Presentation-Controllers-PublicController-GetBooleanRouteParameterOrNull-System-String- 'Definux.Emeraude.Presentation.Controllers.PublicController.GetBooleanRouteParameterOrNull(System.String)')
  - [GetGuidRouteParameterOrNull(name)](#M-Definux-Emeraude-Presentation-Controllers-PublicController-GetGuidRouteParameterOrNull-System-String- 'Definux.Emeraude.Presentation.Controllers.PublicController.GetGuidRouteParameterOrNull(System.String)')
  - [GetInt32RouteParameterOrNull(name)](#M-Definux-Emeraude-Presentation-Controllers-PublicController-GetInt32RouteParameterOrNull-System-String- 'Definux.Emeraude.Presentation.Controllers.PublicController.GetInt32RouteParameterOrNull(System.String)')
  - [GetInt64RouteParameterOrNull(name)](#M-Definux-Emeraude-Presentation-Controllers-PublicController-GetInt64RouteParameterOrNull-System-String- 'Definux.Emeraude.Presentation.Controllers.PublicController.GetInt64RouteParameterOrNull(System.String)')
  - [GetLanguageRoute(route)](#M-Definux-Emeraude-Presentation-Controllers-PublicController-GetLanguageRoute-System-String- 'Definux.Emeraude.Presentation.Controllers.PublicController.GetLanguageRoute(System.String)')
  - [GetLanguageRouteAsync(route)](#M-Definux-Emeraude-Presentation-Controllers-PublicController-GetLanguageRouteAsync-System-String- 'Definux.Emeraude.Presentation.Controllers.PublicController.GetLanguageRouteAsync(System.String)')
  - [GetRouteParameterOrNull(name)](#M-Definux-Emeraude-Presentation-Controllers-PublicController-GetRouteParameterOrNull-System-String- 'Definux.Emeraude.Presentation.Controllers.PublicController.GetRouteParameterOrNull(System.String)')
  - [GetStringRouteParameterOrNull(name)](#M-Definux-Emeraude-Presentation-Controllers-PublicController-GetStringRouteParameterOrNull-System-String- 'Definux.Emeraude.Presentation.Controllers.PublicController.GetStringRouteParameterOrNull(System.String)')
  - [LanguageLocalRedirect(localUrl)](#M-Definux-Emeraude-Presentation-Controllers-PublicController-LanguageLocalRedirect-System-String- 'Definux.Emeraude.Presentation.Controllers.PublicController.LanguageLocalRedirect(System.String)')
  - [LanguageLocalRedirectAsync(localUrl)](#M-Definux-Emeraude-Presentation-Controllers-PublicController-LanguageLocalRedirectAsync-System-String- 'Definux.Emeraude.Presentation.Controllers.PublicController.LanguageLocalRedirectAsync(System.String)')
  - [ManageLanguageCookie()](#M-Definux-Emeraude-Presentation-Controllers-PublicController-ManageLanguageCookie 'Definux.Emeraude.Presentation.Controllers.PublicController.ManageLanguageCookie')
  - [OnActionExecuting()](#M-Definux-Emeraude-Presentation-Controllers-PublicController-OnActionExecuting-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext- 'Definux.Emeraude.Presentation.Controllers.PublicController.OnActionExecuting(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext)')
  - [OnActionExecutionAsync()](#M-Definux-Emeraude-Presentation-Controllers-PublicController-OnActionExecutionAsync-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext,Microsoft-AspNetCore-Mvc-Filters-ActionExecutionDelegate- 'Definux.Emeraude.Presentation.Controllers.PublicController.OnActionExecutionAsync(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext,Microsoft.AspNetCore.Mvc.Filters.ActionExecutionDelegate)')

<a name='T-Definux-Emeraude-Presentation-Controllers-ApiController'></a>
## ApiController `type`

##### Namespace

Definux.Emeraude.Presentation.Controllers

##### Summary

Abstract class for creating API controllers.

<a name='P-Definux-Emeraude-Presentation-Controllers-ApiController-DisableActivityLog'></a>
### DisableActivityLog `property`

##### Summary

Flag that activate and disable activity logging by Emeraude logger.

<a name='P-Definux-Emeraude-Presentation-Controllers-ApiController-HideActivityLogParameters'></a>
### HideActivityLogParameters `property`

##### Summary

Flag that hide or show the request params in activity log.

<a name='P-Definux-Emeraude-Presentation-Controllers-ApiController-Logger'></a>
### Logger `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Presentation-Controllers-ApiController-Mediator'></a>
### Mediator `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Presentation-Controllers-ApiController-GetSimpleResponse-System-Boolean-'></a>
### GetSimpleResponse(success) `method`

##### Summary

Get HTTP OK response with [SimpleResult](#T-Definux-Utilities-Objects-SimpleResult 'Definux.Utilities.Objects.SimpleResult').

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| success | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='M-Definux-Emeraude-Presentation-Controllers-ApiController-GetSuccessResponse-System-Boolean-'></a>
### GetSuccessResponse(success) `method`

##### Summary

Get HTTP default OK or Bad request response based on the passed flag.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| success | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='M-Definux-Emeraude-Presentation-Controllers-ApiController-OnActionExecuting-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext-'></a>
### OnActionExecuting() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Presentation-Extensions-ControllerExtensions'></a>
## ControllerExtensions `type`

##### Namespace

Definux.Emeraude.Presentation.Extensions

##### Summary

Extensions for [Controller](#T-Microsoft-AspNetCore-Mvc-Controller 'Microsoft.AspNetCore.Mvc.Controller').

<a name='M-Definux-Emeraude-Presentation-Extensions-ControllerExtensions-BadRequestWithModelErrors-Microsoft-AspNetCore-Mvc-Controller-'></a>
### BadRequestWithModelErrors(controller) `method`

##### Summary

Bad request with model errors as response.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| controller | [Microsoft.AspNetCore.Mvc.Controller](#T-Microsoft-AspNetCore-Mvc-Controller 'Microsoft.AspNetCore.Mvc.Controller') |  |

<a name='M-Definux-Emeraude-Presentation-Extensions-ControllerExtensions-UploadFileResponse-Microsoft-AspNetCore-Mvc-Controller,Definux-Emeraude-Application-Requests-Files-Commands-Shared-UploadResult-'></a>
### UploadFileResponse(controller,result) `method`

##### Summary

Action result based on upload result.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| controller | [Microsoft.AspNetCore.Mvc.Controller](#T-Microsoft-AspNetCore-Mvc-Controller 'Microsoft.AspNetCore.Mvc.Controller') |  |
| result | [Definux.Emeraude.Application.Requests.Files.Commands.Shared.UploadResult](#T-Definux-Emeraude-Application-Requests-Files-Commands-Shared-UploadResult 'Definux.Emeraude.Application.Requests.Files.Commands.Shared.UploadResult') |  |

<a name='T-Definux-Emeraude-Presentation-Controllers-IChildController'></a>
## IChildController `type`

##### Namespace

Definux.Emeraude.Presentation.Controllers

##### Summary

Definition for controller that must be tolerated as a child one for another controller.

<a name='P-Definux-Emeraude-Presentation-Controllers-IChildController-ParentController'></a>
### ParentController `property`

##### Summary

Parent controller of the current one.

<a name='T-Definux-Emeraude-Presentation-Extensions-ModelStateDictionaryExtensions'></a>
## ModelStateDictionaryExtensions `type`

##### Namespace

Definux.Emeraude.Presentation.Extensions

##### Summary

Extensions for [ModelStateDictionary](#T-Microsoft-AspNetCore-Mvc-ModelBinding-ModelStateDictionary 'Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary').

<a name='M-Definux-Emeraude-Presentation-Extensions-ModelStateDictionaryExtensions-ApplyValidationException-Microsoft-AspNetCore-Mvc-ModelBinding-ModelStateDictionary,Definux-Emeraude-Application-Exceptions-ValidationException,System-Boolean-'></a>
### ApplyValidationException(modelState,exception,skipTranslationKey) `method`

##### Summary

Apply validation exceptions to current model state.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| modelState | [Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary](#T-Microsoft-AspNetCore-Mvc-ModelBinding-ModelStateDictionary 'Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary') |  |
| exception | [Definux.Emeraude.Application.Exceptions.ValidationException](#T-Definux-Emeraude-Application-Exceptions-ValidationException 'Definux.Emeraude.Application.Exceptions.ValidationException') |  |
| skipTranslationKey | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='M-Definux-Emeraude-Presentation-Extensions-ModelStateDictionaryExtensions-GetValidationErrors-Microsoft-AspNetCore-Mvc-ModelBinding-ModelStateDictionary-'></a>
### GetValidationErrors(modelState) `method`

##### Summary

Get list of validation errors.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| modelState | [Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary](#T-Microsoft-AspNetCore-Mvc-ModelBinding-ModelStateDictionary 'Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary') |  |

<a name='T-Definux-Emeraude-Presentation-Controllers-PublicController'></a>
## PublicController `type`

##### Namespace

Definux.Emeraude.Presentation.Controllers

##### Summary

Abstraction for controllers which will be used on the client side of the application (not for the administration).

<a name='P-Definux-Emeraude-Presentation-Controllers-PublicController-CurrentLanguageProvider'></a>
### CurrentLanguageProvider `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Presentation-Controllers-PublicController-CurrentUserProvider'></a>
### CurrentUserProvider `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Presentation-Controllers-PublicController-DisableActivityLog'></a>
### DisableActivityLog `property`

##### Summary

Flag that activate and disable activity logging by Emeraude logger.

<a name='P-Definux-Emeraude-Presentation-Controllers-PublicController-HideActivityLogParameters'></a>
### HideActivityLogParameters `property`

##### Summary

Flag that hide or show the request params in activity log.

<a name='P-Definux-Emeraude-Presentation-Controllers-PublicController-IgnoreMaintenanceMode'></a>
### IgnoreMaintenanceMode `property`

##### Summary

Ignore [MaintenanceMode](#P-Definux-Emeraude-Configuration-Options-EmOptions-MaintenanceMode 'Definux.Emeraude.Configuration.Options.EmOptions.MaintenanceMode') from the Emeraude options.

<a name='P-Definux-Emeraude-Presentation-Controllers-PublicController-Localizer'></a>
### Localizer `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Presentation-Controllers-PublicController-Logger'></a>
### Logger `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Presentation-Controllers-PublicController-Mediator'></a>
### Mediator `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Presentation-Controllers-PublicController-Options'></a>
### Options `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Presentation-Controllers-PublicController-UserManager'></a>
### UserManager `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Presentation-Controllers-PublicController-AddTranslatedValueIntoViewData-System-String,System-String-'></a>
### AddTranslatedValueIntoViewData(key,value) `method`

##### Summary

Add a value (translation key) into the ViewData.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Translation key. |

<a name='M-Definux-Emeraude-Presentation-Controllers-PublicController-GetBooleanRouteParameterOrNull-System-String-'></a>
### GetBooleanRouteParameterOrNull(name) `method`

##### Summary

Get route parameter as boolean or null.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Presentation-Controllers-PublicController-GetGuidRouteParameterOrNull-System-String-'></a>
### GetGuidRouteParameterOrNull(name) `method`

##### Summary

Get route parameter as GUID or null.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Presentation-Controllers-PublicController-GetInt32RouteParameterOrNull-System-String-'></a>
### GetInt32RouteParameterOrNull(name) `method`

##### Summary

Get route parameter as integer or null.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Presentation-Controllers-PublicController-GetInt64RouteParameterOrNull-System-String-'></a>
### GetInt64RouteParameterOrNull(name) `method`

##### Summary

Get route parameter as long or null.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Presentation-Controllers-PublicController-GetLanguageRoute-System-String-'></a>
### GetLanguageRoute(route) `method`

##### Summary

Get route with language code at the beginning based on current language.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| route | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Presentation-Controllers-PublicController-GetLanguageRouteAsync-System-String-'></a>
### GetLanguageRouteAsync(route) `method`

##### Summary

Get route with language code (async extraction) at the beginning based on current language.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| route | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Presentation-Controllers-PublicController-GetRouteParameterOrNull-System-String-'></a>
### GetRouteParameterOrNull(name) `method`

##### Summary

Get route parameter or null.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Presentation-Controllers-PublicController-GetStringRouteParameterOrNull-System-String-'></a>
### GetStringRouteParameterOrNull(name) `method`

##### Summary

Get route parameter as string or null.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Presentation-Controllers-PublicController-LanguageLocalRedirect-System-String-'></a>
### LanguageLocalRedirect(localUrl) `method`

##### Summary

Redirect to local url merged with current language code.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| localUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Presentation-Controllers-PublicController-LanguageLocalRedirectAsync-System-String-'></a>
### LanguageLocalRedirectAsync(localUrl) `method`

##### Summary

Redirect to local url merged with current language code (async extraction).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| localUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Presentation-Controllers-PublicController-ManageLanguageCookie'></a>
### ManageLanguageCookie() `method`

##### Summary

Process current language and set language cookie in the client's browser.

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Presentation-Controllers-PublicController-OnActionExecuting-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext-'></a>
### OnActionExecuting() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Presentation-Controllers-PublicController-OnActionExecutionAsync-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext,Microsoft-AspNetCore-Mvc-Filters-ActionExecutionDelegate-'></a>
### OnActionExecutionAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.
