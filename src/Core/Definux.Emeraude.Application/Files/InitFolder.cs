using System.Collections.Generic;
using Newtonsoft.Json;

namespace Definux.Emeraude.Application.Files
{
    /// <summary>
    /// Class that represent the folder that must be initialized on the start of the application.
    /// </summary>
    public class InitFolder
    {
        /// <summary>
        /// Name of the folder.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// List of all children folders that are placed in the current folder.
        /// </summary>
        [JsonProperty("children")]
        public List<InitFolder> Children { get; set; }
    }
}