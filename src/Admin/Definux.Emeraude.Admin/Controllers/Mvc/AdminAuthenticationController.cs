using Definux.Emeraude.Admin.Controllers.Abstractions;
using Definux.Emeraude.Admin.UI.ViewModels.Account;
using Definux.Emeraude.Application.Common.Exceptions;
using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Application.Requests.Identity.Commands.Login;
using Definux.Emeraude.Application.Requests.Identity.Commands.LoginWithTwoFactorAuthentication;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Presentation.Extensions;
using Definux.Utilities.DataAnnotations;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.Controllers.Mvc
{
    [AllowAnonymous]
    public class AdminAuthenticationController : AdminController
    {
        private readonly IWebHostEnvironment hostingEnvironment;
        private readonly IUserClaimsService userClaimsService;
        private readonly IUserManager userManager;

        public AdminAuthenticationController(
            IUserClaimsService userClaimsService,
            IWebHostEnvironment hostingEnvironment,
            IUserManager userManager)
        {
            this.userClaimsService = userClaimsService;
            this.hostingEnvironment = hostingEnvironment;
            this.userManager = userManager;

            HideActivityLogParameters = true;
        }

        [Route("/admin/login")]
        [HttpGet]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return AdminDashboardActionResult;
            }

            AdminLoginViewModel model = new AdminLoginViewModel();

            return View(model);
        }

        [Route("/admin/login")]
        [ValidateAntiForgeryToken]
        [ServiceFilter(typeof(VisibleReCaptchaValidateAttribute))]
        [HttpPost]
        public async Task<IActionResult> Login(AdminLoginViewModel model)
        {
            if (User.Identity.IsAuthenticated)
            {
                return AdminDashboardActionResult;
            }

            if (ModelState.IsValid)
            {
                if (await this.userClaimsService.CheckUserForAccessAdministrationPermissionAsync(model.Email))
                {
                    try
                    {
                        var requestResult = await Mediator.Send(new LoginCommand(new LoginRequest
                        {
                            Email = model.Email,
                            Password = model.Password
                        }));

                        if (requestResult.Result.RequiresTwoFactor)
                        {
                            await HttpContext.SignInAsync(IdentityConstants.TwoFactorUserIdScheme, StoreTwoFactorInfo(requestResult.User.Id, null));
                            return RedirectToAction(nameof(LoginWith2fa));
                        }
                        else if (requestResult.Result.IsLockedOut)
                        {
                            return Lockout;
                        }
                        else if (requestResult.Result.Succeeded)
                        {
                            await SignInAsync(requestResult.User);

                            return AdminDashboardActionResult;
                        }
                    }
                    catch (Exception ex)
                    {
                        await Logger.LogErrorAsync(ex);
                    }
                }
            }

            return View(model);
        }


        [Route("/admin/login-2fa")]
        [HttpGet]
        public async Task<IActionResult> LoginWith2fa()
        {
            if (User.Identity.IsAuthenticated)
            {
                return AdminDashboardActionResult;
            }

            var user = await this.userManager.GetTwoFactorAuthenticationUserAsync();

            if (user == null || !(await this.userClaimsService.CheckUserForAccessAdministrationPermissionAsync(user.Email)))
            {
                return NotFound();
            }

            AdminLoginWith2faViewModel model = new AdminLoginWith2faViewModel();

            return View(model);
        }

        [HttpPost]
        [Route("/admin/login-2fa")]
        [ServiceFilter(typeof(VisibleReCaptchaValidateAttribute))]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginWith2fa(AdminLoginWith2faViewModel model)
        {

            if (this.User.Identity.IsAuthenticated)
            {
                return this.AdminDashboardActionResult;
            }

            try
            {
                var user = await this.userManager.GetTwoFactorAuthenticationUserAsync();

                if (user == null || !(await this.userClaimsService.CheckUserForAccessAdministrationPermissionAsync(user.Email)))
                {
                    return NotFound();
                }

                var requestResult = await Mediator.Send(new LoginWithTwoFactorAuthenticationCommand(user, model.TwoFactorCode));
                if (requestResult.Result.Succeeded)
                {
                    await SignInAsync(requestResult.User);

                    return AdminDashboardActionResult;
                }
                else if (requestResult.Result.IsLockedOut)
                {
                    return Lockout;
                }

            }
            catch (ValidationException ex)
            {
                ModelState.ApplyValidationException(ex, true);
            }
            catch (Exception ex)
            {
                await Logger.LogErrorAsync(ex);
            }

            return View(model);
        }

        [HttpPost]
        [Route("/admin/logout")]
        [Authorize(Policy = AdminPermissions.AccessAdministrationPolicy)]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await this.HttpContext.SignOutAsync(AuthenticationDefaults.AdminAuthenticationScheme);

            return RedirectToAction(nameof(Login));
        }

        private IActionResult AdminDashboardActionResult
        {
            get
            {
                return RedirectToAction("Index", "AdminDashboard");
            }
        }

        private IActionResult Lockout
        {
            get
            {
                return View("Lockout");
            }
        }

        private AuthenticationProperties AuthenticationProperties
        {
            get
            {
                DateTime expiresUtc = DateTime.UtcNow.AddMinutes(90);
                if (this.hostingEnvironment.IsDevelopment())
                {
                    expiresUtc = DateTime.UtcNow.AddDays(7);
                }

                return new AuthenticationProperties
                {
                    IsPersistent = true,
                    ExpiresUtc = expiresUtc
                };
            }
        }

        protected async Task SignInAsync(IUser user)
        {
            var claims = await this.userClaimsService.GetUserClaimsForCookieAsync(user.Id);
            var claimsIdentity = new ClaimsIdentity(claims, AuthenticationDefaults.AdminAuthenticationScheme);
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            await this.HttpContext.SignInAsync(
                AuthenticationDefaults.AdminAuthenticationScheme,
                claimsPrincipal,
                AuthenticationProperties);
        }

        private ClaimsPrincipal StoreTwoFactorInfo(Guid userId, string loginProvider)
        {
            var identity = new ClaimsIdentity(IdentityConstants.TwoFactorUserIdScheme);
            identity.AddClaim(new Claim(System.Security.Claims.ClaimTypes.Name, userId.ToString()));
            if (loginProvider != null)
            {
                identity.AddClaim(new Claim(System.Security.Claims.ClaimTypes.AuthenticationMethod, loginProvider));
            }
            return new ClaimsPrincipal(identity);
        }
    }
}
