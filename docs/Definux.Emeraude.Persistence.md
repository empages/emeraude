<a name='assembly'></a>
# Definux.Emeraude.Persistence

## Contents

- [ApplicationDatabaseInitializer](#T-Definux-Emeraude-Persistence-Seed-ApplicationDatabaseInitializer 'Definux.Emeraude.Persistence.Seed.ApplicationDatabaseInitializer')
  - [#ctor(context,userManager,roleManager,optionsAccessor)](#M-Definux-Emeraude-Persistence-Seed-ApplicationDatabaseInitializer-#ctor-Definux-Emeraude-Application-Persistence-IEmContext,Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-Identity-IRoleManager,Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions}- 'Definux.Emeraude.Persistence.Seed.ApplicationDatabaseInitializer.#ctor(Definux.Emeraude.Application.Persistence.IEmContext,Definux.Emeraude.Application.Identity.IUserManager,Definux.Emeraude.Application.Identity.IRoleManager,Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions})')
  - [SeedAsync()](#M-Definux-Emeraude-Persistence-Seed-ApplicationDatabaseInitializer-SeedAsync 'Definux.Emeraude.Persistence.Seed.ApplicationDatabaseInitializer.SeedAsync')
- [AssemblyInfo](#T-Definux-Emeraude-Data-AssemblyInfo 'Definux.Emeraude.Data.AssemblyInfo')
  - [GetAssembly()](#M-Definux-Emeraude-Data-AssemblyInfo-GetAssembly 'Definux.Emeraude.Data.AssemblyInfo.GetAssembly')
- [DatabaseInitializerManager](#T-Definux-Emeraude-Persistence-Seed-DatabaseInitializerManager 'Definux.Emeraude.Persistence.Seed.DatabaseInitializerManager')
  - [#ctor(serviceProvider)](#M-Definux-Emeraude-Persistence-Seed-DatabaseInitializerManager-#ctor-System-IServiceProvider- 'Definux.Emeraude.Persistence.Seed.DatabaseInitializerManager.#ctor(System.IServiceProvider)')
  - [LoadDatabaseInitializers()](#M-Definux-Emeraude-Persistence-Seed-DatabaseInitializerManager-LoadDatabaseInitializers-System-Type[]- 'Definux.Emeraude.Persistence.Seed.DatabaseInitializerManager.LoadDatabaseInitializers(System.Type[])')
  - [SeedAsync()](#M-Definux-Emeraude-Persistence-Seed-DatabaseInitializerManager-SeedAsync 'Definux.Emeraude.Persistence.Seed.DatabaseInitializerManager.SeedAsync')
- [DatabaseInitializer\`1](#T-Definux-Emeraude-Persistence-Seed-DatabaseInitializer`1 'Definux.Emeraude.Persistence.Seed.DatabaseInitializer`1')
  - [#ctor(hostingEnvironment,entityContext,systemFilesService,uploadService,rootsService)](#M-Definux-Emeraude-Persistence-Seed-DatabaseInitializer`1-#ctor-Microsoft-Extensions-Hosting-IHostEnvironment,`0,Definux-Emeraude-Application-Files-ISystemFilesService,Definux-Emeraude-Application-Files-IUploadService,Definux-Emeraude-Application-Files-IRootsService- 'Definux.Emeraude.Persistence.Seed.DatabaseInitializer`1.#ctor(Microsoft.Extensions.Hosting.IHostEnvironment,`0,Definux.Emeraude.Application.Files.ISystemFilesService,Definux.Emeraude.Application.Files.IUploadService,Definux.Emeraude.Application.Files.IRootsService)')
  - [DataFolderPath](#P-Definux-Emeraude-Persistence-Seed-DatabaseInitializer`1-DataFolderPath 'Definux.Emeraude.Persistence.Seed.DatabaseInitializer`1.DataFolderPath')
  - [EntityContext](#P-Definux-Emeraude-Persistence-Seed-DatabaseInitializer`1-EntityContext 'Definux.Emeraude.Persistence.Seed.DatabaseInitializer`1.EntityContext')
  - [HostingEnvironment](#P-Definux-Emeraude-Persistence-Seed-DatabaseInitializer`1-HostingEnvironment 'Definux.Emeraude.Persistence.Seed.DatabaseInitializer`1.HostingEnvironment')
  - [RootsService](#P-Definux-Emeraude-Persistence-Seed-DatabaseInitializer`1-RootsService 'Definux.Emeraude.Persistence.Seed.DatabaseInitializer`1.RootsService')
  - [SystemFilesService](#P-Definux-Emeraude-Persistence-Seed-DatabaseInitializer`1-SystemFilesService 'Definux.Emeraude.Persistence.Seed.DatabaseInitializer`1.SystemFilesService')
  - [UploadService](#P-Definux-Emeraude-Persistence-Seed-DatabaseInitializer`1-UploadService 'Definux.Emeraude.Persistence.Seed.DatabaseInitializer`1.UploadService')
  - [SeedAsync()](#M-Definux-Emeraude-Persistence-Seed-DatabaseInitializer`1-SeedAsync 'Definux.Emeraude.Persistence.Seed.DatabaseInitializer`1.SeedAsync')
- [DefaultDataTypesLengths](#T-Definux-Emeraude-Persistence-DefaultDataTypesLengths 'Definux.Emeraude.Persistence.DefaultDataTypesLengths')
  - [Address](#F-Definux-Emeraude-Persistence-DefaultDataTypesLengths-Address 'Definux.Emeraude.Persistence.DefaultDataTypesLengths.Address')
  - [AddressNumber](#F-Definux-Emeraude-Persistence-DefaultDataTypesLengths-AddressNumber 'Definux.Emeraude.Persistence.DefaultDataTypesLengths.AddressNumber')
  - [City](#F-Definux-Emeraude-Persistence-DefaultDataTypesLengths-City 'Definux.Emeraude.Persistence.DefaultDataTypesLengths.City')
  - [CompanyName](#F-Definux-Emeraude-Persistence-DefaultDataTypesLengths-CompanyName 'Definux.Emeraude.Persistence.DefaultDataTypesLengths.CompanyName')
  - [Country](#F-Definux-Emeraude-Persistence-DefaultDataTypesLengths-Country 'Definux.Emeraude.Persistence.DefaultDataTypesLengths.Country')
  - [Email](#F-Definux-Emeraude-Persistence-DefaultDataTypesLengths-Email 'Definux.Emeraude.Persistence.DefaultDataTypesLengths.Email')
  - [Fax](#F-Definux-Emeraude-Persistence-DefaultDataTypesLengths-Fax 'Definux.Emeraude.Persistence.DefaultDataTypesLengths.Fax')
  - [FullName](#F-Definux-Emeraude-Persistence-DefaultDataTypesLengths-FullName 'Definux.Emeraude.Persistence.DefaultDataTypesLengths.FullName')
  - [GroupName](#F-Definux-Emeraude-Persistence-DefaultDataTypesLengths-GroupName 'Definux.Emeraude.Persistence.DefaultDataTypesLengths.GroupName')
  - [Phone](#F-Definux-Emeraude-Persistence-DefaultDataTypesLengths-Phone 'Definux.Emeraude.Persistence.DefaultDataTypesLengths.Phone')
  - [ReferenceNumber](#F-Definux-Emeraude-Persistence-DefaultDataTypesLengths-ReferenceNumber 'Definux.Emeraude.Persistence.DefaultDataTypesLengths.ReferenceNumber')
  - [SingleName](#F-Definux-Emeraude-Persistence-DefaultDataTypesLengths-SingleName 'Definux.Emeraude.Persistence.DefaultDataTypesLengths.SingleName')
  - [Website](#F-Definux-Emeraude-Persistence-DefaultDataTypesLengths-Website 'Definux.Emeraude.Persistence.DefaultDataTypesLengths.Website')
- [EmContext\`1](#T-Definux-Emeraude-Persistence-EmContext`1 'Definux.Emeraude.Persistence.EmContext`1')
  - [#ctor(options,httpAccessor,serviceProvider)](#M-Definux-Emeraude-Persistence-EmContext`1-#ctor-Microsoft-EntityFrameworkCore-DbContextOptions{`0},Microsoft-AspNetCore-Http-IHttpContextAccessor,System-IServiceProvider- 'Definux.Emeraude.Persistence.EmContext`1.#ctor(Microsoft.EntityFrameworkCore.DbContextOptions{`0},Microsoft.AspNetCore.Http.IHttpContextAccessor,System.IServiceProvider)')
  - [ServiceProvider](#P-Definux-Emeraude-Persistence-EmContext`1-ServiceProvider 'Definux.Emeraude.Persistence.EmContext`1.ServiceProvider')
  - [ConfigureEntitiesIdentifications(builder)](#M-Definux-Emeraude-Persistence-EmContext`1-ConfigureEntitiesIdentifications-Microsoft-EntityFrameworkCore-ModelBuilder- 'Definux.Emeraude.Persistence.EmContext`1.ConfigureEntitiesIdentifications(Microsoft.EntityFrameworkCore.ModelBuilder)')
  - [GetContextType()](#M-Definux-Emeraude-Persistence-EmContext`1-GetContextType 'Definux.Emeraude.Persistence.EmContext`1.GetContextType')
  - [OnModelCreating()](#M-Definux-Emeraude-Persistence-EmContext`1-OnModelCreating-Microsoft-EntityFrameworkCore-ModelBuilder- 'Definux.Emeraude.Persistence.EmContext`1.OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder)')
  - [SaveChanges()](#M-Definux-Emeraude-Persistence-EmContext`1-SaveChanges 'Definux.Emeraude.Persistence.EmContext`1.SaveChanges')
  - [SaveChanges()](#M-Definux-Emeraude-Persistence-EmContext`1-SaveChanges-System-Boolean- 'Definux.Emeraude.Persistence.EmContext`1.SaveChanges(System.Boolean)')
  - [SaveChangesAsync()](#M-Definux-Emeraude-Persistence-EmContext`1-SaveChangesAsync-System-Boolean,System-Threading-CancellationToken- 'Definux.Emeraude.Persistence.EmContext`1.SaveChangesAsync(System.Boolean,System.Threading.CancellationToken)')
  - [SaveChangesAsync()](#M-Definux-Emeraude-Persistence-EmContext`1-SaveChangesAsync-System-Threading-CancellationToken- 'Definux.Emeraude.Persistence.EmContext`1.SaveChangesAsync(System.Threading.CancellationToken)')
  - [UpdateAuditableEntities()](#M-Definux-Emeraude-Persistence-EmContext`1-UpdateAuditableEntities 'Definux.Emeraude.Persistence.EmContext`1.UpdateAuditableEntities')
- [PropertyBuilderExtensions](#T-Definux-Emeraude-Persistence-Extensions-PropertyBuilderExtensions 'Definux.Emeraude.Persistence.Extensions.PropertyBuilderExtensions')
  - [HasEnumArrayConversion\`\`1(propertyBuilder)](#M-Definux-Emeraude-Persistence-Extensions-PropertyBuilderExtensions-HasEnumArrayConversion``1-Microsoft-EntityFrameworkCore-Metadata-Builders-PropertyBuilder{``0[]}- 'Definux.Emeraude.Persistence.Extensions.PropertyBuilderExtensions.HasEnumArrayConversion``1(Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder{``0[]})')
  - [HasObjectArrayToJsonConversion\`\`1(propertyBuilder)](#M-Definux-Emeraude-Persistence-Extensions-PropertyBuilderExtensions-HasObjectArrayToJsonConversion``1-Microsoft-EntityFrameworkCore-Metadata-Builders-PropertyBuilder{``0[]}- 'Definux.Emeraude.Persistence.Extensions.PropertyBuilderExtensions.HasObjectArrayToJsonConversion``1(Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder{``0[]})')
- [ServiceCollectionExtensions](#T-Definux-Emeraude-Persistence-Extensions-ServiceCollectionExtensions 'Definux.Emeraude.Persistence.Extensions.ServiceCollectionExtensions')
  - [AddDatabaseInitializer\`\`2(services)](#M-Definux-Emeraude-Persistence-Extensions-ServiceCollectionExtensions-AddDatabaseInitializer``2-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Definux.Emeraude.Persistence.Extensions.ServiceCollectionExtensions.AddDatabaseInitializer``2(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [ConfigureDatabases\`\`2(services,configuration,options)](#M-Definux-Emeraude-Persistence-Extensions-ServiceCollectionExtensions-ConfigureDatabases``2-Microsoft-Extensions-DependencyInjection-IServiceCollection,Microsoft-Extensions-Configuration-IConfiguration,Definux-Emeraude-Configuration-Options-EmOptions- 'Definux.Emeraude.Persistence.Extensions.ServiceCollectionExtensions.ConfigureDatabases``2(Microsoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration,Definux.Emeraude.Configuration.Options.EmOptions)')

<a name='T-Definux-Emeraude-Persistence-Seed-ApplicationDatabaseInitializer'></a>
## ApplicationDatabaseInitializer `type`

##### Namespace

Definux.Emeraude.Persistence.Seed

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Persistence-Seed-ApplicationDatabaseInitializer-#ctor-Definux-Emeraude-Application-Persistence-IEmContext,Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-Identity-IRoleManager,Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions}-'></a>
### #ctor(context,userManager,roleManager,optionsAccessor) `constructor`

##### Summary

Initializes a new instance of the [ApplicationDatabaseInitializer](#T-Definux-Emeraude-Persistence-Seed-ApplicationDatabaseInitializer 'Definux.Emeraude.Persistence.Seed.ApplicationDatabaseInitializer') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Definux.Emeraude.Application.Persistence.IEmContext](#T-Definux-Emeraude-Application-Persistence-IEmContext 'Definux.Emeraude.Application.Persistence.IEmContext') |  |
| userManager | [Definux.Emeraude.Application.Identity.IUserManager](#T-Definux-Emeraude-Application-Identity-IUserManager 'Definux.Emeraude.Application.Identity.IUserManager') |  |
| roleManager | [Definux.Emeraude.Application.Identity.IRoleManager](#T-Definux-Emeraude-Application-Identity-IRoleManager 'Definux.Emeraude.Application.Identity.IRoleManager') |  |
| optionsAccessor | [Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions}](#T-Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions} 'Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions}') |  |

<a name='M-Definux-Emeraude-Persistence-Seed-ApplicationDatabaseInitializer-SeedAsync'></a>
### SeedAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Data-AssemblyInfo'></a>
## AssemblyInfo `type`

##### Namespace

Definux.Emeraude.Data

##### Summary

Assembly info provider.

<a name='M-Definux-Emeraude-Data-AssemblyInfo-GetAssembly'></a>
### GetAssembly() `method`

##### Summary

Gets execution assembly.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Persistence-Seed-DatabaseInitializerManager'></a>
## DatabaseInitializerManager `type`

##### Namespace

Definux.Emeraude.Persistence.Seed

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Persistence-Seed-DatabaseInitializerManager-#ctor-System-IServiceProvider-'></a>
### #ctor(serviceProvider) `constructor`

##### Summary

Initializes a new instance of the [DatabaseInitializerManager](#T-Definux-Emeraude-Persistence-Seed-DatabaseInitializerManager 'Definux.Emeraude.Persistence.Seed.DatabaseInitializerManager') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceProvider | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') |  |

<a name='M-Definux-Emeraude-Persistence-Seed-DatabaseInitializerManager-LoadDatabaseInitializers-System-Type[]-'></a>
### LoadDatabaseInitializers() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Persistence-Seed-DatabaseInitializerManager-SeedAsync'></a>
### SeedAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Persistence-Seed-DatabaseInitializer`1'></a>
## DatabaseInitializer\`1 `type`

##### Namespace

Definux.Emeraude.Persistence.Seed

##### Summary

Implementation of [IDatabaseInitializer](#T-Definux-Emeraude-Interfaces-Services-IDatabaseInitializer 'Definux.Emeraude.Interfaces.Services.IDatabaseInitializer') for the specified [IEmContext](#T-Definux-Emeraude-Application-Persistence-IEmContext 'Definux.Emeraude.Application.Persistence.IEmContext').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TContext | [IEmContext](#T-Definux-Emeraude-Application-Persistence-IEmContext 'Definux.Emeraude.Application.Persistence.IEmContext'). |

<a name='M-Definux-Emeraude-Persistence-Seed-DatabaseInitializer`1-#ctor-Microsoft-Extensions-Hosting-IHostEnvironment,`0,Definux-Emeraude-Application-Files-ISystemFilesService,Definux-Emeraude-Application-Files-IUploadService,Definux-Emeraude-Application-Files-IRootsService-'></a>
### #ctor(hostingEnvironment,entityContext,systemFilesService,uploadService,rootsService) `constructor`

##### Summary

Initializes a new instance of the [DatabaseInitializer\`1](#T-Definux-Emeraude-Persistence-Seed-DatabaseInitializer`1 'Definux.Emeraude.Persistence.Seed.DatabaseInitializer`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hostingEnvironment | [Microsoft.Extensions.Hosting.IHostEnvironment](#T-Microsoft-Extensions-Hosting-IHostEnvironment 'Microsoft.Extensions.Hosting.IHostEnvironment') |  |
| entityContext | [\`0](#T-`0 '`0') |  |
| systemFilesService | [Definux.Emeraude.Application.Files.ISystemFilesService](#T-Definux-Emeraude-Application-Files-ISystemFilesService 'Definux.Emeraude.Application.Files.ISystemFilesService') |  |
| uploadService | [Definux.Emeraude.Application.Files.IUploadService](#T-Definux-Emeraude-Application-Files-IUploadService 'Definux.Emeraude.Application.Files.IUploadService') |  |
| rootsService | [Definux.Emeraude.Application.Files.IRootsService](#T-Definux-Emeraude-Application-Files-IRootsService 'Definux.Emeraude.Application.Files.IRootsService') |  |

<a name='P-Definux-Emeraude-Persistence-Seed-DatabaseInitializer`1-DataFolderPath'></a>
### DataFolderPath `property`

##### Summary

Path of the folder that contains all data files used for data seed.

<a name='P-Definux-Emeraude-Persistence-Seed-DatabaseInitializer`1-EntityContext'></a>
### EntityContext `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Persistence-Seed-DatabaseInitializer`1-HostingEnvironment'></a>
### HostingEnvironment `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Persistence-Seed-DatabaseInitializer`1-RootsService'></a>
### RootsService `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Persistence-Seed-DatabaseInitializer`1-SystemFilesService'></a>
### SystemFilesService `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Persistence-Seed-DatabaseInitializer`1-UploadService'></a>
### UploadService `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Persistence-Seed-DatabaseInitializer`1-SeedAsync'></a>
### SeedAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Persistence-DefaultDataTypesLengths'></a>
## DefaultDataTypesLengths `type`

##### Namespace

Definux.Emeraude.Persistence

##### Summary

Default data types.

<a name='F-Definux-Emeraude-Persistence-DefaultDataTypesLengths-Address'></a>
### Address `constants`

##### Summary

Address.

<a name='F-Definux-Emeraude-Persistence-DefaultDataTypesLengths-AddressNumber'></a>
### AddressNumber `constants`

##### Summary

Address number.

<a name='F-Definux-Emeraude-Persistence-DefaultDataTypesLengths-City'></a>
### City `constants`

##### Summary

City.

<a name='F-Definux-Emeraude-Persistence-DefaultDataTypesLengths-CompanyName'></a>
### CompanyName `constants`

##### Summary

Company name.

<a name='F-Definux-Emeraude-Persistence-DefaultDataTypesLengths-Country'></a>
### Country `constants`

##### Summary

Country.

<a name='F-Definux-Emeraude-Persistence-DefaultDataTypesLengths-Email'></a>
### Email `constants`

##### Summary

Email address.

<a name='F-Definux-Emeraude-Persistence-DefaultDataTypesLengths-Fax'></a>
### Fax `constants`

##### Summary

Fax.

<a name='F-Definux-Emeraude-Persistence-DefaultDataTypesLengths-FullName'></a>
### FullName `constants`

##### Summary

Full name.

<a name='F-Definux-Emeraude-Persistence-DefaultDataTypesLengths-GroupName'></a>
### GroupName `constants`

##### Summary

Group name.

<a name='F-Definux-Emeraude-Persistence-DefaultDataTypesLengths-Phone'></a>
### Phone `constants`

##### Summary

Phone number.

<a name='F-Definux-Emeraude-Persistence-DefaultDataTypesLengths-ReferenceNumber'></a>
### ReferenceNumber `constants`

##### Summary

Reference number.

<a name='F-Definux-Emeraude-Persistence-DefaultDataTypesLengths-SingleName'></a>
### SingleName `constants`

##### Summary

Single name.

<a name='F-Definux-Emeraude-Persistence-DefaultDataTypesLengths-Website'></a>
### Website `constants`

##### Summary

Website.

<a name='T-Definux-Emeraude-Persistence-EmContext`1'></a>
## EmContext\`1 `type`

##### Namespace

Definux.Emeraude.Persistence

##### Summary

Main abstract context of Emeraude application for your database context.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TContext | Your database context. |

<a name='M-Definux-Emeraude-Persistence-EmContext`1-#ctor-Microsoft-EntityFrameworkCore-DbContextOptions{`0},Microsoft-AspNetCore-Http-IHttpContextAccessor,System-IServiceProvider-'></a>
### #ctor(options,httpAccessor,serviceProvider) `constructor`

##### Summary

Initializes a new instance of the [EmContext\`1](#T-Definux-Emeraude-Persistence-EmContext`1 'Definux.Emeraude.Persistence.EmContext`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [Microsoft.EntityFrameworkCore.DbContextOptions{\`0}](#T-Microsoft-EntityFrameworkCore-DbContextOptions{`0} 'Microsoft.EntityFrameworkCore.DbContextOptions{`0}') |  |
| httpAccessor | [Microsoft.AspNetCore.Http.IHttpContextAccessor](#T-Microsoft-AspNetCore-Http-IHttpContextAccessor 'Microsoft.AspNetCore.Http.IHttpContextAccessor') |  |
| serviceProvider | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') |  |

<a name='P-Definux-Emeraude-Persistence-EmContext`1-ServiceProvider'></a>
### ServiceProvider `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Persistence-EmContext`1-ConfigureEntitiesIdentifications-Microsoft-EntityFrameworkCore-ModelBuilder-'></a>
### ConfigureEntitiesIdentifications(builder) `method`

##### Summary

Configure all entities identifications.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.EntityFrameworkCore.ModelBuilder](#T-Microsoft-EntityFrameworkCore-ModelBuilder 'Microsoft.EntityFrameworkCore.ModelBuilder') |  |

<a name='M-Definux-Emeraude-Persistence-EmContext`1-GetContextType'></a>
### GetContextType() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Persistence-EmContext`1-OnModelCreating-Microsoft-EntityFrameworkCore-ModelBuilder-'></a>
### OnModelCreating() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Persistence-EmContext`1-SaveChanges'></a>
### SaveChanges() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Persistence-EmContext`1-SaveChanges-System-Boolean-'></a>
### SaveChanges() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Persistence-EmContext`1-SaveChangesAsync-System-Boolean,System-Threading-CancellationToken-'></a>
### SaveChangesAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Persistence-EmContext`1-SaveChangesAsync-System-Threading-CancellationToken-'></a>
### SaveChangesAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Persistence-EmContext`1-UpdateAuditableEntities'></a>
### UpdateAuditableEntities() `method`

##### Summary

Method that automatically update all dates and users of all tracked auditable entities.

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Persistence-Extensions-PropertyBuilderExtensions'></a>
## PropertyBuilderExtensions `type`

##### Namespace

Definux.Emeraude.Persistence.Extensions

##### Summary

Extensions for [PropertyBuilder](#T-Microsoft-EntityFrameworkCore-Metadata-Builders-PropertyBuilder 'Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder').

<a name='M-Definux-Emeraude-Persistence-Extensions-PropertyBuilderExtensions-HasEnumArrayConversion``1-Microsoft-EntityFrameworkCore-Metadata-Builders-PropertyBuilder{``0[]}-'></a>
### HasEnumArrayConversion\`\`1(propertyBuilder) `method`

##### Summary

Make the conversion between enum array and string.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertyBuilder | [Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder{\`\`0[]}](#T-Microsoft-EntityFrameworkCore-Metadata-Builders-PropertyBuilder{``0[]} 'Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder{``0[]}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEnum | Enum with string name and value in Int32. |

<a name='M-Definux-Emeraude-Persistence-Extensions-PropertyBuilderExtensions-HasObjectArrayToJsonConversion``1-Microsoft-EntityFrameworkCore-Metadata-Builders-PropertyBuilder{``0[]}-'></a>
### HasObjectArrayToJsonConversion\`\`1(propertyBuilder) `method`

##### Summary

Make the conversion between object array and string.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertyBuilder | [Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder{\`\`0[]}](#T-Microsoft-EntityFrameworkCore-Metadata-Builders-PropertyBuilder{``0[]} 'Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder{``0[]}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TType | Object which is easy for serialization. |

<a name='T-Definux-Emeraude-Persistence-Extensions-ServiceCollectionExtensions'></a>
## ServiceCollectionExtensions `type`

##### Namespace

Definux.Emeraude.Persistence.Extensions

##### Summary

Extensions for [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection').

<a name='M-Definux-Emeraude-Persistence-Extensions-ServiceCollectionExtensions-AddDatabaseInitializer``2-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### AddDatabaseInitializer\`\`2(services) `method`

##### Summary

Registers a database initializer.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TInitializerService | Interface of the target database initializer. |
| TInitializerImplementation | Implementation class of the target initializer. |

<a name='M-Definux-Emeraude-Persistence-Extensions-ServiceCollectionExtensions-ConfigureDatabases``2-Microsoft-Extensions-DependencyInjection-IServiceCollection,Microsoft-Extensions-Configuration-IConfiguration,Definux-Emeraude-Configuration-Options-EmOptions-'></a>
### ConfigureDatabases\`\`2(services,configuration,options) `method`

##### Summary

Configures Emeraude database.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |
| configuration | [Microsoft.Extensions.Configuration.IConfiguration](#T-Microsoft-Extensions-Configuration-IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') |  |
| options | [Definux.Emeraude.Configuration.Options.EmOptions](#T-Definux-Emeraude-Configuration-Options-EmOptions 'Definux.Emeraude.Configuration.Options.EmOptions') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TContextInterface | Interface of the application database context. |
| TContextImplementation | Implementation of the application database context. |
