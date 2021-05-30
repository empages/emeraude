using System.Collections.Generic;
using Definux.HtmlBuilder;

namespace Definux.Emeraude.Admin.UI.HtmlBuilders
{
    /// <summary>
    /// Built wrapper for HTML builder which creates dropdown element.
    /// </summary>
    /// <typeparam name="TKey">Value type.</typeparam>
    public class DropdownHtmlBuilder<TKey> : HtmlBuilder.HtmlBuilder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DropdownHtmlBuilder{TKey}"/> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="targetProperty"></param>
        /// <param name="selectedValue"></param>
        /// <param name="isNullable"></param>
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
                            .Append(" - "));
                    }

                    foreach (var dataItem in data)
                    {
                        x.Append(xx => xx
                            .OpenElement(HtmlTags.Option)
                            .WithAttribute("value", dataItem.Key.ToString())
                            .WithAttributeIf("selected", "selected", dataItem.Key.Equals(selectedValue))
                            .Append(dataItem.Value));
                    }
                });
        }
    }
}
