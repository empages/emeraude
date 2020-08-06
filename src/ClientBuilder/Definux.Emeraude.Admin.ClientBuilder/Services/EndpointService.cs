using Definux.Emeraude.Admin.ClientBuilder.Models;
using Definux.Emeraude.Admin.ClientBuilder.Options;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Definux.Emeraude.Admin.ClientBuilder.DataAnnotations;
using Definux.Utilities.Extensions;

namespace Definux.Emeraude.Admin.ClientBuilder.Services
{
    public class EndpointService : IEndpointService
    {
        private readonly ClientBuilderOptions clientBuilderOptions;
        public EndpointService(IOptions<ClientBuilderOptions> clientBuilderOptions)
        {
            this.clientBuilderOptions = clientBuilderOptions.Value;
        }
        public List<Endpoint> GetAllEndpoints()
        {
            var options = this.clientBuilderOptions;
            List<Type> apiControllersTypes = new List<Type>();
            foreach (var assembly in options.Assemblies)
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
                    var endpointAttribute = endpoint.GetAttribute<EndpointAttribute>();
                    string controllerRoute = controllerType.GetAttribute<RouteAttribute>().Template;
                    string actionRoute = endpoint.GetAttribute<RouteAttribute>().Template;

                    Endpoint currentEntpoint = new Endpoint
                    {
                        Id = $"{controllerType.FullName.ToString().ToLower().Replace('.', '-')}-{endpoint.Name.ToString().ToLower().Replace('.', '-')}",
                        ControllerName = controllerType.Name,
                        ActionName = endpoint.Name,
                        Route = actionRoute.StartsWith("/", StringComparison.OrdinalIgnoreCase) ? actionRoute : $"{controllerRoute}{actionRoute}",
                        Method = endpoint.GetControllerActionHttpMethod(),
                        Response = DescriptionExtractor.ExtractResponseDescription(endpointAttribute.ResponseType),
                        Arguments = endpoint.GetParameters().Select(x => DescriptionExtractor.ExtractArgumentDescription(x.Name, x.ParameterType)).ToList()
                    };

                    resultEndpoints.Add(currentEntpoint);
                }
            }

            return resultEndpoints.OrderBy(x => x.ControllerName).ToList();
        }

        public List<ClassDescription> GetAllEndpointsClasses()
        {
            var endpoints = GetAllEndpoints();
            var classes = new List<ClassDescription>();
            foreach (var endpoint in endpoints)
            {
                if (!endpoint.Response.Void && endpoint.Response.Class.IsComplex)
                {
                    classes.Add(endpoint.Response.Class);
                }

                classes.AddRange(endpoint.Arguments.Where(x => x.Class.IsComplex).Select(x => x.Class).ToList());
            }

            return DescriptionExtractor.ExtractUniqueClassesFromClasses(classes);
        }

    }
}
