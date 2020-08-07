using Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.ServiceAgents.Templates;
using Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.Admin.ClientBuilder.Services;
using Definux.Emeraude.Admin.ClientBuilder.Shared;
using Definux.Utilities.Extensions;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.ServiceAgents
{
    public class XamarinServiceAgentsModule : ScaffoldModule
    {
        public XamarinServiceAgentsModule()
            : base("Xamarin Service Agents", InstanceType.MobileModule, true)
        {
            Order = 10;
        }

        public override void DefineFiles()
        {
            string relativePath = Path.Combine(Options.MobileAppPath, XamarinAppFolders.ServiceAgents);
            var endpointService = GetService<IEndpointService>();
            var endpoints = endpointService.GetAllEndpoints();
            var endpointsControllers = endpoints.Select(x => x.ControllerName).Distinct().ToList();

            foreach (var endpointsController in endpointsControllers)
            {
                AddFile(new ModuleFile
                {
                    Name = $"{endpointsController.Replace("ApiController", string.Empty).ToFirstUpper()}ServiceAgent.cs",
                    RelativePath = relativePath,
                    TemplateType = typeof(ServiceAgentClassTemplate),
                    ReferenceId = endpointsController,
                    RenderFunction = RenderServiceAgentClass
                });

                AddFile(new ModuleFile
                {
                    Name = $"I{endpointsController.Replace("ApiController", string.Empty).ToFirstUpper()}ServiceAgent.cs",
                    RelativePath = relativePath,
                    TemplateType = typeof(ServiceAgentInterfaceTemplate),
                    ReferenceId = endpointsController,
                    RenderFunction = RenderServiceAgentInterface
                });
            }

            AddFile(new ModuleFile
            {
                Name = "ContainerRegistryExtensions.cs",
                RelativePath = relativePath,
                TemplateType = typeof(ServiceAgentsRegistratorTemplate),
                RenderFunction = RenderContainerRegistryExtensions
            });
        }

        public override void DefineFolders()
        {
            //
        }

        private string RenderContainerRegistryExtensions(ModuleFile file)
        {
            var endpointService = GetService<IEndpointService>();
            var endpoints = endpointService.GetAllEndpoints();
            var endpointsControllers = endpoints.Select(x => x.ControllerName).Distinct().ToList();


            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "EndpointsControllers", endpointsControllers },
            });
        }

        private string RenderServiceAgentClass(ModuleFile file)
        {
            var endpointService = GetService<IEndpointService>();
            var endpoints = endpointService.GetAllEndpoints();

            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "EndpointsController", file.ReferenceId.Replace("ApiController", string.Empty).ToFirstUpper() },
                { "Endpoints", endpoints.Where(x => x.ControllerName == file.ReferenceId).ToList() }
            });
        }

        private string RenderServiceAgentInterface(ModuleFile file)
        {
            var endpointService = GetService<IEndpointService>();
            var endpoints = endpointService.GetAllEndpoints();

            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "EndpointsController", file.ReferenceId.Replace("ApiController", string.Empty).ToFirstUpper() },
                { "Endpoints", endpoints.Where(x => x.ControllerName == file.ReferenceId).ToList() }
            });
        }
    }
}
