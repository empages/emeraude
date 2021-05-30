<a name='assembly'></a>
# Definux.Emeraude.Domain

## Contents

- [ActivityLog](#T-Definux-Emeraude-Domain-Logging-ActivityLog 'Definux.Emeraude.Domain.Logging.ActivityLog')
  - [Action](#P-Definux-Emeraude-Domain-Logging-ActivityLog-Action 'Definux.Emeraude.Domain.Logging.ActivityLog.Action')
  - [Area](#P-Definux-Emeraude-Domain-Logging-ActivityLog-Area 'Definux.Emeraude.Domain.Logging.ActivityLog.Area')
  - [Controller](#P-Definux-Emeraude-Domain-Logging-ActivityLog-Controller 'Definux.Emeraude.Domain.Logging.ActivityLog.Controller')
  - [Headers](#P-Definux-Emeraude-Domain-Logging-ActivityLog-Headers 'Definux.Emeraude.Domain.Logging.ActivityLog.Headers')
  - [IsAuthenticatedUser](#P-Definux-Emeraude-Domain-Logging-ActivityLog-IsAuthenticatedUser 'Definux.Emeraude.Domain.Logging.ActivityLog.IsAuthenticatedUser')
  - [IsFromMobileDevice](#P-Definux-Emeraude-Domain-Logging-ActivityLog-IsFromMobileDevice 'Definux.Emeraude.Domain.Logging.ActivityLog.IsFromMobileDevice')
  - [Method](#P-Definux-Emeraude-Domain-Logging-ActivityLog-Method 'Definux.Emeraude.Domain.Logging.ActivityLog.Method')
  - [Parameters](#P-Definux-Emeraude-Domain-Logging-ActivityLog-Parameters 'Definux.Emeraude.Domain.Logging.ActivityLog.Parameters')
  - [Route](#P-Definux-Emeraude-Domain-Logging-ActivityLog-Route 'Definux.Emeraude.Domain.Logging.ActivityLog.Route')
  - [TraceId](#P-Definux-Emeraude-Domain-Logging-ActivityLog-TraceId 'Definux.Emeraude.Domain.Logging.ActivityLog.TraceId')
  - [UserAgent](#P-Definux-Emeraude-Domain-Logging-ActivityLog-UserAgent 'Definux.Emeraude.Domain.Logging.ActivityLog.UserAgent')
- [AuditableEntity](#T-Definux-Emeraude-Domain-Entities-AuditableEntity 'Definux.Emeraude.Domain.Entities.AuditableEntity')
  - [CreatedBy](#P-Definux-Emeraude-Domain-Entities-AuditableEntity-CreatedBy 'Definux.Emeraude.Domain.Entities.AuditableEntity.CreatedBy')
  - [CreatedOn](#P-Definux-Emeraude-Domain-Entities-AuditableEntity-CreatedOn 'Definux.Emeraude.Domain.Entities.AuditableEntity.CreatedOn')
  - [UpdatedBy](#P-Definux-Emeraude-Domain-Entities-AuditableEntity-UpdatedBy 'Definux.Emeraude.Domain.Entities.AuditableEntity.UpdatedBy')
  - [UpdatedOn](#P-Definux-Emeraude-Domain-Entities-AuditableEntity-UpdatedOn 'Definux.Emeraude.Domain.Entities.AuditableEntity.UpdatedOn')
- [ContentKey](#T-Definux-Emeraude-Domain-Localization-ContentKey 'Definux.Emeraude.Domain.Localization.ContentKey')
  - [#ctor()](#M-Definux-Emeraude-Domain-Localization-ContentKey-#ctor 'Definux.Emeraude.Domain.Localization.ContentKey.#ctor')
  - [Id](#P-Definux-Emeraude-Domain-Localization-ContentKey-Id 'Definux.Emeraude.Domain.Localization.ContentKey.Id')
  - [Key](#P-Definux-Emeraude-Domain-Localization-ContentKey-Key 'Definux.Emeraude.Domain.Localization.ContentKey.Key')
  - [StaticContentList](#P-Definux-Emeraude-Domain-Localization-ContentKey-StaticContentList 'Definux.Emeraude.Domain.Localization.ContentKey.StaticContentList')
- [EmailLog](#T-Definux-Emeraude-Domain-Logging-EmailLog 'Definux.Emeraude.Domain.Logging.EmailLog')
  - [Body](#P-Definux-Emeraude-Domain-Logging-EmailLog-Body 'Definux.Emeraude.Domain.Logging.EmailLog.Body')
  - [EmailAddress](#P-Definux-Emeraude-Domain-Logging-EmailLog-EmailAddress 'Definux.Emeraude.Domain.Logging.EmailLog.EmailAddress')
  - [Receiver](#P-Definux-Emeraude-Domain-Logging-EmailLog-Receiver 'Definux.Emeraude.Domain.Logging.EmailLog.Receiver')
  - [Sent](#P-Definux-Emeraude-Domain-Logging-EmailLog-Sent 'Definux.Emeraude.Domain.Logging.EmailLog.Sent')
  - [Subject](#P-Definux-Emeraude-Domain-Logging-EmailLog-Subject 'Definux.Emeraude.Domain.Logging.EmailLog.Subject')
- [Entity](#T-Definux-Emeraude-Domain-Entities-Entity 'Definux.Emeraude.Domain.Entities.Entity')
  - [Id](#P-Definux-Emeraude-Domain-Entities-Entity-Id 'Definux.Emeraude.Domain.Entities.Entity.Id')
- [ErrorLog](#T-Definux-Emeraude-Domain-Logging-ErrorLog 'Definux.Emeraude.Domain.Logging.ErrorLog')
  - [Message](#P-Definux-Emeraude-Domain-Logging-ErrorLog-Message 'Definux.Emeraude.Domain.Logging.ErrorLog.Message')
  - [Method](#P-Definux-Emeraude-Domain-Logging-ErrorLog-Method 'Definux.Emeraude.Domain.Logging.ErrorLog.Method')
  - [Source](#P-Definux-Emeraude-Domain-Logging-ErrorLog-Source 'Definux.Emeraude.Domain.Logging.ErrorLog.Source')
  - [StackTrace](#P-Definux-Emeraude-Domain-Logging-ErrorLog-StackTrace 'Definux.Emeraude.Domain.Logging.ErrorLog.StackTrace')
- [IAuditableEntity](#T-Definux-Emeraude-Domain-Entities-IAuditableEntity 'Definux.Emeraude.Domain.Entities.IAuditableEntity')
  - [CreatedBy](#P-Definux-Emeraude-Domain-Entities-IAuditableEntity-CreatedBy 'Definux.Emeraude.Domain.Entities.IAuditableEntity.CreatedBy')
  - [CreatedOn](#P-Definux-Emeraude-Domain-Entities-IAuditableEntity-CreatedOn 'Definux.Emeraude.Domain.Entities.IAuditableEntity.CreatedOn')
  - [UpdatedBy](#P-Definux-Emeraude-Domain-Entities-IAuditableEntity-UpdatedBy 'Definux.Emeraude.Domain.Entities.IAuditableEntity.UpdatedBy')
  - [UpdatedOn](#P-Definux-Emeraude-Domain-Entities-IAuditableEntity-UpdatedOn 'Definux.Emeraude.Domain.Entities.IAuditableEntity.UpdatedOn')
- [IEntity](#T-Definux-Emeraude-Domain-Entities-IEntity 'Definux.Emeraude.Domain.Entities.IEntity')
  - [Id](#P-Definux-Emeraude-Domain-Entities-IEntity-Id 'Definux.Emeraude.Domain.Entities.IEntity.Id')
- [IEntityWithImage](#T-Definux-Emeraude-Domain-Entities-IEntityWithImage 'Definux.Emeraude.Domain.Entities.IEntityWithImage')
  - [ImageUrl](#P-Definux-Emeraude-Domain-Entities-IEntityWithImage-ImageUrl 'Definux.Emeraude.Domain.Entities.IEntityWithImage.ImageUrl')
- [ILoggerEntity](#T-Definux-Emeraude-Domain-Logging-ILoggerEntity 'Definux.Emeraude.Domain.Logging.ILoggerEntity')
  - [CreatedBy](#P-Definux-Emeraude-Domain-Logging-ILoggerEntity-CreatedBy 'Definux.Emeraude.Domain.Logging.ILoggerEntity.CreatedBy')
  - [CreatedOn](#P-Definux-Emeraude-Domain-Logging-ILoggerEntity-CreatedOn 'Definux.Emeraude.Domain.Logging.ILoggerEntity.CreatedOn')
  - [Id](#P-Definux-Emeraude-Domain-Logging-ILoggerEntity-Id 'Definux.Emeraude.Domain.Logging.ILoggerEntity.Id')
- [IUser](#T-Definux-Emeraude-Domain-Entities-IUser 'Definux.Emeraude.Domain.Entities.IUser')
  - [AvatarUrl](#P-Definux-Emeraude-Domain-Entities-IUser-AvatarUrl 'Definux.Emeraude.Domain.Entities.IUser.AvatarUrl')
  - [Email](#P-Definux-Emeraude-Domain-Entities-IUser-Email 'Definux.Emeraude.Domain.Entities.IUser.Email')
  - [Name](#P-Definux-Emeraude-Domain-Entities-IUser-Name 'Definux.Emeraude.Domain.Entities.IUser.Name')
  - [PhoneNumber](#P-Definux-Emeraude-Domain-Entities-IUser-PhoneNumber 'Definux.Emeraude.Domain.Entities.IUser.PhoneNumber')
  - [RegistrationDate](#P-Definux-Emeraude-Domain-Entities-IUser-RegistrationDate 'Definux.Emeraude.Domain.Entities.IUser.RegistrationDate')
- [Language](#T-Definux-Emeraude-Domain-Localization-Language 'Definux.Emeraude.Domain.Localization.Language')
  - [#ctor()](#M-Definux-Emeraude-Domain-Localization-Language-#ctor 'Definux.Emeraude.Domain.Localization.Language.#ctor')
  - [Code](#P-Definux-Emeraude-Domain-Localization-Language-Code 'Definux.Emeraude.Domain.Localization.Language.Code')
  - [Id](#P-Definux-Emeraude-Domain-Localization-Language-Id 'Definux.Emeraude.Domain.Localization.Language.Id')
  - [IsDefault](#P-Definux-Emeraude-Domain-Localization-Language-IsDefault 'Definux.Emeraude.Domain.Localization.Language.IsDefault')
  - [Name](#P-Definux-Emeraude-Domain-Localization-Language-Name 'Definux.Emeraude.Domain.Localization.Language.Name')
  - [NativeName](#P-Definux-Emeraude-Domain-Localization-Language-NativeName 'Definux.Emeraude.Domain.Localization.Language.NativeName')
  - [StaticContentList](#P-Definux-Emeraude-Domain-Localization-Language-StaticContentList 'Definux.Emeraude.Domain.Localization.Language.StaticContentList')
  - [Translations](#P-Definux-Emeraude-Domain-Localization-Language-Translations 'Definux.Emeraude.Domain.Localization.Language.Translations')
- [LoggerEntity](#T-Definux-Emeraude-Domain-Logging-LoggerEntity 'Definux.Emeraude.Domain.Logging.LoggerEntity')
  - [CreatedBy](#P-Definux-Emeraude-Domain-Logging-LoggerEntity-CreatedBy 'Definux.Emeraude.Domain.Logging.LoggerEntity.CreatedBy')
  - [CreatedOn](#P-Definux-Emeraude-Domain-Logging-LoggerEntity-CreatedOn 'Definux.Emeraude.Domain.Logging.LoggerEntity.CreatedOn')
  - [Id](#P-Definux-Emeraude-Domain-Logging-LoggerEntity-Id 'Definux.Emeraude.Domain.Logging.LoggerEntity.Id')
- [ObjectBuilder\`2](#T-Definux-Emeraude-Domain-Abstractions-ObjectBuilder`2 'Definux.Emeraude.Domain.Abstractions.ObjectBuilder`2')
  - [#ctor()](#M-Definux-Emeraude-Domain-Abstractions-ObjectBuilder`2-#ctor 'Definux.Emeraude.Domain.Abstractions.ObjectBuilder`2.#ctor')
  - [Entity](#P-Definux-Emeraude-Domain-Abstractions-ObjectBuilder`2-Entity 'Definux.Emeraude.Domain.Abstractions.ObjectBuilder`2.Entity')
  - [Build()](#M-Definux-Emeraude-Domain-Abstractions-ObjectBuilder`2-Build 'Definux.Emeraude.Domain.Abstractions.ObjectBuilder`2.Build')
  - [Init()](#M-Definux-Emeraude-Domain-Abstractions-ObjectBuilder`2-Init 'Definux.Emeraude.Domain.Abstractions.ObjectBuilder`2.Init')
- [StaticContent](#T-Definux-Emeraude-Domain-Localization-StaticContent 'Definux.Emeraude.Domain.Localization.StaticContent')
  - [Content](#P-Definux-Emeraude-Domain-Localization-StaticContent-Content 'Definux.Emeraude.Domain.Localization.StaticContent.Content')
  - [ContentKey](#P-Definux-Emeraude-Domain-Localization-StaticContent-ContentKey 'Definux.Emeraude.Domain.Localization.StaticContent.ContentKey')
  - [ContentKeyId](#P-Definux-Emeraude-Domain-Localization-StaticContent-ContentKeyId 'Definux.Emeraude.Domain.Localization.StaticContent.ContentKeyId')
  - [Id](#P-Definux-Emeraude-Domain-Localization-StaticContent-Id 'Definux.Emeraude.Domain.Localization.StaticContent.Id')
  - [Language](#P-Definux-Emeraude-Domain-Localization-StaticContent-Language 'Definux.Emeraude.Domain.Localization.StaticContent.Language')
  - [LanguageId](#P-Definux-Emeraude-Domain-Localization-StaticContent-LanguageId 'Definux.Emeraude.Domain.Localization.StaticContent.LanguageId')
- [TempFileLog](#T-Definux-Emeraude-Domain-Logging-TempFileLog 'Definux.Emeraude.Domain.Logging.TempFileLog')
  - [Applied](#P-Definux-Emeraude-Domain-Logging-TempFileLog-Applied 'Definux.Emeraude.Domain.Logging.TempFileLog.Applied')
  - [FileExtension](#P-Definux-Emeraude-Domain-Logging-TempFileLog-FileExtension 'Definux.Emeraude.Domain.Logging.TempFileLog.FileExtension')
  - [FileType](#P-Definux-Emeraude-Domain-Logging-TempFileLog-FileType 'Definux.Emeraude.Domain.Logging.TempFileLog.FileType')
  - [Name](#P-Definux-Emeraude-Domain-Logging-TempFileLog-Name 'Definux.Emeraude.Domain.Logging.TempFileLog.Name')
  - [NameWithExtension](#P-Definux-Emeraude-Domain-Logging-TempFileLog-NameWithExtension 'Definux.Emeraude.Domain.Logging.TempFileLog.NameWithExtension')
  - [Path](#P-Definux-Emeraude-Domain-Logging-TempFileLog-Path 'Definux.Emeraude.Domain.Logging.TempFileLog.Path')
- [TranslationKey](#T-Definux-Emeraude-Domain-Localization-TranslationKey 'Definux.Emeraude.Domain.Localization.TranslationKey')
  - [#ctor()](#M-Definux-Emeraude-Domain-Localization-TranslationKey-#ctor 'Definux.Emeraude.Domain.Localization.TranslationKey.#ctor')
  - [Id](#P-Definux-Emeraude-Domain-Localization-TranslationKey-Id 'Definux.Emeraude.Domain.Localization.TranslationKey.Id')
  - [Key](#P-Definux-Emeraude-Domain-Localization-TranslationKey-Key 'Definux.Emeraude.Domain.Localization.TranslationKey.Key')
  - [Translations](#P-Definux-Emeraude-Domain-Localization-TranslationKey-Translations 'Definux.Emeraude.Domain.Localization.TranslationKey.Translations')
- [TranslationValue](#T-Definux-Emeraude-Domain-Localization-TranslationValue 'Definux.Emeraude.Domain.Localization.TranslationValue')
  - [Id](#P-Definux-Emeraude-Domain-Localization-TranslationValue-Id 'Definux.Emeraude.Domain.Localization.TranslationValue.Id')
  - [Language](#P-Definux-Emeraude-Domain-Localization-TranslationValue-Language 'Definux.Emeraude.Domain.Localization.TranslationValue.Language')
  - [LanguageId](#P-Definux-Emeraude-Domain-Localization-TranslationValue-LanguageId 'Definux.Emeraude.Domain.Localization.TranslationValue.LanguageId')
  - [TranslationKey](#P-Definux-Emeraude-Domain-Localization-TranslationValue-TranslationKey 'Definux.Emeraude.Domain.Localization.TranslationValue.TranslationKey')
  - [TranslationKeyId](#P-Definux-Emeraude-Domain-Localization-TranslationValue-TranslationKeyId 'Definux.Emeraude.Domain.Localization.TranslationValue.TranslationKeyId')
  - [Value](#P-Definux-Emeraude-Domain-Localization-TranslationValue-Value 'Definux.Emeraude.Domain.Localization.TranslationValue.Value')
- [ValueObject](#T-Definux-Emeraude-Domain-Abstractions-ValueObject 'Definux.Emeraude.Domain.Abstractions.ValueObject')
  - [EqualOperator(left,right)](#M-Definux-Emeraude-Domain-Abstractions-ValueObject-EqualOperator-Definux-Emeraude-Domain-Abstractions-ValueObject,Definux-Emeraude-Domain-Abstractions-ValueObject- 'Definux.Emeraude.Domain.Abstractions.ValueObject.EqualOperator(Definux.Emeraude.Domain.Abstractions.ValueObject,Definux.Emeraude.Domain.Abstractions.ValueObject)')
  - [Equals()](#M-Definux-Emeraude-Domain-Abstractions-ValueObject-Equals-System-Object- 'Definux.Emeraude.Domain.Abstractions.ValueObject.Equals(System.Object)')
  - [GetEqualityComponents()](#M-Definux-Emeraude-Domain-Abstractions-ValueObject-GetEqualityComponents 'Definux.Emeraude.Domain.Abstractions.ValueObject.GetEqualityComponents')
  - [GetHashCode()](#M-Definux-Emeraude-Domain-Abstractions-ValueObject-GetHashCode 'Definux.Emeraude.Domain.Abstractions.ValueObject.GetHashCode')
  - [NotEqualOperator(left,right)](#M-Definux-Emeraude-Domain-Abstractions-ValueObject-NotEqualOperator-Definux-Emeraude-Domain-Abstractions-ValueObject,Definux-Emeraude-Domain-Abstractions-ValueObject- 'Definux.Emeraude.Domain.Abstractions.ValueObject.NotEqualOperator(Definux.Emeraude.Domain.Abstractions.ValueObject,Definux.Emeraude.Domain.Abstractions.ValueObject)')

<a name='T-Definux-Emeraude-Domain-Logging-ActivityLog'></a>
## ActivityLog `type`

##### Namespace

Definux.Emeraude.Domain.Logging

##### Summary

Log that store user activity for the current request.

<a name='P-Definux-Emeraude-Domain-Logging-ActivityLog-Action'></a>
### Action `property`

##### Summary

Name of the requested controller action.

<a name='P-Definux-Emeraude-Domain-Logging-ActivityLog-Area'></a>
### Area `property`

##### Summary

Name of the requested controller area.

<a name='P-Definux-Emeraude-Domain-Logging-ActivityLog-Controller'></a>
### Controller `property`

##### Summary

Name of the requested controller.

<a name='P-Definux-Emeraude-Domain-Logging-ActivityLog-Headers'></a>
### Headers `property`

##### Summary

List represent as a string for all request headers.

<a name='P-Definux-Emeraude-Domain-Logging-ActivityLog-IsAuthenticatedUser'></a>
### IsAuthenticatedUser `property`

##### Summary

Flag that indicates whether the request is made from authenticated user.

<a name='P-Definux-Emeraude-Domain-Logging-ActivityLog-IsFromMobileDevice'></a>
### IsFromMobileDevice `property`

##### Summary

Flag that indicates whether the request is made from mobile device.

<a name='P-Definux-Emeraude-Domain-Logging-ActivityLog-Method'></a>
### Method `property`

##### Summary

Current request HTTP method.

<a name='P-Definux-Emeraude-Domain-Logging-ActivityLog-Parameters'></a>
### Parameters `property`

##### Summary

List represent as a string for all request parameters.

<a name='P-Definux-Emeraude-Domain-Logging-ActivityLog-Route'></a>
### Route `property`

##### Summary

Current request route.

<a name='P-Definux-Emeraude-Domain-Logging-ActivityLog-TraceId'></a>
### TraceId `property`

##### Summary

Unique string that unify each user.

<a name='P-Definux-Emeraude-Domain-Logging-ActivityLog-UserAgent'></a>
### UserAgent `property`

##### Summary

Current request user agent.

<a name='T-Definux-Emeraude-Domain-Entities-AuditableEntity'></a>
## AuditableEntity `type`

##### Namespace

Definux.Emeraude.Domain.Entities

##### Summary

Abstract class that represent domain entity with additional auditable information.

<a name='P-Definux-Emeraude-Domain-Entities-AuditableEntity-CreatedBy'></a>
### CreatedBy `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Domain-Entities-AuditableEntity-CreatedOn'></a>
### CreatedOn `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Domain-Entities-AuditableEntity-UpdatedBy'></a>
### UpdatedBy `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Domain-Entities-AuditableEntity-UpdatedOn'></a>
### UpdatedOn `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Domain-Localization-ContentKey'></a>
## ContentKey `type`

##### Namespace

Definux.Emeraude.Domain.Localization

##### Summary

Key of the static content.

<a name='M-Definux-Emeraude-Domain-Localization-ContentKey-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [ContentKey](#T-Definux-Emeraude-Domain-Localization-ContentKey 'Definux.Emeraude.Domain.Localization.ContentKey') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Domain-Localization-ContentKey-Id'></a>
### Id `property`

##### Summary

Id of the content key.

<a name='P-Definux-Emeraude-Domain-Localization-ContentKey-Key'></a>
### Key `property`

##### Summary

Key of the content key.

<a name='P-Definux-Emeraude-Domain-Localization-ContentKey-StaticContentList'></a>
### StaticContentList `property`

##### Summary

List of all static content items which are using the key.

<a name='T-Definux-Emeraude-Domain-Logging-EmailLog'></a>
## EmailLog `type`

##### Namespace

Definux.Emeraude.Domain.Logging

##### Summary

Log that represent sending email try from the system.

<a name='P-Definux-Emeraude-Domain-Logging-EmailLog-Body'></a>
### Body `property`

##### Summary

Body of the email.

<a name='P-Definux-Emeraude-Domain-Logging-EmailLog-EmailAddress'></a>
### EmailAddress `property`

##### Summary

Email address.

<a name='P-Definux-Emeraude-Domain-Logging-EmailLog-Receiver'></a>
### Receiver `property`

##### Summary

Receiver of the email.

<a name='P-Definux-Emeraude-Domain-Logging-EmailLog-Sent'></a>
### Sent `property`

##### Summary

Flag that indicates whether email is sent or not.

<a name='P-Definux-Emeraude-Domain-Logging-EmailLog-Subject'></a>
### Subject `property`

##### Summary

Subject of the email.

<a name='T-Definux-Emeraude-Domain-Entities-Entity'></a>
## Entity `type`

##### Namespace

Definux.Emeraude.Domain.Entities

##### Summary

Abstract class that represent the domain entity.

<a name='P-Definux-Emeraude-Domain-Entities-Entity-Id'></a>
### Id `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Domain-Logging-ErrorLog'></a>
## ErrorLog `type`

##### Namespace

Definux.Emeraude.Domain.Logging

##### Summary

Log that represent errors and exception from the system.

<a name='P-Definux-Emeraude-Domain-Logging-ErrorLog-Message'></a>
### Message `property`

##### Summary

Error message.

<a name='P-Definux-Emeraude-Domain-Logging-ErrorLog-Method'></a>
### Method `property`

##### Summary

Name of the from where the error comes.

<a name='P-Definux-Emeraude-Domain-Logging-ErrorLog-Source'></a>
### Source `property`

##### Summary

Error source.

<a name='P-Definux-Emeraude-Domain-Logging-ErrorLog-StackTrace'></a>
### StackTrace `property`

##### Summary

Stack trace of the exception.

<a name='T-Definux-Emeraude-Domain-Entities-IAuditableEntity'></a>
## IAuditableEntity `type`

##### Namespace

Definux.Emeraude.Domain.Entities

##### Summary

Interface that represent domain entity with additional auditable information.

<a name='P-Definux-Emeraude-Domain-Entities-IAuditableEntity-CreatedBy'></a>
### CreatedBy `property`

##### Summary

Identification of the user that create the entity.

<a name='P-Definux-Emeraude-Domain-Entities-IAuditableEntity-CreatedOn'></a>
### CreatedOn `property`

##### Summary

Date of creation of the entity.

<a name='P-Definux-Emeraude-Domain-Entities-IAuditableEntity-UpdatedBy'></a>
### UpdatedBy `property`

##### Summary

Identification of the user that last modified the entity.

<a name='P-Definux-Emeraude-Domain-Entities-IAuditableEntity-UpdatedOn'></a>
### UpdatedOn `property`

##### Summary

Date of last modification of the entity.

<a name='T-Definux-Emeraude-Domain-Entities-IEntity'></a>
## IEntity `type`

##### Namespace

Definux.Emeraude.Domain.Entities

##### Summary

Interface that represent the domain entity.

<a name='P-Definux-Emeraude-Domain-Entities-IEntity-Id'></a>
### Id `property`

##### Summary

Identification of the entity.

<a name='T-Definux-Emeraude-Domain-Entities-IEntityWithImage'></a>
## IEntityWithImage `type`

##### Namespace

Definux.Emeraude.Domain.Entities

##### Summary

Interface that represent domain entity with additional image.

<a name='P-Definux-Emeraude-Domain-Entities-IEntityWithImage-ImageUrl'></a>
### ImageUrl `property`

##### Summary

Url of the image of the entity.

<a name='T-Definux-Emeraude-Domain-Logging-ILoggerEntity'></a>
## ILoggerEntity `type`

##### Namespace

Definux.Emeraude.Domain.Logging

##### Summary

Interface log entity, parent for all logs into the system.

<a name='P-Definux-Emeraude-Domain-Logging-ILoggerEntity-CreatedBy'></a>
### CreatedBy `property`

##### Summary

Creator id of the logger entity.

<a name='P-Definux-Emeraude-Domain-Logging-ILoggerEntity-CreatedOn'></a>
### CreatedOn `property`

##### Summary

Creation date of the logger entity.

<a name='P-Definux-Emeraude-Domain-Logging-ILoggerEntity-Id'></a>
### Id `property`

##### Summary

Id of the logger entity.

<a name='T-Definux-Emeraude-Domain-Entities-IUser'></a>
## IUser `type`

##### Namespace

Definux.Emeraude.Domain.Entities

##### Summary

Interface that represent user of the application.

<a name='P-Definux-Emeraude-Domain-Entities-IUser-AvatarUrl'></a>
### AvatarUrl `property`

##### Summary

Avatar URL of the user.

<a name='P-Definux-Emeraude-Domain-Entities-IUser-Email'></a>
### Email `property`

##### Summary

Email address of the user.

<a name='P-Definux-Emeraude-Domain-Entities-IUser-Name'></a>
### Name `property`

##### Summary

Name of the user.

<a name='P-Definux-Emeraude-Domain-Entities-IUser-PhoneNumber'></a>
### PhoneNumber `property`

##### Summary

Phone number of the user.

<a name='P-Definux-Emeraude-Domain-Entities-IUser-RegistrationDate'></a>
### RegistrationDate `property`

##### Summary

Registration date of the user.

<a name='T-Definux-Emeraude-Domain-Localization-Language'></a>
## Language `type`

##### Namespace

Definux.Emeraude.Domain.Localization

##### Summary

Class that represent language definition into the system.

<a name='M-Definux-Emeraude-Domain-Localization-Language-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [Language](#T-Definux-Emeraude-Domain-Localization-Language 'Definux.Emeraude.Domain.Localization.Language') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Domain-Localization-Language-Code'></a>
### Code `property`

##### Summary

Language short code.

<a name='P-Definux-Emeraude-Domain-Localization-Language-Id'></a>
### Id `property`

##### Summary

Id of the language.

<a name='P-Definux-Emeraude-Domain-Localization-Language-IsDefault'></a>
### IsDefault `property`

##### Summary

Flag that indicates whether the language is set as default for the application.

<a name='P-Definux-Emeraude-Domain-Localization-Language-Name'></a>
### Name `property`

##### Summary

System name of the language.

<a name='P-Definux-Emeraude-Domain-Localization-Language-NativeName'></a>
### NativeName `property`

##### Summary

Native name of the language.

<a name='P-Definux-Emeraude-Domain-Localization-Language-StaticContentList'></a>
### StaticContentList `property`

##### Summary

List of all static content items for the language.

<a name='P-Definux-Emeraude-Domain-Localization-Language-Translations'></a>
### Translations `property`

##### Summary

List of all translations for the language.

<a name='T-Definux-Emeraude-Domain-Logging-LoggerEntity'></a>
## LoggerEntity `type`

##### Namespace

Definux.Emeraude.Domain.Logging

##### Summary

Abstract log entity, parent for all logs into the system.

<a name='P-Definux-Emeraude-Domain-Logging-LoggerEntity-CreatedBy'></a>
### CreatedBy `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Domain-Logging-LoggerEntity-CreatedOn'></a>
### CreatedOn `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Domain-Logging-LoggerEntity-Id'></a>
### Id `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Domain-Abstractions-ObjectBuilder`2'></a>
## ObjectBuilder\`2 `type`

##### Namespace

Definux.Emeraude.Domain.Abstractions

##### Summary

Abstract class that represent helper for create object builder for creation domein entity with builder pattern.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | Target entity. |
| TEntityBuilder | Target entity builder. |

<a name='M-Definux-Emeraude-Domain-Abstractions-ObjectBuilder`2-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [ObjectBuilder\`2](#T-Definux-Emeraude-Domain-Abstractions-ObjectBuilder`2 'Definux.Emeraude.Domain.Abstractions.ObjectBuilder`2') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Domain-Abstractions-ObjectBuilder`2-Entity'></a>
### Entity `property`

##### Summary

Target entity.

<a name='M-Definux-Emeraude-Domain-Abstractions-ObjectBuilder`2-Build'></a>
### Build() `method`

##### Summary

Finalize method for the builder that build and return the target entity.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Domain-Abstractions-ObjectBuilder`2-Init'></a>
### Init() `method`

##### Summary

Initialization step for the builder.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Domain-Localization-StaticContent'></a>
## StaticContent `type`

##### Namespace

Definux.Emeraude.Domain.Localization

##### Summary

Static content for a key and language.

<a name='P-Definux-Emeraude-Domain-Localization-StaticContent-Content'></a>
### Content `property`

##### Summary

Static content text.

<a name='P-Definux-Emeraude-Domain-Localization-StaticContent-ContentKey'></a>
### ContentKey `property`

##### Summary

Entity of the key of the static content.

<a name='P-Definux-Emeraude-Domain-Localization-StaticContent-ContentKeyId'></a>
### ContentKeyId `property`

##### Summary

Id of the key of the static content.

<a name='P-Definux-Emeraude-Domain-Localization-StaticContent-Id'></a>
### Id `property`

##### Summary

Id of the static content.

<a name='P-Definux-Emeraude-Domain-Localization-StaticContent-Language'></a>
### Language `property`

##### Summary

Entity of the language of the static content.

<a name='P-Definux-Emeraude-Domain-Localization-StaticContent-LanguageId'></a>
### LanguageId `property`

##### Summary

Id of the language of the static content.

<a name='T-Definux-Emeraude-Domain-Logging-TempFileLog'></a>
## TempFileLog `type`

##### Namespace

Definux.Emeraude.Domain.Logging

##### Summary

Log that represent uploaded files - mainly the temp files.

<a name='P-Definux-Emeraude-Domain-Logging-TempFileLog-Applied'></a>
### Applied `property`

##### Summary

Flag that indicates whether the file is applied or it is just a temp file and it is not already used.

<a name='P-Definux-Emeraude-Domain-Logging-TempFileLog-FileExtension'></a>
### FileExtension `property`

##### Summary

Extension type of the file.

<a name='P-Definux-Emeraude-Domain-Logging-TempFileLog-FileType'></a>
### FileType `property`

##### Summary

Type of the file.

<a name='P-Definux-Emeraude-Domain-Logging-TempFileLog-Name'></a>
### Name `property`

##### Summary

Name of the file (without extension).

<a name='P-Definux-Emeraude-Domain-Logging-TempFileLog-NameWithExtension'></a>
### NameWithExtension `property`

##### Summary

Name of the file with its extension.

<a name='P-Definux-Emeraude-Domain-Logging-TempFileLog-Path'></a>
### Path `property`

##### Summary

Relative path of the file.

<a name='T-Definux-Emeraude-Domain-Localization-TranslationKey'></a>
## TranslationKey `type`

##### Namespace

Definux.Emeraude.Domain.Localization

##### Summary

Key of the translation.

<a name='M-Definux-Emeraude-Domain-Localization-TranslationKey-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [TranslationKey](#T-Definux-Emeraude-Domain-Localization-TranslationKey 'Definux.Emeraude.Domain.Localization.TranslationKey') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Domain-Localization-TranslationKey-Id'></a>
### Id `property`

##### Summary

Id of the translation key.

<a name='P-Definux-Emeraude-Domain-Localization-TranslationKey-Key'></a>
### Key `property`

##### Summary

Key of the translation key.

<a name='P-Definux-Emeraude-Domain-Localization-TranslationKey-Translations'></a>
### Translations `property`

##### Summary

List of all translations which are using the key.

<a name='T-Definux-Emeraude-Domain-Localization-TranslationValue'></a>
## TranslationValue `type`

##### Namespace

Definux.Emeraude.Domain.Localization

##### Summary

Translation text based on translation key and language.

<a name='P-Definux-Emeraude-Domain-Localization-TranslationValue-Id'></a>
### Id `property`

##### Summary

Id of the translation.

<a name='P-Definux-Emeraude-Domain-Localization-TranslationValue-Language'></a>
### Language `property`

##### Summary

Entity of the language of the translation.

<a name='P-Definux-Emeraude-Domain-Localization-TranslationValue-LanguageId'></a>
### LanguageId `property`

##### Summary

Id of the language of the translation.

<a name='P-Definux-Emeraude-Domain-Localization-TranslationValue-TranslationKey'></a>
### TranslationKey `property`

##### Summary

Entity of the key of the translation.

<a name='P-Definux-Emeraude-Domain-Localization-TranslationValue-TranslationKeyId'></a>
### TranslationKeyId `property`

##### Summary

Id of the key of the translation.

<a name='P-Definux-Emeraude-Domain-Localization-TranslationValue-Value'></a>
### Value `property`

##### Summary

Translation value.

<a name='T-Definux-Emeraude-Domain-Abstractions-ValueObject'></a>
## ValueObject `type`

##### Namespace

Definux.Emeraude.Domain.Abstractions

##### Summary

Abstract class for domain value object definition.

<a name='M-Definux-Emeraude-Domain-Abstractions-ValueObject-EqualOperator-Definux-Emeraude-Domain-Abstractions-ValueObject,Definux-Emeraude-Domain-Abstractions-ValueObject-'></a>
### EqualOperator(left,right) `method`

##### Summary

Check for equality between two value objects.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Definux.Emeraude.Domain.Abstractions.ValueObject](#T-Definux-Emeraude-Domain-Abstractions-ValueObject 'Definux.Emeraude.Domain.Abstractions.ValueObject') |  |
| right | [Definux.Emeraude.Domain.Abstractions.ValueObject](#T-Definux-Emeraude-Domain-Abstractions-ValueObject 'Definux.Emeraude.Domain.Abstractions.ValueObject') |  |

<a name='M-Definux-Emeraude-Domain-Abstractions-ValueObject-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Domain-Abstractions-ValueObject-GetEqualityComponents'></a>
### GetEqualityComponents() `method`

##### Summary

Method that returns equality components of the value object.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Domain-Abstractions-ValueObject-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Domain-Abstractions-ValueObject-NotEqualOperator-Definux-Emeraude-Domain-Abstractions-ValueObject,Definux-Emeraude-Domain-Abstractions-ValueObject-'></a>
### NotEqualOperator(left,right) `method`

##### Summary

Checo for lack of equality between two value objects.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Definux.Emeraude.Domain.Abstractions.ValueObject](#T-Definux-Emeraude-Domain-Abstractions-ValueObject 'Definux.Emeraude.Domain.Abstractions.ValueObject') |  |
| right | [Definux.Emeraude.Domain.Abstractions.ValueObject](#T-Definux-Emeraude-Domain-Abstractions-ValueObject 'Definux.Emeraude.Domain.Abstractions.ValueObject') |  |
