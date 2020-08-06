using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.UI.TagHelpers
{
    public class HeadTagHelper : TagHelper
    {
        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            StringBuilder headInjections = (StringBuilder)ViewContext.ViewData[typeof(HeadTagHelper).FullName];
            if (headInjections == null)
            {
                headInjections = new StringBuilder();
            }

            output.PostContent.AppendHtml(new HtmlString(headInjections.ToString()));

            return base.ProcessAsync(context, output);
        }
    }

    public static class HeadTagHelperExtensions
    {
        public static void AppendIntoTheHead(this ViewContext viewContext, string headLine)
        {
            if (viewContext.ViewData[typeof(HeadTagHelper).FullName] == null)
            {
                viewContext.ViewData[typeof(HeadTagHelper).FullName] = new StringBuilder();
            }

            ((StringBuilder)viewContext.ViewData[typeof(HeadTagHelper).FullName]).AppendLine(headLine);
        }
    }
}
