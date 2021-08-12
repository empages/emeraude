using System;
using Definux.Emeraude.Admin.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using WebMarkupMin.AspNetCore3;

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
    }
}
