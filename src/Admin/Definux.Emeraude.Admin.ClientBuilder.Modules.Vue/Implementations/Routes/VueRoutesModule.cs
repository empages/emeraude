using System.Collections.Generic;
using System.IO;
using System.Linq;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Abstractions;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.Templates;
using Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.Admin.ClientBuilder.Services;
using Definux.Emeraude.Application.Common.Interfaces.Localization;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes
{
    /// <summary>
    /// Vue routes module for generation of all pages routes for router configuration in Vue application.
    /// </summary>
    public class VueRoutesModule : VueScaffoldModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VueRoutesModule"/> class.
        /// </summary>
        public VueRoutesModule()
            : base("Vue Routes", true)
        {
        }

        /// <inheritdoc/>
        public override void DefineFiles()
        {
            string relativePath = Path.Combine(this.Options.WebAppPath, VueAppFolders.Router);

            this.AddFile(new ModuleFile
            {
                Name = "routes.js",
                RelativePath = relativePath,
                TemplateType = typeof(RoutesTemplate),
                RenderFunction = this.RenderRouterList,
            });
        }

        /// <inheritdoc/>
        public override void DefineFolders()
        {
            this.AddFolder(new ModuleFolder
            {
                Name = VueAppFolders.Router,
                RelativePath = this.Options.WebAppPath,
            });
        }

        private string RenderRouterList(ModuleFile file)
        {
            var pageService = this.GetService<IPageService>();
            var languageStore = this.GetService<ILanguageStore>();
            var pages = pageService.GetAllPages();
            var languages = languageStore.GetLanguages();
            var languageRouteRegex = string.Join('|', languages.Where(x => !x.IsDefault).Select(x => x.Code.ToLower()));

            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "Pages", pages },
                { "LanguageRouteRegex", languageRouteRegex },
                { "SingleLanguage", languages.Count() < 2 },
            });
        }
    }
}
