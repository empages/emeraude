using System.Collections.Generic;
using Definux.Emeraude.Essentials.Models;

namespace Definux.Emeraude.Application.ClientBuilder.Requests.Queries.GetTranslationsGridData
{
    /// <summary>
    /// Transformed translations and their referenced keys into grid format.
    /// </summary>
    public class TranslationsGridDataResult : PaginatedList<TranslationsGridItem>
    {
    }
}
