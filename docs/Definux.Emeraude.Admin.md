<a name='assembly'></a>
# Definux.Emeraude.Admin

## Contents

- [AdminAssembly](#T-Definux-Emeraude-Admin-AdminAssembly 'Definux.Emeraude.Admin.AdminAssembly')
  - [GetAssembly()](#M-Definux-Emeraude-Admin-AdminAssembly-GetAssembly 'Definux.Emeraude.Admin.AdminAssembly.GetAssembly')
- [AdminAssemblyMappingProfile](#T-Definux-Emeraude-Admin-Mapping-Profiles-AdminAssemblyMappingProfile 'Definux.Emeraude.Admin.Mapping.Profiles.AdminAssemblyMappingProfile')
  - [#ctor()](#M-Definux-Emeraude-Admin-Mapping-Profiles-AdminAssemblyMappingProfile-#ctor 'Definux.Emeraude.Admin.Mapping.Profiles.AdminAssemblyMappingProfile.#ctor')
- [AdminAuthenticationController](#T-Definux-Emeraude-Admin-Controllers-Mvc-AdminAuthenticationController 'Definux.Emeraude.Admin.Controllers.Mvc.AdminAuthenticationController')
  - [#ctor(userClaimsService,hostingEnvironment,userManager)](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminAuthenticationController-#ctor-Definux-Emeraude-Application-Identity-IUserClaimsService,Microsoft-AspNetCore-Hosting-IWebHostEnvironment,Definux-Emeraude-Application-Identity-IUserManager- 'Definux.Emeraude.Admin.Controllers.Mvc.AdminAuthenticationController.#ctor(Definux.Emeraude.Application.Identity.IUserClaimsService,Microsoft.AspNetCore.Hosting.IWebHostEnvironment,Definux.Emeraude.Application.Identity.IUserManager)')
  - [Login()](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminAuthenticationController-Login 'Definux.Emeraude.Admin.Controllers.Mvc.AdminAuthenticationController.Login')
  - [Login(model)](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminAuthenticationController-Login-Definux-Emeraude-Admin-UI-ViewModels-Account-AdminLoginViewModel- 'Definux.Emeraude.Admin.Controllers.Mvc.AdminAuthenticationController.Login(Definux.Emeraude.Admin.UI.ViewModels.Account.AdminLoginViewModel)')
  - [LoginWith2Fa()](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminAuthenticationController-LoginWith2Fa 'Definux.Emeraude.Admin.Controllers.Mvc.AdminAuthenticationController.LoginWith2Fa')
  - [LoginWith2Fa(model)](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminAuthenticationController-LoginWith2Fa-Definux-Emeraude-Admin-UI-ViewModels-Account-AdminLoginWith2FaViewModel- 'Definux.Emeraude.Admin.Controllers.Mvc.AdminAuthenticationController.LoginWith2Fa(Definux.Emeraude.Admin.UI.ViewModels.Account.AdminLoginWith2FaViewModel)')
  - [Logout()](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminAuthenticationController-Logout 'Definux.Emeraude.Admin.Controllers.Mvc.AdminAuthenticationController.Logout')
- [AdminChildEntityController\`4](#T-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminChildEntityController`4')
  - [BreadcrumbParentTitlePlaceholder](#F-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-BreadcrumbParentTitlePlaceholder 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminChildEntityController`4.BreadcrumbParentTitlePlaceholder')
  - [ParentRouteKeyPropertyName](#F-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-ParentRouteKeyPropertyName 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminChildEntityController`4.ParentRouteKeyPropertyName')
  - [ParentController](#P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-ParentController 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminChildEntityController`4.ParentController')
  - [ParentExpression](#P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-ParentExpression 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminChildEntityController`4.ParentExpression')
  - [ParentIdentifier](#P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-ParentIdentifier 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminChildEntityController`4.ParentIdentifier')
  - [ParentProperty](#P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-ParentProperty 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminChildEntityController`4.ParentProperty')
  - [ParentRouteKey](#P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-ParentRouteKey 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminChildEntityController`4.ParentRouteKey')
  - [ApplyParentBreadcrumbTitle()](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-ApplyParentBreadcrumbTitle 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminChildEntityController`4.ApplyParentBreadcrumbTitle')
  - [BuildTableViewActions()](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-BuildTableViewActions 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminChildEntityController`4.BuildTableViewActions')
  - [BuildTableViewNavigationActions()](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-BuildTableViewNavigationActions 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminChildEntityController`4.BuildTableViewNavigationActions')
  - [Create()](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-Create 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminChildEntityController`4.Create')
  - [Create()](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-Create-`1- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminChildEntityController`4.Create(`1)')
  - [Details()](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-Details-System-Guid- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminChildEntityController`4.Details(System.Guid)')
  - [Edit()](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-Edit-System-Guid- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminChildEntityController`4.Edit(System.Guid)')
  - [Edit()](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-Edit-System-Guid,`1- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminChildEntityController`4.Edit(System.Guid,`1)')
  - [GetAll()](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-GetAll-System-Int32,System-String,System-String,System-String- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminChildEntityController`4.GetAll(System.Int32,System.String,System.String,System.String)')
  - [GetCreateCommand()](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-GetCreateCommand-`1- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminChildEntityController`4.GetCreateCommand(`1)')
  - [GetDeleteCommand()](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-GetDeleteCommand-System-Guid- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminChildEntityController`4.GetDeleteCommand(System.Guid)')
  - [GetDetailsQuery()](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-GetDetailsQuery-System-Guid- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminChildEntityController`4.GetDetailsQuery(System.Guid)')
  - [GetEditCommand()](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-GetEditCommand-System-Guid,`1- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminChildEntityController`4.GetEditCommand(System.Guid,`1)')
  - [GetGetAllQuery()](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-GetGetAllQuery-System-Int32,System-String,System-String,System-String- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminChildEntityController`4.GetGetAllQuery(System.Int32,System.String,System.String,System.String)')
  - [RedirectToAll()](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-RedirectToAll 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminChildEntityController`4.RedirectToAll')
  - [RedirectToDetails()](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-RedirectToDetails-System-Guid- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminChildEntityController`4.RedirectToDetails(System.Guid)')
  - [UpdateControllerRoute()](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-UpdateControllerRoute 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminChildEntityController`4.UpdateControllerRoute')
  - [ValidateExistenceAsync()](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-ValidateExistenceAsync 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminChildEntityController`4.ValidateExistenceAsync')
- [AdminController](#T-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminController')
  - [#ctor()](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-#ctor 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminController.#ctor')
  - [AdminAreaName](#F-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-AdminAreaName 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminController.AdminAreaName')
  - [ActionName](#P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-ActionName 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminController.ActionName')
  - [AreaName](#P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-AreaName 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminController.AreaName')
  - [ControllerName](#P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-ControllerName 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminController.ControllerName')
  - [ControllerRoute](#P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-ControllerRoute 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminController.ControllerRoute')
  - [CurrentUserProvider](#P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-CurrentUserProvider 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminController.CurrentUserProvider')
  - [DisableActivityLog](#P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-DisableActivityLog 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminController.DisableActivityLog')
  - [HideActivityLogParameters](#P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-HideActivityLogParameters 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminController.HideActivityLogParameters')
  - [Logger](#P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-Logger 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminController.Logger')
  - [Mediator](#P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-Mediator 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminController.Mediator')
  - [UrlEncoder](#P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-UrlEncoder 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminController.UrlEncoder')
  - [BuildControllerRoute(route)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-BuildControllerRoute-System-String- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminController.BuildControllerRoute(System.String)')
  - [InitializeNavigationActions(actions)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-InitializeNavigationActions-System-Collections-Generic-IEnumerable{Definux-Emeraude-Admin-UI-ViewModels-Layout-NavigationActionViewModel}- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminController.InitializeNavigationActions(System.Collections.Generic.IEnumerable{Definux.Emeraude.Admin.UI.ViewModels.Layout.NavigationActionViewModel})')
  - [OnActionExecuting()](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-OnActionExecuting-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminController.OnActionExecuting(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext)')
  - [ShowComputationNotification(success,successMessage,errorMessage)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-ShowComputationNotification-System-Boolean,System-String,System-String- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminController.ShowComputationNotification(System.Boolean,System.String,System.String)')
  - [ShowErrorNotification(message)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-ShowErrorNotification-System-String- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminController.ShowErrorNotification(System.String)')
  - [ShowSuccessNotification(message)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-ShowSuccessNotification-System-String- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminController.ShowSuccessNotification(System.String)')
- [AdminDashboardController](#T-Definux-Emeraude-Admin-Controllers-Mvc-AdminDashboardController 'Definux.Emeraude.Admin.Controllers.Mvc.AdminDashboardController')
  - [#ctor(optionsAccessor)](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminDashboardController-#ctor-Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions}- 'Definux.Emeraude.Admin.Controllers.Mvc.AdminDashboardController.#ctor(Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions})')
  - [Index()](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminDashboardController-Index 'Definux.Emeraude.Admin.Controllers.Mvc.AdminDashboardController.Index')
- [AdminEntityController\`2](#T-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2')
  - [#ctor()](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-#ctor 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.#ctor')
  - [BreadcrumbEntityNamePluralPlaceholder](#F-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-BreadcrumbEntityNamePluralPlaceholder 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.BreadcrumbEntityNamePluralPlaceholder')
  - [BreadcrumbPageTitlePlaceholder](#F-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-BreadcrumbPageTitlePlaceholder 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.BreadcrumbPageTitlePlaceholder')
  - [DeleteRedirectUrlFunction](#P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-DeleteRedirectUrlFunction 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.DeleteRedirectUrlFunction')
  - [EntityMapper](#P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-EntityMapper 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.EntityMapper')
  - [EntityName](#P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-EntityName 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.EntityName')
  - [HasCreate](#P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-HasCreate 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.HasCreate')
  - [HasDelete](#P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-HasDelete 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.HasDelete')
  - [HasDetails](#P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-HasDetails 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.HasDetails')
  - [HasEdit](#P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-HasEdit 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.HasEdit')
  - [BuildTableViewActions()](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-BuildTableViewActions 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.BuildTableViewActions')
  - [BuildTableViewNavigationActions()](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-BuildTableViewNavigationActions 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.BuildTableViewNavigationActions')
  - [Create()](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-Create 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.Create')
  - [Create(model)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-Create-`1- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.Create(`1)')
  - [CreateEditView(model)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-CreateEditView-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-IEntityFormViewModel- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.CreateEditView(Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.IEntityFormViewModel)')
  - [CreateEntityAsync(model)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-CreateEntityAsync-`1- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.CreateEntityAsync(`1)')
  - [Delete(id)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-Delete-System-Guid- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.Delete(System.Guid)')
  - [DeleteEntityAsync(entityId)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-DeleteEntityAsync-System-Guid- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.DeleteEntityAsync(System.Guid)')
  - [Details(id)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-Details-System-Guid- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.Details(System.Guid)')
  - [DetailsView(model)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-DetailsView-Definux-Emeraude-Admin-UI-ViewModels-Entity-DetailsCard-EntityDetailsViewModel- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.DetailsView(Definux.Emeraude.Admin.UI.ViewModels.Entity.DetailsCard.EntityDetailsViewModel)')
  - [Edit(id)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-Edit-System-Guid- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.Edit(System.Guid)')
  - [Edit(id,model)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-Edit-System-Guid,`1- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.Edit(System.Guid,`1)')
  - [GalleryView(model)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-GalleryView-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-SelectableGalleryViewModel- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.GalleryView(Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.SelectableGalleryViewModel)')
  - [GetAll(page,searchQuery,orderBy,orderType)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-GetAll-System-Int32,System-String,System-String,System-String- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.GetAll(System.Int32,System.String,System.String,System.String)')
  - [GetAllEntitiesPaginatedAsync(page,query,orderBy,orderType)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-GetAllEntitiesPaginatedAsync-System-Int32,System-String,System-String,System-String- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.GetAllEntitiesPaginatedAsync(System.Int32,System.String,System.String,System.String)')
  - [GetAllView(model)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-GetAllView-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewViewModel- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.GetAllView(Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableViewViewModel)')
  - [GetCreateCommand(model)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-GetCreateCommand-`1- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.GetCreateCommand(`1)')
  - [GetDeleteCommand(entityId)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-GetDeleteCommand-System-Guid- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.GetDeleteCommand(System.Guid)')
  - [GetDetailsQuery(entityId)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-GetDetailsQuery-System-Guid- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.GetDetailsQuery(System.Guid)')
  - [GetEditCommand(entityId,model)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-GetEditCommand-System-Guid,`1- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.GetEditCommand(System.Guid,`1)')
  - [GetEntityAsync(entityId)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-GetEntityAsync-System-Guid- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.GetEntityAsync(System.Guid)')
  - [GetGalleryActionAsync\`\`1(entityId,picturesUrls,actionName)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-GetGalleryActionAsync``1-System-Guid,System-Collections-Generic-List{System-String},System-String- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.GetGalleryActionAsync``1(System.Guid,System.Collections.Generic.List{System.String},System.String)')
  - [GetGetAllQuery(page,searchQuery,orderBy,orderType)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-GetGetAllQuery-System-Int32,System-String,System-String,System-String- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.GetGetAllQuery(System.Int32,System.String,System.String,System.String)')
  - [GetHttpContextPageNumber()](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-GetHttpContextPageNumber 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.GetHttpContextPageNumber')
  - [GetHttpContextSearchQuery()](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-GetHttpContextSearchQuery 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.GetHttpContextSearchQuery')
  - [GetOrderProperties()](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-GetOrderProperties 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.GetOrderProperties')
  - [ModifyEntityAsync(entityId,model)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-ModifyEntityAsync-System-Guid,`1- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.ModifyEntityAsync(System.Guid,`1)')
  - [OnEntityCreatedAsync(entityId)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-OnEntityCreatedAsync-System-Guid- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.OnEntityCreatedAsync(System.Guid)')
  - [OnEntityDeletedAsync(entityId)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-OnEntityDeletedAsync-System-Guid- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.OnEntityDeletedAsync(System.Guid)')
  - [OnEntityEditedAsync(entityId)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-OnEntityEditedAsync-System-Guid- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.OnEntityEditedAsync(System.Guid)')
  - [PostGalleryActionAsync\`\`1(entityId,model)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-PostGalleryActionAsync``1-System-Guid,Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-SelectableGalleryViewModel- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.PostGalleryActionAsync``1(System.Guid,Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.SelectableGalleryViewModel)')
  - [RedirectToAll()](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-RedirectToAll 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.RedirectToAll')
  - [RedirectToDetails(entityId)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-RedirectToDetails-System-Guid- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.RedirectToDetails(System.Guid)')
  - [SetPartialAboveTheTable(partialName)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-SetPartialAboveTheTable-System-String- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.SetPartialAboveTheTable(System.String)')
  - [SetPartialBelowTheTable(partialName)](#M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-SetPartialBelowTheTable-System-String- 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2.SetPartialBelowTheTable(System.String)')
- [AdminEntityMapper](#T-Definux-Emeraude-Admin-Mapping-AdminEntityMapper 'Definux.Emeraude.Admin.Mapping.AdminEntityMapper')
  - [MapToDetailsViewModel\`\`1()](#M-Definux-Emeraude-Admin-Mapping-AdminEntityMapper-MapToDetailsViewModel``1-``0- 'Definux.Emeraude.Admin.Mapping.AdminEntityMapper.MapToDetailsViewModel``1(``0)')
  - [MapToFormInputViewModels()](#M-Definux-Emeraude-Admin-Mapping-AdminEntityMapper-MapToFormInputViewModels-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-IEntityFormViewModel- 'Definux.Emeraude.Admin.Mapping.AdminEntityMapper.MapToFormInputViewModels(Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.IEntityFormViewModel)')
  - [MapToTableViewModel\`\`1()](#M-Definux-Emeraude-Admin-Mapping-AdminEntityMapper-MapToTableViewModel``1-Definux-Utilities-Objects-PaginatedList{``0},Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel[]- 'Definux.Emeraude.Admin.Mapping.AdminEntityMapper.MapToTableViewModel``1(Definux.Utilities.Objects.PaginatedList{``0},Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowActionViewModel[])')
- [AdminLoggingController](#T-Definux-Emeraude-Admin-Controllers-Mvc-AdminLoggingController 'Definux.Emeraude.Admin.Controllers.Mvc.AdminLoggingController')
  - [#ctor(userManager)](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminLoggingController-#ctor-Definux-Emeraude-Application-Identity-IUserManager- 'Definux.Emeraude.Admin.Controllers.Mvc.AdminLoggingController.#ctor(Definux.Emeraude.Application.Identity.IUserManager)')
  - [DeleteLog(logType,logId,returnUrl)](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminLoggingController-DeleteLog-System-String,System-Int32,System-String- 'Definux.Emeraude.Admin.Controllers.Mvc.AdminLoggingController.DeleteLog(System.String,System.Int32,System.String)')
  - [EmailBody(emailLogId)](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminLoggingController-EmailBody-System-Int32- 'Definux.Emeraude.Admin.Controllers.Mvc.AdminLoggingController.EmailBody(System.Int32)')
  - [FetchLogs(logType,page,searchQuery,fromDate,toDate,user)](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminLoggingController-FetchLogs-System-String,System-Int32,System-String,System-Nullable{System-DateTime},System-Nullable{System-DateTime},System-String- 'Definux.Emeraude.Admin.Controllers.Mvc.AdminLoggingController.FetchLogs(System.String,System.Int32,System.String,System.Nullable{System.DateTime},System.Nullable{System.DateTime},System.String)')
- [AdminManageController](#T-Definux-Emeraude-Admin-Controllers-Mvc-AdminManageController 'Definux.Emeraude.Admin.Controllers.Mvc.AdminManageController')
  - [#ctor(userManager,urlEncoder,twoFactorAuthenticationService,optionsAccessor)](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminManageController-#ctor-Microsoft-AspNetCore-Identity-UserManager{Definux-Emeraude-Identity-Entities-User},System-Text-Encodings-Web-UrlEncoder,Definux-Emeraude-Application-Identity-ITwoFactorAuthenticationService,Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions}- 'Definux.Emeraude.Admin.Controllers.Mvc.AdminManageController.#ctor(Microsoft.AspNetCore.Identity.UserManager{Definux.Emeraude.Identity.Entities.User},System.Text.Encodings.Web.UrlEncoder,Definux.Emeraude.Application.Identity.ITwoFactorAuthenticationService,Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions})')
  - [ChangeEmail(email,token)](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminManageController-ChangeEmail-System-String,System-String- 'Definux.Emeraude.Admin.Controllers.Mvc.AdminManageController.ChangeEmail(System.String,System.String)')
  - [ChangeEmailRequest()](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminManageController-ChangeEmailRequest 'Definux.Emeraude.Admin.Controllers.Mvc.AdminManageController.ChangeEmailRequest')
  - [ChangeEmailRequest(model)](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminManageController-ChangeEmailRequest-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminChangeEmailViewModel- 'Definux.Emeraude.Admin.Controllers.Mvc.AdminManageController.ChangeEmailRequest(Definux.Emeraude.Admin.UI.ViewModels.Manage.AdminChangeEmailViewModel)')
  - [ChangePassword()](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminManageController-ChangePassword 'Definux.Emeraude.Admin.Controllers.Mvc.AdminManageController.ChangePassword')
  - [ChangePassword(model)](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminManageController-ChangePassword-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminChangePasswordViewModel- 'Definux.Emeraude.Admin.Controllers.Mvc.AdminManageController.ChangePassword(Definux.Emeraude.Admin.UI.ViewModels.Manage.AdminChangePasswordViewModel)')
  - [ResetAuthenticator()](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminManageController-ResetAuthenticator 'Definux.Emeraude.Admin.Controllers.Mvc.AdminManageController.ResetAuthenticator')
  - [TwoFactorAuthentication()](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminManageController-TwoFactorAuthentication 'Definux.Emeraude.Admin.Controllers.Mvc.AdminManageController.TwoFactorAuthentication')
  - [TwoFactorAuthentication(model)](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminManageController-TwoFactorAuthentication-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminTwoFactorAuthenticationViewModel- 'Definux.Emeraude.Admin.Controllers.Mvc.AdminManageController.TwoFactorAuthentication(Definux.Emeraude.Admin.UI.ViewModels.Manage.AdminTwoFactorAuthenticationViewModel)')
- [AdminModelsProfile](#T-Definux-Emeraude-Admin-Mapping-Profiles-AdminModelsProfile 'Definux.Emeraude.Admin.Mapping.Profiles.AdminModelsProfile')
  - [#ctor()](#M-Definux-Emeraude-Admin-Mapping-Profiles-AdminModelsProfile-#ctor 'Definux.Emeraude.Admin.Mapping.Profiles.AdminModelsProfile.#ctor')
- [AdminRootsController](#T-Definux-Emeraude-Admin-Controllers-Mvc-AdminRootsController 'Definux.Emeraude.Admin.Controllers.Mvc.AdminRootsController')
  - [#ctor(systemFilesService,rootsService)](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminRootsController-#ctor-Definux-Emeraude-Application-Files-ISystemFilesService,Definux-Emeraude-Application-Files-IRootsService- 'Definux.Emeraude.Admin.Controllers.Mvc.AdminRootsController.#ctor(Definux.Emeraude.Application.Files.ISystemFilesService,Definux.Emeraude.Application.Files.IRootsService)')
  - [CreateFolder(root,folders)](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminRootsController-CreateFolder-System-String,System-String- 'Definux.Emeraude.Admin.Controllers.Mvc.AdminRootsController.CreateFolder(System.String,System.String)')
  - [CreateFolder(root,model)](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminRootsController-CreateFolder-System-String,Definux-Emeraude-Admin-UI-ViewModels-Roots-RootCreateFolderViewModel- 'Definux.Emeraude.Admin.Controllers.Mvc.AdminRootsController.CreateFolder(System.String,Definux.Emeraude.Admin.UI.ViewModels.Roots.RootCreateFolderViewModel)')
  - [Root(root,folders)](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminRootsController-Root-System-String,System-String- 'Definux.Emeraude.Admin.Controllers.Mvc.AdminRootsController.Root(System.String,System.String)')
  - [RootFile(root,folders)](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminRootsController-RootFile-System-String,System-String- 'Definux.Emeraude.Admin.Controllers.Mvc.AdminRootsController.RootFile(System.String,System.String)')
  - [UploadFile(root,formFile,model)](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminRootsController-UploadFile-System-String,Microsoft-AspNetCore-Http-IFormFile,Definux-Emeraude-Admin-UI-ViewModels-Roots-RootUploadFilesViewModel- 'Definux.Emeraude.Admin.Controllers.Mvc.AdminRootsController.UploadFile(System.String,Microsoft.AspNetCore.Http.IFormFile,Definux.Emeraude.Admin.UI.ViewModels.Roots.RootUploadFilesViewModel)')
  - [UploadFiles(root,folders)](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminRootsController-UploadFiles-System-String,System-String- 'Definux.Emeraude.Admin.Controllers.Mvc.AdminRootsController.UploadFiles(System.String,System.String)')
- [AdminUploadApiController](#T-Definux-Emeraude-Admin-Controllers-Api-AdminUploadApiController 'Definux.Emeraude.Admin.Controllers.Api.AdminUploadApiController')
  - [#ctor(emeraudeOptionsAccessor)](#M-Definux-Emeraude-Admin-Controllers-Api-AdminUploadApiController-#ctor-Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions}- 'Definux.Emeraude.Admin.Controllers.Api.AdminUploadApiController.#ctor(Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions})')
  - [File(formFile)](#M-Definux-Emeraude-Admin-Controllers-Api-AdminUploadApiController-File-Microsoft-AspNetCore-Http-IFormFile- 'Definux.Emeraude.Admin.Controllers.Api.AdminUploadApiController.File(Microsoft.AspNetCore.Http.IFormFile)')
  - [Image(formFile)](#M-Definux-Emeraude-Admin-Controllers-Api-AdminUploadApiController-Image-Microsoft-AspNetCore-Http-IFormFile- 'Definux.Emeraude.Admin.Controllers.Api.AdminUploadApiController.Image(Microsoft.AspNetCore.Http.IFormFile)')
  - [Video(formFile)](#M-Definux-Emeraude-Admin-Controllers-Api-AdminUploadApiController-Video-Microsoft-AspNetCore-Http-IFormFile- 'Definux.Emeraude.Admin.Controllers.Api.AdminUploadApiController.Video(Microsoft.AspNetCore.Http.IFormFile)')
- [AdminUsersApiController](#T-Definux-Emeraude-Admin-Controllers-Api-AdminUsersApiController 'Definux.Emeraude.Admin.Controllers.Api.AdminUsersApiController')
  - [Fetch(page,searchQuery)](#M-Definux-Emeraude-Admin-Controllers-Api-AdminUsersApiController-Fetch-System-Int32,System-String- 'Definux.Emeraude.Admin.Controllers.Api.AdminUsersApiController.Fetch(System.Int32,System.String)')
- [AdminUsersController](#T-Definux-Emeraude-Admin-Controllers-Mvc-AdminUsersController 'Definux.Emeraude.Admin.Controllers.Mvc.AdminUsersController')
  - [#ctor(userManager,roleManager,userTokensService,userClaimsService)](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminUsersController-#ctor-Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-Identity-IRoleManager,Definux-Emeraude-Application-Identity-IUserTokensService,Definux-Emeraude-Application-Identity-IUserClaimsService- 'Definux.Emeraude.Admin.Controllers.Mvc.AdminUsersController.#ctor(Definux.Emeraude.Application.Identity.IUserManager,Definux.Emeraude.Application.Identity.IRoleManager,Definux.Emeraude.Application.Identity.IUserTokensService,Definux.Emeraude.Application.Identity.IUserClaimsService)')
  - [BuildTableViewActions()](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminUsersController-BuildTableViewActions 'Definux.Emeraude.Admin.Controllers.Mvc.AdminUsersController.BuildTableViewActions')
  - [ImitateUser(userId)](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminUsersController-ImitateUser-System-Guid- 'Definux.Emeraude.Admin.Controllers.Mvc.AdminUsersController.ImitateUser(System.Guid)')
  - [ResetRefreshToken(userId)](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminUsersController-ResetRefreshToken-System-Guid- 'Definux.Emeraude.Admin.Controllers.Mvc.AdminUsersController.ResetRefreshToken(System.Guid)')
  - [Roles(userId)](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminUsersController-Roles-System-Guid- 'Definux.Emeraude.Admin.Controllers.Mvc.AdminUsersController.Roles(System.Guid)')
  - [Roles(userId,model)](#M-Definux-Emeraude-Admin-Controllers-Mvc-AdminUsersController-Roles-System-Guid,Definux-Emeraude-Admin-UI-ViewModels-Users-RolesViewModel- 'Definux.Emeraude.Admin.Controllers.Mvc.AdminUsersController.Roles(System.Guid,Definux.Emeraude.Admin.UI.ViewModels.Users.RolesViewModel)')
- [ApplicationBuilderExtensions](#T-Definux-Emeraude-Admin-Extensions-ApplicationBuilderExtensions 'Definux.Emeraude.Admin.Extensions.ApplicationBuilderExtensions')
  - [UseEmeraudeAdminSwagger(app)](#M-Definux-Emeraude-Admin-Extensions-ApplicationBuilderExtensions-UseEmeraudeAdminSwagger-Microsoft-AspNetCore-Builder-IApplicationBuilder- 'Definux.Emeraude.Admin.Extensions.ApplicationBuilderExtensions.UseEmeraudeAdminSwagger(Microsoft.AspNetCore.Builder.IApplicationBuilder)')
- [ApplicationPartManagerExtensions](#T-Definux-Emeraude-Admin-Extensions-ApplicationPartManagerExtensions 'Definux.Emeraude.Admin.Extensions.ApplicationPartManagerExtensions')
  - [AddAdminUIApplicationParts(applicationPartManager)](#M-Definux-Emeraude-Admin-Extensions-ApplicationPartManagerExtensions-AddAdminUIApplicationParts-Microsoft-AspNetCore-Mvc-ApplicationParts-ApplicationPartManager- 'Definux.Emeraude.Admin.Extensions.ApplicationPartManagerExtensions.AddAdminUIApplicationParts(Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager)')
- [ApplyImageCommandHandler\`1](#T-Definux-Emeraude-Admin-Requests-ApplyImage-ApplyImageCommandHandler`1 'Definux.Emeraude.Admin.Requests.ApplyImage.ApplyImageCommandHandler`1')
  - [#ctor(context,logger)](#M-Definux-Emeraude-Admin-Requests-ApplyImage-ApplyImageCommandHandler`1-#ctor-Definux-Emeraude-Application-Persistence-IEmContext,Definux-Emeraude-Application-Logger-IEmLogger- 'Definux.Emeraude.Admin.Requests.ApplyImage.ApplyImageCommandHandler`1.#ctor(Definux.Emeraude.Application.Persistence.IEmContext,Definux.Emeraude.Application.Logger.IEmLogger)')
  - [Handle()](#M-Definux-Emeraude-Admin-Requests-ApplyImage-ApplyImageCommandHandler`1-Handle-Definux-Emeraude-Admin-Requests-ApplyImage-ApplyImageCommand{`0},System-Threading-CancellationToken- 'Definux.Emeraude.Admin.Requests.ApplyImage.ApplyImageCommandHandler`1.Handle(Definux.Emeraude.Admin.Requests.ApplyImage.ApplyImageCommand{`0},System.Threading.CancellationToken)')
- [ApplyImageCommand\`1](#T-Definux-Emeraude-Admin-Requests-ApplyImage-ApplyImageCommand`1 'Definux.Emeraude.Admin.Requests.ApplyImage.ApplyImageCommand`1')
  - [#ctor(entityId,imageUrl)](#M-Definux-Emeraude-Admin-Requests-ApplyImage-ApplyImageCommand`1-#ctor-System-Guid,System-String- 'Definux.Emeraude.Admin.Requests.ApplyImage.ApplyImageCommand`1.#ctor(System.Guid,System.String)')
  - [EntityId](#P-Definux-Emeraude-Admin-Requests-ApplyImage-ApplyImageCommand`1-EntityId 'Definux.Emeraude.Admin.Requests.ApplyImage.ApplyImageCommand`1.EntityId')
  - [ImageUrl](#P-Definux-Emeraude-Admin-Requests-ApplyImage-ApplyImageCommand`1-ImageUrl 'Definux.Emeraude.Admin.Requests.ApplyImage.ApplyImageCommand`1.ImageUrl')
- [AssignRolesToUserCommand](#T-Definux-Emeraude-Admin-Requests-AssignRolesToUser-AssignRolesToUserCommand 'Definux.Emeraude.Admin.Requests.AssignRolesToUser.AssignRolesToUserCommand')
  - [#ctor(userId,rolesIds)](#M-Definux-Emeraude-Admin-Requests-AssignRolesToUser-AssignRolesToUserCommand-#ctor-System-Guid,System-Collections-Generic-List{System-Guid}- 'Definux.Emeraude.Admin.Requests.AssignRolesToUser.AssignRolesToUserCommand.#ctor(System.Guid,System.Collections.Generic.List{System.Guid})')
  - [RolesIds](#P-Definux-Emeraude-Admin-Requests-AssignRolesToUser-AssignRolesToUserCommand-RolesIds 'Definux.Emeraude.Admin.Requests.AssignRolesToUser.AssignRolesToUserCommand.RolesIds')
  - [UserId](#P-Definux-Emeraude-Admin-Requests-AssignRolesToUser-AssignRolesToUserCommand-UserId 'Definux.Emeraude.Admin.Requests.AssignRolesToUser.AssignRolesToUserCommand.UserId')
- [AssignRolesToUserCommandHandler](#T-Definux-Emeraude-Admin-Requests-AssignRolesToUser-AssignRolesToUserCommand-AssignRolesToUserCommandHandler 'Definux.Emeraude.Admin.Requests.AssignRolesToUser.AssignRolesToUserCommand.AssignRolesToUserCommandHandler')
  - [#ctor(roleManager,userManager)](#M-Definux-Emeraude-Admin-Requests-AssignRolesToUser-AssignRolesToUserCommand-AssignRolesToUserCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IRoleManager,Definux-Emeraude-Application-Identity-IUserManager- 'Definux.Emeraude.Admin.Requests.AssignRolesToUser.AssignRolesToUserCommand.AssignRolesToUserCommandHandler.#ctor(Definux.Emeraude.Application.Identity.IRoleManager,Definux.Emeraude.Application.Identity.IUserManager)')
  - [Handle()](#M-Definux-Emeraude-Admin-Requests-AssignRolesToUser-AssignRolesToUserCommand-AssignRolesToUserCommandHandler-Handle-Definux-Emeraude-Admin-Requests-AssignRolesToUser-AssignRolesToUserCommand,System-Threading-CancellationToken- 'Definux.Emeraude.Admin.Requests.AssignRolesToUser.AssignRolesToUserCommand.AssignRolesToUserCommandHandler.Handle(Definux.Emeraude.Admin.Requests.AssignRolesToUser.AssignRolesToUserCommand,System.Threading.CancellationToken)')
- [AuthorizationOptionsExtensions](#T-Definux-Emeraude-Admin-Extensions-AuthorizationOptionsExtensions 'Definux.Emeraude.Admin.Extensions.AuthorizationOptionsExtensions')
  - [ApplyEmeraudeAdminAuthorizationPolicies(options)](#M-Definux-Emeraude-Admin-Extensions-AuthorizationOptionsExtensions-ApplyEmeraudeAdminAuthorizationPolicies-Microsoft-AspNetCore-Authorization-AuthorizationOptions- 'Definux.Emeraude.Admin.Extensions.AuthorizationOptionsExtensions.ApplyEmeraudeAdminAuthorizationPolicies(Microsoft.AspNetCore.Authorization.AuthorizationOptions)')
- [BreadcrumbAttribute](#T-Definux-Emeraude-Admin-Attributes-BreadcrumbAttribute 'Definux.Emeraude.Admin.Attributes.BreadcrumbAttribute')
  - [#ctor(title,active,order,action,controller,parameterName,parameterValue)](#M-Definux-Emeraude-Admin-Attributes-BreadcrumbAttribute-#ctor-System-String,System-Boolean,System-Int32,System-String,System-String,System-String,System-String- 'Definux.Emeraude.Admin.Attributes.BreadcrumbAttribute.#ctor(System.String,System.Boolean,System.Int32,System.String,System.String,System.String,System.String)')
  - [ParentRouteKey](#P-Definux-Emeraude-Admin-Attributes-BreadcrumbAttribute-ParentRouteKey 'Definux.Emeraude.Admin.Attributes.BreadcrumbAttribute.ParentRouteKey')
  - [UseParentController](#P-Definux-Emeraude-Admin-Attributes-BreadcrumbAttribute-UseParentController 'Definux.Emeraude.Admin.Attributes.BreadcrumbAttribute.UseParentController')
  - [OnActionExecuting()](#M-Definux-Emeraude-Admin-Attributes-BreadcrumbAttribute-OnActionExecuting-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext- 'Definux.Emeraude.Admin.Attributes.BreadcrumbAttribute.OnActionExecuting(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext)')
- [CreateCommandHandler\`2](#T-Definux-Emeraude-Admin-Requests-Create-CreateCommandHandler`2 'Definux.Emeraude.Admin.Requests.Create.CreateCommandHandler`2')
  - [#ctor(context,mapper,logger)](#M-Definux-Emeraude-Admin-Requests-Create-CreateCommandHandler`2-#ctor-Definux-Emeraude-Application-Persistence-IEmContext,AutoMapper-IMapper,Definux-Emeraude-Application-Logger-IEmLogger- 'Definux.Emeraude.Admin.Requests.Create.CreateCommandHandler`2.#ctor(Definux.Emeraude.Application.Persistence.IEmContext,AutoMapper.IMapper,Definux.Emeraude.Application.Logger.IEmLogger)')
  - [Handle()](#M-Definux-Emeraude-Admin-Requests-Create-CreateCommandHandler`2-Handle-Definux-Emeraude-Admin-Requests-Create-CreateCommand{`0,`1},System-Threading-CancellationToken- 'Definux.Emeraude.Admin.Requests.Create.CreateCommandHandler`2.Handle(Definux.Emeraude.Admin.Requests.Create.CreateCommand{`0,`1},System.Threading.CancellationToken)')
- [CreateCommand\`2](#T-Definux-Emeraude-Admin-Requests-Create-CreateCommand`2 'Definux.Emeraude.Admin.Requests.Create.CreateCommand`2')
  - [#ctor(model)](#M-Definux-Emeraude-Admin-Requests-Create-CreateCommand`2-#ctor-`1- 'Definux.Emeraude.Admin.Requests.Create.CreateCommand`2.#ctor(`1)')
  - [#ctor(model,parentProperty,parentId)](#M-Definux-Emeraude-Admin-Requests-Create-CreateCommand`2-#ctor-`1,System-String,System-Nullable{System-Guid}- 'Definux.Emeraude.Admin.Requests.Create.CreateCommand`2.#ctor(`1,System.String,System.Nullable{System.Guid})')
  - [Model](#P-Definux-Emeraude-Admin-Requests-Create-CreateCommand`2-Model 'Definux.Emeraude.Admin.Requests.Create.CreateCommand`2.Model')
- [DefaultValues](#T-Definux-Emeraude-Admin-Utilities-DefaultValues 'Definux.Emeraude.Admin.Utilities.DefaultValues')
  - [OrderTypes](#F-Definux-Emeraude-Admin-Utilities-DefaultValues-OrderTypes 'Definux.Emeraude.Admin.Utilities.DefaultValues.OrderTypes')
- [DeleteActivityLogCommand](#T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteActivityLogCommand 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteActivityLogCommand')
  - [#ctor(logId)](#M-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteActivityLogCommand-#ctor-System-Int32- 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteActivityLogCommand.#ctor(System.Int32)')
- [DeleteActivityLogCommandHandler](#T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteActivityLogCommand-DeleteActivityLogCommandHandler 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteActivityLogCommand.DeleteActivityLogCommandHandler')
  - [#ctor(context)](#M-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteActivityLogCommand-DeleteActivityLogCommandHandler-#ctor-Definux-Emeraude-Application-Logger-ILoggerContext- 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteActivityLogCommand.DeleteActivityLogCommandHandler.#ctor(Definux.Emeraude.Application.Logger.ILoggerContext)')
- [DeleteCommandHandler\`1](#T-Definux-Emeraude-Admin-Requests-Delete-DeleteCommandHandler`1 'Definux.Emeraude.Admin.Requests.Delete.DeleteCommandHandler`1')
  - [#ctor(context,mapper,logger)](#M-Definux-Emeraude-Admin-Requests-Delete-DeleteCommandHandler`1-#ctor-Definux-Emeraude-Application-Persistence-IEmContext,AutoMapper-IMapper,Definux-Emeraude-Application-Logger-IEmLogger- 'Definux.Emeraude.Admin.Requests.Delete.DeleteCommandHandler`1.#ctor(Definux.Emeraude.Application.Persistence.IEmContext,AutoMapper.IMapper,Definux.Emeraude.Application.Logger.IEmLogger)')
  - [Handle()](#M-Definux-Emeraude-Admin-Requests-Delete-DeleteCommandHandler`1-Handle-Definux-Emeraude-Admin-Requests-Delete-DeleteCommand{`0},System-Threading-CancellationToken- 'Definux.Emeraude.Admin.Requests.Delete.DeleteCommandHandler`1.Handle(Definux.Emeraude.Admin.Requests.Delete.DeleteCommand{`0},System.Threading.CancellationToken)')
- [DeleteCommand\`1](#T-Definux-Emeraude-Admin-Requests-Delete-DeleteCommand`1 'Definux.Emeraude.Admin.Requests.Delete.DeleteCommand`1')
  - [#ctor(entityId)](#M-Definux-Emeraude-Admin-Requests-Delete-DeleteCommand`1-#ctor-System-Guid- 'Definux.Emeraude.Admin.Requests.Delete.DeleteCommand`1.#ctor(System.Guid)')
  - [#ctor(entityId,parentExpression)](#M-Definux-Emeraude-Admin-Requests-Delete-DeleteCommand`1-#ctor-System-Guid,System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}}- 'Definux.Emeraude.Admin.Requests.Delete.DeleteCommand`1.#ctor(System.Guid,System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}})')
  - [EntityId](#P-Definux-Emeraude-Admin-Requests-Delete-DeleteCommand`1-EntityId 'Definux.Emeraude.Admin.Requests.Delete.DeleteCommand`1.EntityId')
- [DeleteEmailLogCommand](#T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteEmailLogCommand 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteEmailLogCommand')
  - [#ctor(logId)](#M-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteEmailLogCommand-#ctor-System-Int32- 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteEmailLogCommand.#ctor(System.Int32)')
- [DeleteEmailLogCommandHandler](#T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteEmailLogCommand-DeleteEmailLogCommandHandler 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteEmailLogCommand.DeleteEmailLogCommandHandler')
  - [#ctor(context)](#M-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteEmailLogCommand-DeleteEmailLogCommandHandler-#ctor-Definux-Emeraude-Application-Logger-ILoggerContext- 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteEmailLogCommand.DeleteEmailLogCommandHandler.#ctor(Definux.Emeraude.Application.Logger.ILoggerContext)')
- [DeleteErrorLogCommand](#T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteErrorLogCommand 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteErrorLogCommand')
  - [#ctor(logId)](#M-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteErrorLogCommand-#ctor-System-Int32- 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteErrorLogCommand.#ctor(System.Int32)')
- [DeleteErrorLogCommandHandler](#T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteErrorLogCommand-DeleteErrorLogCommandHandler 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteErrorLogCommand.DeleteErrorLogCommandHandler')
  - [#ctor(context)](#M-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteErrorLogCommand-DeleteErrorLogCommandHandler-#ctor-Definux-Emeraude-Application-Logger-ILoggerContext- 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteErrorLogCommand.DeleteErrorLogCommandHandler.#ctor(Definux.Emeraude.Application.Logger.ILoggerContext)')
- [DeleteLogCommandHandler\`2](#T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteLogCommandHandler`2 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteLogCommandHandler`2')
  - [#ctor(context)](#M-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteLogCommandHandler`2-#ctor-Definux-Emeraude-Application-Logger-ILoggerContext- 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteLogCommandHandler`2.#ctor(Definux.Emeraude.Application.Logger.ILoggerContext)')
  - [Handle()](#M-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteLogCommandHandler`2-Handle-`0,System-Threading-CancellationToken- 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteLogCommandHandler`2.Handle(`0,System.Threading.CancellationToken)')
- [DeleteLogCommand\`1](#T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteLogCommand`1 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteLogCommand`1')
  - [#ctor(logId)](#M-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteLogCommand`1-#ctor-System-Int32- 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteLogCommand`1.#ctor(System.Int32)')
  - [LogId](#P-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteLogCommand`1-LogId 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteLogCommand`1.LogId')
  - [LogType](#P-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteLogCommand`1-LogType 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteLogCommand`1.LogType')
- [DeleteTempFileLogCommand](#T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteTempFileLogCommand 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteTempFileLogCommand')
  - [#ctor(logId)](#M-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteTempFileLogCommand-#ctor-System-Int32- 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteTempFileLogCommand.#ctor(System.Int32)')
- [DeleteTempFileLogCommandHandler](#T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteTempFileLogCommand-DeleteTempFileLogCommandHandler 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteTempFileLogCommand.DeleteTempFileLogCommandHandler')
  - [#ctor(context)](#M-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteTempFileLogCommand-DeleteTempFileLogCommandHandler-#ctor-Definux-Emeraude-Application-Logger-ILoggerContext- 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteTempFileLogCommand.DeleteTempFileLogCommandHandler.#ctor(Definux.Emeraude.Application.Logger.ILoggerContext)')
- [DetailsFieldAttribute](#T-Definux-Emeraude-Admin-Attributes-DetailsFieldAttribute 'Definux.Emeraude.Admin.Attributes.DetailsFieldAttribute')
  - [#ctor(order,title,uiElementType)](#M-Definux-Emeraude-Admin-Attributes-DetailsFieldAttribute-#ctor-System-Int32,System-String,System-Type- 'Definux.Emeraude.Admin.Attributes.DetailsFieldAttribute.#ctor(System.Int32,System.String,System.Type)')
  - [#ctor(order,uiElementType,propertyName)](#M-Definux-Emeraude-Admin-Attributes-DetailsFieldAttribute-#ctor-System-Int32,System-Type,System-String- 'Definux.Emeraude.Admin.Attributes.DetailsFieldAttribute.#ctor(System.Int32,System.Type,System.String)')
  - [Order](#P-Definux-Emeraude-Admin-Attributes-DetailsFieldAttribute-Order 'Definux.Emeraude.Admin.Attributes.DetailsFieldAttribute.Order')
  - [Title](#P-Definux-Emeraude-Admin-Attributes-DetailsFieldAttribute-Title 'Definux.Emeraude.Admin.Attributes.DetailsFieldAttribute.Title')
  - [UIElementType](#P-Definux-Emeraude-Admin-Attributes-DetailsFieldAttribute-UIElementType 'Definux.Emeraude.Admin.Attributes.DetailsFieldAttribute.UIElementType')
- [DetailsQueryHandler\`2](#T-Definux-Emeraude-Admin-Requests-Details-DetailsQueryHandler`2 'Definux.Emeraude.Admin.Requests.Details.DetailsQueryHandler`2')
  - [#ctor(context,mapper,logger)](#M-Definux-Emeraude-Admin-Requests-Details-DetailsQueryHandler`2-#ctor-Definux-Emeraude-Application-Persistence-IEmContext,AutoMapper-IMapper,Definux-Emeraude-Application-Logger-IEmLogger- 'Definux.Emeraude.Admin.Requests.Details.DetailsQueryHandler`2.#ctor(Definux.Emeraude.Application.Persistence.IEmContext,AutoMapper.IMapper,Definux.Emeraude.Application.Logger.IEmLogger)')
  - [Handle()](#M-Definux-Emeraude-Admin-Requests-Details-DetailsQueryHandler`2-Handle-Definux-Emeraude-Admin-Requests-Details-DetailsQuery{`0,`1},System-Threading-CancellationToken- 'Definux.Emeraude.Admin.Requests.Details.DetailsQueryHandler`2.Handle(Definux.Emeraude.Admin.Requests.Details.DetailsQuery{`0,`1},System.Threading.CancellationToken)')
- [DetailsQuery\`2](#T-Definux-Emeraude-Admin-Requests-Details-DetailsQuery`2 'Definux.Emeraude.Admin.Requests.Details.DetailsQuery`2')
  - [#ctor(entityId)](#M-Definux-Emeraude-Admin-Requests-Details-DetailsQuery`2-#ctor-System-Guid- 'Definux.Emeraude.Admin.Requests.Details.DetailsQuery`2.#ctor(System.Guid)')
  - [#ctor(entityId,parentExpression)](#M-Definux-Emeraude-Admin-Requests-Details-DetailsQuery`2-#ctor-System-Guid,System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}}- 'Definux.Emeraude.Admin.Requests.Details.DetailsQuery`2.#ctor(System.Guid,System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}})')
  - [EntityId](#P-Definux-Emeraude-Admin-Requests-Details-DetailsQuery`2-EntityId 'Definux.Emeraude.Admin.Requests.Details.DetailsQuery`2.EntityId')
- [EditCommandHandler\`2](#T-Definux-Emeraude-Admin-Requests-Edit-EditCommandHandler`2 'Definux.Emeraude.Admin.Requests.Edit.EditCommandHandler`2')
  - [#ctor(context,mapper,logger)](#M-Definux-Emeraude-Admin-Requests-Edit-EditCommandHandler`2-#ctor-Definux-Emeraude-Application-Persistence-IEmContext,AutoMapper-IMapper,Definux-Emeraude-Application-Logger-IEmLogger- 'Definux.Emeraude.Admin.Requests.Edit.EditCommandHandler`2.#ctor(Definux.Emeraude.Application.Persistence.IEmContext,AutoMapper.IMapper,Definux.Emeraude.Application.Logger.IEmLogger)')
  - [Handle()](#M-Definux-Emeraude-Admin-Requests-Edit-EditCommandHandler`2-Handle-Definux-Emeraude-Admin-Requests-Edit-EditCommand{`0,`1},System-Threading-CancellationToken- 'Definux.Emeraude.Admin.Requests.Edit.EditCommandHandler`2.Handle(Definux.Emeraude.Admin.Requests.Edit.EditCommand{`0,`1},System.Threading.CancellationToken)')
- [EditCommand\`2](#T-Definux-Emeraude-Admin-Requests-Edit-EditCommand`2 'Definux.Emeraude.Admin.Requests.Edit.EditCommand`2')
  - [#ctor(entityId,model)](#M-Definux-Emeraude-Admin-Requests-Edit-EditCommand`2-#ctor-System-Guid,`1- 'Definux.Emeraude.Admin.Requests.Edit.EditCommand`2.#ctor(System.Guid,`1)')
  - [#ctor(entityId,model,parentExpression)](#M-Definux-Emeraude-Admin-Requests-Edit-EditCommand`2-#ctor-System-Guid,`1,System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}}- 'Definux.Emeraude.Admin.Requests.Edit.EditCommand`2.#ctor(System.Guid,`1,System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}})')
  - [EntityId](#P-Definux-Emeraude-Admin-Requests-Edit-EditCommand`2-EntityId 'Definux.Emeraude.Admin.Requests.Edit.EditCommand`2.EntityId')
  - [Model](#P-Definux-Emeraude-Admin-Requests-Edit-EditCommand`2-Model 'Definux.Emeraude.Admin.Requests.Edit.EditCommand`2.Model')
- [EmContextAdapter](#T-Definux-Emeraude-Admin-Adapters-EmContextAdapter 'Definux.Emeraude.Admin.Adapters.EmContextAdapter')
  - [#ctor(context)](#M-Definux-Emeraude-Admin-Adapters-EmContextAdapter-#ctor-Definux-Emeraude-Application-Persistence-IEmContext- 'Definux.Emeraude.Admin.Adapters.EmContextAdapter.#ctor(Definux.Emeraude.Application.Persistence.IEmContext)')
  - [GetAllEntitiesByPropertyName()](#M-Definux-Emeraude-Admin-Adapters-EmContextAdapter-GetAllEntitiesByPropertyName-System-String- 'Definux.Emeraude.Admin.Adapters.EmContextAdapter.GetAllEntitiesByPropertyName(System.String)')
  - [GetAllEntitiesByType()](#M-Definux-Emeraude-Admin-Adapters-EmContextAdapter-GetAllEntitiesByType-System-Type- 'Definux.Emeraude.Admin.Adapters.EmContextAdapter.GetAllEntitiesByType(System.Type)')
- [EntityIdentifierAttribute](#T-Definux-Emeraude-Admin-Attributes-EntityIdentifierAttribute 'Definux.Emeraude.Admin.Attributes.EntityIdentifierAttribute')
- [EntitySelectModel](#T-Definux-Emeraude-Admin-Models-EntitySelectModel 'Definux.Emeraude.Admin.Models.EntitySelectModel')
  - [Id](#P-Definux-Emeraude-Admin-Models-EntitySelectModel-Id 'Definux.Emeraude.Admin.Models.EntitySelectModel.Id')
  - [Text](#P-Definux-Emeraude-Admin-Models-EntitySelectModel-Text 'Definux.Emeraude.Admin.Models.EntitySelectModel.Text')
- [ExistsQueryHandler\`1](#T-Definux-Emeraude-Admin-Requests-Exists-ExistsQueryHandler`1 'Definux.Emeraude.Admin.Requests.Exists.ExistsQueryHandler`1')
  - [#ctor(context,logger)](#M-Definux-Emeraude-Admin-Requests-Exists-ExistsQueryHandler`1-#ctor-Definux-Emeraude-Application-Persistence-IEmContext,Definux-Emeraude-Application-Logger-IEmLogger- 'Definux.Emeraude.Admin.Requests.Exists.ExistsQueryHandler`1.#ctor(Definux.Emeraude.Application.Persistence.IEmContext,Definux.Emeraude.Application.Logger.IEmLogger)')
  - [Handle()](#M-Definux-Emeraude-Admin-Requests-Exists-ExistsQueryHandler`1-Handle-Definux-Emeraude-Admin-Requests-Exists-ExistsQuery{`0},System-Threading-CancellationToken- 'Definux.Emeraude.Admin.Requests.Exists.ExistsQueryHandler`1.Handle(Definux.Emeraude.Admin.Requests.Exists.ExistsQuery{`0},System.Threading.CancellationToken)')
- [ExistsQuery\`1](#T-Definux-Emeraude-Admin-Requests-Exists-ExistsQuery`1 'Definux.Emeraude.Admin.Requests.Exists.ExistsQuery`1')
  - [#ctor(entityId)](#M-Definux-Emeraude-Admin-Requests-Exists-ExistsQuery`1-#ctor-System-Guid- 'Definux.Emeraude.Admin.Requests.Exists.ExistsQuery`1.#ctor(System.Guid)')
  - [EntityId](#P-Definux-Emeraude-Admin-Requests-Exists-ExistsQuery`1-EntityId 'Definux.Emeraude.Admin.Requests.Exists.ExistsQuery`1.EntityId')
- [ExpressionBuilders](#T-Definux-Emeraude-Admin-Utilities-ExpressionBuilders 'Definux.Emeraude.Admin.Utilities.ExpressionBuilders')
  - [BuildLambdaExpression\`\`1(propertyName)](#M-Definux-Emeraude-Admin-Utilities-ExpressionBuilders-BuildLambdaExpression``1-System-String- 'Definux.Emeraude.Admin.Utilities.ExpressionBuilders.BuildLambdaExpression``1(System.String)')
  - [BuildQueryExpressionBySearchQuery\`\`1(searchQuery)](#M-Definux-Emeraude-Admin-Utilities-ExpressionBuilders-BuildQueryExpressionBySearchQuery``1-System-String- 'Definux.Emeraude.Admin.Utilities.ExpressionBuilders.BuildQueryExpressionBySearchQuery``1(System.String)')
  - [OrderByProperty\`\`1(queryable,propertyName,orderType)](#M-Definux-Emeraude-Admin-Utilities-ExpressionBuilders-OrderByProperty``1-System-Linq-IQueryable{``0},System-String,Definux-Emeraude-Admin-Utilities-OrderType- 'Definux.Emeraude.Admin.Utilities.ExpressionBuilders.OrderByProperty``1(System.Linq.IQueryable{``0},System.String,Definux.Emeraude.Admin.Utilities.OrderType)')
- [FetchActivityLogsQuery](#T-Definux-Emeraude-Admin-Requests-FetchLogs-FetchActivityLogsQuery 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchActivityLogsQuery')
- [FetchActivityLogsQueryHandler](#T-Definux-Emeraude-Admin-Requests-FetchLogs-FetchActivityLogsQuery-FetchActivityLogsQueryHandler 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchActivityLogsQuery.FetchActivityLogsQueryHandler')
  - [#ctor(loggerContext,entityContext,mapper)](#M-Definux-Emeraude-Admin-Requests-FetchLogs-FetchActivityLogsQuery-FetchActivityLogsQueryHandler-#ctor-Definux-Emeraude-Application-Logger-ILoggerContext,Definux-Emeraude-Application-Persistence-IEmContext,AutoMapper-IMapper- 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchActivityLogsQuery.FetchActivityLogsQueryHandler.#ctor(Definux.Emeraude.Application.Logger.ILoggerContext,Definux.Emeraude.Application.Persistence.IEmContext,AutoMapper.IMapper)')
  - [BuildSearchQueryExpression()](#M-Definux-Emeraude-Admin-Requests-FetchLogs-FetchActivityLogsQuery-FetchActivityLogsQueryHandler-BuildSearchQueryExpression-System-String- 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchActivityLogsQuery.FetchActivityLogsQueryHandler.BuildSearchQueryExpression(System.String)')
- [FetchEmailLogsQuery](#T-Definux-Emeraude-Admin-Requests-FetchLogs-FetchEmailLogsQuery 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchEmailLogsQuery')
- [FetchEmailLogsQueryHandler](#T-Definux-Emeraude-Admin-Requests-FetchLogs-FetchEmailLogsQuery-FetchEmailLogsQueryHandler 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchEmailLogsQuery.FetchEmailLogsQueryHandler')
  - [#ctor(loggerContext,entityContext,mapper)](#M-Definux-Emeraude-Admin-Requests-FetchLogs-FetchEmailLogsQuery-FetchEmailLogsQueryHandler-#ctor-Definux-Emeraude-Application-Logger-ILoggerContext,Definux-Emeraude-Application-Persistence-IEmContext,AutoMapper-IMapper- 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchEmailLogsQuery.FetchEmailLogsQueryHandler.#ctor(Definux.Emeraude.Application.Logger.ILoggerContext,Definux.Emeraude.Application.Persistence.IEmContext,AutoMapper.IMapper)')
  - [BuildSearchQueryExpression()](#M-Definux-Emeraude-Admin-Requests-FetchLogs-FetchEmailLogsQuery-FetchEmailLogsQueryHandler-BuildSearchQueryExpression-System-String- 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchEmailLogsQuery.FetchEmailLogsQueryHandler.BuildSearchQueryExpression(System.String)')
- [FetchErrorLogsQuery](#T-Definux-Emeraude-Admin-Requests-FetchLogs-FetchErrorLogsQuery 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchErrorLogsQuery')
- [FetchErrorLogsQueryHandler](#T-Definux-Emeraude-Admin-Requests-FetchLogs-FetchErrorLogsQuery-FetchErrorLogsQueryHandler 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchErrorLogsQuery.FetchErrorLogsQueryHandler')
  - [#ctor(loggerContext,entityContext,mapper)](#M-Definux-Emeraude-Admin-Requests-FetchLogs-FetchErrorLogsQuery-FetchErrorLogsQueryHandler-#ctor-Definux-Emeraude-Application-Logger-ILoggerContext,Definux-Emeraude-Application-Persistence-IEmContext,AutoMapper-IMapper- 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchErrorLogsQuery.FetchErrorLogsQueryHandler.#ctor(Definux.Emeraude.Application.Logger.ILoggerContext,Definux.Emeraude.Application.Persistence.IEmContext,AutoMapper.IMapper)')
  - [BuildSearchQueryExpression()](#M-Definux-Emeraude-Admin-Requests-FetchLogs-FetchErrorLogsQuery-FetchErrorLogsQueryHandler-BuildSearchQueryExpression-System-String- 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchErrorLogsQuery.FetchErrorLogsQueryHandler.BuildSearchQueryExpression(System.String)')
- [FetchLogsQueryHandler\`4](#T-Definux-Emeraude-Admin-Requests-FetchLogs-FetchLogsQueryHandler`4 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchLogsQueryHandler`4')
  - [#ctor(loggerContext,entityContext,mapper)](#M-Definux-Emeraude-Admin-Requests-FetchLogs-FetchLogsQueryHandler`4-#ctor-Definux-Emeraude-Application-Logger-ILoggerContext,Definux-Emeraude-Application-Persistence-IEmContext,AutoMapper-IMapper- 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchLogsQueryHandler`4.#ctor(Definux.Emeraude.Application.Logger.ILoggerContext,Definux.Emeraude.Application.Persistence.IEmContext,AutoMapper.IMapper)')
  - [BuildSearchQueryExpression(searchQuery)](#M-Definux-Emeraude-Admin-Requests-FetchLogs-FetchLogsQueryHandler`4-BuildSearchQueryExpression-System-String- 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchLogsQueryHandler`4.BuildSearchQueryExpression(System.String)')
  - [Handle()](#M-Definux-Emeraude-Admin-Requests-FetchLogs-FetchLogsQueryHandler`4-Handle-`0,System-Threading-CancellationToken- 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchLogsQueryHandler`4.Handle(`0,System.Threading.CancellationToken)')
- [FetchLogsQuery\`1](#T-Definux-Emeraude-Admin-Requests-FetchLogs-FetchLogsQuery`1 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchLogsQuery`1')
  - [FromDate](#P-Definux-Emeraude-Admin-Requests-FetchLogs-FetchLogsQuery`1-FromDate 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchLogsQuery`1.FromDate')
  - [Page](#P-Definux-Emeraude-Admin-Requests-FetchLogs-FetchLogsQuery`1-Page 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchLogsQuery`1.Page')
  - [SearchQuery](#P-Definux-Emeraude-Admin-Requests-FetchLogs-FetchLogsQuery`1-SearchQuery 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchLogsQuery`1.SearchQuery')
  - [ToDate](#P-Definux-Emeraude-Admin-Requests-FetchLogs-FetchLogsQuery`1-ToDate 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchLogsQuery`1.ToDate')
  - [User](#P-Definux-Emeraude-Admin-Requests-FetchLogs-FetchLogsQuery`1-User 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchLogsQuery`1.User')
- [FetchTempFileLogsQuery](#T-Definux-Emeraude-Admin-Requests-FetchLogs-FetchTempFileLogsQuery 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchTempFileLogsQuery')
- [FetchTempFileLogsQueryHandler](#T-Definux-Emeraude-Admin-Requests-FetchLogs-FetchTempFileLogsQuery-FetchTempFileLogsQueryHandler 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchTempFileLogsQuery.FetchTempFileLogsQueryHandler')
  - [#ctor(loggerContext,entityContext,mapper)](#M-Definux-Emeraude-Admin-Requests-FetchLogs-FetchTempFileLogsQuery-FetchTempFileLogsQueryHandler-#ctor-Definux-Emeraude-Application-Logger-ILoggerContext,Definux-Emeraude-Application-Persistence-IEmContext,AutoMapper-IMapper- 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchTempFileLogsQuery.FetchTempFileLogsQueryHandler.#ctor(Definux.Emeraude.Application.Logger.ILoggerContext,Definux.Emeraude.Application.Persistence.IEmContext,AutoMapper.IMapper)')
  - [BuildSearchQueryExpression()](#M-Definux-Emeraude-Admin-Requests-FetchLogs-FetchTempFileLogsQuery-FetchTempFileLogsQueryHandler-BuildSearchQueryExpression-System-String- 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchTempFileLogsQuery.FetchTempFileLogsQueryHandler.BuildSearchQueryExpression(System.String)')
- [FormInputAttribute](#T-Definux-Emeraude-Admin-Attributes-FormInputAttribute 'Definux.Emeraude.Admin.Attributes.FormInputAttribute')
  - [#ctor(order,name,uiElementType,dataSourceType,visualizationPropertyName)](#M-Definux-Emeraude-Admin-Attributes-FormInputAttribute-#ctor-System-Int32,System-String,System-Type,System-Type,System-String- 'Definux.Emeraude.Admin.Attributes.FormInputAttribute.#ctor(System.Int32,System.String,System.Type,System.Type,System.String)')
  - [#ctor(order,uiElementType,dataSourceType,visualizationPropertyName,propertyName)](#M-Definux-Emeraude-Admin-Attributes-FormInputAttribute-#ctor-System-Int32,System-Type,System-Type,System-String,System-String- 'Definux.Emeraude.Admin.Attributes.FormInputAttribute.#ctor(System.Int32,System.Type,System.Type,System.String,System.String)')
  - [DataSourceType](#P-Definux-Emeraude-Admin-Attributes-FormInputAttribute-DataSourceType 'Definux.Emeraude.Admin.Attributes.FormInputAttribute.DataSourceType')
  - [Name](#P-Definux-Emeraude-Admin-Attributes-FormInputAttribute-Name 'Definux.Emeraude.Admin.Attributes.FormInputAttribute.Name')
  - [Order](#P-Definux-Emeraude-Admin-Attributes-FormInputAttribute-Order 'Definux.Emeraude.Admin.Attributes.FormInputAttribute.Order')
  - [UIElementType](#P-Definux-Emeraude-Admin-Attributes-FormInputAttribute-UIElementType 'Definux.Emeraude.Admin.Attributes.FormInputAttribute.UIElementType')
  - [VisualizationPropertyName](#P-Definux-Emeraude-Admin-Attributes-FormInputAttribute-VisualizationPropertyName 'Definux.Emeraude.Admin.Attributes.FormInputAttribute.VisualizationPropertyName')
- [GenericEntityRequst\`1](#T-Definux-Emeraude-Admin-Requests-GenericEntityRequst`1 'Definux.Emeraude.Admin.Requests.GenericEntityRequst`1')
  - [ParentExpression](#P-Definux-Emeraude-Admin-Requests-GenericEntityRequst`1-ParentExpression 'Definux.Emeraude.Admin.Requests.GenericEntityRequst`1.ParentExpression')
- [GenericNewEntityRequest\`1](#T-Definux-Emeraude-Admin-Requests-GenericNewEntityRequest`1 'Definux.Emeraude.Admin.Requests.GenericNewEntityRequest`1')
  - [ParentId](#P-Definux-Emeraude-Admin-Requests-GenericNewEntityRequest`1-ParentId 'Definux.Emeraude.Admin.Requests.GenericNewEntityRequest`1.ParentId')
  - [ParentProperty](#P-Definux-Emeraude-Admin-Requests-GenericNewEntityRequest`1-ParentProperty 'Definux.Emeraude.Admin.Requests.GenericNewEntityRequest`1.ParentProperty')
- [GetAllQueryHandler\`2](#T-Definux-Emeraude-Admin-Requests-GetAll-GetAllQueryHandler`2 'Definux.Emeraude.Admin.Requests.GetAll.GetAllQueryHandler`2')
  - [#ctor(context,mapper,logger)](#M-Definux-Emeraude-Admin-Requests-GetAll-GetAllQueryHandler`2-#ctor-Definux-Emeraude-Application-Persistence-IEmContext,AutoMapper-IMapper,Definux-Emeraude-Application-Logger-IEmLogger- 'Definux.Emeraude.Admin.Requests.GetAll.GetAllQueryHandler`2.#ctor(Definux.Emeraude.Application.Persistence.IEmContext,AutoMapper.IMapper,Definux.Emeraude.Application.Logger.IEmLogger)')
  - [Handle()](#M-Definux-Emeraude-Admin-Requests-GetAll-GetAllQueryHandler`2-Handle-Definux-Emeraude-Admin-Requests-GetAll-GetAllQuery{`0,`1},System-Threading-CancellationToken- 'Definux.Emeraude.Admin.Requests.GetAll.GetAllQueryHandler`2.Handle(Definux.Emeraude.Admin.Requests.GetAll.GetAllQuery{`0,`1},System.Threading.CancellationToken)')
- [GetAllQuery\`2](#T-Definux-Emeraude-Admin-Requests-GetAll-GetAllQuery`2 'Definux.Emeraude.Admin.Requests.GetAll.GetAllQuery`2')
  - [#ctor(page,searchQuery)](#M-Definux-Emeraude-Admin-Requests-GetAll-GetAllQuery`2-#ctor-System-Int32,System-String- 'Definux.Emeraude.Admin.Requests.GetAll.GetAllQuery`2.#ctor(System.Int32,System.String)')
  - [#ctor(page,searchQuery,parentExpression)](#M-Definux-Emeraude-Admin-Requests-GetAll-GetAllQuery`2-#ctor-System-Int32,System-String,System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}}- 'Definux.Emeraude.Admin.Requests.GetAll.GetAllQuery`2.#ctor(System.Int32,System.String,System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}})')
  - [OrderBy](#P-Definux-Emeraude-Admin-Requests-GetAll-GetAllQuery`2-OrderBy 'Definux.Emeraude.Admin.Requests.GetAll.GetAllQuery`2.OrderBy')
  - [OrderType](#P-Definux-Emeraude-Admin-Requests-GetAll-GetAllQuery`2-OrderType 'Definux.Emeraude.Admin.Requests.GetAll.GetAllQuery`2.OrderType')
  - [Page](#P-Definux-Emeraude-Admin-Requests-GetAll-GetAllQuery`2-Page 'Definux.Emeraude.Admin.Requests.GetAll.GetAllQuery`2.Page')
  - [PageSize](#P-Definux-Emeraude-Admin-Requests-GetAll-GetAllQuery`2-PageSize 'Definux.Emeraude.Admin.Requests.GetAll.GetAllQuery`2.PageSize')
  - [SearchQuery](#P-Definux-Emeraude-Admin-Requests-GetAll-GetAllQuery`2-SearchQuery 'Definux.Emeraude.Admin.Requests.GetAll.GetAllQuery`2.SearchQuery')
- [GetEmailBodyQuery](#T-Definux-Emeraude-Admin-Requests-GetEmailBody-GetEmailBodyQuery 'Definux.Emeraude.Admin.Requests.GetEmailBody.GetEmailBodyQuery')
  - [#ctor(emailLogId)](#M-Definux-Emeraude-Admin-Requests-GetEmailBody-GetEmailBodyQuery-#ctor-System-Int32- 'Definux.Emeraude.Admin.Requests.GetEmailBody.GetEmailBodyQuery.#ctor(System.Int32)')
  - [EmailLogId](#P-Definux-Emeraude-Admin-Requests-GetEmailBody-GetEmailBodyQuery-EmailLogId 'Definux.Emeraude.Admin.Requests.GetEmailBody.GetEmailBodyQuery.EmailLogId')
- [GetEmailBodyQueryHandler](#T-Definux-Emeraude-Admin-Requests-GetEmailBody-GetEmailBodyQuery-GetEmailBodyQueryHandler 'Definux.Emeraude.Admin.Requests.GetEmailBody.GetEmailBodyQuery.GetEmailBodyQueryHandler')
  - [#ctor(context,logger)](#M-Definux-Emeraude-Admin-Requests-GetEmailBody-GetEmailBodyQuery-GetEmailBodyQueryHandler-#ctor-Definux-Emeraude-Application-Logger-ILoggerContext,Definux-Emeraude-Application-Logger-IEmLogger- 'Definux.Emeraude.Admin.Requests.GetEmailBody.GetEmailBodyQuery.GetEmailBodyQueryHandler.#ctor(Definux.Emeraude.Application.Logger.ILoggerContext,Definux.Emeraude.Application.Logger.IEmLogger)')
  - [Handle()](#M-Definux-Emeraude-Admin-Requests-GetEmailBody-GetEmailBodyQuery-GetEmailBodyQueryHandler-Handle-Definux-Emeraude-Admin-Requests-GetEmailBody-GetEmailBodyQuery,System-Threading-CancellationToken- 'Definux.Emeraude.Admin.Requests.GetEmailBody.GetEmailBodyQuery.GetEmailBodyQueryHandler.Handle(Definux.Emeraude.Admin.Requests.GetEmailBody.GetEmailBodyQuery,System.Threading.CancellationToken)')
- [GetEntityImageQueryHandler\`1](#T-Definux-Emeraude-Admin-Requests-GetEntityImage-GetEntityImageQueryHandler`1 'Definux.Emeraude.Admin.Requests.GetEntityImage.GetEntityImageQueryHandler`1')
  - [#ctor(context,logger)](#M-Definux-Emeraude-Admin-Requests-GetEntityImage-GetEntityImageQueryHandler`1-#ctor-Definux-Emeraude-Application-Persistence-IEmContext,Definux-Emeraude-Application-Logger-IEmLogger- 'Definux.Emeraude.Admin.Requests.GetEntityImage.GetEntityImageQueryHandler`1.#ctor(Definux.Emeraude.Application.Persistence.IEmContext,Definux.Emeraude.Application.Logger.IEmLogger)')
  - [Handle()](#M-Definux-Emeraude-Admin-Requests-GetEntityImage-GetEntityImageQueryHandler`1-Handle-Definux-Emeraude-Admin-Requests-GetEntityImage-GetEntityImageQuery{`0},System-Threading-CancellationToken- 'Definux.Emeraude.Admin.Requests.GetEntityImage.GetEntityImageQueryHandler`1.Handle(Definux.Emeraude.Admin.Requests.GetEntityImage.GetEntityImageQuery{`0},System.Threading.CancellationToken)')
- [GetEntityImageQuery\`1](#T-Definux-Emeraude-Admin-Requests-GetEntityImage-GetEntityImageQuery`1 'Definux.Emeraude.Admin.Requests.GetEntityImage.GetEntityImageQuery`1')
  - [#ctor(entityId)](#M-Definux-Emeraude-Admin-Requests-GetEntityImage-GetEntityImageQuery`1-#ctor-System-Guid- 'Definux.Emeraude.Admin.Requests.GetEntityImage.GetEntityImageQuery`1.#ctor(System.Guid)')
  - [EntityId](#P-Definux-Emeraude-Admin-Requests-GetEntityImage-GetEntityImageQuery`1-EntityId 'Definux.Emeraude.Admin.Requests.GetEntityImage.GetEntityImageQuery`1.EntityId')
- [IAdminEntityController](#T-Definux-Emeraude-Admin-Controllers-Abstractions-IAdminEntityController 'Definux.Emeraude.Admin.Controllers.Abstractions.IAdminEntityController')
- [IAdminEntityMapper](#T-Definux-Emeraude-Admin-Mapping-IAdminEntityMapper 'Definux.Emeraude.Admin.Mapping.IAdminEntityMapper')
  - [MapToDetailsViewModel\`\`1(entity)](#M-Definux-Emeraude-Admin-Mapping-IAdminEntityMapper-MapToDetailsViewModel``1-``0- 'Definux.Emeraude.Admin.Mapping.IAdminEntityMapper.MapToDetailsViewModel``1(``0)')
  - [MapToFormInputViewModels(entityViewModel)](#M-Definux-Emeraude-Admin-Mapping-IAdminEntityMapper-MapToFormInputViewModels-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-IEntityFormViewModel- 'Definux.Emeraude.Admin.Mapping.IAdminEntityMapper.MapToFormInputViewModels(Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.IEntityFormViewModel)')
  - [MapToTableViewModel\`\`1(entitiesResult,actions)](#M-Definux-Emeraude-Admin-Mapping-IAdminEntityMapper-MapToTableViewModel``1-Definux-Utilities-Objects-PaginatedList{``0},Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel[]- 'Definux.Emeraude.Admin.Mapping.IAdminEntityMapper.MapToTableViewModel``1(Definux.Utilities.Objects.PaginatedList{``0},Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowActionViewModel[])')
- [ICreateCommandHandler\`3](#T-Definux-Emeraude-Admin-Requests-Create-ICreateCommandHandler`3 'Definux.Emeraude.Admin.Requests.Create.ICreateCommandHandler`3')
- [ICreateCommand\`2](#T-Definux-Emeraude-Admin-Requests-Create-ICreateCommand`2 'Definux.Emeraude.Admin.Requests.Create.ICreateCommand`2')
  - [Model](#P-Definux-Emeraude-Admin-Requests-Create-ICreateCommand`2-Model 'Definux.Emeraude.Admin.Requests.Create.ICreateCommand`2.Model')
- [IDashboardRequest\`1](#T-Definux-Emeraude-Admin-Requests-IDashboardRequest`1 'Definux.Emeraude.Admin.Requests.IDashboardRequest`1')
- [IDeleteCommandHandler\`2](#T-Definux-Emeraude-Admin-Requests-Delete-IDeleteCommandHandler`2 'Definux.Emeraude.Admin.Requests.Delete.IDeleteCommandHandler`2')
- [IDeleteCommand\`1](#T-Definux-Emeraude-Admin-Requests-Delete-IDeleteCommand`1 'Definux.Emeraude.Admin.Requests.Delete.IDeleteCommand`1')
  - [EntityId](#P-Definux-Emeraude-Admin-Requests-Delete-IDeleteCommand`1-EntityId 'Definux.Emeraude.Admin.Requests.Delete.IDeleteCommand`1.EntityId')
- [IDetailsQueryHandler\`3](#T-Definux-Emeraude-Admin-Requests-Details-IDetailsQueryHandler`3 'Definux.Emeraude.Admin.Requests.Details.IDetailsQueryHandler`3')
- [IDetailsQuery\`2](#T-Definux-Emeraude-Admin-Requests-Details-IDetailsQuery`2 'Definux.Emeraude.Admin.Requests.Details.IDetailsQuery`2')
  - [EntityId](#P-Definux-Emeraude-Admin-Requests-Details-IDetailsQuery`2-EntityId 'Definux.Emeraude.Admin.Requests.Details.IDetailsQuery`2.EntityId')
- [IEditCommandHandler\`3](#T-Definux-Emeraude-Admin-Requests-Edit-IEditCommandHandler`3 'Definux.Emeraude.Admin.Requests.Edit.IEditCommandHandler`3')
- [IEditCommand\`2](#T-Definux-Emeraude-Admin-Requests-Edit-IEditCommand`2 'Definux.Emeraude.Admin.Requests.Edit.IEditCommand`2')
  - [EntityId](#P-Definux-Emeraude-Admin-Requests-Edit-IEditCommand`2-EntityId 'Definux.Emeraude.Admin.Requests.Edit.IEditCommand`2.EntityId')
  - [Model](#P-Definux-Emeraude-Admin-Requests-Edit-IEditCommand`2-Model 'Definux.Emeraude.Admin.Requests.Edit.IEditCommand`2.Model')
- [IFetchLogsQuery](#T-Definux-Emeraude-Admin-Requests-FetchLogs-IFetchLogsQuery 'Definux.Emeraude.Admin.Requests.FetchLogs.IFetchLogsQuery')
  - [FromDate](#P-Definux-Emeraude-Admin-Requests-FetchLogs-IFetchLogsQuery-FromDate 'Definux.Emeraude.Admin.Requests.FetchLogs.IFetchLogsQuery.FromDate')
  - [Page](#P-Definux-Emeraude-Admin-Requests-FetchLogs-IFetchLogsQuery-Page 'Definux.Emeraude.Admin.Requests.FetchLogs.IFetchLogsQuery.Page')
  - [SearchQuery](#P-Definux-Emeraude-Admin-Requests-FetchLogs-IFetchLogsQuery-SearchQuery 'Definux.Emeraude.Admin.Requests.FetchLogs.IFetchLogsQuery.SearchQuery')
  - [ToDate](#P-Definux-Emeraude-Admin-Requests-FetchLogs-IFetchLogsQuery-ToDate 'Definux.Emeraude.Admin.Requests.FetchLogs.IFetchLogsQuery.ToDate')
  - [User](#P-Definux-Emeraude-Admin-Requests-FetchLogs-IFetchLogsQuery-User 'Definux.Emeraude.Admin.Requests.FetchLogs.IFetchLogsQuery.User')
- [IGenericEntityRequest\`1](#T-Definux-Emeraude-Admin-Requests-IGenericEntityRequest`1 'Definux.Emeraude.Admin.Requests.IGenericEntityRequest`1')
  - [ParentExpression](#P-Definux-Emeraude-Admin-Requests-IGenericEntityRequest`1-ParentExpression 'Definux.Emeraude.Admin.Requests.IGenericEntityRequest`1.ParentExpression')
- [IGenericNewEntityRequest\`1](#T-Definux-Emeraude-Admin-Requests-IGenericNewEntityRequest`1 'Definux.Emeraude.Admin.Requests.IGenericNewEntityRequest`1')
  - [ParentId](#P-Definux-Emeraude-Admin-Requests-IGenericNewEntityRequest`1-ParentId 'Definux.Emeraude.Admin.Requests.IGenericNewEntityRequest`1.ParentId')
  - [ParentProperty](#P-Definux-Emeraude-Admin-Requests-IGenericNewEntityRequest`1-ParentProperty 'Definux.Emeraude.Admin.Requests.IGenericNewEntityRequest`1.ParentProperty')
- [IGetAllQueryHandler\`3](#T-Definux-Emeraude-Admin-Requests-GetAll-IGetAllQueryHandler`3 'Definux.Emeraude.Admin.Requests.GetAll.IGetAllQueryHandler`3')
- [IGetAllQuery\`2](#T-Definux-Emeraude-Admin-Requests-GetAll-IGetAllQuery`2 'Definux.Emeraude.Admin.Requests.GetAll.IGetAllQuery`2')
  - [OrderBy](#P-Definux-Emeraude-Admin-Requests-GetAll-IGetAllQuery`2-OrderBy 'Definux.Emeraude.Admin.Requests.GetAll.IGetAllQuery`2.OrderBy')
  - [OrderType](#P-Definux-Emeraude-Admin-Requests-GetAll-IGetAllQuery`2-OrderType 'Definux.Emeraude.Admin.Requests.GetAll.IGetAllQuery`2.OrderType')
  - [Page](#P-Definux-Emeraude-Admin-Requests-GetAll-IGetAllQuery`2-Page 'Definux.Emeraude.Admin.Requests.GetAll.IGetAllQuery`2.Page')
  - [SearchQuery](#P-Definux-Emeraude-Admin-Requests-GetAll-IGetAllQuery`2-SearchQuery 'Definux.Emeraude.Admin.Requests.GetAll.IGetAllQuery`2.SearchQuery')
- [IdentityUserInfoAdapter](#T-Definux-Emeraude-Admin-Adapters-IdentityUserInfoAdapter 'Definux.Emeraude.Admin.Adapters.IdentityUserInfoAdapter')
  - [#ctor(currentUserProvider,userClaimsService,logger)](#M-Definux-Emeraude-Admin-Adapters-IdentityUserInfoAdapter-#ctor-Definux-Emeraude-Application-Identity-ICurrentUserProvider,Definux-Emeraude-Application-Identity-IUserClaimsService,Definux-Emeraude-Application-Logger-IEmLogger- 'Definux.Emeraude.Admin.Adapters.IdentityUserInfoAdapter.#ctor(Definux.Emeraude.Application.Identity.ICurrentUserProvider,Definux.Emeraude.Application.Identity.IUserClaimsService,Definux.Emeraude.Application.Logger.IEmLogger)')
  - [GetCurrentUserClaimsAsync()](#M-Definux-Emeraude-Admin-Adapters-IdentityUserInfoAdapter-GetCurrentUserClaimsAsync 'Definux.Emeraude.Admin.Adapters.IdentityUserInfoAdapter.GetCurrentUserClaimsAsync')
  - [GetCurrentUserInfoAsync()](#M-Definux-Emeraude-Admin-Adapters-IdentityUserInfoAdapter-GetCurrentUserInfoAsync 'Definux.Emeraude.Admin.Adapters.IdentityUserInfoAdapter.GetCurrentUserInfoAsync')
- [MaterialDesignIcons](#T-Definux-Emeraude-Admin-Utilities-MaterialDesignIcons 'Definux.Emeraude.Admin.Utilities.MaterialDesignIcons')
- [OrderType](#T-Definux-Emeraude-Admin-Utilities-OrderType 'Definux.Emeraude.Admin.Utilities.OrderType')
  - [Ascending](#F-Definux-Emeraude-Admin-Utilities-OrderType-Ascending 'Definux.Emeraude.Admin.Utilities.OrderType.Ascending')
  - [Descending](#F-Definux-Emeraude-Admin-Utilities-OrderType-Descending 'Definux.Emeraude.Admin.Utilities.OrderType.Descending')
  - [Unspecified](#F-Definux-Emeraude-Admin-Utilities-OrderType-Unspecified 'Definux.Emeraude.Admin.Utilities.OrderType.Unspecified')
- [RootConstraint](#T-Definux-Emeraude-Admin-RouteConstraints-RootConstraint 'Definux.Emeraude.Admin.RouteConstraints.RootConstraint')
  - [RootConstraintKey](#F-Definux-Emeraude-Admin-RouteConstraints-RootConstraint-RootConstraintKey 'Definux.Emeraude.Admin.RouteConstraints.RootConstraint.RootConstraintKey')
  - [RootKey](#F-Definux-Emeraude-Admin-RouteConstraints-RootConstraint-RootKey 'Definux.Emeraude.Admin.RouteConstraints.RootConstraint.RootKey')
  - [RootRouteSlug](#F-Definux-Emeraude-Admin-RouteConstraints-RootConstraint-RootRouteSlug 'Definux.Emeraude.Admin.RouteConstraints.RootConstraint.RootRouteSlug')
  - [Match()](#M-Definux-Emeraude-Admin-RouteConstraints-RootConstraint-Match-Microsoft-AspNetCore-Http-HttpContext,Microsoft-AspNetCore-Routing-IRouter,System-String,Microsoft-AspNetCore-Routing-RouteValueDictionary,Microsoft-AspNetCore-Routing-RouteDirection- 'Definux.Emeraude.Admin.RouteConstraints.RootConstraint.Match(Microsoft.AspNetCore.Http.HttpContext,Microsoft.AspNetCore.Routing.IRouter,System.String,Microsoft.AspNetCore.Routing.RouteValueDictionary,Microsoft.AspNetCore.Routing.RouteDirection)')
- [ServiceCollectionExtensions](#T-Definux-Emeraude-Admin-Extensions-ServiceCollectionExtensions 'Definux.Emeraude.Admin.Extensions.ServiceCollectionExtensions')
  - [AddAdminCookie(builder)](#M-Definux-Emeraude-Admin-Extensions-ServiceCollectionExtensions-AddAdminCookie-Microsoft-AspNetCore-Authentication-AuthenticationBuilder- 'Definux.Emeraude.Admin.Extensions.ServiceCollectionExtensions.AddAdminCookie(Microsoft.AspNetCore.Authentication.AuthenticationBuilder)')
  - [AddAdminMapperConfiguration(configuration)](#M-Definux-Emeraude-Admin-Extensions-ServiceCollectionExtensions-AddAdminMapperConfiguration-AutoMapper-IMapperConfigurationExpression- 'Definux.Emeraude.Admin.Extensions.ServiceCollectionExtensions.AddAdminMapperConfiguration(AutoMapper.IMapperConfigurationExpression)')
  - [AddEmeraudeAdmin(services)](#M-Definux-Emeraude-Admin-Extensions-ServiceCollectionExtensions-AddEmeraudeAdmin-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Definux.Emeraude.Admin.Extensions.ServiceCollectionExtensions.AddEmeraudeAdmin(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [RegisterAdditionalAdminGenericCustomRequests(services)](#M-Definux-Emeraude-Admin-Extensions-ServiceCollectionExtensions-RegisterAdditionalAdminGenericCustomRequests-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Definux.Emeraude.Admin.Extensions.ServiceCollectionExtensions.RegisterAdditionalAdminGenericCustomRequests(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [RegisterAdminEntityControllersRequests(services,assemblies)](#M-Definux-Emeraude-Admin-Extensions-ServiceCollectionExtensions-RegisterAdminEntityControllersRequests-Microsoft-Extensions-DependencyInjection-IServiceCollection,System-Reflection-Assembly[]- 'Definux.Emeraude.Admin.Extensions.ServiceCollectionExtensions.RegisterAdminEntityControllersRequests(Microsoft.Extensions.DependencyInjection.IServiceCollection,System.Reflection.Assembly[])')
- [TableColumnAttribute](#T-Definux-Emeraude-Admin-Attributes-TableColumnAttribute 'Definux.Emeraude.Admin.Attributes.TableColumnAttribute')
  - [#ctor(order,name,uiElementType)](#M-Definux-Emeraude-Admin-Attributes-TableColumnAttribute-#ctor-System-Int32,System-String,System-Type- 'Definux.Emeraude.Admin.Attributes.TableColumnAttribute.#ctor(System.Int32,System.String,System.Type)')
  - [#ctor(order,uiElementType,propertyName)](#M-Definux-Emeraude-Admin-Attributes-TableColumnAttribute-#ctor-System-Int32,System-Type,System-String- 'Definux.Emeraude.Admin.Attributes.TableColumnAttribute.#ctor(System.Int32,System.Type,System.String)')
  - [Name](#P-Definux-Emeraude-Admin-Attributes-TableColumnAttribute-Name 'Definux.Emeraude.Admin.Attributes.TableColumnAttribute.Name')
  - [Order](#P-Definux-Emeraude-Admin-Attributes-TableColumnAttribute-Order 'Definux.Emeraude.Admin.Attributes.TableColumnAttribute.Order')
  - [UIElementType](#P-Definux-Emeraude-Admin-Attributes-TableColumnAttribute-UIElementType 'Definux.Emeraude.Admin.Attributes.TableColumnAttribute.UIElementType')
- [UserViewModel](#T-Definux-Emeraude-Admin-Models-UserViewModel 'Definux.Emeraude.Admin.Models.UserViewModel')
  - [Email](#P-Definux-Emeraude-Admin-Models-UserViewModel-Email 'Definux.Emeraude.Admin.Models.UserViewModel.Email')
  - [EmailConfirmed](#P-Definux-Emeraude-Admin-Models-UserViewModel-EmailConfirmed 'Definux.Emeraude.Admin.Models.UserViewModel.EmailConfirmed')
  - [Id](#P-Definux-Emeraude-Admin-Models-UserViewModel-Id 'Definux.Emeraude.Admin.Models.UserViewModel.Id')
  - [IsLockedOut](#P-Definux-Emeraude-Admin-Models-UserViewModel-IsLockedOut 'Definux.Emeraude.Admin.Models.UserViewModel.IsLockedOut')
  - [Name](#P-Definux-Emeraude-Admin-Models-UserViewModel-Name 'Definux.Emeraude.Admin.Models.UserViewModel.Name')
  - [RegistrationDate](#P-Definux-Emeraude-Admin-Models-UserViewModel-RegistrationDate 'Definux.Emeraude.Admin.Models.UserViewModel.RegistrationDate')
  - [TwoFactorEnabled](#P-Definux-Emeraude-Admin-Models-UserViewModel-TwoFactorEnabled 'Definux.Emeraude.Admin.Models.UserViewModel.TwoFactorEnabled')

<a name='T-Definux-Emeraude-Admin-AdminAssembly'></a>
## AdminAssembly `type`

##### Namespace

Definux.Emeraude.Admin

##### Summary

Assembly provider of the Emeraude administration.

<a name='M-Definux-Emeraude-Admin-AdminAssembly-GetAssembly'></a>
### GetAssembly() `method`

##### Summary

Gets the assembly of the Emeraude administration.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-Mapping-Profiles-AdminAssemblyMappingProfile'></a>
## AdminAssemblyMappingProfile `type`

##### Namespace

Definux.Emeraude.Admin.Mapping.Profiles

##### Summary

Assembly mapping profile for registration of all mappings configurations for administration.

<a name='M-Definux-Emeraude-Admin-Mapping-Profiles-AdminAssemblyMappingProfile-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [AdminAssemblyMappingProfile](#T-Definux-Emeraude-Admin-Mapping-Profiles-AdminAssemblyMappingProfile 'Definux.Emeraude.Admin.Mapping.Profiles.AdminAssemblyMappingProfile') class.

##### Parameters

This constructor has no parameters.

<a name='T-Definux-Emeraude-Admin-Controllers-Mvc-AdminAuthenticationController'></a>
## AdminAuthenticationController `type`

##### Namespace

Definux.Emeraude.Admin.Controllers.Mvc

##### Summary

Controller for administrators authentication.

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminAuthenticationController-#ctor-Definux-Emeraude-Application-Identity-IUserClaimsService,Microsoft-AspNetCore-Hosting-IWebHostEnvironment,Definux-Emeraude-Application-Identity-IUserManager-'></a>
### #ctor(userClaimsService,hostingEnvironment,userManager) `constructor`

##### Summary

Initializes a new instance of the [AdminAuthenticationController](#T-Definux-Emeraude-Admin-Controllers-Mvc-AdminAuthenticationController 'Definux.Emeraude.Admin.Controllers.Mvc.AdminAuthenticationController') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userClaimsService | [Definux.Emeraude.Application.Identity.IUserClaimsService](#T-Definux-Emeraude-Application-Identity-IUserClaimsService 'Definux.Emeraude.Application.Identity.IUserClaimsService') |  |
| hostingEnvironment | [Microsoft.AspNetCore.Hosting.IWebHostEnvironment](#T-Microsoft-AspNetCore-Hosting-IWebHostEnvironment 'Microsoft.AspNetCore.Hosting.IWebHostEnvironment') |  |
| userManager | [Definux.Emeraude.Application.Identity.IUserManager](#T-Definux-Emeraude-Application-Identity-IUserManager 'Definux.Emeraude.Application.Identity.IUserManager') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminAuthenticationController-Login'></a>
### Login() `method`

##### Summary

Login action for GET request.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminAuthenticationController-Login-Definux-Emeraude-Admin-UI-ViewModels-Account-AdminLoginViewModel-'></a>
### Login(model) `method`

##### Summary

Login action for POST request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [Definux.Emeraude.Admin.UI.ViewModels.Account.AdminLoginViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Account-AdminLoginViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Account.AdminLoginViewModel') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminAuthenticationController-LoginWith2Fa'></a>
### LoginWith2Fa() `method`

##### Summary

Login with two factor authentication action for GET request.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminAuthenticationController-LoginWith2Fa-Definux-Emeraude-Admin-UI-ViewModels-Account-AdminLoginWith2FaViewModel-'></a>
### LoginWith2Fa(model) `method`

##### Summary

Login with two factor authentication action for POST request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [Definux.Emeraude.Admin.UI.ViewModels.Account.AdminLoginWith2FaViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Account-AdminLoginWith2FaViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Account.AdminLoginWith2FaViewModel') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminAuthenticationController-Logout'></a>
### Logout() `method`

##### Summary

Logout action.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4'></a>
## AdminChildEntityController\`4 `type`

##### Namespace

Definux.Emeraude.Admin.Controllers.Abstractions

##### Summary

Child admin controller of Entity Admin Controller that provides ready to use CRUD actions for specific entity and its view model with behavior of child controller.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | Entity from the domain model. |
| TEntityViewModel | View Model for selected entity. |
| TParentEntity | Parent entity from the parent controller. |
| TParentController | Parent controller which must be Entity Admin Controller. |

<a name='F-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-BreadcrumbParentTitlePlaceholder'></a>
### BreadcrumbParentTitlePlaceholder `constants`

##### Summary

Breadcrumb parent title placeholder for transferring custom parent title to breadcrumbs list.

<a name='F-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-ParentRouteKeyPropertyName'></a>
### ParentRouteKeyPropertyName `constants`

##### Summary

Parent route key property name. Used for inner processing of the controller.

<a name='P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-ParentController'></a>
### ParentController `property`

##### Summary

Name of the parent controller.

<a name='P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-ParentExpression'></a>
### ParentExpression `property`

##### Summary

Expression of the property from the child entity that referenced the parent entity. Comparison has to be made with [ParentIdentifier](#P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-ParentIdentifier 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminChildEntityController`4.ParentIdentifier').

<a name='P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-ParentIdentifier'></a>
### ParentIdentifier `property`

##### Summary

Identification of the parent entity which will be extracted by the [ParentRouteKey](#P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-ParentRouteKey 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminChildEntityController`4.ParentRouteKey') from the route values.

<a name='P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-ParentProperty'></a>
### ParentProperty `property`

##### Summary

Parent property from the target entity.

<a name='P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-ParentRouteKey'></a>
### ParentRouteKey `property`

##### Summary

Route key that defines the parent identification into the URL.

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-ApplyParentBreadcrumbTitle'></a>
### ApplyParentBreadcrumbTitle() `method`

##### Summary

Apply the title of the parent entity into the breadcrumbs.

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-BuildTableViewActions'></a>
### BuildTableViewActions() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-BuildTableViewNavigationActions'></a>
### BuildTableViewNavigationActions() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-Create'></a>
### Create() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-Create-`1-'></a>
### Create() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-Details-System-Guid-'></a>
### Details() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-Edit-System-Guid-'></a>
### Edit() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-Edit-System-Guid,`1-'></a>
### Edit() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-GetAll-System-Int32,System-String,System-String,System-String-'></a>
### GetAll() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-GetCreateCommand-`1-'></a>
### GetCreateCommand() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-GetDeleteCommand-System-Guid-'></a>
### GetDeleteCommand() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-GetDetailsQuery-System-Guid-'></a>
### GetDetailsQuery() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-GetEditCommand-System-Guid,`1-'></a>
### GetEditCommand() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-GetGetAllQuery-System-Int32,System-String,System-String,System-String-'></a>
### GetGetAllQuery() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-RedirectToAll'></a>
### RedirectToAll() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-RedirectToDetails-System-Guid-'></a>
### RedirectToDetails() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-UpdateControllerRoute'></a>
### UpdateControllerRoute() `method`

##### Summary

Update the controller route with the parent reference.

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminChildEntityController`4-ValidateExistenceAsync'></a>
### ValidateExistenceAsync() `method`

##### Summary

Check the existence of the parent entity of the controller.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController'></a>
## AdminController `type`

##### Namespace

Definux.Emeraude.Admin.Controllers.Abstractions

##### Summary

Abstract admin controller that provides all required services and methods you need in the administration panel.

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [AdminController](#T-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminController') class.

##### Parameters

This constructor has no parameters.

<a name='F-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-AdminAreaName'></a>
### AdminAreaName `constants`

##### Summary

Admin area name.

<a name='P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-ActionName'></a>
### ActionName `property`

##### Summary

Name of the action.

<a name='P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-AreaName'></a>
### AreaName `property`

##### Summary

Name of the area of the controller.

<a name='P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-ControllerName'></a>
### ControllerName `property`

##### Summary

Name of the controller.

<a name='P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-ControllerRoute'></a>
### ControllerRoute `property`

##### Summary

Route of the controller.

<a name='P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-CurrentUserProvider'></a>
### CurrentUserProvider `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-DisableActivityLog'></a>
### DisableActivityLog `property`

##### Summary

Flag that activate and disable activity logging by Emeraude logger.

<a name='P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-HideActivityLogParameters'></a>
### HideActivityLogParameters `property`

##### Summary

Flag that hide or show the request params in activity log.

<a name='P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-Logger'></a>
### Logger `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-Mediator'></a>
### Mediator `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-UrlEncoder'></a>
### UrlEncoder `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-BuildControllerRoute-System-String-'></a>
### BuildControllerRoute(route) `method`

##### Summary

Build controller route for current controller.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| route | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-InitializeNavigationActions-System-Collections-Generic-IEnumerable{Definux-Emeraude-Admin-UI-ViewModels-Layout-NavigationActionViewModel}-'></a>
### InitializeNavigationActions(actions) `method`

##### Summary

Initialize navigation actions for the navbar of the admin panel.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| actions | [System.Collections.Generic.IEnumerable{Definux.Emeraude.Admin.UI.ViewModels.Layout.NavigationActionViewModel}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Definux.Emeraude.Admin.UI.ViewModels.Layout.NavigationActionViewModel}') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-OnActionExecuting-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext-'></a>
### OnActionExecuting() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-ShowComputationNotification-System-Boolean,System-String,System-String-'></a>
### ShowComputationNotification(success,successMessage,errorMessage) `method`

##### Summary

Add notification message based on computation result.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| success | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
| successMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| errorMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-ShowErrorNotification-System-String-'></a>
### ShowErrorNotification(message) `method`

##### Summary

Add error notification message in entities table view.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminController-ShowSuccessNotification-System-String-'></a>
### ShowSuccessNotification(message) `method`

##### Summary

Add success notificaiton message in entities table view.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Admin-Controllers-Mvc-AdminDashboardController'></a>
## AdminDashboardController `type`

##### Namespace

Definux.Emeraude.Admin.Controllers.Mvc

##### Summary

Admin dashboard controller used for index view of the administration.

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminDashboardController-#ctor-Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions}-'></a>
### #ctor(optionsAccessor) `constructor`

##### Summary

Initializes a new instance of the [AdminDashboardController](#T-Definux-Emeraude-Admin-Controllers-Mvc-AdminDashboardController 'Definux.Emeraude.Admin.Controllers.Mvc.AdminDashboardController') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| optionsAccessor | [Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions}](#T-Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions} 'Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions}') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminDashboardController-Index'></a>
### Index() `method`

##### Summary

Index action of the controller.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2'></a>
## AdminEntityController\`2 `type`

##### Namespace

Definux.Emeraude.Admin.Controllers.Abstractions

##### Summary

Admin controller that provides ready to use CRUD actions for specific entity and its view model.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | Entity from the domain model. |
| TEntityViewModel | View Model for selected entity. |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [AdminEntityController\`2](#T-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2 'Definux.Emeraude.Admin.Controllers.Abstractions.AdminEntityController`2') class.

##### Parameters

This constructor has no parameters.

<a name='F-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-BreadcrumbEntityNamePluralPlaceholder'></a>
### BreadcrumbEntityNamePluralPlaceholder `constants`

##### Summary

Breadcrumb plural entity name default placeholder for transferring custom entity plural name to breadcrumbs list.

<a name='F-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-BreadcrumbPageTitlePlaceholder'></a>
### BreadcrumbPageTitlePlaceholder `constants`

##### Summary

Breadcrumb page title default placeholder for transferring custom page title to breadcrumbs list.

<a name='P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-DeleteRedirectUrlFunction'></a>
### DeleteRedirectUrlFunction `property`

##### Summary

Deletion callback on success deletion of the entity.

<a name='P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-EntityMapper'></a>
### EntityMapper `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-EntityName'></a>
### EntityName `property`

##### Summary

Name of the controller entity.

<a name='P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-HasCreate'></a>
### HasCreate `property`

##### Summary

Flag that turn on/off the entity creation provided by the controller.

<a name='P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-HasDelete'></a>
### HasDelete `property`

##### Summary

Flag that turn on/off the entity deletion provided by the controller.

<a name='P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-HasDetails'></a>
### HasDetails `property`

##### Summary

Flag that turn on/off details page provided by the controller.

<a name='P-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-HasEdit'></a>
### HasEdit `property`

##### Summary

Flag that turn on/off the entity modification provided by the controller.

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-BuildTableViewActions'></a>
### BuildTableViewActions() `method`

##### Summary

Build the default table view actions.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-BuildTableViewNavigationActions'></a>
### BuildTableViewNavigationActions() `method`

##### Summary

Build the default table view navigation actions.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-Create'></a>
### Create() `method`

##### Summary

Create action for GET request.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-Create-`1-'></a>
### Create(model) `method`

##### Summary

Create action for POST request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [\`1](#T-`1 '`1') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-CreateEditView-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-IEntityFormViewModel-'></a>
### CreateEditView(model) `method`

##### Summary

Build action result to create/edit view.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.IEntityFormViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-IEntityFormViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.IEntityFormViewModel') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-CreateEntityAsync-`1-'></a>
### CreateEntityAsync(model) `method`

##### Summary

Create action executor.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [\`1](#T-`1 '`1') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-Delete-System-Guid-'></a>
### Delete(id) `method`

##### Summary

Delete action.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-DeleteEntityAsync-System-Guid-'></a>
### DeleteEntityAsync(entityId) `method`

##### Summary

Delete action executor.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entityId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-Details-System-Guid-'></a>
### Details(id) `method`

##### Summary

Details action.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-DetailsView-Definux-Emeraude-Admin-UI-ViewModels-Entity-DetailsCard-EntityDetailsViewModel-'></a>
### DetailsView(model) `method`

##### Summary

Build action result to details view.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [Definux.Emeraude.Admin.UI.ViewModels.Entity.DetailsCard.EntityDetailsViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-DetailsCard-EntityDetailsViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.DetailsCard.EntityDetailsViewModel') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-Edit-System-Guid-'></a>
### Edit(id) `method`

##### Summary

Edit action for GET request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-Edit-System-Guid,`1-'></a>
### Edit(id,model) `method`

##### Summary

Edit action for POST request..

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |
| model | [\`1](#T-`1 '`1') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-GalleryView-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-SelectableGalleryViewModel-'></a>
### GalleryView(model) `method`

##### Summary

Build action result for gallery view.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.SelectableGalleryViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-SelectableGalleryViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.SelectableGalleryViewModel') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-GetAll-System-Int32,System-String,System-String,System-String-'></a>
### GetAll(page,searchQuery,orderBy,orderType) `method`

##### Summary

Get all action.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| page | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| searchQuery | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| orderBy | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| orderType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-GetAllEntitiesPaginatedAsync-System-Int32,System-String,System-String,System-String-'></a>
### GetAllEntitiesPaginatedAsync(page,query,orderBy,orderType) `method`

##### Summary

Get all action executor.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| page | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| query | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| orderBy | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| orderType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-GetAllView-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewViewModel-'></a>
### GetAllView(model) `method`

##### Summary

Build action result to table view.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableViewViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableViewViewModel') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-GetCreateCommand-`1-'></a>
### GetCreateCommand(model) `method`

##### Summary

Method that return the instance of [ICreateCommand\`2](#T-Definux-Emeraude-Admin-Requests-Create-ICreateCommand`2 'Definux.Emeraude.Admin.Requests.Create.ICreateCommand`2') for current entity and view-model.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [\`1](#T-`1 '`1') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-GetDeleteCommand-System-Guid-'></a>
### GetDeleteCommand(entityId) `method`

##### Summary

Method that return the instance of [IDeleteCommand\`1](#T-Definux-Emeraude-Admin-Requests-Delete-IDeleteCommand`1 'Definux.Emeraude.Admin.Requests.Delete.IDeleteCommand`1') for current entity and view-model.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entityId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-GetDetailsQuery-System-Guid-'></a>
### GetDetailsQuery(entityId) `method`

##### Summary

Method that return the instance of [IDetailsQuery\`2](#T-Definux-Emeraude-Admin-Requests-Details-IDetailsQuery`2 'Definux.Emeraude.Admin.Requests.Details.IDetailsQuery`2') for current entity and view-model.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entityId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-GetEditCommand-System-Guid,`1-'></a>
### GetEditCommand(entityId,model) `method`

##### Summary

Method that return the instance of [IEditCommand\`2](#T-Definux-Emeraude-Admin-Requests-Edit-IEditCommand`2 'Definux.Emeraude.Admin.Requests.Edit.IEditCommand`2') for current entity and view-model.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entityId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |
| model | [\`1](#T-`1 '`1') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-GetEntityAsync-System-Guid-'></a>
### GetEntityAsync(entityId) `method`

##### Summary

Details action executor.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entityId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-GetGalleryActionAsync``1-System-Guid,System-Collections-Generic-List{System-String},System-String-'></a>
### GetGalleryActionAsync\`\`1(entityId,picturesUrls,actionName) `method`

##### Summary

Get action used for visualization of image gallery of entity.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entityId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |
| picturesUrls | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') |  |
| actionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the post action used for editing ImageUrl. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntityWithImage | Entity that implements [IEntityWithImage](#T-Definux-Emeraude-Domain-Entities-IEntityWithImage 'Definux.Emeraude.Domain.Entities.IEntityWithImage'). |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-GetGetAllQuery-System-Int32,System-String,System-String,System-String-'></a>
### GetGetAllQuery(page,searchQuery,orderBy,orderType) `method`

##### Summary

Method that return the instance of [IGetAllQuery\`2](#T-Definux-Emeraude-Admin-Requests-GetAll-IGetAllQuery`2 'Definux.Emeraude.Admin.Requests.GetAll.IGetAllQuery`2') for current entity and view-model.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| page | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| searchQuery | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| orderBy | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| orderType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-GetHttpContextPageNumber'></a>
### GetHttpContextPageNumber() `method`

##### Summary

Returns page number from query string of table view.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-GetHttpContextSearchQuery'></a>
### GetHttpContextSearchQuery() `method`

##### Summary

Returns search query from query string of table view.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-GetOrderProperties'></a>
### GetOrderProperties() `method`

##### Summary

Return list of all order properties for current entity.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-ModifyEntityAsync-System-Guid,`1-'></a>
### ModifyEntityAsync(entityId,model) `method`

##### Summary

Edit action executor.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entityId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |
| model | [\`1](#T-`1 '`1') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-OnEntityCreatedAsync-System-Guid-'></a>
### OnEntityCreatedAsync(entityId) `method`

##### Summary

This methods is triggered when an entity is created successfully.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entityId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Entity identifier. |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-OnEntityDeletedAsync-System-Guid-'></a>
### OnEntityDeletedAsync(entityId) `method`

##### Summary

This methods is triggered when an entity is deleted successfully.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entityId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Entity identifier. |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-OnEntityEditedAsync-System-Guid-'></a>
### OnEntityEditedAsync(entityId) `method`

##### Summary

This methods is triggered when an entity is edited successfully.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entityId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Entity identifier. |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-PostGalleryActionAsync``1-System-Guid,Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-SelectableGalleryViewModel-'></a>
### PostGalleryActionAsync\`\`1(entityId,model) `method`

##### Summary

Post action used for editing ImageUrl of entity.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entityId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |
| model | [Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.SelectableGalleryViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-SelectableGalleryViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.SelectableGalleryViewModel') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntityWithImage | Entity that implements [IEntityWithImage](#T-Definux-Emeraude-Domain-Entities-IEntityWithImage 'Definux.Emeraude.Domain.Entities.IEntityWithImage'). |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-RedirectToAll'></a>
### RedirectToAll() `method`

##### Summary

Redirects to table view.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-RedirectToDetails-System-Guid-'></a>
### RedirectToDetails(entityId) `method`

##### Summary

Redirects to details view.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entityId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-SetPartialAboveTheTable-System-String-'></a>
### SetPartialAboveTheTable(partialName) `method`

##### Summary

Set partial above the table of get all view.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| partialName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Abstractions-AdminEntityController`2-SetPartialBelowTheTable-System-String-'></a>
### SetPartialBelowTheTable(partialName) `method`

##### Summary

Set partial below the table of get all view.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| partialName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Admin-Mapping-AdminEntityMapper'></a>
## AdminEntityMapper `type`

##### Namespace

Definux.Emeraude.Admin.Mapping

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-Mapping-AdminEntityMapper-MapToDetailsViewModel``1-``0-'></a>
### MapToDetailsViewModel\`\`1() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Mapping-AdminEntityMapper-MapToFormInputViewModels-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-IEntityFormViewModel-'></a>
### MapToFormInputViewModels() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Mapping-AdminEntityMapper-MapToTableViewModel``1-Definux-Utilities-Objects-PaginatedList{``0},Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel[]-'></a>
### MapToTableViewModel\`\`1() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-Controllers-Mvc-AdminLoggingController'></a>
## AdminLoggingController `type`

##### Namespace

Definux.Emeraude.Admin.Controllers.Mvc

##### Summary

Admin controller that contains system settings actions.

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminLoggingController-#ctor-Definux-Emeraude-Application-Identity-IUserManager-'></a>
### #ctor(userManager) `constructor`

##### Summary

Initializes a new instance of the [AdminLoggingController](#T-Definux-Emeraude-Admin-Controllers-Mvc-AdminLoggingController 'Definux.Emeraude.Admin.Controllers.Mvc.AdminLoggingController') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userManager | [Definux.Emeraude.Application.Identity.IUserManager](#T-Definux-Emeraude-Application-Identity-IUserManager 'Definux.Emeraude.Application.Identity.IUserManager') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminLoggingController-DeleteLog-System-String,System-Int32,System-String-'></a>
### DeleteLog(logType,logId,returnUrl) `method`

##### Summary

Action for delete error log.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| logId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| returnUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminLoggingController-EmailBody-System-Int32-'></a>
### EmailBody(emailLogId) `method`

##### Summary

Returns email body from specified email log.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| emailLogId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminLoggingController-FetchLogs-System-String,System-Int32,System-String,System-Nullable{System-DateTime},System-Nullable{System-DateTime},System-String-'></a>
### FetchLogs(logType,page,searchQuery,fromDate,toDate,user) `method`

##### Summary

Fetch logs action.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| page | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| searchQuery | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| fromDate | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') |  |
| toDate | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') |  |
| user | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Admin-Controllers-Mvc-AdminManageController'></a>
## AdminManageController `type`

##### Namespace

Definux.Emeraude.Admin.Controllers.Mvc

##### Summary

Admin controller for management of current signed user.

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminManageController-#ctor-Microsoft-AspNetCore-Identity-UserManager{Definux-Emeraude-Identity-Entities-User},System-Text-Encodings-Web-UrlEncoder,Definux-Emeraude-Application-Identity-ITwoFactorAuthenticationService,Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions}-'></a>
### #ctor(userManager,urlEncoder,twoFactorAuthenticationService,optionsAccessor) `constructor`

##### Summary

Initializes a new instance of the [AdminManageController](#T-Definux-Emeraude-Admin-Controllers-Mvc-AdminManageController 'Definux.Emeraude.Admin.Controllers.Mvc.AdminManageController') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userManager | [Microsoft.AspNetCore.Identity.UserManager{Definux.Emeraude.Identity.Entities.User}](#T-Microsoft-AspNetCore-Identity-UserManager{Definux-Emeraude-Identity-Entities-User} 'Microsoft.AspNetCore.Identity.UserManager{Definux.Emeraude.Identity.Entities.User}') |  |
| urlEncoder | [System.Text.Encodings.Web.UrlEncoder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encodings.Web.UrlEncoder 'System.Text.Encodings.Web.UrlEncoder') |  |
| twoFactorAuthenticationService | [Definux.Emeraude.Application.Identity.ITwoFactorAuthenticationService](#T-Definux-Emeraude-Application-Identity-ITwoFactorAuthenticationService 'Definux.Emeraude.Application.Identity.ITwoFactorAuthenticationService') |  |
| optionsAccessor | [Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions}](#T-Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions} 'Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions}') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminManageController-ChangeEmail-System-String,System-String-'></a>
### ChangeEmail(email,token) `method`

##### Summary

Change email execution action.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| email | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| token | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminManageController-ChangeEmailRequest'></a>
### ChangeEmailRequest() `method`

##### Summary

Change email action for GET request.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminManageController-ChangeEmailRequest-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminChangeEmailViewModel-'></a>
### ChangeEmailRequest(model) `method`

##### Summary

Change email action for POST request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [Definux.Emeraude.Admin.UI.ViewModels.Manage.AdminChangeEmailViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminChangeEmailViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Manage.AdminChangeEmailViewModel') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminManageController-ChangePassword'></a>
### ChangePassword() `method`

##### Summary

Change password action for GET request.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminManageController-ChangePassword-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminChangePasswordViewModel-'></a>
### ChangePassword(model) `method`

##### Summary

Change password action for POST request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [Definux.Emeraude.Admin.UI.ViewModels.Manage.AdminChangePasswordViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminChangePasswordViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Manage.AdminChangePasswordViewModel') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminManageController-ResetAuthenticator'></a>
### ResetAuthenticator() `method`

##### Summary

Reset two factor authenticator action.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminManageController-TwoFactorAuthentication'></a>
### TwoFactorAuthentication() `method`

##### Summary

Two factor authentication action for GET request.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminManageController-TwoFactorAuthentication-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminTwoFactorAuthenticationViewModel-'></a>
### TwoFactorAuthentication(model) `method`

##### Summary

Two factor authentication action for POST request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [Definux.Emeraude.Admin.UI.ViewModels.Manage.AdminTwoFactorAuthenticationViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Manage-AdminTwoFactorAuthenticationViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Manage.AdminTwoFactorAuthenticationViewModel') |  |

<a name='T-Definux-Emeraude-Admin-Mapping-Profiles-AdminModelsProfile'></a>
## AdminModelsProfile `type`

##### Namespace

Definux.Emeraude.Admin.Mapping.Profiles

##### Summary

Admin view models mapping profile.

<a name='M-Definux-Emeraude-Admin-Mapping-Profiles-AdminModelsProfile-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [AdminModelsProfile](#T-Definux-Emeraude-Admin-Mapping-Profiles-AdminModelsProfile 'Definux.Emeraude.Admin.Mapping.Profiles.AdminModelsProfile') class.

##### Parameters

This constructor has no parameters.

<a name='T-Definux-Emeraude-Admin-Controllers-Mvc-AdminRootsController'></a>
## AdminRootsController `type`

##### Namespace

Definux.Emeraude.Admin.Controllers.Mvc

##### Summary

Admin controller for management of files in the public and private roots.

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminRootsController-#ctor-Definux-Emeraude-Application-Files-ISystemFilesService,Definux-Emeraude-Application-Files-IRootsService-'></a>
### #ctor(systemFilesService,rootsService) `constructor`

##### Summary

Initializes a new instance of the [AdminRootsController](#T-Definux-Emeraude-Admin-Controllers-Mvc-AdminRootsController 'Definux.Emeraude.Admin.Controllers.Mvc.AdminRootsController') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| systemFilesService | [Definux.Emeraude.Application.Files.ISystemFilesService](#T-Definux-Emeraude-Application-Files-ISystemFilesService 'Definux.Emeraude.Application.Files.ISystemFilesService') |  |
| rootsService | [Definux.Emeraude.Application.Files.IRootsService](#T-Definux-Emeraude-Application-Files-IRootsService 'Definux.Emeraude.Application.Files.IRootsService') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminRootsController-CreateFolder-System-String,System-String-'></a>
### CreateFolder(root,folders) `method`

##### Summary

Action for create a folder for GET request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| root | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| folders | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminRootsController-CreateFolder-System-String,Definux-Emeraude-Admin-UI-ViewModels-Roots-RootCreateFolderViewModel-'></a>
### CreateFolder(root,model) `method`

##### Summary

Action for create a folder for POST request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| root | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| model | [Definux.Emeraude.Admin.UI.ViewModels.Roots.RootCreateFolderViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootCreateFolderViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootCreateFolderViewModel') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminRootsController-Root-System-String,System-String-'></a>
### Root(root,folders) `method`

##### Summary

Root action for public and private roots.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| root | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| folders | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminRootsController-RootFile-System-String,System-String-'></a>
### RootFile(root,folders) `method`

##### Summary

Root file action for access a file from the roots.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| root | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| folders | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminRootsController-UploadFile-System-String,Microsoft-AspNetCore-Http-IFormFile,Definux-Emeraude-Admin-UI-ViewModels-Roots-RootUploadFilesViewModel-'></a>
### UploadFile(root,formFile,model) `method`

##### Summary

Upload files action for POST request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| root | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| formFile | [Microsoft.AspNetCore.Http.IFormFile](#T-Microsoft-AspNetCore-Http-IFormFile 'Microsoft.AspNetCore.Http.IFormFile') |  |
| model | [Definux.Emeraude.Admin.UI.ViewModels.Roots.RootUploadFilesViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Roots-RootUploadFilesViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Roots.RootUploadFilesViewModel') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminRootsController-UploadFiles-System-String,System-String-'></a>
### UploadFiles(root,folders) `method`

##### Summary

Upload files action for GET request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| root | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| folders | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Admin-Controllers-Api-AdminUploadApiController'></a>
## AdminUploadApiController `type`

##### Namespace

Definux.Emeraude.Admin.Controllers.Api

##### Summary

Admin upload API controller.

<a name='M-Definux-Emeraude-Admin-Controllers-Api-AdminUploadApiController-#ctor-Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions}-'></a>
### #ctor(emeraudeOptionsAccessor) `constructor`

##### Summary

Initializes a new instance of the [AdminUploadApiController](#T-Definux-Emeraude-Admin-Controllers-Api-AdminUploadApiController 'Definux.Emeraude.Admin.Controllers.Api.AdminUploadApiController') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| emeraudeOptionsAccessor | [Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions}](#T-Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Configuration-Options-EmOptions} 'Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Configuration.Options.EmOptions}') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Api-AdminUploadApiController-File-Microsoft-AspNetCore-Http-IFormFile-'></a>
### File(formFile) `method`

##### Summary

Action for file upload.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| formFile | [Microsoft.AspNetCore.Http.IFormFile](#T-Microsoft-AspNetCore-Http-IFormFile 'Microsoft.AspNetCore.Http.IFormFile') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Api-AdminUploadApiController-Image-Microsoft-AspNetCore-Http-IFormFile-'></a>
### Image(formFile) `method`

##### Summary

Action for image upload.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| formFile | [Microsoft.AspNetCore.Http.IFormFile](#T-Microsoft-AspNetCore-Http-IFormFile 'Microsoft.AspNetCore.Http.IFormFile') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Api-AdminUploadApiController-Video-Microsoft-AspNetCore-Http-IFormFile-'></a>
### Video(formFile) `method`

##### Summary

Action for video upload.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| formFile | [Microsoft.AspNetCore.Http.IFormFile](#T-Microsoft-AspNetCore-Http-IFormFile 'Microsoft.AspNetCore.Http.IFormFile') |  |

<a name='T-Definux-Emeraude-Admin-Controllers-Api-AdminUsersApiController'></a>
## AdminUsersApiController `type`

##### Namespace

Definux.Emeraude.Admin.Controllers.Api

##### Summary

Admin users API controller.

<a name='M-Definux-Emeraude-Admin-Controllers-Api-AdminUsersApiController-Fetch-System-Int32,System-String-'></a>
### Fetch(page,searchQuery) `method`

##### Summary

Fetch users for select purposes.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| page | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| searchQuery | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Admin-Controllers-Mvc-AdminUsersController'></a>
## AdminUsersController `type`

##### Namespace

Definux.Emeraude.Admin.Controllers.Mvc

##### Summary

Admin controller for managing application users into the system.

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminUsersController-#ctor-Definux-Emeraude-Application-Identity-IUserManager,Definux-Emeraude-Application-Identity-IRoleManager,Definux-Emeraude-Application-Identity-IUserTokensService,Definux-Emeraude-Application-Identity-IUserClaimsService-'></a>
### #ctor(userManager,roleManager,userTokensService,userClaimsService) `constructor`

##### Summary

Initializes a new instance of the [AdminUsersController](#T-Definux-Emeraude-Admin-Controllers-Mvc-AdminUsersController 'Definux.Emeraude.Admin.Controllers.Mvc.AdminUsersController') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userManager | [Definux.Emeraude.Application.Identity.IUserManager](#T-Definux-Emeraude-Application-Identity-IUserManager 'Definux.Emeraude.Application.Identity.IUserManager') |  |
| roleManager | [Definux.Emeraude.Application.Identity.IRoleManager](#T-Definux-Emeraude-Application-Identity-IRoleManager 'Definux.Emeraude.Application.Identity.IRoleManager') |  |
| userTokensService | [Definux.Emeraude.Application.Identity.IUserTokensService](#T-Definux-Emeraude-Application-Identity-IUserTokensService 'Definux.Emeraude.Application.Identity.IUserTokensService') |  |
| userClaimsService | [Definux.Emeraude.Application.Identity.IUserClaimsService](#T-Definux-Emeraude-Application-Identity-IUserClaimsService 'Definux.Emeraude.Application.Identity.IUserClaimsService') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminUsersController-BuildTableViewActions'></a>
### BuildTableViewActions() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminUsersController-ImitateUser-System-Guid-'></a>
### ImitateUser(userId) `method`

##### Summary

Imitate user for test purposes.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminUsersController-ResetRefreshToken-System-Guid-'></a>
### ResetRefreshToken(userId) `method`

##### Summary

Reset refresh token action.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminUsersController-Roles-System-Guid-'></a>
### Roles(userId) `method`

##### Summary

Roles action for GET request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |

<a name='M-Definux-Emeraude-Admin-Controllers-Mvc-AdminUsersController-Roles-System-Guid,Definux-Emeraude-Admin-UI-ViewModels-Users-RolesViewModel-'></a>
### Roles(userId,model) `method`

##### Summary

Roles action for POST request.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |
| model | [Definux.Emeraude.Admin.UI.ViewModels.Users.RolesViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Users-RolesViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Users.RolesViewModel') |  |

<a name='T-Definux-Emeraude-Admin-Extensions-ApplicationBuilderExtensions'></a>
## ApplicationBuilderExtensions `type`

##### Namespace

Definux.Emeraude.Admin.Extensions

##### Summary

Extensions for [IApplicationBuilder](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder 'Microsoft.AspNetCore.Builder.IApplicationBuilder').

<a name='M-Definux-Emeraude-Admin-Extensions-ApplicationBuilderExtensions-UseEmeraudeAdminSwagger-Microsoft-AspNetCore-Builder-IApplicationBuilder-'></a>
### UseEmeraudeAdminSwagger(app) `method`

##### Summary

Register Swagger middleware.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| app | [Microsoft.AspNetCore.Builder.IApplicationBuilder](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder 'Microsoft.AspNetCore.Builder.IApplicationBuilder') |  |

<a name='T-Definux-Emeraude-Admin-Extensions-ApplicationPartManagerExtensions'></a>
## ApplicationPartManagerExtensions `type`

##### Namespace

Definux.Emeraude.Admin.Extensions

##### Summary

Extensions for [ApplicationPartManager](#T-Microsoft-AspNetCore-Mvc-ApplicationParts-ApplicationPartManager 'Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager').

<a name='M-Definux-Emeraude-Admin-Extensions-ApplicationPartManagerExtensions-AddAdminUIApplicationParts-Microsoft-AspNetCore-Mvc-ApplicationParts-ApplicationPartManager-'></a>
### AddAdminUIApplicationParts(applicationPartManager) `method`

##### Summary

Add Admin UI application parts.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| applicationPartManager | [Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager](#T-Microsoft-AspNetCore-Mvc-ApplicationParts-ApplicationPartManager 'Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager') |  |

<a name='T-Definux-Emeraude-Admin-Requests-ApplyImage-ApplyImageCommandHandler`1'></a>
## ApplyImageCommandHandler\`1 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.ApplyImage

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-Requests-ApplyImage-ApplyImageCommandHandler`1-#ctor-Definux-Emeraude-Application-Persistence-IEmContext,Definux-Emeraude-Application-Logger-IEmLogger-'></a>
### #ctor(context,logger) `constructor`

##### Summary

Initializes a new instance of the [ApplyImageCommandHandler\`1](#T-Definux-Emeraude-Admin-Requests-ApplyImage-ApplyImageCommandHandler`1 'Definux.Emeraude.Admin.Requests.ApplyImage.ApplyImageCommandHandler`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Definux.Emeraude.Application.Persistence.IEmContext](#T-Definux-Emeraude-Application-Persistence-IEmContext 'Definux.Emeraude.Application.Persistence.IEmContext') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |

<a name='M-Definux-Emeraude-Admin-Requests-ApplyImage-ApplyImageCommandHandler`1-Handle-Definux-Emeraude-Admin-Requests-ApplyImage-ApplyImageCommand{`0},System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-Requests-ApplyImage-ApplyImageCommand`1'></a>
## ApplyImageCommand\`1 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.ApplyImage

##### Summary

Command for appling an image to entity with image.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | Target entity. |

<a name='M-Definux-Emeraude-Admin-Requests-ApplyImage-ApplyImageCommand`1-#ctor-System-Guid,System-String-'></a>
### #ctor(entityId,imageUrl) `constructor`

##### Summary

Initializes a new instance of the [ApplyImageCommand\`1](#T-Definux-Emeraude-Admin-Requests-ApplyImage-ApplyImageCommand`1 'Definux.Emeraude.Admin.Requests.ApplyImage.ApplyImageCommand`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entityId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |
| imageUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='P-Definux-Emeraude-Admin-Requests-ApplyImage-ApplyImageCommand`1-EntityId'></a>
### EntityId `property`

##### Summary

Entity id.

<a name='P-Definux-Emeraude-Admin-Requests-ApplyImage-ApplyImageCommand`1-ImageUrl'></a>
### ImageUrl `property`

##### Summary

Image URL.

<a name='T-Definux-Emeraude-Admin-Requests-AssignRolesToUser-AssignRolesToUserCommand'></a>
## AssignRolesToUserCommand `type`

##### Namespace

Definux.Emeraude.Admin.Requests.AssignRolesToUser

##### Summary

Command for assigning roles to a selected user.

<a name='M-Definux-Emeraude-Admin-Requests-AssignRolesToUser-AssignRolesToUserCommand-#ctor-System-Guid,System-Collections-Generic-List{System-Guid}-'></a>
### #ctor(userId,rolesIds) `constructor`

##### Summary

Initializes a new instance of the [AssignRolesToUserCommand](#T-Definux-Emeraude-Admin-Requests-AssignRolesToUser-AssignRolesToUserCommand 'Definux.Emeraude.Admin.Requests.AssignRolesToUser.AssignRolesToUserCommand') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |
| rolesIds | [System.Collections.Generic.List{System.Guid}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Guid}') |  |

<a name='P-Definux-Emeraude-Admin-Requests-AssignRolesToUser-AssignRolesToUserCommand-RolesIds'></a>
### RolesIds `property`

##### Summary

Roles for assignment.

<a name='P-Definux-Emeraude-Admin-Requests-AssignRolesToUser-AssignRolesToUserCommand-UserId'></a>
### UserId `property`

##### Summary

Target user id.

<a name='T-Definux-Emeraude-Admin-Requests-AssignRolesToUser-AssignRolesToUserCommand-AssignRolesToUserCommandHandler'></a>
## AssignRolesToUserCommandHandler `type`

##### Namespace

Definux.Emeraude.Admin.Requests.AssignRolesToUser.AssignRolesToUserCommand

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-Requests-AssignRolesToUser-AssignRolesToUserCommand-AssignRolesToUserCommandHandler-#ctor-Definux-Emeraude-Application-Identity-IRoleManager,Definux-Emeraude-Application-Identity-IUserManager-'></a>
### #ctor(roleManager,userManager) `constructor`

##### Summary

Initializes a new instance of the [AssignRolesToUserCommandHandler](#T-Definux-Emeraude-Admin-Requests-AssignRolesToUser-AssignRolesToUserCommand-AssignRolesToUserCommandHandler 'Definux.Emeraude.Admin.Requests.AssignRolesToUser.AssignRolesToUserCommand.AssignRolesToUserCommandHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| roleManager | [Definux.Emeraude.Application.Identity.IRoleManager](#T-Definux-Emeraude-Application-Identity-IRoleManager 'Definux.Emeraude.Application.Identity.IRoleManager') |  |
| userManager | [Definux.Emeraude.Application.Identity.IUserManager](#T-Definux-Emeraude-Application-Identity-IUserManager 'Definux.Emeraude.Application.Identity.IUserManager') |  |

<a name='M-Definux-Emeraude-Admin-Requests-AssignRolesToUser-AssignRolesToUserCommand-AssignRolesToUserCommandHandler-Handle-Definux-Emeraude-Admin-Requests-AssignRolesToUser-AssignRolesToUserCommand,System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-Extensions-AuthorizationOptionsExtensions'></a>
## AuthorizationOptionsExtensions `type`

##### Namespace

Definux.Emeraude.Admin.Extensions

##### Summary

Extensions for [AuthorizationOptions](#T-Microsoft-AspNetCore-Authorization-AuthorizationOptions 'Microsoft.AspNetCore.Authorization.AuthorizationOptions').

<a name='M-Definux-Emeraude-Admin-Extensions-AuthorizationOptionsExtensions-ApplyEmeraudeAdminAuthorizationPolicies-Microsoft-AspNetCore-Authorization-AuthorizationOptions-'></a>
### ApplyEmeraudeAdminAuthorizationPolicies(options) `method`

##### Summary

Apply authorization policies to administration.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [Microsoft.AspNetCore.Authorization.AuthorizationOptions](#T-Microsoft-AspNetCore-Authorization-AuthorizationOptions 'Microsoft.AspNetCore.Authorization.AuthorizationOptions') |  |

<a name='T-Definux-Emeraude-Admin-Attributes-BreadcrumbAttribute'></a>
## BreadcrumbAttribute `type`

##### Namespace

Definux.Emeraude.Admin.Attributes

##### Summary

Attribute that add filled data as a breadcrumb item.

<a name='M-Definux-Emeraude-Admin-Attributes-BreadcrumbAttribute-#ctor-System-String,System-Boolean,System-Int32,System-String,System-String,System-String,System-String-'></a>
### #ctor(title,active,order,action,controller,parameterName,parameterValue) `constructor`

##### Summary

Initializes a new instance of the [BreadcrumbAttribute](#T-Definux-Emeraude-Admin-Attributes-BreadcrumbAttribute 'Definux.Emeraude.Admin.Attributes.BreadcrumbAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| title | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Title text in the breadcrumb. Use "[SomeKey]" to add custom title based on the route. The key must be part of the ViewData collection. |
| active | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
| order | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| action | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| controller | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| parameterName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| parameterValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='P-Definux-Emeraude-Admin-Attributes-BreadcrumbAttribute-ParentRouteKey'></a>
### ParentRouteKey `property`

##### Summary

Route key that represent the parent reference.

<a name='P-Definux-Emeraude-Admin-Attributes-BreadcrumbAttribute-UseParentController'></a>
### UseParentController `property`

##### Summary

To use this property the caller controller must inherit [IChildController](#T-Definux-Emeraude-Presentation-Controllers-IChildController 'Definux.Emeraude.Presentation.Controllers.IChildController').

<a name='M-Definux-Emeraude-Admin-Attributes-BreadcrumbAttribute-OnActionExecuting-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext-'></a>
### OnActionExecuting() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-Requests-Create-CreateCommandHandler`2'></a>
## CreateCommandHandler\`2 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.Create

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-Requests-Create-CreateCommandHandler`2-#ctor-Definux-Emeraude-Application-Persistence-IEmContext,AutoMapper-IMapper,Definux-Emeraude-Application-Logger-IEmLogger-'></a>
### #ctor(context,mapper,logger) `constructor`

##### Summary

Initializes a new instance of the [CreateCommandHandler\`2](#T-Definux-Emeraude-Admin-Requests-Create-CreateCommandHandler`2 'Definux.Emeraude.Admin.Requests.Create.CreateCommandHandler`2') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Definux.Emeraude.Application.Persistence.IEmContext](#T-Definux-Emeraude-Application-Persistence-IEmContext 'Definux.Emeraude.Application.Persistence.IEmContext') |  |
| mapper | [AutoMapper.IMapper](#T-AutoMapper-IMapper 'AutoMapper.IMapper') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |

<a name='M-Definux-Emeraude-Admin-Requests-Create-CreateCommandHandler`2-Handle-Definux-Emeraude-Admin-Requests-Create-CreateCommand{`0,`1},System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-Requests-Create-CreateCommand`2'></a>
## CreateCommand\`2 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.Create

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-Requests-Create-CreateCommand`2-#ctor-`1-'></a>
### #ctor(model) `constructor`

##### Summary

Initializes a new instance of the [CreateCommand\`2](#T-Definux-Emeraude-Admin-Requests-Create-CreateCommand`2 'Definux.Emeraude.Admin.Requests.Create.CreateCommand`2') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [\`1](#T-`1 '`1') |  |

<a name='M-Definux-Emeraude-Admin-Requests-Create-CreateCommand`2-#ctor-`1,System-String,System-Nullable{System-Guid}-'></a>
### #ctor(model,parentProperty,parentId) `constructor`

##### Summary

Initializes a new instance of the [CreateCommand\`2](#T-Definux-Emeraude-Admin-Requests-Create-CreateCommand`2 'Definux.Emeraude.Admin.Requests.Create.CreateCommand`2') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [\`1](#T-`1 '`1') |  |
| parentProperty | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| parentId | [System.Nullable{System.Guid}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Guid}') |  |

<a name='P-Definux-Emeraude-Admin-Requests-Create-CreateCommand`2-Model'></a>
### Model `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Admin-Utilities-DefaultValues'></a>
## DefaultValues `type`

##### Namespace

Definux.Emeraude.Admin.Utilities

##### Summary

Default values for the context of administration.

<a name='F-Definux-Emeraude-Admin-Utilities-DefaultValues-OrderTypes'></a>
### OrderTypes `constants`

##### Summary

Order types of properties.

<a name='T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteActivityLogCommand'></a>
## DeleteActivityLogCommand `type`

##### Namespace

Definux.Emeraude.Admin.Requests.DeleteLog

##### Summary

Deletes activity log from the logger context.

<a name='M-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteActivityLogCommand-#ctor-System-Int32-'></a>
### #ctor(logId) `constructor`

##### Summary

Initializes a new instance of the [DeleteActivityLogCommand](#T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteActivityLogCommand 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteActivityLogCommand') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteActivityLogCommand-DeleteActivityLogCommandHandler'></a>
## DeleteActivityLogCommandHandler `type`

##### Namespace

Definux.Emeraude.Admin.Requests.DeleteLog.DeleteActivityLogCommand

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteActivityLogCommand-DeleteActivityLogCommandHandler-#ctor-Definux-Emeraude-Application-Logger-ILoggerContext-'></a>
### #ctor(context) `constructor`

##### Summary

Initializes a new instance of the [DeleteActivityLogCommandHandler](#T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteActivityLogCommand-DeleteActivityLogCommandHandler 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteActivityLogCommand.DeleteActivityLogCommandHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Definux.Emeraude.Application.Logger.ILoggerContext](#T-Definux-Emeraude-Application-Logger-ILoggerContext 'Definux.Emeraude.Application.Logger.ILoggerContext') |  |

<a name='T-Definux-Emeraude-Admin-Requests-Delete-DeleteCommandHandler`1'></a>
## DeleteCommandHandler\`1 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.Delete

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-Requests-Delete-DeleteCommandHandler`1-#ctor-Definux-Emeraude-Application-Persistence-IEmContext,AutoMapper-IMapper,Definux-Emeraude-Application-Logger-IEmLogger-'></a>
### #ctor(context,mapper,logger) `constructor`

##### Summary

Initializes a new instance of the [DeleteCommandHandler\`1](#T-Definux-Emeraude-Admin-Requests-Delete-DeleteCommandHandler`1 'Definux.Emeraude.Admin.Requests.Delete.DeleteCommandHandler`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Definux.Emeraude.Application.Persistence.IEmContext](#T-Definux-Emeraude-Application-Persistence-IEmContext 'Definux.Emeraude.Application.Persistence.IEmContext') |  |
| mapper | [AutoMapper.IMapper](#T-AutoMapper-IMapper 'AutoMapper.IMapper') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |

<a name='M-Definux-Emeraude-Admin-Requests-Delete-DeleteCommandHandler`1-Handle-Definux-Emeraude-Admin-Requests-Delete-DeleteCommand{`0},System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-Requests-Delete-DeleteCommand`1'></a>
## DeleteCommand\`1 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.Delete

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-Requests-Delete-DeleteCommand`1-#ctor-System-Guid-'></a>
### #ctor(entityId) `constructor`

##### Summary

Initializes a new instance of the [DeleteCommand\`1](#T-Definux-Emeraude-Admin-Requests-Delete-DeleteCommand`1 'Definux.Emeraude.Admin.Requests.Delete.DeleteCommand`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entityId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |

<a name='M-Definux-Emeraude-Admin-Requests-Delete-DeleteCommand`1-#ctor-System-Guid,System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}}-'></a>
### #ctor(entityId,parentExpression) `constructor`

##### Summary

Initializes a new instance of the [DeleteCommand\`1](#T-Definux-Emeraude-Admin-Requests-Delete-DeleteCommand`1 'Definux.Emeraude.Admin.Requests.Delete.DeleteCommand`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entityId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |
| parentExpression | [System.Linq.Expressions.Expression{System.Func{\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}}') |  |

<a name='P-Definux-Emeraude-Admin-Requests-Delete-DeleteCommand`1-EntityId'></a>
### EntityId `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteEmailLogCommand'></a>
## DeleteEmailLogCommand `type`

##### Namespace

Definux.Emeraude.Admin.Requests.DeleteLog

##### Summary

Deletes email log from the logger context.

<a name='M-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteEmailLogCommand-#ctor-System-Int32-'></a>
### #ctor(logId) `constructor`

##### Summary

Initializes a new instance of the [DeleteEmailLogCommand](#T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteEmailLogCommand 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteEmailLogCommand') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteEmailLogCommand-DeleteEmailLogCommandHandler'></a>
## DeleteEmailLogCommandHandler `type`

##### Namespace

Definux.Emeraude.Admin.Requests.DeleteLog.DeleteEmailLogCommand

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteEmailLogCommand-DeleteEmailLogCommandHandler-#ctor-Definux-Emeraude-Application-Logger-ILoggerContext-'></a>
### #ctor(context) `constructor`

##### Summary

Initializes a new instance of the [DeleteEmailLogCommandHandler](#T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteEmailLogCommand-DeleteEmailLogCommandHandler 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteEmailLogCommand.DeleteEmailLogCommandHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Definux.Emeraude.Application.Logger.ILoggerContext](#T-Definux-Emeraude-Application-Logger-ILoggerContext 'Definux.Emeraude.Application.Logger.ILoggerContext') |  |

<a name='T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteErrorLogCommand'></a>
## DeleteErrorLogCommand `type`

##### Namespace

Definux.Emeraude.Admin.Requests.DeleteLog

##### Summary

Deletes error log from the logger context.

<a name='M-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteErrorLogCommand-#ctor-System-Int32-'></a>
### #ctor(logId) `constructor`

##### Summary

Initializes a new instance of the [DeleteErrorLogCommand](#T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteErrorLogCommand 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteErrorLogCommand') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteErrorLogCommand-DeleteErrorLogCommandHandler'></a>
## DeleteErrorLogCommandHandler `type`

##### Namespace

Definux.Emeraude.Admin.Requests.DeleteLog.DeleteErrorLogCommand

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteErrorLogCommand-DeleteErrorLogCommandHandler-#ctor-Definux-Emeraude-Application-Logger-ILoggerContext-'></a>
### #ctor(context) `constructor`

##### Summary

Initializes a new instance of the [DeleteErrorLogCommandHandler](#T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteErrorLogCommand-DeleteErrorLogCommandHandler 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteErrorLogCommand.DeleteErrorLogCommandHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Definux.Emeraude.Application.Logger.ILoggerContext](#T-Definux-Emeraude-Application-Logger-ILoggerContext 'Definux.Emeraude.Application.Logger.ILoggerContext') |  |

<a name='T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteLogCommandHandler`2'></a>
## DeleteLogCommandHandler\`2 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.DeleteLog

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteLogCommandHandler`2-#ctor-Definux-Emeraude-Application-Logger-ILoggerContext-'></a>
### #ctor(context) `constructor`

##### Summary

Initializes a new instance of the [DeleteLogCommandHandler\`2](#T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteLogCommandHandler`2 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteLogCommandHandler`2') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Definux.Emeraude.Application.Logger.ILoggerContext](#T-Definux-Emeraude-Application-Logger-ILoggerContext 'Definux.Emeraude.Application.Logger.ILoggerContext') |  |

<a name='M-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteLogCommandHandler`2-Handle-`0,System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteLogCommand`1'></a>
## DeleteLogCommand\`1 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.DeleteLog

##### Summary

Command that delete a specified log.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TLoggerEntity | Logger entity type. |

<a name='M-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteLogCommand`1-#ctor-System-Int32-'></a>
### #ctor(logId) `constructor`

##### Summary

Initializes a new instance of the [DeleteLogCommand\`1](#T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteLogCommand`1 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteLogCommand`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='P-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteLogCommand`1-LogId'></a>
### LogId `property`

##### Summary

Id of the log.

<a name='P-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteLogCommand`1-LogType'></a>
### LogType `property`

##### Summary

Type of the log.

<a name='T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteTempFileLogCommand'></a>
## DeleteTempFileLogCommand `type`

##### Namespace

Definux.Emeraude.Admin.Requests.DeleteLog

##### Summary

Deletes temp file log from the logger context.

<a name='M-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteTempFileLogCommand-#ctor-System-Int32-'></a>
### #ctor(logId) `constructor`

##### Summary

Initializes a new instance of the [DeleteTempFileLogCommand](#T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteTempFileLogCommand 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteTempFileLogCommand') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteTempFileLogCommand-DeleteTempFileLogCommandHandler'></a>
## DeleteTempFileLogCommandHandler `type`

##### Namespace

Definux.Emeraude.Admin.Requests.DeleteLog.DeleteTempFileLogCommand

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteTempFileLogCommand-DeleteTempFileLogCommandHandler-#ctor-Definux-Emeraude-Application-Logger-ILoggerContext-'></a>
### #ctor(context) `constructor`

##### Summary

Initializes a new instance of the [DeleteTempFileLogCommandHandler](#T-Definux-Emeraude-Admin-Requests-DeleteLog-DeleteTempFileLogCommand-DeleteTempFileLogCommandHandler 'Definux.Emeraude.Admin.Requests.DeleteLog.DeleteTempFileLogCommand.DeleteTempFileLogCommandHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Definux.Emeraude.Application.Logger.ILoggerContext](#T-Definux-Emeraude-Application-Logger-ILoggerContext 'Definux.Emeraude.Application.Logger.ILoggerContext') |  |

<a name='T-Definux-Emeraude-Admin-Attributes-DetailsFieldAttribute'></a>
## DetailsFieldAttribute `type`

##### Namespace

Definux.Emeraude.Admin.Attributes

##### Summary

Attribute used for rendering the details card of the details action of admin entity controller.

<a name='M-Definux-Emeraude-Admin-Attributes-DetailsFieldAttribute-#ctor-System-Int32,System-String,System-Type-'></a>
### #ctor(order,title,uiElementType) `constructor`

##### Summary

Initializes a new instance of the [DetailsFieldAttribute](#T-Definux-Emeraude-Admin-Attributes-DetailsFieldAttribute 'Definux.Emeraude.Admin.Attributes.DetailsFieldAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| order | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| title | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| uiElementType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |

<a name='M-Definux-Emeraude-Admin-Attributes-DetailsFieldAttribute-#ctor-System-Int32,System-Type,System-String-'></a>
### #ctor(order,uiElementType,propertyName) `constructor`

##### Summary

Initializes a new instance of the [DetailsFieldAttribute](#T-Definux-Emeraude-Admin-Attributes-DetailsFieldAttribute 'Definux.Emeraude.Admin.Attributes.DetailsFieldAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| order | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| uiElementType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='P-Definux-Emeraude-Admin-Attributes-DetailsFieldAttribute-Order'></a>
### Order `property`

##### Summary

Order of the rendered item.

<a name='P-Definux-Emeraude-Admin-Attributes-DetailsFieldAttribute-Title'></a>
### Title `property`

##### Summary

Label of the rendered item.

<a name='P-Definux-Emeraude-Admin-Attributes-DetailsFieldAttribute-UIElementType'></a>
### UIElementType `property`

##### Summary

UI element type that implemented [IDetailsFieldElement](#T-Definux-Emeraude-Admin-UI-UIElements-Details-IDetailsFieldElement 'Definux.Emeraude.Admin.UI.UIElements.Details.IDetailsFieldElement').

<a name='T-Definux-Emeraude-Admin-Requests-Details-DetailsQueryHandler`2'></a>
## DetailsQueryHandler\`2 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.Details

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-Requests-Details-DetailsQueryHandler`2-#ctor-Definux-Emeraude-Application-Persistence-IEmContext,AutoMapper-IMapper,Definux-Emeraude-Application-Logger-IEmLogger-'></a>
### #ctor(context,mapper,logger) `constructor`

##### Summary

Initializes a new instance of the [DetailsQueryHandler\`2](#T-Definux-Emeraude-Admin-Requests-Details-DetailsQueryHandler`2 'Definux.Emeraude.Admin.Requests.Details.DetailsQueryHandler`2') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Definux.Emeraude.Application.Persistence.IEmContext](#T-Definux-Emeraude-Application-Persistence-IEmContext 'Definux.Emeraude.Application.Persistence.IEmContext') |  |
| mapper | [AutoMapper.IMapper](#T-AutoMapper-IMapper 'AutoMapper.IMapper') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |

<a name='M-Definux-Emeraude-Admin-Requests-Details-DetailsQueryHandler`2-Handle-Definux-Emeraude-Admin-Requests-Details-DetailsQuery{`0,`1},System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-Requests-Details-DetailsQuery`2'></a>
## DetailsQuery\`2 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.Details

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-Requests-Details-DetailsQuery`2-#ctor-System-Guid-'></a>
### #ctor(entityId) `constructor`

##### Summary

Initializes a new instance of the [DetailsQuery\`2](#T-Definux-Emeraude-Admin-Requests-Details-DetailsQuery`2 'Definux.Emeraude.Admin.Requests.Details.DetailsQuery`2') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entityId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |

<a name='M-Definux-Emeraude-Admin-Requests-Details-DetailsQuery`2-#ctor-System-Guid,System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}}-'></a>
### #ctor(entityId,parentExpression) `constructor`

##### Summary

Initializes a new instance of the [DetailsQuery\`2](#T-Definux-Emeraude-Admin-Requests-Details-DetailsQuery`2 'Definux.Emeraude.Admin.Requests.Details.DetailsQuery`2') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entityId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |
| parentExpression | [System.Linq.Expressions.Expression{System.Func{\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}}') |  |

<a name='P-Definux-Emeraude-Admin-Requests-Details-DetailsQuery`2-EntityId'></a>
### EntityId `property`

##### Summary

Id of the entity.

<a name='T-Definux-Emeraude-Admin-Requests-Edit-EditCommandHandler`2'></a>
## EditCommandHandler\`2 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.Edit

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-Requests-Edit-EditCommandHandler`2-#ctor-Definux-Emeraude-Application-Persistence-IEmContext,AutoMapper-IMapper,Definux-Emeraude-Application-Logger-IEmLogger-'></a>
### #ctor(context,mapper,logger) `constructor`

##### Summary

Initializes a new instance of the [EditCommandHandler\`2](#T-Definux-Emeraude-Admin-Requests-Edit-EditCommandHandler`2 'Definux.Emeraude.Admin.Requests.Edit.EditCommandHandler`2') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Definux.Emeraude.Application.Persistence.IEmContext](#T-Definux-Emeraude-Application-Persistence-IEmContext 'Definux.Emeraude.Application.Persistence.IEmContext') |  |
| mapper | [AutoMapper.IMapper](#T-AutoMapper-IMapper 'AutoMapper.IMapper') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |

<a name='M-Definux-Emeraude-Admin-Requests-Edit-EditCommandHandler`2-Handle-Definux-Emeraude-Admin-Requests-Edit-EditCommand{`0,`1},System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-Requests-Edit-EditCommand`2'></a>
## EditCommand\`2 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.Edit

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-Requests-Edit-EditCommand`2-#ctor-System-Guid,`1-'></a>
### #ctor(entityId,model) `constructor`

##### Summary

Initializes a new instance of the [EditCommand\`2](#T-Definux-Emeraude-Admin-Requests-Edit-EditCommand`2 'Definux.Emeraude.Admin.Requests.Edit.EditCommand`2') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entityId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |
| model | [\`1](#T-`1 '`1') |  |

<a name='M-Definux-Emeraude-Admin-Requests-Edit-EditCommand`2-#ctor-System-Guid,`1,System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}}-'></a>
### #ctor(entityId,model,parentExpression) `constructor`

##### Summary

Initializes a new instance of the [EditCommand\`2](#T-Definux-Emeraude-Admin-Requests-Edit-EditCommand`2 'Definux.Emeraude.Admin.Requests.Edit.EditCommand`2') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entityId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |
| model | [\`1](#T-`1 '`1') |  |
| parentExpression | [System.Linq.Expressions.Expression{System.Func{\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}}') |  |

<a name='P-Definux-Emeraude-Admin-Requests-Edit-EditCommand`2-EntityId'></a>
### EntityId `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Admin-Requests-Edit-EditCommand`2-Model'></a>
### Model `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Admin-Adapters-EmContextAdapter'></a>
## EmContextAdapter `type`

##### Namespace

Definux.Emeraude.Admin.Adapters

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-Adapters-EmContextAdapter-#ctor-Definux-Emeraude-Application-Persistence-IEmContext-'></a>
### #ctor(context) `constructor`

##### Summary

Initializes a new instance of the [EmContextAdapter](#T-Definux-Emeraude-Admin-Adapters-EmContextAdapter 'Definux.Emeraude.Admin.Adapters.EmContextAdapter') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Definux.Emeraude.Application.Persistence.IEmContext](#T-Definux-Emeraude-Application-Persistence-IEmContext 'Definux.Emeraude.Application.Persistence.IEmContext') |  |

<a name='M-Definux-Emeraude-Admin-Adapters-EmContextAdapter-GetAllEntitiesByPropertyName-System-String-'></a>
### GetAllEntitiesByPropertyName() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Adapters-EmContextAdapter-GetAllEntitiesByType-System-Type-'></a>
### GetAllEntitiesByType() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-Attributes-EntityIdentifierAttribute'></a>
## EntityIdentifierAttribute `type`

##### Namespace

Definux.Emeraude.Admin.Attributes

##### Summary

Attribute that indicates that the property is identifier for the specified object.

<a name='T-Definux-Emeraude-Admin-Models-EntitySelectModel'></a>
## EntitySelectModel `type`

##### Namespace

Definux.Emeraude.Admin.Models

##### Summary

Entity select model used for selectable data extraction from API requests.

<a name='P-Definux-Emeraude-Admin-Models-EntitySelectModel-Id'></a>
### Id `property`

##### Summary

Identifier of data item.

<a name='P-Definux-Emeraude-Admin-Models-EntitySelectModel-Text'></a>
### Text `property`

##### Summary

Text visualization of data item.

<a name='T-Definux-Emeraude-Admin-Requests-Exists-ExistsQueryHandler`1'></a>
## ExistsQueryHandler\`1 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.Exists

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-Requests-Exists-ExistsQueryHandler`1-#ctor-Definux-Emeraude-Application-Persistence-IEmContext,Definux-Emeraude-Application-Logger-IEmLogger-'></a>
### #ctor(context,logger) `constructor`

##### Summary

Initializes a new instance of the [ExistsQueryHandler\`1](#T-Definux-Emeraude-Admin-Requests-Exists-ExistsQueryHandler`1 'Definux.Emeraude.Admin.Requests.Exists.ExistsQueryHandler`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Definux.Emeraude.Application.Persistence.IEmContext](#T-Definux-Emeraude-Application-Persistence-IEmContext 'Definux.Emeraude.Application.Persistence.IEmContext') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |

<a name='M-Definux-Emeraude-Admin-Requests-Exists-ExistsQueryHandler`1-Handle-Definux-Emeraude-Admin-Requests-Exists-ExistsQuery{`0},System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-Requests-Exists-ExistsQuery`1'></a>
## ExistsQuery\`1 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.Exists

##### Summary

Get whether an entity exist or not query..

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | Target entity. |

<a name='M-Definux-Emeraude-Admin-Requests-Exists-ExistsQuery`1-#ctor-System-Guid-'></a>
### #ctor(entityId) `constructor`

##### Summary

Initializes a new instance of the [ExistsQuery\`1](#T-Definux-Emeraude-Admin-Requests-Exists-ExistsQuery`1 'Definux.Emeraude.Admin.Requests.Exists.ExistsQuery`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entityId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |

<a name='P-Definux-Emeraude-Admin-Requests-Exists-ExistsQuery`1-EntityId'></a>
### EntityId `property`

##### Summary

Id of the entity.

<a name='T-Definux-Emeraude-Admin-Utilities-ExpressionBuilders'></a>
## ExpressionBuilders `type`

##### Namespace

Definux.Emeraude.Admin.Utilities

##### Summary

Expression builders that helps for extraction expressions from simple arguments.

<a name='M-Definux-Emeraude-Admin-Utilities-ExpressionBuilders-BuildLambdaExpression``1-System-String-'></a>
### BuildLambdaExpression\`\`1(propertyName) `method`

##### Summary

Build lambda expression from entityType and propertyName.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | Target entity. |

<a name='M-Definux-Emeraude-Admin-Utilities-ExpressionBuilders-BuildQueryExpressionBySearchQuery``1-System-String-'></a>
### BuildQueryExpressionBySearchQuery\`\`1(searchQuery) `method`

##### Summary

Extract filter expression for entity by search string.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| searchQuery | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | Target entity. |

<a name='M-Definux-Emeraude-Admin-Utilities-ExpressionBuilders-OrderByProperty``1-System-Linq-IQueryable{``0},System-String,Definux-Emeraude-Admin-Utilities-OrderType-'></a>
### OrderByProperty\`\`1(queryable,propertyName,orderType) `method`

##### Summary

Sorts elements of a sequence in order according to the specified property name.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queryable | [System.Linq.IQueryable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable 'System.Linq.IQueryable{``0}') |  |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| orderType | [Definux.Emeraude.Admin.Utilities.OrderType](#T-Definux-Emeraude-Admin-Utilities-OrderType 'Definux.Emeraude.Admin.Utilities.OrderType') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | Target entity. |

<a name='T-Definux-Emeraude-Admin-Requests-FetchLogs-FetchActivityLogsQuery'></a>
## FetchActivityLogsQuery `type`

##### Namespace

Definux.Emeraude.Admin.Requests.FetchLogs

##### Summary

Fetch activity logs.

<a name='T-Definux-Emeraude-Admin-Requests-FetchLogs-FetchActivityLogsQuery-FetchActivityLogsQueryHandler'></a>
## FetchActivityLogsQueryHandler `type`

##### Namespace

Definux.Emeraude.Admin.Requests.FetchLogs.FetchActivityLogsQuery

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-Requests-FetchLogs-FetchActivityLogsQuery-FetchActivityLogsQueryHandler-#ctor-Definux-Emeraude-Application-Logger-ILoggerContext,Definux-Emeraude-Application-Persistence-IEmContext,AutoMapper-IMapper-'></a>
### #ctor(loggerContext,entityContext,mapper) `constructor`

##### Summary

Initializes a new instance of the [FetchActivityLogsQueryHandler](#T-Definux-Emeraude-Admin-Requests-FetchLogs-FetchActivityLogsQuery-FetchActivityLogsQueryHandler 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchActivityLogsQuery.FetchActivityLogsQueryHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| loggerContext | [Definux.Emeraude.Application.Logger.ILoggerContext](#T-Definux-Emeraude-Application-Logger-ILoggerContext 'Definux.Emeraude.Application.Logger.ILoggerContext') |  |
| entityContext | [Definux.Emeraude.Application.Persistence.IEmContext](#T-Definux-Emeraude-Application-Persistence-IEmContext 'Definux.Emeraude.Application.Persistence.IEmContext') |  |
| mapper | [AutoMapper.IMapper](#T-AutoMapper-IMapper 'AutoMapper.IMapper') |  |

<a name='M-Definux-Emeraude-Admin-Requests-FetchLogs-FetchActivityLogsQuery-FetchActivityLogsQueryHandler-BuildSearchQueryExpression-System-String-'></a>
### BuildSearchQueryExpression() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-Requests-FetchLogs-FetchEmailLogsQuery'></a>
## FetchEmailLogsQuery `type`

##### Namespace

Definux.Emeraude.Admin.Requests.FetchLogs

##### Summary

Fetch activity logs.

<a name='T-Definux-Emeraude-Admin-Requests-FetchLogs-FetchEmailLogsQuery-FetchEmailLogsQueryHandler'></a>
## FetchEmailLogsQueryHandler `type`

##### Namespace

Definux.Emeraude.Admin.Requests.FetchLogs.FetchEmailLogsQuery

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-Requests-FetchLogs-FetchEmailLogsQuery-FetchEmailLogsQueryHandler-#ctor-Definux-Emeraude-Application-Logger-ILoggerContext,Definux-Emeraude-Application-Persistence-IEmContext,AutoMapper-IMapper-'></a>
### #ctor(loggerContext,entityContext,mapper) `constructor`

##### Summary

Initializes a new instance of the [FetchEmailLogsQueryHandler](#T-Definux-Emeraude-Admin-Requests-FetchLogs-FetchEmailLogsQuery-FetchEmailLogsQueryHandler 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchEmailLogsQuery.FetchEmailLogsQueryHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| loggerContext | [Definux.Emeraude.Application.Logger.ILoggerContext](#T-Definux-Emeraude-Application-Logger-ILoggerContext 'Definux.Emeraude.Application.Logger.ILoggerContext') |  |
| entityContext | [Definux.Emeraude.Application.Persistence.IEmContext](#T-Definux-Emeraude-Application-Persistence-IEmContext 'Definux.Emeraude.Application.Persistence.IEmContext') |  |
| mapper | [AutoMapper.IMapper](#T-AutoMapper-IMapper 'AutoMapper.IMapper') |  |

<a name='M-Definux-Emeraude-Admin-Requests-FetchLogs-FetchEmailLogsQuery-FetchEmailLogsQueryHandler-BuildSearchQueryExpression-System-String-'></a>
### BuildSearchQueryExpression() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-Requests-FetchLogs-FetchErrorLogsQuery'></a>
## FetchErrorLogsQuery `type`

##### Namespace

Definux.Emeraude.Admin.Requests.FetchLogs

##### Summary

Fetch error logs.

<a name='T-Definux-Emeraude-Admin-Requests-FetchLogs-FetchErrorLogsQuery-FetchErrorLogsQueryHandler'></a>
## FetchErrorLogsQueryHandler `type`

##### Namespace

Definux.Emeraude.Admin.Requests.FetchLogs.FetchErrorLogsQuery

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-Requests-FetchLogs-FetchErrorLogsQuery-FetchErrorLogsQueryHandler-#ctor-Definux-Emeraude-Application-Logger-ILoggerContext,Definux-Emeraude-Application-Persistence-IEmContext,AutoMapper-IMapper-'></a>
### #ctor(loggerContext,entityContext,mapper) `constructor`

##### Summary

Initializes a new instance of the [FetchErrorLogsQueryHandler](#T-Definux-Emeraude-Admin-Requests-FetchLogs-FetchErrorLogsQuery-FetchErrorLogsQueryHandler 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchErrorLogsQuery.FetchErrorLogsQueryHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| loggerContext | [Definux.Emeraude.Application.Logger.ILoggerContext](#T-Definux-Emeraude-Application-Logger-ILoggerContext 'Definux.Emeraude.Application.Logger.ILoggerContext') |  |
| entityContext | [Definux.Emeraude.Application.Persistence.IEmContext](#T-Definux-Emeraude-Application-Persistence-IEmContext 'Definux.Emeraude.Application.Persistence.IEmContext') |  |
| mapper | [AutoMapper.IMapper](#T-AutoMapper-IMapper 'AutoMapper.IMapper') |  |

<a name='M-Definux-Emeraude-Admin-Requests-FetchLogs-FetchErrorLogsQuery-FetchErrorLogsQueryHandler-BuildSearchQueryExpression-System-String-'></a>
### BuildSearchQueryExpression() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-Requests-FetchLogs-FetchLogsQueryHandler`4'></a>
## FetchLogsQueryHandler\`4 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.FetchLogs

##### Summary

Abstract definition for Logger query handler.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TRequest | Target request. |
| TResult | Request result. |
| TLoggerEntity | Target logger entity. |
| TLoggerEntityViewModel | Target logger entity view model. |

<a name='M-Definux-Emeraude-Admin-Requests-FetchLogs-FetchLogsQueryHandler`4-#ctor-Definux-Emeraude-Application-Logger-ILoggerContext,Definux-Emeraude-Application-Persistence-IEmContext,AutoMapper-IMapper-'></a>
### #ctor(loggerContext,entityContext,mapper) `constructor`

##### Summary

Initializes a new instance of the [FetchLogsQueryHandler\`4](#T-Definux-Emeraude-Admin-Requests-FetchLogs-FetchLogsQueryHandler`4 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchLogsQueryHandler`4') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| loggerContext | [Definux.Emeraude.Application.Logger.ILoggerContext](#T-Definux-Emeraude-Application-Logger-ILoggerContext 'Definux.Emeraude.Application.Logger.ILoggerContext') |  |
| entityContext | [Definux.Emeraude.Application.Persistence.IEmContext](#T-Definux-Emeraude-Application-Persistence-IEmContext 'Definux.Emeraude.Application.Persistence.IEmContext') |  |
| mapper | [AutoMapper.IMapper](#T-AutoMapper-IMapper 'AutoMapper.IMapper') |  |

<a name='M-Definux-Emeraude-Admin-Requests-FetchLogs-FetchLogsQueryHandler`4-BuildSearchQueryExpression-System-String-'></a>
### BuildSearchQueryExpression(searchQuery) `method`

##### Summary

Defines search query expression.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| searchQuery | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Admin-Requests-FetchLogs-FetchLogsQueryHandler`4-Handle-`0,System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-Requests-FetchLogs-FetchLogsQuery`1'></a>
## FetchLogsQuery\`1 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.FetchLogs

##### Summary

Logger query abstraction class.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TResult | Result of the query. |

<a name='P-Definux-Emeraude-Admin-Requests-FetchLogs-FetchLogsQuery`1-FromDate'></a>
### FromDate `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Admin-Requests-FetchLogs-FetchLogsQuery`1-Page'></a>
### Page `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Admin-Requests-FetchLogs-FetchLogsQuery`1-SearchQuery'></a>
### SearchQuery `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Admin-Requests-FetchLogs-FetchLogsQuery`1-ToDate'></a>
### ToDate `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Admin-Requests-FetchLogs-FetchLogsQuery`1-User'></a>
### User `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Admin-Requests-FetchLogs-FetchTempFileLogsQuery'></a>
## FetchTempFileLogsQuery `type`

##### Namespace

Definux.Emeraude.Admin.Requests.FetchLogs

##### Summary

Fetch activity logs.

<a name='T-Definux-Emeraude-Admin-Requests-FetchLogs-FetchTempFileLogsQuery-FetchTempFileLogsQueryHandler'></a>
## FetchTempFileLogsQueryHandler `type`

##### Namespace

Definux.Emeraude.Admin.Requests.FetchLogs.FetchTempFileLogsQuery

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-Requests-FetchLogs-FetchTempFileLogsQuery-FetchTempFileLogsQueryHandler-#ctor-Definux-Emeraude-Application-Logger-ILoggerContext,Definux-Emeraude-Application-Persistence-IEmContext,AutoMapper-IMapper-'></a>
### #ctor(loggerContext,entityContext,mapper) `constructor`

##### Summary

Initializes a new instance of the [FetchTempFileLogsQueryHandler](#T-Definux-Emeraude-Admin-Requests-FetchLogs-FetchTempFileLogsQuery-FetchTempFileLogsQueryHandler 'Definux.Emeraude.Admin.Requests.FetchLogs.FetchTempFileLogsQuery.FetchTempFileLogsQueryHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| loggerContext | [Definux.Emeraude.Application.Logger.ILoggerContext](#T-Definux-Emeraude-Application-Logger-ILoggerContext 'Definux.Emeraude.Application.Logger.ILoggerContext') |  |
| entityContext | [Definux.Emeraude.Application.Persistence.IEmContext](#T-Definux-Emeraude-Application-Persistence-IEmContext 'Definux.Emeraude.Application.Persistence.IEmContext') |  |
| mapper | [AutoMapper.IMapper](#T-AutoMapper-IMapper 'AutoMapper.IMapper') |  |

<a name='M-Definux-Emeraude-Admin-Requests-FetchLogs-FetchTempFileLogsQuery-FetchTempFileLogsQueryHandler-BuildSearchQueryExpression-System-String-'></a>
### BuildSearchQueryExpression() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-Attributes-FormInputAttribute'></a>
## FormInputAttribute `type`

##### Namespace

Definux.Emeraude.Admin.Attributes

##### Summary

Attribute that include the decorated property into the create/edit form of entity admin controller.

<a name='M-Definux-Emeraude-Admin-Attributes-FormInputAttribute-#ctor-System-Int32,System-String,System-Type,System-Type,System-String-'></a>
### #ctor(order,name,uiElementType,dataSourceType,visualizationPropertyName) `constructor`

##### Summary

Initializes a new instance of the [FormInputAttribute](#T-Definux-Emeraude-Admin-Attributes-FormInputAttribute 'Definux.Emeraude.Admin.Attributes.FormInputAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| order | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| uiElementType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |
| dataSourceType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |
| visualizationPropertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Admin-Attributes-FormInputAttribute-#ctor-System-Int32,System-Type,System-Type,System-String,System-String-'></a>
### #ctor(order,uiElementType,dataSourceType,visualizationPropertyName,propertyName) `constructor`

##### Summary

Initializes a new instance of the [FormInputAttribute](#T-Definux-Emeraude-Admin-Attributes-FormInputAttribute 'Definux.Emeraude.Admin.Attributes.FormInputAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| order | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| uiElementType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |
| dataSourceType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |
| visualizationPropertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='P-Definux-Emeraude-Admin-Attributes-FormInputAttribute-DataSourceType'></a>
### DataSourceType `property`

##### Summary

The existence of this property defines external data source for the current property. In case you use database source or additional data source map [IDataSourceMap](#T-Definux-Emeraude-Admin-UI-UIElements-IDataSourceMap 'Definux.Emeraude.Admin.UI.UIElements.IDataSourceMap').

<a name='P-Definux-Emeraude-Admin-Attributes-FormInputAttribute-Name'></a>
### Name `property`

##### Summary

Name of the label of the form input.

<a name='P-Definux-Emeraude-Admin-Attributes-FormInputAttribute-Order'></a>
### Order `property`

##### Summary

Order of the form input.

<a name='P-Definux-Emeraude-Admin-Attributes-FormInputAttribute-UIElementType'></a>
### UIElementType `property`

##### Summary

UI element type that implemented [IFormElement](#T-Definux-Emeraude-Admin-UI-UIElements-Form-IFormElement 'Definux.Emeraude.Admin.UI.UIElements.Form.IFormElement').

<a name='P-Definux-Emeraude-Admin-Attributes-FormInputAttribute-VisualizationPropertyName'></a>
### VisualizationPropertyName `property`

##### Summary

Name of the property that will be visualized on the form element.

<a name='T-Definux-Emeraude-Admin-Requests-GenericEntityRequst`1'></a>
## GenericEntityRequst\`1 `type`

##### Namespace

Definux.Emeraude.Admin.Requests

##### Summary

Implementation of generic entity request.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | Target entity. |

<a name='P-Definux-Emeraude-Admin-Requests-GenericEntityRequst`1-ParentExpression'></a>
### ParentExpression `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Admin-Requests-GenericNewEntityRequest`1'></a>
## GenericNewEntityRequest\`1 `type`

##### Namespace

Definux.Emeraude.Admin.Requests

##### Summary

Implementation of generic new entity request.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | Target entity. |

<a name='P-Definux-Emeraude-Admin-Requests-GenericNewEntityRequest`1-ParentId'></a>
### ParentId `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Admin-Requests-GenericNewEntityRequest`1-ParentProperty'></a>
### ParentProperty `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Admin-Requests-GetAll-GetAllQueryHandler`2'></a>
## GetAllQueryHandler\`2 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.GetAll

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-Requests-GetAll-GetAllQueryHandler`2-#ctor-Definux-Emeraude-Application-Persistence-IEmContext,AutoMapper-IMapper,Definux-Emeraude-Application-Logger-IEmLogger-'></a>
### #ctor(context,mapper,logger) `constructor`

##### Summary

Initializes a new instance of the [GetAllQueryHandler\`2](#T-Definux-Emeraude-Admin-Requests-GetAll-GetAllQueryHandler`2 'Definux.Emeraude.Admin.Requests.GetAll.GetAllQueryHandler`2') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Definux.Emeraude.Application.Persistence.IEmContext](#T-Definux-Emeraude-Application-Persistence-IEmContext 'Definux.Emeraude.Application.Persistence.IEmContext') |  |
| mapper | [AutoMapper.IMapper](#T-AutoMapper-IMapper 'AutoMapper.IMapper') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |

<a name='M-Definux-Emeraude-Admin-Requests-GetAll-GetAllQueryHandler`2-Handle-Definux-Emeraude-Admin-Requests-GetAll-GetAllQuery{`0,`1},System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-Requests-GetAll-GetAllQuery`2'></a>
## GetAllQuery\`2 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.GetAll

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-Requests-GetAll-GetAllQuery`2-#ctor-System-Int32,System-String-'></a>
### #ctor(page,searchQuery) `constructor`

##### Summary

Initializes a new instance of the [GetAllQuery\`2](#T-Definux-Emeraude-Admin-Requests-GetAll-GetAllQuery`2 'Definux.Emeraude.Admin.Requests.GetAll.GetAllQuery`2') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| page | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| searchQuery | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Admin-Requests-GetAll-GetAllQuery`2-#ctor-System-Int32,System-String,System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}}-'></a>
### #ctor(page,searchQuery,parentExpression) `constructor`

##### Summary

Initializes a new instance of the [GetAllQuery\`2](#T-Definux-Emeraude-Admin-Requests-GetAll-GetAllQuery`2 'Definux.Emeraude.Admin.Requests.GetAll.GetAllQuery`2') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| page | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| searchQuery | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| parentExpression | [System.Linq.Expressions.Expression{System.Func{\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}}') |  |

<a name='P-Definux-Emeraude-Admin-Requests-GetAll-GetAllQuery`2-OrderBy'></a>
### OrderBy `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Admin-Requests-GetAll-GetAllQuery`2-OrderType'></a>
### OrderType `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Admin-Requests-GetAll-GetAllQuery`2-Page'></a>
### Page `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Admin-Requests-GetAll-GetAllQuery`2-PageSize'></a>
### PageSize `property`

##### Summary

Page size for the pagination. Default value is 25.

<a name='P-Definux-Emeraude-Admin-Requests-GetAll-GetAllQuery`2-SearchQuery'></a>
### SearchQuery `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Admin-Requests-GetEmailBody-GetEmailBodyQuery'></a>
## GetEmailBodyQuery `type`

##### Namespace

Definux.Emeraude.Admin.Requests.GetEmailBody

##### Summary

Returns body from specified email log id.

<a name='M-Definux-Emeraude-Admin-Requests-GetEmailBody-GetEmailBodyQuery-#ctor-System-Int32-'></a>
### #ctor(emailLogId) `constructor`

##### Summary

Initializes a new instance of the [GetEmailBodyQuery](#T-Definux-Emeraude-Admin-Requests-GetEmailBody-GetEmailBodyQuery 'Definux.Emeraude.Admin.Requests.GetEmailBody.GetEmailBodyQuery') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| emailLogId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='P-Definux-Emeraude-Admin-Requests-GetEmailBody-GetEmailBodyQuery-EmailLogId'></a>
### EmailLogId `property`

##### Summary

Id of the email log.

<a name='T-Definux-Emeraude-Admin-Requests-GetEmailBody-GetEmailBodyQuery-GetEmailBodyQueryHandler'></a>
## GetEmailBodyQueryHandler `type`

##### Namespace

Definux.Emeraude.Admin.Requests.GetEmailBody.GetEmailBodyQuery

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-Requests-GetEmailBody-GetEmailBodyQuery-GetEmailBodyQueryHandler-#ctor-Definux-Emeraude-Application-Logger-ILoggerContext,Definux-Emeraude-Application-Logger-IEmLogger-'></a>
### #ctor(context,logger) `constructor`

##### Summary

Initializes a new instance of the [GetEmailBodyQueryHandler](#T-Definux-Emeraude-Admin-Requests-GetEmailBody-GetEmailBodyQuery-GetEmailBodyQueryHandler 'Definux.Emeraude.Admin.Requests.GetEmailBody.GetEmailBodyQuery.GetEmailBodyQueryHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Definux.Emeraude.Application.Logger.ILoggerContext](#T-Definux-Emeraude-Application-Logger-ILoggerContext 'Definux.Emeraude.Application.Logger.ILoggerContext') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |

<a name='M-Definux-Emeraude-Admin-Requests-GetEmailBody-GetEmailBodyQuery-GetEmailBodyQueryHandler-Handle-Definux-Emeraude-Admin-Requests-GetEmailBody-GetEmailBodyQuery,System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-Requests-GetEntityImage-GetEntityImageQueryHandler`1'></a>
## GetEntityImageQueryHandler\`1 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.GetEntityImage

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-Requests-GetEntityImage-GetEntityImageQueryHandler`1-#ctor-Definux-Emeraude-Application-Persistence-IEmContext,Definux-Emeraude-Application-Logger-IEmLogger-'></a>
### #ctor(context,logger) `constructor`

##### Summary

Initializes a new instance of the [GetEntityImageQueryHandler\`1](#T-Definux-Emeraude-Admin-Requests-GetEntityImage-GetEntityImageQueryHandler`1 'Definux.Emeraude.Admin.Requests.GetEntityImage.GetEntityImageQueryHandler`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Definux.Emeraude.Application.Persistence.IEmContext](#T-Definux-Emeraude-Application-Persistence-IEmContext 'Definux.Emeraude.Application.Persistence.IEmContext') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |

<a name='M-Definux-Emeraude-Admin-Requests-GetEntityImage-GetEntityImageQueryHandler`1-Handle-Definux-Emeraude-Admin-Requests-GetEntityImage-GetEntityImageQuery{`0},System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-Requests-GetEntityImage-GetEntityImageQuery`1'></a>
## GetEntityImageQuery\`1 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.GetEntityImage

##### Summary

Get image of entity.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | Entity of type [IEntityWithImage](#T-Definux-Emeraude-Domain-Entities-IEntityWithImage 'Definux.Emeraude.Domain.Entities.IEntityWithImage'). |

<a name='M-Definux-Emeraude-Admin-Requests-GetEntityImage-GetEntityImageQuery`1-#ctor-System-Guid-'></a>
### #ctor(entityId) `constructor`

##### Summary

Initializes a new instance of the [GetEntityImageQuery\`1](#T-Definux-Emeraude-Admin-Requests-GetEntityImage-GetEntityImageQuery`1 'Definux.Emeraude.Admin.Requests.GetEntityImage.GetEntityImageQuery`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entityId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |

<a name='P-Definux-Emeraude-Admin-Requests-GetEntityImage-GetEntityImageQuery`1-EntityId'></a>
### EntityId `property`

##### Summary

Id of the entity.

<a name='T-Definux-Emeraude-Admin-Controllers-Abstractions-IAdminEntityController'></a>
## IAdminEntityController `type`

##### Namespace

Definux.Emeraude.Admin.Controllers.Abstractions

##### Summary

Informative empty interface that defines the administration entity controllers.

<a name='T-Definux-Emeraude-Admin-Mapping-IAdminEntityMapper'></a>
## IAdminEntityMapper `type`

##### Namespace

Definux.Emeraude.Admin.Mapping

##### Summary

Mapper service that provides conversion service between admin view models and UI models.

<a name='M-Definux-Emeraude-Admin-Mapping-IAdminEntityMapper-MapToDetailsViewModel``1-``0-'></a>
### MapToDetailsViewModel\`\`1(entity) `method`

##### Summary

Map entities to [DetailsViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-DetailsCard-DetailsViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.DetailsCard.DetailsViewModel') by using the decorated properties of the view model entity implementation by .

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entity | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | ViewModel entity implementation. |

<a name='M-Definux-Emeraude-Admin-Mapping-IAdminEntityMapper-MapToFormInputViewModels-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-IEntityFormViewModel-'></a>
### MapToFormInputViewModels(entityViewModel) `method`

##### Summary

Converts specified ViewModel ([IEntityFormViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-IEntityFormViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.IEntityFormViewModel')) to collection of [EntityFormViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-EntityFormViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.EntityFormViewModel') by using the decorated properties of the view model entity implementation by .

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entityViewModel | [Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.IEntityFormViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Form-IEntityFormViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Form.IEntityFormViewModel') |  |

<a name='M-Definux-Emeraude-Admin-Mapping-IAdminEntityMapper-MapToTableViewModel``1-Definux-Utilities-Objects-PaginatedList{``0},Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel[]-'></a>
### MapToTableViewModel\`\`1(entitiesResult,actions) `method`

##### Summary

Map entities to [TableViewModel](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableViewModel 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableViewModel') by using the decorated properties of the view model entity implementation by .

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entitiesResult | [Definux.Utilities.Objects.PaginatedList{\`\`0}](#T-Definux-Utilities-Objects-PaginatedList{``0} 'Definux.Utilities.Objects.PaginatedList{``0}') |  |
| actions | [Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowActionViewModel[]](#T-Definux-Emeraude-Admin-UI-ViewModels-Entity-Table-TableRowActionViewModel[] 'Definux.Emeraude.Admin.UI.ViewModels.Entity.Table.TableRowActionViewModel[]') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | ViewModel entity implementation. |

<a name='T-Definux-Emeraude-Admin-Requests-Create-ICreateCommandHandler`3'></a>
## ICreateCommandHandler\`3 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.Create

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Admin-Requests-Create-ICreateCommand`2'></a>
## ICreateCommand\`2 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.Create

##### Summary

Generic command that create an entity.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | Target entity. |
| TRequestModel | Data transfer object of the target entity. |

<a name='P-Definux-Emeraude-Admin-Requests-Create-ICreateCommand`2-Model'></a>
### Model `property`

##### Summary

Request model of the command.

<a name='T-Definux-Emeraude-Admin-Requests-IDashboardRequest`1'></a>
## IDashboardRequest\`1 `type`

##### Namespace

Definux.Emeraude.Admin.Requests

##### Summary

Dashboard request contract for building dashboard view model.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TResponse | Response type of the request. |

<a name='T-Definux-Emeraude-Admin-Requests-Delete-IDeleteCommandHandler`2'></a>
## IDeleteCommandHandler\`2 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.Delete

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Admin-Requests-Delete-IDeleteCommand`1'></a>
## IDeleteCommand\`1 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.Delete

##### Summary

Generic command that delete an entity.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | Target entity. |

<a name='P-Definux-Emeraude-Admin-Requests-Delete-IDeleteCommand`1-EntityId'></a>
### EntityId `property`

##### Summary

Id of the entity.

<a name='T-Definux-Emeraude-Admin-Requests-Details-IDetailsQueryHandler`3'></a>
## IDetailsQueryHandler\`3 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.Details

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Admin-Requests-Details-IDetailsQuery`2'></a>
## IDetailsQuery\`2 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.Details

##### Summary

Generic query that returns detail information about entity.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | Target entity. |
| TRequestModel | Data transfer object of the target entity. |

<a name='P-Definux-Emeraude-Admin-Requests-Details-IDetailsQuery`2-EntityId'></a>
### EntityId `property`

##### Summary

Id of the entity.

<a name='T-Definux-Emeraude-Admin-Requests-Edit-IEditCommandHandler`3'></a>
## IEditCommandHandler\`3 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.Edit

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Admin-Requests-Edit-IEditCommand`2'></a>
## IEditCommand\`2 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.Edit

##### Summary

Generic query that edit an entity.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | Target entity. |
| TRequestModel | Data transfer object of the target entity. |

<a name='P-Definux-Emeraude-Admin-Requests-Edit-IEditCommand`2-EntityId'></a>
### EntityId `property`

##### Summary

Id of the entity.

<a name='P-Definux-Emeraude-Admin-Requests-Edit-IEditCommand`2-Model'></a>
### Model `property`

##### Summary

Request model of the command.

<a name='T-Definux-Emeraude-Admin-Requests-FetchLogs-IFetchLogsQuery'></a>
## IFetchLogsQuery `type`

##### Namespace

Definux.Emeraude.Admin.Requests.FetchLogs

##### Summary

Fetch logs query contract.

<a name='P-Definux-Emeraude-Admin-Requests-FetchLogs-IFetchLogsQuery-FromDate'></a>
### FromDate `property`

##### Summary

Filters by start date.

<a name='P-Definux-Emeraude-Admin-Requests-FetchLogs-IFetchLogsQuery-Page'></a>
### Page `property`

##### Summary

Pagination page index. First index is 1.

<a name='P-Definux-Emeraude-Admin-Requests-FetchLogs-IFetchLogsQuery-SearchQuery'></a>
### SearchQuery `property`

##### Summary

Search query string.

<a name='P-Definux-Emeraude-Admin-Requests-FetchLogs-IFetchLogsQuery-ToDate'></a>
### ToDate `property`

##### Summary

Filters by end date.

<a name='P-Definux-Emeraude-Admin-Requests-FetchLogs-IFetchLogsQuery-User'></a>
### User `property`

##### Summary

Filters by user.

<a name='T-Definux-Emeraude-Admin-Requests-IGenericEntityRequest`1'></a>
## IGenericEntityRequest\`1 `type`

##### Namespace

Definux.Emeraude.Admin.Requests

##### Summary

Definition of generic entity request.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | Target entity. |

<a name='P-Definux-Emeraude-Admin-Requests-IGenericEntityRequest`1-ParentExpression'></a>
### ParentExpression `property`

##### Summary

Referenced property expression of the parent entity for current entity.

<a name='T-Definux-Emeraude-Admin-Requests-IGenericNewEntityRequest`1'></a>
## IGenericNewEntityRequest\`1 `type`

##### Namespace

Definux.Emeraude.Admin.Requests

##### Summary

Definition of generic new entity request.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | Target entity. |

<a name='P-Definux-Emeraude-Admin-Requests-IGenericNewEntityRequest`1-ParentId'></a>
### ParentId `property`

##### Summary

Id of the parent if exists.

<a name='P-Definux-Emeraude-Admin-Requests-IGenericNewEntityRequest`1-ParentProperty'></a>
### ParentProperty `property`

##### Summary

Property of the parent if exists.

<a name='T-Definux-Emeraude-Admin-Requests-GetAll-IGetAllQueryHandler`3'></a>
## IGetAllQueryHandler\`3 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.GetAll

##### Summary

Interface that wraps get all request handler.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TGetAllQuery | Get all query. |
| TEntity | Target entity. |
| TRequestModel | Query response model. |

<a name='T-Definux-Emeraude-Admin-Requests-GetAll-IGetAllQuery`2'></a>
## IGetAllQuery\`2 `type`

##### Namespace

Definux.Emeraude.Admin.Requests.GetAll

##### Summary

Generic query that returns all entities with or without filter.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | Target entity. |
| TRequestModel | Query response model. |

<a name='P-Definux-Emeraude-Admin-Requests-GetAll-IGetAllQuery`2-OrderBy'></a>
### OrderBy `property`

##### Summary

Order property.

<a name='P-Definux-Emeraude-Admin-Requests-GetAll-IGetAllQuery`2-OrderType'></a>
### OrderType `property`

##### Summary

Order type.

<a name='P-Definux-Emeraude-Admin-Requests-GetAll-IGetAllQuery`2-Page'></a>
### Page `property`

##### Summary

Pagination page index. First index is 1.

<a name='P-Definux-Emeraude-Admin-Requests-GetAll-IGetAllQuery`2-SearchQuery'></a>
### SearchQuery `property`

##### Summary

Search query string.

<a name='T-Definux-Emeraude-Admin-Adapters-IdentityUserInfoAdapter'></a>
## IdentityUserInfoAdapter `type`

##### Namespace

Definux.Emeraude.Admin.Adapters

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Admin-Adapters-IdentityUserInfoAdapter-#ctor-Definux-Emeraude-Application-Identity-ICurrentUserProvider,Definux-Emeraude-Application-Identity-IUserClaimsService,Definux-Emeraude-Application-Logger-IEmLogger-'></a>
### #ctor(currentUserProvider,userClaimsService,logger) `constructor`

##### Summary

Initializes a new instance of the [IdentityUserInfoAdapter](#T-Definux-Emeraude-Admin-Adapters-IdentityUserInfoAdapter 'Definux.Emeraude.Admin.Adapters.IdentityUserInfoAdapter') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| currentUserProvider | [Definux.Emeraude.Application.Identity.ICurrentUserProvider](#T-Definux-Emeraude-Application-Identity-ICurrentUserProvider 'Definux.Emeraude.Application.Identity.ICurrentUserProvider') |  |
| userClaimsService | [Definux.Emeraude.Application.Identity.IUserClaimsService](#T-Definux-Emeraude-Application-Identity-IUserClaimsService 'Definux.Emeraude.Application.Identity.IUserClaimsService') |  |
| logger | [Definux.Emeraude.Application.Logger.IEmLogger](#T-Definux-Emeraude-Application-Logger-IEmLogger 'Definux.Emeraude.Application.Logger.IEmLogger') |  |

<a name='M-Definux-Emeraude-Admin-Adapters-IdentityUserInfoAdapter-GetCurrentUserClaimsAsync'></a>
### GetCurrentUserClaimsAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-Adapters-IdentityUserInfoAdapter-GetCurrentUserInfoAsync'></a>
### GetCurrentUserInfoAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-Utilities-MaterialDesignIcons'></a>
## MaterialDesignIcons `type`

##### Namespace

Definux.Emeraude.Admin.Utilities

##### Summary

Material design icons for version 4.9.95. Can be accessed on https://pictogrammers.github.io/@mdi/font/4.9.95/.

<a name='T-Definux-Emeraude-Admin-Utilities-OrderType'></a>
## OrderType `type`

##### Namespace

Definux.Emeraude.Admin.Utilities

##### Summary

Order types.

<a name='F-Definux-Emeraude-Admin-Utilities-OrderType-Ascending'></a>
### Ascending `constants`

##### Summary

Ascending order.

<a name='F-Definux-Emeraude-Admin-Utilities-OrderType-Descending'></a>
### Descending `constants`

##### Summary

Descending order.

<a name='F-Definux-Emeraude-Admin-Utilities-OrderType-Unspecified'></a>
### Unspecified `constants`

##### Summary

Unspecified order.

<a name='T-Definux-Emeraude-Admin-RouteConstraints-RootConstraint'></a>
## RootConstraint `type`

##### Namespace

Definux.Emeraude.Admin.RouteConstraints

##### Summary

Implementation of [IRouteConstraint](#T-Microsoft-AspNetCore-Routing-IRouteConstraint 'Microsoft.AspNetCore.Routing.IRouteConstraint') for the public and private roots.

<a name='F-Definux-Emeraude-Admin-RouteConstraints-RootConstraint-RootConstraintKey'></a>
### RootConstraintKey `constants`

##### Summary

Short name of the root constraint.

<a name='F-Definux-Emeraude-Admin-RouteConstraints-RootConstraint-RootKey'></a>
### RootKey `constants`

##### Summary

Root value property that is applied to the route parameters.

<a name='F-Definux-Emeraude-Admin-RouteConstraints-RootConstraint-RootRouteSlug'></a>
### RootRouteSlug `constants`

##### Summary

Root route slug.

<a name='M-Definux-Emeraude-Admin-RouteConstraints-RootConstraint-Match-Microsoft-AspNetCore-Http-HttpContext,Microsoft-AspNetCore-Routing-IRouter,System-String,Microsoft-AspNetCore-Routing-RouteValueDictionary,Microsoft-AspNetCore-Routing-RouteDirection-'></a>
### Match() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-Extensions-ServiceCollectionExtensions'></a>
## ServiceCollectionExtensions `type`

##### Namespace

Definux.Emeraude.Admin.Extensions

##### Summary

Extensions for [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection').

<a name='M-Definux-Emeraude-Admin-Extensions-ServiceCollectionExtensions-AddAdminCookie-Microsoft-AspNetCore-Authentication-AuthenticationBuilder-'></a>
### AddAdminCookie(builder) `method`

##### Summary

Register Emeraude administration authentication scheme.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Authentication.AuthenticationBuilder](#T-Microsoft-AspNetCore-Authentication-AuthenticationBuilder 'Microsoft.AspNetCore.Authentication.AuthenticationBuilder') |  |

<a name='M-Definux-Emeraude-Admin-Extensions-ServiceCollectionExtensions-AddAdminMapperConfiguration-AutoMapper-IMapperConfigurationExpression-'></a>
### AddAdminMapperConfiguration(configuration) `method`

##### Summary

Register Emeraude administration mapping configuration.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [AutoMapper.IMapperConfigurationExpression](#T-AutoMapper-IMapperConfigurationExpression 'AutoMapper.IMapperConfigurationExpression') |  |

<a name='M-Definux-Emeraude-Admin-Extensions-ServiceCollectionExtensions-AddEmeraudeAdmin-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### AddEmeraudeAdmin(services) `method`

##### Summary

Register all required Emeraude administration services.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |

<a name='M-Definux-Emeraude-Admin-Extensions-ServiceCollectionExtensions-RegisterAdditionalAdminGenericCustomRequests-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### RegisterAdditionalAdminGenericCustomRequests(services) `method`

##### Summary

Register additional requests used from built-in features.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |

<a name='M-Definux-Emeraude-Admin-Extensions-ServiceCollectionExtensions-RegisterAdminEntityControllersRequests-Microsoft-Extensions-DependencyInjection-IServiceCollection,System-Reflection-Assembly[]-'></a>
### RegisterAdminEntityControllersRequests(services,assemblies) `method`

##### Summary

Register Emeraude administration generic requests for all [IAdminEntityController](#T-Definux-Emeraude-Admin-Controllers-Abstractions-IAdminEntityController 'Definux.Emeraude.Admin.Controllers.Abstractions.IAdminEntityController').

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |
| assemblies | [System.Reflection.Assembly[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.Assembly[] 'System.Reflection.Assembly[]') |  |

<a name='T-Definux-Emeraude-Admin-Attributes-TableColumnAttribute'></a>
## TableColumnAttribute `type`

##### Namespace

Definux.Emeraude.Admin.Attributes

##### Summary

Attribute used for rendering the table of the get all action of admin entity controller.

<a name='M-Definux-Emeraude-Admin-Attributes-TableColumnAttribute-#ctor-System-Int32,System-String,System-Type-'></a>
### #ctor(order,name,uiElementType) `constructor`

##### Summary

Initializes a new instance of the [TableColumnAttribute](#T-Definux-Emeraude-Admin-Attributes-TableColumnAttribute 'Definux.Emeraude.Admin.Attributes.TableColumnAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| order | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| uiElementType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |

<a name='M-Definux-Emeraude-Admin-Attributes-TableColumnAttribute-#ctor-System-Int32,System-Type,System-String-'></a>
### #ctor(order,uiElementType,propertyName) `constructor`

##### Summary

Initializes a new instance of the [TableColumnAttribute](#T-Definux-Emeraude-Admin-Attributes-TableColumnAttribute 'Definux.Emeraude.Admin.Attributes.TableColumnAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| order | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| uiElementType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='P-Definux-Emeraude-Admin-Attributes-TableColumnAttribute-Name'></a>
### Name `property`

##### Summary

Name of the column.

<a name='P-Definux-Emeraude-Admin-Attributes-TableColumnAttribute-Order'></a>
### Order `property`

##### Summary

Order of the column.

<a name='P-Definux-Emeraude-Admin-Attributes-TableColumnAttribute-UIElementType'></a>
### UIElementType `property`

##### Summary

UI element type that implemented [ITableElement](#T-Definux-Emeraude-Admin-UI-UIElements-Table-ITableElement 'Definux.Emeraude.Admin.UI.UIElements.Table.ITableElement').

<a name='T-Definux-Emeraude-Admin-Models-UserViewModel'></a>
## UserViewModel `type`

##### Namespace

Definux.Emeraude.Admin.Models

##### Summary

ViewModel of the user entity.

<a name='P-Definux-Emeraude-Admin-Models-UserViewModel-Email'></a>
### Email `property`

##### Summary

Email address of the user.

<a name='P-Definux-Emeraude-Admin-Models-UserViewModel-EmailConfirmed'></a>
### EmailConfirmed `property`

##### Summary

Flat that indicates whether the user has been confirmed his email address.

<a name='P-Definux-Emeraude-Admin-Models-UserViewModel-Id'></a>
### Id `property`

##### Summary

Identifier of the user.

<a name='P-Definux-Emeraude-Admin-Models-UserViewModel-IsLockedOut'></a>
### IsLockedOut `property`

##### Summary

Flag that indicates whether the user is locked out.

<a name='P-Definux-Emeraude-Admin-Models-UserViewModel-Name'></a>
### Name `property`

##### Summary

Name of the user.

<a name='P-Definux-Emeraude-Admin-Models-UserViewModel-RegistrationDate'></a>
### RegistrationDate `property`

##### Summary

Registration date of the user.

<a name='P-Definux-Emeraude-Admin-Models-UserViewModel-TwoFactorEnabled'></a>
### TwoFactorEnabled `property`

##### Summary

Flag that indicates whether the user is activate his/her two factor authentication.
