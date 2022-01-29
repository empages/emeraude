using System;
using System.Threading.Tasks;
using Emeraude.Application.Exceptions;
using Emeraude.Application.Identity.Requests.Commands.Register;
using Emeraude.Presentation.Extensions;
using Emeraude.Presentation.PlatformBase.Attributes;
using Emeraude.Presentation.PlatformBase.Extensions;
using Emeraude.Presentation.PlatformBase.Models;
using Microsoft.AspNetCore.Mvc;

namespace Emeraude.Presentation.PlatformBase.Controllers;

/// <inheritdoc cref="UserAuthenticationController"/>
public abstract partial class UserAuthenticationController
{
    private const string RegisterRoute = "/register";

    /// <summary>
    /// Register action for GET request.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route(RegisterRoute)]
    [LanguageRoute(RegisterRoute)]
    public virtual async Task<IActionResult> Register()
    {
        if (this.IsAuthenticated)
        {
            return this.RedirectToDefault();
        }

        var viewModel = new RegisterViewModel();

        return this.RegisterView(viewModel);
    }

    /// <summary>
    /// Register action for POST request.
    /// </summary>
    /// <param name="viewModel"></param>
    /// <returns></returns>
    [HttpPost]
    [Route(RegisterRoute)]
    [LanguageRoute(RegisterRoute)]
    [ValidateAntiForgeryToken]
    public virtual async Task<IActionResult> Register(RegisterViewModel viewModel)
    {
        if (this.IsAuthenticated)
        {
            return this.RedirectToDefault();
        }

        try
        {
            var result = await this.Mediator.Send(new RegisterCommand
            {
                Name = viewModel?.Name,
                Email = viewModel?.Email,
                Password = viewModel?.Password,
                ConfirmedPassword = viewModel?.ConfirmedPassword,
                AdditionalParameters = viewModel?.AdditionalParameters,
            });

            if (result.Result.Succeeded)
            {
                return await this.RedirectToSucceededExecutionResultAsync(
                    Strings.RegistrationHasBeenSuccessful,
                    Strings.PleaseConfirmYourEmailAddressToCompleteTheRegistration,
                    "register");
            }

            this.ModelState.AddModelError(string.Empty, Strings.UserCannotBeRegistered);
        }
        catch (ValidationException ex)
        {
            this.ModelState.ApplyValidationException(ex);
        }
        catch (Exception)
        {
            this.ModelState.AddModelError(string.Empty, Strings.UserCannotBeRegistered);
        }

        return this.RegisterView(viewModel);
    }

    /// <summary>
    /// Returns register view.
    /// </summary>
    /// <param name="model"></param>
    /// <typeparam name="TViewModel">View model.</typeparam>
    /// <returns></returns>
    protected virtual ViewResult RegisterView<TViewModel>(TViewModel model)
        where TViewModel : RegisterViewModel
    {
        return this.View("Register", model);
    }
}