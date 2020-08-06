using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.PagesComponents.Templates;
using Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.Admin.ClientBuilder.Services;
using Definux.Emeraude.Admin.ClientBuilder.Shared;
using Definux.Utilities.Extensions;
using System.Collections.Generic;
using System.IO;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.PagesComponents
{
    public class VuePagesComponentsModule : ScaffoldModule
    {
        public VuePagesComponentsModule()
            : base("Vue Pages Components", InstanceType.WebModule, false)
        {
            Order = 20;
        }

        public override void DefineFiles()
        {
            var pageService = GetService<IPageService>();
            var pages = pageService.GetAllPages();
            string relativePath = Path.Combine(Options.WebAppPath, VueAppFolders.Pages);

            foreach (var page in pages)
            {
                string currentPageFileName = page.Name.Replace(" ", string.Empty);
                string currentPageFolderName = page.Name.SplitWordsByCapitalLetters().Replace(" ", "-").ToLower();

                AddFile(new ModuleFile
                {
                    Name = $"{currentPageFileName}.vue",
                    RelativePath = Path.Combine(relativePath, currentPageFolderName),
                    TemplateType = typeof(ComponentTemplate),
                    ReferenceId = page.Name,
                    RenderFunction = RenderPageComponent
                });
            }
        }

        public override void DefineFolders()
        {
            //
        }

        private string RenderPageComponent(ModuleFile file)
        {
            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "Page", file.ReferenceId },
            });
        }
    }
}
