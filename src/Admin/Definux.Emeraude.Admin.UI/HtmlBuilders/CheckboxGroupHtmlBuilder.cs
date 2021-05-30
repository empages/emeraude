using System;
using System.Collections.Generic;
using System.Linq;
using Definux.HtmlBuilder;

namespace Definux.Emeraude.Admin.UI.HtmlBuilders
{
    /// <summary>
    /// Built wrapper for HTML builder which creates checkbox group element.
    /// </summary>
    /// <typeparam name="TKey">Value type.</typeparam>
    public class CheckboxGroupHtmlBuilder<TKey> : HtmlBuilder.HtmlBuilder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckboxGroupHtmlBuilder{TKey}"/> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="targetProperty"></param>
        /// <param name="selectedValues"></param>
        public CheckboxGroupHtmlBuilder(Dictionary<TKey, string> data, string targetProperty, TKey[] selectedValues)
        {
            this.StartElement(HtmlTags.Div)
                    .WithClasses("row m-0")
                    .AppendMultiple(x =>
                    {
                        foreach (var dataItem in data)
                        {
                            x.Append(xx => xx.OpenElement(HtmlTags.Div)
                            .WithClasses("custom-control custom-checkbox mr-3")
                            .Append(xxx => xxx
                                .OpenElement(HtmlTags.Input)
                                .WithId($"ch-{targetProperty}-{dataItem.Key}")
                                .WithClasses("custom-control-input")
                                .WithAttribute("type", "checkbox")
                                .WithAttribute("name", $"{targetProperty}[]")
                                .WithAttribute("value", dataItem.Key.ToString())
                                .WithAttributeIf("checked", "checked", selectedValues?.Contains(dataItem.Key) ?? false))
                            .Append(xxx => xxx
                                .OpenElement(HtmlTags.Label)
                                .WithClasses("custom-control-label")
                                .WithAttribute("for", $"ch-{targetProperty}-{dataItem.Key}")
                                .Append(dataItem.Value)));
                        }
                    });
        }
    }
}
