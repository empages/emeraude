using System.Collections.Generic;

namespace Definux.Emeraude.Client.EmPages.Models
{
    public interface IInitialStateModel<TViewModel> : IInitialState
        where TViewModel : class, IEmViewModel, new()
    {
        string RouteName { get; }

        RequestUser User { get; }

        string LanguageCode { get; set; }

        int LanguageId { get; set; }

        string StateString { get; }

        TViewModel ViewModel { get; set; }

        Dictionary<string, object> ViewData { get; }

        void AddViewDataItem(string key, object value);
    }
}
