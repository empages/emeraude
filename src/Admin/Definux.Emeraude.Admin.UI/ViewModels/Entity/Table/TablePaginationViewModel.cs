using System.Collections.Generic;

namespace Definux.Emeraude.Admin.UI.ViewModels.Entity.Table
{
    /// <summary>
    /// Implementation of table pagination.
    /// </summary>
    public class TablePaginationViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TablePaginationViewModel"/> class.
        /// </summary>
        /// <param name="currentPage"></param>
        /// <param name="pagesCount"></param>
        public TablePaginationViewModel(int currentPage, int pagesCount)
        {
            this.CurrentPage = currentPage;

            if (this.CurrentPage != 1)
            {
                this.PreviousPage = this.CurrentPage - 1;
            }

            if (this.CurrentPage != pagesCount)
            {
                this.NextPage = this.CurrentPage + 1;
            }

            for (int i = 1; i <= 2; i++)
            {
                if (this.CurrentPage - i >= 1)
                {
                    this.PreviousPagesCount++;
                }

                if (this.CurrentPage + i <= pagesCount)
                {
                    this.NextPagesCount++;
                }
            }
        }

        /// <summary>
        /// Current selected page.
        /// </summary>
        public int CurrentPage { get; private set; }

        /// <summary>
        /// Next page based on the current page.
        /// </summary>
        public int? NextPage { get; private set; }

        /// <summary>
        /// Previous page based on the current page.
        /// </summary>
        public int? PreviousPage { get; private set; }

        /// <summary>
        /// Amount of all pages after the current.
        /// </summary>
        public int NextPagesCount { get; private set; }

        /// <summary>
        /// Amount of all pages before the current.
        /// </summary>
        public int PreviousPagesCount { get; private set; }

        /// <summary>
        /// Additional query string parameters.
        /// </summary>
        public Dictionary<string, object> AdditionalQueryParams { get; set; }
    }
}
