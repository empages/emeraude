using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using AutoMapper;
using Definux.Emeraude.ActionFilters;
using Definux.Emeraude.Admin;
using Definux.Emeraude.Admin.ClientBuilder.Mapping.Profiles;
using Definux.Emeraude.Admin.Extensions;
using Definux.Emeraude.Admin.Mapping.Profiles;
using Definux.Emeraude.Admin.UI;
using Definux.Emeraude.Application.Behaviours;
using Definux.Emeraude.Application.Common.Interfaces.Persistence;
using Definux.Emeraude.Application.Common.Interfaces.Persistence.Seed;
using Definux.Emeraude.Client.Extensions;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Converters;
using Definux.Emeraude.Emails.Extensions;
using Definux.Emeraude.Files.Extensions;
using Definux.Emeraude.Identity.Entities;
using Definux.Emeraude.Identity.Extensions;
using Definux.Emeraude.Localization.Extensions;
using Definux.Emeraude.Logger.Extensions;
using Definux.Emeraude.ModelBinders;
using Definux.Emeraude.Persistence;
using Definux.Emeraude.Persistence.Extensions;
using Definux.Emeraude.Persistence.Seed;
using Definux.Seo.Extensions;
using Definux.Seo.Options;
using Definux.Utilities.DataAnnotations;
using Definux.Utilities.Extensions;
using Definux.Utilities.Options;
using FluentValidation.AspNetCore;
using IdentityServer4;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace Definux.Emeraude.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Configure Emeraude framework required services and functionalities.
        /// </summary>
        /// <typeparam name="TContextInterface">Interface of the application database context.</typeparam>
        /// <typeparam name="TContextImplementation">Implementation of the application database context.</typeparam>
        /// <param name="services"></param>
        /// <param name="optionsAction"></param>
        /// <param name="seoOptionsAction"></param>
        /// <returns></returns>
        public static IServiceCollection AddEmeraude<TContextInterface, TContextImplementation>(
            this IServiceCollection services,
            Action<EmOptions> optionsAction = null,
            Action<DefinuxSeoOptions> seoOptionsAction = null)
            where TContextInterface : class, IEmContext
            where TContextImplementation : EmContext<TContextImplementation>, TContextInterface
        {
            var options = new EmOptions();
            if (optionsAction != null)
            {
                optionsAction.Invoke(options);
            }

            var applicationAssembly = Assembly.GetCallingAssembly().GetName().Name;
            var serviceProvider = services.BuildServiceProvider();
            var configuration = serviceProvider.GetService<IConfiguration>();

            options.ApplyEmeraudeDefaultOptions();

            services.RegisterEmeraudeOptions(options);

            services.ConfigureDatabases<TContextInterface, TContextImplementation>(applicationAssembly, configuration, options);

            services.ConfigureMapper(applicationAssembly, options.Mapping);

            services.ConfigureIdentityOptions<TContextImplementation>();

            services.ConfigureRazorViews();

            services.AddEmeraudeAuthentication(options.Account);

            services.ConfigureGoogleReCaptcha();

            services.LoadSmtpOptions();

            services.RegisterEmeraudeIdentity();

            services.RegisterEmeraudeLogger(options);

            services.RegisterEmeraudeLocalization(options);

            services.RegisterEmailSender();

            services.RegisterEmeraudeSystemFilesManagement();

            services.ConfigureAuthorizationPolicies();

            services.AddEmeraudeAdmin();

            services.AddEmeraudeClient();

            services.AddDefinuxSeo(Assembly.GetCallingAssembly(), seoOptionsAction);

            services.RegisterMediatR(options.Assemblies);

            services.AddCqrsBehaviours();

            services.AddHttpContextAccessor();

            services.ConfigureMvc(options);

            services.AddDatabaseInitializer<IApplicationDatabaseInitializer, ApplicationDatabaseInitializer>();

            return services;
        }

        private static IServiceCollection RegisterMediatR(this IServiceCollection services, List<Assembly> assemblies)
        {
            List<Assembly> assembliesList = new List<Assembly>();
            assembliesList.Add(AdminAssembly.GetAssembly());
            assembliesList.Add(Assembly.GetCallingAssembly());
            assembliesList.Add(Assembly.GetExecutingAssembly());
            assembliesList.AddRange(assemblies);

            services.AddMediatR(assembliesList.ToArray());
            services.RegisterAdminEntityControllersRequests(assembliesList.ToArray());

            return services;
        }

        private static IServiceCollection AddCqrsBehaviours(this IServiceCollection services)
        {
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

            return services;
        }

        private static IServiceCollection AddEmeraudeAuthentication(this IServiceCollection services, AccountOptions accountOptions)
        {
            services.LoadJwtOptions();

            var authenticationBuilder = services
                .AddAuthentication(options =>
                {
                    options.DefaultSignInScheme = AuthenticationDefaults.ClientAuthenticationScheme;
                    options.DefaultAuthenticateScheme = AuthenticationDefaults.ClientAuthenticationScheme;
                    options.DefaultChallengeScheme = AuthenticationDefaults.ClientAuthenticationScheme;
                    options.DefaultScheme = AuthenticationDefaults.ClientAuthenticationScheme;
                })
                .AddCookie(IdentityServerConstants.ExternalCookieAuthenticationScheme);

            if (accountOptions.HasOAuthLogin)
            {
                services.LoadOAuth2Options();
                authenticationBuilder.AddExternalOAuth2Providers(accountOptions, services.GetOAuth2Options());
            }

            authenticationBuilder
                .AddClientCookie()
                .AddAdminCookie()
                .AddJwtAuthentication(services.GetJwtOptions());

            return services;
        }

        private static IServiceCollection ConfigureRazorViews(this IServiceCollection services)
        {
            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.ViewLocationFormats.Clear();
                options.ViewLocationFormats.Add("/Views/Client/{1}/{0}.cshtml");
                options.ViewLocationFormats.Add("/Views/Client/Shared/{0}.cshtml");
                options.ViewLocationFormats.Add("/Views/Client/{0}.cshtml");
                options.ViewLocationFormats.Add("/Views/Emails/{1}/{0}.cshtml");
                options.ViewLocationFormats.Add("/Views/Emails/Shared/{0}.cshtml");

                options.AreaViewLocationFormats.Clear();
                options.AreaViewLocationFormats.Add("/Views/{2}/{1}/{0}.cshtml");
                options.AreaViewLocationFormats.Add("/Views/{2}/Shared/{0}.cshtml");
                options.AreaViewLocationFormats.Add("/Views/Client/Shared/{0}.cshtml");
            });

            return services;
        }

        private static IServiceCollection ConfigureMapper(this IServiceCollection services, string applicationAssembly, MappingOptions options)
        {
            services.AddSingleton<IMapper>(new Mapper(new MapperConfiguration(configuration =>
            {
                configuration.AddProfile<AdminViewModelsProfile>();
                configuration.AddProfile<AdminAssemblyMappingProfile>();
                configuration.AddProfile<AdminClientBuilderAssemblyMappingProfile>();
                configuration.AddMaps(applicationAssembly);
                configuration.AddAdminMapperConfiguration();
                configuration.AddClientMapperConfiguration();
                configuration.AllowNullCollections = true;
                configuration.AllowNullDestinationValues = true;
                if (options != null)
                {
                    if (options.MappingAssemblies != null && options.MappingAssemblies.Count > 0)
                    {
                        foreach (var mappingAssembly in options.MappingAssemblies)
                        {
                            configuration.AddMaps(mappingAssembly);
                        }
                    }

                    if (options.MappingProfiles != null && options.MappingProfiles.Count > 0)
                    {
                        foreach (var mappingProfileType in options.MappingProfiles)
                        {
                            configuration.AddProfile(mappingProfileType);
                        }
                    }
                }
            })));

            return services;
        }

        private static IServiceCollection ConfigureGoogleReCaptcha(this IServiceCollection services)
        {
            services.LoadGoogleRecaptchaOptions();
            services.AddScoped<InvisibleReCaptchaValidateAttribute>();
            services.AddScoped<VisibleReCaptchaValidateAttribute>();

            return services;
        }

        private static IServiceCollection ConfigureIdentityOptions<TContext>(this IServiceCollection services)
            where TContext : EmContext<TContext>
        {
            services.AddIdentity<User, Role>()
                .AddEntityFrameworkStores<TContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                options.User.RequireUniqueEmail = true;
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = EmIdentityConstants.PasswordRequiredLength;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(EmIdentityConstants.DefaultLockoutTimeSpanMinutes);
                options.Lockout.MaxFailedAccessAttempts = EmIdentityConstants.MaxFailedAccessAttempts;

                options.SignIn.RequireConfirmedEmail = true;
                options.SignIn.RequireConfirmedAccount = true;
            });

            return services;
        }

        private static IServiceCollection ConfigureMvc(this IServiceCollection services, EmOptions emeraudeOptions)
        {
            services.AddMvc(options =>
            {
                options.Filters.Add(new RequestExceptionFilter());
                options.UseCentralEmPagesRoutePrefix();
                options.ModelBinderProviders.Insert(0, new DateTimeModelBinderProvider());
            })
                .AddFluentValidation(options =>
                {
                    options.RegisterValidatorsFromAssemblies(emeraudeOptions.Assemblies);
                })
                .ConfigureApplicationPartManager(p =>
                {
                    p.ApplicationParts.Add(ApplicationAssemblyPart.AssemblyPart);
                    p.AddAdminUIApplicationParts();
                    p.FeatureProviders.Add(new ViewComponentFeatureProvider());
                })
                .AddJsonOptions(options =>
                    options.JsonSerializerOptions.Converters.Add(new TimeSpanConverter()))
                .AddXmlSerializerFormatters();

            return services;
        }

        private static IServiceCollection RegisterEmeraudeOptions(this IServiceCollection services, EmOptions emeraudeOptions)
        {
            emeraudeOptions.SetEmeraudeAssembly(Assembly.GetExecutingAssembly());

            services.Configure<EmOptions>(options =>
            {
                options.ProjectName = emeraudeOptions.ProjectName;
                options.AdminDashboardIndexRedirectRoute = emeraudeOptions.AdminDashboardIndexRedirectRoute;
                options.Mapping = emeraudeOptions.Mapping;
                options.Account = emeraudeOptions.Account;
                options.Assemblies = emeraudeOptions.Assemblies;
                options.AdditonalRoles = emeraudeOptions.AdditonalRoles;
                options.ExecuteMigrations = emeraudeOptions.ExecuteMigrations;

                options.SetEmeraudeAssembly(Assembly.GetExecutingAssembly());
            });

            return services;
        }

        private static void ApplyEmeraudeDefaultOptions(this EmOptions options)
        {
            options.AddAssembly("Definux.Emeraude.Admin");
            options.AddAssembly("Definux.Emeraude.Admin.ClientBuilder");
            options.AddAssembly("Definux.Emeraude.Admin.Analytics");
            options.AddAssembly("Definux.Emeraude.Client");
            options.AddAssembly("Definux.Emeraude.Application");
        }

        private static AuthenticationBuilder AddJwtAuthentication(this AuthenticationBuilder builder, JsonWebTokenOptions jwtOptions)
        {
            builder
                .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = jwtOptions.Issuer,
                        ValidAudience = jwtOptions.Issuer,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions.Key)),
                    };
                });

            return builder;
        }

        private static IServiceCollection ConfigureAuthorizationPolicies(this IServiceCollection services)
        {
            services.AddAuthorizationCore(options =>
            {
                options.ApplyEmeraudeAdminAuthorizationPolicies();

                options.AddPolicy(Policies.AuthorizedUploadPolicy, policy =>
                {
                    policy.RequireAuthenticatedUser();
                    policy.AddAuthenticationSchemes(
                        AuthenticationDefaults.AdminAuthenticationScheme,
                        AuthenticationDefaults.ClientAuthenticationScheme,
                        JwtBearerDefaults.AuthenticationScheme);
                });
            });

            return services;
        }
    }
}
