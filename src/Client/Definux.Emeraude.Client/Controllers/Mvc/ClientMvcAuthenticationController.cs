using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Identity.Entities;
using Definux.Emeraude.Presentation.Controllers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;
using System;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Definux.Emeraude.Client.Controllers.Mvc
{
    public partial class ClientMvcAuthenticationController : PublicController
    {
        public const string LogoutRoute = "/logout";

        private readonly IUserClaimsService userClaimsService;
        private readonly UrlEncoder urlEncoder;
        private readonly EmOptions emeraudeOptions;
        private readonly SignInManager<User> signInManager;

        public ClientMvcAuthenticationController(
            IUserClaimsService userClaimsService,
            UrlEncoder urlEncoder,
            IOptions<EmOptions> emeraudeOptionsAccessor,
            SignInManager<User> signInManager)
        {
            this.userClaimsService = userClaimsService;
            this.urlEncoder = urlEncoder;
            this.emeraudeOptions = emeraudeOptionsAccessor.Value;
            this.signInManager = signInManager;

            HideActivityLogParameters = true;
        }

        [HttpGet]
        [HttpPost]
        [Route(LogoutRoute)]
        public async Task<IActionResult> Logout()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return BadRequest();
            }

            await HttpContext.SignOutAsync(AuthenticationDefaults.ClientAuthenticationScheme);

            return RedirectToHomeIndex();
        }

        protected AuthenticationProperties AuthenticationProperties
        {
            get
            {
                return new AuthenticationProperties
                {
                    IsPersistent = true,
                    ExpiresUtc = DateTime.UtcNow.AddMonths(1)
                };
            }
        }

        protected async Task SignInAsync(IUser user)
        {
            var claims = await this.userClaimsService.GetUserClaimsForCookieAsync(user.Id);
            var claimsIdentity = new ClaimsIdentity(claims, AuthenticationDefaults.ClientAuthenticationScheme);
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            await this.HttpContext.SignInAsync(
                AuthenticationDefaults.ClientAuthenticationScheme,
                claimsPrincipal,
                AuthenticationProperties);
        }

        protected IActionResult RedirectToHomeIndex()
        {
            return RedirectToAction("Index", "Home");
        }

        public override ViewResult View(string viewName, object model)
        {
            return base.View($"Authentication/{viewName}", model);
        }

        public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!this.emeraudeOptions.Account.HasClientMvcAuthentication)
            {
                context.Result = NotFound();
            }

            return base.OnActionExecutionAsync(context, next);
        }
    }
}
