using System;
using System.Collections.Generic;
using Definux.Emeraude.Client.EmPages.Attributes;
using Definux.Seo.Models;
using Newtonsoft.Json;

namespace Definux.Emeraude.Client.EmPages.Models
{
    /// <inheritdoc cref="IInitialStateModel{TViewModel}"/>
    public class InitialStateModel<TViewModel> : IInitialStateModel<TViewModel>
        where TViewModel : class, IEmViewModel, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InitialStateModel{TViewModel}"/> class.
        /// </summary>
        /// <param name="routeName"></param>
        public InitialStateModel(string routeName)
        {
            this.StateString = Guid.NewGuid().ToString();
            this.User = new RequestUser();
            this.ViewData = new Dictionary<string, object>();

            if (routeName.EndsWith("Page", StringComparison.OrdinalIgnoreCase))
            {
                this.RouteName = routeName.Substring(0, routeName.Length - 4);
            }
            else
            {
                this.RouteName = routeName;
            }
        }

        /// <inheritdoc/>
        [JsonProperty("routeName")]
        [EmReadOnly]
        public string RouteName { get; private set; }

        /// <inheritdoc/>
        [JsonProperty("stateString")]
        public string StateString { get; private set; }

        /// <inheritdoc/>
        [JsonProperty("user")]
        [EmReadOnly]
        public RequestUser User { get; set; }

        /// <inheritdoc/>
        [JsonProperty("languageCode")]
        [EmReadOnly]
        public string LanguageCode { get; set; }

        /// <inheritdoc/>
        [JsonProperty("languageId")]
        [EmReadOnly]
        public int LanguageId { get; set; }

        /// <inheritdoc/>
        [JsonProperty("viewModel")]
        public TViewModel ViewModel { get; set; }

        /// <inheritdoc/>
        [JsonProperty("viewData")]
        public Dictionary<string, object> ViewData { get; }

        /// <inheritdoc/>
        [JsonProperty("metaTags")]
        public MetaTagsModel MetaTags { get; set; }

        /// <inheritdoc/>
        public void AddViewDataItem(string key, object value)
        {
            if (!this.ViewData.ContainsKey(key))
            {
                this.ViewData[key] = value;
            }
        }
    }
}
