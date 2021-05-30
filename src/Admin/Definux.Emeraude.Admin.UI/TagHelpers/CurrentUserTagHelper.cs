using System.Threading.Tasks;
using Definux.Emeraude.Admin.UI.Adapters;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Definux.Emeraude.Admin.UI.TagHelpers
{
    /// <summary>
    /// Returns the current user name and email packed in a span. Example: Admin Name (admin@example.com).
    /// </summary>
    [HtmlTargetElement("current-user", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class CurrentUserTagHelper : TagHelper
    {
        private readonly IIdentityUserInfoAdapter identityUserInfoAdapter;

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentUserTagHelper"/> class.
        /// </summary>
        /// <param name="identityUserInfoAdapter"></param>
        public CurrentUserTagHelper(IIdentityUserInfoAdapter identityUserInfoAdapter)
        {
            this.identityUserInfoAdapter = identityUserInfoAdapter;
        }

        /// <inheritdoc/>
        public async override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var user = await this.identityUserInfoAdapter.GetCurrentUserInfoAsync();

            output.TagName = "span";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Content.SetContent($"{user?.Name} ({user?.Email})");
        }
    }
}