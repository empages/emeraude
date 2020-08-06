using Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Definux.Emeraude.Admin.ClientBuilder.Options
{
    public class ClientBuilderOptions
    {
        public ClientBuilderOptions()
        {
            Assemblies = new List<Assembly>();
            ModulesTypes = new List<Type>();
        }
        public List<Assembly> Assemblies { get; internal set; }

        public List<Type> ModulesTypes { get; internal set; }

        public string WebAppPath { get; set; }

        public string MobileAppPath { get; set; }

        public void SetWebAppPath(params string[] paths)
        {
            WebAppPath = Path.Combine(paths);
        }

        public void SetMobileAppPath(params string[] paths)
        {
            MobileAppPath = Path.Combine(paths);
        }

        /// <summary>
        /// Add assembly which will be scan for the purposes of Emeraude Client Builder.
        /// </summary>
        /// <param name="assemblyString"></param>
        public void AddAssembly(string assemblyString)
        {
            Assemblies.Add(Assembly.Load(assemblyString));
        }

        /// <summary>
        /// Add module to Emeraude Client Builder.
        /// </summary>
        /// <typeparam name="TModule"></typeparam>
        public void AddModule<TModule>()
            where TModule : ScaffoldModule
        {
            ModulesTypes.Add(typeof(TModule));
        }
    }
}
