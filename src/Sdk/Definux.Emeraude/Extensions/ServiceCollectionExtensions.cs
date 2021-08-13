using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using AutoMapper;
using Definux.Emeraude.Admin;
using Definux.Emeraude.Admin.Extensions;
using Definux.Emeraude.Admin.Mapping.Profiles;
using Definux.Emeraude.Application;
using Definux.Emeraude.Application.Behaviours;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Client.Extensions;
using Definux.Emeraude.Client.Mapping;
using Definux.Emeraude.ClientBuilder.Mapping.Profiles;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Emails.Extensions;
using Definux.Emeraude.Files.Extensions;
using Definux.Emeraude.Identity;
using Definux.Emeraude.Identity.Entities;
using Definux.Emeraude.Identity.Extensions;
using Definux.Emeraude.Localization.Extensions;
using Definux.Emeraude.Logger.Extensions;
using Definux.Emeraude.Persistence;
using Definux.Emeraude.Persistence.Extensions;
using Definux.Emeraude.Persistence.Seed;
using Definux.Emeraude.Presentation.ActionFilters;
using Definux.Emeraude.Presentation.Converters;
using Definux.Emeraude.Presentation.ModelBinders;
using Definux.Utilities.DataAnnotations;
using Definux.Utilities.Extensions;
using Definux.Utilities.Options;
using FluentValidation.AspNetCore;
using IdentityServer4;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using WebMarkupMin.AspNetCore3;

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
        /// <param name="setupAction"></param>
        /// <returns></returns>
        public static EmeraudeSettingsBuilder AddEmeraude<TContextInterface, TContextImplementation>(
            this IServiceCollection services,
            Action<EmOptionsSetup> setupAction = null)
            where TContextInterface : class, IEmContext
            where TContextImplementation : EmContext<TContextImplementation>, TContextInterface
        {
            var settingsBuilder = new EmeraudeSettingsBuilder
            {
                Services = services,
            };

            var applicationAssembly = Assembly.GetCallingAssembly().GetName().Name;
            var serviceProvider = services.BuildServiceProvider();
            var configuration = serviceProvider.GetService<IConfiguration>();

            var setup = services.RegisterEmeraudeOptions(setupAction);

            services.AddHttpContextAccessor();

            services.ConfigureDatabases<TContextInterface, TContextImplementation>(configuration, setup.PersistenceOptions, setup.MainOptions);

            services.ConfigureMapper(applicationAssembly, setup.ApplicationsOptions);

            services.ConfigureIdentityOptions<TContextImplementation>();

            services.ConfigureRazorViews();

            settingsBuilder.AuthenticationBuilder = services.AddEmeraudeAuthentication(setup.IdentityOptions);

            services.ConfigureGoogleReCaptcha();

            services.LoadSmtpOptions();

            services.RegisterEmeraudeIdentity();

            services.RegisterEmeraudeLogger(configuration, setup.LoggerOptions, setup.MainOptions);

            services.RegisterEmeraudeLocalization(setup.MainOptions);

            services.RegisterEmailInfrastructure(setup.EmailOptions);

            services.RegisterEmeraudeSystemFilesManagement(setup.FilesOptions);

            services.ConfigureAuthorizationPolicies();

            services.AddEmeraudeAdmin();

            services.AddEmeraudeClient(setup.ClientOptions);

            services.RegisterMediatR(setup.MainOptions.Assemblies);

            services.AddCqrsBehaviours();

            services.AddDatabaseInitializer<IApplicationDatabaseInitializer, ApplicationDatabaseInitializer>();

            services.RegisterHtmlOptimizationServices();

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.ConfigureMvc(setup.MainOptions);

            return settingsBuilder;
        }

        /// <summary>
        /// Apply Emeraude base options. In case you want to override the method check the documentation first.
        /// </summary>
        /// <param name="options"></param>
        public static void ApplyEmeraudeBaseOptions(this EmMainOptions options)
        {
            options.AddAssembly("Definux.Emeraude.Admin");
            options.AddAssembly("Definux.Emeraude.ClientBuilder");
            options.AddAssembly("Definux.Emeraude.Client");
            options.AddAssembly("Definux.Emeraude.Application");

            options.AddDatabaseInitializer<IApplicationDatabaseInitializer>();

            options.SetEmeraudeAssembly(Assembly.GetExecutingAssembly());
        }

        /// <summary>
        /// Configure <see cref="IDataProtectionBuilder"/> to use 'privateroot' as directory for session storage.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IDataProtectionBuilder ApplyAuthenticationSessionToPrivateRoot(this IServiceCollection services)
        {
            return services.AddDataProtection().PersistKeysToFileSystem(new DirectoryInfo("./privateroot/sessions"));
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
            services.RegisterAdditionalAdminGenericCustomRequests();

            return services;
        }

        private static IServiceCollection AddCqrsBehaviours(this IServiceCollection services)
        {
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

            return services;
        }

        private static AuthenticationBuilder AddEmeraudeAuthentication(this IServiceCollection services, EmIdentityOptions identityOptions)
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

            if (identityOptions.HasExternalAuthentication)
            {
                services.LoadOAuth2Options();
            }

            authenticationBuilder
                .AddClientCookie()
                .AddAdminCookie()
                .AddJwtAuthentication(services.GetJwtOptions());

            return authenticationBuilder;
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

        private static IServiceCollection ConfigureMapper(this IServiceCollection services, string applicationAssembly, EmApplicationsOptions applicationsOptions)
        {
            services.AddSingleton<IMapper>(new Mapper(new MapperConfiguration(configuration =>
            {
                configuration.AddProfile<AdminModelsProfile>();
                configuration.AddProfile<AdminAssemblyMappingProfile>();
                configuration.AddProfile<ClientAssemblyMappingProfile>();
                configuration.AddProfile<AdminClientBuilderAssemblyMappingProfile>();
                configuration.AddMaps(applicationAssembly);
                configuration.AddAdminMapperConfiguration();
                configuration.AddClientMapperConfiguration();
                configuration.AllowNullCollections = true;
                configuration.AllowNullDestinationValues = true;

                if (applicationsOptions != null)
                {
                    if (applicationsOptions.MappingAssemblies != null && applicationsOptions.MappingAssemblies.Count > 0)
                    {
                        foreach (var mappingAssembly in applicationsOptions.MappingAssemblies)
                        {
                            configuration.AddMaps(mappingAssembly);
                        }
                    }

                    if (applicationsOptions.MappingProfiles != null && applicationsOptions.MappingProfiles.Count > 0)
                    {
                        foreach (var mappingProfileType in applicationsOptions.MappingProfiles)
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

        private static IServiceCollection ConfigureMvc(this IServiceCollection services, EmMainOptions emeraudeOptions)
        {
            services.AddMvc(options =>
            {
                options.Filters.Add(new RequestExceptionFilter());
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
                    p.AddClientUIApplicationParts();
                    p.FeatureProviders.Add(new ViewComponentFeatureProvider());
                })
                .AddJsonOptions(options =>
                    options.JsonSerializerOptions.Converters.Add(new TimeSpanConverter()))
                .AddXmlSerializerFormatters();

            return services;
        }

        private static EmOptionsSetup RegisterEmeraudeOptions(this IServiceCollection services, Action<EmOptionsSetup> setupAction)
        {
            var setup = new EmOptionsSetup();
            setupAction?.Invoke(setup);
            services.AddSingleton<IEmOptionsProvider>(new EmOptionsProvider(setup));

            return setup;
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

        private static void ConfigureAuthorizationPolicies(this IServiceCollection services)
        {
            services.AddAuthorizationCore(options =>
            {
                options.ApplyEmeraudeAdminAuthorizationPolicies();
            });
        }

        private static void RegisterHtmlOptimizationServices(this IServiceCollection services)
        {
            services.AddWebMarkupMin(
                    options =>
                    {
                        options.AllowMinificationInDevelopmentEnvironment = true;
                        options.AllowCompressionInDevelopmentEnvironment = true;
                    })
                .AddHtmlMinification(
                    options =>
                    {
                        options.MinificationSettings.RemoveRedundantAttributes = true;
                    })
                .AddHttpCompression();
        }
    }
}
