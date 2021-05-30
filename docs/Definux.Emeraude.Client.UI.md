<a name='assembly'></a>
# Definux.Emeraude.Client.UI

## Contents

- [ClientUIAssemblyPart](#T-Definux-Emeraude-Client-UI-ClientUIAssemblyPart 'Definux.Emeraude.Client.UI.ClientUIAssemblyPart')
  - [Assembly](#P-Definux-Emeraude-Client-UI-ClientUIAssemblyPart-Assembly 'Definux.Emeraude.Client.UI.ClientUIAssemblyPart.Assembly')
  - [AssemblyPart](#P-Definux-Emeraude-Client-UI-ClientUIAssemblyPart-AssemblyPart 'Definux.Emeraude.Client.UI.ClientUIAssemblyPart.AssemblyPart')
- [ClientUIConfigureOptions](#T-Definux-Emeraude-Client-UI-ClientUIConfigureOptions 'Definux.Emeraude.Client.UI.ClientUIConfigureOptions')
  - [#ctor(environment)](#M-Definux-Emeraude-Client-UI-ClientUIConfigureOptions-#ctor-Microsoft-AspNetCore-Hosting-IHostingEnvironment- 'Definux.Emeraude.Client.UI.ClientUIConfigureOptions.#ctor(Microsoft.AspNetCore.Hosting.IHostingEnvironment)')
- [HtmlHelperExtensions](#T-Definux-Emeraude-Client-UI-Extensions-HtmlHelperExtensions 'Definux.Emeraude.Client.UI.Extensions.HtmlHelperExtensions')
  - [HasNonModelError(htmlHelper)](#M-Definux-Emeraude-Client-UI-Extensions-HtmlHelperExtensions-HasNonModelError-Microsoft-AspNetCore-Mvc-Rendering-IHtmlHelper- 'Definux.Emeraude.Client.UI.Extensions.HtmlHelperExtensions.HasNonModelError(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper)')
  - [NonModelError(htmlHelper)](#M-Definux-Emeraude-Client-UI-Extensions-HtmlHelperExtensions-NonModelError-Microsoft-AspNetCore-Mvc-Rendering-IHtmlHelper- 'Definux.Emeraude.Client.UI.Extensions.HtmlHelperExtensions.NonModelError(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper)')
- [IExternalAuthenticationProvidersCollection](#T-Definux-Emeraude-Client-UI-Adapters-IExternalAuthenticationProvidersCollection 'Definux.Emeraude.Client.UI.Adapters.IExternalAuthenticationProvidersCollection')
  - [ExternalProviders](#P-Definux-Emeraude-Client-UI-Adapters-IExternalAuthenticationProvidersCollection-ExternalProviders 'Definux.Emeraude.Client.UI.Adapters.IExternalAuthenticationProvidersCollection.ExternalProviders')
- [IndexViewModel](#T-Definux-Emeraude-Client-UI-ViewModels-ExecutionResult-IndexViewModel 'Definux.Emeraude.Client.UI.ViewModels.ExecutionResult.IndexViewModel')
  - [Message](#P-Definux-Emeraude-Client-UI-ViewModels-ExecutionResult-IndexViewModel-Message 'Definux.Emeraude.Client.UI.ViewModels.ExecutionResult.IndexViewModel.Message')
  - [Reference](#P-Definux-Emeraude-Client-UI-ViewModels-ExecutionResult-IndexViewModel-Reference 'Definux.Emeraude.Client.UI.ViewModels.ExecutionResult.IndexViewModel.Reference')
  - [Succeeded](#P-Definux-Emeraude-Client-UI-ViewModels-ExecutionResult-IndexViewModel-Succeeded 'Definux.Emeraude.Client.UI.ViewModels.ExecutionResult.IndexViewModel.Succeeded')
  - [Title](#P-Definux-Emeraude-Client-UI-ViewModels-ExecutionResult-IndexViewModel-Title 'Definux.Emeraude.Client.UI.ViewModels.ExecutionResult.IndexViewModel.Title')
- [PredefinedViewMessageModel](#T-Definux-Emeraude-Client-UI-Helpers-PredefinedViewMessageModel 'Definux.Emeraude.Client.UI.Helpers.PredefinedViewMessageModel')
  - [#ctor(targetView,documentationLink)](#M-Definux-Emeraude-Client-UI-Helpers-PredefinedViewMessageModel-#ctor-System-String,System-String- 'Definux.Emeraude.Client.UI.Helpers.PredefinedViewMessageModel.#ctor(System.String,System.String)')
  - [DocumentationLink](#P-Definux-Emeraude-Client-UI-Helpers-PredefinedViewMessageModel-DocumentationLink 'Definux.Emeraude.Client.UI.Helpers.PredefinedViewMessageModel.DocumentationLink')
  - [TargetView](#P-Definux-Emeraude-Client-UI-Helpers-PredefinedViewMessageModel-TargetView 'Definux.Emeraude.Client.UI.Helpers.PredefinedViewMessageModel.TargetView')
- [ServiceCollectionExtensions](#T-Definux-Emeraude-Client-UI-Extensions-ServiceCollectionExtensions 'Definux.Emeraude.Client.UI.Extensions.ServiceCollectionExtensions')
  - [ConfigureClientUI(services)](#M-Definux-Emeraude-Client-UI-Extensions-ServiceCollectionExtensions-ConfigureClientUI-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Definux.Emeraude.Client.UI.Extensions.ServiceCollectionExtensions.ConfigureClientUI(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
- [StaticContentTagHelper](#T-Definux-Emeraude-Client-UI-TagHelpers-StaticContentTagHelper 'Definux.Emeraude.Client.UI.TagHelpers.StaticContentTagHelper')
  - [#ctor(localizer)](#M-Definux-Emeraude-Client-UI-TagHelpers-StaticContentTagHelper-#ctor-Definux-Emeraude-Interfaces-Services-ILocalizer- 'Definux.Emeraude.Client.UI.TagHelpers.StaticContentTagHelper.#ctor(Definux.Emeraude.Interfaces.Services.ILocalizer)')
  - [ProcessOutput()](#M-Definux-Emeraude-Client-UI-TagHelpers-StaticContentTagHelper-ProcessOutput-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput- 'Definux.Emeraude.Client.UI.TagHelpers.StaticContentTagHelper.ProcessOutput(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput)')
- [TranslationTagHelper](#T-Definux-Emeraude-Client-UI-TagHelpers-TranslationTagHelper 'Definux.Emeraude.Client.UI.TagHelpers.TranslationTagHelper')
  - [#ctor(localizer)](#M-Definux-Emeraude-Client-UI-TagHelpers-TranslationTagHelper-#ctor-Definux-Emeraude-Interfaces-Services-ILocalizer- 'Definux.Emeraude.Client.UI.TagHelpers.TranslationTagHelper.#ctor(Definux.Emeraude.Interfaces.Services.ILocalizer)')
  - [Arguments](#P-Definux-Emeraude-Client-UI-TagHelpers-TranslationTagHelper-Arguments 'Definux.Emeraude.Client.UI.TagHelpers.TranslationTagHelper.Arguments')
  - [ArgumentsDelimiterEnd](#P-Definux-Emeraude-Client-UI-TagHelpers-TranslationTagHelper-ArgumentsDelimiterEnd 'Definux.Emeraude.Client.UI.TagHelpers.TranslationTagHelper.ArgumentsDelimiterEnd')
  - [ArgumentsDelimiterStart](#P-Definux-Emeraude-Client-UI-TagHelpers-TranslationTagHelper-ArgumentsDelimiterStart 'Definux.Emeraude.Client.UI.TagHelpers.TranslationTagHelper.ArgumentsDelimiterStart')
  - [Element](#P-Definux-Emeraude-Client-UI-TagHelpers-TranslationTagHelper-Element 'Definux.Emeraude.Client.UI.TagHelpers.TranslationTagHelper.Element')
  - [Localizer](#P-Definux-Emeraude-Client-UI-TagHelpers-TranslationTagHelper-Localizer 'Definux.Emeraude.Client.UI.TagHelpers.TranslationTagHelper.Localizer')
  - [StripHtml](#P-Definux-Emeraude-Client-UI-TagHelpers-TranslationTagHelper-StripHtml 'Definux.Emeraude.Client.UI.TagHelpers.TranslationTagHelper.StripHtml')
  - [ViewContext](#P-Definux-Emeraude-Client-UI-TagHelpers-TranslationTagHelper-ViewContext 'Definux.Emeraude.Client.UI.TagHelpers.TranslationTagHelper.ViewContext')
  - [ApplyArguments(input)](#M-Definux-Emeraude-Client-UI-TagHelpers-TranslationTagHelper-ApplyArguments-System-String- 'Definux.Emeraude.Client.UI.TagHelpers.TranslationTagHelper.ApplyArguments(System.String)')
  - [Process()](#M-Definux-Emeraude-Client-UI-TagHelpers-TranslationTagHelper-Process-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput- 'Definux.Emeraude.Client.UI.TagHelpers.TranslationTagHelper.Process(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput)')
  - [ProcessOutput(output)](#M-Definux-Emeraude-Client-UI-TagHelpers-TranslationTagHelper-ProcessOutput-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput- 'Definux.Emeraude.Client.UI.TagHelpers.TranslationTagHelper.ProcessOutput(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput)')
  - [StripHtmlTags(input)](#M-Definux-Emeraude-Client-UI-TagHelpers-TranslationTagHelper-StripHtmlTags-System-String- 'Definux.Emeraude.Client.UI.TagHelpers.TranslationTagHelper.StripHtmlTags(System.String)')
- [UrlHelperExtensions](#T-Definux-Emeraude-Client-UI-Extensions-UrlHelperExtensions 'Definux.Emeraude.Client.UI.Extensions.UrlHelperExtensions')
  - [AuthenticationControllerName](#F-Definux-Emeraude-Client-UI-Extensions-UrlHelperExtensions-AuthenticationControllerName 'Definux.Emeraude.Client.UI.Extensions.UrlHelperExtensions.AuthenticationControllerName')
  - [ReturnUrlKey](#F-Definux-Emeraude-Client-UI-Extensions-UrlHelperExtensions-ReturnUrlKey 'Definux.Emeraude.Client.UI.Extensions.UrlHelperExtensions.ReturnUrlKey')
  - [ExternalLoginAction(urlHelper,viewData)](#M-Definux-Emeraude-Client-UI-Extensions-UrlHelperExtensions-ExternalLoginAction-Microsoft-AspNetCore-Mvc-IUrlHelper,Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary- 'Definux.Emeraude.Client.UI.Extensions.UrlHelperExtensions.ExternalLoginAction(Microsoft.AspNetCore.Mvc.IUrlHelper,Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary)')
  - [ForgotPasswordAction(urlHelper)](#M-Definux-Emeraude-Client-UI-Extensions-UrlHelperExtensions-ForgotPasswordAction-Microsoft-AspNetCore-Mvc-IUrlHelper- 'Definux.Emeraude.Client.UI.Extensions.UrlHelperExtensions.ForgotPasswordAction(Microsoft.AspNetCore.Mvc.IUrlHelper)')
  - [GetAuthenticationControllerName(urlHelper)](#M-Definux-Emeraude-Client-UI-Extensions-UrlHelperExtensions-GetAuthenticationControllerName-Microsoft-AspNetCore-Mvc-IUrlHelper- 'Definux.Emeraude.Client.UI.Extensions.UrlHelperExtensions.GetAuthenticationControllerName(Microsoft.AspNetCore.Mvc.IUrlHelper)')
  - [IndexAction(urlHelper)](#M-Definux-Emeraude-Client-UI-Extensions-UrlHelperExtensions-IndexAction-Microsoft-AspNetCore-Mvc-IUrlHelper- 'Definux.Emeraude.Client.UI.Extensions.UrlHelperExtensions.IndexAction(Microsoft.AspNetCore.Mvc.IUrlHelper)')
  - [LanguageAction(url,action,controller,values)](#M-Definux-Emeraude-Client-UI-Extensions-UrlHelperExtensions-LanguageAction-Microsoft-AspNetCore-Mvc-IUrlHelper,System-String,System-String,System-Object- 'Definux.Emeraude.Client.UI.Extensions.UrlHelperExtensions.LanguageAction(Microsoft.AspNetCore.Mvc.IUrlHelper,System.String,System.String,System.Object)')
  - [LoginAction(urlHelper,viewData)](#M-Definux-Emeraude-Client-UI-Extensions-UrlHelperExtensions-LoginAction-Microsoft-AspNetCore-Mvc-IUrlHelper,Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary- 'Definux.Emeraude.Client.UI.Extensions.UrlHelperExtensions.LoginAction(Microsoft.AspNetCore.Mvc.IUrlHelper,Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary)')
  - [RegisterAction(urlHelper)](#M-Definux-Emeraude-Client-UI-Extensions-UrlHelperExtensions-RegisterAction-Microsoft-AspNetCore-Mvc-IUrlHelper- 'Definux.Emeraude.Client.UI.Extensions.UrlHelperExtensions.RegisterAction(Microsoft.AspNetCore.Mvc.IUrlHelper)')
  - [ResetPasswordAction(urlHelper)](#M-Definux-Emeraude-Client-UI-Extensions-UrlHelperExtensions-ResetPasswordAction-Microsoft-AspNetCore-Mvc-IUrlHelper- 'Definux.Emeraude.Client.UI.Extensions.UrlHelperExtensions.ResetPasswordAction(Microsoft.AspNetCore.Mvc.IUrlHelper)')
- [ViewDataExtensions](#T-Definux-Emeraude-Client-UI-Extensions-ViewDataExtensions 'Definux.Emeraude.Client.UI.Extensions.ViewDataExtensions')
  - [SetTitle(viewData,title)](#M-Definux-Emeraude-Client-UI-Extensions-ViewDataExtensions-SetTitle-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary,System-String- 'Definux.Emeraude.Client.UI.Extensions.ViewDataExtensions.SetTitle(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary,System.String)')

<a name='T-Definux-Emeraude-Client-UI-ClientUIAssemblyPart'></a>
## ClientUIAssemblyPart `type`

##### Namespace

Definux.Emeraude.Client.UI

##### Summary

Static class that provides access to the Client UI asembly information.

<a name='P-Definux-Emeraude-Client-UI-ClientUIAssemblyPart-Assembly'></a>
### Assembly `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Client-UI-ClientUIAssemblyPart-AssemblyPart'></a>
### AssemblyPart `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Client-UI-ClientUIConfigureOptions'></a>
## ClientUIConfigureOptions `type`

##### Namespace

Definux.Emeraude.Client.UI

##### Summary

Client UI options that configure the static files loaded in the assembly.

<a name='M-Definux-Emeraude-Client-UI-ClientUIConfigureOptions-#ctor-Microsoft-AspNetCore-Hosting-IHostingEnvironment-'></a>
### #ctor(environment) `constructor`

##### Summary

Initializes a new instance of the [ClientUIConfigureOptions](#T-Definux-Emeraude-Client-UI-ClientUIConfigureOptions 'Definux.Emeraude.Client.UI.ClientUIConfigureOptions') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| environment | [Microsoft.AspNetCore.Hosting.IHostingEnvironment](#T-Microsoft-AspNetCore-Hosting-IHostingEnvironment 'Microsoft.AspNetCore.Hosting.IHostingEnvironment') |  |

<a name='T-Definux-Emeraude-Client-UI-Extensions-HtmlHelperExtensions'></a>
## HtmlHelperExtensions `type`

##### Namespace

Definux.Emeraude.Client.UI.Extensions

##### Summary

Extensions for [IHtmlHelper](#T-Microsoft-AspNetCore-Mvc-Rendering-IHtmlHelper 'Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper').

<a name='M-Definux-Emeraude-Client-UI-Extensions-HtmlHelperExtensions-HasNonModelError-Microsoft-AspNetCore-Mvc-Rendering-IHtmlHelper-'></a>
### HasNonModelError(htmlHelper) `method`

##### Summary

Check for existance of model state errors related with no specific property.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| htmlHelper | [Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper](#T-Microsoft-AspNetCore-Mvc-Rendering-IHtmlHelper 'Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper') |  |

<a name='M-Definux-Emeraude-Client-UI-Extensions-HtmlHelperExtensions-NonModelError-Microsoft-AspNetCore-Mvc-Rendering-IHtmlHelper-'></a>
### NonModelError(htmlHelper) `method`

##### Summary

Gives the first model state error related with no specific property.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| htmlHelper | [Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper](#T-Microsoft-AspNetCore-Mvc-Rendering-IHtmlHelper 'Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper') |  |

<a name='T-Definux-Emeraude-Client-UI-Adapters-IExternalAuthenticationProvidersCollection'></a>
## IExternalAuthenticationProvidersCollection `type`

##### Namespace

Definux.Emeraude.Client.UI.Adapters

##### Summary

Adapter provides access to a list of loaded external authentication providers.

<a name='P-Definux-Emeraude-Client-UI-Adapters-IExternalAuthenticationProvidersCollection-ExternalProviders'></a>
### ExternalProviders `property`

##### Summary

Collection of external providers names.

<a name='T-Definux-Emeraude-Client-UI-ViewModels-ExecutionResult-IndexViewModel'></a>
## IndexViewModel `type`

##### Namespace

Definux.Emeraude.Client.UI.ViewModels.ExecutionResult

##### Summary

View model for the execution result view.

<a name='P-Definux-Emeraude-Client-UI-ViewModels-ExecutionResult-IndexViewModel-Message'></a>
### Message `property`

##### Summary

Message on the page.

<a name='P-Definux-Emeraude-Client-UI-ViewModels-ExecutionResult-IndexViewModel-Reference'></a>
### Reference `property`

##### Summary

Execution reference.

<a name='P-Definux-Emeraude-Client-UI-ViewModels-ExecutionResult-IndexViewModel-Succeeded'></a>
### Succeeded `property`

##### Summary

Status of the result.

<a name='P-Definux-Emeraude-Client-UI-ViewModels-ExecutionResult-IndexViewModel-Title'></a>
### Title `property`

##### Summary

Title of the page.

<a name='T-Definux-Emeraude-Client-UI-Helpers-PredefinedViewMessageModel'></a>
## PredefinedViewMessageModel `type`

##### Namespace

Definux.Emeraude.Client.UI.Helpers

##### Summary

Model used for notification message on predefined views.

<a name='M-Definux-Emeraude-Client-UI-Helpers-PredefinedViewMessageModel-#ctor-System-String,System-String-'></a>
### #ctor(targetView,documentationLink) `constructor`

##### Summary

Initializes a new instance of the [PredefinedViewMessageModel](#T-Definux-Emeraude-Client-UI-Helpers-PredefinedViewMessageModel 'Definux.Emeraude.Client.UI.Helpers.PredefinedViewMessageModel') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| targetView | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| documentationLink | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='P-Definux-Emeraude-Client-UI-Helpers-PredefinedViewMessageModel-DocumentationLink'></a>
### DocumentationLink `property`

##### Summary

Link for documentation of current view.

<a name='P-Definux-Emeraude-Client-UI-Helpers-PredefinedViewMessageModel-TargetView'></a>
### TargetView `property`

##### Summary

Name of the view.

<a name='T-Definux-Emeraude-Client-UI-Extensions-ServiceCollectionExtensions'></a>
## ServiceCollectionExtensions `type`

##### Namespace

Definux.Emeraude.Client.UI.Extensions

##### Summary

Extensions for [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection').

<a name='M-Definux-Emeraude-Client-UI-Extensions-ServiceCollectionExtensions-ConfigureClientUI-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### ConfigureClientUI(services) `method`

##### Summary

Configure Client UI.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |

<a name='T-Definux-Emeraude-Client-UI-TagHelpers-StaticContentTagHelper'></a>
## StaticContentTagHelper `type`

##### Namespace

Definux.Emeraude.Client.UI.TagHelpers

##### Summary

Tag helper that translate a static content key (placed in the content of the tag helper) based on the language extracted from the route.

<a name='M-Definux-Emeraude-Client-UI-TagHelpers-StaticContentTagHelper-#ctor-Definux-Emeraude-Interfaces-Services-ILocalizer-'></a>
### #ctor(localizer) `constructor`

##### Summary

Initializes a new instance of the [StaticContentTagHelper](#T-Definux-Emeraude-Client-UI-TagHelpers-StaticContentTagHelper 'Definux.Emeraude.Client.UI.TagHelpers.StaticContentTagHelper') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| localizer | [Definux.Emeraude.Interfaces.Services.ILocalizer](#T-Definux-Emeraude-Interfaces-Services-ILocalizer 'Definux.Emeraude.Interfaces.Services.ILocalizer') |  |

<a name='M-Definux-Emeraude-Client-UI-TagHelpers-StaticContentTagHelper-ProcessOutput-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput-'></a>
### ProcessOutput() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Client-UI-TagHelpers-TranslationTagHelper'></a>
## TranslationTagHelper `type`

##### Namespace

Definux.Emeraude.Client.UI.TagHelpers

##### Summary

Tag helper that translate a translation key (placed in the content of the tag helper) based on the language extracted from the route.

<a name='M-Definux-Emeraude-Client-UI-TagHelpers-TranslationTagHelper-#ctor-Definux-Emeraude-Interfaces-Services-ILocalizer-'></a>
### #ctor(localizer) `constructor`

##### Summary

Initializes a new instance of the [TranslationTagHelper](#T-Definux-Emeraude-Client-UI-TagHelpers-TranslationTagHelper 'Definux.Emeraude.Client.UI.TagHelpers.TranslationTagHelper') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| localizer | [Definux.Emeraude.Interfaces.Services.ILocalizer](#T-Definux-Emeraude-Interfaces-Services-ILocalizer 'Definux.Emeraude.Interfaces.Services.ILocalizer') |  |

<a name='P-Definux-Emeraude-Client-UI-TagHelpers-TranslationTagHelper-Arguments'></a>
### Arguments `property`

##### Summary

Arguments used for the placeholders in the translation. Usage args-param="parameter".

<a name='P-Definux-Emeraude-Client-UI-TagHelpers-TranslationTagHelper-ArgumentsDelimiterEnd'></a>
### ArgumentsDelimiterEnd `property`

##### Summary

Delimiter end for arguments in the content - default value is ']]'.

<a name='P-Definux-Emeraude-Client-UI-TagHelpers-TranslationTagHelper-ArgumentsDelimiterStart'></a>
### ArgumentsDelimiterStart `property`

##### Summary

Delimiter start for arguments in the content - default value is '[['.

<a name='P-Definux-Emeraude-Client-UI-TagHelpers-TranslationTagHelper-Element'></a>
### Element `property`

##### Summary

Element used for tag helper. Default element is span.

<a name='P-Definux-Emeraude-Client-UI-TagHelpers-TranslationTagHelper-Localizer'></a>
### Localizer `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Client-UI-TagHelpers-TranslationTagHelper-StripHtml'></a>
### StripHtml `property`

##### Summary

Flag which true value remove all HTML tags from the tag helper content.

<a name='P-Definux-Emeraude-Client-UI-TagHelpers-TranslationTagHelper-ViewContext'></a>
### ViewContext `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Client-UI-TagHelpers-TranslationTagHelper-ApplyArguments-System-String-'></a>
### ApplyArguments(input) `method`

##### Summary

Apply arguments into the value.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Client-UI-TagHelpers-TranslationTagHelper-Process-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput-'></a>
### Process() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Client-UI-TagHelpers-TranslationTagHelper-ProcessOutput-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput-'></a>
### ProcessOutput(output) `method`

##### Summary

Processing method for the tag helper.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| output | [Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput](#T-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput 'Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput') |  |

<a name='M-Definux-Emeraude-Client-UI-TagHelpers-TranslationTagHelper-StripHtmlTags-System-String-'></a>
### StripHtmlTags(input) `method`

##### Summary

Remove HTML tags from the input.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Client-UI-Extensions-UrlHelperExtensions'></a>
## UrlHelperExtensions `type`

##### Namespace

Definux.Emeraude.Client.UI.Extensions

##### Summary

Extensions for [IUrlHelper](#T-Microsoft-AspNetCore-Mvc-IUrlHelper 'Microsoft.AspNetCore.Mvc.IUrlHelper').

<a name='F-Definux-Emeraude-Client-UI-Extensions-UrlHelperExtensions-AuthenticationControllerName'></a>
### AuthenticationControllerName `constants`

##### Summary

Client authentication controller name.

<a name='F-Definux-Emeraude-Client-UI-Extensions-UrlHelperExtensions-ReturnUrlKey'></a>
### ReturnUrlKey `constants`

##### Summary

Return url query param name.

<a name='M-Definux-Emeraude-Client-UI-Extensions-UrlHelperExtensions-ExternalLoginAction-Microsoft-AspNetCore-Mvc-IUrlHelper,Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary-'></a>
### ExternalLoginAction(urlHelper,viewData) `method`

##### Summary

Generates external login action URL.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| urlHelper | [Microsoft.AspNetCore.Mvc.IUrlHelper](#T-Microsoft-AspNetCore-Mvc-IUrlHelper 'Microsoft.AspNetCore.Mvc.IUrlHelper') |  |
| viewData | [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary') |  |

<a name='M-Definux-Emeraude-Client-UI-Extensions-UrlHelperExtensions-ForgotPasswordAction-Microsoft-AspNetCore-Mvc-IUrlHelper-'></a>
### ForgotPasswordAction(urlHelper) `method`

##### Summary

Generates forgot password action URL.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| urlHelper | [Microsoft.AspNetCore.Mvc.IUrlHelper](#T-Microsoft-AspNetCore-Mvc-IUrlHelper 'Microsoft.AspNetCore.Mvc.IUrlHelper') |  |

<a name='M-Definux-Emeraude-Client-UI-Extensions-UrlHelperExtensions-GetAuthenticationControllerName-Microsoft-AspNetCore-Mvc-IUrlHelper-'></a>
### GetAuthenticationControllerName(urlHelper) `method`

##### Summary

Get the client authentication controller name.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| urlHelper | [Microsoft.AspNetCore.Mvc.IUrlHelper](#T-Microsoft-AspNetCore-Mvc-IUrlHelper 'Microsoft.AspNetCore.Mvc.IUrlHelper') |  |

<a name='M-Definux-Emeraude-Client-UI-Extensions-UrlHelperExtensions-IndexAction-Microsoft-AspNetCore-Mvc-IUrlHelper-'></a>
### IndexAction(urlHelper) `method`

##### Summary

Generates index action URL (Index action from HomeController).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| urlHelper | [Microsoft.AspNetCore.Mvc.IUrlHelper](#T-Microsoft-AspNetCore-Mvc-IUrlHelper 'Microsoft.AspNetCore.Mvc.IUrlHelper') |  |

<a name='M-Definux-Emeraude-Client-UI-Extensions-UrlHelperExtensions-LanguageAction-Microsoft-AspNetCore-Mvc-IUrlHelper,System-String,System-String,System-Object-'></a>
### LanguageAction(url,action,controller,values) `method`

##### Summary

Get transformed route with language code of the current language in case when the current language is not the default one.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Microsoft.AspNetCore.Mvc.IUrlHelper](#T-Microsoft-AspNetCore-Mvc-IUrlHelper 'Microsoft.AspNetCore.Mvc.IUrlHelper') |  |
| action | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| controller | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| values | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |

<a name='M-Definux-Emeraude-Client-UI-Extensions-UrlHelperExtensions-LoginAction-Microsoft-AspNetCore-Mvc-IUrlHelper,Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary-'></a>
### LoginAction(urlHelper,viewData) `method`

##### Summary

Generates login action URL.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| urlHelper | [Microsoft.AspNetCore.Mvc.IUrlHelper](#T-Microsoft-AspNetCore-Mvc-IUrlHelper 'Microsoft.AspNetCore.Mvc.IUrlHelper') |  |
| viewData | [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary') |  |

<a name='M-Definux-Emeraude-Client-UI-Extensions-UrlHelperExtensions-RegisterAction-Microsoft-AspNetCore-Mvc-IUrlHelper-'></a>
### RegisterAction(urlHelper) `method`

##### Summary

Generates register action URL.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| urlHelper | [Microsoft.AspNetCore.Mvc.IUrlHelper](#T-Microsoft-AspNetCore-Mvc-IUrlHelper 'Microsoft.AspNetCore.Mvc.IUrlHelper') |  |

<a name='M-Definux-Emeraude-Client-UI-Extensions-UrlHelperExtensions-ResetPasswordAction-Microsoft-AspNetCore-Mvc-IUrlHelper-'></a>
### ResetPasswordAction(urlHelper) `method`

##### Summary

Generates reset password action URL.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| urlHelper | [Microsoft.AspNetCore.Mvc.IUrlHelper](#T-Microsoft-AspNetCore-Mvc-IUrlHelper 'Microsoft.AspNetCore.Mvc.IUrlHelper') |  |

<a name='T-Definux-Emeraude-Client-UI-Extensions-ViewDataExtensions'></a>
## ViewDataExtensions `type`

##### Namespace

Definux.Emeraude.Client.UI.Extensions

##### Summary

Extensions for [ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary').

<a name='M-Definux-Emeraude-Client-UI-Extensions-ViewDataExtensions-SetTitle-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary,System-String-'></a>
### SetTitle(viewData,title) `method`

##### Summary

Set title to the ViewData.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewData | [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary') |  |
| title | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
