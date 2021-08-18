using System;
using Definux.HtmlBuilder;
using Ganss.XSS;

namespace Definux.Emeraude.Admin.UI.UIElements
{
    /// <summary>
    /// Implementation of <see cref="UIElement"/> for value extracted from custom entity data pair.
    /// </summary>
    /// <typeparam name="TCustomEntityDataPair">Custom entity data pair type.</typeparam>
    public class UICustomEntityDataPairBasedElement<TCustomEntityDataPair> : UIElement
        where TCustomEntityDataPair : ICustomEntityDataPair
    {
        /// <inheritdoc/>
        public override void DefineHtmlBuilder()
        {
            var dataSourceMap = (ICustomEntityDataPair)this.ServiceProvider.GetService(typeof(TCustomEntityDataPair));
            string sourceString = string.Empty;
            var sanitizer = new HtmlSanitizer();

            if (this.DataSource != null)
            {
                var dataSourceId = (Guid)this.DataSource;
                sourceString = dataSourceMap.ContainsKey(dataSourceId) ? sanitizer.Sanitize(dataSourceMap[dataSourceId]) : string.Empty;
            }

            this.HtmlBuilder.StartElement(HtmlTags.Span)
                .Append(sourceString);
        }
    }
}