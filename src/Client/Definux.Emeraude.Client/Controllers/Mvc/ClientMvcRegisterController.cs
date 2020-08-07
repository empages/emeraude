using Definux.Emeraude.Application.Common.Exceptions;
using Definux.Emeraude.Presentation.Extensions;
using Definux.Emeraude.Application.Requests.Identity.Commands.Register;
using Definux.Emeraude.Locales.Attributes;
using Definux.Emeraude.Presentation.Controllers;
using Definux.Emeraude.Resources;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Definux.Emeraude.Client.Controllers.Mvc
{
    public partial class ClientMvcAuthenticationController : PublicController
    {
        public const string RegisterRoute = "/register";

        [HttpGet]
        [Route(RegisterRoute)]
        [LanguageRoute(RegisterRoute)]
        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToHomeIndex();
            }

            var request = new RegisterRequest();

            return RegisterView(request);
        }

        [HttpPost]
        [Route(RegisterRoute)]
        [LanguageRoute(RegisterRoute)]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToHomeIndex();
            }

            try
            {
                var requestResult = await Mediator.Send(new RegisterCommand(request));

                if (requestResult.Result.Succeeded)
                {
                    return View("RegisterSuccess");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, Messages.UserCannotBeRegistered);
                }
            }
            catch (ValidationException ex)
            {
                ModelState.ApplyValidationException(ex);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, Messages.UserCannotBeRegistered);
            }

            return RegisterView(request);
        }

        public ViewResult RegisterView(object model)
        {
            return View("Register", model);
        }
    }
}
