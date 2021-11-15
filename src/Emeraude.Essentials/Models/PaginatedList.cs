using System;
using System.Collections.Generic;
using System.Linq;

namespace Emeraude.Essentials.Models
{
    /// <summary>
    /// Implementation of list separated on pages.
    /// </summary>
    /// <typeparam name="T">List item type.</typeparam>
    public class PaginatedList<T>
    {
        /// <summary>
        /// List of all items in the list.
        /// </summary>
        public IEnumerable<T> Items { get; set; }

        /// <summary>
        /// Count of all items in all pages.
        /// </summary>
        public int AllItemsCount { get; set; }

        /// <summary>
        /// Count of all items in the list.
        /// </summary>
        public int ItemsCount => this.Items?.Count() ?? 0;

        /// <summary>
        /// Amount of the pages based on all items and page size.
        /// </summary>
        public int PagesCount
        {
            get
            {
                if (this.PageSize == 0)
                {
                    return 1;
                }

                return (int)Math.Ceiling(this.AllItemsCount / ((double)this.PageSize));
            }
        }

        /// <summary>
        /// Amount items on a page.
        /// </summary>
        public int PageSize { get; set; } = 10;

        /// <summary>
        /// Current page index.
        /// </summary>
        public int CurrentPage { get; set; } = 1;

        /// <summary>
        /// Index of the first item of the current page based on all items.
        /// </summary>
        public int StartRow => (this.CurrentPage - 1) * this.PageSize;

        /// <summary>
        /// Validates the list properties.
        /// </summary>
        public void ValidateList()
        {
            if (this.PageSize < this.ItemsCount)
            {
                throw new ArgumentException("List items cannot exceeds the page size.");
            }
        }
    }
}