using Definux.Emeraude.Client.EmPages.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Definux.Emeraude.Client.EmPages.Models
{
    public class InitialStateModel<TViewModel> : IInitialStateModel<TViewModel>
        where TViewModel : class, IEmViewModel, new()
    {
        public InitialStateModel(string routeName)
        {
            StateString = Guid.NewGuid().ToString();
            User = new RequestUser();
            ViewData = new Dictionary<string, object>();

            if (routeName.EndsWith("Page", StringComparison.OrdinalIgnoreCase))
            {
                RouteName = routeName.Substring(0, routeName.Length - 4);
            }
            else
            {
                RouteName = routeName;
            }
        }

        [JsonProperty("routeName")]
        [EmReadOnly]
        public string RouteName { get; private set; }

        [JsonProperty("stateString")]
        public string StateString { get; private set; }

        [JsonProperty("user")]
        [EmReadOnly]
        public RequestUser User { get; set; }

        [JsonProperty("languageCode")]
        [EmReadOnly]
        public string LanguageCode { get; set; }

        [JsonProperty("languageId")]
        [EmReadOnly]
        public int LanguageId { get; set; }

        [JsonProperty("viewModel")]
        public TViewModel ViewModel { get; set; }

        [JsonProperty("viewData")]
        public Dictionary<string, object> ViewData { get; }

        public void AddViewDataItem(string key, object value)
        {
            if (!ViewData.ContainsKey(key))
            {
                ViewData[key] = value;
            }
        }
    }
}
