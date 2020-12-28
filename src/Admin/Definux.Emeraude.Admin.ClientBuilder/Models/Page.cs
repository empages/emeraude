using System;
using System.Text.Json.Serialization;

namespace Definux.Emeraude.Admin.ClientBuilder.Models
{
    public class Page : ClientBuilderEntity
    {
        public string Name { get; set; }

        public string Route { get; set; }

        public bool Authorized { get; set; }

        public string ClientRoute { get; set; }

        [JsonIgnore]
        public Type InitialStateModelType { get; set; }

        [JsonIgnore]
        public TypeDescription InitialStateModelClass { get; set; }
    }
}
