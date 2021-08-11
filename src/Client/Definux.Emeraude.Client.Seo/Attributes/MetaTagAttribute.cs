using System.Threading.Tasks;
using Definux.Emeraude.Client.Seo.Extensions;
using Definux.Emeraude.Client.Seo.Models;
using Definux.Utilities.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Definux.Emeraude.Client.Seo.Attributes
{
    /// <summary>
    /// Meta tag attribute that set a main meta tag item into the ViewData.
    /// </summary>
    public class MetaTagAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetaTagAttribute"/> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <param name="extractValueFromViewData"></param>
        public MetaTagAttribute(MainMetaTags type, string value, bool extractValueFromViewData = false)
        {
            this.Type = type;
            this.Value = value;
            this.ExtractValueFromViewData = extractValueFromViewData;
        }

        /// <summary>
        /// Type of the meta tag.
        /// </summary>
        public MainMetaTags Type { get; set; }

        /// <summary>
        /// Flag that indicates whether the meta tag value be extracted from the ViewData or not.
        /// </summary>
        public bool ExtractValueFromViewData { get; set; }

        /// <summary>
        /// Value of the meta tag. In case when <see cref="ExtractValueFromViewData"/> is set to true, the meta tag value will be used as a ViewData key.
        /// </summary>
        public string Value { get; set; }

        /// <inheritdoc cref="ViewDataDictionary"/>
        public ViewDataDictionary ViewData { get; protected set; }

        /// <inheritdoc/>
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var controller = (Controller)context.Controller;
            this.ViewData = controller.ViewData;
            var metaTagsModel = this.ViewData.GetOrCreateCurrentMetaTagsModel();
            string value = this.Value;
            if (this.ExtractValueFromViewData)
            {
                value = this.ViewData.ContainsKey(this.Value) ? this.ViewData[this.Value]?.ToString() : string.Empty;
            }

            metaTagsModel.SetMetaTag(this.Type, value);
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
