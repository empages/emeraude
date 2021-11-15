using Emeraude.Configuration.Options;
using Emeraude.Extensions;
using Emeraude.Tests.Project.Adapters;
using Emeraude.Tests.Project.Application.Interfaces.Persistence;
using Emeraude.Tests.Project.Application.Mapping;
using Emeraude.Tests.Project.Infrastructure.Extensions;
using Emeraude.Tests.Project.Infrastructure.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebMarkupMin.AspNetCore3;

namespace Definux.Emeraude.Tests.Project
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEmeraude<IEntityContext, EntityContext>(setup =>
            {
                setup.ApplyEmeraudeBaseOptions();

                setup.MainOptions.DomainAssembly = "Emeraude.Tests.Project.Domain";
                setup.MainOptions.ApplicationAssembly = "Emeraude.Tests.Project.Application";
                setup.MainOptions.InfrastructureAssembly = "Emeraude.Tests.Project.Infrastructure";
                
                setup.PersistenceOptions.ContextProvider = DatabaseContextProvider.InMemoryDatabase;

                setup.ApplicationsOptions.AddMappingProfile<MainAssemblyMappingProfile>();
                setup.MainOptions.AddAssembly("Emeraude.Tests.Project");
                setup.MainOptions.AddAssembly("Emeraude.Tests.Project.Application");
                setup.MainOptions.ProjectName = "Emeraude.Tests.Project";

                setup.AdminOptions.SetAdminMenusBuilder<AdminMenusBuilder>();
                
                setup.MainOptions.TestMode = true;
                setup.ClientOptions.SetSitemapComposition<SitemapComposition>();
                
                setup.ClientBuilderOptions.AddAssembly("Emeraude");
                setup.ClientBuilderOptions.AddAssembly("Emeraude.Tests.Project");
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
