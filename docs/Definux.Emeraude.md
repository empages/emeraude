<a name='assembly'></a>
# Definux.Emeraude

## Contents

- [ApplicationAssemblyPart](#T-Definux-Emeraude-ApplicationAssemblyPart 'Definux.Emeraude.ApplicationAssemblyPart')
  - [Assembly](#P-Definux-Emeraude-ApplicationAssemblyPart-Assembly 'Definux.Emeraude.ApplicationAssemblyPart.Assembly')
  - [AssemblyPart](#P-Definux-Emeraude-ApplicationAssemblyPart-AssemblyPart 'Definux.Emeraude.ApplicationAssemblyPart.AssemblyPart')
- [ApplicationBuilderExtensions](#T-Definux-Emeraude-Extensions-ApplicationBuilderExtensions 'Definux.Emeraude.Extensions.ApplicationBuilderExtensions')
  - [UseEmeraudeExceptionHandler(app)](#M-Definux-Emeraude-Extensions-ApplicationBuilderExtensions-UseEmeraudeExceptionHandler-Microsoft-AspNetCore-Builder-IApplicationBuilder- 'Definux.Emeraude.Extensions.ApplicationBuilderExtensions.UseEmeraudeExceptionHandler(Microsoft.AspNetCore.Builder.IApplicationBuilder)')
  - [UseEmeraudeStatusCodePage(app)](#M-Definux-Emeraude-Extensions-ApplicationBuilderExtensions-UseEmeraudeStatusCodePage-Microsoft-AspNetCore-Builder-IApplicationBuilder- 'Definux.Emeraude.Extensions.ApplicationBuilderExtensions.UseEmeraudeStatusCodePage(Microsoft.AspNetCore.Builder.IApplicationBuilder)')
- [EmStartup](#T-Definux-Emeraude-EmStartup 'Definux.Emeraude.EmStartup')
  - [RunEmeraude(hostBuilder)](#M-Definux-Emeraude-EmStartup-RunEmeraude-Microsoft-Extensions-Hosting-IHostBuilder- 'Definux.Emeraude.EmStartup.RunEmeraude(Microsoft.Extensions.Hosting.IHostBuilder)')
- [EmeraudeSettingsBuilder](#T-Definux-Emeraude-EmeraudeSettingsBuilder 'Definux.Emeraude.EmeraudeSettingsBuilder')
  - [AuthenticationBuilder](#P-Definux-Emeraude-EmeraudeSettingsBuilder-AuthenticationBuilder 'Definux.Emeraude.EmeraudeSettingsBuilder.AuthenticationBuilder')
  - [Services](#P-Definux-Emeraude-EmeraudeSettingsBuilder-Services 'Definux.Emeraude.EmeraudeSettingsBuilder.Services')
- [EmeraudeSettingsBuilderExtensions](#T-Definux-Emeraude-Extensions-EmeraudeSettingsBuilderExtensions 'Definux.Emeraude.Extensions.EmeraudeSettingsBuilderExtensions')
  - [AddExternalProvidersAuthenticators(builder,authenticatorsAction)](#M-Definux-Emeraude-Extensions-EmeraudeSettingsBuilderExtensions-AddExternalProvidersAuthenticators-Definux-Emeraude-EmeraudeSettingsBuilder,System-Action{System-Collections-Generic-List{Definux-Emeraude-Application-Identity-IExternalProviderAuthenticator}}- 'Definux.Emeraude.Extensions.EmeraudeSettingsBuilderExtensions.AddExternalProvidersAuthenticators(Definux.Emeraude.EmeraudeSettingsBuilder,System.Action{System.Collections.Generic.List{Definux.Emeraude.Application.Identity.IExternalProviderAuthenticator}})')
- [OptionsExtensions](#T-Definux-Emeraude-Extensions-OptionsExtensions 'Definux.Emeraude.Extensions.OptionsExtensions')
  - [ConfigureSeo(options,seoOptionsAction)](#M-Definux-Emeraude-Extensions-OptionsExtensions-ConfigureSeo-Definux-Emeraude-Configuration-Options-EmOptions,System-Action{Definux-Emeraude-Client-Seo-Options-SeoOptions}- 'Definux.Emeraude.Extensions.OptionsExtensions.ConfigureSeo(Definux.Emeraude.Configuration.Options.EmOptions,System.Action{Definux.Emeraude.Client.Seo.Options.SeoOptions})')
- [ServiceCollectionExtensions](#T-Definux-Emeraude-Extensions-ServiceCollectionExtensions 'Definux.Emeraude.Extensions.ServiceCollectionExtensions')
  - [AddEmeraude\`\`2(services,optionsAction)](#M-Definux-Emeraude-Extensions-ServiceCollectionExtensions-AddEmeraude``2-Microsoft-Extensions-DependencyInjection-IServiceCollection,System-Action{Definux-Emeraude-Configuration-Options-EmOptions}- 'Definux.Emeraude.Extensions.ServiceCollectionExtensions.AddEmeraude``2(Microsoft.Extensions.DependencyInjection.IServiceCollection,System.Action{Definux.Emeraude.Configuration.Options.EmOptions})')
  - [ApplyAuthenticationSessionToPrivateRoot(services)](#M-Definux-Emeraude-Extensions-ServiceCollectionExtensions-ApplyAuthenticationSessionToPrivateRoot-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Definux.Emeraude.Extensions.ServiceCollectionExtensions.ApplyAuthenticationSessionToPrivateRoot(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [ApplyEmeraudeBaseOptions(options)](#M-Definux-Emeraude-Extensions-ServiceCollectionExtensions-ApplyEmeraudeBaseOptions-Definux-Emeraude-Configuration-Options-EmOptions- 'Definux.Emeraude.Extensions.ServiceCollectionExtensions.ApplyEmeraudeBaseOptions(Definux.Emeraude.Configuration.Options.EmOptions)')

<a name='T-Definux-Emeraude-ApplicationAssemblyPart'></a>
## ApplicationAssemblyPart `type`

##### Namespace

Definux.Emeraude

##### Summary

Static class that provides access to the Emeraude assembly information.

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

<a name='M-Definux-Emeraude-Extensions-ApplicationBuilderExtensions-UseEmeraudeExceptionHandler-Microsoft-AspNetCore-Builder-IApplicationBuilder-'></a>
### UseEmeraudeExceptionHandler(app) `method`

##### Summary

Configure exception handler to be redirected to the Emeraude error page.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| app | [Microsoft.AspNetCore.Builder.IApplicationBuilder](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder 'Microsoft.AspNetCore.Builder.IApplicationBuilder') |  |

<a name='M-Definux-Emeraude-Extensions-ApplicationBuilderExtensions-UseEmeraudeStatusCodePage-Microsoft-AspNetCore-Builder-IApplicationBuilder-'></a>
### UseEmeraudeStatusCodePage(app) `method`

##### Summary

Configure errors with status code page for the predefined action.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| app | [Microsoft.AspNetCore.Builder.IApplicationBuilder](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder 'Microsoft.AspNetCore.Builder.IApplicationBuilder') |  |

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

<a name='T-Definux-Emeraude-Extensions-OptionsExtensions'></a>
## OptionsExtensions `type`

##### Namespace

Definux.Emeraude.Extensions

##### Summary

Extensions for [EmOptions](#T-Definux-Emeraude-Configuration-Options-EmOptions 'Definux.Emeraude.Configuration.Options.EmOptions').

<a name='M-Definux-Emeraude-Extensions-OptionsExtensions-ConfigureSeo-Definux-Emeraude-Configuration-Options-EmOptions,System-Action{Definux-Emeraude-Client-Seo-Options-SeoOptions}-'></a>
### ConfigureSeo(options,seoOptionsAction) `method`

##### Summary

Configure SEO options.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [Definux.Emeraude.Configuration.Options.EmOptions](#T-Definux-Emeraude-Configuration-Options-EmOptions 'Definux.Emeraude.Configuration.Options.EmOptions') |  |
| seoOptionsAction | [System.Action{Definux.Emeraude.Client.Seo.Options.SeoOptions}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Definux.Emeraude.Client.Seo.Options.SeoOptions}') |  |

<a name='T-Definux-Emeraude-Extensions-ServiceCollectionExtensions'></a>
## ServiceCollectionExtensions `type`

##### Namespace

Definux.Emeraude.Extensions

##### Summary

Extensions for [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection').

<a name='M-Definux-Emeraude-Extensions-ServiceCollectionExtensions-AddEmeraude``2-Microsoft-Extensions-DependencyInjection-IServiceCollection,System-Action{Definux-Emeraude-Configuration-Options-EmOptions}-'></a>
### AddEmeraude\`\`2(services,optionsAction) `method`

##### Summary

Configure Emeraude framework required services and functionalities.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |
| optionsAction | [System.Action{Definux.Emeraude.Configuration.Options.EmOptions}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Definux.Emeraude.Configuration.Options.EmOptions}') |  |

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
