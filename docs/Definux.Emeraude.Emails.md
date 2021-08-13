<a name='assembly'></a>
# Definux.Emeraude.Emails

## Contents

- [EmEmailOptions](#T-Definux-Emeraude-Emails-EmEmailOptions 'Definux.Emeraude.Emails.EmEmailOptions')
  - [EmailSenderImplementationType](#P-Definux-Emeraude-Emails-EmEmailOptions-EmailSenderImplementationType 'Definux.Emeraude.Emails.EmEmailOptions.EmailSenderImplementationType')
- [EmailRenderer](#T-Definux-Emeraude-Emails-Services-EmailRenderer 'Definux.Emeraude.Emails.Services.EmailRenderer')
  - [#ctor(razorViewEngine,tempDataProvider,serviceProvider)](#M-Definux-Emeraude-Emails-Services-EmailRenderer-#ctor-Microsoft-AspNetCore-Mvc-Razor-IRazorViewEngine,Microsoft-AspNetCore-Mvc-ViewFeatures-ITempDataProvider,System-IServiceProvider- 'Definux.Emeraude.Emails.Services.EmailRenderer.#ctor(Microsoft.AspNetCore.Mvc.Razor.IRazorViewEngine,Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataProvider,System.IServiceProvider)')
  - [RenderToStringAsync()](#M-Definux-Emeraude-Emails-Services-EmailRenderer-RenderToStringAsync-System-String,Definux-Emeraude-Application-Emails-EmailModel- 'Definux.Emeraude.Emails.Services.EmailRenderer.RenderToStringAsync(System.String,Definux.Emeraude.Application.Emails.EmailModel)')
- [EmailSender](#T-Definux-Emeraude-Emails-Services-EmailSender 'Definux.Emeraude.Emails.Services.EmailSender')
  - [#ctor(emailRenderer,logger,smtpOptionsAccessor)](#M-Definux-Emeraude-Emails-Services-EmailSender-#ctor-Definux-Emeraude-Application-Emails-IEmailRenderer,Definux-Emeraude-Application-Logger-IEmLogger,Microsoft-Extensions-Options-IOptions{Definux-Utilities-Options-SmtpOptions}- 'Definux.Emeraude.Emails.Services.EmailSender.#ctor(Definux.Emeraude.Application.Emails.IEmailRenderer,Definux.Emeraude.Application.Logger.IEmLogger,Microsoft.Extensions.Options.IOptions{Definux.Utilities.Options.SmtpOptions})')
  - [SendEmailAsync()](#M-Definux-Emeraude-Emails-Services-EmailSender-SendEmailAsync-System-String,Definux-Emeraude-Application-Emails-EmailModel- 'Definux.Emeraude.Emails.Services.EmailSender.SendEmailAsync(System.String,Definux.Emeraude.Application.Emails.EmailModel)')
- [OptionsExtensions](#T-Definux-Emeraude-Emails-Extensions-OptionsExtensions 'Definux.Emeraude.Emails.Extensions.OptionsExtensions')
  - [ConfigureEmailsInfrastructure(options,emailOptionsAction)](#M-Definux-Emeraude-Emails-Extensions-OptionsExtensions-ConfigureEmailsInfrastructure-Definux-Emeraude-Configuration-Options-EmOptions,System-Action{Definux-Emeraude-Emails-EmEmailOptions}- 'Definux.Emeraude.Emails.Extensions.OptionsExtensions.ConfigureEmailsInfrastructure(Definux.Emeraude.Configuration.Options.EmOptions,System.Action{Definux.Emeraude.Emails.EmEmailOptions})')
  - [GetEmailOptions(options)](#M-Definux-Emeraude-Emails-Extensions-OptionsExtensions-GetEmailOptions-Definux-Emeraude-Configuration-Options-EmOptions- 'Definux.Emeraude.Emails.Extensions.OptionsExtensions.GetEmailOptions(Definux.Emeraude.Configuration.Options.EmOptions)')
- [ServiceCollectionExtensions](#T-Definux-Emeraude-Emails-Extensions-ServiceCollectionExtensions 'Definux.Emeraude.Emails.Extensions.ServiceCollectionExtensions')
  - [RegisterEmailInfrastructure(services,options)](#M-Definux-Emeraude-Emails-Extensions-ServiceCollectionExtensions-RegisterEmailInfrastructure-Microsoft-Extensions-DependencyInjection-IServiceCollection,Definux-Emeraude-Emails-EmEmailOptions- 'Definux.Emeraude.Emails.Extensions.ServiceCollectionExtensions.RegisterEmailInfrastructure(Microsoft.Extensions.DependencyInjection.IServiceCollection,Definux.Emeraude.Emails.EmEmailOptions)')
- [StringExtensions](#T-Definux-Emeraude-Emails-Extensions-StringExtensions 'Definux.Emeraude.Emails.Extensions.StringExtensions')
  - [ToLanguageSuffix(targetString,languageCode)](#M-Definux-Emeraude-Emails-Extensions-StringExtensions-ToLanguageSuffix-System-String,System-String- 'Definux.Emeraude.Emails.Extensions.StringExtensions.ToLanguageSuffix(System.String,System.String)')

<a name='T-Definux-Emeraude-Emails-EmEmailOptions'></a>
## EmEmailOptions `type`

##### Namespace

Definux.Emeraude.Emails

##### Summary

Options for email infrastructure of Emeraude.

<a name='P-Definux-Emeraude-Emails-EmEmailOptions-EmailSenderImplementationType'></a>
### EmailSenderImplementationType `property`

##### Summary

Type of email service implementation. If null the default email provider will be registered.

<a name='T-Definux-Emeraude-Emails-Services-EmailRenderer'></a>
## EmailRenderer `type`

##### Namespace

Definux.Emeraude.Emails.Services

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Emails-Services-EmailRenderer-#ctor-Microsoft-AspNetCore-Mvc-Razor-IRazorViewEngine,Microsoft-AspNetCore-Mvc-ViewFeatures-ITempDataProvider,System-IServiceProvider-'></a>
### #ctor(razorViewEngine,tempDataProvider,serviceProvider) `constructor`

##### Summary

Initializes a new instance of the [EmailRenderer](#T-Definux-Emeraude-Emails-Services-EmailRenderer 'Definux.Emeraude.Emails.Services.EmailRenderer') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| razorViewEngine | [Microsoft.AspNetCore.Mvc.Razor.IRazorViewEngine](#T-Microsoft-AspNetCore-Mvc-Razor-IRazorViewEngine 'Microsoft.AspNetCore.Mvc.Razor.IRazorViewEngine') |  |
| tempDataProvider | [Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataProvider](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ITempDataProvider 'Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataProvider') |  |
| serviceProvider | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') |  |

<a name='M-Definux-Emeraude-Emails-Services-EmailRenderer-RenderToStringAsync-System-String,Definux-Emeraude-Application-Emails-EmailModel-'></a>
### RenderToStringAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Emails-Services-EmailSender'></a>
## EmailSender `type`

##### Namespace

Definux.Emeraude.Emails.Services

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Emails-Services-EmailSender-#ctor-Definux-Emeraude-Application-Emails-IEmailRenderer,Definux-Emeraude-Application-Logger-IEmLogger,Microsoft-Extensions-Options-IOptions{Definux-Utilities-Options-SmtpOptions}-'></a>
### #ctor(emailRenderer,logger,smtpOptionsAccessor) `constructor`

##### Summary

Initializes a new instance of the [EmailSender](#T-Definux-Emeraude-Emails-Services-EmailSender 'Definux.Emeraude.Emails.Services.EmailSender') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| emailRenderer | [Definux.Emeraude.Application.Emails.IEmailRenderer](#T-Definux-Emeraude-Application-Emails-IEmailRenderer 'Definux.Emeraude.Application.Emails.IEmailRenderer') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |
| smtpOptionsAccessor | [Microsoft.Extensions.Options.IOptions{Definux.Utilities.Options.SmtpOptions}](#T-Microsoft-Extensions-Options-IOptions{Definux-Utilities-Options-SmtpOptions} 'Microsoft.Extensions.Options.IOptions{Definux.Utilities.Options.SmtpOptions}') |  |

<a name='M-Definux-Emeraude-Emails-Services-EmailSender-SendEmailAsync-System-String,Definux-Emeraude-Application-Emails-EmailModel-'></a>
### SendEmailAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Emails-Extensions-OptionsExtensions'></a>
## OptionsExtensions `type`

##### Namespace

Definux.Emeraude.Emails.Extensions

##### Summary

Extensions for [EmOptions](#T-Definux-Emeraude-Configuration-Options-EmOptions 'Definux.Emeraude.Configuration.Options.EmOptions').

<a name='M-Definux-Emeraude-Emails-Extensions-OptionsExtensions-ConfigureEmailsInfrastructure-Definux-Emeraude-Configuration-Options-EmOptions,System-Action{Definux-Emeraude-Emails-EmEmailOptions}-'></a>
### ConfigureEmailsInfrastructure(options,emailOptionsAction) `method`

##### Summary

Add external Emeraude email options.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [Definux.Emeraude.Configuration.Options.EmOptions](#T-Definux-Emeraude-Configuration-Options-EmOptions 'Definux.Emeraude.Configuration.Options.EmOptions') |  |
| emailOptionsAction | [System.Action{Definux.Emeraude.Emails.EmEmailOptions}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Definux.Emeraude.Emails.EmEmailOptions}') |  |

<a name='M-Definux-Emeraude-Emails-Extensions-OptionsExtensions-GetEmailOptions-Definux-Emeraude-Configuration-Options-EmOptions-'></a>
### GetEmailOptions(options) `method`

##### Summary

Get Emeraude email infrastructure options.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [Definux.Emeraude.Configuration.Options.EmOptions](#T-Definux-Emeraude-Configuration-Options-EmOptions 'Definux.Emeraude.Configuration.Options.EmOptions') |  |

<a name='T-Definux-Emeraude-Emails-Extensions-ServiceCollectionExtensions'></a>
## ServiceCollectionExtensions `type`

##### Namespace

Definux.Emeraude.Emails.Extensions

##### Summary

Extensions for [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection').

<a name='M-Definux-Emeraude-Emails-Extensions-ServiceCollectionExtensions-RegisterEmailInfrastructure-Microsoft-Extensions-DependencyInjection-IServiceCollection,Definux-Emeraude-Emails-EmEmailOptions-'></a>
### RegisterEmailInfrastructure(services,options) `method`

##### Summary

Registers email infrastructure.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |
| options | [Definux.Emeraude.Emails.EmEmailOptions](#T-Definux-Emeraude-Emails-EmEmailOptions 'Definux.Emeraude.Emails.EmEmailOptions') |  |

<a name='T-Definux-Emeraude-Emails-Extensions-StringExtensions'></a>
## StringExtensions `type`

##### Namespace

Definux.Emeraude.Emails.Extensions

##### Summary

Extensions for strings.

<a name='M-Definux-Emeraude-Emails-Extensions-StringExtensions-ToLanguageSuffix-System-String,System-String-'></a>
### ToLanguageSuffix(targetString,languageCode) `method`

##### Summary

Merge string and languageCode.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| targetString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| languageCode | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
