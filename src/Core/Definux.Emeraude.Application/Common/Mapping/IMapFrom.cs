using AutoMapper;

namespace Definux.Emeraude.Application.Common.Mapping
{
    public interface IMapFrom<TEntity>
    {
        void Mapping(Profile profile) => profile.CreateMap(typeof(TEntity), GetType()).ReverseMap();
    }
}
