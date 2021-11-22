using System.Collections.Generic;

namespace Emeraude.Application.Admin.EmPages.Models.IndexView
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
        public List<EmPageTableHeadCellModel> Cells { get; }
    }
}