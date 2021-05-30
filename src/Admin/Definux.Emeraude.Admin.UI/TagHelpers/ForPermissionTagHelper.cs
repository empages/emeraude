using System.Linq;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.UI.Adapters;
using Definux.Emeraude.Configuration.Authorization;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Definux.Emeraude.Admin.UI.TagHelpers
{
    /// <summary>
    /// Show or hide the content of the tag based on specified permission.
    /// </summary>
    [HtmlTargetElement("for-permission", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class ForPermissionTagHelper : TagHelper
    {
        private readonly IIdentityUserInfoAdapter identityUserInfoAdapter;

        /// <summary>
        /// Initializes a new instance of the <see cref="ForPermissionTagHelper"/> class.
        /// </summary>
        /// <param name="identityUserInfoAdapter"></param>
        public ForPermissionTagHelper(IIdentityUserInfoAdapter identityUserInfoAdapter)
        {
            this.identityUserInfoAdapter = identityUserInfoAdapter;
        }

        /// <summary>
        /// Target permission.
        /// </summary>
        [HtmlAttributeName("permission")]
        public string Permission { get; set; }

        /// <inheritdoc />
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            var currentUserClaims = await this.identityUserInfoAdapter.GetCurrentUserClaimsAsync();
            if (currentUserClaims != null && currentUserClaims.Any(x => x.Type == ClaimTypes.Permission && x.Value == this.Permission))
            {
                output.Content.SetHtmlContent(new HtmlString(output?.GetChildContentAsync()?.Result?.GetContent()));
            }
            else
            {
                output.Content.SetContent(string.Empty);
            }

            await base.ProcessAsync(context, output);
        }
    }
}