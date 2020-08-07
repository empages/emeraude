using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.UI.TagHelpers
{
    public class BodyTagHelper : TagHelper
    {
        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            StringBuilder headInjections = (StringBuilder)ViewContext.ViewData[typeof(BodyTagHelper).FullName];
            if (headInjections == null)
            {
                headInjections = new StringBuilder();
            }

            output.PostContent.AppendHtml(new HtmlString(headInjections.ToString()));

            return base.ProcessAsync(context, output);
        }
    }

    public static class BodyTagHelperExtensions
    {
        public static void AppendIntoTheBody(this ViewContext viewContext, string headLine)
        {
            if (viewContext.ViewData[typeof(BodyTagHelper).FullName] == null)
            {
                viewContext.ViewData[typeof(BodyTagHelper).FullName] = new StringBuilder();
            }

            ((StringBuilder)viewContext.ViewData[typeof(BodyTagHelper).FullName]).AppendLine(headLine);
        }
    }
}
