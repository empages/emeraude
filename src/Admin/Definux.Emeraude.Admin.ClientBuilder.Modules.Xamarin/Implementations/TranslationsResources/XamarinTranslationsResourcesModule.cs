using Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Abstractions;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates;
using Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Utilities.Extensions;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources
{
    public class XamarinTranslationsResourcesModule : XamarinScaffoldModule
    {
        public XamarinTranslationsResourcesModule()
            : base("Xamarin Translations Resources", true)
        {

        }

        public override void DefineFiles()
        {
            var languageStore = GetService<ILanguageStore>();
            var languages = languageStore.GetLanguages();
            string relativePath = Path.Combine(Options.MobileAppPath, XamarinAppFolders.Translations);

            AddFile(new ModuleFile
            {
                Name = $"EmeraudeTranslationKeys.cs",
                RelativePath = Path.Combine(relativePath),
                TemplateType = typeof(TranslationsKeysTemplate),
                RenderFunction = RenderTranslationsKeys
            });

            AddFile(new ModuleFile
            {
                Name = $"Translations.resx",
                RelativePath = Path.Combine(relativePath),
                TemplateType = typeof(TranslationsTemplate),
                RenderFunction = RenderTranslationsBase
            });

            foreach (var language in languages)
            {
                AddFile(new ModuleFile
                {
                    Name = $"Translations.{language.Code.ToLower()}.resx",
                    RelativePath = Path.Combine(relativePath),
                    ReferenceId = language.Id.ToString(),
                    TemplateType = typeof(TranslationsTemplate),
                    RenderFunction = RenderTranslations
                });
            }
        }

        public override void DefineFolders()
        {
            AddFolder(new ModuleFolder
            {
                Name = XamarinAppFolders.Translations,
                RelativePath = Options.MobileAppPath
            });
        }

        private string RenderTranslationsBase(ModuleFile file)
        {
            var languageStore = GetService<ILanguageStore>();
            var defaultLanguage = languageStore.GetDefaultLanguage();
            var translationsDictionary = languageStore.GetLanguageTranslationDictionary(defaultLanguage.Id);

            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "Translations", translationsDictionary }
            });
        }

        private string RenderTranslations(ModuleFile file)
        {
            var languageStore = GetService<ILanguageStore>();
            var translationsDictionary = languageStore.GetLanguageTranslationDictionary(int.Parse(file.ReferenceId));

            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "Translations", translationsDictionary }
            });
        }

        private string RenderTranslationsKeys(ModuleFile file)
        {
            var languageStore = GetService<ILanguageStore>();
            var translationsKeys = languageStore.GetTranslationsKeys();
            var translationsKeysDictionary = translationsKeys.ToDictionary(k => MakePascalCaseKeyFromTranslationKey(k), v => v);

            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "TranslationsKeys", translationsKeysDictionary }
            });
        }

        private string MakePascalCaseKeyFromTranslationKey(string translationKey)
        {
            var keyWords = translationKey.Split('_');
            int wordsAmount = keyWords.Length;
            for (int i = 0; i < wordsAmount; i++)
            {
                keyWords[i] = keyWords[i].ToLower().ToFirstUpper();
            }

            return string.Join(string.Empty, keyWords);
        }
    }
}
