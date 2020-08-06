using Definux.Emeraude.Admin.ClientBuilder.Options;
using Definux.Emeraude.Admin.ClientBuilder.Shared;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules
{
    public class ScaffoldModulesProvider : IScaffoldModulesProvider
    {
        private readonly IWebHostEnvironment hostEnvironment;
        private readonly ClientBuilderOptions clientBuilderOptions;
        private readonly IServiceProvider serviceProvider;

        public ScaffoldModulesProvider(
            IWebHostEnvironment hostEnvironment, 
            IOptions<ClientBuilderOptions> options, 
            IServiceProvider serviceProvider)
        {
            this.hostEnvironment = hostEnvironment;
            this.clientBuilderOptions = options.Value;
            this.serviceProvider = serviceProvider;

            LoadModules();
            SyncModules();
        }

        public List<ScaffoldModule> Modules { get; private set; }

        public List<ScaffoldModule> WebModules
        {
            get
            {
                return Modules?
                    .Where(x => x.Type == InstanceType.WebModule)
                    .OrderBy(x => x.Order)
                    .ToList();
            }
        }

        public List<ScaffoldModule> MobileModules
        {
            get
            {
                return Modules?
                    .Where(x => x.Type == InstanceType.MobileModule)
                    .OrderBy(x => x.Order)
                    .ToList();
            }
        }

        public ScaffoldModule GetModule(string moduleId)
        {
            return Modules.FirstOrDefault(x => x.Id == moduleId);
        }

        public bool GenerateModule(string moduleId, out string errorMessage)
        {
            var module = GetModule(moduleId);
            return module.Generate(out errorMessage);
        }

        private void LoadModules()
        {
            Modules = new List<ScaffoldModule>();

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
                Modules.Add(moduleInstance);
            }
        }

        public void SyncModules()
        {
            foreach (var module in Modules)
            {
                module.Sync();
            }
        }

        public ScaffoldModulesProcessResult GenerateAll(out string errorMessage)
        {
            try
            {
                int generatedModules = 0;
                errorMessage = null;
                StringBuilder errorMessageStringBuilder = new StringBuilder();
                string currentErrorMessage = string.Empty;
                foreach (var module in Modules)
                {
                    if (!module.Generate(out currentErrorMessage))
                    {
                        errorMessageStringBuilder.AppendLine(currentErrorMessage);
                    }
                    else
                    {
                        generatedModules++;
                    }
                }

                if (generatedModules == Modules.Count)
                {
                    return ScaffoldModulesProcessResult.Success;
                }
                else if (generatedModules > 0 && generatedModules < Modules.Count)
                {
                    errorMessage = errorMessageStringBuilder.ToString();
                    return ScaffoldModulesProcessResult.SuccessWithErrors;
                }
                else if (generatedModules == 0)
                {
                    errorMessage = errorMessageStringBuilder.ToString();
                    return ScaffoldModulesProcessResult.Unsuccess;
                }
            }
            catch (Exception) { }

            errorMessage = "An unexpected error occured!";
            return ScaffoldModulesProcessResult.Error;
        }
    }
}
