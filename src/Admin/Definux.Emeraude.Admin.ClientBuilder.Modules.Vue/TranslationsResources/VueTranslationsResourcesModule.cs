using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.TranslationsResources.Templates;
using Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.Admin.ClientBuilder.Shared;
using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Emeraude.Domain.Localization;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
                    RelativePath = relativePath,
                    ReferenceId = language.Id.ToString(),
                    RenderFunction = RenderLanguageJson
                });
            }

            AddFile(new ModuleFile
            {
                Name = $"i18n.js",
                RelativePath = relativePath,
                ReferenceId = "config",
                RenderFunction = RenderConfigFile,
                TemplateType = typeof(I18nConfigTemplate)
            });
        }

        public override void DefineFolders()
        {
            AddFolder(new ModuleFolder
            {
                Name = VueAppFolders.Locales,
                RelativePath = Options.WebAppPath
            });
        }

        private string RenderLanguageJson(ModuleFile file)
        {
            var languageStore = GetService<ILanguageStore>();
            int languageId = int.Parse(file.ReferenceId);
            var translationsDictionary = languageStore.GetLanguageTranslationDictionary(languageId);

            return JsonConvert.SerializeObject(translationsDictionary);
        }

        private string RenderConfigFile(ModuleFile file)
        {
            var localizationContext = GetService<ILocalizationContext>();
            var languages = localizationContext.Languages.ToList();
            Language defaultLanguage = languages.FirstOrDefault(x => x.IsDefault);

            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "Languages", languages },
                { "DefaultLanguage", defaultLanguage }
            });
        }
    }
}
