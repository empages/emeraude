using Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.DataTransferObjects.Templates;
using Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.Admin.ClientBuilder.Services;
using Definux.Emeraude.Admin.ClientBuilder.Shared;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.DataTransferObjects
{
    public class XamarinDataTransferObjectsModule : ScaffoldModule
    {
        public XamarinDataTransferObjectsModule()
            : base("Xamarin Data Transfer Objects", InstanceType.MobileModule, true)
        {

        }

        public override void DefineFiles()
        {
            string relativePath = Path.Combine(Options.MobileAppPath, XamarinAppFolders.DataTransferObjects);
            var endpointService = (IEndpointService)ServiceProvider.GetService(typeof(IEndpointService));
            var classes = endpointService.GetAllEndpointsClasses();

            AddFile(new ModuleFile
            {
                Name = $"EmeraudeDtoEnums.cs",
                RelativePath = relativePath,
                TemplateType = typeof(EnumsTemplate),
                RenderFunction = RenderEnums
            });

            foreach (var classItem in classes)
            {
                AddFile(new ModuleFile
                {
                    Name = $"{classItem.Name}Bindable.cs",
                    RelativePath = relativePath,
                    TemplateType = typeof(DtoTemplate),
                    ReferenceId = classItem.FullName,
                    RenderFunction = RenderDto
                });
            }
        }

        public override void DefineFolders()
        {
            //
        }

        private string RenderDto(ModuleFile file)
        {
            var endpointService = GetService<IEndpointService>();
            var classes = endpointService.GetAllEndpointsClasses();

            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "Class", classes.FirstOrDefault(x => x.FullName == file.ReferenceId) }
            });
        }

        private string RenderEnums(ModuleFile file)
        {
            var endpointService = GetService<IEndpointService>();
            var classes = endpointService.GetAllEndpointsClasses();
            var enums = DescriptionExtractor.ExtractUniqueEnumsFromClasses(classes);

            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "Enums", enums },
            });
        }
    }
}
