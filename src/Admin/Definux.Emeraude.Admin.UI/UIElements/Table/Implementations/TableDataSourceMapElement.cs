namespace Definux.Emeraude.Admin.UI.UIElements.Table.Implementations
{
    /// <summary>
    /// Implementation of <see cref="UIElement"/> for value extracted from data source map for table elements.
    /// </summary>
    /// <typeparam name="TDataSourceMap">Data source map type.</typeparam>
    public class TableDataSourceMapElement<TDataSourceMap> : UIDataSourceMapBasedElement<TDataSourceMap>, ITableElement
        where TDataSourceMap : IDataSourceMap
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableDataSourceMapElement{TDataSourceMap}"/> class.
        /// </summary>
        public TableDataSourceMapElement()
            : base()
        {
        }
    }
}