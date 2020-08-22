using Definux.Emeraude.Application.Common.Exceptions;
using Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword;
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
        public const string ResetPasswordRoute = "/reset-password";

        [HttpGet]
        [Route(ResetPasswordRoute)]
        [LanguageRoute(ResetPasswordRoute)]
        public IActionResult ResetPassword([FromQuery]string token, [FromQuery]string email)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToHomeIndex();
            }

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(token))
            {
                return NotFound();
            }

            var request = new ResetPasswordRequest
            {
                Token = token,
                Email = email
            };

            return ResetPasswordView(request);
        }

        [HttpPost]
        [Route(ResetPasswordRoute)]
        [LanguageRoute(ResetPasswordRoute)]
        public async Task<IActionResult> ResetPassword(ResetPasswordRequest request)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToHomeIndex();
            }

            try
            {
                var requestResult = await Mediator.Send(new ResetPasswordCommand(request));

                if (requestResult.Successed)
                {
                    return ResetPasswordSuccessView(request);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, Messages.YourPasswordCannotBeReset);
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

            return ResetPasswordView(request);
        }

        public ViewResult ResetPasswordView(object model)
        {
            return View("ResetPassword", model);
        }
        public ViewResult ResetPasswordSuccessView(object model)
        {
            return View("ResetPasswordSuccess", model);
        }
    }
}
