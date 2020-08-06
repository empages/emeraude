using Definux.Emeraude.Configuration.Options;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Options;

namespace Definux.Emeraude.Admin.UI.TagHelpers
{
    [HtmlTargetElement("emeraude-version", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class EmeraudeVersionTagHelper : TagHelper
    {
        private readonly string version;

        public EmeraudeVersionTagHelper(IOptions<EmOptions> options)
        {
            this.version = options.Value.EmeraudeVersion;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "span";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Content.SetContent(this.version);
        }
    }
}
