using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Definux.Emeraude.Localization.Services
{
    public class Localizer : ILocalizer
    {
        private readonly ILocalizationContext context;
        private readonly ILogger logger;
        private readonly ICurrentLanguageProvider currentLanguageProvider;

        public Localizer(ILocalizationContext context, ILogger logger, ICurrentLanguageProvider currentLanguageProvider)
        {
            this.context = context;
            this.logger = logger;
            this.currentLanguageProvider = currentLanguageProvider;
        }

        public string TranslateKey(string key)
        {
            try
            {
                string languageCode = this.currentLanguageProvider.GetCurrentLanguage()?.Code;
                string value = this.context
                    .Values
                    .AsQueryable()
                    .Where(x => x.Language.Code.ToLower() == languageCode.ToLower() && x.TranslationKey.Key == key)
                    .FirstOrDefault()?.Value;

                return string.IsNullOrEmpty(value) ? key : value;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex);
                return key;
            }
        }

        public string TranslateKey(string key, string languageCode)
        {
            try
            {
                string value = this.context
                    .Values
                    .AsQueryable()
                    .Where(x => x.Language.Code.ToLower() == languageCode.ToLower() && x.TranslationKey.Key == key)
                    .FirstOrDefault()?.Value;

                return string.IsNullOrEmpty(value) ? key : value;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex);
                return key;
            }
        }

        public async Task<string> TranslateKeyAsync(string key)
        {
            try
            {
                string languageCode = (await this.currentLanguageProvider.GetCurrentLanguageAsync())?.Code;
                string value = (await this.context
                    .Values
                    .AsQueryable()
                    .Where(x => x.Language.Code.ToLower() == languageCode.ToLower() && x.TranslationKey.Key == key)
                    .FirstOrDefaultAsync())?.Value;

                return string.IsNullOrEmpty(value) ? key : value;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return key;
            }
        }

        public async Task<string> TranslateKeyAsync(string key, string languageCode)
        {
            try
            {
                string value = (await this.context
                    .Values
                    .AsQueryable()
                    .Where(x => x.Language.Code.ToLower() == languageCode.ToLower() && x.TranslationKey.Key == key)
                    .FirstOrDefaultAsync())?.Value;

                return string.IsNullOrEmpty(value) ? key : value;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return key;
            }
        }
    }
}
