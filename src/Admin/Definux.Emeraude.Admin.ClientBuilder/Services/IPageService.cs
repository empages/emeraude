using System.Collections.Generic;
using Definux.Emeraude.Admin.ClientBuilder.Models;

namespace Definux.Emeraude.Admin.ClientBuilder.Services
{
    /// <summary>
    /// Client builder page service that scan and process assembly information about EmPages.
    /// </summary>
    public interface IPageService
    {
        /// <summary>
        /// Return all pages defined into the application.
        /// </summary>
        /// <returns></returns>
        List<Page> GetAllPages();
    }
}
