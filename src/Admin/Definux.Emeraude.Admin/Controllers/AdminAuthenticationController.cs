using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.UI.ViewModels.Account;
using Definux.Emeraude.Application.Exceptions;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Application.Requests.Identity.Commands.Login;
using Definux.Emeraude.Application.Requests.Identity.Commands.LoginWithTwoFactorAuthentication;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Presentation.Attributes;
using Definux.Emeraude.Presentation.Controllers;
using Definux.Emeraude.Presentation.Extensions;
using Definux.Utilities.DataAnnotations;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Definux.Emeraude.Admin.Controllers
{
    /// <summary>
    /// Controller for administrators authentication.
    /// </summary>
    [Area(EmAdminConstants.AreaName)]
    [AllowAnonymous]
    public sealed class AdminAuthenticationController : EmController
    {
        private readonly IWebHostEnvironment hostingEnvironment;
        private readonly IUserClaimsService userClaimsService;
        private readonly IUserManager userManager;
        private readonly ILogger<AdminAuthenticationController> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminAuthenticationController"/> class.
        /// </summary>
        /// <param name="userClaimsService"></param>
        /// <param name="hostingEnvironment"></param>
        /// <param name="userManager"></param>
        /// <param name="logger"></param>
        public AdminAuthenticationController(
            IUserClaimsService userClaimsService,
            IWebHostEnvironment hostingEnvironment,
            IUserManager userManager,
            ILogger<AdminAuthenticationController> logger)
        {
            this.userClaimsService = userClaimsService;
            this.hostingEnvironment = hostingEnvironment;
            this.userManager = userManager;
            this.logger = logger;
        }

        private IActionResult AdminIndexActionResult => this.LocalRedirect("/admin");

        private IActionResult Lockout => this.View("Lockout");

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
                    ExpiresUtc = expiresUtc,
                };
            }
        }

        /// <summary>
        /// Login action for GET request.
        /// </summary>
        /// <returns></returns>
        [Route("/admin/login")]
        [HttpGet]
        public IActionResult Login()
        {
            if (this.User.Identity?.IsAuthenticated ?? false)
            {
                return this.AdminIndexActionResult;
            }

            AdminLoginViewModel model = new AdminLoginViewModel();

            return this.View(model);
        }

        /// <summary>
        /// Login action for POST request.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [ServiceFilter(typeof(GoogleReCaptchaValidateAttribute))]
        [Route("/admin/login")]
        [HttpPost]
        public async Task<IActionResult> Login(AdminLoginViewModel model)
        {
            if (this.User.Identity?.IsAuthenticated ?? false)
            {
                return this.AdminIndexActionResult;
            }

            if (this.ModelState.IsValid)
            {
                if (await this.userClaimsService.CheckUserForAccessAdministrationPermissionAsync(model.Email))
                {
                    try
                    {
                        var requestResult = await this.Mediator.Send(new LoginCommand
                        {
                            Email = model.Email,
                            Password = model.Password,
                        });

                        if (requestResult.Result.RequiresTwoFactor)
                        {
                            await this.HttpContext.SignInAsync(IdentityConstants.TwoFactorUserIdScheme, this.StoreTwoFactorInfo(requestResult.User.Id, null));
                            return this.RedirectToAction(nameof(this.LoginWith2Fa));
                        }
                        else if (requestResult.Result.IsLockedOut)
                        {
                            return this.Lockout;
                        }
                        else if (requestResult.Result.Succeeded)
                        {
                            await this.SignInAsync(requestResult.User);

                            return this.AdminIndexActionResult;
                        }
                    }
                    catch (Exception ex)
                    {
                        this.logger.LogError(ex, "An error occured during admin email/password authentication");
                    }
                }
            }

            return this.View(model);
        }

        /// <summary>
        /// Login with two factor authentication action for GET request.
        /// </summary>
        /// <returns></returns>
        [Route("/admin/login-2fa")]
        [HttpGet]
        public async Task<IActionResult> LoginWith2Fa()
        {
            if (this.User.Identity?.IsAuthenticated ?? false)
            {
                return this.AdminIndexActionResult;
            }

            var user = await this.userManager.GetTwoFactorAuthenticationUserAsync();

            if (user == null || !(await this.userClaimsService.CheckUserForAccessAdministrationPermissionAsync(user.Email)))
            {
                return this.NotFound();
            }

            AdminLoginWith2FaViewModel model = new AdminLoginWith2FaViewModel();

            return this.View(model);
        }

        /// <summary>
        /// Login with two factor authentication action for POST request.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/admin/login-2fa")]
        [ServiceFilter(typeof(VisibleReCaptchaValidateAttribute))]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginWith2Fa(AdminLoginWith2FaViewModel model)
        {
            if (this.User.Identity?.IsAuthenticated ?? false)
            {
                return this.AdminIndexActionResult;
            }

            try
            {
                var user = await this.userManager.GetTwoFactorAuthenticationUserAsync();

                if (user == null || !(await this.userClaimsService.CheckUserForAccessAdministrationPermissionAsync(user.Email)))
                {
                    return this.NotFound();
                }

                var requestResult = await this.Mediator.Send(new LoginWithTwoFactorAuthenticationCommand(user, model.TwoFactorCode));
                if (requestResult.Result.Succeeded)
                {
                    await this.SignInAsync(requestResult.User);

                    return this.AdminIndexActionResult;
                }
                else if (requestResult.Result.IsLockedOut)
                {
                    return this.Lockout;
                }
            }
            catch (ValidationException ex)
            {
                this.ModelState.ApplyValidationException(ex, true);
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occured during admin two factor authentication");
            }

            return this.View(model);
        }

        /// <summary>
        /// Logout action.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HttpPost]
        [Route("/admin/logout")]
        [Authorize(Policy = AdminPermissions.AccessAdministrationPolicy)]
        public async Task<IActionResult> Logout()
        {
            await this.HttpContext.SignOutAsync(AuthenticationDefaults.AdminAuthenticationScheme);

            return this.RedirectToAction(nameof(this.Login));
        }

        private async Task SignInAsync(IUser user)
        {
            var claims = await this.userClaimsService.GetUserClaimsForCookieAsync(user.Id);
            var claimsIdentity = new ClaimsIdentity(claims, AuthenticationDefaults.AdminAuthenticationScheme);
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            await this.HttpContext.SignInAsync(
                AuthenticationDefaults.AdminAuthenticationScheme,
                claimsPrincipal,
                this.AuthenticationProperties);
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
