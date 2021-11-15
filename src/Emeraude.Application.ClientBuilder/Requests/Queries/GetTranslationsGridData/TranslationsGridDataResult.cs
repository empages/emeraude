using System.Collections.Generic;
using Emeraude.Essentials.Models;

namespace Emeraude.Application.ClientBuilder.Requests.Queries.GetTranslationsGridData
{
    /// <summary>
    /// Transformed translations and their referenced keys into grid format.
    /// </summary>
    public class TranslationsGridDataResult : PaginatedList<TranslationsGridItem>
    {
    }
}
