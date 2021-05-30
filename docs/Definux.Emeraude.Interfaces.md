<a name='assembly'></a>
# Definux.Emeraude.Interfaces

## Contents

- [IBearerAuthenticationResult](#T-Definux-Emeraude-Interfaces-Results-IBearerAuthenticationResult 'Definux.Emeraude.Interfaces.Results.IBearerAuthenticationResult')
  - [JsonWebToken](#P-Definux-Emeraude-Interfaces-Results-IBearerAuthenticationResult-JsonWebToken 'Definux.Emeraude.Interfaces.Results.IBearerAuthenticationResult.JsonWebToken')
  - [Message](#P-Definux-Emeraude-Interfaces-Results-IBearerAuthenticationResult-Message 'Definux.Emeraude.Interfaces.Results.IBearerAuthenticationResult.Message')
  - [RefreshToken](#P-Definux-Emeraude-Interfaces-Results-IBearerAuthenticationResult-RefreshToken 'Definux.Emeraude.Interfaces.Results.IBearerAuthenticationResult.RefreshToken')
  - [Success](#P-Definux-Emeraude-Interfaces-Results-IBearerAuthenticationResult-Success 'Definux.Emeraude.Interfaces.Results.IBearerAuthenticationResult.Success')
- [IChangePasswordRequest](#T-Definux-Emeraude-Interfaces-Requests-IChangePasswordRequest 'Definux.Emeraude.Interfaces.Requests.IChangePasswordRequest')
  - [ConfirmedPassword](#P-Definux-Emeraude-Interfaces-Requests-IChangePasswordRequest-ConfirmedPassword 'Definux.Emeraude.Interfaces.Requests.IChangePasswordRequest.ConfirmedPassword')
  - [CurrentPassword](#P-Definux-Emeraude-Interfaces-Requests-IChangePasswordRequest-CurrentPassword 'Definux.Emeraude.Interfaces.Requests.IChangePasswordRequest.CurrentPassword')
  - [NewPassword](#P-Definux-Emeraude-Interfaces-Requests-IChangePasswordRequest-NewPassword 'Definux.Emeraude.Interfaces.Requests.IChangePasswordRequest.NewPassword')
  - [UserId](#P-Definux-Emeraude-Interfaces-Requests-IChangePasswordRequest-UserId 'Definux.Emeraude.Interfaces.Requests.IChangePasswordRequest.UserId')
- [IDatabaseInitializer](#T-Definux-Emeraude-Interfaces-Services-IDatabaseInitializer 'Definux.Emeraude.Interfaces.Services.IDatabaseInitializer')
  - [SeedAsync()](#M-Definux-Emeraude-Interfaces-Services-IDatabaseInitializer-SeedAsync 'Definux.Emeraude.Interfaces.Services.IDatabaseInitializer.SeedAsync')
- [IExternalLoginRequest](#T-Definux-Emeraude-Interfaces-Requests-IExternalLoginRequest 'Definux.Emeraude.Interfaces.Requests.IExternalLoginRequest')
  - [AccessToken](#P-Definux-Emeraude-Interfaces-Requests-IExternalLoginRequest-AccessToken 'Definux.Emeraude.Interfaces.Requests.IExternalLoginRequest.AccessToken')
  - [Provider](#P-Definux-Emeraude-Interfaces-Requests-IExternalLoginRequest-Provider 'Definux.Emeraude.Interfaces.Requests.IExternalLoginRequest.Provider')
- [IForgotPasswordRequest](#T-Definux-Emeraude-Interfaces-Requests-IForgotPasswordRequest 'Definux.Emeraude.Interfaces.Requests.IForgotPasswordRequest')
  - [Email](#P-Definux-Emeraude-Interfaces-Requests-IForgotPasswordRequest-Email 'Definux.Emeraude.Interfaces.Requests.IForgotPasswordRequest.Email')
- [ILocalizer](#T-Definux-Emeraude-Interfaces-Services-ILocalizer 'Definux.Emeraude.Interfaces.Services.ILocalizer')
  - [Item](#P-Definux-Emeraude-Interfaces-Services-ILocalizer-Item-System-String- 'Definux.Emeraude.Interfaces.Services.ILocalizer.Item(System.String)')
  - [GetStaticContent(key)](#M-Definux-Emeraude-Interfaces-Services-ILocalizer-GetStaticContent-System-String- 'Definux.Emeraude.Interfaces.Services.ILocalizer.GetStaticContent(System.String)')
  - [GetStaticContentAsync(key)](#M-Definux-Emeraude-Interfaces-Services-ILocalizer-GetStaticContentAsync-System-String- 'Definux.Emeraude.Interfaces.Services.ILocalizer.GetStaticContentAsync(System.String)')
  - [TranslateKey(key)](#M-Definux-Emeraude-Interfaces-Services-ILocalizer-TranslateKey-System-String- 'Definux.Emeraude.Interfaces.Services.ILocalizer.TranslateKey(System.String)')
  - [TranslateKeyAsync(key)](#M-Definux-Emeraude-Interfaces-Services-ILocalizer-TranslateKeyAsync-System-String- 'Definux.Emeraude.Interfaces.Services.ILocalizer.TranslateKeyAsync(System.String)')
- [ILogger](#T-Definux-Emeraude-Interfaces-Services-ILogger 'Definux.Emeraude.Interfaces.Services.ILogger')
  - [LogError(exception,method)](#M-Definux-Emeraude-Interfaces-Services-ILogger-LogError-System-Exception,System-String- 'Definux.Emeraude.Interfaces.Services.ILogger.LogError(System.Exception,System.String)')
  - [LogErrorAsync(exception,method)](#M-Definux-Emeraude-Interfaces-Services-ILogger-LogErrorAsync-System-Exception,System-String- 'Definux.Emeraude.Interfaces.Services.ILogger.LogErrorAsync(System.Exception,System.String)')
  - [LogErrorWithoutAnException(source,message,method)](#M-Definux-Emeraude-Interfaces-Services-ILogger-LogErrorWithoutAnException-System-String,System-String,System-String- 'Definux.Emeraude.Interfaces.Services.ILogger.LogErrorWithoutAnException(System.String,System.String,System.String)')
- [ILoginRequest](#T-Definux-Emeraude-Interfaces-Requests-ILoginRequest 'Definux.Emeraude.Interfaces.Requests.ILoginRequest')
  - [Email](#P-Definux-Emeraude-Interfaces-Requests-ILoginRequest-Email 'Definux.Emeraude.Interfaces.Requests.ILoginRequest.Email')
  - [Password](#P-Definux-Emeraude-Interfaces-Requests-ILoginRequest-Password 'Definux.Emeraude.Interfaces.Requests.ILoginRequest.Password')
- [IRegisterRequest](#T-Definux-Emeraude-Interfaces-Requests-IRegisterRequest 'Definux.Emeraude.Interfaces.Requests.IRegisterRequest')
  - [ConfirmedPassword](#P-Definux-Emeraude-Interfaces-Requests-IRegisterRequest-ConfirmedPassword 'Definux.Emeraude.Interfaces.Requests.IRegisterRequest.ConfirmedPassword')
  - [Email](#P-Definux-Emeraude-Interfaces-Requests-IRegisterRequest-Email 'Definux.Emeraude.Interfaces.Requests.IRegisterRequest.Email')
  - [Name](#P-Definux-Emeraude-Interfaces-Requests-IRegisterRequest-Name 'Definux.Emeraude.Interfaces.Requests.IRegisterRequest.Name')
  - [Password](#P-Definux-Emeraude-Interfaces-Requests-IRegisterRequest-Password 'Definux.Emeraude.Interfaces.Requests.IRegisterRequest.Password')
- [IResetPasswordRequest](#T-Definux-Emeraude-Interfaces-Requests-IResetPasswordRequest 'Definux.Emeraude.Interfaces.Requests.IResetPasswordRequest')
  - [ConfirmedPassword](#P-Definux-Emeraude-Interfaces-Requests-IResetPasswordRequest-ConfirmedPassword 'Definux.Emeraude.Interfaces.Requests.IResetPasswordRequest.ConfirmedPassword')
  - [Email](#P-Definux-Emeraude-Interfaces-Requests-IResetPasswordRequest-Email 'Definux.Emeraude.Interfaces.Requests.IResetPasswordRequest.Email')
  - [Password](#P-Definux-Emeraude-Interfaces-Requests-IResetPasswordRequest-Password 'Definux.Emeraude.Interfaces.Requests.IResetPasswordRequest.Password')
  - [Token](#P-Definux-Emeraude-Interfaces-Requests-IResetPasswordRequest-Token 'Definux.Emeraude.Interfaces.Requests.IResetPasswordRequest.Token')

<a name='T-Definux-Emeraude-Interfaces-Results-IBearerAuthenticationResult'></a>
## IBearerAuthenticationResult `type`

##### Namespace

Definux.Emeraude.Interfaces.Results

##### Summary

Interface that defines the required fields for bearer authentication result.

<a name='P-Definux-Emeraude-Interfaces-Results-IBearerAuthenticationResult-JsonWebToken'></a>
### JsonWebToken `property`

##### Summary

Json web token.

<a name='P-Definux-Emeraude-Interfaces-Results-IBearerAuthenticationResult-Message'></a>
### Message `property`

##### Summary

Message of the result.

<a name='P-Definux-Emeraude-Interfaces-Results-IBearerAuthenticationResult-RefreshToken'></a>
### RefreshToken `property`

##### Summary

Refresh token.

<a name='P-Definux-Emeraude-Interfaces-Results-IBearerAuthenticationResult-Success'></a>
### Success `property`

##### Summary

Indicates the success status of the result.

<a name='T-Definux-Emeraude-Interfaces-Requests-IChangePasswordRequest'></a>
## IChangePasswordRequest `type`

##### Namespace

Definux.Emeraude.Interfaces.Requests

##### Summary

Definition of change password request.

<a name='P-Definux-Emeraude-Interfaces-Requests-IChangePasswordRequest-ConfirmedPassword'></a>
### ConfirmedPassword `property`

##### Summary

Confirmed new password of the user.

<a name='P-Definux-Emeraude-Interfaces-Requests-IChangePasswordRequest-CurrentPassword'></a>
### CurrentPassword `property`

##### Summary

Current password of the user.

<a name='P-Definux-Emeraude-Interfaces-Requests-IChangePasswordRequest-NewPassword'></a>
### NewPassword `property`

##### Summary

New password of the user.

<a name='P-Definux-Emeraude-Interfaces-Requests-IChangePasswordRequest-UserId'></a>
### UserId `property`

##### Summary

Id of the user.

<a name='T-Definux-Emeraude-Interfaces-Services-IDatabaseInitializer'></a>
## IDatabaseInitializer `type`

##### Namespace

Definux.Emeraude.Interfaces.Services

##### Summary

Definition of database initializer.

<a name='M-Definux-Emeraude-Interfaces-Services-IDatabaseInitializer-SeedAsync'></a>
### SeedAsync() `method`

##### Summary

Seed the data into database for the current initializer.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Interfaces-Requests-IExternalLoginRequest'></a>
## IExternalLoginRequest `type`

##### Namespace

Definux.Emeraude.Interfaces.Requests

##### Summary

Definition of external login request of Emeraude client authentication.

<a name='P-Definux-Emeraude-Interfaces-Requests-IExternalLoginRequest-AccessToken'></a>
### AccessToken `property`

##### Summary

Access token of the login provider.

<a name='P-Definux-Emeraude-Interfaces-Requests-IExternalLoginRequest-Provider'></a>
### Provider `property`

##### Summary

External login provider.

<a name='T-Definux-Emeraude-Interfaces-Requests-IForgotPasswordRequest'></a>
## IForgotPasswordRequest `type`

##### Namespace

Definux.Emeraude.Interfaces.Requests

##### Summary

Definition of forgot password request of Emeraude client authentication.

<a name='P-Definux-Emeraude-Interfaces-Requests-IForgotPasswordRequest-Email'></a>
### Email `property`

##### Summary

Email of the user.

<a name='T-Definux-Emeraude-Interfaces-Services-ILocalizer'></a>
## ILocalizer `type`

##### Namespace

Definux.Emeraude.Interfaces.Services

##### Summary

Definition of translation service.

<a name='P-Definux-Emeraude-Interfaces-Services-ILocalizer-Item-System-String-'></a>
### Item `property`

##### Summary

Get a translation by using the current language.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Interfaces-Services-ILocalizer-GetStaticContent-System-String-'></a>
### GetStaticContent(key) `method`

##### Summary

Get static content by using the current language.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Interfaces-Services-ILocalizer-GetStaticContentAsync-System-String-'></a>
### GetStaticContentAsync(key) `method`

##### Summary

Get static content by using the current language (async execution).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Interfaces-Services-ILocalizer-TranslateKey-System-String-'></a>
### TranslateKey(key) `method`

##### Summary

Translate key by using the current language.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Interfaces-Services-ILocalizer-TranslateKeyAsync-System-String-'></a>
### TranslateKeyAsync(key) `method`

##### Summary

Translate key by using the current language (async execution).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Interfaces-Services-ILogger'></a>
## ILogger `type`

##### Namespace

Definux.Emeraude.Interfaces.Services

##### Summary

Definition of logger.

<a name='M-Definux-Emeraude-Interfaces-Services-ILogger-LogError-System-Exception,System-String-'></a>
### LogError(exception,method) `method`

##### Summary

Save information for thrown exception.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') |  |
| method | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Interfaces-Services-ILogger-LogErrorAsync-System-Exception,System-String-'></a>
### LogErrorAsync(exception,method) `method`

##### Summary

Save information (async execution) for thrown exception.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') |  |
| method | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Interfaces-Services-ILogger-LogErrorWithoutAnException-System-String,System-String,System-String-'></a>
### LogErrorWithoutAnException(source,message,method) `method`

##### Summary

Save information for specific error without existing exception.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| method | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Interfaces-Requests-ILoginRequest'></a>
## ILoginRequest `type`

##### Namespace

Definux.Emeraude.Interfaces.Requests

##### Summary

Definition of login request of Emeraude client authentication.

<a name='P-Definux-Emeraude-Interfaces-Requests-ILoginRequest-Email'></a>
### Email `property`

##### Summary

Email of the user.

<a name='P-Definux-Emeraude-Interfaces-Requests-ILoginRequest-Password'></a>
### Password `property`

##### Summary

Password of the user.

<a name='T-Definux-Emeraude-Interfaces-Requests-IRegisterRequest'></a>
## IRegisterRequest `type`

##### Namespace

Definux.Emeraude.Interfaces.Requests

##### Summary

Definition of register request of Emeraude client authentication.

<a name='P-Definux-Emeraude-Interfaces-Requests-IRegisterRequest-ConfirmedPassword'></a>
### ConfirmedPassword `property`

##### Summary

Confirmed password of the user.

<a name='P-Definux-Emeraude-Interfaces-Requests-IRegisterRequest-Email'></a>
### Email `property`

##### Summary

Email of the user.

<a name='P-Definux-Emeraude-Interfaces-Requests-IRegisterRequest-Name'></a>
### Name `property`

##### Summary

Name of the user.

<a name='P-Definux-Emeraude-Interfaces-Requests-IRegisterRequest-Password'></a>
### Password `property`

##### Summary

Password of the user.

<a name='T-Definux-Emeraude-Interfaces-Requests-IResetPasswordRequest'></a>
## IResetPasswordRequest `type`

##### Namespace

Definux.Emeraude.Interfaces.Requests

##### Summary

Definition of reset password request of Emeraude client authentication.

<a name='P-Definux-Emeraude-Interfaces-Requests-IResetPasswordRequest-ConfirmedPassword'></a>
### ConfirmedPassword `property`

##### Summary

Confirmed password of the user.

<a name='P-Definux-Emeraude-Interfaces-Requests-IResetPasswordRequest-Email'></a>
### Email `property`

##### Summary

Email of the user.

<a name='P-Definux-Emeraude-Interfaces-Requests-IResetPasswordRequest-Password'></a>
### Password `property`

##### Summary

Password of the user.

<a name='P-Definux-Emeraude-Interfaces-Requests-IResetPasswordRequest-Token'></a>
### Token `property`

##### Summary

Verification reset password token.
