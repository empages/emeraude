<a name='assembly'></a>
# Definux.Emeraude.Logger

## Contents

- [ActivityLogConfiguration](#T-Definux-Emeraude-Logger-Configuration-ActivityLogConfiguration 'Definux.Emeraude.Logger.Configuration.ActivityLogConfiguration')
  - [Configure()](#M-Definux-Emeraude-Logger-Configuration-ActivityLogConfiguration-Configure-Microsoft-EntityFrameworkCore-Metadata-Builders-EntityTypeBuilder{Definux-Emeraude-Domain-Logging-ActivityLog}- 'Definux.Emeraude.Logger.Configuration.ActivityLogConfiguration.Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder{Definux.Emeraude.Domain.Logging.ActivityLog})')
- [AssemblyInfo](#T-Definux-Emeraude-Logger-AssemblyInfo 'Definux.Emeraude.Logger.AssemblyInfo')
  - [GetAssembly()](#M-Definux-Emeraude-Logger-AssemblyInfo-GetAssembly 'Definux.Emeraude.Logger.AssemblyInfo.GetAssembly')
- [EmailLogConfiguration](#T-Definux-Emeraude-Logger-Configuration-EmailLogConfiguration 'Definux.Emeraude.Logger.Configuration.EmailLogConfiguration')
  - [Configure()](#M-Definux-Emeraude-Logger-Configuration-EmailLogConfiguration-Configure-Microsoft-EntityFrameworkCore-Metadata-Builders-EntityTypeBuilder{Definux-Emeraude-Domain-Logging-EmailLog}- 'Definux.Emeraude.Logger.Configuration.EmailLogConfiguration.Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder{Definux.Emeraude.Domain.Logging.EmailLog})')
- [ErrorLogConfiguration](#T-Definux-Emeraude-Logger-Configuration-ErrorLogConfiguration 'Definux.Emeraude.Logger.Configuration.ErrorLogConfiguration')
  - [Configure()](#M-Definux-Emeraude-Logger-Configuration-ErrorLogConfiguration-Configure-Microsoft-EntityFrameworkCore-Metadata-Builders-EntityTypeBuilder{Definux-Emeraude-Domain-Logging-ErrorLog}- 'Definux.Emeraude.Logger.Configuration.ErrorLogConfiguration.Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder{Definux.Emeraude.Domain.Logging.ErrorLog})')
- [Logger](#T-Definux-Emeraude-Logger-Logger 'Definux.Emeraude.Logger.Logger')
  - [#ctor(context)](#M-Definux-Emeraude-Logger-Logger-#ctor-Definux-Emeraude-Logger-LoggerContext- 'Definux.Emeraude.Logger.Logger.#ctor(Definux.Emeraude.Logger.LoggerContext)')
  - [LogActivity()](#M-Definux-Emeraude-Logger-Logger-LogActivity-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext,System-Boolean- 'Definux.Emeraude.Logger.Logger.LogActivity(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext,System.Boolean)')
  - [LogEmailAsync()](#M-Definux-Emeraude-Logger-Logger-LogEmailAsync-System-String,System-String,System-String,System-String,System-Boolean- 'Definux.Emeraude.Logger.Logger.LogEmailAsync(System.String,System.String,System.String,System.String,System.Boolean)')
  - [LogError()](#M-Definux-Emeraude-Logger-Logger-LogError-System-Exception,System-String- 'Definux.Emeraude.Logger.Logger.LogError(System.Exception,System.String)')
  - [LogErrorAsync()](#M-Definux-Emeraude-Logger-Logger-LogErrorAsync-System-Exception,System-String- 'Definux.Emeraude.Logger.Logger.LogErrorAsync(System.Exception,System.String)')
  - [LogErrorWithoutAnException()](#M-Definux-Emeraude-Logger-Logger-LogErrorWithoutAnException-System-String,System-String,System-String- 'Definux.Emeraude.Logger.Logger.LogErrorWithoutAnException(System.String,System.String,System.String)')
- [LoggerContext](#T-Definux-Emeraude-Logger-LoggerContext 'Definux.Emeraude.Logger.LoggerContext')
  - [#ctor(options,httpContextAccessor,optionsAccessor)](#M-Definux-Emeraude-Logger-LoggerContext-#ctor-Microsoft-EntityFrameworkCore-DbContextOptions{Definux-Emeraude-Logger-LoggerContext},Microsoft-AspNetCore-Http-IHttpContextAccessor,Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions}- 'Definux.Emeraude.Logger.LoggerContext.#ctor(Microsoft.EntityFrameworkCore.DbContextOptions{Definux.Emeraude.Logger.LoggerContext},Microsoft.AspNetCore.Http.IHttpContextAccessor,Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions})')
  - [ActivityLogs](#P-Definux-Emeraude-Logger-LoggerContext-ActivityLogs 'Definux.Emeraude.Logger.LoggerContext.ActivityLogs')
  - [EmailLogs](#P-Definux-Emeraude-Logger-LoggerContext-EmailLogs 'Definux.Emeraude.Logger.LoggerContext.EmailLogs')
  - [ErrorLogs](#P-Definux-Emeraude-Logger-LoggerContext-ErrorLogs 'Definux.Emeraude.Logger.LoggerContext.ErrorLogs')
  - [TempFileLogs](#P-Definux-Emeraude-Logger-LoggerContext-TempFileLogs 'Definux.Emeraude.Logger.LoggerContext.TempFileLogs')
  - [OnModelCreating()](#M-Definux-Emeraude-Logger-LoggerContext-OnModelCreating-Microsoft-EntityFrameworkCore-ModelBuilder- 'Definux.Emeraude.Logger.LoggerContext.OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder)')
  - [SaveChanges()](#M-Definux-Emeraude-Logger-LoggerContext-SaveChanges 'Definux.Emeraude.Logger.LoggerContext.SaveChanges')
  - [SaveChanges()](#M-Definux-Emeraude-Logger-LoggerContext-SaveChanges-System-Boolean- 'Definux.Emeraude.Logger.LoggerContext.SaveChanges(System.Boolean)')
  - [SaveChangesAsync()](#M-Definux-Emeraude-Logger-LoggerContext-SaveChangesAsync-System-Boolean,System-Threading-CancellationToken- 'Definux.Emeraude.Logger.LoggerContext.SaveChangesAsync(System.Boolean,System.Threading.CancellationToken)')
  - [SaveChangesAsync()](#M-Definux-Emeraude-Logger-LoggerContext-SaveChangesAsync-System-Threading-CancellationToken- 'Definux.Emeraude.Logger.LoggerContext.SaveChangesAsync(System.Threading.CancellationToken)')
  - [UpdateAuditableEntities()](#M-Definux-Emeraude-Logger-LoggerContext-UpdateAuditableEntities 'Definux.Emeraude.Logger.LoggerContext.UpdateAuditableEntities')
- [LoggerEntityConfigurationBuilder](#T-Definux-Emeraude-Logger-Configuration-LoggerEntityConfigurationBuilder 'Definux.Emeraude.Logger.Configuration.LoggerEntityConfigurationBuilder')
  - [ConfigureLoggerEntity\`\`1(builder)](#M-Definux-Emeraude-Logger-Configuration-LoggerEntityConfigurationBuilder-ConfigureLoggerEntity``1-Microsoft-EntityFrameworkCore-Metadata-Builders-EntityTypeBuilder{``0}- 'Definux.Emeraude.Logger.Configuration.LoggerEntityConfigurationBuilder.ConfigureLoggerEntity``1(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder{``0})')
- [ServiceCollectionExtensions](#T-Definux-Emeraude-Logger-Extensions-ServiceCollectionExtensions 'Definux.Emeraude.Logger.Extensions.ServiceCollectionExtensions')
  - [RegisterEmeraudeLogger(services,configuration,options)](#M-Definux-Emeraude-Logger-Extensions-ServiceCollectionExtensions-RegisterEmeraudeLogger-Microsoft-Extensions-DependencyInjection-IServiceCollection,Microsoft-Extensions-Configuration-IConfiguration,Definux-Emeraude-Configuration-Options-EmOptions- 'Definux.Emeraude.Logger.Extensions.ServiceCollectionExtensions.RegisterEmeraudeLogger(Microsoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration,Definux.Emeraude.Configuration.Options.EmOptions)')
- [TempFileLogConfiguration](#T-Definux-Emeraude-Logger-Configuration-TempFileLogConfiguration 'Definux.Emeraude.Logger.Configuration.TempFileLogConfiguration')
  - [Configure()](#M-Definux-Emeraude-Logger-Configuration-TempFileLogConfiguration-Configure-Microsoft-EntityFrameworkCore-Metadata-Builders-EntityTypeBuilder{Definux-Emeraude-Domain-Logging-TempFileLog}- 'Definux.Emeraude.Logger.Configuration.TempFileLogConfiguration.Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder{Definux.Emeraude.Domain.Logging.TempFileLog})')

<a name='T-Definux-Emeraude-Logger-Configuration-ActivityLogConfiguration'></a>
## ActivityLogConfiguration `type`

##### Namespace

Definux.Emeraude.Logger.Configuration

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Logger-Configuration-ActivityLogConfiguration-Configure-Microsoft-EntityFrameworkCore-Metadata-Builders-EntityTypeBuilder{Definux-Emeraude-Domain-Logging-ActivityLog}-'></a>
### Configure() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Logger-AssemblyInfo'></a>
## AssemblyInfo `type`

##### Namespace

Definux.Emeraude.Logger

##### Summary

Assembly info provider.

<a name='M-Definux-Emeraude-Logger-AssemblyInfo-GetAssembly'></a>
### GetAssembly() `method`

##### Summary

Gets execution assembly.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Logger-Configuration-EmailLogConfiguration'></a>
## EmailLogConfiguration `type`

##### Namespace

Definux.Emeraude.Logger.Configuration

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Logger-Configuration-EmailLogConfiguration-Configure-Microsoft-EntityFrameworkCore-Metadata-Builders-EntityTypeBuilder{Definux-Emeraude-Domain-Logging-EmailLog}-'></a>
### Configure() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Logger-Configuration-ErrorLogConfiguration'></a>
## ErrorLogConfiguration `type`

##### Namespace

Definux.Emeraude.Logger.Configuration

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Logger-Configuration-ErrorLogConfiguration-Configure-Microsoft-EntityFrameworkCore-Metadata-Builders-EntityTypeBuilder{Definux-Emeraude-Domain-Logging-ErrorLog}-'></a>
### Configure() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Logger-Logger'></a>
## Logger `type`

##### Namespace

Definux.Emeraude.Logger

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Logger-Logger-#ctor-Definux-Emeraude-Logger-LoggerContext-'></a>
### #ctor(context) `constructor`

##### Summary

Initializes a new instance of the [Logger](#T-Definux-Emeraude-Logger-Logger 'Definux.Emeraude.Logger.Logger') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Definux.Emeraude.Logger.LoggerContext](#T-Definux-Emeraude-Logger-LoggerContext 'Definux.Emeraude.Logger.LoggerContext') |  |

<a name='M-Definux-Emeraude-Logger-Logger-LogActivity-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext,System-Boolean-'></a>
### LogActivity() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Logger-Logger-LogEmailAsync-System-String,System-String,System-String,System-String,System-Boolean-'></a>
### LogEmailAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Logger-Logger-LogError-System-Exception,System-String-'></a>
### LogError() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Logger-Logger-LogErrorAsync-System-Exception,System-String-'></a>
### LogErrorAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Logger-Logger-LogErrorWithoutAnException-System-String,System-String,System-String-'></a>
### LogErrorWithoutAnException() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Logger-LoggerContext'></a>
## LoggerContext `type`

##### Namespace

Definux.Emeraude.Logger

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Logger-LoggerContext-#ctor-Microsoft-EntityFrameworkCore-DbContextOptions{Definux-Emeraude-Logger-LoggerContext},Microsoft-AspNetCore-Http-IHttpContextAccessor,Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions}-'></a>
### #ctor(options,httpContextAccessor,optionsAccessor) `constructor`

##### Summary

Initializes a new instance of the [LoggerContext](#T-Definux-Emeraude-Logger-LoggerContext 'Definux.Emeraude.Logger.LoggerContext') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [Microsoft.EntityFrameworkCore.DbContextOptions{Definux.Emeraude.Logger.LoggerContext}](#T-Microsoft-EntityFrameworkCore-DbContextOptions{Definux-Emeraude-Logger-LoggerContext} 'Microsoft.EntityFrameworkCore.DbContextOptions{Definux.Emeraude.Logger.LoggerContext}') |  |
| httpContextAccessor | [Microsoft.AspNetCore.Http.IHttpContextAccessor](#T-Microsoft-AspNetCore-Http-IHttpContextAccessor 'Microsoft.AspNetCore.Http.IHttpContextAccessor') |  |
| optionsAccessor | [Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions}](#T-Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions} 'Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions}') |  |

<a name='P-Definux-Emeraude-Logger-LoggerContext-ActivityLogs'></a>
### ActivityLogs `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Logger-LoggerContext-EmailLogs'></a>
### EmailLogs `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Logger-LoggerContext-ErrorLogs'></a>
### ErrorLogs `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Logger-LoggerContext-TempFileLogs'></a>
### TempFileLogs `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Logger-LoggerContext-OnModelCreating-Microsoft-EntityFrameworkCore-ModelBuilder-'></a>
### OnModelCreating() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Logger-LoggerContext-SaveChanges'></a>
### SaveChanges() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Logger-LoggerContext-SaveChanges-System-Boolean-'></a>
### SaveChanges() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Logger-LoggerContext-SaveChangesAsync-System-Boolean,System-Threading-CancellationToken-'></a>
### SaveChangesAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Logger-LoggerContext-SaveChangesAsync-System-Threading-CancellationToken-'></a>
### SaveChangesAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Logger-LoggerContext-UpdateAuditableEntities'></a>
### UpdateAuditableEntities() `method`

##### Summary

Method that automatically update all dates and users of all tracked entities.

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Logger-Configuration-LoggerEntityConfigurationBuilder'></a>
## LoggerEntityConfigurationBuilder `type`

##### Namespace

Definux.Emeraude.Logger.Configuration

##### Summary

Extensions for [EntityTypeBuilder\`1](#T-Microsoft-EntityFrameworkCore-Metadata-Builders-EntityTypeBuilder`1 'Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder`1').

<a name='M-Definux-Emeraude-Logger-Configuration-LoggerEntityConfigurationBuilder-ConfigureLoggerEntity``1-Microsoft-EntityFrameworkCore-Metadata-Builders-EntityTypeBuilder{``0}-'></a>
### ConfigureLoggerEntity\`\`1(builder) `method`

##### Summary

Configure abstract logger entity properties.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder{\`\`0}](#T-Microsoft-EntityFrameworkCore-Metadata-Builders-EntityTypeBuilder{``0} 'Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder{``0}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | Target entity. |

<a name='T-Definux-Emeraude-Logger-Extensions-ServiceCollectionExtensions'></a>
## ServiceCollectionExtensions `type`

##### Namespace

Definux.Emeraude.Logger.Extensions

##### Summary

Extensions for [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection').

<a name='M-Definux-Emeraude-Logger-Extensions-ServiceCollectionExtensions-RegisterEmeraudeLogger-Microsoft-Extensions-DependencyInjection-IServiceCollection,Microsoft-Extensions-Configuration-IConfiguration,Definux-Emeraude-Configuration-Options-EmOptions-'></a>
### RegisterEmeraudeLogger(services,configuration,options) `method`

##### Summary

Register Emeraude logger feature elements and services.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |
| configuration | [Microsoft.Extensions.Configuration.IConfiguration](#T-Microsoft-Extensions-Configuration-IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') |  |
| options | [Definux.Emeraude.Configuration.Options.EmOptions](#T-Definux-Emeraude-Configuration-Options-EmOptions 'Definux.Emeraude.Configuration.Options.EmOptions') |  |

<a name='T-Definux-Emeraude-Logger-Configuration-TempFileLogConfiguration'></a>
## TempFileLogConfiguration `type`

##### Namespace

Definux.Emeraude.Logger.Configuration

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Logger-Configuration-TempFileLogConfiguration-Configure-Microsoft-EntityFrameworkCore-Metadata-Builders-EntityTypeBuilder{Definux-Emeraude-Domain-Logging-TempFileLog}-'></a>
### Configure() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.
