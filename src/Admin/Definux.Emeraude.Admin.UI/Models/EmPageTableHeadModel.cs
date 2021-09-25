using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.Admin.UI.Models
{
    /// <summary>
    /// Implementation model of table head.
    /// </summary>
    public class EmPageTableHeadModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageTableHeadModel"/> class.
        /// </summary>
        public EmPageTableHeadModel()
        {
            this.Cells = new List<EmPageTableHeadCellModel>();
        }

        /// <summary>
        /// Cells of the head row.
        /// </summary>
        public IList<EmPageTableHeadCellModel> Cells { get; }

        /// <summary>
        /// Ordered cells of the head row.
        /// </summary>
        public IEnumerable<EmPageTableHeadCellModel> OrderedCells => this.Cells.OrderBy(x => x.Order);
    }
}