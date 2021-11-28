using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Emeraude.Application.ClientBuilder.Attributes;
using Emeraude.Application.ClientBuilder.Extensions;
using Emeraude.Application.ClientBuilder.Models;
using Emeraude.Application.ClientBuilder.Options;
using Emeraude.Configuration.Options;
using Emeraude.Essentials.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Emeraude.Application.ClientBuilder.Services
{
    /// <inheritdoc cref="IEndpointService"/>
    public class EndpointService : IEndpointService
    {
        private readonly ILogger<EndpointService> logger;
        private readonly EmClientBuilderOptions clientBuilderOptions;

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointService"/> class.
        /// </summary>
        /// <param name="optionsProvider"></param>
        /// <param name="logger"></param>
        public EndpointService(IEmOptionsProvider optionsProvider, ILogger<EndpointService> logger)
        {
            this.clientBuilderOptions = optionsProvider.GetClientBuilderOptions();
            this.logger = logger;
        }

        /// <inheritdoc/>
        public List<Endpoint> GetAllEndpoints()
        {
            try
            {
                List<Type> apiControllersTypes = new List<Type>();
                foreach (var assembly in this.clientBuilderOptions.Assemblies)
                {
                    var assemblyTypes = assembly.GetTypes().Where(x => x.HasAttribute<ApiEndpointsControllerAttribute>()).ToList();
                    apiControllersTypes.AddRange(assemblyTypes);
                }

                List<Endpoint> resultEndpoints = new List<Endpoint>();
                foreach (var controllerType in apiControllersTypes)
                {
                    var currentControllerEndpoints = controllerType.GetMethods().Where(x => x.HasAttribute<EndpointAttribute>()).ToList();
                    foreach (var endpoint in currentControllerEndpoints)
                    {
                        var currentEntpoint = this.BuildEndpoint(endpoint, controllerType);

                        if (currentEntpoint != null && resultEndpoints.FirstOrDefault(x => x.Id == currentEntpoint.Id) == null)
                        {
                            resultEndpoints.Add(currentEntpoint);
                        }
                    }
                }

                return resultEndpoints.OrderBy(x => x.ControllerName).ToList();
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occured during building the endpoints from Client Builder");
                return new List<Endpoint>();
            }
        }

        /// <inheritdoc/>
        public List<TypeDescription> GetAllEndpointsClasses()
        {
            var endpoints = this.GetAllEndpoints();
            var classes = new List<TypeDescription>();
            foreach (var endpoint in endpoints)
            {
                if (!endpoint.Response.Void && endpoint.Response.Type.IsComplex)
                {
                    classes.Add(endpoint.Response.Type);
                }

                classes.AddRange(endpoint.Arguments.Where(x => x.Type.IsComplex).Select(x => x.Type).ToList());
            }

            return DescriptionExtractor.ExtractUniqueClassesFromClasses(classes);
        }

        private Endpoint BuildEndpoint(MethodInfo endpointMethodInfo, Type controllerType)
        {
            try
            {
                var endpointAttribute = endpointMethodInfo.GetAttribute<EndpointAttribute>();
                string controllerRoute = controllerType.GetAttribute<RouteAttribute>().Template;
                string actionRoute = endpointMethodInfo.GetAttribute<RouteAttribute>().Template;

                Endpoint currentEndpoint = new Endpoint
                {
                    Id = $"{controllerType.FullName?.ToLower().Replace('.', '-')}-{endpointMethodInfo.Name.ToLower().Replace('.', '-')}",
                    ControllerName = controllerType.Name,
                    ActionName = endpointMethodInfo.Name,
                    Route = actionRoute.StartsWith("/", StringComparison.OrdinalIgnoreCase) ? actionRoute : $"{controllerRoute}{actionRoute}",
                    Method = endpointMethodInfo.GetControllerActionHttpMethod(),
                    Authorized = endpointMethodInfo.HasAttribute<AuthorizeAttribute>() || (controllerType.HasAttribute<AuthorizeAttribute>() && !endpointMethodInfo.HasAttribute<AllowAnonymousAttribute>()),
                    Response = DescriptionExtractor.ExtractResponseDescription(endpointAttribute.ResponseType),
                    Arguments = endpointMethodInfo
                        .GetParameters()
                        .Where(x => x.GetCustomAttribute<IgnoreParamAttribute>() == null)
                        .Select(x => DescriptionExtractor.ExtractArgumentDescription(x.Name, x.ParameterType))
                        .ToList(),
                };

                return currentEndpoint;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Error on creating endpoint from controller ({FullName}) action ({Name})", endpointMethodInfo.Name, controllerType.FullName);
                return null;
            }
        }
    }
}
