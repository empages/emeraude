<a name='assembly'></a>
# Definux.Emeraude.Configuration

## Contents

- [AccountOptions](#T-Definux-Emeraude-Configuration-Options-AccountOptions 'Definux.Emeraude.Configuration.Options.AccountOptions')
  - [HasClientApiAuthentication](#P-Definux-Emeraude-Configuration-Options-AccountOptions-HasClientApiAuthentication 'Definux.Emeraude.Configuration.Options.AccountOptions.HasClientApiAuthentication')
  - [HasClientMvcAuthentication](#P-Definux-Emeraude-Configuration-Options-AccountOptions-HasClientMvcAuthentication 'Definux.Emeraude.Configuration.Options.AccountOptions.HasClientMvcAuthentication')
  - [HasExternalAuthentication](#P-Definux-Emeraude-Configuration-Options-AccountOptions-HasExternalAuthentication 'Definux.Emeraude.Configuration.Options.AccountOptions.HasExternalAuthentication')
- [AdminPermissions](#T-Definux-Emeraude-Configuration-Authorization-AdminPermissions 'Definux.Emeraude.Configuration.Authorization.AdminPermissions')
  - [AccessAdministrationPolicy](#F-Definux-Emeraude-Configuration-Authorization-AdminPermissions-AccessAdministrationPolicy 'Definux.Emeraude.Configuration.Authorization.AdminPermissions.AccessAdministrationPolicy')
  - [AccessLogsPolicy](#F-Definux-Emeraude-Configuration-Authorization-AdminPermissions-AccessLogsPolicy 'Definux.Emeraude.Configuration.Authorization.AdminPermissions.AccessLogsPolicy')
  - [RootAccessPolicy](#F-Definux-Emeraude-Configuration-Authorization-AdminPermissions-RootAccessPolicy 'Definux.Emeraude.Configuration.Authorization.AdminPermissions.RootAccessPolicy')
  - [UsersManagementPolicy](#F-Definux-Emeraude-Configuration-Authorization-AdminPermissions-UsersManagementPolicy 'Definux.Emeraude.Configuration.Authorization.AdminPermissions.UsersManagementPolicy')
  - [AccessAdministration](#P-Definux-Emeraude-Configuration-Authorization-AdminPermissions-AccessAdministration 'Definux.Emeraude.Configuration.Authorization.AdminPermissions.AccessAdministration')
  - [AccessLogs](#P-Definux-Emeraude-Configuration-Authorization-AdminPermissions-AccessLogs 'Definux.Emeraude.Configuration.Authorization.AdminPermissions.AccessLogs')
  - [AllPermissions](#P-Definux-Emeraude-Configuration-Authorization-AdminPermissions-AllPermissions 'Definux.Emeraude.Configuration.Authorization.AdminPermissions.AllPermissions')
  - [RootAccess](#P-Definux-Emeraude-Configuration-Authorization-AdminPermissions-RootAccess 'Definux.Emeraude.Configuration.Authorization.AdminPermissions.RootAccess')
  - [UsersManagement](#P-Definux-Emeraude-Configuration-Authorization-AdminPermissions-UsersManagement 'Definux.Emeraude.Configuration.Authorization.AdminPermissions.UsersManagement')
  - [GetAllPermissionValues()](#M-Definux-Emeraude-Configuration-Authorization-AdminPermissions-GetAllPermissionValues 'Definux.Emeraude.Configuration.Authorization.AdminPermissions.GetAllPermissionValues')
  - [GetPermissionByName(permissionName)](#M-Definux-Emeraude-Configuration-Authorization-AdminPermissions-GetPermissionByName-System-String- 'Definux.Emeraude.Configuration.Authorization.AdminPermissions.GetPermissionByName(System.String)')
  - [GetPermissionByValue(permissionValue)](#M-Definux-Emeraude-Configuration-Authorization-AdminPermissions-GetPermissionByValue-System-String- 'Definux.Emeraude.Configuration.Authorization.AdminPermissions.GetPermissionByValue(System.String)')
- [ApplicationPermission](#T-Definux-Emeraude-Configuration-Authorization-ApplicationPermission 'Definux.Emeraude.Configuration.Authorization.ApplicationPermission')
  - [#ctor()](#M-Definux-Emeraude-Configuration-Authorization-ApplicationPermission-#ctor 'Definux.Emeraude.Configuration.Authorization.ApplicationPermission.#ctor')
  - [#ctor(name)](#M-Definux-Emeraude-Configuration-Authorization-ApplicationPermission-#ctor-System-String- 'Definux.Emeraude.Configuration.Authorization.ApplicationPermission.#ctor(System.String)')
  - [Name](#P-Definux-Emeraude-Configuration-Authorization-ApplicationPermission-Name 'Definux.Emeraude.Configuration.Authorization.ApplicationPermission.Name')
  - [Value](#P-Definux-Emeraude-Configuration-Authorization-ApplicationPermission-Value 'Definux.Emeraude.Configuration.Authorization.ApplicationPermission.Value')
  - [ToString()](#M-Definux-Emeraude-Configuration-Authorization-ApplicationPermission-ToString 'Definux.Emeraude.Configuration.Authorization.ApplicationPermission.ToString')
  - [op_Implicit(permission)](#M-Definux-Emeraude-Configuration-Authorization-ApplicationPermission-op_Implicit-Definux-Emeraude-Configuration-Authorization-ApplicationPermission-~System-String 'Definux.Emeraude.Configuration.Authorization.ApplicationPermission.op_Implicit(Definux.Emeraude.Configuration.Authorization.ApplicationPermission)~System.String')
- [ApplicationRoles](#T-Definux-Emeraude-Configuration-Authorization-ApplicationRoles 'Definux.Emeraude.Configuration.Authorization.ApplicationRoles')
  - [Admin](#F-Definux-Emeraude-Configuration-Authorization-ApplicationRoles-Admin 'Definux.Emeraude.Configuration.Authorization.ApplicationRoles.Admin')
  - [User](#F-Definux-Emeraude-Configuration-Authorization-ApplicationRoles-User 'Definux.Emeraude.Configuration.Authorization.ApplicationRoles.User')
- [AuthenticationDefaults](#T-Definux-Emeraude-Configuration-Authorization-AuthenticationDefaults 'Definux.Emeraude.Configuration.Authorization.AuthenticationDefaults')
  - [AdminAuthenticationScheme](#F-Definux-Emeraude-Configuration-Authorization-AuthenticationDefaults-AdminAuthenticationScheme 'Definux.Emeraude.Configuration.Authorization.AuthenticationDefaults.AdminAuthenticationScheme')
  - [AdminCookieName](#F-Definux-Emeraude-Configuration-Authorization-AuthenticationDefaults-AdminCookieName 'Definux.Emeraude.Configuration.Authorization.AuthenticationDefaults.AdminCookieName')
  - [ClientAuthenticationScheme](#F-Definux-Emeraude-Configuration-Authorization-AuthenticationDefaults-ClientAuthenticationScheme 'Definux.Emeraude.Configuration.Authorization.AuthenticationDefaults.ClientAuthenticationScheme')
  - [ClientCookieName](#F-Definux-Emeraude-Configuration-Authorization-AuthenticationDefaults-ClientCookieName 'Definux.Emeraude.Configuration.Authorization.AuthenticationDefaults.ClientCookieName')
  - [JwtBearerAuthenticationScheme](#F-Definux-Emeraude-Configuration-Authorization-AuthenticationDefaults-JwtBearerAuthenticationScheme 'Definux.Emeraude.Configuration.Authorization.AuthenticationDefaults.JwtBearerAuthenticationScheme')
- [ClaimTypes](#T-Definux-Emeraude-Configuration-Authorization-ClaimTypes 'Definux.Emeraude.Configuration.Authorization.ClaimTypes')
  - [Imitate](#F-Definux-Emeraude-Configuration-Authorization-ClaimTypes-Imitate 'Definux.Emeraude.Configuration.Authorization.ClaimTypes.Imitate')
  - [Permission](#F-Definux-Emeraude-Configuration-Authorization-ClaimTypes-Permission 'Definux.Emeraude.Configuration.Authorization.ClaimTypes.Permission')
  - [Picture](#F-Definux-Emeraude-Configuration-Authorization-ClaimTypes-Picture 'Definux.Emeraude.Configuration.Authorization.ClaimTypes.Picture')
- [DatabaseContextProvider](#T-Definux-Emeraude-Configuration-Options-DatabaseContextProvider 'Definux.Emeraude.Configuration.Options.DatabaseContextProvider')
  - [InMemoryDatabase](#F-Definux-Emeraude-Configuration-Options-DatabaseContextProvider-InMemoryDatabase 'Definux.Emeraude.Configuration.Options.DatabaseContextProvider.InMemoryDatabase')
  - [MicrosoftSqlServer](#F-Definux-Emeraude-Configuration-Options-DatabaseContextProvider-MicrosoftSqlServer 'Definux.Emeraude.Configuration.Options.DatabaseContextProvider.MicrosoftSqlServer')
  - [PostgreSql](#F-Definux-Emeraude-Configuration-Options-DatabaseContextProvider-PostgreSql 'Definux.Emeraude.Configuration.Options.DatabaseContextProvider.PostgreSql')
- [EmIdentityConstants](#T-Definux-Emeraude-Configuration-Options-EmIdentityConstants 'Definux.Emeraude.Configuration.Options.EmIdentityConstants')
  - [DefaultEmeraudeAdminEmail](#F-Definux-Emeraude-Configuration-Options-EmIdentityConstants-DefaultEmeraudeAdminEmail 'Definux.Emeraude.Configuration.Options.EmIdentityConstants.DefaultEmeraudeAdminEmail')
  - [DefaultEmeraudeAdminName](#F-Definux-Emeraude-Configuration-Options-EmIdentityConstants-DefaultEmeraudeAdminName 'Definux.Emeraude.Configuration.Options.EmIdentityConstants.DefaultEmeraudeAdminName')
  - [DefaultEmeraudeAdminPassword](#F-Definux-Emeraude-Configuration-Options-EmIdentityConstants-DefaultEmeraudeAdminPassword 'Definux.Emeraude.Configuration.Options.EmIdentityConstants.DefaultEmeraudeAdminPassword')
  - [DefaultEmeraudeUserEmail](#F-Definux-Emeraude-Configuration-Options-EmIdentityConstants-DefaultEmeraudeUserEmail 'Definux.Emeraude.Configuration.Options.EmIdentityConstants.DefaultEmeraudeUserEmail')
  - [DefaultEmeraudeUserName](#F-Definux-Emeraude-Configuration-Options-EmIdentityConstants-DefaultEmeraudeUserName 'Definux.Emeraude.Configuration.Options.EmIdentityConstants.DefaultEmeraudeUserName')
  - [DefaultEmeraudeUserPassword](#F-Definux-Emeraude-Configuration-Options-EmIdentityConstants-DefaultEmeraudeUserPassword 'Definux.Emeraude.Configuration.Options.EmIdentityConstants.DefaultEmeraudeUserPassword')
  - [DefaultLockoutTimeSpanMinutes](#F-Definux-Emeraude-Configuration-Options-EmIdentityConstants-DefaultLockoutTimeSpanMinutes 'Definux.Emeraude.Configuration.Options.EmIdentityConstants.DefaultLockoutTimeSpanMinutes')
  - [MaxFailedAccessAttempts](#F-Definux-Emeraude-Configuration-Options-EmIdentityConstants-MaxFailedAccessAttempts 'Definux.Emeraude.Configuration.Options.EmIdentityConstants.MaxFailedAccessAttempts')
  - [PasswordRequiredLength](#F-Definux-Emeraude-Configuration-Options-EmIdentityConstants-PasswordRequiredLength 'Definux.Emeraude.Configuration.Options.EmIdentityConstants.PasswordRequiredLength')
- [EmOptions](#T-Definux-Emeraude-Configuration-Options-EmOptions 'Definux.Emeraude.Configuration.Options.EmOptions')
  - [#ctor()](#M-Definux-Emeraude-Configuration-Options-EmOptions-#ctor 'Definux.Emeraude.Configuration.Options.EmOptions.#ctor')
  - [Account](#P-Definux-Emeraude-Configuration-Options-EmOptions-Account 'Definux.Emeraude.Configuration.Options.EmOptions.Account')
  - [AdditonalRoles](#P-Definux-Emeraude-Configuration-Options-EmOptions-AdditonalRoles 'Definux.Emeraude.Configuration.Options.EmOptions.AdditonalRoles')
  - [AdminDashboardRequestType](#P-Definux-Emeraude-Configuration-Options-EmOptions-AdminDashboardRequestType 'Definux.Emeraude.Configuration.Options.EmOptions.AdminDashboardRequestType')
  - [Assemblies](#P-Definux-Emeraude-Configuration-Options-EmOptions-Assemblies 'Definux.Emeraude.Configuration.Options.EmOptions.Assemblies')
  - [DatabaseContextProvider](#P-Definux-Emeraude-Configuration-Options-EmOptions-DatabaseContextProvider 'Definux.Emeraude.Configuration.Options.EmOptions.DatabaseContextProvider')
  - [DatabaseInitializers](#P-Definux-Emeraude-Configuration-Options-EmOptions-DatabaseInitializers 'Definux.Emeraude.Configuration.Options.EmOptions.DatabaseInitializers')
  - [EmeraudeAssembly](#P-Definux-Emeraude-Configuration-Options-EmOptions-EmeraudeAssembly 'Definux.Emeraude.Configuration.Options.EmOptions.EmeraudeAssembly')
  - [EmeraudeVersion](#P-Definux-Emeraude-Configuration-Options-EmOptions-EmeraudeVersion 'Definux.Emeraude.Configuration.Options.EmOptions.EmeraudeVersion')
  - [ExecuteMigrations](#P-Definux-Emeraude-Configuration-Options-EmOptions-ExecuteMigrations 'Definux.Emeraude.Configuration.Options.EmOptions.ExecuteMigrations')
  - [LoggerContextProvider](#P-Definux-Emeraude-Configuration-Options-EmOptions-LoggerContextProvider 'Definux.Emeraude.Configuration.Options.EmOptions.LoggerContextProvider')
  - [MaintenanceMode](#P-Definux-Emeraude-Configuration-Options-EmOptions-MaintenanceMode 'Definux.Emeraude.Configuration.Options.EmOptions.MaintenanceMode')
  - [Mapping](#P-Definux-Emeraude-Configuration-Options-EmOptions-Mapping 'Definux.Emeraude.Configuration.Options.EmOptions.Mapping')
  - [MigrationsAssembly](#P-Definux-Emeraude-Configuration-Options-EmOptions-MigrationsAssembly 'Definux.Emeraude.Configuration.Options.EmOptions.MigrationsAssembly')
  - [ProjectName](#P-Definux-Emeraude-Configuration-Options-EmOptions-ProjectName 'Definux.Emeraude.Configuration.Options.EmOptions.ProjectName')
  - [TestMode](#P-Definux-Emeraude-Configuration-Options-EmOptions-TestMode 'Definux.Emeraude.Configuration.Options.EmOptions.TestMode')
  - [UseExternalLoggerImplementation](#P-Definux-Emeraude-Configuration-Options-EmOptions-UseExternalLoggerImplementation 'Definux.Emeraude.Configuration.Options.EmOptions.UseExternalLoggerImplementation')
  - [AddAssembly(assemblyName)](#M-Definux-Emeraude-Configuration-Options-EmOptions-AddAssembly-System-String- 'Definux.Emeraude.Configuration.Options.EmOptions.AddAssembly(System.String)')
  - [AddAssembly(assembly)](#M-Definux-Emeraude-Configuration-Options-EmOptions-AddAssembly-System-Reflection-Assembly- 'Definux.Emeraude.Configuration.Options.EmOptions.AddAssembly(System.Reflection.Assembly)')
  - [AddDatabaseInitializer\`\`1()](#M-Definux-Emeraude-Configuration-Options-EmOptions-AddDatabaseInitializer``1 'Definux.Emeraude.Configuration.Options.EmOptions.AddDatabaseInitializer``1')
  - [AddRole(roleName,claims)](#M-Definux-Emeraude-Configuration-Options-EmOptions-AddRole-System-String,System-String[]- 'Definux.Emeraude.Configuration.Options.EmOptions.AddRole(System.String,System.String[])')
  - [SetEmeraudeAssembly(assembly)](#M-Definux-Emeraude-Configuration-Options-EmOptions-SetEmeraudeAssembly-System-Reflection-Assembly- 'Definux.Emeraude.Configuration.Options.EmOptions.SetEmeraudeAssembly(System.Reflection.Assembly)')
- [MappingOptions](#T-Definux-Emeraude-Configuration-Options-MappingOptions 'Definux.Emeraude.Configuration.Options.MappingOptions')
  - [#ctor()](#M-Definux-Emeraude-Configuration-Options-MappingOptions-#ctor 'Definux.Emeraude.Configuration.Options.MappingOptions.#ctor')
  - [MappingAssemblies](#P-Definux-Emeraude-Configuration-Options-MappingOptions-MappingAssemblies 'Definux.Emeraude.Configuration.Options.MappingOptions.MappingAssemblies')
  - [MappingProfiles](#P-Definux-Emeraude-Configuration-Options-MappingOptions-MappingProfiles 'Definux.Emeraude.Configuration.Options.MappingOptions.MappingProfiles')
  - [AddProfile\`\`1()](#M-Definux-Emeraude-Configuration-Options-MappingOptions-AddProfile``1 'Definux.Emeraude.Configuration.Options.MappingOptions.AddProfile``1')
- [Policies](#T-Definux-Emeraude-Configuration-Authorization-Policies 'Definux.Emeraude.Configuration.Authorization.Policies')
  - [AuthorizedUploadPolicy](#F-Definux-Emeraude-Configuration-Authorization-Policies-AuthorizedUploadPolicy 'Definux.Emeraude.Configuration.Authorization.Policies.AuthorizedUploadPolicy')
- [UIConfigureOptions](#T-Definux-Emeraude-Configuration-Abstractions-UIConfigureOptions 'Definux.Emeraude.Configuration.Abstractions.UIConfigureOptions')
  - [#ctor(environment)](#M-Definux-Emeraude-Configuration-Abstractions-UIConfigureOptions-#ctor-Microsoft-AspNetCore-Hosting-IHostingEnvironment- 'Definux.Emeraude.Configuration.Abstractions.UIConfigureOptions.#ctor(Microsoft.AspNetCore.Hosting.IHostingEnvironment)')
  - [Environment](#P-Definux-Emeraude-Configuration-Abstractions-UIConfigureOptions-Environment 'Definux.Emeraude.Configuration.Abstractions.UIConfigureOptions.Environment')
  - [PostConfigure()](#M-Definux-Emeraude-Configuration-Abstractions-UIConfigureOptions-PostConfigure-System-String,Microsoft-AspNetCore-Builder-StaticFileOptions- 'Definux.Emeraude.Configuration.Abstractions.UIConfigureOptions.PostConfigure(System.String,Microsoft.AspNetCore.Builder.StaticFileOptions)')

<a name='T-Definux-Emeraude-Configuration-Options-AccountOptions'></a>
## AccountOptions `type`

##### Namespace

Definux.Emeraude.Configuration.Options

##### Summary

Options for authentication and authorization in the system.

<a name='P-Definux-Emeraude-Configuration-Options-AccountOptions-HasClientApiAuthentication'></a>
### HasClientApiAuthentication `property`

##### Summary

Flag that turn on/off the provided client API authentication. The defualt value is true.

<a name='P-Definux-Emeraude-Configuration-Options-AccountOptions-HasClientMvcAuthentication'></a>
### HasClientMvcAuthentication `property`

##### Summary

Flag that turn on/off the provided client MVC authentication. The default value is true.

<a name='P-Definux-Emeraude-Configuration-Options-AccountOptions-HasExternalAuthentication'></a>
### HasExternalAuthentication `property`

##### Summary

Flag that indicates whether to be registered external authentication from the settings.

<a name='T-Definux-Emeraude-Configuration-Authorization-AdminPermissions'></a>
## AdminPermissions `type`

##### Namespace

Definux.Emeraude.Configuration.Authorization

##### Summary

Static class that provides administration permissions of the Emeraude.

<a name='F-Definux-Emeraude-Configuration-Authorization-AdminPermissions-AccessAdministrationPolicy'></a>
### AccessAdministrationPolicy `constants`

##### Summary

Access administration policy name.

<a name='F-Definux-Emeraude-Configuration-Authorization-AdminPermissions-AccessLogsPolicy'></a>
### AccessLogsPolicy `constants`

##### Summary

Access logs policy name.

<a name='F-Definux-Emeraude-Configuration-Authorization-AdminPermissions-RootAccessPolicy'></a>
### RootAccessPolicy `constants`

##### Summary

Root access policty name.

<a name='F-Definux-Emeraude-Configuration-Authorization-AdminPermissions-UsersManagementPolicy'></a>
### UsersManagementPolicy `constants`

##### Summary

Users management policy name.

<a name='P-Definux-Emeraude-Configuration-Authorization-AdminPermissions-AccessAdministration'></a>
### AccessAdministration `property`

##### Summary

Access administration application permission.

<a name='P-Definux-Emeraude-Configuration-Authorization-AdminPermissions-AccessLogs'></a>
### AccessLogs `property`

##### Summary

Access error logs application permission.

<a name='P-Definux-Emeraude-Configuration-Authorization-AdminPermissions-AllPermissions'></a>
### AllPermissions `property`

##### Summary

Readonly collection contains all permissions of the system.

<a name='P-Definux-Emeraude-Configuration-Authorization-AdminPermissions-RootAccess'></a>
### RootAccess `property`

##### Summary

Root access application permission.

<a name='P-Definux-Emeraude-Configuration-Authorization-AdminPermissions-UsersManagement'></a>
### UsersManagement `property`

##### Summary

Users management application permission.

<a name='M-Definux-Emeraude-Configuration-Authorization-AdminPermissions-GetAllPermissionValues'></a>
### GetAllPermissionValues() `method`

##### Summary

Get all permission values from all permissions.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Configuration-Authorization-AdminPermissions-GetPermissionByName-System-String-'></a>
### GetPermissionByName(permissionName) `method`

##### Summary

Get permission from the list by its permission name.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| permissionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Configuration-Authorization-AdminPermissions-GetPermissionByValue-System-String-'></a>
### GetPermissionByValue(permissionValue) `method`

##### Summary

Get permission from the list by its permission value.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| permissionValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Configuration-Authorization-ApplicationPermission'></a>
## ApplicationPermission `type`

##### Namespace

Definux.Emeraude.Configuration.Authorization

##### Summary

Class that represent application permission used for policy based authorization.

<a name='M-Definux-Emeraude-Configuration-Authorization-ApplicationPermission-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [ApplicationPermission](#T-Definux-Emeraude-Configuration-Authorization-ApplicationPermission 'Definux.Emeraude.Configuration.Authorization.ApplicationPermission') class.

##### Parameters

This constructor has no parameters.

<a name='M-Definux-Emeraude-Configuration-Authorization-ApplicationPermission-#ctor-System-String-'></a>
### #ctor(name) `constructor`

##### Summary

Initializes a new instance of the [ApplicationPermission](#T-Definux-Emeraude-Configuration-Authorization-ApplicationPermission 'Definux.Emeraude.Configuration.Authorization.ApplicationPermission') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='P-Definux-Emeraude-Configuration-Authorization-ApplicationPermission-Name'></a>
### Name `property`

##### Summary

Name of the application permission.

<a name='P-Definux-Emeraude-Configuration-Authorization-ApplicationPermission-Value'></a>
### Value `property`

##### Summary

Value of the application permission.

<a name='M-Definux-Emeraude-Configuration-Authorization-ApplicationPermission-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Configuration-Authorization-ApplicationPermission-op_Implicit-Definux-Emeraude-Configuration-Authorization-ApplicationPermission-~System-String'></a>
### op_Implicit(permission) `method`

##### Summary

Implicit string conversion.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| permission | [Definux.Emeraude.Configuration.Authorization.ApplicationPermission)~System.String](#T-Definux-Emeraude-Configuration-Authorization-ApplicationPermission-~System-String 'Definux.Emeraude.Configuration.Authorization.ApplicationPermission)~System.String') |  |

<a name='T-Definux-Emeraude-Configuration-Authorization-ApplicationRoles'></a>
## ApplicationRoles `type`

##### Namespace

Definux.Emeraude.Configuration.Authorization

##### Summary

List of all predefined application roles.

<a name='F-Definux-Emeraude-Configuration-Authorization-ApplicationRoles-Admin'></a>
### Admin `constants`

##### Summary

Role 'Admin' represent user with absolute all rights in the system.

<a name='F-Definux-Emeraude-Configuration-Authorization-ApplicationRoles-User'></a>
### User `constants`

##### Summary

Role 'User' represent user with access onli in client part of the system.

<a name='T-Definux-Emeraude-Configuration-Authorization-AuthenticationDefaults'></a>
## AuthenticationDefaults `type`

##### Namespace

Definux.Emeraude.Configuration.Authorization

##### Summary

List of all authentication constants into the system.

<a name='F-Definux-Emeraude-Configuration-Authorization-AuthenticationDefaults-AdminAuthenticationScheme'></a>
### AdminAuthenticationScheme `constants`

##### Summary

Name of the admin authentication scheme.

<a name='F-Definux-Emeraude-Configuration-Authorization-AuthenticationDefaults-AdminCookieName'></a>
### AdminCookieName `constants`

##### Summary

Name of the admin session cookie.

<a name='F-Definux-Emeraude-Configuration-Authorization-AuthenticationDefaults-ClientAuthenticationScheme'></a>
### ClientAuthenticationScheme `constants`

##### Summary

Name of the client authentication scheme.

<a name='F-Definux-Emeraude-Configuration-Authorization-AuthenticationDefaults-ClientCookieName'></a>
### ClientCookieName `constants`

##### Summary

Name of the client session cookie.

<a name='F-Definux-Emeraude-Configuration-Authorization-AuthenticationDefaults-JwtBearerAuthenticationScheme'></a>
### JwtBearerAuthenticationScheme `constants`

##### Summary

Name of the JSON web token Bearer authentication scheme.

<a name='T-Definux-Emeraude-Configuration-Authorization-ClaimTypes'></a>
## ClaimTypes `type`

##### Namespace

Definux.Emeraude.Configuration.Authorization

##### Summary

List of all custom predefined claim types.

<a name='F-Definux-Emeraude-Configuration-Authorization-ClaimTypes-Imitate'></a>
### Imitate `constants`

##### Summary

Imitate type.

<a name='F-Definux-Emeraude-Configuration-Authorization-ClaimTypes-Permission'></a>
### Permission `constants`

##### Summary

Permission type.

<a name='F-Definux-Emeraude-Configuration-Authorization-ClaimTypes-Picture'></a>
### Picture `constants`

##### Summary

Picture type.

<a name='T-Definux-Emeraude-Configuration-Options-DatabaseContextProvider'></a>
## DatabaseContextProvider `type`

##### Namespace

Definux.Emeraude.Configuration.Options

##### Summary

Provider of database used for main context.

<a name='F-Definux-Emeraude-Configuration-Options-DatabaseContextProvider-InMemoryDatabase'></a>
### InMemoryDatabase `constants`

##### Summary

To be used only for test purposes.

<a name='F-Definux-Emeraude-Configuration-Options-DatabaseContextProvider-MicrosoftSqlServer'></a>
### MicrosoftSqlServer `constants`

##### Summary

Microsoft SQL Server.

<a name='F-Definux-Emeraude-Configuration-Options-DatabaseContextProvider-PostgreSql'></a>
### PostgreSql `constants`

##### Summary

PostgreSQL

<a name='T-Definux-Emeraude-Configuration-Options-EmIdentityConstants'></a>
## EmIdentityConstants `type`

##### Namespace

Definux.Emeraude.Configuration.Options

##### Summary

List of Emeraude identity constants.

<a name='F-Definux-Emeraude-Configuration-Options-EmIdentityConstants-DefaultEmeraudeAdminEmail'></a>
### DefaultEmeraudeAdminEmail `constants`

##### Summary

Default Emeraude admin email.

<a name='F-Definux-Emeraude-Configuration-Options-EmIdentityConstants-DefaultEmeraudeAdminName'></a>
### DefaultEmeraudeAdminName `constants`

##### Summary

Default Emeraude admin name.

<a name='F-Definux-Emeraude-Configuration-Options-EmIdentityConstants-DefaultEmeraudeAdminPassword'></a>
### DefaultEmeraudeAdminPassword `constants`

##### Summary

Default Emeraude admin password.

<a name='F-Definux-Emeraude-Configuration-Options-EmIdentityConstants-DefaultEmeraudeUserEmail'></a>
### DefaultEmeraudeUserEmail `constants`

##### Summary

Default Emeraude user email.

<a name='F-Definux-Emeraude-Configuration-Options-EmIdentityConstants-DefaultEmeraudeUserName'></a>
### DefaultEmeraudeUserName `constants`

##### Summary

Default Emeraude user name.

<a name='F-Definux-Emeraude-Configuration-Options-EmIdentityConstants-DefaultEmeraudeUserPassword'></a>
### DefaultEmeraudeUserPassword `constants`

##### Summary

Default Emeraude user password.

<a name='F-Definux-Emeraude-Configuration-Options-EmIdentityConstants-DefaultLockoutTimeSpanMinutes'></a>
### DefaultLockoutTimeSpanMinutes `constants`

##### Summary

Default lockout time in minutes.

<a name='F-Definux-Emeraude-Configuration-Options-EmIdentityConstants-MaxFailedAccessAttempts'></a>
### MaxFailedAccessAttempts `constants`

##### Summary

Default max failed access attempts.

<a name='F-Definux-Emeraude-Configuration-Options-EmIdentityConstants-PasswordRequiredLength'></a>
### PasswordRequiredLength `constants`

##### Summary

Default required password length.

<a name='T-Definux-Emeraude-Configuration-Options-EmOptions'></a>
## EmOptions `type`

##### Namespace

Definux.Emeraude.Configuration.Options

##### Summary

Emeraude framework options class.

<a name='M-Definux-Emeraude-Configuration-Options-EmOptions-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [EmOptions](#T-Definux-Emeraude-Configuration-Options-EmOptions 'Definux.Emeraude.Configuration.Options.EmOptions') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Configuration-Options-EmOptions-Account'></a>
### Account `property`

##### Summary

Account configuration options. For more information see [AccountOptions](#T-Definux-Emeraude-Configuration-Options-AccountOptions 'Definux.Emeraude.Configuration.Options.AccountOptions').

<a name='P-Definux-Emeraude-Configuration-Options-EmOptions-AdditonalRoles'></a>
### AdditonalRoles `property`

##### Summary

Dictionary that contains all additional roles and their claims.

<a name='P-Definux-Emeraude-Configuration-Options-EmOptions-AdminDashboardRequestType'></a>
### AdminDashboardRequestType `property`

##### Summary

Admin dashboard request type.

<a name='P-Definux-Emeraude-Configuration-Options-EmOptions-Assemblies'></a>
### Assemblies `property`

##### Summary

List with all assemblies used for registration of execution services and requests.

<a name='P-Definux-Emeraude-Configuration-Options-EmOptions-DatabaseContextProvider'></a>
### DatabaseContextProvider `property`

##### Summary

Provider of database storage for the application.

<a name='P-Definux-Emeraude-Configuration-Options-EmOptions-DatabaseInitializers'></a>
### DatabaseInitializers `property`

##### Summary

Collection of all database initializers.

<a name='P-Definux-Emeraude-Configuration-Options-EmOptions-EmeraudeAssembly'></a>
### EmeraudeAssembly `property`

##### Summary

Execution assembly of the application.

<a name='P-Definux-Emeraude-Configuration-Options-EmOptions-EmeraudeVersion'></a>
### EmeraudeVersion `property`

##### Summary

Get the current Emeraude Framework version.

<a name='P-Definux-Emeraude-Configuration-Options-EmOptions-ExecuteMigrations'></a>
### ExecuteMigrations `property`

##### Summary

Flag that turn on/off auto execution of migrations for all database contexts.

<a name='P-Definux-Emeraude-Configuration-Options-EmOptions-LoggerContextProvider'></a>
### LoggerContextProvider `property`

##### Summary

Provider of logger storage for the application.

<a name='P-Definux-Emeraude-Configuration-Options-EmOptions-MaintenanceMode'></a>
### MaintenanceMode `property`

##### Summary

Flag that turn on/off the maintenance mode of the application. If it is set to 'true' all public client controllers will be available only after admin authentication.

<a name='P-Definux-Emeraude-Configuration-Options-EmOptions-Mapping'></a>
### Mapping `property`

##### Summary

AutoMapper configuration options. For more information see [MappingOptions](#T-Definux-Emeraude-Configuration-Options-MappingOptions 'Definux.Emeraude.Configuration.Options.MappingOptions').

<a name='P-Definux-Emeraude-Configuration-Options-EmOptions-MigrationsAssembly'></a>
### MigrationsAssembly `property`

##### Summary

Contains the migrations assembly name.

<a name='P-Definux-Emeraude-Configuration-Options-EmOptions-ProjectName'></a>
### ProjectName `property`

##### Summary

General name of the project. Default value is 'Emeraude'.

<a name='P-Definux-Emeraude-Configuration-Options-EmOptions-TestMode'></a>
### TestMode `property`

##### Summary

Activate test mode for the application. Recommended for unit and integration tests.

<a name='P-Definux-Emeraude-Configuration-Options-EmOptions-UseExternalLoggerImplementation'></a>
### UseExternalLoggerImplementation `property`

##### Summary

Provides the availability to be used custom logger with the base logger definitions.

<a name='M-Definux-Emeraude-Configuration-Options-EmOptions-AddAssembly-System-String-'></a>
### AddAssembly(assemblyName) `method`

##### Summary

Add assembly for the registration purposes of requests, validators, and handlers.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| assemblyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Configuration-Options-EmOptions-AddAssembly-System-Reflection-Assembly-'></a>
### AddAssembly(assembly) `method`

##### Summary

Add assembly for the registration purposes of requests, validators, and handlers.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| assembly | [System.Reflection.Assembly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.Assembly 'System.Reflection.Assembly') |  |

<a name='M-Definux-Emeraude-Configuration-Options-EmOptions-AddDatabaseInitializer``1'></a>
### AddDatabaseInitializer\`\`1() `method`

##### Summary

Register a database initializer into the database initializer manager. The order of adding is the order of calling.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TDatabaseInitializer | Interface type of the database initializer. |

<a name='M-Definux-Emeraude-Configuration-Options-EmOptions-AddRole-System-String,System-String[]-'></a>
### AddRole(roleName,claims) `method`

##### Summary

Add additional role to the roles of the system. It is prefered to be added before first initialization of the system.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| roleName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| claims | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

<a name='M-Definux-Emeraude-Configuration-Options-EmOptions-SetEmeraudeAssembly-System-Reflection-Assembly-'></a>
### SetEmeraudeAssembly(assembly) `method`

##### Summary

Set the application execution assembly if the value is not set.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| assembly | [System.Reflection.Assembly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.Assembly 'System.Reflection.Assembly') |  |

<a name='T-Definux-Emeraude-Configuration-Options-MappingOptions'></a>
## MappingOptions `type`

##### Namespace

Definux.Emeraude.Configuration.Options

##### Summary

Configuration class that contains mapping assemblies and profiles for proper AutoMapper set up.

<a name='M-Definux-Emeraude-Configuration-Options-MappingOptions-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [MappingOptions](#T-Definux-Emeraude-Configuration-Options-MappingOptions 'Definux.Emeraude.Configuration.Options.MappingOptions') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Configuration-Options-MappingOptions-MappingAssemblies'></a>
### MappingAssemblies `property`

##### Summary

List of all assemblies that contains mappings.

<a name='P-Definux-Emeraude-Configuration-Options-MappingOptions-MappingProfiles'></a>
### MappingProfiles `property`

##### Summary

List of all mapping profiles types used for AutoMapper configuration.

<a name='M-Definux-Emeraude-Configuration-Options-MappingOptions-AddProfile``1'></a>
### AddProfile\`\`1() `method`

##### Summary

Add new mapping profile type to the mapping profile. The method is prefered than the [MappingProfiles](#P-Definux-Emeraude-Configuration-Options-MappingOptions-MappingProfiles 'Definux.Emeraude.Configuration.Options.MappingOptions.MappingProfiles') property.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TProfile | AutoMapper profile type. |

<a name='T-Definux-Emeraude-Configuration-Authorization-Policies'></a>
## Policies `type`

##### Namespace

Definux.Emeraude.Configuration.Authorization

##### Summary

List of the all predefined policies into the Emeraude framework.

<a name='F-Definux-Emeraude-Configuration-Authorization-Policies-AuthorizedUploadPolicy'></a>
### AuthorizedUploadPolicy `constants`

##### Summary

Policy used for upload functionality restrictions.

<a name='T-Definux-Emeraude-Configuration-Abstractions-UIConfigureOptions'></a>
## UIConfigureOptions `type`

##### Namespace

Definux.Emeraude.Configuration.Abstractions

##### Summary

UI options that configure the static files loaded in the assembly.

<a name='M-Definux-Emeraude-Configuration-Abstractions-UIConfigureOptions-#ctor-Microsoft-AspNetCore-Hosting-IHostingEnvironment-'></a>
### #ctor(environment) `constructor`

##### Summary

Initializes a new instance of the [UIConfigureOptions](#T-Definux-Emeraude-Configuration-Abstractions-UIConfigureOptions 'Definux.Emeraude.Configuration.Abstractions.UIConfigureOptions') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| environment | [Microsoft.AspNetCore.Hosting.IHostingEnvironment](#T-Microsoft-AspNetCore-Hosting-IHostingEnvironment 'Microsoft.AspNetCore.Hosting.IHostingEnvironment') |  |

<a name='P-Definux-Emeraude-Configuration-Abstractions-UIConfigureOptions-Environment'></a>
### Environment `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Configuration-Abstractions-UIConfigureOptions-PostConfigure-System-String,Microsoft-AspNetCore-Builder-StaticFileOptions-'></a>
### PostConfigure() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.
