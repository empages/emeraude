using AutoMapper;
using Definux.Emeraude.Admin.Models;
using Definux.Emeraude.Admin.UI.ViewModels.Logging;
using Definux.Emeraude.Domain.Logging;
using Definux.Emeraude.Identity.Entities;

namespace Definux.Emeraude.Admin.Mapping.Profiles
{
    /// <summary>
    /// Admin view models mapping profile.
    /// </summary>
    public class AdminModelsProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminModelsProfile"/> class.
        /// </summary>
        public AdminModelsProfile()
        {
            this.CreateMap<ActivityLog, ActivityLogViewModel>()
                .ReverseMap();

            this.CreateMap<ErrorLog, ErrorLogViewModel>()
                .ReverseMap();

            this.CreateMap<EmailLog, EmailLogViewModel>()
                .ReverseMap();

            this.CreateMap<TempFileLog, TempFileLogViewModel>()
                .ReverseMap();

            this.CreateMap<User, EntitySelectModel>()
                .ForMember(d => d.Id, map => map.MapFrom(s => s.Id))
                .ForMember(d => d.Text, map => map.MapFrom(s => s.Name));
        }
    }
}
