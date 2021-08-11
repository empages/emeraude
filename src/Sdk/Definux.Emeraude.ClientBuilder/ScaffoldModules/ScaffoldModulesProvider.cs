using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Definux.Emeraude.ClientBuilder.Options;
using Definux.Emeraude.ClientBuilder.Shared;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Options;

namespace Definux.Emeraude.ClientBuilder.ScaffoldModules
{
    /// <inheritdoc cref=" IScaffoldModulesProvider"/>
    public class ScaffoldModulesProvider : IScaffoldModulesProvider
    {
        private readonly IWebHostEnvironment hostEnvironment;
        private readonly ClientBuilderOptions clientBuilderOptions;
        private readonly IServiceProvider serviceProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="ScaffoldModulesProvider"/> class.
        /// </summary>
        /// <param name="hostEnvironment"></param>
        /// <param name="options"></param>
        /// <param name="serviceProvider"></param>
        public ScaffoldModulesProvider(
            IWebHostEnvironment hostEnvironment,
            IOptions<ClientBuilderOptions> options,
            IServiceProvider serviceProvider)
        {
            this.hostEnvironment = hostEnvironment;
            this.clientBuilderOptions = options.Value;
            this.serviceProvider = serviceProvider;

            this.LoadModules();
            this.SyncModules();
        }

        /// <inheritdoc/>
        public List<ScaffoldModule> Modules { get; private set; }

        /// <inheritdoc/>
        public List<ScaffoldModule> WebModules
        {
            get
            {
                return this.Modules?
                    .Where(x => x.Type == InstanceType.WebModule)
                    .OrderBy(x => x.Order)
                    .ToList();
            }
        }

        /// <inheritdoc/>
        public List<ScaffoldModule> MobileModules
        {
            get
            {
                return this.Modules?
                    .Where(x => x.Type == InstanceType.MobileModule)
                    .OrderBy(x => x.Order)
                    .ToList();
            }
        }

        /// <inheritdoc/>
        public List<ScaffoldModule> GetModulesByParentModuleId(string parentModuleId)
        {
            return this.Modules?
                .Where(x => x.ParentModuleId.ToLower() == parentModuleId)
                .OrderBy(x => x.Order)
                .ToList();
        }

        /// <inheritdoc/>
        public bool GenerateModule(string moduleId, out string errorMessage)
        {
            var module = this.GetModule(moduleId);
            return module.Generate(out errorMessage);
        }

        private ScaffoldModule GetModule(string moduleId)
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
                ScaffoldModule moduleInstance = Activator.CreateInstance(scaffoldModulesType) as ScaffoldModule;
                moduleInstance.SetSourceDirectory(sourceDirectory);
                moduleInstance.SetServiceProvider(this.serviceProvider);
                moduleInstance.LoadOptions(this.clientBuilderOptions);
                moduleInstance.DefineFiles();
                moduleInstance.DefineFolders();
                this.Modules.Add(moduleInstance);
            }
        }
    }
}
