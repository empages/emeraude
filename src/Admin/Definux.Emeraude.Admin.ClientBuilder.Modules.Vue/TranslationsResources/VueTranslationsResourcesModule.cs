using Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.Admin.ClientBuilder.Shared;
using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Emeraude.Locales;
using Newtonsoft.Json;
using System.IO;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.TranslationsResources
{
    public class VueTranslationsResourcesModule : ScaffoldModule
    {
        public VueTranslationsResourcesModule()
            : base("Vue Translations Resources", InstanceType.WebModule, true)
        {

        }

        public override void DefineFiles()
        {
            var languageStore = GetService<ILanguageStore>();
            var languages = languageStore.GetLanguages();
            string relativePath = Path.Combine(Options.WebAppPath, VueAppFolders.Locales);

            foreach (var language in languages)
            {
                AddFile(new ModuleFile
                {
                    Name = $"{language.Code.ToLower()}.json",
                    RelativePath = Path.Combine(relativePath),
                    ReferenceId = language.Id.ToString(),
                    RenderFunction = RenderLanguageJson
                });
            }
        }

        public override void DefineFolders()
        {
            //
        }

        private string RenderLanguageJson(ModuleFile file)
        {
            var languageStore = GetService<ILanguageStore>();
            int languageId = int.Parse(file.ReferenceId);
            var translationsDictionary = languageStore.GetLanguageTranslationDictionary(languageId);

            return JsonConvert.SerializeObject(translationsDictionary);
        }
    }
}
