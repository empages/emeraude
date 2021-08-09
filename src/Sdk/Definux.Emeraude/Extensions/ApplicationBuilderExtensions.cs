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
        /// Registers and configures Emeraude required middlewares.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="environment"></param>
        /// <param name="forseProduction"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseEmeraude(this IApplicationBuilder app, IWebHostEnvironment environment, bool forseProduction = false)
        {
            if (environment.IsDevelopment() && !forseProduction)
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();

                app.UseEmeraudeAdminSwagger();
            }
            else
            {
                app.UseExceptionHandler("/error/400");

                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStatusCodePagesWithReExecute("/error/{0}");

            app.UseHttpsRedirection();

            app.UseEmeraudeStaticFiles();

            app.UseWebMarkupMin();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            return app;
        }

        private static IApplicationBuilder UseEmeraudeStaticFiles(this IApplicationBuilder app)
        {
            var mimeTypeProvider = new FileExtensionContentTypeProvider();
            var staticFilesOptions = (IOptions<StaticFileOptions>)app.ApplicationServices.GetService(typeof(IOptions<StaticFileOptions>));
            var staticFilesOptionsValue = staticFilesOptions.Value;
            staticFilesOptionsValue.OnPrepareResponse = context =>
            {
                var headers = context.Context.Response.Headers;
                var contentType = headers["Content-Type"];

                if (contentType != "application/x-gzip" && !context.File.Name.EndsWith(".gz"))
                {
                    return;
                }

                var fileNameToTry = context.File.Name.Substring(0, context.File.Name.Length - 3);

                if (mimeTypeProvider.TryGetContentType(fileNameToTry, out var mimeType))
                {
                    headers.Add("Content-Encoding", "gzip");
                    headers["Content-Type"] = mimeType;
                }
            };
            app.UseStaticFiles(staticFilesOptionsValue);

            return app;
        }
    }
}
