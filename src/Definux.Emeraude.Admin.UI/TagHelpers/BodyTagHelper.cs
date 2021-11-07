using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Definux.Emeraude.Admin.UI.TagHelpers
{
    /// <summary>
    /// Body tag helper.
    /// </summary>
    public class BodyTagHelper : TagHelper
    {
        /// <inheritdoc cref="Microsoft.AspNetCore.Mvc.Rendering.ViewContext"/>
        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        /// <inheritdoc/>
        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            StringBuilder headInjections = (StringBuilder)this.ViewContext.ViewData[typeof(BodyTagHelper).FullName];
            if (headInjections == null)
            {
                headInjections = new StringBuilder();
            }

            output.PostContent.AppendHtml(new HtmlString(headInjections.ToString()));

            return base.ProcessAsync(context, output);
        }
    }
}
