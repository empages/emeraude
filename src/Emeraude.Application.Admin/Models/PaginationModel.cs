using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace Emeraude.Application.Admin.Models;

/// <summary>
/// Implementation of table pagination.
/// </summary>
public class PaginationModel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PaginationModel"/> class.
    /// </summary>
    /// <param name="currentPage"></param>
    /// <param name="pagesCount"></param>
    public PaginationModel(int currentPage, int pagesCount)
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

    /// <summary>
    /// Returns collection of all previous pages numbers.
    /// </summary>
    public IEnumerable<int> PreviousPages
    {
        get
        {
            var pages = new List<int>();
            for (int i = this.PreviousPagesCount; i >= 1; i--)
            {
                pages.Add(this.CurrentPage - i);
            }

            return pages;
        }
    }

    /// <summary>
    /// Returns collection of all next pages numbers.
    /// </summary>
    public IEnumerable<int> NextPages
    {
        get
        {
            var pages = new List<int>();
            for (int i = 1; i <= this.NextPagesCount; i++)
            {
                pages.Add(this.CurrentPage + i);
            }

            return pages;
        }
    }

    /// <summary>
    /// Get pagination href.
    /// </summary>
    /// <param name="page"></param>
    /// <param name="navigationManager"></param>
    /// <returns></returns>
    public string GetPaginationHref(int? page, NavigationManager navigationManager)
    {
        var targetUri = navigationManager.GetUriWithQueryParameters(new Dictionary<string, object>
        {
            { "page", page },
        });

        return targetUri;
    }
}