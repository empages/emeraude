using Emeraude;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEmeraude(options =>
{
    options.ConfigureIdentityDbContext(builder =>
    {
        builder.UseSqlite("DataSource=app.db");
    });

    options.GatewayId = "test-id-123";
});

builder.Services.AddControllers();

var app = builder.Build();

app.StartEmeraudeAsync();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();