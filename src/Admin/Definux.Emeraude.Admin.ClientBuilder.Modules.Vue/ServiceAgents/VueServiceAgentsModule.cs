using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.ServiceAgents.Templates;
using Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.Admin.ClientBuilder.Services;
using Definux.Emeraude.Admin.ClientBuilder.Shared;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.ServiceAgents
{
    public class VueServiceAgentsModule : ScaffoldModule
    {
        public VueServiceAgentsModule()
            : base("Vue Service Agents", InstanceType.WebModule, true)
        {

        }

        public override void DefineFiles()
        {
            string relativePath = Path.Combine(Options.WebAppPath, VueAppFolders.Api);

            AddFile(new ModuleFile
            {
                Name = "endpoints.js",
                RelativePath = relativePath,
                TemplateType = typeof(EndpointsTemplate),
                RenderFunction = RenderEndpoints
            });

            AddFile(new ModuleFile
            {
                Name = "enums.js",
                RelativePath = relativePath,
                TemplateType = typeof(EnumsTemplate),
                RenderFunction = RenderEnums
            });
        }

        public override void DefineFolders()
        {
            //
        }

        private string RenderEndpoints(ModuleFile file)
        {
            var endpointService = GetService<IEndpointService>();
            var endpoints = endpointService.GetAllEndpoints();
            var classes = endpointService.GetAllEndpointsClasses();

            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "Classes", classes },
                { "EndpointsControllers", endpoints.Select(x => x.ControllerName).Distinct().ToList() },
                { "Endpoints", endpoints }
            });
        }

        private string RenderEnums(ModuleFile file)
        {
            var endpointService = GetService<IEndpointService>();
            var classes = endpointService.GetAllEndpointsClasses();
            var enums = DescriptionExtractor.ExtractUniqueEnumsFromClasses(classes);

            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "Enums", enums }
            });
        }
    }
}
