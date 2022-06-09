using System;
using System.Threading.Tasks;
using EmDoggo.Core.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace EmDoggo.WebHost.Extensions;

public static class WebApplicationExtensions
{
    public static async Task PrepareDataAsync(this WebApplication app)
    {
        try
        {
            using var scope = app.Services.CreateScope();
            var serviceProvider = scope.ServiceProvider;
            var entityContext = serviceProvider.GetRequiredService<EntityContext>();
            var dataSeeder = serviceProvider.GetRequiredService<DataSeeder>();
            
            // Be sure that application start with clear and and predefined data.
            await entityContext.Database.EnsureDeletedAsync();
            await entityContext.Database.EnsureCreatedAsync();
            await dataSeeder.SeedAsync();

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}