using System;
using System.Linq;
using System.Reflection;
using Definux.Emeraude.Client.Seo.Models;
using Definux.Emeraude.Client.Seo.Options;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Client.Seo.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Register SEO services.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="optionsAction"></param>
        /// <returns></returns>
        public static IServiceCollection AddSeo(this IServiceCollection services, Action<SeoOptions> optionsAction = null)
        {
            var options = new SeoOptions();
            optionsAction?.Invoke(options);

            services.AddScoped(typeof(ISitemapComposition), options.SitemapCompositionType);
            services.AddScoped<ISitemapBuilder, SitemapBuilder>();
            services.AddScoped<IRobotsTxtReader, RobotsTxtReader>();

            services.Configure<SeoOptions>(opt =>
            {
                opt.DefaultMetaTags = options.DefaultMetaTags;
            });

            return services;
        }
    }
}
