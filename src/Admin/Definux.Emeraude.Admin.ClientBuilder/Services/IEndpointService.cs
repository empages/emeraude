using Definux.Emeraude.Admin.ClientBuilder.Models;
using System.Collections.Generic;

namespace Definux.Emeraude.Admin.ClientBuilder.Services
{
    public interface IEndpointService
    {
        List<Endpoint> GetAllEndpoints();

        List<ClassDescription> GetAllEndpointsClasses();
    }
}
