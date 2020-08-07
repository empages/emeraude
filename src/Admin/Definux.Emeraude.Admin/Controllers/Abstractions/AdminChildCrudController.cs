using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Threading.Tasks;
using Definux.Utilities.Functions;
using Definux.Utilities.Extensions;
using Definux.Emeraude.Admin.Requests.Details;
using Definux.Emeraude.Admin.Requests.GetAll;
using Definux.Emeraude.Admin.Requests.Create;
using Definux.Emeraude.Admin.Requests.Exists;
using Definux.Emeraude.Admin.Requests.Edit;
using Definux.Emeraude.Admin.Requests.Delete;
using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.UI.ViewModels.Crud.Table;
using System.Collections.Generic;
using Definux.Emeraude.Admin.UI.ViewModels.Layout;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Admin.Utilities;
using Definux.Emeraude.Presentation.Controllers;

namespace Definux.Emeraude.Admin.Controllers.Abstractions
{
    public abstract class AdminChildCrudController<TEntity, TEntityViewModel, TParentEntity, TParentController> : AdminCrudController<TEntity, TEntityViewModel>, IChildController
        where TEntity : class, IEntity, new()
        where TEntityViewModel : class, new()
        where TParentEntity : class, IEntity, new()
        where TParentController : class
    {
        protected const string ParentRouteKeyPropertyName = "ParentRouteKey";
        protected const string BreadcrumbParentTitlePlaceholder = "[ParentBreadcrumbTitle]";

        public abstract string ParentRouteKey { get; }

        public abstract string ForeignKey { get; }

        public string ParentController => typeof(TParentController).Name;

        public string ForeignKeyValue => HttpContext.Request.RouteValues[ParentRouteKey]?.ToString();

        [Breadcrumb(BreadcrumbParentTitlePlaceholder, true, 0, nameof(GetAll), UseParentController = true)]
        [Breadcrumb(BreadcrumbPageTitlePlaceholder, false, 1)]
        public async override Task<IActionResult> GetAll([FromQuery(Name = "p")] int page = 1, [FromQuery(Name = "q")] string query = null)
        {
            if (!(await ValidateExistanceAsync()))
            {
                return NotFound();
            }

            ApplyParentBreadcrumbTitle();

            return await base.GetAll(page, query);
        }

        [Breadcrumb(BreadcrumbParentTitlePlaceholder, true, 0, nameof(GetAll), UseParentController = true)]
        [Breadcrumb(BreadcrumbEntityNamePluralPlaceholder, true, 1, nameof(GetAll), ParentRouteKey = ParentRouteKeyPropertyName)]
        [Breadcrumb("Details", false, 2)]
        public async override Task<IActionResult> Details(Guid id)
        {
            if (!(await ValidateExistanceAsync()))
            {
                return NotFound();
            }

            ApplyParentBreadcrumbTitle();

            return await base.Details(id);
        }

        [Breadcrumb(BreadcrumbParentTitlePlaceholder, true, 0, nameof(GetAll), UseParentController = true)]
        [Breadcrumb(BreadcrumbEntityNamePluralPlaceholder, true, 1, nameof(GetAll), ParentRouteKey = ParentRouteKeyPropertyName)]
        [Breadcrumb("Create", false, 2)]
        public async override Task<IActionResult> Create()
        {
            if (!(await ValidateExistanceAsync()))
            {
                return NotFound();
            }

            ApplyParentBreadcrumbTitle();

            return await base.Create();
        }

        [Breadcrumb(BreadcrumbParentTitlePlaceholder, true, 0, nameof(GetAll), UseParentController = true)]
        [Breadcrumb(BreadcrumbEntityNamePluralPlaceholder, true, 1, nameof(GetAll), ParentRouteKey = ParentRouteKeyPropertyName)]
        [Breadcrumb("Create", false, 2)]
        public async override Task<IActionResult> Create(TEntityViewModel model)
        {
            if (!(await ValidateExistanceAsync()))
            {
                return NotFound();
            }

            ApplyParentBreadcrumbTitle();

            return await base.Create(model);
        }

        [Breadcrumb(BreadcrumbParentTitlePlaceholder, true, 0, nameof(GetAll), UseParentController = true)]
        [Breadcrumb(BreadcrumbEntityNamePluralPlaceholder, true, 1, nameof(GetAll), ParentRouteKey = ParentRouteKeyPropertyName)]
        [Breadcrumb("Edit", false, 2)]
        public async override Task<IActionResult> Edit(Guid id)
        {
            if (!(await ValidateExistanceAsync()))
            {
                return NotFound();
            }

            ApplyParentBreadcrumbTitle();

            return await base.Edit(id);
        }

        [Breadcrumb(BreadcrumbParentTitlePlaceholder, true, 0, nameof(GetAll), UseParentController = true)]
        [Breadcrumb(BreadcrumbEntityNamePluralPlaceholder, true, 1, nameof(GetAll), ParentRouteKey = ParentRouteKeyPropertyName)]
        [Breadcrumb("Edit", false, 2)]
        public async override Task<IActionResult> Edit(Guid id, TEntityViewModel model)
        {
            if (!(await ValidateExistanceAsync()))
            {
                return NotFound();
            }

            ApplyParentBreadcrumbTitle();

            return await base.Edit(id, model);
        }

        protected override IGetAllQuery<TEntity, TEntityViewModel> GetGetAllQuery(int page, string searchQuery)
        {
            return new GetAllQuery<TEntity, TEntityViewModel>(page, searchQuery, ForeignKey, ForeignKeyValue);
        }

        protected override IDetailsQuery<TEntity, TEntityViewModel> GetDetailsQuery(Guid entityId)
        {
            return new DetailsQuery<TEntity, TEntityViewModel>(entityId, ForeignKey, ForeignKeyValue);
        }

        protected override ICreateCommand<TEntity, TEntityViewModel> GetCreateCommand(TEntityViewModel model)
        {
            return new CreateCommand<TEntity, TEntityViewModel>(model, ForeignKey, ForeignKeyValue);
        }

        protected override IEditCommand<TEntity, TEntityViewModel> GetEditCommand(Guid entityId, TEntityViewModel model)
        {
            return new EditCommand<TEntity, TEntityViewModel>(entityId, model, ForeignKey, ForeignKeyValue);
        }

        protected override IDeleteCommand<TEntity> GetDeleteCommand(Guid entityId)
        {
            return new DeleteCommand<TEntity>(entityId, ForeignKey, ForeignKeyValue);
        }

        protected override IActionResult RedirectToAll()
        {
            var routeValues = new RouteValueDictionary
            {
                { ParentRouteKey, ForeignKeyValue }
            };

            return RedirectToAction(nameof(GetAll), routeValues);
        }

        protected override IActionResult RedirectToDetails(Guid entityId)
        {
            var routeValues = new RouteValueDictionary
            {
                { "id", entityId },
                { ParentRouteKey, ForeignKeyValue }
            };

            return RedirectToAction(nameof(Details), ControllerName, routeValues);
        }

        protected void UpdateControllerRoute()
        {
            ControllerRoute = ControllerRoute.Replace("{" + ParentRouteKey + "}", ForeignKeyValue);
        }

        protected override List<TableRowActionViewModel> BuildTableViewActions()
        {
            UpdateControllerRoute();
            return base.BuildTableViewActions();
        }

        protected override List<NavigationActionViewModel> BuildTableViewNavigationActions()
        {
            UpdateControllerRoute();
            var actions = new List<NavigationActionViewModel>();
            if (HasGenericCreate)
            {
                actions.Add(new NavigationActionViewModel
                {
                    Name = $"Create {StringFunctions.SplitWordsByCapitalLetters(typeof(TEntity).Name)}",
                    ActionUrl = $"{ControllerRoute}create",
                    Icon = MaterialDesignIcons.Plus,
                    Method = System.Net.Http.HttpMethod.Get,
                });
            }

            return actions;
        }

        protected virtual async Task<bool> ValidateExistanceAsync()
        {
            try
            {
                return await Mediator.Send(new ExistsQuery<TParentEntity>(Guid.Parse(ForeignKeyValue)));
            }
            catch (Exception)
            {
                return false;
            }
        }

        protected void ApplyParentBreadcrumbTitle()
        {
            this.ViewData[BreadcrumbParentTitlePlaceholder] = StringFunctions.SplitWordsByCapitalLetters(typeof(TParentEntity).Name).ToPluralString();
        }
    }
}
