using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.Controllers.Abstractions;
using Definux.Emeraude.Admin.UI.Utilities;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Form;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Table;
using Definux.Emeraude.Admin.Utilities;
using EmDoggo.Application.Interfaces;
using EmDoggo.Application.Models.Admin.Foods;
using EmDoggo.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmDoggo.Controllers.Admin
{
    [Route("/admin/foods/")]
    public class AdminFoodsController : AdminEntityController<Food, FoodViewModel>
    {
        private readonly IHelperService helperService;
        public AdminFoodsController(IHelperService helperService)
        {
            this.helperService = helperService;
        }

        [HttpGet]
        [Route("{foodId:guid}/gallery")]
        [Breadcrumb("Foods", true, 0, nameof(GetAll))]
        [Breadcrumb("Gallery", false, 1)]
        public async Task<IActionResult> Gallery(Guid foodId)
        {
            return await GetGalleryActionAsync<Food>(
                foodId,
                this.helperService.GetFoodPictures(foodId),
                nameof(Gallery));
        }

        [HttpPost]
        [Route("{foodId:guid}/gallery")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Gallery(Guid foodId, SelectableGalleryViewModel model)
        {
            return await PostGalleryActionAsync<Food>(foodId, model);
        }

        protected override List<TableRowActionViewModel> BuildTableViewActions()
        {
            var actions = base.BuildTableViewActions();

            string searchQuery = GetHttpContextSearchQuery();
            int pageNumber = GetHttpContextPageNumber();
            string returnUrl = UrlEncoder.Encode($"/admin/foods?p={pageNumber}&q={searchQuery}");
            string returnTitle = UrlEncoder.Encode("Foods");

            actions.Insert(1, new TableRowActionViewModel
            {
                Title = "Upload Images",
                Icon = MaterialDesignIcons.ImagePlus,
                Method = TableRowActionMethod.Get,
                UrlStringFormat = $"/admin/roots/public/upload-files/uploads/images/foods/{{0}}?returnUrl={returnUrl}&returnTitle={returnTitle}",
                RawParameters = new List<string> { "[Id]" },
            });

            actions.Insert(2, new TableRowActionViewModel
            {
                Title = "Select From Gallery",
                Icon = MaterialDesignIcons.ImageMove,
                Method = TableRowActionMethod.Get,
                UrlStringFormat = $"{this.ControllerRoute}{{0}}/gallery",
                RawParameters = new List<string> { "[Id]" },
            });

            return actions;
        }

        protected override async Task OnEntityCreatedAsync(Guid entityId)
        {
            this.helperService.CreateFoodGalleryFolder(entityId);
        }

        protected override async Task OnEntityDeletedAsync(Guid entityId)
        {
            this.helperService.DeleteFoodGalleryFolder(entityId);
        }
    }
}
