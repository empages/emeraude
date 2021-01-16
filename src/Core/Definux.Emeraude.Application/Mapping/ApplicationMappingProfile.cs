using AutoMapper;
using Definux.Emeraude.Application.Requests.Logging.Commands.LogFrontEndError;
using Definux.Emeraude.Domain.Logging;

namespace Definux.Emeraude.Application.Mapping
{
    /// <summary>
    /// Mapping profile for custom rules.
    /// </summary>
    public class ApplicationMappingProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationMappingProfile"/> class.
        /// </summary>
        public ApplicationMappingProfile()
        {
            this.CreateMap<ErrorLog, LogFrontEndErrorCommand>()
                .ReverseMap();
        }
    }
}