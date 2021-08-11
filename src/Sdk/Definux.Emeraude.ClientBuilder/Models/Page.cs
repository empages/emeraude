using System;
using System.Text.Json.Serialization;

namespace Definux.Emeraude.ClientBuilder.Models
{
    /// <summary>
    /// Definition of page in the Client Builder environment.
    /// </summary>
    public class Page
    {
        /// <summary>
        /// Id of the page.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Name of the page.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Full name of the page.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Route of the page.
        /// </summary>
        public string Route { get; set; }

        /// <summary>
        /// Flag that indicates whether the page required authorization.
        /// </summary>
        public bool Authorized { get; set; }

        /// <summary>
        /// Route of the page in the client environment.
        /// </summary>
        public string ClientRoute { get; set; }

        /// <summary>
        /// Type of the initial state model.
        /// </summary>
        [JsonIgnore]
        public Type InitialStateModelType { get; set; }

        /// <summary>
        /// Type description of the initial state model.
        /// </summary>
        [JsonIgnore]
        public TypeDescription InitialStateModelClass { get; set; }
    }
}
