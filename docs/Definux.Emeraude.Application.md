<a name='assembly'></a>
# Definux.Emeraude.Application

## Contents

- [ActivateTwoFactorAuthenticationCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ActivateTwoFactorAuthentication-ActivateTwoFactorAuthenticationCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ActivateTwoFactorAuthentication.ActivateTwoFactorAuthenticationCommand')
  - [#ctor(code)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ActivateTwoFactorAuthentication-ActivateTwoFactorAuthenticationCommand-#ctor-System-String- 'Definux.Emeraude.Application.Requests.Identity.Commands.ActivateTwoFactorAuthentication.ActivateTwoFactorAuthenticationCommand.#ctor(System.String)')
  - [Code](#P-Definux-Emeraude-Application-Requests-Identity-Commands-ActivateTwoFactorAuthentication-ActivateTwoFactorAuthenticationCommand-Code 'Definux.Emeraude.Application.Requests.Identity.Commands.ActivateTwoFactorAuthentication.ActivateTwoFactorAuthenticationCommand.Code')
- [ActivateTwoFactorAuthenticationCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ActivateTwoFactorAuthentication-ActivateTwoFactorAuthenticationCommand-ActivateTwoFactorAuthenticationCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.ActivateTwoFactorAuthentication.ActivateTwoFactorAuthenticationCommand.ActivateTwoFactorAuthenticationCommandHandler')
  - [#ctor(userManager,currentUserProvider)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ActivateTwoFactorAuthentication-ActivateTwoFactorAuthenticationCommand-ActivateTwoFactorAuthenticationCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-Identity-ICurrentUserProvider- 'Definux.Emeraude.Application.Requests.Identity.Commands.ActivateTwoFactorAuthentication.ActivateTwoFactorAuthenticationCommand.ActivateTwoFactorAuthenticationCommandHandler.#ctor(Definux.Emeraude.Application.Identity.IUserManager,Definux.Emeraude.Application.Identity.ICurrentUserProvider)')
  - [Handle()](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ActivateTwoFactorAuthentication-ActivateTwoFactorAuthenticationCommand-ActivateTwoFactorAuthenticationCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-ActivateTwoFactorAuthentication-ActivateTwoFactorAuthenticationCommand,System-Threading-CancellationToken- 'Definux.Emeraude.Application.Requests.Identity.Commands.ActivateTwoFactorAuthentication.ActivateTwoFactorAuthenticationCommand.ActivateTwoFactorAuthenticationCommandHandler.Handle(Definux.Emeraude.Application.Requests.Identity.Commands.ActivateTwoFactorAuthentication.ActivateTwoFactorAuthenticationCommand,System.Threading.CancellationToken)')
- [ActivateTwoFactorAuthenticationCommandValidator](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ActivateTwoFactorAuthentication-ActivateTwoFactorAuthenticationCommandValidator 'Definux.Emeraude.Application.Requests.Identity.Commands.ActivateTwoFactorAuthentication.ActivateTwoFactorAuthenticationCommandValidator')
  - [#ctor()](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ActivateTwoFactorAuthentication-ActivateTwoFactorAuthenticationCommandValidator-#ctor 'Definux.Emeraude.Application.Requests.Identity.Commands.ActivateTwoFactorAuthentication.ActivateTwoFactorAuthenticationCommandValidator.#ctor')
- [ActivateTwoFactorAuthenticationResult](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ActivateTwoFactorAuthentication-ActivateTwoFactorAuthenticationResult 'Definux.Emeraude.Application.Requests.Identity.Commands.ActivateTwoFactorAuthentication.ActivateTwoFactorAuthenticationResult')
  - [#ctor(success)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ActivateTwoFactorAuthentication-ActivateTwoFactorAuthenticationResult-#ctor-System-Boolean- 'Definux.Emeraude.Application.Requests.Identity.Commands.ActivateTwoFactorAuthentication.ActivateTwoFactorAuthenticationResult.#ctor(System.Boolean)')
- [AssemblyMappingProfile](#T-Definux-Emeraude-Application-Mapping-AssemblyMappingProfile 'Definux.Emeraude.Application.Mapping.AssemblyMappingProfile')
  - [#ctor(assembly)](#M-Definux-Emeraude-Application-Mapping-AssemblyMappingProfile-#ctor-System-Reflection-Assembly- 'Definux.Emeraude.Application.Mapping.AssemblyMappingProfile.#ctor(System.Reflection.Assembly)')
- [BearerAuthenticationResult](#T-Definux-Emeraude-Application-Identity-BearerAuthenticationResult 'Definux.Emeraude.Application.Identity.BearerAuthenticationResult')
  - [FailedResult](#P-Definux-Emeraude-Application-Identity-BearerAuthenticationResult-FailedResult 'Definux.Emeraude.Application.Identity.BearerAuthenticationResult.FailedResult')
  - [JsonWebToken](#P-Definux-Emeraude-Application-Identity-BearerAuthenticationResult-JsonWebToken 'Definux.Emeraude.Application.Identity.BearerAuthenticationResult.JsonWebToken')
  - [Message](#P-Definux-Emeraude-Application-Identity-BearerAuthenticationResult-Message 'Definux.Emeraude.Application.Identity.BearerAuthenticationResult.Message')
  - [RefreshToken](#P-Definux-Emeraude-Application-Identity-BearerAuthenticationResult-RefreshToken 'Definux.Emeraude.Application.Identity.BearerAuthenticationResult.RefreshToken')
  - [Success](#P-Definux-Emeraude-Application-Identity-BearerAuthenticationResult-Success 'Definux.Emeraude.Application.Identity.BearerAuthenticationResult.Success')
  - [SuccessResult(jsonWebToken,refreshToken)](#M-Definux-Emeraude-Application-Identity-BearerAuthenticationResult-SuccessResult-System-String,System-String- 'Definux.Emeraude.Application.Identity.BearerAuthenticationResult.SuccessResult(System.String,System.String)')
- [ChangeEmailCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeEmail-ChangeEmailCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeEmail.ChangeEmailCommand')
  - [#ctor(newEmail,token)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeEmail-ChangeEmailCommand-#ctor-System-String,System-String- 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeEmail.ChangeEmailCommand.#ctor(System.String,System.String)')
  - [NewEmail](#P-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeEmail-ChangeEmailCommand-NewEmail 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeEmail.ChangeEmailCommand.NewEmail')
  - [Token](#P-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeEmail-ChangeEmailCommand-Token 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeEmail.ChangeEmailCommand.Token')
- [ChangeEmailCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeEmail-ChangeEmailCommand-ChangeEmailCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeEmail.ChangeEmailCommand.ChangeEmailCommandHandler')
  - [#ctor(userManager,logger,currentUserProvider)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeEmail-ChangeEmailCommand-ChangeEmailCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-Logger-IEmLogger,Definux-Emeraude-Application-Identity-ICurrentUserProvider- 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeEmail.ChangeEmailCommand.ChangeEmailCommandHandler.#ctor(Definux.Emeraude.Application.Identity.IUserManager,Definux.Emeraude.Application.Logger.IEmLogger,Definux.Emeraude.Application.Identity.ICurrentUserProvider)')
  - [Handle()](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeEmail-ChangeEmailCommand-ChangeEmailCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeEmail-ChangeEmailCommand,System-Threading-CancellationToken- 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeEmail.ChangeEmailCommand.ChangeEmailCommandHandler.Handle(Definux.Emeraude.Application.Requests.Identity.Commands.ChangeEmail.ChangeEmailCommand,System.Threading.CancellationToken)')
- [ChangeEmailCommandValidator](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeEmail-ChangeEmailCommandValidator 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeEmail.ChangeEmailCommandValidator')
  - [#ctor()](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeEmail-ChangeEmailCommandValidator-#ctor 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeEmail.ChangeEmailCommandValidator.#ctor')
- [ChangePasswordCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword.ChangePasswordCommand')
  - [ConfirmedPassword](#P-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommand-ConfirmedPassword 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword.ChangePasswordCommand.ConfirmedPassword')
  - [CurrentPassword](#P-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommand-CurrentPassword 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword.ChangePasswordCommand.CurrentPassword')
  - [NewPassword](#P-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommand-NewPassword 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword.ChangePasswordCommand.NewPassword')
  - [UserId](#P-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommand-UserId 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword.ChangePasswordCommand.UserId')
- [ChangePasswordCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommand-ChangePasswordCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword.ChangePasswordCommand.ChangePasswordCommandHandler')
  - [#ctor(userManager,logger)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommand-ChangePasswordCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-Logger-IEmLogger- 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword.ChangePasswordCommand.ChangePasswordCommandHandler.#ctor(Definux.Emeraude.Application.Identity.IUserManager,Definux.Emeraude.Application.Logger.IEmLogger)')
  - [Handle()](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommand-ChangePasswordCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommand,System-Threading-CancellationToken- 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword.ChangePasswordCommand.ChangePasswordCommandHandler.Handle(Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword.ChangePasswordCommand,System.Threading.CancellationToken)')
- [ChangePasswordCommandValidator](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommandValidator 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword.ChangePasswordCommandValidator')
  - [#ctor()](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommandValidator-#ctor 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword.ChangePasswordCommandValidator.#ctor')
- [ChangePasswordRequestResult](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordRequestResult 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword.ChangePasswordRequestResult')
  - [#ctor(success)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordRequestResult-#ctor-System-Boolean- 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword.ChangePasswordRequestResult.#ctor(System.Boolean)')
- [ChangeUserAvatarCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserAvatar-ChangeUserAvatarCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserAvatar.ChangeUserAvatarCommand')
  - [AvatarFileBase64](#P-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserAvatar-ChangeUserAvatarCommand-AvatarFileBase64 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserAvatar.ChangeUserAvatarCommand.AvatarFileBase64')
  - [UserId](#P-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserAvatar-ChangeUserAvatarCommand-UserId 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserAvatar.ChangeUserAvatarCommand.UserId')
- [ChangeUserAvatarCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserAvatar-ChangeUserAvatarCommand-ChangeUserAvatarCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserAvatar.ChangeUserAvatarCommand.ChangeUserAvatarCommandHandler')
  - [#ctor(userAvatarService,logger)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserAvatar-ChangeUserAvatarCommand-ChangeUserAvatarCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserAvatarService,Definux-Emeraude-Application-Logger-IEmLogger- 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserAvatar.ChangeUserAvatarCommand.ChangeUserAvatarCommandHandler.#ctor(Definux.Emeraude.Application.Identity.IUserAvatarService,Definux.Emeraude.Application.Logger.IEmLogger)')
  - [Handle()](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserAvatar-ChangeUserAvatarCommand-ChangeUserAvatarCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserAvatar-ChangeUserAvatarCommand,System-Threading-CancellationToken- 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserAvatar.ChangeUserAvatarCommand.ChangeUserAvatarCommandHandler.Handle(Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserAvatar.ChangeUserAvatarCommand,System.Threading.CancellationToken)')
- [ChangeUserNameCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserName-ChangeUserNameCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserName.ChangeUserNameCommand')
  - [NewName](#P-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserName-ChangeUserNameCommand-NewName 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserName.ChangeUserNameCommand.NewName')
  - [UserId](#P-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserName-ChangeUserNameCommand-UserId 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserName.ChangeUserNameCommand.UserId')
- [ChangeUserNameCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserName-ChangeUserNameCommand-ChangeUserNameCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserName.ChangeUserNameCommand.ChangeUserNameCommandHandler')
  - [#ctor(userManager,logger)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserName-ChangeUserNameCommand-ChangeUserNameCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-Logger-IEmLogger- 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserName.ChangeUserNameCommand.ChangeUserNameCommandHandler.#ctor(Definux.Emeraude.Application.Identity.IUserManager,Definux.Emeraude.Application.Logger.IEmLogger)')
  - [Handle()](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserName-ChangeUserNameCommand-ChangeUserNameCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserName-ChangeUserNameCommand,System-Threading-CancellationToken- 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserName.ChangeUserNameCommand.ChangeUserNameCommandHandler.Handle(Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserName.ChangeUserNameCommand,System.Threading.CancellationToken)')
- [ChangeUserNameCommandValidator](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserName-ChangeUserNameCommandValidator 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserName.ChangeUserNameCommandValidator')
  - [#ctor()](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserName-ChangeUserNameCommandValidator-#ctor 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserName.ChangeUserNameCommandValidator.#ctor')
- [ConfirmEmailCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ConfirmEmail-ConfirmEmailCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail.ConfirmEmailCommand')
  - [#ctor(email,token)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ConfirmEmail-ConfirmEmailCommand-#ctor-System-String,System-String- 'Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail.ConfirmEmailCommand.#ctor(System.String,System.String)')
  - [Email](#P-Definux-Emeraude-Application-Requests-Identity-Commands-ConfirmEmail-ConfirmEmailCommand-Email 'Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail.ConfirmEmailCommand.Email')
  - [Token](#P-Definux-Emeraude-Application-Requests-Identity-Commands-ConfirmEmail-ConfirmEmailCommand-Token 'Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail.ConfirmEmailCommand.Token')
- [ConfirmEmailCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ConfirmEmail-ConfirmEmailCommand-ConfirmEmailCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail.ConfirmEmailCommand.ConfirmEmailCommandHandler')
  - [#ctor(userManager,identityEventManager)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ConfirmEmail-ConfirmEmailCommand-ConfirmEmailCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-EventHandlers-IIdentityEventManager- 'Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail.ConfirmEmailCommand.ConfirmEmailCommandHandler.#ctor(Definux.Emeraude.Application.Identity.IUserManager,Definux.Emeraude.Application.EventHandlers.IIdentityEventManager)')
  - [Handle()](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ConfirmEmail-ConfirmEmailCommand-ConfirmEmailCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-ConfirmEmail-ConfirmEmailCommand,System-Threading-CancellationToken- 'Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail.ConfirmEmailCommand.ConfirmEmailCommandHandler.Handle(Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail.ConfirmEmailCommand,System.Threading.CancellationToken)')
- [ConfirmEmailCommandValidator](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ConfirmEmail-ConfirmEmailCommandValidator 'Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail.ConfirmEmailCommandValidator')
  - [#ctor()](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ConfirmEmail-ConfirmEmailCommandValidator-#ctor 'Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail.ConfirmEmailCommandValidator.#ctor')
- [ConfirmEmailRequestResult](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ConfirmEmail-ConfirmEmailRequestResult 'Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail.ConfirmEmailRequestResult')
  - [#ctor(success)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ConfirmEmail-ConfirmEmailRequestResult-#ctor-System-Boolean- 'Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail.ConfirmEmailRequestResult.#ctor(System.Boolean)')
- [ConfirmedEmailEventArgs](#T-Definux-Emeraude-Application-EventHandlers-ConfirmedEmailEventArgs 'Definux.Emeraude.Application.EventHandlers.ConfirmedEmailEventArgs')
- [DevelopmentOnlyException](#T-Definux-Emeraude-Application-Exceptions-DevelopmentOnlyException 'Definux.Emeraude.Application.Exceptions.DevelopmentOnlyException')
  - [#ctor()](#M-Definux-Emeraude-Application-Exceptions-DevelopmentOnlyException-#ctor 'Definux.Emeraude.Application.Exceptions.DevelopmentOnlyException.#ctor')
  - [#ctor(message)](#M-Definux-Emeraude-Application-Exceptions-DevelopmentOnlyException-#ctor-System-String- 'Definux.Emeraude.Application.Exceptions.DevelopmentOnlyException.#ctor(System.String)')
- [EmailModel](#T-Definux-Emeraude-Application-Emails-EmailModel 'Definux.Emeraude.Application.Emails.EmailModel')
  - [Email](#P-Definux-Emeraude-Application-Emails-EmailModel-Email 'Definux.Emeraude.Application.Emails.EmailModel.Email')
  - [Name](#P-Definux-Emeraude-Application-Emails-EmailModel-Name 'Definux.Emeraude.Application.Emails.EmailModel.Name')
  - [Subject](#P-Definux-Emeraude-Application-Emails-EmailModel-Subject 'Definux.Emeraude.Application.Emails.EmailModel.Subject')
- [EntityNotFoundException](#T-Definux-Emeraude-Application-Exceptions-EntityNotFoundException 'Definux.Emeraude.Application.Exceptions.EntityNotFoundException')
  - [#ctor(entity,identifier)](#M-Definux-Emeraude-Application-Exceptions-EntityNotFoundException-#ctor-System-String,System-Guid- 'Definux.Emeraude.Application.Exceptions.EntityNotFoundException.#ctor(System.String,System.Guid)')
  - [#ctor(entity,identifier)](#M-Definux-Emeraude-Application-Exceptions-EntityNotFoundException-#ctor-System-String,System-Int32- 'Definux.Emeraude.Application.Exceptions.EntityNotFoundException.#ctor(System.String,System.Int32)')
  - [#ctor(message)](#M-Definux-Emeraude-Application-Exceptions-EntityNotFoundException-#ctor-System-String- 'Definux.Emeraude.Application.Exceptions.EntityNotFoundException.#ctor(System.String)')
- [ExternalAuthenticationCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationCommand')
  - [#ctor(claimsPrincipal)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationCommand-#ctor-System-Security-Claims-ClaimsPrincipal- 'Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationCommand.#ctor(System.Security.Claims.ClaimsPrincipal)')
  - [#ctor(externalAuthenticationData)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationCommand-#ctor-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationData- 'Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationCommand.#ctor(Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationData)')
  - [ClaimsPrincipal](#P-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationCommand-ClaimsPrincipal 'Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationCommand.ClaimsPrincipal')
  - [ExternalAuthenticationData](#P-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationCommand-ExternalAuthenticationData 'Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationCommand.ExternalAuthenticationData')
  - [ExternalProvider](#P-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationCommand-ExternalProvider 'Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationCommand.ExternalProvider')
- [ExternalAuthenticationCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationCommand-ExternalAuthenticationCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationCommand.ExternalAuthenticationCommandHandler')
  - [#ctor(logger,userManager,userAvatarService,externalProviderAuthenticatorFactory,eventManager)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationCommand-ExternalAuthenticationCommandHandler-#ctor-Definux-Emeraude-Application-Logger-IEmLogger,Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-Identity-IUserAvatarService,Definux-Emeraude-Application-Identity-IExternalProviderAuthenticatorFactory,Definux-Emeraude-Application-EventHandlers-IIdentityEventManager- 'Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationCommand.ExternalAuthenticationCommandHandler.#ctor(Definux.Emeraude.Application.Logger.IEmLogger,Definux.Emeraude.Application.Identity.IUserManager,Definux.Emeraude.Application.Identity.IUserAvatarService,Definux.Emeraude.Application.Identity.IExternalProviderAuthenticatorFactory,Definux.Emeraude.Application.EventHandlers.IIdentityEventManager)')
  - [Handle()](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationCommand-ExternalAuthenticationCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationCommand,System-Threading-CancellationToken- 'Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationCommand.ExternalAuthenticationCommandHandler.Handle(Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationCommand,System.Threading.CancellationToken)')
- [ExternalAuthenticationData](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationData 'Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationData')
  - [AccessToken](#P-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationData-AccessToken 'Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationData.AccessToken')
  - [Provider](#P-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationData-Provider 'Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationData.Provider')
- [ExternalAuthenticationRequestResult](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationRequestResult 'Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationRequestResult')
  - [Result](#P-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationRequestResult-Result 'Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationRequestResult.Result')
  - [User](#P-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationRequestResult-User 'Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationRequestResult.User')
- [ExternalLoginEventArgs](#T-Definux-Emeraude-Application-EventHandlers-ExternalLoginEventArgs 'Definux.Emeraude.Application.EventHandlers.ExternalLoginEventArgs')
- [ExternalRegisterEventArgs](#T-Definux-Emeraude-Application-EventHandlers-ExternalRegisterEventArgs 'Definux.Emeraude.Application.EventHandlers.ExternalRegisterEventArgs')
- [FileSystemItemType](#T-Definux-Emeraude-Application-Files-FileSystemItemType 'Definux.Emeraude.Application.Files.FileSystemItemType')
  - [File](#F-Definux-Emeraude-Application-Files-FileSystemItemType-File 'Definux.Emeraude.Application.Files.FileSystemItemType.File')
  - [Folder](#F-Definux-Emeraude-Application-Files-FileSystemItemType-Folder 'Definux.Emeraude.Application.Files.FileSystemItemType.Folder')
- [ForgotPasswordCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword.ForgotPasswordCommand')
  - [Email](#P-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommand-Email 'Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword.ForgotPasswordCommand.Email')
- [ForgotPasswordCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommand-ForgotPasswordCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword.ForgotPasswordCommand.ForgotPasswordCommandHandler')
  - [#ctor(userManager,identityEventManager,urlEncoder,httpContextAccessor,currentLanguageProvider)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommand-ForgotPasswordCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-EventHandlers-IIdentityEventManager,System-Text-Encodings-Web-UrlEncoder,Microsoft-AspNetCore-Http-IHttpContextAccessor,Definux-Emeraude-Application-Localization-ICurrentLanguageProvider- 'Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword.ForgotPasswordCommand.ForgotPasswordCommandHandler.#ctor(Definux.Emeraude.Application.Identity.IUserManager,Definux.Emeraude.Application.EventHandlers.IIdentityEventManager,System.Text.Encodings.Web.UrlEncoder,Microsoft.AspNetCore.Http.IHttpContextAccessor,Definux.Emeraude.Application.Localization.ICurrentLanguageProvider)')
  - [Handle()](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommand-ForgotPasswordCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommand,System-Threading-CancellationToken- 'Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword.ForgotPasswordCommand.ForgotPasswordCommandHandler.Handle(Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword.ForgotPasswordCommand,System.Threading.CancellationToken)')
- [ForgotPasswordCommandValidator](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommandValidator 'Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword.ForgotPasswordCommandValidator')
  - [#ctor()](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommandValidator-#ctor 'Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword.ForgotPasswordCommandValidator.#ctor')
- [ForgotPasswordEventArgs](#T-Definux-Emeraude-Application-EventHandlers-ForgotPasswordEventArgs 'Definux.Emeraude.Application.EventHandlers.ForgotPasswordEventArgs')
  - [ResetPasswordLink](#P-Definux-Emeraude-Application-EventHandlers-ForgotPasswordEventArgs-ResetPasswordLink 'Definux.Emeraude.Application.EventHandlers.ForgotPasswordEventArgs.ResetPasswordLink')
- [ForgotPasswordRequestResult](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordRequestResult 'Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword.ForgotPasswordRequestResult')
  - [#ctor(success)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordRequestResult-#ctor-System-Boolean- 'Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword.ForgotPasswordRequestResult.#ctor(System.Boolean)')
- [GetUserAvatarQuery](#T-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserAvatar-GetUserAvatarQuery 'Definux.Emeraude.Application.Requests.Identity.Queries.GetUserAvatar.GetUserAvatarQuery')
  - [UserId](#P-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserAvatar-GetUserAvatarQuery-UserId 'Definux.Emeraude.Application.Requests.Identity.Queries.GetUserAvatar.GetUserAvatarQuery.UserId')
- [GetUserAvatarQueryHandler](#T-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserAvatar-GetUserAvatarQuery-GetUserAvatarQueryHandler 'Definux.Emeraude.Application.Requests.Identity.Queries.GetUserAvatar.GetUserAvatarQuery.GetUserAvatarQueryHandler')
  - [#ctor(systemFilesService,userManager,userAvatarService,rootsService,logger)](#M-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserAvatar-GetUserAvatarQuery-GetUserAvatarQueryHandler-#ctor-Definux-Emeraude-Application-Files-ISystemFilesService,Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-Identity-IUserAvatarService,Definux-Emeraude-Application-Files-IRootsService,Definux-Emeraude-Application-Logger-IEmLogger- 'Definux.Emeraude.Application.Requests.Identity.Queries.GetUserAvatar.GetUserAvatarQuery.GetUserAvatarQueryHandler.#ctor(Definux.Emeraude.Application.Files.ISystemFilesService,Definux.Emeraude.Application.Identity.IUserManager,Definux.Emeraude.Application.Identity.IUserAvatarService,Definux.Emeraude.Application.Files.IRootsService,Definux.Emeraude.Application.Logger.IEmLogger)')
  - [Handle()](#M-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserAvatar-GetUserAvatarQuery-GetUserAvatarQueryHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserAvatar-GetUserAvatarQuery,System-Threading-CancellationToken- 'Definux.Emeraude.Application.Requests.Identity.Queries.GetUserAvatar.GetUserAvatarQuery.GetUserAvatarQueryHandler.Handle(Definux.Emeraude.Application.Requests.Identity.Queries.GetUserAvatar.GetUserAvatarQuery,System.Threading.CancellationToken)')
- [GetUserAvatarResult](#T-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserAvatar-GetUserAvatarResult 'Definux.Emeraude.Application.Requests.Identity.Queries.GetUserAvatar.GetUserAvatarResult')
  - [Avatar](#P-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserAvatar-GetUserAvatarResult-Avatar 'Definux.Emeraude.Application.Requests.Identity.Queries.GetUserAvatar.GetUserAvatarResult.Avatar')
  - [GetUserAvatarType()](#M-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserAvatar-GetUserAvatarResult-GetUserAvatarType 'Definux.Emeraude.Application.Requests.Identity.Queries.GetUserAvatar.GetUserAvatarResult.GetUserAvatarType')
- [GetUserExternalLoginProvidersQuery](#T-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserExternalLoginProviders-GetUserExternalLoginProvidersQuery 'Definux.Emeraude.Application.Requests.Identity.Queries.GetUserExternalLoginProviders.GetUserExternalLoginProvidersQuery')
  - [UserId](#P-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserExternalLoginProviders-GetUserExternalLoginProvidersQuery-UserId 'Definux.Emeraude.Application.Requests.Identity.Queries.GetUserExternalLoginProviders.GetUserExternalLoginProvidersQuery.UserId')
- [GetUserExternalLoginProvidersQueryHandler](#T-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserExternalLoginProviders-GetUserExternalLoginProvidersQuery-GetUserExternalLoginProvidersQueryHandler 'Definux.Emeraude.Application.Requests.Identity.Queries.GetUserExternalLoginProviders.GetUserExternalLoginProvidersQuery.GetUserExternalLoginProvidersQueryHandler')
  - [#ctor(userManager,logger)](#M-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserExternalLoginProviders-GetUserExternalLoginProvidersQuery-GetUserExternalLoginProvidersQueryHandler-#ctor-Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-Logger-IEmLogger- 'Definux.Emeraude.Application.Requests.Identity.Queries.GetUserExternalLoginProviders.GetUserExternalLoginProvidersQuery.GetUserExternalLoginProvidersQueryHandler.#ctor(Definux.Emeraude.Application.Identity.IUserManager,Definux.Emeraude.Application.Logger.IEmLogger)')
  - [Handle()](#M-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserExternalLoginProviders-GetUserExternalLoginProvidersQuery-GetUserExternalLoginProvidersQueryHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserExternalLoginProviders-GetUserExternalLoginProvidersQuery,System-Threading-CancellationToken- 'Definux.Emeraude.Application.Requests.Identity.Queries.GetUserExternalLoginProviders.GetUserExternalLoginProvidersQuery.GetUserExternalLoginProvidersQueryHandler.Handle(Definux.Emeraude.Application.Requests.Identity.Queries.GetUserExternalLoginProviders.GetUserExternalLoginProvidersQuery,System.Threading.CancellationToken)')
- [GetUserExternalLoginProvidersResult](#T-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserExternalLoginProviders-GetUserExternalLoginProvidersResult 'Definux.Emeraude.Application.Requests.Identity.Queries.GetUserExternalLoginProviders.GetUserExternalLoginProvidersResult')
  - [#ctor()](#M-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserExternalLoginProviders-GetUserExternalLoginProvidersResult-#ctor 'Definux.Emeraude.Application.Requests.Identity.Queries.GetUserExternalLoginProviders.GetUserExternalLoginProvidersResult.#ctor')
  - [Providers](#P-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserExternalLoginProviders-GetUserExternalLoginProvidersResult-Providers 'Definux.Emeraude.Application.Requests.Identity.Queries.GetUserExternalLoginProviders.GetUserExternalLoginProvidersResult.Providers')
- [IApplicationDatabaseInitializer](#T-Definux-Emeraude-Application-Persistence-IApplicationDatabaseInitializer 'Definux.Emeraude.Application.Persistence.IApplicationDatabaseInitializer')
- [IConfirmedEmailEventHandler](#T-Definux-Emeraude-Application-EventHandlers-IConfirmedEmailEventHandler 'Definux.Emeraude.Application.EventHandlers.IConfirmedEmailEventHandler')
- [ICurrentLanguageProvider](#T-Definux-Emeraude-Application-Localization-ICurrentLanguageProvider 'Definux.Emeraude.Application.Localization.ICurrentLanguageProvider')
  - [GetCurrentLanguage()](#M-Definux-Emeraude-Application-Localization-ICurrentLanguageProvider-GetCurrentLanguage 'Definux.Emeraude.Application.Localization.ICurrentLanguageProvider.GetCurrentLanguage')
  - [GetCurrentLanguageAsync()](#M-Definux-Emeraude-Application-Localization-ICurrentLanguageProvider-GetCurrentLanguageAsync 'Definux.Emeraude.Application.Localization.ICurrentLanguageProvider.GetCurrentLanguageAsync')
- [ICurrentUserProvider](#T-Definux-Emeraude-Application-Identity-ICurrentUserProvider 'Definux.Emeraude.Application.Identity.ICurrentUserProvider')
  - [CurrentUserId](#P-Definux-Emeraude-Application-Identity-ICurrentUserProvider-CurrentUserId 'Definux.Emeraude.Application.Identity.ICurrentUserProvider.CurrentUserId')
  - [GetCurrentUserAsync()](#M-Definux-Emeraude-Application-Identity-ICurrentUserProvider-GetCurrentUserAsync 'Definux.Emeraude.Application.Identity.ICurrentUserProvider.GetCurrentUserAsync')
- [IDatabaseContext](#T-Definux-Emeraude-Application-Persistence-IDatabaseContext 'Definux.Emeraude.Application.Persistence.IDatabaseContext')
  - [SaveChanges()](#M-Definux-Emeraude-Application-Persistence-IDatabaseContext-SaveChanges 'Definux.Emeraude.Application.Persistence.IDatabaseContext.SaveChanges')
  - [SaveChanges()](#M-Definux-Emeraude-Application-Persistence-IDatabaseContext-SaveChanges-System-Boolean- 'Definux.Emeraude.Application.Persistence.IDatabaseContext.SaveChanges(System.Boolean)')
  - [SaveChangesAsync()](#M-Definux-Emeraude-Application-Persistence-IDatabaseContext-SaveChangesAsync-System-Boolean,System-Threading-CancellationToken- 'Definux.Emeraude.Application.Persistence.IDatabaseContext.SaveChangesAsync(System.Boolean,System.Threading.CancellationToken)')
  - [SaveChangesAsync()](#M-Definux-Emeraude-Application-Persistence-IDatabaseContext-SaveChangesAsync-System-Threading-CancellationToken- 'Definux.Emeraude.Application.Persistence.IDatabaseContext.SaveChangesAsync(System.Threading.CancellationToken)')
  - [Set\`\`1()](#M-Definux-Emeraude-Application-Persistence-IDatabaseContext-Set``1 'Definux.Emeraude.Application.Persistence.IDatabaseContext.Set``1')
- [IDatabaseInitializerManager](#T-Definux-Emeraude-Application-Persistence-IDatabaseInitializerManager 'Definux.Emeraude.Application.Persistence.IDatabaseInitializerManager')
  - [LoadDatabaseInitializers(initializersTypes)](#M-Definux-Emeraude-Application-Persistence-IDatabaseInitializerManager-LoadDatabaseInitializers-System-Type[]- 'Definux.Emeraude.Application.Persistence.IDatabaseInitializerManager.LoadDatabaseInitializers(System.Type[])')
- [IEmContext](#T-Definux-Emeraude-Application-Persistence-IEmContext 'Definux.Emeraude.Application.Persistence.IEmContext')
  - [GetContextType()](#M-Definux-Emeraude-Application-Persistence-IEmContext-GetContextType 'Definux.Emeraude.Application.Persistence.IEmContext.GetContextType')
- [IEmLocalizer](#T-Definux-Emeraude-Application-Localization-IEmLocalizer 'Definux.Emeraude.Application.Localization.IEmLocalizer')
  - [GetStaticContent(key,languageCode)](#M-Definux-Emeraude-Application-Localization-IEmLocalizer-GetStaticContent-System-String,System-String- 'Definux.Emeraude.Application.Localization.IEmLocalizer.GetStaticContent(System.String,System.String)')
  - [GetStaticContentAsync(key,languageCode)](#M-Definux-Emeraude-Application-Localization-IEmLocalizer-GetStaticContentAsync-System-String,System-String- 'Definux.Emeraude.Application.Localization.IEmLocalizer.GetStaticContentAsync(System.String,System.String)')
  - [TranslateKey(key,languageCode)](#M-Definux-Emeraude-Application-Localization-IEmLocalizer-TranslateKey-System-String,System-String- 'Definux.Emeraude.Application.Localization.IEmLocalizer.TranslateKey(System.String,System.String)')
  - [TranslateKeyAsync(key,languageCode)](#M-Definux-Emeraude-Application-Localization-IEmLocalizer-TranslateKeyAsync-System-String,System-String- 'Definux.Emeraude.Application.Localization.IEmLocalizer.TranslateKeyAsync(System.String,System.String)')
- [IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger')
  - [LogActivity(context,hideParameters)](#M-Definux-Emeraude-Application-Logger-IEmLogger-LogActivity-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext,System-Boolean- 'Definux.Emeraude.Application.Logger.IEmLogger.LogActivity(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext,System.Boolean)')
  - [LogEmailAsync(emailAddress,receiver,subject,body,sent)](#M-Definux-Emeraude-Application-Logger-IEmLogger-LogEmailAsync-System-String,System-String,System-String,System-String,System-Boolean- 'Definux.Emeraude.Application.Logger.IEmLogger.LogEmailAsync(System.String,System.String,System.String,System.String,System.Boolean)')
- [IEmailRenderer](#T-Definux-Emeraude-Application-Emails-IEmailRenderer 'Definux.Emeraude.Application.Emails.IEmailRenderer')
  - [RenderToStringAsync(templateName,model)](#M-Definux-Emeraude-Application-Emails-IEmailRenderer-RenderToStringAsync-System-String,Definux-Emeraude-Application-Emails-EmailModel- 'Definux.Emeraude.Application.Emails.IEmailRenderer.RenderToStringAsync(System.String,Definux.Emeraude.Application.Emails.EmailModel)')
- [IEmailSender](#T-Definux-Emeraude-Application-Emails-IEmailSender 'Definux.Emeraude.Application.Emails.IEmailSender')
  - [SendEmailAsync(templateName,model)](#M-Definux-Emeraude-Application-Emails-IEmailSender-SendEmailAsync-System-String,Definux-Emeraude-Application-Emails-EmailModel- 'Definux.Emeraude.Application.Emails.IEmailSender.SendEmailAsync(System.String,Definux.Emeraude.Application.Emails.EmailModel)')
- [IExternalLoginEventHandler](#T-Definux-Emeraude-Application-EventHandlers-IExternalLoginEventHandler 'Definux.Emeraude.Application.EventHandlers.IExternalLoginEventHandler')
- [IExternalProviderAuthenticator](#T-Definux-Emeraude-Application-Identity-IExternalProviderAuthenticator 'Definux.Emeraude.Application.Identity.IExternalProviderAuthenticator')
  - [Name](#P-Definux-Emeraude-Application-Identity-IExternalProviderAuthenticator-Name 'Definux.Emeraude.Application.Identity.IExternalProviderAuthenticator.Name')
  - [GetExternalUserAsync(principal)](#M-Definux-Emeraude-Application-Identity-IExternalProviderAuthenticator-GetExternalUserAsync-System-Security-Claims-ClaimsPrincipal- 'Definux.Emeraude.Application.Identity.IExternalProviderAuthenticator.GetExternalUserAsync(System.Security.Claims.ClaimsPrincipal)')
  - [GetExternalUserAsync(provider,accessToken)](#M-Definux-Emeraude-Application-Identity-IExternalProviderAuthenticator-GetExternalUserAsync-System-String,System-String- 'Definux.Emeraude.Application.Identity.IExternalProviderAuthenticator.GetExternalUserAsync(System.String,System.String)')
  - [RegisterAuthenticator(builder)](#M-Definux-Emeraude-Application-Identity-IExternalProviderAuthenticator-RegisterAuthenticator-Microsoft-AspNetCore-Authentication-AuthenticationBuilder- 'Definux.Emeraude.Application.Identity.IExternalProviderAuthenticator.RegisterAuthenticator(Microsoft.AspNetCore.Authentication.AuthenticationBuilder)')
- [IExternalProviderAuthenticatorFactory](#T-Definux-Emeraude-Application-Identity-IExternalProviderAuthenticatorFactory 'Definux.Emeraude.Application.Identity.IExternalProviderAuthenticatorFactory')
  - [Providers](#P-Definux-Emeraude-Application-Identity-IExternalProviderAuthenticatorFactory-Providers 'Definux.Emeraude.Application.Identity.IExternalProviderAuthenticatorFactory.Providers')
  - [ContainsProvider(externalProvider)](#M-Definux-Emeraude-Application-Identity-IExternalProviderAuthenticatorFactory-ContainsProvider-System-String- 'Definux.Emeraude.Application.Identity.IExternalProviderAuthenticatorFactory.ContainsProvider(System.String)')
  - [GetAuthenticator(externalProvider)](#M-Definux-Emeraude-Application-Identity-IExternalProviderAuthenticatorFactory-GetAuthenticator-System-String- 'Definux.Emeraude.Application.Identity.IExternalProviderAuthenticatorFactory.GetAuthenticator(System.String)')
- [IExternalRegisterEventHandler](#T-Definux-Emeraude-Application-EventHandlers-IExternalRegisterEventHandler 'Definux.Emeraude.Application.EventHandlers.IExternalRegisterEventHandler')
- [IExternalUser](#T-Definux-Emeraude-Application-Identity-IExternalUser 'Definux.Emeraude.Application.Identity.IExternalUser')
  - [EmailAddress](#P-Definux-Emeraude-Application-Identity-IExternalUser-EmailAddress 'Definux.Emeraude.Application.Identity.IExternalUser.EmailAddress')
  - [FirstName](#P-Definux-Emeraude-Application-Identity-IExternalUser-FirstName 'Definux.Emeraude.Application.Identity.IExternalUser.FirstName')
  - [Id](#P-Definux-Emeraude-Application-Identity-IExternalUser-Id 'Definux.Emeraude.Application.Identity.IExternalUser.Id')
  - [LastName](#P-Definux-Emeraude-Application-Identity-IExternalUser-LastName 'Definux.Emeraude.Application.Identity.IExternalUser.LastName')
  - [Name](#P-Definux-Emeraude-Application-Identity-IExternalUser-Name 'Definux.Emeraude.Application.Identity.IExternalUser.Name')
  - [PictureUrl](#P-Definux-Emeraude-Application-Identity-IExternalUser-PictureUrl 'Definux.Emeraude.Application.Identity.IExternalUser.PictureUrl')
  - [Provider](#P-Definux-Emeraude-Application-Identity-IExternalUser-Provider 'Definux.Emeraude.Application.Identity.IExternalUser.Provider')
- [IFilesValidationProvider](#T-Definux-Emeraude-Application-Files-IFilesValidationProvider 'Definux.Emeraude.Application.Files.IFilesValidationProvider')
  - [ValidateFormFile(formFile,customFileExtensions,customMimeTypes,customMaxFileSize)](#M-Definux-Emeraude-Application-Files-IFilesValidationProvider-ValidateFormFile-Microsoft-AspNetCore-Http-IFormFile,System-Collections-Generic-List{Definux-Utilities-Enumerations-FileExtensions},System-Collections-Generic-List{System-String},System-Int64- 'Definux.Emeraude.Application.Files.IFilesValidationProvider.ValidateFormFile(Microsoft.AspNetCore.Http.IFormFile,System.Collections.Generic.List{Definux.Utilities.Enumerations.FileExtensions},System.Collections.Generic.List{System.String},System.Int64)')
  - [ValidateFormImageFile(formFile,customFileExtensions,customMimeTypes,customMaxFileSize)](#M-Definux-Emeraude-Application-Files-IFilesValidationProvider-ValidateFormImageFile-Microsoft-AspNetCore-Http-IFormFile,System-Collections-Generic-List{Definux-Utilities-Enumerations-FileExtensions},System-Collections-Generic-List{System-String},System-Int64- 'Definux.Emeraude.Application.Files.IFilesValidationProvider.ValidateFormImageFile(Microsoft.AspNetCore.Http.IFormFile,System.Collections.Generic.List{Definux.Utilities.Enumerations.FileExtensions},System.Collections.Generic.List{System.String},System.Int64)')
  - [ValidateFormVideoFile(formFile,customFileExtensions,customMimeTypes,customMaxFileSize)](#M-Definux-Emeraude-Application-Files-IFilesValidationProvider-ValidateFormVideoFile-Microsoft-AspNetCore-Http-IFormFile,System-Collections-Generic-List{Definux-Utilities-Enumerations-FileExtensions},System-Collections-Generic-List{System-String},System-Int64- 'Definux.Emeraude.Application.Files.IFilesValidationProvider.ValidateFormVideoFile(Microsoft.AspNetCore.Http.IFormFile,System.Collections.Generic.List{Definux.Utilities.Enumerations.FileExtensions},System.Collections.Generic.List{System.String},System.Int64)')
- [IFoldersInitializer](#T-Definux-Emeraude-Application-Files-IFoldersInitializer 'Definux.Emeraude.Application.Files.IFoldersInitializer')
  - [InitFoldersAsync()](#M-Definux-Emeraude-Application-Files-IFoldersInitializer-InitFoldersAsync 'Definux.Emeraude.Application.Files.IFoldersInitializer.InitFoldersAsync')
- [IForgotPasswordEventHandler](#T-Definux-Emeraude-Application-EventHandlers-IForgotPasswordEventHandler 'Definux.Emeraude.Application.EventHandlers.IForgotPasswordEventHandler')
- [IIdentityEventHandler\`1](#T-Definux-Emeraude-Application-EventHandlers-IIdentityEventHandler`1 'Definux.Emeraude.Application.EventHandlers.IIdentityEventHandler`1')
  - [HandleAsync(args)](#M-Definux-Emeraude-Application-EventHandlers-IIdentityEventHandler`1-HandleAsync-`0- 'Definux.Emeraude.Application.EventHandlers.IIdentityEventHandler`1.HandleAsync(`0)')
- [IIdentityEventManager](#T-Definux-Emeraude-Application-EventHandlers-IIdentityEventManager 'Definux.Emeraude.Application.EventHandlers.IIdentityEventManager')
  - [TriggerConfirmedEmailEventAsync(userId)](#M-Definux-Emeraude-Application-EventHandlers-IIdentityEventManager-TriggerConfirmedEmailEventAsync-System-Guid- 'Definux.Emeraude.Application.EventHandlers.IIdentityEventManager.TriggerConfirmedEmailEventAsync(System.Guid)')
  - [TriggerExternalLoginEventAsync(userId)](#M-Definux-Emeraude-Application-EventHandlers-IIdentityEventManager-TriggerExternalLoginEventAsync-System-Guid- 'Definux.Emeraude.Application.EventHandlers.IIdentityEventManager.TriggerExternalLoginEventAsync(System.Guid)')
  - [TriggerExternalRegisterEventAsync(userId)](#M-Definux-Emeraude-Application-EventHandlers-IIdentityEventManager-TriggerExternalRegisterEventAsync-System-Guid- 'Definux.Emeraude.Application.EventHandlers.IIdentityEventManager.TriggerExternalRegisterEventAsync(System.Guid)')
  - [TriggerForgotPasswordEventAsync(userId,resetPasswordLink)](#M-Definux-Emeraude-Application-EventHandlers-IIdentityEventManager-TriggerForgotPasswordEventAsync-System-Guid,System-String- 'Definux.Emeraude.Application.EventHandlers.IIdentityEventManager.TriggerForgotPasswordEventAsync(System.Guid,System.String)')
  - [TriggerLoginEventAsync(userId)](#M-Definux-Emeraude-Application-EventHandlers-IIdentityEventManager-TriggerLoginEventAsync-System-Guid- 'Definux.Emeraude.Application.EventHandlers.IIdentityEventManager.TriggerLoginEventAsync(System.Guid)')
  - [TriggerRegisterEventAsync(userId,confirmationLink)](#M-Definux-Emeraude-Application-EventHandlers-IIdentityEventManager-TriggerRegisterEventAsync-System-Guid,System-String- 'Definux.Emeraude.Application.EventHandlers.IIdentityEventManager.TriggerRegisterEventAsync(System.Guid,System.String)')
  - [TriggerRequestChangeEmailEventAsync(userId,newEmail,changeEmailConfirmationLink)](#M-Definux-Emeraude-Application-EventHandlers-IIdentityEventManager-TriggerRequestChangeEmailEventAsync-System-Guid,System-String,System-String- 'Definux.Emeraude.Application.EventHandlers.IIdentityEventManager.TriggerRequestChangeEmailEventAsync(System.Guid,System.String,System.String)')
  - [TriggerResetPasswordEventAsync(userId)](#M-Definux-Emeraude-Application-EventHandlers-IIdentityEventManager-TriggerResetPasswordEventAsync-System-Guid- 'Definux.Emeraude.Application.EventHandlers.IIdentityEventManager.TriggerResetPasswordEventAsync(System.Guid)')
- [ILanguageStore](#T-Definux-Emeraude-Application-Localization-ILanguageStore 'Definux.Emeraude.Application.Localization.ILanguageStore')
  - [GetAllLanguageCodes()](#M-Definux-Emeraude-Application-Localization-ILanguageStore-GetAllLanguageCodes 'Definux.Emeraude.Application.Localization.ILanguageStore.GetAllLanguageCodes')
  - [GetAllLanguageCodesAsync()](#M-Definux-Emeraude-Application-Localization-ILanguageStore-GetAllLanguageCodesAsync 'Definux.Emeraude.Application.Localization.ILanguageStore.GetAllLanguageCodesAsync')
  - [GetDefaultLanguage()](#M-Definux-Emeraude-Application-Localization-ILanguageStore-GetDefaultLanguage 'Definux.Emeraude.Application.Localization.ILanguageStore.GetDefaultLanguage')
  - [GetDefaultLanguageAsync()](#M-Definux-Emeraude-Application-Localization-ILanguageStore-GetDefaultLanguageAsync 'Definux.Emeraude.Application.Localization.ILanguageStore.GetDefaultLanguageAsync')
  - [GetLanguageTranslationDictionary(languageId)](#M-Definux-Emeraude-Application-Localization-ILanguageStore-GetLanguageTranslationDictionary-System-Int32- 'Definux.Emeraude.Application.Localization.ILanguageStore.GetLanguageTranslationDictionary(System.Int32)')
  - [GetLanguages()](#M-Definux-Emeraude-Application-Localization-ILanguageStore-GetLanguages 'Definux.Emeraude.Application.Localization.ILanguageStore.GetLanguages')
  - [GetLanguagesAsync()](#M-Definux-Emeraude-Application-Localization-ILanguageStore-GetLanguagesAsync 'Definux.Emeraude.Application.Localization.ILanguageStore.GetLanguagesAsync')
  - [GetTranslationsKeys()](#M-Definux-Emeraude-Application-Localization-ILanguageStore-GetTranslationsKeys 'Definux.Emeraude.Application.Localization.ILanguageStore.GetTranslationsKeys')
- [ILocalizationContext](#T-Definux-Emeraude-Application-Localization-ILocalizationContext 'Definux.Emeraude.Application.Localization.ILocalizationContext')
  - [ContentKeys](#P-Definux-Emeraude-Application-Localization-ILocalizationContext-ContentKeys 'Definux.Emeraude.Application.Localization.ILocalizationContext.ContentKeys')
  - [Keys](#P-Definux-Emeraude-Application-Localization-ILocalizationContext-Keys 'Definux.Emeraude.Application.Localization.ILocalizationContext.Keys')
  - [Languages](#P-Definux-Emeraude-Application-Localization-ILocalizationContext-Languages 'Definux.Emeraude.Application.Localization.ILocalizationContext.Languages')
  - [StaticContent](#P-Definux-Emeraude-Application-Localization-ILocalizationContext-StaticContent 'Definux.Emeraude.Application.Localization.ILocalizationContext.StaticContent')
  - [Values](#P-Definux-Emeraude-Application-Localization-ILocalizationContext-Values 'Definux.Emeraude.Application.Localization.ILocalizationContext.Values')
- [ILoggerContext](#T-Definux-Emeraude-Application-Logger-ILoggerContext 'Definux.Emeraude.Application.Logger.ILoggerContext')
  - [ActivityLogs](#P-Definux-Emeraude-Application-Logger-ILoggerContext-ActivityLogs 'Definux.Emeraude.Application.Logger.ILoggerContext.ActivityLogs')
  - [EmailLogs](#P-Definux-Emeraude-Application-Logger-ILoggerContext-EmailLogs 'Definux.Emeraude.Application.Logger.ILoggerContext.EmailLogs')
  - [ErrorLogs](#P-Definux-Emeraude-Application-Logger-ILoggerContext-ErrorLogs 'Definux.Emeraude.Application.Logger.ILoggerContext.ErrorLogs')
  - [TempFileLogs](#P-Definux-Emeraude-Application-Logger-ILoggerContext-TempFileLogs 'Definux.Emeraude.Application.Logger.ILoggerContext.TempFileLogs')
- [ILoginEventHandler](#T-Definux-Emeraude-Application-EventHandlers-ILoginEventHandler 'Definux.Emeraude.Application.EventHandlers.ILoginEventHandler')
- [IMapFrom\`1](#T-Definux-Emeraude-Application-Mapping-IMapFrom`1 'Definux.Emeraude.Application.Mapping.IMapFrom`1')
  - [Mapping(profile)](#M-Definux-Emeraude-Application-Mapping-IMapFrom`1-Mapping-AutoMapper-Profile- 'Definux.Emeraude.Application.Mapping.IMapFrom`1.Mapping(AutoMapper.Profile)')
- [IRegisterEventHandler](#T-Definux-Emeraude-Application-EventHandlers-IRegisterEventHandler 'Definux.Emeraude.Application.EventHandlers.IRegisterEventHandler')
- [IRequestChangeEmailEventHandler](#T-Definux-Emeraude-Application-EventHandlers-IRequestChangeEmailEventHandler 'Definux.Emeraude.Application.EventHandlers.IRequestChangeEmailEventHandler')
- [IResetPasswordEventHandler](#T-Definux-Emeraude-Application-EventHandlers-IResetPasswordEventHandler 'Definux.Emeraude.Application.EventHandlers.IResetPasswordEventHandler')
- [IRoleManager](#T-Definux-Emeraude-Application-Identity-IRoleManager 'Definux.Emeraude.Application.Identity.IRoleManager')
  - [AssignRolesToUserAsync(user,roleIds)](#M-Definux-Emeraude-Application-Identity-IRoleManager-AssignRolesToUserAsync-Definux-Emeraude-Domain-Entities-IUser,System-Collections-Generic-IEnumerable{System-Guid}- 'Definux.Emeraude.Application.Identity.IRoleManager.AssignRolesToUserAsync(Definux.Emeraude.Domain.Entities.IUser,System.Collections.Generic.IEnumerable{System.Guid})')
  - [CreateRoleAsync(roleName,claims)](#M-Definux-Emeraude-Application-Identity-IRoleManager-CreateRoleAsync-System-String,System-Collections-Generic-IEnumerable{System-String}- 'Definux.Emeraude.Application.Identity.IRoleManager.CreateRoleAsync(System.String,System.Collections.Generic.IEnumerable{System.String})')
  - [DeleteRoleAsync(roleName)](#M-Definux-Emeraude-Application-Identity-IRoleManager-DeleteRoleAsync-System-String- 'Definux.Emeraude.Application.Identity.IRoleManager.DeleteRoleAsync(System.String)')
  - [GetRolesAsync()](#M-Definux-Emeraude-Application-Identity-IRoleManager-GetRolesAsync 'Definux.Emeraude.Application.Identity.IRoleManager.GetRolesAsync')
  - [GetUserRolesAsync(user)](#M-Definux-Emeraude-Application-Identity-IRoleManager-GetUserRolesAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IRoleManager.GetUserRolesAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [UnassignAllRolesFromUserAsync(user)](#M-Definux-Emeraude-Application-Identity-IRoleManager-UnassignAllRolesFromUserAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IRoleManager.UnassignAllRolesFromUserAsync(Definux.Emeraude.Domain.Entities.IUser)')
- [IRootsService](#T-Definux-Emeraude-Application-Files-IRootsService 'Definux.Emeraude.Application.Files.IRootsService')
  - [PrivateRootDirectory](#P-Definux-Emeraude-Application-Files-IRootsService-PrivateRootDirectory 'Definux.Emeraude.Application.Files.IRootsService.PrivateRootDirectory')
  - [PublicRootDirectory](#P-Definux-Emeraude-Application-Files-IRootsService-PublicRootDirectory 'Definux.Emeraude.Application.Files.IRootsService.PublicRootDirectory')
  - [GetPathFromPrivateRoot(paths)](#M-Definux-Emeraude-Application-Files-IRootsService-GetPathFromPrivateRoot-System-String[]- 'Definux.Emeraude.Application.Files.IRootsService.GetPathFromPrivateRoot(System.String[])')
  - [GetPathFromPublicRoot(paths)](#M-Definux-Emeraude-Application-Files-IRootsService-GetPathFromPublicRoot-System-String[]- 'Definux.Emeraude.Application.Files.IRootsService.GetPathFromPublicRoot(System.String[])')
- [ISystemFilesService](#T-Definux-Emeraude-Application-Files-ISystemFilesService 'Definux.Emeraude.Application.Files.ISystemFilesService')
  - [ApplyTempFileToPrivateDirectoryAsync(fileId,targetDirectory)](#M-Definux-Emeraude-Application-Files-ISystemFilesService-ApplyTempFileToPrivateDirectoryAsync-System-Int32,System-String- 'Definux.Emeraude.Application.Files.ISystemFilesService.ApplyTempFileToPrivateDirectoryAsync(System.Int32,System.String)')
  - [ApplyTempFileToPublicDirectoryAsync(fileId,targetDirectory)](#M-Definux-Emeraude-Application-Files-ISystemFilesService-ApplyTempFileToPublicDirectoryAsync-System-Int32,System-String- 'Definux.Emeraude.Application.Files.ISystemFilesService.ApplyTempFileToPublicDirectoryAsync(System.Int32,System.String)')
  - [ApplyTempFilesToPrivateDirectoryAsync(ids,targetDirectory)](#M-Definux-Emeraude-Application-Files-ISystemFilesService-ApplyTempFilesToPrivateDirectoryAsync-System-Collections-Generic-IEnumerable{System-Int32},System-String- 'Definux.Emeraude.Application.Files.ISystemFilesService.ApplyTempFilesToPrivateDirectoryAsync(System.Collections.Generic.IEnumerable{System.Int32},System.String)')
  - [ApplyTempFilesToPublicDirectoryAsync(ids,targetDirectory)](#M-Definux-Emeraude-Application-Files-ISystemFilesService-ApplyTempFilesToPublicDirectoryAsync-System-Collections-Generic-IEnumerable{System-Int32},System-String- 'Definux.Emeraude.Application.Files.ISystemFilesService.ApplyTempFilesToPublicDirectoryAsync(System.Collections.Generic.IEnumerable{System.Int32},System.String)')
  - [CreateFolderAsync(folderName,folderPath)](#M-Definux-Emeraude-Application-Files-ISystemFilesService-CreateFolderAsync-System-String,System-String- 'Definux.Emeraude.Application.Files.ISystemFilesService.CreateFolderAsync(System.String,System.String)')
  - [GetFileAsync(filePath)](#M-Definux-Emeraude-Application-Files-ISystemFilesService-GetFileAsync-System-String- 'Definux.Emeraude.Application.Files.ISystemFilesService.GetFileAsync(System.String)')
  - [GetFileById(id)](#M-Definux-Emeraude-Application-Files-ISystemFilesService-GetFileById-System-Int32- 'Definux.Emeraude.Application.Files.ISystemFilesService.GetFileById(System.Int32)')
  - [GetFileByIdAsync(id)](#M-Definux-Emeraude-Application-Files-ISystemFilesService-GetFileByIdAsync-System-Int32- 'Definux.Emeraude.Application.Files.ISystemFilesService.GetFileByIdAsync(System.Int32)')
  - [GetFilesByIds(ids)](#M-Definux-Emeraude-Application-Files-ISystemFilesService-GetFilesByIds-System-Collections-Generic-IEnumerable{System-Int32}- 'Definux.Emeraude.Application.Files.ISystemFilesService.GetFilesByIds(System.Collections.Generic.IEnumerable{System.Int32})')
  - [GetFilesByIdsAsync(ids)](#M-Definux-Emeraude-Application-Files-ISystemFilesService-GetFilesByIdsAsync-System-Collections-Generic-IEnumerable{System-Int32}- 'Definux.Emeraude.Application.Files.ISystemFilesService.GetFilesByIdsAsync(System.Collections.Generic.IEnumerable{System.Int32})')
  - [GetPublicRootFolderFilesRelativePaths(paths)](#M-Definux-Emeraude-Application-Files-ISystemFilesService-GetPublicRootFolderFilesRelativePaths-System-String[]- 'Definux.Emeraude.Application.Files.ISystemFilesService.GetPublicRootFolderFilesRelativePaths(System.String[])')
  - [ScanDirectory(directory,baseDirectory)](#M-Definux-Emeraude-Application-Files-ISystemFilesService-ScanDirectory-System-String,System-String- 'Definux.Emeraude.Application.Files.ISystemFilesService.ScanDirectory(System.String,System.String)')
  - [ScanPrivateDirectory()](#M-Definux-Emeraude-Application-Files-ISystemFilesService-ScanPrivateDirectory 'Definux.Emeraude.Application.Files.ISystemFilesService.ScanPrivateDirectory')
  - [ScanPublicDirectory()](#M-Definux-Emeraude-Application-Files-ISystemFilesService-ScanPublicDirectory 'Definux.Emeraude.Application.Files.ISystemFilesService.ScanPublicDirectory')
- [ITwoFactorAuthenticationService](#T-Definux-Emeraude-Application-Identity-ITwoFactorAuthenticationService 'Definux.Emeraude.Application.Identity.ITwoFactorAuthenticationService')
  - [GenerateQrCodeUriAsync(user)](#M-Definux-Emeraude-Application-Identity-ITwoFactorAuthenticationService-GenerateQrCodeUriAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.ITwoFactorAuthenticationService.GenerateQrCodeUriAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [GetFormattedKeyAsync(user)](#M-Definux-Emeraude-Application-Identity-ITwoFactorAuthenticationService-GetFormattedKeyAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.ITwoFactorAuthenticationService.GetFormattedKeyAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [IsTwoFactorEnabled(user)](#M-Definux-Emeraude-Application-Identity-ITwoFactorAuthenticationService-IsTwoFactorEnabled-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.ITwoFactorAuthenticationService.IsTwoFactorEnabled(Definux.Emeraude.Domain.Entities.IUser)')
- [IUploadService](#T-Definux-Emeraude-Application-Files-IUploadService 'Definux.Emeraude.Application.Files.IUploadService')
  - [UploadFileAsync(formFile)](#M-Definux-Emeraude-Application-Files-IUploadService-UploadFileAsync-Microsoft-AspNetCore-Http-IFormFile- 'Definux.Emeraude.Application.Files.IUploadService.UploadFileAsync(Microsoft.AspNetCore.Http.IFormFile)')
  - [UploadFileAsync(formFile,saveDirectory,publicRoot)](#M-Definux-Emeraude-Application-Files-IUploadService-UploadFileAsync-Microsoft-AspNetCore-Http-IFormFile,System-String,System-Boolean- 'Definux.Emeraude.Application.Files.IUploadService.UploadFileAsync(Microsoft.AspNetCore.Http.IFormFile,System.String,System.Boolean)')
- [IUserAvatarService](#T-Definux-Emeraude-Application-Identity-IUserAvatarService 'Definux.Emeraude.Application.Identity.IUserAvatarService')
  - [ApplyAvatarToUserAsync(userId,avatarUrl)](#M-Definux-Emeraude-Application-Identity-IUserAvatarService-ApplyAvatarToUserAsync-System-Guid,System-String- 'Definux.Emeraude.Application.Identity.IUserAvatarService.ApplyAvatarToUserAsync(System.Guid,System.String)')
  - [CreateAvatarFromUrlAsync(externalSourceAvatarUrl)](#M-Definux-Emeraude-Application-Identity-IUserAvatarService-CreateAvatarFromUrlAsync-System-String- 'Definux.Emeraude.Application.Identity.IUserAvatarService.CreateAvatarFromUrlAsync(System.String)')
  - [CreateUserAvatarAsync(avatarFileByteArray)](#M-Definux-Emeraude-Application-Identity-IUserAvatarService-CreateUserAvatarAsync-System-Byte[]- 'Definux.Emeraude.Application.Identity.IUserAvatarService.CreateUserAvatarAsync(System.Byte[])')
  - [GetUserAvatarRelativePath(user)](#M-Definux-Emeraude-Application-Identity-IUserAvatarService-GetUserAvatarRelativePath-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserAvatarService.GetUserAvatarRelativePath(Definux.Emeraude.Domain.Entities.IUser)')
- [IUserClaimsService](#T-Definux-Emeraude-Application-Identity-IUserClaimsService 'Definux.Emeraude.Application.Identity.IUserClaimsService')
  - [CheckUserForAccessAdministrationPermissionAsync(email)](#M-Definux-Emeraude-Application-Identity-IUserClaimsService-CheckUserForAccessAdministrationPermissionAsync-System-String- 'Definux.Emeraude.Application.Identity.IUserClaimsService.CheckUserForAccessAdministrationPermissionAsync(System.String)')
  - [GetAllUserClaimsAsync(user)](#M-Definux-Emeraude-Application-Identity-IUserClaimsService-GetAllUserClaimsAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserClaimsService.GetAllUserClaimsAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [GetUserClaimsForCookieAsync(userId)](#M-Definux-Emeraude-Application-Identity-IUserClaimsService-GetUserClaimsForCookieAsync-System-Guid- 'Definux.Emeraude.Application.Identity.IUserClaimsService.GetUserClaimsForCookieAsync(System.Guid)')
  - [GetUserClaimsForJwtTokenAsync(userId)](#M-Definux-Emeraude-Application-Identity-IUserClaimsService-GetUserClaimsForJwtTokenAsync-System-Guid- 'Definux.Emeraude.Application.Identity.IUserClaimsService.GetUserClaimsForJwtTokenAsync(System.Guid)')
- [IUserManager](#T-Definux-Emeraude-Application-Identity-IUserManager 'Definux.Emeraude.Application.Identity.IUserManager')
  - [Options](#P-Definux-Emeraude-Application-Identity-IUserManager-Options 'Definux.Emeraude.Application.Identity.IUserManager.Options')
  - [AccessFailedAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-AccessFailedAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.AccessFailedAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [AddClaimAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-AddClaimAsync-Definux-Emeraude-Domain-Entities-IUser,System-Security-Claims-Claim- 'Definux.Emeraude.Application.Identity.IUserManager.AddClaimAsync(Definux.Emeraude.Domain.Entities.IUser,System.Security.Claims.Claim)')
  - [AddClaimsAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-AddClaimsAsync-Definux-Emeraude-Domain-Entities-IUser,System-Collections-Generic-IEnumerable{System-Security-Claims-Claim}- 'Definux.Emeraude.Application.Identity.IUserManager.AddClaimsAsync(Definux.Emeraude.Domain.Entities.IUser,System.Collections.Generic.IEnumerable{System.Security.Claims.Claim})')
  - [AddLoginAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-AddLoginAsync-Definux-Emeraude-Domain-Entities-IUser,Microsoft-AspNetCore-Identity-UserLoginInfo- 'Definux.Emeraude.Application.Identity.IUserManager.AddLoginAsync(Definux.Emeraude.Domain.Entities.IUser,Microsoft.AspNetCore.Identity.UserLoginInfo)')
  - [AddPasswordAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-AddPasswordAsync-Definux-Emeraude-Domain-Entities-IUser,System-String- 'Definux.Emeraude.Application.Identity.IUserManager.AddPasswordAsync(Definux.Emeraude.Domain.Entities.IUser,System.String)')
  - [AddToRoleAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-AddToRoleAsync-Definux-Emeraude-Domain-Entities-IUser,System-String- 'Definux.Emeraude.Application.Identity.IUserManager.AddToRoleAsync(Definux.Emeraude.Domain.Entities.IUser,System.String)')
  - [AddToRolesAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-AddToRolesAsync-Definux-Emeraude-Domain-Entities-IUser,System-Collections-Generic-IEnumerable{System-String}- 'Definux.Emeraude.Application.Identity.IUserManager.AddToRolesAsync(Definux.Emeraude.Domain.Entities.IUser,System.Collections.Generic.IEnumerable{System.String})')
  - [ChangeEmailAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-ChangeEmailAsync-Definux-Emeraude-Domain-Entities-IUser,System-String,System-String- 'Definux.Emeraude.Application.Identity.IUserManager.ChangeEmailAsync(Definux.Emeraude.Domain.Entities.IUser,System.String,System.String)')
  - [ChangePasswordAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-ChangePasswordAsync-Definux-Emeraude-Domain-Entities-IUser,System-String,System-String- 'Definux.Emeraude.Application.Identity.IUserManager.ChangePasswordAsync(Definux.Emeraude.Domain.Entities.IUser,System.String,System.String)')
  - [ChangePhoneNumberAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-ChangePhoneNumberAsync-Definux-Emeraude-Domain-Entities-IUser,System-String,System-String- 'Definux.Emeraude.Application.Identity.IUserManager.ChangePhoneNumberAsync(Definux.Emeraude.Domain.Entities.IUser,System.String,System.String)')
  - [ChangeUserNameAsync(user,newName)](#M-Definux-Emeraude-Application-Identity-IUserManager-ChangeUserNameAsync-Definux-Emeraude-Domain-Entities-IUser,System-String- 'Definux.Emeraude.Application.Identity.IUserManager.ChangeUserNameAsync(Definux.Emeraude.Domain.Entities.IUser,System.String)')
  - [CheckPasswordAsync(email,password)](#M-Definux-Emeraude-Application-Identity-IUserManager-CheckPasswordAsync-System-String,System-String- 'Definux.Emeraude.Application.Identity.IUserManager.CheckPasswordAsync(System.String,System.String)')
  - [CheckPasswordAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-CheckPasswordAsync-Definux-Emeraude-Domain-Entities-IUser,System-String- 'Definux.Emeraude.Application.Identity.IUserManager.CheckPasswordAsync(Definux.Emeraude.Domain.Entities.IUser,System.String)')
  - [ConfirmEmailAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-ConfirmEmailAsync-Definux-Emeraude-Domain-Entities-IUser,System-String- 'Definux.Emeraude.Application.Identity.IUserManager.ConfirmEmailAsync(Definux.Emeraude.Domain.Entities.IUser,System.String)')
  - [CountRecoveryCodesAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-CountRecoveryCodesAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.CountRecoveryCodesAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [CreateAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-CreateAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.CreateAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [CreateAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-CreateAsync-Definux-Emeraude-Domain-Entities-IUser,System-String- 'Definux.Emeraude.Application.Identity.IUserManager.CreateAsync(Definux.Emeraude.Domain.Entities.IUser,System.String)')
  - [CreateSecurityTokenAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-CreateSecurityTokenAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.CreateSecurityTokenAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [CreateUserObject(email,name,confirmedEmail)](#M-Definux-Emeraude-Application-Identity-IUserManager-CreateUserObject-System-String,System-String,System-Boolean- 'Definux.Emeraude.Application.Identity.IUserManager.CreateUserObject(System.String,System.String,System.Boolean)')
  - [DeleteAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-DeleteAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.DeleteAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [FindUserByEmailAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-FindUserByEmailAsync-System-String- 'Definux.Emeraude.Application.Identity.IUserManager.FindUserByEmailAsync(System.String)')
  - [FindUserByIdAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-FindUserByIdAsync-System-Guid- 'Definux.Emeraude.Application.Identity.IUserManager.FindUserByIdAsync(System.Guid)')
  - [FindUserByLoginAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-FindUserByLoginAsync-System-String,System-String- 'Definux.Emeraude.Application.Identity.IUserManager.FindUserByLoginAsync(System.String,System.String)')
  - [FindUserByNameAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-FindUserByNameAsync-System-String- 'Definux.Emeraude.Application.Identity.IUserManager.FindUserByNameAsync(System.String)')
  - [GenerateChangeEmailTokenAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-GenerateChangeEmailTokenAsync-Definux-Emeraude-Domain-Entities-IUser,System-String- 'Definux.Emeraude.Application.Identity.IUserManager.GenerateChangeEmailTokenAsync(Definux.Emeraude.Domain.Entities.IUser,System.String)')
  - [GenerateChangePhoneNumberTokenAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-GenerateChangePhoneNumberTokenAsync-Definux-Emeraude-Domain-Entities-IUser,System-String- 'Definux.Emeraude.Application.Identity.IUserManager.GenerateChangePhoneNumberTokenAsync(Definux.Emeraude.Domain.Entities.IUser,System.String)')
  - [GenerateConcurrencyStampAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-GenerateConcurrencyStampAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.GenerateConcurrencyStampAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [GenerateEmailConfirmationTokenAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-GenerateEmailConfirmationTokenAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.GenerateEmailConfirmationTokenAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [GenerateNewTwoFactorRecoveryCodesAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-GenerateNewTwoFactorRecoveryCodesAsync-Definux-Emeraude-Domain-Entities-IUser,System-Int32- 'Definux.Emeraude.Application.Identity.IUserManager.GenerateNewTwoFactorRecoveryCodesAsync(Definux.Emeraude.Domain.Entities.IUser,System.Int32)')
  - [GeneratePasswordResetTokenAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-GeneratePasswordResetTokenAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.GeneratePasswordResetTokenAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [GenerateTwoFactorTokenAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-GenerateTwoFactorTokenAsync-Definux-Emeraude-Domain-Entities-IUser,System-String- 'Definux.Emeraude.Application.Identity.IUserManager.GenerateTwoFactorTokenAsync(Definux.Emeraude.Domain.Entities.IUser,System.String)')
  - [GenerateUserTokenAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-GenerateUserTokenAsync-Definux-Emeraude-Domain-Entities-IUser,System-String,System-String- 'Definux.Emeraude.Application.Identity.IUserManager.GenerateUserTokenAsync(Definux.Emeraude.Domain.Entities.IUser,System.String,System.String)')
  - [GetAccessFailedCountAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-GetAccessFailedCountAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.GetAccessFailedCountAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [GetAuthenticationTokenAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-GetAuthenticationTokenAsync-Definux-Emeraude-Domain-Entities-IUser,System-String,System-String- 'Definux.Emeraude.Application.Identity.IUserManager.GetAuthenticationTokenAsync(Definux.Emeraude.Domain.Entities.IUser,System.String,System.String)')
  - [GetAuthenticatorKeyAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-GetAuthenticatorKeyAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.GetAuthenticatorKeyAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [GetClaimsAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-GetClaimsAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.GetClaimsAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [GetEmailAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-GetEmailAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.GetEmailAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [GetLockoutEnabledAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-GetLockoutEnabledAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.GetLockoutEnabledAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [GetLockoutEndDateAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-GetLockoutEndDateAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.GetLockoutEndDateAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [GetLoginsAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-GetLoginsAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.GetLoginsAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [GetPhoneNumberAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-GetPhoneNumberAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.GetPhoneNumberAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [GetRolesAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-GetRolesAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.GetRolesAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [GetSecurityStampAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-GetSecurityStampAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.GetSecurityStampAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [GetTwoFactorAuthenticationUserAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-GetTwoFactorAuthenticationUserAsync 'Definux.Emeraude.Application.Identity.IUserManager.GetTwoFactorAuthenticationUserAsync')
  - [GetTwoFactorEnabledAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-GetTwoFactorEnabledAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.GetTwoFactorEnabledAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [GetUserIdAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-GetUserIdAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.GetUserIdAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [GetValidTwoFactorProvidersAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-GetValidTwoFactorProvidersAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.GetValidTwoFactorProvidersAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [HasPasswordAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-HasPasswordAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.HasPasswordAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [IsEmailConfirmedAsync(email)](#M-Definux-Emeraude-Application-Identity-IUserManager-IsEmailConfirmedAsync-System-String- 'Definux.Emeraude.Application.Identity.IUserManager.IsEmailConfirmedAsync(System.String)')
  - [IsEmailConfirmedAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-IsEmailConfirmedAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.IsEmailConfirmedAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [IsInRoleAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-IsInRoleAsync-Definux-Emeraude-Domain-Entities-IUser,System-String- 'Definux.Emeraude.Application.Identity.IUserManager.IsInRoleAsync(Definux.Emeraude.Domain.Entities.IUser,System.String)')
  - [IsLockedOutAsync(email)](#M-Definux-Emeraude-Application-Identity-IUserManager-IsLockedOutAsync-System-String- 'Definux.Emeraude.Application.Identity.IUserManager.IsLockedOutAsync(System.String)')
  - [IsLockedOutAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-IsLockedOutAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.IsLockedOutAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [IsPhoneNumberConfirmedAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-IsPhoneNumberConfirmedAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.IsPhoneNumberConfirmedAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [RedeemTwoFactorRecoveryCodeAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-RedeemTwoFactorRecoveryCodeAsync-Definux-Emeraude-Domain-Entities-IUser,System-String- 'Definux.Emeraude.Application.Identity.IUserManager.RedeemTwoFactorRecoveryCodeAsync(Definux.Emeraude.Domain.Entities.IUser,System.String)')
  - [RegisterTokenProvider()](#M-Definux-Emeraude-Application-Identity-IUserManager-RegisterTokenProvider-System-String,Microsoft-AspNetCore-Identity-IUserTwoFactorTokenProvider{Definux-Emeraude-Domain-Entities-IUser}- 'Definux.Emeraude.Application.Identity.IUserManager.RegisterTokenProvider(System.String,Microsoft.AspNetCore.Identity.IUserTwoFactorTokenProvider{Definux.Emeraude.Domain.Entities.IUser})')
  - [RemoveAuthenticationTokenAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-RemoveAuthenticationTokenAsync-Definux-Emeraude-Domain-Entities-IUser,System-String,System-String- 'Definux.Emeraude.Application.Identity.IUserManager.RemoveAuthenticationTokenAsync(Definux.Emeraude.Domain.Entities.IUser,System.String,System.String)')
  - [RemoveClaimAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-RemoveClaimAsync-Definux-Emeraude-Domain-Entities-IUser,System-Security-Claims-Claim- 'Definux.Emeraude.Application.Identity.IUserManager.RemoveClaimAsync(Definux.Emeraude.Domain.Entities.IUser,System.Security.Claims.Claim)')
  - [RemoveClaimsAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-RemoveClaimsAsync-Definux-Emeraude-Domain-Entities-IUser,System-Collections-Generic-IEnumerable{System-Security-Claims-Claim}- 'Definux.Emeraude.Application.Identity.IUserManager.RemoveClaimsAsync(Definux.Emeraude.Domain.Entities.IUser,System.Collections.Generic.IEnumerable{System.Security.Claims.Claim})')
  - [RemoveFromRoleAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-RemoveFromRoleAsync-Definux-Emeraude-Domain-Entities-IUser,System-String- 'Definux.Emeraude.Application.Identity.IUserManager.RemoveFromRoleAsync(Definux.Emeraude.Domain.Entities.IUser,System.String)')
  - [RemoveFromRolesAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-RemoveFromRolesAsync-Definux-Emeraude-Domain-Entities-IUser,System-Collections-Generic-IEnumerable{System-String}- 'Definux.Emeraude.Application.Identity.IUserManager.RemoveFromRolesAsync(Definux.Emeraude.Domain.Entities.IUser,System.Collections.Generic.IEnumerable{System.String})')
  - [RemoveLoginAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-RemoveLoginAsync-Definux-Emeraude-Domain-Entities-IUser,System-String,System-String- 'Definux.Emeraude.Application.Identity.IUserManager.RemoveLoginAsync(Definux.Emeraude.Domain.Entities.IUser,System.String,System.String)')
  - [RemovePasswordAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-RemovePasswordAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.RemovePasswordAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [ReplaceClaimAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-ReplaceClaimAsync-Definux-Emeraude-Domain-Entities-IUser,System-Security-Claims-Claim,System-Security-Claims-Claim- 'Definux.Emeraude.Application.Identity.IUserManager.ReplaceClaimAsync(Definux.Emeraude.Domain.Entities.IUser,System.Security.Claims.Claim,System.Security.Claims.Claim)')
  - [ResetAccessFailedCountAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-ResetAccessFailedCountAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.ResetAccessFailedCountAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [ResetAuthenticatorKeyAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-ResetAuthenticatorKeyAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.ResetAuthenticatorKeyAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [ResetPasswordAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-ResetPasswordAsync-Definux-Emeraude-Domain-Entities-IUser,System-String,System-String- 'Definux.Emeraude.Application.Identity.IUserManager.ResetPasswordAsync(Definux.Emeraude.Domain.Entities.IUser,System.String,System.String)')
  - [SetAuthenticationTokenAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-SetAuthenticationTokenAsync-Definux-Emeraude-Domain-Entities-IUser,System-String,System-String,System-String- 'Definux.Emeraude.Application.Identity.IUserManager.SetAuthenticationTokenAsync(Definux.Emeraude.Domain.Entities.IUser,System.String,System.String,System.String)')
  - [SetEmailAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-SetEmailAsync-Definux-Emeraude-Domain-Entities-IUser,System-String- 'Definux.Emeraude.Application.Identity.IUserManager.SetEmailAsync(Definux.Emeraude.Domain.Entities.IUser,System.String)')
  - [SetLockoutEnabledAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-SetLockoutEnabledAsync-Definux-Emeraude-Domain-Entities-IUser,System-Boolean- 'Definux.Emeraude.Application.Identity.IUserManager.SetLockoutEnabledAsync(Definux.Emeraude.Domain.Entities.IUser,System.Boolean)')
  - [SetLockoutEndDateAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-SetLockoutEndDateAsync-Definux-Emeraude-Domain-Entities-IUser,System-Nullable{System-DateTimeOffset}- 'Definux.Emeraude.Application.Identity.IUserManager.SetLockoutEndDateAsync(Definux.Emeraude.Domain.Entities.IUser,System.Nullable{System.DateTimeOffset})')
  - [SetPhoneNumberAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-SetPhoneNumberAsync-Definux-Emeraude-Domain-Entities-IUser,System-String- 'Definux.Emeraude.Application.Identity.IUserManager.SetPhoneNumberAsync(Definux.Emeraude.Domain.Entities.IUser,System.String)')
  - [SetTwoFactorEnabledAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-SetTwoFactorEnabledAsync-Definux-Emeraude-Domain-Entities-IUser,System-Boolean- 'Definux.Emeraude.Application.Identity.IUserManager.SetTwoFactorEnabledAsync(Definux.Emeraude.Domain.Entities.IUser,System.Boolean)')
  - [UpdateAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-UpdateAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.UpdateAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [UpdateSecurityStampAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-UpdateSecurityStampAsync-Definux-Emeraude-Domain-Entities-IUser- 'Definux.Emeraude.Application.Identity.IUserManager.UpdateSecurityStampAsync(Definux.Emeraude.Domain.Entities.IUser)')
  - [VerifyTwoFactorTokenAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-VerifyTwoFactorTokenAsync-Definux-Emeraude-Domain-Entities-IUser,System-String,System-String- 'Definux.Emeraude.Application.Identity.IUserManager.VerifyTwoFactorTokenAsync(Definux.Emeraude.Domain.Entities.IUser,System.String,System.String)')
  - [VerifyUserTokenAsync()](#M-Definux-Emeraude-Application-Identity-IUserManager-VerifyUserTokenAsync-Definux-Emeraude-Domain-Entities-IUser,System-String,System-String,System-String- 'Definux.Emeraude.Application.Identity.IUserManager.VerifyUserTokenAsync(Definux.Emeraude.Domain.Entities.IUser,System.String,System.String,System.String)')
- [IUserTokensService](#T-Definux-Emeraude-Application-Identity-IUserTokensService 'Definux.Emeraude.Application.Identity.IUserTokensService')
  - [BuildJwtTokenForExternalUserAsync(externalUser)](#M-Definux-Emeraude-Application-Identity-IUserTokensService-BuildJwtTokenForExternalUserAsync-Definux-Emeraude-Application-Identity-IExternalUser- 'Definux.Emeraude.Application.Identity.IUserTokensService.BuildJwtTokenForExternalUserAsync(Definux.Emeraude.Application.Identity.IExternalUser)')
  - [BuildJwtTokenForUserAsync(userId)](#M-Definux-Emeraude-Application-Identity-IUserTokensService-BuildJwtTokenForUserAsync-System-Guid- 'Definux.Emeraude.Application.Identity.IUserTokensService.BuildJwtTokenForUserAsync(System.Guid)')
  - [RefreshJwtTokenAsync(userId,refreshToken)](#M-Definux-Emeraude-Application-Identity-IUserTokensService-RefreshJwtTokenAsync-System-Nullable{System-Guid},System-String- 'Definux.Emeraude.Application.Identity.IUserTokensService.RefreshJwtTokenAsync(System.Nullable{System.Guid},System.String)')
  - [ResetRefreshTokenAsync(userId)](#M-Definux-Emeraude-Application-Identity-IUserTokensService-ResetRefreshTokenAsync-System-Guid- 'Definux.Emeraude.Application.Identity.IUserTokensService.ResetRefreshTokenAsync(System.Guid)')
- [IdentityEventArgs](#T-Definux-Emeraude-Application-EventHandlers-IdentityEventArgs 'Definux.Emeraude.Application.EventHandlers.IdentityEventArgs')
  - [HttpContext](#P-Definux-Emeraude-Application-EventHandlers-IdentityEventArgs-HttpContext 'Definux.Emeraude.Application.EventHandlers.IdentityEventArgs.HttpContext')
  - [UserId](#P-Definux-Emeraude-Application-EventHandlers-IdentityEventArgs-UserId 'Definux.Emeraude.Application.EventHandlers.IdentityEventArgs.UserId')
- [InitFolder](#T-Definux-Emeraude-Application-Files-InitFolder 'Definux.Emeraude.Application.Files.InitFolder')
  - [Children](#P-Definux-Emeraude-Application-Files-InitFolder-Children 'Definux.Emeraude.Application.Files.InitFolder.Children')
  - [Name](#P-Definux-Emeraude-Application-Files-InitFolder-Name 'Definux.Emeraude.Application.Files.InitFolder.Name')
- [LoginCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.Login.LoginCommand')
  - [Email](#P-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommand-Email 'Definux.Emeraude.Application.Requests.Identity.Commands.Login.LoginCommand.Email')
  - [Password](#P-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommand-Password 'Definux.Emeraude.Application.Requests.Identity.Commands.Login.LoginCommand.Password')
- [LoginCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommand-LoginCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.Login.LoginCommand.LoginCommandHandler')
  - [#ctor(userManager,eventManager)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommand-LoginCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-EventHandlers-IIdentityEventManager- 'Definux.Emeraude.Application.Requests.Identity.Commands.Login.LoginCommand.LoginCommandHandler.#ctor(Definux.Emeraude.Application.Identity.IUserManager,Definux.Emeraude.Application.EventHandlers.IIdentityEventManager)')
  - [Handle()](#M-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommand-LoginCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommand,System-Threading-CancellationToken- 'Definux.Emeraude.Application.Requests.Identity.Commands.Login.LoginCommand.LoginCommandHandler.Handle(Definux.Emeraude.Application.Requests.Identity.Commands.Login.LoginCommand,System.Threading.CancellationToken)')
- [LoginCommandValidator](#T-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommandValidator 'Definux.Emeraude.Application.Requests.Identity.Commands.Login.LoginCommandValidator')
  - [#ctor(userManager)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommandValidator-#ctor-Definux-Emeraude-Application-Identity-IUserManager- 'Definux.Emeraude.Application.Requests.Identity.Commands.Login.LoginCommandValidator.#ctor(Definux.Emeraude.Application.Identity.IUserManager)')
- [LoginEventArgs](#T-Definux-Emeraude-Application-EventHandlers-LoginEventArgs 'Definux.Emeraude.Application.EventHandlers.LoginEventArgs')
- [LoginRequestResult](#T-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginRequestResult 'Definux.Emeraude.Application.Requests.Identity.Commands.Login.LoginRequestResult')
  - [Result](#P-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginRequestResult-Result 'Definux.Emeraude.Application.Requests.Identity.Commands.Login.LoginRequestResult.Result')
  - [User](#P-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginRequestResult-User 'Definux.Emeraude.Application.Requests.Identity.Commands.Login.LoginRequestResult.User')
- [LoginWithTwoFactorAuthenticationCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.LoginWithTwoFactorAuthentication.LoginWithTwoFactorAuthenticationCommand')
  - [#ctor(user,code)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationCommand-#ctor-Definux-Emeraude-Domain-Entities-IUser,System-String- 'Definux.Emeraude.Application.Requests.Identity.Commands.LoginWithTwoFactorAuthentication.LoginWithTwoFactorAuthenticationCommand.#ctor(Definux.Emeraude.Domain.Entities.IUser,System.String)')
  - [Code](#P-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationCommand-Code 'Definux.Emeraude.Application.Requests.Identity.Commands.LoginWithTwoFactorAuthentication.LoginWithTwoFactorAuthenticationCommand.Code')
  - [User](#P-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationCommand-User 'Definux.Emeraude.Application.Requests.Identity.Commands.LoginWithTwoFactorAuthentication.LoginWithTwoFactorAuthenticationCommand.User')
- [LoginWithTwoFactorAuthenticationCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationCommand-LoginWithTwoFactorAuthenticationCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.LoginWithTwoFactorAuthentication.LoginWithTwoFactorAuthenticationCommand.LoginWithTwoFactorAuthenticationCommandHandler')
  - [#ctor(userManager)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationCommand-LoginWithTwoFactorAuthenticationCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserManager- 'Definux.Emeraude.Application.Requests.Identity.Commands.LoginWithTwoFactorAuthentication.LoginWithTwoFactorAuthenticationCommand.LoginWithTwoFactorAuthenticationCommandHandler.#ctor(Definux.Emeraude.Application.Identity.IUserManager)')
  - [Handle()](#M-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationCommand-LoginWithTwoFactorAuthenticationCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationCommand,System-Threading-CancellationToken- 'Definux.Emeraude.Application.Requests.Identity.Commands.LoginWithTwoFactorAuthentication.LoginWithTwoFactorAuthenticationCommand.LoginWithTwoFactorAuthenticationCommandHandler.Handle(Definux.Emeraude.Application.Requests.Identity.Commands.LoginWithTwoFactorAuthentication.LoginWithTwoFactorAuthenticationCommand,System.Threading.CancellationToken)')
- [LoginWithTwoFactorAuthenticationCommandValidator](#T-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationCommandValidator 'Definux.Emeraude.Application.Requests.Identity.Commands.LoginWithTwoFactorAuthentication.LoginWithTwoFactorAuthenticationCommandValidator')
  - [#ctor()](#M-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationCommandValidator-#ctor 'Definux.Emeraude.Application.Requests.Identity.Commands.LoginWithTwoFactorAuthentication.LoginWithTwoFactorAuthenticationCommandValidator.#ctor')
- [LoginWithTwoFactorAuthenticationRequestResult](#T-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationRequestResult 'Definux.Emeraude.Application.Requests.Identity.Commands.LoginWithTwoFactorAuthentication.LoginWithTwoFactorAuthenticationRequestResult')
  - [Result](#P-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationRequestResult-Result 'Definux.Emeraude.Application.Requests.Identity.Commands.LoginWithTwoFactorAuthentication.LoginWithTwoFactorAuthenticationRequestResult.Result')
  - [User](#P-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationRequestResult-User 'Definux.Emeraude.Application.Requests.Identity.Commands.LoginWithTwoFactorAuthentication.LoginWithTwoFactorAuthenticationRequestResult.User')
- [PageNotFoundException](#T-Definux-Emeraude-Application-Exceptions-PageNotFoundException 'Definux.Emeraude.Application.Exceptions.PageNotFoundException')
  - [#ctor()](#M-Definux-Emeraude-Application-Exceptions-PageNotFoundException-#ctor 'Definux.Emeraude.Application.Exceptions.PageNotFoundException.#ctor')
- [RefreshAccessTokenCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.RefreshAccessToken.RefreshAccessTokenCommand')
  - [#ctor(userId,refreshToken)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommand-#ctor-System-Nullable{System-Guid},System-String- 'Definux.Emeraude.Application.Requests.Identity.Commands.RefreshAccessToken.RefreshAccessTokenCommand.#ctor(System.Nullable{System.Guid},System.String)')
  - [RefreshToken](#P-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommand-RefreshToken 'Definux.Emeraude.Application.Requests.Identity.Commands.RefreshAccessToken.RefreshAccessTokenCommand.RefreshToken')
  - [UserId](#P-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommand-UserId 'Definux.Emeraude.Application.Requests.Identity.Commands.RefreshAccessToken.RefreshAccessTokenCommand.UserId')
- [RefreshAccessTokenCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommand-RefreshAccessTokenCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.RefreshAccessToken.RefreshAccessTokenCommand.RefreshAccessTokenCommandHandler')
  - [#ctor(userTokensService)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommand-RefreshAccessTokenCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserTokensService- 'Definux.Emeraude.Application.Requests.Identity.Commands.RefreshAccessToken.RefreshAccessTokenCommand.RefreshAccessTokenCommandHandler.#ctor(Definux.Emeraude.Application.Identity.IUserTokensService)')
  - [Handle()](#M-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommand-RefreshAccessTokenCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommand,System-Threading-CancellationToken- 'Definux.Emeraude.Application.Requests.Identity.Commands.RefreshAccessToken.RefreshAccessTokenCommand.RefreshAccessTokenCommandHandler.Handle(Definux.Emeraude.Application.Requests.Identity.Commands.RefreshAccessToken.RefreshAccessTokenCommand,System.Threading.CancellationToken)')
- [RefreshAccessTokenCommandValidator](#T-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommandValidator 'Definux.Emeraude.Application.Requests.Identity.Commands.RefreshAccessToken.RefreshAccessTokenCommandValidator')
  - [#ctor()](#M-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommandValidator-#ctor 'Definux.Emeraude.Application.Requests.Identity.Commands.RefreshAccessToken.RefreshAccessTokenCommandValidator.#ctor')
- [RegisterCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterCommand')
  - [ConfirmedPassword](#P-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand-ConfirmedPassword 'Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterCommand.ConfirmedPassword')
  - [Email](#P-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand-Email 'Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterCommand.Email')
  - [Name](#P-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand-Name 'Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterCommand.Name')
  - [Password](#P-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand-Password 'Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterCommand.Password')
- [RegisterCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand-RegisterCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterCommand.RegisterCommandHandler')
  - [#ctor(userManager,eventManager,urlEncoder,httpContextAccessor,currentLanguageProvider)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand-RegisterCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-EventHandlers-IIdentityEventManager,System-Text-Encodings-Web-UrlEncoder,Microsoft-AspNetCore-Http-IHttpContextAccessor,Definux-Emeraude-Application-Localization-ICurrentLanguageProvider- 'Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterCommand.RegisterCommandHandler.#ctor(Definux.Emeraude.Application.Identity.IUserManager,Definux.Emeraude.Application.EventHandlers.IIdentityEventManager,System.Text.Encodings.Web.UrlEncoder,Microsoft.AspNetCore.Http.IHttpContextAccessor,Definux.Emeraude.Application.Localization.ICurrentLanguageProvider)')
  - [Handle()](#M-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand-RegisterCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand,System-Threading-CancellationToken- 'Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterCommand.RegisterCommandHandler.Handle(Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterCommand,System.Threading.CancellationToken)')
- [RegisterCommandValidator](#T-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommandValidator 'Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterCommandValidator')
  - [#ctor(userManager)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommandValidator-#ctor-Definux-Emeraude-Application-Identity-IUserManager- 'Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterCommandValidator.#ctor(Definux.Emeraude.Application.Identity.IUserManager)')
- [RegisterEventArgs](#T-Definux-Emeraude-Application-EventHandlers-RegisterEventArgs 'Definux.Emeraude.Application.EventHandlers.RegisterEventArgs')
  - [EmailConfirmationLink](#P-Definux-Emeraude-Application-EventHandlers-RegisterEventArgs-EmailConfirmationLink 'Definux.Emeraude.Application.EventHandlers.RegisterEventArgs.EmailConfirmationLink')
- [RegisterRequestResult](#T-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterRequestResult 'Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterRequestResult')
  - [Result](#P-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterRequestResult-Result 'Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterRequestResult.Result')
  - [User](#P-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterRequestResult-User 'Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterRequestResult.User')
- [RemoveExternalLoginProviderCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-RemoveExternalLoginProvider-RemoveExternalLoginProviderCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.RemoveExternalLoginProvider.RemoveExternalLoginProviderCommand')
  - [Password](#P-Definux-Emeraude-Application-Requests-Identity-Commands-RemoveExternalLoginProvider-RemoveExternalLoginProviderCommand-Password 'Definux.Emeraude.Application.Requests.Identity.Commands.RemoveExternalLoginProvider.RemoveExternalLoginProviderCommand.Password')
  - [Provider](#P-Definux-Emeraude-Application-Requests-Identity-Commands-RemoveExternalLoginProvider-RemoveExternalLoginProviderCommand-Provider 'Definux.Emeraude.Application.Requests.Identity.Commands.RemoveExternalLoginProvider.RemoveExternalLoginProviderCommand.Provider')
  - [UserId](#P-Definux-Emeraude-Application-Requests-Identity-Commands-RemoveExternalLoginProvider-RemoveExternalLoginProviderCommand-UserId 'Definux.Emeraude.Application.Requests.Identity.Commands.RemoveExternalLoginProvider.RemoveExternalLoginProviderCommand.UserId')
- [RemoveExternalLoginProviderCommandValidator](#T-Definux-Emeraude-Application-Requests-Identity-Commands-RemoveExternalLoginProvider-RemoveExternalLoginProviderCommandValidator 'Definux.Emeraude.Application.Requests.Identity.Commands.RemoveExternalLoginProvider.RemoveExternalLoginProviderCommandValidator')
  - [#ctor(userManager)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-RemoveExternalLoginProvider-RemoveExternalLoginProviderCommandValidator-#ctor-Definux-Emeraude-Application-Identity-IUserManager- 'Definux.Emeraude.Application.Requests.Identity.Commands.RemoveExternalLoginProvider.RemoveExternalLoginProviderCommandValidator.#ctor(Definux.Emeraude.Application.Identity.IUserManager)')
- [RequestChangeEmailCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.RequestChangeEmail.RequestChangeEmailCommand')
  - [LocalCallbackUrl](#P-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommand-LocalCallbackUrl 'Definux.Emeraude.Application.Requests.Identity.Commands.RequestChangeEmail.RequestChangeEmailCommand.LocalCallbackUrl')
  - [NewEmail](#P-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommand-NewEmail 'Definux.Emeraude.Application.Requests.Identity.Commands.RequestChangeEmail.RequestChangeEmailCommand.NewEmail')
  - [UseLocalization](#P-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommand-UseLocalization 'Definux.Emeraude.Application.Requests.Identity.Commands.RequestChangeEmail.RequestChangeEmailCommand.UseLocalization')
  - [UserId](#P-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommand-UserId 'Definux.Emeraude.Application.Requests.Identity.Commands.RequestChangeEmail.RequestChangeEmailCommand.UserId')
  - [ConfigureCallbackOptions(localCallbackUrl,useLocalization)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommand-ConfigureCallbackOptions-System-String,System-Boolean- 'Definux.Emeraude.Application.Requests.Identity.Commands.RequestChangeEmail.RequestChangeEmailCommand.ConfigureCallbackOptions(System.String,System.Boolean)')
- [RequestChangeEmailCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommand-RequestChangeEmailCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.RequestChangeEmail.RequestChangeEmailCommand.RequestChangeEmailCommandHandler')
  - [#ctor(userManager,logger,currentLanguageProvider,identityEventManager,httpContextAccessor,urlEncoder)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommand-RequestChangeEmailCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-Logger-IEmLogger,Definux-Emeraude-Application-Localization-ICurrentLanguageProvider,Definux-Emeraude-Application-EventHandlers-IIdentityEventManager,Microsoft-AspNetCore-Http-IHttpContextAccessor,System-Text-Encodings-Web-UrlEncoder- 'Definux.Emeraude.Application.Requests.Identity.Commands.RequestChangeEmail.RequestChangeEmailCommand.RequestChangeEmailCommandHandler.#ctor(Definux.Emeraude.Application.Identity.IUserManager,Definux.Emeraude.Application.Logger.IEmLogger,Definux.Emeraude.Application.Localization.ICurrentLanguageProvider,Definux.Emeraude.Application.EventHandlers.IIdentityEventManager,Microsoft.AspNetCore.Http.IHttpContextAccessor,System.Text.Encodings.Web.UrlEncoder)')
  - [Handle()](#M-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommand-RequestChangeEmailCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommand,System-Threading-CancellationToken- 'Definux.Emeraude.Application.Requests.Identity.Commands.RequestChangeEmail.RequestChangeEmailCommand.RequestChangeEmailCommandHandler.Handle(Definux.Emeraude.Application.Requests.Identity.Commands.RequestChangeEmail.RequestChangeEmailCommand,System.Threading.CancellationToken)')
- [RequestChangeEmailCommandValidator](#T-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommandValidator 'Definux.Emeraude.Application.Requests.Identity.Commands.RequestChangeEmail.RequestChangeEmailCommandValidator')
  - [#ctor(userManager)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommandValidator-#ctor-Definux-Emeraude-Application-Identity-IUserManager- 'Definux.Emeraude.Application.Requests.Identity.Commands.RequestChangeEmail.RequestChangeEmailCommandValidator.#ctor(Definux.Emeraude.Application.Identity.IUserManager)')
- [RequestChangeEmailEventArgs](#T-Definux-Emeraude-Application-EventHandlers-RequestChangeEmailEventArgs 'Definux.Emeraude.Application.EventHandlers.RequestChangeEmailEventArgs')
  - [EmailConfirmationLink](#P-Definux-Emeraude-Application-EventHandlers-RequestChangeEmailEventArgs-EmailConfirmationLink 'Definux.Emeraude.Application.EventHandlers.RequestChangeEmailEventArgs.EmailConfirmationLink')
  - [NewEmail](#P-Definux-Emeraude-Application-EventHandlers-RequestChangeEmailEventArgs-NewEmail 'Definux.Emeraude.Application.EventHandlers.RequestChangeEmailEventArgs.NewEmail')
- [RequestValidationBehavior\`2](#T-Definux-Emeraude-Application-Behaviours-RequestValidationBehavior`2 'Definux.Emeraude.Application.Behaviours.RequestValidationBehavior`2')
  - [#ctor(validators)](#M-Definux-Emeraude-Application-Behaviours-RequestValidationBehavior`2-#ctor-System-Collections-Generic-IEnumerable{FluentValidation-IValidator{`0}}- 'Definux.Emeraude.Application.Behaviours.RequestValidationBehavior`2.#ctor(System.Collections.Generic.IEnumerable{FluentValidation.IValidator{`0}})')
  - [Handle()](#M-Definux-Emeraude-Application-Behaviours-RequestValidationBehavior`2-Handle-`0,System-Threading-CancellationToken,MediatR-RequestHandlerDelegate{`1}- 'Definux.Emeraude.Application.Behaviours.RequestValidationBehavior`2.Handle(`0,System.Threading.CancellationToken,MediatR.RequestHandlerDelegate{`1})')
- [ResetPasswordCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword.ResetPasswordCommand')
  - [ConfirmedPassword](#P-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommand-ConfirmedPassword 'Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword.ResetPasswordCommand.ConfirmedPassword')
  - [Email](#P-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommand-Email 'Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword.ResetPasswordCommand.Email')
  - [Password](#P-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommand-Password 'Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword.ResetPasswordCommand.Password')
  - [Token](#P-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommand-Token 'Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword.ResetPasswordCommand.Token')
- [ResetPasswordCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommand-ResetPasswordCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword.ResetPasswordCommand.ResetPasswordCommandHandler')
  - [#ctor(userManager,identityEventManager,urlEncoder,httpContextAccessor,currentLanguageProvider)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommand-ResetPasswordCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-EventHandlers-IIdentityEventManager,System-Text-Encodings-Web-UrlEncoder,Microsoft-AspNetCore-Http-IHttpContextAccessor,Definux-Emeraude-Application-Localization-ICurrentLanguageProvider- 'Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword.ResetPasswordCommand.ResetPasswordCommandHandler.#ctor(Definux.Emeraude.Application.Identity.IUserManager,Definux.Emeraude.Application.EventHandlers.IIdentityEventManager,System.Text.Encodings.Web.UrlEncoder,Microsoft.AspNetCore.Http.IHttpContextAccessor,Definux.Emeraude.Application.Localization.ICurrentLanguageProvider)')
  - [Handle()](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommand-ResetPasswordCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommand,System-Threading-CancellationToken- 'Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword.ResetPasswordCommand.ResetPasswordCommandHandler.Handle(Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword.ResetPasswordCommand,System.Threading.CancellationToken)')
- [ResetPasswordCommandValidator](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommandValidator 'Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword.ResetPasswordCommandValidator')
  - [#ctor()](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommandValidator-#ctor 'Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword.ResetPasswordCommandValidator.#ctor')
- [ResetPasswordEventArgs](#T-Definux-Emeraude-Application-EventHandlers-ResetPasswordEventArgs 'Definux.Emeraude.Application.EventHandlers.ResetPasswordEventArgs')
- [ResetPasswordRequestResult](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordRequestResult 'Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword.ResetPasswordRequestResult')
  - [#ctor(success)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordRequestResult-#ctor-System-Boolean- 'Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword.ResetPasswordRequestResult.#ctor(System.Boolean)')
- [ResetTwoFactorAuthenticationCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ResetTwoFactorAuthentication-ResetTwoFactorAuthenticationCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ResetTwoFactorAuthentication.ResetTwoFactorAuthenticationCommand')
- [ResetTwoFactorAuthenticationCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-RemoveExternalLoginProvider-RemoveExternalLoginProviderCommand-ResetTwoFactorAuthenticationCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.RemoveExternalLoginProvider.RemoveExternalLoginProviderCommand.ResetTwoFactorAuthenticationCommandHandler')
- [ResetTwoFactorAuthenticationCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ResetTwoFactorAuthentication-ResetTwoFactorAuthenticationCommand-ResetTwoFactorAuthenticationCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.ResetTwoFactorAuthentication.ResetTwoFactorAuthenticationCommand.ResetTwoFactorAuthenticationCommandHandler')
  - [#ctor(userManager,logger)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-RemoveExternalLoginProvider-RemoveExternalLoginProviderCommand-ResetTwoFactorAuthenticationCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-Logger-IEmLogger- 'Definux.Emeraude.Application.Requests.Identity.Commands.RemoveExternalLoginProvider.RemoveExternalLoginProviderCommand.ResetTwoFactorAuthenticationCommandHandler.#ctor(Definux.Emeraude.Application.Identity.IUserManager,Definux.Emeraude.Application.Logger.IEmLogger)')
  - [#ctor(userManager,currentUserProvider)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ResetTwoFactorAuthentication-ResetTwoFactorAuthenticationCommand-ResetTwoFactorAuthenticationCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-Identity-ICurrentUserProvider- 'Definux.Emeraude.Application.Requests.Identity.Commands.ResetTwoFactorAuthentication.ResetTwoFactorAuthenticationCommand.ResetTwoFactorAuthenticationCommandHandler.#ctor(Definux.Emeraude.Application.Identity.IUserManager,Definux.Emeraude.Application.Identity.ICurrentUserProvider)')
  - [Handle()](#M-Definux-Emeraude-Application-Requests-Identity-Commands-RemoveExternalLoginProvider-RemoveExternalLoginProviderCommand-ResetTwoFactorAuthenticationCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-RemoveExternalLoginProvider-RemoveExternalLoginProviderCommand,System-Threading-CancellationToken- 'Definux.Emeraude.Application.Requests.Identity.Commands.RemoveExternalLoginProvider.RemoveExternalLoginProviderCommand.ResetTwoFactorAuthenticationCommandHandler.Handle(Definux.Emeraude.Application.Requests.Identity.Commands.RemoveExternalLoginProvider.RemoveExternalLoginProviderCommand,System.Threading.CancellationToken)')
  - [Handle()](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ResetTwoFactorAuthentication-ResetTwoFactorAuthenticationCommand-ResetTwoFactorAuthenticationCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-ResetTwoFactorAuthentication-ResetTwoFactorAuthenticationCommand,System-Threading-CancellationToken- 'Definux.Emeraude.Application.Requests.Identity.Commands.ResetTwoFactorAuthentication.ResetTwoFactorAuthenticationCommand.ResetTwoFactorAuthenticationCommandHandler.Handle(Definux.Emeraude.Application.Requests.Identity.Commands.ResetTwoFactorAuthentication.ResetTwoFactorAuthenticationCommand,System.Threading.CancellationToken)')
- [ResetTwoFactorAuthenticationResult](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ResetTwoFactorAuthentication-ResetTwoFactorAuthenticationResult 'Definux.Emeraude.Application.Requests.Identity.Commands.ResetTwoFactorAuthentication.ResetTwoFactorAuthenticationResult')
  - [#ctor(success)](#M-Definux-Emeraude-Application-Requests-Identity-Commands-ResetTwoFactorAuthentication-ResetTwoFactorAuthenticationResult-#ctor-System-Boolean- 'Definux.Emeraude.Application.Requests.Identity.Commands.ResetTwoFactorAuthentication.ResetTwoFactorAuthenticationResult.#ctor(System.Boolean)')
- [SendEmailResult](#T-Definux-Emeraude-Application-Emails-SendEmailResult 'Definux.Emeraude.Application.Emails.SendEmailResult')
  - [FailedResult](#P-Definux-Emeraude-Application-Emails-SendEmailResult-FailedResult 'Definux.Emeraude.Application.Emails.SendEmailResult.FailedResult')
  - [Success](#P-Definux-Emeraude-Application-Emails-SendEmailResult-Success 'Definux.Emeraude.Application.Emails.SendEmailResult.Success')
  - [SuccessResult](#P-Definux-Emeraude-Application-Emails-SendEmailResult-SuccessResult 'Definux.Emeraude.Application.Emails.SendEmailResult.SuccessResult')
- [SystemFileResult](#T-Definux-Emeraude-Application-Files-SystemFileResult 'Definux.Emeraude.Application.Files.SystemFileResult')
  - [ContentType](#P-Definux-Emeraude-Application-Files-SystemFileResult-ContentType 'Definux.Emeraude.Application.Files.SystemFileResult.ContentType')
  - [Stream](#P-Definux-Emeraude-Application-Files-SystemFileResult-Stream 'Definux.Emeraude.Application.Files.SystemFileResult.Stream')
- [SystemItem](#T-Definux-Emeraude-Application-Files-SystemItem 'Definux.Emeraude.Application.Files.SystemItem')
  - [CreatedOn](#P-Definux-Emeraude-Application-Files-SystemItem-CreatedOn 'Definux.Emeraude.Application.Files.SystemItem.CreatedOn')
  - [FileSize](#P-Definux-Emeraude-Application-Files-SystemItem-FileSize 'Definux.Emeraude.Application.Files.SystemItem.FileSize')
  - [LastModifiedOn](#P-Definux-Emeraude-Application-Files-SystemItem-LastModifiedOn 'Definux.Emeraude.Application.Files.SystemItem.LastModifiedOn')
  - [Name](#P-Definux-Emeraude-Application-Files-SystemItem-Name 'Definux.Emeraude.Application.Files.SystemItem.Name')
  - [Path](#P-Definux-Emeraude-Application-Files-SystemItem-Path 'Definux.Emeraude.Application.Files.SystemItem.Path')
  - [RelativePath](#P-Definux-Emeraude-Application-Files-SystemItem-RelativePath 'Definux.Emeraude.Application.Files.SystemItem.RelativePath')
  - [Type](#P-Definux-Emeraude-Application-Files-SystemItem-Type 'Definux.Emeraude.Application.Files.SystemItem.Type')
- [UploadFileCommand](#T-Definux-Emeraude-Application-Requests-Files-Commands-UploadFile-UploadFileCommand 'Definux.Emeraude.Application.Requests.Files.Commands.UploadFile.UploadFileCommand')
  - [#ctor(formFile)](#M-Definux-Emeraude-Application-Requests-Files-Commands-UploadFile-UploadFileCommand-#ctor-Microsoft-AspNetCore-Http-IFormFile- 'Definux.Emeraude.Application.Requests.Files.Commands.UploadFile.UploadFileCommand.#ctor(Microsoft.AspNetCore.Http.IFormFile)')
  - [#ctor(formFile,saveDirectory,publicRoot)](#M-Definux-Emeraude-Application-Requests-Files-Commands-UploadFile-UploadFileCommand-#ctor-Microsoft-AspNetCore-Http-IFormFile,System-String,System-Boolean- 'Definux.Emeraude.Application.Requests.Files.Commands.UploadFile.UploadFileCommand.#ctor(Microsoft.AspNetCore.Http.IFormFile,System.String,System.Boolean)')
  - [FormFile](#P-Definux-Emeraude-Application-Requests-Files-Commands-UploadFile-UploadFileCommand-FormFile 'Definux.Emeraude.Application.Requests.Files.Commands.UploadFile.UploadFileCommand.FormFile')
  - [PublicRoot](#P-Definux-Emeraude-Application-Requests-Files-Commands-UploadFile-UploadFileCommand-PublicRoot 'Definux.Emeraude.Application.Requests.Files.Commands.UploadFile.UploadFileCommand.PublicRoot')
  - [SaveDirectory](#P-Definux-Emeraude-Application-Requests-Files-Commands-UploadFile-UploadFileCommand-SaveDirectory 'Definux.Emeraude.Application.Requests.Files.Commands.UploadFile.UploadFileCommand.SaveDirectory')
- [UploadFileCommandHandler](#T-Definux-Emeraude-Application-Requests-Files-Commands-UploadFile-UploadFileCommand-UploadFileCommandHandler 'Definux.Emeraude.Application.Requests.Files.Commands.UploadFile.UploadFileCommand.UploadFileCommandHandler')
  - [#ctor(validationProvider,systemFilesService,uploadService)](#M-Definux-Emeraude-Application-Requests-Files-Commands-UploadFile-UploadFileCommand-UploadFileCommandHandler-#ctor-Definux-Emeraude-Application-Files-IFilesValidationProvider,Definux-Emeraude-Application-Files-ISystemFilesService,Definux-Emeraude-Application-Files-IUploadService- 'Definux.Emeraude.Application.Requests.Files.Commands.UploadFile.UploadFileCommand.UploadFileCommandHandler.#ctor(Definux.Emeraude.Application.Files.IFilesValidationProvider,Definux.Emeraude.Application.Files.ISystemFilesService,Definux.Emeraude.Application.Files.IUploadService)')
  - [Handle()](#M-Definux-Emeraude-Application-Requests-Files-Commands-UploadFile-UploadFileCommand-UploadFileCommandHandler-Handle-Definux-Emeraude-Application-Requests-Files-Commands-UploadFile-UploadFileCommand,System-Threading-CancellationToken- 'Definux.Emeraude.Application.Requests.Files.Commands.UploadFile.UploadFileCommand.UploadFileCommandHandler.Handle(Definux.Emeraude.Application.Requests.Files.Commands.UploadFile.UploadFileCommand,System.Threading.CancellationToken)')
- [UploadImageCommand](#T-Definux-Emeraude-Application-Requests-Files-Commands-UploadImage-UploadImageCommand 'Definux.Emeraude.Application.Requests.Files.Commands.UploadImage.UploadImageCommand')
  - [#ctor(formFile)](#M-Definux-Emeraude-Application-Requests-Files-Commands-UploadImage-UploadImageCommand-#ctor-Microsoft-AspNetCore-Http-IFormFile- 'Definux.Emeraude.Application.Requests.Files.Commands.UploadImage.UploadImageCommand.#ctor(Microsoft.AspNetCore.Http.IFormFile)')
  - [FormFile](#P-Definux-Emeraude-Application-Requests-Files-Commands-UploadImage-UploadImageCommand-FormFile 'Definux.Emeraude.Application.Requests.Files.Commands.UploadImage.UploadImageCommand.FormFile')
- [UploadImageCommandHandler](#T-Definux-Emeraude-Application-Requests-Files-Commands-UploadImage-UploadImageCommand-UploadImageCommandHandler 'Definux.Emeraude.Application.Requests.Files.Commands.UploadImage.UploadImageCommand.UploadImageCommandHandler')
  - [#ctor(validationProvider,systemFilesService,uploadService)](#M-Definux-Emeraude-Application-Requests-Files-Commands-UploadImage-UploadImageCommand-UploadImageCommandHandler-#ctor-Definux-Emeraude-Application-Files-IFilesValidationProvider,Definux-Emeraude-Application-Files-ISystemFilesService,Definux-Emeraude-Application-Files-IUploadService- 'Definux.Emeraude.Application.Requests.Files.Commands.UploadImage.UploadImageCommand.UploadImageCommandHandler.#ctor(Definux.Emeraude.Application.Files.IFilesValidationProvider,Definux.Emeraude.Application.Files.ISystemFilesService,Definux.Emeraude.Application.Files.IUploadService)')
  - [Handle()](#M-Definux-Emeraude-Application-Requests-Files-Commands-UploadImage-UploadImageCommand-UploadImageCommandHandler-Handle-Definux-Emeraude-Application-Requests-Files-Commands-UploadImage-UploadImageCommand,System-Threading-CancellationToken- 'Definux.Emeraude.Application.Requests.Files.Commands.UploadImage.UploadImageCommand.UploadImageCommandHandler.Handle(Definux.Emeraude.Application.Requests.Files.Commands.UploadImage.UploadImageCommand,System.Threading.CancellationToken)')
- [UploadResult](#T-Definux-Emeraude-Application-Requests-Files-Commands-Shared-UploadResult 'Definux.Emeraude.Application.Requests.Files.Commands.Shared.UploadResult')
  - [Message](#P-Definux-Emeraude-Application-Requests-Files-Commands-Shared-UploadResult-Message 'Definux.Emeraude.Application.Requests.Files.Commands.Shared.UploadResult.Message')
  - [ResultFileId](#P-Definux-Emeraude-Application-Requests-Files-Commands-Shared-UploadResult-ResultFileId 'Definux.Emeraude.Application.Requests.Files.Commands.Shared.UploadResult.ResultFileId')
  - [Success](#P-Definux-Emeraude-Application-Requests-Files-Commands-Shared-UploadResult-Success 'Definux.Emeraude.Application.Requests.Files.Commands.Shared.UploadResult.Success')
  - [ValidationError](#P-Definux-Emeraude-Application-Requests-Files-Commands-Shared-UploadResult-ValidationError 'Definux.Emeraude.Application.Requests.Files.Commands.Shared.UploadResult.ValidationError')
  - [ErrorResult(errorMessage)](#M-Definux-Emeraude-Application-Requests-Files-Commands-Shared-UploadResult-ErrorResult-System-String- 'Definux.Emeraude.Application.Requests.Files.Commands.Shared.UploadResult.ErrorResult(System.String)')
  - [SuccessResult(tempFileId)](#M-Definux-Emeraude-Application-Requests-Files-Commands-Shared-UploadResult-SuccessResult-System-Int32- 'Definux.Emeraude.Application.Requests.Files.Commands.Shared.UploadResult.SuccessResult(System.Int32)')
  - [ValidationErrorResult(message)](#M-Definux-Emeraude-Application-Requests-Files-Commands-Shared-UploadResult-ValidationErrorResult-System-String- 'Definux.Emeraude.Application.Requests.Files.Commands.Shared.UploadResult.ValidationErrorResult(System.String)')
- [UploadVideoCommand](#T-Definux-Emeraude-Application-Requests-Files-Commands-UploadVideo-UploadVideoCommand 'Definux.Emeraude.Application.Requests.Files.Commands.UploadVideo.UploadVideoCommand')
  - [#ctor(formFile)](#M-Definux-Emeraude-Application-Requests-Files-Commands-UploadVideo-UploadVideoCommand-#ctor-Microsoft-AspNetCore-Http-IFormFile- 'Definux.Emeraude.Application.Requests.Files.Commands.UploadVideo.UploadVideoCommand.#ctor(Microsoft.AspNetCore.Http.IFormFile)')
  - [FormFile](#P-Definux-Emeraude-Application-Requests-Files-Commands-UploadVideo-UploadVideoCommand-FormFile 'Definux.Emeraude.Application.Requests.Files.Commands.UploadVideo.UploadVideoCommand.FormFile')
- [UploadVideoCommandHandler](#T-Definux-Emeraude-Application-Requests-Files-Commands-UploadVideo-UploadVideoCommand-UploadVideoCommandHandler 'Definux.Emeraude.Application.Requests.Files.Commands.UploadVideo.UploadVideoCommand.UploadVideoCommandHandler')
  - [#ctor(validationProvider,systemFilesService,uploadService)](#M-Definux-Emeraude-Application-Requests-Files-Commands-UploadVideo-UploadVideoCommand-UploadVideoCommandHandler-#ctor-Definux-Emeraude-Application-Files-IFilesValidationProvider,Definux-Emeraude-Application-Files-ISystemFilesService,Definux-Emeraude-Application-Files-IUploadService- 'Definux.Emeraude.Application.Requests.Files.Commands.UploadVideo.UploadVideoCommand.UploadVideoCommandHandler.#ctor(Definux.Emeraude.Application.Files.IFilesValidationProvider,Definux.Emeraude.Application.Files.ISystemFilesService,Definux.Emeraude.Application.Files.IUploadService)')
  - [Handle()](#M-Definux-Emeraude-Application-Requests-Files-Commands-UploadVideo-UploadVideoCommand-UploadVideoCommandHandler-Handle-Definux-Emeraude-Application-Requests-Files-Commands-UploadVideo-UploadVideoCommand,System-Threading-CancellationToken- 'Definux.Emeraude.Application.Requests.Files.Commands.UploadVideo.UploadVideoCommand.UploadVideoCommandHandler.Handle(Definux.Emeraude.Application.Requests.Files.Commands.UploadVideo.UploadVideoCommand,System.Threading.CancellationToken)')
- [UserAvatarTypeResult](#T-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserAvatar-UserAvatarTypeResult 'Definux.Emeraude.Application.Requests.Identity.Queries.GetUserAvatar.UserAvatarTypeResult')
  - [IsDefault](#P-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserAvatar-UserAvatarTypeResult-IsDefault 'Definux.Emeraude.Application.Requests.Identity.Queries.GetUserAvatar.UserAvatarTypeResult.IsDefault')
- [UserExternalLoginProvider](#T-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserExternalLoginProviders-UserExternalLoginProvider 'Definux.Emeraude.Application.Requests.Identity.Queries.GetUserExternalLoginProviders.UserExternalLoginProvider')
  - [Provider](#P-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserExternalLoginProviders-UserExternalLoginProvider-Provider 'Definux.Emeraude.Application.Requests.Identity.Queries.GetUserExternalLoginProviders.UserExternalLoginProvider.Provider')
  - [ProviderDisplayName](#P-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserExternalLoginProviders-UserExternalLoginProvider-ProviderDisplayName 'Definux.Emeraude.Application.Requests.Identity.Queries.GetUserExternalLoginProviders.UserExternalLoginProvider.ProviderDisplayName')
- [ValidationException](#T-Definux-Emeraude-Application-Exceptions-ValidationException 'Definux.Emeraude.Application.Exceptions.ValidationException')
  - [#ctor()](#M-Definux-Emeraude-Application-Exceptions-ValidationException-#ctor 'Definux.Emeraude.Application.Exceptions.ValidationException.#ctor')
  - [#ctor(failures)](#M-Definux-Emeraude-Application-Exceptions-ValidationException-#ctor-System-Collections-Generic-IEnumerable{FluentValidation-Results-ValidationFailure}- 'Definux.Emeraude.Application.Exceptions.ValidationException.#ctor(System.Collections.Generic.IEnumerable{FluentValidation.Results.ValidationFailure})')
  - [Failures](#P-Definux-Emeraude-Application-Exceptions-ValidationException-Failures 'Definux.Emeraude.Application.Exceptions.ValidationException.Failures')

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ActivateTwoFactorAuthentication-ActivateTwoFactorAuthenticationCommand'></a>
## ActivateTwoFactorAuthenticationCommand `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ActivateTwoFactorAuthentication

##### Summary

Command for activation two factor authentication for a user.

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ActivateTwoFactorAuthentication-ActivateTwoFactorAuthenticationCommand-#ctor-System-String-'></a>
### #ctor(code) `constructor`

##### Summary

Initializes a new instance of the [ActivateTwoFactorAuthenticationCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ActivateTwoFactorAuthentication-ActivateTwoFactorAuthenticationCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ActivateTwoFactorAuthentication.ActivateTwoFactorAuthenticationCommand') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| code | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-ActivateTwoFactorAuthentication-ActivateTwoFactorAuthenticationCommand-Code'></a>
### Code `property`

##### Summary

Authenticator code.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ActivateTwoFactorAuthentication-ActivateTwoFactorAuthenticationCommand-ActivateTwoFactorAuthenticationCommandHandler'></a>
## ActivateTwoFactorAuthenticationCommandHandler `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ActivateTwoFactorAuthentication.ActivateTwoFactorAuthenticationCommand

##### Summary

Activate two factor authentication command handler.

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ActivateTwoFactorAuthentication-ActivateTwoFactorAuthenticationCommand-ActivateTwoFactorAuthenticationCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-Identity-ICurrentUserProvider-'></a>
### #ctor(userManager,currentUserProvider) `constructor`

##### Summary

Initializes a new instance of the [ActivateTwoFactorAuthenticationCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ActivateTwoFactorAuthentication-ActivateTwoFactorAuthenticationCommand-ActivateTwoFactorAuthenticationCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.ActivateTwoFactorAuthentication.ActivateTwoFactorAuthenticationCommand.ActivateTwoFactorAuthenticationCommandHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userManager | [Definux.Emeraude.Application.Identity.IUserManager](#T-Definux-Emeraude-Application-Identity-IUserManager 'Definux.Emeraude.Application.Identity.IUserManager') |  |
| currentUserProvider | [Definux.Emeraude.Application.Identity.ICurrentUserProvider](#T-Definux-Emeraude-Application-Identity-ICurrentUserProvider 'Definux.Emeraude.Application.Identity.ICurrentUserProvider') |  |

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ActivateTwoFactorAuthentication-ActivateTwoFactorAuthenticationCommand-ActivateTwoFactorAuthenticationCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-ActivateTwoFactorAuthentication-ActivateTwoFactorAuthenticationCommand,System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ActivateTwoFactorAuthentication-ActivateTwoFactorAuthenticationCommandValidator'></a>
## ActivateTwoFactorAuthenticationCommandValidator `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ActivateTwoFactorAuthentication

##### Summary

Validator for activate two factor authentication command.

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ActivateTwoFactorAuthentication-ActivateTwoFactorAuthenticationCommandValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [ActivateTwoFactorAuthenticationCommandValidator](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ActivateTwoFactorAuthentication-ActivateTwoFactorAuthenticationCommandValidator 'Definux.Emeraude.Application.Requests.Identity.Commands.ActivateTwoFactorAuthentication.ActivateTwoFactorAuthenticationCommandValidator') class.

##### Parameters

This constructor has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ActivateTwoFactorAuthentication-ActivateTwoFactorAuthenticationResult'></a>
## ActivateTwoFactorAuthenticationResult `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ActivateTwoFactorAuthentication

##### Summary

Result for two factor authentication request.

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ActivateTwoFactorAuthentication-ActivateTwoFactorAuthenticationResult-#ctor-System-Boolean-'></a>
### #ctor(success) `constructor`

##### Summary

Initializes a new instance of the [ActivateTwoFactorAuthenticationResult](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ActivateTwoFactorAuthentication-ActivateTwoFactorAuthenticationResult 'Definux.Emeraude.Application.Requests.Identity.Commands.ActivateTwoFactorAuthentication.ActivateTwoFactorAuthenticationResult') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| success | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-Definux-Emeraude-Application-Mapping-AssemblyMappingProfile'></a>
## AssemblyMappingProfile `type`

##### Namespace

Definux.Emeraude.Application.Mapping

##### Summary

Abstract assembly mapping profile for registration of all mappings configurations.

<a name='M-Definux-Emeraude-Application-Mapping-AssemblyMappingProfile-#ctor-System-Reflection-Assembly-'></a>
### #ctor(assembly) `constructor`

##### Summary

Initializes a new instance of the [AssemblyMappingProfile](#T-Definux-Emeraude-Application-Mapping-AssemblyMappingProfile 'Definux.Emeraude.Application.Mapping.AssemblyMappingProfile') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| assembly | [System.Reflection.Assembly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.Assembly 'System.Reflection.Assembly') |  |

<a name='T-Definux-Emeraude-Application-Identity-BearerAuthenticationResult'></a>
## BearerAuthenticationResult `type`

##### Namespace

Definux.Emeraude.Application.Identity

##### Summary

Bearer authentication result for API authentication request.

<a name='P-Definux-Emeraude-Application-Identity-BearerAuthenticationResult-FailedResult'></a>
### FailedResult `property`

##### Summary

Static property that returns failed bearer result.

<a name='P-Definux-Emeraude-Application-Identity-BearerAuthenticationResult-JsonWebToken'></a>
### JsonWebToken `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Application-Identity-BearerAuthenticationResult-Message'></a>
### Message `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Application-Identity-BearerAuthenticationResult-RefreshToken'></a>
### RefreshToken `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Application-Identity-BearerAuthenticationResult-Success'></a>
### Success `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Application-Identity-BearerAuthenticationResult-SuccessResult-System-String,System-String-'></a>
### SuccessResult(jsonWebToken,refreshToken) `method`

##### Summary

Static method that returns success bearer result.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| jsonWebToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| refreshToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeEmail-ChangeEmailCommand'></a>
## ChangeEmailCommand `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ChangeEmail

##### Summary

Command that change the email of the specified user.

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeEmail-ChangeEmailCommand-#ctor-System-String,System-String-'></a>
### #ctor(newEmail,token) `constructor`

##### Summary

Initializes a new instance of the [ChangeEmailCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeEmail-ChangeEmailCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeEmail.ChangeEmailCommand') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| newEmail | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| token | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeEmail-ChangeEmailCommand-NewEmail'></a>
### NewEmail `property`

##### Summary

Email of the user.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeEmail-ChangeEmailCommand-Token'></a>
### Token `property`

##### Summary

Confirmation token of the user.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeEmail-ChangeEmailCommand-ChangeEmailCommandHandler'></a>
## ChangeEmailCommandHandler `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ChangeEmail.ChangeEmailCommand

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeEmail-ChangeEmailCommand-ChangeEmailCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-Logger-IEmLogger,Definux-Emeraude-Application-Identity-ICurrentUserProvider-'></a>
### #ctor(userManager,logger,currentUserProvider) `constructor`

##### Summary

Initializes a new instance of the [ChangeEmailCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeEmail-ChangeEmailCommand-ChangeEmailCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeEmail.ChangeEmailCommand.ChangeEmailCommandHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userManager | [Definux.Emeraude.Application.Identity.IUserManager](#T-Definux-Emeraude-Application-Identity-IUserManager 'Definux.Emeraude.Application.Identity.IUserManager') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |
| currentUserProvider | [Definux.Emeraude.Application.Identity.ICurrentUserProvider](#T-Definux-Emeraude-Application-Identity-ICurrentUserProvider 'Definux.Emeraude.Application.Identity.ICurrentUserProvider') |  |

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeEmail-ChangeEmailCommand-ChangeEmailCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeEmail-ChangeEmailCommand,System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeEmail-ChangeEmailCommandValidator'></a>
## ChangeEmailCommandValidator `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ChangeEmail

##### Summary

Validator for [ChangeEmailCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeEmail-ChangeEmailCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeEmail.ChangeEmailCommand').

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeEmail-ChangeEmailCommandValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [ChangeEmailCommandValidator](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeEmail-ChangeEmailCommandValidator 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeEmail.ChangeEmailCommandValidator') class.

##### Parameters

This constructor has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommand'></a>
## ChangePasswordCommand `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword

##### Summary

Command for changing password of a specified user.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommand-ConfirmedPassword'></a>
### ConfirmedPassword `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommand-CurrentPassword'></a>
### CurrentPassword `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommand-NewPassword'></a>
### NewPassword `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommand-UserId'></a>
### UserId `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommand-ChangePasswordCommandHandler'></a>
## ChangePasswordCommandHandler `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword.ChangePasswordCommand

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommand-ChangePasswordCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-Logger-IEmLogger-'></a>
### #ctor(userManager,logger) `constructor`

##### Summary

Initializes a new instance of the [ChangePasswordCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommand-ChangePasswordCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword.ChangePasswordCommand.ChangePasswordCommandHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userManager | [Definux.Emeraude.Application.Identity.IUserManager](#T-Definux-Emeraude-Application-Identity-IUserManager 'Definux.Emeraude.Application.Identity.IUserManager') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommand-ChangePasswordCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommand,System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommandValidator'></a>
## ChangePasswordCommandValidator `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword

##### Summary

Validator of change password command.

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommandValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [ChangePasswordCommandValidator](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordCommandValidator 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword.ChangePasswordCommandValidator') class.

##### Parameters

This constructor has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordRequestResult'></a>
## ChangePasswordRequestResult `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword

##### Summary

Change password command result.

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordRequestResult-#ctor-System-Boolean-'></a>
### #ctor(success) `constructor`

##### Summary

Initializes a new instance of the [ChangePasswordRequestResult](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangePassword-ChangePasswordRequestResult 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword.ChangePasswordRequestResult') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| success | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserAvatar-ChangeUserAvatarCommand'></a>
## ChangeUserAvatarCommand `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserAvatar

##### Summary

Command that change the user avatar.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserAvatar-ChangeUserAvatarCommand-AvatarFileBase64'></a>
### AvatarFileBase64 `property`

##### Summary

User avatar image in base64 format.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserAvatar-ChangeUserAvatarCommand-UserId'></a>
### UserId `property`

##### Summary

Id of the user.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserAvatar-ChangeUserAvatarCommand-ChangeUserAvatarCommandHandler'></a>
## ChangeUserAvatarCommandHandler `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserAvatar.ChangeUserAvatarCommand

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserAvatar-ChangeUserAvatarCommand-ChangeUserAvatarCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserAvatarService,Definux-Emeraude-Application-Logger-IEmLogger-'></a>
### #ctor(userAvatarService,logger) `constructor`

##### Summary

Initializes a new instance of the [ChangeUserAvatarCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserAvatar-ChangeUserAvatarCommand-ChangeUserAvatarCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserAvatar.ChangeUserAvatarCommand.ChangeUserAvatarCommandHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userAvatarService | [Definux.Emeraude.Application.Identity.IUserAvatarService](#T-Definux-Emeraude-Application-Identity-IUserAvatarService 'Definux.Emeraude.Application.Identity.IUserAvatarService') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserAvatar-ChangeUserAvatarCommand-ChangeUserAvatarCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserAvatar-ChangeUserAvatarCommand,System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserName-ChangeUserNameCommand'></a>
## ChangeUserNameCommand `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserName

##### Summary

Command that change the user's name.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserName-ChangeUserNameCommand-NewName'></a>
### NewName `property`

##### Summary

New name of the user.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserName-ChangeUserNameCommand-UserId'></a>
### UserId `property`

##### Summary

Id of the user.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserName-ChangeUserNameCommand-ChangeUserNameCommandHandler'></a>
## ChangeUserNameCommandHandler `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserName.ChangeUserNameCommand

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserName-ChangeUserNameCommand-ChangeUserNameCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-Logger-IEmLogger-'></a>
### #ctor(userManager,logger) `constructor`

##### Summary

Initializes a new instance of the [ChangeUserNameCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserName-ChangeUserNameCommand-ChangeUserNameCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserName.ChangeUserNameCommand.ChangeUserNameCommandHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userManager | [Definux.Emeraude.Application.Identity.IUserManager](#T-Definux-Emeraude-Application-Identity-IUserManager 'Definux.Emeraude.Application.Identity.IUserManager') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserName-ChangeUserNameCommand-ChangeUserNameCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserName-ChangeUserNameCommand,System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserName-ChangeUserNameCommandValidator'></a>
## ChangeUserNameCommandValidator `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserName

##### Summary

Validator for [ChangeUserNameCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserName-ChangeUserNameCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserName.ChangeUserNameCommand').

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserName-ChangeUserNameCommandValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [ChangeUserNameCommandValidator](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ChangeUserName-ChangeUserNameCommandValidator 'Definux.Emeraude.Application.Requests.Identity.Commands.ChangeUserName.ChangeUserNameCommandValidator') class.

##### Parameters

This constructor has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ConfirmEmail-ConfirmEmailCommand'></a>
## ConfirmEmailCommand `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail

##### Summary

Command for confirming email of specified user.

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ConfirmEmail-ConfirmEmailCommand-#ctor-System-String,System-String-'></a>
### #ctor(email,token) `constructor`

##### Summary

Initializes a new instance of the [ConfirmEmailCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ConfirmEmail-ConfirmEmailCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail.ConfirmEmailCommand') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| email | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| token | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-ConfirmEmail-ConfirmEmailCommand-Email'></a>
### Email `property`

##### Summary

Email of the user.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-ConfirmEmail-ConfirmEmailCommand-Token'></a>
### Token `property`

##### Summary

Confirmation token of the user.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ConfirmEmail-ConfirmEmailCommand-ConfirmEmailCommandHandler'></a>
## ConfirmEmailCommandHandler `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail.ConfirmEmailCommand

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ConfirmEmail-ConfirmEmailCommand-ConfirmEmailCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-EventHandlers-IIdentityEventManager-'></a>
### #ctor(userManager,identityEventManager) `constructor`

##### Summary

Initializes a new instance of the [ConfirmEmailCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ConfirmEmail-ConfirmEmailCommand-ConfirmEmailCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail.ConfirmEmailCommand.ConfirmEmailCommandHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userManager | [Definux.Emeraude.Application.Identity.IUserManager](#T-Definux-Emeraude-Application-Identity-IUserManager 'Definux.Emeraude.Application.Identity.IUserManager') |  |
| identityEventManager | [Definux.Emeraude.Application.EventHandlers.IIdentityEventManager](#T-Definux-Emeraude-Application-EventHandlers-IIdentityEventManager 'Definux.Emeraude.Application.EventHandlers.IIdentityEventManager') |  |

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ConfirmEmail-ConfirmEmailCommand-ConfirmEmailCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-ConfirmEmail-ConfirmEmailCommand,System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ConfirmEmail-ConfirmEmailCommandValidator'></a>
## ConfirmEmailCommandValidator `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail

##### Summary

Validator for confirm email command.

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ConfirmEmail-ConfirmEmailCommandValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [ConfirmEmailCommandValidator](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ConfirmEmail-ConfirmEmailCommandValidator 'Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail.ConfirmEmailCommandValidator') class.

##### Parameters

This constructor has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ConfirmEmail-ConfirmEmailRequestResult'></a>
## ConfirmEmailRequestResult `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail

##### Summary

Confirm email command result.

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ConfirmEmail-ConfirmEmailRequestResult-#ctor-System-Boolean-'></a>
### #ctor(success) `constructor`

##### Summary

Initializes a new instance of the [ConfirmEmailRequestResult](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ConfirmEmail-ConfirmEmailRequestResult 'Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail.ConfirmEmailRequestResult') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| success | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-Definux-Emeraude-Application-EventHandlers-ConfirmedEmailEventArgs'></a>
## ConfirmedEmailEventArgs `type`

##### Namespace

Definux.Emeraude.Application.EventHandlers

##### Summary

Event arguments for confirmed email event handler.

<a name='T-Definux-Emeraude-Application-Exceptions-DevelopmentOnlyException'></a>
## DevelopmentOnlyException `type`

##### Namespace

Definux.Emeraude.Application.Exceptions

##### Summary

Custom exception design for protection of actions and resources which must be unavailable outside of development environment.

<a name='M-Definux-Emeraude-Application-Exceptions-DevelopmentOnlyException-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [DevelopmentOnlyException](#T-Definux-Emeraude-Application-Exceptions-DevelopmentOnlyException 'Definux.Emeraude.Application.Exceptions.DevelopmentOnlyException') class.

##### Parameters

This constructor has no parameters.

<a name='M-Definux-Emeraude-Application-Exceptions-DevelopmentOnlyException-#ctor-System-String-'></a>
### #ctor(message) `constructor`

##### Summary

Initializes a new instance of the [DevelopmentOnlyException](#T-Definux-Emeraude-Application-Exceptions-DevelopmentOnlyException 'Definux.Emeraude.Application.Exceptions.DevelopmentOnlyException') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Application-Emails-EmailModel'></a>
## EmailModel `type`

##### Namespace

Definux.Emeraude.Application.Emails

##### Summary

Implementation of model that contains core information about the email instance.

<a name='P-Definux-Emeraude-Application-Emails-EmailModel-Email'></a>
### Email `property`

##### Summary

Receiver email.

<a name='P-Definux-Emeraude-Application-Emails-EmailModel-Name'></a>
### Name `property`

##### Summary

Receiver name.

<a name='P-Definux-Emeraude-Application-Emails-EmailModel-Subject'></a>
### Subject `property`

##### Summary

Email subject.

<a name='T-Definux-Emeraude-Application-Exceptions-EntityNotFoundException'></a>
## EntityNotFoundException `type`

##### Namespace

Definux.Emeraude.Application.Exceptions

##### Summary

Custom exception design for requests that access entity that not exist or not available.

<a name='M-Definux-Emeraude-Application-Exceptions-EntityNotFoundException-#ctor-System-String,System-Guid-'></a>
### #ctor(entity,identifier) `constructor`

##### Summary

Initializes a new instance of the [EntityNotFoundException](#T-Definux-Emeraude-Application-Exceptions-EntityNotFoundException 'Definux.Emeraude.Application.Exceptions.EntityNotFoundException') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entity | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| identifier | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |

<a name='M-Definux-Emeraude-Application-Exceptions-EntityNotFoundException-#ctor-System-String,System-Int32-'></a>
### #ctor(entity,identifier) `constructor`

##### Summary

Initializes a new instance of the [EntityNotFoundException](#T-Definux-Emeraude-Application-Exceptions-EntityNotFoundException 'Definux.Emeraude.Application.Exceptions.EntityNotFoundException') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entity | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| identifier | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Definux-Emeraude-Application-Exceptions-EntityNotFoundException-#ctor-System-String-'></a>
### #ctor(message) `constructor`

##### Summary

Initializes a new instance of the [EntityNotFoundException](#T-Definux-Emeraude-Application-Exceptions-EntityNotFoundException 'Definux.Emeraude.Application.Exceptions.EntityNotFoundException') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationCommand'></a>
## ExternalAuthenticationCommand `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication

##### Summary

Command for external authentication of user.

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationCommand-#ctor-System-Security-Claims-ClaimsPrincipal-'></a>
### #ctor(claimsPrincipal) `constructor`

##### Summary

Initializes a new instance of the [ExternalAuthenticationCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationCommand') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| claimsPrincipal | [System.Security.Claims.ClaimsPrincipal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Claims.ClaimsPrincipal 'System.Security.Claims.ClaimsPrincipal') |  |

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationCommand-#ctor-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationData-'></a>
### #ctor(externalAuthenticationData) `constructor`

##### Summary

Initializes a new instance of the [ExternalAuthenticationCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationCommand') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| externalAuthenticationData | [Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationData](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationData 'Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationData') |  |

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationCommand-ClaimsPrincipal'></a>
### ClaimsPrincipal `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationCommand-ExternalAuthenticationData'></a>
### ExternalAuthenticationData `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationCommand-ExternalProvider'></a>
### ExternalProvider `property`

##### Summary

Name of the target external provider.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationCommand-ExternalAuthenticationCommandHandler'></a>
## ExternalAuthenticationCommandHandler `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationCommand

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationCommand-ExternalAuthenticationCommandHandler-#ctor-Definux-Emeraude-Application-Logger-IEmLogger,Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-Identity-IUserAvatarService,Definux-Emeraude-Application-Identity-IExternalProviderAuthenticatorFactory,Definux-Emeraude-Application-EventHandlers-IIdentityEventManager-'></a>
### #ctor(logger,userManager,userAvatarService,externalProviderAuthenticatorFactory,eventManager) `constructor`

##### Summary

Initializes a new instance of the [ExternalAuthenticationCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationCommand-ExternalAuthenticationCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication.ExternalAuthenticationCommand.ExternalAuthenticationCommandHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |
| userManager | [Definux.Emeraude.Application.Identity.IUserManager](#T-Definux-Emeraude-Application-Identity-IUserManager 'Definux.Emeraude.Application.Identity.IUserManager') |  |
| userAvatarService | [Definux.Emeraude.Application.Identity.IUserAvatarService](#T-Definux-Emeraude-Application-Identity-IUserAvatarService 'Definux.Emeraude.Application.Identity.IUserAvatarService') |  |
| externalProviderAuthenticatorFactory | [Definux.Emeraude.Application.Identity.IExternalProviderAuthenticatorFactory](#T-Definux-Emeraude-Application-Identity-IExternalProviderAuthenticatorFactory 'Definux.Emeraude.Application.Identity.IExternalProviderAuthenticatorFactory') |  |
| eventManager | [Definux.Emeraude.Application.EventHandlers.IIdentityEventManager](#T-Definux-Emeraude-Application-EventHandlers-IIdentityEventManager 'Definux.Emeraude.Application.EventHandlers.IIdentityEventManager') |  |

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationCommand-ExternalAuthenticationCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationCommand,System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationData'></a>
## ExternalAuthenticationData `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationData-AccessToken'></a>
### AccessToken `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationData-Provider'></a>
### Provider `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationRequestResult'></a>
## ExternalAuthenticationRequestResult `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication

##### Summary

Result of external authentication request.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationRequestResult-Result'></a>
### Result `property`

##### Summary

Result of the authentication.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-ExternalAuthentication-ExternalAuthenticationRequestResult-User'></a>
### User `property`

##### Summary

Authenticated user.

<a name='T-Definux-Emeraude-Application-EventHandlers-ExternalLoginEventArgs'></a>
## ExternalLoginEventArgs `type`

##### Namespace

Definux.Emeraude.Application.EventHandlers

##### Summary

Event arguments for external login event handler.

<a name='T-Definux-Emeraude-Application-EventHandlers-ExternalRegisterEventArgs'></a>
## ExternalRegisterEventArgs `type`

##### Namespace

Definux.Emeraude.Application.EventHandlers

##### Summary

Event arguments for external register event handler.

<a name='T-Definux-Emeraude-Application-Files-FileSystemItemType'></a>
## FileSystemItemType `type`

##### Namespace

Definux.Emeraude.Application.Files

##### Summary

Types of file system items.

<a name='F-Definux-Emeraude-Application-Files-FileSystemItemType-File'></a>
### File `constants`

##### Summary

File.

<a name='F-Definux-Emeraude-Application-Files-FileSystemItemType-Folder'></a>
### Folder `constants`

##### Summary

Folder.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommand'></a>
## ForgotPasswordCommand `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword

##### Summary

Command for forgot password request.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommand-Email'></a>
### Email `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommand-ForgotPasswordCommandHandler'></a>
## ForgotPasswordCommandHandler `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword.ForgotPasswordCommand

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommand-ForgotPasswordCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-EventHandlers-IIdentityEventManager,System-Text-Encodings-Web-UrlEncoder,Microsoft-AspNetCore-Http-IHttpContextAccessor,Definux-Emeraude-Application-Localization-ICurrentLanguageProvider-'></a>
### #ctor(userManager,identityEventManager,urlEncoder,httpContextAccessor,currentLanguageProvider) `constructor`

##### Summary

Initializes a new instance of the [ForgotPasswordCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommand-ForgotPasswordCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword.ForgotPasswordCommand.ForgotPasswordCommandHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userManager | [Definux.Emeraude.Application.Identity.IUserManager](#T-Definux-Emeraude-Application-Identity-IUserManager 'Definux.Emeraude.Application.Identity.IUserManager') |  |
| identityEventManager | [Definux.Emeraude.Application.EventHandlers.IIdentityEventManager](#T-Definux-Emeraude-Application-EventHandlers-IIdentityEventManager 'Definux.Emeraude.Application.EventHandlers.IIdentityEventManager') |  |
| urlEncoder | [System.Text.Encodings.Web.UrlEncoder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encodings.Web.UrlEncoder 'System.Text.Encodings.Web.UrlEncoder') |  |
| httpContextAccessor | [Microsoft.AspNetCore.Http.IHttpContextAccessor](#T-Microsoft-AspNetCore-Http-IHttpContextAccessor 'Microsoft.AspNetCore.Http.IHttpContextAccessor') |  |
| currentLanguageProvider | [Definux.Emeraude.Application.Localization.ICurrentLanguageProvider](#T-Definux-Emeraude-Application-Localization-ICurrentLanguageProvider 'Definux.Emeraude.Application.Localization.ICurrentLanguageProvider') |  |

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommand-ForgotPasswordCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommand,System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommandValidator'></a>
## ForgotPasswordCommandValidator `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword

##### Summary

Validator for client forgot password command.

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommandValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [ForgotPasswordCommandValidator](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordCommandValidator 'Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword.ForgotPasswordCommandValidator') class.

##### Parameters

This constructor has no parameters.

<a name='T-Definux-Emeraude-Application-EventHandlers-ForgotPasswordEventArgs'></a>
## ForgotPasswordEventArgs `type`

##### Namespace

Definux.Emeraude.Application.EventHandlers

##### Summary

Event arguments for forgot password event handler.

<a name='P-Definux-Emeraude-Application-EventHandlers-ForgotPasswordEventArgs-ResetPasswordLink'></a>
### ResetPasswordLink `property`

##### Summary

Reset password link.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordRequestResult'></a>
## ForgotPasswordRequestResult `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword

##### Summary

Forgot password command result.

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordRequestResult-#ctor-System-Boolean-'></a>
### #ctor(success) `constructor`

##### Summary

Initializes a new instance of the [ForgotPasswordRequestResult](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ForgotPassword-ForgotPasswordRequestResult 'Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword.ForgotPasswordRequestResult') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| success | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserAvatar-GetUserAvatarQuery'></a>
## GetUserAvatarQuery `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Queries.GetUserAvatar

##### Summary

Query that returns the avatar stream of specified user.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserAvatar-GetUserAvatarQuery-UserId'></a>
### UserId `property`

##### Summary

Id of the user.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserAvatar-GetUserAvatarQuery-GetUserAvatarQueryHandler'></a>
## GetUserAvatarQueryHandler `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Queries.GetUserAvatar.GetUserAvatarQuery

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserAvatar-GetUserAvatarQuery-GetUserAvatarQueryHandler-#ctor-Definux-Emeraude-Application-Files-ISystemFilesService,Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-Identity-IUserAvatarService,Definux-Emeraude-Application-Files-IRootsService,Definux-Emeraude-Application-Logger-IEmLogger-'></a>
### #ctor(systemFilesService,userManager,userAvatarService,rootsService,logger) `constructor`

##### Summary

Initializes a new instance of the [GetUserAvatarQueryHandler](#T-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserAvatar-GetUserAvatarQuery-GetUserAvatarQueryHandler 'Definux.Emeraude.Application.Requests.Identity.Queries.GetUserAvatar.GetUserAvatarQuery.GetUserAvatarQueryHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| systemFilesService | [Definux.Emeraude.Application.Files.ISystemFilesService](#T-Definux-Emeraude-Application-Files-ISystemFilesService 'Definux.Emeraude.Application.Files.ISystemFilesService') |  |
| userManager | [Definux.Emeraude.Application.Identity.IUserManager](#T-Definux-Emeraude-Application-Identity-IUserManager 'Definux.Emeraude.Application.Identity.IUserManager') |  |
| userAvatarService | [Definux.Emeraude.Application.Identity.IUserAvatarService](#T-Definux-Emeraude-Application-Identity-IUserAvatarService 'Definux.Emeraude.Application.Identity.IUserAvatarService') |  |
| rootsService | [Definux.Emeraude.Application.Files.IRootsService](#T-Definux-Emeraude-Application-Files-IRootsService 'Definux.Emeraude.Application.Files.IRootsService') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |

<a name='M-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserAvatar-GetUserAvatarQuery-GetUserAvatarQueryHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserAvatar-GetUserAvatarQuery,System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserAvatar-GetUserAvatarResult'></a>
## GetUserAvatarResult `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Queries.GetUserAvatar

##### Summary

Result of [GetUserAvatarQuery](#T-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserAvatar-GetUserAvatarQuery 'Definux.Emeraude.Application.Requests.Identity.Queries.GetUserAvatar.GetUserAvatarQuery').

<a name='P-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserAvatar-GetUserAvatarResult-Avatar'></a>
### Avatar `property`

##### Summary

Avatar file result.

<a name='M-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserAvatar-GetUserAvatarResult-GetUserAvatarType'></a>
### GetUserAvatarType() `method`

##### Summary

Gets the user avatar type result.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserExternalLoginProviders-GetUserExternalLoginProvidersQuery'></a>
## GetUserExternalLoginProvidersQuery `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Queries.GetUserExternalLoginProviders

##### Summary

Query that returns the specified user external login providers.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserExternalLoginProviders-GetUserExternalLoginProvidersQuery-UserId'></a>
### UserId `property`

##### Summary

Id of the user.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserExternalLoginProviders-GetUserExternalLoginProvidersQuery-GetUserExternalLoginProvidersQueryHandler'></a>
## GetUserExternalLoginProvidersQueryHandler `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Queries.GetUserExternalLoginProviders.GetUserExternalLoginProvidersQuery

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserExternalLoginProviders-GetUserExternalLoginProvidersQuery-GetUserExternalLoginProvidersQueryHandler-#ctor-Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-Logger-IEmLogger-'></a>
### #ctor(userManager,logger) `constructor`

##### Summary

Initializes a new instance of the [GetUserExternalLoginProvidersQueryHandler](#T-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserExternalLoginProviders-GetUserExternalLoginProvidersQuery-GetUserExternalLoginProvidersQueryHandler 'Definux.Emeraude.Application.Requests.Identity.Queries.GetUserExternalLoginProviders.GetUserExternalLoginProvidersQuery.GetUserExternalLoginProvidersQueryHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userManager | [Definux.Emeraude.Application.Identity.IUserManager](#T-Definux-Emeraude-Application-Identity-IUserManager 'Definux.Emeraude.Application.Identity.IUserManager') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |

<a name='M-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserExternalLoginProviders-GetUserExternalLoginProvidersQuery-GetUserExternalLoginProvidersQueryHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserExternalLoginProviders-GetUserExternalLoginProvidersQuery,System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserExternalLoginProviders-GetUserExternalLoginProvidersResult'></a>
## GetUserExternalLoginProvidersResult `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Queries.GetUserExternalLoginProviders

##### Summary

Result of [GetUserExternalLoginProvidersQuery](#T-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserExternalLoginProviders-GetUserExternalLoginProvidersQuery 'Definux.Emeraude.Application.Requests.Identity.Queries.GetUserExternalLoginProviders.GetUserExternalLoginProvidersQuery').

<a name='M-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserExternalLoginProviders-GetUserExternalLoginProvidersResult-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [GetUserExternalLoginProvidersResult](#T-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserExternalLoginProviders-GetUserExternalLoginProvidersResult 'Definux.Emeraude.Application.Requests.Identity.Queries.GetUserExternalLoginProviders.GetUserExternalLoginProvidersResult') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserExternalLoginProviders-GetUserExternalLoginProvidersResult-Providers'></a>
### Providers `property`

##### Summary

Collection of user external login providers.

<a name='T-Definux-Emeraude-Application-Persistence-IApplicationDatabaseInitializer'></a>
## IApplicationDatabaseInitializer `type`

##### Namespace

Definux.Emeraude.Application.Persistence

##### Summary

Definition of [IDatabaseInitializer](#T-Definux-Emeraude-Interfaces-Services-IDatabaseInitializer 'Definux.Emeraude.Interfaces.Services.IDatabaseInitializer') for the default application data.

<a name='T-Definux-Emeraude-Application-EventHandlers-IConfirmedEmailEventHandler'></a>
## IConfirmedEmailEventHandler `type`

##### Namespace

Definux.Emeraude.Application.EventHandlers

##### Summary

Event handler that handle succeeded confirmed email request.

<a name='T-Definux-Emeraude-Application-Localization-ICurrentLanguageProvider'></a>
## ICurrentLanguageProvider `type`

##### Namespace

Definux.Emeraude.Application.Localization

##### Summary

Helper service accessor that provides the language extracted from the current request.

<a name='M-Definux-Emeraude-Application-Localization-ICurrentLanguageProvider-GetCurrentLanguage'></a>
### GetCurrentLanguage() `method`

##### Summary

Returns current request language.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Localization-ICurrentLanguageProvider-GetCurrentLanguageAsync'></a>
### GetCurrentLanguageAsync() `method`

##### Summary

Returns current request language.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-Identity-ICurrentUserProvider'></a>
## ICurrentUserProvider `type`

##### Namespace

Definux.Emeraude.Application.Identity

##### Summary

Helper accessor service that provides the identity user for the current request.

<a name='P-Definux-Emeraude-Application-Identity-ICurrentUserProvider-CurrentUserId'></a>
### CurrentUserId `property`

##### Summary

Current user id.

<a name='M-Definux-Emeraude-Application-Identity-ICurrentUserProvider-GetCurrentUserAsync'></a>
### GetCurrentUserAsync() `method`

##### Summary

Returns current request user.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-Persistence-IDatabaseContext'></a>
## IDatabaseContext `type`

##### Namespace

Definux.Emeraude.Application.Persistence

##### Summary

Database context interface of Emeraude application that contains main functions of [DbContext](#T-Microsoft-EntityFrameworkCore-DbContext 'Microsoft.EntityFrameworkCore.DbContext').

<a name='M-Definux-Emeraude-Application-Persistence-IDatabaseContext-SaveChanges'></a>
### SaveChanges() `method`

##### Summary



##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Persistence-IDatabaseContext-SaveChanges-System-Boolean-'></a>
### SaveChanges() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Persistence-IDatabaseContext-SaveChangesAsync-System-Boolean,System-Threading-CancellationToken-'></a>
### SaveChangesAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Persistence-IDatabaseContext-SaveChangesAsync-System-Threading-CancellationToken-'></a>
### SaveChangesAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Persistence-IDatabaseContext-Set``1'></a>
### Set\`\`1() `method`

##### Summary

Creates a Microsoft.EntityFrameworkCore.DbSet\`1 that can be used to query and save instances of TEntity.

##### Returns



##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | The type of entity for which a set should be returned. |

<a name='T-Definux-Emeraude-Application-Persistence-IDatabaseInitializerManager'></a>
## IDatabaseInitializerManager `type`

##### Namespace

Definux.Emeraude.Application.Persistence

##### Summary

Database initializer manager that load and trigger all database initializers for the application.

<a name='M-Definux-Emeraude-Application-Persistence-IDatabaseInitializerManager-LoadDatabaseInitializers-System-Type[]-'></a>
### LoadDatabaseInitializers(initializersTypes) `method`

##### Summary

Load database initializers types. Their execution is in the order of their adding.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| initializersTypes | [System.Type[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type[] 'System.Type[]') |  |

<a name='T-Definux-Emeraude-Application-Persistence-IEmContext'></a>
## IEmContext `type`

##### Namespace

Definux.Emeraude.Application.Persistence

##### Summary

Main database context of Emeraude application.

<a name='M-Definux-Emeraude-Application-Persistence-IEmContext-GetContextType'></a>
### GetContextType() `method`

##### Summary

Method that returns the type of the context.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-Localization-IEmLocalizer'></a>
## IEmLocalizer `type`

##### Namespace

Definux.Emeraude.Application.Localization

##### Summary

Service that provide translation functionality by using current language based on the route.

<a name='M-Definux-Emeraude-Application-Localization-IEmLocalizer-GetStaticContent-System-String,System-String-'></a>
### GetStaticContent(key,languageCode) `method`

##### Summary

Get static content by using the specified language.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| languageCode | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Application-Localization-IEmLocalizer-GetStaticContentAsync-System-String,System-String-'></a>
### GetStaticContentAsync(key,languageCode) `method`

##### Summary

Get static content by using the specified language (async execution).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| languageCode | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Application-Localization-IEmLocalizer-TranslateKey-System-String,System-String-'></a>
### TranslateKey(key,languageCode) `method`

##### Summary

Translate key by using the specified language.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| languageCode | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Application-Localization-IEmLocalizer-TranslateKeyAsync-System-String,System-String-'></a>
### TranslateKeyAsync(key,languageCode) `method`

##### Summary

Translate key by using the specified language (async execution).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| languageCode | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Application-Logger-IEmLogger'></a>
## IEmLogger `type`

##### Namespace

Definux.Emeraude.Application.Logger

##### Summary

Emeraude default logger.

<a name='M-Definux-Emeraude-Application-Logger-IEmLogger-LogActivity-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext,System-Boolean-'></a>
### LogActivity(context,hideParameters) `method`

##### Summary

Register information about current request without saving.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext](#T-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext 'Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext') |  |
| hideParameters | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='M-Definux-Emeraude-Application-Logger-IEmLogger-LogEmailAsync-System-String,System-String,System-String,System-String,System-Boolean-'></a>
### LogEmailAsync(emailAddress,receiver,subject,body,sent) `method`

##### Summary

Save information about sent/unsent email.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| emailAddress | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| receiver | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| subject | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| sent | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-Definux-Emeraude-Application-Emails-IEmailRenderer'></a>
## IEmailRenderer `type`

##### Namespace

Definux.Emeraude.Application.Emails

##### Summary

Service that provides renderer that use Razor for generate email body.

<a name='M-Definux-Emeraude-Application-Emails-IEmailRenderer-RenderToStringAsync-System-String,Definux-Emeraude-Application-Emails-EmailModel-'></a>
### RenderToStringAsync(templateName,model) `method`

##### Summary

Render email HTML body via provided template name and Email model.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| templateName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| model | [Definux.Emeraude.Application.Emails.EmailModel](#T-Definux-Emeraude-Application-Emails-EmailModel 'Definux.Emeraude.Application.Emails.EmailModel') |  |

<a name='T-Definux-Emeraude-Application-Emails-IEmailSender'></a>
## IEmailSender `type`

##### Namespace

Definux.Emeraude.Application.Emails

##### Summary

Service which gives methods for sending emails.

<a name='M-Definux-Emeraude-Application-Emails-IEmailSender-SendEmailAsync-System-String,Definux-Emeraude-Application-Emails-EmailModel-'></a>
### SendEmailAsync(templateName,model) `method`

##### Summary

Method that send email by Razor template name and [EmailModel](#T-Definux-Emeraude-Application-Emails-EmailModel 'Definux.Emeraude.Application.Emails.EmailModel').

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| templateName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| model | [Definux.Emeraude.Application.Emails.EmailModel](#T-Definux-Emeraude-Application-Emails-EmailModel 'Definux.Emeraude.Application.Emails.EmailModel') |  |

<a name='T-Definux-Emeraude-Application-EventHandlers-IExternalLoginEventHandler'></a>
## IExternalLoginEventHandler `type`

##### Namespace

Definux.Emeraude.Application.EventHandlers

##### Summary

Event handler that handle succeeded external login request.

<a name='T-Definux-Emeraude-Application-Identity-IExternalProviderAuthenticator'></a>
## IExternalProviderAuthenticator `type`

##### Namespace

Definux.Emeraude.Application.Identity

##### Summary

Provides external provider authenticator for registration and consuming external authentication services.

<a name='P-Definux-Emeraude-Application-Identity-IExternalProviderAuthenticator-Name'></a>
### Name `property`

##### Summary

Gets the external provider name.

<a name='M-Definux-Emeraude-Application-Identity-IExternalProviderAuthenticator-GetExternalUserAsync-System-Security-Claims-ClaimsPrincipal-'></a>
### GetExternalUserAsync(principal) `method`

##### Summary

Gets external user stored in the claims principal of the request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| principal | [System.Security.Claims.ClaimsPrincipal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Claims.ClaimsPrincipal 'System.Security.Claims.ClaimsPrincipal') |  |

<a name='M-Definux-Emeraude-Application-Identity-IExternalProviderAuthenticator-GetExternalUserAsync-System-String,System-String-'></a>
### GetExternalUserAsync(provider,accessToken) `method`

##### Summary

Gets external user based on the provider name and its provided access token.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| provider | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Application-Identity-IExternalProviderAuthenticator-RegisterAuthenticator-Microsoft-AspNetCore-Authentication-AuthenticationBuilder-'></a>
### RegisterAuthenticator(builder) `method`

##### Summary

Register authenticator into the authentication settings.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Authentication.AuthenticationBuilder](#T-Microsoft-AspNetCore-Authentication-AuthenticationBuilder 'Microsoft.AspNetCore.Authentication.AuthenticationBuilder') |  |

<a name='T-Definux-Emeraude-Application-Identity-IExternalProviderAuthenticatorFactory'></a>
## IExternalProviderAuthenticatorFactory `type`

##### Namespace

Definux.Emeraude.Application.Identity

##### Summary

Provides factory for getting an external provider authenticator.

<a name='P-Definux-Emeraude-Application-Identity-IExternalProviderAuthenticatorFactory-Providers'></a>
### Providers `property`

##### Summary

Collection of all external providers.

<a name='M-Definux-Emeraude-Application-Identity-IExternalProviderAuthenticatorFactory-ContainsProvider-System-String-'></a>
### ContainsProvider(externalProvider) `method`

##### Summary

Returns boolean value that indicates whether the external provider is available or not.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| externalProvider | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Application-Identity-IExternalProviderAuthenticatorFactory-GetAuthenticator-System-String-'></a>
### GetAuthenticator(externalProvider) `method`

##### Summary

Returns external provider authenticator by specified provider name.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| externalProvider | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Application-EventHandlers-IExternalRegisterEventHandler'></a>
## IExternalRegisterEventHandler `type`

##### Namespace

Definux.Emeraude.Application.EventHandlers

##### Summary

Event handler that handle succeeded external register request.

<a name='T-Definux-Emeraude-Application-Identity-IExternalUser'></a>
## IExternalUser `type`

##### Namespace

Definux.Emeraude.Application.Identity

##### Summary

Interface of external user definition.

<a name='P-Definux-Emeraude-Application-Identity-IExternalUser-EmailAddress'></a>
### EmailAddress `property`

##### Summary

Email address of the user.

<a name='P-Definux-Emeraude-Application-Identity-IExternalUser-FirstName'></a>
### FirstName `property`

##### Summary

First name of the user.

<a name='P-Definux-Emeraude-Application-Identity-IExternalUser-Id'></a>
### Id `property`

##### Summary

Identifier of the user.

<a name='P-Definux-Emeraude-Application-Identity-IExternalUser-LastName'></a>
### LastName `property`

##### Summary

Last name of the user.

<a name='P-Definux-Emeraude-Application-Identity-IExternalUser-Name'></a>
### Name `property`

##### Summary

Name of the user.

<a name='P-Definux-Emeraude-Application-Identity-IExternalUser-PictureUrl'></a>
### PictureUrl `property`

##### Summary

Picture of the user.

<a name='P-Definux-Emeraude-Application-Identity-IExternalUser-Provider'></a>
### Provider `property`

##### Summary

External provider name.

<a name='T-Definux-Emeraude-Application-Files-IFilesValidationProvider'></a>
## IFilesValidationProvider `type`

##### Namespace

Definux.Emeraude.Application.Files

##### Summary

Provider service of file validators.

<a name='M-Definux-Emeraude-Application-Files-IFilesValidationProvider-ValidateFormFile-Microsoft-AspNetCore-Http-IFormFile,System-Collections-Generic-List{Definux-Utilities-Enumerations-FileExtensions},System-Collections-Generic-List{System-String},System-Int64-'></a>
### ValidateFormFile(formFile,customFileExtensions,customMimeTypes,customMaxFileSize) `method`

##### Summary

Validate file by default or custom criteria.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| formFile | [Microsoft.AspNetCore.Http.IFormFile](#T-Microsoft-AspNetCore-Http-IFormFile 'Microsoft.AspNetCore.Http.IFormFile') |  |
| customFileExtensions | [System.Collections.Generic.List{Definux.Utilities.Enumerations.FileExtensions}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{Definux.Utilities.Enumerations.FileExtensions}') |  |
| customMimeTypes | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') |  |
| customMaxFileSize | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |

<a name='M-Definux-Emeraude-Application-Files-IFilesValidationProvider-ValidateFormImageFile-Microsoft-AspNetCore-Http-IFormFile,System-Collections-Generic-List{Definux-Utilities-Enumerations-FileExtensions},System-Collections-Generic-List{System-String},System-Int64-'></a>
### ValidateFormImageFile(formFile,customFileExtensions,customMimeTypes,customMaxFileSize) `method`

##### Summary

Validate image by default or custom criteria.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| formFile | [Microsoft.AspNetCore.Http.IFormFile](#T-Microsoft-AspNetCore-Http-IFormFile 'Microsoft.AspNetCore.Http.IFormFile') |  |
| customFileExtensions | [System.Collections.Generic.List{Definux.Utilities.Enumerations.FileExtensions}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{Definux.Utilities.Enumerations.FileExtensions}') |  |
| customMimeTypes | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') |  |
| customMaxFileSize | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |

<a name='M-Definux-Emeraude-Application-Files-IFilesValidationProvider-ValidateFormVideoFile-Microsoft-AspNetCore-Http-IFormFile,System-Collections-Generic-List{Definux-Utilities-Enumerations-FileExtensions},System-Collections-Generic-List{System-String},System-Int64-'></a>
### ValidateFormVideoFile(formFile,customFileExtensions,customMimeTypes,customMaxFileSize) `method`

##### Summary

Validate video by default or custom criteria.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| formFile | [Microsoft.AspNetCore.Http.IFormFile](#T-Microsoft-AspNetCore-Http-IFormFile 'Microsoft.AspNetCore.Http.IFormFile') |  |
| customFileExtensions | [System.Collections.Generic.List{Definux.Utilities.Enumerations.FileExtensions}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{Definux.Utilities.Enumerations.FileExtensions}') |  |
| customMimeTypes | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') |  |
| customMaxFileSize | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |

<a name='T-Definux-Emeraude-Application-Files-IFoldersInitializer'></a>
## IFoldersInitializer `type`

##### Namespace

Definux.Emeraude.Application.Files

##### Summary

Service that manages the project structure folders of the application.

<a name='M-Definux-Emeraude-Application-Files-IFoldersInitializer-InitFoldersAsync'></a>
### InitFoldersAsync() `method`

##### Summary

Creates all folders that don't exist in the application.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-EventHandlers-IForgotPasswordEventHandler'></a>
## IForgotPasswordEventHandler `type`

##### Namespace

Definux.Emeraude.Application.EventHandlers

##### Summary

Event handler that handle succeeded forgot password request.

<a name='T-Definux-Emeraude-Application-EventHandlers-IIdentityEventHandler`1'></a>
## IIdentityEventHandler\`1 `type`

##### Namespace

Definux.Emeraude.Application.EventHandlers

##### Summary

Event handler that handle succeeded authentication request.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TIdentityEventArgs | Event args of the handler. |

<a name='M-Definux-Emeraude-Application-EventHandlers-IIdentityEventHandler`1-HandleAsync-`0-'></a>
### HandleAsync(args) `method`

##### Summary

Method that handles succeeded identity request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [\`0](#T-`0 '`0') |  |

<a name='T-Definux-Emeraude-Application-EventHandlers-IIdentityEventManager'></a>
## IIdentityEventManager `type`

##### Namespace

Definux.Emeraude.Application.EventHandlers

##### Summary

Event manager that trigger all identity related events on successfull execution of authentication operation.

<a name='M-Definux-Emeraude-Application-EventHandlers-IIdentityEventManager-TriggerConfirmedEmailEventAsync-System-Guid-'></a>
### TriggerConfirmedEmailEventAsync(userId) `method`

##### Summary

Trigger [IConfirmedEmailEventHandler](#T-Definux-Emeraude-Application-EventHandlers-IConfirmedEmailEventHandler 'Definux.Emeraude.Application.EventHandlers.IConfirmedEmailEventHandler').

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |

<a name='M-Definux-Emeraude-Application-EventHandlers-IIdentityEventManager-TriggerExternalLoginEventAsync-System-Guid-'></a>
### TriggerExternalLoginEventAsync(userId) `method`

##### Summary

Trigger [IExternalLoginEventHandler](#T-Definux-Emeraude-Application-EventHandlers-IExternalLoginEventHandler 'Definux.Emeraude.Application.EventHandlers.IExternalLoginEventHandler').

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |

<a name='M-Definux-Emeraude-Application-EventHandlers-IIdentityEventManager-TriggerExternalRegisterEventAsync-System-Guid-'></a>
### TriggerExternalRegisterEventAsync(userId) `method`

##### Summary

Trigger [IExternalRegisterEventHandler](#T-Definux-Emeraude-Application-EventHandlers-IExternalRegisterEventHandler 'Definux.Emeraude.Application.EventHandlers.IExternalRegisterEventHandler').

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |

<a name='M-Definux-Emeraude-Application-EventHandlers-IIdentityEventManager-TriggerForgotPasswordEventAsync-System-Guid,System-String-'></a>
### TriggerForgotPasswordEventAsync(userId,resetPasswordLink) `method`

##### Summary

Trigger [IForgotPasswordEventHandler](#T-Definux-Emeraude-Application-EventHandlers-IForgotPasswordEventHandler 'Definux.Emeraude.Application.EventHandlers.IForgotPasswordEventHandler').

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |
| resetPasswordLink | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Application-EventHandlers-IIdentityEventManager-TriggerLoginEventAsync-System-Guid-'></a>
### TriggerLoginEventAsync(userId) `method`

##### Summary

Trigger [ILoginEventHandler](#T-Definux-Emeraude-Application-EventHandlers-ILoginEventHandler 'Definux.Emeraude.Application.EventHandlers.ILoginEventHandler').

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |

<a name='M-Definux-Emeraude-Application-EventHandlers-IIdentityEventManager-TriggerRegisterEventAsync-System-Guid,System-String-'></a>
### TriggerRegisterEventAsync(userId,confirmationLink) `method`

##### Summary

Trigger [IRegisterEventHandler](#T-Definux-Emeraude-Application-EventHandlers-IRegisterEventHandler 'Definux.Emeraude.Application.EventHandlers.IRegisterEventHandler').

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |
| confirmationLink | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Application-EventHandlers-IIdentityEventManager-TriggerRequestChangeEmailEventAsync-System-Guid,System-String,System-String-'></a>
### TriggerRequestChangeEmailEventAsync(userId,newEmail,changeEmailConfirmationLink) `method`

##### Summary

Trigger [IRequestChangeEmailEventHandler](#T-Definux-Emeraude-Application-EventHandlers-IRequestChangeEmailEventHandler 'Definux.Emeraude.Application.EventHandlers.IRequestChangeEmailEventHandler').

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |
| newEmail | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| changeEmailConfirmationLink | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Application-EventHandlers-IIdentityEventManager-TriggerResetPasswordEventAsync-System-Guid-'></a>
### TriggerResetPasswordEventAsync(userId) `method`

##### Summary

Trigger [IResetPasswordEventHandler](#T-Definux-Emeraude-Application-EventHandlers-IResetPasswordEventHandler 'Definux.Emeraude.Application.EventHandlers.IResetPasswordEventHandler').

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |

<a name='T-Definux-Emeraude-Application-Localization-ILanguageStore'></a>
## ILanguageStore `type`

##### Namespace

Definux.Emeraude.Application.Localization

##### Summary

Storage for all localization data - languages, translations.

<a name='M-Definux-Emeraude-Application-Localization-ILanguageStore-GetAllLanguageCodes'></a>
### GetAllLanguageCodes() `method`

##### Summary

Get all available language codes.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Localization-ILanguageStore-GetAllLanguageCodesAsync'></a>
### GetAllLanguageCodesAsync() `method`

##### Summary

Get all available language codes (async execution).

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Localization-ILanguageStore-GetDefaultLanguage'></a>
### GetDefaultLanguage() `method`

##### Summary

Get default language from the available ones.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Localization-ILanguageStore-GetDefaultLanguageAsync'></a>
### GetDefaultLanguageAsync() `method`

##### Summary

Get default language (async execution) from the available ones.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Localization-ILanguageStore-GetLanguageTranslationDictionary-System-Int32-'></a>
### GetLanguageTranslationDictionary(languageId) `method`

##### Summary

Get all translations for specific language in dictionary.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| languageId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Definux-Emeraude-Application-Localization-ILanguageStore-GetLanguages'></a>
### GetLanguages() `method`

##### Summary

Get all available languages.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Localization-ILanguageStore-GetLanguagesAsync'></a>
### GetLanguagesAsync() `method`

##### Summary

Get all available languages (async execution).

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Localization-ILanguageStore-GetTranslationsKeys'></a>
### GetTranslationsKeys() `method`

##### Summary

Get all translation keys.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-Localization-ILocalizationContext'></a>
## ILocalizationContext `type`

##### Namespace

Definux.Emeraude.Application.Localization

##### Summary

Database context for managing localization resources of the application.

<a name='P-Definux-Emeraude-Application-Localization-ILocalizationContext-ContentKeys'></a>
### ContentKeys `property`

##### Summary

Static content keys.

<a name='P-Definux-Emeraude-Application-Localization-ILocalizationContext-Keys'></a>
### Keys `property`

##### Summary

Translation keys.

<a name='P-Definux-Emeraude-Application-Localization-ILocalizationContext-Languages'></a>
### Languages `property`

##### Summary

Application languages.

<a name='P-Definux-Emeraude-Application-Localization-ILocalizationContext-StaticContent'></a>
### StaticContent `property`

##### Summary

Static content items.

<a name='P-Definux-Emeraude-Application-Localization-ILocalizationContext-Values'></a>
### Values `property`

##### Summary

Translation values.

<a name='T-Definux-Emeraude-Application-Logger-ILoggerContext'></a>
## ILoggerContext `type`

##### Namespace

Definux.Emeraude.Application.Logger

##### Summary

Context that contains all logs saved from the system.

<a name='P-Definux-Emeraude-Application-Logger-ILoggerContext-ActivityLogs'></a>
### ActivityLogs `property`

##### Summary

Logs of all requests and user actions.

<a name='P-Definux-Emeraude-Application-Logger-ILoggerContext-EmailLogs'></a>
### EmailLogs `property`

##### Summary

Logs of all sent and unsent emails.

<a name='P-Definux-Emeraude-Application-Logger-ILoggerContext-ErrorLogs'></a>
### ErrorLogs `property`

##### Summary

Logs of all errors and exceptions.

<a name='P-Definux-Emeraude-Application-Logger-ILoggerContext-TempFileLogs'></a>
### TempFileLogs `property`

##### Summary

Logs of all uploaded files.

<a name='T-Definux-Emeraude-Application-EventHandlers-ILoginEventHandler'></a>
## ILoginEventHandler `type`

##### Namespace

Definux.Emeraude.Application.EventHandlers

##### Summary

Event handler that handle succeeded login request.

<a name='T-Definux-Emeraude-Application-Mapping-IMapFrom`1'></a>
## IMapFrom\`1 `type`

##### Namespace

Definux.Emeraude.Application.Mapping

##### Summary

Auto configure mapping for specified mapping object with implemented entity.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | Mapping object. |

<a name='M-Definux-Emeraude-Application-Mapping-IMapFrom`1-Mapping-AutoMapper-Profile-'></a>
### Mapping(profile) `method`

##### Summary

Configure mapping for mapping object with implemented entity.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| profile | [AutoMapper.Profile](#T-AutoMapper-Profile 'AutoMapper.Profile') |  |

<a name='T-Definux-Emeraude-Application-EventHandlers-IRegisterEventHandler'></a>
## IRegisterEventHandler `type`

##### Namespace

Definux.Emeraude.Application.EventHandlers

##### Summary

Event handler that handle succeeded register request.

<a name='T-Definux-Emeraude-Application-EventHandlers-IRequestChangeEmailEventHandler'></a>
## IRequestChangeEmailEventHandler `type`

##### Namespace

Definux.Emeraude.Application.EventHandlers

##### Summary

Event handler that handle request for change user email.

<a name='T-Definux-Emeraude-Application-EventHandlers-IResetPasswordEventHandler'></a>
## IResetPasswordEventHandler `type`

##### Namespace

Definux.Emeraude.Application.EventHandlers

##### Summary

Event handler that handle succeeded reset password request.

<a name='T-Definux-Emeraude-Application-Identity-IRoleManager'></a>
## IRoleManager `type`

##### Namespace

Definux.Emeraude.Application.Identity

##### Summary

Emeraude role manager service.

<a name='M-Definux-Emeraude-Application-Identity-IRoleManager-AssignRolesToUserAsync-Definux-Emeraude-Domain-Entities-IUser,System-Collections-Generic-IEnumerable{System-Guid}-'></a>
### AssignRolesToUserAsync(user,roleIds) `method`

##### Summary

Assign specified roles to a user.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| user | [Definux.Emeraude.Domain.Entities.IUser](#T-Definux-Emeraude-Domain-Entities-IUser 'Definux.Emeraude.Domain.Entities.IUser') |  |
| roleIds | [System.Collections.Generic.IEnumerable{System.Guid}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Guid}') |  |

<a name='M-Definux-Emeraude-Application-Identity-IRoleManager-CreateRoleAsync-System-String,System-Collections-Generic-IEnumerable{System-String}-'></a>
### CreateRoleAsync(roleName,claims) `method`

##### Summary

Create role entity by name and claims.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| roleName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| claims | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') |  |

<a name='M-Definux-Emeraude-Application-Identity-IRoleManager-DeleteRoleAsync-System-String-'></a>
### DeleteRoleAsync(roleName) `method`

##### Summary

Delete role entity.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| roleName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Application-Identity-IRoleManager-GetRolesAsync'></a>
### GetRolesAsync() `method`

##### Summary

Get all roles as a dictionary.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IRoleManager-GetUserRolesAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### GetUserRolesAsync(user) `method`

##### Summary

Get all roles for a user as a dictionary.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| user | [Definux.Emeraude.Domain.Entities.IUser](#T-Definux-Emeraude-Domain-Entities-IUser 'Definux.Emeraude.Domain.Entities.IUser') |  |

<a name='M-Definux-Emeraude-Application-Identity-IRoleManager-UnassignAllRolesFromUserAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### UnassignAllRolesFromUserAsync(user) `method`

##### Summary

Unassign all roles from a user.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| user | [Definux.Emeraude.Domain.Entities.IUser](#T-Definux-Emeraude-Domain-Entities-IUser 'Definux.Emeraude.Domain.Entities.IUser') |  |

<a name='T-Definux-Emeraude-Application-Files-IRootsService'></a>
## IRootsService `type`

##### Namespace

Definux.Emeraude.Application.Files

##### Summary

Service that builds paths for roots.

<a name='P-Definux-Emeraude-Application-Files-IRootsService-PrivateRootDirectory'></a>
### PrivateRootDirectory `property`

##### Summary

Get private root directory.

<a name='P-Definux-Emeraude-Application-Files-IRootsService-PublicRootDirectory'></a>
### PublicRootDirectory `property`

##### Summary

Get public root directory.

<a name='M-Definux-Emeraude-Application-Files-IRootsService-GetPathFromPrivateRoot-System-String[]-'></a>
### GetPathFromPrivateRoot(paths) `method`

##### Summary

Get path from private root by path.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| paths | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

<a name='M-Definux-Emeraude-Application-Files-IRootsService-GetPathFromPublicRoot-System-String[]-'></a>
### GetPathFromPublicRoot(paths) `method`

##### Summary

Get path from public root by path.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| paths | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

<a name='T-Definux-Emeraude-Application-Files-ISystemFilesService'></a>
## ISystemFilesService `type`

##### Namespace

Definux.Emeraude.Application.Files

##### Summary

System files service that access and process files and folders from the public and private root of the system.

<a name='M-Definux-Emeraude-Application-Files-ISystemFilesService-ApplyTempFileToPrivateDirectoryAsync-System-Int32,System-String-'></a>
### ApplyTempFileToPrivateDirectoryAsync(fileId,targetDirectory) `method`

##### Summary

Apply temp file ([TempFileLog](#T-Definux-Emeraude-Domain-Logging-TempFileLog 'Definux.Emeraude.Domain.Logging.TempFileLog')) into specified private root directory (async execution).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| targetDirectory | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Application-Files-ISystemFilesService-ApplyTempFileToPublicDirectoryAsync-System-Int32,System-String-'></a>
### ApplyTempFileToPublicDirectoryAsync(fileId,targetDirectory) `method`

##### Summary

Apply temp file ([TempFileLog](#T-Definux-Emeraude-Domain-Logging-TempFileLog 'Definux.Emeraude.Domain.Logging.TempFileLog')) into specified public root directory (async execution).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| targetDirectory | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Application-Files-ISystemFilesService-ApplyTempFilesToPrivateDirectoryAsync-System-Collections-Generic-IEnumerable{System-Int32},System-String-'></a>
### ApplyTempFilesToPrivateDirectoryAsync(ids,targetDirectory) `method`

##### Summary

Apply temp files ([TempFileLog](#T-Definux-Emeraude-Domain-Logging-TempFileLog 'Definux.Emeraude.Domain.Logging.TempFileLog')) into specified private root directory (async execution).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ids | [System.Collections.Generic.IEnumerable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Int32}') |  |
| targetDirectory | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Application-Files-ISystemFilesService-ApplyTempFilesToPublicDirectoryAsync-System-Collections-Generic-IEnumerable{System-Int32},System-String-'></a>
### ApplyTempFilesToPublicDirectoryAsync(ids,targetDirectory) `method`

##### Summary

Apply temp files ([TempFileLog](#T-Definux-Emeraude-Domain-Logging-TempFileLog 'Definux.Emeraude.Domain.Logging.TempFileLog')) into specified public root directory (async execution).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ids | [System.Collections.Generic.IEnumerable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Int32}') |  |
| targetDirectory | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Application-Files-ISystemFilesService-CreateFolderAsync-System-String,System-String-'></a>
### CreateFolderAsync(folderName,folderPath) `method`

##### Summary

Create folder.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| folderName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| folderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Application-Files-ISystemFilesService-GetFileAsync-System-String-'></a>
### GetFileAsync(filePath) `method`

##### Summary

Get system file by file bath.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Application-Files-ISystemFilesService-GetFileById-System-Int32-'></a>
### GetFileById(id) `method`

##### Summary

Get file ([TempFileLog](#T-Definux-Emeraude-Domain-Logging-TempFileLog 'Definux.Emeraude.Domain.Logging.TempFileLog')) by temp file log id.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Definux-Emeraude-Application-Files-ISystemFilesService-GetFileByIdAsync-System-Int32-'></a>
### GetFileByIdAsync(id) `method`

##### Summary

Get file ([TempFileLog](#T-Definux-Emeraude-Domain-Logging-TempFileLog 'Definux.Emeraude.Domain.Logging.TempFileLog')) by temp file log id (async execution).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Definux-Emeraude-Application-Files-ISystemFilesService-GetFilesByIds-System-Collections-Generic-IEnumerable{System-Int32}-'></a>
### GetFilesByIds(ids) `method`

##### Summary

Get files ([TempFileLog](#T-Definux-Emeraude-Domain-Logging-TempFileLog 'Definux.Emeraude.Domain.Logging.TempFileLog')) by temp file log ids.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ids | [System.Collections.Generic.IEnumerable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Int32}') |  |

<a name='M-Definux-Emeraude-Application-Files-ISystemFilesService-GetFilesByIdsAsync-System-Collections-Generic-IEnumerable{System-Int32}-'></a>
### GetFilesByIdsAsync(ids) `method`

##### Summary

Get files ([TempFileLog](#T-Definux-Emeraude-Domain-Logging-TempFileLog 'Definux.Emeraude.Domain.Logging.TempFileLog')) by temp file log ids (async execution).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ids | [System.Collections.Generic.IEnumerable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Int32}') |  |

<a name='M-Definux-Emeraude-Application-Files-ISystemFilesService-GetPublicRootFolderFilesRelativePaths-System-String[]-'></a>
### GetPublicRootFolderFilesRelativePaths(paths) `method`

##### Summary

Get public root files with its relative paths from a path.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| paths | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

<a name='M-Definux-Emeraude-Application-Files-ISystemFilesService-ScanDirectory-System-String,System-String-'></a>
### ScanDirectory(directory,baseDirectory) `method`

##### Summary

Scan directory (public or private roots) for system items.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| directory | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| baseDirectory | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Must be [PublicRootDirectory](#P-Definux-Emeraude-Application-Files-IRootsService-PublicRootDirectory 'Definux.Emeraude.Application.Files.IRootsService.PublicRootDirectory') or [PrivateRootDirectory](#P-Definux-Emeraude-Application-Files-IRootsService-PrivateRootDirectory 'Definux.Emeraude.Application.Files.IRootsService.PrivateRootDirectory'). |

<a name='M-Definux-Emeraude-Application-Files-ISystemFilesService-ScanPrivateDirectory'></a>
### ScanPrivateDirectory() `method`

##### Summary

Scan private root directory for system items.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Files-ISystemFilesService-ScanPublicDirectory'></a>
### ScanPublicDirectory() `method`

##### Summary

Scan public root directory for system items.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-Identity-ITwoFactorAuthenticationService'></a>
## ITwoFactorAuthenticationService `type`

##### Namespace

Definux.Emeraude.Application.Identity

##### Summary

Two factor authentication service that provides specific methods for managing this functionality into the system.

<a name='M-Definux-Emeraude-Application-Identity-ITwoFactorAuthenticationService-GenerateQrCodeUriAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### GenerateQrCodeUriAsync(user) `method`

##### Summary

Generate QR code URL for specific user.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| user | [Definux.Emeraude.Domain.Entities.IUser](#T-Definux-Emeraude-Domain-Entities-IUser 'Definux.Emeraude.Domain.Entities.IUser') |  |

<a name='M-Definux-Emeraude-Application-Identity-ITwoFactorAuthenticationService-GetFormattedKeyAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### GetFormattedKeyAsync(user) `method`

##### Summary

Get formatted authentication key for specific user.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| user | [Definux.Emeraude.Domain.Entities.IUser](#T-Definux-Emeraude-Domain-Entities-IUser 'Definux.Emeraude.Domain.Entities.IUser') |  |

<a name='M-Definux-Emeraude-Application-Identity-ITwoFactorAuthenticationService-IsTwoFactorEnabled-Definux-Emeraude-Domain-Entities-IUser-'></a>
### IsTwoFactorEnabled(user) `method`

##### Summary

Check whether a user is enabled two factor authentication.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| user | [Definux.Emeraude.Domain.Entities.IUser](#T-Definux-Emeraude-Domain-Entities-IUser 'Definux.Emeraude.Domain.Entities.IUser') |  |

<a name='T-Definux-Emeraude-Application-Files-IUploadService'></a>
## IUploadService `type`

##### Namespace

Definux.Emeraude.Application.Files

##### Summary

Service that supports upload functionality of the files infrastructure.

<a name='M-Definux-Emeraude-Application-Files-IUploadService-UploadFileAsync-Microsoft-AspNetCore-Http-IFormFile-'></a>
### UploadFileAsync(formFile) `method`

##### Summary

Upload file as a temp file in private root.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| formFile | [Microsoft.AspNetCore.Http.IFormFile](#T-Microsoft-AspNetCore-Http-IFormFile 'Microsoft.AspNetCore.Http.IFormFile') |  |

<a name='M-Definux-Emeraude-Application-Files-IUploadService-UploadFileAsync-Microsoft-AspNetCore-Http-IFormFile,System-String,System-Boolean-'></a>
### UploadFileAsync(formFile,saveDirectory,publicRoot) `method`

##### Summary

Upload file in specified directory.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| formFile | [Microsoft.AspNetCore.Http.IFormFile](#T-Microsoft-AspNetCore-Http-IFormFile 'Microsoft.AspNetCore.Http.IFormFile') |  |
| saveDirectory | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| publicRoot | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-Definux-Emeraude-Application-Identity-IUserAvatarService'></a>
## IUserAvatarService `type`

##### Namespace

Definux.Emeraude.Application.Identity

##### Summary

Service specified for user avatar processing.

<a name='M-Definux-Emeraude-Application-Identity-IUserAvatarService-ApplyAvatarToUserAsync-System-Guid,System-String-'></a>
### ApplyAvatarToUserAsync(userId,avatarUrl) `method`

##### Summary

Apply local saved avatar to specified user.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |
| avatarUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Application-Identity-IUserAvatarService-CreateAvatarFromUrlAsync-System-String-'></a>
### CreateAvatarFromUrlAsync(externalSourceAvatarUrl) `method`

##### Summary

Create avatar for a user from external file source.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| externalSourceAvatarUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Application-Identity-IUserAvatarService-CreateUserAvatarAsync-System-Byte[]-'></a>
### CreateUserAvatarAsync(avatarFileByteArray) `method`

##### Summary

Create avatar for a user from file in byte array format.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| avatarFileByteArray | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') |  |

<a name='M-Definux-Emeraude-Application-Identity-IUserAvatarService-GetUserAvatarRelativePath-Definux-Emeraude-Domain-Entities-IUser-'></a>
### GetUserAvatarRelativePath(user) `method`

##### Summary

Get user avatar relative path.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| user | [Definux.Emeraude.Domain.Entities.IUser](#T-Definux-Emeraude-Domain-Entities-IUser 'Definux.Emeraude.Domain.Entities.IUser') |  |

<a name='T-Definux-Emeraude-Application-Identity-IUserClaimsService'></a>
## IUserClaimsService `type`

##### Namespace

Definux.Emeraude.Application.Identity

##### Summary

Service for accessing and mutation of user claims.

<a name='M-Definux-Emeraude-Application-Identity-IUserClaimsService-CheckUserForAccessAdministrationPermissionAsync-System-String-'></a>
### CheckUserForAccessAdministrationPermissionAsync(email) `method`

##### Summary

Function that returns true or false based on the user rights to access administration panel.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| email | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Application-Identity-IUserClaimsService-GetAllUserClaimsAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### GetAllUserClaimsAsync(user) `method`

##### Summary

Gets all user claims.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| user | [Definux.Emeraude.Domain.Entities.IUser](#T-Definux-Emeraude-Domain-Entities-IUser 'Definux.Emeraude.Domain.Entities.IUser') |  |

<a name='M-Definux-Emeraude-Application-Identity-IUserClaimsService-GetUserClaimsForCookieAsync-System-Guid-'></a>
### GetUserClaimsForCookieAsync(userId) `method`

##### Summary

Get user claims which can be applied into the session cookie.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |

<a name='M-Definux-Emeraude-Application-Identity-IUserClaimsService-GetUserClaimsForJwtTokenAsync-System-Guid-'></a>
### GetUserClaimsForJwtTokenAsync(userId) `method`

##### Summary

Get user claims which can be applied into the JSON web token.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |

<a name='T-Definux-Emeraude-Application-Identity-IUserManager'></a>
## IUserManager `type`

##### Namespace

Definux.Emeraude.Application.Identity

##### Summary

Emeraude wrapper of ASP.NET Core User Manager with additional functionalities.

<a name='P-Definux-Emeraude-Application-Identity-IUserManager-Options'></a>
### Options `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-AccessFailedAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### AccessFailedAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-AddClaimAsync-Definux-Emeraude-Domain-Entities-IUser,System-Security-Claims-Claim-'></a>
### AddClaimAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-AddClaimsAsync-Definux-Emeraude-Domain-Entities-IUser,System-Collections-Generic-IEnumerable{System-Security-Claims-Claim}-'></a>
### AddClaimsAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-AddLoginAsync-Definux-Emeraude-Domain-Entities-IUser,Microsoft-AspNetCore-Identity-UserLoginInfo-'></a>
### AddLoginAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-AddPasswordAsync-Definux-Emeraude-Domain-Entities-IUser,System-String-'></a>
### AddPasswordAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-AddToRoleAsync-Definux-Emeraude-Domain-Entities-IUser,System-String-'></a>
### AddToRoleAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-AddToRolesAsync-Definux-Emeraude-Domain-Entities-IUser,System-Collections-Generic-IEnumerable{System-String}-'></a>
### AddToRolesAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-ChangeEmailAsync-Definux-Emeraude-Domain-Entities-IUser,System-String,System-String-'></a>
### ChangeEmailAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-ChangePasswordAsync-Definux-Emeraude-Domain-Entities-IUser,System-String,System-String-'></a>
### ChangePasswordAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-ChangePhoneNumberAsync-Definux-Emeraude-Domain-Entities-IUser,System-String,System-String-'></a>
### ChangePhoneNumberAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-ChangeUserNameAsync-Definux-Emeraude-Domain-Entities-IUser,System-String-'></a>
### ChangeUserNameAsync(user,newName) `method`

##### Summary

Changes the specified user name.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| user | [Definux.Emeraude.Domain.Entities.IUser](#T-Definux-Emeraude-Domain-Entities-IUser 'Definux.Emeraude.Domain.Entities.IUser') |  |
| newName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-CheckPasswordAsync-System-String,System-String-'></a>
### CheckPasswordAsync(email,password) `method`

##### Summary

Returns a flag indicating whether the given password is valid for the specified email.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| email | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-CheckPasswordAsync-Definux-Emeraude-Domain-Entities-IUser,System-String-'></a>
### CheckPasswordAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-ConfirmEmailAsync-Definux-Emeraude-Domain-Entities-IUser,System-String-'></a>
### ConfirmEmailAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-CountRecoveryCodesAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### CountRecoveryCodesAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-CreateAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### CreateAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-CreateAsync-Definux-Emeraude-Domain-Entities-IUser,System-String-'></a>
### CreateAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-CreateSecurityTokenAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### CreateSecurityTokenAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-CreateUserObject-System-String,System-String,System-Boolean-'></a>
### CreateUserObject(email,name,confirmedEmail) `method`

##### Summary

Create user object by email and name.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| email | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| confirmedEmail | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-DeleteAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### DeleteAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-FindUserByEmailAsync-System-String-'></a>
### FindUserByEmailAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-FindUserByIdAsync-System-Guid-'></a>
### FindUserByIdAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-FindUserByLoginAsync-System-String,System-String-'></a>
### FindUserByLoginAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-FindUserByNameAsync-System-String-'></a>
### FindUserByNameAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-GenerateChangeEmailTokenAsync-Definux-Emeraude-Domain-Entities-IUser,System-String-'></a>
### GenerateChangeEmailTokenAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-GenerateChangePhoneNumberTokenAsync-Definux-Emeraude-Domain-Entities-IUser,System-String-'></a>
### GenerateChangePhoneNumberTokenAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-GenerateConcurrencyStampAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### GenerateConcurrencyStampAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-GenerateEmailConfirmationTokenAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### GenerateEmailConfirmationTokenAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-GenerateNewTwoFactorRecoveryCodesAsync-Definux-Emeraude-Domain-Entities-IUser,System-Int32-'></a>
### GenerateNewTwoFactorRecoveryCodesAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-GeneratePasswordResetTokenAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### GeneratePasswordResetTokenAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-GenerateTwoFactorTokenAsync-Definux-Emeraude-Domain-Entities-IUser,System-String-'></a>
### GenerateTwoFactorTokenAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-GenerateUserTokenAsync-Definux-Emeraude-Domain-Entities-IUser,System-String,System-String-'></a>
### GenerateUserTokenAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-GetAccessFailedCountAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### GetAccessFailedCountAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-GetAuthenticationTokenAsync-Definux-Emeraude-Domain-Entities-IUser,System-String,System-String-'></a>
### GetAuthenticationTokenAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-GetAuthenticatorKeyAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### GetAuthenticatorKeyAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-GetClaimsAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### GetClaimsAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-GetEmailAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### GetEmailAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-GetLockoutEnabledAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### GetLockoutEnabledAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-GetLockoutEndDateAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### GetLockoutEndDateAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-GetLoginsAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### GetLoginsAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-GetPhoneNumberAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### GetPhoneNumberAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-GetRolesAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### GetRolesAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-GetSecurityStampAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### GetSecurityStampAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-GetTwoFactorAuthenticationUserAsync'></a>
### GetTwoFactorAuthenticationUserAsync() `method`

##### Summary

Extract two factor authenticated user from request context.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-GetTwoFactorEnabledAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### GetTwoFactorEnabledAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-GetUserIdAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### GetUserIdAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-GetValidTwoFactorProvidersAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### GetValidTwoFactorProvidersAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-HasPasswordAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### HasPasswordAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-IsEmailConfirmedAsync-System-String-'></a>
### IsEmailConfirmedAsync(email) `method`

##### Summary

Gets a flag indicating whether the email address for the specified email has been verified, true if the email address is verified otherwise false.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| email | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-IsEmailConfirmedAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### IsEmailConfirmedAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-IsInRoleAsync-Definux-Emeraude-Domain-Entities-IUser,System-String-'></a>
### IsInRoleAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-IsLockedOutAsync-System-String-'></a>
### IsLockedOutAsync(email) `method`

##### Summary

Returns a flag that indicating whether the specified user is locked out or not.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| email | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-IsLockedOutAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### IsLockedOutAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-IsPhoneNumberConfirmedAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### IsPhoneNumberConfirmedAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-RedeemTwoFactorRecoveryCodeAsync-Definux-Emeraude-Domain-Entities-IUser,System-String-'></a>
### RedeemTwoFactorRecoveryCodeAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-RegisterTokenProvider-System-String,Microsoft-AspNetCore-Identity-IUserTwoFactorTokenProvider{Definux-Emeraude-Domain-Entities-IUser}-'></a>
### RegisterTokenProvider() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-RemoveAuthenticationTokenAsync-Definux-Emeraude-Domain-Entities-IUser,System-String,System-String-'></a>
### RemoveAuthenticationTokenAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-RemoveClaimAsync-Definux-Emeraude-Domain-Entities-IUser,System-Security-Claims-Claim-'></a>
### RemoveClaimAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-RemoveClaimsAsync-Definux-Emeraude-Domain-Entities-IUser,System-Collections-Generic-IEnumerable{System-Security-Claims-Claim}-'></a>
### RemoveClaimsAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-RemoveFromRoleAsync-Definux-Emeraude-Domain-Entities-IUser,System-String-'></a>
### RemoveFromRoleAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-RemoveFromRolesAsync-Definux-Emeraude-Domain-Entities-IUser,System-Collections-Generic-IEnumerable{System-String}-'></a>
### RemoveFromRolesAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-RemoveLoginAsync-Definux-Emeraude-Domain-Entities-IUser,System-String,System-String-'></a>
### RemoveLoginAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-RemovePasswordAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### RemovePasswordAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-ReplaceClaimAsync-Definux-Emeraude-Domain-Entities-IUser,System-Security-Claims-Claim,System-Security-Claims-Claim-'></a>
### ReplaceClaimAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-ResetAccessFailedCountAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### ResetAccessFailedCountAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-ResetAuthenticatorKeyAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### ResetAuthenticatorKeyAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-ResetPasswordAsync-Definux-Emeraude-Domain-Entities-IUser,System-String,System-String-'></a>
### ResetPasswordAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-SetAuthenticationTokenAsync-Definux-Emeraude-Domain-Entities-IUser,System-String,System-String,System-String-'></a>
### SetAuthenticationTokenAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-SetEmailAsync-Definux-Emeraude-Domain-Entities-IUser,System-String-'></a>
### SetEmailAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-SetLockoutEnabledAsync-Definux-Emeraude-Domain-Entities-IUser,System-Boolean-'></a>
### SetLockoutEnabledAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-SetLockoutEndDateAsync-Definux-Emeraude-Domain-Entities-IUser,System-Nullable{System-DateTimeOffset}-'></a>
### SetLockoutEndDateAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-SetPhoneNumberAsync-Definux-Emeraude-Domain-Entities-IUser,System-String-'></a>
### SetPhoneNumberAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-SetTwoFactorEnabledAsync-Definux-Emeraude-Domain-Entities-IUser,System-Boolean-'></a>
### SetTwoFactorEnabledAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-UpdateAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### UpdateAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-UpdateSecurityStampAsync-Definux-Emeraude-Domain-Entities-IUser-'></a>
### UpdateSecurityStampAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-VerifyTwoFactorTokenAsync-Definux-Emeraude-Domain-Entities-IUser,System-String,System-String-'></a>
### VerifyTwoFactorTokenAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Identity-IUserManager-VerifyUserTokenAsync-Definux-Emeraude-Domain-Entities-IUser,System-String,System-String,System-String-'></a>
### VerifyUserTokenAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-Identity-IUserTokensService'></a>
## IUserTokensService `type`

##### Namespace

Definux.Emeraude.Application.Identity

##### Summary

Service that provides methods for generation of access and refresh tokens.

<a name='M-Definux-Emeraude-Application-Identity-IUserTokensService-BuildJwtTokenForExternalUserAsync-Definux-Emeraude-Application-Identity-IExternalUser-'></a>
### BuildJwtTokenForExternalUserAsync(externalUser) `method`

##### Summary

Build JSON web token for specified external user.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| externalUser | [Definux.Emeraude.Application.Identity.IExternalUser](#T-Definux-Emeraude-Application-Identity-IExternalUser 'Definux.Emeraude.Application.Identity.IExternalUser') |  |

<a name='M-Definux-Emeraude-Application-Identity-IUserTokensService-BuildJwtTokenForUserAsync-System-Guid-'></a>
### BuildJwtTokenForUserAsync(userId) `method`

##### Summary

Build JSON web token for specified user.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |

<a name='M-Definux-Emeraude-Application-Identity-IUserTokensService-RefreshJwtTokenAsync-System-Nullable{System-Guid},System-String-'></a>
### RefreshJwtTokenAsync(userId,refreshToken) `method`

##### Summary

Refresh JSON web token for specified user by refresh token.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.Nullable{System.Guid}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Guid}') |  |
| refreshToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Application-Identity-IUserTokensService-ResetRefreshTokenAsync-System-Guid-'></a>
### ResetRefreshTokenAsync(userId) `method`

##### Summary

Reset refresh token for specified user.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |

<a name='T-Definux-Emeraude-Application-EventHandlers-IdentityEventArgs'></a>
## IdentityEventArgs `type`

##### Namespace

Definux.Emeraude.Application.EventHandlers

##### Summary

Base class that implements the identity event arguments.

<a name='P-Definux-Emeraude-Application-EventHandlers-IdentityEventArgs-HttpContext'></a>
### HttpContext `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Application-EventHandlers-IdentityEventArgs-UserId'></a>
### UserId `property`

##### Summary

User id.

<a name='T-Definux-Emeraude-Application-Files-InitFolder'></a>
## InitFolder `type`

##### Namespace

Definux.Emeraude.Application.Files

##### Summary

Class that represent the folder that must be initialized on the start of the application.

<a name='P-Definux-Emeraude-Application-Files-InitFolder-Children'></a>
### Children `property`

##### Summary

List of all children folders that are placed in the current folder.

<a name='P-Definux-Emeraude-Application-Files-InitFolder-Name'></a>
### Name `property`

##### Summary

Name of the folder.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommand'></a>
## LoginCommand `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.Login

##### Summary

Command for user login.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommand-Email'></a>
### Email `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommand-Password'></a>
### Password `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommand-LoginCommandHandler'></a>
## LoginCommandHandler `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.Login.LoginCommand

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommand-LoginCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-EventHandlers-IIdentityEventManager-'></a>
### #ctor(userManager,eventManager) `constructor`

##### Summary

Initializes a new instance of the [LoginCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommand-LoginCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.Login.LoginCommand.LoginCommandHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userManager | [Definux.Emeraude.Application.Identity.IUserManager](#T-Definux-Emeraude-Application-Identity-IUserManager 'Definux.Emeraude.Application.Identity.IUserManager') |  |
| eventManager | [Definux.Emeraude.Application.EventHandlers.IIdentityEventManager](#T-Definux-Emeraude-Application-EventHandlers-IIdentityEventManager 'Definux.Emeraude.Application.EventHandlers.IIdentityEventManager') |  |

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommand-LoginCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommand,System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommandValidator'></a>
## LoginCommandValidator `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.Login

##### Summary

Validator for login command.

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommandValidator-#ctor-Definux-Emeraude-Application-Identity-IUserManager-'></a>
### #ctor(userManager) `constructor`

##### Summary

Initializes a new instance of the [LoginCommandValidator](#T-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginCommandValidator 'Definux.Emeraude.Application.Requests.Identity.Commands.Login.LoginCommandValidator') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userManager | [Definux.Emeraude.Application.Identity.IUserManager](#T-Definux-Emeraude-Application-Identity-IUserManager 'Definux.Emeraude.Application.Identity.IUserManager') |  |

<a name='T-Definux-Emeraude-Application-EventHandlers-LoginEventArgs'></a>
## LoginEventArgs `type`

##### Namespace

Definux.Emeraude.Application.EventHandlers

##### Summary

Event arguments for login event handler.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginRequestResult'></a>
## LoginRequestResult `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.Login

##### Summary

Result of the login command.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginRequestResult-Result'></a>
### Result `property`

##### Summary

Status of the result.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-Login-LoginRequestResult-User'></a>
### User `property`

##### Summary

Target user.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationCommand'></a>
## LoginWithTwoFactorAuthenticationCommand `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.LoginWithTwoFactorAuthentication

##### Summary

Command for user login with two factor authentication.

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationCommand-#ctor-Definux-Emeraude-Domain-Entities-IUser,System-String-'></a>
### #ctor(user,code) `constructor`

##### Summary

Initializes a new instance of the [LoginWithTwoFactorAuthenticationCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.LoginWithTwoFactorAuthentication.LoginWithTwoFactorAuthenticationCommand') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| user | [Definux.Emeraude.Domain.Entities.IUser](#T-Definux-Emeraude-Domain-Entities-IUser 'Definux.Emeraude.Domain.Entities.IUser') |  |
| code | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationCommand-Code'></a>
### Code `property`

##### Summary

Two factor authentication code.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationCommand-User'></a>
### User `property`

##### Summary

Target user.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationCommand-LoginWithTwoFactorAuthenticationCommandHandler'></a>
## LoginWithTwoFactorAuthenticationCommandHandler `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.LoginWithTwoFactorAuthentication.LoginWithTwoFactorAuthenticationCommand

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationCommand-LoginWithTwoFactorAuthenticationCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserManager-'></a>
### #ctor(userManager) `constructor`

##### Summary

Initializes a new instance of the [LoginWithTwoFactorAuthenticationCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationCommand-LoginWithTwoFactorAuthenticationCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.LoginWithTwoFactorAuthentication.LoginWithTwoFactorAuthenticationCommand.LoginWithTwoFactorAuthenticationCommandHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userManager | [Definux.Emeraude.Application.Identity.IUserManager](#T-Definux-Emeraude-Application-Identity-IUserManager 'Definux.Emeraude.Application.Identity.IUserManager') |  |

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationCommand-LoginWithTwoFactorAuthenticationCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationCommand,System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationCommandValidator'></a>
## LoginWithTwoFactorAuthenticationCommandValidator `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.LoginWithTwoFactorAuthentication

##### Summary

Validator for login with two factor authentication command.

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationCommandValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [LoginWithTwoFactorAuthenticationCommandValidator](#T-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationCommandValidator 'Definux.Emeraude.Application.Requests.Identity.Commands.LoginWithTwoFactorAuthentication.LoginWithTwoFactorAuthenticationCommandValidator') class.

##### Parameters

This constructor has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationRequestResult'></a>
## LoginWithTwoFactorAuthenticationRequestResult `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.LoginWithTwoFactorAuthentication

##### Summary

Login with two factor authenticaiton command result.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationRequestResult-Result'></a>
### Result `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-LoginWithTwoFactorAuthentication-LoginWithTwoFactorAuthenticationRequestResult-User'></a>
### User `property`

##### Summary

Target user.

<a name='T-Definux-Emeraude-Application-Exceptions-PageNotFoundException'></a>
## PageNotFoundException `type`

##### Namespace

Definux.Emeraude.Application.Exceptions

##### Summary

Exception for showing the lack of accessed entity.

<a name='M-Definux-Emeraude-Application-Exceptions-PageNotFoundException-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [PageNotFoundException](#T-Definux-Emeraude-Application-Exceptions-PageNotFoundException 'Definux.Emeraude.Application.Exceptions.PageNotFoundException') class.

##### Parameters

This constructor has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommand'></a>
## RefreshAccessTokenCommand `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.RefreshAccessToken

##### Summary

Command for refresh access token of specified user.

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommand-#ctor-System-Nullable{System-Guid},System-String-'></a>
### #ctor(userId,refreshToken) `constructor`

##### Summary

Initializes a new instance of the [RefreshAccessTokenCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.RefreshAccessToken.RefreshAccessTokenCommand') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.Nullable{System.Guid}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Guid}') |  |
| refreshToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommand-RefreshToken'></a>
### RefreshToken `property`

##### Summary

Refresh token.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommand-UserId'></a>
### UserId `property`

##### Summary

Target user id.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommand-RefreshAccessTokenCommandHandler'></a>
## RefreshAccessTokenCommandHandler `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.RefreshAccessToken.RefreshAccessTokenCommand

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommand-RefreshAccessTokenCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserTokensService-'></a>
### #ctor(userTokensService) `constructor`

##### Summary

Initializes a new instance of the [RefreshAccessTokenCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommand-RefreshAccessTokenCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.RefreshAccessToken.RefreshAccessTokenCommand.RefreshAccessTokenCommandHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userTokensService | [Definux.Emeraude.Application.Identity.IUserTokensService](#T-Definux-Emeraude-Application-Identity-IUserTokensService 'Definux.Emeraude.Application.Identity.IUserTokensService') |  |

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommand-RefreshAccessTokenCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommand,System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommandValidator'></a>
## RefreshAccessTokenCommandValidator `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.RefreshAccessToken

##### Summary

Validator for refresh access token command.

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommandValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [RefreshAccessTokenCommandValidator](#T-Definux-Emeraude-Application-Requests-Identity-Commands-RefreshAccessToken-RefreshAccessTokenCommandValidator 'Definux.Emeraude.Application.Requests.Identity.Commands.RefreshAccessToken.RefreshAccessTokenCommandValidator') class.

##### Parameters

This constructor has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand'></a>
## RegisterCommand `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.Register

##### Summary

Command for client user registration.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand-ConfirmedPassword'></a>
### ConfirmedPassword `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand-Email'></a>
### Email `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand-Name'></a>
### Name `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand-Password'></a>
### Password `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand-RegisterCommandHandler'></a>
## RegisterCommandHandler `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterCommand

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand-RegisterCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-EventHandlers-IIdentityEventManager,System-Text-Encodings-Web-UrlEncoder,Microsoft-AspNetCore-Http-IHttpContextAccessor,Definux-Emeraude-Application-Localization-ICurrentLanguageProvider-'></a>
### #ctor(userManager,eventManager,urlEncoder,httpContextAccessor,currentLanguageProvider) `constructor`

##### Summary

Initializes a new instance of the [RegisterCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand-RegisterCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterCommand.RegisterCommandHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userManager | [Definux.Emeraude.Application.Identity.IUserManager](#T-Definux-Emeraude-Application-Identity-IUserManager 'Definux.Emeraude.Application.Identity.IUserManager') |  |
| eventManager | [Definux.Emeraude.Application.EventHandlers.IIdentityEventManager](#T-Definux-Emeraude-Application-EventHandlers-IIdentityEventManager 'Definux.Emeraude.Application.EventHandlers.IIdentityEventManager') |  |
| urlEncoder | [System.Text.Encodings.Web.UrlEncoder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encodings.Web.UrlEncoder 'System.Text.Encodings.Web.UrlEncoder') |  |
| httpContextAccessor | [Microsoft.AspNetCore.Http.IHttpContextAccessor](#T-Microsoft-AspNetCore-Http-IHttpContextAccessor 'Microsoft.AspNetCore.Http.IHttpContextAccessor') |  |
| currentLanguageProvider | [Definux.Emeraude.Application.Localization.ICurrentLanguageProvider](#T-Definux-Emeraude-Application-Localization-ICurrentLanguageProvider 'Definux.Emeraude.Application.Localization.ICurrentLanguageProvider') |  |

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand-RegisterCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommand,System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommandValidator'></a>
## RegisterCommandValidator `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.Register

##### Summary

Validator for client registration command.

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommandValidator-#ctor-Definux-Emeraude-Application-Identity-IUserManager-'></a>
### #ctor(userManager) `constructor`

##### Summary

Initializes a new instance of the [RegisterCommandValidator](#T-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterCommandValidator 'Definux.Emeraude.Application.Requests.Identity.Commands.Register.RegisterCommandValidator') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userManager | [Definux.Emeraude.Application.Identity.IUserManager](#T-Definux-Emeraude-Application-Identity-IUserManager 'Definux.Emeraude.Application.Identity.IUserManager') | User Manager provided from Emeraude Identity. |

<a name='T-Definux-Emeraude-Application-EventHandlers-RegisterEventArgs'></a>
## RegisterEventArgs `type`

##### Namespace

Definux.Emeraude.Application.EventHandlers

##### Summary

Event arguments for register event handler.

<a name='P-Definux-Emeraude-Application-EventHandlers-RegisterEventArgs-EmailConfirmationLink'></a>
### EmailConfirmationLink `property`

##### Summary

Email confirmation link.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterRequestResult'></a>
## RegisterRequestResult `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.Register

##### Summary

Result of the register request.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterRequestResult-Result'></a>
### Result `property`

##### Summary



<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-Register-RegisterRequestResult-User'></a>
### User `property`

##### Summary

Target user.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-RemoveExternalLoginProvider-RemoveExternalLoginProviderCommand'></a>
## RemoveExternalLoginProviderCommand `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.RemoveExternalLoginProvider

##### Summary

Command for remove external login provider from specified user.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-RemoveExternalLoginProvider-RemoveExternalLoginProviderCommand-Password'></a>
### Password `property`

##### Summary

Password of the specified user.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-RemoveExternalLoginProvider-RemoveExternalLoginProviderCommand-Provider'></a>
### Provider `property`

##### Summary

External login provider.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-RemoveExternalLoginProvider-RemoveExternalLoginProviderCommand-UserId'></a>
### UserId `property`

##### Summary

Id of the user.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-RemoveExternalLoginProvider-RemoveExternalLoginProviderCommandValidator'></a>
## RemoveExternalLoginProviderCommandValidator `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.RemoveExternalLoginProvider

##### Summary

Validator of remove external login provider command.

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-RemoveExternalLoginProvider-RemoveExternalLoginProviderCommandValidator-#ctor-Definux-Emeraude-Application-Identity-IUserManager-'></a>
### #ctor(userManager) `constructor`

##### Summary

Initializes a new instance of the [RemoveExternalLoginProviderCommandValidator](#T-Definux-Emeraude-Application-Requests-Identity-Commands-RemoveExternalLoginProvider-RemoveExternalLoginProviderCommandValidator 'Definux.Emeraude.Application.Requests.Identity.Commands.RemoveExternalLoginProvider.RemoveExternalLoginProviderCommandValidator') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userManager | [Definux.Emeraude.Application.Identity.IUserManager](#T-Definux-Emeraude-Application-Identity-IUserManager 'Definux.Emeraude.Application.Identity.IUserManager') |  |

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommand'></a>
## RequestChangeEmailCommand `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.RequestChangeEmail

##### Summary

Command that send request for change email for specified user.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommand-LocalCallbackUrl'></a>
### LocalCallbackUrl `property`

##### Summary

Url that will be applied into the change email link.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommand-NewEmail'></a>
### NewEmail `property`

##### Summary

New email of the target user.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommand-UseLocalization'></a>
### UseLocalization `property`

##### Summary

Flag that indicates whether to apply localization parameter to change email link.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommand-UserId'></a>
### UserId `property`

##### Summary

Id of the target user.

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommand-ConfigureCallbackOptions-System-String,System-Boolean-'></a>
### ConfigureCallbackOptions(localCallbackUrl,useLocalization) `method`

##### Summary

Configure the callback options for change email link.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| localCallbackUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| useLocalization | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommand-RequestChangeEmailCommandHandler'></a>
## RequestChangeEmailCommandHandler `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.RequestChangeEmail.RequestChangeEmailCommand

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommand-RequestChangeEmailCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-Logger-IEmLogger,Definux-Emeraude-Application-Localization-ICurrentLanguageProvider,Definux-Emeraude-Application-EventHandlers-IIdentityEventManager,Microsoft-AspNetCore-Http-IHttpContextAccessor,System-Text-Encodings-Web-UrlEncoder-'></a>
### #ctor(userManager,logger,currentLanguageProvider,identityEventManager,httpContextAccessor,urlEncoder) `constructor`

##### Summary

Initializes a new instance of the [RequestChangeEmailCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommand-RequestChangeEmailCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.RequestChangeEmail.RequestChangeEmailCommand.RequestChangeEmailCommandHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userManager | [Definux.Emeraude.Application.Identity.IUserManager](#T-Definux-Emeraude-Application-Identity-IUserManager 'Definux.Emeraude.Application.Identity.IUserManager') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |
| currentLanguageProvider | [Definux.Emeraude.Application.Localization.ICurrentLanguageProvider](#T-Definux-Emeraude-Application-Localization-ICurrentLanguageProvider 'Definux.Emeraude.Application.Localization.ICurrentLanguageProvider') |  |
| identityEventManager | [Definux.Emeraude.Application.EventHandlers.IIdentityEventManager](#T-Definux-Emeraude-Application-EventHandlers-IIdentityEventManager 'Definux.Emeraude.Application.EventHandlers.IIdentityEventManager') |  |
| httpContextAccessor | [Microsoft.AspNetCore.Http.IHttpContextAccessor](#T-Microsoft-AspNetCore-Http-IHttpContextAccessor 'Microsoft.AspNetCore.Http.IHttpContextAccessor') |  |
| urlEncoder | [System.Text.Encodings.Web.UrlEncoder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encodings.Web.UrlEncoder 'System.Text.Encodings.Web.UrlEncoder') |  |

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommand-RequestChangeEmailCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommand,System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommandValidator'></a>
## RequestChangeEmailCommandValidator `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.RequestChangeEmail

##### Summary

Validator for [RequestChangeEmailCommand](#T-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommand 'Definux.Emeraude.Application.Requests.Identity.Commands.RequestChangeEmail.RequestChangeEmailCommand').

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommandValidator-#ctor-Definux-Emeraude-Application-Identity-IUserManager-'></a>
### #ctor(userManager) `constructor`

##### Summary

Initializes a new instance of the [RequestChangeEmailCommandValidator](#T-Definux-Emeraude-Application-Requests-Identity-Commands-RequestChangeEmail-RequestChangeEmailCommandValidator 'Definux.Emeraude.Application.Requests.Identity.Commands.RequestChangeEmail.RequestChangeEmailCommandValidator') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userManager | [Definux.Emeraude.Application.Identity.IUserManager](#T-Definux-Emeraude-Application-Identity-IUserManager 'Definux.Emeraude.Application.Identity.IUserManager') |  |

<a name='T-Definux-Emeraude-Application-EventHandlers-RequestChangeEmailEventArgs'></a>
## RequestChangeEmailEventArgs `type`

##### Namespace

Definux.Emeraude.Application.EventHandlers

##### Summary

Event arguments for request change email event handler.

<a name='P-Definux-Emeraude-Application-EventHandlers-RequestChangeEmailEventArgs-EmailConfirmationLink'></a>
### EmailConfirmationLink `property`

##### Summary

Email confirmation link.

<a name='P-Definux-Emeraude-Application-EventHandlers-RequestChangeEmailEventArgs-NewEmail'></a>
### NewEmail `property`

##### Summary

Requested new email.

<a name='T-Definux-Emeraude-Application-Behaviours-RequestValidationBehavior`2'></a>
## RequestValidationBehavior\`2 `type`

##### Namespace

Definux.Emeraude.Application.Behaviours

##### Summary

Pipeline behavior that handles the validation errors of the executed requests.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TRequest | Request. |
| TResponse | Response. |

<a name='M-Definux-Emeraude-Application-Behaviours-RequestValidationBehavior`2-#ctor-System-Collections-Generic-IEnumerable{FluentValidation-IValidator{`0}}-'></a>
### #ctor(validators) `constructor`

##### Summary

Initializes a new instance of the [RequestValidationBehavior\`2](#T-Definux-Emeraude-Application-Behaviours-RequestValidationBehavior`2 'Definux.Emeraude.Application.Behaviours.RequestValidationBehavior`2') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| validators | [System.Collections.Generic.IEnumerable{FluentValidation.IValidator{\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{FluentValidation.IValidator{`0}}') |  |

<a name='M-Definux-Emeraude-Application-Behaviours-RequestValidationBehavior`2-Handle-`0,System-Threading-CancellationToken,MediatR-RequestHandlerDelegate{`1}-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommand'></a>
## ResetPasswordCommand `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword

##### Summary

Command for client reset password of user.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommand-ConfirmedPassword'></a>
### ConfirmedPassword `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommand-Email'></a>
### Email `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommand-Password'></a>
### Password `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommand-Token'></a>
### Token `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommand-ResetPasswordCommandHandler'></a>
## ResetPasswordCommandHandler `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword.ResetPasswordCommand

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommand-ResetPasswordCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-EventHandlers-IIdentityEventManager,System-Text-Encodings-Web-UrlEncoder,Microsoft-AspNetCore-Http-IHttpContextAccessor,Definux-Emeraude-Application-Localization-ICurrentLanguageProvider-'></a>
### #ctor(userManager,identityEventManager,urlEncoder,httpContextAccessor,currentLanguageProvider) `constructor`

##### Summary

Initializes a new instance of the [ResetPasswordCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommand-ResetPasswordCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword.ResetPasswordCommand.ResetPasswordCommandHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userManager | [Definux.Emeraude.Application.Identity.IUserManager](#T-Definux-Emeraude-Application-Identity-IUserManager 'Definux.Emeraude.Application.Identity.IUserManager') |  |
| identityEventManager | [Definux.Emeraude.Application.EventHandlers.IIdentityEventManager](#T-Definux-Emeraude-Application-EventHandlers-IIdentityEventManager 'Definux.Emeraude.Application.EventHandlers.IIdentityEventManager') |  |
| urlEncoder | [System.Text.Encodings.Web.UrlEncoder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encodings.Web.UrlEncoder 'System.Text.Encodings.Web.UrlEncoder') |  |
| httpContextAccessor | [Microsoft.AspNetCore.Http.IHttpContextAccessor](#T-Microsoft-AspNetCore-Http-IHttpContextAccessor 'Microsoft.AspNetCore.Http.IHttpContextAccessor') |  |
| currentLanguageProvider | [Definux.Emeraude.Application.Localization.ICurrentLanguageProvider](#T-Definux-Emeraude-Application-Localization-ICurrentLanguageProvider 'Definux.Emeraude.Application.Localization.ICurrentLanguageProvider') |  |

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommand-ResetPasswordCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommand,System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommandValidator'></a>
## ResetPasswordCommandValidator `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword

##### Summary

Validator of reset password command.

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommandValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [ResetPasswordCommandValidator](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordCommandValidator 'Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword.ResetPasswordCommandValidator') class.

##### Parameters

This constructor has no parameters.

<a name='T-Definux-Emeraude-Application-EventHandlers-ResetPasswordEventArgs'></a>
## ResetPasswordEventArgs `type`

##### Namespace

Definux.Emeraude.Application.EventHandlers

##### Summary

Event arguments for reset password event handler.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordRequestResult'></a>
## ResetPasswordRequestResult `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword

##### Summary

Reset password command result.

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordRequestResult-#ctor-System-Boolean-'></a>
### #ctor(success) `constructor`

##### Summary

Initializes a new instance of the [ResetPasswordRequestResult](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ResetPassword-ResetPasswordRequestResult 'Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword.ResetPasswordRequestResult') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| success | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ResetTwoFactorAuthentication-ResetTwoFactorAuthenticationCommand'></a>
## ResetTwoFactorAuthenticationCommand `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ResetTwoFactorAuthentication

##### Summary

Command for reset two factor authenticator.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-RemoveExternalLoginProvider-RemoveExternalLoginProviderCommand-ResetTwoFactorAuthenticationCommandHandler'></a>
## ResetTwoFactorAuthenticationCommandHandler `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.RemoveExternalLoginProvider.RemoveExternalLoginProviderCommand

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ResetTwoFactorAuthentication-ResetTwoFactorAuthenticationCommand-ResetTwoFactorAuthenticationCommandHandler'></a>
## ResetTwoFactorAuthenticationCommandHandler `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ResetTwoFactorAuthentication.ResetTwoFactorAuthenticationCommand

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-RemoveExternalLoginProvider-RemoveExternalLoginProviderCommand-ResetTwoFactorAuthenticationCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-Logger-IEmLogger-'></a>
### #ctor(userManager,logger) `constructor`

##### Summary

Initializes a new instance of the [ResetTwoFactorAuthenticationCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-RemoveExternalLoginProvider-RemoveExternalLoginProviderCommand-ResetTwoFactorAuthenticationCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.RemoveExternalLoginProvider.RemoveExternalLoginProviderCommand.ResetTwoFactorAuthenticationCommandHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userManager | [Definux.Emeraude.Application.Identity.IUserManager](#T-Definux-Emeraude-Application-Identity-IUserManager 'Definux.Emeraude.Application.Identity.IUserManager') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ResetTwoFactorAuthentication-ResetTwoFactorAuthenticationCommand-ResetTwoFactorAuthenticationCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-Identity-ICurrentUserProvider-'></a>
### #ctor(userManager,currentUserProvider) `constructor`

##### Summary

Initializes a new instance of the [ResetTwoFactorAuthenticationCommandHandler](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ResetTwoFactorAuthentication-ResetTwoFactorAuthenticationCommand-ResetTwoFactorAuthenticationCommandHandler 'Definux.Emeraude.Application.Requests.Identity.Commands.ResetTwoFactorAuthentication.ResetTwoFactorAuthenticationCommand.ResetTwoFactorAuthenticationCommandHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userManager | [Definux.Emeraude.Application.Identity.IUserManager](#T-Definux-Emeraude-Application-Identity-IUserManager 'Definux.Emeraude.Application.Identity.IUserManager') |  |
| currentUserProvider | [Definux.Emeraude.Application.Identity.ICurrentUserProvider](#T-Definux-Emeraude-Application-Identity-ICurrentUserProvider 'Definux.Emeraude.Application.Identity.ICurrentUserProvider') |  |

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-RemoveExternalLoginProvider-RemoveExternalLoginProviderCommand-ResetTwoFactorAuthenticationCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-RemoveExternalLoginProvider-RemoveExternalLoginProviderCommand,System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ResetTwoFactorAuthentication-ResetTwoFactorAuthenticationCommand-ResetTwoFactorAuthenticationCommandHandler-Handle-Definux-Emeraude-Application-Requests-Identity-Commands-ResetTwoFactorAuthentication-ResetTwoFactorAuthenticationCommand,System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Commands-ResetTwoFactorAuthentication-ResetTwoFactorAuthenticationResult'></a>
## ResetTwoFactorAuthenticationResult `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Commands.ResetTwoFactorAuthentication

##### Summary

Reset two factor authenticator command result.

<a name='M-Definux-Emeraude-Application-Requests-Identity-Commands-ResetTwoFactorAuthentication-ResetTwoFactorAuthenticationResult-#ctor-System-Boolean-'></a>
### #ctor(success) `constructor`

##### Summary

Initializes a new instance of the [ResetTwoFactorAuthenticationResult](#T-Definux-Emeraude-Application-Requests-Identity-Commands-ResetTwoFactorAuthentication-ResetTwoFactorAuthenticationResult 'Definux.Emeraude.Application.Requests.Identity.Commands.ResetTwoFactorAuthentication.ResetTwoFactorAuthenticationResult') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| success | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-Definux-Emeraude-Application-Emails-SendEmailResult'></a>
## SendEmailResult `type`

##### Namespace

Definux.Emeraude.Application.Emails

##### Summary

Result model used on sending email operation.

<a name='P-Definux-Emeraude-Application-Emails-SendEmailResult-FailedResult'></a>
### FailedResult `property`

##### Summary

Built result for failure.

<a name='P-Definux-Emeraude-Application-Emails-SendEmailResult-Success'></a>
### Success `property`

##### Summary

Boolean status which set success or failure for the result.

<a name='P-Definux-Emeraude-Application-Emails-SendEmailResult-SuccessResult'></a>
### SuccessResult `property`

##### Summary

Built result for success.

<a name='T-Definux-Emeraude-Application-Files-SystemFileResult'></a>
## SystemFileResult `type`

##### Namespace

Definux.Emeraude.Application.Files

##### Summary

Result of the file for reading purposes.

<a name='P-Definux-Emeraude-Application-Files-SystemFileResult-ContentType'></a>
### ContentType `property`

##### Summary

Content type of the file.

<a name='P-Definux-Emeraude-Application-Files-SystemFileResult-Stream'></a>
### Stream `property`

##### Summary

File stream of the file.

<a name='T-Definux-Emeraude-Application-Files-SystemItem'></a>
## SystemItem `type`

##### Namespace

Definux.Emeraude.Application.Files

##### Summary

Encapsulated definition of system item.

<a name='P-Definux-Emeraude-Application-Files-SystemItem-CreatedOn'></a>
### CreatedOn `property`

##### Summary

Creation date of the item.

<a name='P-Definux-Emeraude-Application-Files-SystemItem-FileSize'></a>
### FileSize `property`

##### Summary

File size of the item.

<a name='P-Definux-Emeraude-Application-Files-SystemItem-LastModifiedOn'></a>
### LastModifiedOn `property`

##### Summary

Last modification date of the item.

<a name='P-Definux-Emeraude-Application-Files-SystemItem-Name'></a>
### Name `property`

##### Summary

Name of the item.

<a name='P-Definux-Emeraude-Application-Files-SystemItem-Path'></a>
### Path `property`

##### Summary

Path of the item.

<a name='P-Definux-Emeraude-Application-Files-SystemItem-RelativePath'></a>
### RelativePath `property`

##### Summary

Relative path of the item.

<a name='P-Definux-Emeraude-Application-Files-SystemItem-Type'></a>
### Type `property`

##### Summary

Type of the item.

<a name='T-Definux-Emeraude-Application-Requests-Files-Commands-UploadFile-UploadFileCommand'></a>
## UploadFileCommand `type`

##### Namespace

Definux.Emeraude.Application.Requests.Files.Commands.UploadFile

##### Summary

Command for uploading files.

<a name='M-Definux-Emeraude-Application-Requests-Files-Commands-UploadFile-UploadFileCommand-#ctor-Microsoft-AspNetCore-Http-IFormFile-'></a>
### #ctor(formFile) `constructor`

##### Summary

Initializes a new instance of the [UploadFileCommand](#T-Definux-Emeraude-Application-Requests-Files-Commands-UploadFile-UploadFileCommand 'Definux.Emeraude.Application.Requests.Files.Commands.UploadFile.UploadFileCommand') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| formFile | [Microsoft.AspNetCore.Http.IFormFile](#T-Microsoft-AspNetCore-Http-IFormFile 'Microsoft.AspNetCore.Http.IFormFile') |  |

<a name='M-Definux-Emeraude-Application-Requests-Files-Commands-UploadFile-UploadFileCommand-#ctor-Microsoft-AspNetCore-Http-IFormFile,System-String,System-Boolean-'></a>
### #ctor(formFile,saveDirectory,publicRoot) `constructor`

##### Summary

Initializes a new instance of the [UploadFileCommand](#T-Definux-Emeraude-Application-Requests-Files-Commands-UploadFile-UploadFileCommand 'Definux.Emeraude.Application.Requests.Files.Commands.UploadFile.UploadFileCommand') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| formFile | [Microsoft.AspNetCore.Http.IFormFile](#T-Microsoft-AspNetCore-Http-IFormFile 'Microsoft.AspNetCore.Http.IFormFile') |  |
| saveDirectory | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| publicRoot | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='P-Definux-Emeraude-Application-Requests-Files-Commands-UploadFile-UploadFileCommand-FormFile'></a>
### FormFile `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Application-Requests-Files-Commands-UploadFile-UploadFileCommand-PublicRoot'></a>
### PublicRoot `property`

##### Summary

Flag that indicates whether the target root is public (for true) or private (for false).

<a name='P-Definux-Emeraude-Application-Requests-Files-Commands-UploadFile-UploadFileCommand-SaveDirectory'></a>
### SaveDirectory `property`

##### Summary

Save directory of the file.

<a name='T-Definux-Emeraude-Application-Requests-Files-Commands-UploadFile-UploadFileCommand-UploadFileCommandHandler'></a>
## UploadFileCommandHandler `type`

##### Namespace

Definux.Emeraude.Application.Requests.Files.Commands.UploadFile.UploadFileCommand

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Application-Requests-Files-Commands-UploadFile-UploadFileCommand-UploadFileCommandHandler-#ctor-Definux-Emeraude-Application-Files-IFilesValidationProvider,Definux-Emeraude-Application-Files-ISystemFilesService,Definux-Emeraude-Application-Files-IUploadService-'></a>
### #ctor(validationProvider,systemFilesService,uploadService) `constructor`

##### Summary

Initializes a new instance of the [UploadFileCommandHandler](#T-Definux-Emeraude-Application-Requests-Files-Commands-UploadFile-UploadFileCommand-UploadFileCommandHandler 'Definux.Emeraude.Application.Requests.Files.Commands.UploadFile.UploadFileCommand.UploadFileCommandHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| validationProvider | [Definux.Emeraude.Application.Files.IFilesValidationProvider](#T-Definux-Emeraude-Application-Files-IFilesValidationProvider 'Definux.Emeraude.Application.Files.IFilesValidationProvider') |  |
| systemFilesService | [Definux.Emeraude.Application.Files.ISystemFilesService](#T-Definux-Emeraude-Application-Files-ISystemFilesService 'Definux.Emeraude.Application.Files.ISystemFilesService') |  |
| uploadService | [Definux.Emeraude.Application.Files.IUploadService](#T-Definux-Emeraude-Application-Files-IUploadService 'Definux.Emeraude.Application.Files.IUploadService') |  |

<a name='M-Definux-Emeraude-Application-Requests-Files-Commands-UploadFile-UploadFileCommand-UploadFileCommandHandler-Handle-Definux-Emeraude-Application-Requests-Files-Commands-UploadFile-UploadFileCommand,System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Files-Commands-UploadImage-UploadImageCommand'></a>
## UploadImageCommand `type`

##### Namespace

Definux.Emeraude.Application.Requests.Files.Commands.UploadImage

##### Summary

Command for uploading images.

<a name='M-Definux-Emeraude-Application-Requests-Files-Commands-UploadImage-UploadImageCommand-#ctor-Microsoft-AspNetCore-Http-IFormFile-'></a>
### #ctor(formFile) `constructor`

##### Summary

Initializes a new instance of the [UploadImageCommand](#T-Definux-Emeraude-Application-Requests-Files-Commands-UploadImage-UploadImageCommand 'Definux.Emeraude.Application.Requests.Files.Commands.UploadImage.UploadImageCommand') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| formFile | [Microsoft.AspNetCore.Http.IFormFile](#T-Microsoft-AspNetCore-Http-IFormFile 'Microsoft.AspNetCore.Http.IFormFile') |  |

<a name='P-Definux-Emeraude-Application-Requests-Files-Commands-UploadImage-UploadImageCommand-FormFile'></a>
### FormFile `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Application-Requests-Files-Commands-UploadImage-UploadImageCommand-UploadImageCommandHandler'></a>
## UploadImageCommandHandler `type`

##### Namespace

Definux.Emeraude.Application.Requests.Files.Commands.UploadImage.UploadImageCommand

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Application-Requests-Files-Commands-UploadImage-UploadImageCommand-UploadImageCommandHandler-#ctor-Definux-Emeraude-Application-Files-IFilesValidationProvider,Definux-Emeraude-Application-Files-ISystemFilesService,Definux-Emeraude-Application-Files-IUploadService-'></a>
### #ctor(validationProvider,systemFilesService,uploadService) `constructor`

##### Summary

Initializes a new instance of the [UploadImageCommandHandler](#T-Definux-Emeraude-Application-Requests-Files-Commands-UploadImage-UploadImageCommand-UploadImageCommandHandler 'Definux.Emeraude.Application.Requests.Files.Commands.UploadImage.UploadImageCommand.UploadImageCommandHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| validationProvider | [Definux.Emeraude.Application.Files.IFilesValidationProvider](#T-Definux-Emeraude-Application-Files-IFilesValidationProvider 'Definux.Emeraude.Application.Files.IFilesValidationProvider') |  |
| systemFilesService | [Definux.Emeraude.Application.Files.ISystemFilesService](#T-Definux-Emeraude-Application-Files-ISystemFilesService 'Definux.Emeraude.Application.Files.ISystemFilesService') |  |
| uploadService | [Definux.Emeraude.Application.Files.IUploadService](#T-Definux-Emeraude-Application-Files-IUploadService 'Definux.Emeraude.Application.Files.IUploadService') |  |

<a name='M-Definux-Emeraude-Application-Requests-Files-Commands-UploadImage-UploadImageCommand-UploadImageCommandHandler-Handle-Definux-Emeraude-Application-Requests-Files-Commands-UploadImage-UploadImageCommand,System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Files-Commands-Shared-UploadResult'></a>
## UploadResult `type`

##### Namespace

Definux.Emeraude.Application.Requests.Files.Commands.Shared

##### Summary

Upload result used for files upload commands.

<a name='P-Definux-Emeraude-Application-Requests-Files-Commands-Shared-UploadResult-Message'></a>
### Message `property`

##### Summary

Message of the result.

<a name='P-Definux-Emeraude-Application-Requests-Files-Commands-Shared-UploadResult-ResultFileId'></a>
### ResultFileId `property`

##### Summary

Temp file result id.

<a name='P-Definux-Emeraude-Application-Requests-Files-Commands-Shared-UploadResult-Success'></a>
### Success `property`

##### Summary

Boolean status of the result.

<a name='P-Definux-Emeraude-Application-Requests-Files-Commands-Shared-UploadResult-ValidationError'></a>
### ValidationError `property`

##### Summary

Boolean status that indicates that the file is not uploaded because of validation error.

<a name='M-Definux-Emeraude-Application-Requests-Files-Commands-Shared-UploadResult-ErrorResult-System-String-'></a>
### ErrorResult(errorMessage) `method`

##### Summary

Built upload error result.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errorMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Application-Requests-Files-Commands-Shared-UploadResult-SuccessResult-System-Int32-'></a>
### SuccessResult(tempFileId) `method`

##### Summary

Built upload success result.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tempFileId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Definux-Emeraude-Application-Requests-Files-Commands-Shared-UploadResult-ValidationErrorResult-System-String-'></a>
### ValidationErrorResult(message) `method`

##### Summary

Built upload error result with message.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Application-Requests-Files-Commands-UploadVideo-UploadVideoCommand'></a>
## UploadVideoCommand `type`

##### Namespace

Definux.Emeraude.Application.Requests.Files.Commands.UploadVideo

##### Summary

Command for uploading video files.

<a name='M-Definux-Emeraude-Application-Requests-Files-Commands-UploadVideo-UploadVideoCommand-#ctor-Microsoft-AspNetCore-Http-IFormFile-'></a>
### #ctor(formFile) `constructor`

##### Summary

Initializes a new instance of the [UploadVideoCommand](#T-Definux-Emeraude-Application-Requests-Files-Commands-UploadVideo-UploadVideoCommand 'Definux.Emeraude.Application.Requests.Files.Commands.UploadVideo.UploadVideoCommand') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| formFile | [Microsoft.AspNetCore.Http.IFormFile](#T-Microsoft-AspNetCore-Http-IFormFile 'Microsoft.AspNetCore.Http.IFormFile') |  |

<a name='P-Definux-Emeraude-Application-Requests-Files-Commands-UploadVideo-UploadVideoCommand-FormFile'></a>
### FormFile `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Application-Requests-Files-Commands-UploadVideo-UploadVideoCommand-UploadVideoCommandHandler'></a>
## UploadVideoCommandHandler `type`

##### Namespace

Definux.Emeraude.Application.Requests.Files.Commands.UploadVideo.UploadVideoCommand

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Application-Requests-Files-Commands-UploadVideo-UploadVideoCommand-UploadVideoCommandHandler-#ctor-Definux-Emeraude-Application-Files-IFilesValidationProvider,Definux-Emeraude-Application-Files-ISystemFilesService,Definux-Emeraude-Application-Files-IUploadService-'></a>
### #ctor(validationProvider,systemFilesService,uploadService) `constructor`

##### Summary

Initializes a new instance of the [UploadVideoCommandHandler](#T-Definux-Emeraude-Application-Requests-Files-Commands-UploadVideo-UploadVideoCommand-UploadVideoCommandHandler 'Definux.Emeraude.Application.Requests.Files.Commands.UploadVideo.UploadVideoCommand.UploadVideoCommandHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| validationProvider | [Definux.Emeraude.Application.Files.IFilesValidationProvider](#T-Definux-Emeraude-Application-Files-IFilesValidationProvider 'Definux.Emeraude.Application.Files.IFilesValidationProvider') |  |
| systemFilesService | [Definux.Emeraude.Application.Files.ISystemFilesService](#T-Definux-Emeraude-Application-Files-ISystemFilesService 'Definux.Emeraude.Application.Files.ISystemFilesService') |  |
| uploadService | [Definux.Emeraude.Application.Files.IUploadService](#T-Definux-Emeraude-Application-Files-IUploadService 'Definux.Emeraude.Application.Files.IUploadService') |  |

<a name='M-Definux-Emeraude-Application-Requests-Files-Commands-UploadVideo-UploadVideoCommand-UploadVideoCommandHandler-Handle-Definux-Emeraude-Application-Requests-Files-Commands-UploadVideo-UploadVideoCommand,System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserAvatar-UserAvatarTypeResult'></a>
## UserAvatarTypeResult `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Queries.GetUserAvatar

##### Summary

Result of [GetUserAvatarQuery](#T-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserAvatar-GetUserAvatarQuery 'Definux.Emeraude.Application.Requests.Identity.Queries.GetUserAvatar.GetUserAvatarQuery').

<a name='P-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserAvatar-UserAvatarTypeResult-IsDefault'></a>
### IsDefault `property`

##### Summary

Flag that indicates whether the result avatar is the system default or not.

<a name='T-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserExternalLoginProviders-UserExternalLoginProvider'></a>
## UserExternalLoginProvider `type`

##### Namespace

Definux.Emeraude.Application.Requests.Identity.Queries.GetUserExternalLoginProviders

##### Summary

Wrap for external login provider.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserExternalLoginProviders-UserExternalLoginProvider-Provider'></a>
### Provider `property`

##### Summary

External login provider.

<a name='P-Definux-Emeraude-Application-Requests-Identity-Queries-GetUserExternalLoginProviders-UserExternalLoginProvider-ProviderDisplayName'></a>
### ProviderDisplayName `property`

##### Summary

External login provider display name.

<a name='T-Definux-Emeraude-Application-Exceptions-ValidationException'></a>
## ValidationException `type`

##### Namespace

Definux.Emeraude.Application.Exceptions

##### Summary

Custom exception thrown on invalid fluent validation.

<a name='M-Definux-Emeraude-Application-Exceptions-ValidationException-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [ValidationException](#T-Definux-Emeraude-Application-Exceptions-ValidationException 'Definux.Emeraude.Application.Exceptions.ValidationException') class.

##### Parameters

This constructor has no parameters.

<a name='M-Definux-Emeraude-Application-Exceptions-ValidationException-#ctor-System-Collections-Generic-IEnumerable{FluentValidation-Results-ValidationFailure}-'></a>
### #ctor(failures) `constructor`

##### Summary

Initializes a new instance of the [ValidationException](#T-Definux-Emeraude-Application-Exceptions-ValidationException 'Definux.Emeraude.Application.Exceptions.ValidationException') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| failures | [System.Collections.Generic.IEnumerable{FluentValidation.Results.ValidationFailure}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{FluentValidation.Results.ValidationFailure}') |  |

<a name='P-Definux-Emeraude-Application-Exceptions-ValidationException-Failures'></a>
### Failures `property`

##### Summary

Dictionary with all failures of fluent validation.
