namespace Definux.Emeraude.Admin.UI.ViewModels.Entity.Table
{
    /// <summary>
    /// Entity ViewModel that contains the render properties for the table view.
    /// </summary>
    public class TableViewViewModel
    {
        /// <summary>
        /// Title of the view.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Entity name as a single item.
        /// </summary>
        public string SingleEntityName { get; set; }

        /// <inheritdoc cref="TableViewModel"/>
        public TableViewModel Table { get; set; }
    }
}
