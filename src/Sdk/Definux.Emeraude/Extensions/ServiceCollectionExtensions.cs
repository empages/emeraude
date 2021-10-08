using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using AutoMapper;
using Definux.Emeraude.Admin;
using Definux.Emeraude.Admin.Extensions;
using Definux.Emeraude.Admin.Mapping.Profiles;
using Definux.Emeraude.Application;
using Definux.Emeraude.Application.Behaviours;
using Definux.Emeraude.Application.Mapping;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Client.Extensions;
using Definux.Emeraude.Client.Mapping;
using Definux.Emeraude.ClientBuilder.Extensions;
using Definux.Emeraude.ClientBuilder.Mapping.Profiles;
using Definux.Emeraude.ClientBuilder.Options;
using Definux.Emeraude.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.ClientBuilder.Services;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Emails.Extensions;
using Definux.Emeraude.Files.Extensions;
using Definux.Emeraude.Identity.Entities;
using Definux.Emeraude.Identity.Extensions;
using Definux.Emeraude.Identity.Options;
using Definux.Emeraude.Localization.Extensions;
using Definux.Emeraude.Logger.Extensions;
using Definux.Emeraude.Persistence;
using Definux.Emeraude.Persistence.Extensions;
using Definux.Emeraude.Persistence.Seed;
using Definux.Emeraude.Presentation.ActionFilters;
using Definux.Emeraude.Presentation.Attributes;
using Definux.Emeraude.Presentation.Converters;
using Definux.Emeraude.Presentation.ModelBinders;
using Definux.Emeraude.Resources;
using Definux.Utilities.Extensions;
using FluentValidation.AspNetCore;
using IdentityServer4;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
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

            services.AddOptions();

            services.ConfigureDatabases<TContextInterface, TContextImplementation>(configuration, setup.PersistenceOptions, setup.MainOptions);

            services.ConfigureMapper(applicationAssembly, setup.ApplicationsOptions);

            services.ConfigureIdentityOptions<TContextImplementation>(setup.IdentityOptions);

            services.ConfigureRazor();

            settingsBuilder.AuthenticationBuilder = services.AddEmeraudeAuthentication(setup.IdentityOptions);

            services.ConfigureGoogleReCaptcha();

            services.RegisterEmeraudeIdentity();

            services.RegisterEmeraudeLogger(configuration, setup.LoggerOptions, setup.MainOptions);

            services.RegisterEmeraudeLocalization(setup.MainOptions);

            services.RegisterEmailInfrastructure(setup.EmailOptions);

            services.RegisterEmeraudeSystemFilesManagement(setup.FilesOptions);

            services.ConfigureAuthorizationPolicies();

            services.AddEmeraudeAdmin(setup.AdminOptions, setup.MainOptions);

            services.AddEmeraudeClient(setup.ClientOptions);

            services.RegisterMediatR(setup.MainOptions.Assemblies);

            services.AddCqrsBehaviours();

            services.AddDatabaseInitializer<IApplicationDatabaseInitializer, ApplicationDatabaseInitializer>();

            services.RegisterHtmlOptimizationServices();

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddEmeraudeClientBuilder(setup.ClientBuilderOptions);

            services.AddServerSideBlazor();

            services.ConfigureMvc(setup.MainOptions);

            return settingsBuilder;
        }

        /// <summary>
        /// Apply Emeraude base options. In case you want to override the method check the documentation first.
        /// </summary>
        /// <param name="setup"></param>
        public static void ApplyEmeraudeBaseOptions(this EmOptionsSetup setup)
        {
            setup.MainOptions.AddAssembly("Definux.Emeraude.Admin");
            setup.MainOptions.AddAssembly("Definux.Emeraude.Admin.EmPages");
            setup.MainOptions.AddAssembly("Definux.Emeraude.ClientBuilder");
            setup.MainOptions.AddAssembly("Definux.Emeraude.Client");
            setup.MainOptions.AddAssembly("Definux.Emeraude.Application");
            setup.MainOptions.SetEmeraudeAssembly(Assembly.GetExecutingAssembly());
            setup.MainOptions.AddAssembly(Assembly.GetCallingAssembly());

            setup.PersistenceOptions.AddDatabaseInitializer<IApplicationDatabaseInitializer>();
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

        private static void RegisterMediatR(this IServiceCollection services, List<Assembly> assemblies)
        {
            List<Assembly> assembliesList = new List<Assembly>();
            assembliesList.Add(AdminAssembly.GetAssembly());
            assembliesList.Add(Assembly.GetCallingAssembly());
            assembliesList.Add(Assembly.GetExecutingAssembly());
            assembliesList.AddRange(assemblies);

            services.AddMediatR(assembliesList.ToArray());
        }

        private static void AddCqrsBehaviours(this IServiceCollection services)
        {
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));
        }

        private static AuthenticationBuilder AddEmeraudeAuthentication(this IServiceCollection services, EmIdentityOptions identityOptions)
        {
            services.LoadOptions<JsonWebTokenOptions>(nameof(JsonWebTokenOptions));

            var authenticationBuilder = services
                .AddAuthentication(options =>
                {
                    options.DefaultSignInScheme = AuthenticationDefaults.ClientAuthenticationScheme;
                    options.DefaultAuthenticateScheme = AuthenticationDefaults.ClientAuthenticationScheme;
                    options.DefaultChallengeScheme = AuthenticationDefaults.ClientAuthenticationScheme;
                    options.DefaultScheme = AuthenticationDefaults.ClientAuthenticationScheme;
                })
                .AddCookie(IdentityServerConstants.ExternalCookieAuthenticationScheme);

            services.LoadOptions<ExternalOAuth2ProvidersOptions>(nameof(ExternalOAuth2ProvidersOptions));
            services.RegisterExternalProvidersAuthenticators(
                authenticationBuilder,
                identityOptions.ExternalProvidersAuthenticators);

            authenticationBuilder
                .AddClientCookie()
                .AddAdminCookie()
                .AddJwtAuthentication(services.GetOptions<JsonWebTokenOptions>());

            return authenticationBuilder;
        }

        private static void ConfigureRazor(this IServiceCollection services)
        {
            services.AddRazorPages(options =>
            {
                options.RootDirectory = "/Views/Admin";
            });

            services.Configure<RazorPagesOptions>(options => options.RootDirectory = "/Views/Admin");

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
        }

        private static void ConfigureMapper(
            this IServiceCollection services,
            string applicationAssembly,
            EmApplicationsOptions applicationsOptions)
        {
            services.AddSingleton<IMapper>(new Mapper(new MapperConfiguration(configuration =>
            {
                configuration.AddProfile<AdminModelsProfile>();
                configuration.AddProfile<AdminAssemblyMappingProfile>();
                configuration.AddProfile<ClientAssemblyMappingProfile>();
                configuration.AddProfile<AdminClientBuilderAssemblyMappingProfile>();
                configuration.AddProfile<ApplicationMappingProfile>();
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
        }

        private static void ConfigureGoogleReCaptcha(this IServiceCollection services)
        {
            services.LoadOptions<GoogleRecaptchaKeysOptions>(nameof(GoogleRecaptchaKeysOptions));
            services.AddScoped<GoogleReCaptchaValidateAttribute>();
        }

        private static void ConfigureIdentityOptions<TContext>(this IServiceCollection services, EmIdentityOptions options)
            where TContext : EmContext<TContext>
        {
            services.AddIdentity<User, Role>()
                .AddEntityFrameworkStores<TContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(opt =>
            {
                opt.Lockout = options.SourceIdentityOptions.Lockout;
                opt.Password = options.SourceIdentityOptions.Password;
                opt.Stores = options.SourceIdentityOptions.Stores;

                opt.Tokens.AuthenticatorIssuer = options.SourceIdentityOptions.Tokens.AuthenticatorIssuer;
                opt.Tokens.AuthenticatorTokenProvider = options.SourceIdentityOptions.Tokens.AuthenticatorTokenProvider;
                opt.Tokens.ChangeEmailTokenProvider = options.SourceIdentityOptions.Tokens.ChangeEmailTokenProvider;
                opt.Tokens.EmailConfirmationTokenProvider = options.SourceIdentityOptions.Tokens.EmailConfirmationTokenProvider;
                opt.Tokens.PasswordResetTokenProvider = options.SourceIdentityOptions.Tokens.PasswordResetTokenProvider;
                opt.Tokens.ChangePhoneNumberTokenProvider = options.SourceIdentityOptions.Tokens.ChangePhoneNumberTokenProvider;
                if (options.SourceIdentityOptions.Tokens.ProviderMap.Any())
                {
                    opt.Tokens.ProviderMap = options.SourceIdentityOptions.Tokens.ProviderMap;
                }

                opt.User = options.SourceIdentityOptions.User;
                opt.ClaimsIdentity = options.SourceIdentityOptions.ClaimsIdentity;
                opt.SignIn = options.SourceIdentityOptions.SignIn;
            });
        }

        private static void ConfigureMvc(this IServiceCollection services, EmMainOptions emeraudeOptions)
        {
            services.AddMvc(options =>
            {
                options.Filters.Add(new RequestExceptionFilter());
                options.ModelBinderProviders.Insert(0, new DateModelBinderProvider());
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
                {
                    JsonConvert.DefaultSettings = () => new JsonSerializerSettings
                    {
                        ContractResolver = new DefaultContractResolver
                        {
                            NamingStrategy = new CamelCaseNamingStrategy(),
                        },
                        Formatting = Formatting.Indented,
                        Converters = new List<JsonConverter>
                        {
                            new TimeSpanNewtonsoftConverter(),
                            new TimeSpanNullableNewtonsoftConverter(),
                            new DateModelNewtonsoftConverter(),
                            new DateModelNullableNewtonsoftConverter(),
                        },
                    };

                    options.JsonSerializerOptions.Converters.Add(new TimeSpanConverter());
                    options.JsonSerializerOptions.Converters.Add(new TimeSpanNullableConverter());
                    options.JsonSerializerOptions.Converters.Add(new DateModelConverter());
                    options.JsonSerializerOptions.Converters.Add(new DateModelNullableConverter());
                })
                .AddXmlSerializerFormatters();
        }

        private static EmOptionsSetup RegisterEmeraudeOptions(this IServiceCollection services, Action<EmOptionsSetup> setupAction)
        {
            var setup = new EmOptionsSetup();
            setupAction?.Invoke(setup);
            services.AddSingleton<IEmOptionsProvider>(new EmOptionsProvider(setup));

            return setup;
        }

        private static void AddJwtAuthentication(this AuthenticationBuilder builder, JsonWebTokenOptions jwtOptions)
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

        private static void AddEmeraudeClientBuilder(this IServiceCollection services, EmClientBuilderOptions options)
        {
            if (options.EnableClientBuilder)
            {
                services.RegisterClientBuilder(options);
            }
        }
    }
}
