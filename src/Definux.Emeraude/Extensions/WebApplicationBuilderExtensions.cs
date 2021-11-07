using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using AutoMapper;
using Definux.Emeraude.Application;
using Definux.Emeraude.Application.Admin;
using Definux.Emeraude.Application.Admin.Extensions;
using Definux.Emeraude.Application.Admin.Mapping.Profiles;
using Definux.Emeraude.Application.Behaviours;
using Definux.Emeraude.Application.ClientBuilder.Extensions;
using Definux.Emeraude.Application.ClientBuilder.Mapping.Profiles;
using Definux.Emeraude.Application.ClientBuilder.Options;
using Definux.Emeraude.Application.Consumer.Extensions;
using Definux.Emeraude.Application.Consumer.Mapping;
using Definux.Emeraude.Application.Mapping;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Essentials.Base;
using Definux.Emeraude.Essentials.Extensions;
using Definux.Emeraude.Infrastructure.FileStorage.Extensions;
using Definux.Emeraude.Infrastructure.Identity.Entities;
using Definux.Emeraude.Infrastructure.Identity.Extensions;
using Definux.Emeraude.Infrastructure.Identity.Options;
using Definux.Emeraude.Infrastructure.Identity.Persistence;
using Definux.Emeraude.Infrastructure.Localization.Extensions;
using Definux.Emeraude.Infrastructure.Persistence.Extensions;
using Definux.Emeraude.Presentation.ActionFilters;
using Definux.Emeraude.Presentation.Converters;
using Definux.Emeraude.Presentation.ModelBinders;
using Definux.Emeraude.Presentation.PortalGateway.Extensions;
using FluentValidation.AspNetCore;
using IdentityServer4;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using WebMarkupMin.AspNetCore3;

namespace Definux.Emeraude.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IServiceCollection"/>.
    /// </summary>
    public static class WebApplicationBuilderExtensions
    {
        /// <summary>
        /// Configure Emeraude framework required services and functionalities.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="setupAction"></param>
        /// <returns></returns>
        public static EmeraudeSettingsBuilder ConfigureEmeraude(
            this WebApplicationBuilder builder,
            Action<EmOptionsSetup> setupAction = null)
        {
            var settingsBuilder = new EmeraudeSettingsBuilder
            {
                Services = builder.Services,
            };

            var applicationAssembly = Assembly.GetCallingAssembly().GetName().Name;

            var setup = builder.Services.RegisterEmeraudeOptions(setupAction);

            builder.Services.AddHttpContextAccessor();

            builder.Services.AddOptions();

            builder.Services.ConfigureDatabases(builder.Configuration, setup.PersistenceOptions, setup.MainOptions);

            builder.Services.ConfigureMapper(applicationAssembly, setup.ApplicationsOptions);

            builder.Services.ConfigureIdentityOptions(setup.IdentityOptions);

            builder.Services.ConfigureRazor();

            settingsBuilder.AuthenticationBuilder = builder.AddEmeraudeAuthentication(setup.IdentityOptions);

            builder.Services.RegisterEmeraudeIdentity();

            builder.Services.RegisterEmeraudeLocalization(setup.MainOptions);

            builder.Services.RegisterEmeraudeSystemFilesManagement(setup.FilesOptions);

            builder.Services.ConfigureAuthorizationPolicies();

            builder.Services.AddEmeraudeAdmin(setup.AdminOptions, setup.MainOptions);

            builder.Services.AddEmeraudeConsumer(setup.ConsumerOptions);

            builder.Services.RegisterMediatR(setup.MainOptions.Assemblies);

            builder.Services.AddCqrsBehaviours();

            builder.Services.AddDatabaseInitializer<IApplicationDatabaseInitializer, ApplicationDatabaseInitializer>();

            builder.Services.RegisterHtmlOptimizationServices();

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddEmeraudeClientBuilder(setup.ClientBuilderOptions);

            builder.Services.AddServerSideBlazor();

            builder.Services.RegisterEmeraudePortalGateway(setup.PortalGatewayOptions);

            builder.Services.ConfigureMvc(setup.MainOptions);

            return settingsBuilder;
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

        private static void ApplyEmeraudeBaseOptions(this EmOptionsSetup setup)
        {
            setup.MainOptions.AddAssembly(FrameworkAssemblies.EmeraudeApplicationAdmin);
            setup.MainOptions.AddAssembly(FrameworkAssemblies.EmeraudeApplicationAdminEmPages);
            setup.MainOptions.AddAssembly(FrameworkAssemblies.EmeraudeApplicationClientBuilder);
            setup.MainOptions.AddAssembly(FrameworkAssemblies.EmeraudeApplicationConsumer);
            setup.MainOptions.AddAssembly(FrameworkAssemblies.EmeraudeApplicationGeneral);
            setup.MainOptions.AddAssembly(FrameworkAssemblies.EmeraudeApplicationIdentity);
            setup.MainOptions.AddAssembly(FrameworkAssemblies.EmeraudeApplication);
            setup.MainOptions.SetEmeraudeAssembly(Assembly.GetExecutingAssembly());
            setup.MainOptions.AddAssembly(Assembly.GetCallingAssembly());

            setup.PersistenceOptions.AddDatabaseInitializer<IApplicationDatabaseInitializer>();
        }

        private static void RegisterMediatR(this IServiceCollection services, List<Assembly> assemblies)
        {
            var assembliesList = new List<Assembly>
            {
                AdminAssembly.GetAssembly(), Assembly.GetCallingAssembly(), Assembly.GetExecutingAssembly(),
            };
            assembliesList.AddRange(assemblies);

            services.AddMediatR(assembliesList.ToArray());
        }

        private static void AddCqrsBehaviours(this IServiceCollection services)
        {
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestLoggingBehavior<,>));
        }

        private static AuthenticationBuilder AddEmeraudeAuthentication(this WebApplicationBuilder builder, EmIdentityOptions identityOptions)
        {
            builder.Services.LoadOptions<JsonWebTokenOptions>(builder.Configuration, nameof(JsonWebTokenOptions));

            var authenticationBuilder = builder
                .Services
                .AddAuthentication(options =>
                {
                    options.DefaultSignInScheme = EmAuthenticationDefaults.CookieAuthenticationScheme;
                    options.DefaultAuthenticateScheme = EmAuthenticationDefaults.CookieAuthenticationScheme;
                    options.DefaultChallengeScheme = EmAuthenticationDefaults.CookieAuthenticationScheme;
                    options.DefaultScheme = EmAuthenticationDefaults.CookieAuthenticationScheme;
                })
                .AddCookie(IdentityServerConstants.ExternalCookieAuthenticationScheme);

            builder.Services.LoadOptions<ExternalOAuth2ProvidersOptions>(builder.Configuration, nameof(ExternalOAuth2ProvidersOptions));
            builder.Services.RegisterExternalProvidersAuthenticators(
                authenticationBuilder,
                identityOptions.ExternalProvidersAuthenticators);

            authenticationBuilder
                .AddConsumerCookie()
                .AddJwtAuthentication(builder.Services.GetOptions<JsonWebTokenOptions>());

            return authenticationBuilder;
        }

        private static void ConfigureRazor(this IServiceCollection services)
        {
            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.ViewLocationFormats.Clear();
                options.ViewLocationFormats.Add("/Views/{1}/{0}.cshtml");
                options.ViewLocationFormats.Add("/Views/Shared/{0}.cshtml");
                options.ViewLocationFormats.Add("/Views/{0}.cshtml");

                options.AreaViewLocationFormats.Clear();
                options.AreaViewLocationFormats.Add("/Views/{2}/{1}/{0}.cshtml");
                options.AreaViewLocationFormats.Add("/Views/{2}/Shared/{0}.cshtml");
                options.AreaViewLocationFormats.Add("/Views/Shared/{0}.cshtml");
            });
        }

        private static void ConfigureMapper(
            this IServiceCollection services,
            string applicationAssembly,
            EmApplicationsOptions applicationsOptions)
        {
            services.AddSingleton<IMapper>(new Mapper(new MapperConfiguration(configuration =>
            {
                configuration.AddProfile<AdminAssemblyMappingProfile>();
                configuration.AddProfile<ClientAssemblyMappingProfile>();
                configuration.AddProfile<AdminClientBuilderAssemblyMappingProfile>();
                configuration.AddProfile<ApplicationMappingProfile>();
                configuration.AddMaps(applicationAssembly);
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

        private static void ConfigureIdentityOptions(this IServiceCollection services, EmIdentityOptions options)
        {
            services.AddIdentity<User, Role>()
                .AddEntityFrameworkStores<IdentityContextInstance>()
                .AddDefaultTokenProviders()
                .AddEmPostAuthenticationTokenProvider();

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
            setup.ApplyEmeraudeBaseOptions();
            setupAction?.Invoke(setup);
            services.AddSingleton<IEmOptionsProvider>(new EmOptionsProvider(setup));

            return setup;
        }

        private static void AddJwtAuthentication(this AuthenticationBuilder builder, JsonWebTokenOptions jwtOptions)
        {
            builder
                .AddJwtBearer(EmAuthenticationDefaults.BearerAuthenticationScheme, options =>
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
