using System;
using System.Collections.Generic;
using System.IO;
using System.Resources;
using Definux.Emeraude.Application.Files;
using Definux.Emeraude.Application.Localization;
using Definux.Emeraude.Resources;
using Microsoft.AspNetCore.Hosting;

namespace Definux.Emeraude.Localization.Services
{
    /// <inheritdoc cref="ILanguagesResourceManager"/>
    public class LanguagesResourceManager : ILanguagesResourceManager
    {
        private const string ResourceNameFormat = "Translations.{0}.resources";

        private readonly ILanguageStore languageStore;
        private readonly IRootsService rootsService;
        private readonly ISystemFilesService systemFilesService;

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagesResourceManager"/> class.
        /// </summary>
        /// <param name="languageStore"></param>
        /// <param name="rootsService"></param>
        /// <param name="systemFilesService"></param>
        public LanguagesResourceManager(
            ILanguageStore languageStore,
            IRootsService rootsService,
            ISystemFilesService systemFilesService)
        {
            this.languageStore = languageStore;
            this.rootsService = rootsService;
            this.systemFilesService = systemFilesService;
        }

        /// <inheritdoc />
        public void BuildResources()
        {
            var languages = this.languageStore.GetLanguages();
            this.systemFilesService.CreateFolder(Folders.ResourcesFolderName, this.rootsService.PrivateRootDirectory);

            foreach (var language in languages)
            {
                var translations = this.languageStore.GetLanguageTranslationDictionary(language.Id);
                string languageTranslationsResourcesPath = this.rootsService.GetPathFromPrivateRoot(Folders.ResourcesFolderName, string.Format(ResourceNameFormat, language.Code));
                using (ResourceWriter resourceWriter = new ResourceWriter(languageTranslationsResourcesPath))
                {
                    foreach (var (key, value) in translations)
                    {
                        resourceWriter.AddResource(key.Trim(), value?.Trim() ?? string.Empty);
                    }
                }
            }
        }

        /// <inheritdoc />
        public string GetTranslationResource(string translationKey, string languageCode)
        {
            try
            {
                using var resourceReader = new ResourceReader(this.rootsService.GetPathFromPrivateRoot(Folders.ResourcesFolderName, string.Format(ResourceNameFormat, languageCode)));
                resourceReader.GetResourceData(translationKey, out _, out var translationBytes);
                using var memoryStream = new MemoryStream(translationBytes);
                using var binaryReader = new BinaryReader(memoryStream);
                return binaryReader.ReadString();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}