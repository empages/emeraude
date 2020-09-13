using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Abstractions;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.ServiceAgents.Templates;
using Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.Admin.ClientBuilder.Services;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.ServiceAgents
{
    public class VueServiceAgentsModule : VueScaffoldModule
    {
        public VueServiceAgentsModule()
            : base("Vue Service Agents", true)
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
