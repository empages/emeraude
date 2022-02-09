using System;
using System.Threading.Tasks;
using Emeraude.Application.Exceptions;
using Emeraude.Application.Identity.Requests.Commands.Login;
using Emeraude.Infrastructure.Localization.Extensions;
using Emeraude.Infrastructure.Persistence.Extensions;
using Emeraude.Presentation.Extensions;
using Emeraude.Presentation.PlatformBase.Attributes;
using Emeraude.Presentation.PlatformBase.Models;
using Microsoft.AspNetCore.Mvc;

namespace Emeraude.Presentation.PlatformBase.Controllers;

/// <inheritdoc cref="UserAuthenticationController"/>
public abstract partial class UserAuthenticationController
{
    private const string LoginRoute = "/login";

    /// <summary>
    /// Login action for GET request.
    /// </summary>
    /// <param name="returnUrl"></param>
    /// <returns></returns>
    [HttpGet]
    [Route(LoginRoute)]
    [LanguageRoute(LoginRoute)]
    public virtual async Task<IActionResult> Login(string returnUrl = null)
    {
        if (this.IsAuthenticated)
        {
            return this.RedirectToDefault();
        }

        var returnUrlLanguageCode = returnUrl.GetLanguageCodeFromUrl();
        var viewModel = new LoginViewModel();
        this.ViewData["ReturnUrl"] = returnUrl;
        if (!string.IsNullOrEmpty(returnUrlLanguageCode) && string.IsNullOrEmpty(this.HttpContext.GetLanguageCode()))
        {
            return this.LocalRedirect($"/{returnUrlLanguageCode}{LoginRoute}?returnUrl={this.urlEncoder.Encode(returnUrl)}");
        }

        return this.LoginView(viewModel);
    }

    /// <summary>
    /// Login action for GET request.
    /// </summary>
    /// <param name="viewModel"></param>
    /// <param name="returnUrl"></param>
    /// <returns></returns>
    [HttpPost]
    [Route(LoginRoute)]
    [LanguageRoute(LoginRoute)]
    [ValidateAntiForgeryToken]
    public virtual async Task<IActionResult> Login(LoginViewModel viewModel, string returnUrl = "")
    {
        if (this.IsAuthenticated)
        {
            return this.RedirectToDefault();
        }

        try
        {
            var result = await this.Mediator.Send(new LoginCommand
            {
                Email = viewModel?.Email,
                Password = viewModel?.Password,
                AdditionalParameters = viewModel?.AdditionalParameters,
            });

            if (result.Result.Succeeded)
            {
                await this.SignInAsync(result.User);
                if (string.IsNullOrWhiteSpace(returnUrl))
                {
                    return this.RedirectToDefault();
                }

                return this.LocalRedirect(returnUrl);
            }

            if (result.Result.IsLockedOut)
            {
                return this.View("Lockout");
            }

            this.ModelState.AddModelError(string.Empty, Strings.TheEmailAddressOrPasswordIsIncorrect);
        }
        catch (ValidationException ex)
        {
            this.ModelState.ApplyValidationException(ex);
        }
        catch (Exception)
        {
            this.ModelState.AddModelError(string.Empty, Strings.YourLoginAttemptHasFailed);
        }

        this.ViewData["ReturnUrl"] = returnUrl;

        return this.LoginView(viewModel);
    }

    /// <summary>
    /// Returns login view.
    /// </summary>
    /// <param name="model"></param>
    /// <typeparam name="TViewModel">View model.</typeparam>
    /// <returns></returns>
    protected virtual ViewResult LoginView<TViewModel>(TViewModel model)
        where TViewModel : LoginViewModel
    {
        return this.View("Login", model);
    }
}