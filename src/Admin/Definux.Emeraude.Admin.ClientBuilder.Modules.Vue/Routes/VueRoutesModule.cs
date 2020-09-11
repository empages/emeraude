using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Routes.Templates;
using Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.Admin.ClientBuilder.Services;
using Definux.Emeraude.Admin.ClientBuilder.Shared;
using Definux.Emeraude.Application.Common.Interfaces.Localization;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Routes
{
    public class VueRoutesModule : ScaffoldModule
    {
        public VueRoutesModule() 
            : base("Vue Routes", InstanceType.WebModule, true) 
        {

        }

        public override void DefineFiles()
        {
            string relativePath = Path.Combine(Options.WebAppPath, VueAppFolders.Router);

            AddFile(new ModuleFile
            {
                Name = "routes.js",
                RelativePath = relativePath,
                TemplateType = typeof(RoutesTemplate),
                RenderFunction = RenderRouterList
            });
        }

        public override void DefineFolders()
        {
            AddFolder(new ModuleFolder
            {
                Name = VueAppFolders.Router,
                RelativePath = Options.WebAppPath
            });
        }

        private string RenderRouterList(ModuleFile file)
        {
            var pageService = GetService<IPageService>();
            var languageStore = GetService<ILanguageStore>();
            var pages = pageService.GetAllPages();
            var languages = languageStore.GetLanguages();
            var languageRouteRegex = string.Join('|', languages.Where(x => !x.IsDefault).Select(x => x.Code.ToLower()));

            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "Pages", pages },
                { "LanguageRouteRegex", languageRouteRegex },
                { "SingleLanguage", languages.Count() < 2 }
            });
        }
    }
}
