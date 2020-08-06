using Definux.Emeraude.Admin.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System.IO;

namespace Definux.Emeraude.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseEmeraude(this IApplicationBuilder app, IWebHostEnvironment environment)
        {
            if (environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();

                app.UseEmeraudeAdminSwagger();
            }
            else
            {
                app.UseExceptionHandler("/error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseEmeraudeStaticFiles();

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
