using System;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.Controllers.Abstractions;
using Definux.Emeraude.Admin.UI.ViewModels.Manage;
using Definux.Emeraude.Application.Exceptions;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Application.Requests.Identity.Commands.ActivateTwoFactorAuthentication;
using Definux.Emeraude.Application.Requests.Identity.Commands.ChangeEmail;
using Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword;
using Definux.Emeraude.Application.Requests.Identity.Commands.RequestChangeEmail;
using Definux.Emeraude.Application.Requests.Identity.Commands.ResetTwoFactorAuthentication;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Identity.Entities;
using Definux.Emeraude.Presentation.Extensions;
using Definux.Utilities.Extensions;
using Definux.Utilities.Objects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Definux.Emeraude.Admin.Controllers.Mvc
{
    /// <summary>
    /// Admin controller for management of current signed user.
    /// </summary>
    [Route("/admin/manage/")]
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = AdminPermissions.AccessAdministrationPolicy)]
    public sealed class AdminManageController : AdminController
    {
        private readonly UserManager<User> userManager;
        private readonly UrlEncoder urlEncoder;
        private readonly EmOptions options;
        private readonly ITwoFactorAuthenticationService twoFactorAuthenticationService;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminManageController"/> class.
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="urlEncoder"></param>
        /// <param name="twoFactorAuthenticationService"></param>
        /// <param name="optionsAccessor"></param>
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

        /// <summary>
        /// Two factor authentication action for GET request.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("two-factor-authentication")]
        public async Task<IActionResult> TwoFactorAuthentication()
        {
            var user = await this.CurrentUserProvider.GetCurrentUserAsync();

            var model = new AdminTwoFactorAuthenticationViewModel
            {
                HasAuthenticator = await this.twoFactorAuthenticationService.GetFormattedKeyAsync(user) != null,
                Is2faEnabled = this.twoFactorAuthenticationService.IsTwoFactorEnabled(user),
            };

            await this.LoadSharedKeyAndQrCodeUriAsync(user, model);

            return this.View(model);
        }

        /// <summary>
        /// Two factor authentication action for POST request.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("two-factor-authentication")]
        public async Task<IActionResult> TwoFactorAuthentication(AdminTwoFactorAuthenticationViewModel model)
        {
            try
            {
                var user = await this.CurrentUserProvider.GetCurrentUserAsync();

                var requestResult = await this.Mediator.Send(new ActivateTwoFactorAuthenticationCommand(model.Code));

                if (requestResult.Successed)
                {
                    var responseModel = new AdminTwoFactorAuthenticationViewModel
                    {
                        HasAuthenticator = await this.twoFactorAuthenticationService.GetFormattedKeyAsync(user) != null,
                        Is2faEnabled = this.twoFactorAuthenticationService.IsTwoFactorEnabled(user),
                    };

                    this.ShowSuccessNotification("Two Factor Authenticator has been enabled successfully.");

                    return this.View(responseModel);
                }
                else
                {
                    this.ModelState.AddModelError("Code", "Verification code is invalid.");
                    await this.LoadSharedKeyAndQrCodeUriAsync(user, model);
                }
            }
            catch (ValidationException ex)
            {
                this.ModelState.ApplyValidationException(ex, true);
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, "Two factor authentication operation has failed.");
            }

            return this.View(model);
        }

        /// <summary>
        /// Reset two factor authenticator action.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("reset-authenticator")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetAuthenticator()
        {
            await this.Mediator.Send(new ResetTwoFactorAuthenticationCommand());

            return this.RedirectToAction(nameof(this.TwoFactorAuthentication));
        }

        /// <summary>
        /// Change password action for GET request.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("change-password")]
        public IActionResult ChangePassword()
        {
            AdminChangePasswordViewModel model = new AdminChangePasswordViewModel();

            return this.View(model);
        }

        /// <summary>
        /// Change password action for POST request.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("change-password")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(AdminChangePasswordViewModel model)
        {
            try
            {
                var requestResult = await this.Mediator.Send(new ChangePasswordCommand
                {
                    UserId = this.HttpContext.GetCurrentUserId().Value,
                    CurrentPassword = model.CurrentPassword,
                    NewPassword = model.NewPassword,
                    ConfirmedPassword = model.ConfirmedPassword,
                });

                if (requestResult.Successed)
                {
                    this.ShowSuccessNotification("Password has been changed successfully.");
                    return this.View();
                }
                else
                {
                    this.ShowErrorNotification("Password has not been changed successfully.");
                    return this.View(model);
                }
            }
            catch (ValidationException ex)
            {
                this.ModelState.ApplyValidationException(ex, true);
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, "Change password operation has failed.");
            }

            return this.View(model);
        }

        /// <summary>
        /// Change email action for GET request.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("change-email-request")]
        public async Task<IActionResult> ChangeEmailRequest()
        {
            AdminChangeEmailViewModel model = new AdminChangeEmailViewModel();
            var currentUser = await this.CurrentUserProvider.GetCurrentUserAsync();
            model.NewEmail = currentUser.Email;
            return this.View(model);
        }

        /// <summary>
        /// Change email action for POST request.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("change-email-request")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeEmailRequest(AdminChangeEmailViewModel model)
        {
            try
            {
                var currentUser = await this.CurrentUserProvider.GetCurrentUserAsync();
                var request = new RequestChangeEmailCommand()
                {
                    UserId = currentUser.Id,
                    NewEmail = model.NewEmail,
                };

                request.ConfigureCallbackOptions("admin/manage/change-email", false);
                var requestResult = await this.Mediator.Send(request);

                if (requestResult.Successed)
                {
                    this.ShowSuccessNotification("Email request has been sent successfully. Check your email for confirmation.");
                    return this.View();
                }
                else
                {
                    this.ShowErrorNotification("Email request has not been sent successfully.");
                    return this.View(model);
                }
            }
            catch (ValidationException ex)
            {
                this.ModelState.ApplyValidationException(ex, true);
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, "Change email request operation has failed.");
            }

            return this.View(model);
        }

        /// <summary>
        /// Change email execution action.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        [Route("change-email")]
        public async Task<IActionResult> ChangeEmail(
            [FromQuery] string email,
            [FromQuery] string token)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(token))
            {
                return this.NotFound();
            }

            var requestResult = SimpleResult.UnsuccessfulResult;

            try
            {
                requestResult = await this.Mediator.Send(new ChangeEmailCommand(email, token));
            }
            catch (Exception ex)
            {
                await this.Logger.LogErrorAsync(ex);
            }

            this.ShowComputationNotification(
                requestResult.Successed,
                "Your email has been changed successfully.",
                "Your email has not been changed successfully.");

            return this.RedirectToAction(nameof(this.ChangeEmailRequest));
        }

        private async Task LoadSharedKeyAndQrCodeUriAsync(IUser user, AdminTwoFactorAuthenticationViewModel model)
        {
            model.SharedKey = await this.twoFactorAuthenticationService.GetFormattedKeyAsync(user);
            model.AuthenticatorUri = await this.twoFactorAuthenticationService.GenerateQrCodeUriAsync(user);
        }
    }
}
