using System.Collections.Generic;

namespace Definux.Emeraude.Client.EmPages.Models
{
    /// <summary>
    /// Model for definition of data transfer object container from the back-end to the front-end initial state.
    /// </summary>
    /// <typeparam name="TViewModel">Data transfer object that contains the custom strong-typed data for the page.</typeparam>
    public interface IInitialStateModel<TViewModel> : IInitialState
        where TViewModel : class, IEmViewModel, new()
    {
        /// <summary>
        /// Name of the accessed route. It is recommended to match with the name of the page.
        /// </summary>
        string RouteName { get; }

        /// <summary>
        /// Identity user extracted from the request. For more information see <see cref="RequestUser"/>.
        /// </summary>
        RequestUser User { get; }

        /// <summary>
        /// Code of the language extracted from the accessed route.
        /// </summary>
        string LanguageCode { get; set; }

        /// <summary>
        /// Id of the language extracted from the accessed route.
        /// </summary>
        int LanguageId { get; set; }

        /// <summary>
        /// Random string (GUID format) that represents the current request.
        /// </summary>
        string StateString { get; }

        /// <summary>
        /// Data transfer object that contains the custom strong-typed data for the page. For non strong-typed data see <see cref="ViewData"/>.
        /// </summary>
        TViewModel ViewModel { get; set; }

        /// <summary>
        /// Data transfer object that contains the custom non strong-typed data for the page. For strong-typed data see <see cref="ViewModel"/>.
        /// </summary>
        Dictionary<string, object> ViewData { get; }

        /// <summary>
        /// Method that add a new key/value pair to the <see cref="ViewData"/>.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        void AddViewDataItem(string key, object value);
    }
}
