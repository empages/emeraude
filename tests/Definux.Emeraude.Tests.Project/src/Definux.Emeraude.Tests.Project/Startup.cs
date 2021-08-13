using Definux.Emeraude.ClientBuilder.Extensions;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Emails.Extensions;
using Definux.Emeraude.Extensions;
using Definux.Emeraude.Tests.Project.Application.Interfaces.Persistence;
using Definux.Emeraude.Tests.Project.Application.Mapping;
using Definux.Emeraude.Tests.Project.Infrastructure.Emails;
using Definux.Emeraude.Tests.Project.Infrastructure.Extensions;
using Definux.Emeraude.Tests.Project.Infrastructure.Persistence;
using Definux.Emeraude.Tests.Project.Seo;
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
                setup.MainOptions.ApplyEmeraudeBaseOptions();

                setup.MainOptions.DomainAssembly = "Definux.Emeraude.Tests.Project.Domain";
                setup.MainOptions.ApplicationAssembly = "Definux.Emeraude.Tests.Project.Application";
                setup.MainOptions.InfrastructureAssembly = "Definux.Emeraude.Tests.Project.Infrastructure";
                
                setup.PersistenceOptions.ContextProvider = DatabaseContextProvider.InMemoryDatabase;
                setup.LoggerOptions.ContextProvider = DatabaseContextProvider.InMemoryDatabase;
                
                setup.ApplicationsOptions.AddMappingProfile<MainAssemblyMappingProfile>();
                setup.MainOptions.AddAssembly("Definux.Emeraude.Tests.Project");
                setup.MainOptions.AddAssembly("Definux.Emeraude.Tests.Project.Application");
                setup.MainOptions.ProjectName = "Definux.Emeraude.Tests.Project";

                setup.MainOptions.TestMode = true;
                setup.ClientOptions.SetSitemapComposition<SitemapComposition>();
                setup.EmailOptions.EmailSenderImplementationType = typeof(CustomEmailSender);
            })
                .AddExternalProvidersAuthenticators(authenticators =>
                {
                    // here comes the external provider authenticators.
                });

            services.AddEmeraudeClientBuilder(options =>
            {
                options.AddAssembly("Definux.Emeraude");
                options.AddAssembly("Definux.Emeraude.Tests.Project");
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
