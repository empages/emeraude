using Definux.Emeraude.Admin.ClientBuilder.Extensions;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Extensions;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Extensions;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Extensions;
using EmDoggo.Application.Common.Interfaces.Persistance;
using EmDoggo.Application.Common.Mapping;
using EmDoggo.Infrastructure.Extensions;
using EmDoggo.Infrastructure.Persistance;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace EmDoggo
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEmeraude<IEntityContext, EntityContext>(options =>
            {
                options.ApplyEmeraudeBaseOptions();

                options.DatabaseContextProvider = DatabaseContextProvider.PostgreSql;
                options.MigrationsAssembly = "EmDoggo.Infrastructure";
                options.ExecuteMigrations = false;

                options.Mapping.AddProfile<EmDoggoAssemblyMappingProfile>();
                options.AddAssembly("EmDoggo");
                options.AddAssembly("EmDoggo.Application");
                options.ProjectName = "EmDoggo Dev";
                options.MaintenanceMode = true;

                options.Account.HasFacebookLogin = true;
                options.Account.HasGoogleLogin = true;
            },
            seoOptions =>
            {
                seoOptions.DefaultMetaTags.TitleSuffix = " | EmDoggo";
            });

            services.AddEmeraudeClientBuilder(options =>
            {
                options.SetWebAppPath("web", "EmDoggo", "ClientApp");
                options.SetMobileAppPath("mobile", "EmDoggo.Mobile");

                options.AddAssembly("Definux.Emeraude");
                options.AddAssembly("EmDoggo");

                options.AddDefaultVueModules();
                options.AddDefaultXamarinModules();
            });

            services.RegisterInfrastructureServices();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseEmeraude(env);

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
