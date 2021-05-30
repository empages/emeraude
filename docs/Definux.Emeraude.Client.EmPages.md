<a name='assembly'></a>
# Definux.Emeraude.Client.EmPages

## Contents

- [EmLanguageRouteAttribute](#T-Definux-Emeraude-Client-EmPages-Attributes-EmLanguageRouteAttribute 'Definux.Emeraude.Client.EmPages.Attributes.EmLanguageRouteAttribute')
  - [#ctor()](#M-Definux-Emeraude-Client-EmPages-Attributes-EmLanguageRouteAttribute-#ctor 'Definux.Emeraude.Client.EmPages.Attributes.EmLanguageRouteAttribute.#ctor')
  - [Name](#P-Definux-Emeraude-Client-EmPages-Attributes-EmLanguageRouteAttribute-Name 'Definux.Emeraude.Client.EmPages.Attributes.EmLanguageRouteAttribute.Name')
  - [Order](#P-Definux-Emeraude-Client-EmPages-Attributes-EmLanguageRouteAttribute-Order 'Definux.Emeraude.Client.EmPages.Attributes.EmLanguageRouteAttribute.Order')
  - [Template](#P-Definux-Emeraude-Client-EmPages-Attributes-EmLanguageRouteAttribute-Template 'Definux.Emeraude.Client.EmPages.Attributes.EmLanguageRouteAttribute.Template')
- [EmPageRenderer](#T-Definux-Emeraude-Client-EmPages-Renderer-EmPageRenderer 'Definux.Emeraude.Client.EmPages.Renderer.EmPageRenderer')
  - [RenderToString(applicationBasePath,nodeServices,applicationStoppingToken,serverBundlePath,httpContext,customDataParameter,timeoutMilliseconds)](#M-Definux-Emeraude-Client-EmPages-Renderer-EmPageRenderer-RenderToString-System-String,Microsoft-AspNetCore-NodeServices-INodeServices,System-Threading-CancellationToken,System-String,Microsoft-AspNetCore-Http-HttpContext,System-Object,System-Int32- 'Definux.Emeraude.Client.EmPages.Renderer.EmPageRenderer.RenderToString(System.String,Microsoft.AspNetCore.NodeServices.INodeServices,System.Threading.CancellationToken,System.String,Microsoft.AspNetCore.Http.HttpContext,System.Object,System.Int32)')
- [EmPageRendererTagHelper](#T-Definux-Emeraude-Client-EmPages-Renderer-EmPageRendererTagHelper 'Definux.Emeraude.Client.EmPages.Renderer.EmPageRendererTagHelper')
  - [#ctor(serviceProvider,logger)](#M-Definux-Emeraude-Client-EmPages-Renderer-EmPageRendererTagHelper-#ctor-System-IServiceProvider,Definux-Emeraude-Application-Logger-IEmLogger- 'Definux.Emeraude.Client.EmPages.Renderer.EmPageRendererTagHelper.#ctor(System.IServiceProvider,Definux.Emeraude.Application.Logger.IEmLogger)')
  - [ActivateEmeraude](#P-Definux-Emeraude-Client-EmPages-Renderer-EmPageRendererTagHelper-ActivateEmeraude 'Definux.Emeraude.Client.EmPages.Renderer.EmPageRendererTagHelper.ActivateEmeraude')
  - [InitialStateViewModel](#P-Definux-Emeraude-Client-EmPages-Renderer-EmPageRendererTagHelper-InitialStateViewModel 'Definux.Emeraude.Client.EmPages.Renderer.EmPageRendererTagHelper.InitialStateViewModel')
  - [ServerBundle](#P-Definux-Emeraude-Client-EmPages-Renderer-EmPageRendererTagHelper-ServerBundle 'Definux.Emeraude.Client.EmPages.Renderer.EmPageRendererTagHelper.ServerBundle')
  - [TimeoutMillisecondsParameter](#P-Definux-Emeraude-Client-EmPages-Renderer-EmPageRendererTagHelper-TimeoutMillisecondsParameter 'Definux.Emeraude.Client.EmPages.Renderer.EmPageRendererTagHelper.TimeoutMillisecondsParameter')
  - [ViewContext](#P-Definux-Emeraude-Client-EmPages-Renderer-EmPageRendererTagHelper-ViewContext 'Definux.Emeraude.Client.EmPages.Renderer.EmPageRendererTagHelper.ViewContext')
  - [ProcessAsync()](#M-Definux-Emeraude-Client-EmPages-Renderer-EmPageRendererTagHelper-ProcessAsync-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput- 'Definux.Emeraude.Client.EmPages.Renderer.EmPageRendererTagHelper.ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput)')
- [EmPageSitemapPattern](#T-Definux-Emeraude-Client-EmPages-Abstractions-EmPageSitemapPattern 'Definux.Emeraude.Client.EmPages.Abstractions.EmPageSitemapPattern')
  - [#ctor(template,languageStore)](#M-Definux-Emeraude-Client-EmPages-Abstractions-EmPageSitemapPattern-#ctor-System-String,Definux-Emeraude-Application-Localization-ILanguageStore- 'Definux.Emeraude.Client.EmPages.Abstractions.EmPageSitemapPattern.#ctor(System.String,Definux.Emeraude.Application.Localization.ILanguageStore)')
- [EmPage\`2](#T-Definux-Emeraude-Client-EmPages-Abstractions-EmPage`2 'Definux.Emeraude.Client.EmPages.Abstractions.EmPage`2')
  - [InitialStateModel](#P-Definux-Emeraude-Client-EmPages-Abstractions-EmPage`2-InitialStateModel 'Definux.Emeraude.Client.EmPages.Abstractions.EmPage`2.InitialStateModel')
  - [InitialStateRequest](#P-Definux-Emeraude-Client-EmPages-Abstractions-EmPage`2-InitialStateRequest 'Definux.Emeraude.Client.EmPages.Abstractions.EmPage`2.InitialStateRequest')
  - [ViewModel](#P-Definux-Emeraude-Client-EmPages-Abstractions-EmPage`2-ViewModel 'Definux.Emeraude.Client.EmPages.Abstractions.EmPage`2.ViewModel')
  - [BuildInitialStateModel()](#M-Definux-Emeraude-Client-EmPages-Abstractions-EmPage`2-BuildInitialStateModel 'Definux.Emeraude.Client.EmPages.Abstractions.EmPage`2.BuildInitialStateModel')
  - [CreateInitialStateModelAsync(dataQuery)](#M-Definux-Emeraude-Client-EmPages-Abstractions-EmPage`2-CreateInitialStateModelAsync-MediatR-IRequest{`0}- 'Definux.Emeraude.Client.EmPages.Abstractions.EmPage`2.CreateInitialStateModelAsync(MediatR.IRequest{`0})')
  - [EmPageView(model)](#M-Definux-Emeraude-Client-EmPages-Abstractions-EmPage`2-EmPageView-Definux-Emeraude-Client-EmPages-Models-InitialStateModel{`0}- 'Definux.Emeraude.Client.EmPages.Abstractions.EmPage`2.EmPageView(Definux.Emeraude.Client.EmPages.Models.InitialStateModel{`0})')
  - [Index()](#M-Definux-Emeraude-Client-EmPages-Abstractions-EmPage`2-Index 'Definux.Emeraude.Client.EmPages.Abstractions.EmPage`2.Index')
  - [InitializeMetaTagsAsync(model,disableDefaultDecoratedTags)](#M-Definux-Emeraude-Client-EmPages-Abstractions-EmPage`2-InitializeMetaTagsAsync-Definux-Emeraude-Client-EmPages-Models-InitialStateModel{`0},System-Boolean- 'Definux.Emeraude.Client.EmPages.Abstractions.EmPage`2.InitializeMetaTagsAsync(Definux.Emeraude.Client.EmPages.Models.InitialStateModel{`0},System.Boolean)')
  - [InitializeViewDataAsync(model)](#M-Definux-Emeraude-Client-EmPages-Abstractions-EmPage`2-InitializeViewDataAsync-Definux-Emeraude-Client-EmPages-Models-InitialStateModel{`0}- 'Definux.Emeraude.Client.EmPages.Abstractions.EmPage`2.InitializeViewDataAsync(Definux.Emeraude.Client.EmPages.Models.InitialStateModel{`0})')
  - [RequestInitialState()](#M-Definux-Emeraude-Client-EmPages-Abstractions-EmPage`2-RequestInitialState 'Definux.Emeraude.Client.EmPages.Abstractions.EmPage`2.RequestInitialState')
- [EmPagesConstants](#T-Definux-Emeraude-Client-EmPages-EmPagesConstants 'Definux.Emeraude.Client.EmPages.EmPagesConstants')
  - [PageMetaTagDescriptionKey](#F-Definux-Emeraude-Client-EmPages-EmPagesConstants-PageMetaTagDescriptionKey 'Definux.Emeraude.Client.EmPages.EmPagesConstants.PageMetaTagDescriptionKey')
  - [PageMetaTagTitleKey](#F-Definux-Emeraude-Client-EmPages-EmPagesConstants-PageMetaTagTitleKey 'Definux.Emeraude.Client.EmPages.EmPagesConstants.PageMetaTagTitleKey')
- [EmPagesRouteConvention](#T-Definux-Emeraude-Client-EmPages-Conventions-EmPagesRouteConvention 'Definux.Emeraude.Client.EmPages.Conventions.EmPagesRouteConvention')
  - [Apply()](#M-Definux-Emeraude-Client-EmPages-Conventions-EmPagesRouteConvention-Apply-Microsoft-AspNetCore-Mvc-ApplicationModels-ApplicationModel- 'Definux.Emeraude.Client.EmPages.Conventions.EmPagesRouteConvention.Apply(Microsoft.AspNetCore.Mvc.ApplicationModels.ApplicationModel)')
- [EmReadOnlyAttribute](#T-Definux-Emeraude-Client-EmPages-Attributes-EmReadOnlyAttribute 'Definux.Emeraude.Client.EmPages.Attributes.EmReadOnlyAttribute')
- [EmRouteAttribute](#T-Definux-Emeraude-Client-EmPages-Attributes-EmRouteAttribute 'Definux.Emeraude.Client.EmPages.Attributes.EmRouteAttribute')
  - [#ctor(template)](#M-Definux-Emeraude-Client-EmPages-Attributes-EmRouteAttribute-#ctor-System-String- 'Definux.Emeraude.Client.EmPages.Attributes.EmRouteAttribute.#ctor(System.String)')
  - [#ctor()](#M-Definux-Emeraude-Client-EmPages-Attributes-EmRouteAttribute-#ctor 'Definux.Emeraude.Client.EmPages.Attributes.EmRouteAttribute.#ctor')
  - [Name](#P-Definux-Emeraude-Client-EmPages-Attributes-EmRouteAttribute-Name 'Definux.Emeraude.Client.EmPages.Attributes.EmRouteAttribute.Name')
  - [Order](#P-Definux-Emeraude-Client-EmPages-Attributes-EmRouteAttribute-Order 'Definux.Emeraude.Client.EmPages.Attributes.EmRouteAttribute.Order')
  - [Template](#P-Definux-Emeraude-Client-EmPages-Attributes-EmRouteAttribute-Template 'Definux.Emeraude.Client.EmPages.Attributes.EmRouteAttribute.Template')
- [IEmPage](#T-Definux-Emeraude-Client-EmPages-Abstractions-IEmPage 'Definux.Emeraude.Client.EmPages.Abstractions.IEmPage')
- [IEmViewModel](#T-Definux-Emeraude-Client-EmPages-Models-IEmViewModel 'Definux.Emeraude.Client.EmPages.Models.IEmViewModel')
- [IInitialState](#T-Definux-Emeraude-Client-EmPages-Models-IInitialState 'Definux.Emeraude.Client.EmPages.Models.IInitialState')
- [IInitialStateModel\`1](#T-Definux-Emeraude-Client-EmPages-Models-IInitialStateModel`1 'Definux.Emeraude.Client.EmPages.Models.IInitialStateModel`1')
  - [LanguageCode](#P-Definux-Emeraude-Client-EmPages-Models-IInitialStateModel`1-LanguageCode 'Definux.Emeraude.Client.EmPages.Models.IInitialStateModel`1.LanguageCode')
  - [LanguageId](#P-Definux-Emeraude-Client-EmPages-Models-IInitialStateModel`1-LanguageId 'Definux.Emeraude.Client.EmPages.Models.IInitialStateModel`1.LanguageId')
  - [MetaTags](#P-Definux-Emeraude-Client-EmPages-Models-IInitialStateModel`1-MetaTags 'Definux.Emeraude.Client.EmPages.Models.IInitialStateModel`1.MetaTags')
  - [RouteName](#P-Definux-Emeraude-Client-EmPages-Models-IInitialStateModel`1-RouteName 'Definux.Emeraude.Client.EmPages.Models.IInitialStateModel`1.RouteName')
  - [StateString](#P-Definux-Emeraude-Client-EmPages-Models-IInitialStateModel`1-StateString 'Definux.Emeraude.Client.EmPages.Models.IInitialStateModel`1.StateString')
  - [User](#P-Definux-Emeraude-Client-EmPages-Models-IInitialStateModel`1-User 'Definux.Emeraude.Client.EmPages.Models.IInitialStateModel`1.User')
  - [ViewData](#P-Definux-Emeraude-Client-EmPages-Models-IInitialStateModel`1-ViewData 'Definux.Emeraude.Client.EmPages.Models.IInitialStateModel`1.ViewData')
  - [ViewModel](#P-Definux-Emeraude-Client-EmPages-Models-IInitialStateModel`1-ViewModel 'Definux.Emeraude.Client.EmPages.Models.IInitialStateModel`1.ViewModel')
  - [AddViewDataItem(key,value)](#M-Definux-Emeraude-Client-EmPages-Models-IInitialStateModel`1-AddViewDataItem-System-String,System-Object- 'Definux.Emeraude.Client.EmPages.Models.IInitialStateModel`1.AddViewDataItem(System.String,System.Object)')
- [InitialStateModel\`1](#T-Definux-Emeraude-Client-EmPages-Models-InitialStateModel`1 'Definux.Emeraude.Client.EmPages.Models.InitialStateModel`1')
  - [#ctor(routeName)](#M-Definux-Emeraude-Client-EmPages-Models-InitialStateModel`1-#ctor-System-String- 'Definux.Emeraude.Client.EmPages.Models.InitialStateModel`1.#ctor(System.String)')
  - [LanguageCode](#P-Definux-Emeraude-Client-EmPages-Models-InitialStateModel`1-LanguageCode 'Definux.Emeraude.Client.EmPages.Models.InitialStateModel`1.LanguageCode')
  - [LanguageId](#P-Definux-Emeraude-Client-EmPages-Models-InitialStateModel`1-LanguageId 'Definux.Emeraude.Client.EmPages.Models.InitialStateModel`1.LanguageId')
  - [MetaTags](#P-Definux-Emeraude-Client-EmPages-Models-InitialStateModel`1-MetaTags 'Definux.Emeraude.Client.EmPages.Models.InitialStateModel`1.MetaTags')
  - [RouteName](#P-Definux-Emeraude-Client-EmPages-Models-InitialStateModel`1-RouteName 'Definux.Emeraude.Client.EmPages.Models.InitialStateModel`1.RouteName')
  - [StateString](#P-Definux-Emeraude-Client-EmPages-Models-InitialStateModel`1-StateString 'Definux.Emeraude.Client.EmPages.Models.InitialStateModel`1.StateString')
  - [User](#P-Definux-Emeraude-Client-EmPages-Models-InitialStateModel`1-User 'Definux.Emeraude.Client.EmPages.Models.InitialStateModel`1.User')
  - [ViewData](#P-Definux-Emeraude-Client-EmPages-Models-InitialStateModel`1-ViewData 'Definux.Emeraude.Client.EmPages.Models.InitialStateModel`1.ViewData')
  - [ViewModel](#P-Definux-Emeraude-Client-EmPages-Models-InitialStateModel`1-ViewModel 'Definux.Emeraude.Client.EmPages.Models.InitialStateModel`1.ViewModel')
  - [AddViewDataItem()](#M-Definux-Emeraude-Client-EmPages-Models-InitialStateModel`1-AddViewDataItem-System-String,System-Object- 'Definux.Emeraude.Client.EmPages.Models.InitialStateModel`1.AddViewDataItem(System.String,System.Object)')
- [RenderToStringResult](#T-Definux-Emeraude-Client-EmPages-Renderer-RenderToStringResult 'Definux.Emeraude.Client.EmPages.Renderer.RenderToStringResult')
  - [Globals](#P-Definux-Emeraude-Client-EmPages-Renderer-RenderToStringResult-Globals 'Definux.Emeraude.Client.EmPages.Renderer.RenderToStringResult.Globals')
  - [Html](#P-Definux-Emeraude-Client-EmPages-Renderer-RenderToStringResult-Html 'Definux.Emeraude.Client.EmPages.Renderer.RenderToStringResult.Html')
  - [RedirectUrl](#P-Definux-Emeraude-Client-EmPages-Renderer-RenderToStringResult-RedirectUrl 'Definux.Emeraude.Client.EmPages.Renderer.RenderToStringResult.RedirectUrl')
  - [StatusCode](#P-Definux-Emeraude-Client-EmPages-Renderer-RenderToStringResult-StatusCode 'Definux.Emeraude.Client.EmPages.Renderer.RenderToStringResult.StatusCode')
  - [CreateGlobalsAssignmentScript()](#M-Definux-Emeraude-Client-EmPages-Renderer-RenderToStringResult-CreateGlobalsAssignmentScript 'Definux.Emeraude.Client.EmPages.Renderer.RenderToStringResult.CreateGlobalsAssignmentScript')
- [RequestUser](#T-Definux-Emeraude-Client-EmPages-Models-RequestUser 'Definux.Emeraude.Client.EmPages.Models.RequestUser')
  - [Email](#P-Definux-Emeraude-Client-EmPages-Models-RequestUser-Email 'Definux.Emeraude.Client.EmPages.Models.RequestUser.Email')
  - [IsAuthenticated](#P-Definux-Emeraude-Client-EmPages-Models-RequestUser-IsAuthenticated 'Definux.Emeraude.Client.EmPages.Models.RequestUser.IsAuthenticated')
  - [Name](#P-Definux-Emeraude-Client-EmPages-Models-RequestUser-Name 'Definux.Emeraude.Client.EmPages.Models.RequestUser.Name')
  - [Roles](#P-Definux-Emeraude-Client-EmPages-Models-RequestUser-Roles 'Definux.Emeraude.Client.EmPages.Models.RequestUser.Roles')
- [ServiceCollectionExtensions](#T-Definux-Emeraude-Client-EmPages-Extensions-ServiceCollectionExtensions 'Definux.Emeraude.Client.EmPages.Extensions.ServiceCollectionExtensions')
  - [RegisterEmPages(services)](#M-Definux-Emeraude-Client-EmPages-Extensions-ServiceCollectionExtensions-RegisterEmPages-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Definux.Emeraude.Client.EmPages.Extensions.ServiceCollectionExtensions.RegisterEmPages(Microsoft.Extensions.DependencyInjection.IServiceCollection)')

<a name='T-Definux-Emeraude-Client-EmPages-Attributes-EmLanguageRouteAttribute'></a>
## EmLanguageRouteAttribute `type`

##### Namespace

Definux.Emeraude.Client.EmPages.Attributes

##### Summary

Defines language SEO friendly route based on language code (not default language).
Example for English Language with code 'en': '/items/1' map route '/en/items/1'.
Provides string variable 'languageCode' contains current request language code.

<a name='M-Definux-Emeraude-Client-EmPages-Attributes-EmLanguageRouteAttribute-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [EmLanguageRouteAttribute](#T-Definux-Emeraude-Client-EmPages-Attributes-EmLanguageRouteAttribute 'Definux.Emeraude.Client.EmPages.Attributes.EmLanguageRouteAttribute') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Client-EmPages-Attributes-EmLanguageRouteAttribute-Name'></a>
### Name `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Client-EmPages-Attributes-EmLanguageRouteAttribute-Order'></a>
### Order `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Client-EmPages-Attributes-EmLanguageRouteAttribute-Template'></a>
### Template `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Client-EmPages-Renderer-EmPageRenderer'></a>
## EmPageRenderer `type`

##### Namespace

Definux.Emeraude.Client.EmPages.Renderer

##### Summary

Performs server-side Vue app prerendering by invoking code in Node.js.

<a name='M-Definux-Emeraude-Client-EmPages-Renderer-EmPageRenderer-RenderToString-System-String,Microsoft-AspNetCore-NodeServices-INodeServices,System-Threading-CancellationToken,System-String,Microsoft-AspNetCore-Http-HttpContext,System-Object,System-Int32-'></a>
### RenderToString(applicationBasePath,nodeServices,applicationStoppingToken,serverBundlePath,httpContext,customDataParameter,timeoutMilliseconds) `method`

##### Summary

Performs server-side EmPage prerendering by invoking code in Node.js.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| applicationBasePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| nodeServices | [Microsoft.AspNetCore.NodeServices.INodeServices](#T-Microsoft-AspNetCore-NodeServices-INodeServices 'Microsoft.AspNetCore.NodeServices.INodeServices') |  |
| applicationStoppingToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |  |
| serverBundlePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| httpContext | [Microsoft.AspNetCore.Http.HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') |  |
| customDataParameter | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| timeoutMilliseconds | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='T-Definux-Emeraude-Client-EmPages-Renderer-EmPageRendererTagHelper'></a>
## EmPageRendererTagHelper `type`

##### Namespace

Definux.Emeraude.Client.EmPages.Renderer

##### Summary

EmPage Vue server-side rendering tag helper which prerender the Vue application by the server bundle and initial state model.

<a name='M-Definux-Emeraude-Client-EmPages-Renderer-EmPageRendererTagHelper-#ctor-System-IServiceProvider,Definux-Emeraude-Application-Logger-IEmLogger-'></a>
### #ctor(serviceProvider,logger) `constructor`

##### Summary

Initializes a new instance of the [EmPageRendererTagHelper](#T-Definux-Emeraude-Client-EmPages-Renderer-EmPageRendererTagHelper 'Definux.Emeraude.Client.EmPages.Renderer.EmPageRendererTagHelper') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceProvider | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |

<a name='P-Definux-Emeraude-Client-EmPages-Renderer-EmPageRendererTagHelper-ActivateEmeraude'></a>
### ActivateEmeraude `property`

##### Summary

Flag that indicates Emeraude app initialization.

<a name='P-Definux-Emeraude-Client-EmPages-Renderer-EmPageRendererTagHelper-InitialStateViewModel'></a>
### InitialStateViewModel `property`

##### Summary

The initial state model parameter that will be applied into the application store state.

<a name='P-Definux-Emeraude-Client-EmPages-Renderer-EmPageRendererTagHelper-ServerBundle'></a>
### ServerBundle `property`

##### Summary

Specifies the path to the built application server bundle.

<a name='P-Definux-Emeraude-Client-EmPages-Renderer-EmPageRendererTagHelper-TimeoutMillisecondsParameter'></a>
### TimeoutMillisecondsParameter `property`

##### Summary

The maximum duration to wait for prerendering to complete.

<a name='P-Definux-Emeraude-Client-EmPages-Renderer-EmPageRendererTagHelper-ViewContext'></a>
### ViewContext `property`

##### Summary

The [ViewContext](#P-Definux-Emeraude-Client-EmPages-Renderer-EmPageRendererTagHelper-ViewContext 'Definux.Emeraude.Client.EmPages.Renderer.EmPageRendererTagHelper.ViewContext').

<a name='M-Definux-Emeraude-Client-EmPages-Renderer-EmPageRendererTagHelper-ProcessAsync-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput-'></a>
### ProcessAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Client-EmPages-Abstractions-EmPageSitemapPattern'></a>
## EmPageSitemapPattern `type`

##### Namespace

Definux.Emeraude.Client.EmPages.Abstractions

##### Summary

Abstract class that implements the [PageSitemapPattern](#T-Definux-Seo-Models-PageSitemapPattern 'Definux.Seo.Models.PageSitemapPattern') for the purposes of EmPages.

<a name='M-Definux-Emeraude-Client-EmPages-Abstractions-EmPageSitemapPattern-#ctor-System-String,Definux-Emeraude-Application-Localization-ILanguageStore-'></a>
### #ctor(template,languageStore) `constructor`

##### Summary

Initializes a new instance of the [EmPageSitemapPattern](#T-Definux-Emeraude-Client-EmPages-Abstractions-EmPageSitemapPattern 'Definux.Emeraude.Client.EmPages.Abstractions.EmPageSitemapPattern') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| template | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| languageStore | [Definux.Emeraude.Application.Localization.ILanguageStore](#T-Definux-Emeraude-Application-Localization-ILanguageStore 'Definux.Emeraude.Application.Localization.ILanguageStore') |  |

<a name='T-Definux-Emeraude-Client-EmPages-Abstractions-EmPage`2'></a>
## EmPage\`2 `type`

##### Namespace

Definux.Emeraude.Client.EmPages.Abstractions

##### Summary

EmPage parent class that initialize a ASP.NET Core MVC page related with Vue.js page with custom predefined initial state.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TViewModel | Type of the returning data transfer object (ViewModel). |
| TRequest | Request that compute and return the ViewModel. |

<a name='P-Definux-Emeraude-Client-EmPages-Abstractions-EmPage`2-InitialStateModel'></a>
### InitialStateModel `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Client-EmPages-Abstractions-EmPage`2-InitialStateRequest'></a>
### InitialStateRequest `property`

##### Summary

Request that compute and return the [ViewModel](#P-Definux-Emeraude-Client-EmPages-Abstractions-EmPage`2-ViewModel 'Definux.Emeraude.Client.EmPages.Abstractions.EmPage`2.ViewModel').

<a name='P-Definux-Emeraude-Client-EmPages-Abstractions-EmPage`2-ViewModel'></a>
### ViewModel `property`

##### Summary

Data transfer object for pass strong-typed data to the initial state of the page.

<a name='M-Definux-Emeraude-Client-EmPages-Abstractions-EmPage`2-BuildInitialStateModel'></a>
### BuildInitialStateModel() `method`

##### Summary

Method that contains the implementation of creation of initial state model. It is usefull if you want to pass some routing data to the page ViewModel request.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Client-EmPages-Abstractions-EmPage`2-CreateInitialStateModelAsync-MediatR-IRequest{`0}-'></a>
### CreateInitialStateModelAsync(dataQuery) `method`

##### Summary

Method that create the initial state model - the customized data + all generic data. Overriding is not recommended.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataQuery | [MediatR.IRequest{\`0}](#T-MediatR-IRequest{`0} 'MediatR.IRequest{`0}') |  |

<a name='M-Definux-Emeraude-Client-EmPages-Abstractions-EmPage`2-EmPageView-Definux-Emeraude-Client-EmPages-Models-InitialStateModel{`0}-'></a>
### EmPageView(model) `method`

##### Summary

Method that returns the action result of the EmPage. To work properly the existance of Views/Client/Shared/EmPages/Index.cshtml is a must.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [Definux.Emeraude.Client.EmPages.Models.InitialStateModel{\`0}](#T-Definux-Emeraude-Client-EmPages-Models-InitialStateModel{`0} 'Definux.Emeraude.Client.EmPages.Models.InitialStateModel{`0}') |  |

<a name='M-Definux-Emeraude-Client-EmPages-Abstractions-EmPage`2-Index'></a>
### Index() `method`

##### Summary

GET request that returns the [EmPageView](#M-Definux-Emeraude-Client-EmPages-Abstractions-EmPage`2-EmPageView-Definux-Emeraude-Client-EmPages-Models-InitialStateModel{`0}- 'Definux.Emeraude.Client.EmPages.Abstractions.EmPage`2.EmPageView(Definux.Emeraude.Client.EmPages.Models.InitialStateModel{`0})') with the page initial state.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Client-EmPages-Abstractions-EmPage`2-InitializeMetaTagsAsync-Definux-Emeraude-Client-EmPages-Models-InitialStateModel{`0},System-Boolean-'></a>
### InitializeMetaTagsAsync(model,disableDefaultDecoratedTags) `method`

##### Summary

This method initialize the meta tags properties definition for current initial state of the current page.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [Definux.Emeraude.Client.EmPages.Models.InitialStateModel{\`0}](#T-Definux-Emeraude-Client-EmPages-Models-InitialStateModel{`0} 'Definux.Emeraude.Client.EmPages.Models.InitialStateModel{`0}') |  |
| disableDefaultDecoratedTags | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Disable default decorated meta tags for the parent controller. |

<a name='M-Definux-Emeraude-Client-EmPages-Abstractions-EmPage`2-InitializeViewDataAsync-Definux-Emeraude-Client-EmPages-Models-InitialStateModel{`0}-'></a>
### InitializeViewDataAsync(model) `method`

##### Summary

This method initializes the key-value pair used as view data for the initial state after the page view model is computed but before the page sending action result to the view.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [Definux.Emeraude.Client.EmPages.Models.InitialStateModel{\`0}](#T-Definux-Emeraude-Client-EmPages-Models-InitialStateModel{`0} 'Definux.Emeraude.Client.EmPages.Models.InitialStateModel{`0}') |  |

<a name='M-Definux-Emeraude-Client-EmPages-Abstractions-EmPage`2-RequestInitialState'></a>
### RequestInitialState() `method`

##### Summary

POST request for the page initial state without HTML rendering.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Client-EmPages-EmPagesConstants'></a>
## EmPagesConstants `type`

##### Namespace

Definux.Emeraude.Client.EmPages

##### Summary

Constants used into EmPages context.

<a name='F-Definux-Emeraude-Client-EmPages-EmPagesConstants-PageMetaTagDescriptionKey'></a>
### PageMetaTagDescriptionKey `constants`

##### Summary

Default page meta description key.

<a name='F-Definux-Emeraude-Client-EmPages-EmPagesConstants-PageMetaTagTitleKey'></a>
### PageMetaTagTitleKey `constants`

##### Summary

Default page meta title key.

<a name='T-Definux-Emeraude-Client-EmPages-Conventions-EmPagesRouteConvention'></a>
## EmPagesRouteConvention `type`

##### Namespace

Definux.Emeraude.Client.EmPages.Conventions

##### Summary

An implementation of [IApplicationModelConvention](#T-Microsoft-AspNetCore-Mvc-ApplicationModels-IApplicationModelConvention 'Microsoft.AspNetCore.Mvc.ApplicationModels.IApplicationModelConvention') for configure and validate EmPages routings.

<a name='M-Definux-Emeraude-Client-EmPages-Conventions-EmPagesRouteConvention-Apply-Microsoft-AspNetCore-Mvc-ApplicationModels-ApplicationModel-'></a>
### Apply() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Client-EmPages-Attributes-EmReadOnlyAttribute'></a>
## EmReadOnlyAttribute `type`

##### Namespace

Definux.Emeraude.Client.EmPages.Attributes

##### Summary

Emeraude specific attribute that decorates the property to be read only.

<a name='T-Definux-Emeraude-Client-EmPages-Attributes-EmRouteAttribute'></a>
## EmRouteAttribute `type`

##### Namespace

Definux.Emeraude.Client.EmPages.Attributes

##### Summary

Defines the route of current EmPage.

<a name='M-Definux-Emeraude-Client-EmPages-Attributes-EmRouteAttribute-#ctor-System-String-'></a>
### #ctor(template) `constructor`

##### Summary

Initializes a new instance of the [EmRouteAttribute](#T-Definux-Emeraude-Client-EmPages-Attributes-EmRouteAttribute 'Definux.Emeraude.Client.EmPages.Attributes.EmRouteAttribute') class.
Set up the page route.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| template | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Client-EmPages-Attributes-EmRouteAttribute-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [EmRouteAttribute](#T-Definux-Emeraude-Client-EmPages-Attributes-EmRouteAttribute 'Definux.Emeraude.Client.EmPages.Attributes.EmRouteAttribute') class.
Set up the page as home page for the system.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Client-EmPages-Attributes-EmRouteAttribute-Name'></a>
### Name `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Client-EmPages-Attributes-EmRouteAttribute-Order'></a>
### Order `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Client-EmPages-Attributes-EmRouteAttribute-Template'></a>
### Template `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Client-EmPages-Abstractions-IEmPage'></a>
## IEmPage `type`

##### Namespace

Definux.Emeraude.Client.EmPages.Abstractions

##### Summary

Definition of EmPage.

<a name='T-Definux-Emeraude-Client-EmPages-Models-IEmViewModel'></a>
## IEmViewModel `type`

##### Namespace

Definux.Emeraude.Client.EmPages.Models

##### Summary

Simple definition for EmPage view model.

<a name='T-Definux-Emeraude-Client-EmPages-Models-IInitialState'></a>
## IInitialState `type`

##### Namespace

Definux.Emeraude.Client.EmPages.Models

##### Summary

Definition of EmPage initial state.

<a name='T-Definux-Emeraude-Client-EmPages-Models-IInitialStateModel`1'></a>
## IInitialStateModel\`1 `type`

##### Namespace

Definux.Emeraude.Client.EmPages.Models

##### Summary

Model for definition of data transfer object container from the back-end to the front-end initial state.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TViewModel | Data transfer object that contains the custom strong-typed data for the page. |

<a name='P-Definux-Emeraude-Client-EmPages-Models-IInitialStateModel`1-LanguageCode'></a>
### LanguageCode `property`

##### Summary

Code of the language extracted from the accessed route.

<a name='P-Definux-Emeraude-Client-EmPages-Models-IInitialStateModel`1-LanguageId'></a>
### LanguageId `property`

##### Summary

Id of the language extracted from the accessed route.

<a name='P-Definux-Emeraude-Client-EmPages-Models-IInitialStateModel`1-MetaTags'></a>
### MetaTags `property`

##### Summary

Defines an collection of properties for HTML meta tags for better SEO.

<a name='P-Definux-Emeraude-Client-EmPages-Models-IInitialStateModel`1-RouteName'></a>
### RouteName `property`

##### Summary

Name of the accessed route. It is recommended to match with the name of the page.

<a name='P-Definux-Emeraude-Client-EmPages-Models-IInitialStateModel`1-StateString'></a>
### StateString `property`

##### Summary

Random string (GUID format) that represents the current request.

<a name='P-Definux-Emeraude-Client-EmPages-Models-IInitialStateModel`1-User'></a>
### User `property`

##### Summary

Identity user extracted from the request. For more information see [RequestUser](#T-Definux-Emeraude-Client-EmPages-Models-RequestUser 'Definux.Emeraude.Client.EmPages.Models.RequestUser').

<a name='P-Definux-Emeraude-Client-EmPages-Models-IInitialStateModel`1-ViewData'></a>
### ViewData `property`

##### Summary

Data transfer object that contains the custom non strong-typed data for the page. For strong-typed data see [ViewModel](#P-Definux-Emeraude-Client-EmPages-Models-IInitialStateModel`1-ViewModel 'Definux.Emeraude.Client.EmPages.Models.IInitialStateModel`1.ViewModel').

<a name='P-Definux-Emeraude-Client-EmPages-Models-IInitialStateModel`1-ViewModel'></a>
### ViewModel `property`

##### Summary

Data transfer object that contains the custom strong-typed data for the page. For non strong-typed data see [ViewData](#P-Definux-Emeraude-Client-EmPages-Models-IInitialStateModel`1-ViewData 'Definux.Emeraude.Client.EmPages.Models.IInitialStateModel`1.ViewData').

<a name='M-Definux-Emeraude-Client-EmPages-Models-IInitialStateModel`1-AddViewDataItem-System-String,System-Object-'></a>
### AddViewDataItem(key,value) `method`

##### Summary

Method that add a new key/value pair to the [ViewData](#P-Definux-Emeraude-Client-EmPages-Models-IInitialStateModel`1-ViewData 'Definux.Emeraude.Client.EmPages.Models.IInitialStateModel`1.ViewData').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |

<a name='T-Definux-Emeraude-Client-EmPages-Models-InitialStateModel`1'></a>
## InitialStateModel\`1 `type`

##### Namespace

Definux.Emeraude.Client.EmPages.Models

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Client-EmPages-Models-InitialStateModel`1-#ctor-System-String-'></a>
### #ctor(routeName) `constructor`

##### Summary

Initializes a new instance of the [InitialStateModel\`1](#T-Definux-Emeraude-Client-EmPages-Models-InitialStateModel`1 'Definux.Emeraude.Client.EmPages.Models.InitialStateModel`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| routeName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='P-Definux-Emeraude-Client-EmPages-Models-InitialStateModel`1-LanguageCode'></a>
### LanguageCode `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Client-EmPages-Models-InitialStateModel`1-LanguageId'></a>
### LanguageId `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Client-EmPages-Models-InitialStateModel`1-MetaTags'></a>
### MetaTags `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Client-EmPages-Models-InitialStateModel`1-RouteName'></a>
### RouteName `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Client-EmPages-Models-InitialStateModel`1-StateString'></a>
### StateString `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Client-EmPages-Models-InitialStateModel`1-User'></a>
### User `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Client-EmPages-Models-InitialStateModel`1-ViewData'></a>
### ViewData `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Client-EmPages-Models-InitialStateModel`1-ViewModel'></a>
### ViewModel `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Client-EmPages-Models-InitialStateModel`1-AddViewDataItem-System-String,System-Object-'></a>
### AddViewDataItem() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Client-EmPages-Renderer-RenderToStringResult'></a>
## RenderToStringResult `type`

##### Namespace

Definux.Emeraude.Client.EmPages.Renderer

##### Summary

Describes the prerendering result returned by JavaScript code.

<a name='P-Definux-Emeraude-Client-EmPages-Renderer-RenderToStringResult-Globals'></a>
### Globals `property`

##### Summary

If set, specifies JSON-serializable data that should be added as a set of global JavaScript variables in the document.
This can be used to transfer arbitrary data from server-side prerendering code to client-side code (for example, to
transfer the state of a Redux store).

<a name='P-Definux-Emeraude-Client-EmPages-Renderer-RenderToStringResult-Html'></a>
### Html `property`

##### Summary

The HTML generated by the prerendering logic.

<a name='P-Definux-Emeraude-Client-EmPages-Renderer-RenderToStringResult-RedirectUrl'></a>
### RedirectUrl `property`

##### Summary

If set, specifies that instead of rendering HTML, the response should be an HTTP redirection to this URL.
This can be used if the prerendering code determines that the requested URL would lead to a redirection according
to the SPA's routing configuration.

<a name='P-Definux-Emeraude-Client-EmPages-Renderer-RenderToStringResult-StatusCode'></a>
### StatusCode `property`

##### Summary

If set, specifies the HTTP status code that should be sent back with the server response.

<a name='M-Definux-Emeraude-Client-EmPages-Renderer-RenderToStringResult-CreateGlobalsAssignmentScript'></a>
### CreateGlobalsAssignmentScript() `method`

##### Summary

Constructs a block of JavaScript code that assigns data from the
[Globals](#P-Definux-Emeraude-Client-EmPages-Renderer-RenderToStringResult-Globals 'Definux.Emeraude.Client.EmPages.Renderer.RenderToStringResult.Globals') property to the global namespace.

##### Returns

A block of JavaScript code.

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Client-EmPages-Models-RequestUser'></a>
## RequestUser `type`

##### Namespace

Definux.Emeraude.Client.EmPages.Models

##### Summary

Encapsulated class that contains information about the identity user for the current request.

<a name='P-Definux-Emeraude-Client-EmPages-Models-RequestUser-Email'></a>
### Email `property`

##### Summary

Email address of the user.

<a name='P-Definux-Emeraude-Client-EmPages-Models-RequestUser-IsAuthenticated'></a>
### IsAuthenticated `property`

##### Summary

Flag that indicates whether user is authenticated or not.

<a name='P-Definux-Emeraude-Client-EmPages-Models-RequestUser-Name'></a>
### Name `property`

##### Summary

Full name of the user.

<a name='P-Definux-Emeraude-Client-EmPages-Models-RequestUser-Roles'></a>
### Roles `property`

##### Summary

Array with the roles of the user.

<a name='T-Definux-Emeraude-Client-EmPages-Extensions-ServiceCollectionExtensions'></a>
## ServiceCollectionExtensions `type`

##### Namespace

Definux.Emeraude.Client.EmPages.Extensions

##### Summary

Extensions for [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection').

<a name='M-Definux-Emeraude-Client-EmPages-Extensions-ServiceCollectionExtensions-RegisterEmPages-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### RegisterEmPages(services) `method`

##### Summary

Register EmPages required services.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |
