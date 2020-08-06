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
                            x.Append(xx => xx
                                .OpenElement(HtmlTags.Div)
                                .WithClasses("form-check form-check-flat col-4")
                                .Append(xxx => xxx
                                    .OpenElement(HtmlTags.Label)
                                    .WithClasses("form-check-label")
                                    .Append(xxxx => xxxx
                                        .OpenElement(HtmlTags.Input)
                                        .WithId($"flat-checkbox-{Guid.NewGuid()}")
                                        .WithAttribute("type", "checkbox")
                                        .WithAttribute("name", $"{targetProperty}[]")
                                        .WithAttributeIf("checked", "checked", selectedValues?.Contains(dataItem.Key) ?? false)
                                        .WithAttribute("value", dataItem.Key.ToString())
                                        .WithClasses("form-check-input")
                                    )
                                    .Append($" {dataItem.Value} ")
                                    .Append(xxxx => xxxx
                                        .OpenElement(HtmlTags.I)
                                        .WithClasses("input-helper")
                                    )
                                )
                            );
                        }
                    });
        }
    }
}
