using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Definux.Utilities.Functions;
using Definux.Utilities.Extensions;
using Definux.Emeraude.Admin.Requests.GetAll;
using Definux.Emeraude.Admin.Requests.Details;
using Definux.Emeraude.Admin.Requests.Create;
using Definux.Emeraude.Admin.Requests.Edit;
using Definux.Emeraude.Admin.Requests.Delete;
using Definux.Emeraude.Admin.Requests.ApplyImage;
using Definux.Emeraude.Admin.Requests.GetEntityImage;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Form;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.DetailsCard;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Table;
using Definux.Emeraude.Admin.Mapping.Mappers;
using Definux.Emeraude.Admin.UI.ViewModels.Layout;
using Definux.Emeraude.Admin.Attributes;
using Definux.Utilities.Objects;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Admin.Utilities;

namespace Definux.Emeraude.Admin.Controllers.Abstractions
{
    public abstract class AdminEntityController<TEntity, TEntityViewModel> : AdminController, IAdminEntityController
        where TEntity : class, IEntity, new()
        where TEntityViewModel : class, new()
    {
        protected const string BreadcrumbPageTitlePlaceholder = "[PageTitle]";
        protected const string BreadcrumbEntityNamePluralPlaceholder = "[EntityNamePlural]";

        public AdminEntityController() 
        {
            EntityName = StringFunctions.SplitWordsByCapitalLetters(typeof(TEntity).Name);
        }

        [ViewData]
        public string EntityName { get; protected set; }

        protected bool HasGenericCreate { get; set; } = true;

        protected bool HasDetails { get; set; } = true;

        protected bool HasEdit { get; set; } = true;

        protected bool HasDelete { get; set; } = true;

        protected Func<Guid, string> DeleteRedirectUrlFunction { get; set; }

        /// <summary>
        /// Method that return the instance of IGetAllQuery for current entity and view-model.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="searchQuery"></param>
        /// <returns></returns>
        protected virtual IGetAllQuery<TEntity, TEntityViewModel> GetGetAllQuery(int page, string searchQuery)
        {
            return new GetAllQuery<TEntity, TEntityViewModel>(page, searchQuery);
        }
            
        protected async virtual Task<PaginatedList<TEntityViewModel>> GetAllEntitiesPaginatedAsync(int page, string query)
        {
            return await Mediator.Send(GetGetAllQuery(page, query));
        }

        [HttpGet]
        [Route("")]
        [Breadcrumb(BreadcrumbPageTitlePlaceholder, false, 0)]
        public virtual async Task<IActionResult> GetAll([FromQuery] int page = 1, [FromQuery] string searchQuery = null)
        {
            PaginatedList<TEntityViewModel> entitiesResult = await GetAllEntitiesPaginatedAsync(page, searchQuery);
            TableViewViewModel model = new TableViewViewModel();
            model.SingleEntityName = StringFunctions.SplitWordsByCapitalLetters(typeof(TEntity).Name);
            model.Title = model.SingleEntityName.ToPluralString();
            ViewData[BreadcrumbPageTitlePlaceholder] = model.Title;

            model.Table = EntityTableMapper.Map(entitiesResult, BuildTableViewActions()?.ToArray());
            model.Table.SetPaginationRedirection(AreaName, ControllerName, ActionName);
            ViewData.Add("SearchQuery", searchQuery);

            InitializeNavigationActions(BuildTableViewNavigationActions());

            return GetAllView(model);
        }

        /// <summary>
        /// Method that return the instance of IDetailsQuery for current entity and view-model.
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        protected virtual IDetailsQuery<TEntity, TEntityViewModel> GetDetailsQuery(Guid entityId)
        {
            return new DetailsQuery<TEntity, TEntityViewModel>(entityId);
        }

        protected virtual async Task<TEntityViewModel> GetEntityAsync(Guid entityId)
        {
            return await Mediator.Send(GetDetailsQuery(entityId));
        }

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

            TEntityViewModel entity = await GetEntityAsync(id);
            if (entity == null)
            {
                return NotFound();
            }

            EntityDetailsViewModel model = new EntityDetailsViewModel();
            model.Details = EntityDetailsCardMapper.Map(entity);
            string singleEntityName = StringFunctions.SplitWordsByCapitalLetters(typeof(TEntity).Name);
            this.ViewData[BreadcrumbEntityNamePluralPlaceholder] = singleEntityName.ToPluralString();

            return DetailsView(model);
        }

        [HttpGet]
        [Route("create")]
        [Breadcrumb(BreadcrumbEntityNamePluralPlaceholder, true, 0, nameof(GetAll))]
        [Breadcrumb("Create", false, 1)]
        public virtual async Task<IActionResult> Create()
        {
            if (!HasGenericCreate)
            {
                return NotFound();
            }

            ICreateEditEntityViewModel model = CastModel(new TEntityViewModel());

            return CreateEditView(model);
        }

        /// <summary>
        /// Method that return the instance of ICreateCommand for current entity and view-model.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual ICreateCommand<TEntity, TEntityViewModel> GetCreateCommand(TEntityViewModel model)
        {
            return new CreateCommand<TEntity, TEntityViewModel>(model);
        }

        protected virtual async Task<Guid?> CreateEntityAsync(TEntityViewModel model)
        {
            return await Mediator.Send(GetCreateCommand(model));
        }

        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        [Breadcrumb(BreadcrumbEntityNamePluralPlaceholder, true, 0, nameof(GetAll))]
        [Breadcrumb("Create", false, 1)]
        public virtual async Task<IActionResult> Create(TEntityViewModel model)
        {
            if (!HasGenericCreate)
            {
                return NotFound();
            }

            ICreateEditEntityViewModel castedModel = CastModel(model);

            if (ModelState.IsValid)
            {
                var createdEntityId = await CreateEntityAsync(model);
                if (createdEntityId.HasValue)
                {
                    await OnEntityCreatedAsync(createdEntityId.Value);
                    return RedirectToDetails(createdEntityId.Value);
                }
            }

            return CreateEditView(castedModel);
        }

        [HttpGet]
        [Route("{id}/edit")]
        [Breadcrumb(BreadcrumbEntityNamePluralPlaceholder, true, 0, nameof(GetAll))]
        [Breadcrumb("Edit", false, 1)]
        public virtual async Task<IActionResult> Edit(Guid id)
        {
            if (!HasEdit)
            {
                return NotFound();
            }

            ICreateEditEntityViewModel model = CastModel(await GetEntityAsync(id));
            if (model == null)
            {
                return NotFound();
            }

            return CreateEditView(model);
        }

        /// <summary>
        /// Method that return the instance of IEditCommand for current entity and view-model.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual IEditCommand<TEntity, TEntityViewModel> GetEditCommand(Guid entityId, TEntityViewModel model)
        {
            return new EditCommand<TEntity, TEntityViewModel>(entityId, model);
        }

        protected virtual async Task<Guid?> ModifyEntityAsync(Guid entityId, TEntityViewModel model)
        {
            return await Mediator.Send(GetEditCommand(entityId, model));
        }

        [HttpPost]
        [Route("{id}/edit")]
        [ValidateAntiForgeryToken]
        [Breadcrumb(BreadcrumbEntityNamePluralPlaceholder, true, 0, nameof(GetAll))]
        [Breadcrumb("Edit", false, 1)]
        public virtual async Task<IActionResult> Edit(Guid id, TEntityViewModel model)
        {
            if (!HasEdit)
            {
                return NotFound();
            }

            ICreateEditEntityViewModel castedModel = CastModel(model);

            if (ModelState.IsValid)
            {
                var modifiedEntityId = await ModifyEntityAsync(id, model);
                if (modifiedEntityId.HasValue)
                {
                    await OnEntityEditedAsync(modifiedEntityId.Value);
                    return RedirectToDetails(modifiedEntityId.Value);
                }
                else
                {
                    return BadRequest();
                }
            }

            return CreateEditView(castedModel);
        }

        /// <summary>
        /// Method that return the instance of IDeleteCommand for current entity and view-model.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual IDeleteCommand<TEntity> GetDeleteCommand(Guid entityId)
        {
            return new DeleteCommand<TEntity>(entityId);
        }

        protected async virtual Task<bool> DeleteEntityAsync(Guid entityId)
        {
            return await Mediator.Send(GetDeleteCommand(entityId));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("{id}/delete")]
        public virtual async Task<IActionResult> Delete(Guid id)
        {
            if (!HasDelete)
            {
                return NotFound();
            }

            bool isEntityDeleted = await DeleteEntityAsync(id);
            if (isEntityDeleted)
            {
                await OnEntityDeletedAsync(id);
                ShowSuccessNotification($"{EntityName} has been deleted successfully.");
            }
            else
            {
                ShowErrorNotification($"{EntityName} deletion failed.");
            }

            return RedirectToAll();
        }

        /// <summary>
        /// Build the default table view navigation actions.
        /// </summary>
        protected virtual List<NavigationActionViewModel> BuildTableViewNavigationActions()
        {
            var actions = new List<NavigationActionViewModel>();
            if (HasGenericCreate)
            {
                actions.Add(new NavigationActionViewModel
                {
                    Name = $"Create {EntityName}",
                    ActionUrl = $"{ControllerRoute}create",
                    Icon = MaterialDesignIcons.Plus,
                    Method = System.Net.Http.HttpMethod.Get,
                });
            }

            return actions;
        }

        /// <summary>
        /// Build the default table view actions.
        /// </summary>
        protected virtual List<TableRowActionViewModel> BuildTableViewActions()
        {
            var actions = new List<TableRowActionViewModel>();
            if (HasDetails)
            {
                actions.Add(EntityTableMapper.DetailsAction($"{ControllerRoute}{{0}}", "[Id]"));
            }

            if (HasEdit)
            {
                actions.Add(EntityTableMapper.EditAction($"{ControllerRoute}{{0}}/edit", "[Id]"));
            }

            if (HasDelete)
            {
                actions.Add(EntityTableMapper.DeleteAction($"{ControllerRoute}{{0}}/delete", "[Id]"));
            }

            return actions;
        }

        /// <summary>
        /// This methods is triggered when an entity is created successfully.
        /// </summary>
        /// <param name="entityId">Entity identifier</param>
        /// <returns></returns>
        protected virtual async Task OnEntityCreatedAsync(Guid entityId) { }

        /// <summary>
        /// This methods is triggered when an entity is edited successfully.
        /// </summary>
        /// <param name="entityId">Entity identifier</param>
        /// <returns></returns>
        protected virtual async Task OnEntityEditedAsync(Guid entityId) { }

        /// <summary>
        /// This methods is triggered when an entity is deleted successfully.
        /// </summary>
        /// <param name="entityId">Entity identifier</param>
        /// <returns></returns>
        protected virtual async Task OnEntityDeletedAsync(Guid entityId) { }

        /// <summary>
        /// Returns page number from query string of table view.
        /// </summary>
        /// <returns></returns>
        protected int GetHttpContextPageNumber()
        {
            int pageNumber = 1;
            int tempPageNumber = 0;
            if (HttpContext.Request.Query.ContainsKey("p") && int.TryParse(HttpContext.Request.Query["p"].ToString(), out tempPageNumber))
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
            if (HttpContext.Request.Query.ContainsKey("q"))
            {
                searchQuery = HttpContext.Request.Query["q"].ToString();
            }

            return searchQuery;
        }

        /// <summary>
        /// Get action used for visualization of image gallery of entity.
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entityId"></param>
        /// <param name="picturesUrls"></param>
        /// <param name="actionName">Name of the post action used for editing ImageUrl.</param>
        /// <returns></returns>
        protected virtual async Task<IActionResult> GetGalleryActionAsync<TEntityWithImage>(Guid entityId, List<string> picturesUrls, string actionName)
            where TEntityWithImage : class, IEntityWithImage, new()
        {
            SelectableGalleryViewModel model = new SelectableGalleryViewModel();
            model.Pictures = picturesUrls;
            model.SelectedPicture = await Mediator.Send(new GetEntityImageQuery<TEntityWithImage>(entityId));
            model.Controller = ControllerName;
            model.Action = actionName;

            return GalleryView(model);
        }

        /// <summary>
        /// Post action used for editing ImageUrl of entity.
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entityId"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual async Task<IActionResult> PostGalleryActionAsync<TEntityWithImage>(Guid entityId, SelectableGalleryViewModel model)
            where TEntityWithImage : class, IEntityWithImage, new()
        {
            bool applied = await Mediator.Send(new ApplyImageCommand<TEntityWithImage>(entityId, model.SelectedPicture));
            ShowComputationNotification(applied, "Image has been applied successfully.", "Image has not been applied.");

            return RedirectToAll();
        }

        /// <summary>
        /// Build action result to table view.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual IActionResult GetAllView(TableViewViewModel model)
        {
            return View("EntityViews/GetAll", model);
        }

        /// <summary>
        /// Build action result to details view.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual IActionResult DetailsView(EntityDetailsViewModel model)
        {
            return View("EntityViews/Details", model);
        }

        /// <summary>
        /// Build action result to create/edit view.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual IActionResult CreateEditView(ICreateEditEntityViewModel model)
        {
            return View("EntityViews/CreateEdit", model);
        }

        /// <summary>
        /// Build action result for gallery view.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual IActionResult GalleryView(SelectableGalleryViewModel model)
        {
            return View("EntityViews/SelectableGallery", model);
        }

        /// <summary>
        /// Redirects to table view.
        /// </summary>
        /// <returns></returns>
        protected virtual IActionResult RedirectToAll()
        {
            return RedirectToAction(nameof(GetAll));
        }

        /// <summary>
        /// Redirects to details view.
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        protected virtual IActionResult RedirectToDetails(Guid entityId)
        {
            return RedirectToAction(nameof(Details), ControllerName, new { id = entityId });
        }

        /// <summary>
        /// Set partial above the table of get all view.
        /// </summary>
        /// <param name="partialName"></param>
        protected void SetPartialAboveTheTable(string partialName)
        {
            ViewData["TableAbovePartial"] = partialName;
        }

        /// <summary>
        /// Set partial below the table of get all view.
        /// </summary>
        /// <param name="partialName"></param>
        protected void SetPartialBelowTheTable(string partialName)
        {
            ViewData["TableBelowPartial"] = partialName;
        }

        private ICreateEditEntityViewModel CastModel(TEntityViewModel model)
        {
            ICreateEditEntityViewModel castedModel = (ICreateEditEntityViewModel)model;
            if (castedModel != null)
            {
                castedModel.Inputs = EntityFormMapper.BuildInputs(castedModel);
                ViewData[BreadcrumbEntityNamePluralPlaceholder] = EntityName.ToPluralString();
            }

            return castedModel;
        }
    }
}
