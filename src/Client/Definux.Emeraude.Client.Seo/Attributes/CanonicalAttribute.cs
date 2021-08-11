using Definux.Emeraude.Client.Seo.Extensions;
using Definux.Utilities.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Definux.Emeraude.Client.Seo.Attributes
{
    /// <summary>
    /// Canonical attribute that set a href of current page into canonical link tag into the ViewData.
    /// </summary>
    public class CanonicalAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CanonicalAttribute"/> class.
        /// </summary>
        /// <param name="href"></param>
        public CanonicalAttribute(string href = null)
        {
            this.Href = href;
        }

        /// <inheritdoc cref="ViewDataDictionary"/>
        public ViewDataDictionary ViewData { get; protected set; }

        /// <summary>
        /// Href value of the link tag.
        /// </summary>
        public string Href { get; set; }

        /// <inheritdoc/>
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var controller = (Controller)context.Controller;
            this.ViewData = controller.ViewData;
            var metaTagsModel = this.ViewData.GetOrCreateCurrentMetaTagsModel();

            if (string.IsNullOrWhiteSpace(this.Href))
            {
                string href = context.HttpContext.GetAbsoluteRoute(context.HttpContext.Request.Path.Value);
                metaTagsModel.Canonical = href;
                metaTagsModel.OpenGraphUrl.Value = href;
            }
            else
            {
                metaTagsModel.Canonical = this.Href;
                metaTagsModel.OpenGraphUrl.Value = this.Href;
            }

            this.ViewData.ApplyMetaTagsModel(metaTagsModel);
            base.OnActionExecuted(context);
        }

        /// <inheritdoc/>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            var controller = (Controller)context.Controller;
            this.ViewData = controller.ViewData;
            this.ViewData.GetOrCreateCurrentMetaTagsModel();
        }
    }
}