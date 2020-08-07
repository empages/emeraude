using AutoMapper;
using Definux.Emeraude.Admin.UI.ViewModels.System;
using Definux.Emeraude.Domain.Logging;

namespace Definux.Emeraude.Admin.Mapping.Profiles
{
    public class AdminViewModelsProfile : Profile
    {
        public AdminViewModelsProfile()
        {
            CreateMap<ErrorLog, ErrorLogViewModel>()
                .ReverseMap();
        }
    }
}
