using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.Mapping.Mappers;
using Definux.Emeraude.Admin.Requests.ApplyImage;
using Definux.Emeraude.Admin.Requests.Create;
using Definux.Emeraude.Admin.Requests.Delete;
using Definux.Emeraude.Admin.Requests.Details;
using Definux.Emeraude.Admin.Requests.Edit;
using Definux.Emeraude.Admin.Requests.GetAll;
using Definux.Emeraude.Admin.Requests.GetEntityImage;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.DetailsCard;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Form;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Table;
using Definux.Emeraude.Admin.UI.ViewModels.Layout;
using Definux.Emeraude.Admin.Utilities;
using Definux.Emeraude.Domain.Entities;
using Definux.Utilities.Extensions;
using Definux.Utilities.Functions;
using Definux.Utilities.Objects;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Admin.Controllers.Abstractions
{
    /// <summary>
    /// Admin controller that provides ready to use CRUD actions for specific entity and its view model.
    /// </summary>
    /// <typeparam name="TEntity">Entity from the domain model.</typeparam>
    /// <typeparam name="TEntityViewModel">View Model for selected entity.</typeparam>
    public abstract class AdminEntityController<TEntity, TEntityViewModel> : AdminController, IAdminEntityController
        where TEntity : class, IEntity, new()
        where TEntityViewModel : class, new()
    {
        /// <summary>
        /// Breadcrumb page title default placeholder for transferring custom page title to breadcrumbs list.
        /// </summary>
        protected const string BreadcrumbPageTitlePlaceholder = "[PageTitle]";

        /// <summary>
        /// Breadcrumb plural entity name default placeholder for transferring custom entity plural name to breadcrumbs list.
        /// </summary>
        protected const string BreadcrumbEntityNamePluralPlaceholder = "[EntityNamePlural]";

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminEntityController{TEntity, TEntityViewModel}"/> class.
        /// </summary>
        public AdminEntityController()
            : base()
        {
            this.EntityName = StringFunctions.SplitWordsByCapitalLetters(typeof(TEntity).Name);
        }

        /// <summary>
        /// Name of the controller entity.
        /// </summary>
        [ViewData]
        public string EntityName { get; protected set; }

        /// <summary>
        /// Flag that turn on/off the entity creation provided by the controller.
        /// </summary>
        protected bool HasCreate { get; set; } = true;

        /// <summary>
        /// Flag that turn on/off details page provided by the controller.
        /// </summary>
        protected bool HasDetails { get; set; } = true;

        /// <summary>
        /// Flag that turn on/off the entity modification provided by the controller.
        /// </summary>
        protected bool HasEdit { get; set; } = true;

        /// <summary>
        /// Flag that turn on/off the entity deletion provided by the controller.
        /// </summary>
        protected bool HasDelete { get; set; } = true;

        /// <summary>
        /// Deletion callback on success deletion of the entity.
        /// </summary>
        protected Func<Guid, string> DeleteRedirectUrlFunction { get; set; }

        /// <summary>
        /// Get all action.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="searchQuery"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        [Breadcrumb(BreadcrumbPageTitlePlaceholder, false, 0)]
        public virtual async Task<IActionResult> GetAll([FromQuery] int page = 1, [FromQuery] string searchQuery = null)
        {
            PaginatedList<TEntityViewModel> entitiesResult = await this.GetAllEntitiesPaginatedAsync(page, searchQuery);
            TableViewViewModel model = new TableViewViewModel();
            model.SingleEntityName = StringFunctions.SplitWordsByCapitalLetters(typeof(TEntity).Name);
            model.Title = model.SingleEntityName.ToPluralString();
            this.ViewData[BreadcrumbPageTitlePlaceholder] = model.Title;

            model.Table = EntityTableMapper.Map(entitiesResult, this.BuildTableViewActions()?.ToArray());
            model.Table.SetPaginationRedirection(this.AreaName, this.ControllerName, this.ActionName);
            this.ViewData.Add("SearchQuery", searchQuery);

            this.InitializeNavigationActions(this.BuildTableViewNavigationActions());

            return this.GetAllView(model);
        }

        /// <summary>
        /// Details action.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id:guid}")]
        [Breadcrumb(BreadcrumbEntityNamePluralPlaceholder, true, 0, nameof(GetAll))]
        [Breadcrumb("Details", false, 1)]
        public virtual async Task<IActionResult> Details(Guid id)
        {
            if (!this.HasDetails)
            {
                return this.NotFound();
            }

            TEntityViewModel entity = await this.GetEntityAsync(id);
            if (entity == null)
            {
                return this.NotFound();
            }

            EntityDetailsViewModel model = new EntityDetailsViewModel();
            model.Details = EntityDetailsCardMapper.Map(entity);
            string singleEntityName = StringFunctions.SplitWordsByCapitalLetters(typeof(TEntity).Name);
            this.ViewData[BreadcrumbEntityNamePluralPlaceholder] = singleEntityName.ToPluralString();

            return this.DetailsView(model);
        }

        /// <summary>
        /// Create action for GET request.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("create")]
        [Breadcrumb(BreadcrumbEntityNamePluralPlaceholder, true, 0, nameof(GetAll))]
        [Breadcrumb("Create", false, 1)]
        public virtual async Task<IActionResult> Create()
        {
            if (!this.HasCreate)
            {
                return this.NotFound();
            }

            ICreateEditEntityViewModel model = this.CastModel(new TEntityViewModel());

            return this.CreateEditView(model);
        }

        /// <summary>
        /// Create action for POST request.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        [Breadcrumb(BreadcrumbEntityNamePluralPlaceholder, true, 0, nameof(GetAll))]
        [Breadcrumb("Create", false, 1)]
        public virtual async Task<IActionResult> Create(TEntityViewModel model)
        {
            if (!this.HasCreate)
            {
                return this.NotFound();
            }

            ICreateEditEntityViewModel castedModel = this.CastModel(model);

            if (this.ModelState.IsValid)
            {
                var createdEntityId = await this.CreateEntityAsync(model);
                if (createdEntityId.HasValue)
                {
                    await this.OnEntityCreatedAsync(createdEntityId.Value);
                    return this.RedirectToDetails(createdEntityId.Value);
                }
            }

            return this.CreateEditView(castedModel);
        }

        /// <summary>
        /// Edit action for GET request.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}/edit")]
        [Breadcrumb(BreadcrumbEntityNamePluralPlaceholder, true, 0, nameof(GetAll))]
        [Breadcrumb("Edit", false, 1)]
        public virtual async Task<IActionResult> Edit(Guid id)
        {
            if (!this.HasEdit)
            {
                return this.NotFound();
            }

            ICreateEditEntityViewModel model = this.CastModel(await this.GetEntityAsync(id));
            if (model == null)
            {
                return this.NotFound();
            }

            return this.CreateEditView(model);
        }

        /// <summary>
        /// Edit action for POST request..
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("{id}/edit")]
        [ValidateAntiForgeryToken]
        [Breadcrumb(BreadcrumbEntityNamePluralPlaceholder, true, 0, nameof(GetAll))]
        [Breadcrumb("Edit", false, 1)]
        public virtual async Task<IActionResult> Edit(Guid id, TEntityViewModel model)
        {
            if (!this.HasEdit)
            {
                return this.NotFound();
            }

            ICreateEditEntityViewModel castedModel = this.CastModel(model);

            if (this.ModelState.IsValid)
            {
                var modifiedEntityId = await this.ModifyEntityAsync(id, model);
                if (modifiedEntityId.HasValue)
                {
                    await this.OnEntityEditedAsync(modifiedEntityId.Value);
                    return this.RedirectToDetails(modifiedEntityId.Value);
                }
                else
                {
                    return this.BadRequest();
                }
            }

            return this.CreateEditView(castedModel);
        }

        /// <summary>
        /// Delete action.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("{id}/delete")]
        public virtual async Task<IActionResult> Delete(Guid id)
        {
            if (!this.HasDelete)
            {
                return this.NotFound();
            }

            bool isEntityDeleted = await this.DeleteEntityAsync(id);
            if (isEntityDeleted)
            {
                await this.OnEntityDeletedAsync(id);
                this.ShowSuccessNotification($"{this.EntityName} has been deleted successfully.");
            }
            else
            {
                this.ShowErrorNotification($"{this.EntityName} deletion failed.");
            }

            return this.RedirectToAll();
        }

        /// <summary>
        /// Method that return the instance of <see cref="IGetAllQuery{TEntity, TRequestModel}"/> for current entity and view-model.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="searchQuery"></param>
        /// <returns></returns>
        protected virtual IGetAllQuery<TEntity, TEntityViewModel> GetGetAllQuery(int page, string searchQuery)
        {
            return new GetAllQuery<TEntity, TEntityViewModel>(page, searchQuery);
        }

        /// <summary>
        /// Get all action executor.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        protected async virtual Task<PaginatedList<TEntityViewModel>> GetAllEntitiesPaginatedAsync(int page, string query)
        {
            return await this.Mediator.Send(this.GetGetAllQuery(page, query));
        }

        /// <summary>
        /// Method that return the instance of <see cref="IDetailsQuery{TEntity, TRequestModel}"/> for current entity and view-model.
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        protected virtual IDetailsQuery<TEntity, TEntityViewModel> GetDetailsQuery(Guid entityId)
        {
            return new DetailsQuery<TEntity, TEntityViewModel>(entityId);
        }

        /// <summary>
        /// Details action executor.
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        protected virtual async Task<TEntityViewModel> GetEntityAsync(Guid entityId)
        {
            return await this.Mediator.Send(this.GetDetailsQuery(entityId));
        }

        /// <summary>
        /// Method that return the instance of <see cref="ICreateCommand{TEntity, TRequestModel}"/> for current entity and view-model.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual ICreateCommand<TEntity, TEntityViewModel> GetCreateCommand(TEntityViewModel model)
        {
            return new CreateCommand<TEntity, TEntityViewModel>(model);
        }

        /// <summary>
        /// Create action executor.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual async Task<Guid?> CreateEntityAsync(TEntityViewModel model)
        {
            return await this.Mediator.Send(this.GetCreateCommand(model));
        }

        /// <summary>
        /// Method that return the instance of <see cref="IEditCommand{TEntity, TRequestModel}"/> for current entity and view-model.
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual IEditCommand<TEntity, TEntityViewModel> GetEditCommand(Guid entityId, TEntityViewModel model)
        {
            return new EditCommand<TEntity, TEntityViewModel>(entityId, model);
        }

        /// <summary>
        /// Edit action executor.
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual async Task<Guid?> ModifyEntityAsync(Guid entityId, TEntityViewModel model)
        {
            return await this.Mediator.Send(this.GetEditCommand(entityId, model));
        }

        /// <summary>
        /// Method that return the instance of <see cref="IDeleteCommand{TEntity}"/> for current entity and view-model.
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        protected virtual IDeleteCommand<TEntity> GetDeleteCommand(Guid entityId)
        {
            return new DeleteCommand<TEntity>(entityId);
        }

        /// <summary>
        /// Delete action executor.
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        protected async virtual Task<bool> DeleteEntityAsync(Guid entityId)
        {
            return await this.Mediator.Send(this.GetDeleteCommand(entityId));
        }

        /// <summary>
        /// Build the default table view navigation actions.
        /// </summary>
        /// <returns></returns>
        protected virtual List<NavigationActionViewModel> BuildTableViewNavigationActions()
        {
            var actions = new List<NavigationActionViewModel>();
            if (this.HasCreate)
            {
                actions.Add(new NavigationActionViewModel
                {
                    Name = $"Create {this.EntityName}",
                    ActionUrl = $"{this.ControllerRoute}create",
                    Icon = MaterialDesignIcons.Plus,
                    Method = System.Net.Http.HttpMethod.Get,
                });
            }

            return actions;
        }

        /// <summary>
        /// Build the default table view actions.
        /// </summary>
        /// <returns></returns>
        protected virtual List<TableRowActionViewModel> BuildTableViewActions()
        {
            var actions = new List<TableRowActionViewModel>();
            if (this.HasDetails)
            {
                actions.Add(EntityTableMapper.DetailsAction($"{this.ControllerRoute}{{0}}", "[Id]"));
            }

            if (this.HasEdit)
            {
                actions.Add(EntityTableMapper.EditAction($"{this.ControllerRoute}{{0}}/edit", "[Id]"));
            }

            if (this.HasDelete)
            {
                actions.Add(EntityTableMapper.DeleteAction($"{this.ControllerRoute}{{0}}/delete", "[Id]"));
            }

            return actions;
        }

        /// <summary>
        /// This methods is triggered when an entity is created successfully.
        /// </summary>
        /// <param name="entityId">Entity identifier.</param>
        /// <returns></returns>
        protected virtual async Task OnEntityCreatedAsync(Guid entityId)
        {
        }

        /// <summary>
        /// This methods is triggered when an entity is edited successfully.
        /// </summary>
        /// <param name="entityId">Entity identifier.</param>
        /// <returns></returns>
        protected virtual async Task OnEntityEditedAsync(Guid entityId)
        {
        }

        /// <summary>
        /// This methods is triggered when an entity is deleted successfully.
        /// </summary>
        /// <param name="entityId">Entity identifier.</param>
        /// <returns></returns>
        protected virtual async Task OnEntityDeletedAsync(Guid entityId)
        {
        }

        /// <summary>
        /// Returns page number from query string of table view.
        /// </summary>
        /// <returns></returns>
        protected int GetHttpContextPageNumber()
        {
            int pageNumber = 1;
            int tempPageNumber = 0;
            if (this.HttpContext.Request.Query.ContainsKey("p") && int.TryParse(this.HttpContext.Request.Query["p"].ToString(), out tempPageNumber))
            {
                pageNumber = tempPageNumber;
            }

            return pageNumber;
        }

        /// <summary>
        /// Returns search query from query string of table view.
        /// </summary>
        /// <returns></returns>
        protected virtual string GetHttpContextSearchQuery()
        {
            string searchQuery = string.Empty;
            if (this.HttpContext.Request.Query.ContainsKey("q"))
            {
                searchQuery = this.HttpContext.Request.Query["q"].ToString();
            }

            return searchQuery;
        }

        /// <summary>
        /// Get action used for visualization of image gallery of entity.
        /// </summary>
        /// <typeparam name="TEntityWithImage">Entity that implements <see cref="IEntityWithImage"/>.</typeparam>
        /// <param name="entityId"></param>
        /// <param name="picturesUrls"></param>
        /// <param name="actionName">Name of the post action used for editing ImageUrl.</param>
        /// <returns></returns>
        protected virtual async Task<IActionResult> GetGalleryActionAsync<TEntityWithImage>(Guid entityId, List<string> picturesUrls, string actionName)
            where TEntityWithImage : class, IEntityWithImage, new()
        {
            SelectableGalleryViewModel model = new SelectableGalleryViewModel();
            model.Pictures = picturesUrls;
            model.SelectedPicture = await this.Mediator.Send(new GetEntityImageQuery<TEntityWithImage>(entityId));
            model.Controller = this.ControllerName;
            model.Action = actionName;

            return this.GalleryView(model);
        }

        /// <summary>
        /// Post action used for editing ImageUrl of entity.
        /// </summary>
        /// <typeparam name="TEntityWithImage">Entity that implements <see cref="IEntityWithImage"/>.</typeparam>
        /// <param name="entityId"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual async Task<IActionResult> PostGalleryActionAsync<TEntityWithImage>(Guid entityId, SelectableGalleryViewModel model)
            where TEntityWithImage : class, IEntityWithImage, new()
        {
            bool applied = await this.Mediator.Send(new ApplyImageCommand<TEntityWithImage>(entityId, model.SelectedPicture));
            this.ShowComputationNotification(applied, "Image has been applied successfully.", "Image has not been applied.");

            return this.RedirectToAll();
        }

        /// <summary>
        /// Build action result to table view.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual IActionResult GetAllView(TableViewViewModel model)
        {
            return this.View("EntityViews/GetAll", model);
        }

        /// <summary>
        /// Build action result to details view.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual IActionResult DetailsView(EntityDetailsViewModel model)
        {
            return this.View("EntityViews/Details", model);
        }

        /// <summary>
        /// Build action result to create/edit view.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual IActionResult CreateEditView(ICreateEditEntityViewModel model)
        {
            return this.View("EntityViews/CreateEdit", model);
        }

        /// <summary>
        /// Build action result for gallery view.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual IActionResult GalleryView(SelectableGalleryViewModel model)
        {
            return this.View("EntityViews/SelectableGallery", model);
        }

        /// <summary>
        /// Redirects to table view.
        /// </summary>
        /// <returns></returns>
        protected virtual IActionResult RedirectToAll()
        {
            return this.RedirectToAction(nameof(this.GetAll));
        }

        /// <summary>
        /// Redirects to details view.
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        protected virtual IActionResult RedirectToDetails(Guid entityId)
        {
            return this.RedirectToAction(nameof(this.Details), this.ControllerName, new { id = entityId });
        }

        /// <summary>
        /// Set partial above the table of get all view.
        /// </summary>
        /// <param name="partialName"></param>
        protected void SetPartialAboveTheTable(string partialName)
        {
            this.ViewData["TableAbovePartial"] = partialName;
        }

        /// <summary>
        /// Set partial below the table of get all view.
        /// </summary>
        /// <param name="partialName"></param>
        protected void SetPartialBelowTheTable(string partialName)
        {
            this.ViewData["TableBelowPartial"] = partialName;
        }

        private ICreateEditEntityViewModel CastModel(TEntityViewModel model)
        {
            ICreateEditEntityViewModel castedModel = (ICreateEditEntityViewModel)model;
            if (castedModel != null)
            {
                castedModel.Inputs = EntityFormMapper.BuildInputs(castedModel);
                this.ViewData[BreadcrumbEntityNamePluralPlaceholder] = this.EntityName.ToPluralString();
            }

            return castedModel;
        }
    }
}