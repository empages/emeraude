using Definux.HtmlBuilder;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.Admin.UI.HtmlBuilders
{
    public class CheckboxGroupHtmlBuilder<TKey> : HtmlBuilder.HtmlBuilder
    {
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
                                .WithAttributeIf("checked", "checked", selectedValues?.Contains(dataItem.Key) ?? false))
                            .Append(xxx => xxx
                                .OpenElement(HtmlTags.Label)
                                .WithClasses("custom-control-label")
                                .WithAttribute("for", $"ch-{targetProperty}-{dataItem.Key}")
                                .Append(dataItem.Value)
                         ));
                        }
                    });
        }
    }
}
