using AutoMapper;
using Definux.Emeraude.Admin.UI.ViewModels.System;
using Definux.Emeraude.Domain.Logging;

namespace Definux.Emeraude.Admin.Mapping.Profiles
{
    /// <summary>
    /// Admin view models mapping profile.
    /// </summary>
    public class AdminViewModelsProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminViewModelsProfile"/> class.
        /// </summary>
        public AdminViewModelsProfile()
        {
            this.CreateMap<ErrorLog, ErrorLogViewModel>()
                .ReverseMap();
        }
    }
}
