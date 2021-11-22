namespace Emeraude.Application.Admin.EmPages.Models.IndexView
{
    /// <summary>
    /// Implementation of table header cell.
    /// </summary>
    public class EmPageTableHeadCellModel
    {
        /// <summary>
        /// Order of the cell.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Name of the cell.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Property of the cell.
        /// </summary>
        public string Identifier { get; set; }
    }
}