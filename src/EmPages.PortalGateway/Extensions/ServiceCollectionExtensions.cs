using System.Linq;
using System.Text;
using EmPages.Common;
using EmPages.Identity;
using EmPages.PortalGateway.ActionFilters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace EmPages.PortalGateway.Extensions;

/// <summary>
/// Extensions for <see cref="IServiceCollection"/>.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds EmPages Framework portal gateway services.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static IServiceCollection AddEmeraudePortalGateway(this IServiceCollection services, IEmPortalGatewayOptions options)
    {
        var identityOptions = options as IEmIdentityOptions;
        services.AddScoped<EmPortalFilterAttribute>();
        services.AddCors(corsOptions =>
        {
            corsOptions.AddPolicy(EmPortalGatewayConstants.CorsPolicyName, builder =>
            {
                builder
                    .WithOrigins(options.PortalUrls.ToArray())
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
        });

        services
            .AddAuthentication()
            .AddJwtBearer(EmPortalGatewayConstants.AuthenticationScheme, opt =>
            {
                opt.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = identityOptions.AccessTokenIssuer,
                    ValidAudience = EmConstants.FrameworkId,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(identityOptions.AccessTokenSecurityKey)),
                };
            });

        return services;
    }
}