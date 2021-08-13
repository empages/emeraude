<a name='assembly'></a>
# Definux.Emeraude.Files

## Contents

- [EmFilesOptions](#T-Definux-Emeraude-Files-EmFilesOptions 'Definux.Emeraude.Files.EmFilesOptions')
  - [AllowFileUpload](#P-Definux-Emeraude-Files-EmFilesOptions-AllowFileUpload 'Definux.Emeraude.Files.EmFilesOptions.AllowFileUpload')
  - [AllowImageUpload](#P-Definux-Emeraude-Files-EmFilesOptions-AllowImageUpload 'Definux.Emeraude.Files.EmFilesOptions.AllowImageUpload')
  - [AllowVideoUpload](#P-Definux-Emeraude-Files-EmFilesOptions-AllowVideoUpload 'Definux.Emeraude.Files.EmFilesOptions.AllowVideoUpload')
  - [MaxAllowedFileSize](#P-Definux-Emeraude-Files-EmFilesOptions-MaxAllowedFileSize 'Definux.Emeraude.Files.EmFilesOptions.MaxAllowedFileSize')
  - [MaxAllowedImageFileSize](#P-Definux-Emeraude-Files-EmFilesOptions-MaxAllowedImageFileSize 'Definux.Emeraude.Files.EmFilesOptions.MaxAllowedImageFileSize')
  - [MaxAllowedVideoFileSize](#P-Definux-Emeraude-Files-EmFilesOptions-MaxAllowedVideoFileSize 'Definux.Emeraude.Files.EmFilesOptions.MaxAllowedVideoFileSize')
- [FileExtensionHandler](#T-Definux-Emeraude-Files-Validation-Handlers-FileExtensionHandler 'Definux.Emeraude.Files.Validation.Handlers.FileExtensionHandler')
  - [#ctor(allowedFileExtensions)](#M-Definux-Emeraude-Files-Validation-Handlers-FileExtensionHandler-#ctor-System-Collections-Generic-List{Definux-Utilities-Enumerations-FileExtensions}- 'Definux.Emeraude.Files.Validation.Handlers.FileExtensionHandler.#ctor(System.Collections.Generic.List{Definux.Utilities.Enumerations.FileExtensions})')
  - [HandleProcessAction()](#M-Definux-Emeraude-Files-Validation-Handlers-FileExtensionHandler-HandleProcessAction 'Definux.Emeraude.Files.Validation.Handlers.FileExtensionHandler.HandleProcessAction')
- [FileMimeTypesHandler](#T-Definux-Emeraude-Files-Validation-Handlers-FileMimeTypesHandler 'Definux.Emeraude.Files.Validation.Handlers.FileMimeTypesHandler')
  - [#ctor(allowedMimeTypes)](#M-Definux-Emeraude-Files-Validation-Handlers-FileMimeTypesHandler-#ctor-System-Collections-Generic-List{System-String}- 'Definux.Emeraude.Files.Validation.Handlers.FileMimeTypesHandler.#ctor(System.Collections.Generic.List{System.String})')
  - [HandleProcessAction()](#M-Definux-Emeraude-Files-Validation-Handlers-FileMimeTypesHandler-HandleProcessAction 'Definux.Emeraude.Files.Validation.Handlers.FileMimeTypesHandler.HandleProcessAction')
- [FileSizeHandler](#T-Definux-Emeraude-Files-Validation-Handlers-FileSizeHandler 'Definux.Emeraude.Files.Validation.Handlers.FileSizeHandler')
  - [#ctor(maxAllowedFileSize)](#M-Definux-Emeraude-Files-Validation-Handlers-FileSizeHandler-#ctor-System-Int64- 'Definux.Emeraude.Files.Validation.Handlers.FileSizeHandler.#ctor(System.Int64)')
  - [HandleProcessAction()](#M-Definux-Emeraude-Files-Validation-Handlers-FileSizeHandler-HandleProcessAction 'Definux.Emeraude.Files.Validation.Handlers.FileSizeHandler.HandleProcessAction')
- [FilesValidationProvider](#T-Definux-Emeraude-Files-Validation-FilesValidationProvider 'Definux.Emeraude.Files.Validation.FilesValidationProvider')
  - [#ctor(optionsAccessor)](#M-Definux-Emeraude-Files-Validation-FilesValidationProvider-#ctor-Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions}- 'Definux.Emeraude.Files.Validation.FilesValidationProvider.#ctor(Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions})')
  - [ValidateFormFile()](#M-Definux-Emeraude-Files-Validation-FilesValidationProvider-ValidateFormFile-Microsoft-AspNetCore-Http-IFormFile,System-Collections-Generic-List{Definux-Utilities-Enumerations-FileExtensions},System-Collections-Generic-List{System-String},System-Int64- 'Definux.Emeraude.Files.Validation.FilesValidationProvider.ValidateFormFile(Microsoft.AspNetCore.Http.IFormFile,System.Collections.Generic.List{Definux.Utilities.Enumerations.FileExtensions},System.Collections.Generic.List{System.String},System.Int64)')
  - [ValidateFormImageFile()](#M-Definux-Emeraude-Files-Validation-FilesValidationProvider-ValidateFormImageFile-Microsoft-AspNetCore-Http-IFormFile,System-Collections-Generic-List{Definux-Utilities-Enumerations-FileExtensions},System-Collections-Generic-List{System-String},System-Int64- 'Definux.Emeraude.Files.Validation.FilesValidationProvider.ValidateFormImageFile(Microsoft.AspNetCore.Http.IFormFile,System.Collections.Generic.List{Definux.Utilities.Enumerations.FileExtensions},System.Collections.Generic.List{System.String},System.Int64)')
  - [ValidateFormVideoFile()](#M-Definux-Emeraude-Files-Validation-FilesValidationProvider-ValidateFormVideoFile-Microsoft-AspNetCore-Http-IFormFile,System-Collections-Generic-List{Definux-Utilities-Enumerations-FileExtensions},System-Collections-Generic-List{System-String},System-Int64- 'Definux.Emeraude.Files.Validation.FilesValidationProvider.ValidateFormVideoFile(Microsoft.AspNetCore.Http.IFormFile,System.Collections.Generic.List{Definux.Utilities.Enumerations.FileExtensions},System.Collections.Generic.List{System.String},System.Int64)')
- [FoldersInitializer](#T-Definux-Emeraude-Files-Services-FoldersInitializer 'Definux.Emeraude.Files.Services.FoldersInitializer')
  - [#ctor(logger,hostingEnvironment)](#M-Definux-Emeraude-Files-Services-FoldersInitializer-#ctor-Definux-Emeraude-Application-Logger-IEmLogger,Microsoft-AspNetCore-Hosting-IHostingEnvironment- 'Definux.Emeraude.Files.Services.FoldersInitializer.#ctor(Definux.Emeraude.Application.Logger.IEmLogger,Microsoft.AspNetCore.Hosting.IHostingEnvironment)')
  - [InitFoldersAsync()](#M-Definux-Emeraude-Files-Services-FoldersInitializer-InitFoldersAsync 'Definux.Emeraude.Files.Services.FoldersInitializer.InitFoldersAsync')
- [HostingEnvironmentExtensions](#T-Definux-Emeraude-Files-Extensions-HostingEnvironmentExtensions 'Definux.Emeraude.Files.Extensions.HostingEnvironmentExtensions')
  - [GetTempUploadDirectory(hostingEnvironment)](#M-Definux-Emeraude-Files-Extensions-HostingEnvironmentExtensions-GetTempUploadDirectory-Microsoft-AspNetCore-Hosting-IHostingEnvironment- 'Definux.Emeraude.Files.Extensions.HostingEnvironmentExtensions.GetTempUploadDirectory(Microsoft.AspNetCore.Hosting.IHostingEnvironment)')
- [ImageBoxingHandler](#T-Definux-Emeraude-Files-Validation-Handlers-ImageBoxingHandler 'Definux.Emeraude.Files.Validation.Handlers.ImageBoxingHandler')
  - [HandleProcessAction()](#M-Definux-Emeraude-Files-Validation-Handlers-ImageBoxingHandler-HandleProcessAction 'Definux.Emeraude.Files.Validation.Handlers.ImageBoxingHandler.HandleProcessAction')
- [OptionsExtensions](#T-Definux-Emeraude-Files-Extensions-OptionsExtensions 'Definux.Emeraude.Files.Extensions.OptionsExtensions')
  - [ConfigureFilesInfrastructure(options,filesOptionsAction)](#M-Definux-Emeraude-Files-Extensions-OptionsExtensions-ConfigureFilesInfrastructure-Definux-Emeraude-Configuration-Options-EmOptions,System-Action{Definux-Emeraude-Files-EmFilesOptions}- 'Definux.Emeraude.Files.Extensions.OptionsExtensions.ConfigureFilesInfrastructure(Definux.Emeraude.Configuration.Options.EmOptions,System.Action{Definux.Emeraude.Files.EmFilesOptions})')
  - [GetFilesOptions(options)](#M-Definux-Emeraude-Files-Extensions-OptionsExtensions-GetFilesOptions-Definux-Emeraude-Configuration-Options-EmOptions- 'Definux.Emeraude.Files.Extensions.OptionsExtensions.GetFilesOptions(Definux.Emeraude.Configuration.Options.EmOptions)')
- [RootsService](#T-Definux-Emeraude-Files-Services-RootsService 'Definux.Emeraude.Files.Services.RootsService')
  - [#ctor(hostingEnvironment)](#M-Definux-Emeraude-Files-Services-RootsService-#ctor-Microsoft-AspNetCore-Hosting-IHostingEnvironment- 'Definux.Emeraude.Files.Services.RootsService.#ctor(Microsoft.AspNetCore.Hosting.IHostingEnvironment)')
  - [PrivateRootDirectory](#P-Definux-Emeraude-Files-Services-RootsService-PrivateRootDirectory 'Definux.Emeraude.Files.Services.RootsService.PrivateRootDirectory')
  - [PublicRootDirectory](#P-Definux-Emeraude-Files-Services-RootsService-PublicRootDirectory 'Definux.Emeraude.Files.Services.RootsService.PublicRootDirectory')
  - [GetPathFromPrivateRoot()](#M-Definux-Emeraude-Files-Services-RootsService-GetPathFromPrivateRoot-System-String[]- 'Definux.Emeraude.Files.Services.RootsService.GetPathFromPrivateRoot(System.String[])')
  - [GetPathFromPublicRoot()](#M-Definux-Emeraude-Files-Services-RootsService-GetPathFromPublicRoot-System-String[]- 'Definux.Emeraude.Files.Services.RootsService.GetPathFromPublicRoot(System.String[])')
- [ServiceCollectionExtensions](#T-Definux-Emeraude-Files-Extensions-ServiceCollectionExtensions 'Definux.Emeraude.Files.Extensions.ServiceCollectionExtensions')
  - [RegisterEmeraudeSystemFilesManagement(services,options)](#M-Definux-Emeraude-Files-Extensions-ServiceCollectionExtensions-RegisterEmeraudeSystemFilesManagement-Microsoft-Extensions-DependencyInjection-IServiceCollection,Definux-Emeraude-Files-EmFilesOptions- 'Definux.Emeraude.Files.Extensions.ServiceCollectionExtensions.RegisterEmeraudeSystemFilesManagement(Microsoft.Extensions.DependencyInjection.IServiceCollection,Definux.Emeraude.Files.EmFilesOptions)')
- [SystemFilesService](#T-Definux-Emeraude-Files-Services-SystemFilesService 'Definux.Emeraude.Files.Services.SystemFilesService')
  - [#ctor(logger,hostingEnvironment,loggerContext,rootsService)](#M-Definux-Emeraude-Files-Services-SystemFilesService-#ctor-Definux-Emeraude-Application-Logger-IEmLogger,Microsoft-AspNetCore-Hosting-IHostingEnvironment,Definux-Emeraude-Application-Logger-ILoggerContext,Definux-Emeraude-Application-Files-IRootsService- 'Definux.Emeraude.Files.Services.SystemFilesService.#ctor(Definux.Emeraude.Application.Logger.IEmLogger,Microsoft.AspNetCore.Hosting.IHostingEnvironment,Definux.Emeraude.Application.Logger.ILoggerContext,Definux.Emeraude.Application.Files.IRootsService)')
  - [ApplyTempFileToPrivateDirectoryAsync()](#M-Definux-Emeraude-Files-Services-SystemFilesService-ApplyTempFileToPrivateDirectoryAsync-System-Int32,System-String- 'Definux.Emeraude.Files.Services.SystemFilesService.ApplyTempFileToPrivateDirectoryAsync(System.Int32,System.String)')
  - [ApplyTempFileToPublicDirectoryAsync()](#M-Definux-Emeraude-Files-Services-SystemFilesService-ApplyTempFileToPublicDirectoryAsync-System-Int32,System-String- 'Definux.Emeraude.Files.Services.SystemFilesService.ApplyTempFileToPublicDirectoryAsync(System.Int32,System.String)')
  - [ApplyTempFilesToPrivateDirectoryAsync()](#M-Definux-Emeraude-Files-Services-SystemFilesService-ApplyTempFilesToPrivateDirectoryAsync-System-Collections-Generic-IEnumerable{System-Int32},System-String- 'Definux.Emeraude.Files.Services.SystemFilesService.ApplyTempFilesToPrivateDirectoryAsync(System.Collections.Generic.IEnumerable{System.Int32},System.String)')
  - [ApplyTempFilesToPublicDirectoryAsync()](#M-Definux-Emeraude-Files-Services-SystemFilesService-ApplyTempFilesToPublicDirectoryAsync-System-Collections-Generic-IEnumerable{System-Int32},System-String- 'Definux.Emeraude.Files.Services.SystemFilesService.ApplyTempFilesToPublicDirectoryAsync(System.Collections.Generic.IEnumerable{System.Int32},System.String)')
  - [CreateFolderAsync()](#M-Definux-Emeraude-Files-Services-SystemFilesService-CreateFolderAsync-System-String,System-String- 'Definux.Emeraude.Files.Services.SystemFilesService.CreateFolderAsync(System.String,System.String)')
  - [GetFileAsync()](#M-Definux-Emeraude-Files-Services-SystemFilesService-GetFileAsync-System-String- 'Definux.Emeraude.Files.Services.SystemFilesService.GetFileAsync(System.String)')
  - [GetFileById()](#M-Definux-Emeraude-Files-Services-SystemFilesService-GetFileById-System-Int32- 'Definux.Emeraude.Files.Services.SystemFilesService.GetFileById(System.Int32)')
  - [GetFileByIdAsync()](#M-Definux-Emeraude-Files-Services-SystemFilesService-GetFileByIdAsync-System-Int32- 'Definux.Emeraude.Files.Services.SystemFilesService.GetFileByIdAsync(System.Int32)')
  - [GetFilesByIds()](#M-Definux-Emeraude-Files-Services-SystemFilesService-GetFilesByIds-System-Collections-Generic-IEnumerable{System-Int32}- 'Definux.Emeraude.Files.Services.SystemFilesService.GetFilesByIds(System.Collections.Generic.IEnumerable{System.Int32})')
  - [GetFilesByIdsAsync()](#M-Definux-Emeraude-Files-Services-SystemFilesService-GetFilesByIdsAsync-System-Collections-Generic-IEnumerable{System-Int32}- 'Definux.Emeraude.Files.Services.SystemFilesService.GetFilesByIdsAsync(System.Collections.Generic.IEnumerable{System.Int32})')
  - [GetPublicRootFolderFilesRelativePaths()](#M-Definux-Emeraude-Files-Services-SystemFilesService-GetPublicRootFolderFilesRelativePaths-System-String[]- 'Definux.Emeraude.Files.Services.SystemFilesService.GetPublicRootFolderFilesRelativePaths(System.String[])')
  - [ScanDirectory()](#M-Definux-Emeraude-Files-Services-SystemFilesService-ScanDirectory-System-String,System-String- 'Definux.Emeraude.Files.Services.SystemFilesService.ScanDirectory(System.String,System.String)')
  - [ScanPrivateDirectory()](#M-Definux-Emeraude-Files-Services-SystemFilesService-ScanPrivateDirectory 'Definux.Emeraude.Files.Services.SystemFilesService.ScanPrivateDirectory')
  - [ScanPublicDirectory()](#M-Definux-Emeraude-Files-Services-SystemFilesService-ScanPublicDirectory 'Definux.Emeraude.Files.Services.SystemFilesService.ScanPublicDirectory')
- [UploadService](#T-Definux-Emeraude-Files-Services-UploadService 'Definux.Emeraude.Files.Services.UploadService')
  - [#ctor(loggerContext,logger,hostingEnvironment,rootsService)](#M-Definux-Emeraude-Files-Services-UploadService-#ctor-Definux-Emeraude-Application-Logger-ILoggerContext,Definux-Emeraude-Application-Logger-IEmLogger,Microsoft-AspNetCore-Hosting-IHostingEnvironment,Definux-Emeraude-Application-Files-IRootsService- 'Definux.Emeraude.Files.Services.UploadService.#ctor(Definux.Emeraude.Application.Logger.ILoggerContext,Definux.Emeraude.Application.Logger.IEmLogger,Microsoft.AspNetCore.Hosting.IHostingEnvironment,Definux.Emeraude.Application.Files.IRootsService)')
  - [UploadFileAsync()](#M-Definux-Emeraude-Files-Services-UploadService-UploadFileAsync-Microsoft-AspNetCore-Http-IFormFile- 'Definux.Emeraude.Files.Services.UploadService.UploadFileAsync(Microsoft.AspNetCore.Http.IFormFile)')
  - [UploadFileAsync()](#M-Definux-Emeraude-Files-Services-UploadService-UploadFileAsync-Microsoft-AspNetCore-Http-IFormFile,System-String,System-Boolean- 'Definux.Emeraude.Files.Services.UploadService.UploadFileAsync(Microsoft.AspNetCore.Http.IFormFile,System.String,System.Boolean)')

<a name='T-Definux-Emeraude-Files-EmFilesOptions'></a>
## EmFilesOptions `type`

##### Namespace

Definux.Emeraude.Files

##### Summary

Options for files infrastructure of Emeraude.

<a name='P-Definux-Emeraude-Files-EmFilesOptions-AllowFileUpload'></a>
### AllowFileUpload `property`

##### Summary

Enables file upload. The default value is true.

<a name='P-Definux-Emeraude-Files-EmFilesOptions-AllowImageUpload'></a>
### AllowImageUpload `property`

##### Summary

Enables image upload. The default value is false.

<a name='P-Definux-Emeraude-Files-EmFilesOptions-AllowVideoUpload'></a>
### AllowVideoUpload `property`

##### Summary

Enables video upload. The default value is false.

<a name='P-Definux-Emeraude-Files-EmFilesOptions-MaxAllowedFileSize'></a>
### MaxAllowedFileSize `property`

##### Summary

Maximum allowed upload file size. The default value is 20971520 bytes (~20MB).

<a name='P-Definux-Emeraude-Files-EmFilesOptions-MaxAllowedImageFileSize'></a>
### MaxAllowedImageFileSize `property`

##### Summary

Maximum allowed upload image size. The default value is 10485760 bytes (~10MB).

<a name='P-Definux-Emeraude-Files-EmFilesOptions-MaxAllowedVideoFileSize'></a>
### MaxAllowedVideoFileSize `property`

##### Summary

Maximum allowed upload video size. The default value is 209715200 bytes (~200MB).

<a name='T-Definux-Emeraude-Files-Validation-Handlers-FileExtensionHandler'></a>
## FileExtensionHandler `type`

##### Namespace

Definux.Emeraude.Files.Validation.Handlers

##### Summary

File validation handler for file extension.

<a name='M-Definux-Emeraude-Files-Validation-Handlers-FileExtensionHandler-#ctor-System-Collections-Generic-List{Definux-Utilities-Enumerations-FileExtensions}-'></a>
### #ctor(allowedFileExtensions) `constructor`

##### Summary

Initializes a new instance of the [FileExtensionHandler](#T-Definux-Emeraude-Files-Validation-Handlers-FileExtensionHandler 'Definux.Emeraude.Files.Validation.Handlers.FileExtensionHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| allowedFileExtensions | [System.Collections.Generic.List{Definux.Utilities.Enumerations.FileExtensions}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{Definux.Utilities.Enumerations.FileExtensions}') |  |

<a name='M-Definux-Emeraude-Files-Validation-Handlers-FileExtensionHandler-HandleProcessAction'></a>
### HandleProcessAction() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Files-Validation-Handlers-FileMimeTypesHandler'></a>
## FileMimeTypesHandler `type`

##### Namespace

Definux.Emeraude.Files.Validation.Handlers

##### Summary

File validation handler for MIME types.

<a name='M-Definux-Emeraude-Files-Validation-Handlers-FileMimeTypesHandler-#ctor-System-Collections-Generic-List{System-String}-'></a>
### #ctor(allowedMimeTypes) `constructor`

##### Summary

Initializes a new instance of the [FileMimeTypesHandler](#T-Definux-Emeraude-Files-Validation-Handlers-FileMimeTypesHandler 'Definux.Emeraude.Files.Validation.Handlers.FileMimeTypesHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| allowedMimeTypes | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') |  |

<a name='M-Definux-Emeraude-Files-Validation-Handlers-FileMimeTypesHandler-HandleProcessAction'></a>
### HandleProcessAction() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Files-Validation-Handlers-FileSizeHandler'></a>
## FileSizeHandler `type`

##### Namespace

Definux.Emeraude.Files.Validation.Handlers

##### Summary

File validation handler for the size of the file.

<a name='M-Definux-Emeraude-Files-Validation-Handlers-FileSizeHandler-#ctor-System-Int64-'></a>
### #ctor(maxAllowedFileSize) `constructor`

##### Summary

Initializes a new instance of the [FileSizeHandler](#T-Definux-Emeraude-Files-Validation-Handlers-FileSizeHandler 'Definux.Emeraude.Files.Validation.Handlers.FileSizeHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| maxAllowedFileSize | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |

<a name='M-Definux-Emeraude-Files-Validation-Handlers-FileSizeHandler-HandleProcessAction'></a>
### HandleProcessAction() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Files-Validation-FilesValidationProvider'></a>
## FilesValidationProvider `type`

##### Namespace

Definux.Emeraude.Files.Validation

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Files-Validation-FilesValidationProvider-#ctor-Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions}-'></a>
### #ctor(optionsAccessor) `constructor`

##### Summary

Initializes a new instance of the [FilesValidationProvider](#T-Definux-Emeraude-Files-Validation-FilesValidationProvider 'Definux.Emeraude.Files.Validation.FilesValidationProvider') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| optionsAccessor | [Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions}](#T-Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions} 'Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions}') |  |

<a name='M-Definux-Emeraude-Files-Validation-FilesValidationProvider-ValidateFormFile-Microsoft-AspNetCore-Http-IFormFile,System-Collections-Generic-List{Definux-Utilities-Enumerations-FileExtensions},System-Collections-Generic-List{System-String},System-Int64-'></a>
### ValidateFormFile() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Files-Validation-FilesValidationProvider-ValidateFormImageFile-Microsoft-AspNetCore-Http-IFormFile,System-Collections-Generic-List{Definux-Utilities-Enumerations-FileExtensions},System-Collections-Generic-List{System-String},System-Int64-'></a>
### ValidateFormImageFile() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Files-Validation-FilesValidationProvider-ValidateFormVideoFile-Microsoft-AspNetCore-Http-IFormFile,System-Collections-Generic-List{Definux-Utilities-Enumerations-FileExtensions},System-Collections-Generic-List{System-String},System-Int64-'></a>
### ValidateFormVideoFile() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Files-Services-FoldersInitializer'></a>
## FoldersInitializer `type`

##### Namespace

Definux.Emeraude.Files.Services

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Files-Services-FoldersInitializer-#ctor-Definux-Emeraude-Application-Logger-IEmLogger,Microsoft-AspNetCore-Hosting-IHostingEnvironment-'></a>
### #ctor(logger,hostingEnvironment) `constructor`

##### Summary

Initializes a new instance of the [FoldersInitializer](#T-Definux-Emeraude-Files-Services-FoldersInitializer 'Definux.Emeraude.Files.Services.FoldersInitializer') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |
| hostingEnvironment | [Microsoft.AspNetCore.Hosting.IHostingEnvironment](#T-Microsoft-AspNetCore-Hosting-IHostingEnvironment 'Microsoft.AspNetCore.Hosting.IHostingEnvironment') |  |

<a name='M-Definux-Emeraude-Files-Services-FoldersInitializer-InitFoldersAsync'></a>
### InitFoldersAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Files-Extensions-HostingEnvironmentExtensions'></a>
## HostingEnvironmentExtensions `type`

##### Namespace

Definux.Emeraude.Files.Extensions

##### Summary

Extensions for [IHostingEnvironment](#T-Microsoft-AspNetCore-Hosting-IHostingEnvironment 'Microsoft.AspNetCore.Hosting.IHostingEnvironment').

<a name='M-Definux-Emeraude-Files-Extensions-HostingEnvironmentExtensions-GetTempUploadDirectory-Microsoft-AspNetCore-Hosting-IHostingEnvironment-'></a>
### GetTempUploadDirectory(hostingEnvironment) `method`

##### Summary

Get temp directory for upload.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hostingEnvironment | [Microsoft.AspNetCore.Hosting.IHostingEnvironment](#T-Microsoft-AspNetCore-Hosting-IHostingEnvironment 'Microsoft.AspNetCore.Hosting.IHostingEnvironment') |  |

<a name='T-Definux-Emeraude-Files-Validation-Handlers-ImageBoxingHandler'></a>
## ImageBoxingHandler `type`

##### Namespace

Definux.Emeraude.Files.Validation.Handlers

##### Summary

File validation handler that check whether a file can be cast to a image.

<a name='M-Definux-Emeraude-Files-Validation-Handlers-ImageBoxingHandler-HandleProcessAction'></a>
### HandleProcessAction() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Files-Extensions-OptionsExtensions'></a>
## OptionsExtensions `type`

##### Namespace

Definux.Emeraude.Files.Extensions

##### Summary

Extensions for [EmOptions](#T-Definux-Emeraude-Configuration-Options-EmOptions 'Definux.Emeraude.Configuration.Options.EmOptions').

<a name='M-Definux-Emeraude-Files-Extensions-OptionsExtensions-ConfigureFilesInfrastructure-Definux-Emeraude-Configuration-Options-EmOptions,System-Action{Definux-Emeraude-Files-EmFilesOptions}-'></a>
### ConfigureFilesInfrastructure(options,filesOptionsAction) `method`

##### Summary

Add external Emeraude files options.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [Definux.Emeraude.Configuration.Options.EmOptions](#T-Definux-Emeraude-Configuration-Options-EmOptions 'Definux.Emeraude.Configuration.Options.EmOptions') |  |
| filesOptionsAction | [System.Action{Definux.Emeraude.Files.EmFilesOptions}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Definux.Emeraude.Files.EmFilesOptions}') |  |

<a name='M-Definux-Emeraude-Files-Extensions-OptionsExtensions-GetFilesOptions-Definux-Emeraude-Configuration-Options-EmOptions-'></a>
### GetFilesOptions(options) `method`

##### Summary

Get Emeraude files infrastructure options.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [Definux.Emeraude.Configuration.Options.EmOptions](#T-Definux-Emeraude-Configuration-Options-EmOptions 'Definux.Emeraude.Configuration.Options.EmOptions') |  |

<a name='T-Definux-Emeraude-Files-Services-RootsService'></a>
## RootsService `type`

##### Namespace

Definux.Emeraude.Files.Services

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Files-Services-RootsService-#ctor-Microsoft-AspNetCore-Hosting-IHostingEnvironment-'></a>
### #ctor(hostingEnvironment) `constructor`

##### Summary

Initializes a new instance of the [RootsService](#T-Definux-Emeraude-Files-Services-RootsService 'Definux.Emeraude.Files.Services.RootsService') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hostingEnvironment | [Microsoft.AspNetCore.Hosting.IHostingEnvironment](#T-Microsoft-AspNetCore-Hosting-IHostingEnvironment 'Microsoft.AspNetCore.Hosting.IHostingEnvironment') |  |

<a name='P-Definux-Emeraude-Files-Services-RootsService-PrivateRootDirectory'></a>
### PrivateRootDirectory `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Files-Services-RootsService-PublicRootDirectory'></a>
### PublicRootDirectory `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Files-Services-RootsService-GetPathFromPrivateRoot-System-String[]-'></a>
### GetPathFromPrivateRoot() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Files-Services-RootsService-GetPathFromPublicRoot-System-String[]-'></a>
### GetPathFromPublicRoot() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Files-Extensions-ServiceCollectionExtensions'></a>
## ServiceCollectionExtensions `type`

##### Namespace

Definux.Emeraude.Files.Extensions

##### Summary

Extensions for [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection').

<a name='M-Definux-Emeraude-Files-Extensions-ServiceCollectionExtensions-RegisterEmeraudeSystemFilesManagement-Microsoft-Extensions-DependencyInjection-IServiceCollection,Definux-Emeraude-Files-EmFilesOptions-'></a>
### RegisterEmeraudeSystemFilesManagement(services,options) `method`

##### Summary

Registers system file management services.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |
| options | [Definux.Emeraude.Files.EmFilesOptions](#T-Definux-Emeraude-Files-EmFilesOptions 'Definux.Emeraude.Files.EmFilesOptions') |  |

<a name='T-Definux-Emeraude-Files-Services-SystemFilesService'></a>
## SystemFilesService `type`

##### Namespace

Definux.Emeraude.Files.Services

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Files-Services-SystemFilesService-#ctor-Definux-Emeraude-Application-Logger-IEmLogger,Microsoft-AspNetCore-Hosting-IHostingEnvironment,Definux-Emeraude-Application-Logger-ILoggerContext,Definux-Emeraude-Application-Files-IRootsService-'></a>
### #ctor(logger,hostingEnvironment,loggerContext,rootsService) `constructor`

##### Summary

Initializes a new instance of the [SystemFilesService](#T-Definux-Emeraude-Files-Services-SystemFilesService 'Definux.Emeraude.Files.Services.SystemFilesService') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |
| hostingEnvironment | [Microsoft.AspNetCore.Hosting.IHostingEnvironment](#T-Microsoft-AspNetCore-Hosting-IHostingEnvironment 'Microsoft.AspNetCore.Hosting.IHostingEnvironment') |  |
| loggerContext | [Definux.Emeraude.Application.Logger.ILoggerContext](#T-Definux-Emeraude-Application-Logger-ILoggerContext 'Definux.Emeraude.Application.Logger.ILoggerContext') |  |
| rootsService | [Definux.Emeraude.Application.Files.IRootsService](#T-Definux-Emeraude-Application-Files-IRootsService 'Definux.Emeraude.Application.Files.IRootsService') |  |

<a name='M-Definux-Emeraude-Files-Services-SystemFilesService-ApplyTempFileToPrivateDirectoryAsync-System-Int32,System-String-'></a>
### ApplyTempFileToPrivateDirectoryAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Files-Services-SystemFilesService-ApplyTempFileToPublicDirectoryAsync-System-Int32,System-String-'></a>
### ApplyTempFileToPublicDirectoryAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Files-Services-SystemFilesService-ApplyTempFilesToPrivateDirectoryAsync-System-Collections-Generic-IEnumerable{System-Int32},System-String-'></a>
### ApplyTempFilesToPrivateDirectoryAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Files-Services-SystemFilesService-ApplyTempFilesToPublicDirectoryAsync-System-Collections-Generic-IEnumerable{System-Int32},System-String-'></a>
### ApplyTempFilesToPublicDirectoryAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Files-Services-SystemFilesService-CreateFolderAsync-System-String,System-String-'></a>
### CreateFolderAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Files-Services-SystemFilesService-GetFileAsync-System-String-'></a>
### GetFileAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Files-Services-SystemFilesService-GetFileById-System-Int32-'></a>
### GetFileById() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Files-Services-SystemFilesService-GetFileByIdAsync-System-Int32-'></a>
### GetFileByIdAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Files-Services-SystemFilesService-GetFilesByIds-System-Collections-Generic-IEnumerable{System-Int32}-'></a>
### GetFilesByIds() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Files-Services-SystemFilesService-GetFilesByIdsAsync-System-Collections-Generic-IEnumerable{System-Int32}-'></a>
### GetFilesByIdsAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Files-Services-SystemFilesService-GetPublicRootFolderFilesRelativePaths-System-String[]-'></a>
### GetPublicRootFolderFilesRelativePaths() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Files-Services-SystemFilesService-ScanDirectory-System-String,System-String-'></a>
### ScanDirectory() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Files-Services-SystemFilesService-ScanPrivateDirectory'></a>
### ScanPrivateDirectory() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Files-Services-SystemFilesService-ScanPublicDirectory'></a>
### ScanPublicDirectory() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Files-Services-UploadService'></a>
## UploadService `type`

##### Namespace

Definux.Emeraude.Files.Services

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Files-Services-UploadService-#ctor-Definux-Emeraude-Application-Logger-ILoggerContext,Definux-Emeraude-Application-Logger-IEmLogger,Microsoft-AspNetCore-Hosting-IHostingEnvironment,Definux-Emeraude-Application-Files-IRootsService-'></a>
### #ctor(loggerContext,logger,hostingEnvironment,rootsService) `constructor`

##### Summary

Initializes a new instance of the [UploadService](#T-Definux-Emeraude-Files-Services-UploadService 'Definux.Emeraude.Files.Services.UploadService') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| loggerContext | [Definux.Emeraude.Application.Logger.ILoggerContext](#T-Definux-Emeraude-Application-Logger-ILoggerContext 'Definux.Emeraude.Application.Logger.ILoggerContext') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |
| hostingEnvironment | [Microsoft.AspNetCore.Hosting.IHostingEnvironment](#T-Microsoft-AspNetCore-Hosting-IHostingEnvironment 'Microsoft.AspNetCore.Hosting.IHostingEnvironment') |  |
| rootsService | [Definux.Emeraude.Application.Files.IRootsService](#T-Definux-Emeraude-Application-Files-IRootsService 'Definux.Emeraude.Application.Files.IRootsService') |  |

<a name='M-Definux-Emeraude-Files-Services-UploadService-UploadFileAsync-Microsoft-AspNetCore-Http-IFormFile-'></a>
### UploadFileAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Files-Services-UploadService-UploadFileAsync-Microsoft-AspNetCore-Http-IFormFile,System-String,System-Boolean-'></a>
### UploadFileAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.
