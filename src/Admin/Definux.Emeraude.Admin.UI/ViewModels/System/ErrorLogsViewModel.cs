using Definux.Utilities.Objects;

namespace Definux.Emeraude.Admin.UI.ViewModels.System
{
    public class ErrorLogsViewModel : PaginatedList<ErrorLogViewModel>
    {
        public string SearchQuery { get; set; }
    }
}
