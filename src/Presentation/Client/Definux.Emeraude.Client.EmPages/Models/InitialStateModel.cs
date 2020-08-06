using Definux.Emeraude.Client.EmPages.Attributes;
using Newtonsoft.Json;
using System;

namespace Definux.Emeraude.Client.EmPages.Models
{
    public abstract class InitialStateModel<TData> : IInitialStateModel<TData>
        where TData : class, IInitialStateModelData, new()
    {
        public InitialStateModel(string routeName)
        {
            StateString = Guid.NewGuid().ToString();
            User = new InitialStateUserModel();
            RouteName = routeName;
        }

        [JsonProperty("routeName")]
        [EmReadOnly]
        public string RouteName { get; private set; }

        [JsonProperty("stateString")]
        public string StateString { get; private set; }

        [JsonProperty("user")]
        [EmReadOnly]
        public InitialStateUserModel User { get; set; }

        [JsonProperty("languageCode")]
        [EmReadOnly]
        public string LanguageCode { get; set; }

        [JsonProperty("languageId")]
        [EmReadOnly]
        public int LanguageId { get; set; }

        [JsonProperty("data")]
        public TData Data { get; set; }
    }
}
