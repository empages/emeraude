using System;
using System.Collections.Generic;
using System.Linq;
using Definux.HtmlBuilder;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Definux.Emeraude.Admin.UI.TagHelpers
{
    /// <summary>
    /// Returns the layout of the default styled table in Emeraude administration.
    /// </summary>
    [HtmlTargetElement("default-table", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class DefaultTableTagHelper : TagHelper
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultTableTagHelper"/> class.
        /// </summary>
        public DefaultTableTagHelper()
        {
            this.Columns = new AttributeDictionary();
        }

        /// <summary>
        /// Columns of the table in form of arguments. Example of usage - column-1="Id"
        /// </summary>
        [HtmlAttributeName("column")]
        public AttributeDictionary Columns { get; set; }

        /// <inheritdoc/>
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var defaultTableHtmlBuilder = new HtmlBuilder.HtmlBuilder();
            var columns = new Dictionary<int, string>();
            foreach (var column in this.Columns)
            {
                if (int.TryParse(column.Key, out int columnIndex))
                {
                    columns[Math.Abs(columnIndex)] = column.Value;
                }
                else
                {
                    columns[columns.Keys.Max() + 10000] = column.Value;
                }
            }

            var columnsArray = columns.OrderBy(x => x.Key).Select(x => x.Value).ToArray();

            defaultTableHtmlBuilder.StartElement(HtmlTags.Div)
                .WithClasses("responsive-table")
                .Append(x => x
                    .OpenElement(HtmlTags.Table)
                    .WithClasses("table table-hover table-striped table-bordered")
                    .Append(xx => xx
                        .OpenElement(HtmlTags.Thead)
                        .WithClasses("text-left")
                        .Append(xxx => xxx
                            .OpenElement(HtmlTags.Tr)
                            .AppendMultiple(xxxx =>
                            {
                                foreach (var column in columnsArray)
                                {
                                    xxxx.Append(xxxxx => xxxxx
                                        .OpenElement(HtmlTags.Th)
                                        .WithClasses("p-2 h-auto")
                                        .Append(column));
                                }
                            })))
                    .Append(xx => xx
                        .OpenElement(HtmlTags.Tbody)
                        .Append(output?.GetChildContentAsync()?.Result?.GetContent() ?? string.Empty)));

            output = defaultTableHtmlBuilder.ApplyToTagHelperOutput(output);

            base.Process(context, output);
        }
    }
}