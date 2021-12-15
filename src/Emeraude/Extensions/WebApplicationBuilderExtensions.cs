using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using AutoMapper;
using Emeraude.Application;
using Emeraude.Application.Admin;
using Emeraude.Application.Admin.EmPages.Extensions;
using Emeraude.Application.Admin.Extensions;
using Emeraude.Application.Admin.Mapping.Profiles;
using Emeraude.Application.Behaviours;
using Emeraude.Application.ClientBuilder.Extensions;
using Emeraude.Application.ClientBuilder.Mapping.Profiles;
using Emeraude.Application.ClientBuilder.Options;
using Emeraude.Application.Consumer.Extensions;
using Emeraude.Application.Consumer.Mapping;
using Emeraude.Application.Mapping;
using Emeraude.Application.Options;
using Emeraude.Configuration.Options;
using Emeraude.Infrastructure.FileStorage.Extensions;
using Emeraude.Infrastructure.Identity.Entities;
using Emeraude.Infrastructure.Identity.Extensions;
using Emeraude.Infrastructure.Identity.Options;
using Emeraude.Infrastructure.Identity.Persistence;
using Emeraude.Infrastructure.Localization.Extensions;
using Emeraude.Infrastructure.Persistence.Extensions;
using Emeraude.Presentation;
using Emeraude.Presentation.ActionFilters;
using Emeraude.Presentation.Converters;
using Emeraude.Presentation.ModelBinders;
using Emeraude.Presentation.Options;
using Emeraude.Presentation.PlatformBase.Constraints;
using Emeraude.Presentation.PortalGateway.ActionFilters;
using Emeraude.Presentation.PortalGateway.Extensions;
using FluentValidation.AspNetCore;
using IdentityServer4;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Emeraude.Extensions;

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
    public static EmSettingsBuilder ConfigureEmeraude(
        this WebApplicationBuilder builder,
        Action<EmOptionsSetup> setupAction = null)
    {
        var settingsBuilder = new EmSettingsBuilder();

        var applicationAssembly = Assembly.GetCallingAssembly().GetName().Name;

        var setup = builder.Services.RegisterEmeraudeOptions(setupAction);

        builder.Services.AddHttpContextAccessor();

        builder.Services.AddOptions();

        builder.Services.ConfigureDatabases(setup.PersistenceOptions, setup.MainOptions);

        builder.Services.ConfigureMapper(applicationAssembly, setup.ApplicationsOptions);

        settingsBuilder.IdentityBuilder = builder.Services.ConfigureIdentityOptions(setup.IdentityOptions);

        settingsBuilder.AuthenticationBuilder = builder.AddEmeraudeAuthentication(setup.IdentityOptions);

        builder.Services.RegisterEmeraudeIdentity();

        builder.Services.RegisterEmeraudeLocalization(setup.MainOptions);

        builder.Services.RegisterEmeraudeSystemFilesManagement(setup.FilesOptions);

        builder.Services.ConfigureAuthorizationPolicies();

        builder.Services.AddEmeraudeAdmin(setup.AdminOptions, setup.MainOptions);

        builder.Services.RegisterEmPages(setup.MainOptions.Assemblies);

        builder.Services.AddEmeraudeConsumer(setup.ConsumerOptions);

        builder.Services.RegisterMediatR(setup.MainOptions.Assemblies);

        builder.Services.AddCqrsBehaviours();

        builder.Services.ConfigureRouting();

        builder.Services.AddDatabaseDeveloperPageExceptionFilter();

        builder.Services.AddEmeraudeClientBuilder(setup.ClientBuilderOptions);

        builder.Services.RegisterEmeraudePortalGateway(setup.PortalGatewayOptions);

        settingsBuilder.MvcBuilder = builder.Services.ConfigureMvc(setup.MainOptions, setup.PresentationOptions);

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
        setup.MainOptions.SetEmeraudeAssembly(Assembly.GetExecutingAssembly());
        setup.MainOptions.AddAssembly(Assembly.GetCallingAssembly());
        setup.MainOptions.AddAssembly(FrameworkAssemblies.EmeraudeApplicationAdmin);
        setup.MainOptions.AddAssembly(FrameworkAssemblies.EmeraudeApplicationAdminEmPages);
        setup.MainOptions.AddAssembly(FrameworkAssemblies.EmeraudeApplicationClientBuilder);
        setup.MainOptions.AddAssembly(FrameworkAssemblies.EmeraudeApplicationConsumer);
        setup.MainOptions.AddAssembly(FrameworkAssemblies.EmeraudeApplicationIdentity);
        setup.MainOptions.AddAssembly(FrameworkAssemblies.EmeraudeApplication);
    }

    private static void PostOperationalEmeraudeOptions(this EmOptionsSetup setup)
    {
        // Currently empty.
    }

    private static void ConfigureRouting(this IServiceCollection services)
    {
        services.AddRouting(opt =>
        {
            opt.ConstraintMap.Add(LanguageRouteConstraint.LanguageConstraintKey, typeof(LanguageRouteConstraint));
        });
    }

    private static void RegisterMediatR(this IServiceCollection services, List<Assembly> assemblies)
    {
        services.AddMediatR(assemblies.ToArray());
    }

    private static void AddCqrsBehaviours(this IServiceCollection services)
    {
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestLoggingBehavior<,>));
    }

    private static AuthenticationBuilder AddEmeraudeAuthentication(this WebApplicationBuilder builder, EmIdentityOptions identityOptions)
    {
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

        builder.Services.RegisterExternalProvidersAuthenticators(
            authenticationBuilder,
            identityOptions.ExternalProvidersAuthenticators);

        authenticationBuilder
            .AddConsumerCookie()
            .AddBearerAuthentication(identityOptions.AccessTokenOptions);

        return authenticationBuilder;
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

    private static IdentityBuilder ConfigureIdentityOptions(this IServiceCollection services, EmIdentityOptions options)
    {
        var identityBuilder = services.AddIdentity<User, Role>()
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

        return identityBuilder;
    }

    private static IMvcBuilder ConfigureMvc(this IServiceCollection services, EmMainOptions emeraudeOptions, EmPresentationOptions presentationOptions)
    {
        var mvcBuilder = services.AddMvc(options =>
            {
                options.Filters.Add(new RequestExceptionFilter());
                options.Filters.Add(new EmPagesExceptionFilter());
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
                foreach (var featureProvider in presentationOptions.FeatureProviders)
                {
                    p.FeatureProviders.Add(featureProvider);
                }
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

        return mvcBuilder;
    }

    private static EmOptionsSetup RegisterEmeraudeOptions(this IServiceCollection services, Action<EmOptionsSetup> setupAction)
    {
        var setup = new EmOptionsSetup();
        setup.ApplyEmeraudeBaseOptions();
        setupAction?.Invoke(setup);
        setup.PostOperationalEmeraudeOptions();
        services.AddSingleton<IEmOptionsProvider>(new EmOptionsProvider(setup));

        return setup;
    }

    private static void ConfigureAuthorizationPolicies(this IServiceCollection services)
    {
        services.AddAuthorizationCore(options =>
        {
            options.ApplyEmeraudeAdminAuthorizationPolicies();
        });
    }

    private static void AddEmeraudeClientBuilder(this IServiceCollection services, EmClientBuilderOptions options)
    {
        if (options.EnableClientBuilder)
        {
            services.RegisterClientBuilder(options);
        }
    }
}