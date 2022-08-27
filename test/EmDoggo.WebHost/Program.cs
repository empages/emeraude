using EmDoggo.Core.Data;
using EmDoggo.WebHost.Extensions;
using EmPages;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<EntityContext>(b =>
{
    b.UseSqlite(builder.Configuration.GetConnectionString("EntityContext"));
});

builder.Services.AddTransient<DataSeeder>();

builder.Services.AddEmeraldPages(options =>
{
    options.ConfigureIdentityDbContext(b =>
    {
        b.UseSqlite(builder.Configuration.GetConnectionString("EmeraudeIdentityContext"));
    });

    options.GatewayId = "test-id-123";
});

builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

var app = builder.Build();

await app.PrepareDataAsync();

await app.StartEmeraudeAsync();

app.UseSwagger();

app.UseSwaggerUI();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();