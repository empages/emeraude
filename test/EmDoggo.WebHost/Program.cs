using System;
using EmDoggo.Core.Data;
using EmDoggo.WebHost.Extensions;
using EmPages;
using Microsoft.AspNetCore.Authentication.JwtBearer;
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

    options.AddPagesAssembly("EmDoggo.EmConfig");
    
    options.AccessTokenIssuer = "http://localhost:5155";
    options.AccessTokenSecurityKey = "23f78223-83af-471c-8e7c-082b0df857ed";
    options.AccessTokenExpirationSpan = TimeSpan.FromHours(1);
});

builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

var app = builder.Build();

await app.PrepareDataAsync();

await app.StartEmeraudeAsync();

app.UseSwagger();

app.UseSwaggerUI();

app.UseCors();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();