using System.Collections.Generic;
using System.IO;
using System.Linq;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Abstractions;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.ServiceAgents.Templates;
using Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.Admin.ClientBuilder.Services;
using Definux.Utilities.Functions;
using Definux.Utilities.Objects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.ServiceAgents
{
    /// <summary>
    /// Vue service agents module for generation of API endpoints as help functions in Vue application.
    /// </summary>
    public class VueServiceAgentsModule : VueScaffoldModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VueServiceAgentsModule"/> class.
        /// </summary>
        public VueServiceAgentsModule()
            : base("Vue Service Agents", true)
        {
        }

        /// <inheritdoc/>
        public override void DefineFiles()
        {
            string relativePath = Path.Combine(this.Options.WebAppPath, VueAppFolders.Api);

            this.AddFile(new ModuleFile
            {
                Name = "endpoints.js",
                RelativePath = relativePath,
                TemplateType = typeof(EndpointsTemplate),
                RenderFunction = this.RenderEndpoints,
            });

            this.AddFile(new ModuleFile
            {
                Name = "enums.js",
                RelativePath = relativePath,
                TemplateType = typeof(EnumsTemplate),
                RenderFunction = this.RenderEnums,
            });
        }

        /// <inheritdoc/>
        public override void DefineFolders()
        {
        }

        private string RenderEndpoints(ModuleFile file)
        {
            var endpointService = this.GetService<IEndpointService>();
            var endpoints = endpointService.GetAllEndpoints();
            var classes = endpointService.GetAllEndpointsClasses();

            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "Classes", classes },
                { "EndpointsControllers", endpoints.Select(x => x.ControllerName).Distinct().ToList() },
                { "Endpoints", endpoints },
            });
        }

        private string RenderEnums(ModuleFile file)
        {
            var endpointService = this.GetService<IEndpointService>();
            var classes = endpointService.GetAllEndpointsClasses();
            var enums = DescriptionExtractor.ExtractUniqueEnumsFromClasses(classes);
            var enumValueItems = new Dictionary<string, string>();
            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy(),
            };
            foreach (var enumItem in enums)
            {
                string serializedEnums = JsonConvert.SerializeObject(
                    EnumFunctions.GetEnumValueItems(enumItem.FullName),
                    new JsonSerializerSettings
                    {
                        ContractResolver = contractResolver,
                        Formatting = Formatting.Indented,
                    });
                enumValueItems[enumItem.FullName] = JToken.Parse(serializedEnums).ToString();
            }

            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "Enums", enums },
                { "EnumsValueItems", enumValueItems },
            });
        }
    }
}
