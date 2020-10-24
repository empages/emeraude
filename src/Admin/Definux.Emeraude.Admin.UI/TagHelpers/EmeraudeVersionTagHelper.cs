using Definux.Emeraude.Configuration.Options;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Options;

namespace Definux.Emeraude.Admin.UI.TagHelpers
{
    /// <summary>
    /// Tag helper that returns the current version of Emeraude Framework.
    /// </summary>
    [HtmlTargetElement("emeraude-version", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class EmeraudeVersionTagHelper : TagHelper
    {
        private readonly string version;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmeraudeVersionTagHelper"/> class.
        /// </summary>
        /// <param name="options"></param>
        public EmeraudeVersionTagHelper(IOptions<EmOptions> options)
        {
            this.version = options.Value.EmeraudeVersion;
        }

        /// <inheritdoc/>
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "span";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Content.SetContent(this.version);
        }
    }
}
