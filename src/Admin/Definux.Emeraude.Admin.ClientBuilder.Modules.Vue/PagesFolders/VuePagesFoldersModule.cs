using Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.Admin.ClientBuilder.Services;
using Definux.Emeraude.Admin.ClientBuilder.Shared;
using Definux.Utilities.Extensions;
using System;
using System.IO;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.PagesFolders
{
    public class VuePagesFoldersModule : ScaffoldModule
    {
        public VuePagesFoldersModule()
            : base("Vue Pages Folders", InstanceType.WebModule, true)
        {
            Order = 10;
        }

        public override void DefineFiles()
        {
            //
        }

        public override void DefineFolders()
        {
            string relativePath = Path.Combine(Options.WebAppPath, VueAppFolders.Pages);
            var pageService = GetService<IPageService>();
            var pages = pageService.GetAllPages();

            foreach (var page in pages)
            {
                AddFolder(new ModuleFolder
                {
                    Name = page.Name.SplitWordsByCapitalLetters().Replace(" ", "-").ToLower(),
                    RelativePath = relativePath,
                });
            }
        }
    }
}
