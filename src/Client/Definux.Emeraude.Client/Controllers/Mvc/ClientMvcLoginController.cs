using Definux.Emeraude.Application.Common.Exceptions;
using Definux.Emeraude.Presentation.Extensions;
using Definux.Emeraude.Application.Requests.Identity.Commands.Login;
using Definux.Emeraude.Locales.Attributes;
using Definux.Emeraude.Localization.Extensions;
using Definux.Emeraude.Presentation.Controllers;
using Definux.Emeraude.Resources;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Definux.Emeraude.Client.Controllers.Mvc
{
    public partial class ClientMvcAuthenticationController : PublicController
    {
        public const string LoginRoute = "/login";

        [HttpGet]
        [Route(LoginRoute)]
        [LanguageRoute(LoginRoute)]
        public IActionResult Login(string returnUrl = null)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToHomeIndex();
            }

            string returnUrlLanguageCode = returnUrl.GetLanguageCodeFromUrl();

            var request = new LoginRequest();
            ViewData["ReturnUrl"] = returnUrl;

            if (!string.IsNullOrEmpty(returnUrlLanguageCode) && string.IsNullOrEmpty(this.HttpContext.GetLanguageCode()))
            {
                return LocalRedirect($"/{returnUrlLanguageCode}{LoginRoute}?returnUrl={this.urlEncoder.Encode(returnUrl)}");
            }
            else
            {
                return LoginView(request);
            }
        }

        [HttpPost]
        [Route(LoginRoute)]
        [LanguageRoute(LoginRoute)]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginRequest request, string returnUrl = "")
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToHomeIndex();
            }

            try
            {
                var requestResult = await Mediator.Send(new LoginCommand(request));

                if (requestResult.Result.Succeeded)
                {
                    await SignInAsync(requestResult.User);
                    if (string.IsNullOrWhiteSpace(returnUrl))
                    {
                        return RedirectToHomeIndex();
                    }

                    return LocalRedirect(returnUrl);
                }
                else if (requestResult.Result.IsLockedOut)
                {
                    return View("Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, Messages.YourEmailOrPasswordIsIncorrect);
                }
            }
            catch (ValidationException ex)
            {
                ModelState.ApplyValidationException(ex);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, Messages.YourLoginAttemptHasFailed);
            }

            ViewData["ReturnUrl"] = returnUrl;

            return LoginView(request);
        }

        public ViewResult LoginView(object model)
        {
            return View("Login", model);
        }
    }
}
