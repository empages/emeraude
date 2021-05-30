using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.Controllers.Abstractions;
using Definux.Emeraude.Admin.Models;
using Definux.Emeraude.Admin.Requests.AssignRolesToUser;
using Definux.Emeraude.Admin.UI.Utilities;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Table;
using Definux.Emeraude.Admin.UI.ViewModels.Users;
using Definux.Emeraude.Admin.Utilities;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Identity.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ClaimTypes = Definux.Emeraude.Configuration.Authorization.ClaimTypes;

namespace Definux.Emeraude.Admin.Controllers.Mvc
{
    /// <summary>
    /// Admin controller for managing application users into the system.
    /// </summary>
    [Route("/admin/users/")]
    [Authorize(Policy = AdminPermissions.UsersManagementPolicy)]
    public sealed class AdminUsersController : AdminEntityController<User, UserViewModel>
    {
        private readonly IUserManager userManager;
        private readonly IRoleManager roleManager;
        private readonly IUserTokensService userTokensService;
        private readonly IUserClaimsService userClaimsService;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminUsersController"/> class.
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="roleManager"></param>
        /// <param name="userTokensService"></param>
        /// <param name="userClaimsService"></param>
        public AdminUsersController(
            IUserManager userManager,
            IRoleManager roleManager,
            IUserTokensService userTokensService,
            IUserClaimsService userClaimsService)
        {
            this.HasCreate = false;
            this.HasEdit = false;

            this.userManager = userManager;
            this.roleManager = roleManager;
            this.userTokensService = userTokensService;
            this.userClaimsService = userClaimsService;
        }

        /// <summary>
        /// Roles action for GET request.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
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
                this.ViewData["[UserName]"] = user.Name;

                var model = new RolesViewModel();
                model.SetRoleOptions(await this.roleManager.GetRolesAsync());
                model.SetSelectedRoles(await this.roleManager.GetUserRolesAsync(user));

                return this.View(model);
            }

            return this.NotFound();
        }

        /// <summary>
        /// Roles action for POST request.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="model"></param>
        /// <returns></returns>
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
                var result = await this.Mediator.Send(new AssignRolesToUserCommand(user.Id, model?.SelectedRoles));
                if (result.Succeeded)
                {
                    this.ShowSuccessNotification($"Roles have been assigned successfully to {user.Name}");
                    return this.RedirectToAction(nameof(this.GetAll));
                }
                else
                {
                    this.ShowErrorNotification("Roles have not been assigned successfully.");
                    model.SetRoleOptions(await this.roleManager.GetRolesAsync());
                    return this.View(model);
                }
            }

            return this.NotFound();
        }

        /// <summary>
        /// Reset refresh token action.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("{userId}/reset-refresh-token")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetRefreshToken(Guid userId)
        {
            var isRefreshed = await this.userTokensService.ResetRefreshTokenAsync(userId);
            if (isRefreshed)
            {
                this.ShowSuccessNotification("Reset token has been refreshed successfully.");
            }
            else
            {
                this.ShowErrorNotification("Reset token has not been refreshed successfully.");
            }

            return this.RedirectToAction(nameof(this.GetAll));
        }

        /// <summary>
        /// Imitate user for test purposes.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("{userId}/imitate")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ImitateUser(Guid userId)
        {
            var claims = await this.userClaimsService.GetUserClaimsForCookieAsync(userId);
            claims.Add(new Claim(ClaimTypes.Imitate, "true"));
            var claimsIdentity = new ClaimsIdentity(claims, AuthenticationDefaults.AdminAuthenticationScheme);
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            var authenticationProperties = new AuthenticationProperties
            {
                IsPersistent = true,
                ExpiresUtc = DateTime.UtcNow.AddHours(2),
            };

            await this.HttpContext.SignInAsync(
                AuthenticationDefaults.ClientAuthenticationScheme,
                claimsPrincipal,
                authenticationProperties);

            return this.LocalRedirect("/");
        }

        /// <inheritdoc/>
        protected override List<TableRowActionViewModel> BuildTableViewActions()
        {
            var actions = base.BuildTableViewActions();

            actions.Insert(1, new TableRowActionViewModel(
                "Imitate",
                MaterialDesignIcons.Play,
                this.BuildControllerRoute("{0}/imitate"),
                new List<string> { "[Id]" },
                TableRowActionMethod.Post));

            actions.Insert(2, new TableRowActionViewModel(
                "Roles",
                MaterialDesignIcons.AccountBadgeHorizontal,
                this.BuildControllerRoute("{0}/roles"),
                new List<string> { "[Id]" }));

            actions.Insert(3, new TableRowActionViewModel(
                "Reset Refresh Token",
                MaterialDesignIcons.Refresh,
                this.BuildControllerRoute("{0}/reset-refresh-token"),
                new List<string> { "[Id]" },
                TableRowActionMethod.Post)
            {
                HasConfirmation = true,
                ConfirmationTitle = "Reset Refresh Token",
                ConfirmationMessage = "Are you sure you want to reset refresh token of this user?",
            });

            return actions;
        }
    }
}
