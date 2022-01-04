using System;
using System.Threading.Tasks;
using Emeraude.Infrastructure.Identity.Services;
using Emeraude.Infrastructure.Localization.Services;
using Emeraude.Presentation.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;

namespace Emeraude.Presentation.Controllers;

/// <summary>
/// Abstraction for controllers which will be used on the customer side of the application.
/// </summary>
[ApiExplorerSettings(IgnoreApi = true)]
public abstract class EmPublicController : EmController
{
    private const string LanguageCookieName = ".Emeraude.Language";

    private ICurrentLanguageProvider currentLanguageProvider;
    private IUserManager userManager;
    private IEmLocalizer localizer;

    /// <inheritdoc cref="ICurrentLanguageProvider"/>
    protected ICurrentLanguageProvider CurrentLanguageProvider =>
        this.currentLanguageProvider ??= this.HttpContext.RequestServices.GetService<ICurrentLanguageProvider>();

    /// <inheritdoc cref="IUserManager"/>
    protected IUserManager UserManager =>
        this.userManager ??= this.HttpContext.RequestServices.GetService<IUserManager>();

    /// <inheritdoc cref="IEmLocalizer"/>
    protected IEmLocalizer Localizer => this.localizer ??= this.HttpContext.RequestServices.GetService<IEmLocalizer>();

    /// <inheritdoc/>
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        this.ManageLanguageCookie();
        base.OnActionExecuting(context);
    }

    /// <summary>
    /// Gets route with language code (async extraction) at the beginning based on current language.
    /// </summary>
    /// <param name="route"></param>
    /// <returns></returns>
    public async Task<string> GetLanguageRouteAsync(string route)
    {
        var currentLanguage = await this.currentLanguageProvider.GetCurrentLanguageAsync();
        return this.GetRouteWithAppliedLanguage(route, currentLanguage);
    }

    /// <summary>
    /// Process current language and set language cookie in the client's browser.
    /// </summary>
    [NonAction]
    protected virtual void ManageLanguageCookie()
    {
        var currentLanguage = this.CurrentLanguageProvider.GetCurrentLanguage();
        if (currentLanguage == null || currentLanguage.IsDefault)
        {
            return;
        }

        bool cookieExist = this.HttpContext.Request.Cookies.ContainsKey(LanguageCookieName);

        CookieOptions options = new CookieOptions
        {
            Expires = DateTime.Now.AddYears(1),
            IsEssential = true,
        };

        if (cookieExist)
        {
            this.Response.Cookies.Delete(LanguageCookieName);
        }

        this.Response.Cookies.Append(LanguageCookieName, currentLanguage.Code, options);
    }

    /// <summary>
    /// Get route with language code at the beginning based on current language.
    /// </summary>
    /// <param name="route"></param>
    /// <returns></returns>
    protected string GetLanguageRoute(string route)
    {
        var currentLanguage = this.currentLanguageProvider.GetCurrentLanguage();
        return this.GetRouteWithAppliedLanguage(route, currentLanguage);
    }

    /// <summary>
    /// Redirect to local url merged with current language code (async extraction).
    /// </summary>
    /// <param name="localUrl"></param>
    /// <returns></returns>
    protected async Task<IActionResult> LanguageLocalRedirectAsync(string localUrl)
    {
        return this.LocalRedirect(await this.GetLanguageRouteAsync(localUrl));
    }

    /// <summary>
    /// Redirect to local url merged with current language code.
    /// </summary>
    /// <param name="localUrl"></param>
    /// <returns></returns>
    protected IActionResult LanguageLocalRedirect(string localUrl)
    {
        return this.LocalRedirect(this.GetLanguageRoute(localUrl));
    }

    /// <summary>
    /// Add a value (translation key) into the ViewData.
    /// </summary>
    /// <param name="key"></param>
    /// <param name="value">Translation key.</param>
    protected void AddTranslatedValueIntoViewData(string key, string value)
    {
        this.ViewData[key] = this.Localizer[value];
    }
}