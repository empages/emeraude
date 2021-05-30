using System.Collections.Generic;
using Definux.HtmlBuilder;

namespace Definux.Emeraude.Admin.UI.HtmlBuilders
{
    /// <summary>
    /// Predefined radio group <see cref="HtmlBuilder.HtmlBuilder"/>.
    /// </summary>
    /// <typeparam name="TKey">Key that represent the value used for radios.</typeparam>
    public class RadioGroupHtmlBuilder<TKey> : HtmlBuilder.HtmlBuilder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RadioGroupHtmlBuilder{TKey}"/> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="targetProperty"></param>
        /// <param name="selectedValue"></param>
        public RadioGroupHtmlBuilder(Dictionary<TKey, string> data, string targetProperty, TKey selectedValue)
        {
            this.StartElement(HtmlTags.Div)
                .WithClasses("row m-0")
                .AppendMultiple(x =>
                {
                    foreach (var dataItem in data)
                    {
                        x.Append(xx => xx
                            .OpenElement(HtmlTags.Div)
                            .WithClasses("custom-control custom-radio mr-3")
                            .Append(xxxx => xxxx
                                    .OpenElement(HtmlTags.Input)
                                    .WithId($"rad-{targetProperty}-{dataItem.Key}")
                                    .WithAttribute("type", "radio")
                                    .WithAttribute("name", targetProperty)
                                    .WithAttributeIf("checked", "checked", dataItem.Key.Equals(selectedValue))
                                    .WithAttribute("value", dataItem.Key.ToString())
                                    .WithClasses("custom-control-input"))
                            .Append(xxx => xxx
                                .OpenElement(HtmlTags.Label)
                                .WithClasses("custom-control-label")
                                .WithAttribute("for", $"rad-{targetProperty}-{dataItem.Key}")
                                .Append(dataItem.Value)));
                    }
                });
        }
    }
}
