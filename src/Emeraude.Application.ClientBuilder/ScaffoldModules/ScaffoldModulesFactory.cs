using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Emeraude.Application.ClientBuilder.Extensions;
using Emeraude.Application.ClientBuilder.Options;
using Emeraude.Application.ClientBuilder.Shared;
using Emeraude.Configuration.Options;
using Microsoft.AspNetCore.Hosting;

namespace Emeraude.Application.ClientBuilder.ScaffoldModules
{
    /// <inheritdoc cref=" IScaffoldModulesFactory"/>
    public class ScaffoldModulesFactory : IScaffoldModulesFactory
    {
        private readonly IWebHostEnvironment hostEnvironment;
        private readonly EmClientBuilderOptions clientBuilderOptions;
        private readonly IServiceProvider serviceProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="ScaffoldModulesFactory"/> class.
        /// </summary>
        /// <param name="hostEnvironment"></param>
        /// <param name="optionsProvider"></param>
        /// <param name="serviceProvider"></param>
        public ScaffoldModulesFactory(
            IWebHostEnvironment hostEnvironment,
            IEmOptionsProvider optionsProvider,
            IServiceProvider serviceProvider)
        {
            this.hostEnvironment = hostEnvironment;
            this.clientBuilderOptions = optionsProvider.GetClientBuilderOptions();
            this.serviceProvider = serviceProvider;

            this.LoadModules();
            this.SyncModules();
        }

        /// <inheritdoc/>
        public IList<ScaffoldModule> Modules { get; private set; }

        /// <inheritdoc/>
        public IList<ScaffoldModule> GetModulesByClientId(string clientId)
            => this.Modules?
                .Where(x => x.ClientId.Equals(clientId, StringComparison.OrdinalIgnoreCase))
                .OrderBy(x => x.Order)
                .ToList();

        /// <inheritdoc/>
        public IList<ScaffoldModule> GetModulesByInstance(InstanceType type)
            => this.Modules?
                .Where(x => x.Type == type)
                .OrderBy(x => x.Order)
                .ToList();

        /// <inheritdoc/>
        public bool GenerateModule(string moduleId, out string errorMessage)
        {
            var module = this.GetModule(moduleId);
            return module.Generate(out errorMessage);
        }

        /// <inheritdoc/>
        public ScaffoldModule GetModule(string moduleId)
        {
            return this.Modules.FirstOrDefault(x => x.Id == moduleId);
        }

        private void SyncModules()
        {
            foreach (var module in this.Modules)
            {
                module.Sync();
            }
        }

        private void LoadModules()
        {
            this.Modules = new List<ScaffoldModule>();

            string sourceDirectory = Path.GetFullPath(
                Path.Combine(
                    this.hostEnvironment.ContentRootPath,
                    $@"..{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}"));

            var scaffoldModulesTypes = this.clientBuilderOptions.ModulesTypes;

            foreach (var scaffoldModulesType in scaffoldModulesTypes)
            {
                ScaffoldModule moduleInstance = this.serviceProvider.GetService(scaffoldModulesType) as ScaffoldModule;
                if (moduleInstance != null)
                {
                    moduleInstance.ValidateModule();
                    moduleInstance.SetSourceDirectory(sourceDirectory);
                    moduleInstance.LoadOptions(this.clientBuilderOptions);
                    moduleInstance.DefineFiles();
                    moduleInstance.DefineFolders();
                    this.Modules.Add(moduleInstance);
                }
            }
        }
    }
}
