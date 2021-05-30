namespace Definux.Emeraude.Admin.UI.UIElements.Details.Implementations
{
    /// <summary>
    /// Implementation of <see cref="UIElement"/> for value extracted from data source map for details elements.
    /// </summary>
    /// <typeparam name="TDataSourceMap">Data source map type.</typeparam>
    public class DetailsFieldDataSourceMapElement<TDataSourceMap> : UIDataSourceMapBasedElement<TDataSourceMap>, IDetailsFieldElement
        where TDataSourceMap : IDataSourceMap
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsFieldDataSourceMapElement{TDataSourceMap}"/> class.
        /// </summary>
        public DetailsFieldDataSourceMapElement()
            : base()
        {
        }

        /// <inheritdoc/>
        public bool HasClipboardCopyButton => true;
    }
}