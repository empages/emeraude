<a name='assembly'></a>
# Definux.Emeraude.MobileSdk

## Contents

- [AccountViewModel](#T-Definux-Emeraude-MobileSdk-ViewModels-AccountViewModel 'Definux.Emeraude.MobileSdk.ViewModels.AccountViewModel')
  - [#ctor(navigationService,systemSettingsStore,localizer,authenticationStore,configuration)](#M-Definux-Emeraude-MobileSdk-ViewModels-AccountViewModel-#ctor-Prism-Navigation-INavigationService,Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore,Definux-Emeraude-Interfaces-Services-ILocalizer,Definux-Emeraude-MobileSdk-Stores-IAuthenticationStore,Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration- 'Definux.Emeraude.MobileSdk.ViewModels.AccountViewModel.#ctor(Prism.Navigation.INavigationService,Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore,Definux.Emeraude.Interfaces.Services.ILocalizer,Definux.Emeraude.MobileSdk.Stores.IAuthenticationStore,Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration)')
  - [AuthenticationStore](#P-Definux-Emeraude-MobileSdk-ViewModels-AccountViewModel-AuthenticationStore 'Definux.Emeraude.MobileSdk.ViewModels.AccountViewModel.AuthenticationStore')
  - [Configuration](#P-Definux-Emeraude-MobileSdk-ViewModels-AccountViewModel-Configuration 'Definux.Emeraude.MobileSdk.ViewModels.AccountViewModel.Configuration')
  - [GoToLoginPageCommand](#P-Definux-Emeraude-MobileSdk-ViewModels-AccountViewModel-GoToLoginPageCommand 'Definux.Emeraude.MobileSdk.ViewModels.AccountViewModel.GoToLoginPageCommand')
  - [GoToRegisterPageCommand](#P-Definux-Emeraude-MobileSdk-ViewModels-AccountViewModel-GoToRegisterPageCommand 'Definux.Emeraude.MobileSdk.ViewModels.AccountViewModel.GoToRegisterPageCommand')
  - [LoginWithFacebookCommand](#P-Definux-Emeraude-MobileSdk-ViewModels-AccountViewModel-LoginWithFacebookCommand 'Definux.Emeraude.MobileSdk.ViewModels.AccountViewModel.LoginWithFacebookCommand')
  - [LoginWithGoogleCommand](#P-Definux-Emeraude-MobileSdk-ViewModels-AccountViewModel-LoginWithGoogleCommand 'Definux.Emeraude.MobileSdk.ViewModels.AccountViewModel.LoginWithGoogleCommand')
  - [OAuth2Authenticator](#P-Definux-Emeraude-MobileSdk-ViewModels-AccountViewModel-OAuth2Authenticator 'Definux.Emeraude.MobileSdk.ViewModels.AccountViewModel.OAuth2Authenticator')
  - [OAuth2AuthenticatorType](#P-Definux-Emeraude-MobileSdk-ViewModels-AccountViewModel-OAuth2AuthenticatorType 'Definux.Emeraude.MobileSdk.ViewModels.AccountViewModel.OAuth2AuthenticatorType')
  - [OAuthLoginPresenter](#P-Definux-Emeraude-MobileSdk-ViewModels-AccountViewModel-OAuthLoginPresenter 'Definux.Emeraude.MobileSdk.ViewModels.AccountViewModel.OAuthLoginPresenter')
- [ApplicationLanguage](#T-Definux-Emeraude-MobileSdk-Settings-ApplicationLanguage 'Definux.Emeraude.MobileSdk.Settings.ApplicationLanguage')
  - [Code](#P-Definux-Emeraude-MobileSdk-Settings-ApplicationLanguage-Code 'Definux.Emeraude.MobileSdk.Settings.ApplicationLanguage.Code')
  - [IsDefault](#P-Definux-Emeraude-MobileSdk-Settings-ApplicationLanguage-IsDefault 'Definux.Emeraude.MobileSdk.Settings.ApplicationLanguage.IsDefault')
  - [Name](#P-Definux-Emeraude-MobileSdk-Settings-ApplicationLanguage-Name 'Definux.Emeraude.MobileSdk.Settings.ApplicationLanguage.Name')
  - [NativeName](#P-Definux-Emeraude-MobileSdk-Settings-ApplicationLanguage-NativeName 'Definux.Emeraude.MobileSdk.Settings.ApplicationLanguage.NativeName')
  - [ToString()](#M-Definux-Emeraude-MobileSdk-Settings-ApplicationLanguage-ToString 'Definux.Emeraude.MobileSdk.Settings.ApplicationLanguage.ToString')
- [AuthenticationServiceAgent](#T-Definux-Emeraude-MobileSdk-ServiceAgents-AuthenticationServiceAgent 'Definux.Emeraude.MobileSdk.ServiceAgents.AuthenticationServiceAgent')
  - [#ctor(configuration,clientFactory)](#M-Definux-Emeraude-MobileSdk-ServiceAgents-AuthenticationServiceAgent-#ctor-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration,Definux-Emeraude-MobileSdk-ServiceAgents-Http-IHttpClientFactory- 'Definux.Emeraude.MobileSdk.ServiceAgents.AuthenticationServiceAgent.#ctor(Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration,Definux.Emeraude.MobileSdk.ServiceAgents.Http.IHttpClientFactory)')
  - [RequestTokenAsync()](#M-Definux-Emeraude-MobileSdk-ServiceAgents-AuthenticationServiceAgent-RequestTokenAsync-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-LoginRequest- 'Definux.Emeraude.MobileSdk.ServiceAgents.AuthenticationServiceAgent.RequestTokenAsync(Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests.LoginRequest)')
  - [RequestTokenWithExternalProviderAsync()](#M-Definux-Emeraude-MobileSdk-ServiceAgents-AuthenticationServiceAgent-RequestTokenWithExternalProviderAsync-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-ExternalLoginRequest- 'Definux.Emeraude.MobileSdk.ServiceAgents.AuthenticationServiceAgent.RequestTokenWithExternalProviderAsync(Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests.ExternalLoginRequest)')
- [AuthenticationStore](#T-Definux-Emeraude-MobileSdk-Stores-AuthenticationStore 'Definux.Emeraude.MobileSdk.Stores.AuthenticationStore')
  - [#ctor(authenticationServiceAgent,loggingServiceAgent,configuration)](#M-Definux-Emeraude-MobileSdk-Stores-AuthenticationStore-#ctor-Definux-Emeraude-MobileSdk-ServiceAgents-IAuthenticationServiceAgent,Definux-Emeraude-MobileSdk-ServiceAgents-ILoggingServiceAgent,Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration- 'Definux.Emeraude.MobileSdk.Stores.AuthenticationStore.#ctor(Definux.Emeraude.MobileSdk.ServiceAgents.IAuthenticationServiceAgent,Definux.Emeraude.MobileSdk.ServiceAgents.ILoggingServiceAgent,Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration)')
  - [IsAuthenticated](#P-Definux-Emeraude-MobileSdk-Stores-AuthenticationStore-IsAuthenticated 'Definux.Emeraude.MobileSdk.Stores.AuthenticationStore.IsAuthenticated')
  - [RequestTokenAsync()](#M-Definux-Emeraude-MobileSdk-Stores-AuthenticationStore-RequestTokenAsync-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-LoginRequest- 'Definux.Emeraude.MobileSdk.Stores.AuthenticationStore.RequestTokenAsync(Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests.LoginRequest)')
  - [RequestTokenWithExternalProviderAsync()](#M-Definux-Emeraude-MobileSdk-Stores-AuthenticationStore-RequestTokenWithExternalProviderAsync-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-ExternalLoginRequest- 'Definux.Emeraude.MobileSdk.Stores.AuthenticationStore.RequestTokenWithExternalProviderAsync(Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests.ExternalLoginRequest)')
- [BearerAuthenticationResult](#T-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Results-BearerAuthenticationResult 'Definux.Emeraude.MobileSdk.ServiceAgents.Models.Results.BearerAuthenticationResult')
  - [JsonWebToken](#P-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Results-BearerAuthenticationResult-JsonWebToken 'Definux.Emeraude.MobileSdk.ServiceAgents.Models.Results.BearerAuthenticationResult.JsonWebToken')
  - [Message](#P-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Results-BearerAuthenticationResult-Message 'Definux.Emeraude.MobileSdk.ServiceAgents.Models.Results.BearerAuthenticationResult.Message')
  - [RefreshToken](#P-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Results-BearerAuthenticationResult-RefreshToken 'Definux.Emeraude.MobileSdk.ServiceAgents.Models.Results.BearerAuthenticationResult.RefreshToken')
  - [Success](#P-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Results-BearerAuthenticationResult-Success 'Definux.Emeraude.MobileSdk.ServiceAgents.Models.Results.BearerAuthenticationResult.Success')
- [ContainerRegistryExtensions](#T-Definux-Emeraude-MobileSdk-Extensions-ContainerRegistryExtensions 'Definux.Emeraude.MobileSdk.Extensions.ContainerRegistryExtensions')
  - [RegisterEmeraudeCore(containerRegistry,settingsAction)](#M-Definux-Emeraude-MobileSdk-Extensions-ContainerRegistryExtensions-RegisterEmeraudeCore-Prism-Ioc-IContainerRegistry,System-Action{Definux-Emeraude-MobileSdk-Settings-EmeraudeMobileSettings}- 'Definux.Emeraude.MobileSdk.Extensions.ContainerRegistryExtensions.RegisterEmeraudeCore(Prism.Ioc.IContainerRegistry,System.Action{Definux.Emeraude.MobileSdk.Settings.EmeraudeMobileSettings})')
  - [RegisterEmeraudeLocalizer(containerRegistry,resourceManager,systemSettingsStore)](#M-Definux-Emeraude-MobileSdk-Extensions-ContainerRegistryExtensions-RegisterEmeraudeLocalizer-Prism-Ioc-IContainerRegistry,System-Resources-ResourceManager,Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore- 'Definux.Emeraude.MobileSdk.Extensions.ContainerRegistryExtensions.RegisterEmeraudeLocalizer(Prism.Ioc.IContainerRegistry,System.Resources.ResourceManager,Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore)')
- [EmConfiguration](#T-Definux-Emeraude-MobileSdk-Configuration-EmConfiguration 'Definux.Emeraude.MobileSdk.Configuration.EmConfiguration')
  - [#ctor(rootBaseUrl)](#M-Definux-Emeraude-MobileSdk-Configuration-EmConfiguration-#ctor-System-String- 'Definux.Emeraude.MobileSdk.Configuration.EmConfiguration.#ctor(System.String)')
  - [#ctor(hostMachineIp,addressPort,useHttps)](#M-Definux-Emeraude-MobileSdk-Configuration-EmConfiguration-#ctor-System-String,System-String,System-Boolean- 'Definux.Emeraude.MobileSdk.Configuration.EmConfiguration.#ctor(System.String,System.String,System.Boolean)')
  - [FacebookAppId](#P-Definux-Emeraude-MobileSdk-Configuration-EmConfiguration-FacebookAppId 'Definux.Emeraude.MobileSdk.Configuration.EmConfiguration.FacebookAppId')
  - [FacebookRedirectUrl](#P-Definux-Emeraude-MobileSdk-Configuration-EmConfiguration-FacebookRedirectUrl 'Definux.Emeraude.MobileSdk.Configuration.EmConfiguration.FacebookRedirectUrl')
  - [GoogleClientId](#P-Definux-Emeraude-MobileSdk-Configuration-EmConfiguration-GoogleClientId 'Definux.Emeraude.MobileSdk.Configuration.EmConfiguration.GoogleClientId')
  - [GoogleRedirectUrl](#P-Definux-Emeraude-MobileSdk-Configuration-EmConfiguration-GoogleRedirectUrl 'Definux.Emeraude.MobileSdk.Configuration.EmConfiguration.GoogleRedirectUrl')
  - [Headers](#P-Definux-Emeraude-MobileSdk-Configuration-EmConfiguration-Headers 'Definux.Emeraude.MobileSdk.Configuration.EmConfiguration.Headers')
  - [RootBaseUrl](#P-Definux-Emeraude-MobileSdk-Configuration-EmConfiguration-RootBaseUrl 'Definux.Emeraude.MobileSdk.Configuration.EmConfiguration.RootBaseUrl')
  - [GetValueBasedOnDevicePlatform()](#M-Definux-Emeraude-MobileSdk-Configuration-EmConfiguration-GetValueBasedOnDevicePlatform-System-String,System-String- 'Definux.Emeraude.MobileSdk.Configuration.EmConfiguration.GetValueBasedOnDevicePlatform(System.String,System.String)')
  - [ToHostSettings()](#M-Definux-Emeraude-MobileSdk-Configuration-EmConfiguration-ToHostSettings 'Definux.Emeraude.MobileSdk.Configuration.EmConfiguration.ToHostSettings')
- [EmStaticServiceProvider](#T-Definux-Emeraude-MobileSdk-Services-EmStaticServiceProvider 'Definux.Emeraude.MobileSdk.Services.EmStaticServiceProvider')
  - [GetService\`\`1()](#M-Definux-Emeraude-MobileSdk-Services-EmStaticServiceProvider-GetService``1 'Definux.Emeraude.MobileSdk.Services.EmStaticServiceProvider.GetService``1')
- [EmeraudeMobileSettings](#T-Definux-Emeraude-MobileSdk-Settings-EmeraudeMobileSettings 'Definux.Emeraude.MobileSdk.Settings.EmeraudeMobileSettings')
  - [#ctor()](#M-Definux-Emeraude-MobileSdk-Settings-EmeraudeMobileSettings-#ctor 'Definux.Emeraude.MobileSdk.Settings.EmeraudeMobileSettings.#ctor')
  - [Languages](#P-Definux-Emeraude-MobileSdk-Settings-EmeraudeMobileSettings-Languages 'Definux.Emeraude.MobileSdk.Settings.EmeraudeMobileSettings.Languages')
  - [AddLanguage()](#M-Definux-Emeraude-MobileSdk-Settings-EmeraudeMobileSettings-AddLanguage-System-String,System-String,System-String,System-Boolean- 'Definux.Emeraude.MobileSdk.Settings.EmeraudeMobileSettings.AddLanguage(System.String,System.String,System.String,System.Boolean)')
- [ErrorMessageToBoolConverter](#T-Definux-Emeraude-MobileSdk-Converters-ErrorMessageToBoolConverter 'Definux.Emeraude.MobileSdk.Converters.ErrorMessageToBoolConverter')
  - [Convert()](#M-Definux-Emeraude-MobileSdk-Converters-ErrorMessageToBoolConverter-Convert-System-Object,System-Type,System-Object,System-Globalization-CultureInfo- 'Definux.Emeraude.MobileSdk.Converters.ErrorMessageToBoolConverter.Convert(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)')
  - [ConvertBack()](#M-Definux-Emeraude-MobileSdk-Converters-ErrorMessageToBoolConverter-ConvertBack-System-Object,System-Type,System-Object,System-Globalization-CultureInfo- 'Definux.Emeraude.MobileSdk.Converters.ErrorMessageToBoolConverter.ConvertBack(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)')
- [ExternalLoginRequest](#T-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-ExternalLoginRequest 'Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests.ExternalLoginRequest')
  - [AccessToken](#P-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-ExternalLoginRequest-AccessToken 'Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests.ExternalLoginRequest.AccessToken')
  - [Provider](#P-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-ExternalLoginRequest-Provider 'Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests.ExternalLoginRequest.Provider')
- [ForgotPasswordFormModel](#T-Definux-Emeraude-MobileSdk-FormModels-ForgotPasswordFormModel 'Definux.Emeraude.MobileSdk.FormModels.ForgotPasswordFormModel')
  - [#ctor()](#M-Definux-Emeraude-MobileSdk-FormModels-ForgotPasswordFormModel-#ctor 'Definux.Emeraude.MobileSdk.FormModels.ForgotPasswordFormModel.#ctor')
  - [Email](#P-Definux-Emeraude-MobileSdk-FormModels-ForgotPasswordFormModel-Email 'Definux.Emeraude.MobileSdk.FormModels.ForgotPasswordFormModel.Email')
  - [IsValid()](#M-Definux-Emeraude-MobileSdk-FormModels-ForgotPasswordFormModel-IsValid 'Definux.Emeraude.MobileSdk.FormModels.ForgotPasswordFormModel.IsValid')
- [ForgotPasswordViewModel](#T-Definux-Emeraude-MobileSdk-ViewModels-ForgotPasswordViewModel 'Definux.Emeraude.MobileSdk.ViewModels.ForgotPasswordViewModel')
  - [#ctor(navigationService,systemSettingsStore,authenticationStore,localizer)](#M-Definux-Emeraude-MobileSdk-ViewModels-ForgotPasswordViewModel-#ctor-Prism-Navigation-INavigationService,Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore,Definux-Emeraude-MobileSdk-Stores-IAuthenticationStore,Definux-Emeraude-Interfaces-Services-ILocalizer- 'Definux.Emeraude.MobileSdk.ViewModels.ForgotPasswordViewModel.#ctor(Prism.Navigation.INavigationService,Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore,Definux.Emeraude.MobileSdk.Stores.IAuthenticationStore,Definux.Emeraude.Interfaces.Services.ILocalizer)')
  - [AuthenticationStore](#P-Definux-Emeraude-MobileSdk-ViewModels-ForgotPasswordViewModel-AuthenticationStore 'Definux.Emeraude.MobileSdk.ViewModels.ForgotPasswordViewModel.AuthenticationStore')
  - [ForgotPasswordModel](#P-Definux-Emeraude-MobileSdk-ViewModels-ForgotPasswordViewModel-ForgotPasswordModel 'Definux.Emeraude.MobileSdk.ViewModels.ForgotPasswordViewModel.ForgotPasswordModel')
  - [SubmitForgotPasswordFormCommand](#P-Definux-Emeraude-MobileSdk-ViewModels-ForgotPasswordViewModel-SubmitForgotPasswordFormCommand 'Definux.Emeraude.MobileSdk.ViewModels.ForgotPasswordViewModel.SubmitForgotPasswordFormCommand')
- [FormModel](#T-Definux-Emeraude-MobileSdk-FormModels-Abstractions-FormModel 'Definux.Emeraude.MobileSdk.FormModels.Abstractions.FormModel')
  - [#ctor()](#M-Definux-Emeraude-MobileSdk-FormModels-Abstractions-FormModel-#ctor 'Definux.Emeraude.MobileSdk.FormModels.Abstractions.FormModel.#ctor')
  - [Errors](#P-Definux-Emeraude-MobileSdk-FormModels-Abstractions-FormModel-Errors 'Definux.Emeraude.MobileSdk.FormModels.Abstractions.FormModel.Errors')
  - [HasErrors](#P-Definux-Emeraude-MobileSdk-FormModels-Abstractions-FormModel-HasErrors 'Definux.Emeraude.MobileSdk.FormModels.Abstractions.FormModel.HasErrors')
  - [AddError(propertyName,error)](#M-Definux-Emeraude-MobileSdk-FormModels-Abstractions-FormModel-AddError-System-String,System-String- 'Definux.Emeraude.MobileSdk.FormModels.Abstractions.FormModel.AddError(System.String,System.String)')
  - [IsValid()](#M-Definux-Emeraude-MobileSdk-FormModels-Abstractions-FormModel-IsValid 'Definux.Emeraude.MobileSdk.FormModels.Abstractions.FormModel.IsValid')
- [FormModelError](#T-Definux-Emeraude-MobileSdk-FormModels-Abstractions-FormModelError 'Definux.Emeraude.MobileSdk.FormModels.Abstractions.FormModelError')
  - [Error](#P-Definux-Emeraude-MobileSdk-FormModels-Abstractions-FormModelError-Error 'Definux.Emeraude.MobileSdk.FormModels.Abstractions.FormModelError.Error')
  - [Key](#P-Definux-Emeraude-MobileSdk-FormModels-Abstractions-FormModelError-Key 'Definux.Emeraude.MobileSdk.FormModels.Abstractions.FormModelError.Key')
- [HostSettings](#T-Definux-Emeraude-MobileSdk-ServiceAgents-Settings-HostSettings 'Definux.Emeraude.MobileSdk.ServiceAgents.Settings.HostSettings')
  - [Headers](#P-Definux-Emeraude-MobileSdk-ServiceAgents-Settings-HostSettings-Headers 'Definux.Emeraude.MobileSdk.ServiceAgents.Settings.HostSettings.Headers')
  - [Url](#P-Definux-Emeraude-MobileSdk-ServiceAgents-Settings-HostSettings-Url 'Definux.Emeraude.MobileSdk.ServiceAgents.Settings.HostSettings.Url')
- [HttpClientFactory](#T-Definux-Emeraude-MobileSdk-ServiceAgents-Http-HttpClientFactory 'Definux.Emeraude.MobileSdk.ServiceAgents.Http.HttpClientFactory')
  - [#ctor(requestHeaderHelper)](#M-Definux-Emeraude-MobileSdk-ServiceAgents-Http-HttpClientFactory-#ctor-Definux-Emeraude-MobileSdk-ServiceAgents-Http-IRequestHeaderHelper- 'Definux.Emeraude.MobileSdk.ServiceAgents.Http.HttpClientFactory.#ctor(Definux.Emeraude.MobileSdk.ServiceAgents.Http.IRequestHeaderHelper)')
  - [CreateClientAsync()](#M-Definux-Emeraude-MobileSdk-ServiceAgents-Http-HttpClientFactory-CreateClientAsync-Definux-Emeraude-MobileSdk-ServiceAgents-Settings-HostSettings- 'Definux.Emeraude.MobileSdk.ServiceAgents.Http.HttpClientFactory.CreateClientAsync(Definux.Emeraude.MobileSdk.ServiceAgents.Settings.HostSettings)')
- [IAuthenticationServiceAgent](#T-Definux-Emeraude-MobileSdk-ServiceAgents-IAuthenticationServiceAgent 'Definux.Emeraude.MobileSdk.ServiceAgents.IAuthenticationServiceAgent')
  - [RequestTokenAsync(loginRequest)](#M-Definux-Emeraude-MobileSdk-ServiceAgents-IAuthenticationServiceAgent-RequestTokenAsync-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-LoginRequest- 'Definux.Emeraude.MobileSdk.ServiceAgents.IAuthenticationServiceAgent.RequestTokenAsync(Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests.LoginRequest)')
  - [RequestTokenWithExternalProviderAsync(externalLoginRequest)](#M-Definux-Emeraude-MobileSdk-ServiceAgents-IAuthenticationServiceAgent-RequestTokenWithExternalProviderAsync-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-ExternalLoginRequest- 'Definux.Emeraude.MobileSdk.ServiceAgents.IAuthenticationServiceAgent.RequestTokenWithExternalProviderAsync(Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests.ExternalLoginRequest)')
- [IAuthenticationStore](#T-Definux-Emeraude-MobileSdk-Stores-IAuthenticationStore 'Definux.Emeraude.MobileSdk.Stores.IAuthenticationStore')
  - [IsAuthenticated](#P-Definux-Emeraude-MobileSdk-Stores-IAuthenticationStore-IsAuthenticated 'Definux.Emeraude.MobileSdk.Stores.IAuthenticationStore.IsAuthenticated')
  - [RequestTokenAsync(loginRequest)](#M-Definux-Emeraude-MobileSdk-Stores-IAuthenticationStore-RequestTokenAsync-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-LoginRequest- 'Definux.Emeraude.MobileSdk.Stores.IAuthenticationStore.RequestTokenAsync(Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests.LoginRequest)')
  - [RequestTokenWithExternalProviderAsync(externalLoginRequest)](#M-Definux-Emeraude-MobileSdk-Stores-IAuthenticationStore-RequestTokenWithExternalProviderAsync-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-ExternalLoginRequest- 'Definux.Emeraude.MobileSdk.Stores.IAuthenticationStore.RequestTokenWithExternalProviderAsync(Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests.ExternalLoginRequest)')
- [IEmConfiguration](#T-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration 'Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration')
  - [FacebookAppId](#P-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration-FacebookAppId 'Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration.FacebookAppId')
  - [FacebookRedirectUrl](#P-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration-FacebookRedirectUrl 'Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration.FacebookRedirectUrl')
  - [GoogleClientId](#P-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration-GoogleClientId 'Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration.GoogleClientId')
  - [GoogleRedirectUrl](#P-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration-GoogleRedirectUrl 'Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration.GoogleRedirectUrl')
  - [Headers](#P-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration-Headers 'Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration.Headers')
  - [RootBaseUrl](#P-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration-RootBaseUrl 'Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration.RootBaseUrl')
  - [GetValueBasedOnDevicePlatform(androidValue,iOSValue)](#M-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration-GetValueBasedOnDevicePlatform-System-String,System-String- 'Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration.GetValueBasedOnDevicePlatform(System.String,System.String)')
  - [ToHostSettings()](#M-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration-ToHostSettings 'Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration.ToHostSettings')
- [IHttpClientFactory](#T-Definux-Emeraude-MobileSdk-ServiceAgents-Http-IHttpClientFactory 'Definux.Emeraude.MobileSdk.ServiceAgents.Http.IHttpClientFactory')
  - [CreateClientAsync(settings)](#M-Definux-Emeraude-MobileSdk-ServiceAgents-Http-IHttpClientFactory-CreateClientAsync-Definux-Emeraude-MobileSdk-ServiceAgents-Settings-HostSettings- 'Definux.Emeraude.MobileSdk.ServiceAgents.Http.IHttpClientFactory.CreateClientAsync(Definux.Emeraude.MobileSdk.ServiceAgents.Settings.HostSettings)')
- [ILoggingServiceAgent](#T-Definux-Emeraude-MobileSdk-ServiceAgents-ILoggingServiceAgent 'Definux.Emeraude.MobileSdk.ServiceAgents.ILoggingServiceAgent')
- [IRequestHeaderHelper](#T-Definux-Emeraude-MobileSdk-ServiceAgents-Http-IRequestHeaderHelper 'Definux.Emeraude.MobileSdk.ServiceAgents.Http.IRequestHeaderHelper')
  - [InitializeHeadersAsync(client,settings)](#M-Definux-Emeraude-MobileSdk-ServiceAgents-Http-IRequestHeaderHelper-InitializeHeadersAsync-System-Net-Http-HttpClient,Definux-Emeraude-MobileSdk-ServiceAgents-Settings-HostSettings- 'Definux.Emeraude.MobileSdk.ServiceAgents.Http.IRequestHeaderHelper.InitializeHeadersAsync(System.Net.Http.HttpClient,Definux.Emeraude.MobileSdk.ServiceAgents.Settings.HostSettings)')
- [ISettingsProvider](#T-Definux-Emeraude-MobileSdk-Settings-ISettingsProvider 'Definux.Emeraude.MobileSdk.Settings.ISettingsProvider')
  - [Languages](#P-Definux-Emeraude-MobileSdk-Settings-ISettingsProvider-Languages 'Definux.Emeraude.MobileSdk.Settings.ISettingsProvider.Languages')
  - [AddLanguage(code,name,nativeName,isDefault)](#M-Definux-Emeraude-MobileSdk-Settings-ISettingsProvider-AddLanguage-System-String,System-String,System-String,System-Boolean- 'Definux.Emeraude.MobileSdk.Settings.ISettingsProvider.AddLanguage(System.String,System.String,System.String,System.Boolean)')
- [ISystemSettingsStore](#T-Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore 'Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore')
  - [Languages](#P-Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore-Languages 'Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore.Languages')
  - [SelectedLanguage](#P-Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore-SelectedLanguage 'Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore.SelectedLanguage')
  - [ApplyCurrentLanguage()](#M-Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore-ApplyCurrentLanguage 'Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore.ApplyCurrentLanguage')
  - [SelectLanguage(language)](#M-Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore-SelectLanguage-Definux-Emeraude-MobileSdk-Settings-ApplicationLanguage- 'Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore.SelectLanguage(Definux.Emeraude.MobileSdk.Settings.ApplicationLanguage)')
- [LanguageChangedEventArgs](#T-Definux-Emeraude-MobileSdk-Events-LanguageChangedEventArgs 'Definux.Emeraude.MobileSdk.Events.LanguageChangedEventArgs')
  - [#ctor(languageCode)](#M-Definux-Emeraude-MobileSdk-Events-LanguageChangedEventArgs-#ctor-System-String- 'Definux.Emeraude.MobileSdk.Events.LanguageChangedEventArgs.#ctor(System.String)')
  - [LanguageCode](#P-Definux-Emeraude-MobileSdk-Events-LanguageChangedEventArgs-LanguageCode 'Definux.Emeraude.MobileSdk.Events.LanguageChangedEventArgs.LanguageCode')
- [Localizer](#T-Definux-Emeraude-MobileSdk-Services-Localizer 'Definux.Emeraude.MobileSdk.Services.Localizer')
  - [#ctor(resourceManager,systemSettingsStore)](#M-Definux-Emeraude-MobileSdk-Services-Localizer-#ctor-System-Resources-ResourceManager,Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore- 'Definux.Emeraude.MobileSdk.Services.Localizer.#ctor(System.Resources.ResourceManager,Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore)')
  - [Item](#P-Definux-Emeraude-MobileSdk-Services-Localizer-Item-System-String- 'Definux.Emeraude.MobileSdk.Services.Localizer.Item(System.String)')
  - [GetStaticContent()](#M-Definux-Emeraude-MobileSdk-Services-Localizer-GetStaticContent-System-String- 'Definux.Emeraude.MobileSdk.Services.Localizer.GetStaticContent(System.String)')
  - [GetStaticContentAsync()](#M-Definux-Emeraude-MobileSdk-Services-Localizer-GetStaticContentAsync-System-String- 'Definux.Emeraude.MobileSdk.Services.Localizer.GetStaticContentAsync(System.String)')
  - [TranslateKey()](#M-Definux-Emeraude-MobileSdk-Services-Localizer-TranslateKey-System-String- 'Definux.Emeraude.MobileSdk.Services.Localizer.TranslateKey(System.String)')
  - [TranslateKeyAsync()](#M-Definux-Emeraude-MobileSdk-Services-Localizer-TranslateKeyAsync-System-String- 'Definux.Emeraude.MobileSdk.Services.Localizer.TranslateKeyAsync(System.String)')
- [LocalizerViewModel](#T-Definux-Emeraude-MobileSdk-ViewModels-LocalizerViewModel 'Definux.Emeraude.MobileSdk.ViewModels.LocalizerViewModel')
  - [#ctor(navigationService,systemSettingsStore,localizer)](#M-Definux-Emeraude-MobileSdk-ViewModels-LocalizerViewModel-#ctor-Prism-Navigation-INavigationService,Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore,Definux-Emeraude-Interfaces-Services-ILocalizer- 'Definux.Emeraude.MobileSdk.ViewModels.LocalizerViewModel.#ctor(Prism.Navigation.INavigationService,Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore,Definux.Emeraude.Interfaces.Services.ILocalizer)')
- [LoggingServiceAgent](#T-Definux-Emeraude-MobileSdk-ServiceAgents-LoggingServiceAgent 'Definux.Emeraude.MobileSdk.ServiceAgents.LoggingServiceAgent')
  - [#ctor(configuration,clientFactory)](#M-Definux-Emeraude-MobileSdk-ServiceAgents-LoggingServiceAgent-#ctor-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration,Definux-Emeraude-MobileSdk-ServiceAgents-Http-IHttpClientFactory- 'Definux.Emeraude.MobileSdk.ServiceAgents.LoggingServiceAgent.#ctor(Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration,Definux.Emeraude.MobileSdk.ServiceAgents.Http.IHttpClientFactory)')
- [LoginCompletedEventArgs](#T-Definux-Emeraude-MobileSdk-Events-LoginCompletedEventArgs 'Definux.Emeraude.MobileSdk.Events.LoginCompletedEventArgs')
  - [#ctor(succeeded)](#M-Definux-Emeraude-MobileSdk-Events-LoginCompletedEventArgs-#ctor-System-Boolean- 'Definux.Emeraude.MobileSdk.Events.LoginCompletedEventArgs.#ctor(System.Boolean)')
  - [Succeeded](#P-Definux-Emeraude-MobileSdk-Events-LoginCompletedEventArgs-Succeeded 'Definux.Emeraude.MobileSdk.Events.LoginCompletedEventArgs.Succeeded')
- [LoginFormModel](#T-Definux-Emeraude-MobileSdk-FormModels-LoginFormModel 'Definux.Emeraude.MobileSdk.FormModels.LoginFormModel')
  - [#ctor()](#M-Definux-Emeraude-MobileSdk-FormModels-LoginFormModel-#ctor 'Definux.Emeraude.MobileSdk.FormModels.LoginFormModel.#ctor')
  - [Email](#P-Definux-Emeraude-MobileSdk-FormModels-LoginFormModel-Email 'Definux.Emeraude.MobileSdk.FormModels.LoginFormModel.Email')
  - [Password](#P-Definux-Emeraude-MobileSdk-FormModels-LoginFormModel-Password 'Definux.Emeraude.MobileSdk.FormModels.LoginFormModel.Password')
  - [IsValid()](#M-Definux-Emeraude-MobileSdk-FormModels-LoginFormModel-IsValid 'Definux.Emeraude.MobileSdk.FormModels.LoginFormModel.IsValid')
- [LoginRequest](#T-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-LoginRequest 'Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests.LoginRequest')
  - [Email](#P-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-LoginRequest-Email 'Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests.LoginRequest.Email')
  - [Password](#P-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-LoginRequest-Password 'Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests.LoginRequest.Password')
- [LoginViewModel](#T-Definux-Emeraude-MobileSdk-ViewModels-LoginViewModel 'Definux.Emeraude.MobileSdk.ViewModels.LoginViewModel')
  - [#ctor(navigationService,systemSettingsStore,authenticationStore,localizer)](#M-Definux-Emeraude-MobileSdk-ViewModels-LoginViewModel-#ctor-Prism-Navigation-INavigationService,Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore,Definux-Emeraude-MobileSdk-Stores-IAuthenticationStore,Definux-Emeraude-Interfaces-Services-ILocalizer- 'Definux.Emeraude.MobileSdk.ViewModels.LoginViewModel.#ctor(Prism.Navigation.INavigationService,Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore,Definux.Emeraude.MobileSdk.Stores.IAuthenticationStore,Definux.Emeraude.Interfaces.Services.ILocalizer)')
  - [AuthenticationStore](#P-Definux-Emeraude-MobileSdk-ViewModels-LoginViewModel-AuthenticationStore 'Definux.Emeraude.MobileSdk.ViewModels.LoginViewModel.AuthenticationStore')
  - [GoToForgotPasswordPageCommand](#P-Definux-Emeraude-MobileSdk-ViewModels-LoginViewModel-GoToForgotPasswordPageCommand 'Definux.Emeraude.MobileSdk.ViewModels.LoginViewModel.GoToForgotPasswordPageCommand')
  - [GoToRegisterPageCommand](#P-Definux-Emeraude-MobileSdk-ViewModels-LoginViewModel-GoToRegisterPageCommand 'Definux.Emeraude.MobileSdk.ViewModels.LoginViewModel.GoToRegisterPageCommand')
  - [LoginModel](#P-Definux-Emeraude-MobileSdk-ViewModels-LoginViewModel-LoginModel 'Definux.Emeraude.MobileSdk.ViewModels.LoginViewModel.LoginModel')
  - [SubmitLoginCommand](#P-Definux-Emeraude-MobileSdk-ViewModels-LoginViewModel-SubmitLoginCommand 'Definux.Emeraude.MobileSdk.ViewModels.LoginViewModel.SubmitLoginCommand')
- [OAuth2AuthenticatorHelper](#T-Definux-Emeraude-MobileSdk-OAuth-OAuth2AuthenticatorHelper 'Definux.Emeraude.MobileSdk.OAuth.OAuth2AuthenticatorHelper')
  - [AuthenticationState](#P-Definux-Emeraude-MobileSdk-OAuth-OAuth2AuthenticatorHelper-AuthenticationState 'Definux.Emeraude.MobileSdk.OAuth.OAuth2AuthenticatorHelper.AuthenticationState')
  - [CreateFacebookOAuth2Authenticator(configuration)](#M-Definux-Emeraude-MobileSdk-OAuth-OAuth2AuthenticatorHelper-CreateFacebookOAuth2Authenticator-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration- 'Definux.Emeraude.MobileSdk.OAuth.OAuth2AuthenticatorHelper.CreateFacebookOAuth2Authenticator(Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration)')
  - [CreateGoogleOAuth2Authenticator(configuration)](#M-Definux-Emeraude-MobileSdk-OAuth-OAuth2AuthenticatorHelper-CreateGoogleOAuth2Authenticator-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration- 'Definux.Emeraude.MobileSdk.OAuth.OAuth2AuthenticatorHelper.CreateGoogleOAuth2Authenticator(Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration)')
- [OAuth2Constants](#T-Definux-Emeraude-MobileSdk-Constants-OAuth2Constants 'Definux.Emeraude.MobileSdk.Constants.OAuth2Constants')
  - [FacebookOAuth2DataHost](#F-Definux-Emeraude-MobileSdk-Constants-OAuth2Constants-FacebookOAuth2DataHost 'Definux.Emeraude.MobileSdk.Constants.OAuth2Constants.FacebookOAuth2DataHost')
  - [FacebookOAuth2DataPath](#F-Definux-Emeraude-MobileSdk-Constants-OAuth2Constants-FacebookOAuth2DataPath 'Definux.Emeraude.MobileSdk.Constants.OAuth2Constants.FacebookOAuth2DataPath')
  - [FacebookOAuth2InterceptorName](#F-Definux-Emeraude-MobileSdk-Constants-OAuth2Constants-FacebookOAuth2InterceptorName 'Definux.Emeraude.MobileSdk.Constants.OAuth2Constants.FacebookOAuth2InterceptorName')
  - [GoogleOAuth2DataPath](#F-Definux-Emeraude-MobileSdk-Constants-OAuth2Constants-GoogleOAuth2DataPath 'Definux.Emeraude.MobileSdk.Constants.OAuth2Constants.GoogleOAuth2DataPath')
  - [GoogleOAuth2InterceptorName](#F-Definux-Emeraude-MobileSdk-Constants-OAuth2Constants-GoogleOAuth2InterceptorName 'Definux.Emeraude.MobileSdk.Constants.OAuth2Constants.GoogleOAuth2InterceptorName')
- [OAuth2ProviderType](#T-Definux-Emeraude-MobileSdk-OAuth-OAuth2ProviderType 'Definux.Emeraude.MobileSdk.OAuth.OAuth2ProviderType')
  - [Facebook](#F-Definux-Emeraude-MobileSdk-OAuth-OAuth2ProviderType-Facebook 'Definux.Emeraude.MobileSdk.OAuth.OAuth2ProviderType.Facebook')
  - [Google](#F-Definux-Emeraude-MobileSdk-OAuth-OAuth2ProviderType-Google 'Definux.Emeraude.MobileSdk.OAuth.OAuth2ProviderType.Google')
- [OAuth2TokenResult](#T-Definux-Emeraude-MobileSdk-OAuth-OAuth2TokenResult 'Definux.Emeraude.MobileSdk.OAuth.OAuth2TokenResult')
  - [AccessToken](#P-Definux-Emeraude-MobileSdk-OAuth-OAuth2TokenResult-AccessToken 'Definux.Emeraude.MobileSdk.OAuth.OAuth2TokenResult.AccessToken')
  - [DataAccessExpirationTime](#P-Definux-Emeraude-MobileSdk-OAuth-OAuth2TokenResult-DataAccessExpirationTime 'Definux.Emeraude.MobileSdk.OAuth.OAuth2TokenResult.DataAccessExpirationTime')
  - [ExpiresIn](#P-Definux-Emeraude-MobileSdk-OAuth-OAuth2TokenResult-ExpiresIn 'Definux.Emeraude.MobileSdk.OAuth.OAuth2TokenResult.ExpiresIn')
  - [IdToken](#P-Definux-Emeraude-MobileSdk-OAuth-OAuth2TokenResult-IdToken 'Definux.Emeraude.MobileSdk.OAuth.OAuth2TokenResult.IdToken')
  - [ReauthorizeRequiredIn](#P-Definux-Emeraude-MobileSdk-OAuth-OAuth2TokenResult-ReauthorizeRequiredIn 'Definux.Emeraude.MobileSdk.OAuth.OAuth2TokenResult.ReauthorizeRequiredIn')
  - [RefreshToken](#P-Definux-Emeraude-MobileSdk-OAuth-OAuth2TokenResult-RefreshToken 'Definux.Emeraude.MobileSdk.OAuth.OAuth2TokenResult.RefreshToken')
  - [Scope](#P-Definux-Emeraude-MobileSdk-OAuth-OAuth2TokenResult-Scope 'Definux.Emeraude.MobileSdk.OAuth.OAuth2TokenResult.Scope')
  - [State](#P-Definux-Emeraude-MobileSdk-OAuth-OAuth2TokenResult-State 'Definux.Emeraude.MobileSdk.OAuth.OAuth2TokenResult.State')
  - [TokenType](#P-Definux-Emeraude-MobileSdk-OAuth-OAuth2TokenResult-TokenType 'Definux.Emeraude.MobileSdk.OAuth.OAuth2TokenResult.TokenType')
- [RegisterFormModel](#T-Definux-Emeraude-MobileSdk-FormModels-RegisterFormModel 'Definux.Emeraude.MobileSdk.FormModels.RegisterFormModel')
  - [#ctor()](#M-Definux-Emeraude-MobileSdk-FormModels-RegisterFormModel-#ctor 'Definux.Emeraude.MobileSdk.FormModels.RegisterFormModel.#ctor')
  - [ConfirmedPassword](#P-Definux-Emeraude-MobileSdk-FormModels-RegisterFormModel-ConfirmedPassword 'Definux.Emeraude.MobileSdk.FormModels.RegisterFormModel.ConfirmedPassword')
  - [Email](#P-Definux-Emeraude-MobileSdk-FormModels-RegisterFormModel-Email 'Definux.Emeraude.MobileSdk.FormModels.RegisterFormModel.Email')
  - [FullName](#P-Definux-Emeraude-MobileSdk-FormModels-RegisterFormModel-FullName 'Definux.Emeraude.MobileSdk.FormModels.RegisterFormModel.FullName')
  - [Password](#P-Definux-Emeraude-MobileSdk-FormModels-RegisterFormModel-Password 'Definux.Emeraude.MobileSdk.FormModels.RegisterFormModel.Password')
  - [IsValid()](#M-Definux-Emeraude-MobileSdk-FormModels-RegisterFormModel-IsValid 'Definux.Emeraude.MobileSdk.FormModels.RegisterFormModel.IsValid')
- [RegisterViewModel](#T-Definux-Emeraude-MobileSdk-ViewModels-RegisterViewModel 'Definux.Emeraude.MobileSdk.ViewModels.RegisterViewModel')
  - [#ctor(navigationService,systemSettingsStore,authenticationStore,localizer)](#M-Definux-Emeraude-MobileSdk-ViewModels-RegisterViewModel-#ctor-Prism-Navigation-INavigationService,Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore,Definux-Emeraude-MobileSdk-Stores-IAuthenticationStore,Definux-Emeraude-Interfaces-Services-ILocalizer- 'Definux.Emeraude.MobileSdk.ViewModels.RegisterViewModel.#ctor(Prism.Navigation.INavigationService,Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore,Definux.Emeraude.MobileSdk.Stores.IAuthenticationStore,Definux.Emeraude.Interfaces.Services.ILocalizer)')
  - [AuthenticationStore](#P-Definux-Emeraude-MobileSdk-ViewModels-RegisterViewModel-AuthenticationStore 'Definux.Emeraude.MobileSdk.ViewModels.RegisterViewModel.AuthenticationStore')
  - [GoToLoginPageCommand](#P-Definux-Emeraude-MobileSdk-ViewModels-RegisterViewModel-GoToLoginPageCommand 'Definux.Emeraude.MobileSdk.ViewModels.RegisterViewModel.GoToLoginPageCommand')
  - [RegisterModel](#P-Definux-Emeraude-MobileSdk-ViewModels-RegisterViewModel-RegisterModel 'Definux.Emeraude.MobileSdk.ViewModels.RegisterViewModel.RegisterModel')
  - [SubmitRegistrationCommand](#P-Definux-Emeraude-MobileSdk-ViewModels-RegisterViewModel-SubmitRegistrationCommand 'Definux.Emeraude.MobileSdk.ViewModels.RegisterViewModel.SubmitRegistrationCommand')
- [RequestHeaderHelper](#T-Definux-Emeraude-MobileSdk-ServiceAgents-Http-RequestHeaderHelper 'Definux.Emeraude.MobileSdk.ServiceAgents.Http.RequestHeaderHelper')
  - [#ctor(systemSettingsStore,configuration)](#M-Definux-Emeraude-MobileSdk-ServiceAgents-Http-RequestHeaderHelper-#ctor-Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore,Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration- 'Definux.Emeraude.MobileSdk.ServiceAgents.Http.RequestHeaderHelper.#ctor(Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore,Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration)')
  - [InitializeHeadersAsync()](#M-Definux-Emeraude-MobileSdk-ServiceAgents-Http-RequestHeaderHelper-InitializeHeadersAsync-System-Net-Http-HttpClient,Definux-Emeraude-MobileSdk-ServiceAgents-Settings-HostSettings- 'Definux.Emeraude.MobileSdk.ServiceAgents.Http.RequestHeaderHelper.InitializeHeadersAsync(System.Net.Http.HttpClient,Definux.Emeraude.MobileSdk.ServiceAgents.Settings.HostSettings)')
- [ServiceAgent](#T-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgent 'Definux.Emeraude.MobileSdk.ServiceAgents.ServiceAgent')
  - [#ctor(configuration,clientFactory)](#M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgent-#ctor-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration,Definux-Emeraude-MobileSdk-ServiceAgents-Http-IHttpClientFactory- 'Definux.Emeraude.MobileSdk.ServiceAgents.ServiceAgent.#ctor(Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration,Definux.Emeraude.MobileSdk.ServiceAgents.Http.IHttpClientFactory)')
  - [DeleteWithoutResultAsync(requestUri)](#M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgent-DeleteWithoutResultAsync-System-String- 'Definux.Emeraude.MobileSdk.ServiceAgents.ServiceAgent.DeleteWithoutResultAsync(System.String)')
  - [GetAsync\`\`1(requestUri)](#M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgent-GetAsync``1-System-String- 'Definux.Emeraude.MobileSdk.ServiceAgents.ServiceAgent.GetAsync``1(System.String)')
  - [ParseJsonErrorAsync(response)](#M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgent-ParseJsonErrorAsync-System-Net-Http-HttpResponseMessage- 'Definux.Emeraude.MobileSdk.ServiceAgents.ServiceAgent.ParseJsonErrorAsync(System.Net.Http.HttpResponseMessage)')
  - [ParseResult\`\`1(response)](#M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgent-ParseResult``1-System-Net-Http-HttpResponseMessage- 'Definux.Emeraude.MobileSdk.ServiceAgents.ServiceAgent.ParseResult``1(System.Net.Http.HttpResponseMessage)')
  - [PostAsync\`\`1(requestUri,data)](#M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgent-PostAsync``1-System-String,``0- 'Definux.Emeraude.MobileSdk.ServiceAgents.ServiceAgent.PostAsync``1(System.String,``0)')
  - [PostAsync\`\`2(requestUri,data)](#M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgent-PostAsync``2-System-String,``0- 'Definux.Emeraude.MobileSdk.ServiceAgents.ServiceAgent.PostAsync``2(System.String,``0)')
  - [PostWithoutResultAsync(requestUri)](#M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgent-PostWithoutResultAsync-System-String- 'Definux.Emeraude.MobileSdk.ServiceAgents.ServiceAgent.PostWithoutResultAsync(System.String)')
  - [PutAsync\`\`1(requestUri,data)](#M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgent-PutAsync``1-System-String,``0- 'Definux.Emeraude.MobileSdk.ServiceAgents.ServiceAgent.PutAsync``1(System.String,``0)')
  - [PutAsync\`\`2(requestUri,data)](#M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgent-PutAsync``2-System-String,``0- 'Definux.Emeraude.MobileSdk.ServiceAgents.ServiceAgent.PutAsync``2(System.String,``0)')
  - [PutWithoutResultAsync(requestUri)](#M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgent-PutWithoutResultAsync-System-String- 'Definux.Emeraude.MobileSdk.ServiceAgents.ServiceAgent.PutWithoutResultAsync(System.String)')
  - [PutWithoutResultAsync\`\`1(requestUri,data)](#M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgent-PutWithoutResultAsync``1-System-String,``0- 'Definux.Emeraude.MobileSdk.ServiceAgents.ServiceAgent.PutWithoutResultAsync``1(System.String,``0)')
- [ServiceAgentRequestError](#T-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgentRequestError 'Definux.Emeraude.MobileSdk.ServiceAgents.ServiceAgentRequestError')
  - [#ctor()](#M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgentRequestError-#ctor 'Definux.Emeraude.MobileSdk.ServiceAgents.ServiceAgentRequestError.#ctor')
  - [#ctor(extraParameters)](#M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgentRequestError-#ctor-System-Collections-Generic-Dictionary{System-String,System-Collections-Generic-IEnumerable{System-String}}- 'Definux.Emeraude.MobileSdk.ServiceAgents.ServiceAgentRequestError.#ctor(System.Collections.Generic.Dictionary{System.String,System.Collections.Generic.IEnumerable{System.String}})')
  - [#ctor(identifier,extraParameters)](#M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgentRequestError-#ctor-System-Guid,System-Collections-Generic-Dictionary{System-String,System-Collections-Generic-IEnumerable{System-String}}- 'Definux.Emeraude.MobileSdk.ServiceAgents.ServiceAgentRequestError.#ctor(System.Guid,System.Collections.Generic.Dictionary{System.String,System.Collections.Generic.IEnumerable{System.String}})')
  - [Code](#P-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgentRequestError-Code 'Definux.Emeraude.MobileSdk.ServiceAgents.ServiceAgentRequestError.Code')
  - [ExtraParameters](#P-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgentRequestError-ExtraParameters 'Definux.Emeraude.MobileSdk.ServiceAgents.ServiceAgentRequestError.ExtraParameters')
  - [Identifier](#P-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgentRequestError-Identifier 'Definux.Emeraude.MobileSdk.ServiceAgents.ServiceAgentRequestError.Identifier')
  - [Status](#P-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgentRequestError-Status 'Definux.Emeraude.MobileSdk.ServiceAgents.ServiceAgentRequestError.Status')
  - [Title](#P-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgentRequestError-Title 'Definux.Emeraude.MobileSdk.ServiceAgents.ServiceAgentRequestError.Title')
  - [Type](#P-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgentRequestError-Type 'Definux.Emeraude.MobileSdk.ServiceAgents.ServiceAgentRequestError.Type')
- [Store](#T-Definux-Emeraude-MobileSdk-Stores-Store 'Definux.Emeraude.MobileSdk.Stores.Store')
  - [#ctor(loggingServiceAgent)](#M-Definux-Emeraude-MobileSdk-Stores-Store-#ctor-Definux-Emeraude-MobileSdk-ServiceAgents-ILoggingServiceAgent- 'Definux.Emeraude.MobileSdk.Stores.Store.#ctor(Definux.Emeraude.MobileSdk.ServiceAgents.ILoggingServiceAgent)')
- [SystemSettingsStore](#T-Definux-Emeraude-MobileSdk-Stores-SystemSettingsStore 'Definux.Emeraude.MobileSdk.Stores.SystemSettingsStore')
  - [#ctor(settingsProvider)](#M-Definux-Emeraude-MobileSdk-Stores-SystemSettingsStore-#ctor-Definux-Emeraude-MobileSdk-Settings-ISettingsProvider- 'Definux.Emeraude.MobileSdk.Stores.SystemSettingsStore.#ctor(Definux.Emeraude.MobileSdk.Settings.ISettingsProvider)')
  - [Languages](#P-Definux-Emeraude-MobileSdk-Stores-SystemSettingsStore-Languages 'Definux.Emeraude.MobileSdk.Stores.SystemSettingsStore.Languages')
  - [SelectedLanguage](#P-Definux-Emeraude-MobileSdk-Stores-SystemSettingsStore-SelectedLanguage 'Definux.Emeraude.MobileSdk.Stores.SystemSettingsStore.SelectedLanguage')
  - [ApplyCurrentLanguage()](#M-Definux-Emeraude-MobileSdk-Stores-SystemSettingsStore-ApplyCurrentLanguage 'Definux.Emeraude.MobileSdk.Stores.SystemSettingsStore.ApplyCurrentLanguage')
  - [SelectLanguage()](#M-Definux-Emeraude-MobileSdk-Stores-SystemSettingsStore-SelectLanguage-Definux-Emeraude-MobileSdk-Settings-ApplicationLanguage- 'Definux.Emeraude.MobileSdk.Stores.SystemSettingsStore.SelectLanguage(Definux.Emeraude.MobileSdk.Settings.ApplicationLanguage)')
- [Tokens](#T-Definux-Emeraude-MobileSdk-Constants-Tokens 'Definux.Emeraude.MobileSdk.Constants.Tokens')
  - [AccessTokenString](#F-Definux-Emeraude-MobileSdk-Constants-Tokens-AccessTokenString 'Definux.Emeraude.MobileSdk.Constants.Tokens.AccessTokenString')
  - [RefreshTokenString](#F-Definux-Emeraude-MobileSdk-Constants-Tokens-RefreshTokenString 'Definux.Emeraude.MobileSdk.Constants.Tokens.RefreshTokenString')
- [Validators](#T-Definux-Emeraude-MobileSdk-Helpers-Validators 'Definux.Emeraude.MobileSdk.Helpers.Validators')
  - [IsValidEmail(email,errorMessage)](#M-Definux-Emeraude-MobileSdk-Helpers-Validators-IsValidEmail-System-String,System-String@- 'Definux.Emeraude.MobileSdk.Helpers.Validators.IsValidEmail(System.String,System.String@)')
  - [IsValidPassword(password,errorMessage,minLength)](#M-Definux-Emeraude-MobileSdk-Helpers-Validators-IsValidPassword-System-String,System-String@,System-Int32- 'Definux.Emeraude.MobileSdk.Helpers.Validators.IsValidPassword(System.String,System.String@,System.Int32)')
- [ViewModelBase](#T-Definux-Emeraude-MobileSdk-ViewModels-ViewModelBase 'Definux.Emeraude.MobileSdk.ViewModels.ViewModelBase')
  - [#ctor(navigationService,systemSettingsStore,localizer)](#M-Definux-Emeraude-MobileSdk-ViewModels-ViewModelBase-#ctor-Prism-Navigation-INavigationService,Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore,Definux-Emeraude-Interfaces-Services-ILocalizer- 'Definux.Emeraude.MobileSdk.ViewModels.ViewModelBase.#ctor(Prism.Navigation.INavigationService,Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore,Definux.Emeraude.Interfaces.Services.ILocalizer)')
  - [Localizer](#P-Definux-Emeraude-MobileSdk-ViewModels-ViewModelBase-Localizer 'Definux.Emeraude.MobileSdk.ViewModels.ViewModelBase.Localizer')
  - [NavigationService](#P-Definux-Emeraude-MobileSdk-ViewModels-ViewModelBase-NavigationService 'Definux.Emeraude.MobileSdk.ViewModels.ViewModelBase.NavigationService')
  - [SystemSettingsStore](#P-Definux-Emeraude-MobileSdk-ViewModels-ViewModelBase-SystemSettingsStore 'Definux.Emeraude.MobileSdk.ViewModels.ViewModelBase.SystemSettingsStore')
  - [Destroy()](#M-Definux-Emeraude-MobileSdk-ViewModels-ViewModelBase-Destroy 'Definux.Emeraude.MobileSdk.ViewModels.ViewModelBase.Destroy')
  - [DisplayAlert(title,message,cancel)](#M-Definux-Emeraude-MobileSdk-ViewModels-ViewModelBase-DisplayAlert-System-String,System-String,System-String- 'Definux.Emeraude.MobileSdk.ViewModels.ViewModelBase.DisplayAlert(System.String,System.String,System.String)')
  - [GetTranslation(key)](#M-Definux-Emeraude-MobileSdk-ViewModels-ViewModelBase-GetTranslation-System-String- 'Definux.Emeraude.MobileSdk.ViewModels.ViewModelBase.GetTranslation(System.String)')
  - [Initialize(parameters)](#M-Definux-Emeraude-MobileSdk-ViewModels-ViewModelBase-Initialize-Prism-Navigation-INavigationParameters- 'Definux.Emeraude.MobileSdk.ViewModels.ViewModelBase.Initialize(Prism.Navigation.INavigationParameters)')
  - [OnLanguageChanged(sender,e)](#M-Definux-Emeraude-MobileSdk-ViewModels-ViewModelBase-OnLanguageChanged-System-Object,Definux-Emeraude-MobileSdk-Events-LanguageChangedEventArgs- 'Definux.Emeraude.MobileSdk.ViewModels.ViewModelBase.OnLanguageChanged(System.Object,Definux.Emeraude.MobileSdk.Events.LanguageChangedEventArgs)')
  - [OnNavigatedFrom(parameters)](#M-Definux-Emeraude-MobileSdk-ViewModels-ViewModelBase-OnNavigatedFrom-Prism-Navigation-INavigationParameters- 'Definux.Emeraude.MobileSdk.ViewModels.ViewModelBase.OnNavigatedFrom(Prism.Navigation.INavigationParameters)')
  - [OnNavigatedTo(parameters)](#M-Definux-Emeraude-MobileSdk-ViewModels-ViewModelBase-OnNavigatedTo-Prism-Navigation-INavigationParameters- 'Definux.Emeraude.MobileSdk.ViewModels.ViewModelBase.OnNavigatedTo(Prism.Navigation.INavigationParameters)')

<a name='T-Definux-Emeraude-MobileSdk-ViewModels-AccountViewModel'></a>
## AccountViewModel `type`

##### Namespace

Definux.Emeraude.MobileSdk.ViewModels

##### Summary

An abstract ViewModel that defines the binding model for a page that contains access to login, register and external login actions.

<a name='M-Definux-Emeraude-MobileSdk-ViewModels-AccountViewModel-#ctor-Prism-Navigation-INavigationService,Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore,Definux-Emeraude-Interfaces-Services-ILocalizer,Definux-Emeraude-MobileSdk-Stores-IAuthenticationStore,Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration-'></a>
### #ctor(navigationService,systemSettingsStore,localizer,authenticationStore,configuration) `constructor`

##### Summary

Initializes a new instance of the [AccountViewModel](#T-Definux-Emeraude-MobileSdk-ViewModels-AccountViewModel 'Definux.Emeraude.MobileSdk.ViewModels.AccountViewModel') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| navigationService | [Prism.Navigation.INavigationService](#T-Prism-Navigation-INavigationService 'Prism.Navigation.INavigationService') |  |
| systemSettingsStore | [Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore](#T-Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore 'Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore') |  |
| localizer | [Definux.Emeraude.Interfaces.Services.ILocalizer](#T-Definux-Emeraude-Interfaces-Services-ILocalizer 'Definux.Emeraude.Interfaces.Services.ILocalizer') |  |
| authenticationStore | [Definux.Emeraude.MobileSdk.Stores.IAuthenticationStore](#T-Definux-Emeraude-MobileSdk-Stores-IAuthenticationStore 'Definux.Emeraude.MobileSdk.Stores.IAuthenticationStore') |  |
| configuration | [Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration](#T-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration 'Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration') |  |

<a name='P-Definux-Emeraude-MobileSdk-ViewModels-AccountViewModel-AuthenticationStore'></a>
### AuthenticationStore `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-MobileSdk-ViewModels-AccountViewModel-Configuration'></a>
### Configuration `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-MobileSdk-ViewModels-AccountViewModel-GoToLoginPageCommand'></a>
### GoToLoginPageCommand `property`

##### Summary

Command that redirect to login page.

<a name='P-Definux-Emeraude-MobileSdk-ViewModels-AccountViewModel-GoToRegisterPageCommand'></a>
### GoToRegisterPageCommand `property`

##### Summary

Command that redirect to register page.

<a name='P-Definux-Emeraude-MobileSdk-ViewModels-AccountViewModel-LoginWithFacebookCommand'></a>
### LoginWithFacebookCommand `property`

##### Summary

Command that login with Facebook.

<a name='P-Definux-Emeraude-MobileSdk-ViewModels-AccountViewModel-LoginWithGoogleCommand'></a>
### LoginWithGoogleCommand `property`

##### Summary

Command that login with Google.

<a name='P-Definux-Emeraude-MobileSdk-ViewModels-AccountViewModel-OAuth2Authenticator'></a>
### OAuth2Authenticator `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-MobileSdk-ViewModels-AccountViewModel-OAuth2AuthenticatorType'></a>
### OAuth2AuthenticatorType `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-MobileSdk-ViewModels-AccountViewModel-OAuthLoginPresenter'></a>
### OAuthLoginPresenter `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-MobileSdk-Settings-ApplicationLanguage'></a>
## ApplicationLanguage `type`

##### Namespace

Definux.Emeraude.MobileSdk.Settings

##### Summary

Mobile implementation of language domain entity.

<a name='P-Definux-Emeraude-MobileSdk-Settings-ApplicationLanguage-Code'></a>
### Code `property`

##### Summary

Short code of the language.

<a name='P-Definux-Emeraude-MobileSdk-Settings-ApplicationLanguage-IsDefault'></a>
### IsDefault `property`

##### Summary

Flag that indicates whether the language is default for the system.

<a name='P-Definux-Emeraude-MobileSdk-Settings-ApplicationLanguage-Name'></a>
### Name `property`

##### Summary

Name of the language.

<a name='P-Definux-Emeraude-MobileSdk-Settings-ApplicationLanguage-NativeName'></a>
### NativeName `property`

##### Summary

Native name of the language.

<a name='M-Definux-Emeraude-MobileSdk-Settings-ApplicationLanguage-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-MobileSdk-ServiceAgents-AuthenticationServiceAgent'></a>
## AuthenticationServiceAgent `type`

##### Namespace

Definux.Emeraude.MobileSdk.ServiceAgents

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-MobileSdk-ServiceAgents-AuthenticationServiceAgent-#ctor-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration,Definux-Emeraude-MobileSdk-ServiceAgents-Http-IHttpClientFactory-'></a>
### #ctor(configuration,clientFactory) `constructor`

##### Summary

Initializes a new instance of the [AuthenticationServiceAgent](#T-Definux-Emeraude-MobileSdk-ServiceAgents-AuthenticationServiceAgent 'Definux.Emeraude.MobileSdk.ServiceAgents.AuthenticationServiceAgent') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration](#T-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration 'Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration') |  |
| clientFactory | [Definux.Emeraude.MobileSdk.ServiceAgents.Http.IHttpClientFactory](#T-Definux-Emeraude-MobileSdk-ServiceAgents-Http-IHttpClientFactory 'Definux.Emeraude.MobileSdk.ServiceAgents.Http.IHttpClientFactory') |  |

<a name='M-Definux-Emeraude-MobileSdk-ServiceAgents-AuthenticationServiceAgent-RequestTokenAsync-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-LoginRequest-'></a>
### RequestTokenAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-MobileSdk-ServiceAgents-AuthenticationServiceAgent-RequestTokenWithExternalProviderAsync-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-ExternalLoginRequest-'></a>
### RequestTokenWithExternalProviderAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-MobileSdk-Stores-AuthenticationStore'></a>
## AuthenticationStore `type`

##### Namespace

Definux.Emeraude.MobileSdk.Stores

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-MobileSdk-Stores-AuthenticationStore-#ctor-Definux-Emeraude-MobileSdk-ServiceAgents-IAuthenticationServiceAgent,Definux-Emeraude-MobileSdk-ServiceAgents-ILoggingServiceAgent,Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration-'></a>
### #ctor(authenticationServiceAgent,loggingServiceAgent,configuration) `constructor`

##### Summary

Initializes a new instance of the [AuthenticationStore](#T-Definux-Emeraude-MobileSdk-Stores-AuthenticationStore 'Definux.Emeraude.MobileSdk.Stores.AuthenticationStore') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| authenticationServiceAgent | [Definux.Emeraude.MobileSdk.ServiceAgents.IAuthenticationServiceAgent](#T-Definux-Emeraude-MobileSdk-ServiceAgents-IAuthenticationServiceAgent 'Definux.Emeraude.MobileSdk.ServiceAgents.IAuthenticationServiceAgent') |  |
| loggingServiceAgent | [Definux.Emeraude.MobileSdk.ServiceAgents.ILoggingServiceAgent](#T-Definux-Emeraude-MobileSdk-ServiceAgents-ILoggingServiceAgent 'Definux.Emeraude.MobileSdk.ServiceAgents.ILoggingServiceAgent') |  |
| configuration | [Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration](#T-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration 'Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration') |  |

<a name='P-Definux-Emeraude-MobileSdk-Stores-AuthenticationStore-IsAuthenticated'></a>
### IsAuthenticated `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-MobileSdk-Stores-AuthenticationStore-RequestTokenAsync-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-LoginRequest-'></a>
### RequestTokenAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-MobileSdk-Stores-AuthenticationStore-RequestTokenWithExternalProviderAsync-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-ExternalLoginRequest-'></a>
### RequestTokenWithExternalProviderAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Results-BearerAuthenticationResult'></a>
## BearerAuthenticationResult `type`

##### Namespace

Definux.Emeraude.MobileSdk.ServiceAgents.Models.Results

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Results-BearerAuthenticationResult-JsonWebToken'></a>
### JsonWebToken `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Results-BearerAuthenticationResult-Message'></a>
### Message `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Results-BearerAuthenticationResult-RefreshToken'></a>
### RefreshToken `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Results-BearerAuthenticationResult-Success'></a>
### Success `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-MobileSdk-Extensions-ContainerRegistryExtensions'></a>
## ContainerRegistryExtensions `type`

##### Namespace

Definux.Emeraude.MobileSdk.Extensions

##### Summary

Extensions for [IContainerRegistry](#T-Prism-Ioc-IContainerRegistry 'Prism.Ioc.IContainerRegistry').

<a name='M-Definux-Emeraude-MobileSdk-Extensions-ContainerRegistryExtensions-RegisterEmeraudeCore-Prism-Ioc-IContainerRegistry,System-Action{Definux-Emeraude-MobileSdk-Settings-EmeraudeMobileSettings}-'></a>
### RegisterEmeraudeCore(containerRegistry,settingsAction) `method`

##### Summary

Register all required services of Emeraude Mobile SDK.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| containerRegistry | [Prism.Ioc.IContainerRegistry](#T-Prism-Ioc-IContainerRegistry 'Prism.Ioc.IContainerRegistry') |  |
| settingsAction | [System.Action{Definux.Emeraude.MobileSdk.Settings.EmeraudeMobileSettings}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Definux.Emeraude.MobileSdk.Settings.EmeraudeMobileSettings}') |  |

<a name='M-Definux-Emeraude-MobileSdk-Extensions-ContainerRegistryExtensions-RegisterEmeraudeLocalizer-Prism-Ioc-IContainerRegistry,System-Resources-ResourceManager,Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore-'></a>
### RegisterEmeraudeLocalizer(containerRegistry,resourceManager,systemSettingsStore) `method`

##### Summary

Register default Emeraude localizer service.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| containerRegistry | [Prism.Ioc.IContainerRegistry](#T-Prism-Ioc-IContainerRegistry 'Prism.Ioc.IContainerRegistry') |  |
| resourceManager | [System.Resources.ResourceManager](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Resources.ResourceManager 'System.Resources.ResourceManager') |  |
| systemSettingsStore | [Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore](#T-Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore 'Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore') |  |

<a name='T-Definux-Emeraude-MobileSdk-Configuration-EmConfiguration'></a>
## EmConfiguration `type`

##### Namespace

Definux.Emeraude.MobileSdk.Configuration

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-MobileSdk-Configuration-EmConfiguration-#ctor-System-String-'></a>
### #ctor(rootBaseUrl) `constructor`

##### Summary

Initializes a new instance of the [EmConfiguration](#T-Definux-Emeraude-MobileSdk-Configuration-EmConfiguration 'Definux.Emeraude.MobileSdk.Configuration.EmConfiguration') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootBaseUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-MobileSdk-Configuration-EmConfiguration-#ctor-System-String,System-String,System-Boolean-'></a>
### #ctor(hostMachineIp,addressPort,useHttps) `constructor`

##### Summary

Initializes a new instance of the [EmConfiguration](#T-Definux-Emeraude-MobileSdk-Configuration-EmConfiguration 'Definux.Emeraude.MobileSdk.Configuration.EmConfiguration') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hostMachineIp | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| addressPort | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| useHttps | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='P-Definux-Emeraude-MobileSdk-Configuration-EmConfiguration-FacebookAppId'></a>
### FacebookAppId `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-MobileSdk-Configuration-EmConfiguration-FacebookRedirectUrl'></a>
### FacebookRedirectUrl `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-MobileSdk-Configuration-EmConfiguration-GoogleClientId'></a>
### GoogleClientId `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-MobileSdk-Configuration-EmConfiguration-GoogleRedirectUrl'></a>
### GoogleRedirectUrl `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-MobileSdk-Configuration-EmConfiguration-Headers'></a>
### Headers `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-MobileSdk-Configuration-EmConfiguration-RootBaseUrl'></a>
### RootBaseUrl `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-MobileSdk-Configuration-EmConfiguration-GetValueBasedOnDevicePlatform-System-String,System-String-'></a>
### GetValueBasedOnDevicePlatform() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-MobileSdk-Configuration-EmConfiguration-ToHostSettings'></a>
### ToHostSettings() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-MobileSdk-Services-EmStaticServiceProvider'></a>
## EmStaticServiceProvider `type`

##### Namespace

Definux.Emeraude.MobileSdk.Services

##### Summary

Emeraude static service used for resolve a service from the services container.

<a name='M-Definux-Emeraude-MobileSdk-Services-EmStaticServiceProvider-GetService``1'></a>
### GetService\`\`1() `method`

##### Summary

Get a service from services container.

##### Returns



##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the service. |

<a name='T-Definux-Emeraude-MobileSdk-Settings-EmeraudeMobileSettings'></a>
## EmeraudeMobileSettings `type`

##### Namespace

Definux.Emeraude.MobileSdk.Settings

##### Summary

Implementation of [ISettingsProvider](#T-Definux-Emeraude-MobileSdk-Settings-ISettingsProvider 'Definux.Emeraude.MobileSdk.Settings.ISettingsProvider').

<a name='M-Definux-Emeraude-MobileSdk-Settings-EmeraudeMobileSettings-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [EmeraudeMobileSettings](#T-Definux-Emeraude-MobileSdk-Settings-EmeraudeMobileSettings 'Definux.Emeraude.MobileSdk.Settings.EmeraudeMobileSettings') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-MobileSdk-Settings-EmeraudeMobileSettings-Languages'></a>
### Languages `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-MobileSdk-Settings-EmeraudeMobileSettings-AddLanguage-System-String,System-String,System-String,System-Boolean-'></a>
### AddLanguage() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-MobileSdk-Converters-ErrorMessageToBoolConverter'></a>
## ErrorMessageToBoolConverter `type`

##### Namespace

Definux.Emeraude.MobileSdk.Converters

##### Summary

Value converter for error message to success flag.

<a name='M-Definux-Emeraude-MobileSdk-Converters-ErrorMessageToBoolConverter-Convert-System-Object,System-Type,System-Object,System-Globalization-CultureInfo-'></a>
### Convert() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-MobileSdk-Converters-ErrorMessageToBoolConverter-ConvertBack-System-Object,System-Type,System-Object,System-Globalization-CultureInfo-'></a>
### ConvertBack() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-ExternalLoginRequest'></a>
## ExternalLoginRequest `type`

##### Namespace

Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-ExternalLoginRequest-AccessToken'></a>
### AccessToken `property`

##### Summary

External login provider access token.

<a name='P-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-ExternalLoginRequest-Provider'></a>
### Provider `property`

##### Summary

External login provider name.

<a name='T-Definux-Emeraude-MobileSdk-FormModels-ForgotPasswordFormModel'></a>
## ForgotPasswordFormModel `type`

##### Namespace

Definux.Emeraude.MobileSdk.FormModels

##### Summary

Form model for forgot password form.

<a name='M-Definux-Emeraude-MobileSdk-FormModels-ForgotPasswordFormModel-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [ForgotPasswordFormModel](#T-Definux-Emeraude-MobileSdk-FormModels-ForgotPasswordFormModel 'Definux.Emeraude.MobileSdk.FormModels.ForgotPasswordFormModel') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-MobileSdk-FormModels-ForgotPasswordFormModel-Email'></a>
### Email `property`

##### Summary

Email of the user.

<a name='M-Definux-Emeraude-MobileSdk-FormModels-ForgotPasswordFormModel-IsValid'></a>
### IsValid() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-MobileSdk-ViewModels-ForgotPasswordViewModel'></a>
## ForgotPasswordViewModel `type`

##### Namespace

Definux.Emeraude.MobileSdk.ViewModels

##### Summary

An abstract ViewModel that defines the binding model for a page that contains forgot password form.

<a name='M-Definux-Emeraude-MobileSdk-ViewModels-ForgotPasswordViewModel-#ctor-Prism-Navigation-INavigationService,Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore,Definux-Emeraude-MobileSdk-Stores-IAuthenticationStore,Definux-Emeraude-Interfaces-Services-ILocalizer-'></a>
### #ctor(navigationService,systemSettingsStore,authenticationStore,localizer) `constructor`

##### Summary

Initializes a new instance of the [ForgotPasswordViewModel](#T-Definux-Emeraude-MobileSdk-ViewModels-ForgotPasswordViewModel 'Definux.Emeraude.MobileSdk.ViewModels.ForgotPasswordViewModel') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| navigationService | [Prism.Navigation.INavigationService](#T-Prism-Navigation-INavigationService 'Prism.Navigation.INavigationService') |  |
| systemSettingsStore | [Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore](#T-Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore 'Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore') |  |
| authenticationStore | [Definux.Emeraude.MobileSdk.Stores.IAuthenticationStore](#T-Definux-Emeraude-MobileSdk-Stores-IAuthenticationStore 'Definux.Emeraude.MobileSdk.Stores.IAuthenticationStore') |  |
| localizer | [Definux.Emeraude.Interfaces.Services.ILocalizer](#T-Definux-Emeraude-Interfaces-Services-ILocalizer 'Definux.Emeraude.Interfaces.Services.ILocalizer') |  |

<a name='P-Definux-Emeraude-MobileSdk-ViewModels-ForgotPasswordViewModel-AuthenticationStore'></a>
### AuthenticationStore `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-MobileSdk-ViewModels-ForgotPasswordViewModel-ForgotPasswordModel'></a>
### ForgotPasswordModel `property`

##### Summary

Binding model for the forgot password form.

<a name='P-Definux-Emeraude-MobileSdk-ViewModels-ForgotPasswordViewModel-SubmitForgotPasswordFormCommand'></a>
### SubmitForgotPasswordFormCommand `property`

##### Summary

Command that submit the forgot password form.

<a name='T-Definux-Emeraude-MobileSdk-FormModels-Abstractions-FormModel'></a>
## FormModel `type`

##### Namespace

Definux.Emeraude.MobileSdk.FormModels.Abstractions

##### Summary

Abstraction for wrapping form with validations in ViewModel.

<a name='M-Definux-Emeraude-MobileSdk-FormModels-Abstractions-FormModel-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [FormModel](#T-Definux-Emeraude-MobileSdk-FormModels-Abstractions-FormModel 'Definux.Emeraude.MobileSdk.FormModels.Abstractions.FormModel') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-MobileSdk-FormModels-Abstractions-FormModel-Errors'></a>
### Errors `property`

##### Summary

Dictionary that contains errors of model.

<a name='P-Definux-Emeraude-MobileSdk-FormModels-Abstractions-FormModel-HasErrors'></a>
### HasErrors `property`

##### Summary

Flag that indicates the existance of model errors.

<a name='M-Definux-Emeraude-MobileSdk-FormModels-Abstractions-FormModel-AddError-System-String,System-String-'></a>
### AddError(propertyName,error) `method`

##### Summary

Add error to model state errors.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| error | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-MobileSdk-FormModels-Abstractions-FormModel-IsValid'></a>
### IsValid() `method`

##### Summary

Method that trigger the model validation.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-MobileSdk-FormModels-Abstractions-FormModelError'></a>
## FormModelError `type`

##### Namespace

Definux.Emeraude.MobileSdk.FormModels.Abstractions

##### Summary

Error definition class for form model.

<a name='P-Definux-Emeraude-MobileSdk-FormModels-Abstractions-FormModelError-Error'></a>
### Error `property`

##### Summary

Error text.

<a name='P-Definux-Emeraude-MobileSdk-FormModels-Abstractions-FormModelError-Key'></a>
### Key `property`

##### Summary

Key of the error - the name of the property or the error is general - use empty string.

<a name='T-Definux-Emeraude-MobileSdk-ServiceAgents-Settings-HostSettings'></a>
## HostSettings `type`

##### Namespace

Definux.Emeraude.MobileSdk.ServiceAgents.Settings

##### Summary

Service agent host settings.

<a name='P-Definux-Emeraude-MobileSdk-ServiceAgents-Settings-HostSettings-Headers'></a>
### Headers `property`

##### Summary

Dictionary with all headers which must be applied with any request to the web API.

<a name='P-Definux-Emeraude-MobileSdk-ServiceAgents-Settings-HostSettings-Url'></a>
### Url `property`

##### Summary

Base URL of the web API.

<a name='T-Definux-Emeraude-MobileSdk-ServiceAgents-Http-HttpClientFactory'></a>
## HttpClientFactory `type`

##### Namespace

Definux.Emeraude.MobileSdk.ServiceAgents.Http

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-MobileSdk-ServiceAgents-Http-HttpClientFactory-#ctor-Definux-Emeraude-MobileSdk-ServiceAgents-Http-IRequestHeaderHelper-'></a>
### #ctor(requestHeaderHelper) `constructor`

##### Summary

Initializes a new instance of the [HttpClientFactory](#T-Definux-Emeraude-MobileSdk-ServiceAgents-Http-HttpClientFactory 'Definux.Emeraude.MobileSdk.ServiceAgents.Http.HttpClientFactory') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| requestHeaderHelper | [Definux.Emeraude.MobileSdk.ServiceAgents.Http.IRequestHeaderHelper](#T-Definux-Emeraude-MobileSdk-ServiceAgents-Http-IRequestHeaderHelper 'Definux.Emeraude.MobileSdk.ServiceAgents.Http.IRequestHeaderHelper') |  |

<a name='M-Definux-Emeraude-MobileSdk-ServiceAgents-Http-HttpClientFactory-CreateClientAsync-Definux-Emeraude-MobileSdk-ServiceAgents-Settings-HostSettings-'></a>
### CreateClientAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-MobileSdk-ServiceAgents-IAuthenticationServiceAgent'></a>
## IAuthenticationServiceAgent `type`

##### Namespace

Definux.Emeraude.MobileSdk.ServiceAgents

##### Summary

Service agent that provides access to the authentication API.

<a name='M-Definux-Emeraude-MobileSdk-ServiceAgents-IAuthenticationServiceAgent-RequestTokenAsync-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-LoginRequest-'></a>
### RequestTokenAsync(loginRequest) `method`

##### Summary

Request access token via ordinary login request with email and password.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| loginRequest | [Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests.LoginRequest](#T-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-LoginRequest 'Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests.LoginRequest') |  |

<a name='M-Definux-Emeraude-MobileSdk-ServiceAgents-IAuthenticationServiceAgent-RequestTokenWithExternalProviderAsync-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-ExternalLoginRequest-'></a>
### RequestTokenWithExternalProviderAsync(externalLoginRequest) `method`

##### Summary

Request access token via external provider token.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| externalLoginRequest | [Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests.ExternalLoginRequest](#T-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-ExternalLoginRequest 'Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests.ExternalLoginRequest') |  |

<a name='T-Definux-Emeraude-MobileSdk-Stores-IAuthenticationStore'></a>
## IAuthenticationStore `type`

##### Namespace

Definux.Emeraude.MobileSdk.Stores

##### Summary

Store that provides functionality for managing the authentication of the application.

<a name='P-Definux-Emeraude-MobileSdk-Stores-IAuthenticationStore-IsAuthenticated'></a>
### IsAuthenticated `property`

##### Summary

Flag that indicate whether the user is authenticated or not.

<a name='M-Definux-Emeraude-MobileSdk-Stores-IAuthenticationStore-RequestTokenAsync-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-LoginRequest-'></a>
### RequestTokenAsync(loginRequest) `method`

##### Summary

Request access token via ordinary login request with email and password by accessing the [IAuthenticationServiceAgent](#T-Definux-Emeraude-MobileSdk-ServiceAgents-IAuthenticationServiceAgent 'Definux.Emeraude.MobileSdk.ServiceAgents.IAuthenticationServiceAgent').

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| loginRequest | [Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests.LoginRequest](#T-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-LoginRequest 'Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests.LoginRequest') |  |

<a name='M-Definux-Emeraude-MobileSdk-Stores-IAuthenticationStore-RequestTokenWithExternalProviderAsync-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-ExternalLoginRequest-'></a>
### RequestTokenWithExternalProviderAsync(externalLoginRequest) `method`

##### Summary

Request access token via external provider token by accessing the [IAuthenticationServiceAgent](#T-Definux-Emeraude-MobileSdk-ServiceAgents-IAuthenticationServiceAgent 'Definux.Emeraude.MobileSdk.ServiceAgents.IAuthenticationServiceAgent').

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| externalLoginRequest | [Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests.ExternalLoginRequest](#T-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-ExternalLoginRequest 'Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests.ExternalLoginRequest') |  |

<a name='T-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration'></a>
## IEmConfiguration `type`

##### Namespace

Definux.Emeraude.MobileSdk.Configuration

##### Summary

Emeraude mobile SDK configuration definition.

<a name='P-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration-FacebookAppId'></a>
### FacebookAppId `property`

##### Summary

AppId for Facebook OAuth2 external authentication.

<a name='P-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration-FacebookRedirectUrl'></a>
### FacebookRedirectUrl `property`

##### Summary

Redirect URL for Facebook OAuth2 external authentication.

<a name='P-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration-GoogleClientId'></a>
### GoogleClientId `property`

##### Summary

ClientId for Google OAuth2 external authentication.

<a name='P-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration-GoogleRedirectUrl'></a>
### GoogleRedirectUrl `property`

##### Summary

Redirect URL for Google OAuth2 external authentication.

<a name='P-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration-Headers'></a>
### Headers `property`

##### Summary

Headers which will be send on each request.

<a name='P-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration-RootBaseUrl'></a>
### RootBaseUrl `property`

##### Summary

Web API base URL.

<a name='M-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration-GetValueBasedOnDevicePlatform-System-String,System-String-'></a>
### GetValueBasedOnDevicePlatform(androidValue,iOSValue) `method`

##### Summary

Get value based on the current platform.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| androidValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| iOSValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration-ToHostSettings'></a>
### ToHostSettings() `method`

##### Summary

Method that converts the configuration into host settings.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-MobileSdk-ServiceAgents-Http-IHttpClientFactory'></a>
## IHttpClientFactory `type`

##### Namespace

Definux.Emeraude.MobileSdk.ServiceAgents.Http

##### Summary

Factory for creating HTTP client with all application settings.

<a name='M-Definux-Emeraude-MobileSdk-ServiceAgents-Http-IHttpClientFactory-CreateClientAsync-Definux-Emeraude-MobileSdk-ServiceAgents-Settings-HostSettings-'></a>
### CreateClientAsync(settings) `method`

##### Summary

Creates a HTTP client configured with connected web API.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| settings | [Definux.Emeraude.MobileSdk.ServiceAgents.Settings.HostSettings](#T-Definux-Emeraude-MobileSdk-ServiceAgents-Settings-HostSettings 'Definux.Emeraude.MobileSdk.ServiceAgents.Settings.HostSettings') |  |

<a name='T-Definux-Emeraude-MobileSdk-ServiceAgents-ILoggingServiceAgent'></a>
## ILoggingServiceAgent `type`

##### Namespace

Definux.Emeraude.MobileSdk.ServiceAgents

##### Summary

Service agent that provides access to the logger API.

<a name='T-Definux-Emeraude-MobileSdk-ServiceAgents-Http-IRequestHeaderHelper'></a>
## IRequestHeaderHelper `type`

##### Namespace

Definux.Emeraude.MobileSdk.ServiceAgents.Http

##### Summary

Request header helper that modify HTTP client.

<a name='M-Definux-Emeraude-MobileSdk-ServiceAgents-Http-IRequestHeaderHelper-InitializeHeadersAsync-System-Net-Http-HttpClient,Definux-Emeraude-MobileSdk-ServiceAgents-Settings-HostSettings-'></a>
### InitializeHeadersAsync(client,settings) `method`

##### Summary

Apply specified [HostSettings](#T-Definux-Emeraude-MobileSdk-ServiceAgents-Settings-HostSettings 'Definux.Emeraude.MobileSdk.ServiceAgents.Settings.HostSettings') into .

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| client | [System.Net.Http.HttpClient](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpClient 'System.Net.Http.HttpClient') |  |
| settings | [Definux.Emeraude.MobileSdk.ServiceAgents.Settings.HostSettings](#T-Definux-Emeraude-MobileSdk-ServiceAgents-Settings-HostSettings 'Definux.Emeraude.MobileSdk.ServiceAgents.Settings.HostSettings') |  |

<a name='T-Definux-Emeraude-MobileSdk-Settings-ISettingsProvider'></a>
## ISettingsProvider `type`

##### Namespace

Definux.Emeraude.MobileSdk.Settings

##### Summary

Definition of settings provider for the Emeraude Mobile SDK.

<a name='P-Definux-Emeraude-MobileSdk-Settings-ISettingsProvider-Languages'></a>
### Languages `property`

##### Summary

List of all languages loaded in the application.

<a name='M-Definux-Emeraude-MobileSdk-Settings-ISettingsProvider-AddLanguage-System-String,System-String,System-String,System-Boolean-'></a>
### AddLanguage(code,name,nativeName,isDefault) `method`

##### Summary

Method that add language to the collection of all languages.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| code | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| nativeName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| isDefault | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore'></a>
## ISystemSettingsStore `type`

##### Namespace

Definux.Emeraude.MobileSdk.Stores

##### Summary

Store used for managing the built-in settings of the application.

<a name='P-Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore-Languages'></a>
### Languages `property`

##### Summary

List of all registered languages.

<a name='P-Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore-SelectedLanguage'></a>
### SelectedLanguage `property`

##### Summary

Currently selected language of the application.

<a name='M-Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore-ApplyCurrentLanguage'></a>
### ApplyCurrentLanguage() `method`

##### Summary

Load previously selected language from the settubgs.

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore-SelectLanguage-Definux-Emeraude-MobileSdk-Settings-ApplicationLanguage-'></a>
### SelectLanguage(language) `method`

##### Summary

Set the specified language as selected one.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| language | [Definux.Emeraude.MobileSdk.Settings.ApplicationLanguage](#T-Definux-Emeraude-MobileSdk-Settings-ApplicationLanguage 'Definux.Emeraude.MobileSdk.Settings.ApplicationLanguage') |  |

<a name='T-Definux-Emeraude-MobileSdk-Events-LanguageChangedEventArgs'></a>
## LanguageChangedEventArgs `type`

##### Namespace

Definux.Emeraude.MobileSdk.Events

##### Summary

Event args implementation for language change event.

<a name='M-Definux-Emeraude-MobileSdk-Events-LanguageChangedEventArgs-#ctor-System-String-'></a>
### #ctor(languageCode) `constructor`

##### Summary

Initializes a new instance of the [LanguageChangedEventArgs](#T-Definux-Emeraude-MobileSdk-Events-LanguageChangedEventArgs 'Definux.Emeraude.MobileSdk.Events.LanguageChangedEventArgs') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| languageCode | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='P-Definux-Emeraude-MobileSdk-Events-LanguageChangedEventArgs-LanguageCode'></a>
### LanguageCode `property`

##### Summary

Short code of the langauge.

<a name='T-Definux-Emeraude-MobileSdk-Services-Localizer'></a>
## Localizer `type`

##### Namespace

Definux.Emeraude.MobileSdk.Services

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-MobileSdk-Services-Localizer-#ctor-System-Resources-ResourceManager,Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore-'></a>
### #ctor(resourceManager,systemSettingsStore) `constructor`

##### Summary

Initializes a new instance of the [Localizer](#T-Definux-Emeraude-MobileSdk-Services-Localizer 'Definux.Emeraude.MobileSdk.Services.Localizer') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resourceManager | [System.Resources.ResourceManager](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Resources.ResourceManager 'System.Resources.ResourceManager') |  |
| systemSettingsStore | [Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore](#T-Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore 'Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore') |  |

<a name='P-Definux-Emeraude-MobileSdk-Services-Localizer-Item-System-String-'></a>
### Item `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-MobileSdk-Services-Localizer-GetStaticContent-System-String-'></a>
### GetStaticContent() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-MobileSdk-Services-Localizer-GetStaticContentAsync-System-String-'></a>
### GetStaticContentAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-MobileSdk-Services-Localizer-TranslateKey-System-String-'></a>
### TranslateKey() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-MobileSdk-Services-Localizer-TranslateKeyAsync-System-String-'></a>
### TranslateKeyAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-MobileSdk-ViewModels-LocalizerViewModel'></a>
## LocalizerViewModel `type`

##### Namespace

Definux.Emeraude.MobileSdk.ViewModels

##### Summary

ViewModel used for the language switcher.

<a name='M-Definux-Emeraude-MobileSdk-ViewModels-LocalizerViewModel-#ctor-Prism-Navigation-INavigationService,Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore,Definux-Emeraude-Interfaces-Services-ILocalizer-'></a>
### #ctor(navigationService,systemSettingsStore,localizer) `constructor`

##### Summary

Initializes a new instance of the [LocalizerViewModel](#T-Definux-Emeraude-MobileSdk-ViewModels-LocalizerViewModel 'Definux.Emeraude.MobileSdk.ViewModels.LocalizerViewModel') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| navigationService | [Prism.Navigation.INavigationService](#T-Prism-Navigation-INavigationService 'Prism.Navigation.INavigationService') |  |
| systemSettingsStore | [Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore](#T-Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore 'Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore') |  |
| localizer | [Definux.Emeraude.Interfaces.Services.ILocalizer](#T-Definux-Emeraude-Interfaces-Services-ILocalizer 'Definux.Emeraude.Interfaces.Services.ILocalizer') |  |

<a name='T-Definux-Emeraude-MobileSdk-ServiceAgents-LoggingServiceAgent'></a>
## LoggingServiceAgent `type`

##### Namespace

Definux.Emeraude.MobileSdk.ServiceAgents

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-MobileSdk-ServiceAgents-LoggingServiceAgent-#ctor-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration,Definux-Emeraude-MobileSdk-ServiceAgents-Http-IHttpClientFactory-'></a>
### #ctor(configuration,clientFactory) `constructor`

##### Summary

Initializes a new instance of the [LoggingServiceAgent](#T-Definux-Emeraude-MobileSdk-ServiceAgents-LoggingServiceAgent 'Definux.Emeraude.MobileSdk.ServiceAgents.LoggingServiceAgent') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration](#T-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration 'Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration') |  |
| clientFactory | [Definux.Emeraude.MobileSdk.ServiceAgents.Http.IHttpClientFactory](#T-Definux-Emeraude-MobileSdk-ServiceAgents-Http-IHttpClientFactory 'Definux.Emeraude.MobileSdk.ServiceAgents.Http.IHttpClientFactory') |  |

<a name='T-Definux-Emeraude-MobileSdk-Events-LoginCompletedEventArgs'></a>
## LoginCompletedEventArgs `type`

##### Namespace

Definux.Emeraude.MobileSdk.Events

##### Summary

Event args implementation for login completion event.

<a name='M-Definux-Emeraude-MobileSdk-Events-LoginCompletedEventArgs-#ctor-System-Boolean-'></a>
### #ctor(succeeded) `constructor`

##### Summary

Initializes a new instance of the [LoginCompletedEventArgs](#T-Definux-Emeraude-MobileSdk-Events-LoginCompletedEventArgs 'Definux.Emeraude.MobileSdk.Events.LoginCompletedEventArgs') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| succeeded | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='P-Definux-Emeraude-MobileSdk-Events-LoginCompletedEventArgs-Succeeded'></a>
### Succeeded `property`

##### Summary

Flag that indicates the success status of the login completion.

<a name='T-Definux-Emeraude-MobileSdk-FormModels-LoginFormModel'></a>
## LoginFormModel `type`

##### Namespace

Definux.Emeraude.MobileSdk.FormModels

##### Summary

Form model for login form.

<a name='M-Definux-Emeraude-MobileSdk-FormModels-LoginFormModel-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [LoginFormModel](#T-Definux-Emeraude-MobileSdk-FormModels-LoginFormModel 'Definux.Emeraude.MobileSdk.FormModels.LoginFormModel') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-MobileSdk-FormModels-LoginFormModel-Email'></a>
### Email `property`

##### Summary

Email of the user.

<a name='P-Definux-Emeraude-MobileSdk-FormModels-LoginFormModel-Password'></a>
### Password `property`

##### Summary

User password.

<a name='M-Definux-Emeraude-MobileSdk-FormModels-LoginFormModel-IsValid'></a>
### IsValid() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-LoginRequest'></a>
## LoginRequest `type`

##### Namespace

Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-LoginRequest-Email'></a>
### Email `property`

##### Summary

Request email.

<a name='P-Definux-Emeraude-MobileSdk-ServiceAgents-Models-Requests-LoginRequest-Password'></a>
### Password `property`

##### Summary

Request password.

<a name='T-Definux-Emeraude-MobileSdk-ViewModels-LoginViewModel'></a>
## LoginViewModel `type`

##### Namespace

Definux.Emeraude.MobileSdk.ViewModels

##### Summary

An abstract ViewModel that defines the binding model for a page that contains login form.

<a name='M-Definux-Emeraude-MobileSdk-ViewModels-LoginViewModel-#ctor-Prism-Navigation-INavigationService,Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore,Definux-Emeraude-MobileSdk-Stores-IAuthenticationStore,Definux-Emeraude-Interfaces-Services-ILocalizer-'></a>
### #ctor(navigationService,systemSettingsStore,authenticationStore,localizer) `constructor`

##### Summary

Initializes a new instance of the [LoginViewModel](#T-Definux-Emeraude-MobileSdk-ViewModels-LoginViewModel 'Definux.Emeraude.MobileSdk.ViewModels.LoginViewModel') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| navigationService | [Prism.Navigation.INavigationService](#T-Prism-Navigation-INavigationService 'Prism.Navigation.INavigationService') |  |
| systemSettingsStore | [Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore](#T-Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore 'Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore') |  |
| authenticationStore | [Definux.Emeraude.MobileSdk.Stores.IAuthenticationStore](#T-Definux-Emeraude-MobileSdk-Stores-IAuthenticationStore 'Definux.Emeraude.MobileSdk.Stores.IAuthenticationStore') |  |
| localizer | [Definux.Emeraude.Interfaces.Services.ILocalizer](#T-Definux-Emeraude-Interfaces-Services-ILocalizer 'Definux.Emeraude.Interfaces.Services.ILocalizer') |  |

<a name='P-Definux-Emeraude-MobileSdk-ViewModels-LoginViewModel-AuthenticationStore'></a>
### AuthenticationStore `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-MobileSdk-ViewModels-LoginViewModel-GoToForgotPasswordPageCommand'></a>
### GoToForgotPasswordPageCommand `property`

##### Summary

Command that redirect to forgot password page.

<a name='P-Definux-Emeraude-MobileSdk-ViewModels-LoginViewModel-GoToRegisterPageCommand'></a>
### GoToRegisterPageCommand `property`

##### Summary

Command that redirect to register page.

<a name='P-Definux-Emeraude-MobileSdk-ViewModels-LoginViewModel-LoginModel'></a>
### LoginModel `property`

##### Summary

Binding model for the login form.

<a name='P-Definux-Emeraude-MobileSdk-ViewModels-LoginViewModel-SubmitLoginCommand'></a>
### SubmitLoginCommand `property`

##### Summary

Command that submit the login form.

<a name='T-Definux-Emeraude-MobileSdk-OAuth-OAuth2AuthenticatorHelper'></a>
## OAuth2AuthenticatorHelper `type`

##### Namespace

Definux.Emeraude.MobileSdk.OAuth

##### Summary

Helper that contains predefined OAuth2 authenticators.

<a name='P-Definux-Emeraude-MobileSdk-OAuth-OAuth2AuthenticatorHelper-AuthenticationState'></a>
### AuthenticationState `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-MobileSdk-OAuth-OAuth2AuthenticatorHelper-CreateFacebookOAuth2Authenticator-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration-'></a>
### CreateFacebookOAuth2Authenticator(configuration) `method`

##### Summary

Creates predefined Facebook OAuth2 authenticator.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration](#T-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration 'Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration') |  |

<a name='M-Definux-Emeraude-MobileSdk-OAuth-OAuth2AuthenticatorHelper-CreateGoogleOAuth2Authenticator-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration-'></a>
### CreateGoogleOAuth2Authenticator(configuration) `method`

##### Summary

Creates predefined Google OAuth2 authenticator.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration](#T-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration 'Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration') |  |

<a name='T-Definux-Emeraude-MobileSdk-Constants-OAuth2Constants'></a>
## OAuth2Constants `type`

##### Namespace

Definux.Emeraude.MobileSdk.Constants

##### Summary

OAuth2 constants.

<a name='F-Definux-Emeraude-MobileSdk-Constants-OAuth2Constants-FacebookOAuth2DataHost'></a>
### FacebookOAuth2DataHost `constants`

##### Summary

Facebook OAuth2 data host.

<a name='F-Definux-Emeraude-MobileSdk-Constants-OAuth2Constants-FacebookOAuth2DataPath'></a>
### FacebookOAuth2DataPath `constants`

##### Summary

Facebook OAuth2 data path.

<a name='F-Definux-Emeraude-MobileSdk-Constants-OAuth2Constants-FacebookOAuth2InterceptorName'></a>
### FacebookOAuth2InterceptorName `constants`

##### Summary

Facebook OAuth2 interceptor name.

<a name='F-Definux-Emeraude-MobileSdk-Constants-OAuth2Constants-GoogleOAuth2DataPath'></a>
### GoogleOAuth2DataPath `constants`

##### Summary

Google OAuth2 data path.

<a name='F-Definux-Emeraude-MobileSdk-Constants-OAuth2Constants-GoogleOAuth2InterceptorName'></a>
### GoogleOAuth2InterceptorName `constants`

##### Summary

Google OAuth2 interceptor name.

<a name='T-Definux-Emeraude-MobileSdk-OAuth-OAuth2ProviderType'></a>
## OAuth2ProviderType `type`

##### Namespace

Definux.Emeraude.MobileSdk.OAuth

##### Summary

List of supported OAuth2 providers.

<a name='F-Definux-Emeraude-MobileSdk-OAuth-OAuth2ProviderType-Facebook'></a>
### Facebook `constants`

##### Summary

Facebook.

<a name='F-Definux-Emeraude-MobileSdk-OAuth-OAuth2ProviderType-Google'></a>
### Google `constants`

##### Summary

Google.

<a name='T-Definux-Emeraude-MobileSdk-OAuth-OAuth2TokenResult'></a>
## OAuth2TokenResult `type`

##### Namespace

Definux.Emeraude.MobileSdk.OAuth

##### Summary

OAuth2 result of the access token external authentication request.

<a name='P-Definux-Emeraude-MobileSdk-OAuth-OAuth2TokenResult-AccessToken'></a>
### AccessToken `property`

##### Summary

Access token.

<a name='P-Definux-Emeraude-MobileSdk-OAuth-OAuth2TokenResult-DataAccessExpirationTime'></a>
### DataAccessExpirationTime `property`

##### Summary

Data access expiration time. Applicable for Facebook authorization.

<a name='P-Definux-Emeraude-MobileSdk-OAuth-OAuth2TokenResult-ExpiresIn'></a>
### ExpiresIn `property`

##### Summary

Expiration date.

<a name='P-Definux-Emeraude-MobileSdk-OAuth-OAuth2TokenResult-IdToken'></a>
### IdToken `property`

##### Summary

Identification of the token. Applicable for Google authorization.

<a name='P-Definux-Emeraude-MobileSdk-OAuth-OAuth2TokenResult-ReauthorizeRequiredIn'></a>
### ReauthorizeRequiredIn `property`

##### Summary

Reauthorization time. Applicable for Facebook authorization.

<a name='P-Definux-Emeraude-MobileSdk-OAuth-OAuth2TokenResult-RefreshToken'></a>
### RefreshToken `property`

##### Summary

Refresh token. Applicable for Google authorization.

<a name='P-Definux-Emeraude-MobileSdk-OAuth-OAuth2TokenResult-Scope'></a>
### Scope `property`

##### Summary

Scope of the request. Applicable for Google authorization.

<a name='P-Definux-Emeraude-MobileSdk-OAuth-OAuth2TokenResult-State'></a>
### State `property`

##### Summary

State of the OAuth2 request. Applicable for Facebook authorization.

<a name='P-Definux-Emeraude-MobileSdk-OAuth-OAuth2TokenResult-TokenType'></a>
### TokenType `property`

##### Summary

Type of the token. Applicable for Google authorization.

<a name='T-Definux-Emeraude-MobileSdk-FormModels-RegisterFormModel'></a>
## RegisterFormModel `type`

##### Namespace

Definux.Emeraude.MobileSdk.FormModels

##### Summary

Form model for register form.

<a name='M-Definux-Emeraude-MobileSdk-FormModels-RegisterFormModel-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [RegisterFormModel](#T-Definux-Emeraude-MobileSdk-FormModels-RegisterFormModel 'Definux.Emeraude.MobileSdk.FormModels.RegisterFormModel') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-MobileSdk-FormModels-RegisterFormModel-ConfirmedPassword'></a>
### ConfirmedPassword `property`

##### Summary

Confirmed user password.

<a name='P-Definux-Emeraude-MobileSdk-FormModels-RegisterFormModel-Email'></a>
### Email `property`

##### Summary

Email of the user.

<a name='P-Definux-Emeraude-MobileSdk-FormModels-RegisterFormModel-FullName'></a>
### FullName `property`

##### Summary

Full name of the user.

<a name='P-Definux-Emeraude-MobileSdk-FormModels-RegisterFormModel-Password'></a>
### Password `property`

##### Summary

User password.

<a name='M-Definux-Emeraude-MobileSdk-FormModels-RegisterFormModel-IsValid'></a>
### IsValid() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-MobileSdk-ViewModels-RegisterViewModel'></a>
## RegisterViewModel `type`

##### Namespace

Definux.Emeraude.MobileSdk.ViewModels

##### Summary

An abstract ViewModel that defines the binding model for a page that contains register form.

<a name='M-Definux-Emeraude-MobileSdk-ViewModels-RegisterViewModel-#ctor-Prism-Navigation-INavigationService,Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore,Definux-Emeraude-MobileSdk-Stores-IAuthenticationStore,Definux-Emeraude-Interfaces-Services-ILocalizer-'></a>
### #ctor(navigationService,systemSettingsStore,authenticationStore,localizer) `constructor`

##### Summary

Initializes a new instance of the [RegisterViewModel](#T-Definux-Emeraude-MobileSdk-ViewModels-RegisterViewModel 'Definux.Emeraude.MobileSdk.ViewModels.RegisterViewModel') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| navigationService | [Prism.Navigation.INavigationService](#T-Prism-Navigation-INavigationService 'Prism.Navigation.INavigationService') |  |
| systemSettingsStore | [Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore](#T-Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore 'Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore') |  |
| authenticationStore | [Definux.Emeraude.MobileSdk.Stores.IAuthenticationStore](#T-Definux-Emeraude-MobileSdk-Stores-IAuthenticationStore 'Definux.Emeraude.MobileSdk.Stores.IAuthenticationStore') |  |
| localizer | [Definux.Emeraude.Interfaces.Services.ILocalizer](#T-Definux-Emeraude-Interfaces-Services-ILocalizer 'Definux.Emeraude.Interfaces.Services.ILocalizer') |  |

<a name='P-Definux-Emeraude-MobileSdk-ViewModels-RegisterViewModel-AuthenticationStore'></a>
### AuthenticationStore `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-MobileSdk-ViewModels-RegisterViewModel-GoToLoginPageCommand'></a>
### GoToLoginPageCommand `property`

##### Summary

Command that redirect to login page.

<a name='P-Definux-Emeraude-MobileSdk-ViewModels-RegisterViewModel-RegisterModel'></a>
### RegisterModel `property`

##### Summary

Binding model for the register form.

<a name='P-Definux-Emeraude-MobileSdk-ViewModels-RegisterViewModel-SubmitRegistrationCommand'></a>
### SubmitRegistrationCommand `property`

##### Summary

Command that submit the register form.

<a name='T-Definux-Emeraude-MobileSdk-ServiceAgents-Http-RequestHeaderHelper'></a>
## RequestHeaderHelper `type`

##### Namespace

Definux.Emeraude.MobileSdk.ServiceAgents.Http

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-MobileSdk-ServiceAgents-Http-RequestHeaderHelper-#ctor-Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore,Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration-'></a>
### #ctor(systemSettingsStore,configuration) `constructor`

##### Summary

Initializes a new instance of the [RequestHeaderHelper](#T-Definux-Emeraude-MobileSdk-ServiceAgents-Http-RequestHeaderHelper 'Definux.Emeraude.MobileSdk.ServiceAgents.Http.RequestHeaderHelper') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| systemSettingsStore | [Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore](#T-Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore 'Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore') |  |
| configuration | [Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration](#T-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration 'Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration') |  |

<a name='M-Definux-Emeraude-MobileSdk-ServiceAgents-Http-RequestHeaderHelper-InitializeHeadersAsync-System-Net-Http-HttpClient,Definux-Emeraude-MobileSdk-ServiceAgents-Settings-HostSettings-'></a>
### InitializeHeadersAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgent'></a>
## ServiceAgent `type`

##### Namespace

Definux.Emeraude.MobileSdk.ServiceAgents

##### Summary

Abstract service agent that provides all methods for HTTP request to the web API.

<a name='M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgent-#ctor-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration,Definux-Emeraude-MobileSdk-ServiceAgents-Http-IHttpClientFactory-'></a>
### #ctor(configuration,clientFactory) `constructor`

##### Summary

Initializes a new instance of the [ServiceAgent](#T-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgent 'Definux.Emeraude.MobileSdk.ServiceAgents.ServiceAgent') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration](#T-Definux-Emeraude-MobileSdk-Configuration-IEmConfiguration 'Definux.Emeraude.MobileSdk.Configuration.IEmConfiguration') |  |
| clientFactory | [Definux.Emeraude.MobileSdk.ServiceAgents.Http.IHttpClientFactory](#T-Definux-Emeraude-MobileSdk-ServiceAgents-Http-IHttpClientFactory 'Definux.Emeraude.MobileSdk.ServiceAgents.Http.IHttpClientFactory') |  |

<a name='M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgent-DeleteWithoutResultAsync-System-String-'></a>
### DeleteWithoutResultAsync(requestUri) `method`

##### Summary

Execute DELETE request to specified url to the target web API that returns without a result.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| requestUri | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgent-GetAsync``1-System-String-'></a>
### GetAsync\`\`1(requestUri) `method`

##### Summary

Executes GET request to specified url from the target web API.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| requestUri | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TResponseData | Result model. |

<a name='M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgent-ParseJsonErrorAsync-System-Net-Http-HttpResponseMessage-'></a>
### ParseJsonErrorAsync(response) `method`

##### Summary

Parse the error(in JSON format) from HTTP response.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| response | [System.Net.Http.HttpResponseMessage](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpResponseMessage 'System.Net.Http.HttpResponseMessage') |  |

<a name='M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgent-ParseResult``1-System-Net-Http-HttpResponseMessage-'></a>
### ParseResult\`\`1(response) `method`

##### Summary

Parse the result from the HTTP response.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| response | [System.Net.Http.HttpResponseMessage](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpResponseMessage 'System.Net.Http.HttpResponseMessage') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Result model. |

<a name='M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgent-PostAsync``1-System-String,``0-'></a>
### PostAsync\`\`1(requestUri,data) `method`

##### Summary

Executes POST request to specified url with request model to the target web API that returns.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| requestUri | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| data | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TRequestData | Request and result model. |

<a name='M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgent-PostAsync``2-System-String,``0-'></a>
### PostAsync\`\`2(requestUri,data) `method`

##### Summary

Executes POST request to specified url with request model to the target web API that returns.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| requestUri | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| data | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TRequestData | Request model. |
| TReponseData | Result model. |

<a name='M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgent-PostWithoutResultAsync-System-String-'></a>
### PostWithoutResultAsync(requestUri) `method`

##### Summary

Execute POST request to specified url without a request model to the target web API that returns.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| requestUri | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgent-PutAsync``1-System-String,``0-'></a>
### PutAsync\`\`1(requestUri,data) `method`

##### Summary

Executes PUT request to specified url with request model to the target web API that returns.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| requestUri | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| data | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TRequestData | Request and result model. |

<a name='M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgent-PutAsync``2-System-String,``0-'></a>
### PutAsync\`\`2(requestUri,data) `method`

##### Summary

Executes PUT request to specified url with request model to the target web API that returns.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| requestUri | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| data | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TRequestData | Request model. |
| TReponseData | Result model. |

<a name='M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgent-PutWithoutResultAsync-System-String-'></a>
### PutWithoutResultAsync(requestUri) `method`

##### Summary

Execute PUT request to specified url without a request model to the target web API that returns without a result.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| requestUri | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgent-PutWithoutResultAsync``1-System-String,``0-'></a>
### PutWithoutResultAsync\`\`1(requestUri,data) `method`

##### Summary

Execute PUT request to specified url with a request model to the target web API that returns without a result.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| requestUri | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| data | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TRequestData | Request model. |

<a name='T-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgentRequestError'></a>
## ServiceAgentRequestError `type`

##### Namespace

Definux.Emeraude.MobileSdk.ServiceAgents

##### Summary

Service agent request error implementation used for error encapsulation.

<a name='M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgentRequestError-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [ServiceAgentRequestError](#T-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgentRequestError 'Definux.Emeraude.MobileSdk.ServiceAgents.ServiceAgentRequestError') class.

##### Parameters

This constructor has no parameters.

<a name='M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgentRequestError-#ctor-System-Collections-Generic-Dictionary{System-String,System-Collections-Generic-IEnumerable{System-String}}-'></a>
### #ctor(extraParameters) `constructor`

##### Summary

Initializes a new instance of the [ServiceAgentRequestError](#T-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgentRequestError 'Definux.Emeraude.MobileSdk.ServiceAgents.ServiceAgentRequestError') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extraParameters | [System.Collections.Generic.Dictionary{System.String,System.Collections.Generic.IEnumerable{System.String}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,System.Collections.Generic.IEnumerable{System.String}}') |  |

<a name='M-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgentRequestError-#ctor-System-Guid,System-Collections-Generic-Dictionary{System-String,System-Collections-Generic-IEnumerable{System-String}}-'></a>
### #ctor(identifier,extraParameters) `constructor`

##### Summary

Initializes a new instance of the [ServiceAgentRequestError](#T-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgentRequestError 'Definux.Emeraude.MobileSdk.ServiceAgents.ServiceAgentRequestError') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| identifier | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |
| extraParameters | [System.Collections.Generic.Dictionary{System.String,System.Collections.Generic.IEnumerable{System.String}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,System.Collections.Generic.IEnumerable{System.String}}') |  |

<a name='P-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgentRequestError-Code'></a>
### Code `property`

##### Summary

Code of the error.

<a name='P-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgentRequestError-ExtraParameters'></a>
### ExtraParameters `property`

##### Summary

Extra parameters for more details about the error.

<a name='P-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgentRequestError-Identifier'></a>
### Identifier `property`

##### Summary

Identifier of the error.

<a name='P-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgentRequestError-Status'></a>
### Status `property`

##### Summary

Status code of the error.

<a name='P-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgentRequestError-Title'></a>
### Title `property`

##### Summary

Title of the error.

<a name='P-Definux-Emeraude-MobileSdk-ServiceAgents-ServiceAgentRequestError-Type'></a>
### Type `property`

##### Summary

Url of the error.

<a name='T-Definux-Emeraude-MobileSdk-Stores-Store'></a>
## Store `type`

##### Namespace

Definux.Emeraude.MobileSdk.Stores

##### Summary

Abstract implementation of store for state management.

<a name='M-Definux-Emeraude-MobileSdk-Stores-Store-#ctor-Definux-Emeraude-MobileSdk-ServiceAgents-ILoggingServiceAgent-'></a>
### #ctor(loggingServiceAgent) `constructor`

##### Summary

Initializes a new instance of the [Store](#T-Definux-Emeraude-MobileSdk-Stores-Store 'Definux.Emeraude.MobileSdk.Stores.Store') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| loggingServiceAgent | [Definux.Emeraude.MobileSdk.ServiceAgents.ILoggingServiceAgent](#T-Definux-Emeraude-MobileSdk-ServiceAgents-ILoggingServiceAgent 'Definux.Emeraude.MobileSdk.ServiceAgents.ILoggingServiceAgent') |  |

<a name='T-Definux-Emeraude-MobileSdk-Stores-SystemSettingsStore'></a>
## SystemSettingsStore `type`

##### Namespace

Definux.Emeraude.MobileSdk.Stores

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-MobileSdk-Stores-SystemSettingsStore-#ctor-Definux-Emeraude-MobileSdk-Settings-ISettingsProvider-'></a>
### #ctor(settingsProvider) `constructor`

##### Summary

Initializes a new instance of the [SystemSettingsStore](#T-Definux-Emeraude-MobileSdk-Stores-SystemSettingsStore 'Definux.Emeraude.MobileSdk.Stores.SystemSettingsStore') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| settingsProvider | [Definux.Emeraude.MobileSdk.Settings.ISettingsProvider](#T-Definux-Emeraude-MobileSdk-Settings-ISettingsProvider 'Definux.Emeraude.MobileSdk.Settings.ISettingsProvider') |  |

<a name='P-Definux-Emeraude-MobileSdk-Stores-SystemSettingsStore-Languages'></a>
### Languages `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-MobileSdk-Stores-SystemSettingsStore-SelectedLanguage'></a>
### SelectedLanguage `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-MobileSdk-Stores-SystemSettingsStore-ApplyCurrentLanguage'></a>
### ApplyCurrentLanguage() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-MobileSdk-Stores-SystemSettingsStore-SelectLanguage-Definux-Emeraude-MobileSdk-Settings-ApplicationLanguage-'></a>
### SelectLanguage() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-MobileSdk-Constants-Tokens'></a>
## Tokens `type`

##### Namespace

Definux.Emeraude.MobileSdk.Constants

##### Summary

Available token keys strings.

<a name='F-Definux-Emeraude-MobileSdk-Constants-Tokens-AccessTokenString'></a>
### AccessTokenString `constants`

##### Summary

Access token key string.

<a name='F-Definux-Emeraude-MobileSdk-Constants-Tokens-RefreshTokenString'></a>
### RefreshTokenString `constants`

##### Summary

Refresh token key string.

<a name='T-Definux-Emeraude-MobileSdk-Helpers-Validators'></a>
## Validators `type`

##### Namespace

Definux.Emeraude.MobileSdk.Helpers

##### Summary

Built validators for strings and parameters.

<a name='M-Definux-Emeraude-MobileSdk-Helpers-Validators-IsValidEmail-System-String,System-String@-'></a>
### IsValidEmail(email,errorMessage) `method`

##### Summary

Check validity of email address.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| email | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| errorMessage | [System.String@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String@ 'System.String@') |  |

<a name='M-Definux-Emeraude-MobileSdk-Helpers-Validators-IsValidPassword-System-String,System-String@,System-Int32-'></a>
### IsValidPassword(password,errorMessage,minLength) `method`

##### Summary

Check validity of password based on Emeraude framework requirements.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| errorMessage | [System.String@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String@ 'System.String@') |  |
| minLength | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='T-Definux-Emeraude-MobileSdk-ViewModels-ViewModelBase'></a>
## ViewModelBase `type`

##### Namespace

Definux.Emeraude.MobileSdk.ViewModels

##### Summary

Abstract MVVM ViewModel that contains all needed services and methods.

<a name='M-Definux-Emeraude-MobileSdk-ViewModels-ViewModelBase-#ctor-Prism-Navigation-INavigationService,Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore,Definux-Emeraude-Interfaces-Services-ILocalizer-'></a>
### #ctor(navigationService,systemSettingsStore,localizer) `constructor`

##### Summary

Initializes a new instance of the [ViewModelBase](#T-Definux-Emeraude-MobileSdk-ViewModels-ViewModelBase 'Definux.Emeraude.MobileSdk.ViewModels.ViewModelBase') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| navigationService | [Prism.Navigation.INavigationService](#T-Prism-Navigation-INavigationService 'Prism.Navigation.INavigationService') |  |
| systemSettingsStore | [Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore](#T-Definux-Emeraude-MobileSdk-Stores-ISystemSettingsStore 'Definux.Emeraude.MobileSdk.Stores.ISystemSettingsStore') |  |
| localizer | [Definux.Emeraude.Interfaces.Services.ILocalizer](#T-Definux-Emeraude-Interfaces-Services-ILocalizer 'Definux.Emeraude.Interfaces.Services.ILocalizer') |  |

<a name='P-Definux-Emeraude-MobileSdk-ViewModels-ViewModelBase-Localizer'></a>
### Localizer `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-MobileSdk-ViewModels-ViewModelBase-NavigationService'></a>
### NavigationService `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-MobileSdk-ViewModels-ViewModelBase-SystemSettingsStore'></a>
### SystemSettingsStore `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-MobileSdk-ViewModels-ViewModelBase-Destroy'></a>
### Destroy() `method`

##### Summary

Method triggered on destroy of the view model.

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-MobileSdk-ViewModels-ViewModelBase-DisplayAlert-System-String,System-String,System-String-'></a>
### DisplayAlert(title,message,cancel) `method`

##### Summary

Method that wrap current page display alert.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| title | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| cancel | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-MobileSdk-ViewModels-ViewModelBase-GetTranslation-System-String-'></a>
### GetTranslation(key) `method`

##### Summary

Method that returns translation for specified key.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-MobileSdk-ViewModels-ViewModelBase-Initialize-Prism-Navigation-INavigationParameters-'></a>
### Initialize(parameters) `method`

##### Summary

Method triggered on initialization of the view model.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameters | [Prism.Navigation.INavigationParameters](#T-Prism-Navigation-INavigationParameters 'Prism.Navigation.INavigationParameters') |  |

<a name='M-Definux-Emeraude-MobileSdk-ViewModels-ViewModelBase-OnLanguageChanged-System-Object,Definux-Emeraude-MobileSdk-Events-LanguageChangedEventArgs-'></a>
### OnLanguageChanged(sender,e) `method`

##### Summary

Method triggered when current language is changed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [Definux.Emeraude.MobileSdk.Events.LanguageChangedEventArgs](#T-Definux-Emeraude-MobileSdk-Events-LanguageChangedEventArgs 'Definux.Emeraude.MobileSdk.Events.LanguageChangedEventArgs') |  |

<a name='M-Definux-Emeraude-MobileSdk-ViewModels-ViewModelBase-OnNavigatedFrom-Prism-Navigation-INavigationParameters-'></a>
### OnNavigatedFrom(parameters) `method`

##### Summary

Method triggered on navigated from the view model.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameters | [Prism.Navigation.INavigationParameters](#T-Prism-Navigation-INavigationParameters 'Prism.Navigation.INavigationParameters') |  |

<a name='M-Definux-Emeraude-MobileSdk-ViewModels-ViewModelBase-OnNavigatedTo-Prism-Navigation-INavigationParameters-'></a>
### OnNavigatedTo(parameters) `method`

##### Summary

Method triggered on navigated to the view model.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameters | [Prism.Navigation.INavigationParameters](#T-Prism-Navigation-INavigationParameters 'Prism.Navigation.INavigationParameters') |  |
