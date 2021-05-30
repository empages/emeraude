<a name='assembly'></a>
# Definux.Emeraude.Emails

## Contents

- [EmailSender](#T-Definux-Emeraude-Emails-Services-EmailSender 'Definux.Emeraude.Emails.Services.EmailSender')
  - [#ctor(logger,razorViewEngine,tempDataProvider,serviceProvider,smtpOptionsAccessor)](#M-Definux-Emeraude-Emails-Services-EmailSender-#ctor-Definux-Emeraude-Application-Logger-IEmLogger,Microsoft-AspNetCore-Mvc-Razor-IRazorViewEngine,Microsoft-AspNetCore-Mvc-ViewFeatures-ITempDataProvider,System-IServiceProvider,Microsoft-Extensions-Options-IOptions{Definux-Utilities-Options-SmtpOptions}- 'Definux.Emeraude.Emails.Services.EmailSender.#ctor(Definux.Emeraude.Application.Logger.IEmLogger,Microsoft.AspNetCore.Mvc.Razor.IRazorViewEngine,Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataProvider,System.IServiceProvider,Microsoft.Extensions.Options.IOptions{Definux.Utilities.Options.SmtpOptions})')
  - [SendEmailAsync()](#M-Definux-Emeraude-Emails-Services-EmailSender-SendEmailAsync-System-String,Definux-Emeraude-Application-Emails-EmailModel- 'Definux.Emeraude.Emails.Services.EmailSender.SendEmailAsync(System.String,Definux.Emeraude.Application.Emails.EmailModel)')
- [ServiceCollectionExtensions](#T-Definux-Emeraude-Emails-Extensions-ServiceCollectionExtensions 'Definux.Emeraude.Emails.Extensions.ServiceCollectionExtensions')
  - [RegisterEmailSender(services)](#M-Definux-Emeraude-Emails-Extensions-ServiceCollectionExtensions-RegisterEmailSender-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Definux.Emeraude.Emails.Extensions.ServiceCollectionExtensions.RegisterEmailSender(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
- [StringExtensions](#T-Definux-Emeraude-Emails-Extensions-StringExtensions 'Definux.Emeraude.Emails.Extensions.StringExtensions')
  - [ToLanguageSuffix(targetString,languageCode)](#M-Definux-Emeraude-Emails-Extensions-StringExtensions-ToLanguageSuffix-System-String,System-String- 'Definux.Emeraude.Emails.Extensions.StringExtensions.ToLanguageSuffix(System.String,System.String)')

<a name='T-Definux-Emeraude-Emails-Services-EmailSender'></a>
## EmailSender `type`

##### Namespace

Definux.Emeraude.Emails.Services

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Emails-Services-EmailSender-#ctor-Definux-Emeraude-Application-Logger-IEmLogger,Microsoft-AspNetCore-Mvc-Razor-IRazorViewEngine,Microsoft-AspNetCore-Mvc-ViewFeatures-ITempDataProvider,System-IServiceProvider,Microsoft-Extensions-Options-IOptions{Definux-Utilities-Options-SmtpOptions}-'></a>
### #ctor(logger,razorViewEngine,tempDataProvider,serviceProvider,smtpOptionsAccessor) `constructor`

##### Summary

Initializes a new instance of the [EmailSender](#T-Definux-Emeraude-Emails-Services-EmailSender 'Definux.Emeraude.Emails.Services.EmailSender') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |
| razorViewEngine | [Microsoft.AspNetCore.Mvc.Razor.IRazorViewEngine](#T-Microsoft-AspNetCore-Mvc-Razor-IRazorViewEngine 'Microsoft.AspNetCore.Mvc.Razor.IRazorViewEngine') |  |
| tempDataProvider | [Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataProvider](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ITempDataProvider 'Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataProvider') |  |
| serviceProvider | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') |  |
| smtpOptionsAccessor | [Microsoft.Extensions.Options.IOptions{Definux.Utilities.Options.SmtpOptions}](#T-Microsoft-Extensions-Options-IOptions{Definux-Utilities-Options-SmtpOptions} 'Microsoft.Extensions.Options.IOptions{Definux.Utilities.Options.SmtpOptions}') |  |

<a name='M-Definux-Emeraude-Emails-Services-EmailSender-SendEmailAsync-System-String,Definux-Emeraude-Application-Emails-EmailModel-'></a>
### SendEmailAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Emails-Extensions-ServiceCollectionExtensions'></a>
## ServiceCollectionExtensions `type`

##### Namespace

Definux.Emeraude.Emails.Extensions

##### Summary

Extensions for [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection').

<a name='M-Definux-Emeraude-Emails-Extensions-ServiceCollectionExtensions-RegisterEmailSender-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### RegisterEmailSender(services) `method`

##### Summary

Registers email infrastructure.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |

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
