using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Definux.Emeraude.ClientBuilder.ScaffoldModules;

namespace Definux.Emeraude.ClientBuilder.Options
{
    /// <summary>
    /// Options for client builder.
    /// </summary>
    public class ClientBuilderOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientBuilderOptions"/> class.
        /// </summary>
        public ClientBuilderOptions()
        {
            this.Assemblies = new List<Assembly>();
            this.ModulesTypes = new List<Type>();
            this.ConstantsTypes = new List<Type>();
            this.Constants = new Dictionary<string, object>();
            this.ClientApplicationsPaths = new Dictionary<string, string>();
        }

        /// <summary>
        /// Assemblies which will be scanned for the purposes of client builder.
        /// </summary>
        public List<Assembly> Assemblies { get; internal set; }

        /// <summary>
        /// List of all scaffold modules used for code generation from the client builder.
        /// </summary>
        public List<Type> ModulesTypes { get; internal set; }

        /// <summary>
        /// List of all classes types which will be scanned for constants.
        /// </summary>
        public List<Type> ConstantsTypes { get; private set; }

        /// <summary>
        /// Dictionary of all constants which will be exposed by the Client Builder.
        /// </summary>
        public Dictionary<string, object> Constants { get; private set; }

        /// <summary>
        /// Paths of the client applications used use for the purposes of client builder.
        /// </summary>
        public Dictionary<string, string> ClientApplicationsPaths { get; private set; }

        /// <summary>
        /// Method that set the mobile application path into the options.
        /// </summary>
        /// <param name="clientIdentifier"></param>
        /// <param name="paths">Paths are defined by the solution folder.</param>
        public void SetClientApplicationPath(string clientIdentifier, params string[] paths)
        {
            this.ClientApplicationsPaths[clientIdentifier] = Path.Combine(paths);
        }

        /// <summary>
        /// Returns client path based on specified identifier.
        /// </summary>
        /// <param name="clientIdentifier"></param>
        /// <returns></returns>
        /// <exception cref="KeyNotFoundException">Throw an error in case of undefined client path.</exception>
        public string GetClientApplicationPath(string clientIdentifier)
        {
            if (!this.ClientApplicationsPaths.ContainsKey(clientIdentifier))
            {
                throw new KeyNotFoundException($"There is no defined client application path for that identifier '{clientIdentifier}'");
            }

            return this.ClientApplicationsPaths[clientIdentifier];
        }

        /// <summary>
        /// Add assembly which will be scan for the purposes of Emeraude Client Builder.
        /// </summary>
        /// <param name="assemblyString"></param>
        public void AddAssembly(string assemblyString)
        {
            this.Assemblies.Add(Assembly.Load(assemblyString));
        }

        /// <summary>
        /// Add module to Emeraude Client Builder.
        /// </summary>
        /// <typeparam name="TModule">Type of the module.</typeparam>
        public void AddModule<TModule>()
            where TModule : ScaffoldModule
        {
            this.ModulesTypes.Add(typeof(TModule));
        }
    }
}
