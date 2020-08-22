using Definux.Emeraude.Admin.Controllers.Abstractions;
using Definux.Emeraude.Admin.UI.ViewModels.Manage;
using Definux.Emeraude.Application.Common.Exceptions;
using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Application.Requests.Identity.Commands.ActivateTwoFactorAuthentication;
using Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword;
using Definux.Emeraude.Application.Requests.Identity.Commands.ResetTwoFactorAuthentication;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Identity.Entities;
using Definux.Emeraude.Presentation.Extensions;
using Definux.Utilities.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.Controllers.Mvc
{
    [Route("admin/manage/")]
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = AdminPermissions.AccessAdministrationPolicy)]
    public class AdminManageController : AdminController
    {
        private readonly UserManager<User> userManager;
        private readonly UrlEncoder urlEncoder;
        private readonly EmOptions options;

        private readonly ITwoFactorAuthenticationService twoFactorAuthenticationService;

        public AdminManageController(
            UserManager<User> userManager, 
            UrlEncoder urlEncoder, 
            ITwoFactorAuthenticationService twoFactorAuthenticationService, 
            IOptions<EmOptions> optionsAccessor)
        {
            this.userManager = userManager;
            this.urlEncoder = urlEncoder;
            this.twoFactorAuthenticationService = twoFactorAuthenticationService;
            this.options = optionsAccessor.Value;
        }

        [HttpGet]
        [Route("two-factor-authentication")]
        public async Task<IActionResult> TwoFactorAuthentication()
        {
            var user = await CurrentUserProvider.GetCurrentUserAsync();

            var model = new AdminTwoFactorAuthenticationViewModel
            {
                HasAuthenticator = await this.twoFactorAuthenticationService.GetFormattedKeyAsync(user) != null,
                Is2faEnabled = this.twoFactorAuthenticationService.IsTwoFactorEnabled(user)
            };

            await LoadSharedKeyAndQrCodeUriAsync(user, model);

            return View(model);
        }

        [HttpPost]
        [Route("two-factor-authentication")]
        public async Task<IActionResult> TwoFactorAuthentication(AdminTwoFactorAuthenticationViewModel model)
        {
            try
            {
                var user = await CurrentUserProvider.GetCurrentUserAsync();

                var requestResult = await Mediator.Send(new ActivateTwoFactorAuthenticationCommand(model.Code));

                if (requestResult.Successed)
                {
                    var responseModel = new AdminTwoFactorAuthenticationViewModel
                    {
                        HasAuthenticator = await this.twoFactorAuthenticationService.GetFormattedKeyAsync(user) != null,
                        Is2faEnabled = this.twoFactorAuthenticationService.IsTwoFactorEnabled(user)
                    };

                    ShowSuccessNotification("Two Factor Authenticator has been enabled successfully.");

                    return View(responseModel);
                }
                else
                {
                    ModelState.AddModelError("Code", "Verification code is invalid.");
                    await LoadSharedKeyAndQrCodeUriAsync(user, model);
                }
            }
            catch (ValidationException ex)
            {
                ModelState.ApplyValidationException(ex, true);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Two factor authentication operation has failed.");
            }

            return View(model);
        }

        [HttpPost]
        [Route("reset-authenticator")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetAuthenticator()
        {
            await Mediator.Send(new ResetTwoFactorAuthenticationCommand());

            return RedirectToAction(nameof(TwoFactorAuthentication));
        }

        [HttpGet]
        [Route("change-password")]
        public IActionResult ChangePassword()
        {
            AdminChangePasswordViewModel model = new AdminChangePasswordViewModel();

            return View(model);
        }

        [HttpPost]
        [Route("change-password")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(AdminChangePasswordViewModel model)
        {
            try
            {
                var requestResult = await Mediator.Send(new ChangePasswordCommand(new ChangePasswordRequest
                {
                    UserId = HttpContext.GetCurrentUserId().Value,
                    CurrentPassword = model.CurrentPassword,
                    NewPassword = model.NewPassword,
                    ConfirmedPassword = model.ConfirmedPassword
                }));

                if (requestResult.Successed)
                {
                    ShowSuccessNotification("Password has been changed successfully.");
                    return View();
                }
                else
                {
                    ShowErrorNotification("Password has not been changed successfully.");
                    return View(model);
                }
            }
            catch (ValidationException ex)
            {
                ModelState.ApplyValidationException(ex, true);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Change password operation has failed.");
            }

            return View(model);
        }

        private async Task LoadSharedKeyAndQrCodeUriAsync(IUser user, AdminTwoFactorAuthenticationViewModel model)
        {
            model.SharedKey = await this.twoFactorAuthenticationService.GetFormattedKeyAsync(user);
            model.AuthenticatorUri = await this.twoFactorAuthenticationService.GenerateQrCodeUriAsync(user);
        }
    }
}
