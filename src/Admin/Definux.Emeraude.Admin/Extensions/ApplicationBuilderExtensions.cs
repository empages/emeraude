using Microsoft.AspNetCore.Builder;

namespace Definux.Emeraude.Admin.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseEmeraudeAdminSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(config =>
            {
                config.SwaggerEndpoint("/swagger/v1/swagger.json", "Application API V1");
            });

            return app;
        }
    }
}
