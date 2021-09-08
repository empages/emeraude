using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Definux.Emeraude.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IApplicationBuilder"/>.
    /// </summary>
    public static class ApplicationBuilderExtensions
    {
        /// <summary>
        /// Configure errors with status code page for the predefined action.
        /// </summary>
        /// <param name="app"></param>
        public static void UseEmeraudeStatusCodePage(this IApplicationBuilder app)
        {
            app.UseStatusCodePagesWithReExecute("/error/{0}");
        }

        /// <summary>
        /// Configure exception handler to be redirected to the Emeraude error page.
        /// </summary>
        /// <param name="app"></param>
        public static void UseEmeraudeExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler("/error/400");
        }

        /// <summary>
        /// Get registered option instance or new instance.
        /// </summary>
        /// <param name="app"></param>
        /// <typeparam name="TOptions">Options type registered by the general ASP.NET options API.</typeparam>
        /// <returns></returns>
        public static TOptions GetOptions<TOptions>(this IApplicationBuilder app)
            where TOptions : class, new()
        {
            var optionsAccessor = app.ApplicationServices.GetService<IOptions<TOptions>>();
            return optionsAccessor?.Value ?? new TOptions();
        }
    }
}
