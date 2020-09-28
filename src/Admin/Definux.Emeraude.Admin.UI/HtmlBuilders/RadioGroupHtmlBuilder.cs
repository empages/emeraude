using Definux.HtmlBuilder;
using System;
using System.Collections.Generic;

namespace Definux.Emeraude.Admin.UI.HtmlBuilders
{
    public class RadioGroupHtmlBuilder<TKey> : HtmlBuilder.HtmlBuilder
    {
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
                                    .WithClasses("custom-control-input")
                                )
                            .Append(xxx => xxx
                                .OpenElement(HtmlTags.Label)
                                .WithClasses("custom-control-label")
                                .WithAttribute("for", $"rad-{targetProperty}-{dataItem.Key}")
                                .Append(dataItem.Value)
                            )
                        );
                    }
                });
        }
    }
}
