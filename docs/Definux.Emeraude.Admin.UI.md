<a name='assembly'></a>
# Definux.Emeraude.Admin.UI

## Contents

- [ActivityLogViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Logging-ActivityLogViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Logging.ActivityLogViewModel')
  - [Action](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ActivityLogViewModel-Action 'Definux.Emeraude.Admin.UI.ViewModels.Logging.ActivityLogViewModel.Action')
  - [Area](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ActivityLogViewModel-Area 'Definux.Emeraude.Admin.UI.ViewModels.Logging.ActivityLogViewModel.Area')
  - [Controller](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ActivityLogViewModel-Controller 'Definux.Emeraude.Admin.UI.ViewModels.Logging.ActivityLogViewModel.Controller')
  - [Headers](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ActivityLogViewModel-Headers 'Definux.Emeraude.Admin.UI.ViewModels.Logging.ActivityLogViewModel.Headers')
  - [IsAuthenticatedUser](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ActivityLogViewModel-IsAuthenticatedUser 'Definux.Emeraude.Admin.UI.ViewModels.Logging.ActivityLogViewModel.IsAuthenticatedUser')
  - [IsFromMobileDevice](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ActivityLogViewModel-IsFromMobileDevice 'Definux.Emeraude.Admin.UI.ViewModels.Logging.ActivityLogViewModel.IsFromMobileDevice')
  - [Method](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ActivityLogViewModel-Method 'Definux.Emeraude.Admin.UI.ViewModels.Logging.ActivityLogViewModel.Method')
  - [Parameters](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ActivityLogViewModel-Parameters 'Definux.Emeraude.Admin.UI.ViewModels.Logging.ActivityLogViewModel.Parameters')
  - [Route](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ActivityLogViewModel-Route 'Definux.Emeraude.Admin.UI.ViewModels.Logging.ActivityLogViewModel.Route')
  - [TraceId](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ActivityLogViewModel-TraceId 'Definux.Emeraude.Admin.UI.ViewModels.Logging.ActivityLogViewModel.TraceId')
  - [UserAgent](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ActivityLogViewModel-UserAgent 'Definux.Emeraude.Admin.UI.ViewModels.Logging.ActivityLogViewModel.UserAgent')
- [ActivityLogsViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Logging-ActivityLogsViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Logging.ActivityLogsViewModel')
- [AdminChangeEmailViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminChangeEmailViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Manage.AdminChangeEmailViewModel')
  - [NewEmail](#P-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminChangeEmailViewModel-NewEmail 'Definux.Emeraude.Admin.UI.ViewModels.Manage.AdminChangeEmailViewModel.NewEmail')
- [AdminChangePasswordViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminChangePasswordViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Manage.AdminChangePasswordViewModel')
  - [ConfirmedPassword](#P-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminChangePasswordViewModel-ConfirmedPassword 'Definux.Emeraude.Admin.UI.ViewModels.Manage.AdminChangePasswordViewModel.ConfirmedPassword')
  - [CurrentPassword](#P-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminChangePasswordViewModel-CurrentPassword 'Definux.Emeraude.Admin.UI.ViewModels.Manage.AdminChangePasswordViewModel.CurrentPassword')
  - [NewPassword](#P-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminChangePasswordViewModel-NewPassword 'Definux.Emeraude.Admin.UI.ViewModels.Manage.AdminChangePasswordViewModel.NewPassword')
- [AdminLoginViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Account-AdminLoginViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Account.AdminLoginViewModel')
  - [Email](#P-Definux-Emeraude-Admin-UI-ViewModels-Account-AdminLoginViewModel-Email 'Definux.Emeraude.Admin.UI.ViewModels.Account.AdminLoginViewModel.Email')
  - [Password](#P-Definux-Emeraude-Admin-UI-ViewModels-Account-AdminLoginViewModel-Password 'Definux.Emeraude.Admin.UI.ViewModels.Account.AdminLoginViewModel.Password')
- [AdminLoginWith2FaViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Account-AdminLoginWith2FaViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Account.AdminLoginWith2FaViewModel')
  - [TwoFactorCode](#P-Definux-Emeraude-Admin-UI-ViewModels-Account-AdminLoginWith2FaViewModel-TwoFactorCode 'Definux.Emeraude.Admin.UI.ViewModels.Account.AdminLoginWith2FaViewModel.TwoFactorCode')
- [AdminNavigationScheme](#T-Definux-Emeraude-Admin-UI-AdminMenu-AdminNavigationScheme 'Definux.Emeraude.Admin.UI.AdminMenu.AdminNavigationScheme')
  - [#ctor(contentRootPath,role)](#M-Definux-Emeraude-Admin-UI-AdminMenu-AdminNavigationScheme-#ctor-System-String,System-String- 'Definux.Emeraude.Admin.UI.AdminMenu.AdminNavigationScheme.#ctor(System.String,System.String)')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-AdminMenu-AdminNavigationScheme-#ctor 'Definux.Emeraude.Admin.UI.AdminMenu.AdminNavigationScheme.#ctor')
  - [InsightsItems](#P-Definux-Emeraude-Admin-UI-AdminMenu-AdminNavigationScheme-InsightsItems 'Definux.Emeraude.Admin.UI.AdminMenu.AdminNavigationScheme.InsightsItems')
  - [Menus](#P-Definux-Emeraude-Admin-UI-AdminMenu-AdminNavigationScheme-Menus 'Definux.Emeraude.Admin.UI.AdminMenu.AdminNavigationScheme.Menus')
  - [ApplyCurrentRoute(currentRoute)](#M-Definux-Emeraude-Admin-UI-AdminMenu-AdminNavigationScheme-ApplyCurrentRoute-System-String- 'Definux.Emeraude.Admin.UI.AdminMenu.AdminNavigationScheme.ApplyCurrentRoute(System.String)')
- [AdminTwoFactorAuthenticationViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminTwoFactorAuthenticationViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Manage.AdminTwoFactorAuthenticationViewModel')
  - [AuthenticatorUri](#P-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminTwoFactorAuthenticationViewModel-AuthenticatorUri 'Definux.Emeraude.Admin.UI.ViewModels.Manage.AdminTwoFactorAuthenticationViewModel.AuthenticatorUri')
  - [Code](#P-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminTwoFactorAuthenticationViewModel-Code 'Definux.Emeraude.Admin.UI.ViewModels.Manage.AdminTwoFactorAuthenticationViewModel.Code')
  - [HasAuthenticator](#P-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminTwoFactorAuthenticationViewModel-HasAuthenticator 'Definux.Emeraude.Admin.UI.ViewModels.Manage.AdminTwoFactorAuthenticationViewModel.HasAuthenticator')
  - [Is2faEnabled](#P-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminTwoFactorAuthenticationViewModel-Is2faEnabled 'Definux.Emeraude.Admin.UI.ViewModels.Manage.AdminTwoFactorAuthenticationViewModel.Is2faEnabled')
  - [SharedKey](#P-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminTwoFactorAuthenticationViewModel-SharedKey 'Definux.Emeraude.Admin.UI.ViewModels.Manage.AdminTwoFactorAuthenticationViewModel.SharedKey')
- [AdminUIAssemblyPart](#T-Definux-Emeraude-Admin-UI-AdminUIAssemblyPart 'Definux.Emeraude.Admin.UI.AdminUIAssemblyPart')
  - [Assembly](#P-Definux-Emeraude-Admin-UI-AdminUIAssemblyPart-Assembly 'Definux.Emeraude.Admin.UI.AdminUIAssemblyPart.Assembly')
  - [AssemblyPart](#P-Definux-Emeraude-Admin-UI-AdminUIAssemblyPart-AssemblyPart 'Definux.Emeraude.Admin.UI.AdminUIAssemblyPart.AssemblyPart')
- [AdminUIConfigureOptions](#T-Definux-Emeraude-Admin-UI-AdminUIConfigureOptions 'Definux.Emeraude.Admin.UI.AdminUIConfigureOptions')
  - [#ctor(environment)](#M-Definux-Emeraude-Admin-UI-AdminUIConfigureOptions-#ctor-Microsoft-AspNetCore-Hosting-IHostingEnvironment- 'Definux.Emeraude.Admin.UI.AdminUIConfigureOptions.#ctor(Microsoft.AspNetCore.Hosting.IHostingEnvironment)')
- [BodyTagHelper](#T-Definux-Emeraude-Admin-UI-TagHelpers-BodyTagHelper 'Definux.Emeraude.Admin.UI.TagHelpers.BodyTagHelper')
  - [ViewContext](#P-Definux-Emeraude-Admin-UI-TagHelpers-BodyTagHelper-ViewContext 'Definux.Emeraude.Admin.UI.TagHelpers.BodyTagHelper.ViewContext')
  - [ProcessAsync()](#M-Definux-Emeraude-Admin-UI-TagHelpers-BodyTagHelper-ProcessAsync-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput- 'Definux.Emeraude.Admin.UI.TagHelpers.BodyTagHelper.ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput)')
- [BreadcrumbItemViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Layout.BreadcrumbItemViewModel')
  - [#ctor(context)](#M-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel-#ctor-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext- 'Definux.Emeraude.Admin.UI.ViewModels.Layout.BreadcrumbItemViewModel.#ctor(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext)')
  - [BreadcrumbKey](#F-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel-BreadcrumbKey 'Definux.Emeraude.Admin.UI.ViewModels.Layout.BreadcrumbItemViewModel.BreadcrumbKey')
  - [Action](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel-Action 'Definux.Emeraude.Admin.UI.ViewModels.Layout.BreadcrumbItemViewModel.Action')
  - [ActionLink](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel-ActionLink 'Definux.Emeraude.Admin.UI.ViewModels.Layout.BreadcrumbItemViewModel.ActionLink')
  - [Active](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel-Active 'Definux.Emeraude.Admin.UI.ViewModels.Layout.BreadcrumbItemViewModel.Active')
  - [Controller](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel-Controller 'Definux.Emeraude.Admin.UI.ViewModels.Layout.BreadcrumbItemViewModel.Controller')
  - [Order](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel-Order 'Definux.Emeraude.Admin.UI.ViewModels.Layout.BreadcrumbItemViewModel.Order')
  - [ParameterName](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel-ParameterName 'Definux.Emeraude.Admin.UI.ViewModels.Layout.BreadcrumbItemViewModel.ParameterName')
  - [ParameterValue](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel-ParameterValue 'Definux.Emeraude.Admin.UI.ViewModels.Layout.BreadcrumbItemViewModel.ParameterValue')
  - [ParentReferenceKey](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel-ParentReferenceKey 'Definux.Emeraude.Admin.UI.ViewModels.Layout.BreadcrumbItemViewModel.ParentReferenceKey')
  - [ParentReferenceValue](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel-ParentReferenceValue 'Definux.Emeraude.Admin.UI.ViewModels.Layout.BreadcrumbItemViewModel.ParentReferenceValue')
  - [Title](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel-Title 'Definux.Emeraude.Admin.UI.ViewModels.Layout.BreadcrumbItemViewModel.Title')
- [CheckboxGroupHtmlBuilder\`1](#T-Definux-Emeraude-Admin-UI-HtmlBuilders-CheckboxGroupHtmlBuilder`1 'Definux.Emeraude.Admin.UI.HtmlBuilders.CheckboxGroupHtmlBuilder`1')
  - [#ctor(data,targetProperty,selectedValues)](#M-Definux-Emeraude-Admin-UI-HtmlBuilders-CheckboxGroupHtmlBuilder`1-#ctor-System-Collections-Generic-Dictionary{`0,System-String},System-String,`0[]- 'Definux.Emeraude.Admin.UI.HtmlBuilders.CheckboxGroupHtmlBuilder`1.#ctor(System.Collections.Generic.Dictionary{`0,System.String},System.String,`0[])')
- [CurrentUserTagHelper](#T-Definux-Emeraude-Admin-UI-TagHelpers-CurrentUserTagHelper 'Definux.Emeraude.Admin.UI.TagHelpers.CurrentUserTagHelper')
  - [#ctor(identityUserInfoAdapter)](#M-Definux-Emeraude-Admin-UI-TagHelpers-CurrentUserTagHelper-#ctor-Definux-Emeraude-Admin-UI-Adapters-IIdentityUserInfoAdapter- 'Definux.Emeraude.Admin.UI.TagHelpers.CurrentUserTagHelper.#ctor(Definux.Emeraude.Admin.UI.Adapters.IIdentityUserInfoAdapter)')
  - [ProcessAsync()](#M-Definux-Emeraude-Admin-UI-TagHelpers-CurrentUserTagHelper-ProcessAsync-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput- 'Definux.Emeraude.Admin.UI.TagHelpers.CurrentUserTagHelper.ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput)')
- [DataSourceMap\`1](#T-Definux-Emeraude-Admin-UI-UIElements-DataSourceMap`1 'Definux.Emeraude.Admin.UI.UIElements.DataSourceMap`1')
  - [#ctor(context)](#M-Definux-Emeraude-Admin-UI-UIElements-DataSourceMap`1-#ctor-`0- 'Definux.Emeraude.Admin.UI.UIElements.DataSourceMap`1.#ctor(`0)')
  - [Context](#P-Definux-Emeraude-Admin-UI-UIElements-DataSourceMap`1-Context 'Definux.Emeraude.Admin.UI.UIElements.DataSourceMap`1.Context')
  - [Init()](#M-Definux-Emeraude-Admin-UI-UIElements-DataSourceMap`1-Init 'Definux.Emeraude.Admin.UI.UIElements.DataSourceMap`1.Init')
- [DatePickerHtmlBuilder](#T-Definux-Emeraude-Admin-UI-HtmlBuilders-DatePickerHtmlBuilder 'Definux.Emeraude.Admin.UI.HtmlBuilders.DatePickerHtmlBuilder')
  - [#ctor(targetProperty,value,placeholder)](#M-Definux-Emeraude-Admin-UI-HtmlBuilders-DatePickerHtmlBuilder-#ctor-System-String,System-Nullable{System-DateTime},System-String- 'Definux.Emeraude.Admin.UI.HtmlBuilders.DatePickerHtmlBuilder.#ctor(System.String,System.Nullable{System.DateTime},System.String)')
- [DatePickerTagHelper](#T-Definux-Emeraude-Admin-UI-TagHelpers-DatePickerTagHelper 'Definux.Emeraude.Admin.UI.TagHelpers.DatePickerTagHelper')
  - [Name](#P-Definux-Emeraude-Admin-UI-TagHelpers-DatePickerTagHelper-Name 'Definux.Emeraude.Admin.UI.TagHelpers.DatePickerTagHelper.Name')
  - [Placeholder](#P-Definux-Emeraude-Admin-UI-TagHelpers-DatePickerTagHelper-Placeholder 'Definux.Emeraude.Admin.UI.TagHelpers.DatePickerTagHelper.Placeholder')
  - [Value](#P-Definux-Emeraude-Admin-UI-TagHelpers-DatePickerTagHelper-Value 'Definux.Emeraude.Admin.UI.TagHelpers.DatePickerTagHelper.Value')
  - [Process()](#M-Definux-Emeraude-Admin-UI-TagHelpers-DatePickerTagHelper-Process-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput- 'Definux.Emeraude.Admin.UI.TagHelpers.DatePickerTagHelper.Process(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput)')
- [DefaultTableCellTagHelper](#T-Definux-Emeraude-Admin-UI-TagHelpers-DefaultTableCellTagHelper 'Definux.Emeraude.Admin.UI.TagHelpers.DefaultTableCellTagHelper')
  - [Fit](#P-Definux-Emeraude-Admin-UI-TagHelpers-DefaultTableCellTagHelper-Fit 'Definux.Emeraude.Admin.UI.TagHelpers.DefaultTableCellTagHelper.Fit')
  - [MakeCellApplicableForDefaultTable](#P-Definux-Emeraude-Admin-UI-TagHelpers-DefaultTableCellTagHelper-MakeCellApplicableForDefaultTable 'Definux.Emeraude.Admin.UI.TagHelpers.DefaultTableCellTagHelper.MakeCellApplicableForDefaultTable')
  - [Process()](#M-Definux-Emeraude-Admin-UI-TagHelpers-DefaultTableCellTagHelper-Process-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput- 'Definux.Emeraude.Admin.UI.TagHelpers.DefaultTableCellTagHelper.Process(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput)')
- [DefaultTableTagHelper](#T-Definux-Emeraude-Admin-UI-TagHelpers-DefaultTableTagHelper 'Definux.Emeraude.Admin.UI.TagHelpers.DefaultTableTagHelper')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-TagHelpers-DefaultTableTagHelper-#ctor 'Definux.Emeraude.Admin.UI.TagHelpers.DefaultTableTagHelper.#ctor')
  - [Columns](#P-Definux-Emeraude-Admin-UI-TagHelpers-DefaultTableTagHelper-Columns 'Definux.Emeraude.Admin.UI.TagHelpers.DefaultTableTagHelper.Columns')
  - [Process()](#M-Definux-Emeraude-Admin-UI-TagHelpers-DefaultTableTagHelper-Process-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput- 'Definux.Emeraude.Admin.UI.TagHelpers.DefaultTableTagHelper.Process(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput)')
- [DeleteLoggerEntityFormModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Layout-DeleteLoggerEntityFormModel 'Definux.Emeraude.Admin.UI.ViewModels.Layout.DeleteLoggerEntityFormModel')
  - [ButtonClasses](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-DeleteLoggerEntityFormModel-ButtonClasses 'Definux.Emeraude.Admin.UI.ViewModels.Layout.DeleteLoggerEntityFormModel.ButtonClasses')
  - [ButtonIconClasses](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-DeleteLoggerEntityFormModel-ButtonIconClasses 'Definux.Emeraude.Admin.UI.ViewModels.Layout.DeleteLoggerEntityFormModel.ButtonIconClasses')
  - [ButtonText](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-DeleteLoggerEntityFormModel-ButtonText 'Definux.Emeraude.Admin.UI.ViewModels.Layout.DeleteLoggerEntityFormModel.ButtonText')
  - [EntityId](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-DeleteLoggerEntityFormModel-EntityId 'Definux.Emeraude.Admin.UI.ViewModels.Layout.DeleteLoggerEntityFormModel.EntityId')
  - [FormClasses](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-DeleteLoggerEntityFormModel-FormClasses 'Definux.Emeraude.Admin.UI.ViewModels.Layout.DeleteLoggerEntityFormModel.FormClasses')
  - [LoggerEntityType](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-DeleteLoggerEntityFormModel-LoggerEntityType 'Definux.Emeraude.Admin.UI.ViewModels.Layout.DeleteLoggerEntityFormModel.LoggerEntityType')
- [DetailsFieldDataSourceMapElement\`1](#T-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldDataSourceMapElement`1 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldDataSourceMapElement`1')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldDataSourceMapElement`1-#ctor 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldDataSourceMapElement`1.#ctor')
  - [HasClipboardCopyButton](#P-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldDataSourceMapElement`1-HasClipboardCopyButton 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldDataSourceMapElement`1.HasClipboardCopyButton')
- [DetailsFieldDateElement](#T-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldDateElement 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldDateElement')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldDateElement-#ctor 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldDateElement.#ctor')
  - [HasClipboardCopyButton](#P-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldDateElement-HasClipboardCopyButton 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldDateElement.HasClipboardCopyButton')
- [DetailsFieldDateTimeElement](#T-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldDateTimeElement 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldDateTimeElement')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldDateTimeElement-#ctor 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldDateTimeElement.#ctor')
  - [HasClipboardCopyButton](#P-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldDateTimeElement-HasClipboardCopyButton 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldDateTimeElement.HasClipboardCopyButton')
- [DetailsFieldFlagElement](#T-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldFlagElement 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldFlagElement')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldFlagElement-#ctor 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldFlagElement.#ctor')
  - [HasClipboardCopyButton](#P-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldFlagElement-HasClipboardCopyButton 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldFlagElement.HasClipboardCopyButton')
- [DetailsFieldHtmlContentElement](#T-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldHtmlContentElement 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldHtmlContentElement')
  - [HasClipboardCopyButton](#P-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldHtmlContentElement-HasClipboardCopyButton 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldHtmlContentElement.HasClipboardCopyButton')
  - [DefineHtmlBuilder()](#M-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldHtmlContentElement-DefineHtmlBuilder 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldHtmlContentElement.DefineHtmlBuilder')
- [DetailsFieldLinkElement](#T-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldLinkElement 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldLinkElement')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldLinkElement-#ctor 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldLinkElement.#ctor')
  - [HasClipboardCopyButton](#P-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldLinkElement-HasClipboardCopyButton 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldLinkElement.HasClipboardCopyButton')
- [DetailsFieldTextElement](#T-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldTextElement 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldTextElement')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldTextElement-#ctor 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldTextElement.#ctor')
  - [HasClipboardCopyButton](#P-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldTextElement-HasClipboardCopyButton 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldTextElement.HasClipboardCopyButton')
- [DetailsFieldTimeElement](#T-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldTimeElement 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldTimeElement')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldTimeElement-#ctor 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldTimeElement.#ctor')
  - [HasClipboardCopyButton](#P-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldTimeElement-HasClipboardCopyButton 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldTimeElement.HasClipboardCopyButton')
- [DetailsPropertyViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Details-DetailsPropertyViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Details.DetailsPropertyViewModel')
  - [DetailsFieldElement](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Details-DetailsPropertyViewModel-DetailsFieldElement 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Details.DetailsPropertyViewModel.DetailsFieldElement')
  - [KebapCaseName](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Details-DetailsPropertyViewModel-KebapCaseName 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Details.DetailsPropertyViewModel.KebapCaseName')
  - [Name](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Details-DetailsPropertyViewModel-Name 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Details.DetailsPropertyViewModel.Name')
  - [Order](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Details-DetailsPropertyViewModel-Order 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Details.DetailsPropertyViewModel.Order')
  - [Value](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Details-DetailsPropertyViewModel-Value 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Details.DetailsPropertyViewModel.Value')
  - [RenderHtmlContent()](#M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Details-DetailsPropertyViewModel-RenderHtmlContent 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Details.DetailsPropertyViewModel.RenderHtmlContent')
- [DetailsViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-DetailsCard-DetailsViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.DetailsCard.DetailsViewModel')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-ViewModels-Entity-DetailsCard-DetailsViewModel-#ctor 'Definux.Emeraude.Admin.UI.ViewModels.Entity.DetailsCard.DetailsViewModel.#ctor')
  - [Properties](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-DetailsCard-DetailsViewModel-Properties 'Definux.Emeraude.Admin.UI.ViewModels.Entity.DetailsCard.DetailsViewModel.Properties')
  - [AddProperty(property)](#M-Definux-Emeraude-Admin-UI-ViewModels-Entity-DetailsCard-DetailsViewModel-AddProperty-Definux-Emeraude-Admin-UI-ViewModels-Entity-Details-DetailsPropertyViewModel- 'Definux.Emeraude.Admin.UI.ViewModels.Entity.DetailsCard.DetailsViewModel.AddProperty(Definux.Emeraude.Admin.UI.ViewModels.Entity.Details.DetailsPropertyViewModel)')
- [DevelopmentOnlyNotificationAlertTagHelper](#T-Definux-Emeraude-Admin-UI-TagHelpers-DevelopmentOnlyNotificationAlertTagHelper 'Definux.Emeraude.Admin.UI.TagHelpers.DevelopmentOnlyNotificationAlertTagHelper')
  - [Process()](#M-Definux-Emeraude-Admin-UI-TagHelpers-DevelopmentOnlyNotificationAlertTagHelper-Process-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput- 'Definux.Emeraude.Admin.UI.TagHelpers.DevelopmentOnlyNotificationAlertTagHelper.Process(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput)')
- [DropdownHtmlBuilder\`1](#T-Definux-Emeraude-Admin-UI-HtmlBuilders-DropdownHtmlBuilder`1 'Definux.Emeraude.Admin.UI.HtmlBuilders.DropdownHtmlBuilder`1')
  - [#ctor(data,targetProperty,selectedValue,isNullable)](#M-Definux-Emeraude-Admin-UI-HtmlBuilders-DropdownHtmlBuilder`1-#ctor-System-Collections-Generic-Dictionary{`0,System-String},System-String,`0,System-Boolean- 'Definux.Emeraude.Admin.UI.HtmlBuilders.DropdownHtmlBuilder`1.#ctor(System.Collections.Generic.Dictionary{`0,System.String},System.String,`0,System.Boolean)')
- [EditEntityViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-EditEntityViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.EditEntityViewModel')
  - [Title](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-EditEntityViewModel-Title 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.EditEntityViewModel.Title')
- [EmailLogViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Logging-EmailLogViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Logging.EmailLogViewModel')
  - [Body](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-EmailLogViewModel-Body 'Definux.Emeraude.Admin.UI.ViewModels.Logging.EmailLogViewModel.Body')
  - [EmailAddress](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-EmailLogViewModel-EmailAddress 'Definux.Emeraude.Admin.UI.ViewModels.Logging.EmailLogViewModel.EmailAddress')
  - [Receiver](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-EmailLogViewModel-Receiver 'Definux.Emeraude.Admin.UI.ViewModels.Logging.EmailLogViewModel.Receiver')
  - [Sent](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-EmailLogViewModel-Sent 'Definux.Emeraude.Admin.UI.ViewModels.Logging.EmailLogViewModel.Sent')
  - [Subject](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-EmailLogViewModel-Subject 'Definux.Emeraude.Admin.UI.ViewModels.Logging.EmailLogViewModel.Subject')
- [EmailsLogsViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Logging-EmailsLogsViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Logging.EmailsLogsViewModel')
- [EmeraudeVersionTagHelper](#T-Definux-Emeraude-Admin-UI-TagHelpers-EmeraudeVersionTagHelper 'Definux.Emeraude.Admin.UI.TagHelpers.EmeraudeVersionTagHelper')
  - [#ctor(options)](#M-Definux-Emeraude-Admin-UI-TagHelpers-EmeraudeVersionTagHelper-#ctor-Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions}- 'Definux.Emeraude.Admin.UI.TagHelpers.EmeraudeVersionTagHelper.#ctor(Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions})')
  - [Process()](#M-Definux-Emeraude-Admin-UI-TagHelpers-EmeraudeVersionTagHelper-Process-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput- 'Definux.Emeraude.Admin.UI.TagHelpers.EmeraudeVersionTagHelper.Process(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput)')
- [EntityDetailsViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-DetailsCard-EntityDetailsViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.DetailsCard.EntityDetailsViewModel')
  - [Details](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-DetailsCard-EntityDetailsViewModel-Details 'Definux.Emeraude.Admin.UI.ViewModels.Entity.DetailsCard.EntityDetailsViewModel.Details')
- [EntityFormViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-EntityFormViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.EntityFormViewModel')
  - [Action](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-EntityFormViewModel-Action 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.EntityFormViewModel.Action')
  - [Area](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-EntityFormViewModel-Area 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.EntityFormViewModel.Area')
  - [Controller](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-EntityFormViewModel-Controller 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.EntityFormViewModel.Controller')
  - [EntityName](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-EntityFormViewModel-EntityName 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.EntityFormViewModel.EntityName')
  - [Inputs](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-EntityFormViewModel-Inputs 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.EntityFormViewModel.Inputs')
- [ErrorLogViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Logging-ErrorLogViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Logging.ErrorLogViewModel')
  - [Message](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ErrorLogViewModel-Message 'Definux.Emeraude.Admin.UI.ViewModels.Logging.ErrorLogViewModel.Message')
  - [Method](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ErrorLogViewModel-Method 'Definux.Emeraude.Admin.UI.ViewModels.Logging.ErrorLogViewModel.Method')
  - [Source](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ErrorLogViewModel-Source 'Definux.Emeraude.Admin.UI.ViewModels.Logging.ErrorLogViewModel.Source')
  - [StackTrace](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ErrorLogViewModel-StackTrace 'Definux.Emeraude.Admin.UI.ViewModels.Logging.ErrorLogViewModel.StackTrace')
- [ErrorNotificationHtmlBuilder](#T-Definux-Emeraude-Admin-UI-HtmlBuilders-ErrorNotificationHtmlBuilder 'Definux.Emeraude.Admin.UI.HtmlBuilders.ErrorNotificationHtmlBuilder')
  - [#ctor(message)](#M-Definux-Emeraude-Admin-UI-HtmlBuilders-ErrorNotificationHtmlBuilder-#ctor-System-String- 'Definux.Emeraude.Admin.UI.HtmlBuilders.ErrorNotificationHtmlBuilder.#ctor(System.String)')
- [ErrorsLogsViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Logging-ErrorsLogsViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Logging.ErrorsLogsViewModel')
- [FlagHtmlBuilder](#T-Definux-Emeraude-Admin-UI-HtmlBuilders-FlagHtmlBuilder 'Definux.Emeraude.Admin.UI.HtmlBuilders.FlagHtmlBuilder')
  - [#ctor(value,trueValue,falseValue)](#M-Definux-Emeraude-Admin-UI-HtmlBuilders-FlagHtmlBuilder-#ctor-System-Boolean,System-String,System-String- 'Definux.Emeraude.Admin.UI.HtmlBuilders.FlagHtmlBuilder.#ctor(System.Boolean,System.String,System.String)')
- [FlagTagHelper](#T-Definux-Emeraude-Admin-UI-TagHelpers-FlagTagHelper 'Definux.Emeraude.Admin.UI.TagHelpers.FlagTagHelper')
  - [FalseValue](#P-Definux-Emeraude-Admin-UI-TagHelpers-FlagTagHelper-FalseValue 'Definux.Emeraude.Admin.UI.TagHelpers.FlagTagHelper.FalseValue')
  - [TrueValue](#P-Definux-Emeraude-Admin-UI-TagHelpers-FlagTagHelper-TrueValue 'Definux.Emeraude.Admin.UI.TagHelpers.FlagTagHelper.TrueValue')
  - [Value](#P-Definux-Emeraude-Admin-UI-TagHelpers-FlagTagHelper-Value 'Definux.Emeraude.Admin.UI.TagHelpers.FlagTagHelper.Value')
  - [Process()](#M-Definux-Emeraude-Admin-UI-TagHelpers-FlagTagHelper-Process-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput- 'Definux.Emeraude.Admin.UI.TagHelpers.FlagTagHelper.Process(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput)')
- [ForPermissionTagHelper](#T-Definux-Emeraude-Admin-UI-TagHelpers-ForPermissionTagHelper 'Definux.Emeraude.Admin.UI.TagHelpers.ForPermissionTagHelper')
  - [#ctor(identityUserInfoAdapter)](#M-Definux-Emeraude-Admin-UI-TagHelpers-ForPermissionTagHelper-#ctor-Definux-Emeraude-Admin-UI-Adapters-IIdentityUserInfoAdapter- 'Definux.Emeraude.Admin.UI.TagHelpers.ForPermissionTagHelper.#ctor(Definux.Emeraude.Admin.UI.Adapters.IIdentityUserInfoAdapter)')
  - [Permission](#P-Definux-Emeraude-Admin-UI-TagHelpers-ForPermissionTagHelper-Permission 'Definux.Emeraude.Admin.UI.TagHelpers.ForPermissionTagHelper.Permission')
  - [ProcessAsync()](#M-Definux-Emeraude-Admin-UI-TagHelpers-ForPermissionTagHelper-ProcessAsync-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput- 'Definux.Emeraude.Admin.UI.TagHelpers.ForPermissionTagHelper.ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput)')
- [FormDataSourceMapDropdownElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormDataSourceMapDropdownElement 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormDataSourceMapDropdownElement')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormDataSourceMapDropdownElement-#ctor 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormDataSourceMapDropdownElement.#ctor')
  - [DefineHtmlBuilder()](#M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormDataSourceMapDropdownElement-DefineHtmlBuilder 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormDataSourceMapDropdownElement.DefineHtmlBuilder')
- [FormDatabaseCheckboxGroupElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormDatabaseCheckboxGroupElement 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormDatabaseCheckboxGroupElement')
  - [DefineHtmlBuilder()](#M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormDatabaseCheckboxGroupElement-DefineHtmlBuilder 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormDatabaseCheckboxGroupElement.DefineHtmlBuilder')
- [FormDatabaseDropdownElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormDatabaseDropdownElement 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormDatabaseDropdownElement')
  - [DefineHtmlBuilder()](#M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormDatabaseDropdownElement-DefineHtmlBuilder 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormDatabaseDropdownElement.DefineHtmlBuilder')
- [FormDatabaseRadioGroupElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormDatabaseRadioGroupElement 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormDatabaseRadioGroupElement')
  - [DefineHtmlBuilder()](#M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormDatabaseRadioGroupElement-DefineHtmlBuilder 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormDatabaseRadioGroupElement.DefineHtmlBuilder')
- [FormDateElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormDateElement 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormDateElement')
  - [DefineHtmlBuilder()](#M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormDateElement-DefineHtmlBuilder 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormDateElement.DefineHtmlBuilder')
- [FormElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement 'Definux.Emeraude.Admin.UI.UIElements.Form.FormElement')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement-#ctor 'Definux.Emeraude.Admin.UI.UIElements.Form.FormElement.#ctor')
  - [Hidden](#P-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement-Hidden 'Definux.Emeraude.Admin.UI.UIElements.Form.FormElement.Hidden')
  - [IsNullable](#P-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement-IsNullable 'Definux.Emeraude.Admin.UI.UIElements.Form.FormElement.IsNullable')
  - [Label](#P-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement-Label 'Definux.Emeraude.Admin.UI.UIElements.Form.FormElement.Label')
  - [TargetProperty](#P-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement-TargetProperty 'Definux.Emeraude.Admin.UI.UIElements.Form.FormElement.TargetProperty')
  - [Value](#P-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement-Value 'Definux.Emeraude.Admin.UI.UIElements.Form.FormElement.Value')
  - [VisibleKey](#P-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement-VisibleKey 'Definux.Emeraude.Admin.UI.UIElements.Form.FormElement.VisibleKey')
- [FormEmailElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormEmailElement 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormEmailElement')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormEmailElement-#ctor 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormEmailElement.#ctor')
- [FormEnumCheckboxGroupElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormEnumCheckboxGroupElement 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormEnumCheckboxGroupElement')
  - [DefineHtmlBuilder()](#M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormEnumCheckboxGroupElement-DefineHtmlBuilder 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormEnumCheckboxGroupElement.DefineHtmlBuilder')
- [FormEnumDropdownElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormEnumDropdownElement 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormEnumDropdownElement')
  - [DefineHtmlBuilder()](#M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormEnumDropdownElement-DefineHtmlBuilder 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormEnumDropdownElement.DefineHtmlBuilder')
- [FormEnumRadioGroupElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormEnumRadioGroupElement 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormEnumRadioGroupElement')
  - [DefineHtmlBuilder()](#M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormEnumRadioGroupElement-DefineHtmlBuilder 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormEnumRadioGroupElement.DefineHtmlBuilder')
- [FormFlagElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormFlagElement 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormFlagElement')
  - [DefineHtmlBuilder()](#M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormFlagElement-DefineHtmlBuilder 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormFlagElement.DefineHtmlBuilder')
- [FormHiddenElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormHiddenElement 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormHiddenElement')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormHiddenElement-#ctor 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormHiddenElement.#ctor')
  - [InputType](#P-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormHiddenElement-InputType 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormHiddenElement.InputType')
  - [KeepValue](#P-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormHiddenElement-KeepValue 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormHiddenElement.KeepValue')
  - [DefineHtmlBuilder()](#M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormHiddenElement-DefineHtmlBuilder 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormHiddenElement.DefineHtmlBuilder')
- [FormHtmlEditorElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormHtmlEditorElement 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormHtmlEditorElement')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormHtmlEditorElement-#ctor 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormHtmlEditorElement.#ctor')
  - [DefineHtmlBuilder()](#M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormHtmlEditorElement-DefineHtmlBuilder 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormHtmlEditorElement.DefineHtmlBuilder')
- [FormInputViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-FormInputViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.FormInputViewModel')
  - [DataSourceType](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-FormInputViewModel-DataSourceType 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.FormInputViewModel.DataSourceType')
  - [FormElement](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-FormInputViewModel-FormElement 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.FormInputViewModel.FormElement')
  - [Hidden](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-FormInputViewModel-Hidden 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.FormInputViewModel.Hidden')
  - [IsFlag](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-FormInputViewModel-IsFlag 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.FormInputViewModel.IsFlag')
  - [Label](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-FormInputViewModel-Label 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.FormInputViewModel.Label')
  - [Name](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-FormInputViewModel-Name 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.FormInputViewModel.Name')
  - [Order](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-FormInputViewModel-Order 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.FormInputViewModel.Order')
  - [Value](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-FormInputViewModel-Value 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.FormInputViewModel.Value')
  - [VisualizationPropertyName](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-FormInputViewModel-VisualizationPropertyName 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.FormInputViewModel.VisualizationPropertyName')
  - [RenderHtmlContent()](#M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-FormInputViewModel-RenderHtmlContent 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.FormInputViewModel.RenderHtmlContent')
- [FormNumberElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormNumberElement 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormNumberElement')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormNumberElement-#ctor 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormNumberElement.#ctor')
- [FormPasswordElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormPasswordElement 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormPasswordElement')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormPasswordElement-#ctor 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormPasswordElement.#ctor')
- [FormTextElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormTextElement 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormTextElement')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormTextElement-#ctor 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormTextElement.#ctor')
  - [InputType](#P-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormTextElement-InputType 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormTextElement.InputType')
  - [KeepValue](#P-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormTextElement-KeepValue 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormTextElement.KeepValue')
  - [DefineHtmlBuilder()](#M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormTextElement-DefineHtmlBuilder 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormTextElement.DefineHtmlBuilder')
- [FormTimeElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormTimeElement 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormTimeElement')
  - [DefineHtmlBuilder()](#M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormTimeElement-DefineHtmlBuilder 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormTimeElement.DefineHtmlBuilder')
- [FormVisibleRecaptchaTagHelper](#T-Definux-Emeraude-Admin-UI-TagHelpers-FormVisibleRecaptchaTagHelper 'Definux.Emeraude.Admin.UI.TagHelpers.FormVisibleRecaptchaTagHelper')
  - [#ctor(options)](#M-Definux-Emeraude-Admin-UI-TagHelpers-FormVisibleRecaptchaTagHelper-#ctor-Microsoft-Extensions-Options-IOptions{Definux-Utilities-Options-GoogleRecaptchaKeysOptions}- 'Definux.Emeraude.Admin.UI.TagHelpers.FormVisibleRecaptchaTagHelper.#ctor(Microsoft.Extensions.Options.IOptions{Definux.Utilities.Options.GoogleRecaptchaKeysOptions})')
  - [ViewContext](#P-Definux-Emeraude-Admin-UI-TagHelpers-FormVisibleRecaptchaTagHelper-ViewContext 'Definux.Emeraude.Admin.UI.TagHelpers.FormVisibleRecaptchaTagHelper.ViewContext')
  - [ProcessAsync()](#M-Definux-Emeraude-Admin-UI-TagHelpers-FormVisibleRecaptchaTagHelper-ProcessAsync-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput- 'Definux.Emeraude.Admin.UI.TagHelpers.FormVisibleRecaptchaTagHelper.ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput)')
- [Functions](#T-Definux-Emeraude-Admin-UI-Utilities-Functions 'Definux.Emeraude.Admin.UI.Utilities.Functions')
  - [GetDatabaseEntityDictionary(databaseEntities,visibleProperty)](#M-Definux-Emeraude-Admin-UI-Utilities-Functions-GetDatabaseEntityDictionary-System-Collections-Generic-IEnumerable{Definux-Emeraude-Domain-Entities-IEntity},System-String- 'Definux.Emeraude.Admin.UI.Utilities.Functions.GetDatabaseEntityDictionary(System.Collections.Generic.IEnumerable{Definux.Emeraude.Domain.Entities.IEntity},System.String)')
  - [NormalizeRoute(route)](#M-Definux-Emeraude-Admin-UI-Utilities-Functions-NormalizeRoute-System-String- 'Definux.Emeraude.Admin.UI.Utilities.Functions.NormalizeRoute(System.String)')
- [HeadTagHelper](#T-Definux-Emeraude-Admin-UI-TagHelpers-HeadTagHelper 'Definux.Emeraude.Admin.UI.TagHelpers.HeadTagHelper')
  - [ViewContext](#P-Definux-Emeraude-Admin-UI-TagHelpers-HeadTagHelper-ViewContext 'Definux.Emeraude.Admin.UI.TagHelpers.HeadTagHelper.ViewContext')
  - [ProcessAsync()](#M-Definux-Emeraude-Admin-UI-TagHelpers-HeadTagHelper-ProcessAsync-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput- 'Definux.Emeraude.Admin.UI.TagHelpers.HeadTagHelper.ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput)')
- [IDataSourceMap](#T-Definux-Emeraude-Admin-UI-UIElements-IDataSourceMap 'Definux.Emeraude.Admin.UI.UIElements.IDataSourceMap')
- [IDetailsFieldElement](#T-Definux-Emeraude-Admin-UI-UIElements-Details-IDetailsFieldElement 'Definux.Emeraude.Admin.UI.UIElements.Details.IDetailsFieldElement')
  - [HasClipboardCopyButton](#P-Definux-Emeraude-Admin-UI-UIElements-Details-IDetailsFieldElement-HasClipboardCopyButton 'Definux.Emeraude.Admin.UI.UIElements.Details.IDetailsFieldElement.HasClipboardCopyButton')
- [IEmContextAdapter](#T-Definux-Emeraude-Admin-UI-Adapters-IEmContextAdapter 'Definux.Emeraude.Admin.UI.Adapters.IEmContextAdapter')
  - [GetAllEntitiesByPropertyName(name)](#M-Definux-Emeraude-Admin-UI-Adapters-IEmContextAdapter-GetAllEntitiesByPropertyName-System-String- 'Definux.Emeraude.Admin.UI.Adapters.IEmContextAdapter.GetAllEntitiesByPropertyName(System.String)')
  - [GetAllEntitiesByType(entityType)](#M-Definux-Emeraude-Admin-UI-Adapters-IEmContextAdapter-GetAllEntitiesByType-System-Type- 'Definux.Emeraude.Admin.UI.Adapters.IEmContextAdapter.GetAllEntitiesByType(System.Type)')
- [IEntityFormViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-IEntityFormViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.IEntityFormViewModel')
  - [Inputs](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-IEntityFormViewModel-Inputs 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.IEntityFormViewModel.Inputs')
- [IFormElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-IFormElement 'Definux.Emeraude.Admin.UI.UIElements.Form.IFormElement')
  - [Hidden](#P-Definux-Emeraude-Admin-UI-UIElements-Form-IFormElement-Hidden 'Definux.Emeraude.Admin.UI.UIElements.Form.IFormElement.Hidden')
  - [IsNullable](#P-Definux-Emeraude-Admin-UI-UIElements-Form-IFormElement-IsNullable 'Definux.Emeraude.Admin.UI.UIElements.Form.IFormElement.IsNullable')
  - [Label](#P-Definux-Emeraude-Admin-UI-UIElements-Form-IFormElement-Label 'Definux.Emeraude.Admin.UI.UIElements.Form.IFormElement.Label')
  - [TargetProperty](#P-Definux-Emeraude-Admin-UI-UIElements-Form-IFormElement-TargetProperty 'Definux.Emeraude.Admin.UI.UIElements.Form.IFormElement.TargetProperty')
  - [Value](#P-Definux-Emeraude-Admin-UI-UIElements-Form-IFormElement-Value 'Definux.Emeraude.Admin.UI.UIElements.Form.IFormElement.Value')
  - [VisibleKey](#P-Definux-Emeraude-Admin-UI-UIElements-Form-IFormElement-VisibleKey 'Definux.Emeraude.Admin.UI.UIElements.Form.IFormElement.VisibleKey')
- [IIdentityUserInfoAdapter](#T-Definux-Emeraude-Admin-UI-Adapters-IIdentityUserInfoAdapter 'Definux.Emeraude.Admin.UI.Adapters.IIdentityUserInfoAdapter')
  - [GetCurrentUserClaimsAsync()](#M-Definux-Emeraude-Admin-UI-Adapters-IIdentityUserInfoAdapter-GetCurrentUserClaimsAsync 'Definux.Emeraude.Admin.UI.Adapters.IIdentityUserInfoAdapter.GetCurrentUserClaimsAsync')
  - [GetCurrentUserInfoAsync()](#M-Definux-Emeraude-Admin-UI-Adapters-IIdentityUserInfoAdapter-GetCurrentUserInfoAsync 'Definux.Emeraude.Admin.UI.Adapters.IIdentityUserInfoAdapter.GetCurrentUserInfoAsync')
- [ITableElement](#T-Definux-Emeraude-Admin-UI-UIElements-Table-ITableElement 'Definux.Emeraude.Admin.UI.UIElements.Table.ITableElement')
- [IUIElement](#T-Definux-Emeraude-Admin-UI-UIElements-IUIElement 'Definux.Emeraude.Admin.UI.UIElements.IUIElement')
  - [DataSource](#P-Definux-Emeraude-Admin-UI-UIElements-IUIElement-DataSource 'Definux.Emeraude.Admin.UI.UIElements.IUIElement.DataSource')
  - [DefineHtmlBuilder()](#M-Definux-Emeraude-Admin-UI-UIElements-IUIElement-DefineHtmlBuilder 'Definux.Emeraude.Admin.UI.UIElements.IUIElement.DefineHtmlBuilder')
  - [LoadServiceProvider(serviceProvider)](#M-Definux-Emeraude-Admin-UI-UIElements-IUIElement-LoadServiceProvider-System-IServiceProvider- 'Definux.Emeraude.Admin.UI.UIElements.IUIElement.LoadServiceProvider(System.IServiceProvider)')
  - [RenderHtmlString()](#M-Definux-Emeraude-Admin-UI-UIElements-IUIElement-RenderHtmlString 'Definux.Emeraude.Admin.UI.UIElements.IUIElement.RenderHtmlString')
- [LogEntitiesViewModel\`1](#T-Definux-Emeraude-Admin-UI-ViewModels-Logging-LogEntitiesViewModel`1 'Definux.Emeraude.Admin.UI.ViewModels.Logging.LogEntitiesViewModel`1')
  - [FromDate](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-LogEntitiesViewModel`1-FromDate 'Definux.Emeraude.Admin.UI.ViewModels.Logging.LogEntitiesViewModel`1.FromDate')
  - [SearchQuery](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-LogEntitiesViewModel`1-SearchQuery 'Definux.Emeraude.Admin.UI.ViewModels.Logging.LogEntitiesViewModel`1.SearchQuery')
  - [ToDate](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-LogEntitiesViewModel`1-ToDate 'Definux.Emeraude.Admin.UI.ViewModels.Logging.LogEntitiesViewModel`1.ToDate')
  - [User](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-LogEntitiesViewModel`1-User 'Definux.Emeraude.Admin.UI.ViewModels.Logging.LogEntitiesViewModel`1.User')
- [LogEntityViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Logging-LogEntityViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Logging.LogEntityViewModel')
  - [CreatedBy](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-LogEntityViewModel-CreatedBy 'Definux.Emeraude.Admin.UI.ViewModels.Logging.LogEntityViewModel.CreatedBy')
  - [CreatedOn](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-LogEntityViewModel-CreatedOn 'Definux.Emeraude.Admin.UI.ViewModels.Logging.LogEntityViewModel.CreatedOn')
  - [Id](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-LogEntityViewModel-Id 'Definux.Emeraude.Admin.UI.ViewModels.Logging.LogEntityViewModel.Id')
  - [InvolvedUser](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-LogEntityViewModel-InvolvedUser 'Definux.Emeraude.Admin.UI.ViewModels.Logging.LogEntityViewModel.InvolvedUser')
- [LogUserViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Logging-LogUserViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Logging.LogUserViewModel')
  - [Email](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-LogUserViewModel-Email 'Definux.Emeraude.Admin.UI.ViewModels.Logging.LogUserViewModel.Email')
  - [Id](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-LogUserViewModel-Id 'Definux.Emeraude.Admin.UI.ViewModels.Logging.LogUserViewModel.Id')
  - [Name](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-LogUserViewModel-Name 'Definux.Emeraude.Admin.UI.ViewModels.Logging.LogUserViewModel.Name')
- [MenuSectionTagHelper](#T-Definux-Emeraude-Admin-UI-TagHelpers-MenuSectionTagHelper 'Definux.Emeraude.Admin.UI.TagHelpers.MenuSectionTagHelper')
  - [Index](#P-Definux-Emeraude-Admin-UI-TagHelpers-MenuSectionTagHelper-Index 'Definux.Emeraude.Admin.UI.TagHelpers.MenuSectionTagHelper.Index')
  - [Model](#P-Definux-Emeraude-Admin-UI-TagHelpers-MenuSectionTagHelper-Model 'Definux.Emeraude.Admin.UI.TagHelpers.MenuSectionTagHelper.Model')
  - [ViewContext](#P-Definux-Emeraude-Admin-UI-TagHelpers-MenuSectionTagHelper-ViewContext 'Definux.Emeraude.Admin.UI.TagHelpers.MenuSectionTagHelper.ViewContext')
  - [Process()](#M-Definux-Emeraude-Admin-UI-TagHelpers-MenuSectionTagHelper-Process-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput- 'Definux.Emeraude.Admin.UI.TagHelpers.MenuSectionTagHelper.Process(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput)')
- [ModalActionButton](#T-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-ModalActionButton 'Definux.Emeraude.Admin.UI.ViewModels.Layout.ModalViewModel.ModalActionButton')
  - [Classes](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-ModalActionButton-Classes 'Definux.Emeraude.Admin.UI.ViewModels.Layout.ModalViewModel.ModalActionButton.Classes')
  - [Id](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-ModalActionButton-Id 'Definux.Emeraude.Admin.UI.ViewModels.Layout.ModalViewModel.ModalActionButton.Id')
  - [Title](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-ModalActionButton-Title 'Definux.Emeraude.Admin.UI.ViewModels.Layout.ModalViewModel.ModalActionButton.Title')
- [ModalType](#T-Definux-Emeraude-Admin-UI-Utilities-ModalType 'Definux.Emeraude.Admin.UI.Utilities.ModalType')
  - [Large](#F-Definux-Emeraude-Admin-UI-Utilities-ModalType-Large 'Definux.Emeraude.Admin.UI.Utilities.ModalType.Large')
  - [Normal](#F-Definux-Emeraude-Admin-UI-Utilities-ModalType-Normal 'Definux.Emeraude.Admin.UI.Utilities.ModalType.Normal')
  - [Small](#F-Definux-Emeraude-Admin-UI-Utilities-ModalType-Small 'Definux.Emeraude.Admin.UI.Utilities.ModalType.Small')
- [ModalViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Layout.ModalViewModel')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-#ctor 'Definux.Emeraude.Admin.UI.ViewModels.Layout.ModalViewModel.#ctor')
  - [Buttons](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-Buttons 'Definux.Emeraude.Admin.UI.ViewModels.Layout.ModalViewModel.Buttons')
  - [Content](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-Content 'Definux.Emeraude.Admin.UI.ViewModels.Layout.ModalViewModel.Content')
  - [ContentClass](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-ContentClass 'Definux.Emeraude.Admin.UI.ViewModels.Layout.ModalViewModel.ContentClass')
  - [HasCloseButton](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-HasCloseButton 'Definux.Emeraude.Admin.UI.ViewModels.Layout.ModalViewModel.HasCloseButton')
  - [IsContentHtml](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-IsContentHtml 'Definux.Emeraude.Admin.UI.ViewModels.Layout.ModalViewModel.IsContentHtml')
  - [LunchButtonClasses](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-LunchButtonClasses 'Definux.Emeraude.Admin.UI.ViewModels.Layout.ModalViewModel.LunchButtonClasses')
  - [LunchButtonIcon](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-LunchButtonIcon 'Definux.Emeraude.Admin.UI.ViewModels.Layout.ModalViewModel.LunchButtonIcon')
  - [LunchButtonTitle](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-LunchButtonTitle 'Definux.Emeraude.Admin.UI.ViewModels.Layout.ModalViewModel.LunchButtonTitle')
  - [ModalBodyClasses](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-ModalBodyClasses 'Definux.Emeraude.Admin.UI.ViewModels.Layout.ModalViewModel.ModalBodyClasses')
  - [ModalFooterClasses](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-ModalFooterClasses 'Definux.Emeraude.Admin.UI.ViewModels.Layout.ModalViewModel.ModalFooterClasses')
  - [ModalHeaderClasses](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-ModalHeaderClasses 'Definux.Emeraude.Admin.UI.ViewModels.Layout.ModalViewModel.ModalHeaderClasses')
  - [ModalId](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-ModalId 'Definux.Emeraude.Admin.UI.ViewModels.Layout.ModalViewModel.ModalId')
  - [Title](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-Title 'Definux.Emeraude.Admin.UI.ViewModels.Layout.ModalViewModel.Title')
  - [Type](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-Type 'Definux.Emeraude.Admin.UI.ViewModels.Layout.ModalViewModel.Type')
  - [TypeClass](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-TypeClass 'Definux.Emeraude.Admin.UI.ViewModels.Layout.ModalViewModel.TypeClass')
- [NavigationActionViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Layout-NavigationActionViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Layout.NavigationActionViewModel')
  - [ActionUrl](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-NavigationActionViewModel-ActionUrl 'Definux.Emeraude.Admin.UI.ViewModels.Layout.NavigationActionViewModel.ActionUrl')
  - [ConfirmationMessage](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-NavigationActionViewModel-ConfirmationMessage 'Definux.Emeraude.Admin.UI.ViewModels.Layout.NavigationActionViewModel.ConfirmationMessage')
  - [ConfirmationTitle](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-NavigationActionViewModel-ConfirmationTitle 'Definux.Emeraude.Admin.UI.ViewModels.Layout.NavigationActionViewModel.ConfirmationTitle')
  - [HasConfirmation](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-NavigationActionViewModel-HasConfirmation 'Definux.Emeraude.Admin.UI.ViewModels.Layout.NavigationActionViewModel.HasConfirmation')
  - [Icon](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-NavigationActionViewModel-Icon 'Definux.Emeraude.Admin.UI.ViewModels.Layout.NavigationActionViewModel.Icon')
  - [Method](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-NavigationActionViewModel-Method 'Definux.Emeraude.Admin.UI.ViewModels.Layout.NavigationActionViewModel.Method')
  - [Name](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-NavigationActionViewModel-Name 'Definux.Emeraude.Admin.UI.ViewModels.Layout.NavigationActionViewModel.Name')
  - [Parameters](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-NavigationActionViewModel-Parameters 'Definux.Emeraude.Admin.UI.ViewModels.Layout.NavigationActionViewModel.Parameters')
  - [SeparatePage](#P-Definux-Emeraude-Admin-UI-ViewModels-Layout-NavigationActionViewModel-SeparatePage 'Definux.Emeraude.Admin.UI.ViewModels.Layout.NavigationActionViewModel.SeparatePage')
- [NotificationAlertTagHelper](#T-Definux-Emeraude-Admin-UI-TagHelpers-NotificationAlertTagHelper 'Definux.Emeraude.Admin.UI.TagHelpers.NotificationAlertTagHelper')
  - [Type](#P-Definux-Emeraude-Admin-UI-TagHelpers-NotificationAlertTagHelper-Type 'Definux.Emeraude.Admin.UI.TagHelpers.NotificationAlertTagHelper.Type')
  - [Process()](#M-Definux-Emeraude-Admin-UI-TagHelpers-NotificationAlertTagHelper-Process-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput- 'Definux.Emeraude.Admin.UI.TagHelpers.NotificationAlertTagHelper.Process(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput)')
- [RadioGroupHtmlBuilder\`1](#T-Definux-Emeraude-Admin-UI-HtmlBuilders-RadioGroupHtmlBuilder`1 'Definux.Emeraude.Admin.UI.HtmlBuilders.RadioGroupHtmlBuilder`1')
  - [#ctor(data,targetProperty,selectedValue)](#M-Definux-Emeraude-Admin-UI-HtmlBuilders-RadioGroupHtmlBuilder`1-#ctor-System-Collections-Generic-Dictionary{`0,System-String},System-String,`0- 'Definux.Emeraude.Admin.UI.HtmlBuilders.RadioGroupHtmlBuilder`1.#ctor(System.Collections.Generic.Dictionary{`0,System.String},System.String,`0)')
- [RoleOption](#T-Definux-Emeraude-Admin-UI-ViewModels-Users-RolesViewModel-RoleOption 'Definux.Emeraude.Admin.UI.ViewModels.Users.RolesViewModel.RoleOption')
  - [Name](#P-Definux-Emeraude-Admin-UI-ViewModels-Users-RolesViewModel-RoleOption-Name 'Definux.Emeraude.Admin.UI.ViewModels.Users.RolesViewModel.RoleOption.Name')
  - [Value](#P-Definux-Emeraude-Admin-UI-ViewModels-Users-RolesViewModel-RoleOption-Value 'Definux.Emeraude.Admin.UI.ViewModels.Users.RolesViewModel.RoleOption.Value')
- [RolesViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Users-RolesViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Users.RolesViewModel')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-ViewModels-Users-RolesViewModel-#ctor 'Definux.Emeraude.Admin.UI.ViewModels.Users.RolesViewModel.#ctor')
  - [RoleOptions](#P-Definux-Emeraude-Admin-UI-ViewModels-Users-RolesViewModel-RoleOptions 'Definux.Emeraude.Admin.UI.ViewModels.Users.RolesViewModel.RoleOptions')
  - [SelectedRoles](#P-Definux-Emeraude-Admin-UI-ViewModels-Users-RolesViewModel-SelectedRoles 'Definux.Emeraude.Admin.UI.ViewModels.Users.RolesViewModel.SelectedRoles')
  - [SetRoleOptions(rolesDictionary)](#M-Definux-Emeraude-Admin-UI-ViewModels-Users-RolesViewModel-SetRoleOptions-System-Collections-Generic-Dictionary{System-Guid,System-String}- 'Definux.Emeraude.Admin.UI.ViewModels.Users.RolesViewModel.SetRoleOptions(System.Collections.Generic.Dictionary{System.Guid,System.String})')
  - [SetSelectedRoles(userRolesDictionary)](#M-Definux-Emeraude-Admin-UI-ViewModels-Users-RolesViewModel-SetSelectedRoles-System-Collections-Generic-Dictionary{System-Guid,System-String}- 'Definux.Emeraude.Admin.UI.ViewModels.Users.RolesViewModel.SetSelectedRoles(System.Collections.Generic.Dictionary{System.Guid,System.String})')
- [RootCreateFolderViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootCreateFolderViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootCreateFolderViewModel')
  - [FolderName](#P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootCreateFolderViewModel-FolderName 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootCreateFolderViewModel.FolderName')
  - [ParentFolderPath](#P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootCreateFolderViewModel-ParentFolderPath 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootCreateFolderViewModel.ParentFolderPath')
  - [Root](#P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootCreateFolderViewModel-Root 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootCreateFolderViewModel.Root')
- [RootFileViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFileViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootFileViewModel')
  - [CreatedOn](#P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFileViewModel-CreatedOn 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootFileViewModel.CreatedOn')
  - [LastModifiedOn](#P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFileViewModel-LastModifiedOn 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootFileViewModel.LastModifiedOn')
  - [Name](#P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFileViewModel-Name 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootFileViewModel.Name')
  - [RelativePath](#P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFileViewModel-RelativePath 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootFileViewModel.RelativePath')
  - [RelativePathUrlFormat](#P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFileViewModel-RelativePathUrlFormat 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootFileViewModel.RelativePathUrlFormat')
  - [Size](#P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFileViewModel-Size 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootFileViewModel.Size')
  - [SizeString](#P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFileViewModel-SizeString 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootFileViewModel.SizeString')
- [RootFolderViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFolderViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootFolderViewModel')
  - [CreatedOn](#P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFolderViewModel-CreatedOn 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootFolderViewModel.CreatedOn')
  - [LastModifiedOn](#P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFolderViewModel-LastModifiedOn 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootFolderViewModel.LastModifiedOn')
  - [Name](#P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFolderViewModel-Name 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootFolderViewModel.Name')
  - [RelativePath](#P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFolderViewModel-RelativePath 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootFolderViewModel.RelativePath')
  - [RelativePathUrlFormat](#P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFolderViewModel-RelativePathUrlFormat 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootFolderViewModel.RelativePathUrlFormat')
- [RootUploadFilesViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootUploadFilesViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootUploadFilesViewModel')
  - [ParentFolderPath](#P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootUploadFilesViewModel-ParentFolderPath 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootUploadFilesViewModel.ParentFolderPath')
  - [Root](#P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootUploadFilesViewModel-Root 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootUploadFilesViewModel.Root')
- [RootViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootViewModel')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootViewModel-#ctor 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootViewModel.#ctor')
  - [Files](#P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootViewModel-Files 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootViewModel.Files')
  - [FolderName](#P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootViewModel-FolderName 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootViewModel.FolderName')
  - [Folders](#P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootViewModel-Folders 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootViewModel.Folders')
  - [Root](#P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootViewModel-Root 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootViewModel.Root')
  - [AddFile(name,relativePath,fileSize,createdOn,lastModifiedOn)](#M-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootViewModel-AddFile-System-String,System-String,System-Int64,System-DateTime,System-DateTime- 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootViewModel.AddFile(System.String,System.String,System.Int64,System.DateTime,System.DateTime)')
  - [AddFolder(name,relativePath,createdOn,lastModifiedOn)](#M-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootViewModel-AddFolder-System-String,System-String,System-DateTime,System-DateTime- 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootViewModel.AddFolder(System.String,System.String,System.DateTime,System.DateTime)')
- [SelectableGalleryViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-SelectableGalleryViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.SelectableGalleryViewModel')
  - [Action](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-SelectableGalleryViewModel-Action 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.SelectableGalleryViewModel.Action')
  - [Controller](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-SelectableGalleryViewModel-Controller 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.SelectableGalleryViewModel.Controller')
  - [Pictures](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-SelectableGalleryViewModel-Pictures 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.SelectableGalleryViewModel.Pictures')
  - [SelectedPicture](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-SelectableGalleryViewModel-SelectedPicture 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.SelectableGalleryViewModel.SelectedPicture')
- [ServiceCollectionExtensions](#T-Definux-Emeraude-Admin-UI-Extensions-ServiceCollectionExtensions 'Definux.Emeraude.Admin.UI.Extensions.ServiceCollectionExtensions')
  - [ConfigureAdminUI(services)](#M-Definux-Emeraude-Admin-UI-Extensions-ServiceCollectionExtensions-ConfigureAdminUI-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Definux.Emeraude.Admin.UI.Extensions.ServiceCollectionExtensions.ConfigureAdminUI(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
- [SidebarInsightItem](#T-Definux-Emeraude-Admin-UI-AdminMenu-SidebarInsightItem 'Definux.Emeraude.Admin.UI.AdminMenu.SidebarInsightItem')
  - [Blank](#P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarInsightItem-Blank 'Definux.Emeraude.Admin.UI.AdminMenu.SidebarInsightItem.Blank')
  - [Icon](#P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarInsightItem-Icon 'Definux.Emeraude.Admin.UI.AdminMenu.SidebarInsightItem.Icon')
  - [IsButton](#P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarInsightItem-IsButton 'Definux.Emeraude.Admin.UI.AdminMenu.SidebarInsightItem.IsButton')
  - [Route](#P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarInsightItem-Route 'Definux.Emeraude.Admin.UI.AdminMenu.SidebarInsightItem.Route')
  - [Title](#P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarInsightItem-Title 'Definux.Emeraude.Admin.UI.AdminMenu.SidebarInsightItem.Title')
- [SidebarMenuSectionItem](#T-Definux-Emeraude-Admin-UI-AdminMenu-SidebarMenuSectionItem 'Definux.Emeraude.Admin.UI.AdminMenu.SidebarMenuSectionItem')
  - [Children](#P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarMenuSectionItem-Children 'Definux.Emeraude.Admin.UI.AdminMenu.SidebarMenuSectionItem.Children')
  - [Dropdown](#P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarMenuSectionItem-Dropdown 'Definux.Emeraude.Admin.UI.AdminMenu.SidebarMenuSectionItem.Dropdown')
  - [Icon](#P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarMenuSectionItem-Icon 'Definux.Emeraude.Admin.UI.AdminMenu.SidebarMenuSectionItem.Icon')
  - [IsActive](#P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarMenuSectionItem-IsActive 'Definux.Emeraude.Admin.UI.AdminMenu.SidebarMenuSectionItem.IsActive')
  - [IsSingle](#P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarMenuSectionItem-IsSingle 'Definux.Emeraude.Admin.UI.AdminMenu.SidebarMenuSectionItem.IsSingle')
  - [SingleLinkItem](#P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarMenuSectionItem-SingleLinkItem 'Definux.Emeraude.Admin.UI.AdminMenu.SidebarMenuSectionItem.SingleLinkItem')
  - [Title](#P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarMenuSectionItem-Title 'Definux.Emeraude.Admin.UI.AdminMenu.SidebarMenuSectionItem.Title')
  - [BuildState(currentRoute)](#M-Definux-Emeraude-Admin-UI-AdminMenu-SidebarMenuSectionItem-BuildState-System-String- 'Definux.Emeraude.Admin.UI.AdminMenu.SidebarMenuSectionItem.BuildState(System.String)')
- [SidebarNavigationLinkItem](#T-Definux-Emeraude-Admin-UI-AdminMenu-SidebarNavigationLinkItem 'Definux.Emeraude.Admin.UI.AdminMenu.SidebarNavigationLinkItem')
  - [DefaultRoute](#P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarNavigationLinkItem-DefaultRoute 'Definux.Emeraude.Admin.UI.AdminMenu.SidebarNavigationLinkItem.DefaultRoute')
  - [IsActive](#P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarNavigationLinkItem-IsActive 'Definux.Emeraude.Admin.UI.AdminMenu.SidebarNavigationLinkItem.IsActive')
  - [Routes](#P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarNavigationLinkItem-Routes 'Definux.Emeraude.Admin.UI.AdminMenu.SidebarNavigationLinkItem.Routes')
  - [Title](#P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarNavigationLinkItem-Title 'Definux.Emeraude.Admin.UI.AdminMenu.SidebarNavigationLinkItem.Title')
  - [BuildState(currentRoute)](#M-Definux-Emeraude-Admin-UI-AdminMenu-SidebarNavigationLinkItem-BuildState-System-String- 'Definux.Emeraude.Admin.UI.AdminMenu.SidebarNavigationLinkItem.BuildState(System.String)')
- [TableCellViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableCellViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableCellViewModel')
  - [#ctor(order,content,tableElement)](#M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableCellViewModel-#ctor-System-Int32,System-Object,Definux-Emeraude-Admin-UI-UIElements-Table-ITableElement- 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableCellViewModel.#ctor(System.Int32,System.Object,Definux.Emeraude.Admin.UI.UIElements.Table.ITableElement)')
  - [Order](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableCellViewModel-Order 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableCellViewModel.Order')
  - [TableElement](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableCellViewModel-TableElement 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableCellViewModel.TableElement')
  - [RenderHtmlContent()](#M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableCellViewModel-RenderHtmlContent 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableCellViewModel.RenderHtmlContent')
- [TableDataSourceMapElement\`1](#T-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableDataSourceMapElement`1 'Definux.Emeraude.Admin.UI.UIElements.Table.Implementations.TableDataSourceMapElement`1')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableDataSourceMapElement`1-#ctor 'Definux.Emeraude.Admin.UI.UIElements.Table.Implementations.TableDataSourceMapElement`1.#ctor')
- [TableDateElement](#T-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableDateElement 'Definux.Emeraude.Admin.UI.UIElements.Table.Implementations.TableDateElement')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableDateElement-#ctor 'Definux.Emeraude.Admin.UI.UIElements.Table.Implementations.TableDateElement.#ctor')
- [TableDateTimeElement](#T-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableDateTimeElement 'Definux.Emeraude.Admin.UI.UIElements.Table.Implementations.TableDateTimeElement')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableDateTimeElement-#ctor 'Definux.Emeraude.Admin.UI.UIElements.Table.Implementations.TableDateTimeElement.#ctor')
- [TableFlagElement](#T-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableFlagElement 'Definux.Emeraude.Admin.UI.UIElements.Table.Implementations.TableFlagElement')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableFlagElement-#ctor 'Definux.Emeraude.Admin.UI.UIElements.Table.Implementations.TableFlagElement.#ctor')
- [TableHeaderCellViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableHeaderCellViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableHeaderCellViewModel')
  - [Name](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableHeaderCellViewModel-Name 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableHeaderCellViewModel.Name')
  - [Order](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableHeaderCellViewModel-Order 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableHeaderCellViewModel.Order')
- [TableHeaderViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableHeaderViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableHeaderViewModel')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableHeaderViewModel-#ctor 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableHeaderViewModel.#ctor')
  - [Cells](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableHeaderViewModel-Cells 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableHeaderViewModel.Cells')
  - [AddCell(name)](#M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableHeaderViewModel-AddCell-System-String- 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableHeaderViewModel.AddCell(System.String)')
- [TableLinkElement](#T-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableLinkElement 'Definux.Emeraude.Admin.UI.UIElements.Table.Implementations.TableLinkElement')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableLinkElement-#ctor 'Definux.Emeraude.Admin.UI.UIElements.Table.Implementations.TableLinkElement.#ctor')
- [TableLongTextElement](#T-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableLongTextElement 'Definux.Emeraude.Admin.UI.UIElements.Table.Implementations.TableLongTextElement')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableLongTextElement-#ctor 'Definux.Emeraude.Admin.UI.UIElements.Table.Implementations.TableLongTextElement.#ctor')
  - [DefineHtmlBuilder()](#M-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableLongTextElement-DefineHtmlBuilder 'Definux.Emeraude.Admin.UI.UIElements.Table.Implementations.TableLongTextElement.DefineHtmlBuilder')
- [TablePaginationViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TablePaginationViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TablePaginationViewModel')
  - [#ctor(currentPage,pagesCount)](#M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TablePaginationViewModel-#ctor-System-Int32,System-Int32- 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TablePaginationViewModel.#ctor(System.Int32,System.Int32)')
  - [AdditionalQueryParams](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TablePaginationViewModel-AdditionalQueryParams 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TablePaginationViewModel.AdditionalQueryParams')
  - [CurrentPage](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TablePaginationViewModel-CurrentPage 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TablePaginationViewModel.CurrentPage')
  - [NextPage](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TablePaginationViewModel-NextPage 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TablePaginationViewModel.NextPage')
  - [NextPagesCount](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TablePaginationViewModel-NextPagesCount 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TablePaginationViewModel.NextPagesCount')
  - [PreviousPage](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TablePaginationViewModel-PreviousPage 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TablePaginationViewModel.PreviousPage')
  - [PreviousPagesCount](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TablePaginationViewModel-PreviousPagesCount 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TablePaginationViewModel.PreviousPagesCount')
- [TableRowActionMethod](#T-Definux-Emeraude-Admin-UI-Utilities-TableRowActionMethod 'Definux.Emeraude.Admin.UI.Utilities.TableRowActionMethod')
  - [Get](#F-Definux-Emeraude-Admin-UI-Utilities-TableRowActionMethod-Get 'Definux.Emeraude.Admin.UI.Utilities.TableRowActionMethod.Get')
  - [Post](#F-Definux-Emeraude-Admin-UI-Utilities-TableRowActionMethod-Post 'Definux.Emeraude.Admin.UI.Utilities.TableRowActionMethod.Post')
- [TableRowActionViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowActionViewModel')
  - [#ctor(title,icon,urlStringFormat,rawParameters,method)](#M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel-#ctor-System-String,System-String,System-String,System-Collections-Generic-List{System-String},Definux-Emeraude-Admin-UI-Utilities-TableRowActionMethod- 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowActionViewModel.#ctor(System.String,System.String,System.String,System.Collections.Generic.List{System.String},Definux.Emeraude.Admin.UI.Utilities.TableRowActionMethod)')
  - [ConfirmationMessage](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel-ConfirmationMessage 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowActionViewModel.ConfirmationMessage')
  - [ConfirmationTitle](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel-ConfirmationTitle 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowActionViewModel.ConfirmationTitle')
  - [HasConfirmation](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel-HasConfirmation 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowActionViewModel.HasConfirmation')
  - [Icon](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel-Icon 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowActionViewModel.Icon')
  - [Method](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel-Method 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowActionViewModel.Method')
  - [Parameters](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel-Parameters 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowActionViewModel.Parameters')
  - [RawParameters](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel-RawParameters 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowActionViewModel.RawParameters')
  - [Title](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel-Title 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowActionViewModel.Title')
  - [Url](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel-Url 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowActionViewModel.Url')
  - [UrlStringFormat](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel-UrlStringFormat 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowActionViewModel.UrlStringFormat')
  - [SetConfirmation(confirmationTitle,confirmationMessage)](#M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel-SetConfirmation-System-String,System-String- 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowActionViewModel.SetConfirmation(System.String,System.String)')
- [TableRowViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowViewModel')
  - [Actions](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowViewModel-Actions 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowViewModel.Actions')
  - [Cells](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowViewModel-Cells 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowViewModel.Cells')
  - [Identifier](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowViewModel-Identifier 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowViewModel.Identifier')
  - [AddAction(action,parameters)](#M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowViewModel-AddAction-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel,System-Collections-Generic-List{System-String}- 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowViewModel.AddAction(Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowActionViewModel,System.Collections.Generic.List{System.String})')
  - [AddCell(order,content,tableElement)](#M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowViewModel-AddCell-System-Int32,System-Object,Definux-Emeraude-Admin-UI-UIElements-Table-ITableElement- 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowViewModel.AddCell(System.Int32,System.Object,Definux.Emeraude.Admin.UI.UIElements.Table.ITableElement)')
  - [HasOrder(order)](#M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowViewModel-HasOrder-System-Int32- 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowViewModel.HasOrder(System.Int32)')
- [TableTextElement](#T-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableTextElement 'Definux.Emeraude.Admin.UI.UIElements.Table.Implementations.TableTextElement')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableTextElement-#ctor 'Definux.Emeraude.Admin.UI.UIElements.Table.Implementations.TableTextElement.#ctor')
- [TableTimeElement](#T-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableTimeElement 'Definux.Emeraude.Admin.UI.UIElements.Table.Implementations.TableTimeElement')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableTimeElement-#ctor 'Definux.Emeraude.Admin.UI.UIElements.Table.Implementations.TableTimeElement.#ctor')
- [TableViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableViewModel')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewModel-#ctor 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableViewModel.#ctor')
  - [Action](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewModel-Action 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableViewModel.Action')
  - [Area](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewModel-Area 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableViewModel.Area')
  - [Controller](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewModel-Controller 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableViewModel.Controller')
  - [HasActions](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewModel-HasActions 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableViewModel.HasActions')
  - [Header](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewModel-Header 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableViewModel.Header')
  - [Pagination](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewModel-Pagination 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableViewModel.Pagination')
  - [Rows](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewModel-Rows 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableViewModel.Rows')
  - [AddRow(row)](#M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewModel-AddRow-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowViewModel- 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableViewModel.AddRow(Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowViewModel)')
  - [SetPagination(currentPage,pagesCount)](#M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewModel-SetPagination-System-Int32,System-Int32- 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableViewModel.SetPagination(System.Int32,System.Int32)')
  - [SetPaginationRedirection(area,controller,action)](#M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewModel-SetPaginationRedirection-System-String,System-String,System-String- 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableViewModel.SetPaginationRedirection(System.String,System.String,System.String)')
- [TableViewViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableViewViewModel')
  - [SingleEntityName](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewViewModel-SingleEntityName 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableViewViewModel.SingleEntityName')
  - [Table](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewViewModel-Table 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableViewViewModel.Table')
  - [Title](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewViewModel-Title 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableViewViewModel.Title')
- [TempDataExtensions](#T-Definux-Emeraude-Admin-UI-Extensions-TempDataExtensions 'Definux.Emeraude.Admin.UI.Extensions.TempDataExtensions')
  - [TryGetErrorMessage(tempData,message)](#M-Definux-Emeraude-Admin-UI-Extensions-TempDataExtensions-TryGetErrorMessage-Microsoft-AspNetCore-Mvc-ViewFeatures-ITempDataDictionary,System-String@- 'Definux.Emeraude.Admin.UI.Extensions.TempDataExtensions.TryGetErrorMessage(Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary,System.String@)')
  - [TryGetSuccessMessage(tempData,message)](#M-Definux-Emeraude-Admin-UI-Extensions-TempDataExtensions-TryGetSuccessMessage-Microsoft-AspNetCore-Mvc-ViewFeatures-ITempDataDictionary,System-String@- 'Definux.Emeraude.Admin.UI.Extensions.TempDataExtensions.TryGetSuccessMessage(Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary,System.String@)')
- [TempFileLogViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Logging-TempFileLogViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Logging.TempFileLogViewModel')
  - [Applied](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-TempFileLogViewModel-Applied 'Definux.Emeraude.Admin.UI.ViewModels.Logging.TempFileLogViewModel.Applied')
  - [FileExtension](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-TempFileLogViewModel-FileExtension 'Definux.Emeraude.Admin.UI.ViewModels.Logging.TempFileLogViewModel.FileExtension')
  - [FileType](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-TempFileLogViewModel-FileType 'Definux.Emeraude.Admin.UI.ViewModels.Logging.TempFileLogViewModel.FileType')
  - [Name](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-TempFileLogViewModel-Name 'Definux.Emeraude.Admin.UI.ViewModels.Logging.TempFileLogViewModel.Name')
  - [Path](#P-Definux-Emeraude-Admin-UI-ViewModels-Logging-TempFileLogViewModel-Path 'Definux.Emeraude.Admin.UI.ViewModels.Logging.TempFileLogViewModel.Path')
- [TempFilesLogsViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Logging-TempFilesLogsViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Logging.TempFilesLogsViewModel')
- [UIDataSourceMapBasedElement\`1](#T-Definux-Emeraude-Admin-UI-UIElements-UIDataSourceMapBasedElement`1 'Definux.Emeraude.Admin.UI.UIElements.UIDataSourceMapBasedElement`1')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-UIElements-UIDataSourceMapBasedElement`1-#ctor 'Definux.Emeraude.Admin.UI.UIElements.UIDataSourceMapBasedElement`1.#ctor')
  - [DefineHtmlBuilder()](#M-Definux-Emeraude-Admin-UI-UIElements-UIDataSourceMapBasedElement`1-DefineHtmlBuilder 'Definux.Emeraude.Admin.UI.UIElements.UIDataSourceMapBasedElement`1.DefineHtmlBuilder')
- [UIDateTimeElement](#T-Definux-Emeraude-Admin-UI-UIElements-UIDateTimeElement 'Definux.Emeraude.Admin.UI.UIElements.UIDateTimeElement')
  - [#ctor(dateTimeFormat,typeName)](#M-Definux-Emeraude-Admin-UI-UIElements-UIDateTimeElement-#ctor-System-String,System-String- 'Definux.Emeraude.Admin.UI.UIElements.UIDateTimeElement.#ctor(System.String,System.String)')
  - [DefineHtmlBuilder()](#M-Definux-Emeraude-Admin-UI-UIElements-UIDateTimeElement-DefineHtmlBuilder 'Definux.Emeraude.Admin.UI.UIElements.UIDateTimeElement.DefineHtmlBuilder')
- [UIElement](#T-Definux-Emeraude-Admin-UI-UIElements-UIElement 'Definux.Emeraude.Admin.UI.UIElements.UIElement')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-UIElements-UIElement-#ctor 'Definux.Emeraude.Admin.UI.UIElements.UIElement.#ctor')
  - [DataSource](#P-Definux-Emeraude-Admin-UI-UIElements-UIElement-DataSource 'Definux.Emeraude.Admin.UI.UIElements.UIElement.DataSource')
  - [HtmlBuilder](#P-Definux-Emeraude-Admin-UI-UIElements-UIElement-HtmlBuilder 'Definux.Emeraude.Admin.UI.UIElements.UIElement.HtmlBuilder')
  - [ServiceProvider](#P-Definux-Emeraude-Admin-UI-UIElements-UIElement-ServiceProvider 'Definux.Emeraude.Admin.UI.UIElements.UIElement.ServiceProvider')
  - [DefineHtmlBuilder()](#M-Definux-Emeraude-Admin-UI-UIElements-UIElement-DefineHtmlBuilder 'Definux.Emeraude.Admin.UI.UIElements.UIElement.DefineHtmlBuilder')
  - [LoadServiceProvider()](#M-Definux-Emeraude-Admin-UI-UIElements-UIElement-LoadServiceProvider-System-IServiceProvider- 'Definux.Emeraude.Admin.UI.UIElements.UIElement.LoadServiceProvider(System.IServiceProvider)')
  - [RenderHtmlString()](#M-Definux-Emeraude-Admin-UI-UIElements-UIElement-RenderHtmlString 'Definux.Emeraude.Admin.UI.UIElements.UIElement.RenderHtmlString')
  - [ShowError(message)](#M-Definux-Emeraude-Admin-UI-UIElements-UIElement-ShowError-System-String- 'Definux.Emeraude.Admin.UI.UIElements.UIElement.ShowError(System.String)')
- [UIFlagElement](#T-Definux-Emeraude-Admin-UI-UIElements-UIFlagElement 'Definux.Emeraude.Admin.UI.UIElements.UIFlagElement')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-UIElements-UIFlagElement-#ctor 'Definux.Emeraude.Admin.UI.UIElements.UIFlagElement.#ctor')
  - [DefineHtmlBuilder()](#M-Definux-Emeraude-Admin-UI-UIElements-UIFlagElement-DefineHtmlBuilder 'Definux.Emeraude.Admin.UI.UIElements.UIFlagElement.DefineHtmlBuilder')
- [UILinkElement](#T-Definux-Emeraude-Admin-UI-UIElements-UILinkElement 'Definux.Emeraude.Admin.UI.UIElements.UILinkElement')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-UIElements-UILinkElement-#ctor 'Definux.Emeraude.Admin.UI.UIElements.UILinkElement.#ctor')
  - [DefineHtmlBuilder()](#M-Definux-Emeraude-Admin-UI-UIElements-UILinkElement-DefineHtmlBuilder 'Definux.Emeraude.Admin.UI.UIElements.UILinkElement.DefineHtmlBuilder')
- [UITextElement](#T-Definux-Emeraude-Admin-UI-UIElements-UITextElement 'Definux.Emeraude.Admin.UI.UIElements.UITextElement')
  - [#ctor()](#M-Definux-Emeraude-Admin-UI-UIElements-UITextElement-#ctor 'Definux.Emeraude.Admin.UI.UIElements.UITextElement.#ctor')
  - [DefineHtmlBuilder()](#M-Definux-Emeraude-Admin-UI-UIElements-UITextElement-DefineHtmlBuilder 'Definux.Emeraude.Admin.UI.UIElements.UITextElement.DefineHtmlBuilder')
- [UrlHelperExtensions](#T-Definux-Emeraude-Admin-UI-Extensions-UrlHelperExtensions 'Definux.Emeraude.Admin.UI.Extensions.UrlHelperExtensions')
  - [GetDefaultUrl(urlHelper,viewData)](#M-Definux-Emeraude-Admin-UI-Extensions-UrlHelperExtensions-GetDefaultUrl-Microsoft-AspNetCore-Mvc-IUrlHelper,Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary- 'Definux.Emeraude.Admin.UI.Extensions.UrlHelperExtensions.GetDefaultUrl(Microsoft.AspNetCore.Mvc.IUrlHelper,Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary)')
- [UserInfoResult](#T-Definux-Emeraude-Admin-UI-Adapters-UserInfoResult 'Definux.Emeraude.Admin.UI.Adapters.UserInfoResult')
  - [Email](#P-Definux-Emeraude-Admin-UI-Adapters-UserInfoResult-Email 'Definux.Emeraude.Admin.UI.Adapters.UserInfoResult.Email')
  - [Id](#P-Definux-Emeraude-Admin-UI-Adapters-UserInfoResult-Id 'Definux.Emeraude.Admin.UI.Adapters.UserInfoResult.Id')
  - [Name](#P-Definux-Emeraude-Admin-UI-Adapters-UserInfoResult-Name 'Definux.Emeraude.Admin.UI.Adapters.UserInfoResult.Name')
- [ViewContextExtensions](#T-Definux-Emeraude-Admin-UI-Extensions-ViewContextExtensions 'Definux.Emeraude.Admin.UI.Extensions.ViewContextExtensions')
  - [AppendIntoTheBody(viewContext,bodyLine)](#M-Definux-Emeraude-Admin-UI-Extensions-ViewContextExtensions-AppendIntoTheBody-Microsoft-AspNetCore-Mvc-Rendering-ViewContext,System-String- 'Definux.Emeraude.Admin.UI.Extensions.ViewContextExtensions.AppendIntoTheBody(Microsoft.AspNetCore.Mvc.Rendering.ViewContext,System.String)')
  - [AppendIntoTheHead(viewContext,headLine)](#M-Definux-Emeraude-Admin-UI-Extensions-ViewContextExtensions-AppendIntoTheHead-Microsoft-AspNetCore-Mvc-Rendering-ViewContext,System-String- 'Definux.Emeraude.Admin.UI.Extensions.ViewContextExtensions.AppendIntoTheHead(Microsoft.AspNetCore.Mvc.Rendering.ViewContext,System.String)')
- [ViewDataExtensions](#T-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions 'Definux.Emeraude.Admin.UI.Extensions.ViewDataExtensions')
  - [BreadcrumbsKey](#F-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-BreadcrumbsKey 'Definux.Emeraude.Admin.UI.Extensions.ViewDataExtensions.BreadcrumbsKey')
  - [NavigationActionsKey](#F-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-NavigationActionsKey 'Definux.Emeraude.Admin.UI.Extensions.ViewDataExtensions.NavigationActionsKey')
  - [AddBreadcrumb(viewData,breadcrumb)](#M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-AddBreadcrumb-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary,Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel- 'Definux.Emeraude.Admin.UI.Extensions.ViewDataExtensions.AddBreadcrumb(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary,Definux.Emeraude.Admin.UI.ViewModels.Layout.BreadcrumbItemViewModel)')
  - [AddNavigationAction(viewData,action)](#M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-AddNavigationAction-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary,Definux-Emeraude-Admin-UI-ViewModels-Layout-NavigationActionViewModel- 'Definux.Emeraude.Admin.UI.Extensions.ViewDataExtensions.AddNavigationAction(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary,Definux.Emeraude.Admin.UI.ViewModels.Layout.NavigationActionViewModel)')
  - [GetAction(viewData)](#M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-GetAction-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary- 'Definux.Emeraude.Admin.UI.Extensions.ViewDataExtensions.GetAction(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary)')
  - [GetArea(viewData)](#M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-GetArea-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary- 'Definux.Emeraude.Admin.UI.Extensions.ViewDataExtensions.GetArea(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary)')
  - [GetBreadcrumbs(viewData)](#M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-GetBreadcrumbs-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary- 'Definux.Emeraude.Admin.UI.Extensions.ViewDataExtensions.GetBreadcrumbs(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary)')
  - [GetController(viewData)](#M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-GetController-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary- 'Definux.Emeraude.Admin.UI.Extensions.ViewDataExtensions.GetController(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary)')
  - [GetDateValueOrNull(viewData,key)](#M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-GetDateValueOrNull-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary,System-String- 'Definux.Emeraude.Admin.UI.Extensions.ViewDataExtensions.GetDateValueOrNull(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary,System.String)')
  - [GetEntityName(viewData)](#M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-GetEntityName-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary- 'Definux.Emeraude.Admin.UI.Extensions.ViewDataExtensions.GetEntityName(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary)')
  - [GetNavigationActions(viewData)](#M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-GetNavigationActions-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary- 'Definux.Emeraude.Admin.UI.Extensions.ViewDataExtensions.GetNavigationActions(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary)')
  - [GetOrderProperties(viewData)](#M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-GetOrderProperties-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary- 'Definux.Emeraude.Admin.UI.Extensions.ViewDataExtensions.GetOrderProperties(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary)')
  - [GetOrderProperty(viewData)](#M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-GetOrderProperty-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary- 'Definux.Emeraude.Admin.UI.Extensions.ViewDataExtensions.GetOrderProperty(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary)')
  - [GetOrderType(viewData)](#M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-GetOrderType-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary- 'Definux.Emeraude.Admin.UI.Extensions.ViewDataExtensions.GetOrderType(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary)')
  - [GetSearchQuery(viewData)](#M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-GetSearchQuery-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary- 'Definux.Emeraude.Admin.UI.Extensions.ViewDataExtensions.GetSearchQuery(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary)')
  - [InitializeBreadcrumbs(viewData)](#M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-InitializeBreadcrumbs-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary- 'Definux.Emeraude.Admin.UI.Extensions.ViewDataExtensions.InitializeBreadcrumbs(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary)')
  - [InitializeNavigationActions(viewData,actions)](#M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-InitializeNavigationActions-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary,System-Collections-Generic-IEnumerable{Definux-Emeraude-Admin-UI-ViewModels-Layout-NavigationActionViewModel}- 'Definux.Emeraude.Admin.UI.Extensions.ViewDataExtensions.InitializeNavigationActions(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary,System.Collections.Generic.IEnumerable{Definux.Emeraude.Admin.UI.ViewModels.Layout.NavigationActionViewModel})')
  - [SetOrderProperty(viewData,value)](#M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-SetOrderProperty-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary,System-String- 'Definux.Emeraude.Admin.UI.Extensions.ViewDataExtensions.SetOrderProperty(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary,System.String)')
  - [SetOrderType(viewData,value)](#M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-SetOrderType-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary,System-String- 'Definux.Emeraude.Admin.UI.Extensions.ViewDataExtensions.SetOrderType(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary,System.String)')
  - [SetSearchQuery(viewData,value)](#M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-SetSearchQuery-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary,System-String- 'Definux.Emeraude.Admin.UI.Extensions.ViewDataExtensions.SetSearchQuery(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary,System.String)')
  - [SetTitle(viewData,title)](#M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-SetTitle-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary,System-String- 'Definux.Emeraude.Admin.UI.Extensions.ViewDataExtensions.SetTitle(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary,System.String)')

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Logging-ActivityLogViewModel'></a>
## ActivityLogViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Logging

##### Summary

View model that encapsulate activity log.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ActivityLogViewModel-Action'></a>
### Action `property`

##### Summary

Name of the requested controller action.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ActivityLogViewModel-Area'></a>
### Area `property`

##### Summary

Name of the requested controller area.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ActivityLogViewModel-Controller'></a>
### Controller `property`

##### Summary

Name of the requested controller.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ActivityLogViewModel-Headers'></a>
### Headers `property`

##### Summary

List represent as a string for all request headers.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ActivityLogViewModel-IsAuthenticatedUser'></a>
### IsAuthenticatedUser `property`

##### Summary

Flag that indicates whether the request is made from authenticated user.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ActivityLogViewModel-IsFromMobileDevice'></a>
### IsFromMobileDevice `property`

##### Summary

Flag that indicates whether the request is made from mobile device.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ActivityLogViewModel-Method'></a>
### Method `property`

##### Summary

Current request HTTP method.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ActivityLogViewModel-Parameters'></a>
### Parameters `property`

##### Summary

List represent as a string for all request parameters.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ActivityLogViewModel-Route'></a>
### Route `property`

##### Summary

Current request route.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ActivityLogViewModel-TraceId'></a>
### TraceId `property`

##### Summary

Unique string that unify each user.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ActivityLogViewModel-UserAgent'></a>
### UserAgent `property`

##### Summary

Current request user agent.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Logging-ActivityLogsViewModel'></a>
## ActivityLogsViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Logging

##### Summary

View model that represent activity logs view.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminChangeEmailViewModel'></a>
## AdminChangeEmailViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Manage

##### Summary

View model for changing administrator email.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminChangeEmailViewModel-NewEmail'></a>
### NewEmail `property`

##### Summary

New email.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminChangePasswordViewModel'></a>
## AdminChangePasswordViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Manage

##### Summary

View model for changing administrator password.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminChangePasswordViewModel-ConfirmedPassword'></a>
### ConfirmedPassword `property`

##### Summary

Confirmed new password.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminChangePasswordViewModel-CurrentPassword'></a>
### CurrentPassword `property`

##### Summary

Current password.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminChangePasswordViewModel-NewPassword'></a>
### NewPassword `property`

##### Summary

New password.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Account-AdminLoginViewModel'></a>
## AdminLoginViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Account

##### Summary

View model that defines the login form for admin authentication.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Account-AdminLoginViewModel-Email'></a>
### Email `property`

##### Summary

Email address of the admin user.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Account-AdminLoginViewModel-Password'></a>
### Password `property`

##### Summary

Password of the admin user.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Account-AdminLoginWith2FaViewModel'></a>
## AdminLoginWith2FaViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Account

##### Summary

View model that defines the multi-factor login form for admin authentication.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Account-AdminLoginWith2FaViewModel-TwoFactorCode'></a>
### TwoFactorCode `property`

##### Summary

Two factor authentication code.

<a name='T-Definux-Emeraude-Admin-UI-AdminMenu-AdminNavigationScheme'></a>
## AdminNavigationScheme `type`

##### Namespace

Definux.Emeraude.Admin.UI.AdminMenu

##### Summary

Model that defines the admin navigation schemes.

<a name='M-Definux-Emeraude-Admin-UI-AdminMenu-AdminNavigationScheme-#ctor-System-String,System-String-'></a>
### #ctor(contentRootPath,role) `constructor`

##### Summary

Initializes a new instance of the [AdminNavigationScheme](#T-Definux-Emeraude-Admin-UI-AdminMenu-AdminNavigationScheme 'Definux.Emeraude.Admin.UI.AdminMenu.AdminNavigationScheme') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| contentRootPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| role | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Admin-UI-AdminMenu-AdminNavigationScheme-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [AdminNavigationScheme](#T-Definux-Emeraude-Admin-UI-AdminMenu-AdminNavigationScheme 'Definux.Emeraude.Admin.UI.AdminMenu.AdminNavigationScheme') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Admin-UI-AdminMenu-AdminNavigationScheme-InsightsItems'></a>
### InsightsItems `property`

##### Summary

List of all insight items from the admin menu.

<a name='P-Definux-Emeraude-Admin-UI-AdminMenu-AdminNavigationScheme-Menus'></a>
### Menus `property`

##### Summary

List of all sidebar items from the admin menu.

<a name='M-Definux-Emeraude-Admin-UI-AdminMenu-AdminNavigationScheme-ApplyCurrentRoute-System-String-'></a>
### ApplyCurrentRoute(currentRoute) `method`

##### Summary

Method that apply current route to the state of navigation items.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| currentRoute | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminTwoFactorAuthenticationViewModel'></a>
## AdminTwoFactorAuthenticationViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Manage

##### Summary

ViewModel for activation of admin two factor authentication.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminTwoFactorAuthenticationViewModel-AuthenticatorUri'></a>
### AuthenticatorUri `property`

##### Summary

Two factor authenticator code used for QR code generation.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminTwoFactorAuthenticationViewModel-Code'></a>
### Code `property`

##### Summary

Two factor authenticator code.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminTwoFactorAuthenticationViewModel-HasAuthenticator'></a>
### HasAuthenticator `property`

##### Summary

Flag that indicates the current admin has two factor authenticator or not.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminTwoFactorAuthenticationViewModel-Is2faEnabled'></a>
### Is2faEnabled `property`

##### Summary

Flag that indicates the current user has enabled two factor authentication or not.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminTwoFactorAuthenticationViewModel-SharedKey'></a>
### SharedKey `property`

##### Summary

Key used for manual two factor authentication activation without a QR key.

<a name='T-Definux-Emeraude-Admin-UI-AdminUIAssemblyPart'></a>
## AdminUIAssemblyPart `type`

##### Namespace

Definux.Emeraude.Admin.UI

##### Summary

Static class that provides access to the Admin UI asembly information.

<a name='P-Definux-Emeraude-Admin-UI-AdminUIAssemblyPart-Assembly'></a>
### Assembly `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Admin-UI-AdminUIAssemblyPart-AssemblyPart'></a>
### AssemblyPart `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Admin-UI-AdminUIConfigureOptions'></a>
## AdminUIConfigureOptions `type`

##### Namespace

Definux.Emeraude.Admin.UI

##### Summary

Admin UI options that configure the static files loaded in the assembly.

<a name='M-Definux-Emeraude-Admin-UI-AdminUIConfigureOptions-#ctor-Microsoft-AspNetCore-Hosting-IHostingEnvironment-'></a>
### #ctor(environment) `constructor`

##### Summary

Initializes a new instance of the [AdminUIConfigureOptions](#T-Definux-Emeraude-Admin-UI-AdminUIConfigureOptions 'Definux.Emeraude.Admin.UI.AdminUIConfigureOptions') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| environment | [Microsoft.AspNetCore.Hosting.IHostingEnvironment](#T-Microsoft-AspNetCore-Hosting-IHostingEnvironment 'Microsoft.AspNetCore.Hosting.IHostingEnvironment') |  |

<a name='T-Definux-Emeraude-Admin-UI-TagHelpers-BodyTagHelper'></a>
## BodyTagHelper `type`

##### Namespace

Definux.Emeraude.Admin.UI.TagHelpers

##### Summary

Body tag helper.

<a name='P-Definux-Emeraude-Admin-UI-TagHelpers-BodyTagHelper-ViewContext'></a>
### ViewContext `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-UI-TagHelpers-BodyTagHelper-ProcessAsync-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput-'></a>
### ProcessAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel'></a>
## BreadcrumbItemViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Layout

##### Summary

Implementation of a breadcrumb item.

<a name='M-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel-#ctor-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext-'></a>
### #ctor(context) `constructor`

##### Summary

Initializes a new instance of the [BreadcrumbItemViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Layout.BreadcrumbItemViewModel') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext](#T-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext 'Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext') |  |

<a name='F-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel-BreadcrumbKey'></a>
### BreadcrumbKey `constants`

##### Summary

Breadcrumb ViewData key.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel-Action'></a>
### Action `property`

##### Summary

Action that builds the breadcrumb action link.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel-ActionLink'></a>
### ActionLink `property`

##### Summary

Action link of the breadcrumb.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel-Active'></a>
### Active `property`

##### Summary

Flag that shows the active status of the breadcrumb.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel-Controller'></a>
### Controller `property`

##### Summary

Controller that builds the breadcrumb action link.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel-Order'></a>
### Order `property`

##### Summary

Order of the breadcrumb.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel-ParameterName'></a>
### ParameterName `property`

##### Summary

Additional parameter name for the breadcrumb action link.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel-ParameterValue'></a>
### ParameterValue `property`

##### Summary

Additional parameter value for the breadcrumb action link.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel-ParentReferenceKey'></a>
### ParentReferenceKey `property`

##### Summary

In case breadcrumb is called from child controller that property defines the parent controller entity reference key.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel-ParentReferenceValue'></a>
### ParentReferenceValue `property`

##### Summary

In case breadcrumb is called from child controller that property defines the parent controller entity reference value.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel-Title'></a>
### Title `property`

##### Summary

Title of the breadcrumb.

<a name='T-Definux-Emeraude-Admin-UI-HtmlBuilders-CheckboxGroupHtmlBuilder`1'></a>
## CheckboxGroupHtmlBuilder\`1 `type`

##### Namespace

Definux.Emeraude.Admin.UI.HtmlBuilders

##### Summary

Built wrapper for HTML builder which creates checkbox group element.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey | Value type. |

<a name='M-Definux-Emeraude-Admin-UI-HtmlBuilders-CheckboxGroupHtmlBuilder`1-#ctor-System-Collections-Generic-Dictionary{`0,System-String},System-String,`0[]-'></a>
### #ctor(data,targetProperty,selectedValues) `constructor`

##### Summary

Initializes a new instance of the [CheckboxGroupHtmlBuilder\`1](#T-Definux-Emeraude-Admin-UI-HtmlBuilders-CheckboxGroupHtmlBuilder`1 'Definux.Emeraude.Admin.UI.HtmlBuilders.CheckboxGroupHtmlBuilder`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| data | [System.Collections.Generic.Dictionary{\`0,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{`0,System.String}') |  |
| targetProperty | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| selectedValues | [\`0[]](#T-`0[] '`0[]') |  |

<a name='T-Definux-Emeraude-Admin-UI-TagHelpers-CurrentUserTagHelper'></a>
## CurrentUserTagHelper `type`

##### Namespace

Definux.Emeraude.Admin.UI.TagHelpers

##### Summary

Returns the current user name and email packed in a span. Example: Admin Name (admin@example.com).

<a name='M-Definux-Emeraude-Admin-UI-TagHelpers-CurrentUserTagHelper-#ctor-Definux-Emeraude-Admin-UI-Adapters-IIdentityUserInfoAdapter-'></a>
### #ctor(identityUserInfoAdapter) `constructor`

##### Summary

Initializes a new instance of the [CurrentUserTagHelper](#T-Definux-Emeraude-Admin-UI-TagHelpers-CurrentUserTagHelper 'Definux.Emeraude.Admin.UI.TagHelpers.CurrentUserTagHelper') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| identityUserInfoAdapter | [Definux.Emeraude.Admin.UI.Adapters.IIdentityUserInfoAdapter](#T-Definux-Emeraude-Admin-UI-Adapters-IIdentityUserInfoAdapter 'Definux.Emeraude.Admin.UI.Adapters.IIdentityUserInfoAdapter') |  |

<a name='M-Definux-Emeraude-Admin-UI-TagHelpers-CurrentUserTagHelper-ProcessAsync-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput-'></a>
### ProcessAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-DataSourceMap`1'></a>
## DataSourceMap\`1 `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements

##### Summary

Abstract class that helps to be created custom data extraction for the purposes of UI element rendering.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TContext | Main database context of the application. |

<a name='M-Definux-Emeraude-Admin-UI-UIElements-DataSourceMap`1-#ctor-`0-'></a>
### #ctor(context) `constructor`

##### Summary

Initializes a new instance of the [DataSourceMap\`1](#T-Definux-Emeraude-Admin-UI-UIElements-DataSourceMap`1 'Definux.Emeraude.Admin.UI.UIElements.DataSourceMap`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [\`0](#T-`0 '`0') |  |

<a name='P-Definux-Emeraude-Admin-UI-UIElements-DataSourceMap`1-Context'></a>
### Context `property`

##### Summary

Database context of the application.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-DataSourceMap`1-Init'></a>
### Init() `method`

##### Summary

Method which contains the implementation of data extraction.

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-HtmlBuilders-DatePickerHtmlBuilder'></a>
## DatePickerHtmlBuilder `type`

##### Namespace

Definux.Emeraude.Admin.UI.HtmlBuilders

##### Summary

Built wrapper for HTML builder for date picker input.

<a name='M-Definux-Emeraude-Admin-UI-HtmlBuilders-DatePickerHtmlBuilder-#ctor-System-String,System-Nullable{System-DateTime},System-String-'></a>
### #ctor(targetProperty,value,placeholder) `constructor`

##### Summary

Initializes a new instance of the [DatePickerHtmlBuilder](#T-Definux-Emeraude-Admin-UI-HtmlBuilders-DatePickerHtmlBuilder 'Definux.Emeraude.Admin.UI.HtmlBuilders.DatePickerHtmlBuilder') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| targetProperty | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| value | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') |  |
| placeholder | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Admin-UI-TagHelpers-DatePickerTagHelper'></a>
## DatePickerTagHelper `type`

##### Namespace

Definux.Emeraude.Admin.UI.TagHelpers

##### Summary

Returns datepicker input.

<a name='P-Definux-Emeraude-Admin-UI-TagHelpers-DatePickerTagHelper-Name'></a>
### Name `property`

##### Summary

Target property name of the datepicker.

<a name='P-Definux-Emeraude-Admin-UI-TagHelpers-DatePickerTagHelper-Placeholder'></a>
### Placeholder `property`

##### Summary

The placeholder text of the datepicker.

<a name='P-Definux-Emeraude-Admin-UI-TagHelpers-DatePickerTagHelper-Value'></a>
### Value `property`

##### Summary

Current value of the datepicker.

<a name='M-Definux-Emeraude-Admin-UI-TagHelpers-DatePickerTagHelper-Process-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput-'></a>
### Process() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-TagHelpers-DefaultTableCellTagHelper'></a>
## DefaultTableCellTagHelper `type`

##### Namespace

Definux.Emeraude.Admin.UI.TagHelpers

##### Summary

Default table cell tag helper.

<a name='P-Definux-Emeraude-Admin-UI-TagHelpers-DefaultTableCellTagHelper-Fit'></a>
### Fit `property`

##### Summary

Flag that makes the cell with fit content.

<a name='P-Definux-Emeraude-Admin-UI-TagHelpers-DefaultTableCellTagHelper-MakeCellApplicableForDefaultTable'></a>
### MakeCellApplicableForDefaultTable `property`

##### Summary

Flag that applies the default table styles to the cell.

<a name='M-Definux-Emeraude-Admin-UI-TagHelpers-DefaultTableCellTagHelper-Process-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput-'></a>
### Process() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-TagHelpers-DefaultTableTagHelper'></a>
## DefaultTableTagHelper `type`

##### Namespace

Definux.Emeraude.Admin.UI.TagHelpers

##### Summary

Returns the layout of the default styled table in Emeraude administration.

<a name='M-Definux-Emeraude-Admin-UI-TagHelpers-DefaultTableTagHelper-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [DefaultTableTagHelper](#T-Definux-Emeraude-Admin-UI-TagHelpers-DefaultTableTagHelper 'Definux.Emeraude.Admin.UI.TagHelpers.DefaultTableTagHelper') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Admin-UI-TagHelpers-DefaultTableTagHelper-Columns'></a>
### Columns `property`

##### Summary

Columns of the table in form of arguments. Example of usage - column-1="Id".

<a name='M-Definux-Emeraude-Admin-UI-TagHelpers-DefaultTableTagHelper-Process-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput-'></a>
### Process() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Layout-DeleteLoggerEntityFormModel'></a>
## DeleteLoggerEntityFormModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Layout

##### Summary

Helper class for delete logger entity form.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-DeleteLoggerEntityFormModel-ButtonClasses'></a>
### ButtonClasses `property`

##### Summary

Button classes.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-DeleteLoggerEntityFormModel-ButtonIconClasses'></a>
### ButtonIconClasses `property`

##### Summary

Button icon.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-DeleteLoggerEntityFormModel-ButtonText'></a>
### ButtonText `property`

##### Summary

Button text.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-DeleteLoggerEntityFormModel-EntityId'></a>
### EntityId `property`

##### Summary

Entity ID.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-DeleteLoggerEntityFormModel-FormClasses'></a>
### FormClasses `property`

##### Summary

Form classes.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-DeleteLoggerEntityFormModel-LoggerEntityType'></a>
### LoggerEntityType `property`

##### Summary

Logger entity type.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldDataSourceMapElement`1'></a>
## DetailsFieldDataSourceMapElement\`1 `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Details.Implementations

##### Summary

Implementation of [UIElement](#T-Definux-Emeraude-Admin-UI-UIElements-UIElement 'Definux.Emeraude.Admin.UI.UIElements.UIElement') for value extracted from data source map for details elements.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TDataSourceMap | Data source map type. |

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldDataSourceMapElement`1-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [DetailsFieldDataSourceMapElement\`1](#T-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldDataSourceMapElement`1 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldDataSourceMapElement`1') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldDataSourceMapElement`1-HasClipboardCopyButton'></a>
### HasClipboardCopyButton `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldDateElement'></a>
## DetailsFieldDateElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Details.Implementations

##### Summary

Implementation of [UIDateTimeElement](#T-Definux-Emeraude-Admin-UI-UIElements-UIDateTimeElement 'Definux.Emeraude.Admin.UI.UIElements.UIDateTimeElement') for details cards for showing date.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldDateElement-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [DetailsFieldDateElement](#T-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldDateElement 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldDateElement') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldDateElement-HasClipboardCopyButton'></a>
### HasClipboardCopyButton `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldDateTimeElement'></a>
## DetailsFieldDateTimeElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Details.Implementations

##### Summary

Implementation of [UIDateTimeElement](#T-Definux-Emeraude-Admin-UI-UIElements-UIDateTimeElement 'Definux.Emeraude.Admin.UI.UIElements.UIDateTimeElement') for details cards for showing date and time.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldDateTimeElement-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [DetailsFieldDateTimeElement](#T-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldDateTimeElement 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldDateTimeElement') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldDateTimeElement-HasClipboardCopyButton'></a>
### HasClipboardCopyButton `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldFlagElement'></a>
## DetailsFieldFlagElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Details.Implementations

##### Summary

Implementation of [UIFlagElement](#T-Definux-Emeraude-Admin-UI-UIElements-UIFlagElement 'Definux.Emeraude.Admin.UI.UIElements.UIFlagElement') for details cards.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldFlagElement-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [DetailsFieldFlagElement](#T-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldFlagElement 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldFlagElement') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldFlagElement-HasClipboardCopyButton'></a>
### HasClipboardCopyButton `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldHtmlContentElement'></a>
## DetailsFieldHtmlContentElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Details.Implementations

##### Summary

Implementation of [UIElement](#T-Definux-Emeraude-Admin-UI-UIElements-UIElement 'Definux.Emeraude.Admin.UI.UIElements.UIElement') for details cards for showing HTML content.

<a name='P-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldHtmlContentElement-HasClipboardCopyButton'></a>
### HasClipboardCopyButton `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldHtmlContentElement-DefineHtmlBuilder'></a>
### DefineHtmlBuilder() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldLinkElement'></a>
## DetailsFieldLinkElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Details.Implementations

##### Summary

Implementation of [UILinkElement](#T-Definux-Emeraude-Admin-UI-UIElements-UILinkElement 'Definux.Emeraude.Admin.UI.UIElements.UILinkElement') for details cards.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldLinkElement-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [DetailsFieldLinkElement](#T-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldLinkElement 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldLinkElement') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldLinkElement-HasClipboardCopyButton'></a>
### HasClipboardCopyButton `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldTextElement'></a>
## DetailsFieldTextElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Details.Implementations

##### Summary

Implementation of [UITextElement](#T-Definux-Emeraude-Admin-UI-UIElements-UITextElement 'Definux.Emeraude.Admin.UI.UIElements.UITextElement') for details cards.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldTextElement-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [DetailsFieldTextElement](#T-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldTextElement 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldTextElement') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldTextElement-HasClipboardCopyButton'></a>
### HasClipboardCopyButton `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldTimeElement'></a>
## DetailsFieldTimeElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Details.Implementations

##### Summary

Implementation of [UIDateTimeElement](#T-Definux-Emeraude-Admin-UI-UIElements-UIDateTimeElement 'Definux.Emeraude.Admin.UI.UIElements.UIDateTimeElement') for details cards for showing time.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldTimeElement-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [DetailsFieldTimeElement](#T-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldTimeElement 'Definux.Emeraude.Admin.UI.UIElements.Details.Implementations.DetailsFieldTimeElement') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Admin-UI-UIElements-Details-Implementations-DetailsFieldTimeElement-HasClipboardCopyButton'></a>
### HasClipboardCopyButton `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Details-DetailsPropertyViewModel'></a>
## DetailsPropertyViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Entity.Details

##### Summary

Implementation of the details card row item.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Details-DetailsPropertyViewModel-DetailsFieldElement'></a>
### DetailsFieldElement `property`

##### Summary

Render UI element of the property.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Details-DetailsPropertyViewModel-KebapCaseName'></a>
### KebapCaseName `property`

##### Summary

Name of the property in kebap case.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Details-DetailsPropertyViewModel-Name'></a>
### Name `property`

##### Summary

Name of the property.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Details-DetailsPropertyViewModel-Order'></a>
### Order `property`

##### Summary

Order of the property.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Details-DetailsPropertyViewModel-Value'></a>
### Value `property`

##### Summary

Value of the property.

<a name='M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Details-DetailsPropertyViewModel-RenderHtmlContent'></a>
### RenderHtmlContent() `method`

##### Summary

Renders the HTML content for the current property.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Entity-DetailsCard-DetailsViewModel'></a>
## DetailsViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Entity.DetailsCard

##### Summary

Implementation of the details card of the entity.

<a name='M-Definux-Emeraude-Admin-UI-ViewModels-Entity-DetailsCard-DetailsViewModel-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [DetailsViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-DetailsCard-DetailsViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.DetailsCard.DetailsViewModel') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-DetailsCard-DetailsViewModel-Properties'></a>
### Properties `property`

##### Summary

List of all properties of the details card implemented by [DetailsPropertyViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Details-DetailsPropertyViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Details.DetailsPropertyViewModel').

<a name='M-Definux-Emeraude-Admin-UI-ViewModels-Entity-DetailsCard-DetailsViewModel-AddProperty-Definux-Emeraude-Admin-UI-ViewModels-Entity-Details-DetailsPropertyViewModel-'></a>
### AddProperty(property) `method`

##### Summary

Add a property to the card details.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| property | [Definux.Emeraude.Admin.UI.ViewModels.Entity.Details.DetailsPropertyViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Details-DetailsPropertyViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Details.DetailsPropertyViewModel') |  |

<a name='T-Definux-Emeraude-Admin-UI-TagHelpers-DevelopmentOnlyNotificationAlertTagHelper'></a>
## DevelopmentOnlyNotificationAlertTagHelper `type`

##### Namespace

Definux.Emeraude.Admin.UI.TagHelpers

##### Summary

Warning alert for pages which will be seen only in development.

<a name='M-Definux-Emeraude-Admin-UI-TagHelpers-DevelopmentOnlyNotificationAlertTagHelper-Process-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput-'></a>
### Process() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-HtmlBuilders-DropdownHtmlBuilder`1'></a>
## DropdownHtmlBuilder\`1 `type`

##### Namespace

Definux.Emeraude.Admin.UI.HtmlBuilders

##### Summary

Built wrapper for HTML builder which creates dropdown element.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey | Value type. |

<a name='M-Definux-Emeraude-Admin-UI-HtmlBuilders-DropdownHtmlBuilder`1-#ctor-System-Collections-Generic-Dictionary{`0,System-String},System-String,`0,System-Boolean-'></a>
### #ctor(data,targetProperty,selectedValue,isNullable) `constructor`

##### Summary

Initializes a new instance of the [DropdownHtmlBuilder\`1](#T-Definux-Emeraude-Admin-UI-HtmlBuilders-DropdownHtmlBuilder`1 'Definux.Emeraude.Admin.UI.HtmlBuilders.DropdownHtmlBuilder`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| data | [System.Collections.Generic.Dictionary{\`0,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{`0,System.String}') |  |
| targetProperty | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| selectedValue | [\`0](#T-`0 '`0') |  |
| isNullable | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-EditEntityViewModel'></a>
## EditEntityViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Entity.Form

##### Summary

Edit entity view model.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-EditEntityViewModel-Title'></a>
### Title `property`

##### Summary

Title of the entity.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Logging-EmailLogViewModel'></a>
## EmailLogViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Logging

##### Summary

View model that encapsulate email log.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-EmailLogViewModel-Body'></a>
### Body `property`

##### Summary

Body of the email.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-EmailLogViewModel-EmailAddress'></a>
### EmailAddress `property`

##### Summary

Email address.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-EmailLogViewModel-Receiver'></a>
### Receiver `property`

##### Summary

Receiver of the email.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-EmailLogViewModel-Sent'></a>
### Sent `property`

##### Summary

Flag that indicates whether email is sent or not.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-EmailLogViewModel-Subject'></a>
### Subject `property`

##### Summary

Subject of the email.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Logging-EmailsLogsViewModel'></a>
## EmailsLogsViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Logging

##### Summary

View model that represent email logs view.

<a name='T-Definux-Emeraude-Admin-UI-TagHelpers-EmeraudeVersionTagHelper'></a>
## EmeraudeVersionTagHelper `type`

##### Namespace

Definux.Emeraude.Admin.UI.TagHelpers

##### Summary

Tag helper that returns the current version of Emeraude Framework.

<a name='M-Definux-Emeraude-Admin-UI-TagHelpers-EmeraudeVersionTagHelper-#ctor-Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions}-'></a>
### #ctor(options) `constructor`

##### Summary

Initializes a new instance of the [EmeraudeVersionTagHelper](#T-Definux-Emeraude-Admin-UI-TagHelpers-EmeraudeVersionTagHelper 'Definux.Emeraude.Admin.UI.TagHelpers.EmeraudeVersionTagHelper') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions}](#T-Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions} 'Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions}') |  |

<a name='M-Definux-Emeraude-Admin-UI-TagHelpers-EmeraudeVersionTagHelper-Process-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput-'></a>
### Process() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Entity-DetailsCard-EntityDetailsViewModel'></a>
## EntityDetailsViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Entity.DetailsCard

##### Summary

Entity ViewModel that contains the render properties for the details view.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-DetailsCard-EntityDetailsViewModel-Details'></a>
### Details `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-EntityFormViewModel'></a>
## EntityFormViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Entity.Form

##### Summary

Implementation of entity form view model.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-EntityFormViewModel-Action'></a>
### Action `property`

##### Summary

Name of the action which are using the view model.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-EntityFormViewModel-Area'></a>
### Area `property`

##### Summary

Name of the area of action which are using the view model.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-EntityFormViewModel-Controller'></a>
### Controller `property`

##### Summary

Name of the controller of action which are using the view model.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-EntityFormViewModel-EntityName'></a>
### EntityName `property`

##### Summary

Name of the target entity for the view model.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-EntityFormViewModel-Inputs'></a>
### Inputs `property`

##### Summary



<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Logging-ErrorLogViewModel'></a>
## ErrorLogViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Logging

##### Summary

ViewModel encapsulated error log item.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ErrorLogViewModel-Message'></a>
### Message `property`

##### Summary

Message of the error log.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ErrorLogViewModel-Method'></a>
### Method `property`

##### Summary

Class method from where comes the error log.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ErrorLogViewModel-Source'></a>
### Source `property`

##### Summary

Source of the error log.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-ErrorLogViewModel-StackTrace'></a>
### StackTrace `property`

##### Summary

Stack trace of the error log.

<a name='T-Definux-Emeraude-Admin-UI-HtmlBuilders-ErrorNotificationHtmlBuilder'></a>
## ErrorNotificationHtmlBuilder `type`

##### Namespace

Definux.Emeraude.Admin.UI.HtmlBuilders

##### Summary

Built wrapper for HTML builder which creates error notification element with error message.

<a name='M-Definux-Emeraude-Admin-UI-HtmlBuilders-ErrorNotificationHtmlBuilder-#ctor-System-String-'></a>
### #ctor(message) `constructor`

##### Summary

Initializes a new instance of the [ErrorNotificationHtmlBuilder](#T-Definux-Emeraude-Admin-UI-HtmlBuilders-ErrorNotificationHtmlBuilder 'Definux.Emeraude.Admin.UI.HtmlBuilders.ErrorNotificationHtmlBuilder') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Logging-ErrorsLogsViewModel'></a>
## ErrorsLogsViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Logging

##### Summary

View model that represent error logs view.

<a name='T-Definux-Emeraude-Admin-UI-HtmlBuilders-FlagHtmlBuilder'></a>
## FlagHtmlBuilder `type`

##### Namespace

Definux.Emeraude.Admin.UI.HtmlBuilders

##### Summary

Built wrapper for HTML builder which creates flag element.

<a name='M-Definux-Emeraude-Admin-UI-HtmlBuilders-FlagHtmlBuilder-#ctor-System-Boolean,System-String,System-String-'></a>
### #ctor(value,trueValue,falseValue) `constructor`

##### Summary

Initializes a new instance of the [FlagHtmlBuilder](#T-Definux-Emeraude-Admin-UI-HtmlBuilders-FlagHtmlBuilder 'Definux.Emeraude.Admin.UI.HtmlBuilders.FlagHtmlBuilder') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
| trueValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| falseValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Admin-UI-TagHelpers-FlagTagHelper'></a>
## FlagTagHelper `type`

##### Namespace

Definux.Emeraude.Admin.UI.TagHelpers

##### Summary

Returns readonly checkbox for flag value.

<a name='P-Definux-Emeraude-Admin-UI-TagHelpers-FlagTagHelper-FalseValue'></a>
### FalseValue `property`

##### Summary

False value of the flag. Default value is 'No'.

<a name='P-Definux-Emeraude-Admin-UI-TagHelpers-FlagTagHelper-TrueValue'></a>
### TrueValue `property`

##### Summary

True value of the flag. Default value is 'Yes'.

<a name='P-Definux-Emeraude-Admin-UI-TagHelpers-FlagTagHelper-Value'></a>
### Value `property`

##### Summary

Value of the flag.

<a name='M-Definux-Emeraude-Admin-UI-TagHelpers-FlagTagHelper-Process-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput-'></a>
### Process() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-TagHelpers-ForPermissionTagHelper'></a>
## ForPermissionTagHelper `type`

##### Namespace

Definux.Emeraude.Admin.UI.TagHelpers

##### Summary

Show or hide the content of the tag based on specified permission.

<a name='M-Definux-Emeraude-Admin-UI-TagHelpers-ForPermissionTagHelper-#ctor-Definux-Emeraude-Admin-UI-Adapters-IIdentityUserInfoAdapter-'></a>
### #ctor(identityUserInfoAdapter) `constructor`

##### Summary

Initializes a new instance of the [ForPermissionTagHelper](#T-Definux-Emeraude-Admin-UI-TagHelpers-ForPermissionTagHelper 'Definux.Emeraude.Admin.UI.TagHelpers.ForPermissionTagHelper') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| identityUserInfoAdapter | [Definux.Emeraude.Admin.UI.Adapters.IIdentityUserInfoAdapter](#T-Definux-Emeraude-Admin-UI-Adapters-IIdentityUserInfoAdapter 'Definux.Emeraude.Admin.UI.Adapters.IIdentityUserInfoAdapter') |  |

<a name='P-Definux-Emeraude-Admin-UI-TagHelpers-ForPermissionTagHelper-Permission'></a>
### Permission `property`

##### Summary

Target permission.

<a name='M-Definux-Emeraude-Admin-UI-TagHelpers-ForPermissionTagHelper-ProcessAsync-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput-'></a>
### ProcessAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormDataSourceMapDropdownElement'></a>
## FormDataSourceMapDropdownElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Form.Implementations

##### Summary

Implementation of [FormElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement 'Definux.Emeraude.Admin.UI.UIElements.Form.FormElement') that renders a dropdown based on specified [IDataSourceMap](#T-Definux-Emeraude-Admin-UI-UIElements-IDataSourceMap 'Definux.Emeraude.Admin.UI.UIElements.IDataSourceMap').

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormDataSourceMapDropdownElement-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [FormDataSourceMapDropdownElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormDataSourceMapDropdownElement 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormDataSourceMapDropdownElement') class.

##### Parameters

This constructor has no parameters.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormDataSourceMapDropdownElement-DefineHtmlBuilder'></a>
### DefineHtmlBuilder() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormDatabaseCheckboxGroupElement'></a>
## FormDatabaseCheckboxGroupElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Form.Implementations

##### Summary

Implementation of [FormElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement 'Definux.Emeraude.Admin.UI.UIElements.Form.FormElement') that renders a checkbox group based on all entities from a table of the database.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormDatabaseCheckboxGroupElement-DefineHtmlBuilder'></a>
### DefineHtmlBuilder() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormDatabaseDropdownElement'></a>
## FormDatabaseDropdownElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Form.Implementations

##### Summary

Implementation of [FormElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement 'Definux.Emeraude.Admin.UI.UIElements.Form.FormElement') that renders a dropdown based on all entities from a table of the database.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormDatabaseDropdownElement-DefineHtmlBuilder'></a>
### DefineHtmlBuilder() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormDatabaseRadioGroupElement'></a>
## FormDatabaseRadioGroupElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Form.Implementations

##### Summary

Implementation of [FormElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement 'Definux.Emeraude.Admin.UI.UIElements.Form.FormElement') that renders a radio group based on all entities from a table of the database.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormDatabaseRadioGroupElement-DefineHtmlBuilder'></a>
### DefineHtmlBuilder() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormDateElement'></a>
## FormDateElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Form.Implementations

##### Summary

Implementation of [FormElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement 'Definux.Emeraude.Admin.UI.UIElements.Form.FormElement') that renders a date picker.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormDateElement-DefineHtmlBuilder'></a>
### DefineHtmlBuilder() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement'></a>
## FormElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Form

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [FormElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement 'Definux.Emeraude.Admin.UI.UIElements.Form.FormElement') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement-Hidden'></a>
### Hidden `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement-IsNullable'></a>
### IsNullable `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement-Label'></a>
### Label `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement-TargetProperty'></a>
### TargetProperty `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement-Value'></a>
### Value `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement-VisibleKey'></a>
### VisibleKey `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormEmailElement'></a>
## FormEmailElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Form.Implementations

##### Summary

Implementation of [FormElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement 'Definux.Emeraude.Admin.UI.UIElements.Form.FormElement') that renders an input of type 'email'.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormEmailElement-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [FormEmailElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormEmailElement 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormEmailElement') class.

##### Parameters

This constructor has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormEnumCheckboxGroupElement'></a>
## FormEnumCheckboxGroupElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Form.Implementations

##### Summary

Implementation of [FormElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement 'Definux.Emeraude.Admin.UI.UIElements.Form.FormElement') that renders a checkbox group based on all options from a specified enumeration.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormEnumCheckboxGroupElement-DefineHtmlBuilder'></a>
### DefineHtmlBuilder() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormEnumDropdownElement'></a>
## FormEnumDropdownElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Form.Implementations

##### Summary

Implementation of [FormElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement 'Definux.Emeraude.Admin.UI.UIElements.Form.FormElement') that renders a dropdown based on all options from a specified enumeration.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormEnumDropdownElement-DefineHtmlBuilder'></a>
### DefineHtmlBuilder() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormEnumRadioGroupElement'></a>
## FormEnumRadioGroupElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Form.Implementations

##### Summary

Implementation of [FormElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement 'Definux.Emeraude.Admin.UI.UIElements.Form.FormElement') that renders a radio group based on all options from a specified enumeration.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormEnumRadioGroupElement-DefineHtmlBuilder'></a>
### DefineHtmlBuilder() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormFlagElement'></a>
## FormFlagElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Form.Implementations

##### Summary

Implementation of [FormElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement 'Definux.Emeraude.Admin.UI.UIElements.Form.FormElement') that renders a checkbox representing a flag.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormFlagElement-DefineHtmlBuilder'></a>
### DefineHtmlBuilder() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormHiddenElement'></a>
## FormHiddenElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Form.Implementations

##### Summary

Implementation of [FormElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement 'Definux.Emeraude.Admin.UI.UIElements.Form.FormElement') that renders a hidden input.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormHiddenElement-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [FormHiddenElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormHiddenElement 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormHiddenElement') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormHiddenElement-InputType'></a>
### InputType `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormHiddenElement-KeepValue'></a>
### KeepValue `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormHiddenElement-DefineHtmlBuilder'></a>
### DefineHtmlBuilder() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormHtmlEditorElement'></a>
## FormHtmlEditorElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Form.Implementations

##### Summary

Implementation of [FormElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement 'Definux.Emeraude.Admin.UI.UIElements.Form.FormElement') that renders HTML editor.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormHtmlEditorElement-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [FormHtmlEditorElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormHtmlEditorElement 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormHtmlEditorElement') class.

##### Parameters

This constructor has no parameters.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormHtmlEditorElement-DefineHtmlBuilder'></a>
### DefineHtmlBuilder() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-FormInputViewModel'></a>
## FormInputViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Entity.Form

##### Summary

Implementation of the create/edit form input.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-FormInputViewModel-DataSourceType'></a>
### DataSourceType `property`

##### Summary

Data source of the input in case of multiple options for the input.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-FormInputViewModel-FormElement'></a>
### FormElement `property`

##### Summary

Render UI element of the input.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-FormInputViewModel-Hidden'></a>
### Hidden `property`

##### Summary

Flag that indicates that the element must be hidden.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-FormInputViewModel-IsFlag'></a>
### IsFlag `property`

##### Summary

Flag that indicates the input has behavior as a flag.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-FormInputViewModel-Label'></a>
### Label `property`

##### Summary

Label of the input.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-FormInputViewModel-Name'></a>
### Name `property`

##### Summary

Name of the input and related POST argument name.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-FormInputViewModel-Order'></a>
### Order `property`

##### Summary

Order of the input.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-FormInputViewModel-Value'></a>
### Value `property`

##### Summary

Value of the input.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-FormInputViewModel-VisualizationPropertyName'></a>
### VisualizationPropertyName `property`

##### Summary

Visualization property of the data source in case of multiple options for the input.

<a name='M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-FormInputViewModel-RenderHtmlContent'></a>
### RenderHtmlContent() `method`

##### Summary

Renders the HTML content for the current input.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormNumberElement'></a>
## FormNumberElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Form.Implementations

##### Summary

Implementation of [FormElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement 'Definux.Emeraude.Admin.UI.UIElements.Form.FormElement') that renders an input of type number.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormNumberElement-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [FormNumberElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormNumberElement 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormNumberElement') class.

##### Parameters

This constructor has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormPasswordElement'></a>
## FormPasswordElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Form.Implementations

##### Summary

Implementation of [FormElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement 'Definux.Emeraude.Admin.UI.UIElements.Form.FormElement') that renders an input of type password.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormPasswordElement-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [FormPasswordElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormPasswordElement 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormPasswordElement') class.

##### Parameters

This constructor has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormTextElement'></a>
## FormTextElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Form.Implementations

##### Summary

Implementation of [FormElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement 'Definux.Emeraude.Admin.UI.UIElements.Form.FormElement') that renders an input of type text.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormTextElement-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [FormTextElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormTextElement 'Definux.Emeraude.Admin.UI.UIElements.Form.Implementations.FormTextElement') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormTextElement-InputType'></a>
### InputType `property`

##### Summary

Type of the input.

<a name='P-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormTextElement-KeepValue'></a>
### KeepValue `property`

##### Summary

Flag that indicates whether the value been kept on a page refresh.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormTextElement-DefineHtmlBuilder'></a>
### DefineHtmlBuilder() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormTimeElement'></a>
## FormTimeElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Form.Implementations

##### Summary

Implementation of [FormElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-FormElement 'Definux.Emeraude.Admin.UI.UIElements.Form.FormElement') that renders a time picker.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Form-Implementations-FormTimeElement-DefineHtmlBuilder'></a>
### DefineHtmlBuilder() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-TagHelpers-FormVisibleRecaptchaTagHelper'></a>
## FormVisibleRecaptchaTagHelper `type`

##### Namespace

Definux.Emeraude.Admin.UI.TagHelpers

##### Summary

Tag helper that add visible recaptcha input + all required scripts into the head and body.

<a name='M-Definux-Emeraude-Admin-UI-TagHelpers-FormVisibleRecaptchaTagHelper-#ctor-Microsoft-Extensions-Options-IOptions{Definux-Utilities-Options-GoogleRecaptchaKeysOptions}-'></a>
### #ctor(options) `constructor`

##### Summary

Initializes a new instance of the [FormVisibleRecaptchaTagHelper](#T-Definux-Emeraude-Admin-UI-TagHelpers-FormVisibleRecaptchaTagHelper 'Definux.Emeraude.Admin.UI.TagHelpers.FormVisibleRecaptchaTagHelper') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [Microsoft.Extensions.Options.IOptions{Definux.Utilities.Options.GoogleRecaptchaKeysOptions}](#T-Microsoft-Extensions-Options-IOptions{Definux-Utilities-Options-GoogleRecaptchaKeysOptions} 'Microsoft.Extensions.Options.IOptions{Definux.Utilities.Options.GoogleRecaptchaKeysOptions}') |  |

<a name='P-Definux-Emeraude-Admin-UI-TagHelpers-FormVisibleRecaptchaTagHelper-ViewContext'></a>
### ViewContext `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-UI-TagHelpers-FormVisibleRecaptchaTagHelper-ProcessAsync-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput-'></a>
### ProcessAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-Utilities-Functions'></a>
## Functions `type`

##### Namespace

Definux.Emeraude.Admin.UI.Utilities

##### Summary

Static utility functions for the purposes of Admin UI.

<a name='M-Definux-Emeraude-Admin-UI-Utilities-Functions-GetDatabaseEntityDictionary-System-Collections-Generic-IEnumerable{Definux-Emeraude-Domain-Entities-IEntity},System-String-'></a>
### GetDatabaseEntityDictionary(databaseEntities,visibleProperty) `method`

##### Summary

Convert collection of entities to a dictionary with id as a key and specified property as a value.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| databaseEntities | [System.Collections.Generic.IEnumerable{Definux.Emeraude.Domain.Entities.IEntity}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Definux.Emeraude.Domain.Entities.IEntity}') |  |
| visibleProperty | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Admin-UI-Utilities-Functions-NormalizeRoute-System-String-'></a>
### NormalizeRoute(route) `method`

##### Summary

Normalize specified route.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| route | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Admin-UI-TagHelpers-HeadTagHelper'></a>
## HeadTagHelper `type`

##### Namespace

Definux.Emeraude.Admin.UI.TagHelpers

##### Summary

Head tag helper.

<a name='P-Definux-Emeraude-Admin-UI-TagHelpers-HeadTagHelper-ViewContext'></a>
### ViewContext `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-UI-TagHelpers-HeadTagHelper-ProcessAsync-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput-'></a>
### ProcessAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-IDataSourceMap'></a>
## IDataSourceMap `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements

##### Summary

Dictionary definition that helps to be created custom data extraction for the purposes of UI element rendering.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Details-IDetailsFieldElement'></a>
## IDetailsFieldElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Details

##### Summary

[IUIElement](#T-Definux-Emeraude-Admin-UI-UIElements-IUIElement 'Definux.Emeraude.Admin.UI.UIElements.IUIElement') specified for details card elements.

<a name='P-Definux-Emeraude-Admin-UI-UIElements-Details-IDetailsFieldElement-HasClipboardCopyButton'></a>
### HasClipboardCopyButton `property`

##### Summary

Flag that activate the button for copy in clipboard.

<a name='T-Definux-Emeraude-Admin-UI-Adapters-IEmContextAdapter'></a>
## IEmContextAdapter `type`

##### Namespace

Definux.Emeraude.Admin.UI.Adapters

##### Summary

Emeraude context adapter that provide access of unavailable services to administration UI assembly.

<a name='M-Definux-Emeraude-Admin-UI-Adapters-IEmContextAdapter-GetAllEntitiesByPropertyName-System-String-'></a>
### GetAllEntitiesByPropertyName(name) `method`

##### Summary

Get all entities from the database based on the property name.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the database context property. |

<a name='M-Definux-Emeraude-Admin-UI-Adapters-IEmContextAdapter-GetAllEntitiesByType-System-Type-'></a>
### GetAllEntitiesByType(entityType) `method`

##### Summary

Get all entities from the database based on the type of the desired entity.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entityType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Type of the desired entity. |

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-IEntityFormViewModel'></a>
## IEntityFormViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Entity.Form

##### Summary

Defines base structure of entity form view model.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-IEntityFormViewModel-Inputs'></a>
### Inputs `property`

##### Summary

List of all inputs for the current form view model.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Form-IFormElement'></a>
## IFormElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Form

##### Summary

[IUIElement](#T-Definux-Emeraude-Admin-UI-UIElements-IUIElement 'Definux.Emeraude.Admin.UI.UIElements.IUIElement') specified for form elements.

<a name='P-Definux-Emeraude-Admin-UI-UIElements-Form-IFormElement-Hidden'></a>
### Hidden `property`

##### Summary

Flag that indicate that the form element is hidden in the form.

<a name='P-Definux-Emeraude-Admin-UI-UIElements-Form-IFormElement-IsNullable'></a>
### IsNullable `property`

##### Summary

Flag that indicates whether the value supports null.

<a name='P-Definux-Emeraude-Admin-UI-UIElements-Form-IFormElement-Label'></a>
### Label `property`

##### Summary

Label of the form element.

<a name='P-Definux-Emeraude-Admin-UI-UIElements-Form-IFormElement-TargetProperty'></a>
### TargetProperty `property`

##### Summary

Target property of the form element.

<a name='P-Definux-Emeraude-Admin-UI-UIElements-Form-IFormElement-Value'></a>
### Value `property`

##### Summary

Value of the form element.

<a name='P-Definux-Emeraude-Admin-UI-UIElements-Form-IFormElement-VisibleKey'></a>
### VisibleKey `property`

##### Summary

Visible property of the form element object.

<a name='T-Definux-Emeraude-Admin-UI-Adapters-IIdentityUserInfoAdapter'></a>
## IIdentityUserInfoAdapter `type`

##### Namespace

Definux.Emeraude.Admin.UI.Adapters

##### Summary

Adapted for transferring data to Admin UI assembly.

<a name='M-Definux-Emeraude-Admin-UI-Adapters-IIdentityUserInfoAdapter-GetCurrentUserClaimsAsync'></a>
### GetCurrentUserClaimsAsync() `method`

##### Summary

Get current user claims.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-UI-Adapters-IIdentityUserInfoAdapter-GetCurrentUserInfoAsync'></a>
### GetCurrentUserInfoAsync() `method`

##### Summary

Get current user info.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Table-ITableElement'></a>
## ITableElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Table

##### Summary

[IUIElement](#T-Definux-Emeraude-Admin-UI-UIElements-IUIElement 'Definux.Emeraude.Admin.UI.UIElements.IUIElement') specified for table elements.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-IUIElement'></a>
## IUIElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements

##### Summary

Definition of view rendering abstraction by using source data and predefined HTML builder.

<a name='P-Definux-Emeraude-Admin-UI-UIElements-IUIElement-DataSource'></a>
### DataSource `property`

##### Summary

Data source of the element.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-IUIElement-DefineHtmlBuilder'></a>
### DefineHtmlBuilder() `method`

##### Summary

Method which purpose is to be used for UI element HTML builder.

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-IUIElement-LoadServiceProvider-System-IServiceProvider-'></a>
### LoadServiceProvider(serviceProvider) `method`

##### Summary

Method used for loading the application service provider ([IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider')).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceProvider | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') |  |

<a name='M-Definux-Emeraude-Admin-UI-UIElements-IUIElement-RenderHtmlString'></a>
### RenderHtmlString() `method`

##### Summary

Method that returns the HTML result.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Logging-LogEntitiesViewModel`1'></a>
## LogEntitiesViewModel\`1 `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Logging

##### Summary

Log entity abstraction for view model implementation.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TResultViewModel | Result view model implementation. |

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-LogEntitiesViewModel`1-FromDate'></a>
### FromDate `property`

##### Summary

Date indicates the start date of the filter.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-LogEntitiesViewModel`1-SearchQuery'></a>
### SearchQuery `property`

##### Summary

Search query.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-LogEntitiesViewModel`1-ToDate'></a>
### ToDate `property`

##### Summary

Date indicates the end date of the filter.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-LogEntitiesViewModel`1-User'></a>
### User `property`

##### Summary

User id or null used for filter by involved user.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Logging-LogEntityViewModel'></a>
## LogEntityViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Logging

##### Summary

Abstraction defines the log entity view model.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-LogEntityViewModel-CreatedBy'></a>
### CreatedBy `property`

##### Summary

Creator of the log.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-LogEntityViewModel-CreatedOn'></a>
### CreatedOn `property`

##### Summary

Date of creation of the log.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-LogEntityViewModel-Id'></a>
### Id `property`

##### Summary

Id of the log.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-LogEntityViewModel-InvolvedUser'></a>
### InvolvedUser `property`

##### Summary

User that create error log.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Logging-LogUserViewModel'></a>
## LogUserViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Logging

##### Summary

Encapsulates user registered the log.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-LogUserViewModel-Email'></a>
### Email `property`

##### Summary

Email of the user.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-LogUserViewModel-Id'></a>
### Id `property`

##### Summary

Id of the user.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-LogUserViewModel-Name'></a>
### Name `property`

##### Summary

Name of the user.

<a name='T-Definux-Emeraude-Admin-UI-TagHelpers-MenuSectionTagHelper'></a>
## MenuSectionTagHelper `type`

##### Namespace

Definux.Emeraude.Admin.UI.TagHelpers

##### Summary

Tag helper used for rendering the admin menu section of the administration sidebar.

<a name='P-Definux-Emeraude-Admin-UI-TagHelpers-MenuSectionTagHelper-Index'></a>
### Index `property`

##### Summary

Index of the menu section.

<a name='P-Definux-Emeraude-Admin-UI-TagHelpers-MenuSectionTagHelper-Model'></a>
### Model `property`

##### Summary

Model of the section.

<a name='P-Definux-Emeraude-Admin-UI-TagHelpers-MenuSectionTagHelper-ViewContext'></a>
### ViewContext `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-UI-TagHelpers-MenuSectionTagHelper-Process-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput-'></a>
### Process() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-ModalActionButton'></a>
## ModalActionButton `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Layout.ModalViewModel

##### Summary

Struct that represent the action button of the modal.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-ModalActionButton-Classes'></a>
### Classes `property`

##### Summary

Style classes of the button.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-ModalActionButton-Id'></a>
### Id `property`

##### Summary

Identificator of the button.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-ModalActionButton-Title'></a>
### Title `property`

##### Summary

Title text of the button.

<a name='T-Definux-Emeraude-Admin-UI-Utilities-ModalType'></a>
## ModalType `type`

##### Namespace

Definux.Emeraude.Admin.UI.Utilities

##### Summary

Type of the modal.

<a name='F-Definux-Emeraude-Admin-UI-Utilities-ModalType-Large'></a>
### Large `constants`

##### Summary

Large size.

<a name='F-Definux-Emeraude-Admin-UI-Utilities-ModalType-Normal'></a>
### Normal `constants`

##### Summary

Normal size.

<a name='F-Definux-Emeraude-Admin-UI-Utilities-ModalType-Small'></a>
### Small `constants`

##### Summary

Small size.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel'></a>
## ModalViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Layout

##### Summary

ViewModel that complements the '_Modal' partial.

<a name='M-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [ModalViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Layout.ModalViewModel') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-Buttons'></a>
### Buttons `property`

##### Summary

List of all action buttons of the modal.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-Content'></a>
### Content `property`

##### Summary

Content of the modal.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-ContentClass'></a>
### ContentClass `property`

##### Summary

Content class of the modal.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-HasCloseButton'></a>
### HasCloseButton `property`

##### Summary

Flag that show/hide the close button of the modal.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-IsContentHtml'></a>
### IsContentHtml `property`

##### Summary

Flag that indicates whether the content is raw text or HTML.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-LunchButtonClasses'></a>
### LunchButtonClasses `property`

##### Summary

Classes of the button that lunch the modal.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-LunchButtonIcon'></a>
### LunchButtonIcon `property`

##### Summary

Icon of the button that lunch the modal.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-LunchButtonTitle'></a>
### LunchButtonTitle `property`

##### Summary

Title text of the button that lunch the modal.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-ModalBodyClasses'></a>
### ModalBodyClasses `property`

##### Summary

Classes of the modal body.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-ModalFooterClasses'></a>
### ModalFooterClasses `property`

##### Summary

Classes of the modal footer.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-ModalHeaderClasses'></a>
### ModalHeaderClasses `property`

##### Summary

Classes of the modal header.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-ModalId'></a>
### ModalId `property`

##### Summary

Identification of the modal.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-Title'></a>
### Title `property`

##### Summary

Title text of the modal.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-Type'></a>
### Type `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-ModalViewModel-TypeClass'></a>
### TypeClass `property`

##### Summary

Modal type class based on the modal type.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Layout-NavigationActionViewModel'></a>
## NavigationActionViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Layout

##### Summary

View model that represents navigation action from the top bar of the administration panel.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-NavigationActionViewModel-ActionUrl'></a>
### ActionUrl `property`

##### Summary

Action URL.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-NavigationActionViewModel-ConfirmationMessage'></a>
### ConfirmationMessage `property`

##### Summary

Confirmation popup message.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-NavigationActionViewModel-ConfirmationTitle'></a>
### ConfirmationTitle `property`

##### Summary

Confirmation popup title.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-NavigationActionViewModel-HasConfirmation'></a>
### HasConfirmation `property`

##### Summary

Indicates that whether to be shown a confirmation popup.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-NavigationActionViewModel-Icon'></a>
### Icon `property`

##### Summary

Visualization icon.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-NavigationActionViewModel-Method'></a>
### Method `property`

##### Summary

HTTP method of the action.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-NavigationActionViewModel-Name'></a>
### Name `property`

##### Summary

Visualization name.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-NavigationActionViewModel-Parameters'></a>
### Parameters `property`

##### Summary

Parameters for the action.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Layout-NavigationActionViewModel-SeparatePage'></a>
### SeparatePage `property`

##### Summary

Represents a flag that indicates the URL be opened on separated page.

<a name='T-Definux-Emeraude-Admin-UI-TagHelpers-NotificationAlertTagHelper'></a>
## NotificationAlertTagHelper `type`

##### Namespace

Definux.Emeraude.Admin.UI.TagHelpers

##### Summary

Render notification alert for container for the content inside.

<a name='P-Definux-Emeraude-Admin-UI-TagHelpers-NotificationAlertTagHelper-Type'></a>
### Type `property`

##### Summary

Type of the notification (primary, secondary, success, danger, warning, info, light, dark).

<a name='M-Definux-Emeraude-Admin-UI-TagHelpers-NotificationAlertTagHelper-Process-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput-'></a>
### Process() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-HtmlBuilders-RadioGroupHtmlBuilder`1'></a>
## RadioGroupHtmlBuilder\`1 `type`

##### Namespace

Definux.Emeraude.Admin.UI.HtmlBuilders

##### Summary

Predefined radio group [HtmlBuilder](#T-Definux-HtmlBuilder-HtmlBuilder 'Definux.HtmlBuilder.HtmlBuilder').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey | Key that represent the value used for radios. |

<a name='M-Definux-Emeraude-Admin-UI-HtmlBuilders-RadioGroupHtmlBuilder`1-#ctor-System-Collections-Generic-Dictionary{`0,System-String},System-String,`0-'></a>
### #ctor(data,targetProperty,selectedValue) `constructor`

##### Summary

Initializes a new instance of the [RadioGroupHtmlBuilder\`1](#T-Definux-Emeraude-Admin-UI-HtmlBuilders-RadioGroupHtmlBuilder`1 'Definux.Emeraude.Admin.UI.HtmlBuilders.RadioGroupHtmlBuilder`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| data | [System.Collections.Generic.Dictionary{\`0,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{`0,System.String}') |  |
| targetProperty | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| selectedValue | [\`0](#T-`0 '`0') |  |

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Users-RolesViewModel-RoleOption'></a>
## RoleOption `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Users.RolesViewModel

##### Summary

Helper role option struct.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Users-RolesViewModel-RoleOption-Name'></a>
### Name `property`

##### Summary

Name of the role.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Users-RolesViewModel-RoleOption-Value'></a>
### Value `property`

##### Summary

Value property that represent the id of the role.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Users-RolesViewModel'></a>
## RolesViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Users

##### Summary

View model for role assignment feature.

<a name='M-Definux-Emeraude-Admin-UI-ViewModels-Users-RolesViewModel-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [RolesViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Users-RolesViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Users.RolesViewModel') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Users-RolesViewModel-RoleOptions'></a>
### RoleOptions `property`

##### Summary

List of all roles in the application.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Users-RolesViewModel-SelectedRoles'></a>
### SelectedRoles `property`

##### Summary

List of all selected roles.

<a name='M-Definux-Emeraude-Admin-UI-ViewModels-Users-RolesViewModel-SetRoleOptions-System-Collections-Generic-Dictionary{System-Guid,System-String}-'></a>
### SetRoleOptions(rolesDictionary) `method`

##### Summary

Method that apply roles dictionary into [RoleOptions](#P-Definux-Emeraude-Admin-UI-ViewModels-Users-RolesViewModel-RoleOptions 'Definux.Emeraude.Admin.UI.ViewModels.Users.RolesViewModel.RoleOptions').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rolesDictionary | [System.Collections.Generic.Dictionary{System.Guid,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.Guid,System.String}') |  |

<a name='M-Definux-Emeraude-Admin-UI-ViewModels-Users-RolesViewModel-SetSelectedRoles-System-Collections-Generic-Dictionary{System-Guid,System-String}-'></a>
### SetSelectedRoles(userRolesDictionary) `method`

##### Summary

Method that apply roles dictionary into [SelectedRoles](#P-Definux-Emeraude-Admin-UI-ViewModels-Users-RolesViewModel-SelectedRoles 'Definux.Emeraude.Admin.UI.ViewModels.Users.RolesViewModel.SelectedRoles').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userRolesDictionary | [System.Collections.Generic.Dictionary{System.Guid,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.Guid,System.String}') |  |

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootCreateFolderViewModel'></a>
## RootCreateFolderViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Roots

##### Summary

View model for creating new folder.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootCreateFolderViewModel-FolderName'></a>
### FolderName `property`

##### Summary

Name of the folder.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootCreateFolderViewModel-ParentFolderPath'></a>
### ParentFolderPath `property`

##### Summary

Target folder path.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootCreateFolderViewModel-Root'></a>
### Root `property`

##### Summary

Target root.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFileViewModel'></a>
## RootFileViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Roots

##### Summary

Implementation of root file of the system.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFileViewModel-CreatedOn'></a>
### CreatedOn `property`

##### Summary

Creation date of the file.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFileViewModel-LastModifiedOn'></a>
### LastModifiedOn `property`

##### Summary

Last modification date of the file.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFileViewModel-Name'></a>
### Name `property`

##### Summary

Name of the file.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFileViewModel-RelativePath'></a>
### RelativePath `property`

##### Summary

Relative path of the file.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFileViewModel-RelativePathUrlFormat'></a>
### RelativePathUrlFormat `property`

##### Summary

URL of the file.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFileViewModel-Size'></a>
### Size `property`

##### Summary

Size of the file.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFileViewModel-SizeString'></a>
### SizeString `property`

##### Summary

Size of the file with size suffix.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFolderViewModel'></a>
## RootFolderViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Roots

##### Summary

Implementation of root folder of the system.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFolderViewModel-CreatedOn'></a>
### CreatedOn `property`

##### Summary

Creation date of the folder.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFolderViewModel-LastModifiedOn'></a>
### LastModifiedOn `property`

##### Summary

Last modification date of the folder.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFolderViewModel-Name'></a>
### Name `property`

##### Summary

Name of the folder.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFolderViewModel-RelativePath'></a>
### RelativePath `property`

##### Summary

Relative path of the folder.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFolderViewModel-RelativePathUrlFormat'></a>
### RelativePathUrlFormat `property`

##### Summary

URL of the folder.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootUploadFilesViewModel'></a>
## RootUploadFilesViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Roots

##### Summary

View model for uploading file.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootUploadFilesViewModel-ParentFolderPath'></a>
### ParentFolderPath `property`

##### Summary

Target folder path.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootUploadFilesViewModel-Root'></a>
### Root `property`

##### Summary

Target root of the file.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootViewModel'></a>
## RootViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Roots

##### Summary

ViewModel of the roots (public and private) actions of file management feature of the application.

<a name='M-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootViewModel-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [RootViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootViewModel') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootViewModel-Files'></a>
### Files `property`

##### Summary

List of all files implemented by [RootFileViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFileViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootFileViewModel') in the current folder.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootViewModel-FolderName'></a>
### FolderName `property`

##### Summary

Current folder name.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootViewModel-Folders'></a>
### Folders `property`

##### Summary

List of all folders implemented by [RootFolderViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootFolderViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootFolderViewModel') in the current folder.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootViewModel-Root'></a>
### Root `property`

##### Summary

Name of the target root.

<a name='M-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootViewModel-AddFile-System-String,System-String,System-Int64,System-DateTime,System-DateTime-'></a>
### AddFile(name,relativePath,fileSize,createdOn,lastModifiedOn) `method`

##### Summary

Add file to the list of files.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| relativePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| fileSize | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |
| createdOn | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') |  |
| lastModifiedOn | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') |  |

<a name='M-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootViewModel-AddFolder-System-String,System-String,System-DateTime,System-DateTime-'></a>
### AddFolder(name,relativePath,createdOn,lastModifiedOn) `method`

##### Summary

Add folder to the list of files.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| relativePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| createdOn | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') |  |
| lastModifiedOn | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') |  |

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-SelectableGalleryViewModel'></a>
## SelectableGalleryViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Entity.Form

##### Summary

Implementation of view model specified to apply image to entity.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-SelectableGalleryViewModel-Action'></a>
### Action `property`

##### Summary

Name of the target action that using the view model.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-SelectableGalleryViewModel-Controller'></a>
### Controller `property`

##### Summary

Name of the target controller of the action that using the view model.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-SelectableGalleryViewModel-Pictures'></a>
### Pictures `property`

##### Summary

List of all images urls used for the form view.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-SelectableGalleryViewModel-SelectedPicture'></a>
### SelectedPicture `property`

##### Summary

Url of the selected image.

<a name='T-Definux-Emeraude-Admin-UI-Extensions-ServiceCollectionExtensions'></a>
## ServiceCollectionExtensions `type`

##### Namespace

Definux.Emeraude.Admin.UI.Extensions

##### Summary

Extensions for [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection').

<a name='M-Definux-Emeraude-Admin-UI-Extensions-ServiceCollectionExtensions-ConfigureAdminUI-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### ConfigureAdminUI(services) `method`

##### Summary

Configure Admin UI.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |

<a name='T-Definux-Emeraude-Admin-UI-AdminMenu-SidebarInsightItem'></a>
## SidebarInsightItem `type`

##### Namespace

Definux.Emeraude.Admin.UI.AdminMenu

##### Summary

Model defines the sidebar insight item.

<a name='P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarInsightItem-Blank'></a>
### Blank `property`

##### Summary

Flag that indicates whether the route be opened on the same page or not.

<a name='P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarInsightItem-Icon'></a>
### Icon `property`

##### Summary

Icon of the item.

<a name='P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarInsightItem-IsButton'></a>
### IsButton `property`

##### Summary

Indicates whether the item has button behavior or not.

<a name='P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarInsightItem-Route'></a>
### Route `property`

##### Summary

Route of the item.

<a name='P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarInsightItem-Title'></a>
### Title `property`

##### Summary

Title of the item.

<a name='T-Definux-Emeraude-Admin-UI-AdminMenu-SidebarMenuSectionItem'></a>
## SidebarMenuSectionItem `type`

##### Namespace

Definux.Emeraude.Admin.UI.AdminMenu

##### Summary

Model that defines sidebar section of the admin menu.

<a name='P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarMenuSectionItem-Children'></a>
### Children `property`

##### Summary

List of all sub-items of the section.

<a name='P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarMenuSectionItem-Dropdown'></a>
### Dropdown `property`

##### Summary

Flag that indicates whether the section has behavior of dropdown or not.

<a name='P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarMenuSectionItem-Icon'></a>
### Icon `property`

##### Summary

Icon of the section.

<a name='P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarMenuSectionItem-IsActive'></a>
### IsActive `property`

##### Summary

Flag that indicates the active state of the section for the current request.

<a name='P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarMenuSectionItem-IsSingle'></a>
### IsSingle `property`

##### Summary

Computed flag that return true when there is just one sub-item in the section.

<a name='P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarMenuSectionItem-SingleLinkItem'></a>
### SingleLinkItem `property`

##### Summary

Computed property that return the single link item if the section is single.

<a name='P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarMenuSectionItem-Title'></a>
### Title `property`

##### Summary

Title of the section.

<a name='M-Definux-Emeraude-Admin-UI-AdminMenu-SidebarMenuSectionItem-BuildState-System-String-'></a>
### BuildState(currentRoute) `method`

##### Summary

Method that apply current route to the state of the section.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| currentRoute | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Admin-UI-AdminMenu-SidebarNavigationLinkItem'></a>
## SidebarNavigationLinkItem `type`

##### Namespace

Definux.Emeraude.Admin.UI.AdminMenu

##### Summary

Model that defines sidebar link part of the sidebar section [SidebarMenuSectionItem](#T-Definux-Emeraude-Admin-UI-AdminMenu-SidebarMenuSectionItem 'Definux.Emeraude.Admin.UI.AdminMenu.SidebarMenuSectionItem').

<a name='P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarNavigationLinkItem-DefaultRoute'></a>
### DefaultRoute `property`

##### Summary

Default route of the link item.

<a name='P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarNavigationLinkItem-IsActive'></a>
### IsActive `property`

##### Summary

Flag that indicates the active state of the link item.

<a name='P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarNavigationLinkItem-Routes'></a>
### Routes `property`

##### Summary

Route of the link item.

<a name='P-Definux-Emeraude-Admin-UI-AdminMenu-SidebarNavigationLinkItem-Title'></a>
### Title `property`

##### Summary

Title of the link item.

<a name='M-Definux-Emeraude-Admin-UI-AdminMenu-SidebarNavigationLinkItem-BuildState-System-String-'></a>
### BuildState(currentRoute) `method`

##### Summary

Method that apply current route to the state of the navigation link.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| currentRoute | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableCellViewModel'></a>
## TableCellViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Entity.Table

##### Summary

Implementation of the table cell item.

<a name='M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableCellViewModel-#ctor-System-Int32,System-Object,Definux-Emeraude-Admin-UI-UIElements-Table-ITableElement-'></a>
### #ctor(order,content,tableElement) `constructor`

##### Summary

Initializes a new instance of the [TableCellViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableCellViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableCellViewModel') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| order | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| content | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| tableElement | [Definux.Emeraude.Admin.UI.UIElements.Table.ITableElement](#T-Definux-Emeraude-Admin-UI-UIElements-Table-ITableElement 'Definux.Emeraude.Admin.UI.UIElements.Table.ITableElement') |  |

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableCellViewModel-Order'></a>
### Order `property`

##### Summary

Order of the cell.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableCellViewModel-TableElement'></a>
### TableElement `property`

##### Summary

Render UI element of the cell.

<a name='M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableCellViewModel-RenderHtmlContent'></a>
### RenderHtmlContent() `method`

##### Summary

Renders the HTML content for the current cell.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableDataSourceMapElement`1'></a>
## TableDataSourceMapElement\`1 `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Table.Implementations

##### Summary

Implementation of [UIElement](#T-Definux-Emeraude-Admin-UI-UIElements-UIElement 'Definux.Emeraude.Admin.UI.UIElements.UIElement') for value extracted from data source map for table elements.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TDataSourceMap | Data source map type. |

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableDataSourceMapElement`1-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [TableDataSourceMapElement\`1](#T-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableDataSourceMapElement`1 'Definux.Emeraude.Admin.UI.UIElements.Table.Implementations.TableDataSourceMapElement`1') class.

##### Parameters

This constructor has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableDateElement'></a>
## TableDateElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Table.Implementations

##### Summary

Implementation of [UIDateTimeElement](#T-Definux-Emeraude-Admin-UI-UIElements-UIDateTimeElement 'Definux.Emeraude.Admin.UI.UIElements.UIDateTimeElement') for tables for showing date.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableDateElement-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [TableDateElement](#T-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableDateElement 'Definux.Emeraude.Admin.UI.UIElements.Table.Implementations.TableDateElement') class.

##### Parameters

This constructor has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableDateTimeElement'></a>
## TableDateTimeElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Table.Implementations

##### Summary

Implementation of [UIDateTimeElement](#T-Definux-Emeraude-Admin-UI-UIElements-UIDateTimeElement 'Definux.Emeraude.Admin.UI.UIElements.UIDateTimeElement') for tables for showing date and time.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableDateTimeElement-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [TableDateTimeElement](#T-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableDateTimeElement 'Definux.Emeraude.Admin.UI.UIElements.Table.Implementations.TableDateTimeElement') class.

##### Parameters

This constructor has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableFlagElement'></a>
## TableFlagElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Table.Implementations

##### Summary

Implementation of [UIFlagElement](#T-Definux-Emeraude-Admin-UI-UIElements-UIFlagElement 'Definux.Emeraude.Admin.UI.UIElements.UIFlagElement') for tables.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableFlagElement-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [TableFlagElement](#T-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableFlagElement 'Definux.Emeraude.Admin.UI.UIElements.Table.Implementations.TableFlagElement') class.

##### Parameters

This constructor has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableHeaderCellViewModel'></a>
## TableHeaderCellViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Entity.Table

##### Summary

Implementation of table header cell.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableHeaderCellViewModel-Name'></a>
### Name `property`

##### Summary

Name of the cell.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableHeaderCellViewModel-Order'></a>
### Order `property`

##### Summary

Order of the cell.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableHeaderViewModel'></a>
## TableHeaderViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Entity.Table

##### Summary

Implementation of a table header.

<a name='M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableHeaderViewModel-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [TableHeaderViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableHeaderViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableHeaderViewModel') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableHeaderViewModel-Cells'></a>
### Cells `property`

##### Summary

List of all header cells implemented by [TableHeaderCellViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableHeaderCellViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableHeaderCellViewModel').

<a name='M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableHeaderViewModel-AddCell-System-String-'></a>
### AddCell(name) `method`

##### Summary

Add header cell by name.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableLinkElement'></a>
## TableLinkElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Table.Implementations

##### Summary

Implementation of [UILinkElement](#T-Definux-Emeraude-Admin-UI-UIElements-UILinkElement 'Definux.Emeraude.Admin.UI.UIElements.UILinkElement') for tables.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableLinkElement-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [TableLinkElement](#T-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableLinkElement 'Definux.Emeraude.Admin.UI.UIElements.Table.Implementations.TableLinkElement') class.

##### Parameters

This constructor has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableLongTextElement'></a>
## TableLongTextElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Table.Implementations

##### Summary

Implementation of [UIElement](#T-Definux-Emeraude-Admin-UI-UIElements-UIElement 'Definux.Emeraude.Admin.UI.UIElements.UIElement') that shows long texts for tables.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableLongTextElement-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [TableLongTextElement](#T-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableLongTextElement 'Definux.Emeraude.Admin.UI.UIElements.Table.Implementations.TableLongTextElement') class.

##### Parameters

This constructor has no parameters.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableLongTextElement-DefineHtmlBuilder'></a>
### DefineHtmlBuilder() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TablePaginationViewModel'></a>
## TablePaginationViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Entity.Table

##### Summary

Implementation of table pagination.

<a name='M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TablePaginationViewModel-#ctor-System-Int32,System-Int32-'></a>
### #ctor(currentPage,pagesCount) `constructor`

##### Summary

Initializes a new instance of the [TablePaginationViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TablePaginationViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TablePaginationViewModel') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| currentPage | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| pagesCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TablePaginationViewModel-AdditionalQueryParams'></a>
### AdditionalQueryParams `property`

##### Summary

Additional query string parameters.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TablePaginationViewModel-CurrentPage'></a>
### CurrentPage `property`

##### Summary

Current selected page.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TablePaginationViewModel-NextPage'></a>
### NextPage `property`

##### Summary

Next page based on the current page.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TablePaginationViewModel-NextPagesCount'></a>
### NextPagesCount `property`

##### Summary

Amount of all pages after the current.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TablePaginationViewModel-PreviousPage'></a>
### PreviousPage `property`

##### Summary

Previous page based on the current page.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TablePaginationViewModel-PreviousPagesCount'></a>
### PreviousPagesCount `property`

##### Summary

Amount of all pages before the current.

<a name='T-Definux-Emeraude-Admin-UI-Utilities-TableRowActionMethod'></a>
## TableRowActionMethod `type`

##### Namespace

Definux.Emeraude.Admin.UI.Utilities

##### Summary

Table row action method.

<a name='F-Definux-Emeraude-Admin-UI-Utilities-TableRowActionMethod-Get'></a>
### Get `constants`

##### Summary

GET method.

<a name='F-Definux-Emeraude-Admin-UI-Utilities-TableRowActionMethod-Post'></a>
### Post `constants`

##### Summary

POST method.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel'></a>
## TableRowActionViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Entity.Table

##### Summary

Implementation of a table row action.

<a name='M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel-#ctor-System-String,System-String,System-String,System-Collections-Generic-List{System-String},Definux-Emeraude-Admin-UI-Utilities-TableRowActionMethod-'></a>
### #ctor(title,icon,urlStringFormat,rawParameters,method) `constructor`

##### Summary

Initializes a new instance of the [TableRowActionViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowActionViewModel') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| title | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| icon | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| urlStringFormat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| rawParameters | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') |  |
| method | [Definux.Emeraude.Admin.UI.Utilities.TableRowActionMethod](#T-Definux-Emeraude-Admin-UI-Utilities-TableRowActionMethod 'Definux.Emeraude.Admin.UI.Utilities.TableRowActionMethod') |  |

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel-ConfirmationMessage'></a>
### ConfirmationMessage `property`

##### Summary

Message of the confirmation modal.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel-ConfirmationTitle'></a>
### ConfirmationTitle `property`

##### Summary

Title of the confirmation modal.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel-HasConfirmation'></a>
### HasConfirmation `property`

##### Summary

Flag that shows or not a confirmation modal if the method is [Post](#F-Definux-Emeraude-Admin-UI-Utilities-TableRowActionMethod-Post 'Definux.Emeraude.Admin.UI.Utilities.TableRowActionMethod.Post').

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel-Icon'></a>
### Icon `property`

##### Summary

Icon of the action button.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel-Method'></a>
### Method `property`

##### Summary

HTTP method of the action.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel-Parameters'></a>
### Parameters `property`

##### Summary

Parameters for the URL template with their actual values (processed [RawParameters](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel-RawParameters 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowActionViewModel.RawParameters')).

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel-RawParameters'></a>
### RawParameters `property`

##### Summary

Parameters for the URL template ([UrlStringFormat](#P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel-UrlStringFormat 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowActionViewModel.UrlStringFormat')) that can be hardcoded value (something-123) or property value ([SomeProperty]) where 'SomeProperty' is property of the target entity.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel-Title'></a>
### Title `property`

##### Summary

Title of the action.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel-Url'></a>
### Url `property`

##### Summary

URL of the action.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel-UrlStringFormat'></a>
### UrlStringFormat `property`

##### Summary

URL template with placeholders.

<a name='M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel-SetConfirmation-System-String,System-String-'></a>
### SetConfirmation(confirmationTitle,confirmationMessage) `method`

##### Summary

Method that set confirmation modal.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| confirmationTitle | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| confirmationMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowViewModel'></a>
## TableRowViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Entity.Table

##### Summary

Implementation of table row.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowViewModel-Actions'></a>
### Actions `property`

##### Summary

List of all actions for the row.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowViewModel-Cells'></a>
### Cells `property`

##### Summary

List of all cells implemented by [TableCellViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableCellViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableCellViewModel').

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowViewModel-Identifier'></a>
### Identifier `property`

##### Summary

Row identifier.

<a name='M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowViewModel-AddAction-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel,System-Collections-Generic-List{System-String}-'></a>
### AddAction(action,parameters) `method`

##### Summary

Add action to the row.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| action | [Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowActionViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowActionViewModel') |  |
| parameters | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') |  |

<a name='M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowViewModel-AddCell-System-Int32,System-Object,Definux-Emeraude-Admin-UI-UIElements-Table-ITableElement-'></a>
### AddCell(order,content,tableElement) `method`

##### Summary

Add cell to the row.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| order | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| content | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| tableElement | [Definux.Emeraude.Admin.UI.UIElements.Table.ITableElement](#T-Definux-Emeraude-Admin-UI-UIElements-Table-ITableElement 'Definux.Emeraude.Admin.UI.UIElements.Table.ITableElement') |  |

<a name='M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowViewModel-HasOrder-System-Int32-'></a>
### HasOrder(order) `method`

##### Summary

Checks whether exist order with value.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| order | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableTextElement'></a>
## TableTextElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Table.Implementations

##### Summary

Implementation of [UITextElement](#T-Definux-Emeraude-Admin-UI-UIElements-UITextElement 'Definux.Emeraude.Admin.UI.UIElements.UITextElement') for tables.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableTextElement-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [TableTextElement](#T-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableTextElement 'Definux.Emeraude.Admin.UI.UIElements.Table.Implementations.TableTextElement') class.

##### Parameters

This constructor has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableTimeElement'></a>
## TableTimeElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements.Table.Implementations

##### Summary

Table element for rendering time.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableTimeElement-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [TableTimeElement](#T-Definux-Emeraude-Admin-UI-UIElements-Table-Implementations-TableTimeElement 'Definux.Emeraude.Admin.UI.UIElements.Table.Implementations.TableTimeElement') class.

##### Parameters

This constructor has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewModel'></a>
## TableViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Entity.Table

##### Summary

Implementation of the table of the entity.

<a name='M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewModel-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [TableViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableViewModel') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewModel-Action'></a>
### Action `property`

##### Summary

Name of the action that visualize the table.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewModel-Area'></a>
### Area `property`

##### Summary

Name of the area that visualize the table.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewModel-Controller'></a>
### Controller `property`

##### Summary

Name of the controller that visualize the table.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewModel-HasActions'></a>
### HasActions `property`

##### Summary

Flag that indicates that the table has actions for their rows.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewModel-Header'></a>
### Header `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewModel-Pagination'></a>
### Pagination `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewModel-Rows'></a>
### Rows `property`

##### Summary

Collection of all rows implemented by [TableRowViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowViewModel').

<a name='M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewModel-AddRow-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowViewModel-'></a>
### AddRow(row) `method`

##### Summary

Add a row to the table.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| row | [Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowViewModel') |  |

<a name='M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewModel-SetPagination-System-Int32,System-Int32-'></a>
### SetPagination(currentPage,pagesCount) `method`

##### Summary

Set pagination of the table.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| currentPage | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| pagesCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewModel-SetPaginationRedirection-System-String,System-String,System-String-'></a>
### SetPaginationRedirection(area,controller,action) `method`

##### Summary

Set pagination redirection core parameters of the table.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| area | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| controller | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| action | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewViewModel'></a>
## TableViewViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Entity.Table

##### Summary

Entity ViewModel that contains the render properties for the table view.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewViewModel-SingleEntityName'></a>
### SingleEntityName `property`

##### Summary

Entity name as a single item.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewViewModel-Table'></a>
### Table `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewViewModel-Title'></a>
### Title `property`

##### Summary

Title of the view.

<a name='T-Definux-Emeraude-Admin-UI-Extensions-TempDataExtensions'></a>
## TempDataExtensions `type`

##### Namespace

Definux.Emeraude.Admin.UI.Extensions

##### Summary

Extensions for [ITempDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ITempDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary').

<a name='M-Definux-Emeraude-Admin-UI-Extensions-TempDataExtensions-TryGetErrorMessage-Microsoft-AspNetCore-Mvc-ViewFeatures-ITempDataDictionary,System-String@-'></a>
### TryGetErrorMessage(tempData,message) `method`

##### Summary

Gets error message or null.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tempData | [Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ITempDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary') |  |
| message | [System.String@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String@ 'System.String@') |  |

<a name='M-Definux-Emeraude-Admin-UI-Extensions-TempDataExtensions-TryGetSuccessMessage-Microsoft-AspNetCore-Mvc-ViewFeatures-ITempDataDictionary,System-String@-'></a>
### TryGetSuccessMessage(tempData,message) `method`

##### Summary

Gets success message or null.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tempData | [Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ITempDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary') |  |
| message | [System.String@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String@ 'System.String@') |  |

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Logging-TempFileLogViewModel'></a>
## TempFileLogViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Logging

##### Summary

View model that encapsulate temp file log.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-TempFileLogViewModel-Applied'></a>
### Applied `property`

##### Summary

Flag that indicates whether the file is applied or it is just a temp file and it is not already used.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-TempFileLogViewModel-FileExtension'></a>
### FileExtension `property`

##### Summary

Extension type of the file.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-TempFileLogViewModel-FileType'></a>
### FileType `property`

##### Summary

Type of the file.

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-TempFileLogViewModel-Name'></a>
### Name `property`

##### Summary

Name of the file (without extension).

<a name='P-Definux-Emeraude-Admin-UI-ViewModels-Logging-TempFileLogViewModel-Path'></a>
### Path `property`

##### Summary

Relative path of the file.

<a name='T-Definux-Emeraude-Admin-UI-ViewModels-Logging-TempFilesLogsViewModel'></a>
## TempFilesLogsViewModel `type`

##### Namespace

Definux.Emeraude.Admin.UI.ViewModels.Logging

##### Summary

View model that represent temp file logs view.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-UIDataSourceMapBasedElement`1'></a>
## UIDataSourceMapBasedElement\`1 `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements

##### Summary

Implementation of [UIElement](#T-Definux-Emeraude-Admin-UI-UIElements-UIElement 'Definux.Emeraude.Admin.UI.UIElements.UIElement') for value extracted from data source map.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TDataSourceMap | Data source map type. |

<a name='M-Definux-Emeraude-Admin-UI-UIElements-UIDataSourceMapBasedElement`1-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [UIDataSourceMapBasedElement\`1](#T-Definux-Emeraude-Admin-UI-UIElements-UIDataSourceMapBasedElement`1 'Definux.Emeraude.Admin.UI.UIElements.UIDataSourceMapBasedElement`1') class.

##### Parameters

This constructor has no parameters.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-UIDataSourceMapBasedElement`1-DefineHtmlBuilder'></a>
### DefineHtmlBuilder() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-UIDateTimeElement'></a>
## UIDateTimeElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements

##### Summary

Implementation of [UIElement](#T-Definux-Emeraude-Admin-UI-UIElements-UIElement 'Definux.Emeraude.Admin.UI.UIElements.UIElement') for date and time.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-UIDateTimeElement-#ctor-System-String,System-String-'></a>
### #ctor(dateTimeFormat,typeName) `constructor`

##### Summary

Initializes a new instance of the [UIDateTimeElement](#T-Definux-Emeraude-Admin-UI-UIElements-UIDateTimeElement 'Definux.Emeraude.Admin.UI.UIElements.UIDateTimeElement') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateTimeFormat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| typeName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Admin-UI-UIElements-UIDateTimeElement-DefineHtmlBuilder'></a>
### DefineHtmlBuilder() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-UIElement'></a>
## UIElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-UI-UIElements-UIElement-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [UIElement](#T-Definux-Emeraude-Admin-UI-UIElements-UIElement 'Definux.Emeraude.Admin.UI.UIElements.UIElement') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Admin-UI-UIElements-UIElement-DataSource'></a>
### DataSource `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Admin-UI-UIElements-UIElement-HtmlBuilder'></a>
### HtmlBuilder `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Admin-UI-UIElements-UIElement-ServiceProvider'></a>
### ServiceProvider `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-UI-UIElements-UIElement-DefineHtmlBuilder'></a>
### DefineHtmlBuilder() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-UIElement-LoadServiceProvider-System-IServiceProvider-'></a>
### LoadServiceProvider() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-UIElement-RenderHtmlString'></a>
### RenderHtmlString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-UIElement-ShowError-System-String-'></a>
### ShowError(message) `method`

##### Summary

Method that apply an error into HTML builder of the element.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Admin-UI-UIElements-UIFlagElement'></a>
## UIFlagElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements

##### Summary

Implementation of [UIElement](#T-Definux-Emeraude-Admin-UI-UIElements-UIElement 'Definux.Emeraude.Admin.UI.UIElements.UIElement') for flags.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-UIFlagElement-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [UIFlagElement](#T-Definux-Emeraude-Admin-UI-UIElements-UIFlagElement 'Definux.Emeraude.Admin.UI.UIElements.UIFlagElement') class.

##### Parameters

This constructor has no parameters.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-UIFlagElement-DefineHtmlBuilder'></a>
### DefineHtmlBuilder() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-UILinkElement'></a>
## UILinkElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements

##### Summary

Implementation of [UIElement](#T-Definux-Emeraude-Admin-UI-UIElements-UIElement 'Definux.Emeraude.Admin.UI.UIElements.UIElement') for links.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-UILinkElement-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [UILinkElement](#T-Definux-Emeraude-Admin-UI-UIElements-UILinkElement 'Definux.Emeraude.Admin.UI.UIElements.UILinkElement') class.

##### Parameters

This constructor has no parameters.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-UILinkElement-DefineHtmlBuilder'></a>
### DefineHtmlBuilder() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-UIElements-UITextElement'></a>
## UITextElement `type`

##### Namespace

Definux.Emeraude.Admin.UI.UIElements

##### Summary

Implementation of [UIElement](#T-Definux-Emeraude-Admin-UI-UIElements-UIElement 'Definux.Emeraude.Admin.UI.UIElements.UIElement') for texts.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-UITextElement-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [UITextElement](#T-Definux-Emeraude-Admin-UI-UIElements-UITextElement 'Definux.Emeraude.Admin.UI.UIElements.UITextElement') class.

##### Parameters

This constructor has no parameters.

<a name='M-Definux-Emeraude-Admin-UI-UIElements-UITextElement-DefineHtmlBuilder'></a>
### DefineHtmlBuilder() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-UI-Extensions-UrlHelperExtensions'></a>
## UrlHelperExtensions `type`

##### Namespace

Definux.Emeraude.Admin.UI.Extensions

##### Summary

Extensions for [IUrlHelper](#T-Microsoft-AspNetCore-Mvc-IUrlHelper 'Microsoft.AspNetCore.Mvc.IUrlHelper').

<a name='M-Definux-Emeraude-Admin-UI-Extensions-UrlHelperExtensions-GetDefaultUrl-Microsoft-AspNetCore-Mvc-IUrlHelper,Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary-'></a>
### GetDefaultUrl(urlHelper,viewData) `method`

##### Summary

Gets default URL based on current action, controller and area.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| urlHelper | [Microsoft.AspNetCore.Mvc.IUrlHelper](#T-Microsoft-AspNetCore-Mvc-IUrlHelper 'Microsoft.AspNetCore.Mvc.IUrlHelper') |  |
| viewData | [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary') |  |

<a name='T-Definux-Emeraude-Admin-UI-Adapters-UserInfoResult'></a>
## UserInfoResult `type`

##### Namespace

Definux.Emeraude.Admin.UI.Adapters

##### Summary

Simplified user info result.

<a name='P-Definux-Emeraude-Admin-UI-Adapters-UserInfoResult-Email'></a>
### Email `property`

##### Summary

Email of the user.

<a name='P-Definux-Emeraude-Admin-UI-Adapters-UserInfoResult-Id'></a>
### Id `property`

##### Summary

Id of the user.

<a name='P-Definux-Emeraude-Admin-UI-Adapters-UserInfoResult-Name'></a>
### Name `property`

##### Summary

Name of the user.

<a name='T-Definux-Emeraude-Admin-UI-Extensions-ViewContextExtensions'></a>
## ViewContextExtensions `type`

##### Namespace

Definux.Emeraude.Admin.UI.Extensions

##### Summary

Extensions for [ViewContext](#T-Microsoft-AspNetCore-Mvc-Rendering-ViewContext 'Microsoft.AspNetCore.Mvc.Rendering.ViewContext').

<a name='M-Definux-Emeraude-Admin-UI-Extensions-ViewContextExtensions-AppendIntoTheBody-Microsoft-AspNetCore-Mvc-Rendering-ViewContext,System-String-'></a>
### AppendIntoTheBody(viewContext,bodyLine) `method`

##### Summary

Append line into the content of the body.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewContext | [Microsoft.AspNetCore.Mvc.Rendering.ViewContext](#T-Microsoft-AspNetCore-Mvc-Rendering-ViewContext 'Microsoft.AspNetCore.Mvc.Rendering.ViewContext') |  |
| bodyLine | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Admin-UI-Extensions-ViewContextExtensions-AppendIntoTheHead-Microsoft-AspNetCore-Mvc-Rendering-ViewContext,System-String-'></a>
### AppendIntoTheHead(viewContext,headLine) `method`

##### Summary

Append line into the content of the head.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewContext | [Microsoft.AspNetCore.Mvc.Rendering.ViewContext](#T-Microsoft-AspNetCore-Mvc-Rendering-ViewContext 'Microsoft.AspNetCore.Mvc.Rendering.ViewContext') |  |
| headLine | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions'></a>
## ViewDataExtensions `type`

##### Namespace

Definux.Emeraude.Admin.UI.Extensions

##### Summary

Extensions for [ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary').

<a name='F-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-BreadcrumbsKey'></a>
### BreadcrumbsKey `constants`

##### Summary

Breadcrumbs ViewData key.

<a name='F-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-NavigationActionsKey'></a>
### NavigationActionsKey `constants`

##### Summary

Navigation actions ViewData key.

<a name='M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-AddBreadcrumb-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary,Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel-'></a>
### AddBreadcrumb(viewData,breadcrumb) `method`

##### Summary

Add a breadcrumb into the ViewData.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewData | [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary') |  |
| breadcrumb | [Definux.Emeraude.Admin.UI.ViewModels.Layout.BreadcrumbItemViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Layout.BreadcrumbItemViewModel') |  |

<a name='M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-AddNavigationAction-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary,Definux-Emeraude-Admin-UI-ViewModels-Layout-NavigationActionViewModel-'></a>
### AddNavigationAction(viewData,action) `method`

##### Summary

Add a navigation action into the ViewData.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewData | [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary') |  |
| action | [Definux.Emeraude.Admin.UI.ViewModels.Layout.NavigationActionViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Layout-NavigationActionViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Layout.NavigationActionViewModel') |  |

<a name='M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-GetAction-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary-'></a>
### GetAction(viewData) `method`

##### Summary

Get the name of the action for the current request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewData | [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary') |  |

<a name='M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-GetArea-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary-'></a>
### GetArea(viewData) `method`

##### Summary

Get the name of the area for the current request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewData | [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary') |  |

<a name='M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-GetBreadcrumbs-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary-'></a>
### GetBreadcrumbs(viewData) `method`

##### Summary

Get a breadcrumb from the ViewData.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewData | [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary') |  |

<a name='M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-GetController-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary-'></a>
### GetController(viewData) `method`

##### Summary

Get the name of the controller for the current request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewData | [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary') |  |

<a name='M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-GetDateValueOrNull-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary,System-String-'></a>
### GetDateValueOrNull(viewData,key) `method`

##### Summary

Get a date value from the ViewData.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewData | [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary') |  |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-GetEntityName-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary-'></a>
### GetEntityName(viewData) `method`

##### Summary

Get the name of the entity from key 'EntityName'.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewData | [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary') |  |

<a name='M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-GetNavigationActions-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary-'></a>
### GetNavigationActions(viewData) `method`

##### Summary

Get a navigation action from the ViewData.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewData | [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary') |  |

<a name='M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-GetOrderProperties-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary-'></a>
### GetOrderProperties(viewData) `method`

##### Summary

Get order properties for current entity page.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewData | [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary') |  |

<a name='M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-GetOrderProperty-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary-'></a>
### GetOrderProperty(viewData) `method`

##### Summary

Get order property from key 'OrderBy'.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewData | [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary') |  |

<a name='M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-GetOrderType-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary-'></a>
### GetOrderType(viewData) `method`

##### Summary

Get order type from key 'OrderType.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewData | [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary') |  |

<a name='M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-GetSearchQuery-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary-'></a>
### GetSearchQuery(viewData) `method`

##### Summary

Get the search query value from key 'SearchQuery'.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewData | [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary') |  |

<a name='M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-InitializeBreadcrumbs-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary-'></a>
### InitializeBreadcrumbs(viewData) `method`

##### Summary

Initialize collection of breadcrumbs items of type [BreadcrumbItemViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Layout-BreadcrumbItemViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Layout.BreadcrumbItemViewModel').

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewData | [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary') |  |

<a name='M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-InitializeNavigationActions-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary,System-Collections-Generic-IEnumerable{Definux-Emeraude-Admin-UI-ViewModels-Layout-NavigationActionViewModel}-'></a>
### InitializeNavigationActions(viewData,actions) `method`

##### Summary

Initialize collection of navigation actions of type [NavigationActionViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Layout-NavigationActionViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Layout.NavigationActionViewModel').

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewData | [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary') |  |
| actions | [System.Collections.Generic.IEnumerable{Definux.Emeraude.Admin.UI.ViewModels.Layout.NavigationActionViewModel}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Definux.Emeraude.Admin.UI.ViewModels.Layout.NavigationActionViewModel}') |  |

<a name='M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-SetOrderProperty-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary,System-String-'></a>
### SetOrderProperty(viewData,value) `method`

##### Summary

Save order property into ViewData.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewData | [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary') |  |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-SetOrderType-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary,System-String-'></a>
### SetOrderType(viewData,value) `method`

##### Summary

Save order type into ViewData.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewData | [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary') |  |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-SetSearchQuery-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary,System-String-'></a>
### SetSearchQuery(viewData,value) `method`

##### Summary

Save search query into ViewData.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewData | [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary') |  |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Admin-UI-Extensions-ViewDataExtensions-SetTitle-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary,System-String-'></a>
### SetTitle(viewData,title) `method`

##### Summary

Set title to the ViewData.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewData | [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary') |  |
| title | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
