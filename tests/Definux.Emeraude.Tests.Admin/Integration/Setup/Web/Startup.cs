using Definux.Emeraude.Admin.ClientBuilder.Extensions;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Extensions;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Extensions;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Extensions;
using Definux.Emeraude.Persistence.Extensions;
using Definux.Emeraude.Tests.Admin.Integration.Setup.Application.Interfaces;
using Definux.Emeraude.Tests.Admin.Integration.Setup.Application.Mapping;
using Definux.Emeraude.Tests.Admin.Integration.Setup.Infrastructure.Persistence;
using Definux.Emeraude.Tests.Admin.Integration.Setup.Infrastructure.Persistence.Seed;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Tests.Admin.Integration.Setup.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEmeraude<ITestEntityContext, TestEntityContext>(options =>
                {
                    options.ApplyEmeraudeBaseOptions();

                    options.DatabaseContextProvider = DatabaseContextProvider.InMemoryDatabase;
                    options.MigrationsAssembly = "Definux.Emeraude.Tests.Admin";
                    options.ExecuteMigrations = false;
                    
                    options.Mapping.AddProfile<TestAssemblyMappingProfile>();
                    options.AddAssembly("Definux.Emeraude.Tests.Admin");
                    options.ProjectName = "Emeraude Admin Test";
                });

            services.AddEmeraudeClientBuilder(options =>
            {
                options.SetWebAppPath("web", "EmTest", "ClientApp");
                options.SetMobileAppPath("mobile", "EmTest");

                options.AddAssembly("Definux.Emeraude");
                options.AddAssembly("Definux.Emeraude.Tests.Admin");

                options.AddDefaultVueModules();
                options.AddDefaultXamarinModules();
            });

            services.AddDatabaseInitializer<ITestDataInitializer, TestDataInitializer>();
        }

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