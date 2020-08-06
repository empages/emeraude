using Definux.Emeraude.Application.Common.Exceptions;
using Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword;
using Definux.Emeraude.Locales.Attributes;
using Definux.Emeraude.Presentation.Controllers;
using Definux.Emeraude.Presentation.Extensions;
using Definux.Emeraude.Resources;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Definux.Emeraude.Client.Controllers.Mvc
{
    public partial class ClientMvcAuthenticationController : PublicController
    {
        public const string ForgotPasswordRoute = "/forgot-password";

        [HttpGet]
        [Route(ForgotPasswordRoute)]
        [LanguageRoute(ForgotPasswordRoute)]
        public IActionResult ForgotPassword()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToHomeIndex();
            }

            ForgotPasswordRequest request = new ForgotPasswordRequest();

            return ForgotPasswordView(request);
        }

        [HttpPost]
        [Route(ForgotPasswordRoute)]
        [LanguageRoute(ForgotPasswordRoute)]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordRequest request)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToHomeIndex();
            }

            try
            {
                var result = await Mediator.Send(new ForgotPasswordCommand(request));
                if (result.Success)
                {
                    return ForgotPasswordSuccessView(request);
                }
                else
                {
                    await Logger.LogErrorAsync(new ArgumentException($"Invalid email ({request.Email}) from reset password form."));
                    return ForgotPasswordSuccessView(request);
                }
            }
            catch (ValidationException ex)
            {
                ModelState.ApplyValidationException(ex);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, Messages.YourPasswordCannotBeReset);
            }

            return ForgotPasswordView(request);
        }

        public ViewResult ForgotPasswordView(object model)
        {
            return View("ForgotPassword", model);
        }

        public ViewResult ForgotPasswordSuccessView(object model)
        {
            return View("ForgotPasswordSuccess", model);
        }
    }
}
