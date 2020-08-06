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
                            .WithClasses("form-radio form-radio-flat col-4")
                            .Append(xxx => xxx
                                .OpenElement(HtmlTags.Label)
                                .WithClasses("form-check-label")
                                .Append(xxxx => xxxx
                                    .OpenElement(HtmlTags.Input)
                                    .WithId($"flat-radios-{Guid.NewGuid()}")
                                    .WithAttribute("type", "radio")
                                    .WithAttribute("name", targetProperty)
                                    .WithAttributeIf("checked", "checked", dataItem.Key.Equals(selectedValue))
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
