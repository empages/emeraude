using System.Collections.Generic;
using System.IO;
using System.Linq;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Abstractions;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates;
using Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.Admin.ClientBuilder.Services;
using Definux.Utilities.Extensions;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents
{
    /// <summary>
    /// Xamarin service agents module for generation of all endpoints service agents for the consuming of the web API in Xamarin application.
    /// </summary>
    public class XamarinServiceAgentsModule : XamarinScaffoldModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XamarinServiceAgentsModule"/> class.
        /// </summary>
        public XamarinServiceAgentsModule()
            : base("Xamarin Service Agents", true)
        {
            this.Order = 10;
        }

        /// <inheritdoc/>
        public override void DefineFiles()
        {
            string relativePath = Path.Combine(this.Options.MobileAppPath, XamarinAppFolders.ServiceAgents);
            var endpointService = this.GetService<IEndpointService>();
            var endpoints = endpointService.GetAllEndpoints();
            var endpointsControllers = endpoints.Select(x => x.ControllerName).Distinct().ToList();

            foreach (var endpointsController in endpointsControllers)
            {
                this.AddFile(new ModuleFile
                {
                    Name = $"{endpointsController.Replace("ApiController", string.Empty).ToFirstUpper()}ServiceAgent.cs",
                    RelativePath = relativePath,
                    TemplateType = typeof(ServiceAgentClassTemplate),
                    ReferenceId = endpointsController,
                    RenderFunction = this.RenderServiceAgentClass,
                });

                this.AddFile(new ModuleFile
                {
                    Name = $"I{endpointsController.Replace("ApiController", string.Empty).ToFirstUpper()}ServiceAgent.cs",
                    RelativePath = relativePath,
                    TemplateType = typeof(ServiceAgentInterfaceTemplate),
                    ReferenceId = endpointsController,
                    RenderFunction = this.RenderServiceAgentInterface,
                });
            }

            this.AddFile(new ModuleFile
            {
                Name = "ContainerRegistryExtensions.cs",
                RelativePath = relativePath,
                TemplateType = typeof(ServiceAgentsRegistratorTemplate),
                RenderFunction = this.RenderContainerRegistryExtensions,
            });
        }

        /// <inheritdoc/>
        public override void DefineFolders()
        {
            this.AddFolder(new ModuleFolder
            {
                Name = XamarinAppFolders.ServiceAgents,
                RelativePath = this.Options.MobileAppPath,
            });
        }

        private string RenderContainerRegistryExtensions(ModuleFile file)
        {
            var endpointService = this.GetService<IEndpointService>();
            var endpoints = endpointService.GetAllEndpoints();
            var endpointsControllers = endpoints.Select(x => x.ControllerName).Distinct().ToList();

            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "EndpointsControllers", endpointsControllers },
            });
        }

        private string RenderServiceAgentClass(ModuleFile file)
        {
            var endpointService = this.GetService<IEndpointService>();
            var endpoints = endpointService.GetAllEndpoints();

            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "EndpointsController", file.ReferenceId.Replace("ApiController", string.Empty).ToFirstUpper() },
                { "Endpoints", endpoints.Where(x => x.ControllerName == file.ReferenceId).ToList() },
            });
        }

        private string RenderServiceAgentInterface(ModuleFile file)
        {
            var endpointService = this.GetService<IEndpointService>();
            var endpoints = endpointService.GetAllEndpoints();

            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "EndpointsController", file.ReferenceId.Replace("ApiController", string.Empty).ToFirstUpper() },
                { "Endpoints", endpoints.Where(x => x.ControllerName == file.ReferenceId).ToList() },
            });
        }
    }
}
