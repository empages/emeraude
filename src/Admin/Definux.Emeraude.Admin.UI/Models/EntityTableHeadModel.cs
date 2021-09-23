using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.Admin.UI.Models
{
    /// <summary>
    /// Implementation model of table head.
    /// </summary>
    public class EntityTableHeadModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityTableHeadModel"/> class.
        /// </summary>
        public EntityTableHeadModel()
        {
            this.Cells = new List<EntityTableHeadCellModel>();
        }

        /// <summary>
        /// Cells of the head row.
        /// </summary>
        public IList<EntityTableHeadCellModel> Cells { get; }

        /// <summary>
        /// Ordered cells of the head row.
        /// </summary>
        public IEnumerable<EntityTableHeadCellModel> OrderedCells => this.Cells.OrderBy(x => x.Order);
    }
}