using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.Requests.Create;
using Definux.Emeraude.Admin.Requests.Delete;
using Definux.Emeraude.Admin.Requests.Details;
using Definux.Emeraude.Admin.Requests.Edit;
using Definux.Emeraude.Admin.Requests.Exists;
using Definux.Emeraude.Admin.Requests.GetAll;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Table;
using Definux.Emeraude.Admin.UI.ViewModels.Layout;
using Definux.Emeraude.Admin.Utilities;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Presentation.Controllers;
using Definux.Utilities.Extensions;
using Definux.Utilities.Functions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Definux.Emeraude.Admin.Controllers.Abstractions
{
    /// <summary>
    /// Child admin controller of Entity Admin Controller that provides ready to use CRUD actions for specific entity and its view model with behavior of child controller.
    /// </summary>
    /// <typeparam name="TEntity">Entity from the domain model.</typeparam>
    /// <typeparam name="TEntityViewModel">View Model for selected entity.</typeparam>
    /// <typeparam name="TParentEntity">Parent entity from the parent controller.</typeparam>
    /// <typeparam name="TParentController">Parent controller which must be Entity Admin Controller.</typeparam>
    public abstract class AdminChildEntityController<TEntity, TEntityViewModel, TParentEntity, TParentController> : AdminEntityController<TEntity, TEntityViewModel>, IChildController
        where TEntity : class, IEntity, new()
        where TEntityViewModel : class, new()
        where TParentEntity : class, IEntity, new()
        where TParentController : class
    {
        /// <summary>
        /// Parent route key property name. Used for inner processing of the controller.
        /// </summary>
        protected const string ParentRouteKeyPropertyName = "ParentRouteKey";

        /// <summary>
        /// Breadcrumb parent title placeholder for transferring custom parent title to breadcrumbs list.
        /// </summary>
        protected const string BreadcrumbParentTitlePlaceholder = "[ParentBreadcrumbTitle]";

        /// <summary>
        /// Name of the parent controller.
        /// </summary>
        public string ParentController => typeof(TParentController).Name;

        /// <summary>
        /// Route key that defines the parent identification into the URL.
        /// </summary>
        protected abstract string ParentRouteKey { get; }

        /// <summary>
        /// Parent property from the target entity.
        /// </summary>
        protected abstract string ParentProperty { get; }

        /// <summary>
        /// Expression of the property from the child entity that referenced the parent entity. Comparison has to be made with <see cref="ParentIdentifier"/>.
        /// </summary>
        protected abstract Expression<Func<TEntity, bool>> ParentExpression { get; }

        /// <summary>
        /// Identification of the parent entity which will be extracted by the <see cref="ParentRouteKey"/> from the route values.
        /// </summary>
        protected Guid ParentIdentifier
        {
            get
            {
                string parentIdentifierString = this.HttpContext.Request.RouteValues[this.ParentRouteKey]?.ToString() ?? string.Empty;
                Guid.TryParse(parentIdentifierString, out Guid parentIdentifier);
                return parentIdentifier;
            }
        }

        /// <inheritdoc/>
        [Breadcrumb(BreadcrumbParentTitlePlaceholder, true, 0, nameof(GetAll), UseParentController = true)]
        [Breadcrumb(BreadcrumbPageTitlePlaceholder, false, 1)]
        public override async Task<IActionResult> GetAll(
            [FromQuery] int page = 1,
            [FromQuery] string searchQuery = null,
            [FromQuery] string orderBy = null,
            [FromQuery] string orderType = null)
        {
            if (!(await this.ValidateExistenceAsync()))
            {
                return this.NotFound();
            }

            this.ApplyParentBreadcrumbTitle();

            return await base.GetAll(page, searchQuery, orderBy, orderType);
        }

        /// <inheritdoc/>
        [Breadcrumb(BreadcrumbParentTitlePlaceholder, true, 0, nameof(GetAll), UseParentController = true)]
        [Breadcrumb(BreadcrumbEntityNamePluralPlaceholder, true, 1, nameof(GetAll), ParentRouteKey = ParentRouteKeyPropertyName)]
        [Breadcrumb("Details", false, 2)]
        public override async Task<IActionResult> Details(Guid id)
        {
            if (!(await this.ValidateExistenceAsync()))
            {
                return this.NotFound();
            }

            this.ApplyParentBreadcrumbTitle();

            return await base.Details(id);
        }

        /// <inheritdoc/>
        [Breadcrumb(BreadcrumbParentTitlePlaceholder, true, 0, nameof(GetAll), UseParentController = true)]
        [Breadcrumb(BreadcrumbEntityNamePluralPlaceholder, true, 1, nameof(GetAll), ParentRouteKey = ParentRouteKeyPropertyName)]
        [Breadcrumb("Create", false, 2)]
        public override async Task<IActionResult> Create()
        {
            if (!(await this.ValidateExistenceAsync()))
            {
                return this.NotFound();
            }

            this.ApplyParentBreadcrumbTitle();

            return await base.Create();
        }

        /// <inheritdoc/>
        [Breadcrumb(BreadcrumbParentTitlePlaceholder, true, 0, nameof(GetAll), UseParentController = true)]
        [Breadcrumb(BreadcrumbEntityNamePluralPlaceholder, true, 1, nameof(GetAll), ParentRouteKey = ParentRouteKeyPropertyName)]
        [Breadcrumb("Create", false, 2)]
        public override async Task<IActionResult> Create(TEntityViewModel model)
        {
            if (!(await this.ValidateExistenceAsync()))
            {
                return this.NotFound();
            }

            this.ApplyParentBreadcrumbTitle();

            return await base.Create(model);
        }

        /// <inheritdoc/>
        [Breadcrumb(BreadcrumbParentTitlePlaceholder, true, 0, nameof(GetAll), UseParentController = true)]
        [Breadcrumb(BreadcrumbEntityNamePluralPlaceholder, true, 1, nameof(GetAll), ParentRouteKey = ParentRouteKeyPropertyName)]
        [Breadcrumb("Edit", false, 2)]
        public override async Task<IActionResult> Edit(Guid id)
        {
            if (!(await this.ValidateExistenceAsync()))
            {
                return this.NotFound();
            }

            this.ApplyParentBreadcrumbTitle();

            return await base.Edit(id);
        }

        /// <inheritdoc/>
        [Breadcrumb(BreadcrumbParentTitlePlaceholder, true, 0, nameof(GetAll), UseParentController = true)]
        [Breadcrumb(BreadcrumbEntityNamePluralPlaceholder, true, 1, nameof(GetAll), ParentRouteKey = ParentRouteKeyPropertyName)]
        [Breadcrumb("Edit", false, 2)]
        public override async Task<IActionResult> Edit(Guid id, TEntityViewModel model)
        {
            if (!(await this.ValidateExistenceAsync()))
            {
                return this.NotFound();
            }

            this.ApplyParentBreadcrumbTitle();

            return await base.Edit(id, model);
        }

        /// <inheritdoc/>
        protected override IGetAllQuery<TEntity, TEntityViewModel> GetGetAllQuery(
            int page,
            string searchQuery,
            string orderBy,
            string orderType)
        {
            return new GetAllQuery<TEntity, TEntityViewModel>(page, searchQuery, this.ParentExpression)
            {
                OrderBy = orderBy,
                OrderType = orderType,
            };
        }

        /// <inheritdoc/>
        protected override IDetailsQuery<TEntity, TEntityViewModel> GetDetailsQuery(Guid entityId)
        {
            return new DetailsQuery<TEntity, TEntityViewModel>(entityId, this.ParentExpression);
        }

        /// <inheritdoc/>
        protected override ICreateCommand<TEntity, TEntityViewModel> GetCreateCommand(TEntityViewModel model)
        {
            return new CreateCommand<TEntity, TEntityViewModel>(model, this.ParentProperty, this.ParentIdentifier);
        }

        /// <inheritdoc/>
        protected override IEditCommand<TEntity, TEntityViewModel> GetEditCommand(Guid entityId, TEntityViewModel model)
        {
            return new EditCommand<TEntity, TEntityViewModel>(entityId, model, this.ParentExpression);
        }

        /// <inheritdoc/>
        protected override IDeleteCommand<TEntity> GetDeleteCommand(Guid entityId)
        {
            return new DeleteCommand<TEntity>(entityId, this.ParentExpression);
        }

        /// <inheritdoc/>
        protected override IActionResult RedirectToAll()
        {
            var routeValues = new RouteValueDictionary
            {
                { this.ParentRouteKey, this.ParentIdentifier },
            };

            return this.RedirectToAction(nameof(this.GetAll), routeValues);
        }

        /// <inheritdoc/>
        protected override IActionResult RedirectToDetails(Guid entityId)
        {
            var routeValues = new RouteValueDictionary
            {
                { "id", entityId },
                { this.ParentRouteKey, this.ParentIdentifier },
            };

            return this.RedirectToAction(nameof(this.Details), this.ControllerName, routeValues);
        }

        /// <summary>
        /// Update the controller route with the parent reference.
        /// </summary>
        protected void UpdateControllerRoute()
        {
            this.ControllerRoute = this.ControllerRoute.Replace($"{{{this.ParentRouteKey}}}", this.ParentIdentifier.ToString());
        }

        /// <inheritdoc/>
        protected override List<TableRowActionViewModel> BuildTableViewActions()
        {
            this.UpdateControllerRoute();
            return base.BuildTableViewActions();
        }

        /// <inheritdoc/>
        protected override List<NavigationActionViewModel> BuildTableViewNavigationActions()
        {
            this.UpdateControllerRoute();
            var actions = new List<NavigationActionViewModel>();
            if (this.HasCreate)
            {
                actions.Add(new NavigationActionViewModel
                {
                    Name = $"Create {StringFunctions.SplitWordsByCapitalLetters(typeof(TEntity).Name)}",
                    ActionUrl = $"{this.ControllerRoute}create",
                    Icon = MaterialDesignIcons.Plus,
                    Method = System.Net.Http.HttpMethod.Get,
                });
            }

            return actions;
        }

        /// <summary>
        /// Check the existence of the parent entity of the controller.
        /// </summary>
        /// <returns></returns>
        protected virtual async Task<bool> ValidateExistenceAsync()
        {
            try
            {
                return await this.Mediator.Send(new ExistsQuery<TParentEntity>(this.ParentIdentifier));
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Apply the title of the parent entity into the breadcrumbs.
        /// </summary>
        protected void ApplyParentBreadcrumbTitle()
        {
            this.ViewData[BreadcrumbParentTitlePlaceholder] = StringFunctions.SplitWordsByCapitalLetters(typeof(TParentEntity).Name).ToPluralString();
        }
    }
}
