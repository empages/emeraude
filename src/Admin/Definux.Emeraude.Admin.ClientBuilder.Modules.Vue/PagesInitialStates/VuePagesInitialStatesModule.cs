using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.PagesInitialStates.Templates;
using Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.Admin.ClientBuilder.Services;
using Definux.Emeraude.Admin.ClientBuilder.Shared;
using Definux.Utilities.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.PagesInitialStates
{
    public class VuePagesInitialStatesModule : ScaffoldModule
    {
        public VuePagesInitialStatesModule()
            : base("Vue Pages Initial States", InstanceType.WebModule, true)
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
                string currentPageFolderName = page.Name.SplitWordsByCapitalLetters().Replace(" ", "-").ToLower();
                AddFile(new ModuleFile
                {
                    Name = "initialState.js",
                    RelativePath = Path.Combine(relativePath, currentPageFolderName),
                    TemplateType = typeof(InitialStateTemplate),
                    ReferenceId = page.Id,
                    RenderFunction = RenderInitialState
                });
            }
        }

        public override void DefineFolders()
        {
            //
        }

        private string RenderInitialState(ModuleFile file)
        {
            var pageService = GetService<IPageService>();
            var pages = pageService.GetAllPages();
            var currentPage = pages.FirstOrDefault(x => x.Id == file.ReferenceId);

            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "Properties",  currentPage.InitialStateModelClass.Properties }
            });
        }
    }
}
