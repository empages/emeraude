using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Emeraude.Domain.Localization;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Definux.Emeraude.Localization.Services
{
    public class LanguageStore : ILanguageStore
    {
        private readonly ILocalizationContext context;
        private readonly ILogger logger;

        public LanguageStore(ILocalizationContext context, ILogger logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public string[] GetAllLanguageCodes()
        {
            try
            {
                var languages = this.context.Languages.ToList();
                string[] languageCodes = languages.Select(x => x.Code).ToArray();

                return languageCodes;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex);
                return null;
            }
        }

        public async Task<string[]> GetAllLanguageCodesAsync()
        {
            try
            {
                var languages = await this.context.Languages.AsQueryable().ToListAsync();
                string[] languageCodes = languages.Select(x => x.Code).ToArray();

                return languageCodes;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return null;
            }
        }

        public Language GetDefaultLanguage()
        {
            try
            {
                return this.context.Languages.FirstOrDefault(x => x.IsDefault);
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex);
                return default;
            }
        }

        public async Task<Language> GetDefaultLanguageAsync()
        {
            try
            {
                return await this.context.Languages.AsQueryable().FirstOrDefaultAsync(x => x.IsDefault); ;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return default;
            }
        }

        public List<string> GetTranslationsKeys()
        {
            try
            {
                return this.context
                    .Keys
                    .AsQueryable()
                    .Select(x => x.Key)
                    .ToList();
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex);
                return null;
            }
        }

        public IEnumerable<Language> GetLanguages()
        {
            try
            {
                return this.context.Languages.AsQueryable().ToList();
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex);
                return null;
            }
        }

        public async Task<IEnumerable<Language>> GetLanguagesAsync()
        {
            try
            {
                return await this.context.Languages.AsQueryable().ToListAsync();
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return null;
            }
        }

        public Dictionary<string, string> GetLanguageTranslationDictionary(int languageId)
        {
            try
            {
                var translations = this.context
                    .Values
                    .AsQueryable()
                    .Where(x => x.LanguageId == languageId)
                    .Include(x => x.TranslationKey)
                    .ToDictionary(k => k.TranslationKey.Key, v => v.Value);

                return translations;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex);
                return null;
            }
        }
    }
}
