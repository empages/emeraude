using System.Threading.Tasks;
using Definux.Emeraude.Admin.UI.Adapters;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Definux.Emeraude.Admin.UI.TagHelpers
{
    [HtmlTargetElement("user-name", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class UserFullNameTagHelper : TagHelper
    {
        private readonly IIdentityUserInfoAdapter identityUserInfoAdapter;

        public UserFullNameTagHelper(IIdentityUserInfoAdapter identityUserInfoAdapter)
        {
            this.identityUserInfoAdapter = identityUserInfoAdapter;
        }

        public async override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var user = await this.identityUserInfoAdapter.GetCurrentUserInfoAsync();

            output.TagName = "span";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Content.SetContent(user?.Name);
        }
    }
}
