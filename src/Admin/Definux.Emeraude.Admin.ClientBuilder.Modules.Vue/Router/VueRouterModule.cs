using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Router.Templates;
using Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.Admin.ClientBuilder.Services;
using Definux.Emeraude.Admin.ClientBuilder.Shared;
using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Emeraude.Locales;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Router
{
    public class VueRouterModule : ScaffoldModule
    {
        public VueRouterModule() 
            : base("Vue Router", InstanceType.WebModule, true) 
        {

        }

        public override void DefineFiles()
        {
            string relativePath = Path.Combine(Options.WebAppPath, VueAppFolders.Router);

            AddFile(new ModuleFile
            {
                Name = "index.js",
                RelativePath = relativePath,
                TemplateType = typeof(IndexTemplate),
                RenderFunction = RenderRouterIndex
            });

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
            //
        }

        private string RenderRouterIndex(ModuleFile file)
        {
            return file.RenderTemplate();
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
