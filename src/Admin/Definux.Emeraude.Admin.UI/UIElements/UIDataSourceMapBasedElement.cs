using System;
using Definux.HtmlBuilder;
using Ganss.XSS;

namespace Definux.Emeraude.Admin.UI.UIElements
{
    /// <summary>
    /// Implementation of <see cref="UIElement"/> for value extracted from data source map.
    /// </summary>
    /// <typeparam name="TDataSourceMap">Data source map type.</typeparam>
    public class UIDataSourceMapBasedElement<TDataSourceMap> : UIElement
        where TDataSourceMap : IDataSourceMap
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UIDataSourceMapBasedElement{TDataSourceMap}"/> class.
        /// </summary>
        public UIDataSourceMapBasedElement()
            : base()
        {
        }

        /// <inheritdoc/>
        public override void DefineHtmlBuilder()
        {
            var dataSourceMap = (IDataSourceMap)this.ServiceProvider.GetService(typeof(TDataSourceMap));
            string sourceString = string.Empty;
            var sanitizer = new HtmlSanitizer();

            if (this.DataSource != null)
            {
                var dataSourceId = (Guid)this.DataSource;
                if (dataSourceMap.ContainsKey(dataSourceId))
                {
                    sourceString = sanitizer.Sanitize(dataSourceMap[dataSourceId]);
                }
                else
                {
                    sourceString = string.Empty;
                }
            }

            this.HtmlBuilder.StartElement(HtmlTags.Span)
                .Append(sourceString);
        }
    }
}