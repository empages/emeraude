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

namespace Definux.Emeraude.Tests.Project
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEmeraude<IEntityContext, EntityContext>(options =>
            {
                options.ApplyEmeraudeBaseOptions();

                options.DatabaseContextProvider = DatabaseContextProvider.InMemoryDatabase;
                options.LoggerContextProvider = DatabaseContextProvider.InMemoryDatabase;
                options.MigrationsAssembly = "Definux.Emeraude.Tests.Project.Infrastructure";
                
                options.Mapping.AddProfile<MainAssemblyMappingProfile>();
                options.AddAssembly("Definux.Emeraude.Tests.Project");
                options.AddAssembly("Definux.Emeraude.Tests.Project.Application");
                options.ProjectName = "Definux.Emeraude.Tests.Project";

                options.TestMode = true;
                options.ConfigureSeo(seoOptions =>
                {
                    seoOptions.SetSitemapComposition<SitemapComposition>();
                });
                
                options.ConfigureEmailsInfrastructure(emailOptions =>
                {
                    emailOptions.EmailSenderImplementationType = typeof(CustomEmailSender);
                });
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
