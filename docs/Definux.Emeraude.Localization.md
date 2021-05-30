<a name='assembly'></a>
# Definux.Emeraude.Localization

## Contents

- [AssemblyInfo](#T-Definux-Emeraude-Localization-AssemblyInfo 'Definux.Emeraude.Localization.AssemblyInfo')
  - [GetAssembly()](#M-Definux-Emeraude-Localization-AssemblyInfo-GetAssembly 'Definux.Emeraude.Localization.AssemblyInfo.GetAssembly')
- [ContentKeyConfiguration](#T-Definux-Emeraude-Localization-Configuration-ContentKeyConfiguration 'Definux.Emeraude.Localization.Configuration.ContentKeyConfiguration')
  - [Configure()](#M-Definux-Emeraude-Localization-Configuration-ContentKeyConfiguration-Configure-Microsoft-EntityFrameworkCore-Metadata-Builders-EntityTypeBuilder{Definux-Emeraude-Domain-Localization-ContentKey}- 'Definux.Emeraude.Localization.Configuration.ContentKeyConfiguration.Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder{Definux.Emeraude.Domain.Localization.ContentKey})')
- [ControllerExtensions](#T-Definux-Emeraude-Localization-Extensions-ControllerExtensions 'Definux.Emeraude.Localization.Extensions.ControllerExtensions')
  - [GetRouteWithAppliedLanguage(controller,route,language)](#M-Definux-Emeraude-Localization-Extensions-ControllerExtensions-GetRouteWithAppliedLanguage-Microsoft-AspNetCore-Mvc-Controller,System-String,Definux-Emeraude-Domain-Localization-Language- 'Definux.Emeraude.Localization.Extensions.ControllerExtensions.GetRouteWithAppliedLanguage(Microsoft.AspNetCore.Mvc.Controller,System.String,Definux.Emeraude.Domain.Localization.Language)')
- [CurrentLanguageProvider](#T-Definux-Emeraude-Localization-Services-CurrentLanguageProvider 'Definux.Emeraude.Localization.Services.CurrentLanguageProvider')
  - [#ctor(context,httpAccessor)](#M-Definux-Emeraude-Localization-Services-CurrentLanguageProvider-#ctor-Definux-Emeraude-Application-Localization-ILocalizationContext,Microsoft-AspNetCore-Http-IHttpContextAccessor- 'Definux.Emeraude.Localization.Services.CurrentLanguageProvider.#ctor(Definux.Emeraude.Application.Localization.ILocalizationContext,Microsoft.AspNetCore.Http.IHttpContextAccessor)')
  - [GetCurrentLanguage()](#M-Definux-Emeraude-Localization-Services-CurrentLanguageProvider-GetCurrentLanguage 'Definux.Emeraude.Localization.Services.CurrentLanguageProvider.GetCurrentLanguage')
  - [GetCurrentLanguageAsync()](#M-Definux-Emeraude-Localization-Services-CurrentLanguageProvider-GetCurrentLanguageAsync 'Definux.Emeraude.Localization.Services.CurrentLanguageProvider.GetCurrentLanguageAsync')
- [HttpContextExtensions](#T-Definux-Emeraude-Localization-Extensions-HttpContextExtensions 'Definux.Emeraude.Localization.Extensions.HttpContextExtensions')
  - [GetLanguageCode(httpContext)](#M-Definux-Emeraude-Localization-Extensions-HttpContextExtensions-GetLanguageCode-Microsoft-AspNetCore-Http-HttpContext- 'Definux.Emeraude.Localization.Extensions.HttpContextExtensions.GetLanguageCode(Microsoft.AspNetCore.Http.HttpContext)')
- [Init](#T-Definux-Emeraude-Localization-Migrations-Init 'Definux.Emeraude.Localization.Migrations.Init')
  - [BuildTargetModel()](#M-Definux-Emeraude-Localization-Migrations-Init-BuildTargetModel-Microsoft-EntityFrameworkCore-ModelBuilder- 'Definux.Emeraude.Localization.Migrations.Init.BuildTargetModel(Microsoft.EntityFrameworkCore.ModelBuilder)')
  - [Down()](#M-Definux-Emeraude-Localization-Migrations-Init-Down-Microsoft-EntityFrameworkCore-Migrations-MigrationBuilder- 'Definux.Emeraude.Localization.Migrations.Init.Down(Microsoft.EntityFrameworkCore.Migrations.MigrationBuilder)')
  - [Up()](#M-Definux-Emeraude-Localization-Migrations-Init-Up-Microsoft-EntityFrameworkCore-Migrations-MigrationBuilder- 'Definux.Emeraude.Localization.Migrations.Init.Up(Microsoft.EntityFrameworkCore.Migrations.MigrationBuilder)')
- [LanguageConfiguration](#T-Definux-Emeraude-Localization-Configuration-LanguageConfiguration 'Definux.Emeraude.Localization.Configuration.LanguageConfiguration')
  - [Configure()](#M-Definux-Emeraude-Localization-Configuration-LanguageConfiguration-Configure-Microsoft-EntityFrameworkCore-Metadata-Builders-EntityTypeBuilder{Definux-Emeraude-Domain-Localization-Language}- 'Definux.Emeraude.Localization.Configuration.LanguageConfiguration.Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder{Definux.Emeraude.Domain.Localization.Language})')
- [LanguageRouteAttribute](#T-Definux-Emeraude-Locales-Attributes-LanguageRouteAttribute 'Definux.Emeraude.Locales.Attributes.LanguageRouteAttribute')
  - [#ctor(template)](#M-Definux-Emeraude-Locales-Attributes-LanguageRouteAttribute-#ctor-System-String- 'Definux.Emeraude.Locales.Attributes.LanguageRouteAttribute.#ctor(System.String)')
  - [Name](#P-Definux-Emeraude-Locales-Attributes-LanguageRouteAttribute-Name 'Definux.Emeraude.Locales.Attributes.LanguageRouteAttribute.Name')
  - [Order](#P-Definux-Emeraude-Locales-Attributes-LanguageRouteAttribute-Order 'Definux.Emeraude.Locales.Attributes.LanguageRouteAttribute.Order')
  - [Template](#P-Definux-Emeraude-Locales-Attributes-LanguageRouteAttribute-Template 'Definux.Emeraude.Locales.Attributes.LanguageRouteAttribute.Template')
- [LanguageRouteConstraint](#T-Definux-Emeraude-Locales-Constraints-LanguageRouteConstraint 'Definux.Emeraude.Locales.Constraints.LanguageRouteConstraint')
  - [LanguageConstraintKey](#F-Definux-Emeraude-Locales-Constraints-LanguageRouteConstraint-LanguageConstraintKey 'Definux.Emeraude.Locales.Constraints.LanguageRouteConstraint.LanguageConstraintKey')
  - [LanguageValueKey](#F-Definux-Emeraude-Locales-Constraints-LanguageRouteConstraint-LanguageValueKey 'Definux.Emeraude.Locales.Constraints.LanguageRouteConstraint.LanguageValueKey')
  - [Match()](#M-Definux-Emeraude-Locales-Constraints-LanguageRouteConstraint-Match-Microsoft-AspNetCore-Http-HttpContext,Microsoft-AspNetCore-Routing-IRouter,System-String,Microsoft-AspNetCore-Routing-RouteValueDictionary,Microsoft-AspNetCore-Routing-RouteDirection- 'Definux.Emeraude.Locales.Constraints.LanguageRouteConstraint.Match(Microsoft.AspNetCore.Http.HttpContext,Microsoft.AspNetCore.Routing.IRouter,System.String,Microsoft.AspNetCore.Routing.RouteValueDictionary,Microsoft.AspNetCore.Routing.RouteDirection)')
- [LanguageStore](#T-Definux-Emeraude-Localization-Services-LanguageStore 'Definux.Emeraude.Localization.Services.LanguageStore')
  - [#ctor(context,logger)](#M-Definux-Emeraude-Localization-Services-LanguageStore-#ctor-Definux-Emeraude-Application-Localization-ILocalizationContext,Definux-Emeraude-Application-Logger-IEmLogger- 'Definux.Emeraude.Localization.Services.LanguageStore.#ctor(Definux.Emeraude.Application.Localization.ILocalizationContext,Definux.Emeraude.Application.Logger.IEmLogger)')
  - [GetAllLanguageCodes()](#M-Definux-Emeraude-Localization-Services-LanguageStore-GetAllLanguageCodes 'Definux.Emeraude.Localization.Services.LanguageStore.GetAllLanguageCodes')
  - [GetAllLanguageCodesAsync()](#M-Definux-Emeraude-Localization-Services-LanguageStore-GetAllLanguageCodesAsync 'Definux.Emeraude.Localization.Services.LanguageStore.GetAllLanguageCodesAsync')
  - [GetDefaultLanguage()](#M-Definux-Emeraude-Localization-Services-LanguageStore-GetDefaultLanguage 'Definux.Emeraude.Localization.Services.LanguageStore.GetDefaultLanguage')
  - [GetDefaultLanguageAsync()](#M-Definux-Emeraude-Localization-Services-LanguageStore-GetDefaultLanguageAsync 'Definux.Emeraude.Localization.Services.LanguageStore.GetDefaultLanguageAsync')
  - [GetLanguageTranslationDictionary()](#M-Definux-Emeraude-Localization-Services-LanguageStore-GetLanguageTranslationDictionary-System-Int32- 'Definux.Emeraude.Localization.Services.LanguageStore.GetLanguageTranslationDictionary(System.Int32)')
  - [GetLanguages()](#M-Definux-Emeraude-Localization-Services-LanguageStore-GetLanguages 'Definux.Emeraude.Localization.Services.LanguageStore.GetLanguages')
  - [GetLanguagesAsync()](#M-Definux-Emeraude-Localization-Services-LanguageStore-GetLanguagesAsync 'Definux.Emeraude.Localization.Services.LanguageStore.GetLanguagesAsync')
  - [GetTranslationsKeys()](#M-Definux-Emeraude-Localization-Services-LanguageStore-GetTranslationsKeys 'Definux.Emeraude.Localization.Services.LanguageStore.GetTranslationsKeys')
- [LocalizationContext](#T-Definux-Emeraude-Localization-LocalizationContext 'Definux.Emeraude.Localization.LocalizationContext')
  - [#ctor(options)](#M-Definux-Emeraude-Localization-LocalizationContext-#ctor-Microsoft-EntityFrameworkCore-DbContextOptions{Definux-Emeraude-Localization-LocalizationContext}- 'Definux.Emeraude.Localization.LocalizationContext.#ctor(Microsoft.EntityFrameworkCore.DbContextOptions{Definux.Emeraude.Localization.LocalizationContext})')
  - [ContentKeys](#P-Definux-Emeraude-Localization-LocalizationContext-ContentKeys 'Definux.Emeraude.Localization.LocalizationContext.ContentKeys')
  - [Keys](#P-Definux-Emeraude-Localization-LocalizationContext-Keys 'Definux.Emeraude.Localization.LocalizationContext.Keys')
  - [Languages](#P-Definux-Emeraude-Localization-LocalizationContext-Languages 'Definux.Emeraude.Localization.LocalizationContext.Languages')
  - [StaticContent](#P-Definux-Emeraude-Localization-LocalizationContext-StaticContent 'Definux.Emeraude.Localization.LocalizationContext.StaticContent')
  - [Values](#P-Definux-Emeraude-Localization-LocalizationContext-Values 'Definux.Emeraude.Localization.LocalizationContext.Values')
  - [OnModelCreating()](#M-Definux-Emeraude-Localization-LocalizationContext-OnModelCreating-Microsoft-EntityFrameworkCore-ModelBuilder- 'Definux.Emeraude.Localization.LocalizationContext.OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder)')
- [Localizer](#T-Definux-Emeraude-Localization-Services-Localizer 'Definux.Emeraude.Localization.Services.Localizer')
  - [#ctor(context,logger,currentLanguageProvider)](#M-Definux-Emeraude-Localization-Services-Localizer-#ctor-Definux-Emeraude-Application-Localization-ILocalizationContext,Definux-Emeraude-Application-Logger-IEmLogger,Definux-Emeraude-Application-Localization-ICurrentLanguageProvider- 'Definux.Emeraude.Localization.Services.Localizer.#ctor(Definux.Emeraude.Application.Localization.ILocalizationContext,Definux.Emeraude.Application.Logger.IEmLogger,Definux.Emeraude.Application.Localization.ICurrentLanguageProvider)')
  - [Item](#P-Definux-Emeraude-Localization-Services-Localizer-Item-System-String- 'Definux.Emeraude.Localization.Services.Localizer.Item(System.String)')
  - [GetStaticContent()](#M-Definux-Emeraude-Localization-Services-Localizer-GetStaticContent-System-String- 'Definux.Emeraude.Localization.Services.Localizer.GetStaticContent(System.String)')
  - [GetStaticContent()](#M-Definux-Emeraude-Localization-Services-Localizer-GetStaticContent-System-String,System-String- 'Definux.Emeraude.Localization.Services.Localizer.GetStaticContent(System.String,System.String)')
  - [GetStaticContentAsync()](#M-Definux-Emeraude-Localization-Services-Localizer-GetStaticContentAsync-System-String- 'Definux.Emeraude.Localization.Services.Localizer.GetStaticContentAsync(System.String)')
  - [GetStaticContentAsync()](#M-Definux-Emeraude-Localization-Services-Localizer-GetStaticContentAsync-System-String,System-String- 'Definux.Emeraude.Localization.Services.Localizer.GetStaticContentAsync(System.String,System.String)')
  - [TranslateKey()](#M-Definux-Emeraude-Localization-Services-Localizer-TranslateKey-System-String- 'Definux.Emeraude.Localization.Services.Localizer.TranslateKey(System.String)')
  - [TranslateKey()](#M-Definux-Emeraude-Localization-Services-Localizer-TranslateKey-System-String,System-String- 'Definux.Emeraude.Localization.Services.Localizer.TranslateKey(System.String,System.String)')
  - [TranslateKeyAsync()](#M-Definux-Emeraude-Localization-Services-Localizer-TranslateKeyAsync-System-String- 'Definux.Emeraude.Localization.Services.Localizer.TranslateKeyAsync(System.String)')
  - [TranslateKeyAsync()](#M-Definux-Emeraude-Localization-Services-Localizer-TranslateKeyAsync-System-String,System-String- 'Definux.Emeraude.Localization.Services.Localizer.TranslateKeyAsync(System.String,System.String)')
- [ServiceCollectionExtensions](#T-Definux-Emeraude-Localization-Extensions-ServiceCollectionExtensions 'Definux.Emeraude.Localization.Extensions.ServiceCollectionExtensions')
  - [RegisterEmeraudeLocalization(services,options)](#M-Definux-Emeraude-Localization-Extensions-ServiceCollectionExtensions-RegisterEmeraudeLocalization-Microsoft-Extensions-DependencyInjection-IServiceCollection,Definux-Emeraude-Configuration-Options-EmOptions- 'Definux.Emeraude.Localization.Extensions.ServiceCollectionExtensions.RegisterEmeraudeLocalization(Microsoft.Extensions.DependencyInjection.IServiceCollection,Definux.Emeraude.Configuration.Options.EmOptions)')
- [StaticContentConfiguration](#T-Definux-Emeraude-Localization-Configuration-StaticContentConfiguration 'Definux.Emeraude.Localization.Configuration.StaticContentConfiguration')
  - [Configure()](#M-Definux-Emeraude-Localization-Configuration-StaticContentConfiguration-Configure-Microsoft-EntityFrameworkCore-Metadata-Builders-EntityTypeBuilder{Definux-Emeraude-Domain-Localization-StaticContent}- 'Definux.Emeraude.Localization.Configuration.StaticContentConfiguration.Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder{Definux.Emeraude.Domain.Localization.StaticContent})')
- [StringExtensions](#T-Definux-Emeraude-Localization-Extensions-StringExtensions 'Definux.Emeraude.Localization.Extensions.StringExtensions')
  - [GetLanguageCodeFromUrl(url)](#M-Definux-Emeraude-Localization-Extensions-StringExtensions-GetLanguageCodeFromUrl-System-String- 'Definux.Emeraude.Localization.Extensions.StringExtensions.GetLanguageCodeFromUrl(System.String)')
- [TranslationKeyConfiguration](#T-Definux-Emeraude-Localization-Configuration-TranslationKeyConfiguration 'Definux.Emeraude.Localization.Configuration.TranslationKeyConfiguration')
  - [Configure()](#M-Definux-Emeraude-Localization-Configuration-TranslationKeyConfiguration-Configure-Microsoft-EntityFrameworkCore-Metadata-Builders-EntityTypeBuilder{Definux-Emeraude-Domain-Localization-TranslationKey}- 'Definux.Emeraude.Localization.Configuration.TranslationKeyConfiguration.Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder{Definux.Emeraude.Domain.Localization.TranslationKey})')
- [TranslationValueConfiguration](#T-Definux-Emeraude-Localization-Configuration-TranslationValueConfiguration 'Definux.Emeraude.Localization.Configuration.TranslationValueConfiguration')
  - [Configure()](#M-Definux-Emeraude-Localization-Configuration-TranslationValueConfiguration-Configure-Microsoft-EntityFrameworkCore-Metadata-Builders-EntityTypeBuilder{Definux-Emeraude-Domain-Localization-TranslationValue}- 'Definux.Emeraude.Localization.Configuration.TranslationValueConfiguration.Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder{Definux.Emeraude.Domain.Localization.TranslationValue})')

<a name='T-Definux-Emeraude-Localization-AssemblyInfo'></a>
## AssemblyInfo `type`

##### Namespace

Definux.Emeraude.Localization

##### Summary

Assembly info provider.

<a name='M-Definux-Emeraude-Localization-AssemblyInfo-GetAssembly'></a>
### GetAssembly() `method`

##### Summary

Gets execution assembly.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Localization-Configuration-ContentKeyConfiguration'></a>
## ContentKeyConfiguration `type`

##### Namespace

Definux.Emeraude.Localization.Configuration

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Localization-Configuration-ContentKeyConfiguration-Configure-Microsoft-EntityFrameworkCore-Metadata-Builders-EntityTypeBuilder{Definux-Emeraude-Domain-Localization-ContentKey}-'></a>
### Configure() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Localization-Extensions-ControllerExtensions'></a>
## ControllerExtensions `type`

##### Namespace

Definux.Emeraude.Localization.Extensions

##### Summary

Extensions for [Controller](#T-Microsoft-AspNetCore-Mvc-Controller 'Microsoft.AspNetCore.Mvc.Controller').

<a name='M-Definux-Emeraude-Localization-Extensions-ControllerExtensions-GetRouteWithAppliedLanguage-Microsoft-AspNetCore-Mvc-Controller,System-String,Definux-Emeraude-Domain-Localization-Language-'></a>
### GetRouteWithAppliedLanguage(controller,route,language) `method`

##### Summary

Gets route with applied language code on the beginning.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| controller | [Microsoft.AspNetCore.Mvc.Controller](#T-Microsoft-AspNetCore-Mvc-Controller 'Microsoft.AspNetCore.Mvc.Controller') |  |
| route | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| language | [Definux.Emeraude.Domain.Localization.Language](#T-Definux-Emeraude-Domain-Localization-Language 'Definux.Emeraude.Domain.Localization.Language') |  |

<a name='T-Definux-Emeraude-Localization-Services-CurrentLanguageProvider'></a>
## CurrentLanguageProvider `type`

##### Namespace

Definux.Emeraude.Localization.Services

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Localization-Services-CurrentLanguageProvider-#ctor-Definux-Emeraude-Application-Localization-ILocalizationContext,Microsoft-AspNetCore-Http-IHttpContextAccessor-'></a>
### #ctor(context,httpAccessor) `constructor`

##### Summary

Initializes a new instance of the [CurrentLanguageProvider](#T-Definux-Emeraude-Localization-Services-CurrentLanguageProvider 'Definux.Emeraude.Localization.Services.CurrentLanguageProvider') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Definux.Emeraude.Application.Localization.ILocalizationContext](#T-Definux-Emeraude-Application-Localization-ILocalizationContext 'Definux.Emeraude.Application.Localization.ILocalizationContext') |  |
| httpAccessor | [Microsoft.AspNetCore.Http.IHttpContextAccessor](#T-Microsoft-AspNetCore-Http-IHttpContextAccessor 'Microsoft.AspNetCore.Http.IHttpContextAccessor') |  |

<a name='M-Definux-Emeraude-Localization-Services-CurrentLanguageProvider-GetCurrentLanguage'></a>
### GetCurrentLanguage() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Localization-Services-CurrentLanguageProvider-GetCurrentLanguageAsync'></a>
### GetCurrentLanguageAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Localization-Extensions-HttpContextExtensions'></a>
## HttpContextExtensions `type`

##### Namespace

Definux.Emeraude.Localization.Extensions

##### Summary

Extensions for [HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext').

<a name='M-Definux-Emeraude-Localization-Extensions-HttpContextExtensions-GetLanguageCode-Microsoft-AspNetCore-Http-HttpContext-'></a>
### GetLanguageCode(httpContext) `method`

##### Summary

Get language code from current instance of [HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext').

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| httpContext | [Microsoft.AspNetCore.Http.HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') |  |

<a name='T-Definux-Emeraude-Localization-Migrations-Init'></a>
## Init `type`

##### Namespace

Definux.Emeraude.Localization.Migrations

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Localization-Migrations-Init-BuildTargetModel-Microsoft-EntityFrameworkCore-ModelBuilder-'></a>
### BuildTargetModel() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Localization-Migrations-Init-Down-Microsoft-EntityFrameworkCore-Migrations-MigrationBuilder-'></a>
### Down() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Localization-Migrations-Init-Up-Microsoft-EntityFrameworkCore-Migrations-MigrationBuilder-'></a>
### Up() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Localization-Configuration-LanguageConfiguration'></a>
## LanguageConfiguration `type`

##### Namespace

Definux.Emeraude.Localization.Configuration

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Localization-Configuration-LanguageConfiguration-Configure-Microsoft-EntityFrameworkCore-Metadata-Builders-EntityTypeBuilder{Definux-Emeraude-Domain-Localization-Language}-'></a>
### Configure() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Locales-Attributes-LanguageRouteAttribute'></a>
## LanguageRouteAttribute `type`

##### Namespace

Definux.Emeraude.Locales.Attributes

##### Summary

Defines language SEO friendly route based on language code (not default language).
Example for English Language with code 'en': '/items/1' map route '/en/items/1'.
Provides string variable 'languageCode' contains current request language code.

<a name='M-Definux-Emeraude-Locales-Attributes-LanguageRouteAttribute-#ctor-System-String-'></a>
### #ctor(template) `constructor`

##### Summary

Initializes a new instance of the [LanguageRouteAttribute](#T-Definux-Emeraude-Locales-Attributes-LanguageRouteAttribute 'Definux.Emeraude.Locales.Attributes.LanguageRouteAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| template | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='P-Definux-Emeraude-Locales-Attributes-LanguageRouteAttribute-Name'></a>
### Name `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Locales-Attributes-LanguageRouteAttribute-Order'></a>
### Order `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Locales-Attributes-LanguageRouteAttribute-Template'></a>
### Template `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Locales-Constraints-LanguageRouteConstraint'></a>
## LanguageRouteConstraint `type`

##### Namespace

Definux.Emeraude.Locales.Constraints

##### Summary

Implementation of [IRouteConstraint](#T-Microsoft-AspNetCore-Routing-IRouteConstraint 'Microsoft.AspNetCore.Routing.IRouteConstraint') for language code constraint that validate the request language code.

<a name='F-Definux-Emeraude-Locales-Constraints-LanguageRouteConstraint-LanguageConstraintKey'></a>
### LanguageConstraintKey `constants`

##### Summary

Short name of the language constraint.

<a name='F-Definux-Emeraude-Locales-Constraints-LanguageRouteConstraint-LanguageValueKey'></a>
### LanguageValueKey `constants`

##### Summary

Language value property that is applied to the route parameters.

<a name='M-Definux-Emeraude-Locales-Constraints-LanguageRouteConstraint-Match-Microsoft-AspNetCore-Http-HttpContext,Microsoft-AspNetCore-Routing-IRouter,System-String,Microsoft-AspNetCore-Routing-RouteValueDictionary,Microsoft-AspNetCore-Routing-RouteDirection-'></a>
### Match() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Localization-Services-LanguageStore'></a>
## LanguageStore `type`

##### Namespace

Definux.Emeraude.Localization.Services

##### Summary

Storage implementation for all localization data - languages, translations.

<a name='M-Definux-Emeraude-Localization-Services-LanguageStore-#ctor-Definux-Emeraude-Application-Localization-ILocalizationContext,Definux-Emeraude-Application-Logger-IEmLogger-'></a>
### #ctor(context,logger) `constructor`

##### Summary

Initializes a new instance of the [LanguageStore](#T-Definux-Emeraude-Localization-Services-LanguageStore 'Definux.Emeraude.Localization.Services.LanguageStore') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Definux.Emeraude.Application.Localization.ILocalizationContext](#T-Definux-Emeraude-Application-Localization-ILocalizationContext 'Definux.Emeraude.Application.Localization.ILocalizationContext') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |

<a name='M-Definux-Emeraude-Localization-Services-LanguageStore-GetAllLanguageCodes'></a>
### GetAllLanguageCodes() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Localization-Services-LanguageStore-GetAllLanguageCodesAsync'></a>
### GetAllLanguageCodesAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Localization-Services-LanguageStore-GetDefaultLanguage'></a>
### GetDefaultLanguage() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Localization-Services-LanguageStore-GetDefaultLanguageAsync'></a>
### GetDefaultLanguageAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Localization-Services-LanguageStore-GetLanguageTranslationDictionary-System-Int32-'></a>
### GetLanguageTranslationDictionary() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Localization-Services-LanguageStore-GetLanguages'></a>
### GetLanguages() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Localization-Services-LanguageStore-GetLanguagesAsync'></a>
### GetLanguagesAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Localization-Services-LanguageStore-GetTranslationsKeys'></a>
### GetTranslationsKeys() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Localization-LocalizationContext'></a>
## LocalizationContext `type`

##### Namespace

Definux.Emeraude.Localization

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Localization-LocalizationContext-#ctor-Microsoft-EntityFrameworkCore-DbContextOptions{Definux-Emeraude-Localization-LocalizationContext}-'></a>
### #ctor(options) `constructor`

##### Summary

Initializes a new instance of the [LocalizationContext](#T-Definux-Emeraude-Localization-LocalizationContext 'Definux.Emeraude.Localization.LocalizationContext') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [Microsoft.EntityFrameworkCore.DbContextOptions{Definux.Emeraude.Localization.LocalizationContext}](#T-Microsoft-EntityFrameworkCore-DbContextOptions{Definux-Emeraude-Localization-LocalizationContext} 'Microsoft.EntityFrameworkCore.DbContextOptions{Definux.Emeraude.Localization.LocalizationContext}') |  |

<a name='P-Definux-Emeraude-Localization-LocalizationContext-ContentKeys'></a>
### ContentKeys `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Localization-LocalizationContext-Keys'></a>
### Keys `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Localization-LocalizationContext-Languages'></a>
### Languages `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Localization-LocalizationContext-StaticContent'></a>
### StaticContent `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Localization-LocalizationContext-Values'></a>
### Values `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Localization-LocalizationContext-OnModelCreating-Microsoft-EntityFrameworkCore-ModelBuilder-'></a>
### OnModelCreating() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Localization-Services-Localizer'></a>
## Localizer `type`

##### Namespace

Definux.Emeraude.Localization.Services

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Localization-Services-Localizer-#ctor-Definux-Emeraude-Application-Localization-ILocalizationContext,Definux-Emeraude-Application-Logger-IEmLogger,Definux-Emeraude-Application-Localization-ICurrentLanguageProvider-'></a>
### #ctor(context,logger,currentLanguageProvider) `constructor`

##### Summary

Initializes a new instance of the [Localizer](#T-Definux-Emeraude-Localization-Services-Localizer 'Definux.Emeraude.Localization.Services.Localizer') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Definux.Emeraude.Application.Localization.ILocalizationContext](#T-Definux-Emeraude-Application-Localization-ILocalizationContext 'Definux.Emeraude.Application.Localization.ILocalizationContext') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |
| currentLanguageProvider | [Definux.Emeraude.Application.Localization.ICurrentLanguageProvider](#T-Definux-Emeraude-Application-Localization-ICurrentLanguageProvider 'Definux.Emeraude.Application.Localization.ICurrentLanguageProvider') |  |

<a name='P-Definux-Emeraude-Localization-Services-Localizer-Item-System-String-'></a>
### Item `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Localization-Services-Localizer-GetStaticContent-System-String-'></a>
### GetStaticContent() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Localization-Services-Localizer-GetStaticContent-System-String,System-String-'></a>
### GetStaticContent() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Localization-Services-Localizer-GetStaticContentAsync-System-String-'></a>
### GetStaticContentAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Localization-Services-Localizer-GetStaticContentAsync-System-String,System-String-'></a>
### GetStaticContentAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Localization-Services-Localizer-TranslateKey-System-String-'></a>
### TranslateKey() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Localization-Services-Localizer-TranslateKey-System-String,System-String-'></a>
### TranslateKey() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Localization-Services-Localizer-TranslateKeyAsync-System-String-'></a>
### TranslateKeyAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Localization-Services-Localizer-TranslateKeyAsync-System-String,System-String-'></a>
### TranslateKeyAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Localization-Extensions-ServiceCollectionExtensions'></a>
## ServiceCollectionExtensions `type`

##### Namespace

Definux.Emeraude.Localization.Extensions

##### Summary

Extensions for [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection').

<a name='M-Definux-Emeraude-Localization-Extensions-ServiceCollectionExtensions-RegisterEmeraudeLocalization-Microsoft-Extensions-DependencyInjection-IServiceCollection,Definux-Emeraude-Configuration-Options-EmOptions-'></a>
### RegisterEmeraudeLocalization(services,options) `method`

##### Summary

Register required services for Emeraude localization.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |
| options | [Definux.Emeraude.Configuration.Options.EmOptions](#T-Definux-Emeraude-Configuration-Options-EmOptions 'Definux.Emeraude.Configuration.Options.EmOptions') |  |

<a name='T-Definux-Emeraude-Localization-Configuration-StaticContentConfiguration'></a>
## StaticContentConfiguration `type`

##### Namespace

Definux.Emeraude.Localization.Configuration

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Localization-Configuration-StaticContentConfiguration-Configure-Microsoft-EntityFrameworkCore-Metadata-Builders-EntityTypeBuilder{Definux-Emeraude-Domain-Localization-StaticContent}-'></a>
### Configure() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Localization-Extensions-StringExtensions'></a>
## StringExtensions `type`

##### Namespace

Definux.Emeraude.Localization.Extensions

##### Summary

Extensions for strings.

<a name='M-Definux-Emeraude-Localization-Extensions-StringExtensions-GetLanguageCodeFromUrl-System-String-'></a>
### GetLanguageCodeFromUrl(url) `method`

##### Summary

Extract language code from specified URL.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Localization-Configuration-TranslationKeyConfiguration'></a>
## TranslationKeyConfiguration `type`

##### Namespace

Definux.Emeraude.Localization.Configuration

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Localization-Configuration-TranslationKeyConfiguration-Configure-Microsoft-EntityFrameworkCore-Metadata-Builders-EntityTypeBuilder{Definux-Emeraude-Domain-Localization-TranslationKey}-'></a>
### Configure() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Localization-Configuration-TranslationValueConfiguration'></a>
## TranslationValueConfiguration `type`

##### Namespace

Definux.Emeraude.Localization.Configuration

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Localization-Configuration-TranslationValueConfiguration-Configure-Microsoft-EntityFrameworkCore-Metadata-Builders-EntityTypeBuilder{Definux-Emeraude-Domain-Localization-TranslationValue}-'></a>
### Configure() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.
