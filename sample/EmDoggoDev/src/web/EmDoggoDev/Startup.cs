using Definux.Emeraude.Admin.ClientBuilder.Extensions;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Extensions;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Extensions;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Extensions;
using EmDoggoDev.Application.Common.Interfaces.Persistance;
using EmDoggoDev.Application.Common.Mapping;
using EmDoggoDev.Infrastructure.Extensions;
using EmDoggoDev.Infrastructure.Persistance;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace EmDoggoDev
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
                options.MigrationsAssembly = "EmDoggoDev.Infrastructure";
                options.ExecuteMigrations = false;

                options.Mapping.AddProfile<EmDoggoDevAssemblyMappingProfile>();
                options.AddAssembly("EmDoggoDev");
                options.AddAssembly("EmDoggoDev.Application");
                options.ProjectName = "EmDoggo Dev";
                options.MaintenanceMode = true;
            });

            services.AddEmeraudeClientBuilder(options =>
            {
                options.SetWebAppPath("web", "EmDoggoDev", "ClientApp");
                options.SetMobileAppPath("mobile", "EmDoggoDev.Mobile");

                options.AddAssembly("Definux.Emeraude");
                options.AddAssembly("EmDoggoDev");

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
