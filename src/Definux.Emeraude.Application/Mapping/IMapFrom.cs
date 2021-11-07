using AutoMapper;

namespace Definux.Emeraude.Application.Mapping
{
    /// <summary>
    /// Auto configure mapping for specified mapping object with implemented entity.
    /// </summary>
    /// <typeparam name="TEntity">Mapping object.</typeparam>
    public interface IMapFrom<TEntity>
    {
        /// <summary>
        /// Configure mapping for mapping object with implemented entity.
        /// </summary>
        /// <param name="profile"></param>
        void Mapping(Profile profile) => profile.CreateMap(typeof(TEntity), this.GetType()).ReverseMap();
    }
}