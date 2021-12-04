using System;
using System.Linq;
using System.Threading.Tasks;
using Emeraude.Infrastructure.Localization.Extensions;
using Emeraude.Infrastructure.Localization.Persistence;
using Emeraude.Infrastructure.Localization.Persistence.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Emeraude.Infrastructure.Localization.Services;

/// <inheritdoc cref="ICurrentLanguageProvider"/>
public class CurrentLanguageProvider : ICurrentLanguageProvider
{
    private readonly ILocalizationContext context;
    private readonly IHttpContextAccessor httpAccessor;
    private readonly string languageCode;

    /// <summary>
    /// Initializes a new instance of the <see cref="CurrentLanguageProvider"/> class.
    /// </summary>
    /// <param name="context"></param>
    /// <param name="httpAccessor"></param>
    public CurrentLanguageProvider(
        ILocalizationContext context,
        IHttpContextAccessor httpAccessor)
    {
        this.context = context;
        this.httpAccessor = httpAccessor;
        this.languageCode = this.httpAccessor.HttpContext?.GetLanguageCode();
    }

    /// <inheritdoc/>
    public Language GetCurrentLanguage()
    {
        try
        {
            var language = this.context
                .Languages
                .FirstOrDefault(x => x.Code == this.languageCode) ?? this.context
                .Languages
                .FirstOrDefault(x => x.IsDefault);

            return language;
        }
        catch (Exception)
        {
            return null;
        }
    }

    /// <inheritdoc/>
    public async Task<Language> GetCurrentLanguageAsync()
    {
        try
        {
            var language = await this.context
                .Languages
                .FirstOrDefaultAsync(x => x.Code == this.languageCode) ?? await this.context
                .Languages
                .FirstOrDefaultAsync(x => x.IsDefault);

            return language;
        }
        catch (Exception)
        {
            return null;
        }
    }
}