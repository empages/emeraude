using System.Resources;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Extensions;
using Definux.Emeraude.Identity.ExternalProviders.Facebook;
using Definux.Emeraude.Identity.ExternalProviders.Google;
using EmDoggo.Adapters;
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
            services.AddEmeraude<IEntityContext, EntityContext>(setup =>
            {
                setup.ApplyEmeraudeBaseOptions();

                setup.MainOptions.InfrastructureAssembly = "EmDoggo.Infrastructure";
                setup.MainOptions.ApplicationAssembly = "EmDoggo.Application";
                setup.MainOptions.DomainAssembly = "EmDoggo.Domain";
                setup.MainOptions.ProjectName = "EmDoggo Dev";
                setup.MainOptions.MaintenanceMode = false;
                setup.MainOptions.ExecuteMigrations = true;

                setup.ApplicationsOptions.AddMappingProfile<EmDoggoAssemblyMappingProfile>();
                
                setup.PersistenceOptions.ContextProvider = DatabaseContextProvider.PostgreSql;
                
                setup.LoggerOptions.ContextProvider = DatabaseContextProvider.PostgreSql;
                
                setup.IdentityOptions.HasExternalAuthentication = true;
                setup.IdentityOptions.ExternalProvidersAuthenticators.Add(new FacebookAuthenticator());
                setup.IdentityOptions.ExternalProvidersAuthenticators.Add(new GoogleAuthenticator());
                
                setup.AdminOptions.SetDashboardRequestType<AdminDashboardQuery>();
                setup.AdminOptions.SetAdminMenusBuilder<AdminMenusBuilder>();
                
                setup.FilesOptions.AddInitFolders("wwwroot", "uploads", "images", "foods");
                setup.FilesOptions.AddInitFolders("wwwroot", "dummy", "folder_A");
                setup.FilesOptions.AddInitFolders("wwwroot", "dummy", "folder_B");
                
                setup.ClientOptions.SetSitemapComposition<SitemapComposition>();
                setup.ClientOptions.DefaultMetaTags.TitleSuffix = " | EmDoggo";
                setup.ClientOptions.DefaultMetaTags.SetImage("https://scontent.definux.net/emeraude/EmeraudeFramework.jpg");
                
                setup.ClientBuilderOptions.SetClientApplicationPath("VueClientApp", "src", "EmDoggo", "ClientApp");
                setup.ClientBuilderOptions.AddAssembly("Definux.Emeraude");
                setup.ClientBuilderOptions.AddAssembly("EmDoggo");
                setup.ClientBuilderOptions.AddModule<VueConstantsModule>();
                setup.ClientBuilderOptions.AddModule<VueStaticContentModule>();
                setup.ClientBuilderOptions.AddModule<VueTranslationsResourcesModule>();
                setup.ClientBuilderOptions.AddModule<VueWebApiModule>();
                setup.ClientBuilderOptions.ConstantsTypes.Add(typeof(SomeConstants));
                setup.ClientBuilderOptions.Constants.Add("SomeKey1", "SomeValue1");
                setup.ClientBuilderOptions.Constants.Add("SomeKey2", "SomeValue2");
            });

            services.RegisterInfrastructureServices();
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
