using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Emeraude.Domain.Localization;
using Definux.Emeraude.Localization.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Definux.Emeraude.Localization.Services
{
    public class CurrentLanguageProvider : ICurrentLanguageProvider
    {
        private readonly ILocalizationContext context;
        private readonly IHttpContextAccessor httpAccessor;
        private readonly string languageCode;
        public CurrentLanguageProvider(
            ILocalizationContext context,
            IHttpContextAccessor httpAccessor)
        {
            this.context = context;
            this.httpAccessor = httpAccessor;
            this.languageCode = this.httpAccessor.HttpContext?.GetLanguageCode();
        }

        public Language GetCurrentLanguage()
        {
            try
            {
                var language = this.context
                    .Languages
                    .FirstOrDefault(x => x.Code == this.languageCode);

                if (language == null)
                {
                    language = this.context
                        .Languages
                        .FirstOrDefault(x => x.IsDefault);
                }

                return language;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Language> GetCurrentLanguageAsync()
        {
            try
            {
                var language = await this.context
                    .Languages
                    .FirstOrDefaultAsync(x => x.Code == this.languageCode);

                if (language == null)
                {
                    language = await this.context
                        .Languages
                        .FirstOrDefaultAsync(x => x.IsDefault);
                }

                return language;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
