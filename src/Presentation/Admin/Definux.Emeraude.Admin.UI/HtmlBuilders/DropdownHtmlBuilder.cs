using Definux.HtmlBuilder;
using System.Collections.Generic;

namespace Definux.Emeraude.Admin.UI.HtmlBuilders
{
    public class DropdownHtmlBuilder<TKey> : HtmlBuilder.HtmlBuilder
    {
        public DropdownHtmlBuilder(Dictionary<TKey, string> data, string targetProperty, TKey selectedValue, bool isNullable)
        {
            this.StartElement(HtmlTags.Select)
                .WithAttribute("name", targetProperty)
                .WithClasses("form-control")
                .AppendMultiple(x =>
                {
                    if (isNullable)
                    {
                        x.Append(xx => xx
                            .OpenElement(HtmlTags.Option)
                            .WithAttribute("value", string.Empty)
                            .Append(" - ")
                        );
                    }

                    foreach (var dataItem in data)
                    {
                        x.Append(xx => xx
                            .OpenElement(HtmlTags.Option)
                            .WithAttribute("value", dataItem.Key.ToString())
                            .WithAttributeIf("selected", "selected", dataItem.Key.Equals(selectedValue))
                            .Append(dataItem.Value)
                        );
                    }
                });
        }
    }
}
