using System;
using Definux.HtmlBuilder;
using Ganss.XSS;

namespace Definux.Emeraude.Admin.UI.UIElements
{
    /// <summary>
    /// Implementation of <see cref="UIElement"/> for value extracted from custom entity data pair.
    /// </summary>
    /// <typeparam name="TCustomEntityDataPair">Custom entity data pair type.</typeparam>
    public class UICustomEntityDataPairBasedElement<TCustomEntityDataPair> : UIElement, IUICustomEntityDataPairBasedElement
        where TCustomEntityDataPair : ICustomEntityDataPair
    {
        /// <inheritdoc/>
        public override void DefineHtmlBuilder()
        {
            var entityDataPair = this.GetSource();
            string sourceString = string.Empty;
            var sanitizer = new HtmlSanitizer();

            if (this.DataSource != null)
            {
                var dataSourceId = (Guid)this.DataSource;
                sourceString = entityDataPair.ContainsKey(dataSourceId) ? sanitizer.Sanitize(entityDataPair[dataSourceId]) : string.Empty;
            }

            this.HtmlBuilder.StartElement(HtmlTags.Span)
                .Append(sourceString);
        }

        /// <inheritdoc/>
        public ICustomEntityDataPair GetSource() => (ICustomEntityDataPair)this.ServiceProvider.GetService(typeof(TCustomEntityDataPair));
    }
}