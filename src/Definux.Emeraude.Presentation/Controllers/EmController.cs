using System.Text.Encodings.Web;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Infrastructure.Identity.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Presentation.Controllers
{
    /// <summary>
    /// Base Emeraude controller that provides all required services and base functionalities.
    /// </summary>
    public abstract class EmController : Controller
    {
        private UrlEncoder urlEncoder;
        private IMediator mediator;
        private ICurrentUserProvider currentUserProvider;
        private IEmOptionsProvider optionsProvider;

        /// <inheritdoc cref="IMediator"/>
        protected IMediator Mediator => this.mediator ??= this.HttpContext?.RequestServices?.GetService<IMediator>();

        /// <inheritdoc cref="System.Text.Encodings.Web.UrlEncoder"/>
        protected UrlEncoder UrlEncoder => this.urlEncoder ??= this.HttpContext.RequestServices.GetService<UrlEncoder>();

        /// <inheritdoc cref="ICurrentUserProvider"/>
        protected ICurrentUserProvider CurrentUserProvider =>
            this.currentUserProvider ??= this.HttpContext.RequestServices.GetService<ICurrentUserProvider>();

        /// <inheritdoc cref="IEmOptionsProvider"/>
        protected IEmOptionsProvider OptionsProvider =>
            this.optionsProvider ??= this.HttpContext.RequestServices.GetService<IEmOptionsProvider>();
    }
}