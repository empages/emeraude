using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.Controllers.Abstractions;
using Definux.Emeraude.Admin.Models;
using Definux.Emeraude.Admin.Requests.AssignRolesToUser;
using Definux.Emeraude.Admin.UI.ViewModels.Crud.Table;
using Definux.Emeraude.Admin.UI.ViewModels.Users;
using Definux.Emeraude.Admin.Utilities;
using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Identity.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.Controllers.Mvc
{
    [Route("/admin/users/")]
    public class AdminUsersController : AdminCrudController<User, UserViewModel>
    {
        private readonly IUserManager userManager;
        private readonly IRoleManager roleManager;
        private readonly IUserTokensService userTokensService;

        public AdminUsersController(
            IUserManager userManager, 
            IRoleManager roleManager, 
            IUserTokensService userTokensService)
        {
            HasGenericCreate = false;
            HasEdit = false;

            this.userManager = userManager;
            this.roleManager = roleManager;
            this.userTokensService = userTokensService;
        }

        [HttpGet]
        [Route("{userId}/roles")]
        [Breadcrumb("Users", true, 0, "GetAll", "AdminUsers")]
        [Breadcrumb("[UserName]", false, 1)]
        [Breadcrumb("Roles", false, 2)]
        public async Task<IActionResult> Roles(Guid userId)
        {
            var user = await this.userManager.FindUserByIdAsync(userId);
            if (user != null)
            {
                ViewData["[UserName]"] = user.Name;

                var model = new RolesViewModel();
                model.SetRoleOptions(await this.roleManager.GetRolesAsync());
                model.SetSelectedRoles(await this.roleManager.GetUserRolesAsync(user));

                return View(model);
            }

            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("{userId}/roles")]
        [Breadcrumb("Users", true, 0, "GetAll", "AdminUsers")]
        [Breadcrumb("[UserName]", false, 1)]
        [Breadcrumb("Roles", false, 2)]
        public async Task<IActionResult> Roles(Guid userId, RolesViewModel model)
        {
            var user = await this.userManager.FindUserByIdAsync(userId);
            if (user != null)
            {
                var result = await Mediator.Send(new AssignRolesToUserCommand(user.Id, model?.SelectedRoles));
                if (result.Success)
                {
                    ShowSuccessNotification($"Roles have been assigned successfully to {user.Name}");
                    
                    return RedirectToAction(nameof(GetAll));
                }
                else
                {
                    ShowErrorNotification("Roles have not been assigned successfully.");
                    model.SetRoleOptions(await this.roleManager.GetRolesAsync());

                    return View(model);
                }
            }

            return NotFound();
        }

        [HttpPost]
        [Route("{userId}/reset-refresh-token")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetRefreshToken(Guid userId)
        {
            var isRefreshed = await userTokensService.ResetRefreshTokenAsync(userId);
            if (isRefreshed)
            {
                ShowSuccessNotification("Reset token has been refreshed successfully.");
            }
            else
            {
                ShowErrorNotification("Reset token has not been refreshed successfully.");
            }

            return RedirectToAction(nameof(GetAll));
        }

        protected override List<TableRowActionViewModel> BuildTableViewActions()
        {
            var actions = base.BuildTableViewActions();

            actions.Insert(1, new TableRowActionViewModel(
                "Roles",
                MaterialDesignIcons.AccountBadgeHorizontal,
                BuildControllerRoute("{0}/roles"),
                new List<string> { "[Id]" }));

            actions.Insert(2, new TableRowActionViewModel(
                "Reset Refresh Token",
                MaterialDesignIcons.Refresh,
                BuildControllerRoute("{0}/reset-refresh-token"),
                new List<string> { "[Id]" },
                TableRowActionMethod.Post)
            { 
                HasConfirmation = true,
                ConfirmationTitle = "Reset Refresh Token",
                ConfirmationMessage = "Are you sure you want to reset refresh token of this user?"
            });

            return actions;
        }
    }
}
