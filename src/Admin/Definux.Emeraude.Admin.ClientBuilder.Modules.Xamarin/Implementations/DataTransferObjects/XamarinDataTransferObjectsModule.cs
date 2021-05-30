using System.Collections.Generic;
using System.IO;
using System.Linq;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Abstractions;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates;
using Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.Admin.ClientBuilder.Services;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects
{
    /// <summary>
    /// Xamarin data transfer objects module for generation of all endpoints related objects needed for the consuming of the web API in Xamarin application.
    /// </summary>
    public class XamarinDataTransferObjectsModule : XamarinScaffoldModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XamarinDataTransferObjectsModule"/> class.
        /// </summary>
        public XamarinDataTransferObjectsModule()
            : base("Xamarin Data Transfer Objects", true)
        {
        }

        /// <inheritdoc/>
        public override void DefineFiles()
        {
            string relativePath = Path.Combine(this.Options.MobileAppPath, XamarinAppFolders.DataTransferObjects);
            var endpointService = this.GetService<IEndpointService>();
            var classes = endpointService.GetAllEndpointsClasses();

            this.AddFile(new ModuleFile
            {
                Name = $"EmeraudeDtoEnums.cs",
                RelativePath = relativePath,
                TemplateType = typeof(EnumsTemplate),
                RenderFunction = this.RenderEnums,
            });

            foreach (var classItem in classes)
            {
                this.AddFile(new ModuleFile
                {
                    Name = $"{classItem.Name}Bindable.cs",
                    RelativePath = relativePath,
                    TemplateType = typeof(DtoTemplate),
                    ReferenceId = classItem.FullName,
                    RenderFunction = this.RenderDto,
                });
            }
        }

        /// <inheritdoc/>
        public override void DefineFolders()
        {
            this.AddFolder(new ModuleFolder
            {
                Name = XamarinAppFolders.DataTransferObjects,
                RelativePath = this.Options.MobileAppPath,
            });
        }

        private string RenderDto(ModuleFile file)
        {
            var endpointService = this.GetService<IEndpointService>();
            var classes = endpointService.GetAllEndpointsClasses();

            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "Class", classes.FirstOrDefault(x => x.FullName == file.ReferenceId) },
            });
        }

        private string RenderEnums(ModuleFile file)
        {
            var endpointService = this.GetService<IEndpointService>();
            var classes = endpointService.GetAllEndpointsClasses();
            var enums = DescriptionExtractor.ExtractUniqueEnumsFromClasses(classes);

            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "Enums", enums },
            });
        }
    }
}
