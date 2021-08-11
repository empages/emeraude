using System.Collections.Generic;
using System.IO;
using System.Linq;
using Definux.Emeraude.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.ClientBuilder.Services;
using Definux.Utilities.Functions;
using EmDoggo.ClientBuilder.Modules.WebApi.Templates;
using EmDoggo.ClientBuilder.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace EmDoggo.ClientBuilder.Modules.WebApi
{
    /// <summary>
    /// Vue web API module for generation of API endpoints as help functions and all supported classes and enums in Vue application.
    /// </summary>
    public class VueWebApiModule : VueScaffoldModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VueWebApiModule"/> class.
        /// </summary>
        public VueWebApiModule()
            : base("Vue Web API", true)
        {
        }

        /// <inheritdoc/>
        public override void DefineFiles()
        {
            string relativePath = Path.Combine(this.Options.GetVueClientAppPath(), VueAppFolders.Api);

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

            this.AddFile(new ModuleFile
            {
                Name = "types.js",
                RelativePath = relativePath,
                TemplateType = typeof(TypesTemplate),
                RenderFunction = this.RenderTypes,
            });
        }

        /// <inheritdoc/>
        public override void DefineFolders()
        {
            this.AddFolder(new ModuleFolder
            {
                Name = VueAppFolders.Api,
                RelativePath = this.Options.GetVueClientAppPath()
            });
        }

        private string RenderTypes(ModuleFile file)
        {
            var endpointService = this.GetService<IEndpointService>();
            var classes = endpointService.GetAllEndpointsClasses();

            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "Classes", classes },
            });
        }

        private string RenderEndpoints(ModuleFile file)
        {
            var endpointService = this.GetService<IEndpointService>();
            var endpoints = endpointService.GetAllEndpoints();

            return file.RenderTemplate(new Dictionary<string, object>
            {
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
