using System;
using System.Threading.Tasks;
using Emeraude.Application.Exceptions;
using Emeraude.Application.Identity.Requests.Commands.ResetPassword;
using Emeraude.Presentation.Extensions;
using Emeraude.Presentation.PlatformBase.Attributes;
using Emeraude.Presentation.PlatformBase.Extensions;
using Emeraude.Presentation.PlatformBase.Models;
using Microsoft.AspNetCore.Mvc;

namespace Emeraude.Presentation.PlatformBase.Controllers;

/// <inheritdoc cref="UserAuthenticationController"/>
public abstract partial class UserAuthenticationController
{
    private const string ResetPasswordRoute = "/reset-password";

    /// <summary>
    /// Reset password action for GET request.
    /// </summary>
    /// <param name="token"></param>
    /// <param name="email"></param>
    /// <returns></returns>
    [HttpGet]
    [Route(ResetPasswordRoute)]
    [LanguageRoute(ResetPasswordRoute)]
    public virtual async Task<IActionResult> ResetPassword([FromQuery]string token, [FromQuery]string email)
    {
        if (this.IsAuthenticated &&
            !string.Equals(this.User.Identity.Name?.Trim(), email?.Trim(), StringComparison.CurrentCultureIgnoreCase))
        {
            return this.RedirectToDefault();
        }

        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(token))
        {
            return this.NotFound();
        }

        var viewModel = new ResetPasswordViewModel
        {
            Token = token,
            Email = email,
        };

        return this.ResetPasswordView(viewModel);
    }

    /// <summary>
    /// Reset password action for POST request.
    /// </summary>
    /// <param name="viewModel"></param>
    /// <returns></returns>
    [HttpPost]
    [Route(ResetPasswordRoute)]
    [LanguageRoute(ResetPasswordRoute)]
    public virtual async Task<IActionResult> ResetPassword(ResetPasswordViewModel viewModel)
    {
        if (this.IsAuthenticated &&
            this.User.Identity.Name?.Trim().ToLower() != viewModel.Email?.Trim().ToLower())
        {
            return this.RedirectToDefault();
        }

        try
        {
            var result = await this.Mediator.Send(new ResetPasswordCommand
            {
                Email = viewModel?.Email,
                Token = viewModel?.Token,
                Password = viewModel?.Password,
                ConfirmedPassword = viewModel?.ConfirmedPassword,
                AdditionalParameters = viewModel?.AdditionalParameters,
            });

            if (result.Succeeded)
            {
                return await this.RedirectToSucceededExecutionResultAsync(
                    Strings.ResetPasswordSuccessful,
                    Strings.YourPasswordHasBeenReset,
                    "reset-password");
            }
            else
            {
                this.ModelState.AddModelError(string.Empty, Strings.YourPasswordCannotBeReset);
            }
        }
        catch (ValidationException ex)
        {
            this.ModelState.ApplyValidationException(ex);
        }
        catch (Exception)
        {
            this.ModelState.AddModelError(string.Empty, Strings.YourPasswordCannotBeReset);
        }

        return this.ResetPasswordView(viewModel);
    }

    /// <summary>
    /// Returns reset password view.
    /// </summary>
    /// <param name="model"></param>
    /// <typeparam name="TViewModel">View model.</typeparam>
    /// <returns></returns>
    protected virtual ViewResult ResetPasswordView<TViewModel>(TViewModel model)
        where TViewModel : ResetPasswordViewModel
    {
        return this.View("ResetPassword", model);
    }
}