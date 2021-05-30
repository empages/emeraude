using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Definux.Emeraude.Admin.UI.TagHelpers
{
    /// <summary>
    /// Default table cell tag helper.
    /// </summary>
    [HtmlTargetElement(Attributes = AttributeName)]
    public class DefaultTableCellTagHelper : TagHelper
    {
        private const string AttributeName = "default-table-cell";

        /// <summary>
        /// Flag that applies the default table styles to the cell.
        /// </summary>
        [HtmlAttributeName(AttributeName)]
        public bool MakeCellApplicableForDefaultTable { get; set; }

        /// <summary>
        /// Flag that makes the cell with fit content.
        /// </summary>
        [HtmlAttributeName("fit")]
        public bool Fit { get; set; }

        /// <inheritdoc/>
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (this.MakeCellApplicableForDefaultTable)
            {
                output.Attributes.Add(new TagHelperAttribute("class", $"px-2 py-0 text-left{(this.Fit ? " fit" : string.Empty)}"));
            }

            base.Process(context, output);
        }
    }
}