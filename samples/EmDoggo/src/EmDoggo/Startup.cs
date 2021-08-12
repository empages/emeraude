using Definux.Emeraude.ClientBuilder.Extensions;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Extensions;
using Definux.Emeraude.Identity.ExternalProviders.Facebook;
using Definux.Emeraude.Identity.ExternalProviders.Google;
using EmDoggo.Application.DataSourceMaps;
using EmDoggo.Application.Interfaces;
using EmDoggo.Application.Mapping;
using EmDoggo.Application.Requests.Queries.AdminDashboard;
using EmDoggo.Application.Shared;
using EmDoggo.ClientBuilder.Modules.Constants;
using EmDoggo.ClientBuilder.Modules.StaticContent;
using EmDoggo.ClientBuilder.Modules.TranslationsResources;
using EmDoggo.ClientBuilder.Modules.WebApi;
using EmDoggo.Infrastructure.Extensions;
using EmDoggo.Infrastructure.Persistance;
using EmDoggo.Seo;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebMarkupMin.AspNetCore3;

namespace EmDoggo
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEmeraude<IEntityContext, EntityContext>(options =>
            {
                options.ApplyEmeraudeBaseOptions();

                options.DatabaseContextProvider = DatabaseContextProvider.PostgreSql;
                options.LoggerContextProvider = DatabaseContextProvider.PostgreSql;
                options.MigrationsAssembly = "EmDoggo.Infrastructure";
                options.ExecuteMigrations = true;

                options.Mapping.AddProfile<EmDoggoAssemblyMappingProfile>();
                options.AddAssembly("EmDoggo");
                options.AddAssembly("EmDoggo.Application");
                options.ProjectName = "EmDoggo Dev";
                options.MaintenanceMode = false;
                options.Account.HasExternalAuthentication = true;
                options.AdminDashboardRequestType = typeof(AdminDashboardQuery);
                
                options.ConfigureSeo(seoOptions =>
                {
                    seoOptions.SetSitemapComposition<SitemapComposition>();
                    seoOptions.DefaultMetaTags.TitleSuffix = " | EmDoggo";
                    seoOptions.DefaultMetaTags.SetImage("https://scontent.definux.net/emeraude/EmeraudeFramework.jpg");
                });
            })
                .AddExternalProvidersAuthenticators(authenticators =>
                {
                    authenticators.Add(new FacebookAuthenticator());
                    authenticators.Add(new GoogleAuthenticator());
                });

            services.AddEmeraudeClientBuilder(options =>
            {
                options.SetClientApplicationPath("VueClientApp", "src", "EmDoggo", "ClientApp");

                options.AddAssembly("Definux.Emeraude");
                options.AddAssembly("EmDoggo");

                options.AddModule<VueConstantsModule>();
                options.AddModule<VueStaticContentModule>();
                options.AddModule<VueTranslationsResourcesModule>();
                options.AddModule<VueWebApiModule>();
                
                options.ConstantsTypes.Add(typeof(SomeConstants));
                options.Constants.Add("SomeKey1", "SomeValue1");
                options.Constants.Add("SomeKey2", "SomeValue2");
            });

            services.RegisterInfrastructureServices();

            services.AddScoped<FoodDataSourceMap>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseEmeraudeExceptionHandler();

                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseEmeraudeStatusCodePage();

            app.UseHttpsRedirection();

            app.UseWebMarkupMin();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseStaticFiles();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
            });
        }
    }
}
