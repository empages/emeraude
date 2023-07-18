using System.Text;
using EmPages.Common;
using EmPages.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace EmPages.Portal;

/// <summary>
/// EmPages Portal dependency module injector.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Adds EmPages Framework portal services.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static IServiceCollection AddPortal(this IServiceCollection services, IEmPortalOptions options)
    {
        var identityOptions = options as IEmIdentityOptions;

        services
            .AddAuthentication()
            .AddJwtBearer(EmPortalConstants.AuthenticationScheme, opt =>
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